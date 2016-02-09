Public Class frmBackup

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim b As New DBASE_Backup
            b.Backup()
            b.Get_Existing()
            'System.Diagnostics.Process.Start("\\ekg1\iss\backups") 
            '' nope. 
            '' 2/9/2016 AC
            '' hardware and path locations have changed.
            '' also, i don't even think this is used any more.
            '' was not asked to expand upon this. 
            '' DBASE_Backup class is legacy code circa: 2005-2008
            '' 
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmBackup", "FormCode", "Sub", "btn1_Click", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim b As New DBASE_Backup
            b.Get_Existing()

        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmBackup", "FormCode", "Sub", "form1_load", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.ListView1.Items.Clear()
        Me.Close()
    End Sub
End Class
