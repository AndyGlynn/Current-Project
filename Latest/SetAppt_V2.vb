Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Sql


Public Class SetAppt_V2

    '' notes:

    '' 1-11-2015 AC
    '' private classes do the SQL work
    '' SQL work NO LONGER inline. 
    '' lines 346+ at bottom of form code.
    '' 
    Public Contact1 As String
    Public Contact2 As String
    Public ID As String
    Public OrigApptDate As String
    Public OrigApptTime As String
    Public frm As Form
    Public Confirmed As Boolean = False


    Private Sub cboautonotes_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboautonotes.SelectedValueChanged
        Try
            Dim i As String
            If Me.cboautonotes.SelectedItem = "<Add New>" Then
                Me.cboautonotes.SelectedItem = Nothing

                i = InputBox$("Enter a new ""Auto Note"" here.", "Save Auto Note")

                If i = "" Then
                    MsgBox("You must enter Text to save this Auto Note!", MsgBoxStyle.Exclamation, "No Text Supplied")
                    Exit Sub
                End If
                Dim c As Integer = Me.Check_For_DuplicateNote(i)
                If i > 0 Then
                    MsgBox("There is already a note in the system with the title '" & i & "'." & vbCrLf & "Please use a different auto note name.", MsgBoxStyle.Exclamation, "Same Note Exists")
                    Exit Sub
                End If
                Dim cnn = New SqlConnection(STATIC_VARIABLES.Cnn)
                Dim cmdINS As SqlCommand = New SqlCommand("dbo.InsSetApptNotes", cnn)
                Dim param1 As SqlParameter = New SqlParameter("@Notes", i)
                cmdINS.Parameters.Add(param1)
                cmdINS.CommandType = CommandType.StoredProcedure
                Dim r1 As SqlDataReader

                Me.cboautonotes.Items.Clear()
                Me.cboautonotes.Items.Add("<Add New>")
                Me.cboautonotes.Items.Add("___________________________________________________")
                cnn.Open()
                r1 = cmdINS.ExecuteReader


                While r1.Read
                    Me.cboautonotes.Items.Add(r1.Item(0))
                End While
                r1.Close()
                cnn.Close()

                Me.cboautonotes.Text = i

            End If
            If Me.cboautonotes.Text = i Then
                Exit Sub
            End If





            Dim x
            Dim y
            y = Me.RichTextBox1.Text.Length
            If Me.cboautonotes.SelectedItem = Nothing Then
                Exit Sub
            End If

            x = Me.cboautonotes.Text
            If x = "" Then
                Exit Sub
            End If
            If x = "<Add New>" Then
                Me.lblautonotes.ForeColor = Color.Gray
                Me.lblautonotes.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                Me.lblautonotes.Text = "Select Auto Note Here"
                'Me.cboautonotes.SelectedItem = Nothing
                Exit Sub
            ElseIf x = "___________________________________________________" Then
                Me.lblautonotes.ForeColor = Color.Gray
                Me.lblautonotes.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                Me.lblautonotes.Text = "Select Auto Note Here"
                Me.cboautonotes.SelectedItem = Nothing
                Exit Sub
            End If

            Select Case y
                Case Is < 1
                    Me.RichTextBox1.Text = x
                    Me.lblautonotes.Text = Me.cboautonotes.Text
                    Me.lblautonotes.ForeColor = Color.Black
                    Me.lblautonotes.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))


                    Exit Select
                Case Is > 0
                    Me.RichTextBox1.Text = (Me.RichTextBox1.Text & ", " & x)
                    Me.lblautonotes.Text = Me.cboautonotes.Text
                    Me.lblautonotes.ForeColor = Color.Black
                    Me.lblautonotes.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            End Select
            If Me.RichTextBox1.Text <> "" Then
                Me.Label1.Visible = False
            End If

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "SendNotesSM", "FormCode", "Event", "cboauotnotes_SelectedValueChanged", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub


    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Me.Confirmed = Me.chkConfirm.Checked
        Try
            If Me.dtpApptDate.Value < Today And Me.txtDate.Visible = False And chkConfirm.Checked = False Then

                Dim er As New ErrorProvider
                er.BlinkStyle = ErrorBlinkStyle.NeverBlink
                er.SetError(Me.dtpApptDate, "Appointment Date Must be for Today or Future!")
                'MsgBox("Appointment Date Must be for Today or Future!", MsgBoxStyle.Exclamation, "Cannot Set Appt.")
                Exit Sub
            End If

            Me.ErrorProvider1.Clear()
            Me.ErrorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink
            If Me.cboSpokeWith.Text = "" Then
                Me.ErrorProvider1.SetError(Me.cboSpokeWith, "You Must supply a Name!")
            End If

            'If Me.RichTextBox1.Text = "" Then
            'Me.ErrorProvider1.SetError(Me.RichTextBox1, "You must supply a reason for cancellation!")
            'End If
            If Me.txtDate.Text = "" Then
                Me.ErrorProvider1.SetError(Me.dtpApptDate, "You must supply a new Appt. Date!")
            End If
            If Me.txtTime.Text = "" Then
                Me.ErrorProvider1.SetError(Me.dtpApptTime, "You must supply a new Appt. Time!")
            End If
            Dim Description As String
            If Me.cboSpokeWith.Text <> "" And Me.txtDate.Text <> "" And Me.txtTime.Text <> "" Then
                Dim day = Me.dtpApptDate.Value.DayOfWeek
                If day = 0 Then
                    day = "Sunday"
                ElseIf day = 1 Then
                    day = "Monday"
                ElseIf day = 2 Then
                    day = "Tuesday"
                ElseIf day = 3 Then
                    day = "Wednesday"
                ElseIf day = 4 Then
                    day = "Thursday"
                ElseIf day = 5 Then
                    day = "Friday"
                ElseIf day = 6 Then
                    day = "Saturday"
                End If

                If Me.txtDate.Text = "" Then

                    Me.txtDate.Text = OrigApptDate
                End If
                If Me.txtTime.Text = "" Then
                    Me.txtTime.Text = OrigApptTime
                End If

                Dim s = Split(Me.txtDate.Text, " ")
                Dim dt = s(0) & " 12:00:00 AM"
                Dim s2 = Split(Me.txtTime.Text, " ")
                Dim tm

                Try
                    tm = "1/1/1900 " & s2(1) & s2(2)

                Catch ex As Exception
                    tm = "1/1/1900 " & s2(0) & s2(1)
                End Try
                If frm.Name = "WCaller" Then
                    Description = "Appt. Set from Warm Calling by " & STATIC_VARIABLES.CurrentUser & ", set up with " & Me.cboSpokeWith.Text & " for " & day & ", " & CDate(dt).ToShortDateString & " at " & CDate(tm).ToShortTimeString & "."
                ElseIf frm.Name = "ConfirmingSingleRecord" Then
                    Description = "Appt. Set by " & STATIC_VARIABLES.CurrentUser & ", set up with " & Me.cboSpokeWith.Text & " for " & day & ", " & CDate(dt).ToShortDateString & " at " & CDate(tm).ToShortTimeString & "."
                ElseIf frm.Name = "Sales" Then
                    If Me.Confirmed = True Then
                        Description = "Appt. Set from Sales Department by " & STATIC_VARIABLES.CurrentUser & ", set up with " & Me.cboSpokeWith.Text & " for " & day & ", " & CDate(dt).ToShortDateString & " at " & CDate(tm).ToShortTimeString & ". Confirmed by " & STATIC_VARIABLES.CurrentUser & ". (Confirming Bypassed)"
                    Else
                        Description = "Appt. Set from Sales Department by " & STATIC_VARIABLES.CurrentUser & ", set up with " & Me.cboSpokeWith.Text & " for " & day & ", " & CDate(dt).ToShortDateString & " at " & CDate(tm).ToShortTimeString & "."
                    End If
                ElseIf frm.Name = "Recovery" Then
                    Description = "Appt. Set from Recovery by " & STATIC_VARIABLES.CurrentUser & ", set up with " & Me.cboSpokeWith.Text & " for " & day & ", " & CDate(dt).ToShortDateString & " at " & CDate(tm).ToShortTimeString & "."
                ElseIf frm.Name = "PreviousCustomer" Then
                    Description = "Appt. Set from Previous Customer by " & STATIC_VARIABLES.CurrentUser & ", set up with " & Me.cboSpokeWith.Text & " for " & day & ", " & CDate(dt).ToShortDateString & " at " & CDate(tm).ToShortTimeString & "."
                ElseIf frm.Name = "Finance" Then
                    Description = "Appt. Set from Financing by " & STATIC_VARIABLES.CurrentUser & ", set up with " & Me.cboSpokeWith.Text & " for " & day & ", " & CDate(dt).ToShortDateString & " at " & CDate(tm).ToShortTimeString & "."
                ElseIf frm.Name = "Installation" Then
                    Description = "Appt. Set from Installation Department by " & STATIC_VARIABLES.CurrentUser & ", set up with " & Me.cboSpokeWith.Text & " for " & day & ", " & CDate(dt).ToShortDateString & " at " & CDate(tm).ToShortTimeString & "."
                ElseIf frm.Name = "MarketingManager" Then
                    If Me.Confirmed = True Then
                        Description = "Appt. Set from Marketing Manager by " & STATIC_VARIABLES.CurrentUser & ", set up with " & Me.cboSpokeWith.Text & " for " & day & ", " & CDate(dt).ToShortDateString & " at " & CDate(tm).ToShortTimeString & ". Confirmed by " & STATIC_VARIABLES.CurrentUser & ". (Confirming Bypassed)"
                    Else
                        Description = "Appt. Set from Marketing Manager by " & STATIC_VARIABLES.CurrentUser & ", set up with " & Me.cboSpokeWith.Text & " for " & day & ", " & CDate(dt).ToShortDateString & " at " & CDate(tm).ToShortTimeString & "."
                    End If
                ElseIf frm.Name = "Administration" Then
                    If Me.Confirmed = True Then
                        Description = "Appt. Set from Administration by " & STATIC_VARIABLES.CurrentUser & ", set up with " & Me.cboSpokeWith.Text & " for " & day & ", " & CDate(dt).ToShortDateString & " at " & CDate(tm).ToShortTimeString & ". Confirmed by " & STATIC_VARIABLES.CurrentUser & ". (Confirming Bypassed)"
                    Else
                        Description = "Appt. Set from Administration by " & STATIC_VARIABLES.CurrentUser & ", set up with " & Me.cboSpokeWith.Text & " for " & day & ", " & CDate(dt).ToShortDateString & " at " & CDate(tm).ToShortTimeString & "."
                    End If
                ElseIf frm.Name = "Confirming" Then
                    Description = "Appt. Set from Confirming by " & STATIC_VARIABLES.CurrentUser & ", set up with " & Me.cboSpokeWith.Text & " for " & day & ", " & CDate(dt).ToShortDateString & " at " & CDate(tm).ToShortTimeString & "."
                End If


                Dim cnn = New SqlConnection(STATIC_VARIABLES.Cnn)

                Dim cmdIns As SqlCommand = New SqlCommand("dbo.LogSetAppt", cnn)
                Dim param1 As SqlParameter = New SqlParameter("@ID", ID)
                Dim param2 As SqlParameter = New SqlParameter("@User", STATIC_VARIABLES.CurrentUser)
                Dim param3 As SqlParameter = New SqlParameter("@Spokewith", Me.cboSpokeWith.Text)
                Dim param4 As SqlParameter = New SqlParameter("@ApptDate", dt)
                Dim param5 As SqlParameter = New SqlParameter("@Description", Description)
                Dim param6 As SqlParameter = New SqlParameter("@ApptTime", tm)
                Dim param7 As SqlParameter = New SqlParameter("@Notes", Me.RichTextBox1.Text)
                Dim param8 As SqlParameter = New SqlParameter("@Manager", STATIC_VARIABLES.CurrentManager)
                Dim param9 As SqlParameter = New SqlParameter("@Confirmed", Me.Confirmed)
                Dim param10 As SqlParameter = New SqlParameter("@Form", frm.Name.ToString)

                cmdIns.CommandType = CommandType.StoredProcedure
                cmdIns.Parameters.Add(param1)
                cmdIns.Parameters.Add(param2)
                cmdIns.Parameters.Add(param3)
                cmdIns.Parameters.Add(param4)
                cmdIns.Parameters.Add(param5)
                cmdIns.Parameters.Add(param6)
                cmdIns.Parameters.Add(param7)
                cmdIns.Parameters.Add(param8)
                cmdIns.Parameters.Add(param9)
                cmdIns.Parameters.Add(param10)
                cnn.Open()
                Dim R1 As SqlDataReader
                R1 = cmdIns.ExecuteReader(CommandBehavior.CloseConnection)
                R1.Read()
                R1.Close()
                cnn.close()
                STATIC_VARIABLES.Update = True
                Me.Close()
                Me.Dispose()
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "SendNotesSM", "FormCode", "Event", "btnSave_Click", "0", ex.Message.ToString)
            y = Nothing
        End Try


    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub lblautonotes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblautonotes.Click
        Me.cboautonotes.DroppedDown = True
    End Sub





    Private Sub lblSpokeWith_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSpokeWith.Click
        Me.cboSpokeWith.DroppedDown = True
    End Sub





    Private Sub txtDate_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDate.GotFocus
        Me.dtpApptDate.Focus()
    End Sub

    Private Sub dtpApptDate_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpApptDate.GotFocus
        Me.txtDate.Visible = False
        Me.txtDate.Text = Me.dtpApptDate.Value.ToString
    End Sub

    Private Sub dtpApptDate_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpApptDate.ValueChanged


        Me.txtDate.Text = Me.dtpApptDate.Value.ToString

    End Sub

    Private Sub dtpApptTime_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpApptTime.GotFocus
        Me.txtTime.Visible = False
        Me.txtTime.Text = Me.dtpApptTime.Value.ToString
    End Sub

    Private Sub dtpApptTime_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpApptTime.ValueChanged
        Me.txtTime.Text = Me.dtpApptTime.Value.ToString
    End Sub

    Private Sub txtTime_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTime.GotFocus
        Me.dtpApptTime.Focus()


    End Sub

    Private Sub SetAppt_V2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()

    End Sub
    Private Function Chk_Locked_Sales_Results()
        Try
            Dim lock As Boolean = False
            Dim cnx As New SqlConnection(STATIC_VARIABLES.Cnn)
            cnx.Open()
            Dim cmdGet As New SqlCommand("Select NeedsSaleResult from EnterLead where id = " & ID, cnx)
            lock = cmdGet.ExecuteScalar
            cnx.Close()
            cnx = Nothing
            Return lock
        Catch ex As Exception

            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "SetAppt_V2", "FormCode-PrivateClass", "Function", "Chk_Locked_Sales_Results()", "0", ex.Message.ToString)
            y = Nothing
        End Try
    End Function


    Private Sub SetAppt_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ID = STATIC_VARIABLES.CurrentID
        Dim lock As Boolean = Me.Chk_Locked_Sales_Results
        If lock = True Then
            MsgBox("This Record is locked pending a sales result!" & vbCr & "Cannot Set Appointment at this time!", MsgBoxStyle.Exclamation, "Pending Sales Result")
            Me.Dispose()
        End If
        If Me.ID = "" Then
            MsgBox("You must select a record to Set Appointment!", MsgBoxStyle.Exclamation, "No Record Selected")
            Me.Dispose()
        End If
        Try

            Select Case frm.Name
                Case Is = "Sales"
                    Me.chkConfirm.Visible = True
                    Me.Size = New System.Drawing.Size(413, 296)
                    Me.Contact1 = Sales.txtContact1.Text
                    Me.Contact2 = Sales.txtContact2.Text
                    Me.OrigApptDate = Sales.txtApptDate.Text
                    Me.OrigApptTime = Sales.txtApptTime.Text
                Case Is = "Confirming"
                    Contact1 = Confirming.txtContact1.Text
                    Contact2 = Confirming.txtContact2.Text
                    OrigApptDate = Confirming.txtApptDate.Text
                    OrigApptTime = Confirming.txtApptTime.Text
                Case Is = "WCaller"
                    Contact1 = WCaller.txtContact1.Text
                    Contact2 = WCaller.txtContact2.Text
                    OrigApptDate = WCaller.txtApptDate.Text
                    OrigApptTime = WCaller.txtApptTime.Text
                Case Is = "Recovery"
                    'Contact1 = Recovery.txtContact1.Text
                    'Contact2 = Recovery.txtContact2.Text
                    'OrigApptDate = Recovery.txtApptDate.Text
                    'OrigApptTime = Recovery.txtApptTime.Text
                Case Is = "Administration"
                    'Contact1 = Administration.txtContact1.Text
                    'Contact2 = Administration.txtContact2.Text
                    'OrigApptDate = Administration.txtApptDate.Text
                    'OrigApptTime = Administration.txtApptTime.Text
                Case Is = "Installation"
                    'Contact1 = Installation.txtContact1.Text
                    'Contact2 = Installation.txtContact2.Text
                    'OrigApptDate = Installation.txtApptDate.Text
                    'OrigApptTime = Installation.txtApptTime.Text
                Case Is = "ConfirmingSingleRecord"
                    Contact1 = ConfirmingSingleRecord.txtContact1.Text
                    Contact2 = ConfirmingSingleRecord.txtContact2.Text
                    OrigApptDate = ConfirmingSingleRecord.txtApptDate.Text
                    OrigApptTime = ConfirmingSingleRecord.txtApptTime.Text
                Case Is = "Finance"
                    'Contact1 = Finance.txtContact1.Text
                    'Contact2 = Finance.txtContact2.Text
                    'OrigApptDate = Finance.txtApptDate.Text
                    'OrigApptTime = Finance.txtApptTime.Text
                Case Is = "MarketingManager"
                    Contact1 = MarketingManager.txtContact1.Text
                    Contact2 = MarketingManager.txtContact2.Text
                    OrigApptDate = MarketingManager.txtApptDate.Text
                    OrigApptTime = MarketingManager.txtApptTime.Text
                Case Is = "PreviousCustomer"
                    'Contact1 = PreviousCustomer.txtContact1.Text
                    'Contact2 = PreviousCustomer.txtContact2.Text
                    'OrigApptDate = PreviousCustomer.txtApptDate.Text
                    'OrigApptTime = PreviousCustomer.txtApptTime.Text
                Case Is = "EditCustomerInfo"
                    Me.Contact1 = EditCustomerInfo.txtContact1.Text
                    Me.Contact2 = EditCustomerInfo.txtContact2.Text
                    Me.OrigApptDate = EditCustomerInfo.txtApptDate.Text
                    Me.OrigApptTime = EditCustomerInfo.txtApptTime.Text
            End Select

            


            Me.cboSpokeWith.Items.Clear()
            Dim s = Split(Contact1, " ")
            Dim s2 = Split(Contact2, " ")
            Me.cboSpokeWith.Items.Add(s(0))
            If Contact2 <> " " Then
                Me.cboSpokeWith.Items.Add(s2(0))
                Me.cboSpokeWith.Items.Add(s(0) & " & " & s2(0))
            Else
                Me.cboSpokeWith.Text = s(0)
            End If

            Me.btnsave.Focus()
            Dim DD As String = OrigApptDate
            Dim DT As String = OrigApptTime
            DT = "1/1/1900 " & DT
            Convert.ToDateTime(DD)
            Convert.ToDateTime(DT)
            Me.dtpApptDate.Value = DD
            Me.dtpApptTime.Value = DT
            Me.txtDate.Text = ""
            Me.txtDate.Visible = True

            Me.txtTime.Text = ""
            Me.txtTime.Visible = True
            Me.cboSpokeWith.Text = ""
            Me.cboautonotes.SelectedItem = Nothing


            Me.RichTextBox1.Text = ""

            Dim cnn = New SqlConnection(STATIC_VARIABLES.Cnn)
            Dim cmdget As SqlCommand = New SqlCommand("dbo.GetSetApptNotes", cnn)
            cmdget.CommandType = CommandType.StoredProcedure
            Dim r1 As SqlDataReader
            Me.cboautonotes.Items.Clear()
            Me.cboautonotes.Items.Add("<Add New>")
            Me.cboautonotes.Items.Add("___________________________________________________")

            cnn.Open()
            r1 = cmdget.ExecuteReader
            While r1.Read
                Me.cboautonotes.Items.Add(r1.Item(0))
            End While
            r1.Close()
            cnn.Close()

            If frm.Name = "ConfirmingSingleRecord" And ConfirmingSingleRecord.Lastbtn = "btnSales" Then
                frm = Sales
            End If

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "SendNotesSM", "FormCode", "Event", "SetAppt_Load", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub RichTextBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles RichTextBox1.GotFocus
        Me.Label1.Visible = False
    End Sub

    Private Sub RichTextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles RichTextBox1.LostFocus
        If Me.RichTextBox1.Text = "" Then
            Me.Label1.Visible = True
        End If
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Me.RichTextBox1.Focus()
    End Sub

    Private Sub cboSpokeWith_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSpokeWith.SelectedValueChanged
        If Me.cboSpokeWith.Text <> "" Then
            Me.lblSpokeWith.Text = Me.cboSpokeWith.Text
            Me.lblSpokeWith.ForeColor = Color.Black
            Me.lblSpokeWith.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        End If

    End Sub
    Private Function Check_For_DuplicateNote(ByVal Note As String)
        Try
            Dim cnt As Integer = 0
            Dim cnx As New SqlConnection(STATIC_VARIABLES.Cnn)
            cnx.Open()
            Dim cmdCNT As New SqlCommand("SELECT COUNT(ID) FROM SetApptNotes WHERE Notes = '" & Note & "';", cnx)
            cnt = cmdCNT.ExecuteScalar
            cnx.Close()
            cnx = Nothing
            Return cnt
        Catch ex As Exception

            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "SetAppt_V2", "FormCode-PrivateClass", "Function", "Check_For_Duplicate(note)", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Function


    Private Sub chkConfirm_CheckedChanged(sender As Object, e As EventArgs) Handles chkConfirm.CheckedChanged
        Me.Confirmed = Me.chkConfirm.CheckState
    End Sub



