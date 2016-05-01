Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System
Public Class CNGApptTime
    Public Frm As Form
    Public Id As String

    Private Sub CNGApptTime_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Id = STATIC_VARIABLES.CurrentID
        If Id = "" Then
            MsgBox("You must select a record to change Appt. Time!", MsgBoxStyle.Exclamation, "No Record Selected")
            Me.Dispose()
        End If

        If Frm.Name = "Confirming" Then
            Me.txtApptTime.Text = Confirming.txtApptTime.Text
        Else
            Me.txtApptTime.Text = ConfirmingSingleRecord.txtApptTime.Text
        End If


    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If Me.dtpApptTime.Value.ToShortTimeString = Me.txtApptTime.Text Then
                Me.Close()
                Exit Sub
            End If
            Dim Description As String = "At " & DateTime.Now.ToShortTimeString & " " & STATIC_VARIABLES.CurrentUser & " changed Appt. Time from " & Me.txtApptTime.Text & " to " & Me.dtpApptTime.Value.ToShortTimeString
            Dim tm As String
            If Frm.Name = "Confirming" Then
                tm = Confirming.lvSales.SelectedItems(0).Text
            Else
                tm = ConfirmingSingleRecord.ID
            End If



            Dim cnn As SqlConnection = New SqlConnection(STATIC_VARIABLES.Cnn)
            Dim cmdChange As SqlCommand
            cmdChange = New SqlCommand("dbo.CNGApptTime", cnn)
            Dim param1 As SqlParameter = New SqlParameter("@ID", tm)
            Dim param2 As SqlParameter = New SqlParameter("@User", STATIC_VARIABLES.CurrentUser)
            Dim param3 As SqlParameter = New SqlParameter("@Description", Description)
            Dim param4 As SqlParameter = New SqlParameter("@ApptTime", Me.dtpApptTime.Value)

            cmdChange.CommandType = CommandType.StoredProcedure
            cmdChange.Parameters.Add(param1)
            cmdChange.Parameters.Add(param2)
            cmdChange.Parameters.Add(param3)
            cmdChange.Parameters.Add(param4)
            cnn.Open()
            Dim R1 = cmdChange.ExecuteReader
            R1.Read()
            R1.Close()
            cnn.Close()
            STATIC_VARIABLES.Update = True
            Me.Close()
            Me.Dispose()
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now.ToString, My.Computer.Name, STATIC_VARIABLES.IP, "CNGApptTime", "CNGApptTime", "Event", "btnSave", "0", ex.Message.ToString)
            y = Nothing
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
        Me.Dispose()
    End Sub
End Class