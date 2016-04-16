Public Class frmTesting


    Public List_Of_Leads_To_Scrub As New List(Of convertLeadToStruct.EnterLead_Record)
    Public List_Of_Scrubbed_Leads As New List(Of bulkEmail.EmailMessageScrubbed)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim y As New USER_LOGICv2
            Dim arIPV4 As ArrayList = New ArrayList
            arIPV4 = y.GET_arIPV4s_FROM_LOCAL_MACHINE
            Dim i As Integer = 0
            For i = 0 To arIPV4.Count - 1
                Me.cboIPV4s.Items.Add(arIPV4(i))
            Next
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmTesting", "FormCode", "Event", "Button1_Click", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim y As New USER_LOGICv2
            MsgBox("User Exists : " & vbCrLf & y.Check_User_Exists(Me.txtFName.Text, Me.txtLName.Text), MsgBoxStyle.Information)

        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmTesting", "FormCode", "Event", "Button2_Click", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim z As New USER_LOGICv2
            MsgBox("Can Connect : " & vbCrLf & z.Check_Password(Me.txtPWD.Text, Me.txtFName.Text, Me.txtLName.Text), MsgBoxStyle.Information, "Check Password")

        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmTesting", "FormCode", "Event", "Button3_Click", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim z As New USER_LOGICv2
            Dim x As USER_LOGICv2.UserObj = z.Get_User_Obj(Me.txtFName.Text, Me.txtPWD.Text)
            STATIC_VARIABLES.employee.Add(x)
            z = Nothing
            x = Nothing
            MsgBox(STATIC_VARIABLES.employee(0).ID & " : " & STATIC_VARIABLES.employee(0).UserFirstName & ", " & STATIC_VARIABLES.employee(0).UserLastName & " ", MsgBoxStyle.Information, "User Info Dump")
            Main.tsLoggedInAs.Text = STATIC_VARIABLES.employee(0).UserFirstName
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmTesting", "FormCode", "Event", "Button4_Click", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Dim a As New USER_LOGICv2
            Dim lf As USER_LOGICv2.LAST_FORM_AND_SCREEN_SIZE = a.Get_LAST_FORM_AND_SIZES(Me.txtFName.Text, Me.txtLName.Text, Me.txtPWD.Text)
            MsgBox("Form Name :" & lf.FormName.ToString & vbCrLf & "X : " & lf.ScreenX & " | Y : " & lf.ScreenY & vbCrLf & "Width : " & lf.ScreenW & " | Height : " & lf.ScreenH, MsgBoxStyle.Information, "Last Form and Screen Sizes")
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmTesting", "FormCode", "Event", "Button5_Click", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

     
    Private Sub btnBlast_Click(sender As Object, e As EventArgs) Handles btnBlast.Click
        Try
            Dim y As New EmailIssuedLeads
            y.Send_BLAST_MAIL(Me.txtFrom.Text, Me.txtTo.Text, Me.rtfMSG.Text, Me.txtSubject.Text)
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmTesting", "FormCode", "Event", "btnBlast_Click", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.txtFrom.Text = "Valued Person"
        Me.txtTo.Text = "Aaron.Clay79@gmail.com"
        Me.txtSubject.Text = "Make The DEV Laugh"
        Me.rtfMSG.Text = "You know, I just wanted to take the time to say that I think what you're doing here is awesome and worthwhile. Also, don't feed the trolls." & vbCrLf & "http://www.youtube.com/watch?v=a1Y73sPHKxw"

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim x As Form = frmPrint
        x.MdiParent = Main
        x.Show()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Try
            Dim y As New createListPrintOperations
            Dim arLeadNums As New ArrayList
            arLeadNums = y.TestList()
            Dim x As Object
            Dim cnt As Integer
            For Each x In arLeadNums
                cnt += 1
            Next
            Dim i As Integer = 0
            For i = 0 To cnt - 1
                Me.CheckedListBox1.Items.Add(arLeadNums(i))
            Next
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmTesting", "FormCode", "Event", "Button8_Click", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        MsgBox("Procedure redone. PlaceHolder. 10-8-2015", MsgBoxStyle.Information, "DEBUG INFO")
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Try
            Dim txt As TextBox = Me.txtRecID
            Dim str As String = txt.Text
            Dim a As New convertLeadToStruct.EnterLead_Record
            If Len(str) <= 0 Then
                Dim y As New convertLeadToStruct
                a = y.ConvertToStructure("83137", False)
                MsgBox(a.RecID & vbCrLf & "Name: " & a.C1FirstName & " " & a.C1LastName, MsgBoxStyle.Information, "DEBUG INFO")
                Exit Sub
            ElseIf Len(str) >= 1 Then
                Dim y As New convertLeadToStruct
                a = y.ConvertToStructure(str, False)
                MsgBox(a.RecID & vbCrLf & "Name: " & a.C1FirstName & " " & a.C1LastName, MsgBoxStyle.Information, "DEBUG INFO")
            End If
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmTesting", "FormCode", "Event", "Button10_Click", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Try
            Dim b As New emlTemplateLogic
            Dim id As String = Me.txtScrubID.Text
            If Len(id) <= 0 Then
                id = b.GetMaxID(False)
            ElseIf Len(id) >= 1 Then
                id = id
            End If
            'Dim scrubbedText As String = b.TestTemplateScrub(id, False, "TEST TEMPLATE", "Administration")
            Dim nonScrubbedTemplate As emlTemplateLogic.TemplateInfo = b.GetSingleTemplate("TEST TEMPLATE3", False)
            Me.rtfUnscrubbed.Text = nonScrubbedTemplate.Body
            Me.rtfScrubbed.Text = b.TestTemplateScrub(id, False, "TEST TEMPLATE3")
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmTesting", "FormCode", "Event", "Button11_click", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub frmTesting_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Try
            Dim y As New bulkEmail(False)
            Me.List_Of_Leads_To_Scrub.Clear()
            For Each z As convertLeadToStruct.EnterLead_Record In y.ListOfLeads
                Dim yy As New ListViewItem
                yy.Text = z.RecID
                yy.SubItems.Add(z.C1FirstName & " " & z.C1LastName)
                Me.lstSimulated.Items.Add(yy)
                Me.List_Of_Leads_To_Scrub.Add(z)
            Next
            Me.lblCurrentUser.Text = y.CurrentUser.FName & " " & y.CurrentUser.LName
            Me.lblDepartment.Text = y.CurrentUser.Department
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmTesting", "FormCode", "Event", "Button12_Click", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Try
            Dim z As New emlTemplateLogic
            Dim listOfTemplates As New List(Of emlTemplateLogic.TemplateInfo)
            listOfTemplates = z.GetTemplates(False)
            Me.cboMailTemplates.Items.Clear()
            For Each a As emlTemplateLogic.TemplateInfo In listOfTemplates
                Me.cboMailTemplates.Items.Add(a.TemplateName)
            Next
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmTesting", "FormCode", "Event", "Button13_click", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub cboMailTemplates_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMailTemplates.SelectedIndexChanged
        Try
            Dim cbo As ComboBox = sender
            Dim str_temp As String = cbo.Text
            Dim strMSG As String = ""
            Dim y As New emlTemplateLogic
            Dim arScrubbedMSGS As New List(Of bulkEmail.EmailMessageScrubbed)
            If Len(str_temp) >= 1 Then
                '' apply template and such.
                Me.Cursor = Cursors.WaitCursor
                For Each b As convertLeadToStruct.EnterLead_Record In Me.List_Of_Leads_To_Scrub
                    Dim g As New bulkEmail.EmailMessageScrubbed
                    g.recID = b.RecID
                    g.Subject = y.SubjectScrub(b.RecID, False, str_temp, Me.lblDepartment.Text)
                    g.Body = y.TestTemplateScrub(b.RecID, False, str_temp)
                    arScrubbedMSGS.Add(g)
                Next

                Me.rtfPreview.Text = ""
                Me.List_Of_Scrubbed_Leads = arScrubbedMSGS

                For Each a As bulkEmail.EmailMessageScrubbed In arScrubbedMSGS

                    strMSG += vbCrLf & vbCrLf
                    strMSG += "Subject: " & a.Subject.ToString & " " & vbCrLf
                    strMSG += "Body: " & vbCrLf & vbCrLf & a.Body & vbCrLf & vbCrLf
                    strMSG += vbCrLf & vbCrLf
                    strMSG += "Correspondence Code#: LN-" & a.recID & ""
                    strMSG += vbCrLf & vbCrLf
                    Me.rtfPreview.Text += strMSG
                    strMSG = ""
                Next
                Me.Cursor = Cursors.Default

            ElseIf Len(str_temp) <= 0 Then
                '' dont do anything.
                Exit Sub
            End If
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmTesting", "FormCode", "Event", "cboMailTemplates_SelectedValueChanged", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click

        'Dim y As New EmailIssuedLeads
        'y.Send_BLAST_MAIL(Me.txtFrom.Text, Me.txtTo.Text, Me.rtfMSG.Text, Me.txtSubject.Text)
        Try
            Dim g As New EmailIssuedLeads
            Me.Cursor = Cursors.WaitCursor
            For Each a As bulkEmail.EmailMessageScrubbed In Me.List_Of_Scrubbed_Leads
                g.Send_BLAST_MAIL("aaron.clay79@gmail.com", "aaron.clay79@gmail.com", a.Body, a.Subject)
            Next
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmTesting", "FormCode", "Event", "button14_click", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Try
            Dim g As New EmailIssuedLeads
            Dim a As New bulkEmail.EmailMessageScrubbed
            a = Me.List_Of_Scrubbed_Leads.Item(0)
            g.Send_BLAST_MAIL("aaron.clay79@gmail.com", "aaron.clay79@gmail.com", a.Body, a.Subject)
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmTesting", "FormCode", "Event", "Button15_click", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Try
            Dim y As New Input_Utility_Class
            Me.Cursor = Cursors.WaitCursor
            Dim path As String = "\\server.greenworks.local\Company\ISS\Data Imports"
            Dim file1 As String = "free-zipcode-database.csv"
            Dim file2 As String = "email_domain_list.txt"

            If System.IO.File.Exists(path & "\" & file1) = True Then
                Dim response As Integer = MsgBox("Zip code file downloaded." & vbCrLf & "View It?", MsgBoxStyle.YesNo, "Zip Code File")
                If response = vbYes Then
                    System.Diagnostics.Process.Start(path & "\" & file1)
                    Me.Cursor = Cursors.Default
                Else
                    '' exit 
                    Me.Cursor = Cursors.Default

                End If
            End If
            If System.IO.File.Exists(path & "\" & file1) = False Then
                Dim r As Integer = MsgBox("The local copy of zip code files is missing. Download it?", MsgBoxStyle.YesNo, "No Zip Code Info")
                If r = vbYes Then
                    y.Download_Federal_Zip_Code_List()
                    System.Diagnostics.Process.Start(path & "\" & file1)
                    Me.Cursor = Cursors.Default

                Else
                    Me.Cursor = Cursors.Default

                End If
            End If

            If System.IO.File.Exists(path & "\" & file2) = True Then
                Dim response As Integer = MsgBox("Email Domains file downloaded." & vbCrLf & "View It?", MsgBoxStyle.YesNo, "Email Domain File")
                If response = vbYes Then
                    System.Diagnostics.Process.Start(path & "\" & file2)
                    Me.Cursor = Cursors.Default

                Else
                    '' exit
                    Me.Cursor = Cursors.Default

                End If
            End If
            If System.IO.File.Exists(path & "\" & file2) = False Then
                Dim r As Integer = MsgBox("The local copy of email domains is missing. Download it?", MsgBoxStyle.YesNo, "No Email Domain Info")
                If r = vbYes Then
                    y.dl_list()
                    System.Diagnostics.Process.Start(path & "\" & file2)
                    Me.Cursor = Cursors.Default

                Else
                    Me.Cursor = Cursors.Default

                End If
            End If

            Me.Cursor = Cursors.Default

        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmTesting", "Input_Utility_Class", "Class", "New()", "0", ex.Message.ToString)
        End Try
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Dim y As New Input_Utility_Class
        Me.txtCaptText.Text = y.CapText(Me.txtCaptText.Text)

    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Dim y As New Input_Utility_Class
        Me.txtValidText.Text = y.IsTextValid(Me.txtValidText.Text).ToString

    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Dim y As New Input_Utility_Class
        Me.txtStripSpecials.Text = y.StripOutSpecials(Me.txtStripSpecials.Text)
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Dim y As New Input_Utility_Class
        Dim lstDomains As New ArrayList
        lstDomains = y.dl_list()
        Dim x As String
        Me.Cursor = Cursors.WaitCursor
        Me.cboDomains.Items.Clear()
        For Each x In lstDomains
            Me.cboDomains.Items.Add(x)
        Next
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Dim y As New Input_Utility_Class
        Dim lstZipInfo As New List(Of Input_Utility_Class.ZipCodeInfoFED)
        lstZipInfo = y.Download_Federal_Zip_Code_List()
        Dim b As Input_Utility_Class.ZipCodeInfoFED
        Me.cboCityStateZip.Items.Clear()
        Me.Cursor = Cursors.WaitCursor
        For Each b In lstZipInfo
            Me.cboCityStateZip.Items.Add(b.City & "-" & b.State & "-" & b.ZipCode)
        Next
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Dim y As New Input_Utility_Class
        Me.txtToTwoChar.Text = y.Convert_State_ByName_To_Abbreviation(Me.txtToTwoChar.Text)

    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Dim y As New Input_Utility_Class
        Me.txtFromTwoChar.Text = y.Convert_State_Two_Char(Me.txtFromTwoChar.Text)

    End Sub
End Class