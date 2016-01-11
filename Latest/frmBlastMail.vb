Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient



Public Class frmBlastMail
    Public RecID As String = ""
    Private arListReps As List(Of GetReps.Rep)
    Private Company_Info As GetEmails.CompanyInfo
    Private User_Info As GetEmails.UserInfo
    Private Lead_as_a_structure As convertLeadToStruct.EnterLead_Record

    Private Sub frmBlastMail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Len(RecID) <= 0 Then
            MsgBox("You must select a lead to use this function.", MsgBoxStyle.Exclamation, "No Lead Selected.")
            Me.ResetFormLocal()
            Exit Sub
        End If
        If RecID = " " Then
            MsgBox("You must select a lead to use this function.", MsgBoxStyle.Exclamation, "No Lead Selected.")
            Me.ResetFormLocal()
            Exit Sub
        End If
        Me.Text = "Send Email To Rep For Lead#: " & RecID.ToString
        Dim b As New GetReps
        arListReps = b.List_Of_Reps
        For Each x As GetReps.Rep In arListReps
            Me.cboReps.Items.Add(x.FName & " " & x.LName)
        Next

        Dim c As New GetLeadInfo(Me.RecID)
        Lead_as_a_structure = c.Lead_As_Structure

        Dim name() = Split(STATIC_VARIABLES.CurrentUser, " ", -1, Microsoft.VisualBasic.CompareMethod.Text)
        Dim fname As String = name(0)
        Dim lname As String = name(1)

        Dim d As New GetEmails(fname, lname)
        User_Info = d.User_Information
        Me.cboFromEmail.Items.Add(User_Info.CoEmail)
        Company_Info = d.Company_Information
        Me.cboFromEmail.Items.Add(Company_Info.Email)

        Dim strAutoPopInfo As String = ""
        strAutoPopInfo += "-------------" & Me.RecID & "-------------" & vbCrLf & vbCrLf
        strAutoPopInfo += "Customer Name(s): " & Lead_as_a_structure.C1FirstName & " " & Lead_as_a_structure.C1LastName & vbCrLf
        strAutoPopInfo += "                    " & Lead_as_a_structure.C2FirstName & " " & Lead_as_a_structure.C2LastName & vbCrLf & vbCrLf
        strAutoPopInfo += "Phone(s): " & Lead_as_a_structure.HousePhone & vbCrLf & Lead_as_a_structure.AltPhone2 & vbCrLf & Lead_as_a_structure.AltPhone2 & vbCrLf & vbCrLf
        strAutoPopInfo += "Product(s):" & Lead_as_a_structure.Product1 & vbCrLf & Lead_as_a_structure.Product2 & vbCrLf & Lead_as_a_structure.Product3 & vbCrLf & vbCrLf
        strAutoPopInfo += "Customer Email: " & Lead_as_a_structure.EmailAddress & vbCrLf & vbCrLf
        Dim dateTimes() = Split(Lead_as_a_structure.ApptDate, " ", -1, Microsoft.VisualBasic.CompareMethod.Text)
        Dim dt As String = dateTimes(0)
        Dim tms() As String = Split(Lead_as_a_structure.ApptTime, " ", -1, Microsoft.VisualBasic.CompareMethod.Text)
        Dim tm As String = tms(1)
        strAutoPopInfo += "Appt. Time:" & tm & vbCrLf
        strAutoPopInfo += "Appt. Date:" & dt & vbCrLf & vbCrLf
        strAutoPopInfo += "Home Info:  Age-" & Lead_as_a_structure.HomeAge & vbCrLf & "Years Owned-" & Lead_as_a_structure.YearsOwned & vbCrLf
        strAutoPopInfo += vbCrLf & "Street Address: " & Lead_as_a_structure.StAddress & " " & Lead_as_a_structure.City & "," & Lead_as_a_structure.State & " " & Lead_as_a_structure.Zip & vbCrLf & vbCrLf
        strAutoPopInfo += "Special Instructions: " & Lead_as_a_structure.SpecialInstructions & vbCrLf & vbCrLf
        strAutoPopInfo += "-------------------------------------" & vbCrLf

        Me.rtfBody.Text = strAutoPopInfo

    End Sub

    Private Sub ResetFormLocal()

        Me.cboReps.Text = ""
        Me.cboFromEmail.Text = ""
        Me.txtSubject.Text = ""
        Me.txtToEmail.Text = ""
        Me.rtfBody.Text = ""

    End Sub

    Private Sub ResetClose()

        Me.cboReps.Items.Clear()
        Me.cboFromEmail.Items.Clear()
        Me.RecID = ""
        Me.Lead_as_a_structure = Nothing
        Me.User_Info = Nothing
        Me.Company_Info = Nothing
        Me.txtSubject.Text = ""
        Me.rtfBody.Text = ""
        Me.arListReps = Nothing
        Me.Text = "Send Email To Rep For Lead#: "

    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Me.ResetFormLocal()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.ResetClose()
        Me.Close()
    End Sub

    Private Sub cboReps_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboReps.SelectedValueChanged
        Dim y As New GetReps.Rep
        For Each x As GetReps.Rep In arListReps
            Dim name() = Split(Me.cboReps.Text, " ", -1, Microsoft.VisualBasic.CompareMethod.Text)
            If name(0) = x.FName Then
                Me.txtToEmail.Text = x.Email
            End If
        Next
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click

        If Len(Me.cboReps.Text) <= 0 Then
            If Me.cboReps.Text <> " " Then
                MsgBox("You must select a person to send this email to.", MsgBoxStyle.Exclamation, "No Person Selected.")
                Exit Sub
            End If
        End If

        If Len(Me.cboFromEmail.Text) <= 0 Then
            If Me.cboFromEmail.Text <> " " Then
                MsgBox("You must select an email address to send this message from.", MsgBoxStyle.Exclamation, "No 'From' Email Address Selected.")
                Exit Sub
            End If
        End If

        If Len(Me.txtToEmail.Text) <= 0 Then
            If Me.txtToEmail.Text <> " " Then
                MsgBox("You must have a valid destination email address for this message to be sent.", MsgBoxStyle.Exclamation, "No Recipient Selected.")
                Exit Sub
            End If
        End If

        Dim yesNo As Integer = 0

        If Len(Me.txtSubject.Text) <= 0 Then
            If Me.txtSubject.Text <> " " Then
                yesNo = MsgBox("Are you sure you want to send this email without a subject?", MsgBoxStyle.YesNo, "No Subject")
                If yesNo = vbYes Then
                    '' continue
                ElseIf yesNo = vbNo Then
                    '' exit sub 
                    Exit Sub
                End If
            End If
        End If

        If Me.cboFromEmail.Text = Company_Info.Email Then
            Dim abc As New EmailIssuedLeads
            abc.Send_Blast_Mail_Confirming(Me.cboFromEmail.Text, Me.txtToEmail.Text, Me.rtfBody.Text, Me.txtSubject.Text, Company_Info.SMTP, Company_Info.SMTPPort, Company_Info.EmailPWD, Company_Info.Email, STATIC_VARIABLES.CurrentUser)
            abc = Nothing

        ElseIf Me.cboFromEmail.Text <> Company_Info.Email Then
            Dim z As New EmailIssuedLeads
            z.Send_Blast_Mail_Confirming(Me.cboFromEmail.Text, Me.txtToEmail.Text, Me.rtfBody.Text, Me.txtSubject.Text, User_Info.SMTP, User_Info.SMTPPort, User_Info.EmlPWD, User_Info.CoEmail, STATIC_VARIABLES.CurrentUser)
            z = Nothing
        End If


        Me.ResetFormLocal()
        Me.Close()

    End Sub






