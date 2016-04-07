Imports System.Windows.Forms
Imports System.Drawing.Icon
Imports System.IO
Imports System.IO.FileInfo
Imports System.IO.DirectoryInfo
Imports IWshRuntimeLibrary
Imports System.Drawing
Imports System.Drawing.Image
Imports System.Drawing.Bitmap
Imports System.Drawing.Drawing2D
Imports Microsoft.Win32
Imports System.Runtime.InteropServices
Imports System.String
Imports System.Text


Public Class AF_And_JP_Logic

#Region "Notes"
    ''
    '' 11-16-2015
    '' AC
    '' split off for static controls across form 
    '' and to hopefully operate on a background thread
    '' to improve ui performance
    '' form code going to deal with ccp, change dir, and the like now
    '' Nested getting images inside of dir/file iteration
    '' NOT returning image lists now, just lists of (files/dirs) 
    '' file and dir object now contain their own images within the structs
    ''
#End Region
    
#Region "structures"
    Public Structure FileObject
        Public FileName As String
        Public FileExt As String
        Public FullPath As String
        Public IconKey As String

        Public smIcon As Icon ''16
        Public smThumb As Image

        Public mdIcon As Icon '' 32
        Public mdThumb As Image

        Public lgIcon As Icon '' 64
        Public lgThumb As Image

        Public jbIcon As Icon '' 256x256
        Public jbThumb As Image '' 

        Public Tile As Image ' 128

        Public FileSize As String
        Public DateCreated As String
        Public DateModified As String
    End Structure



    Public Structure DirObject
        Public FileName As String
        Public FullPath As String
        Public IconKey As String
        Public smIcon As Icon ''16
        Public lgIcon As Icon '' 32
        Public mdIcon As Icon '' 48-64
        Public jbIcon As Icon '' 256x256
        Public FileSize As Integer
        Public DateCreated As String
        Public DateModified As String
        Public HasSubDirsAndFiles As Boolean
    End Structure

    Public Structure SHFILEINFO
        Public hIcon As IntPtr ' : icon
        Public iIcon As Integer ' : icon index
        Public dwAttributes As Integer ' 
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=260)> _
        Public szDisplayName As String '' size must be marshaled because of com interop
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=80)> _
        Public szTypeName As String '' size must be marshaled because of com interop
    End Structure

    Public Structure IconDir
        Dim lpszFile As String
        Dim IconIndex As Integer
        Dim LargeIcons()
        Dim SmallIcons()
        Dim NumIcons As Integer
    End Structure

    Public Structure IconDir_DEF
        Dim lpszFile As String
        Dim IconIndex As Integer
        Dim LargeIcons()
        Dim SmallIcons()
        Dim NumIcons As Integer
    End Structure
#End Region
#Region "Constants"
    Public Const SHIL_JUMBO = &H4 '' 256x256 system icons
    Public Const SHIL_LARGE = &H0 '' 48x48 
    Public Const SHIL_SMALL = &H1 '' 16x16 
    Public Const SHIL_EXTRALARGE = &H2 '' Typically 48x48 but can be customized. 
    Private Const SHGFI_ICON = &H100 '' default icon size | required for shgetfileinfo flag

    Private Const af_dir As String = "\\192.168.1.2\Company\ISS\Attached Files\"
    Private Const jp_dir As String = "\\192.168.1.2\Company\ISS\Job Pictures\"

