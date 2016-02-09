Public Class frmEmailTemplateChoice

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        EmailTemplate.ShowDialog()
        GetTemplates()

    End Sub

    Private Sub GetTemplates()
        Try
            Me.cboTemplates.Items.Clear()
            Dim y As New emlTemplateLogic
            Dim name() = Split(STATIC_VARIABLES.CurrentUser, " ", -1, Microsoft.VisualBasic.CompareMethod.Text)
            Dim depart_ As String = y.GetEmployeeDepartment(name(0), name(1), False)
            Dim g As List(Of emlTemplateLogic.TemplateInfo)
            g = y.GetTemplatesByDepartment(False, depart_)
            Dim a As emlTemplateLogic.TemplateInfo
            For Each a In g
                Me.cboTemplates.Items.Add(a.TemplateName)
            Next
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmEmailTemplateChoice", "FormCode", "Sub", "GetTemplates()", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub frmEmailTemplateChoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetTemplates()
    End Sub

    
    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        Try
            Dim str_template As String = ""
            str_template = Me.cboTemplates.Text
            If Len(str_template) <= 0 Then
                '' no template selected.
                '' exit 
                MsgBox("You must select a template to continue.", MsgBoxStyle.Critical, "No Template Selected")
                frmEmailPreview.TemplateName = ""
                frmEmailPreview.LeadToShow = Nothing
                frmEmailPreview.Department = ""
                Me.Close()
            ElseIf Len(str_template) >= 1 Then
                '' template selected 
                frmEmailPreview.TemplateName = str_template
                Dim z As New convertLeadToStruct
                Dim x As New convertLeadToStruct.EnterLead_Record
                x = z.ConvertToStructure(STATIC_VARIABLES.CurrentID, False)
                frmEmailPreview.LeadToShow = x
                Me.Close()
                frmEmailPreview.ShowDialog()
            End If
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmEmailTemplateChoice", "FormCode", "Event", "btnApply_Click", "0", ex.Message.ToString)
            y = Nothing
        End Try


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frmEmailPreview.TemplateName = ""
        frmEmailPreview.LeadToShow = Nothing
        frmEmailPreview.Department = ""
        Me.Close()

    End Sub
End Class