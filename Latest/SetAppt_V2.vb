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

    Public ID As String = "" '' ID to target leadhistory to / and pull Customer Names From
    Public CallingForm As String = "" '' name of form calling 'set appt' for log verbage
    Private OrigApptDate
    Private OrigApptTime
    Public frm As String = ""
    Public Confirmed As Boolean = False

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub SetAppt_V2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ResetForm()
    End Sub

    Private Sub SetAppt_V2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim y As New List(Of String)
        Dim z As New GetINFOAutoNotes '' private class
        frm = CallingForm
        y = z.List_Of_Auto_Notes
        Me.cboautonotes.Items.Clear()
        Me.cboautonotes.Items.Add("<Add New>")
        Me.cboautonotes.Items.Add("___________________________________________________")
        For Each x As String In y
            Me.cboautonotes.Items.Add(x.ToString)
        Next
        Me.cboSpokeWith.Items.Clear()
        Dim a As New GetLeadInfo(Me.ID)
        For Each b As String In a.List_Of_Names
            Me.cboSpokeWith.Items.Add(b)
        Next

        Me.txtTime.Text = a.Date_And_Time.ApptTime
        OrigApptDate = a.Date_And_Time.ApptDate
        Me.txtDate.Text = a.Date_And_Time.ApptDate
        OrigApptTime = a.Date_And_Time.ApptTime

        Dim g As GetLeadInfo.AutoNoteInformation
        g = a.Extended_AutoNote_Info


        Me.rtfNotes.Text = g.ExtendedNote
        If g.DelayedInstall = True Then
            Me.chkDelayInstall.CheckState = CheckState.Checked
        Else
            Me.chkDelayInstall.CheckState = CheckState.Unchecked
        End If

        Me.Text = "Set Appointment For - " & Me.ID.ToString

    End Sub

    Private Sub ResetForm()

        Me.ID = ""
        Me.CallingForm = ""
        Me.ErrorProvider1.Clear()

        Me.dtpApptDate.Text = ""
        Me.dtpApptTime.Text = ""

        Me.rtfNotes.Text = ""

        Me.cboSpokeWith.Items.Clear()
        Me.cboautonotes.Items.Clear()

        Me.lblSpokeWith.Visible = True
        Me.cboautonotes.Text = ""

        Me.lblautonotes.Visible = True
        Me.cboSpokeWith.Text = ""

        Me.chkDelayInstall.CheckState = CheckState.Unchecked

        Me.Text = "Set Appointment"

        Me.ErrorProvider1.Clear()

    End Sub

    Private Sub cboautonotes_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboautonotes.SelectedValueChanged
        Dim cbo As ComboBox = sender
        Dim strText As String = cbo.Text
        Select Case strText
            Case Is = "<Add New>"
                Dim nt As String = InputBox("Please enter the new note name.", "New Auto Note", "<New Note Name>")
                If Len(nt) > 0 Then
                    If nt <> " " Then
                        If nt <> "<New Note Name>" Then
                            Dim y As New InsertNewAuotNote(nt)
                            Me.cboautonotes.Items.Clear()
                            Dim a As New GetINFOAutoNotes
                            Me.cboautonotes.Items.Add("<Add New>")
                            Me.cboautonotes.Items.Add("___________________________________________________")
                            Dim idx As Integer = 0
                            For Each b As String In a.List_Of_Auto_Notes
                                Me.cboautonotes.Items.Add(b)
                                If b = nt Then
                                    idx = Me.cboautonotes.Items.IndexOf(b)
                                End If
                            Next
                            Me.cboautonotes.SelectedIndex = idx
                        ElseIf nt = "<New Note Name>" Then
                            MsgBox("You can't enter ' <New Note Name> ' as a new note.", MsgBoxStyle.Exclamation, "Error Entering New Note")
                            Exit Sub
                        End If
                    Else
                        MsgBox("Can't enter a blank note.", MsgBoxStyle.Exclamation, "Error Entering New Note")
                        Exit Sub
                    End If
                End If
                Exit Select
            Case Else
                Exit Select
        End Select
    End Sub

    Private Sub cboautonotes_TextChanged(sender As Object, e As EventArgs) Handles cboautonotes.TextChanged
        If Len(Me.cboautonotes.Text) >= 1 Then
            Me.lblautonotes.Visible = False
            Me.rtfNotes.Text += (Me.cboautonotes.Text & vbCrLf)
        Else
            Me.lblautonotes.Visible = True
        End If
    End Sub

    Private Sub cboSpokeWith_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboSpokeWith.SelectedValueChanged

        If Len(Me.cboSpokeWith.Text) >= 1 Then
            Me.lblSpokeWith.Visible = False
        Else
            Me.lblSpokeWith.Visible = True
            Me.lblSpokeWith.Text = Me.cboSpokeWith.Text
            Me.lblSpokeWith.ForeColor = Color.Black
            Me.lblSpokeWith.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        End If
    End Sub

    Private Sub dtpApptDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpApptDate.ValueChanged
        Dim dtp As DateTimePicker = sender
        If Len(Me.txtDate.Text) > 0 Then
            If Me.txtDate.Text <> " " Then
                If InStr(Me.txtDate.Text, "/", Microsoft.VisualBasic.CompareMethod.Text) <= 0 Then
                    Me.txtDate.Text = Date.Today.ToShortDateString
                Else
                    If dtp.Value <> Me.txtDate.Text Then
                        If dtp.Value > Date.Today.ToShortDateString Then
                            Me.txtDate.Text = dtp.Value.ToShortDateString
                        End If
                    End If
                End If
            ElseIf Len(Me.txtDate.Text) <= 0 Then
                Me.txtDate.Text = Date.Today.ToShortDateString
            End If
        End If
    End Sub

    Private Sub txtDate_LostFocus(sender As Object, e As EventArgs) Handles txtDate.LostFocus
        If Me.txtDate.Text = "" Then
            Me.txtDate.Text = Date.Today.ToShortDateString
        End If
        If Me.txtDate.Text = " " Then
            Me.txtDate.Text = Date.Today.ToShortDateString
        End If
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If Me.dtpApptDate.Value < Today And Me.txtDate.Visible = False Then

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






            'If Me.txtDate.Text = "" Then

            '    Me.txtDate.Text = OrigApptDate
            'End If
            'If Me.txtTime.Text = "" Then
            '    Me.txtTime.Text = OrigApptTime
            'End If

            'Dim s = Split(Me.txtDate.Text, " ")
            Dim dt = Me.txtDate.Text & " 12:00:00 AM"
            'Dim s2 = Split(Me.txtTime.Text, " ")
            Dim tm

            Try
                tm = "1/1/1900 " & Me.txtTime.Text

            Catch ex As Exception
                tm = "1/1/1900 " & Me.txtTime.Text
            End Try

            If frm = "WCaller" Then
                Description = "Appt. Set from Warm Calling by " & STATIC_VARIABLES.CurrentUser & ", set up with " & Me.cboSpokeWith.Text & " for " & day & ", " & CDate(dt).ToShortDateString & " at " & CDate(tm).ToShortTimeString & "."
            ElseIf frm = "ConfirmingSingleRecord" Then
                Description = "Appt. Set by " & STATIC_VARIABLES.CurrentUser & ", set up with " & Me.cboSpokeWith.Text & " for " & day & ", " & CDate(dt).ToShortDateString & " at " & CDate(tm).ToShortTimeString & "."
            ElseIf frm = "Sales" Then
                If Me.Confirmed = True Then
                    Description = "Appt. Set from Sales Department by " & STATIC_VARIABLES.CurrentUser & ", set up with " & Me.cboSpokeWith.Text & " for " & day & ", " & CDate(dt).ToShortDateString & " at " & CDate(tm).ToShortTimeString & ". Confirmed by " & STATIC_VARIABLES.CurrentUser & ". (Confirming Bypassed)"
                Else
                    Description = "Appt. Set from Sales Department by " & STATIC_VARIABLES.CurrentUser & ", set up with " & Me.cboSpokeWith.Text & " for " & day & ", " & CDate(dt).ToShortDateString & " at " & CDate(tm).ToShortTimeString & "."
                End If
            ElseIf frm = "Recovery" Then
                Description = "Appt. Set from Recovery by " & STATIC_VARIABLES.CurrentUser & ", set up with " & Me.cboSpokeWith.Text & " for " & day & ", " & CDate(dt).ToShortDateString & " at " & CDate(tm).ToShortTimeString & "."
            ElseIf frm = "PreviousCustomer" Then
                Description = "Appt. Set from Previous Customer by " & STATIC_VARIABLES.CurrentUser & ", set up with " & Me.cboSpokeWith.Text & " for " & day & ", " & CDate(dt).ToShortDateString & " at " & CDate(tm).ToShortTimeString & "."
            ElseIf frm = "Finance" Then
                Description = "Appt. Set from Financing by " & STATIC_VARIABLES.CurrentUser & ", set up with " & Me.cboSpokeWith.Text & " for " & day & ", " & CDate(dt).ToShortDateString & " at " & CDate(tm).ToShortTimeString & "."
            ElseIf frm = "Installation" Then
                Description = "Appt. Set from Installation Department by " & STATIC_VARIABLES.CurrentUser & ", set up with " & Me.cboSpokeWith.Text & " for " & day & ", " & CDate(dt).ToShortDateString & " at " & CDate(tm).ToShortTimeString & "."
            ElseIf frm = "MarketingManager" Then
                If Me.Confirmed = True Then
                    Description = "Appt. Set from Marketing Manager by " & STATIC_VARIABLES.CurrentUser & ", set up with " & Me.cboSpokeWith.Text & " for " & day & ", " & CDate(dt).ToShortDateString & " at " & CDate(tm).ToShortTimeString & ". Confirmed by " & STATIC_VARIABLES.CurrentUser & ". (Confirming Bypassed)"
                Else
                    Description = "Appt. Set from Marketing Manager by " & STATIC_VARIABLES.CurrentUser & ", set up with " & Me.cboSpokeWith.Text & " for " & day & ", " & CDate(dt).ToShortDateString & " at " & CDate(tm).ToShortTimeString & "."
                End If
            ElseIf frm = "Administration" Then
                If Me.Confirmed = True Then
                    Description = "Appt. Set from Administration by " & STATIC_VARIABLES.CurrentUser & ", set up with " & Me.cboSpokeWith.Text & " for " & day & ", " & CDate(dt).ToShortDateString & " at " & CDate(tm).ToShortTimeString & ". Confirmed by " & STATIC_VARIABLES.CurrentUser & ". (Confirming Bypassed)"
                Else
                    Description = "Appt. Set from Administration by " & STATIC_VARIABLES.CurrentUser & ", set up with " & Me.cboSpokeWith.Text & " for " & day & ", " & CDate(dt).ToShortDateString & " at " & CDate(tm).ToShortTimeString & "."
                End If
            ElseIf frm = "Confirming" Then
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
            Dim param7 As SqlParameter = New SqlParameter("@Notes", Me.rtfNotes.Text)
            Dim param8 As SqlParameter = New SqlParameter("@Manager", STATIC_VARIABLES.CurrentManager)
            Dim param9 As SqlParameter = New SqlParameter("@Confirmed", Me.Confirmed)
            Dim param10 As SqlParameter = New SqlParameter("@Form", CallingForm)

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


            '' now send off to 'set / move appt log 
            '' support for delayed install, moving set appts
            '' 1-11-2015 revised  AC 
            Dim b As New SetMoveAppointment(ID, Me.cboautonotes.Text, Me.rtfNotes.Text, Me.chkDelayInstall.CheckState, Date.Now, STATIC_VARIABLES.CurrentUser)
            b = Nothing
            ''
            '' refresh customer history for selected item
            '' 
            For Each bb As ListViewItem In Sales.lvSales.Items
                If bb.Selected = True Then
                    Dim c As New CustomerHistory()
                    c.SetUp(Sales, ID, Sales.TScboCustomerHistory)
                End If
            Next


            Me.Close()
            Me.Dispose()
        End If
        Select Case frm
            Case "WCaller"
                If WCaller.Tab = "WC" Then
                    Dim i As Integer = WCaller.lvWarmCalling.Items.IndexOfKey(WCaller.lvWarmCalling.SelectedItems(0).Text)
                    WCaller.lvWarmCalling.SelectedItems(0).Remove()
                    WCaller.txtRecordsMatching.Text = CStr(CInt(WCaller.txtRecordsMatching.Text) - 1)
                    If WCaller.lvWarmCalling.Items.Count <> 0 Then
                        If i > WCaller.lvWarmCalling.Items.Count - 1 Then
                            WCaller.lvWarmCalling.Items(i - 1).Selected = True
                        Else
                            WCaller.lvWarmCalling.Items(i).Selected = True
                        End If
                    Else
                        Dim wc As New WarmCalling
                        wc.PullCustomerINFO("")
                    End If
                    Dim c As New WarmCalling.MyApptsTab.Populate(WCaller.cboFilter.Text)
                ElseIf WCaller.Tab = "MA" Then
                    Dim c As New WarmCalling.MyApptsTab.Populate(WCaller.cboFilter.Text)
                    Dim y As New WarmCalling
                    y.Populate()
                    WCaller.SuspendLayout()
                End If
            Case "Confirming"

                Dim c As New ConfirmingData
                c.PullCustomerINFO(Confirming.Tab, ID)
            Case "Installation"
            Case "Sales"
            Case "ConfirmerSingleRecord"
                Dim c As New CustomerHistory
                Dim g As Form = Sales
                c.SetUp(g, ID, ConfirmingSingleRecord.TScboCustomerHistory)
            Case "Administration"
                ''comeback
            Case "Finance"
                'comeback
            Case "Recovery"
                'comeback
            Case "PreviousCustomer"
                'comeback
            Case "ColdCalling"
                'comeback
            Case "SecondSource"
                'comeback
        End Select




    End Sub

