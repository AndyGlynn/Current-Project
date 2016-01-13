Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class frmLinkSendEmail

    Public RecID As String = ""
    Public Cust_Email As String = ""
    Private co_info As GetEmails.CompanyInfo


    Private Sub frmLinkSendEmail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        co_info = New GetEmails.CompanyInfo
        Dim a As New GetEmails
        co_info = a.Company_Information
        Me.txtFrom.Text = co_info.Email
        Me.txtTo.Text = Cust_Email
        Me.Text = "Send Customer Email For Lead#: " & RecID
    End Sub

    Private Sub ResetForm()
        Me.RecID = ""
        Me.txtTo.Text = ""
        Me.txtFrom.Text = ""
        Me.txtSubject.Text = ""
        Me.rtfBodyMSG.Text = ""
        Me.Text = "Send Customer Email For Lead#: "
        Me.co_info = Nothing
    End Sub


    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        If Len(Me.txtSubject.Text) <= 0 Then
            Dim response As Integer = MsgBox("Are you sure you want to send email without a subject?", MsgBoxStyle.YesNo, "Send Without Subject")
            If response = vbYes Then
                '' send mail
                Dim y As New EmailIssuedLeads
                y.Send_Blast_Mail_Confirming(Me.txtFrom.Text, Me.txtTo.Text, Me.rtfBodyMSG.Text, Me.txtSubject.Text, co_info.SMTP, co_info.SMTPPort, co_info.EmailPWD, co_info.EmaiLogin, co_info.Name)
                Me.ResetForm()
                Me.Close()
            ElseIf response = vbNo Then
                Exit Sub
            End If
        Else
            Dim y As New EmailIssuedLeads
            y.Send_Blast_Mail_Confirming(Me.txtFrom.Text, Me.txtTo.Text, Me.rtfBodyMSG.Text, Me.txtSubject.Text, co_info.SMTP, co_info.SMTPPort, co_info.EmailPWD, co_info.EmaiLogin, co_info.Name)
            Me.ResetForm()
            Me.Close()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.ResetForm()
        Me.Close()
    End Sub

#Region "Private Classes For Local Logic"
    Private Class GetEmails
 
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

        Private Const pro_cnx As String = "SERVER=192.168.1.2;Database=Iss;User Id=sa;Password=spoken1;"
        Public ReadOnly Property Company_Information As CompanyInfo
            Get
                Return coInfo
            End Get
        End Property
        
        Public Sub New()
            coInfo = New CompanyInfo
            coInfo = Get_Company_Info()
        End Sub

       

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
#End Region


End Class