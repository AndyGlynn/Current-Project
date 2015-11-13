<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WCaller
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WCaller))
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("My Set Appointments", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup2 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("My Memorized Appointments", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"", "Jonas, John & Becky", "7/30/2008 - 11:00 PM", "(419) 472-2496", "4906 Ridgedale Rd. Toledo, OH 43613", "Roof - Windows"}, 8)
        Me.tsWarmCalling = New System.Windows.Forms.ToolStrip
        Me.btnSetAppt = New System.Windows.Forms.ToolStripSplitButton
        Me.MemorizeThisApptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.btnEditCustomer = New System.Windows.Forms.ToolStripButton
        Me.btnChangeStatus = New System.Windows.Forms.ToolStripDropDownButton
        Me.btnKill = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.btnDoNotCall = New System.Windows.Forms.ToolStripMenuItem
        Me.btnDoNotMail = New System.Windows.Forms.ToolStripMenuItem
        Me.btnDoNotCallOrMail = New System.Windows.Forms.ToolStripMenuItem
        Me.lblTo = New System.Windows.Forms.ToolStripLabel
        Me.lblFrom = New System.Windows.Forms.ToolStripLabel
        Me.cboDateRange = New System.Windows.Forms.ToolStripComboBox
        Me.lblDateRange = New System.Windows.Forms.ToolStripLabel
        Me.btnAutoDialer = New System.Windows.Forms.ToolStripDropDownButton
        Me.LaunchProgressiveDialerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.TabControl2 = New System.Windows.Forms.TabControl
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.lblGroupBy = New System.Windows.Forms.Label
        Me.cboGroupBy = New System.Windows.Forms.ComboBox
        Me.btnExpandWarmCalling = New System.Windows.Forms.Button
        Me.lblToChangeWarmCalling = New System.Windows.Forms.Label
        Me.lblSLSWarmCalling = New System.Windows.Forms.Label
        Me.lblPLSWarmCalling = New System.Windows.Forms.Label
        Me.cboSLSWarmCalling = New System.Windows.Forms.ComboBox
        Me.cboPLSWarmCalling = New System.Windows.Forms.ComboBox
        Me.lvWarmCalling = New System.Windows.Forms.ListView
        Me.LeadID = New System.Windows.Forms.ColumnHeader
        Me.ApptDate = New System.Windows.Forms.ColumnHeader
        Me.ApptTime = New System.Windows.Forms.ColumnHeader
        Me.Contacts = New System.Windows.Forms.ColumnHeader
        Me.Address = New System.Windows.Forms.ColumnHeader
        Me.Products = New System.Windows.Forms.ColumnHeader
        Me.Result = New System.Windows.Forms.ColumnHeader
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.lblFilter = New System.Windows.Forms.Label
        Me.lblGroupSetAppts = New System.Windows.Forms.Label
        Me.lblDisplayColumn = New System.Windows.Forms.Label
        Me.cboGroupSetAppt = New System.Windows.Forms.ComboBox
        Me.cboDisplayColumn = New System.Windows.Forms.ComboBox
        Me.cboFilter = New System.Windows.Forms.ComboBox
        Me.btnExpandMyAppts = New System.Windows.Forms.Button
        Me.lblToChangeMyAppts = New System.Windows.Forms.Label
        Me.lvMyAppts = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader("Notes4.ico")
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ilCustomerHistory = New System.Windows.Forms.ImageList(Me.components)
        Me.pnlSearch = New System.Windows.Forms.Panel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.chlstResults = New System.Windows.Forms.CheckedListBox
        Me.cbWeekdays = New System.Windows.Forms.CheckBox
        Me.btnExpandCollapse = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtRecordsMatching = New System.Windows.Forms.TextBox
        Me.btnSearch = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.txtZipCode = New System.Windows.Forms.TextBox
        Me.pbRadiusSearch = New System.Windows.Forms.ProgressBar
        Me.lblUncheckAll = New System.Windows.Forms.Label
        Me.lblCheckAll = New System.Windows.Forms.Label
        Me.btnZipCity = New System.Windows.Forms.Button
        Me.rdoCity = New System.Windows.Forms.RadioButton
        Me.rdoZip = New System.Windows.Forms.RadioButton
        Me.nupMiles = New System.Windows.Forms.NumericUpDown
        Me.lblShow = New System.Windows.Forms.Label
        Me.lblEnter = New System.Windows.Forms.Label
        Me.lbZipCity = New System.Windows.Forms.CheckedListBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.txtTime2 = New System.Windows.Forms.TextBox
        Me.txtTime1 = New System.Windows.Forms.TextBox
        Me.dptTime2 = New System.Windows.Forms.DateTimePicker
        Me.dtpTime1 = New System.Windows.Forms.DateTimePicker
        Me.Label86 = New System.Windows.Forms.Label
        Me.Label87 = New System.Windows.Forms.Label
        Me.gbSpecialInstructions = New System.Windows.Forms.GroupBox
        Me.rtbSpecialInstructions = New System.Windows.Forms.RichTextBox
        Me.gbProductInfo = New System.Windows.Forms.GroupBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.txtProducts = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblQty = New System.Windows.Forms.Label
        Me.ComboBox5 = New System.Windows.Forms.ComboBox
        Me.txtColor = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblColor = New System.Windows.Forms.Label
        Me.ComboBox6 = New System.Windows.Forms.ComboBox
        Me.txtQty = New System.Windows.Forms.TextBox
        Me.lblProducts = New System.Windows.Forms.Label
        Me.gbApptInfo = New System.Windows.Forms.GroupBox
        Me.txtApptDate = New System.Windows.Forms.TextBox
        Me.txtApptTime = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.lblApptDate = New System.Windows.Forms.Label
        Me.lblApptDay = New System.Windows.Forms.Label
        Me.txtApptDay = New System.Windows.Forms.TextBox
        Me.gbHomeInfo = New System.Windows.Forms.GroupBox
        Me.txtHomeValue = New System.Windows.Forms.TextBox
        Me.txtYrsOwned = New System.Windows.Forms.TextBox
        Me.lblYrBuilt = New System.Windows.Forms.Label
        Me.lblYrsOwned = New System.Windows.Forms.Label
        Me.lblHomeValue = New System.Windows.Forms.Label
        Me.txtYrBuilt = New System.Windows.Forms.TextBox
        Me.gbContactInfo = New System.Windows.Forms.GroupBox
        Me.txtWorkHours = New System.Windows.Forms.RichTextBox
        Me.tsAutoDial = New System.Windows.Forms.ToolStrip
        Me.tsbtnPreviousRecord = New System.Windows.Forms.ToolStripButton
        Me.tsbtnNextRecord = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbtnHousePhone = New System.Windows.Forms.ToolStripSplitButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tslblCalling = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbtnCloseDialer = New System.Windows.Forms.ToolStripButton
        Me.txtHousePhone = New System.Windows.Forms.TextBox
        Me.txtaltphone2 = New System.Windows.Forms.TextBox
        Me.txtaltphone1 = New System.Windows.Forms.TextBox
        Me.lnkEmail = New System.Windows.Forms.LinkLabel
        Me.lblEmail = New System.Windows.Forms.Label
        Me.txtAlt1Type = New System.Windows.Forms.TextBox
        Me.txtAlt2Type = New System.Windows.Forms.TextBox
        Me.lblAltPhone2 = New System.Windows.Forms.Label
        Me.lblAltPhone1 = New System.Windows.Forms.Label
        Me.pctVerified = New System.Windows.Forms.PictureBox
        Me.lblHousePhone = New System.Windows.Forms.Label
        Me.lblWorkHours = New System.Windows.Forms.Label
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.lblAddress = New System.Windows.Forms.Label
        Me.txtContact2 = New System.Windows.Forms.TextBox
        Me.txtContact1 = New System.Windows.Forms.TextBox
        Me.lblContact2 = New System.Windows.Forms.Label
        Me.lblContact1 = New System.Windows.Forms.Label
        Me.ListView4 = New System.Windows.Forms.ListView
        Me.tsCustomerLog = New System.Windows.Forms.ToolStrip
        Me.TScboCustomerHistory = New System.Windows.Forms.ToolStripComboBox
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.btnLogCall = New System.Windows.Forms.ToolStripSplitButton
        Me.LogAsCalledCancelledToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
        Me.pnlCustomerHistory = New System.Windows.Forms.Panel
        Me.ttCustomerHistoryNotes = New System.Windows.Forms.ToolTip(Me.components)
        Me.ilToolStripIcons = New System.Windows.Forms.ImageList(Me.components)
        Me.dtp1 = New System.Windows.Forms.DateTimePicker
        Me.dtp2 = New System.Windows.Forms.DateTimePicker
        Me.ilSearch = New System.Windows.Forms.ImageList(Me.components)
        Me.txtDate1 = New System.Windows.Forms.TextBox
        Me.txtDate2 = New System.Windows.Forms.TextBox
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.tsWarmCalling.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.pnlSearch.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.nupMiles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.gbSpecialInstructions.SuspendLayout()
        Me.gbProductInfo.SuspendLayout()
        Me.gbApptInfo.SuspendLayout()
        Me.gbHomeInfo.SuspendLayout()
        Me.gbContactInfo.SuspendLayout()
        Me.tsAutoDial.SuspendLayout()
        CType(Me.pctVerified, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsCustomerLog.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tsWarmCalling
        '
        Me.tsWarmCalling.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsWarmCalling.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSetAppt, Me.btnEditCustomer, Me.btnChangeStatus, Me.lblTo, Me.lblFrom, Me.cboDateRange, Me.lblDateRange, Me.btnAutoDialer})
        Me.tsWarmCalling.Location = New System.Drawing.Point(0, 0)
        Me.tsWarmCalling.Name = "tsWarmCalling"
        Me.tsWarmCalling.Size = New System.Drawing.Size(990, 25)
        Me.tsWarmCalling.TabIndex = 2
        Me.tsWarmCalling.Text = "ToolStrip1"
        '
        'btnSetAppt
        '
        Me.btnSetAppt.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MemorizeThisApptToolStripMenuItem})
        Me.btnSetAppt.Image = CType(resources.GetObject("btnSetAppt.Image"), System.Drawing.Image)
        Me.btnSetAppt.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSetAppt.Name = "btnSetAppt"
        Me.btnSetAppt.Size = New System.Drawing.Size(129, 22)
        Me.btnSetAppt.Text = "Set Appointment"
        '
        'MemorizeThisApptToolStripMenuItem
        '
        Me.MemorizeThisApptToolStripMenuItem.Image = CType(resources.GetObject("MemorizeThisApptToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MemorizeThisApptToolStripMenuItem.Name = "MemorizeThisApptToolStripMenuItem"
        Me.MemorizeThisApptToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.MemorizeThisApptToolStripMenuItem.Text = "Memorize This Appt."
        '
        'btnEditCustomer
        '
        Me.btnEditCustomer.Image = CType(resources.GetObject("btnEditCustomer.Image"), System.Drawing.Image)
        Me.btnEditCustomer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEditCustomer.Name = "btnEditCustomer"
        Me.btnEditCustomer.Size = New System.Drawing.Size(102, 22)
        Me.btnEditCustomer.Text = "Edit Customer"
        '
        'btnChangeStatus
        '
        Me.btnChangeStatus.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnKill, Me.ToolStripSeparator4, Me.btnDoNotCall, Me.btnDoNotMail, Me.btnDoNotCallOrMail})
        Me.btnChangeStatus.Image = CType(resources.GetObject("btnChangeStatus.Image"), System.Drawing.Image)
        Me.btnChangeStatus.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnChangeStatus.Name = "btnChangeStatus"
        Me.btnChangeStatus.Size = New System.Drawing.Size(112, 22)
        Me.btnChangeStatus.Text = "Change Status"
        '
        'btnKill
        '
        Me.btnKill.Image = CType(resources.GetObject("btnKill.Image"), System.Drawing.Image)
        Me.btnKill.Name = "btnKill"
        Me.btnKill.Size = New System.Drawing.Size(221, 22)
        Me.btnKill.Text = "Kill Appointment"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(218, 6)
        '
        'btnDoNotCall
        '
        Me.btnDoNotCall.Image = CType(resources.GetObject("btnDoNotCall.Image"), System.Drawing.Image)
        Me.btnDoNotCall.Name = "btnDoNotCall"
        Me.btnDoNotCall.Size = New System.Drawing.Size(221, 22)
        Me.btnDoNotCall.Text = "Mark as Do Not Call"
        '
        'btnDoNotMail
        '
        Me.btnDoNotMail.Image = CType(resources.GetObject("btnDoNotMail.Image"), System.Drawing.Image)
        Me.btnDoNotMail.Name = "btnDoNotMail"
        Me.btnDoNotMail.Size = New System.Drawing.Size(221, 22)
        Me.btnDoNotMail.Text = "Mark as Do Not Mail"
        '
        'btnDoNotCallOrMail
        '
        Me.btnDoNotCallOrMail.Image = CType(resources.GetObject("btnDoNotCallOrMail.Image"), System.Drawing.Image)
        Me.btnDoNotCallOrMail.Name = "btnDoNotCallOrMail"
        Me.btnDoNotCallOrMail.Size = New System.Drawing.Size(221, 22)
        Me.btnDoNotCallOrMail.Text = "Mark as Do Not Call Or Mail"
        '
        'lblTo
        '
        Me.lblTo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lblTo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTo.Margin = New System.Windows.Forms.Padding(0, 1, 115, 2)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(23, 22)
        Me.lblTo.Text = "To"
        '
        'lblFrom
        '
        Me.lblFrom.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lblFrom.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrom.Margin = New System.Windows.Forms.Padding(0, 1, 120, 2)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(39, 22)
        Me.lblFrom.Text = "From"
        '
        'cboDateRange
        '
        Me.cboDateRange.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.cboDateRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDateRange.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.cboDateRange.Items.AddRange(New Object() {"All", "Today", "Yesterday", "This Week", "This Week - to date", "This Month", "This Month - to date", "This Year", "This Year - to date", "Next Week", "Next Month", "Last Week", "Last Week - to date", "Last Month", "Last Month - to date", "Last Year", "Last Year - to date", "Custom"})
        Me.cboDateRange.Margin = New System.Windows.Forms.Padding(1, 0, 10, 0)
        Me.cboDateRange.Name = "cboDateRange"
        Me.cboDateRange.Size = New System.Drawing.Size(123, 25)
        '
        'lblDateRange
        '
        Me.lblDateRange.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lblDateRange.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateRange.Name = "lblDateRange"
        Me.lblDateRange.Size = New System.Drawing.Size(86, 22)
        Me.lblDateRange.Text = "Appt. Dates"
        '
        'btnAutoDialer
        '
        Me.btnAutoDialer.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaunchProgressiveDialerToolStripMenuItem})
        Me.btnAutoDialer.Image = CType(resources.GetObject("btnAutoDialer.Image"), System.Drawing.Image)
        Me.btnAutoDialer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAutoDialer.Name = "btnAutoDialer"
        Me.btnAutoDialer.Size = New System.Drawing.Size(95, 22)
        Me.btnAutoDialer.Text = "Auto Dialer"
        '
        'LaunchProgressiveDialerToolStripMenuItem
        '
        Me.LaunchProgressiveDialerToolStripMenuItem.Name = "LaunchProgressiveDialerToolStripMenuItem"
        Me.LaunchProgressiveDialerToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.LaunchProgressiveDialerToolStripMenuItem.Text = "Launch Progressive Dialer"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 25)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TabControl2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.pnlSearch)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbSpecialInstructions)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbProductInfo)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbApptInfo)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbHomeInfo)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbContactInfo)
        Me.SplitContainer1.Panel2.Controls.Add(Me.tsCustomerLog)
        Me.SplitContainer1.Panel2.Controls.Add(Me.pnlCustomerHistory)
        Me.SplitContainer1.Size = New System.Drawing.Size(990, 576)
        Me.SplitContainer1.SplitterDistance = 224
        Me.SplitContainer1.TabIndex = 3
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Controls.Add(Me.TabPage5)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl2.Location = New System.Drawing.Point(0, 0)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(224, 576)
        Me.TabControl2.TabIndex = 13
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.lblGroupBy)
        Me.TabPage4.Controls.Add(Me.cboGroupBy)
        Me.TabPage4.Controls.Add(Me.btnExpandWarmCalling)
        Me.TabPage4.Controls.Add(Me.lblToChangeWarmCalling)
        Me.TabPage4.Controls.Add(Me.lblSLSWarmCalling)
        Me.TabPage4.Controls.Add(Me.lblPLSWarmCalling)
        Me.TabPage4.Controls.Add(Me.cboSLSWarmCalling)
        Me.TabPage4.Controls.Add(Me.cboPLSWarmCalling)
        Me.TabPage4.Controls.Add(Me.lvWarmCalling)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(216, 550)
        Me.TabPage4.TabIndex = 0
        Me.TabPage4.Text = "Call List"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'lblGroupBy
        '
        Me.lblGroupBy.AutoSize = True
        Me.lblGroupBy.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblGroupBy.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGroupBy.ForeColor = System.Drawing.Color.Gray
        Me.lblGroupBy.Location = New System.Drawing.Point(12, 64)
        Me.lblGroupBy.Name = "lblGroupBy"
        Me.lblGroupBy.Size = New System.Drawing.Size(51, 13)
        Me.lblGroupBy.TabIndex = 86
        Me.lblGroupBy.Text = "Group By"
        '
        'cboGroupBy
        '
        Me.cboGroupBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGroupBy.FormattingEnabled = True
        Me.cboGroupBy.Items.AddRange(New Object() {"", "Marketing Result", "Primary Lead Source", "Primary Product", "Zip Code", "City, State"})
        Me.cboGroupBy.Location = New System.Drawing.Point(6, 61)
        Me.cboGroupBy.Name = "cboGroupBy"
        Me.cboGroupBy.Size = New System.Drawing.Size(175, 21)
        Me.cboGroupBy.TabIndex = 85
        '
        'btnExpandWarmCalling
        '
        Me.btnExpandWarmCalling.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExpandWarmCalling.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExpandWarmCalling.Location = New System.Drawing.Point(190, 7)
        Me.btnExpandWarmCalling.Name = "btnExpandWarmCalling"
        Me.btnExpandWarmCalling.Size = New System.Drawing.Size(22, 75)
        Me.btnExpandWarmCalling.TabIndex = 18
        Me.btnExpandWarmCalling.UseVisualStyleBackColor = True
        '
        'lblToChangeWarmCalling
        '
        Me.lblToChangeWarmCalling.AutoSize = True
        Me.lblToChangeWarmCalling.Font = New System.Drawing.Font("Tahoma", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToChangeWarmCalling.ForeColor = System.Drawing.Color.Gray
        Me.lblToChangeWarmCalling.Location = New System.Drawing.Point(266, 16)
        Me.lblToChangeWarmCalling.Name = "lblToChangeWarmCalling"
        Me.lblToChangeWarmCalling.Size = New System.Drawing.Size(559, 23)
        Me.lblToChangeWarmCalling.TabIndex = 17
        Me.lblToChangeWarmCalling.Text = "To Change Column Order Click And Drag Column Headers"
        '
        'lblSLSWarmCalling
        '
        Me.lblSLSWarmCalling.AutoSize = True
        Me.lblSLSWarmCalling.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblSLSWarmCalling.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSLSWarmCalling.ForeColor = System.Drawing.Color.Gray
        Me.lblSLSWarmCalling.Location = New System.Drawing.Point(12, 37)
        Me.lblSLSWarmCalling.Name = "lblSLSWarmCalling"
        Me.lblSLSWarmCalling.Size = New System.Drawing.Size(132, 13)
        Me.lblSLSWarmCalling.TabIndex = 16
        Me.lblSLSWarmCalling.Text = "Filter by Sec. Lead Source"
        '
        'lblPLSWarmCalling
        '
        Me.lblPLSWarmCalling.AutoSize = True
        Me.lblPLSWarmCalling.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblPLSWarmCalling.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblPLSWarmCalling.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPLSWarmCalling.ForeColor = System.Drawing.Color.Gray
        Me.lblPLSWarmCalling.Location = New System.Drawing.Point(12, 10)
        Me.lblPLSWarmCalling.Name = "lblPLSWarmCalling"
        Me.lblPLSWarmCalling.Size = New System.Drawing.Size(147, 13)
        Me.lblPLSWarmCalling.TabIndex = 15
        Me.lblPLSWarmCalling.Text = "Filter by Primary Lead Source"
        '
        'cboSLSWarmCalling
        '
        Me.cboSLSWarmCalling.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSLSWarmCalling.FormattingEnabled = True
        Me.cboSLSWarmCalling.Location = New System.Drawing.Point(6, 34)
        Me.cboSLSWarmCalling.Name = "cboSLSWarmCalling"
        Me.cboSLSWarmCalling.Size = New System.Drawing.Size(176, 21)
        Me.cboSLSWarmCalling.TabIndex = 14
        '
        'cboPLSWarmCalling
        '
        Me.cboPLSWarmCalling.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPLSWarmCalling.FormattingEnabled = True
        Me.cboPLSWarmCalling.Location = New System.Drawing.Point(6, 7)
        Me.cboPLSWarmCalling.Name = "cboPLSWarmCalling"
        Me.cboPLSWarmCalling.Size = New System.Drawing.Size(176, 21)
        Me.cboPLSWarmCalling.TabIndex = 13
        '
        'lvWarmCalling
        '
        Me.lvWarmCalling.AllowColumnReorder = True
        Me.lvWarmCalling.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvWarmCalling.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.LeadID, Me.ApptDate, Me.ApptTime, Me.Contacts, Me.Address, Me.Products, Me.Result})
        Me.lvWarmCalling.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lvWarmCalling.FullRowSelect = True
        Me.lvWarmCalling.HideSelection = False
        Me.lvWarmCalling.Location = New System.Drawing.Point(3, 95)
        Me.lvWarmCalling.MultiSelect = False
        Me.lvWarmCalling.Name = "lvWarmCalling"
        Me.lvWarmCalling.Size = New System.Drawing.Size(210, 452)
        Me.lvWarmCalling.TabIndex = 9
        Me.lvWarmCalling.UseCompatibleStateImageBehavior = False
        Me.lvWarmCalling.View = System.Windows.Forms.View.Details
        '
        'LeadID
        '
        Me.LeadID.Text = "ID"
        Me.LeadID.Width = 0
        '
        'ApptDate
        '
        Me.ApptDate.Text = "Appt. Date"
        Me.ApptDate.Width = 102
        '
        'ApptTime
        '
        Me.ApptTime.Text = "Appt. Time"
        Me.ApptTime.Width = 102
        '
        'Contacts
        '
        Me.Contacts.Text = "Contact(s)"
        Me.Contacts.Width = 200
        '
        'Address
        '
        Me.Address.Text = "Address"
        Me.Address.Width = 280
        '
        'Products
        '
        Me.Products.Text = "Product(s)"
        Me.Products.Width = 115
        '
        'Result
        '
        Me.Result.Text = "Marketing Result"
        Me.Result.Width = 129
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(138, 26)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(137, 22)
        Me.ToolStripMenuItem1.Text = "Show Notes"
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.lblFilter)
        Me.TabPage5.Controls.Add(Me.lblGroupSetAppts)
        Me.TabPage5.Controls.Add(Me.lblDisplayColumn)
        Me.TabPage5.Controls.Add(Me.cboGroupSetAppt)
        Me.TabPage5.Controls.Add(Me.cboDisplayColumn)
        Me.TabPage5.Controls.Add(Me.cboFilter)
        Me.TabPage5.Controls.Add(Me.btnExpandMyAppts)
        Me.TabPage5.Controls.Add(Me.lblToChangeMyAppts)
        Me.TabPage5.Controls.Add(Me.lvMyAppts)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(216, 550)
        Me.TabPage5.TabIndex = 1
        Me.TabPage5.Text = "My Set Appts."
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'lblFilter
        '
        Me.lblFilter.AutoSize = True
        Me.lblFilter.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblFilter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFilter.ForeColor = System.Drawing.Color.Gray
        Me.lblFilter.Location = New System.Drawing.Point(12, 10)
        Me.lblFilter.Name = "lblFilter"
        Me.lblFilter.Size = New System.Drawing.Size(67, 13)
        Me.lblFilter.TabIndex = 33
        Me.lblFilter.Text = "Filter My List"
        '
        'lblGroupSetAppts
        '
        Me.lblGroupSetAppts.AutoSize = True
        Me.lblGroupSetAppts.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblGroupSetAppts.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGroupSetAppts.ForeColor = System.Drawing.Color.Gray
        Me.lblGroupSetAppts.Location = New System.Drawing.Point(12, 64)
        Me.lblGroupSetAppts.Name = "lblGroupSetAppts"
        Me.lblGroupSetAppts.Size = New System.Drawing.Size(139, 13)
        Me.lblGroupSetAppts.TabIndex = 32
        Me.lblGroupSetAppts.Text = "Group Set Appointments By"
        '
        'lblDisplayColumn
        '
        Me.lblDisplayColumn.AutoSize = True
        Me.lblDisplayColumn.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDisplayColumn.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplayColumn.ForeColor = System.Drawing.Color.Gray
        Me.lblDisplayColumn.Location = New System.Drawing.Point(12, 37)
        Me.lblDisplayColumn.Name = "lblDisplayColumn"
        Me.lblDisplayColumn.Size = New System.Drawing.Size(117, 13)
        Me.lblDisplayColumn.TabIndex = 31
        Me.lblDisplayColumn.Text = "Change Dispay Column"
        '
        'cboGroupSetAppt
        '
        Me.cboGroupSetAppt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGroupSetAppt.FormattingEnabled = True
        Me.cboGroupSetAppt.Items.AddRange(New Object() {"", "Date", "Primary Product", "City, State", "Zip Code"})
        Me.cboGroupSetAppt.Location = New System.Drawing.Point(6, 61)
        Me.cboGroupSetAppt.Name = "cboGroupSetAppt"
        Me.cboGroupSetAppt.Size = New System.Drawing.Size(176, 21)
        Me.cboGroupSetAppt.TabIndex = 29
        '
        'cboDisplayColumn
        '
        Me.cboDisplayColumn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDisplayColumn.FormattingEnabled = True
        Me.cboDisplayColumn.Items.AddRange(New Object() {"", "Contact(s) (Default)", "Appt. Date/Time", "Product(s)"})
        Me.cboDisplayColumn.Location = New System.Drawing.Point(6, 34)
        Me.cboDisplayColumn.Name = "cboDisplayColumn"
        Me.cboDisplayColumn.Size = New System.Drawing.Size(176, 21)
        Me.cboDisplayColumn.TabIndex = 28
        '
        'cboFilter
        '
        Me.cboFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFilter.FormattingEnabled = True
        Me.cboFilter.Items.AddRange(New Object() {"", "Show Set Appointments", "Show Memorized Appointments"})
        Me.cboFilter.Location = New System.Drawing.Point(6, 7)
        Me.cboFilter.Name = "cboFilter"
        Me.cboFilter.Size = New System.Drawing.Size(176, 21)
        Me.cboFilter.TabIndex = 27
        '
        'btnExpandMyAppts
        '
        Me.btnExpandMyAppts.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExpandMyAppts.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExpandMyAppts.Location = New System.Drawing.Point(190, 7)
        Me.btnExpandMyAppts.Name = "btnExpandMyAppts"
        Me.btnExpandMyAppts.Size = New System.Drawing.Size(22, 75)
        Me.btnExpandMyAppts.TabIndex = 26
        Me.btnExpandMyAppts.UseVisualStyleBackColor = True
        '
        'lblToChangeMyAppts
        '
        Me.lblToChangeMyAppts.AutoSize = True
        Me.lblToChangeMyAppts.Font = New System.Drawing.Font("Tahoma", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToChangeMyAppts.ForeColor = System.Drawing.Color.Gray
        Me.lblToChangeMyAppts.Location = New System.Drawing.Point(266, 16)
        Me.lblToChangeMyAppts.Name = "lblToChangeMyAppts"
        Me.lblToChangeMyAppts.Size = New System.Drawing.Size(559, 23)
        Me.lblToChangeMyAppts.TabIndex = 25
        Me.lblToChangeMyAppts.Text = "To Change Column Order Click And Drag Column Headers"
        '
        'lvMyAppts
        '
        Me.lvMyAppts.AllowColumnReorder = True
        Me.lvMyAppts.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvMyAppts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader7, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lvMyAppts.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lvMyAppts.FullRowSelect = True
        ListViewGroup1.Header = "My Set Appointments"
        ListViewGroup1.Name = "grpMyAppts"
        ListViewGroup2.Header = "My Memorized Appointments"
        ListViewGroup2.Name = "grpMemorized"
        Me.lvMyAppts.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1, ListViewGroup2})
        Me.lvMyAppts.HideSelection = False
        ListViewItem1.Group = ListViewGroup1
        ListViewItem1.ToolTipText = "These people can only be seen on a Sat."
        Me.lvMyAppts.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.lvMyAppts.Location = New System.Drawing.Point(3, 95)
        Me.lvMyAppts.MultiSelect = False
        Me.lvMyAppts.Name = "lvMyAppts"
        Me.lvMyAppts.Size = New System.Drawing.Size(211, 452)
        Me.lvMyAppts.SmallImageList = Me.ilCustomerHistory
        Me.lvMyAppts.Sorting = System.Windows.Forms.SortOrder.Descending
        Me.lvMyAppts.StateImageList = Me.ilCustomerHistory
        Me.lvMyAppts.TabIndex = 10
        Me.lvMyAppts.UseCompatibleStateImageBehavior = False
        Me.lvMyAppts.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = ""
        Me.ColumnHeader1.Width = 46
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Contact(s)"
        Me.ColumnHeader2.Width = 160
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Appt. Date/Time"
        Me.ColumnHeader3.Width = 146
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "House Phone"
        Me.ColumnHeader7.Width = 101
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Address"
        Me.ColumnHeader4.Width = 280
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Product(s)"
        Me.ColumnHeader5.Width = 182
        '
        'ilCustomerHistory
        '
        Me.ilCustomerHistory.ImageStream = CType(resources.GetObject("ilCustomerHistory.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilCustomerHistory.TransparentColor = System.Drawing.Color.Transparent
        Me.ilCustomerHistory.Images.SetKeyName(0, "Confirmer.ico")
        Me.ilCustomerHistory.Images.SetKeyName(1, "cash.ico")
        Me.ilCustomerHistory.Images.SetKeyName(2, "marketing manager4.ico")
        Me.ilCustomerHistory.Images.SetKeyName(3, "Finance Dept.ico")
        Me.ilCustomerHistory.Images.SetKeyName(4, "hammerused.ico")
        Me.ilCustomerHistory.Images.SetKeyName(5, "recovery2.ico")
        Me.ilCustomerHistory.Images.SetKeyName(6, "phone4.ico")
        Me.ilCustomerHistory.Images.SetKeyName(7, "lock.ico")
        Me.ilCustomerHistory.Images.SetKeyName(8, "Notes4.ico")
        '
        'pnlSearch
        '
        Me.pnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlSearch.Controls.Add(Me.GroupBox1)
        Me.pnlSearch.Controls.Add(Me.btnExpandCollapse)
        Me.pnlSearch.Controls.Add(Me.Label2)
        Me.pnlSearch.Controls.Add(Me.txtRecordsMatching)
        Me.pnlSearch.Controls.Add(Me.btnSearch)
        Me.pnlSearch.Controls.Add(Me.btnClear)
        Me.pnlSearch.Controls.Add(Me.GroupBox5)
        Me.pnlSearch.Controls.Add(Me.GroupBox4)
        Me.pnlSearch.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlSearch.Location = New System.Drawing.Point(740, 0)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.Size = New System.Drawing.Size(22, 576)
        Me.pnlSearch.TabIndex = 198
        Me.pnlSearch.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.chlstResults)
        Me.GroupBox1.Controls.Add(Me.cbWeekdays)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(304, 95)
        Me.GroupBox1.TabIndex = 436
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(8, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 16)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "Marketing Result Filter:"
        '
        'chlstResults
        '
        Me.chlstResults.CheckOnClick = True
        Me.chlstResults.FormattingEnabled = True
        Me.chlstResults.Items.AddRange(New Object() {"Unconfirmed", "Called and Cancelled", "Reset", "Not Hit", "Not Issued"})
        Me.chlstResults.Location = New System.Drawing.Point(167, 11)
        Me.chlstResults.Name = "chlstResults"
        Me.chlstResults.Size = New System.Drawing.Size(123, 79)
        Me.chlstResults.TabIndex = 83
        '
        'cbWeekdays
        '
        Me.cbWeekdays.AutoSize = True
        Me.cbWeekdays.BackColor = System.Drawing.Color.Transparent
        Me.cbWeekdays.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbWeekdays.ForeColor = System.Drawing.Color.Black
        Me.cbWeekdays.Location = New System.Drawing.Point(33, 36)
        Me.cbWeekdays.Name = "cbWeekdays"
        Me.cbWeekdays.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cbWeekdays.Size = New System.Drawing.Size(91, 52)
        Me.cbWeekdays.TabIndex = 77
        Me.cbWeekdays.Text = "Weekday " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Appt. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Only"
        Me.cbWeekdays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cbWeekdays.UseVisualStyleBackColor = False
        '
        'btnExpandCollapse
        '
        Me.btnExpandCollapse.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExpandCollapse.Image = CType(resources.GetObject("btnExpandCollapse.Image"), System.Drawing.Image)
        Me.btnExpandCollapse.Location = New System.Drawing.Point(-2, 3)
        Me.btnExpandCollapse.Name = "btnExpandCollapse"
        Me.btnExpandCollapse.Size = New System.Drawing.Size(21, 570)
        Me.btnExpandCollapse.TabIndex = 435
        Me.btnExpandCollapse.TabStop = False
        Me.btnExpandCollapse.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExpandCollapse.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(29, 503)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 16)
        Me.Label2.TabIndex = 119
        Me.Label2.Text = "Number of records returned -"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtRecordsMatching
        '
        Me.txtRecordsMatching.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtRecordsMatching.BackColor = System.Drawing.Color.White
        Me.txtRecordsMatching.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecordsMatching.Location = New System.Drawing.Point(231, 500)
        Me.txtRecordsMatching.Name = "txtRecordsMatching"
        Me.txtRecordsMatching.ReadOnly = True
        Me.txtRecordsMatching.Size = New System.Drawing.Size(102, 23)
        Me.txtRecordsMatching.TabIndex = 118
        Me.txtRecordsMatching.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.Location = New System.Drawing.Point(189, 536)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(124, 23)
        Me.btnSearch.TabIndex = 116
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnClear.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.Location = New System.Drawing.Point(59, 536)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(124, 23)
        Me.btnClear.TabIndex = 117
        Me.btnClear.Text = "Clear Criteria"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.txtZipCode)
        Me.GroupBox5.Controls.Add(Me.pbRadiusSearch)
        Me.GroupBox5.Controls.Add(Me.lblUncheckAll)
        Me.GroupBox5.Controls.Add(Me.lblCheckAll)
        Me.GroupBox5.Controls.Add(Me.btnZipCity)
        Me.GroupBox5.Controls.Add(Me.rdoCity)
        Me.GroupBox5.Controls.Add(Me.rdoZip)
        Me.GroupBox5.Controls.Add(Me.nupMiles)
        Me.GroupBox5.Controls.Add(Me.lblShow)
        Me.GroupBox5.Controls.Add(Me.lblEnter)
        Me.GroupBox5.Controls.Add(Me.lbZipCity)
        Me.GroupBox5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Black
        Me.GroupBox5.Location = New System.Drawing.Point(29, 182)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(304, 309)
        Me.GroupBox5.TabIndex = 110
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Geography"
        '
        'txtZipCode
        '
        Me.txtZipCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtZipCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtZipCode.Location = New System.Drawing.Point(181, 78)
        Me.txtZipCode.Name = "txtZipCode"
        Me.txtZipCode.Size = New System.Drawing.Size(100, 23)
        Me.txtZipCode.TabIndex = 81
        '
        'pbRadiusSearch
        '
        Me.pbRadiusSearch.Location = New System.Drawing.Point(176, 286)
        Me.pbRadiusSearch.Name = "pbRadiusSearch"
        Me.pbRadiusSearch.Size = New System.Drawing.Size(113, 15)
        Me.pbRadiusSearch.TabIndex = 80
        Me.pbRadiusSearch.Visible = False
        '
        'lblUncheckAll
        '
        Me.lblUncheckAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblUncheckAll.AutoSize = True
        Me.lblUncheckAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblUncheckAll.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUncheckAll.ForeColor = System.Drawing.Color.Gray
        Me.lblUncheckAll.Location = New System.Drawing.Point(89, 286)
        Me.lblUncheckAll.Name = "lblUncheckAll"
        Me.lblUncheckAll.Size = New System.Drawing.Size(72, 13)
        Me.lblUncheckAll.TabIndex = 79
        Me.lblUncheckAll.Text = "Uncheck All"
        '
        'lblCheckAll
        '
        Me.lblCheckAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCheckAll.AutoSize = True
        Me.lblCheckAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblCheckAll.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCheckAll.ForeColor = System.Drawing.Color.Gray
        Me.lblCheckAll.Location = New System.Drawing.Point(15, 286)
        Me.lblCheckAll.Name = "lblCheckAll"
        Me.lblCheckAll.Size = New System.Drawing.Size(58, 13)
        Me.lblCheckAll.TabIndex = 78
        Me.lblCheckAll.Text = "Check All"
        '
        'btnZipCity
        '
        Me.btnZipCity.Location = New System.Drawing.Point(98, 152)
        Me.btnZipCity.Name = "btnZipCity"
        Me.btnZipCity.Size = New System.Drawing.Size(131, 26)
        Me.btnZipCity.TabIndex = 77
        Me.btnZipCity.Text = "Show Zip Codes"
        Me.btnZipCity.UseVisualStyleBackColor = True
        '
        'rdoCity
        '
        Me.rdoCity.AutoSize = True
        Me.rdoCity.Location = New System.Drawing.Point(15, 46)
        Me.rdoCity.Name = "rdoCity"
        Me.rdoCity.Size = New System.Drawing.Size(167, 20)
        Me.rdoCity.TabIndex = 75
        Me.rdoCity.Text = "Search by City Radius"
        Me.rdoCity.UseVisualStyleBackColor = True
        '
        'rdoZip
        '
        Me.rdoZip.AutoSize = True
        Me.rdoZip.Checked = True
        Me.rdoZip.Location = New System.Drawing.Point(15, 20)
        Me.rdoZip.Name = "rdoZip"
        Me.rdoZip.Size = New System.Drawing.Size(196, 20)
        Me.rdoZip.TabIndex = 74
        Me.rdoZip.TabStop = True
        Me.rdoZip.Text = "Search by Zip Code Radius"
        Me.rdoZip.UseVisualStyleBackColor = True
        '
        'nupMiles
        '
        Me.nupMiles.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nupMiles.Location = New System.Drawing.Point(167, 114)
        Me.nupMiles.Maximum = New Decimal(New Integer() {120, 0, 0, 0})
        Me.nupMiles.Name = "nupMiles"
        Me.nupMiles.Size = New System.Drawing.Size(44, 23)
        Me.nupMiles.TabIndex = 72
        '
        'lblShow
        '
        Me.lblShow.AutoSize = True
        Me.lblShow.BackColor = System.Drawing.Color.Transparent
        Me.lblShow.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShow.ForeColor = System.Drawing.Color.Black
        Me.lblShow.Location = New System.Drawing.Point(12, 114)
        Me.lblShow.Name = "lblShow"
        Me.lblShow.Size = New System.Drawing.Size(264, 32)
        Me.lblShow.TabIndex = 71
        Me.lblShow.Text = "Show Zip Codes within                miles of" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "starting zip code"
        '
        'lblEnter
        '
        Me.lblEnter.AutoSize = True
        Me.lblEnter.BackColor = System.Drawing.Color.Transparent
        Me.lblEnter.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnter.ForeColor = System.Drawing.Color.Black
        Me.lblEnter.Location = New System.Drawing.Point(12, 81)
        Me.lblEnter.Name = "lblEnter"
        Me.lblEnter.Size = New System.Drawing.Size(163, 16)
        Me.lblEnter.TabIndex = 70
        Me.lblEnter.Text = "Enter Starting Zip Code:"
        '
        'lbZipCity
        '
        Me.lbZipCity.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbZipCity.CheckOnClick = True
        Me.lbZipCity.ColumnWidth = 141
        Me.lbZipCity.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbZipCity.FormattingEnabled = True
        Me.lbZipCity.Location = New System.Drawing.Point(10, 184)
        Me.lbZipCity.MultiColumn = True
        Me.lbZipCity.Name = "lbZipCity"
        Me.lbZipCity.Size = New System.Drawing.Size(286, 94)
        Me.lbZipCity.TabIndex = 69
        Me.lbZipCity.ThreeDCheckBoxes = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtTime2)
        Me.GroupBox4.Controls.Add(Me.txtTime1)
        Me.GroupBox4.Controls.Add(Me.dptTime2)
        Me.GroupBox4.Controls.Add(Me.dtpTime1)
        Me.GroupBox4.Controls.Add(Me.Label86)
        Me.GroupBox4.Controls.Add(Me.Label87)
        Me.GroupBox4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(29, 5)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(304, 83)
        Me.GroupBox4.TabIndex = 109
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Time"
        '
        'txtTime2
        '
        Me.txtTime2.BackColor = System.Drawing.Color.White
        Me.txtTime2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTime2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTime2.ForeColor = System.Drawing.Color.Black
        Me.txtTime2.Location = New System.Drawing.Point(171, 48)
        Me.txtTime2.Name = "txtTime2"
        Me.txtTime2.ReadOnly = True
        Me.txtTime2.Size = New System.Drawing.Size(84, 16)
        Me.txtTime2.TabIndex = 92
        '
        'txtTime1
        '
        Me.txtTime1.BackColor = System.Drawing.Color.White
        Me.txtTime1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTime1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTime1.ForeColor = System.Drawing.Color.Black
        Me.txtTime1.Location = New System.Drawing.Point(20, 48)
        Me.txtTime1.Name = "txtTime1"
        Me.txtTime1.ReadOnly = True
        Me.txtTime1.Size = New System.Drawing.Size(84, 16)
        Me.txtTime1.TabIndex = 91
        '
        'dptTime2
        '
        Me.dptTime2.CalendarFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dptTime2.CustomFormat = "h:mm tt"
        Me.dptTime2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dptTime2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dptTime2.Location = New System.Drawing.Point(167, 44)
        Me.dptTime2.Name = "dptTime2"
        Me.dptTime2.ShowUpDown = True
        Me.dptTime2.Size = New System.Drawing.Size(114, 23)
        Me.dptTime2.TabIndex = 90
        Me.dptTime2.TabStop = False
        Me.dptTime2.Value = New Date(2008, 2, 5, 23, 59, 0, 0)
        '
        'dtpTime1
        '
        Me.dtpTime1.CustomFormat = "h:mm tt"
        Me.dtpTime1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTime1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTime1.Location = New System.Drawing.Point(17, 44)
        Me.dtpTime1.Name = "dtpTime1"
        Me.dtpTime1.ShowUpDown = True
        Me.dtpTime1.Size = New System.Drawing.Size(107, 23)
        Me.dtpTime1.TabIndex = 89
        Me.dtpTime1.TabStop = False
        Me.dtpTime1.Value = New Date(2008, 2, 5, 0, 0, 0, 0)
        '
        'Label86
        '
        Me.Label86.AutoSize = True
        Me.Label86.BackColor = System.Drawing.Color.Transparent
        Me.Label86.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label86.ForeColor = System.Drawing.Color.Black
        Me.Label86.Location = New System.Drawing.Point(8, 19)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(282, 16)
        Me.Label86.TabIndex = 75
        Me.Label86.Text = "Search for Appointment Time(s) Between:"
        '
        'Label87
        '
        Me.Label87.AutoSize = True
        Me.Label87.BackColor = System.Drawing.Color.Transparent
        Me.Label87.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label87.ForeColor = System.Drawing.Color.Black
        Me.Label87.Location = New System.Drawing.Point(133, 47)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(32, 16)
        Me.Label87.TabIndex = 83
        Me.Label87.Text = "and"
        '
        'gbSpecialInstructions
        '
        Me.gbSpecialInstructions.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbSpecialInstructions.BackColor = System.Drawing.Color.White
        Me.gbSpecialInstructions.Controls.Add(Me.rtbSpecialInstructions)
        Me.gbSpecialInstructions.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSpecialInstructions.ForeColor = System.Drawing.Color.Gray
        Me.gbSpecialInstructions.Location = New System.Drawing.Point(444, 207)
        Me.gbSpecialInstructions.Name = "gbSpecialInstructions"
        Me.gbSpecialInstructions.Size = New System.Drawing.Size(290, 144)
        Me.gbSpecialInstructions.TabIndex = 195
        Me.gbSpecialInstructions.TabStop = False
        Me.gbSpecialInstructions.Text = "Special Instructions:"
        '
        'rtbSpecialInstructions
        '
        Me.rtbSpecialInstructions.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbSpecialInstructions.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbSpecialInstructions.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbSpecialInstructions.Location = New System.Drawing.Point(8, 22)
        Me.rtbSpecialInstructions.Name = "rtbSpecialInstructions"
        Me.rtbSpecialInstructions.Size = New System.Drawing.Size(276, 116)
        Me.rtbSpecialInstructions.TabIndex = 146
        Me.rtbSpecialInstructions.Text = "The customer only wants a rough frame in the basement and they are interested in " & _
            "upper grids in the windows"
        '
        'gbProductInfo
        '
        Me.gbProductInfo.BackColor = System.Drawing.Color.White
        Me.gbProductInfo.Controls.Add(Me.Button3)
        Me.gbProductInfo.Controls.Add(Me.txtProducts)
        Me.gbProductInfo.Controls.Add(Me.Label5)
        Me.gbProductInfo.Controls.Add(Me.lblQty)
        Me.gbProductInfo.Controls.Add(Me.ComboBox5)
        Me.gbProductInfo.Controls.Add(Me.txtColor)
        Me.gbProductInfo.Controls.Add(Me.Label6)
        Me.gbProductInfo.Controls.Add(Me.lblColor)
        Me.gbProductInfo.Controls.Add(Me.ComboBox6)
        Me.gbProductInfo.Controls.Add(Me.txtQty)
        Me.gbProductInfo.Controls.Add(Me.lblProducts)
        Me.gbProductInfo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbProductInfo.ForeColor = System.Drawing.Color.Gray
        Me.gbProductInfo.Location = New System.Drawing.Point(197, 207)
        Me.gbProductInfo.Name = "gbProductInfo"
        Me.gbProductInfo.Size = New System.Drawing.Size(241, 144)
        Me.gbProductInfo.TabIndex = 194
        Me.gbProductInfo.TabStop = False
        Me.gbProductInfo.Text = "Product Info:"
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Location = New System.Drawing.Point(-232, -178)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(25, 48)
        Me.Button3.TabIndex = 24
        Me.Button3.Text = "»"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txtProducts
        '
        Me.txtProducts.BackColor = System.Drawing.Color.White
        Me.txtProducts.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtProducts.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProducts.ForeColor = System.Drawing.Color.Black
        Me.txtProducts.Location = New System.Drawing.Point(97, 28)
        Me.txtProducts.Multiline = True
        Me.txtProducts.Name = "txtProducts"
        Me.txtProducts.ReadOnly = True
        Me.txtProducts.Size = New System.Drawing.Size(138, 48)
        Me.txtProducts.TabIndex = 32
        Me.txtProducts.Text = "Roofing" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Basement Finish" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Windows"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(-412, -148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Filter by Sec. Lead Source"
        '
        'lblQty
        '
        Me.lblQty.AutoSize = True
        Me.lblQty.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQty.ForeColor = System.Drawing.Color.Gray
        Me.lblQty.Location = New System.Drawing.Point(6, 117)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(63, 16)
        Me.lblQty.TabIndex = 31
        Me.lblQty.Text = "Quanity:"
        '
        'ComboBox5
        '
        Me.ComboBox5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Items.AddRange(New Object() {"No Results", "Sales", "Demo/No Sales", "No Demo", "Recission Cancels", "Resets", "Not Hits", "Not Issued", "Lost Results", "Unconfirmed for today"})
        Me.ComboBox5.Location = New System.Drawing.Point(-418, -151)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(176, 21)
        Me.ComboBox5.TabIndex = 22
        '
        'txtColor
        '
        Me.txtColor.BackColor = System.Drawing.Color.White
        Me.txtColor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtColor.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColor.ForeColor = System.Drawing.Color.Black
        Me.txtColor.Location = New System.Drawing.Point(97, 94)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.ReadOnly = True
        Me.txtColor.Size = New System.Drawing.Size(138, 16)
        Me.txtColor.TabIndex = 30
        Me.txtColor.Text = "Onyx Black"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gray
        Me.Label6.Location = New System.Drawing.Point(-412, -175)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(147, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Filter by Primary Lead Source"
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColor.ForeColor = System.Drawing.Color.Gray
        Me.lblColor.Location = New System.Drawing.Point(6, 94)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(46, 16)
        Me.lblColor.TabIndex = 29
        Me.lblColor.Text = "Color:"
        '
        'ComboBox6
        '
        Me.ComboBox6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Items.AddRange(New Object() {"No Results", "Sales", "Demo/No Sales", "No Demo", "Recission Cancels", "Resets", "Not Hits", "Not Issued", "Lost Results", "Unconfirmed for today"})
        Me.ComboBox6.Location = New System.Drawing.Point(-418, -178)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(176, 21)
        Me.ComboBox6.TabIndex = 20
        '
        'txtQty
        '
        Me.txtQty.BackColor = System.Drawing.Color.White
        Me.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtQty.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.ForeColor = System.Drawing.Color.Black
        Me.txtQty.Location = New System.Drawing.Point(97, 117)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.ReadOnly = True
        Me.txtQty.Size = New System.Drawing.Size(138, 16)
        Me.txtQty.TabIndex = 28
        Me.txtQty.Text = "16"
        '
        'lblProducts
        '
        Me.lblProducts.AutoSize = True
        Me.lblProducts.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProducts.ForeColor = System.Drawing.Color.Gray
        Me.lblProducts.Location = New System.Drawing.Point(8, 28)
        Me.lblProducts.Name = "lblProducts"
        Me.lblProducts.Size = New System.Drawing.Size(83, 16)
        Me.lblProducts.TabIndex = 2
        Me.lblProducts.Text = "Product(s):"
        '
        'gbApptInfo
        '
        Me.gbApptInfo.BackColor = System.Drawing.Color.White
        Me.gbApptInfo.Controls.Add(Me.txtApptDate)
        Me.gbApptInfo.Controls.Add(Me.txtApptTime)
        Me.gbApptInfo.Controls.Add(Me.Label22)
        Me.gbApptInfo.Controls.Add(Me.lblApptDate)
        Me.gbApptInfo.Controls.Add(Me.lblApptDay)
        Me.gbApptInfo.Controls.Add(Me.txtApptDay)
        Me.gbApptInfo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbApptInfo.ForeColor = System.Drawing.Color.Gray
        Me.gbApptInfo.Location = New System.Drawing.Point(3, 207)
        Me.gbApptInfo.Name = "gbApptInfo"
        Me.gbApptInfo.Size = New System.Drawing.Size(188, 144)
        Me.gbApptInfo.TabIndex = 193
        Me.gbApptInfo.TabStop = False
        Me.gbApptInfo.Text = "Appointment Info:"
        '
        'txtApptDate
        '
        Me.txtApptDate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtApptDate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApptDate.ForeColor = System.Drawing.Color.Black
        Me.txtApptDate.Location = New System.Drawing.Point(61, 30)
        Me.txtApptDate.Name = "txtApptDate"
        Me.txtApptDate.Size = New System.Drawing.Size(114, 16)
        Me.txtApptDate.TabIndex = 21
        Me.txtApptDate.Text = "12/24/2007"
        '
        'txtApptTime
        '
        Me.txtApptTime.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtApptTime.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApptTime.ForeColor = System.Drawing.Color.Black
        Me.txtApptTime.Location = New System.Drawing.Point(61, 116)
        Me.txtApptTime.Name = "txtApptTime"
        Me.txtApptTime.Size = New System.Drawing.Size(114, 16)
        Me.txtApptTime.TabIndex = 20
        Me.txtApptTime.Text = "11:00 AM"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Gray
        Me.Label22.Location = New System.Drawing.Point(11, 116)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(42, 16)
        Me.Label22.TabIndex = 19
        Me.Label22.Text = "Time:"
        '
        'lblApptDate
        '
        Me.lblApptDate.AutoSize = True
        Me.lblApptDate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApptDate.ForeColor = System.Drawing.Color.Gray
        Me.lblApptDate.Location = New System.Drawing.Point(11, 30)
        Me.lblApptDate.Name = "lblApptDate"
        Me.lblApptDate.Size = New System.Drawing.Size(44, 16)
        Me.lblApptDate.TabIndex = 3
        Me.lblApptDate.Text = "Date:"
        '
        'lblApptDay
        '
        Me.lblApptDay.AutoSize = True
        Me.lblApptDay.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApptDay.ForeColor = System.Drawing.Color.Gray
        Me.lblApptDay.Location = New System.Drawing.Point(17, 73)
        Me.lblApptDay.Name = "lblApptDay"
        Me.lblApptDay.Size = New System.Drawing.Size(38, 16)
        Me.lblApptDay.TabIndex = 18
        Me.lblApptDay.Text = "Day:"
        '
        'txtApptDay
        '
        Me.txtApptDay.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtApptDay.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApptDay.ForeColor = System.Drawing.Color.Black
        Me.txtApptDay.Location = New System.Drawing.Point(61, 73)
        Me.txtApptDay.Name = "txtApptDay"
        Me.txtApptDay.Size = New System.Drawing.Size(114, 16)
        Me.txtApptDay.TabIndex = 16
        Me.txtApptDay.Text = "Wednesday"
        '
        'gbHomeInfo
        '
        Me.gbHomeInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbHomeInfo.BackColor = System.Drawing.Color.White
        Me.gbHomeInfo.Controls.Add(Me.txtHomeValue)
        Me.gbHomeInfo.Controls.Add(Me.txtYrsOwned)
        Me.gbHomeInfo.Controls.Add(Me.lblYrBuilt)
        Me.gbHomeInfo.Controls.Add(Me.lblYrsOwned)
        Me.gbHomeInfo.Controls.Add(Me.lblHomeValue)
        Me.gbHomeInfo.Controls.Add(Me.txtYrBuilt)
        Me.gbHomeInfo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbHomeInfo.ForeColor = System.Drawing.Color.Gray
        Me.gbHomeInfo.Location = New System.Drawing.Point(607, 3)
        Me.gbHomeInfo.Name = "gbHomeInfo"
        Me.gbHomeInfo.Size = New System.Drawing.Size(127, 198)
        Me.gbHomeInfo.TabIndex = 192
        Me.gbHomeInfo.TabStop = False
        Me.gbHomeInfo.Text = "Home Info:"
        '
        'txtHomeValue
        '
        Me.txtHomeValue.BackColor = System.Drawing.Color.White
        Me.txtHomeValue.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtHomeValue.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHomeValue.ForeColor = System.Drawing.Color.Black
        Me.txtHomeValue.Location = New System.Drawing.Point(21, 166)
        Me.txtHomeValue.Name = "txtHomeValue"
        Me.txtHomeValue.ReadOnly = True
        Me.txtHomeValue.Size = New System.Drawing.Size(91, 16)
        Me.txtHomeValue.TabIndex = 35
        Me.txtHomeValue.Text = "25"
        Me.txtHomeValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtYrsOwned
        '
        Me.txtYrsOwned.BackColor = System.Drawing.Color.White
        Me.txtYrsOwned.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtYrsOwned.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYrsOwned.ForeColor = System.Drawing.Color.Black
        Me.txtYrsOwned.Location = New System.Drawing.Point(22, 114)
        Me.txtYrsOwned.Name = "txtYrsOwned"
        Me.txtYrsOwned.ReadOnly = True
        Me.txtYrsOwned.Size = New System.Drawing.Size(91, 16)
        Me.txtYrsOwned.TabIndex = 34
        Me.txtYrsOwned.Text = "25"
        Me.txtYrsOwned.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblYrBuilt
        '
        Me.lblYrBuilt.AutoSize = True
        Me.lblYrBuilt.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYrBuilt.ForeColor = System.Drawing.Color.Gray
        Me.lblYrBuilt.Location = New System.Drawing.Point(29, 33)
        Me.lblYrBuilt.Name = "lblYrBuilt"
        Me.lblYrBuilt.Size = New System.Drawing.Size(76, 16)
        Me.lblYrBuilt.TabIndex = 28
        Me.lblYrBuilt.Text = "Year Built:"
        '
        'lblYrsOwned
        '
        Me.lblYrsOwned.AutoSize = True
        Me.lblYrsOwned.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYrsOwned.ForeColor = System.Drawing.Color.Gray
        Me.lblYrsOwned.Location = New System.Drawing.Point(18, 87)
        Me.lblYrsOwned.Name = "lblYrsOwned"
        Me.lblYrsOwned.Size = New System.Drawing.Size(99, 16)
        Me.lblYrsOwned.TabIndex = 2
        Me.lblYrsOwned.Text = "Years Owned:"
        '
        'lblHomeValue
        '
        Me.lblHomeValue.AutoSize = True
        Me.lblHomeValue.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHomeValue.ForeColor = System.Drawing.Color.Gray
        Me.lblHomeValue.Location = New System.Drawing.Point(23, 141)
        Me.lblHomeValue.Name = "lblHomeValue"
        Me.lblHomeValue.Size = New System.Drawing.Size(89, 16)
        Me.lblHomeValue.TabIndex = 32
        Me.lblHomeValue.Text = "Home Value:"
        '
        'txtYrBuilt
        '
        Me.txtYrBuilt.BackColor = System.Drawing.Color.White
        Me.txtYrBuilt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtYrBuilt.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYrBuilt.ForeColor = System.Drawing.Color.Black
        Me.txtYrBuilt.Location = New System.Drawing.Point(21, 60)
        Me.txtYrBuilt.Name = "txtYrBuilt"
        Me.txtYrBuilt.ReadOnly = True
        Me.txtYrBuilt.Size = New System.Drawing.Size(91, 16)
        Me.txtYrBuilt.TabIndex = 29
        Me.txtYrBuilt.Text = "1960"
        Me.txtYrBuilt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gbContactInfo
        '
        Me.gbContactInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbContactInfo.BackColor = System.Drawing.Color.White
        Me.gbContactInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.gbContactInfo.Controls.Add(Me.txtWorkHours)
        Me.gbContactInfo.Controls.Add(Me.tsAutoDial)
        Me.gbContactInfo.Controls.Add(Me.txtHousePhone)
        Me.gbContactInfo.Controls.Add(Me.txtaltphone2)
        Me.gbContactInfo.Controls.Add(Me.txtaltphone1)
        Me.gbContactInfo.Controls.Add(Me.lnkEmail)
        Me.gbContactInfo.Controls.Add(Me.lblEmail)
        Me.gbContactInfo.Controls.Add(Me.txtAlt1Type)
        Me.gbContactInfo.Controls.Add(Me.txtAlt2Type)
        Me.gbContactInfo.Controls.Add(Me.lblAltPhone2)
        Me.gbContactInfo.Controls.Add(Me.lblAltPhone1)
        Me.gbContactInfo.Controls.Add(Me.pctVerified)
        Me.gbContactInfo.Controls.Add(Me.lblHousePhone)
        Me.gbContactInfo.Controls.Add(Me.lblWorkHours)
        Me.gbContactInfo.Controls.Add(Me.txtAddress)
        Me.gbContactInfo.Controls.Add(Me.lblAddress)
        Me.gbContactInfo.Controls.Add(Me.txtContact2)
        Me.gbContactInfo.Controls.Add(Me.txtContact1)
        Me.gbContactInfo.Controls.Add(Me.lblContact2)
        Me.gbContactInfo.Controls.Add(Me.lblContact1)
        Me.gbContactInfo.Controls.Add(Me.ListView4)
        Me.gbContactInfo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbContactInfo.ForeColor = System.Drawing.Color.Gray
        Me.gbContactInfo.Location = New System.Drawing.Point(3, 3)
        Me.gbContactInfo.Name = "gbContactInfo"
        Me.gbContactInfo.Size = New System.Drawing.Size(598, 198)
        Me.gbContactInfo.TabIndex = 191
        Me.gbContactInfo.TabStop = False
        Me.gbContactInfo.Text = "Contact Info:"
        '
        'txtWorkHours
        '
        Me.txtWorkHours.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtWorkHours.Location = New System.Drawing.Point(100, 144)
        Me.txtWorkHours.Name = "txtWorkHours"
        Me.txtWorkHours.Size = New System.Drawing.Size(185, 38)
        Me.txtWorkHours.TabIndex = 178
        Me.txtWorkHours.Text = ""
        '
        'tsAutoDial
        '
        Me.tsAutoDial.Dock = System.Windows.Forms.DockStyle.None
        Me.tsAutoDial.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsAutoDial.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnPreviousRecord, Me.tsbtnNextRecord, Me.ToolStripSeparator3, Me.tsbtnHousePhone, Me.ToolStripSeparator1, Me.tslblCalling, Me.ToolStripSeparator2, Me.tsbtnCloseDialer})
        Me.tsAutoDial.Location = New System.Drawing.Point(104, 0)
        Me.tsAutoDial.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.tsAutoDial.Name = "tsAutoDial"
        Me.tsAutoDial.Size = New System.Drawing.Size(501, 25)
        Me.tsAutoDial.TabIndex = 177
        Me.tsAutoDial.Text = "tsAutodial"
        Me.tsAutoDial.Visible = False
        '
        'tsbtnPreviousRecord
        '
        Me.tsbtnPreviousRecord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnPreviousRecord.Image = CType(resources.GetObject("tsbtnPreviousRecord.Image"), System.Drawing.Image)
        Me.tsbtnPreviousRecord.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnPreviousRecord.Name = "tsbtnPreviousRecord"
        Me.tsbtnPreviousRecord.Size = New System.Drawing.Size(23, 22)
        Me.tsbtnPreviousRecord.Text = "ToolStripButton2"
        '
        'tsbtnNextRecord
        '
        Me.tsbtnNextRecord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnNextRecord.Image = CType(resources.GetObject("tsbtnNextRecord.Image"), System.Drawing.Image)
        Me.tsbtnNextRecord.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnNextRecord.Name = "tsbtnNextRecord"
        Me.tsbtnNextRecord.Size = New System.Drawing.Size(23, 22)
        Me.tsbtnNextRecord.Text = "ToolStripButton3"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'tsbtnHousePhone
        '
        Me.tsbtnHousePhone.ForeColor = System.Drawing.Color.Black
        Me.tsbtnHousePhone.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnHousePhone.Name = "tsbtnHousePhone"
        Me.tsbtnHousePhone.Size = New System.Drawing.Size(194, 22)
        Me.tsbtnHousePhone.Text = "Call Main Phone- (419) 472-4000"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tslblCalling
        '
        Me.tslblCalling.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tslblCalling.ForeColor = System.Drawing.Color.Black
        Me.tslblCalling.Name = "tslblCalling"
        Me.tslblCalling.Size = New System.Drawing.Size(151, 22)
        Me.tslblCalling.Text = "Calling.... (419) 472-4000"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tsbtnCloseDialer
        '
        Me.tsbtnCloseDialer.ForeColor = System.Drawing.Color.Black
        Me.tsbtnCloseDialer.Image = CType(resources.GetObject("tsbtnCloseDialer.Image"), System.Drawing.Image)
        Me.tsbtnCloseDialer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnCloseDialer.Name = "tsbtnCloseDialer"
        Me.tsbtnCloseDialer.Size = New System.Drawing.Size(89, 22)
        Me.tsbtnCloseDialer.Text = "Close Dialer"
        '
        'txtHousePhone
        '
        Me.txtHousePhone.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHousePhone.BackColor = System.Drawing.Color.White
        Me.txtHousePhone.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtHousePhone.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHousePhone.ForeColor = System.Drawing.Color.Black
        Me.txtHousePhone.Location = New System.Drawing.Point(394, 33)
        Me.txtHousePhone.Name = "txtHousePhone"
        Me.txtHousePhone.ReadOnly = True
        Me.txtHousePhone.Size = New System.Drawing.Size(116, 16)
        Me.txtHousePhone.TabIndex = 141
        Me.txtHousePhone.Text = "(419) 472-4000"
        '
        'txtaltphone2
        '
        Me.txtaltphone2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtaltphone2.BackColor = System.Drawing.Color.White
        Me.txtaltphone2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtaltphone2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaltphone2.ForeColor = System.Drawing.Color.Black
        Me.txtaltphone2.Location = New System.Drawing.Point(394, 96)
        Me.txtaltphone2.Name = "txtaltphone2"
        Me.txtaltphone2.ReadOnly = True
        Me.txtaltphone2.Size = New System.Drawing.Size(116, 16)
        Me.txtaltphone2.TabIndex = 140
        '
        'txtaltphone1
        '
        Me.txtaltphone1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtaltphone1.BackColor = System.Drawing.Color.White
        Me.txtaltphone1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtaltphone1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaltphone1.ForeColor = System.Drawing.Color.Black
        Me.txtaltphone1.Location = New System.Drawing.Point(394, 64)
        Me.txtaltphone1.Name = "txtaltphone1"
        Me.txtaltphone1.ReadOnly = True
        Me.txtaltphone1.Size = New System.Drawing.Size(116, 16)
        Me.txtaltphone1.TabIndex = 139
        Me.txtaltphone1.Text = "(419) 467-4926"
        '
        'lnkEmail
        '
        Me.lnkEmail.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lnkEmail.AutoSize = True
        Me.lnkEmail.Location = New System.Drawing.Point(341, 144)
        Me.lnkEmail.Name = "lnkEmail"
        Me.lnkEmail.Size = New System.Drawing.Size(137, 16)
        Me.lnkEmail.TabIndex = 136
        Me.lnkEmail.TabStop = True
        Me.lnkEmail.Text = "SuzzieN@yahoo.com"
        '
        'lblEmail
        '
        Me.lblEmail.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.Gray
        Me.lblEmail.Location = New System.Drawing.Point(290, 144)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(45, 16)
        Me.lblEmail.TabIndex = 135
        Me.lblEmail.Text = "Email:"
        '
        'txtAlt1Type
        '
        Me.txtAlt1Type.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAlt1Type.BackColor = System.Drawing.Color.White
        Me.txtAlt1Type.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAlt1Type.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlt1Type.ForeColor = System.Drawing.Color.Black
        Me.txtAlt1Type.Location = New System.Drawing.Point(526, 64)
        Me.txtAlt1Type.Name = "txtAlt1Type"
        Me.txtAlt1Type.ReadOnly = True
        Me.txtAlt1Type.Size = New System.Drawing.Size(57, 16)
        Me.txtAlt1Type.TabIndex = 126
        Me.txtAlt1Type.Text = "Cell"
        '
        'txtAlt2Type
        '
        Me.txtAlt2Type.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAlt2Type.BackColor = System.Drawing.Color.White
        Me.txtAlt2Type.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAlt2Type.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlt2Type.ForeColor = System.Drawing.Color.Black
        Me.txtAlt2Type.Location = New System.Drawing.Point(526, 96)
        Me.txtAlt2Type.Name = "txtAlt2Type"
        Me.txtAlt2Type.ReadOnly = True
        Me.txtAlt2Type.Size = New System.Drawing.Size(57, 16)
        Me.txtAlt2Type.TabIndex = 125
        Me.txtAlt2Type.Text = "Work"
        '
        'lblAltPhone2
        '
        Me.lblAltPhone2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAltPhone2.AutoSize = True
        Me.lblAltPhone2.BackColor = System.Drawing.Color.Transparent
        Me.lblAltPhone2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAltPhone2.ForeColor = System.Drawing.Color.Gray
        Me.lblAltPhone2.Location = New System.Drawing.Point(290, 96)
        Me.lblAltPhone2.Name = "lblAltPhone2"
        Me.lblAltPhone2.Size = New System.Drawing.Size(84, 16)
        Me.lblAltPhone2.TabIndex = 83
        Me.lblAltPhone2.Text = "Alt Phone2:"
        '
        'lblAltPhone1
        '
        Me.lblAltPhone1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAltPhone1.AutoSize = True
        Me.lblAltPhone1.BackColor = System.Drawing.Color.Transparent
        Me.lblAltPhone1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAltPhone1.ForeColor = System.Drawing.Color.Gray
        Me.lblAltPhone1.Location = New System.Drawing.Point(290, 64)
        Me.lblAltPhone1.Name = "lblAltPhone1"
        Me.lblAltPhone1.Size = New System.Drawing.Size(88, 16)
        Me.lblAltPhone1.TabIndex = 81
        Me.lblAltPhone1.Text = "Alt Phone 1:"
        '
        'pctVerified
        '
        Me.pctVerified.Location = New System.Drawing.Point(29, 114)
        Me.pctVerified.Name = "pctVerified"
        Me.pctVerified.Size = New System.Drawing.Size(24, 24)
        Me.pctVerified.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctVerified.TabIndex = 133
        Me.pctVerified.TabStop = False
        Me.pctVerified.Visible = False
        '
        'lblHousePhone
        '
        Me.lblHousePhone.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHousePhone.AutoSize = True
        Me.lblHousePhone.BackColor = System.Drawing.Color.Transparent
        Me.lblHousePhone.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHousePhone.ForeColor = System.Drawing.Color.Gray
        Me.lblHousePhone.Location = New System.Drawing.Point(290, 33)
        Me.lblHousePhone.Name = "lblHousePhone"
        Me.lblHousePhone.Size = New System.Drawing.Size(97, 16)
        Me.lblHousePhone.TabIndex = 78
        Me.lblHousePhone.Text = "House Phone:"
        '
        'lblWorkHours
        '
        Me.lblWorkHours.AutoSize = True
        Me.lblWorkHours.BackColor = System.Drawing.Color.Transparent
        Me.lblWorkHours.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWorkHours.ForeColor = System.Drawing.Color.Gray
        Me.lblWorkHours.Location = New System.Drawing.Point(6, 144)
        Me.lblWorkHours.Name = "lblWorkHours"
        Me.lblWorkHours.Size = New System.Drawing.Size(89, 16)
        Me.lblWorkHours.TabIndex = 130
        Me.lblWorkHours.Text = "Work Hours:"
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.Color.White
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAddress.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtAddress.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.ForeColor = System.Drawing.Color.Black
        Me.txtAddress.Location = New System.Drawing.Point(100, 96)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.Size = New System.Drawing.Size(185, 33)
        Me.txtAddress.TabIndex = 124
        Me.txtAddress.Text = "12345 Main St." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Toledo, OH 43613"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.BackColor = System.Drawing.Color.Transparent
        Me.lblAddress.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.Color.Gray
        Me.lblAddress.Location = New System.Drawing.Point(6, 96)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(67, 16)
        Me.lblAddress.TabIndex = 86
        Me.lblAddress.Text = "Address:"
        '
        'txtContact2
        '
        Me.txtContact2.BackColor = System.Drawing.Color.White
        Me.txtContact2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtContact2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact2.ForeColor = System.Drawing.Color.Black
        Me.txtContact2.Location = New System.Drawing.Point(100, 64)
        Me.txtContact2.Name = "txtContact2"
        Me.txtContact2.ReadOnly = True
        Me.txtContact2.Size = New System.Drawing.Size(185, 16)
        Me.txtContact2.TabIndex = 76
        Me.txtContact2.Text = "Suzzana NameWaytolong"
        '
        'txtContact1
        '
        Me.txtContact1.BackColor = System.Drawing.Color.White
        Me.txtContact1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtContact1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact1.ForeColor = System.Drawing.Color.Black
        Me.txtContact1.Location = New System.Drawing.Point(100, 33)
        Me.txtContact1.Name = "txtContact1"
        Me.txtContact1.ReadOnly = True
        Me.txtContact1.Size = New System.Drawing.Size(185, 16)
        Me.txtContact1.TabIndex = 74
        Me.txtContact1.Text = "Alexander Namewaytolong"
        '
        'lblContact2
        '
        Me.lblContact2.AutoSize = True
        Me.lblContact2.BackColor = System.Drawing.Color.Transparent
        Me.lblContact2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact2.ForeColor = System.Drawing.Color.Gray
        Me.lblContact2.Location = New System.Drawing.Point(6, 64)
        Me.lblContact2.Name = "lblContact2"
        Me.lblContact2.Size = New System.Drawing.Size(76, 16)
        Me.lblContact2.TabIndex = 73
        Me.lblContact2.Text = "Contact 2:"
        '
        'lblContact1
        '
        Me.lblContact1.AutoSize = True
        Me.lblContact1.BackColor = System.Drawing.Color.Transparent
        Me.lblContact1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact1.ForeColor = System.Drawing.Color.Gray
        Me.lblContact1.Location = New System.Drawing.Point(6, 33)
        Me.lblContact1.Name = "lblContact1"
        Me.lblContact1.Size = New System.Drawing.Size(76, 16)
        Me.lblContact1.TabIndex = 72
        Me.lblContact1.Text = "Contact 1:"
        '
        'ListView4
        '
        Me.ListView4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ListView4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView4.FullRowSelect = True
        Me.ListView4.GridLines = True
        Me.ListView4.HideSelection = False
        Me.ListView4.Location = New System.Drawing.Point(-224, 64)
        Me.ListView4.MultiSelect = False
        Me.ListView4.Name = "ListView4"
        Me.ListView4.Size = New System.Drawing.Size(125, 486)
        Me.ListView4.Sorting = System.Windows.Forms.SortOrder.Descending
        Me.ListView4.TabIndex = 19
        Me.ListView4.UseCompatibleStateImageBehavior = False
        Me.ListView4.View = System.Windows.Forms.View.Details
        '
        'tsCustomerLog
        '
        Me.tsCustomerLog.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tsCustomerLog.AutoSize = False
        Me.tsCustomerLog.Dock = System.Windows.Forms.DockStyle.None
        Me.tsCustomerLog.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsCustomerLog.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TScboCustomerHistory, Me.ToolStripLabel1, Me.btnLogCall, Me.ToolStripLabel2})
        Me.tsCustomerLog.Location = New System.Drawing.Point(3, 354)
        Me.tsCustomerLog.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.tsCustomerLog.Name = "tsCustomerLog"
        Me.tsCustomerLog.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.tsCustomerLog.Size = New System.Drawing.Size(731, 33)
        Me.tsCustomerLog.TabIndex = 196
        Me.tsCustomerLog.Text = "ToolStrip1"
        '
        'TScboCustomerHistory
        '
        Me.TScboCustomerHistory.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TScboCustomerHistory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TScboCustomerHistory.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.TScboCustomerHistory.Items.AddRange(New Object() {"All", "Marketing Department", "Sales Department", "Finance Department", "Installation Department"})
        Me.TScboCustomerHistory.Margin = New System.Windows.Forms.Padding(1, 0, 10, 0)
        Me.TScboCustomerHistory.Name = "TScboCustomerHistory"
        Me.TScboCustomerHistory.Size = New System.Drawing.Size(160, 33)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Margin = New System.Windows.Forms.Padding(10, 1, 0, 2)
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(43, 30)
        Me.ToolStripLabel1.Text = "Show"
        '
        'btnLogCall
        '
        Me.btnLogCall.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogAsCalledCancelledToolStripMenuItem})
        Me.btnLogCall.Image = CType(resources.GetObject("btnLogCall.Image"), System.Drawing.Image)
        Me.btnLogCall.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnLogCall.Name = "btnLogCall"
        Me.btnLogCall.Size = New System.Drawing.Size(272, 30)
        Me.btnLogCall.Text = "Log Phone Conversation with this Customer"
        '
        'LogAsCalledCancelledToolStripMenuItem
        '
        Me.LogAsCalledCancelledToolStripMenuItem.Name = "LogAsCalledCancelledToolStripMenuItem"
        Me.LogAsCalledCancelledToolStripMenuItem.Size = New System.Drawing.Size(254, 22)
        Me.LogAsCalledCancelledToolStripMenuItem.Text = "Log Appt. as Called and Cancelled"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.Margin = New System.Windows.Forms.Padding(40, 1, 0, 2)
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(150, 30)
        Me.ToolStripLabel2.Text = "Customer History"
        '
        'pnlCustomerHistory
        '
        Me.pnlCustomerHistory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCustomerHistory.AutoScroll = True
        Me.pnlCustomerHistory.Location = New System.Drawing.Point(3, 388)
        Me.pnlCustomerHistory.Name = "pnlCustomerHistory"
        Me.pnlCustomerHistory.Size = New System.Drawing.Size(729, 183)
        Me.pnlCustomerHistory.TabIndex = 199
        '
        'ttCustomerHistoryNotes
        '
        Me.ttCustomerHistoryNotes.AutoPopDelay = 30000
        Me.ttCustomerHistoryNotes.InitialDelay = 500
        Me.ttCustomerHistoryNotes.ReshowDelay = 100
        '
        'ilToolStripIcons
        '
        Me.ilToolStripIcons.ImageStream = CType(resources.GetObject("ilToolStripIcons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilToolStripIcons.TransparentColor = System.Drawing.Color.Transparent
        Me.ilToolStripIcons.Images.SetKeyName(0, "Cancel.ico")
        Me.ilToolStripIcons.Images.SetKeyName(1, "Cancel.ico")
        Me.ilToolStripIcons.Images.SetKeyName(2, "notes 10.ico")
        Me.ilToolStripIcons.Images.SetKeyName(3, "tranfer.ico")
        Me.ilToolStripIcons.Images.SetKeyName(4, "reminder.ico")
        '
        'dtp1
        '
        Me.dtp1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtp1.CalendarFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp1.Location = New System.Drawing.Point(745, 2)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(98, 21)
        Me.dtp1.TabIndex = 434
        Me.dtp1.TabStop = False
        Me.dtp1.Value = New Date(2008, 4, 8, 0, 0, 0, 0)
        '
        'dtp2
        '
        Me.dtp2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtp2.CalendarFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp2.Location = New System.Drawing.Point(882, 2)
        Me.dtp2.Name = "dtp2"
        Me.dtp2.Size = New System.Drawing.Size(98, 21)
        Me.dtp2.TabIndex = 433
        Me.dtp2.TabStop = False
        Me.dtp2.Value = New Date(2008, 4, 8, 0, 0, 0, 0)
        '
        'ilSearch
        '
        Me.ilSearch.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ilSearch.ImageSize = New System.Drawing.Size(16, 16)
        Me.ilSearch.TransparentColor = System.Drawing.Color.Transparent
        '
        'txtDate1
        '
        Me.txtDate1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDate1.BackColor = System.Drawing.Color.White
        Me.txtDate1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDate1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate1.ForeColor = System.Drawing.Color.Black
        Me.txtDate1.Location = New System.Drawing.Point(749, 5)
        Me.txtDate1.Name = "txtDate1"
        Me.txtDate1.ReadOnly = True
        Me.txtDate1.Size = New System.Drawing.Size(63, 16)
        Me.txtDate1.TabIndex = 92
        Me.txtDate1.TabStop = False
        '
        'txtDate2
        '
        Me.txtDate2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDate2.BackColor = System.Drawing.Color.White
        Me.txtDate2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDate2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate2.ForeColor = System.Drawing.Color.Black
        Me.txtDate2.Location = New System.Drawing.Point(886, 4)
        Me.txtDate2.Name = "txtDate2"
        Me.txtDate2.ReadOnly = True
        Me.txtDate2.Size = New System.Drawing.Size(63, 16)
        Me.txtDate2.TabIndex = 178
        Me.txtDate2.TabStop = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.Icon = CType(resources.GetObject("ErrorProvider1.Icon"), System.Drawing.Icon)
        '
        'Timer1
        '
        Me.Timer1.Interval = 150
        '
        'WCaller
        '
        Me.AcceptButton = Me.btnExpandWarmCalling
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(990, 601)
        Me.Controls.Add(Me.txtDate2)
        Me.Controls.Add(Me.txtDate1)
        Me.Controls.Add(Me.dtp1)
        Me.Controls.Add(Me.dtp2)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.tsWarmCalling)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "WCaller"
        Me.Text = "Warm Calling"
        Me.tsWarmCalling.ResumeLayout(False)
        Me.tsWarmCalling.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.pnlSearch.ResumeLayout(False)
        Me.pnlSearch.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.nupMiles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.gbSpecialInstructions.ResumeLayout(False)
        Me.gbProductInfo.ResumeLayout(False)
        Me.gbProductInfo.PerformLayout()
        Me.gbApptInfo.ResumeLayout(False)
        Me.gbApptInfo.PerformLayout()
        Me.gbHomeInfo.ResumeLayout(False)
        Me.gbHomeInfo.PerformLayout()
        Me.gbContactInfo.ResumeLayout(False)
        Me.gbContactInfo.PerformLayout()
        Me.tsAutoDial.ResumeLayout(False)
        Me.tsAutoDial.PerformLayout()
        CType(Me.pctVerified, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsCustomerLog.ResumeLayout(False)
        Me.tsCustomerLog.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsWarmCalling As System.Windows.Forms.ToolStrip
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents lvWarmCalling As System.Windows.Forms.ListView
    Friend WithEvents LeadID As System.Windows.Forms.ColumnHeader
    Friend WithEvents Contacts As System.Windows.Forms.ColumnHeader
    Friend WithEvents ApptDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents Address As System.Windows.Forms.ColumnHeader
    Friend WithEvents Products As System.Windows.Forms.ColumnHeader
    Friend WithEvents ApptTime As System.Windows.Forms.ColumnHeader
    Friend WithEvents Result As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblSLSWarmCalling As System.Windows.Forms.Label
    Friend WithEvents lblPLSWarmCalling As System.Windows.Forms.Label
    Friend WithEvents cboSLSWarmCalling As System.Windows.Forms.ComboBox
    Friend WithEvents cboPLSWarmCalling As System.Windows.Forms.ComboBox
    Friend WithEvents btnExpandWarmCalling As System.Windows.Forms.Button
    Friend WithEvents lblToChangeWarmCalling As System.Windows.Forms.Label
    Friend WithEvents lvMyAppts As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnExpandMyAppts As System.Windows.Forms.Button
    Friend WithEvents lblToChangeMyAppts As System.Windows.Forms.Label
    Friend WithEvents gbSpecialInstructions As System.Windows.Forms.GroupBox
    Friend WithEvents rtbSpecialInstructions As System.Windows.Forms.RichTextBox
    Friend WithEvents gbProductInfo As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Public WithEvents txtProducts As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblQty As System.Windows.Forms.Label
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
    Public WithEvents txtColor As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblColor As System.Windows.Forms.Label
    Friend WithEvents ComboBox6 As System.Windows.Forms.ComboBox
    Public WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents lblProducts As System.Windows.Forms.Label
    Friend WithEvents gbApptInfo As System.Windows.Forms.GroupBox
    Friend WithEvents txtApptDate As System.Windows.Forms.TextBox
    Friend WithEvents txtApptTime As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents lblApptDate As System.Windows.Forms.Label
    Friend WithEvents lblApptDay As System.Windows.Forms.Label
    Friend WithEvents txtApptDay As System.Windows.Forms.TextBox
    Friend WithEvents gbHomeInfo As System.Windows.Forms.GroupBox
    Friend WithEvents txtHomeValue As System.Windows.Forms.TextBox
    Friend WithEvents txtYrsOwned As System.Windows.Forms.TextBox
    Friend WithEvents lblYrBuilt As System.Windows.Forms.Label
    Friend WithEvents lblYrsOwned As System.Windows.Forms.Label
    Friend WithEvents lblHomeValue As System.Windows.Forms.Label
    Friend WithEvents txtYrBuilt As System.Windows.Forms.TextBox
    Friend WithEvents gbContactInfo As System.Windows.Forms.GroupBox
    Friend WithEvents txtHousePhone As System.Windows.Forms.TextBox
    Friend WithEvents txtaltphone2 As System.Windows.Forms.TextBox
    Friend WithEvents txtaltphone1 As System.Windows.Forms.TextBox
    Friend WithEvents lnkEmail As System.Windows.Forms.LinkLabel
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtAlt1Type As System.Windows.Forms.TextBox
    Friend WithEvents txtAlt2Type As System.Windows.Forms.TextBox
    Friend WithEvents lblAltPhone2 As System.Windows.Forms.Label
    Friend WithEvents lblAltPhone1 As System.Windows.Forms.Label
    Friend WithEvents pctVerified As System.Windows.Forms.PictureBox
    Friend WithEvents lblHousePhone As System.Windows.Forms.Label
    Friend WithEvents lblWorkHours As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents txtContact2 As System.Windows.Forms.TextBox
    Friend WithEvents txtContact1 As System.Windows.Forms.TextBox
    Friend WithEvents lblContact2 As System.Windows.Forms.Label
    Friend WithEvents lblContact1 As System.Windows.Forms.Label
    Friend WithEvents ListView4 As System.Windows.Forms.ListView
    Friend WithEvents tsCustomerLog As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnLogCall As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tsAutoDial As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbtnPreviousRecord As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnNextRecord As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbtnHousePhone As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tslblCalling As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbtnCloseDialer As System.Windows.Forms.ToolStripButton
    Friend WithEvents ttCustomerHistoryNotes As System.Windows.Forms.ToolTip
    Friend WithEvents ilCustomerHistory As System.Windows.Forms.ImageList
    Friend WithEvents ilToolStripIcons As System.Windows.Forms.ImageList
    Friend WithEvents btnEditCustomer As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnChangeStatus As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents btnKill As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnDoNotCall As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnDoNotMail As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnDoNotCallOrMail As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dtp1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblTo As System.Windows.Forms.ToolStripLabel
    Friend WithEvents lblFrom As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cboDateRange As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents lblDateRange As System.Windows.Forms.ToolStripLabel
    Friend WithEvents LogAsCalledCancelledToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnSetAppt As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents MemorizeThisApptToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnAutoDialer As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents LaunchProgressiveDialerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ilSearch As System.Windows.Forms.ImageList
    Friend WithEvents pnlSearch As System.Windows.Forms.Panel
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents dptTime2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpTime1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label86 As System.Windows.Forms.Label
    Friend WithEvents Label87 As System.Windows.Forms.Label
    Friend WithEvents cbWeekdays As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents btnZipCity As System.Windows.Forms.Button
    Friend WithEvents rdoCity As System.Windows.Forms.RadioButton
    Friend WithEvents rdoZip As System.Windows.Forms.RadioButton
    Friend WithEvents nupMiles As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblShow As System.Windows.Forms.Label
    Friend WithEvents lblEnter As System.Windows.Forms.Label
    Friend WithEvents lbZipCity As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtRecordsMatching As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExpandCollapse As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblUncheckAll As System.Windows.Forms.Label
    Friend WithEvents lblCheckAll As System.Windows.Forms.Label
    Friend WithEvents chlstResults As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents txtTime2 As System.Windows.Forms.TextBox
    Public WithEvents txtTime1 As System.Windows.Forms.TextBox
    Public WithEvents txtDate1 As System.Windows.Forms.TextBox
    Public WithEvents txtDate2 As System.Windows.Forms.TextBox
    Friend WithEvents cboGroupBy As System.Windows.Forms.ComboBox
    Friend WithEvents lblGroupBy As System.Windows.Forms.Label
    Friend WithEvents pbRadiusSearch As System.Windows.Forms.ProgressBar
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents pnlCustomerHistory As System.Windows.Forms.Panel
    Friend WithEvents txtWorkHours As System.Windows.Forms.RichTextBox
    Friend WithEvents TScboCustomerHistory As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents txtZipCode As System.Windows.Forms.TextBox
    Friend WithEvents lblDisplayColumn As System.Windows.Forms.Label
    Friend WithEvents cboGroupSetAppt As System.Windows.Forms.ComboBox
    Friend WithEvents cboDisplayColumn As System.Windows.Forms.ComboBox
    Friend WithEvents cboFilter As System.Windows.Forms.ComboBox
    Friend WithEvents lblGroupSetAppts As System.Windows.Forms.Label
    Friend WithEvents lblFilter As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