End Class
'#Region "Private Classes"

'Private Class GetINFOAutoNotes
'    Private Const pro_cnx As String = "SERVER=192.168.1.2;Database=Iss;User Id=sa;Password=spoken1;"
'    Private arAutoNotes As List(Of String)
'    Public ReadOnly Property List_Of_Auto_Notes As List(Of String)
'        Get
'            Return arAutoNotes
'        End Get
'    End Property
'    Public Sub New()
'        arAutoNotes = New List(Of String)
'        arAutoNotes = GetAutoNotes()
'    End Sub
'    Private Function GetAutoNotes()

'        Dim res As New List(Of String)
'        Try
'            Dim cnx As New SqlConnection(pro_cnx)
'            cnx.Open()
'            Dim cmdGET As New SqlCommand("SELECT notes FROM SetApptNotes;", cnx)
'            Dim r1 As SqlDataReader = cmdGET.ExecuteReader
'            While r1.Read
'                res.Add(r1.Item("notes"))
'            End While
'            r1.Close()
'            cnx.Close()
'            cnx = Nothing
'        Catch ex As Exception

'            Main.Cursor = Cursors.Default
'            Return res
'            Dim y As New ErrorLogging_V2
'            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "SendNotesSM", "FormCode-PrivateClass", "Function", "GetAuotNotes", "0", ex.Message.ToString)
'            y = Nothing
'        End Try
'        Return res
'    End Function
'End Class
'Private Class GetLeadInfo

