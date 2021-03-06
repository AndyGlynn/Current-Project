﻿Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System

Public Class AddManager

    Private Sub AddManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.txtFName.Text = ""
            Me.txtLname.Text = ""
            Me.cboDept.SelectedItem = Nothing
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "AddManager", "FormCode", "Event", "AddManager_Load", "0", ex.Message.ToString)
            y = Nothing
        End Try


    End Sub

    Private Sub txtFName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFName.KeyPress
        Try
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = Not Char.IsLetter(e.KeyChar)
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "AddManager", "FormCode", "Event", "txtFName_KeyPress", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub txtFName_LostFocus(sender As Object, e As EventArgs) Handles txtFName.LostFocus
        Try
            If Me.txtFName.Text <> "" Then
                Me.txtFName.Text = Me.CapitalizeText(Me.txtFName.Text)
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "AddManager", "FormCode", "Event", "txtFName_LostFocus", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub
    Public Function CapitalizeText(ByVal TextToCap As String)
        Try
            Dim Text
            Text = Mid(TextToCap, 1, 1)
            Text = Text.ToString.ToUpper
            TextToCap = Text & Mid(TextToCap, 2, TextToCap.Length)
            Return TextToCap
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Return TextToCap
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "AddManager", "FormCode", "Function", "CapitalizeText", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Function

    Private Sub txtLname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLname.KeyPress
        Try
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = Not Char.IsLetter(e.KeyChar)
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "AddManager", "FormCode", "Event", "txtLName_KeyPress", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub txtLname_LostFocus(sender As Object, e As EventArgs) Handles txtLname.LostFocus
        Try
            If Me.txtLname.Text <> "" Then
                Me.txtLname.Text = Me.CapitalizeText(Me.txtLname.Text)
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "AddManager", "FormCode", "Event", "txtLName_LostFocus", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub


    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Try
            Dim cnt As Integer = 0
            If Me.txtFName.Text = "" Then
                Me.ErrorProvider1.SetError(Me.txtFName, "Required Field")
                cnt += 1
            End If
            If Me.txtLname.Text = "" Then
                Me.ErrorProvider1.SetError(Me.txtLname, "Required Field")
                cnt += 1
            End If
            If Me.cboDept.Text = "" Then
                Me.ErrorProvider1.SetError(Me.cboDept, "Required Field")
                cnt += 1
            End If
            If cnt >= 1 Then
                Exit Sub
            End If


            ''' Query Name to look for duplicates and add to error count


            Dim SQLString As String
            If Me.cboDept.Text = "Marketing" Then
                SQLString = "insert into MarketingManagerPull (ManFName , ManLName  ) values ('" & Me.txtFName.Text & "', '" & Me.txtLname.Text & "') "
            ElseIf Me.cboDept.Text = "Sales" Then
                SQLString = "insert into SalesManagerPull (FName , LName  ) values ('" & Me.txtFName.Text & "', '" & Me.txtLname.Text & "') "
            Else
                SQLString = "insert into ManagerMaster (ManFName , ManLName , Department ) values ('" & Me.txtFName.Text & "', '" & Me.txtLname.Text & "', '" & Me.cboDept.Text & "') "
            End If


            Dim cnx As SqlConnection = New SqlConnection(STATIC_VARIABLES.Cnn)
            Dim cmdGet As SqlCommand = New SqlCommand(SQLString, cnx)
            cnx.Open()
            Dim r As SqlDataReader
            r = cmdGet.ExecuteReader
            r.Read()
            r.Close()
            cnx.Close()
            SetUpUser1.cboManager.Items.Add(Me.txtFName.Text & " " & Me.txtLname.Text)
            SetUpUser1.cboManager.SelectedItem = Me.txtFName.Text & " " & Me.txtLname.Text
            Me.Close()
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "AddManager", "FormCode", "Event", "btnNext_Click", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub
End Class