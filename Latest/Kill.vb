
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System
Public Class Kill
    Public Contact1 As String
    Public Contact2 As String
    Public ID As String
    Public frm As Form


    Private Sub Kill_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub Kill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ID = STATIC_VARIABLES.CurrentID
            If Me.ID = "" Then
                MsgBox("You must select a record to Kill!", MsgBoxStyle.Exclamation, "No Record Selected")
                Me.Dispose()
            End If
            Select Case frm.Name
                Case Is = "Sales"
                    Me.Contact1 = Sales.txtContact1.Text
                    Me.Contact2 = Sales.txtContact2.Text
                Case Is = "Confirming"
                    Contact1 = Confirming.txtContact1.Text
                    Contact2 = Confirming.txtContact2.Text
                Case Is = "WCaller"
                    Contact1 = WCaller.txtContact1.Text
                    Contact2 = WCaller.txtContact2.Text
                Case Is = "Recovery"
                    'Contact1 = Recovery.txtContact1.Text
                    'Contact2 = Recovery.txtContact2.Text
                Case Is = "Administration"
                    'Contact1 = Administration.txtContact1.Text
                    'Contact2 = Administration.txtContact2.Text
                Case Is = "Installation"
                    'Contact1 = Installation.txtContact1.Text
                    'Contact2 = Installation.txtContact2.Text
                Case Is = "ConfirmingSingleRecord"
                    Contact1 = ConfirmingSingleRecord.txtContact1.Text
                    Contact2 = ConfirmingSingleRecord.txtContact2.Text
                Case Is = "Finance"
                    'Contact1 = Finance.txtContact1.Text
                    'Contact2 = Finance.txtContact2.Text
                Case Is = "MarketingManager"
                    Contact1 = MarketingManager.txtContact1.Text
                    Contact2 = MarketingManager.txtContact2.Text

                Case Is = "PreviousCustomer"
                    'Contact1 = PreviousCustomer.txtContact1.Text
                    'Contact2 = PreviousCustomer.txtContact2.Text
                Case Is = "EditCustomerInfo"
                    Me.Contact1 = EditCustomerInfo.txtContact1.Text
                    Me.Contact2 = EditCustomerInfo.txtContact2.Text
            End Select





            Dim s = Split(Contact1, " ")
            Me.Contact1 = s(0)
            Dim s2 = Split(Contact2, " ")
            Me.Contact2 = s2(0)
            Me.cboSpokeWith.Items.Add(Me.Contact1)
            If Me.Contact2 <> " " Then
                Me.cboSpokeWith.Items.Add(Contact2)
                Me.cboSpokeWith.Items.Add(Contact1 & " & " & Contact2)
            Else
                Me.cboSpokeWith.Text = Contact1
            End If

            Dim cnn = New SqlConnection(STATIC_VARIABLES.Cnn)
            Dim cmdIns As SqlCommand = New SqlCommand("dbo.GetKillReasons", cnn)
            cmdIns.CommandType = CommandType.StoredProcedure

            Me.cboautonote.Items.Clear()
            Me.cboautonote.Items.Add("<Add New>")
            Me.cboautonote.Items.Add("___________________________________________________")

            cnn.Open()
            Dim R1 As SqlDataReader
            R1 = cmdIns.ExecuteReader(CommandBehavior.CloseConnection)
            While R1.Read()
                Me.cboautonote.Items.Add(R1.Item(0))
            End While
            R1.Close()
            cnn.close()
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "Kill", "FormCode", "Event", "Kill_Load", "0", ex.Message.ToString)
            y = Nothing
        End Try


    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            Me.ErrorProvider1.Clear()
            If Me.cboSpokeWith.Text = "" Then
                Me.ErrorProvider1.SetError(Me.cboSpokeWith, "This field is required!")
            End If
            If Me.cboautonote.SelectedItem = Nothing Then
                Me.ErrorProvider1.SetError(Me.cboautonote, "This field is required!")
            End If
            If Me.cboSpokeWith.Text <> "" And Me.cboautonote.SelectedItem <> Nothing Then
                Dim Description = STATIC_VARIABLES.CurrentUser & " spoke with " & Me.cboSpokeWith.Text & " and killed this appt." & " Reason: " & Me.cboautonote.Text


                Dim cnn = New SqlConnection(STATIC_VARIABLES.Cnn)
                Dim cmdIns As SqlCommand = New SqlCommand("dbo.KillAppt", cnn)
                Dim param1 As SqlParameter = New SqlParameter("@ID", ID)
                Dim param2 As SqlParameter = New SqlParameter("@User", STATIC_VARIABLES.CurrentUser)
                Dim param3 As SqlParameter = New SqlParameter("@Spokewith", Me.cboSpokeWith.Text)
                Dim param4 As SqlParameter = New SqlParameter("@Description", Description)
                Dim param5 As SqlParameter = New SqlParameter("@Notes", Me.txtNotes.Text)
                cmdIns.CommandType = CommandType.StoredProcedure
                cmdIns.Parameters.Add(param1)
                cmdIns.Parameters.Add(param2)
                cmdIns.Parameters.Add(param3)
                cmdIns.Parameters.Add(param4)
                cmdIns.Parameters.Add(param5)

                cnn.Open()
                Dim R1 As SqlDataReader
                R1 = cmdIns.ExecuteReader(CommandBehavior.CloseConnection)
                R1.Read()
                R1.Close()
                cnn.close()

                Me.Close()

                Dim c As New ConfirmingData
                If frm.Name = "Confirming" Then
                    c.Populate(Confirming.Tab, Confirming.cboConfirmingPLS.Text, Confirming.cboConfirmingSLS.Text, Confirming.dpConfirming.Value.ToString, "Populate")
                ElseIf frm.Name = "WCaller" Then

                ElseIf frm.Name = "ConfirmingSingleRecord" Then
                    Dim q As New CustomerHistory
                    q.SetUp(ConfirmingSingleRecord.TScboCustomerHistory)

                End If
                STATIC_VARIABLES.Update = True
                Me.Close()
                Me.Dispose()
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "Kill", "FormCode", "Event", "btnSave_Click", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub



    Private Sub cboautonote_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboautonote.SelectedValueChanged
        Try
            Dim i As String
            Select Case Me.cboautonote.Text
                Case "<Add New>"
                    Me.cboautonote.SelectedItem = Nothing

                    i = InputBox$("Enter a new ""Kill Reason"" here." & vbCr & "(25 Character Maximum)", "Save Auto Note")

                    If i.Length > 25 Then
                        Do
                            MsgBox("The ""Kill Reason"" you've entered is " & i.Length.ToString & " characters long!" & vbCr & "You've exceeding the Maximum number of characters by " & i.Length - 25 & " characters!" & vbCr & "Please enter a shorter description for your Reason")
                            i = InputBox$("Enter a new ""Kill Reason"" here." & vbCr & "(25 Character Maximum)", "Save Auto Note", Microsoft.VisualBasic.Right(i, 25))
                        Loop Until i.Length < 26

                    End If
                    If i = "" Then
                        'MsgBox("You must enter Text to save this Kill Reason!", MsgBoxStyle.Exclamation, "No Text Supplied")
                        Exit Sub
                    End If

                    Dim cnn = New SqlConnection(STATIC_VARIABLES.Cnn)
                    Dim cmdINS As SqlCommand = New SqlCommand("dbo.INSKillReasons", cnn)
                    Dim param1 As SqlParameter = New SqlParameter("@Reason", i)
                    cmdINS.Parameters.Add(param1)
                    cmdINS.CommandType = CommandType.StoredProcedure

                    Dim r1 As SqlDataReader

                    Me.cboautonote.Items.Clear()
                    Me.cboautonote.Items.Add("<Add New>")
                    Me.cboautonote.Items.Add("___________________________________________________")
                    cnn.Open()
                    r1 = cmdINS.ExecuteReader
                    While r1.Read
                        Me.cboautonote.Items.Add(r1.Item(0))
                    End While
                    r1.Close()
                    cnn.Close()
                    Me.cboautonote.Text = i
                    Me.lblautonotes.Text = Me.cboautonote.Text
                    Me.lblautonotes.ForeColor = Color.Black
                    Me.lblautonotes.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                    Exit Select


                Case "___________________________________________________", ""
                    Me.lblautonotes.ForeColor = Color.Gray
                    Me.lblautonotes.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                    Me.lblautonotes.Text = "Select Reason From Standard Reason List (Required)"
                    Me.cboautonote.SelectedItem = Nothing
                    Exit Select
                Case Else
                    Me.lblautonotes.Text = Me.cboautonote.Text
                    Me.lblautonotes.ForeColor = Color.Black
                    Me.lblautonotes.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

            End Select



        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "Kill", "FormCode", "Event", "cboautonote_selectedValueChanged", "0", ex.Message.ToString)
            y = Nothing
        End Try



    End Sub

    Private Sub txtNotes_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNotes.GotFocus
        Me.lblNotes.Visible = False
    End Sub

    Private Sub txtNotes_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNotes.LostFocus
        If Me.txtNotes.Text = "" Then
            Me.lblNotes.Visible = True
        End If
    End Sub

    Private Sub lblautonotes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblautonotes.Click

        Me.cboautonote.DroppedDown = True

    End Sub

    Private Sub lblNotes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblNotes.Click
        Me.txtNotes.Focus()

    End Sub



End Class