'    Public Structure OriginalApptDateAndTime
'        Public ApptDate As String
'        Public ApptTime As String
'    End Structure

'    Public Structure AutoNoteInformation
'        Public DelayedInstall As Boolean
'        Public ExtendedNote As String
'    End Structure

'    Private Const pro_cnx As String = "SERVER=192.168.1.2;Database=Iss;User Id=sa;Password=spoken1;"
'    Private custNames As List(Of String)
'    Private aptDateAndTime As OriginalApptDateAndTime
'    Private ExtendInfo As AutoNoteInformation
'    Public ReadOnly Property List_Of_Names As List(Of String)
'        Get
'            Return custNames
'        End Get
'    End Property
'    Public ReadOnly Property Date_And_Time As OriginalApptDateAndTime
'        Get
'            Return aptDateAndTime
'        End Get
'    End Property
'    Public ReadOnly Property Extended_AutoNote_Info As AutoNoteInformation
'        Get
'            Return ExtendInfo
'        End Get
'    End Property
'    Public Sub New(ByVal recID As String)
'        custNames = New List(Of String)
'        custNames = Get_Customer_names(recID)
'        aptDateAndTime = New OriginalApptDateAndTime
'        aptDateAndTime = Get_Appointment_Date_And_Time(recID)
'        ExtendInfo = New AutoNoteInformation
'        ExtendInfo = Get_ExtendedAutoNote_Info(recID)
'    End Sub

