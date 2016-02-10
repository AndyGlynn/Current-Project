Imports System.Data.Sql
Imports System.Data
Imports System.Data.SqlClient
Imports System

Public Class PastDueAlerts
    Public SelectedID As New ArrayList
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Me.MdiParent = Main
            Me.SelectedID.Clear()
            Me.pnlBack.Controls.Clear()
            If STATIC_VARIABLES.CurrentUser.ToString = "Admin Admin" Then
                Dim g As New ALERT_LOGIC("Admin")
            ElseIf STATIC_VARIABLES.CurrentUser.ToString <> "Admin Admin" Then
                Dim g As New ALERT_LOGIC(STATIC_VARIABLES.CurrentUser)
            End If
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "PastDueAlerts", "FormCode", "Event", "Form1_Load", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            If SelectedID.ToString = "0" Or SelectedID.ToString = "" Or SelectedID.ToString = " " Then
                MsgBox("You must select a record to toggle as completed.", MsgBoxStyle.Exclamation, )
                Exit Sub
            ElseIf SelectedID.ToString.ToString <> "0" Or SelectedID.ToString <> "" Or SelectedID.ToString <> " " Then
                Dim g
                Dim i As Integer = 0
                For Each g In SelectedID
                    i += 1
                    ToggleComplete(SelectedID(i - 1))
                Next
                If STATIC_VARIABLES.CurrentUser.ToString = "Admin Admin" Then
                    Dim al As New ALERT_LOGIC("Admin")
                ElseIf STATIC_VARIABLES.CurrentUser.ToString <> "Admin Admin" Then
                    Dim al As New ALERT_LOGIC(STATIC_VARIABLES.CurrentUser)
                End If
            End If
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "PastDueAlerts", "FormCode", "Event", "Button2_Click", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub
    Private Sub ToggleComplete(ByVal RecordID As String)
        Try
            Dim cnn As SqlConnection = New SqlConnection(STATIC_VARIABLES.Cnn)
            Dim cmdUP As SqlCommand = New SqlCommand("UPDATE iss.dbo.alerttable SET Completed = 1 where ID = @ID", cnn)
            Dim param1 As SqlParameter = New SqlParameter("@ID", RecordID)
            cmdUP.Parameters.Add(param1)
            cnn.Open()
            Dim r1 As SqlDataReader
            r1 = cmdUP.ExecuteReader
            r1.Close()
            cnn.Close()
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "PastDueAlerts", "FormCode", "Sub", "ToggleComplete(recordID)", RecordID, ex.Message.ToString)
            y = Nothing
        End Try

    End Sub


End Class
