Public Class openset

    Private Sub openset_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Visible = False
            Dim x As New opensetappt(Sales, Sales.ID, Sales.txtApptDate.Text, Sales.txtApptTime.Text, Sales.txtContact1.Text, Sales.txtContact2.Text)
            Me.Close()
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "OpenSet", "FormCode", "Event", "openset_load", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub
End Class