'    Private Function Get_Customer_names(ByVal recID As String)
'        Try
'            Dim arNames As New List(Of String)
'            Dim cnx As New SqlConnection(pro_cnx)
'            cnx.Open()
'            Dim cmdGET As New SqlCommand("SELECT Contact1FirstName,Contact2FirstName from EnterLead WHERE ID = '" & recID & "';", cnx)
'            Dim r1 As SqlDataReader = cmdGET.ExecuteReader
'            While r1.Read
'                arNames.Add(r1.Item("Contact1FirstName"))
'                If r1.Item("Contact2FirstName") <> "" Then
'                    arNames.Add(r1.Item("Contact2FirstName"))
'                End If
'            End While
'            r1.Close()
'            cnx.Close()
'            cnx = Nothing
'            If arNames.Count > 1 Then
'                If Len(arNames(1).ToString) >= 2 Then
'                    arNames.Add(arNames(0).ToString & " & " & arNames(1).ToString)
'                End If
'            End If
'            Return arNames
'        Catch ex As Exception

'            Main.Cursor = Cursors.Default
'            Dim y As New ErrorLogging_V2
'            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "SendNotesSM", "FormCode-PrivateClass", "Function", "Get_Customer_Names(recID)", recID, ex.Message.ToString)
'            y = Nothing
'        End Try

