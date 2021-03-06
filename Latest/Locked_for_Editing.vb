Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient



Public Class Locked_for_Editing
    Dim cnn As SqlConnection = New SqlConnection(STATIC_VARIABLES.Cnn)

    Public Sub Lock()
        Try
            If STATIC_VARIABLES.CurrentID = "" Then
                EditCustomerInfo.Cls = True
                Exit Sub
            End If

            Dim cmdSEL As SqlCommand = New SqlCommand("select locked, lockedbyuser from LockTable where leadnum = " & STATIC_VARIABLES.CurrentID, cnn)
            cmdSEL.CommandType = CommandType.Text
            cnn.Open()
            cmdSEL.ExecuteNonQuery()
            Dim r1 As SqlDataReader
            r1 = cmdSEL.ExecuteReader
            While r1.Read


                If r1.Item(0) = True And r1.Item(1) <> STATIC_VARIABLES.CurrentUser Then

                    EditCustomerInfo.Cls = True

                    MsgBox("This record is already being edited by " & r1.Item(1), MsgBoxStyle.Information, "Record Locked for Editing- Please Try Again Later")
                    EditCustomerInfo.Close()
                    Exit Sub
                End If
            End While
            r1.Close()


            Dim cmdUP As SqlCommand = New SqlCommand("Update LockTable set locked = 1 , LockedByUser = '" & STATIC_VARIABLES.CurrentUser & "'  where leadnum = " & STATIC_VARIABLES.CurrentID, cnn)
            cmdUP.CommandType = CommandType.Text

            cmdUP.ExecuteNonQuery()
            cnn.Close()
        Catch ex As Exception
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "Locked_For_Editing", "Locked_For_Editing", "Sub", "Lock", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub
    Public Sub Remove_Lock(ByVal id As String)
        Try
            Dim cmdUP As SqlCommand = New SqlCommand("Update LockTable set locked = 0 , LockedByUser = '' where leadnum = " & id & " and LockedByUser = '" & STATIC_VARIABLES.CurrentUser & "'", cnn)
            cmdUP.CommandType = CommandType.Text
            cnn.Open()
            cmdUP.ExecuteNonQuery()
            cnn.Close()
        Catch ex As Exception
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "Locked_For_Editing", "Locked_For_Editing", "Sub", "Remove_Lock", id, ex.Message.ToString)
            y = Nothing
        End Try
    End Sub
End Class
