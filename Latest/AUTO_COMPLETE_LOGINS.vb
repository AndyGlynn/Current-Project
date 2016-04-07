
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Sql


Public Class AUTO_COMPLETE_LOGINS
    Private cnn As SqlConnection = New sqlconnection(STATIC_VARIABLES.cnn)
    Public Sub New()
        Try
            LOGIN.txtUserName.AutoCompleteCustomSource.Clear()
            Dim ArUSERS As New ArrayList
            Dim cmdGET As SqlCommand = New SqlCommand("SELECT UserName from iss.dbo.userpermissiontable Order By UserName", cnn)
            Dim r1 As SqlDataReader
            cnn.Open()
            r1 = cmdGET.ExecuteReader
            While r1.Read
                If r1.Item(0).ToString = "Admin" Then
                    ArUSERS.Add(r1.Item(0).ToString)
                End If
                If r1.Item(0).ToString <> "Admin" Then
                    ArUSERS.Add(r1.Item(0))
                End If
            End While
            r1.Close()
            cnn.Close()
            Dim i As Integer = 0
            For i = 0 To ArUSERS.Count - 1
                LOGIN.txtUserName.AutoCompleteCustomSource.Add(ArUSERS.Item(i).ToString)
            Next
        Catch ex As Exception

            Main.Cursor = Cursors.Default
            cnn.Close()
            'Dim err As New ErrorLogFlatFile
            'err.WriteLog("AUTO_COMPLETE_LOGINS", "None", ex.Message.ToString, "Client", STATIC_VARIABLES.CurrentUser & ", " & STATIC_VARIABLES.CurrentForm, "SQL", "'New'")
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now.ToString, My.Computer.Name, STATIC_VARIABLES.IP, "AUTO_COMPLETE_LOGINS", "AUTO_COMPLETE_LOGINS", "Class", "Constructor()", "0", ex.Message.ToString)
            y = Nothing
        End Try
    End Sub
End Class