'    End Function

'    Private Function Get_Appointment_Date_And_Time(ByVal RecID As String)
'        Try
'            Dim x As New OriginalApptDateAndTime
'            Dim cnx As New SqlConnection(pro_cnx)
'            Dim apt_Date As String = ""
'            Dim apt_Time As String = ""
'            cnx.Open()
'            Dim cmdGET As New SqlCommand("SELECT ApptDate,ApptTime from EnterLead WHERE ID = '" & RecID & "';", cnx)
'            Dim r1 As SqlDataReader = cmdGET.ExecuteReader
'            While r1.Read
'                apt_Date = r1.Item("ApptDate")
'                apt_Time = r1.Item("ApptTime")
'            End While
'            r1.Close()
'            cnx.Close()
'            cnx = Nothing

'            Dim d_Peices() = Split(apt_Date, " ", -1, Microsoft.VisualBasic.CompareMethod.Text)
'            x.ApptDate = d_Peices(0)

'            Dim t_pecies() = Split(apt_Time, " ", -1, Microsoft.VisualBasic.CompareMethod.Binary)
'            x.ApptTime = t_pecies(1)

'            Return x
'        Catch ex As Exception

'            Main.Cursor = Cursors.Default
'            Dim y As New ErrorLogging_V2
'            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "SendNotesSM", "FormCode-PrivateClass", "Function", "Get_Appointment_Date_And_Time(RecID)", RecID, ex.Message.ToString)
'            y = Nothing
'        End Try

