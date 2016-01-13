Public Class FinancingDepartment

    Public RecID As String = ""

    Private Sub FinancingDepartment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lblRecID.Text = RecID.ToString
    End Sub
End Class