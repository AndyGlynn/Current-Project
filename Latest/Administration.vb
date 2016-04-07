Public Class Administration



    

    Private Sub TreeView1_NodeMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs)
        ' MsgBox(Me.TreeView1.SelectedNode.Text)
        'If Me.TreeView1.Nodes(0).Checked = True Then
        '    Me.TreeView1.Nodes(0).Nodes(0).Checked = True
        '    Me.TreeView1.Nodes(0).Nodes(0).Nodes(0).Checked = True
        '    Me.TreeView1.Nodes(0).Nodes(0).Nodes(1).Checked = True
        '    Me.TreeView1.Nodes(0).Nodes(0).Nodes(2).Checked = True
        'ElseIf Me.TreeView1.Nodes(0).Checked = False Then
        '    Me.TreeView1.Nodes(0).Nodes(0).Checked = False
        '    Me.TreeView1.Nodes(0).Nodes(0).Nodes(0).Checked = False
        '    Me.TreeView1.Nodes(0).Nodes(0).Nodes(1).Checked = False
        '    Me.TreeView1.Nodes(0).Nodes(0).Nodes(2).Checked = False
        'End If
    End Sub

    
    Private Sub tsbtnUsers_Click(sender As Object, e As EventArgs) Handles tsbtnUsers.Click
        Try
            SetUpUser.ShowDialog()
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "Administration", "FormCode", "Event", "tsbtnUsers_click", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    
End Class