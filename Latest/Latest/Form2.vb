Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        KillProcess()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel1_Scroll(ByVal sender As Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles Panel1.Scroll

    End Sub
    Public Sub KillProcess()
        Dim pr() = System.Diagnostics.Process.GetProcessesByName("MapPoint")
        Dim g
        For Each g In pr
            Dim b As System.Diagnostics.Process = g
            If b.HasExited = False Then
                b.Kill()
            End If
        Next
    End Sub
End Class