#End Region
#Region "Mimic Sys Image List For Icon Extraction"
    Public Class MimicSysImgList
        <StructLayout(LayoutKind.Sequential)>
        Public Structure Rect
            Public left, top, right, bottom As Integer
        End Structure

        <StructLayout(LayoutKind.Sequential)>
        Private Structure POINT
            Dim x As Integer
            Dim y As Integer
        End Structure

        <StructLayout(LayoutKind.Sequential)>
        Public Structure IMAGELISTDRAWPARAMS
            Public cbSize As Integer
            Public himl As IntPtr
            Public x As Integer
            Public y As Integer
            Public cx As Integer
            Public cy As Integer
            Public xBitmap As Integer
            Public yBitmap As Integer
            Public rgbBk As Integer
            Public rgbFg As Integer
            Public fStyle As Integer
            Public dwRop As Integer
            Public fState As Integer
            Public frame As Integer
            Public crEffect As Integer
        End Structure

        <StructLayout(LayoutKind.Sequential)>
        Public Structure IMAGEINFO
            Public hbmImage As IntPtr
            Public hbmMask As IntPtr
            Public Unused1 As Integer
            Public Unused2 As Integer
            Public rcImage As Rect
        End Structure

        <ComImportAttribute()>
        <GuidAttribute("46EB5926-582E-4017-9FDF-E8998DAA0950")>
        <InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)>
        Interface IImageList

            <PreserveSig()>
            Function Add(ByVal hbmImage As IntPtr, ByVal hbmMask As IntPtr, ByRef pi As Integer) As Integer

            <PreserveSig()>
            Function ReplaceIcon(ByVal i As Integer, ByVal hicon As IntPtr, ByRef pi As Integer) As Integer

            <PreserveSig()>
            Function SetOverlayImage(ByVal iImage As Integer, ByVal iOverlay As Integer) As Integer

            <PreserveSig()>
            Function Replace(ByVal i As Integer, ByVal hbmImage As IntPtr, ByVal hbmMask As IntPtr) As Integer

            <PreserveSig()>
            Function AddMasked(hbmImage As IntPtr, crMask As Integer, ByRef pi As Integer) As Integer

            <PreserveSig()>
            Function Draw(ByRef pimldp As IMAGELISTDRAWPARAMS) As Integer

            <PreserveSig()>
            Function Remove(ByVal i As Integer) As Integer

            <PreserveSig()>
            Function GetIcon(ByVal i As Integer, ByVal flags As Integer, ByRef picon As IntPtr) As Integer

            <PreserveSig()>
            Function GetImageInfo(ByVal i As Integer, ByRef pImageInfo As IMAGEINFO) As Integer

        End Interface

    End Class
#End Region
#Region "PINVOKE and MISC Vars"
    Public cnt As Integer = 399 '' as returned by a  total count in imageres.dll off of a windows 8 machine
    Public LargeIcons() As IntPtr = New IntPtr(cnt - 1) {}
    Public SmallIcons() As IntPtr = New IntPtr(cnt - 1) {}

    Public Const ILD_TRANSPARENT As Integer = 1 '' for draw params / would leave on transparent other flags cause overlays to be used
    Public Declare Function SHGetImageList Lib "shell32.dll" (ByVal iImagelist As Integer, ByRef riid As Guid, ByRef ppv As MimicSysImgList.IImageList) As IntPtr
    Public Declare Function SHGetFileInfo Lib "shell32.dll" (ByVal pszPath As String, ByVal dwFileAttributes As Integer, ByRef psfi As SHFILEINFO, ByVal cbFileInfo As Integer, ByVal uFlags As Integer) As IntPtr
    Public Declare Auto Function ExtractIconEx Lib "shell32.dll" Alias "ExtractIconExW" (ByVal libName As String, ByVal iconIndex As Integer, ByVal largeIcon() As IntPtr, ByVal smallIcon() As IntPtr, ByVal nIcons As Integer) As Integer

    Private _ReconFile As FileObject

#End Region
#Region "DLL Import for PINVOKE"
    <DllImport("comctl32.dll", SetLastError:=True)> _
    Public Shared Function ImageList_GetIcon(himl As IntPtr, i As Integer, flags As Integer) As IntPtr
    End Function
#End Region
#Region "Properties"


    Private ar_Files As List(Of FileObject)
    Private ar_directories As List(Of DirObject)

    Public ReadOnly Property Files As List(Of FileObject)
        Get
            Return ar_Files
        End Get
    End Property

    Public ReadOnly Property Directories As List(Of DirObject)
        Get
            Return ar_directories
        End Get
    End Property