'    End Function

'    Private Function Get_ExtendedAutoNote_Info(ByVal RecID)
'        Try
'            Dim a As New AutoNoteInformation
'            Dim cnx As New SqlConnection(pro_cnx)
'            cnx.Open()
'            Dim cmdGET As New SqlCommand("SELECT ExtendedNote,DelayedInstall FROM tblAutoNotesPerLead WHERE LeadNumber = '" & RecID & "';", cnx)
'            Dim r1 As SqlDataReader = cmdGET.ExecuteReader
'            While r1.Read
'                a.DelayedInstall = r1.Item("DelayedInstall")
'                a.ExtendedNote = r1.Item("ExtendedNote")
'            End While
'            r1.Close()
'            cnx.Close()
'            cnx = Nothing
'            Return a
'        Catch ex As Exception

'            Main.Cursor = Cursors.Default
'            Dim y As New ErrorLogging_V2
'            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "SendNotesSM", "FormCode-PrivateClass", "Function", "Get_ExtendedAutoNote_info(recid)", RecID, ex.Message.ToString)
'            y = Nothing
'        End Try

'    End Function

'End Class
'Private Class InsertNewAuotNote
'    Private Const pro_cnx As String = "SERVER=192.168.1.2;Database=Iss;User Id=sa;Password=spoken1;"

