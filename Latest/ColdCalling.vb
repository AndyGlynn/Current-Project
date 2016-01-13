Public Class ColdCalling
    Public recID As String = ""
    Private Sub ColdCalling_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = Main
        Me.lblRecID.Text = recID.ToString
    End Sub
End Class