#End Region
#Region "Constructor"
    Public Sub New(ByVal LeadNum As String, ByVal Which_Control As String)
        '' TRUE = AF
        '' FALSE = JP
        Try
            Dim target_path As String = ""
            If Which_Control = "AF" Then
                target_path = (af_dir & LeadNum & "\")
            ElseIf Which_Control = "JP" Then
                target_path = (jp_dir & LeadNum & "\")
            End If

            ar_Files = New List(Of FileObject)
            ar_Files = Get_Files_In_Directory(target_path)
            ar_directories = New List(Of DirObject)
            ar_directories = Get_Folders_In_Directory(target_path)
        Catch ex As Exception
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "AF_And_JP_Logic", "Class", "Constructor", "New {1}", "0", ex.Message.ToString)
            y = Nothing
        End Try
    End Sub
    Public Sub New(ByVal Directory As String)
        Try
            ar_Files = New List(Of FileObject)
            ar_Files = Get_Files_In_Directory(Directory)
            ar_directories = New List(Of DirObject)
            ar_directories = Get_Folders_In_Directory(Directory)
        Catch ex As Exception
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "AF_And_JP_Logic Class", "AF_And_JP_Logic", "Constructor", "New {2} Overloaded", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub
#End Region
#Region "Main Loops To Get Files and Folder Info"


    Private Function Get_Files_In_Directory(ByVal Directory As String)
        Try
            If Len(Directory) <= 0 Then
                Directory = (af_dir & STATIC_VARIABLES.CurrentID & "\")
            End If

            Dim dir_info As New DirectoryInfo(Directory)
            If dir_info.Exists = True Then
                Dim y As FileInfo
                For Each y In dir_info.GetFiles("*.*")
                    Dim z As New FileObject
                    z.DateCreated = y.CreationTime.ToString
                    z.DateModified = y.LastWriteTime.ToString
                    z.FileExt = y.Extension
                    z.FileName = y.Name
                    z.FullPath = y.FullName
                    z.FileSize = y.Length
                    z.IconKey = y.Name
                    z.jbIcon = GetJumbos(y.FullName)
                    z.lgIcon = GetLarges(y.FullName)
                    z.smIcon = GetSmalls(y.FullName)
                    z.mdIcon = GetMediums(y.FullName)
                    Dim pullThum As Boolean = False
                    Select Case y.Extension
                        Case ".jpg"
                            pullThum = True
                            Exit Select
                        Case ".JPG"
                            pullThum = True
                            Exit Select
                        Case ".JPEG"
                            pullThum = True
                            Exit Select
                        Case ".jpeg"
                            pullThum = True
                            Exit Select
                        Case ".png"
                            pullThum = True
                            Exit Select
                        Case ".PNG"
                            pullThum = True
                            Exit Select
                        Case ".bmp"
                            pullThum = True
                            Exit Select
                        Case ".BMP"
                            pullThum = True
                            Exit Select
                        Case ".tiff"
                            pullThum = True
                            Exit Select
                        Case ".TIFF"
                            pullThum = True
                            Exit Select
                        Case ".gif"
                            pullThum = True
                            Exit Select
                        Case ".GIF"
                            pullThum = True
                            Exit Select
                        Case Else
                            pullThum = False
                            Exit Select
                    End Select
                    If pullThum = True Then
                        z = Extract_Thumbs(y.FullName, z)
                    ElseIf pullThum = False Then
                        z = z
                    End If
                    If z.FileName <> "Thumbs" Then
                        If z.FileExt <> ".db" Then
                            ar_Files.Add(z)
                        End If
                    End If
                Next
                Return ar_Files
            ElseIf dir_info.Exists = False Then
                System.IO.Directory.CreateDirectory(TargetPath)
            End If
        Catch ex As Exception
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "AF_And_JP_Logic", "AF_And_JP_Logic", "Function", "Get_Files_In_Directory()", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Function

    Private Function Get_Folders_In_Directory(ByVal Directory As String)
        Try
            If Len(Directory) <= 0 Then
                Directory = (af_dir & STATIC_VARIABLES.CurrentID & "\")
            End If
            Dim dir_info As New DirectoryInfo(Directory)
            If dir_info.Exists = True Then
                Dim y As DirectoryInfo
                For Each y In dir_info.GetDirectories
                    Dim z As New DirObject
                    z.DateCreated = y.CreationTime.ToString
                    z.DateModified = y.LastWriteTime.ToString
                    z.FileName = y.Name
                    z.FullPath = y.FullName
                    z.HasSubDirsAndFiles = True
                    z.IconKey = y.Name
                    z.jbIcon = GetJumbos(y.FullName)
                    z.lgIcon = GetLarges(y.FullName)
                    z.smIcon = GetSmalls(y.FullName)
                    z.mdIcon = GetMediums(y.FullName)
                    ar_directories.Add(z)
                Next
                Return ar_directories
            ElseIf dir_info.Exists = False Then
                System.IO.Directory.CreateDirectory(TargetPath)
            End If
        Catch ex As Exception
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "AF_And_JP_Logic Class", "AF_And_JP_Logic", "Function", "Get_Folders_In_Directory(directory)", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Function

#End Region

#Region "Methods To Get Different Image Sizes"
    Private Function GetJumbos(ByVal path As String)
        Try
            Dim iml As AF_And_JP_Logic.MimicSysImgList.IImageList
            Dim riid As Guid = New Guid("46EB5926-582E-4017-9FDF-E8998DAA0950")
            Dim lresult As IntPtr
            lresult = SHGetImageList(SHIL_JUMBO, riid, iml)
            Dim hImg As IntPtr
            Dim shinfo As SHFILEINFO = New SHFILEINFO
            Dim icoIDX = shinfo.iIcon
            Dim hIcon = IntPtr.Zero
            hImg = SHGetFileInfo(path, 0, shinfo, Marshal.SizeOf(shinfo), SHGFI_ICON)
            Dim hres = iml.GetIcon(shinfo.iIcon, 1, hIcon)
            Dim ico As Icon = System.Drawing.Icon.FromHandle(hIcon)
            Dim ico2 As Icon = ico.Clone()
            ico.Dispose()
            Return ico2
        Catch ex As Exception
            '' the error reporter here spams the logs with unessecary
            '' errors
            '' 2-11-2016
            'Dim y As New ErrorLogging_V2
            'y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "AF_And_JP_Logic Class", "AF_And_JP_Logic", "Function", "GetJumbos(path)", "0", ex.Message.ToString)
            'y = Nothing
            Main.Cursor = Cursors.Default
        End Try

    End Function

    Private Function GetLarges(ByVal Path As String)
        Try
            Dim iml As AF_And_JP_Logic.MimicSysImgList.IImageList
            Dim riid As Guid = New Guid("46EB5926-582E-4017-9FDF-E8998DAA0950")
            Dim lresult As IntPtr
            lresult = SHGetImageList(SHIL_EXTRALARGE, riid, iml)
            Dim hImg As IntPtr
            Dim shinfo As SHFILEINFO = New SHFILEINFO
            Dim icoIDX = shinfo.iIcon
            Dim hIcon = IntPtr.Zero
            hImg = SHGetFileInfo(Path, 0, shinfo, Marshal.SizeOf(shinfo), SHGFI_ICON)
            Dim hres = iml.GetIcon(shinfo.iIcon, 1, hIcon)
            Dim ico As Icon = System.Drawing.Icon.FromHandle(hIcon)
            Dim ico2 As Icon = ico.Clone()
            ico.Dispose()
            Return ico2

        Catch ex As Exception
            '' the error reporter here spams the logs with unessecary
            '' errors
            '' 2-11-2016
            'Dim y As New ErrorLogging_V2
            'y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "AF_And_JP_Logic Class", "AF_And_JP_Logic", "Function", "GetLarges(path)", "0", ex.Message.ToString)
            'y = Nothing
            Main.Cursor = Cursors.Default
        End Try

    End Function

    Private Function GetSmalls(ByVal path As String)
        Try
            Dim iml As AF_And_JP_Logic.MimicSysImgList.IImageList
            Dim riid As Guid = New Guid("46EB5926-582E-4017-9FDF-E8998DAA0950")
            Dim lresult As IntPtr
            lresult = SHGetImageList(SHIL_SMALL, riid, iml)
            Dim hImg As IntPtr
            Dim shinfo As SHFILEINFO = New SHFILEINFO
            Dim icoIDX = shinfo.iIcon
            Dim hIcon = IntPtr.Zero
            hImg = SHGetFileInfo(path, 0, shinfo, Marshal.SizeOf(shinfo), SHGFI_ICON)
            Dim hres = iml.GetIcon(shinfo.iIcon, 1, hIcon)
            Dim ico As Icon = System.Drawing.Icon.FromHandle(hIcon)
            Dim ico2 As Icon = ico.Clone()
            ico.Dispose()
            Return ico2

        Catch ex As Exception
            '' the error reporter here spams the logs with unessecary
            '' errors
            '' 2-11-2016
            'Dim y As New ErrorLogging_V2
            'y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "AF_And_JP_Logic Class", "AF_And_JP_Logic", "Function", "GetSmalls(Path)", "0", ex.Message.ToString)
            'y = Nothing
            Main.Cursor = Cursors.Default
        End Try

    End Function

    Private Function GetMediums(ByVal path As String)
        Try
            Dim iml As AF_And_JP_Logic.MimicSysImgList.IImageList
            Dim riid As Guid = New Guid("46EB5926-582E-4017-9FDF-E8998DAA0950")
            Dim lresult As IntPtr
            lresult = SHGetImageList(SHIL_LARGE, riid, iml)
            Dim hImg As IntPtr
            Dim shinfo As SHFILEINFO = New SHFILEINFO
            Dim icoIDX = shinfo.iIcon
            Dim hIcon = IntPtr.Zero
            hImg = SHGetFileInfo(path, 0, shinfo, Marshal.SizeOf(shinfo), SHGFI_ICON)
            Dim hres = iml.GetIcon(shinfo.iIcon, 1, hIcon)
            Dim ico As Icon = System.Drawing.Icon.FromHandle(hIcon)
            Dim ico2 As Icon = ico.Clone()
            ico.Dispose()
            Return ico2

        Catch ex As Exception
            '' the error reporter here spams the logs with unessecary
            '' errors
            '' 2-11-2016
            'Dim y As New ErrorLogging_V2
            'y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "AF_And_JP_Logic Class", "AF_And_JP_Logic", "Function", "GetMediums(path)", "0", ex.Message.ToString)
            'y = Nothing
            Main.Cursor = Cursors.Default
        End Try

    End Function

    Private Function Extract_Thumbs(ByVal FillFullName As String, ByVal File As FileObject)
        Try
            Dim y As FileObject = File


            '' one thumb for each size.
            '' 16
            '' 32
            '' 48
            '' 128
            '' 256



            Try
                Dim thumA As Image = Bitmap.FromFile(FillFullName, True)
                Dim tThumbA16 As Image = thumA.GetThumbnailImage(16, 16, AddressOf GetThumbCallBackAbort, IntPtr.Zero)
                Dim imgC As Image = tThumbA16.Clone
                tThumbA16.Dispose()
                thumA.Dispose()
                y.smThumb = imgC

            Catch ex As Exception
                '' point to default error icon here.
                '' 
            End Try

            Try
                Dim thumB As Image = Bitmap.FromFile(FillFullName, True)
                Dim tThumbB32 As Image = thumB.GetThumbnailImage(32, 32, AddressOf GetThumbCallBackAbort, IntPtr.Zero)
                Dim imgD As Image = tThumbB32.Clone
                thumB.Dispose()
                tThumbB32.Dispose()
                y.mdThumb = imgD

            Catch ex As Exception
                '' point to default error icon here.
                '' 
            End Try

            Try
                Dim thumC As Image = Bitmap.FromFile(FillFullName, True)
                Dim tthumbC48 As Image = thumC.GetThumbnailImage(48, 48, AddressOf GetThumbCallBackAbort, IntPtr.Zero)
                Dim imgE As Image = tthumbC48.Clone
                thumC.Dispose()
                tthumbC48.Dispose()
                y.lgThumb = imgE

            Catch ex As Exception
                '' point to default error icon here.
                '' 
            End Try

            Try
                Dim thumC As Image = Bitmap.FromFile(FillFullName, True)
                Dim tthumbC256 As Image = thumC.GetThumbnailImage(256, 256, AddressOf GetThumbCallBackAbort, IntPtr.Zero)
                Dim imgE As Image = tthumbC256.Clone
                thumC.Dispose()
                tthumbC256.Dispose()
                y.jbThumb = imgE

            Catch ex As Exception
                '' point to default error icon here.
                '' 
            End Try

            Try
                Dim thumC As Image = Bitmap.FromFile(FillFullName, True)
                Dim tthumbC128 As Image = thumC.GetThumbnailImage(128, 128, AddressOf GetThumbCallBackAbort, IntPtr.Zero)
                Dim imgE As Image = tthumbC128.Clone
                thumC.Dispose()
                tthumbC128.Dispose()
                y.Tile = imgE

            Catch ex As Exception
                '' point to default error icon here.
                '' 
            End Try

            Return y
        Catch ex As Exception
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "AF_And_JP_Logic Class", "AF_And_JP_Logic", "Function", "Extract_Thumbs(FillFullName,File)", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Function

    Public Function GetThumbCallBackAbort() As Boolean
        Return False
    End Function

#End Region



End Class
