﻿Public Class frmEmailPreview

    Public LeadToShow As convertLeadToStruct.EnterLead_Record
    Public TemplateName As String = ""
    Public Department As String = ""



    Private Sub frmEmailPreview_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ResetForm()
        Me.cboTemplates.Items.Clear()

    End Sub

    Private Sub frmEmailPreview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.lblLeadNum.Text = LeadToShow.RecID
            Dim name() = Split(STATIC_VARIABLES.CurrentUser, " ", -1, Microsoft.VisualBasic.CompareMethod.Text)
            Dim z As New emlTemplateLogic
            Dim depart_ As String = z.GetEmployeeDepartment(name(0), name(1), False)
            Me.Department = depart_
            Dim template_scrubbed As String = z.TestTemplateScrub(LeadToShow.RecID, False, TemplateName)
            Dim templt_info As emlTemplateLogic.TemplateInfo = z.GetSingleTemplate(TemplateName, False)
            Dim g As List(Of emlTemplateLogic.TemplateInfo)
            g = z.GetTemplatesByDepartment(False, depart_)
            Dim a As emlTemplateLogic.TemplateInfo
            For Each a In g
                Me.cboTemplates.Items.Add(a.TemplateName)
            Next
            Me.rtfPreview.Text = template_scrubbed
            Me.lblAppliedTemplate.Text = TemplateName.ToString
            Me.lblSubject.Text = z.SubjectScrub(LeadToShow.RecID, False, TemplateName, depart_)
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmEmailPreview", "FormCode", "Event", "frmEmailPreview_Load", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub ResetForm()
        LeadToShow = Nothing
        TemplateName = ""
        Me.lblLeadNum.Text = ""
        Me.rtfPreview.Text = ""
        Me.Department = ""
        Me.lblSubject.Text = ""
        Me.lblAppliedTemplate.Text = ""
        Me.cboTemplates.Items.Clear()
        Try
            Dim y As New emlTemplateLogic
            Dim name() = Split(STATIC_VARIABLES.CurrentUser, " ", -1, Microsoft.VisualBasic.CompareMethod.Text)
            Dim depart_ As String = y.GetEmployeeDepartment(name(0), name(1), False)
            Dim g As List(Of emlTemplateLogic.TemplateInfo)
            g = y.GetTemplatesByDepartment(False, depart_)
            Dim a As emlTemplateLogic.TemplateInfo
            For Each a In g
                Me.cboTemplates.Items.Add(a.TemplateName)
            Next
            Me.Name = "Email Preview"
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmEmailPreview", "FormCode", "Event", "ResetForm()", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub cboTemplates_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTemplates.SelectedIndexChanged
        Try
            Dim cbo As ComboBox = sender
            Dim cbo_txt As String = cbo.Text
            Dim z As New emlTemplateLogic
            Dim template_scrubbed As String = z.TestTemplateScrub(LeadToShow.RecID, False, cbo_txt)
            Dim templt_info As emlTemplateLogic.TemplateInfo = z.GetSingleTemplate(cbo_txt, False)
            Me.rtfPreview.Text = template_scrubbed
            Me.lblAppliedTemplate.Text = cbo_txt
            Me.lblSubject.Text = z.SubjectScrub(LeadToShow.RecID, False, cbo_txt, Me.Department)
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmEmailPreview", "FormCode", "Event", "cboTemplates_SelectedIndexChanged", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub btnSendEmail_Click(sender As Object, e As EventArgs) Handles btnSendEmail.Click
        Try
            Dim y As New EmailIssuedLeads
            Dim CustEmail As String = y.Get_Record_Email(STATIC_VARIABLES.CurrentID)
            If Len(CustEmail) <= 0 Then
                MsgBox("This Customer Does Not Have an Email Address.", MsgBoxStyle.Information, "DEBUG INFO - No Customer Email Address")
                y = Nothing
                Exit Sub
            ElseIf Len(CustEmail) Then
                If Len(STATIC_VARIABLES.CurrentLoggedInEmployee.Email) <= 0 Then
                    MsgBox("You do not have a valid email address to send from.", MsgBoxStyle.Information, "DEBUG INFO - You Dont Have An Email Address")
                    y = Nothing
                    Exit Sub
                ElseIf Len(STATIC_VARIABLES.CurrentLoggedInEmployee.Email) >= 1 Then
                    y.Send_BLAST_MAIL(STATIC_VARIABLES.CurrentLoggedInEmployee.Email, CustEmail, Me.rtfPreview.Text, Me.lblSubject.Text)
                    y = Nothing
                    '' Notes:
                    '' was double "confirming" that message was sent.
                    '' class notifies of mail sent. no need for form code here.
                    '' class: EmailIssueLeads=>Send_BLAST_MAIL=>Line 1169
                    '' 2-11-2016 AC 
                    'MsgBox("Email Sent.", MsgBoxStyle.Information, "SENT EMAIL")
                End If
            End If
            Me.ResetForm()
            Me.Close()
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmEmailPreview", "FormCode", "Event", "btnSendEmail_click", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub
End Class