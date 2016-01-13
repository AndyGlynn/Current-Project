Public Class Recovery
    Public RecID As String = ""
    Private Sub Recovery_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = Main
        Me.lblRecID.Text = RecID
    End Sub
End Class