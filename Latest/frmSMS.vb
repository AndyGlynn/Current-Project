Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System

Imports System.Net.Mail


Public Class frmSMS

    Public Emp_OBJ As Rolodex_Logic_V2.EmployeeOBJ

    Private Sub frmSMS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopululateCarrierList()
        Populate_Phone_And_Carrier(Emp_OBJ)
        If Me.cboPhoneNumbers.Items.Count >= 1 Then
            Me.cboPhoneNumbers.SelectedIndex = 0
        End If

    End Sub


    Private Sub PopululateCarrierList()
        '' list of common sms free gateways per carrier
        '' 
        Me.cboCarrier.Items.Clear()
        Me.cboCarrier.Items.Add("@text.wireless.alltel.com") '' AllTel
        Me.cboCarrier.Items.Add("@txt.att.net") '' AT & T
        Me.cboCarrier.Items.Add("@myboostmobile.com") '' Boost Mobile
        Me.cboCarrier.Items.Add("@sms.mycricket.com") '' Cricket
        Me.cboCarrier.Items.Add("@messaging.sprintpcs.com") '' sprint
        Me.cboCarrier.Items.Add("@tmomail.net") '' T-Mobile
        Me.cboCarrier.Items.Add("@email.uscc.net") '' US Cellular
        Me.cboCarrier.Items.Add("@vtext.com") '' Verizon
        Me.cboCarrier.Items.Add("@vmobl.com") '' Virgin Mobile
    End Sub

    Private Sub Populate_Phone_And_Carrier(ByVal EmployeeOBJ As Rolodex_Logic_V2.EmployeeOBJ)
        Me.txtContactCarrier.Text = EmployeeOBJ.PhoneCarrier

        Me.cboPhoneNumbers.Items.Add(EmployeeOBJ.Phone1 & " - " & EmployeeOBJ.Phone1Type)
        If Len(EmployeeOBJ.Phone2) >= 1 Then
            Me.cboPhoneNumbers.Items.Add(EmployeeOBJ.Phone2 & " - " & EmployeeOBJ.Phone2Type)
        End If
        If Len(EmployeeOBJ.Phone3) >= 1 Then
            Me.cboPhoneNumbers.Items.Add(EmployeeOBJ.Phone3 & " - " & EmployeeOBJ.Phone3Type)
        End If
    End Sub

    Private Sub ResetForm()
        Me.cboCarrier.Text = ""
        Me.cboPhoneNumbers.Items.Clear()
        Me.cboCarrier.Items.Clear()
        Me.txtSubject.Text = ""
        Me.rtfSMS.Text = ""
        Me.txtLocation.Text = ""
        Me.txtLeadNumberLookup.Text = ""
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ResetForm()
        Me.Close()

    End Sub

    Private Sub rtfSMS_TextChanged(sender As Object, e As EventArgs) Handles rtfSMS.TextChanged
        Dim rtf As RichTextBox = sender
        Dim strTxt As String = rtf.Text
        Dim maxCnt As Integer = 160
        Dim cnt As Integer = Len(strTxt)
        If cnt = 160 Then
            Dim strSplit = strTxt.Substring(0, 159)
            rtf.Text = strSplit
            Exit Sub
        End If
        Dim remaining As Integer = (159 - cnt)
        Me.lblChars.Text = "Characters Remaining: " & remaining.ToString & " ( 160 Max )"
    End Sub

    Private Sub SendMSG(ByVal Subject As String, ByVal telNum As String, ByVal CarrierGateway As String, ByVal MSG As String)
    
        Try

            Dim g As New GetCompanyInfo
            Dim obj As GetCompanyInfo.CoInfo = g.CompanyInfo

            ''**WORKING CODE COPIED OVER***
            '' 
            '' getting an error now for certificate validation when SMS messages are sent.
            '' reference for error: https://msdn.microsoft.com/en-us/library/system.net.servicepointmanager.servercertificatevalidationcallback.aspx
            '' 
            '' logs show "The remote certificate is invalid according to the validation procedure."
            '' 
            '' 2-12-2016 Sent Email to support@bananahosting.com asking how to communicate with their SMTP's for SMS
            '' Waiting response: AC 
            ''
            Dim smptSERV As New SmtpClient
            Dim credentials As New Net.NetworkCredential
            credentials.Password = obj.coEmailPWD
            credentials.UserName = obj.coEmail
            smptSERV.UseDefaultCredentials = False
            smptSERV.Port = 587

            '' Notes: 2-13-2016 AC
            '' have to use a static assigned mail server 
            '' from banana hosting according to 
            '' 'Johnny' from support to send SMS/Text. 
            '' We also are not supposed to use SSL
            '' but according to him it shouldn't be a security issue.
            '' 
            smptSERV.Host = "mail6.gohsphere.com"
            'smptSERV.Host = obj.coSMTP
            'smptSERV.EnableSsl = True

            smptSERV.Credentials = credentials
            Dim numAndCarrier As String = (telNum & CarrierGateway)

            Dim eml_msg As New MailMessage(obj.coEmail, numAndCarrier)
            Dim mailAddress As New MailAddress(obj.coEmail, STATIC_VARIABLES.ProgramName)

            With eml_msg
                .From = mailAddress
                .Subject = Subject
                .Body = MSG
                .IsBodyHtml = False
            End With
            smptSERV.Send(eml_msg)

            MsgBox("Text message has been sent to: " & vbCrLf & numAndCarrier & " .", MsgBoxStyle.Information, "SMS Message Sent.")

            ''**NON WORKING CODE FOR REFERENCE**
            'Dim smtp As New SmtpClient
            'Dim eml As New MailMessage()
            'smtp.UseDefaultCredentials = False
            'smtp.Credentials = New Net.NetworkCredential(obj.coEmail, obj.coEmailPWD)
            'smtp.Port = obj.coEmailPort  '' or 465
            'smtp.EnableSsl = True
            'smtp.Host = obj.coSMTP
            'With eml
            '    .From = New MailAddress(obj.coEmail)
            '    .To.Add(telNum & CarrierGateway)
            '    .Subject = Subject
            '    .Body = MSG
            '    .IsBodyHtml = False
            'End With

            'smtp.Send(eml)
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmSMS", "FormCode", "Sub", "SendMSG(args)", "0", ex.Message.ToString)
            y = Nothing
            MsgBox("Message Failed to send. Please check the logs for further information.", MsgBoxStyle.Exclamation, "Text Not Sent")
        End Try

    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Try
            Dim str() = Split(Me.cboPhoneNumbers.Text, "-")
            Dim num As String = Trim(str(0))
            num = num.Replace(" ", "")
            num = num.Replace(")", "")
            num = num.Replace("(", "")
            num = num.Replace("-", "")
            num = num.Replace("+", "")
            If Me.cboCarrier.Text.Length <= 0 Then
                MsgBox("You have to select a Carrier for the telephone number provided.", MsgBoxStyle.Critical, "Select A Carrier")
                Exit Sub
            End If
            If Me.rtfSMS.Text.Length <= 0 Then
                MsgBox("You have chosen to send a blank message. ", MsgBoxStyle.Information, "Blank Message")
                Exit Sub
            End If
            SendMSG(Me.txtSubject.Text, num, Me.cboCarrier.Text, Me.rtfSMS.Text)
            Me.ResetForm()
            Me.Close()
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmSMS", "FormCode", "Event", "btnSend_Click", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub txtLeadNumberLookup_TextChanged(sender As Object, e As EventArgs) Handles txtLeadNumberLookup.TextChanged
        Try

            'MsgBox(Me.txtLeadNumberLookup.Text)
            Dim v As New Rolodex_Logic_V2
            Dim RetStr As String = v.Lookup_Lead_Number_For_Text_Location(Me.txtLeadNumberLookup.Text)
            If Len(RetStr) >= 2 Then
                Me.txtLocation.Text = RetStr
            ElseIf Len(RetStr) <= 0 Then
                Me.txtLocation.Text = "No Location Found/Lead Number Provided."
            End If
            v = Nothing
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmSMS", "FormCode", "Event", "txtLeadNumberLookup_TextChanged", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub
    Private Class GetCompanyInfo

        Public Structure CoInfo
            Public coEmail As String
            Public coEmailPWD As String
            Public coEmailPort As String
            Public coSMTP As String
            Public coFrom As String
        End Structure

        Private Const cnxSTR As String = "SERVER=192.168.1.2;Database=Iss;User id=sa;Password=spoken1;"
        Private coInfoObj As CoInfo
        Public ReadOnly Property CompanyInfo As CoInfo
            Get
                Return coInfoObj
            End Get
        End Property
        Public Sub New()
            coInfoObj = GetCompanyInfo()
        End Sub
        Private Function GetCompanyInfo()
            Try
                Dim retCoObj As New CoInfo
                Dim cnx As New SqlConnection(cnxSTR)
                cnx.Open()
                Dim cmdGET As New SqlCommand("SELECT CompanyName,Email,EmailLogin,EmailPassword,Outgoing,Oport FROM CompanyInfo; ", cnx)
                Dim r1 As SqlDataReader = cmdGET.ExecuteReader
                While r1.Read
                    retCoObj.coEmail = r1.Item("Email")
                    retCoObj.coEmailPWD = r1.Item("EmailPassword")
                    retCoObj.coEmailPort = r1.Item("OPort")
                    retCoObj.coSMTP = r1.Item("Outgoing")
                    retCoObj.coFrom = r1.Item("CompanyName")
                End While
                r1.Close()
                cnx.Close()
                Return retCoObj
            Catch ex As Exception
                Dim y As New ErrorLogging_V2
                y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmSMS", "FormCode-Private Class", "Function", "GetCompanyInfo()", "0", ex.Message.ToString)
                y = Nothing
            End Try
        End Function
    End Class
End Class