#Region "Private Classes"

    Private Class GetINFOAutoNotes
        Private Const pro_cnx As String = "SERVER=192.168.1.2;Database=Iss;User Id=sa;Password=spoken1;"
        Private arAutoNotes As List(Of String)
        Public ReadOnly Property List_Of_Auto_Notes As List(Of String)
            Get
                Return arAutoNotes
            End Get
        End Property
        Public Sub New()
            arAutoNotes = New List(Of String)
            arAutoNotes = GetAutoNotes()
        End Sub
        Private Function GetAutoNotes()
            Dim res As New List(Of String)
            Try
                Dim cnx As New SqlConnection(pro_cnx)
                cnx.Open()
                Dim cmdGET As New SqlCommand("SELECT notes FROM SetApptNotes;", cnx)
                Dim r1 As SqlDataReader = cmdGET.ExecuteReader
                While r1.Read
                    res.Add(r1.Item("notes"))
                End While
                r1.Close()
                cnx.Close()
                cnx = Nothing
            Catch ex As Exception
                Return res
            End Try
            Return res
        End Function
    End Class
    Private Class GetLeadInfo

        Public Structure OriginalApptDateAndTime
            Public ApptDate As String
            Public ApptTime As String
        End Structure

        Public Structure AutoNoteInformation
            Public DelayedInstall As Boolean
            Public ExtendedNote As String
        End Structure

        Private Const pro_cnx As String = "SERVER=192.168.1.2;Database=Iss;User Id=sa;Password=spoken1;"
        Private custNames As List(Of String)
        Private aptDateAndTime As OriginalApptDateAndTime
        Private ExtendInfo As AutoNoteInformation
        Public ReadOnly Property List_Of_Names As List(Of String)
            Get
                Return custNames
            End Get
        End Property
        Public ReadOnly Property Date_And_Time As OriginalApptDateAndTime
            Get
                Return aptDateAndTime
            End Get
        End Property
        Public ReadOnly Property Extended_AutoNote_Info As AutoNoteInformation
            Get
                Return ExtendInfo
            End Get
        End Property
        Public Sub New(ByVal recID As String)
            custNames = New List(Of String)
            custNames = Get_Customer_names(recID)
            aptDateAndTime = New OriginalApptDateAndTime
            aptDateAndTime = Get_Appointment_Date_And_Time(recID)
            ExtendInfo = New AutoNoteInformation
            ExtendInfo = Get_ExtendedAutoNote_Info(recID)
        End Sub

        Private Function Get_Customer_names(ByVal recID As String)
            Dim arNames As New List(Of String)
            Dim cnx As New SqlConnection(pro_cnx)
            cnx.Open()
            Dim cmdGET As New SqlCommand("SELECT Contact1FirstName,Contact2FirstName from EnterLead WHERE ID = '" & recID & "';", cnx)
            Dim r1 As SqlDataReader = cmdGET.ExecuteReader
            While r1.Read
                arNames.Add(r1.Item("Contact1FirstName"))
                If r1.Item("Contact2FirstName") <> "" Then
                    arNames.Add(r1.Item("Contact2FirstName"))
                End If
            End While
            r1.Close()
            cnx.Close()
            cnx = Nothing
            If arNames.Count > 1 Then
                If Len(arNames(1).ToString) >= 2 Then
                    arNames.Add(arNames(0).ToString & " & " & arNames(1).ToString)
                End If
            End If
            Return arNames
        End Function

        Private Function Get_Appointment_Date_And_Time(ByVal RecID As String)
            Dim x As New OriginalApptDateAndTime
            Dim cnx As New SqlConnection(pro_cnx)
            Dim apt_Date As String = ""
            Dim apt_Time As String = ""
            cnx.Open()
            Dim cmdGET As New SqlCommand("SELECT ApptDate,ApptTime from EnterLead WHERE ID = '" & RecID & "';", cnx)
            Dim r1 As SqlDataReader = cmdGET.ExecuteReader
            While r1.Read
                apt_Date = r1.Item("ApptDate")
                apt_Time = r1.Item("ApptTime")
            End While
            r1.Close()
            cnx.Close()
            cnx = Nothing

            Dim d_Peices() = Split(apt_Date, " ", -1, Microsoft.VisualBasic.CompareMethod.Text)
            x.ApptDate = d_Peices(0)

            Dim t_pecies() = Split(apt_Time, " ", -1, Microsoft.VisualBasic.CompareMethod.Binary)
            x.ApptTime = t_pecies(1)

            Return x
        End Function

        Private Function Get_ExtendedAutoNote_Info(ByVal RecID)
            Dim a As New AutoNoteInformation
            Dim cnx As New SqlConnection(pro_cnx)
            cnx.Open()
            Dim cmdGET As New SqlCommand("SELECT ExtendedNote,DelayedInstall FROM tblAutoNotesPerLead WHERE LeadNumber = '" & RecID & "';", cnx)
            Dim r1 As SqlDataReader = cmdGET.ExecuteReader
            While r1.Read
                a.DelayedInstall = r1.Item("DelayedInstall")
                a.ExtendedNote = r1.Item("ExtendedNote")
            End While
            r1.Close()
            cnx.Close()
            cnx = Nothing
            Return a
        End Function

    End Class
    Private Class InsertNewAuotNote
        Private Const pro_cnx As String = "SERVER=192.168.1.2;Database=Iss;User Id=sa;Password=spoken1;"

        Public Sub New(ByVal Note As String)
            Insert_Note(Note)
        End Sub
        Private Sub Insert_Note(ByVal Note As String)
            If Check_For_DuplicateNote(Note) >= 1 Then
                MsgBox("There is already a note in the system with the title '" & Note.ToString & "'." & vbCrLf & "Please use a different auto note name.", MsgBoxStyle.Exclamation, "Same Note Exists")
                Exit Sub
            Else
                '' insert the new note. 
                Dim cnx As New SqlConnection(pro_cnx)
                cnx.Open()
                Dim cmdINS As New SqlCommand("INSERT SetApptNotes(Notes) values('" & Note & "');", cnx)
                cmdINS.ExecuteScalar()
                cnx.Close()
                cnx = Nothing
            End If
        End Sub
        Private Function Check_For_DuplicateNote(ByVal Note As String)
            Dim cnt As Integer = 0
            Dim cnx As New SqlConnection(pro_cnx)
            cnx.Open()
            Dim cmdCNT As New SqlCommand("SELECT COUNT(ID) FROM SetApptNotes WHERE Notes = '" & Note & "';", cnx)
            cnt = cmdCNT.ExecuteScalar
            cnx.Close()
            cnx = Nothing
            Return cnt
        End Function
    End Class
    Private Class SetMoveAppointment
        Private Const pro_cnx As String = "SERVER=192.168.1.2;Database=Iss;User Id=sa;Password=spoken1;"

        '' notes:
        '' first determine if lead exists.
        '' if it does , update it
        '' if it does NOT, insert it.
        '' two separate methods NOT on construction of class
        '' 

        Public Sub New(ByVal RecID As String, ByVal AutoNote As String, ByVal ExtendedNote As String, ByVal DelayedInstall As Boolean, ByVal DateLogged As DateTime, ByVal UserLogged As String)
            '' 1) count num 'LeadNumbers' in tblAutoNotesPerLead with N'ID';
            '' 2) if count >=1 => update it
            ''    elseif count <=0 => insert it
            '' 3) clean up. 
            Dim cnt As Integer = Check_If_Exists_Alread(RecID)

            Select Case cnt
                Case Is >= 1
                    Update_ExtendedInfoLog(RecID, AutoNote, ExtendedNote, DelayedInstall, DateLogged, UserLogged)
                    Exit Select
                Case Is <= 0
                    Insert_New_ExtendedInfo(RecID, AutoNote, ExtendedNote, DelayedInstall, DateLogged, UserLogged)
                    Exit Select
                Case Else
                    Exit Select
            End Select

        End Sub
        Private Function Check_If_Exists_Alread(ByVal RecID As String)
            Dim cnx As New SqlConnection(pro_cnx)
            cnx.Open()
            Dim cmdGET As New SqlCommand("SELECT COUNT(ID) FROM tblAutoNotesPerLead where LeadNumber = '" & RecID & "';", cnx)
            Dim cnt As Integer = cmdGET.ExecuteScalar
            cnx.Close()
            cnx = Nothing
            Return cnt
        End Function

        Private Sub Insert_New_ExtendedInfo(ByVal RecID As String, ByVal AutoNote As String, ByVal ExtendedNote As String, ByVal DelayedInstall As Boolean, ByVal DateLogged As DateTime, ByVal UserLogged As String)
            Dim cnx As New SqlConnection(pro_cnx)
            cnx.Open()
            Dim cmdINS As New SqlCommand("INSERT tblAutoNotesPerLead(LeadNumber,AutoNote,ExtendedNote,DelayedInstall,DateLogged,UserLogged) values('" & RecID & "','" & AutoNote & "','" & ExtendedNote & "','" & DelayedInstall & "','" & DateLogged & "','" & UserLogged & "');", cnx)
            cmdINS.ExecuteScalar()
            cnx.Close()
            cnx = Nothing
        End Sub
        Private Sub Update_ExtendedInfoLog(ByVal RecID As String, ByVal AutoNote As String, ByVal ExtendedNote As String, ByVal DelayedInstall As Boolean, ByVal DateLogged As DateTime, ByVal UserLogged As String)
            Dim cnx As New SqlConnection(pro_cnx)
            cnx.Open()
            '' yyyyMMdd Format for sql
            '' 
            Dim Year As Integer = 0
            Dim month As Integer = 0
            Dim day As Integer = 0

            Dim hour As Integer = 0
            Dim minute As Integer = 0
            Dim second As Integer = 0
            Dim milSecond As Integer = 0
            hour = DateLogged.Hour
            minute = DateLogged.Minute
            second = DateLogged.Second
            milSecond = 0

            Year = DateLogged.Year
            month = DateLogged.Month
            Dim monthSTR As String = ""
            If month < 10 Then
                '' 01-09
                monthSTR = ("0" & month.ToString)
            Else
                monthSTR = month.ToString
            End If
            day = DateLogged.Day

            Dim strCorrected As String = ("'" & Year & "-" & monthSTR & "-" & day & " " & hour & ":" & minute & ":" & second & "." & milSecond & "'")

            Dim strDelay As String = ""
            If DelayedInstall = False Then
                strDelay = "'0'"
            Else
                strDelay = "'1'"
            End If

            Dim cmdUP As New SqlCommand("UPDATE tblAutoNotesPerLead SET AutoNote = '" & AutoNote & "',ExtendedNote = '" & ExtendedNote & "',DelayedInstall = " & strDelay & ",DateLogged = " & strCorrected & ",UserLogged = '" & UserLogged & "' WHERE LeadNumber = '" & RecID & "';", cnx)
            cmdUP.ExecuteScalar()
            cnx.Close()
            cnx = Nothing
        End Sub

    End Class

#End Region



End Class

