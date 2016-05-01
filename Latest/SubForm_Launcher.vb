Public Class SubForm_Launcher
    Dim Calling_Form As Form
    Dim SubFrm As Form
    Dim Contact1 As String
    Dim Contact2 As String
    Dim OrigApptTime As String
    Dim OrigApptDate As String
    Dim Id As String = STATIC_VARIABLES.CurrentID
    Dim btn As Object


    Public Sub New(ByVal sender As Object)
        Try
            STATIC_VARIABLES.Update = False
            Select Case sender.GetType.ToString
                Case Is = "System.Windows.Forms.ToolStripMenuItem", "System.Windows.Forms.ToolStripSplitButton", "System.Windows.Forms.ToolStripButton" _
                    , "System.Windows.Forms.ToolStripDropDown", "System.Windows.Forms.ToolStripDropDownButton"
                    Calling_Form = Get_Parent_Form(sender)
                    btn = sender
                Case Is = "System.Windows.Forms.Button"
                    Dim ctrl As Button = sender
                    Calling_Form = ctrl.FindForm
                    btn = ctrl
            End Select

            Select Case btn.name
                Case Is = "btnSetAppt", "btnSetAppt2"
                    SubFrm = SetAppt_V2
                Case Is = "btnMoveAppt"
                    SubFrm = RescheduleAppt
                Case Is = "btnKill"
                    SubFrm = Kill
                Case Is = "btnEditCustomer", "btnEditCustIssue", "btnEditCust2"
                    SubFrm = EditCustomerInfo
                Case Is = "SalesResult"
                    SubFrm = Reissue
                Case Is = "btnEditSPI", "btnUpdateSPI"
                    SubFrm = frmEditSpecialInstructions
                Case Is = "btnEditScheduledTask", "tsbschedule"
                    SubFrm = ScheduleAction
                Case Is = "btnCandC", "btnCCIssue"
                    SubFrm = CandCNotes
                Case Is = "btnCNGApptTime"
                    SubFrm = CNGApptTime
                Case Is = "btnSalesResult", "btnSalesResult2"
                    SubFrm = SDResult
                Case Is = "btnLogCall"
                    SubFrm = LogPhoneCall
                Case Is = "tsbattach"
                    SubFrm = AttachAFile
                Case Is = "tsImportsPics"
                    SubFrm = ImportPictures
            End Select
            Set_Up_SubForm()
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "SubForm_Launcher", "Class", "Sub", "New", Calling_Form.Name & " - " & Id, ex.Message.ToString)
            y = Nothing
        End Try

    End Sub
    Function Get_Parent_Form(ByVal sender As Object)
        Try
            Dim x As Form
            Dim b As Boolean = False
            Dim ctrl As Object = sender.GetCurrentParent
            Do
                Select Case ctrl.GetType.ToString
                    Case Is = "System.Windows.Forms.ToolStripMenuItem", "System.Windows.Forms.ToolStripSplitButton", "System.Windows.Forms.ToolStripButton"
                        ctrl = ctrl.getcurrentparent
                    Case Is = "System.Windows.Forms.ToolStripDropDown", "System.Windows.Forms.ToolStripDropDownButton", "System.Windows.Forms.ToolStripDropDownMenu"
                        Dim q = ctrl.owneritem
                        ctrl = q.getcurrentparent
                    Case Is = "System.Windows.Forms.ToolStrip"
                        Dim q As ToolStrip = ctrl
                        x = q.FindForm
                        b = True
                End Select
            Loop Until b = True
            Return x
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "SubForm_Launcher", "Class", "Function", "Get_Parent_Form", Id, ex.Message.ToString)
            y = Nothing
        End Try

    End Function
    Private Sub Set_Up_SubForm()
        Try
            Select Case SubFrm.Name
                Case Is = "CandCNotes"
                    CandCNotes.frm = Calling_Form
                    CandCNotes.ShowDialog()
                    If STATIC_VARIABLES.Update = True Then
                        Called_and_Cancelled(Calling_Form)
                    End If
                Case Is = "SetAppt_V2"
                    If Calling_Form.Name = "ConfirmingSingleRecord" And ConfirmingSingleRecord.Lastbtn = "btnSales" Then
                        SetAppt_V2.chkConfirm.Visible = True
                        SetAppt_V2.Size = New System.Drawing.Size(413, 296)
                    End If
                    SetAppt_V2.frm = Calling_Form
                    SetAppt_V2.ShowDialog()
                    If STATIC_VARIABLES.Update = True Then
                        Set_Appt(Calling_Form)
                    End If
                Case Is = "RescheduleAppt"
                    RescheduleAppt.frm = Calling_Form
                    RescheduleAppt.ShowDialog()
                    If STATIC_VARIABLES.Update = True Then
                        ReSchedule_Appt(Calling_Form)
                    End If
                Case Is = "Kill"
                    Kill.frm = Calling_Form
                    Kill.ShowDialog()
                    If STATIC_VARIABLES.Update = True Then
                        Kill_Appt(Calling_Form)
                    End If
                Case Is = "EditCustomerInfo"
                    EditCustomerInfo.Show()
                Case Is = "Reissue"
                    Reissue.frm = Calling_Form
                    Reissue.ShowDialog()
                    If STATIC_VARIABLES.Update = True Then
                        ReIssue_Appt(Calling_Form)
                    End If
                Case Is = "frmEditSpecialInstructions"
                    frmEditSpecialInstructions.frm = Calling_Form
                    frmEditSpecialInstructions.ShowDialog()
                Case Is = "ScheduleAction"
                    ''Revisit
                    If btn.name = "btnEditScheduledTask" Then
                        Edit_Scheduled_Action()
                    End If
                    ScheduleAction.ShowDialog()
                    If STATIC_VARIABLES.Update = True Then
                        Schedule_Action(Calling_Form)
                    End If

                Case Is = "LogPhoneCall"
                    LogPhoneCall.frm = Calling_Form
                    LogPhoneCall.ShowDialog()
                    If STATIC_VARIABLES.Update = True Then
                        Log_Phone_Call(Calling_Form)
                    End If
                Case Is = "CNGApptTime"
                    CNGApptTime.Frm = Calling_Form
                    CNGApptTime.ShowDialog()
                    If STATIC_VARIABLES.Update = True Then
                        Change_Appt_Time(Calling_Form)
                    End If
                Case Is = "SDResult"
                    SDResult.Frm = Calling_Form
                    SDResult.ShowDialog()
                    If STATIC_VARIABLES.Update = True Then
                        Sales_Result(Calling_Form)
                    End If
                Case Is = "AttachAFile"
                    AttachAFile.ShowDialog()
                    If STATIC_VARIABLES.Update = True Then
                        Attach_File()
                    End If
                Case Is = "ImportPictures"
                    ImportPictures.ShowDialog()
                    If STATIC_VARIABLES.Update = True Then
                        Pictures()
                    End If
            End Select
            STATIC_VARIABLES.Update = False
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "SubForm_Launcher", "Class", "Sub", "Set_Up_SubForm", Calling_Form.Name & " - " & Id, ex.Message.ToString)
            y = Nothing
        End Try

    End Sub
    Private Sub Edit_Scheduled_Action()
        Try
            Select Case Calling_Form.Name
                Case Is = "Sales"
                    Dim c As Integer = Sales.pnlScheduledTasks.Controls.Count
                    Dim i As Integer
                    For i = 1 To c
                        Dim all As Panel = Sales.pnlScheduledTasks.Controls(i - 1)
                        If all.BorderStyle = BorderStyle.FixedSingle Then
                            ScheduleAction.EditId = all.Name.ToString.Substring(3)
                        End If
                    Next
                Case Is = "Administration"
                    Dim c As Integer = Administration.pnlScheduledTasks.Controls.Count
                    Dim i As Integer
                    For i = 1 To c
                        Dim all As Panel = Administration.pnlScheduledTasks.Controls(i - 1)
                        If all.BorderStyle = BorderStyle.FixedSingle Then
                            ScheduleAction.EditId = all.Name.ToString.Substring(3)
                        End If
                    Next
                Case Is = "Installation"
                    Dim c As Integer = Installation.pnlScheduledTasks.Controls.Count
                    Dim i As Integer
                    For i = 1 To c
                        Dim all As Panel = Installation.pnlScheduledTasks.Controls(i - 1)
                        If all.BorderStyle = BorderStyle.FixedSingle Then
                            ScheduleAction.EditId = all.Name.ToString.Substring(3)
                        End If
                    Next
                Case Is = "Finance"
                    Dim c As Integer = Finance.pnlScheduledTasks.Controls.Count
                    Dim i As Integer
                    For i = 1 To c
                        Dim all As Panel = Finance.pnlScheduledTasks.Controls(i - 1)
                        If all.BorderStyle = BorderStyle.FixedSingle Then
                            ScheduleAction.EditId = all.Name.ToString.Substring(3)
                        End If
                    Next
                Case Is = "MarketingManager"
                    Dim c As Integer = MarketingManager.pnlScheduledTasks.Controls.Count
                    Dim i As Integer
                    For i = 1 To c
                        Dim all As Panel = MarketingManager.pnlScheduledTasks.Controls(i - 1)
                        If all.BorderStyle = BorderStyle.FixedSingle Then
                            ScheduleAction.EditId = all.Name.ToString.Substring(3)
                        End If
                    Next
            End Select
            ScheduleAction.edit = True
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "SubForm_Launcher", "Class", "Sub", "Edit_Scheduled_Action", Calling_Form.Name & " - " & Id, ex.Message.ToString)
            y = Nothing
        End Try

    End Sub
    Private Sub Pictures()
        Try
            Dim count As Integer = Main.MdiChildren.Length
            For i As Integer = 0 To count - 1
                Dim f As Form = Main.MdiChildren(i)
                If f Is STATIC_VARIABLES.ActiveChild Then
                    Select Case f.Name
                        Case "Sales"
                            If Sales.tbMain.SelectedIndex = 1 And Sales.Text.Contains(STATIC_VARIABLES.CurrentID) _
                                And Sales.pnlAFPics.Visible = True Then
                                Sales.btnRefreshJP_Click(Sales.btnRefreshJP, Nothing)
                            End If
                        Case "Administration"
                            ''Add Cases as Forms Complete 
                        Case "MarketingManager"
                            'If MarketingManager.tbMain.SelectedIndex = 1 And MarketingManager.Text.Contains(STATIC_VARIABLES.CurrentID) And MarketingManager.pnlAFPics.Visible = True Then
                            '    MarketingManager.btnRefreshJP_Click(Sales.btnRefreshJP, Nothing)
                            'End If
                        Case "Finance"
                            ''Add Cases as Forms Complete 
                        Case "Installation"
                            ''Add Cases as Forms Complete 
                    End Select

                End If

            Next
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "SubForm_Launcher", "Class", "Sub", "Pictures", Calling_Form.Name & " - " & Id, ex.Message.ToString)
            y = Nothing
        End Try

    End Sub
    Private Sub Attach_File()
        Try
            Dim count As Integer = Main.MdiChildren.Length
            For i As Integer = 0 To count - 1
                Dim f As Form = Main.MdiChildren(i)
                If f Is STATIC_VARIABLES.ActiveChild Then
                    Select Case f.Name
                        Case "Sales"
                            If Sales.tbMain.SelectedIndex = 1 And Sales.Text.Contains(STATIC_VARIABLES.CurrentID) And Sales.pnlAFPics.Visible = True Then
                                Sales.btnRefresh_Click(Sales.btnRefresh, Nothing)
                            End If
                        Case "Administration"
                            ''Add Cases as Forms Complete 
                        Case "MarketingManager"
                            'If MarketingManager.tbMain.SelectedIndex = 1 And MarketingManager.Text.Contains(STATIC_VARIABLES.CurrentID) And MarketingManager.pnlAFPics.Visible = True Then
                            '    MarketingManager.btnRefresh_Click(Sales.btnRefresh, Nothing)
                            'End If
                        Case "Finance"
                            ''Add Cases as Forms Complete 
                        Case "Installation"
                            ''Add Cases as Forms Complete 
                    End Select

                End If

            Next
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "SubForm_Launcher", "Class", "Sub", "Attach_File", Calling_Form.Name & " - " & Id, ex.Message.ToString)
            y = Nothing
        End Try

    End Sub
    Private Sub Kill_Appt(ByVal frm As Form)
        Try
            Select Case frm.Name
                Case Is = "Sales"

                Case Is = "Confirming"
                    If Confirming.TabControl1.SelectedIndex = 0 Then
                        Dim d As New ConfirmingData
                        d.Populate("Dispatch", Confirming.cboSalesPLS.Text, Confirming.cboSalesSLS.Text, Confirming.dpSales.Value.ToString, "Populate")
                    Else
                        Dim d As New ConfirmingData
                        d.Populate("Confirm", Confirming.cboConfirmingPLS.Text, Confirming.cboConfirmingSLS.Text, Confirming.dpConfirming.Value.ToString, "Populate")
                    End If
                Case Is = "WCaller"
                    Dim TAB = WCaller.TabControl1.SelectedTab
                    If TAB.Name = "CallList" Then
                        Dim i As Integer = WCaller.lvCallList.Items.IndexOfKey(WCaller.lvCallList.SelectedItems(0).Text)
                        WCaller.lvCallList.SelectedItems(0).Remove()
                        WCaller.txtRecordsMatching.Text = CStr(CInt(WCaller.txtRecordsMatching.Text) - 1)
                        If WCaller.lvCallList.Items.Count <> 0 Then
                            If i > WCaller.lvCallList.Items.Count - 1 Then
                                WCaller.lvCallList.Items(i - 1).Selected = True
                                WCaller.lvCallList.SelectedItems(0).EnsureVisible()
                            Else
                                WCaller.lvCallList.Items(i).Selected = True
                                WCaller.lvCallList.SelectedItems(0).EnsureVisible()
                            End If
                        Else
                            Dim wc As New WarmCalling
                            wc.PullCustomerINFO("")
                        End If
                    Else
                        Dim c As New WarmCalling.MyApptsTab.Populate(WCaller.cboFilter.Text)
                        Dim y As New WarmCalling
                        y.Populate()
                        WCaller.SuspendLayout()
                    End If
                Case Is = "Administration"

                Case Is = "Installation"

                Case Is = "Finance"

                Case Is = "MarketingManager"

                Case Is = "Recovery"

                Case Is = "PreviousCustomer"

                Case Is = "ConfirmingSingleRecord"
                    Dim c As New CustomerHistory
                    c.SetUp(ConfirmingSingleRecord.TScboCustomerHistory)
                    ConfirmingSingleRecord.Manage_Buttons()
            End Select
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "SubForm_Launcher", "Class", "Sub", "Kill_Appt", Calling_Form.Name & " - " & Id, ex.Message.ToString)
            y = Nothing
        End Try

    End Sub
    Private Sub Sales_Result(ByVal frm As Form)
        Try
            Select Case frm.Name
                Case Is = "Sales"
                    Dim tab As Integer = Sales.tbMain.SelectedIndex
                    Select Case tab
                        Case Is = 0
                            Sales.ForceRefresh = True
                            If Sales.lvnoresults.SelectedItems(0).Index = 0 And Sales.lvnoresults.Items.Count >= 2 Then
                                Sales.lvnoresults.SelectedItems(0).Remove()
                                Sales.lvnoresults.Items(0).Selected = True
                            ElseIf Sales.lvnoresults.SelectedItems(0).Index = Sales.lvnoresults.Items.Count - 1 And Sales.lvnoresults.Items.Count >= 2 Then
                                Dim x As Integer = Sales.lvnoresults.SelectedItems(0).Index
                                Sales.lvnoresults.SelectedItems(0).Remove()
                                Sales.lvnoresults.Items(x - 1).Selected = True

                            ElseIf Sales.lvnoresults.SelectedItems(0).Index <> 0 And Sales.lvnoresults.Items.Count >= 2 Then
                                Dim x As Integer = Sales.lvnoresults.SelectedItems(0).Index
                                Sales.lvnoresults.SelectedItems(0).Remove()
                                Sales.lvnoresults.Items(x).Selected = True
                            Else
                                Sales.lvnoresults.SelectedItems(0).Remove()
                            End If
                            Sales.Label38.Text = ("All Records Needing Sales Results" & " -[ Records: " & Sales.lvnoresults.Items.Count & " ]")
                            Dim z As New Sales_Performance_Report
                        Case Is = 1
                            Sales.ForceRefresh = True
                            If Sales.cboSalesList.Text <> "Unfiltered Sales Dept. List" Or (Sales.cboGroupSales.Text = "Sales Result" Or Sales.cboGroupSales.Text = "Marketing Result" Or Sales.cboGroupSales.Text = "Sales Rep") Then
                                Dim c As New SalesListManager()
                            Else
                                If Sales.TabControl2.TabIndex = 0 And Sales.lvSales.SelectedItems.Count <> 0 Then
                                    Sales.lvSales_SelectedIndexChanged(Nothing, Nothing)
                                ElseIf Sales.TabControl2.TabIndex = 1 And Sales.lvMemorized.SelectedItems.Count <> 0 Then
                                    Sales.PopulateMemorized()
                                End If
                            End If
                    End Select

                Case Is = "ConfirmingSingleRecord"
                    Dim c As New CustomerHistory
                    c.SetUp(ConfirmingSingleRecord.TScboCustomerHistory)
            End Select
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "SubForm_Launcher", "Class", "Sub", "Sales_Result", Calling_Form.Name & " - " & Id, ex.Message.ToString)
            y = Nothing
        End Try
    End Sub
    Private Sub Schedule_Action(ByVal frm As Form)
        Try
            Dim c As New CustomerHistory
            Select Case frm.Name
                Case Is = "Sales"
                    Dim q As New ScheduledActions
                    q.SetUp(frm)
                    If Sales.tbMain.SelectedIndex = 1 Then
                        c.SetUp(Sales.TScboCustomerHistory)
                    End If
                Case Is = "Administration"
                    Dim q As New ScheduledActions
                    q.SetUp(frm)
                    'If Administration.tbMain.SelectedIndex = 1 Then
                    '    c.SetUp(Administration.TScboCustomerHistory)
                    'End If
                Case Is = "Installation"
                    Dim q As New ScheduledActions
                    q.SetUp(frm)
                    'If Installation.tbMain.SelectedIndex = 1 Then
                    '    c.SetUp(Installation.TScboCustomerHistory)
                    'End If
                Case Is = "Finance"
                    Dim q As New ScheduledActions
                    q.SetUp(frm)
                    'If Finance.tbMain.SelectedIndex = 1 Then
                    '    c.SetUp(Finance.TScboCustomerHistory)
                    'End If
                Case Is = "MarketingManager"
                    Dim q As New ScheduledActions
                    q.SetUp(frm)
                    If MarketingManager.tbMain.SelectedIndex = 1 Then
                        c.SetUp(MarketingManager.TScboCustomerHistory)
                    End If
                Case Is = "Main"
                    Dim count As Integer = Main.MdiChildren.Length
                    For i As Integer = 0 To count - 1
                        Dim f As Form = Main.MdiChildren(i)
                        Dim cse As String = f.Name & " " & STATIC_VARIABLES.New_SA_Dept
                        Select Case cse
                            Case "Sales Sales", "Administration Administration", "MarketingManager Marketing", "Finance Financing", _
                                "Installation Installation"
                                Dim q As New ScheduledActions
                                q.SetUp(f)
                        End Select
                    Next
            End Select
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "SubForm_Launcher", "Class", "Sub", "Schedule_Action", Calling_Form.Name & " - " & Id, ex.Message.ToString)
            y = Nothing
        End Try
    End Sub
    Private Sub Log_Phone_Call(ByVal frm As Form)
        Try
            Dim c As New CustomerHistory
            Select Case frm.Name
                Case Is = "Sales"
                    c.SetUp(Sales.TScboCustomerHistory)
                Case Is = "Confirming"
                    c.SetUp(Confirming.TScboCustomerHistory)
                Case Is = "WCaller"
                    c.SetUp(WCaller.TScboCustomerHistory)
                Case Is = "Administration"
                    c.SetUp(Administration.TScboCustomerHistory)
                Case Is = "Installation"
                    ' c.SetUp(Installation.TScboCustomerHistory)
                Case Is = "Finance"
                    c.SetUp(Finance.TScboCustomerHistory)
                Case Is = "MarketingManager"
                    c.SetUp(MarketingManager.TScboCustomerHistory)
                Case Is = "Recovery"
                    c.SetUp(Recovery.TScboCustomerHistory)
                Case Is = "PreviousCustomer"
                    c.SetUp(PreviousCustomer.TScboCustomerHistory)
                Case Is = "ConfirmingSingleRecord"
                    c.SetUp(ConfirmingSingleRecord.TScboCustomerHistory)
            End Select
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "SubForm_Launcher", "Class", "Sub", "Log_Phone_Call", Calling_Form.Name & " - " & Id, ex.Message.ToString)
            y = Nothing
        End Try

    End Sub
    Private Sub Set_Appt(ByVal frm As Form)
        Try
            Select Case frm.Name
                Case Is = "Sales"
                    Sales.ForceRefresh = True
                    Sales.PullInfo(Me.Id)
                    If Sales.TabControl2.SelectedIndex = 0 Then
                        Sales.RefreshSelectedItem(Sales.lvSales, Me.Id)
                    Else
                        Sales.RefreshSelectedItem(Sales.lvMemorized, Me.Id)
                    End If
                Case Is = "Confirming"
                    If Confirming.TabControl1.SelectedIndex = 0 Then
                        Dim d As New ConfirmingData
                        d.Populate("Dispatch", Confirming.cboSalesPLS.Text, Confirming.cboSalesSLS.Text, Confirming.dpSales.Value.ToString, "Populate")
                    Else
                        Dim d As New ConfirmingData
                        d.Populate("Confirm", Confirming.cboConfirmingPLS.Text, Confirming.cboConfirmingSLS.Text, Confirming.dpConfirming.Value.ToString, "Populate")
                    End If
                Case Is = "WCaller"
                    Dim TAB = WCaller.TabControl1.SelectedTab
                    If TAB.Name = "CallList" Then
                        Dim i As Integer = WCaller.lvCallList.Items.IndexOfKey(WCaller.lvCallList.SelectedItems(0).Text)
                        WCaller.lvCallList.SelectedItems(0).Remove()
                        WCaller.txtRecordsMatching.Text = CStr(CInt(WCaller.txtRecordsMatching.Text) - 1)
                        If WCaller.lvCallList.Items.Count <> 0 Then
                            If i > WCaller.lvCallList.Items.Count - 1 Then
                                WCaller.lvCallList.Items(i - 1).Selected = True
                                WCaller.lvCallList.SelectedItems(0).EnsureVisible()
                            Else
                                WCaller.lvCallList.Items(i).Selected = True
                                WCaller.lvCallList.SelectedItems(0).EnsureVisible()
                            End If
                        Else
                            Dim wc As New WarmCalling
                            wc.PullCustomerINFO("")
                        End If
                        Dim c As New WarmCalling.MyApptsTab.Populate(WCaller.cboFilter.Text)
                    Else
                        Dim c As New WarmCalling.MyApptsTab.Populate(WCaller.cboFilter.Text)
                        Dim y As New WarmCalling
                        y.Populate()
                        WCaller.SuspendLayout()
                    End If
                Case Is = "Administration"

                Case Is = "Installation"

                Case Is = "Finance"

                Case Is = "MarketingManager"

                Case Is = "Recovery"

                Case Is = "PreviousCustomer"

                Case Is = "ConfirmingSingleRecord"
                    ConfirmingSingleRecord.Update()
                    Dim c As New CustomerHistory
                    c.SetUp(ConfirmingSingleRecord.TScboCustomerHistory)
                Case Is = "EditCustomerInfo"
                    Dim d As New EDIT_CUSTOMER_INFORMATION
                    d.Get_New_Appt(Id)
                    EditCustomerInfo.txtApptDate.Text = d.AppointmentDate
                    EditCustomerInfo.txtApptTime.Text = d.AppointmentTime
                    EditCustomerInfo.txtApptDay.Text = d.AppointmentDay

            End Select
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "SubForm_Launcher", "Class", "Sub", "Set_Appt", Calling_Form.Name & " - " & Id, ex.Message.ToString)
            y = Nothing
        End Try

    End Sub
    Private Sub ReSchedule_Appt(ByVal frm As Form)
        Try
            Select Case frm.Name
                Case Is = "Sales"
                    Sales.ForceRefresh = True
                    Sales.PullInfo(Me.Id)
                    If Sales.TabControl2.SelectedIndex = 0 Then
                        Sales.RefreshSelectedItem(Sales.lvSales, Me.Id)
                    Else
                        Sales.RefreshSelectedItem(Sales.lvMemorized, Me.Id)
                    End If
                Case Is = "Confirming"
                    If Confirming.TabControl1.SelectedIndex = 0 Then
                        Dim d As New ConfirmingData
                        d.Populate("Dispatch", Confirming.cboSalesPLS.Text, Confirming.cboSalesSLS.Text, Confirming.dpSales.Value.ToString, "Populate")
                    Else
                        Dim d As New ConfirmingData
                        d.Populate("Confirm", Confirming.cboConfirmingPLS.Text, Confirming.cboConfirmingSLS.Text, Confirming.dpConfirming.Value.ToString, "Populate")
                    End If
                Case Is = "WCaller"

                Case Is = "Administration"

                Case Is = "Installation"

                Case Is = "Finance"

                Case Is = "MarketingManager"

                Case Is = "Recovery"

                Case Is = "PreviousCustomer"

                Case Is = "ConfirmingSingleRecord"
                    Dim c As New CustomerHistory
                    ConfirmingSingleRecord.Update()
                    c.SetUp(ConfirmingSingleRecord.TScboCustomerHistory)
                Case Is = "EditCustomerInfo"
                    Dim d As New EDIT_CUSTOMER_INFORMATION
                    d.Get_New_Appt(Id)
                    EditCustomerInfo.txtApptDate.Text = d.AppointmentDate
                    EditCustomerInfo.txtApptTime.Text = d.AppointmentTime
                    EditCustomerInfo.txtApptDay.Text = d.AppointmentDay

            End Select
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "SubForm_Launcher", "Class", "Sub", "Reschedule_Appt", Calling_Form.Name & " - " & Id, ex.Message.ToString)
            y = Nothing
        End Try
    End Sub
    Private Sub ReIssue_Appt(ByVal frm As Form)
        Try
            Select Case frm.Name
                Case Is = "Sales"

                Case Is = "Confirming"
                    Dim d As New ConfirmingData
                    d.Populate("Dispatch", Confirming.cboSalesPLS.Text, Confirming.cboSalesSLS.Text, Confirming.dpSales.Value.ToString, "Populate")
                Case Is = "WCaller"

                Case Is = "Administration"

                Case Is = "Installation"

                Case Is = "Finance"

                Case Is = "MarketingManager"

                Case Is = "Recovery"

                Case Is = "PreviousCustomer"

                Case Is = "ConfirmingSingleRecord"
                    Dim c As New CustomerHistory
                    ConfirmingSingleRecord.Update()
                    c.SetUp(ConfirmingSingleRecord.TScboCustomerHistory)
            End Select
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "SubForm_Launcher", "Class", "Sub", "ReIssue_Appt", Calling_Form.Name & " - " & Id, ex.Message.ToString)
            y = Nothing
        End Try
    End Sub
    Private Sub Edit_Customer_Info(ByVal frm As Form)
        Try
            Select Case frm.Name
                Case Is = "Sales"
                    If Sales.tbMain.SelectedIndex = 1 Then
                        Sales.ForceRefresh = True
                        Sales.PullInfo(Me.Id)
                        If Sales.TabControl2.SelectedIndex = 0 Then
                            Sales.RefreshSelectedItem(Sales.lvSales, Me.Id)
                        Else
                            Sales.RefreshSelectedItem(Sales.lvMemorized, Me.Id)
                        End If
                    Else
                        Dim c = New Issue_Leads(True, "")
                    End If
                Case Is = "Confirming"
                    If Confirming.TabControl1.SelectedIndex = 0 Then
                        Dim d As New ConfirmingData
                        d.Populate("Dispatch", Confirming.cboSalesPLS.Text, Confirming.cboSalesSLS.Text, Confirming.dpSales.Value.ToString, "Populate")
                    Else
                        Dim d As New ConfirmingData
                        d.Populate("Confirm", Confirming.cboConfirmingPLS.Text, Confirming.cboConfirmingSLS.Text, Confirming.dpConfirming.Value.ToString, "Populate")
                    End If
                Case Is = "WCaller"

                Case Is = "Administration"

                Case Is = "Installation"

                Case Is = "Finance"

                Case Is = "MarketingManager"

                Case Is = "Recovery"

                Case Is = "PreviousCustomer"

                Case Is = "ConfirmingSingleRecord"
                    Dim c As New CustomerHistory
                    ConfirmingSingleRecord.Update()
                    c.SetUp(ConfirmingSingleRecord.TScboCustomerHistory)
            End Select
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "SubForm_Launcher", "Class", "Sub", "Edit_Customer_Info", Calling_Form.Name & " - " & Id, ex.Message.ToString)
            y = Nothing
        End Try

    End Sub
    Private Sub Change_Appt_Time(ByVal frm As Form)
        Try
            Select Case frm.Name
                Case Is = "Confirming"
                    Dim c As New ConfirmingData
                    c.Populate("Dispatch", Confirming.cboSalesPLS.Text, Confirming.cboSalesSLS.Text, Confirming.dpSales.Value.ToString, "Refresh")
                    Dim c2 As New CustomerHistory
                    c2.SetUp(Confirming.TScboCustomerHistory)
                Case Is = "ConfirmingSingleRecord"
                    Dim c As New CustomerHistory
                    ConfirmingSingleRecord.Update()
                    c.SetUp(ConfirmingSingleRecord.TScboCustomerHistory)
            End Select
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "SubForm_Launcher", "Class", "Sub", "Change_Appt_Time", Calling_Form.Name & " - " & Id, ex.Message.ToString)
            y = Nothing
        End Try
    End Sub
    Private Sub Called_and_Cancelled(ByVal frm As Form)
        Try
            Dim c As New ConfirmingData
            Dim c2 As New CustomerHistory
            Dim c3 As New WarmCalling
            Select Case frm.Name
                Case Is = "Sales"
                    If Sales.tbMain.SelectedIndex = 1 Then
                        If Sales.TabControl2.SelectedIndex = 0 Then
                            Sales.RefreshSelectedItem(Sales.lvSales, Me.Id)
                        Else
                            Sales.RefreshSelectedItem(Sales.lvMemorized, Me.Id)
                        End If
                        Sales.ForceRefresh = True
                        Sales.PullInfo(Me.Id)
                    Else
                        Dim x = New Issue_Leads(True, "")
                    End If
                Case Is = "Confirming"
                    If Confirming.Tab = "Confirm" Then
                        If CandCNotes.cbCallBack.Checked = True Or CandCNotes.cbNoReschedule.Checked = True Then
                            c.Populate(Confirming.Tab, Confirming.cboConfirmingPLS.Text, Confirming.cboConfirmingSLS.Text, Confirming.dpConfirming.Value.ToString, "Refresh")
                            c2.SetUp(Confirming.TScboCustomerHistory)
                        Else
                            c.Populate(Confirming.Tab, Confirming.cboConfirmingPLS.Text, Confirming.cboConfirmingSLS.Text, Confirming.dpConfirming.Value.ToString, "Populate")
                        End If
                    ElseIf Confirming.Tab = "Dispatch" Then
                        If CandCNotes.cbCallBack.Checked = True Or CandCNotes.cbNoReschedule.Checked = True Then
                            c.Populate(Confirming.Tab, Confirming.cboSalesPLS.Text, Confirming.cboSalesSLS.Text, Confirming.dpSales.Value.ToString, "Refresh")
                            If Confirming.lvSales.SelectedItems.Count >= 1 Then
                                c2.SetUp(Confirming.TScboCustomerHistory)
                            End If
                        Else
                            c.Populate(Confirming.Tab, Confirming.cboSalesPLS.Text, Confirming.cboSalesSLS.Text, Confirming.dpSales.Value.ToString, "Populate")
                        End If
                    End If
                Case Is = "WCaller"
                    If WCaller.TabControl1.SelectedIndex = 0 Then
                        c2.SetUp(WCaller.TScboCustomerHistory)
                    Else
                        If WCaller.lvMyAppts.SelectedItems(0).Group.Name <> "grpMemorized" Then
                            Dim x As New WarmCalling.MyApptsTab.Populate(WCaller.cboFilter.Text)
                            c3.Populate()
                        Else
                            c2.SetUp(WCaller.TScboCustomerHistory)

                        End If

                    End If
                Case Is = "Administration"
                    c2.SetUp(Administration.TScboCustomerHistory)
                Case Is = "Installation"
                    ''c2.SetUp(Installation.TScboCustomerHistory)  'Comeback
                Case Is = "Finance"
                    c2.SetUp(Finance.TScboCustomerHistory)
                Case Is = "MarketingManager"
                    c2.SetUp(MarketingManager.TScboCustomerHistory)
                Case Is = "Recovery"

                    ''Revisit when forms complete 
                    'If Recovery.TabControl1.SelectedIndex = 0 Then
                    '    c2.SetUp(Recovery.TScboCustomerHistory)
                    'Else
                    '    If Recovery.lvMyAppts.SelectedItems(0).Group.Name <> "grpMemorized" Then

                    '    Else
                    '        c2.SetUp(Recovery.TScboCustomerHistory)

                    '    End If
                    'End If
                Case Is = "PreviousCustomer"
                    ''Revisit when forms complete 
                    'If PreviousCustomer.TabControl1.SelectedIndex = 0 Then
                    '    c2.SetUp(PreviousCustomer.TScboCustomerHistory)
                    'Else
                    '    If PreviousCustomer.lvMyAppts.SelectedItems(0).Group.Name <> "grpMemorized" Then

                    '    Else
                    '        c2.SetUp(PreviousCustomer.TScboCustomerHistory)

                    '    End If
                    'End If

                Case Is = "ConfirmingSingleRecord"
                    c2.SetUp(ConfirmingSingleRecord.TScboCustomerHistory)
            End Select
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "SubForm_Launcher", "Class", "Sub", "Called_And_Cancelled", Calling_Form.Name & " - " & Id, ex.Message.ToString)
            y = Nothing
        End Try
    End Sub


End Class
