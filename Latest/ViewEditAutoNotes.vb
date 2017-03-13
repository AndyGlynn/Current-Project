Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System


Public Class ViewEditAutoNotes
    '' connection string
    '' 
    Private cnn As SqlConnection = New sqlconnection(STATIC_VARIABLES.cnn)
    Public ArAutoNotes As New ArrayList

    Public Sub PopuluateList()
        Try
            Dim cmdGET As SqlCommand = New SqlCommand("SELECT Response from .autonotes", cnn)
            cnn.Open()
            Dim r1 As SqlDataReader
            r1 = cmdGET.ExecuteReader
            While r1.Read
                ArAutoNotes.Add(r1.Item("Response"))
            End While
            r1.Close()
            cnn.Close()
        Catch ex As Exception
            Main.Cursor = Cursors.Default
            cnn.Close()
            'Dim err As New ErrorLogFlatFile
            'err.WriteLog("ViewEditAutoNotes", "None", ex.Message.ToString, "Client", STATIC_VARIABLES.CurrentUser & ", " & STATIC_VARIABLES.CurrentForm, "Client", "PopulateList")
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "ViewEditAutoNotes", "ViewEditAutoNotes", "Sub", "PopulateList()", "0", ex.Message.ToString)
            y = Nothing
        End Try
    End Sub
    Public Sub InsertAutoNote(ByVal Response As String)
        Try
            Dim cmdCNT As SqlCommand = New SqlCommand("SELECT COUNT(ID) from .autonotes where Response = @RES", cnn)
            Dim param1 As SqlParameter = New SqlParameter("@RES", Response)
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
                        Dim cmdINS As SqlCommand = New SqlCommand("INSERT .autonotes (Response) values(@RES)", cnn)
                        Dim param2 As SqlParameter = New SqlParameter("@RES", Response)
                        cmdINS.Parameters.Add(param2)
                        cnn.Open()
                        cmdINS.ExecuteNonQuery()
                        cnn.Close()
                        '' now repopulate list
                        'Me.PopuluateList()

                    Catch ex As Exception
                        cnn.Close()
                        Dim y As New ErrorLogging_V2
                        y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "ViewEditAutoNotes", "ViewEditAutoNotes", "Sub", "InsertAutoNotes(response)", "0", ex.Message.ToString)
                        y = Nothing
                    End Try
                    Exit Select
                Case Is >= 1
                    '' exists.
                    '' flag it
                    '' exit sub 
                    '' 
                    MsgBox("Response '" & Response & "' already exists. Please enter a new response and try again.", MsgBoxStyle.Exclamation, "Error Entering Auto Note")
                    Exit Sub
                    Exit Select
            End Select
        Catch ex As Exception
            cnn.Close()
            Main.Cursor = Cursors.Default
            'Dim err As New ErrorLogFlatFile
            'err.WriteLog("ViewEditAutoNotes", "ByVal Response As String", ex.Message.ToString, "Client", STATIC_VARIABLES.CurrentUser & ", " & STATIC_VARIABLES.CurrentForm, "Client", "InsertAutoNote")
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "ViewEditAutoNotes", "ViewEditAutoNotes", "Sub", "InsertAutoNote(response)", "0", ex.Message.ToString)
            y = Nothing
        End Try
    End Sub
    Public Sub DeleteNote(ByVal Response As String)
        Try
            Dim cmdDEL As SqlCommand = New SqlCommand("DELETE .autonotes where Response = @RES", cnn)
            Dim param1 As SqlParameter = New SqlParameter("@RES", Response)
            cmdDEL.Parameters.Add(param1)
            cnn.Open()
            cmdDEL.ExecuteNonQuery()
            cnn.Close()
            'Me.PopuluateList()
        Catch ex As Exception
            cnn.Close()
            Main.Cursor = Cursors.Default
            'Dim err As New ErrorLogFlatFile
            'err.WriteLog("DeleteNote", "ByVal Response as string", ex.Message.ToString, "Client", STATIC_VARIABLES.CurrentUser & ", " & STATIC_VARIABLES.CurrentForm, "SQL", "DeleteNote")
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "ViewEditAutoNotes", "ViewEditAutoNotes", "Sub", "DeleteNote(response)", "0", ex.Message.ToString)
            y = Nothing
        End Try
    End Sub
End Class
