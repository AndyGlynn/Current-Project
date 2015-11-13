Public Class Administration

    Private Sub TreeView1_AfterCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterCheck
        MsgBox(Me.TreeView1.SelectedNode.Text)


    End Sub

    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
      
    End Sub

    Private Sub TreeView1_BeforeSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeView1.BeforeSelect

    End Sub

    Private Sub TreeView1_ControlAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.ControlEventArgs) Handles TreeView1.ControlAdded

    End Sub

    Private Sub TreeView1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TreeView1.MouseClick


    End Sub

    Private Sub TreeView1_NodeMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseClick
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

    Private Sub TreeView1_QueryAccessibilityHelp(ByVal sender As Object, ByVal e As System.Windows.Forms.QueryAccessibilityHelpEventArgs) Handles TreeView1.QueryAccessibilityHelp

    End Sub
End Class