'    Public Sub New(ByVal Note As String)
'        Insert_Note(Note)
'    End Sub
'    Private Sub Insert_Note(ByVal Note As String)
'        Try
'            If Check_For_DuplicateNote(Note) >= 1 Then
'                MsgBox("There is already a note in the system with the title '" & Note.ToString & "'." & vbCrLf & "Please use a different auto note name.", MsgBoxStyle.Exclamation, "Same Note Exists")
'                Exit Sub
'            Else
'                '' insert the new note. 
'                Dim cnx As New SqlConnection(pro_cnx)
'                cnx.Open()
'                Dim cmdINS As New SqlCommand("INSERT SetApptNotes(Notes) values('" & Note & "');", cnx)
'                cmdINS.ExecuteScalar()
'                cnx.Close()
'                cnx = Nothing
'            End If
'        Catch ex As Exception

'            Main.Cursor = Cursors.Default
'            Dim y As New ErrorLogging_V2
'            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "SetAppt_V2", "FormCode-PrivateClass", "Function", "InsertNewAuotNote.InsertNote(note)", "0", ex.Message.ToString)
'            y = Nothing
'        End Try

'    End Sub
'    Private Function Check_For_DuplicateNote(ByVal Note As String)
'        Try
'            Dim cnt As Integer = 0
'            Dim cnx As New SqlConnection(pro_cnx)
'            cnx.Open()
'            Dim cmdCNT As New SqlCommand("SELECT COUNT(ID) FROM SetApptNotes WHERE Notes = '" & Note & "';", cnx)
'            cnt = cmdCNT.ExecuteScalar
'            cnx.Close()
'            cnx = Nothing
'            Return cnt
'        Catch ex As Exception

'            Main.Cursor = Cursors.Default
'            Dim y As New ErrorLogging_V2
'            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "SetAppt_V2", "FormCode-PrivateClass", "Function", "Check_For_Duplicate(note)", "0", ex.Message.ToString)
'            y = Nothing
'        End Try

'    End Function
'End Class
'Private Class SetMoveAppointment
'    Private Const pro_cnx As String = "SERVER=192.168.1.2;Database=Iss;User Id=sa;Password=spoken1;"

'    '' notes:
'    '' first determine if lead exists.
'    '' if it does , update it
'    '' if it does NOT, insert it.
'    '' two separate methods NOT on construction of class
'    '' 

'    Public Sub New(ByVal RecID As String, ByVal AutoNote As String, ByVal ExtendedNote As String, ByVal DelayedInstall As Boolean, ByVal DateLogged As DateTime, ByVal UserLogged As String)
'        '' 1) count num 'LeadNumbers' in tblAutoNotesPerLead with N'ID';
'        '' 2) if count >=1 => update it
'        ''    elseif count <=0 => insert it
'        '' 3) clean up. 
'        Dim cnt As Integer = Check_If_Exists_Alread(RecID)