#Region "Private Classes For local logic"

    Private Class GetReps

        '' struct rep
        Public Structure Rep
            Public ID As String
            Public Email As String
            Public ExcludePrintInfo As Boolean
            Public FName As String
            Public LName As String
            Public SalesManager As String
        End Structure
        '' struct exclusion
        Public Structure Exclusion
            Public Generated As Boolean
            Public Marketer As Boolean
            Public PLS As Boolean
            Public SLS As Boolean
            Public LastMResult As Boolean
            Public Phone As Boolean
        End Structure

        Private arReps As List(Of Rep)
        Private Const pro_cnx As String = "SERVER=192.168.1.2;Database=Iss;User Id=sa;Password=spoken1;"

        Public ReadOnly Property List_Of_Reps As List(Of Rep)
            Get
                Return arReps
            End Get
        End Property
        Public Sub New()
            arReps = New List(Of Rep)
            arReps = Get_Reps()
        End Sub
        Private Function Get_Reps()
            Dim reps As New List(Of Rep)
            Dim cnx As New SqlConnection(pro_cnx)
            cnx.Open()
            Dim cmdGET As New SqlCommand("SELECT ID,Email,CanRecieveEmail,ExcludePrintInfo,FName,LName,SalesManager FROM salesreppull WHERE CanRecieveEmail = 1;", cnx)
            Dim r1 As SqlDataReader = cmdGET.ExecuteReader
            While r1.Read
                Dim a As New Rep
                a.ID = r1.Item("ID")
                a.FName = r1.Item("FName")
                a.LName = r1.Item("LName")
                a.Email = r1.Item("Email")
                a.ExcludePrintInfo = r1.Item("ExcludePrintInfo")
                a.SalesManager = r1.Item("SalesManager")
                reps.Add(a)
            End While
            r1.Close()
            cnx.Close()
            cnx = Nothing
            Return reps
        End Function

    End Class

    Private Class GetEmails

        '' struct user info / user email info
        Public Structure UserInfo
            Public FName As String
            Public LName As String
            Public CoEmail As String
            Public EmlPWD As String
            Public POP3 As String
            Public SMTP As String
            Public POP3Port As String
            Public SMTPPort As String
            Public LogonUsing As String
        End Structure
        '' struct company info / company email info
        Public Structure CompanyInfo
            Public Name As String
            Public Email As String
            Public EmaiLogin As String
            Public POP3 As String
            Public SMTP As String
            Public POP3Port As String
            Public SMTPPort As String
            Public LogonUsing As String
            Public EmailPWD As String
        End Structure

        Private coInfo As CompanyInfo
        Private usrInfo As UserInfo
        Private Const pro_cnx As String = "SERVER=192.168.1.2;Database=Iss;User Id=sa;Password=spoken1;"
        Public ReadOnly Property Company_Information As CompanyInfo
            Get
                Return coInfo
            End Get
        End Property
        Public ReadOnly Property User_Information As UserInfo
            Get
                Return usrInfo
            End Get
        End Property
        Public Sub New(ByVal FName As String, ByVal LName As String)
            coInfo = New CompanyInfo
            coInfo = Get_Company_Info()
            usrInfo = New UserInfo
            usrInfo = Get_User_Info(FName, LName)
        End Sub

        Private Function Get_User_Info(ByVal FName As String, ByVal LName As String)
            Dim a As New UserInfo
            Dim cnx As New SqlConnection(pro_cnx)
            cnx.Open()
            Dim strCMD As String = ""
            strCMD += "SELECT UserFirstName,UserLastName,Email,EmailLogon,EmailPassword,Incoming,Outgoing,IncomingPort,OutgoingPort,LogonUsing FROM UserPermissionTable WHERE UserFirstName = '" & FName & "' and UserLastName = '" & LName & "';"
            Dim cmdGET As New SqlCommand(strCMD, cnx)
            Dim r1 As SqlDataReader = cmdGET.ExecuteReader
            While r1.Read
                a.FName = FName
                a.LName = LName
                a.CoEmail = r1.Item("Email")
                a.EmlPWD = r1.Item("EmailPassword")
                a.POP3 = r1.Item("Incoming")
                a.SMTP = r1.Item("Outgoing")
                a.POP3Port = r1.Item("IncomingPort")
                a.SMTPPort = r1.Item("OutgoingPort")
                a.LogonUsing = r1.Item("LogonUsing")
            End While
            r1.Close()
            cnx.Close()
            cnx = Nothing
            Return a
        End Function

        Private Function Get_Company_Info()
            Dim a As New CompanyInfo
            Dim cnx As New SqlConnection(pro_cnx)
            cnx.Open()
            Dim cmdGET As New SqlCommand("SELECT CompanyName,Email,EmailLogin,Incoming,Outgoing,Iport,OPort,LogonUsing,EmailPassword FROM CompanyInfo;", cnx)
            Dim r1 As SqlDataReader = cmdGET.ExecuteReader
            While r1.Read
                a.Name = r1.Item("CompanyName")
                a.Email = r1.Item("Email")
                a.EmaiLogin = r1.Item("EmailLogin")
                a.POP3 = r1.Item("Incoming")
                a.SMTP = r1.Item("Outgoing")
                a.POP3Port = r1.Item("Iport")
                a.SMTPPort = r1.Item("Oport")
                a.LogonUsing = r1.Item("LogonUsing")
                a.EmailPWD = r1.Item("EmailPassword")
            End While
            r1.Close()
            cnx.Close()
            cnx = Nothing
            Return a
        End Function

    End Class

    Private Class GetLeadInfo

        '' struct lead
        '' 
        '' class already in place "convertLeadToStruct(args)" returns Structure of Lead 
        '' 
        Private structOfLead As convertLeadToStruct.EnterLead_Record
        Public ReadOnly Property Lead_As_Structure As convertLeadToStruct.EnterLead_Record
            Get
                Return structOfLead
            End Get
        End Property
        Public Sub New(ByVal RecID As String)
            structOfLead = New convertLeadToStruct.EnterLead_Record
            Dim b As New convertLeadToStruct
            structOfLead = b.ConvertToStructure(RecID, False)
        End Sub

    End Class

#End Region


End Class