Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System


Public Class ViewEditWorkHours
    '' sql connection string
    '' 
    Private cnn As SqlConnection = New sqlconnection(STATIC_VARIABLES.cnn)

    '' Array list of work hours
    '' 
    Public ArWorkHours As New ArrayList

    Public Sub PopulateWorkHours()
        Try
            Dim cmdGET As SqlCommand = New SqlCommand("SELECT Hour from .workhours", cnn)
            cnn.Open()
            Dim r1 As SqlDataReader
            r1 = cmdGET.ExecuteReader
            While r1.Read
                ArWorkHours.Add(r1.Item("Hour").ToString)
            End While
            r1.Close()
            cnn.Close()
        Catch ex As Exception
            cnn.Close()
            Main.Cursor = Cursors.Default
            'Dim err As New ErrorLogFlatFile
            'err.WriteLog("ViewEditWorkHours", "None", ex.Message.ToString, "Client", STATIC_VARIABLES.CurrentUser & ", " & STATIC_VARIABLES.CurrentForm, "SQL", "PopulateWorkHours")
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "ViewEditWorkHours", "ViewEditWorkHours", "Sub", "PopulateWorkHours()", "0", ex.Message.ToString)
            y = Nothing
        End Try
    End Sub
    Public Sub DeleteWorkHour(ByVal Hour As String)
        Try
            Dim cmdDEL As SqlCommand = New SqlCommand("DELETE .workhours where Hour = @HR", cnn)
            Dim param1 As SqlParameter = New SqlParameter("@HR", Hour)
            cmdDEL.Parameters.Add(param1)
            cnn.Open()
            cmdDEL.ExecuteNonQuery()
            cnn.Close()
        Catch ex As Exception
            cnn.Close()
            Main.Cursor = Cursors.Default
            'Dim err As New ErrorLogFlatFile
            'err.WriteLog("ViewEditWorkHours", "ByVal Hour As String", ex.Message.ToString, "Client", STATIC_VARIABLES.CurrentUser & ", " & STATIC_VARIABLES.CurrentForm, "SQL", "DeleteWorkHour")
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "ViewEditWorkHours", "ViewEditWorkHours", "Sub", "DeleteWorkHour()", "0", ex.Message.ToString)
            y = Nothing
        End Try
    End Sub
    Public Sub InsertHour(ByVal Hour As String)
        Try
            Dim cmdCNT As SqlCommand = New SqlCommand("SELECT COUNT(ID) from .workhours where Hour = @HR", cnn)
            Dim param1 As SqlParameter = New SqlParameter("@HR", Hour)
            cmdCNT.Parameters.Add(param1)
            cnn.Open()
            Dim cnt As Integer = 0
            cnt = cmdCNT.ExecuteScalar
            cnn.Close()
            Select Case cnt
                Case Is <= 0
                    '' doesn't exist
                    '' add it
                    '' refresh 
                    '' 
                    Try
                        Dim cmdINS As SqlCommand = New SqlCommand("INSERT .workhours (Hour) values(@HR)", cnn)
                        Dim param2 As SqlParameter = New SqlParameter("@HR", Hour)
                        cmdINS.Parameters.Add(param2)
                        cnn.Open()
                        cmdINS.ExecuteNonQuery()
                        cnn.Close()
                        '' now repopulate list
                        'Me.PopuluateList()
                    Catch ex As Exception
                        cnn.Close()
                        Dim y As New ErrorLogging_V2
                        y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "ViewEditWorkHours", "ViewEditWorkHours", "Sub", "InsertHour()", "0", ex.Message.ToString)
                        y = Nothing
                    End Try
                    Exit Select
                Case Is >= 1
                    '' exists.
                    '' flag it
                    '' exit sub 
                    '' 
                    MsgBox("Work Hour '" & Hour & "' already exists. Please enter a new response and try again.", MsgBoxStyle.Exclamation, "Error Entering Work Hour")
                    Exit Sub
                    Exit Select
            End Select
        Catch ex As Exception
            cnn.Close()
            Main.Cursor = Cursors.Default
            'Dim err As New ErrorLogFlatFile
            'err.WriteLog("ViewEditWorkHours", "ByVal Hour As String", ex.Message.ToString, "Client", STATIC_VARIABLES.CurrentUser & ", " & STATIC_VARIABLES.CurrentForm, "SQL", "InsertHour")
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "ViewEditWorkHours", "ViewEditWorkHours", "Sub", "InsertHour()", "0", ex.Message.ToString)
            y = Nothing
        End Try
    End Sub
End Class