'        Select Case cnt
'            Case Is >= 1
'                Update_ExtendedInfoLog(RecID, AutoNote, ExtendedNote, DelayedInstall, DateLogged, UserLogged)
'                Exit Select
'            Case Is <= 0
'                Insert_New_ExtendedInfo(RecID, AutoNote, ExtendedNote, DelayedInstall, DateLogged, UserLogged)
'                Exit Select
'            Case Else
'                Exit Select
'        End Select

'    End Sub
'    Private Function Check_If_Exists_Alread(ByVal RecID As String)
'        Try
'            Dim cnx As New SqlConnection(pro_cnx)
'            cnx.Open()
'            Dim cmdGET As New SqlCommand("SELECT COUNT(ID) FROM tblAutoNotesPerLead where LeadNumber = '" & RecID & "';", cnx)
'            Dim cnt As Integer = cmdGET.ExecuteScalar
'            cnx.Close()
'            cnx = Nothing
'            Return cnt
'        Catch ex As Exception

'            Main.Cursor = Cursors.Default
'            Dim y As New ErrorLogging_V2
'            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "SetAppt_V2", "FormCode-PrivateClass", "Function", "Check_IF_exists_Already(recID)", RecID, ex.Message.ToString)
'            y = Nothing
'        End Try

'    End Function

'    Private Sub Insert_New_ExtendedInfo(ByVal RecID As String, ByVal AutoNote As String, ByVal ExtendedNote As String, ByVal DelayedInstall As Boolean, ByVal DateLogged As DateTime, ByVal UserLogged As String)
'        Try
'            Dim cnx As New SqlConnection(pro_cnx)
'            cnx.Open()
'            Dim cmdINS As New SqlCommand("INSERT tblAutoNotesPerLead(LeadNumber,AutoNote,ExtendedNote,DelayedInstall,DateLogged,UserLogged) values('" & RecID & "','" & AutoNote & "','" & ExtendedNote & "','" & DelayedInstall & "','" & DateLogged & "','" & UserLogged & "');", cnx)
'            cmdINS.ExecuteScalar()
'            cnx.Close()
'            cnx = Nothing
'        Catch ex As Exception

'            Main.Cursor = Cursors.Default
'            Dim y As New ErrorLogging_V2
'            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "SetAppt_V2", "FormCode-PrivateClass", "Function", "Insert_New_ExtendedINfo(recid,autonote,extendednote,delayedinstall,datelogged,userlogged)", RecID, ex.Message.ToString)
'            y = Nothing
'        End Try

'    End Sub
'    Private Sub Update_ExtendedInfoLog(ByVal RecID As String, ByVal AutoNote As String, ByVal ExtendedNote As String, ByVal DelayedInstall As Boolean, ByVal DateLogged As DateTime, ByVal UserLogged As String)
'        Try
'            Dim cnx As New SqlConnection(pro_cnx)
'            cnx.Open()
'            '' yyyyMMdd Format for sql
'            '' 
'            Dim Year As Integer = 0
'            Dim month As Integer = 0
'            Dim day As Integer = 0

'            Dim hour As Integer = 0
'            Dim minute As Integer = 0
'            Dim second As Integer = 0
'            Dim milSecond As Integer = 0
'            hour = DateLogged.Hour
'            minute = DateLogged.Minute
'            second = DateLogged.Second
'            milSecond = 0

'            Year = DateLogged.Year
'            month = DateLogged.Month
'            Dim monthSTR As String = ""
'            If month < 10 Then
'                '' 01-09
'                monthSTR = ("0" & month.ToString)
'            Else
'                monthSTR = month.ToString
'            End If
'            day = DateLogged.Day

'            Dim strCorrected As String = ("'" & Year & "-" & monthSTR & "-" & day & " " & hour & ":" & minute & ":" & second & "." & milSecond & "'")

'            Dim strDelay As String = ""
'            If DelayedInstall = False Then
'                strDelay = "'0'"
'            Else
'                strDelay = "'1'"
'            End If

'            Dim cmdUP As New SqlCommand("UPDATE tblAutoNotesPerLead SET AutoNote = '" & AutoNote & "',ExtendedNote = '" & ExtendedNote & "',DelayedInstall = " & strDelay & ",DateLogged = " & strCorrected & ",UserLogged = '" & UserLogged & "' WHERE LeadNumber = '" & RecID & "';", cnx)
'            cmdUP.ExecuteScalar()
'            cnx.Close()
'            cnx = Nothing
'        Catch ex As Exception

'            Main.Cursor = Cursors.Default
'            Dim y As New ErrorLogging_V2
'            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "SetAppt_V2", "FormCode-PrivateClass", "Function", "Update_ExtendedInfoLog", RecID, ex.Message.ToString)
'            y = Nothing
'        End Try

'    End Sub

'End Class

'#End Region





