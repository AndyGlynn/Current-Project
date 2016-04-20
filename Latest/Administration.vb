Public Class Administration

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


    Private Sub Administration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Main
    End Sub
End Class