Imports System.IO
Imports System.Text


Public Class Import_V2
    '' for each file insert/move/copy to attached files directory
    '' 
    Public Structure ImportPicObj
        Public LeadNum As String
        Public Acro As String
        Public BeginMidEnd As String
        Public FileExt As String
        Public FullPath As String
        Public FileNumSequence As Integer
    End Structure
    Public CompleteFlag As Boolean = False
    Private Const af_dir As String = "\\192.168.1.2\Company\ISS\Attached Files\"
    Private Const jp_dir As String = "\\192.168.1.2\Company\ISS\Job Pictures\"

    Public Sub ImportThePictures(ByVal FileObj As ImportPicObj)
        Try

            If System.IO.Directory.Exists(jp_dir & FileObj.LeadNum) = False Then
                System.IO.Directory.CreateDirectory(jp_dir & FileObj.LeadNum)
                Dim reconstructed As String = (FileObj.LeadNum & "-" & FileObj.BeginMidEnd & "-" & FileObj.Acro & "-" & FileObj.FileNumSequence & "." & FileObj.FileExt)
                Try
                    System.IO.File.Copy(FileObj.FullPath, (jp_dir & FileObj.LeadNum & "\" & reconstructed))
                Catch ex As Exception
                    Dim err As String = ex.Message
                    MsgBox("Error Importing Picture(s)." & vbCrLf & err, MsgBoxStyle.Critical, "DEBUG INFO - Import Picture(s) Error")
                End Try
            ElseIf System.IO.Directory.Exists(jp_dir & FileObj.LeadNum) = True Then
                '' its already there...
                '' 
                Dim reconstructed As String = (FileObj.LeadNum & "-" & FileObj.BeginMidEnd & "-" & FileObj.Acro & "-" & FileObj.FileNumSequence & "." & FileObj.FileExt)
                Try
                    System.IO.File.Copy(FileObj.FullPath, (jp_dir & FileObj.LeadNum & "\" & reconstructed))
                Catch ex As Exception
                    Dim err As String = ex.Message
                    MsgBox("Error Importing Picture(s)." & vbCrLf & err, MsgBoxStyle.Critical, "DEBUG INFO - Import Picture(s) Error")
                End Try
            End If
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "IMPORT_PICTURES_LOGIC", "IMPORT_PICTURES_LOGIC", "Sub", "ImportThePictures(fileObj)", "0", ex.Message.ToString)
            y = Nothing
        End Try


    End Sub
    Public Sub CloseImportPictures()

        ImportPictures.Cursor = Cursors.Default
        ImportPictures.Close()
    End Sub
End Class
