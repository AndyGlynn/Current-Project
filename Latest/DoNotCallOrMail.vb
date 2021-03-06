
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System



Public Class DoNotCallOrMail
    Public Sub DoNot(ByVal ID As String, ByVal cmd As String)
        Try
            Dim cnn As SqlConnection = New SqlConnection(STATIC_VARIABLES.Cnn)
            Dim cmdIns As SqlCommand
            If cmd = "Mark as Do Not Call" Then
                cmdIns = New SqlCommand("dbo.DoNotCall", cnn)
            ElseIf cmd = "Mark as Do Not Mail" Then
                cmdIns = New SqlCommand("dbo.DoNotMail", cnn)
            ElseIf cmd = "Mark as Do Not Call Or Mail" Then
                cmdIns = New SqlCommand("dbo.DoNotCallorMail", cnn)
            ElseIf cmd = "Undo Do Not Call" Then
                cmdIns = New SqlCommand("dbo.UndoDoNotCall", cnn)
            ElseIf cmd = "Undo Do Not Call Or Mail" Then
                cmdIns = New SqlCommand("dbo.UndoDoNotCallorMail", cnn)
            ElseIf cmd = "Undo Do Not Mail" Then
                cmdIns = New SqlCommand("dbo.UndoDoNotMail", cnn)
            End If
            Dim param1 As SqlParameter = New SqlParameter("@ID", ID)
            Dim param2 As SqlParameter = New SqlParameter("@User", STATIC_VARIABLES.CurrentUser)
            cmdIns.CommandType = CommandType.StoredProcedure
            cmdIns.Parameters.Add(param1)
            cmdIns.Parameters.Add(param2)
            cnn.Open()
            Dim R1 As SqlDataReader
            R1 = cmdIns.ExecuteReader(CommandBehavior.CloseConnection)
            R1.Read()
            R1.Close()
            cnn.Close()
        Catch ex As Exception
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "DoNotCallOrMail", "DoNotCallOrMail", "Sub", "DoNot(ID,cmd)", "0", ex.Message.ToString)
            y = Nothing

        End Try

    End Sub
End Class
