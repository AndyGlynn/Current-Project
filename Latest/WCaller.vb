Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System

Public Class WCaller
    Friend WithEvents btnUndoSet As New ToolStripButton
    Friend WithEvents btnUndoMemorize As New ToolStripMenuItem
    Friend WithEvents btnAlt1 As New ToolStripMenuItem
    Friend WithEvents btnAlt2 As New ToolStripMenuItem
    Friend WithEvents btnMain As New ToolStripMenuItem
    Friend WithEvents separator As New ToolStripSeparator
    Friend WithEvents tsbtnAlt1 As New ToolStripMenuItem
    Friend WithEvents tsbtnAlt2 As New ToolStripMenuItem
    Friend WithEvents rcbtnSet As New ToolStripMenuItem
    Friend WithEvents rcbtnShow As New ToolStripMenuItem
    Friend WithEvents rcbtnUndoSet As New ToolStripMenuItem
    Friend WithEvents rcbtnRemoveMemorized As New ToolStripMenuItem
    Friend WithEvents rcbtnMemorize As New ToolStripMenuItem
    Public LoadComplete As Boolean = False
    Public LastD1 As String
    Public LastD2 As String
    Public Tab As String = "WC"
    Public PBar As Boolean = False
    Public msgzip As Boolean = False
    Public msgcity As Boolean = False
    Public cntZip As Integer
    Public cntCity As Integer
    Public Toolbar As Integer = 1
    Public TT As ToolTip
    Public SelItem As New ListViewItem
    Public xcordinate As Integer = 0
    Public ycordinate As Integer = 0
    Public IfExists As Boolean = False
    Public ID As String
    Private Sub WCaller_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        '' Me.Dispose()
        Me.Cursor = Cursors.Default
        Main.Cursor = Cursors.Default
    End Sub

    Private Sub WCaller_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim c As New WarmCalling.LoadProcedure()
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "WCaller", "FormCode", "Event", "WCaller_Load", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        Try
            If Me.TabControl1.SelectedIndex = (1) Then
                Me.Tab = "MA"
                Me.btnExpandCollapse.Enabled = False
                If Me.lvMyAppts.Items.Count > 0 And Me.lvMyAppts.SelectedItems.Count = 0 Then
                    Me.lvMyAppts.TopItem.Selected = True
                End If
                If Me.lvMyAppts.SelectedItems.Count = 0 Or Me.lvMyAppts.Items.Count = 0 Then
                    Me.ToolBarConfig(2)
                Else
                    Me.lvMyAppts_SelectedIndexChanged(Nothing, Nothing)
                End If
                Dim w = Me.Size.Width
                Me.pnlSearch.Controls.Remove(Me.btnExpandCollapse)
                Me.Controls.Add(Me.btnExpandCollapse)

                Me.btnExpandCollapse.Location = New System.Drawing.Point(w - 30, 28)

                Me.btnExpandCollapse.Text = Chr(171)

                Me.pnlSearch.Visible = False
                Me.btnExpandCollapse.BringToFront()
                If Me.lvMyAppts.SelectedItems.Count > 0 Then
                    STATIC_VARIABLES.CurrentID = Me.lvMyAppts.SelectedItems(0).Tag
                Else
                    STATIC_VARIABLES.CurrentID = ""
                End If

            Else
                If Me.IfExists = True Then
                    Me.TT.Dispose()
                End If
                If Me.lvCallList.Items.Count > 0 And Me.lvCallList.SelectedItems.Count = 0 Then
                    Me.lvCallList.TopItem.Selected = True
                End If
                Me.Tab = "WC"
                Me.ToolBarConfig(1)
                Me.lvCallList_SelectedIndexChanged(Nothing, Nothing)
                Me.btnExpandCollapse.Enabled = True
                If Me.lvCallList.SelectedItems.Count > 0 Then
                    STATIC_VARIABLES.CurrentID = Me.lvCallList.SelectedItems(0).Text
                Else
                    STATIC_VARIABLES.CurrentID = ""
                End If
            End If
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "WCaller", "FormCode", "Event", "WCaller_SelectedINdexChanged", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub lvMyAppts_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        If Me.IfExists = True Then
            Me.TT.Dispose()
        End If
        Me.SelItem.ToolTipText = Nothing
        Me.SelItem.ToolTipText = Me.lvMyAppts.GetItemAt(Me.xcordinate, Me.ycordinate).ToolTipText
        'MsgBox(Me.SelItem.Tag)
    End Sub

    Private Sub lvMyAppts_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            Me.TT = New ToolTip
            Me.IfExists = True
            If Me.SelItem Is Nothing Then
                Exit Sub
            End If
            Dim p As System.Drawing.Point = New System.Drawing.Point(10, Me.ycordinate + 15)
            Dim notes As String
            If Me.SelItem.ToolTipText <> "" Then
                Dim c As New TruncateNotes
                c.Truncate(Me.SelItem.ToolTipText, Me.lvMyAppts)
                notes = c.NewSTRING
                TT.ToolTipIcon = ToolTipIcon.Info
                Dim z = Me.lvMyAppts.SelectedItems(0).Index
                Dim y As ListViewGroup = Me.lvMyAppts.Items(z).Group
                If y.Name <> ("grpMemorized") Then
                    TT.ToolTipTitle = "Set Appt. Notes"
                Else
                    TT.ToolTipTitle = "Memorized Appt. Notes"
                End If
                Me.TT.Show(notes, Me.lvMyAppts, p, 30000)
            End If
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "WCaller", "FormCode", "Event", "lvMyAppts_DoubleClick", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub lvMyAppts_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Me.xcordinate = e.X
        Me.ycordinate = e.Y

    End Sub

    Private Sub lvMyAppts_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If Me.lvMyAppts.SelectedItems.Count > 0 Then
            STATIC_VARIABLES.CurrentID = Me.lvMyAppts.SelectedItems(0).Tag
        End If
        Try
            If Me.Tab = "MA" Then
                If Me.lvMyAppts.SelectedItems.Count = 0 Or Me.lvMyAppts.Items.Count = 0 Then
                    Me.ToolBarConfig(2)
                    Dim g As New WarmCalling
                    Dim b As ListViewItem
                    For Each b In Me.lvMyAppts.Items
                        If b.Selected = True Then
                            Dim res As Boolean = g.IsAppointmentSet(b.Tag)
                            If res = True Then
                                Me.ContextMenuStrip1.Items(1).Text = "Move Appointment"
                                Me.btnSetAppt.Text = "Move Appointment"
                            ElseIf res = False Then
                                Me.ContextMenuStrip1.Items(1).Text = "Set Appointment"
                                Me.btnSetAppt.Text = "Set Appointment"
                            End If
                        End If
                    Next
                    g = Nothing
                    Exit Sub
                End If
                Dim z = Me.lvMyAppts.SelectedItems(0).Index
                Dim y As ListViewGroup = Me.lvMyAppts.Items(z).Group
                If y.Name <> ("grpMemorized") Then
                    '' no set appt button
                    Me.ToolBarConfig(3)

                Else

                    Me.ToolBarConfig(2)
                    Dim g As New WarmCalling
                    Dim b As ListViewItem
                    For Each b In Me.lvMyAppts.Items
                        If b.Selected = True Then
                            Dim res As Boolean = g.IsAppointmentSet(b.Tag)
                            If res = True Then
                                Me.ContextMenuStrip1.Items(1).Text = "Move Appointment"
                                Me.btnSetAppt.Text = "Move Appointment"
                            ElseIf res = False Then
                                Me.ContextMenuStrip1.Items(1).Text = "Set Appointment"
                                Me.btnSetAppt.Text = "Set Appointment"
                            End If
                        End If
                    Next
                    g = Nothing
                End If
                Dim c As New WarmCalling
                If Me.lvMyAppts.SelectedItems.Count = 0 Then
                    c.PullCustomerINFO("")
                Else
                    c.PullCustomerINFO(Me.lvMyAppts.SelectedItems(0).Tag)

                    Me.btnAutoDialer.DropDownItems.Add(Me.separator)
                    Me.btnAutoDialer.DropDownItems.Add(Me.btnMain)
                    Me.btnMain.Text = "Call Main- " & Me.txtHousePhone.Text
                    If Me.txtaltphone1.Text <> "" Then
                        Me.btnAutoDialer.DropDownItems.Add(Me.btnAlt1)
                        Me.btnAlt1.Text = "Call Alt 1- " & Me.txtaltphone1.Text
                    Else
                        Me.btnAutoDialer.DropDownItems.Remove(Me.btnAlt1)
                    End If
                    If Me.txtaltphone2.Text <> "" Then
                        Me.btnAutoDialer.DropDownItems.Add(Me.btnAlt2)
                        Me.btnAlt2.Text = "Call Alt 2- " & Me.txtaltphone2.Text
                    Else
                        Me.btnAutoDialer.DropDownItems.Remove(Me.btnAlt2)
                    End If
                End If
            End If
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "WCaller", "FormCode", "Event", "lvMyAppts_SelectedIndexChanged", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub ToolBarConfig(ByVal x As Integer)
        Try
            Select Case x
                Case 1
                    Me.tsWarmCalling.Items.Clear()
                    Me.tsWarmCalling.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSetAppt, Me.btnEditCustomer, Me.btnChangeStatus, Me.lblTo, Me.lblFrom, Me.cboDateRange, Me.lblDateRange, Me.btnAutoDialer})
                    Me.btnSetAppt.DropDownItems.Clear()
                    Me.btnSetAppt.DropDownItems.Add(Me.MemorizeThisApptToolStripMenuItem)
                    Me.dtp1.Visible = True
                    Me.dtp2.Visible = True
                    Me.lblDateRange.Visible = True
                    Me.lblFrom.Visible = True
                    Me.lblTo.Visible = True
                    If Me.txtDate1.Text = "" Then
                        Me.txtDate1.Visible = True
                    End If
                    If Me.txtDate2.Text = "" Then
                        Me.txtDate2.Visible = True
                    End If
                    If Me.ContextMenuStrip1.Items.Count <> 0 Then
                        Me.ContextMenuStrip1.Items.Clear()
                    End If


                    Me.ContextMenuStrip1.Items.Add("Set Appointment", Me.ilToolStripIcons.Images(3), AddressOf btnSetAppt_ButtonClick)
                    Me.ContextMenuStrip1.Items.Add("Memorize Appointment", Me.ilToolStripIcons.Images(4), AddressOf MemorizeThisApptToolStripMenuItem_Click)
                Case 2
                    Me.tsWarmCalling.Items.Clear()
                    Me.dtp1.Visible = False
                    Me.dtp2.Visible = False
                    Me.txtDate1.Visible = False
                    Me.txtDate2.Visible = False
                    Me.tsWarmCalling.Items.Clear()
                    Me.tsWarmCalling.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSetAppt, Me.btnEditCustomer, Me.btnChangeStatus, Me.btnAutoDialer})
                    Me.btnSetAppt.DropDownItems.Clear()
                    Me.btnSetAppt.DropDownItems.Add(Me.btnUndoMemorize)
                    If Me.ContextMenuStrip1.Items.Count <> 0 Then
                        Me.ContextMenuStrip1.Items.Clear()
                    End If
                    Me.ContextMenuStrip1.Items.Add("Show Notes", Me.ilToolStripIcons.Images(2), AddressOf Me.lvMyAppts_DoubleClick)
                    Me.ContextMenuStrip1.Items.Add("Set Appointment", Me.ilToolStripIcons.Images(3), AddressOf btnSetAppt_ButtonClick)
                    Me.ContextMenuStrip1.Items.Add("Remove Memorized Appt.", Me.ilToolStripIcons.Images(1), AddressOf Me.btnUndoMemorize_Click)
                Case 3
                    Me.tsWarmCalling.Items.Clear()
                    Me.dtp1.Visible = False
                    Me.dtp2.Visible = False
                    Me.txtDate1.Visible = False
                    Me.txtDate2.Visible = False
                    Me.tsWarmCalling.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnUndoSet, Me.btnEditCustomer, Me.btnChangeStatus, Me.btnAutoDialer})
                    If Me.ContextMenuStrip1.Items.Count <> 0 Then
                        Me.ContextMenuStrip1.Items.Clear()
                    End If
                    Me.ContextMenuStrip1.Items.Add("Show Notes", Me.ilToolStripIcons.Images(2), AddressOf Me.lvMyAppts_DoubleClick)

                    Me.ContextMenuStrip1.Items.Add("Undo Set Appt.", Me.ilToolStripIcons.Images(1), AddressOf Me.btnUndoSet_Click)
            End Select
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "WCaller", "FormCode", "Sub", "ToolBarConfig()", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub lvCallList_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvCallList.SelectedIndexChanged

    End Sub

    Private Sub btnExpandWarmCalling_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Select Case Me.btnExpandWarmCalling.Text
            Case Chr(187)
                Me.SplitContainer1.SplitterDistance = 2500
                Me.SplitContainer1.SplitterWidth = 100
                Me.btnExpandMyAppts.Text = Chr(171)
                Me.btnExpandWarmCalling.Text = Chr(171)
            Case Chr(171)
                Me.SplitContainer1.SplitterDistance = 225
                Me.SplitContainer1.SplitterWidth = 5
                Me.btnExpandWarmCalling.Text = Chr(187)
                Me.btnExpandMyAppts.Text = Chr(187)
        End Select
    End Sub

    Private Sub btnExpandMyAppts_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.btnExpandWarmCalling_Click(Nothing, Nothing)
    End Sub

    Private Sub cboPLSWarmCalling_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.lblPLSWarmCalling.Visible = False
    End Sub

    Private Sub cboPLSWarmCalling_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        If Me.cboPLSWarmCalling.Text = "" Then
            Me.lblPLSWarmCalling.Visible = True
        End If
    End Sub

    Private Sub cboSLSWarmCalling_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.lblSLSWarmCalling.Visible = False
        If Me.cboPLSWarmCalling.Text = "" Then
            Me.cboSLSWarmCalling.Items.Clear()
        End If

    End Sub

    Private Sub cboSLSWarmCalling_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        If Me.cboSLSWarmCalling.Text = "" Then
            Me.lblSLSWarmCalling.Visible = True
        End If
    End Sub

    Private Sub lblPLSWarmCalling_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.cboPLSWarmCalling.Focus()
    End Sub

    Private Sub lblSLSWarmCalling_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.cboSLSWarmCalling.Focus()
    End Sub

    Private Sub btnExpandCollapse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim w = Me.Size.Width
        If Me.btnExpandCollapse.Text = Chr(171) Then
            Me.Controls.Remove(Me.btnExpandCollapse)
            Me.pnlSearch.Controls.Add(Me.btnExpandCollapse)
            Me.btnExpandCollapse.Location = New System.Drawing.Point(3, 3)
            Me.btnExpandCollapse.Text = Chr(187)
            Me.pnlSearch.Location = New System.Drawing.Point(w - 344, 28)
            Me.pnlSearch.Size = New System.Drawing.Size(344, 576)
            Me.pnlSearch.Visible = True
            Me.btnExpandCollapse.BringToFront()
            Dim x As Integer = Me.pnlSearch.Size.Height

            Me.btnExpandCollapse.Size = New Size(Me.btnExpandCollapse.Size.Width, x - 6)

        Else

            Me.pnlSearch.Controls.Remove(Me.btnExpandCollapse)
            Me.Controls.Add(Me.btnExpandCollapse)

            Me.btnExpandCollapse.Location = New System.Drawing.Point(w - 30, 31)

            Me.btnExpandCollapse.Text = Chr(171)

            Me.pnlSearch.Visible = False
            Me.btnExpandCollapse.BringToFront()
        End If
    End Sub

    Private Sub rdoCity_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.lblEnter.Text = "Enter Starting City:"
            Me.lblShow.Text = "Show Cities within                      miles of" & vbCrLf & "starting City"
            Me.btnZipCity.Text = "Show Cities"
            Dim c As New AutoCompleteSourceCities
            Me.txtZipCode.Text = ""
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "WCaller", "FormCode", "Event", "rdoCity_CheckedChanged", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub rdoZip_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.lblEnter.Text = "Enter Starting Zip Code:"
        Me.lblShow.Text = "Show Zip Codes within                miles of" & vbCrLf & "starting Zip Code"
        Me.btnZipCity.Text = "Show Zip Codes"
        Me.txtZipCode.AutoCompleteCustomSource.Clear()
        Me.txtZipCode.Text = ""
    End Sub


    Private Sub WCaller_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Try
            Dim w = Me.Size.Width
            If Me.btnExpandCollapse.Parent.Name = "pnlSearch" Then
                If Me.pnlSearch.Visible = True Then
                    If Me.Size.Width = 998 And Me.Size.Height = 635 Then
                        Me.btnExpandCollapse.Size = New Size(21, 570)
                    End If
                End If
                Exit Sub
            Else
                Me.btnExpandCollapse.Location = New System.Drawing.Point(w - 30, 31)
            End If
            Dim c As New CustomerHistory
            c.SetUp(Me.TScboCustomerHistory)

        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "WCaller", "FormCode", "Event", "WCaller_Resize", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub


    Private Sub LaunchProgressiveDialerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.tsAutoDial.Visible = True
    End Sub

    Private Sub tsbtnCloseDialer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.tsAutoDial.Visible = False
    End Sub

    Private Sub btnLogCall_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim x As New SubForm_Launcher(sender)
    End Sub

    Private Sub btnCandC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCandC.Click

        Dim x As New SubForm_Launcher(sender)
        'Stamp in Log without notes

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.btnClear.Enabled = False
            Me.txtTime1.Text = ""
            Me.txtTime1.Visible = True
            Me.txtTime2.Text = ""
            Me.txtTime2.Visible = True
            Me.cbWeekdays.Checked = False
            For i As Integer = 0 To Me.chlstResults.Items.Count - 1
                Me.chlstResults.SetItemChecked(i, True)
            Next
            Me.txtZipCode.Text = ""
            Me.nupMiles.Value = 0
            Me.lbZipCity.Items.Clear()
            Dim c As New WarmCalling
            c.ManagerCriteria()
            c.Populate()

            Me.btnClear.Enabled = True
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "WCaller", "FormCode", "Event", "btnClear_Click", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Public Sub lblCheckAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


        For i As Integer = 0 To Me.lbZipCity.Items.Count - 1
            Me.lbZipCity.SetItemChecked(i, True)
        Next


    End Sub

    Private Sub lblUncheckAll_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        For i As Integer = 0 To Me.lbZipCity.Items.Count - 1
            Me.lbZipCity.SetItemChecked(i, False)
        Next
    End Sub

    Private Sub btnUndoMemorize_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUndoMemorize.Click
        Try
            If Me.lvMyAppts.SelectedItems.Count = 0 Then
                MsgBox("You must Select a Record!", MsgBoxStyle.Exclamation, "No Record Selected")
                Exit Sub
            End If

            Dim cnn As SqlConnection = New SqlConnection(STATIC_VARIABLES.Cnn)
            Dim cmdGet As SqlCommand = New SqlCommand("dbo.RemoveMemorized", cnn)
            Dim r1 As SqlDataReader
            Dim param1 As SqlParameter = New SqlParameter("@User", STATIC_VARIABLES.CurrentUser)
            Dim param2 As SqlParameter = New SqlParameter("@Form", "Warm Calling")
            Dim param3 As SqlParameter = New SqlParameter("@ID", Me.lvMyAppts.SelectedItems(0).Tag)

            cmdGet.Parameters.Add(param1)
            cmdGet.Parameters.Add(param2)
            cmdGet.Parameters.Add(param3)

            cmdGet.CommandType = CommandType.StoredProcedure
            cnn.Open()
            r1 = cmdGet.ExecuteReader(CommandBehavior.CloseConnection)
            r1.Read()
            r1.Close()
            cnn.Close()

            Me.lvMyAppts.SelectedItems(0).Remove()
            If Me.lvMyAppts.Items.Count <> 0 Then
                Me.lvMyAppts.TopItem.Selected = True
            End If

        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "WCaller", "FormCode", "Event", "btnUndoMemorize_Click", "0", ex.Message.ToString)
            y = Nothing
        End Try


    End Sub

    Private Sub cboGroupBy_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        If Me.cboGroupBy.Text = "" Then
            Me.lblGroupBy.Visible = True
        End If
    End Sub

    Private Sub cboGroupBy_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.lblGroupBy.Visible = False
    End Sub

    Private Sub lblGroupBy_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.cboGroupBy.Focus()
    End Sub

    Private Sub txtTime1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.txtTime1.Visible = False
        Me.dtpTime1.Focus()
        Me.txtTime1.Text = Me.dtpTime1.Value.ToShortTimeString
    End Sub

    Private Sub txtTime2_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.txtTime2.Visible = False
        Me.dptTime2.Focus()
        Me.txtTime2.Text = Me.dptTime2.Value.ToShortTimeString
    End Sub

    Private Sub dtpTime1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.txtTime1.Text = Me.dtpTime1.Value.ToShortTimeString
    End Sub

    Private Sub dtpTime1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If Me.LoadComplete = False Then
            Exit Sub
        End If
        Me.txtTime1.Text = Me.dtpTime1.Value.ToShortTimeString
    End Sub

    Private Sub dptTime2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)

        Me.txtTime2.Text = Me.dptTime2.Value.ToShortTimeString
    End Sub

    Private Sub dptTime2_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If Me.LoadComplete = False Then
            Exit Sub
        End If
        Me.txtTime2.Text = Me.dptTime2.Value.ToShortTimeString
    End Sub

    Private Sub txtDate2_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.dtp2.Focus()
        Me.txtDate2.Visible = False

        Me.txtDate2.Text = Me.dtp2.Value.ToShortDateString
        Me.cboDateRange.Text = "Custom"
    End Sub

    Private Sub txtDate1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.txtDate1.Visible = False
        Me.dtp1.Focus()
        Me.txtDate1.Text = Me.dtp1.Value.ToShortDateString
        Me.cboDateRange.Text = "Custom"
    End Sub

    Private Sub dtp1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.txtDate1.Visible = False
        Me.txtDate1.Text = Me.dtp1.Value.ToShortDateString
        'Me.txtDate2.Visible = False
        Me.cboDateRange.Text = "Custom"
    End Sub

    Private Sub dtp1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            If Me.txtDate1.Text = Me.LastD1 And Me.txtDate2.Text = Me.LastD2 Then
                Exit Sub
            End If
            Dim c As New WarmCalling
            c.Populate()
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "WCaller", "FormCode", "Event", "dtp1_lostFocus", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub dtp1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If Me.LoadComplete = False Then
            Exit Sub
        End If
        Me.txtDate1.Text = Me.dtp1.Value.ToShortDateString

    End Sub

    Private Sub dtp2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        'Me.txtDate1.Visible = False
        Me.txtDate2.Text = Me.dtp2.Value.ToShortDateString
        Me.txtDate2.Visible = False
        Me.cboDateRange.Text = "Custom"
    End Sub

    Private Sub dtp2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            Dim c As New WarmCalling
            'If Me.txtDate1.Text = "" Then
            '    MsgBox("You must supply a ""Start Date""", MsgBoxStyle.Exclamation, "Please Supply a Date")
            '    Me.dtp1.Focus()
            '    Exit Sub
            'End If
            If Me.LastD1 = Me.txtDate1.Text And Me.LastD2 = Me.txtDate2.Text Then
                Exit Sub
            End If
            c.Populate()
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "WCaller", "FormCode", "Event", "dtp2_lostfocus", "0", ex.Message.ToString)
            y = Nothing
        End Try



    End Sub

    Private Sub dtp2_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If Me.LoadComplete = False Then
            Exit Sub
        End If
        Me.txtDate2.Text = Me.dtp2.Value.ToShortDateString

    End Sub

    Private Sub cboDateRange_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            If Me.LoadComplete = False Then
                Exit Sub
            End If
            If Me.cboDateRange.Text = "All" Then
                Me.txtDate1.Text = ""
                Me.txtDate1.Visible = True
                Me.txtDate2.Text = ""
                Me.txtDate2.Visible = True

            End If

            If Me.cboDateRange.Text <> "All" And Me.cboDateRange.Text <> "Custom" Then
                Dim d As New DTPManipulation(Me.cboDateRange.Text)
                Me.dtp1.Value = d.retDateFrom
                Me.dtp2.Value = d.retDateTo
                Me.txtDate1.Visible = False
                Me.txtDate2.Visible = False
                Me.txtDate1.Text = d.retDateFrom.ToString
                Me.txtDate2.Text = d.retDateTo.ToString
            End If
            If Me.LastD1 = Me.txtDate1.Text And Me.LastD2 = Me.txtDate2.Text Then
                Exit Sub
            End If
            Dim c As New WarmCalling
            c.Populate()
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "WCaller", "FormCode", "Event", "cboDateRange_SelectedIndexChanged", "0", ex.Message.ToString)
            y = Nothing
        End Try


    End Sub

    Public Sub btnZipCity_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            Me.Cursor = Cursors.WaitCursor
            Me.pbRadiusSearch.Value = 0
            Me.pbRadiusSearch.Visible = True
            Me.btnZipCity.Enabled = False
            If Me.txtZipCode.Text = "" Or Me.nupMiles.Value = 0 Then
                MsgBox("You must supply a starting point and" & vbCr & "supply a radius of at least 1 mile!", MsgBoxStyle.Exclamation, "Please supply Values")
                Me.btnZipCity.Enabled = True
                Exit Sub

            End If

            Dim c As New MAPPOINT_LOGIC
            If Me.rdoZip.Checked = True Then
                c.DoIt(Me.nupMiles.Value, Me.txtZipCode.Text)
            Else
                Dim b As New GetStateFromCity(Me.txtZipCode.Text)

                '' private class : getstatefromcity(arg) 
                '' lines: 1038-1069
                '' 

                c.DoItCity(Me.nupMiles.Value, Me.txtZipCode.Text, b.StatePulled)
            End If
            Me.btnZipCity.Enabled = True
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "WCaller", "FormCode", "Event", "btnZipCity_click", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub cboGroupBy_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            If Me.LoadComplete = False Then
                Exit Sub
            End If
            Dim c As New WarmCalling
            If Me.cboGroupBy.Text = "" Then
                Me.lvCallList.Groups.Clear()
                c.Populate()

                Exit Sub
            End If
            c.GroupBy()
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "WCaller", "FormCode", "Event", "cboGroupBy_selectedValueChanged", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub cboPLSWarmCalling_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim c As New WarmCalling


            If Me.LoadComplete = False Then
                Exit Sub
            End If
            If Me.cboPLSWarmCalling.Text <> "" Then
                c.GetSLS(Me.cboPLSWarmCalling.Text)
            End If

            c.Populate()
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "WCaller", "FormCode", "Event", "cboPLSWarmCalling_selectedINdexChanged", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub cboSLSWarmCalling_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            If Me.LoadComplete = False Then
                Exit Sub
            End If
            Dim c As New WarmCalling
            c.Populate()
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "WCaller", "FormCode", "Event", "cboSLSWarmCalling_SelectedINdexChanged", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Cursor = Cursors.WaitCursor
            If Me.lbZipCity.Items.Count > 0 And Me.lbZipCity.CheckedItems.Count = 0 Then
                MsgBox("You must check at least 1 Zip/City to Search", MsgBoxStyle.Exclamation, "No Zip/City Selected")
                Me.lbZipCity.SetSelected(0, True)
                Me.lbZipCity.SetItemChecked(0, True)
                Exit Sub
            End If
            If Me.chlstResults.CheckedItems.Count = 0 Then
                MsgBox("You must check at least 1 marketing result to search", MsgBoxStyle.Exclamation, "No Marketing Result Selected")
                Exit Sub
            End If
            Dim c As New WarmCalling
            c.Populate()
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "WCaller", "FormCode", "Event", "btnSearch_Click", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub btnKill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.Tab = "WC" Then
            If Me.lvCallList.SelectedItems.Count = 0 Then
                MsgBox("You must Select a Record!", MsgBoxStyle.Exclamation, "No Record Selected")
                Exit Sub
            End If
        Else
            If Me.lvMyAppts.SelectedItems.Count = 0 Then
                MsgBox("You must Select a Record!", MsgBoxStyle.Exclamation, "No Record Selected")
                Exit Sub
            End If
        End If


        Dim x As New SubForm_Launcher(sender)
    End Sub

    Private Sub btnDoNotCall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If Me.Tab = "WC" Then
                If Me.lvCallList.SelectedItems.Count = 0 Then
                    MsgBox("You must Select a Record!", MsgBoxStyle.Exclamation, "No Record Selected")
                    Exit Sub
                Else
                    Dim c As New DoNotCallOrMail
                    c.DoNot(Me.lvCallList.SelectedItems(0).Text, sender.text.ToString)
                End If
                Dim i As Integer = Me.lvCallList.Items.IndexOfKey(Me.lvCallList.SelectedItems(0).Text)
                Dim x As New WarmCalling.MyApptsTab.Populate(Me.cboFilter.Text)
                Me.lvCallList.SelectedItems(0).Remove()
                Me.txtRecordsMatching.Text = CStr(CInt(Me.txtRecordsMatching.Text) - 1)
                If Me.lvCallList.Items.Count <> 0 Then
                    If i > Me.lvCallList.Items.Count - 1 Then
                        Me.lvCallList.Items(i - 1).Selected = True
                    Else
                        Me.lvCallList.Items(i).Selected = True
                    End If
                Else
                    Dim wc As New WarmCalling
                    wc.PullCustomerINFO("")
                End If
            Else
                If Me.lvMyAppts.SelectedItems.Count = 0 Then
                    MsgBox("You must Select a Record!", MsgBoxStyle.Exclamation, "No Record Selected")
                    Exit Sub
                Else
                    Dim c As New DoNotCallOrMail
                    c.DoNot(Me.lvMyAppts.SelectedItems(0).Tag, sender.text.ToString)
                    Dim y As New WarmCalling
                    y.Populate()
                    Dim x As New WarmCalling.MyApptsTab.Populate(Me.cboFilter.Text)
                End If
            End If
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "WCaller", "FormCode", "Event", "btnDoNotCall_Click", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub btnDoNotMail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If Me.Tab = "WC" Then

                If Me.lvCallList.SelectedItems.Count = 0 Then
                    MsgBox("You must Select a Record!", MsgBoxStyle.Exclamation, "No Record Selected")
                    Exit Sub
                Else
                    Dim y As New DoNotCallOrMail
                    y.DoNot(Me.lvCallList.SelectedItems(0).Text, sender.text.ToString)
                End If
                Dim c As New CustomerHistory
                c.SetUp(Me.TScboCustomerHistory)
            Else
                If Me.lvMyAppts.SelectedItems.Count = 0 Then
                    MsgBox("You must Select a Record!", MsgBoxStyle.Exclamation, "No Record Selected")
                    Exit Sub
                Else
                    Dim x As New DoNotCallOrMail
                    x.DoNot(Me.lvMyAppts.SelectedItems(0).Tag, sender.text.ToString)
                End If
                Dim c As New CustomerHistory
                c.SetUp(Me.TScboCustomerHistory)
            End If
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "WCaller", "FormCode", "Event", "btnDoNotMail_click", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub btnDoNotCallOrMail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If Me.Tab = "WC" Then
                If Me.lvCallList.SelectedItems.Count = 0 Then
                    MsgBox("You must Select a Record!", MsgBoxStyle.Exclamation, "No Record Selected")
                    Exit Sub
                Else
                    Dim c As New DoNotCallOrMail
                    c.DoNot(Me.lvCallList.SelectedItems(0).Text, sender.text.ToString)
                End If
                Dim x As New WarmCalling.MyApptsTab.Populate(Me.cboFilter.Text)
                Dim i As Integer = Me.lvCallList.Items.IndexOfKey(Me.lvCallList.SelectedItems(0).Text)
                Me.lvCallList.SelectedItems(0).Remove()
                Me.txtRecordsMatching.Text = CStr(CInt(Me.txtRecordsMatching.Text) - 1)
                If Me.lvCallList.Items.Count <> 0 Then
                    If i > Me.lvCallList.Items.Count - 1 Then
                        Me.lvCallList.Items(i - 1).Selected = True
                    Else
                        Me.lvCallList.Items(i).Selected = True
                    End If
                Else
                    Dim wc As New WarmCalling
                    wc.PullCustomerINFO("")
                End If
            Else
                If Me.lvMyAppts.SelectedItems.Count = 0 Then
                    MsgBox("You must Select a Record!", MsgBoxStyle.Exclamation, "No Record Selected")
                    Exit Sub
                Else
                    Dim c As New DoNotCallOrMail
                    c.DoNot(Me.lvMyAppts.SelectedItems(0).Tag, sender.text.ToString)
                    Dim y As New WarmCalling
                    y.Populate()
                    Dim x As New WarmCalling.MyApptsTab.Populate(Me.cboFilter.Text)

                End If
            End If
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "WCaller", "FormCode", "Event", "btnDoNotCallOrMail_click", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Class AutoCompleteSourceCities
        Private cnn As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection(STATIC_VARIABLES.Cnn)
        Public Sub New()
            Try
                WCaller.lbZipCity.Items.Clear()
                WCaller.txtZipCode.AutoCompleteSource = AutoCompleteSource.CustomSource
                Dim cmdGET As SqlCommand = New SqlCommand("SELECT City,State from .citypull", cnn)
                Dim r1 As SqlDataReader
                cnn.Open()
                r1 = cmdGET.ExecuteReader
                WCaller.txtZipCode.AutoCompleteCustomSource.Clear()
                While r1.Read
                    WCaller.txtZipCode.AutoCompleteCustomSource.Add(r1.Item(0).ToString)
                End While
                r1.Close()
                cnn.Close()
            Catch ex As Exception
                Dim y As New ErrorLogging_V2
                y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "WCaller", "FormCode", "Constructor", "WCaller.AutoCompleteSourceCities.New()", "0", ex.Message.ToString)
                y = Nothing
            End Try

        End Sub
    End Class

    Private Class GetStateFromCity
        Private cnn As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection(static_variables.cnn)
        Private ST As String = ""
        Public Property StatePulled() As String
            Get
                Return ST
            End Get
            Set(ByVal value As String)
                ST = value
            End Set
        End Property
        Public Sub New(ByVal City As String)
            Try
                Dim cmdGET As SqlCommand = New SqlCommand("SELECT state from .citypull where city = @CTY", cnn)
                Dim param1 As SqlParameter = New SqlParameter("@CTY", City)
                cmdGET.Parameters.Add(param1)
                Dim r1 As SqlDataReader
                cnn.Open()
                r1 = cmdGET.ExecuteReader
                While r1.Read
                    Me.StatePulled = r1.Item(0)
                End While
                r1.Close()
                cnn.Close()
            Catch ex As Exception
                Dim y As New ErrorLogging_V2
                y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "WCaller", "FormCode", "Constructor", "WCaller.GetStateFromCity.new(city)", "0", ex.Message.ToString)
                y = Nothing
            End Try

        End Sub
    End Class


    Private Sub txtZipCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            If IsNumeric(Me.txtZipCode.Text) = True Then
                Exit Sub
            Else
                Dim c As New GetStateFromCity(Me.txtZipCode.Text)
            End If
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "WCaller", "FormCode", "Event", "txtZipCode_LostFocus", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub MemorizeThisApptToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        If Me.lvCallList.SelectedItems.Count = 0 Then
            MsgBox("You must Select a Record!", MsgBoxStyle.Exclamation, "No Record Selected")
            Exit Sub
        End If


        MemorizeNotes.ShowDialog()

    End Sub

    Private Sub btnEditCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim x As New WarmCalling.MyApptsTab.Populate(Me.cboGroupBy.Text)
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "WCaller", "FormCode", "Event", "button1_click", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub cboDisplayColumn_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.lblDisplayColumn.Visible = False
    End Sub

    Private Sub cboDisplayColumn_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        If Me.cboDisplayColumn.Text = "" Then
            Me.lblDisplayColumn.Visible = True
        End If
    End Sub

    Private Sub cboDisplayColumn_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim c As New WarmCalling.MyApptsTab.DisplayColumn()
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "WCaller", "FormCode", "Event", "cboDisplayColumn_SelectedINdexChanged", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub cboFilter_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.lblFilter.Visible = False
    End Sub

    Private Sub cboFilter_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        If Me.cboFilter.Text = "" Then
            Me.lblFilter.Visible = True
        End If
    End Sub

    Private Sub cboFilter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim c As New WarmCalling.MyApptsTab.Populate(Me.cboFilter.Text)
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "WCaller", "FormCode", "Event", "cboFilter_SelectedIndexChanged", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub cboGroupSetAppt_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.lblGroupSetAppts.Visible = False
    End Sub

    Private Sub cboGroupSetAppt_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        If Me.cboGroupSetAppt.Text = "" Then
            Me.lblGroupSetAppts.Visible = True
        End If
    End Sub

    Private Sub lblGroupSetAppts_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.cboGroupSetAppt.Focus()
    End Sub

    Private Sub lblDisplayColumn_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.cboDisplayColumn.Focus()
    End Sub

    Private Sub lblFilter_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.cboFilter.Focus()
    End Sub

    Private Sub cboGroupSetAppt_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim c As New WarmCalling.MyApptsTab.Populate(Me.cboFilter.Text)
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "WCaller", "FormCode", "Event", "cboGroupSetAppt_SelectedINdexChanged", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub btnUndoSet_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUndoSet.Click
        'Me.lvMyAppts.SelectedItems(0).Remove()
        Try
            Dim cnn As SqlConnection = New SqlConnection(STATIC_VARIABLES.Cnn)
            Dim cmdGet As SqlCommand = New SqlCommand("dbo.UndoSet", cnn)
            Dim r1 As SqlDataReader
            Dim param1 As SqlParameter = New SqlParameter("@User", STATIC_VARIABLES.CurrentUser)
            Dim param2 As SqlParameter = New SqlParameter("@ID", Me.lvMyAppts.SelectedItems(0).Tag)

            cmdGet.Parameters.Add(param1)
            cmdGet.Parameters.Add(param2)
            cmdGet.CommandType = CommandType.StoredProcedure
            cnn.Open()
            r1 = cmdGet.ExecuteReader(CommandBehavior.CloseConnection)
            r1.Read()
            r1.Close()
            cnn.Close()
            Dim c As New WarmCalling
            Dim y As New WarmCalling.MyApptsTab.Populate(Me.cboFilter.Text)
            c.Populate()
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "WCaller", "FormCode", "Event", "btnUndoSet_Click", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub btnSetAppt_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim x As New SubForm_Launcher(sender)
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "WCaller", "FormCode", "Event", "BtnSetAppt_ButtonClick", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub WCaller_ResizeEnd(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ResizeEnd
        Dim x As Integer = Me.pnlSearch.Size.Height
        If Me.btnExpandCollapse.Parent.Name = "pnlSearch" Then
            Me.btnExpandCollapse.Size = New Size(Me.btnExpandCollapse.Size.Width, x - 6)


        End If
    End Sub




    Private Sub lnkEmail_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        frmLinkSendEmail.Cust_Email = Me.lnkEmail.Text
        frmLinkSendEmail.RecID = STATIC_VARIABLES.CurrentID
        frmLinkSendEmail.Show()
        frmLinkSendEmail.BringToFront()
    End Sub

    Private Sub btnEditSPI_Click(sender As Object, e As EventArgs)

        Dim x As New SubForm_Launcher(sender)
    End Sub
End Class