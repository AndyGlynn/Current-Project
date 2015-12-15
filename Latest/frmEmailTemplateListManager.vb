Public Class frmEmailTemplateListManager

    Private Sub frmEmailTemplateListManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateTemplates()
        Me.MdiParent = Main
        Me.BringToFront()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ResetMe()
    End Sub

    Private Sub PopulateTemplates()
        Dim x As New emlTemplateLogic
        Dim arTemplates As New List(Of emlTemplateLogic.TemplateInfo)
        arTemplates = x.GetTemplates(False)
        For Each y As emlTemplateLogic.TemplateInfo In arTemplates
            If y.Department <> "DEFAULT" Then
                Me.chkEmailTemplateList.Items.Add(y.TemplateName, False)
            End If
        Next
    End Sub

    Private Sub ResetMe()
        Me.chkEmailTemplateList.Items.Clear()
        PopulateTemplates()
    End Sub

    Private Sub Close_And_Clear()
        Me.chkEmailTemplateList.Items.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close_And_Clear()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim y As String
        Dim cnt As Integer
        Dim z As New emlTemplateLogic
        For cnt = 0 To Me.chkEmailTemplateList.CheckedItems.Count - 1
            Dim strTempName As String = Me.chkEmailTemplateList.CheckedItems(cnt).ToString
            'MsgBox(strTempName, MsgBoxStyle.Information, "DEBUG INFO")
            Me.chkEmailTemplateList.Items.Remove(Me.chkEmailTemplateList.CheckedItems(cnt))
            Dim template As New emlTemplateLogic.TemplateInfo
            template = z.GetSingleTemplate(strTempName, False)
            z.DeleteTemplate(False, template)
        Next
        ResetMe()
    End Sub
End Class