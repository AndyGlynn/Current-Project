

Public Class ImportPictures
    Private ProdAcro As String = ""

   

    Private Sub ImportPictures_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim z As New IMPORT_PICTURES_LOGIC
            z.GetProducts()
            Me.txtLeadNum.Text = STATIC_VARIABLES.CurrentID.ToString
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "ImportPictures", "FormCode", "Event", "ImportPictures_Load", "0", ex.Message.ToString)
            y = Nothing
        End Try

        'Dim b
        'For b = 1 To z.ProdCnt
        '    Me.cboProductSel.Items.Add(z.prods(b).ToString)
        'Next
        'Me.txtLeadNum.Text = RecordLogic.CurrentID.ToString
    End Sub



    Private Sub cboProductSel_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboProductSel.SelectedValueChanged
        Try
            Dim x As String = Me.cboProductSel.Text
            Dim z As New IMPORT_PICTURES_LOGIC
            z.PullACRO(x.ToString)
            ProdAcro = z.ProductAcronym
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "ImportPictures", "FormCode", "Event", "cboProductSel_SelectedValueChanged", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Try
            Dim chkrdos As Integer
            chkrdos = 0
            If Me.txtLeadNum.Text = "" Then
                Me.ErrorProvider1.SetError(Me.txtLeadNum, "You must supply a Record ID.")
                Exit Sub
            End If
            If Me.cboProductSel.Text = "" Then
                Me.ErrorProvider1.SetError(Me.cboProductSel, "You must supply a product.")
                Exit Sub
            End If
            Dim x
            LeadNum = ""
            If Me.rdoBefore.Checked = True Then
                x = "B"
                chkrdos = 1
                ProgressVal = x
                LeadNum = Me.txtLeadNum.Text

            End If
            If Me.rdoMiddle.Checked = True Then
                x = "M"
                chkrdos = 1
                ProgressVal = x
                LeadNum = Me.txtLeadNum.Text
            End If
            If Me.rdoAfter.Checked = True Then
                x = "A"
                chkrdos = 1
                ProgressVal = x
                LeadNum = Me.txtLeadNum.Text
            End If
            Select Case chkrdos
                Case Is = 1
                    'ValidateID.Validate()
                    'Select Case ValidateID.ThereFlag
                    '    Case True
                    OpenPics.Multiselect = True

                    OpenPics.Title = "Select Picture(s) to Import"
                    OpenPics.Filter = "JPG|*.jpg|JPEG|*.jpeg|BMP|*.bmp|TIFF|*.tif|PNG|*.png|WMF|*.wmf|GIF|*.gif|All Files|*.*"
                    OpenPics.FileName = "[Select a File]"
                    OpenPics.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop '"C:\documents and settings\All users\Desktop"
                    OpenPics.ShowDialog()

                    Dim fName() As String = OpenPics.FileNames
                    Dim strConcat As String = ""
                    Dim cntFiles As Integer = -1 '' zero based index 
                    For Each z As String In fName
                        strConcat += z & vbCrLf
                        cntFiles += 1
                    Next

                    Dim i As Integer = 0
                    Dim arReconstructed As New ArrayList
                    For i = 0 To cntFiles
                        '' Structure
                        '' lead num - {b,m,e} - acro - fileNum[] => & File Extension.
                        '' 
                        '' Process:
                        '' first break file name down by delimeter "\"
                        '' second get index of last 'split'
                        '' third break off file extension from last 'part' 
                        '' 
                        Dim parts() = Split(fName(i), "\", -1, Microsoft.VisualBasic.CompareMethod.Text)
                        Dim cntOfParts As Integer = parts.Length
                        Dim FileAndExt As String = parts(cntOfParts - 1)

                        Dim f_parts() = Split(FileAndExt, ".", -1, Microsoft.VisualBasic.CompareMethod.Text)
                        Dim file_Name As String = f_parts(0)
                        Dim file_ext As String = f_parts(1)

                        '' now, for each file { this part loop } 
                        '' send the info off to Import_V2 class to:
                        '' a) fail if exists
                        '' b) if it doesnt exist => create directory
                        ''    i) after dir created => insert the file there
                        '' c) call a 'completion event' / move to the next part in block
                        '' 
                        '' then remove {if they exist} previous references in the image list on sales of image indexes
                        '' 
                        '' then call a refresh method to repop the list view control for added job pictures
                        '' 
                        Dim g As New Import_V2.ImportPicObj
                        g.LeadNum = Me.txtLeadNum.Text
                        g.FullPath = fName(i)
                        g.Acro = ProdAcro
                        g.FileExt = file_ext
                        g.FileNumSequence = i
                        g.BeginMidEnd = ProgressVal

                        Dim y As New Import_V2
                        y.ImportThePictures(g)

                        Dim strConstructed As String = (g.LeadNum & "-" & g.BeginMidEnd & "-" & ProdAcro & "-" & g.FileNumSequence & "." & g.FileExt)

                        For Each f As Windows.Forms.Form In Application.OpenForms
                            If f.Name = "Sales" Then
                                Dim idx16 As Integer = Sales.imgLst16.Images.IndexOfKey(strConstructed)
                                Dim idx32 As Integer = Sales.ImgLst32.Images.IndexOfKey(strConstructed)
                                Dim idx48 As Integer = Sales.ImgLst48.Images.IndexOfKey(strConstructed)
                                Dim idx128 As Integer = Sales.ImgLst128.Images.IndexOfKey(strConstructed)
                                Dim idx256 As Integer = Sales.ImgLst256.Images.IndexOfKey(strConstructed)
                                If idx16 >= 0 Then
                                    Sales.imgLst16.Images.RemoveAt(idx16)
                                End If
                                If idx32 >= 0 Then
                                    Sales.ImgLst32.Images.RemoveAt(idx32)
                                End If
                                If idx48 >= 0 Then
                                    Sales.ImgLst48.Images.RemoveAt(idx48)
                                End If
                                If idx128 >= 0 Then
                                    Sales.ImgLst128.Images.RemoveAt(idx128)
                                End If
                                If idx256 >= 0 Then
                                    Sales.ImgLst256.Images.RemoveAt(idx256)
                                End If

                            End If
                        Next
                        y = Nothing
                    Next

                    Me.txtLeadNum.Text = ""
                    Me.cboProductSel.Text = ""
                    ProdAcro = ""
                    Import.FileName = ""
                    Dim v As New Import_V2
                    v.CloseImportPictures()
                    Sales.btnRefreshJP_Click(Nothing, Nothing)

                    Exit Select
                Case Is < 1
                    Me.ErrorProvider1.SetError(Me.GroupBox1, "You must select job picture status.")
                    Exit Select
            End Select
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "ImportPictures", "FormCode", "Event", "btnOK_click", "0", ex.Message.ToString)
            y = Nothing
        End Try


    End Sub



    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub
End Class
