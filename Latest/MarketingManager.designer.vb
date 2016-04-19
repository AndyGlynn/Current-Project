<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MarketingManager
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MarketingManager))
        Me.tsMarketingDepartment = New System.Windows.Forms.ToolStrip()
        Me.ScheduledTasks = New System.Windows.Forms.ToolStripDropDownButton()
        Me.btnMarkTaskAsDone = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnEditScheduledTask = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnRemoveThisCompletedTask = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnRemoveAllScheduledTask = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.GenerateWarmCallingListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecoveryListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreviewCustomerListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSplitButton2 = New System.Windows.Forms.ToolStripSplitButton()
        Me.tbMain = New System.Windows.Forms.TabControl()
        Me.tpSummary = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.pnlScheduledTasks = New System.Windows.Forms.Panel()
        Me.tpCustomerList = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.lblDisplayColumn = New System.Windows.Forms.Label()
        Me.lblGroupBy = New System.Windows.Forms.Label()
        Me.cboGroupSales = New System.Windows.Forms.ComboBox()
        Me.cboDisplayColumn = New System.Windows.Forms.ComboBox()
        Me.btnExpandSalesList = New System.Windows.Forms.Button()
        Me.lvSales = New System.Windows.Forms.ListView()
        Me.LeadID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Contact1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Address = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.HousePhone = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Products = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ApptDateTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Reps = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblConfimingPLS = New System.Windows.Forms.Label()
        Me.cboSalesList = New System.Windows.Forms.ComboBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lnkOrderbyMem = New System.Windows.Forms.LinkLabel()
        Me.lvMemorized = New System.Windows.Forms.ListView()
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblFilterGroups = New System.Windows.Forms.Label()
        Me.btnExpandMemorize = New System.Windows.Forms.Button()
        Me.lbldisplaymemorized = New System.Windows.Forms.Label()
        Me.lblgroupbymemorized = New System.Windows.Forms.Label()
        Me.cboGroupByMemorized = New System.Windows.Forms.ComboBox()
        Me.cboDisplayMemorized = New System.Windows.Forms.ComboBox()
        Me.cboFilterGroups = New System.Windows.Forms.ComboBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripComboBox3 = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.pnlCustomerHistory = New System.Windows.Forms.Panel()
        Me.gbContactInfo = New System.Windows.Forms.GroupBox()
        Me.txtHousePhone = New System.Windows.Forms.TextBox()
        Me.txtaltphone2 = New System.Windows.Forms.TextBox()
        Me.txtaltphone1 = New System.Windows.Forms.TextBox()
        Me.lnkEmail = New System.Windows.Forms.LinkLabel()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtWorkHours = New System.Windows.Forms.TextBox()
        Me.txtAlt1Type = New System.Windows.Forms.TextBox()
        Me.txtAlt2Type = New System.Windows.Forms.TextBox()
        Me.lblAltPhone2 = New System.Windows.Forms.Label()
        Me.lblAltPhone1 = New System.Windows.Forms.Label()
        Me.pctVerified = New System.Windows.Forms.PictureBox()
        Me.lblHousePhone = New System.Windows.Forms.Label()
        Me.lblWorkHours = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtContact2 = New System.Windows.Forms.TextBox()
        Me.txtContact1 = New System.Windows.Forms.TextBox()
        Me.lblContact2 = New System.Windows.Forms.Label()
        Me.lblContact1 = New System.Windows.Forms.Label()
        Me.ListView4 = New System.Windows.Forms.ListView()
        Me.gbHomeInfo = New System.Windows.Forms.GroupBox()
        Me.txtHomeValue = New System.Windows.Forms.TextBox()
        Me.txtYrsOwned = New System.Windows.Forms.TextBox()
        Me.lblYrBuilt = New System.Windows.Forms.Label()
        Me.lblYrsOwned = New System.Windows.Forms.Label()
        Me.lblHomeValue = New System.Windows.Forms.Label()
        Me.txtYrBuilt = New System.Windows.Forms.TextBox()
        Me.gbSpecialInstructions = New System.Windows.Forms.GroupBox()
        Me.btnEditSPI = New System.Windows.Forms.Button()
        Me.rtbSpecialInstructions = New System.Windows.Forms.RichTextBox()
        Me.gbProductInfo = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtProducts = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblQty = New System.Windows.Forms.Label()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.lblProducts = New System.Windows.Forms.Label()
        Me.gbApptInfo = New System.Windows.Forms.GroupBox()
        Me.txtApptDate = New System.Windows.Forms.TextBox()
        Me.txtApptTime = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lblApptDate = New System.Windows.Forms.Label()
        Me.lblApptDay = New System.Windows.Forms.Label()
        Me.txtApptDay = New System.Windows.Forms.TextBox()
        Me.tsCustomerLog = New System.Windows.Forms.ToolStrip()
        Me.TScboCustomerHistory = New System.Windows.Forms.ToolStripComboBox()
        Me.tslblShowDepartment = New System.Windows.Forms.ToolStripLabel()
        Me.tsbtnAFPics = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnLogCall = New System.Windows.Forms.ToolStripSplitButton()
        Me.btnCalledandCancelled = New System.Windows.Forms.ToolStripMenuItem()
        Me.tslblCustomerHistory = New System.Windows.Forms.ToolStripLabel()
        Me.tsAFPics = New System.Windows.Forms.ToolStrip()
        Me.tscboAFPicsFilter = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.tsbtnShowCH = New System.Windows.Forms.ToolStripButton()
        Me.tsAttachedFilesNAV = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tslblAFPic = New System.Windows.Forms.ToolStripLabel()
        Me.tpIssueLeads = New System.Windows.Forms.TabPage()
        Me.tpReferences = New System.Windows.Forms.TabPage()
        Me.tpReports = New System.Windows.Forms.TabPage()
        Me.tsMarketingDepartment.SuspendLayout()
        Me.tbMain.SuspendLayout()
        Me.tpSummary.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.tpCustomerList.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.gbContactInfo.SuspendLayout()
        CType(Me.pctVerified, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbHomeInfo.SuspendLayout()
        Me.gbSpecialInstructions.SuspendLayout()
        Me.gbProductInfo.SuspendLayout()
        Me.gbApptInfo.SuspendLayout()
        Me.tsCustomerLog.SuspendLayout()
        Me.tsAFPics.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsMarketingDepartment
        '
        Me.tsMarketingDepartment.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMarketingDepartment.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ScheduledTasks, Me.ToolStripDropDownButton1, Me.ToolStripSplitButton2})
        Me.tsMarketingDepartment.Location = New System.Drawing.Point(0, 0)
        Me.tsMarketingDepartment.Name = "tsMarketingDepartment"
        Me.tsMarketingDepartment.Size = New System.Drawing.Size(990, 25)
        Me.tsMarketingDepartment.TabIndex = 250
        Me.tsMarketingDepartment.Text = "ToolStrip1"
        '
        'ScheduledTasks
        '
        Me.ScheduledTasks.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnMarkTaskAsDone, Me.btnEditScheduledTask, Me.btnRemoveThisCompletedTask, Me.btnRemoveAllScheduledTask})
        Me.ScheduledTasks.Image = CType(resources.GetObject("ScheduledTasks.Image"), System.Drawing.Image)
        Me.ScheduledTasks.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ScheduledTasks.Name = "ScheduledTasks"
        Me.ScheduledTasks.Size = New System.Drawing.Size(141, 22)
        Me.ScheduledTasks.Text = "Edit Scheduled Task"
        '
        'btnMarkTaskAsDone
        '
        Me.btnMarkTaskAsDone.Name = "btnMarkTaskAsDone"
        Me.btnMarkTaskAsDone.Size = New System.Drawing.Size(231, 22)
        Me.btnMarkTaskAsDone.Text = "Mark Task as Done"
        '
        'btnEditScheduledTask
        '
        Me.btnEditScheduledTask.Name = "btnEditScheduledTask"
        Me.btnEditScheduledTask.Size = New System.Drawing.Size(231, 22)
        Me.btnEditScheduledTask.Text = "Edit Scheduled Task"
        '
        'btnRemoveThisCompletedTask
        '
        Me.btnRemoveThisCompletedTask.Name = "btnRemoveThisCompletedTask"
        Me.btnRemoveThisCompletedTask.Size = New System.Drawing.Size(231, 22)
        Me.btnRemoveThisCompletedTask.Text = "Remove This Completed Task"
        '
        'btnRemoveAllScheduledTask
        '
        Me.btnRemoveAllScheduledTask.Name = "btnRemoveAllScheduledTask"
        Me.btnRemoveAllScheduledTask.Size = New System.Drawing.Size(231, 22)
        Me.btnRemoveAllScheduledTask.Text = "Remove All Completed Tasks"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerateWarmCallingListToolStripMenuItem, Me.RecoveryListToolStripMenuItem, Me.PreviewCustomerListToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = Global.Latest.My.Resources.Resources.notes2
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(148, 22)
        Me.ToolStripDropDownButton1.Text = "Create Marketing List"
        '
        'GenerateWarmCallingListToolStripMenuItem
        '
        Me.GenerateWarmCallingListToolStripMenuItem.Image = Global.Latest.My.Resources.Resources.Fire__2_
        Me.GenerateWarmCallingListToolStripMenuItem.Name = "GenerateWarmCallingListToolStripMenuItem"
        Me.GenerateWarmCallingListToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.GenerateWarmCallingListToolStripMenuItem.Text = "Warm Calling List"
        '
        'RecoveryListToolStripMenuItem
        '
        Me.RecoveryListToolStripMenuItem.Image = Global.Latest.My.Resources.Resources.recovery2
        Me.RecoveryListToolStripMenuItem.Name = "RecoveryListToolStripMenuItem"
        Me.RecoveryListToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.RecoveryListToolStripMenuItem.Text = "Recovery List"
        '
        'PreviewCustomerListToolStripMenuItem
        '
        Me.PreviewCustomerListToolStripMenuItem.Image = Global.Latest.My.Resources.Resources.hand_shake
        Me.PreviewCustomerListToolStripMenuItem.Name = "PreviewCustomerListToolStripMenuItem"
        Me.PreviewCustomerListToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.PreviewCustomerListToolStripMenuItem.Text = "Preview Customer List"
        '
        'ToolStripSplitButton2
        '
        Me.ToolStripSplitButton2.Image = CType(resources.GetObject("ToolStripSplitButton2.Image"), System.Drawing.Image)
        Me.ToolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton2.Name = "ToolStripSplitButton2"
        Me.ToolStripSplitButton2.Size = New System.Drawing.Size(138, 22)
        Me.ToolStripSplitButton2.Text = "Log Marketer Appt"
        '
        'tbMain
        '
        Me.tbMain.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.tbMain.Controls.Add(Me.tpSummary)
        Me.tbMain.Controls.Add(Me.tpCustomerList)
        Me.tbMain.Controls.Add(Me.tpIssueLeads)
        Me.tbMain.Controls.Add(Me.tpReferences)
        Me.tbMain.Controls.Add(Me.tpReports)
        Me.tbMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbMain.Location = New System.Drawing.Point(0, 25)
        Me.tbMain.Multiline = True
        Me.tbMain.Name = "tbMain"
        Me.tbMain.SelectedIndex = 0
        Me.tbMain.Size = New System.Drawing.Size(990, 575)
        Me.tbMain.TabIndex = 251
        '
        'tpSummary
        '
        Me.tpSummary.Controls.Add(Me.GroupBox4)
        Me.tpSummary.ImageKey = "Summary- Selected.png"
        Me.tpSummary.Location = New System.Drawing.Point(23, 4)
        Me.tpSummary.Name = "tpSummary"
        Me.tpSummary.Padding = New System.Windows.Forms.Padding(3)
        Me.tpSummary.Size = New System.Drawing.Size(963, 567)
        Me.tpSummary.TabIndex = 0
        Me.tpSummary.Text = "Summary"
        Me.tpSummary.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.pnlScheduledTasks)
        Me.GroupBox4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox4.Size = New System.Drawing.Size(659, 282)
        Me.GroupBox4.TabIndex = 221
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Scheduled Tasks -Marketing Department"
        '
        'pnlScheduledTasks
        '
        Me.pnlScheduledTasks.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlScheduledTasks.AutoScroll = True
        Me.pnlScheduledTasks.BackColor = System.Drawing.Color.White
        Me.pnlScheduledTasks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlScheduledTasks.Location = New System.Drawing.Point(8, 22)
        Me.pnlScheduledTasks.Name = "pnlScheduledTasks"
        Me.pnlScheduledTasks.Size = New System.Drawing.Size(641, 254)
        Me.pnlScheduledTasks.TabIndex = 246
        '
        'tpCustomerList
        '
        Me.tpCustomerList.Controls.Add(Me.SplitContainer1)
        Me.tpCustomerList.ImageKey = "Customer List.png"
        Me.tpCustomerList.Location = New System.Drawing.Point(23, 4)
        Me.tpCustomerList.Name = "tpCustomerList"
        Me.tpCustomerList.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCustomerList.Size = New System.Drawing.Size(963, 567)
        Me.tpCustomerList.TabIndex = 1
        Me.tpCustomerList.Text = "Customer List"
        Me.tpCustomerList.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TabControl2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ToolStrip1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.pnlCustomerHistory)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbContactInfo)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbHomeInfo)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbSpecialInstructions)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbProductInfo)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbApptInfo)
        Me.SplitContainer1.Panel2.Controls.Add(Me.tsCustomerLog)
        Me.SplitContainer1.Panel2.Controls.Add(Me.tsAFPics)
        Me.SplitContainer1.Size = New System.Drawing.Size(957, 561)
        Me.SplitContainer1.SplitterDistance = 215
        Me.SplitContainer1.SplitterWidth = 1
        Me.SplitContainer1.TabIndex = 0
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage1)
        Me.TabControl2.Controls.Add(Me.TabPage2)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl2.Location = New System.Drawing.Point(0, 0)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.ShowToolTips = True
        Me.TabControl2.Size = New System.Drawing.Size(215, 561)
        Me.TabControl2.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.LinkLabel2)
        Me.TabPage1.Controls.Add(Me.lblDisplayColumn)
        Me.TabPage1.Controls.Add(Me.lblGroupBy)
        Me.TabPage1.Controls.Add(Me.cboGroupSales)
        Me.TabPage1.Controls.Add(Me.cboDisplayColumn)
        Me.TabPage1.Controls.Add(Me.btnExpandSalesList)
        Me.TabPage1.Controls.Add(Me.lvSales)
        Me.TabPage1.Controls.Add(Me.lblConfimingPLS)
        Me.TabPage1.Controls.Add(Me.cboSalesList)
        Me.TabPage1.ImageIndex = 0
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(207, 535)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Marketing List"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.Location = New System.Drawing.Point(114, 3)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(64, 13)
        Me.LinkLabel2.TabIndex = 97
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Order By ID"
        '
        'lblDisplayColumn
        '
        Me.lblDisplayColumn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDisplayColumn.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblDisplayColumn.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplayColumn.ForeColor = System.Drawing.Color.Gray
        Me.lblDisplayColumn.Location = New System.Drawing.Point(3, 50)
        Me.lblDisplayColumn.Name = "lblDisplayColumn"
        Me.lblDisplayColumn.Size = New System.Drawing.Size(144, 21)
        Me.lblDisplayColumn.TabIndex = 96
        Me.lblDisplayColumn.Text = "Change Display Column"
        Me.lblDisplayColumn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblGroupBy
        '
        Me.lblGroupBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGroupBy.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblGroupBy.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGroupBy.ForeColor = System.Drawing.Color.Gray
        Me.lblGroupBy.Location = New System.Drawing.Point(4, 77)
        Me.lblGroupBy.Name = "lblGroupBy"
        Me.lblGroupBy.Size = New System.Drawing.Size(144, 21)
        Me.lblGroupBy.TabIndex = 95
        Me.lblGroupBy.Text = "Group By"
        Me.lblGroupBy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboGroupSales
        '
        Me.cboGroupSales.DropDownHeight = 150
        Me.cboGroupSales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGroupSales.DropDownWidth = 200
        Me.cboGroupSales.FormattingEnabled = True
        Me.cboGroupSales.IntegralHeight = False
        Me.cboGroupSales.Items.AddRange(New Object() {"", "Primary Product", "Appt. Date", "Sales Result", "Marketing Result", "Sales Rep", "City, State", "Zip Code"})
        Me.cboGroupSales.Location = New System.Drawing.Point(4, 77)
        Me.cboGroupSales.Name = "cboGroupSales"
        Me.cboGroupSales.Size = New System.Drawing.Size(164, 21)
        Me.cboGroupSales.TabIndex = 94
        '
        'cboDisplayColumn
        '
        Me.cboDisplayColumn.DropDownHeight = 150
        Me.cboDisplayColumn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDisplayColumn.DropDownWidth = 200
        Me.cboDisplayColumn.FormattingEnabled = True
        Me.cboDisplayColumn.IntegralHeight = False
        Me.cboDisplayColumn.Items.AddRange(New Object() {"", "Record ID (Default)", "Contact(s)", "House Phone", "Products", "Appt. Date/Time", "Rep(s)"})
        Me.cboDisplayColumn.Location = New System.Drawing.Point(4, 50)
        Me.cboDisplayColumn.Name = "cboDisplayColumn"
        Me.cboDisplayColumn.Size = New System.Drawing.Size(164, 21)
        Me.cboDisplayColumn.TabIndex = 93
        '
        'btnExpandSalesList
        '
        Me.btnExpandSalesList.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExpandSalesList.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExpandSalesList.Location = New System.Drawing.Point(176, 23)
        Me.btnExpandSalesList.Name = "btnExpandSalesList"
        Me.btnExpandSalesList.Size = New System.Drawing.Size(22, 75)
        Me.btnExpandSalesList.TabIndex = 92
        Me.btnExpandSalesList.UseVisualStyleBackColor = True
        '
        'lvSales
        '
        Me.lvSales.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvSales.AllowColumnReorder = True
        Me.lvSales.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvSales.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.LeadID, Me.Contact1, Me.Address, Me.HousePhone, Me.Products, Me.ApptDateTime, Me.Reps})
        Me.lvSales.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvSales.FullRowSelect = True
        Me.lvSales.HideSelection = False
        Me.lvSales.Location = New System.Drawing.Point(0, 104)
        Me.lvSales.MultiSelect = False
        Me.lvSales.Name = "lvSales"
        Me.lvSales.Size = New System.Drawing.Size(207, 431)
        Me.lvSales.TabIndex = 91
        Me.lvSales.UseCompatibleStateImageBehavior = False
        Me.lvSales.View = System.Windows.Forms.View.Details
        '
        'LeadID
        '
        Me.LeadID.Text = "ID"
        '
        'Contact1
        '
        Me.Contact1.Text = "Contact(s)"
        Me.Contact1.Width = 160
        '
        'Address
        '
        Me.Address.Text = "Address"
        Me.Address.Width = 255
        '
        'HousePhone
        '
        Me.HousePhone.Text = "House Phone"
        Me.HousePhone.Width = 101
        '
        'Products
        '
        Me.Products.Text = "Product(s)"
        Me.Products.Width = 82
        '
        'ApptDateTime
        '
        Me.ApptDateTime.Text = "Appt. Date/Time"
        Me.ApptDateTime.Width = 144
        '
        'Reps
        '
        Me.Reps.Text = "Rep(s)"
        Me.Reps.Width = 99
        '
        'lblConfimingPLS
        '
        Me.lblConfimingPLS.AutoSize = True
        Me.lblConfimingPLS.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblConfimingPLS.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfimingPLS.ForeColor = System.Drawing.Color.Black
        Me.lblConfimingPLS.Location = New System.Drawing.Point(12, 3)
        Me.lblConfimingPLS.Name = "lblConfimingPLS"
        Me.lblConfimingPLS.Size = New System.Drawing.Size(75, 13)
        Me.lblConfimingPLS.TabIndex = 90
        Me.lblConfimingPLS.Text = "Select a List"
        '
        'cboSalesList
        '
        Me.cboSalesList.DropDownHeight = 150
        Me.cboSalesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSalesList.DropDownWidth = 200
        Me.cboSalesList.FormattingEnabled = True
        Me.cboSalesList.IntegralHeight = False
        Me.cboSalesList.Items.AddRange(New Object() {"Unfiltered Sales Dept. List", "Records Needing Sales Results", "Finance Dept. List", "Sales still within Recission Period", "Unconfirmed Appts. For Today", "Previous Customer List", "Recovery Dept. List", "Installation Dept. List", "Issue Leads List", "Scheduled Tasks List", "Custom..."})
        Me.cboSalesList.Location = New System.Drawing.Point(4, 23)
        Me.cboSalesList.Name = "cboSalesList"
        Me.cboSalesList.Size = New System.Drawing.Size(164, 21)
        Me.cboSalesList.TabIndex = 89
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lnkOrderbyMem)
        Me.TabPage2.Controls.Add(Me.lvMemorized)
        Me.TabPage2.Controls.Add(Me.lblFilterGroups)
        Me.TabPage2.Controls.Add(Me.btnExpandMemorize)
        Me.TabPage2.Controls.Add(Me.lbldisplaymemorized)
        Me.TabPage2.Controls.Add(Me.lblgroupbymemorized)
        Me.TabPage2.Controls.Add(Me.cboGroupByMemorized)
        Me.TabPage2.Controls.Add(Me.cboDisplayMemorized)
        Me.TabPage2.Controls.Add(Me.cboFilterGroups)
        Me.TabPage2.ImageIndex = 4
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(207, 535)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Memorized List"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lnkOrderbyMem
        '
        Me.lnkOrderbyMem.AutoSize = True
        Me.lnkOrderbyMem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkOrderbyMem.Location = New System.Drawing.Point(54, 3)
        Me.lnkOrderbyMem.Name = "lnkOrderbyMem"
        Me.lnkOrderbyMem.Size = New System.Drawing.Size(64, 13)
        Me.lnkOrderbyMem.TabIndex = 104
        Me.lnkOrderbyMem.TabStop = True
        Me.lnkOrderbyMem.Text = "Order By ID"
        '
        'lvMemorized
        '
        Me.lvMemorized.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvMemorized.AllowColumnReorder = True
        Me.lvMemorized.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvMemorized.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader9, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader13, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader10})
        Me.lvMemorized.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvMemorized.FullRowSelect = True
        Me.lvMemorized.HideSelection = False
        Me.lvMemorized.LabelEdit = True
        Me.lvMemorized.Location = New System.Drawing.Point(0, 104)
        Me.lvMemorized.MultiSelect = False
        Me.lvMemorized.Name = "lvMemorized"
        Me.lvMemorized.Size = New System.Drawing.Size(207, 431)
        Me.lvMemorized.TabIndex = 103
        Me.lvMemorized.UseCompatibleStateImageBehavior = False
        Me.lvMemorized.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = ""
        Me.ColumnHeader9.Width = 33
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Contact(s)"
        Me.ColumnHeader2.Width = 127
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Address"
        Me.ColumnHeader3.Width = 255
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.DisplayIndex = 6
        Me.ColumnHeader13.Text = "House Phone"
        Me.ColumnHeader13.Width = 101
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.DisplayIndex = 4
        Me.ColumnHeader4.Text = "Product(s)"
        Me.ColumnHeader4.Width = 82
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.DisplayIndex = 5
        Me.ColumnHeader5.Text = "Appt. Date/Time"
        Me.ColumnHeader5.Width = 144
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Rep(s)"
        Me.ColumnHeader10.Width = 99
        '
        'lblFilterGroups
        '
        Me.lblFilterGroups.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFilterGroups.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblFilterGroups.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFilterGroups.ForeColor = System.Drawing.Color.Gray
        Me.lblFilterGroups.Location = New System.Drawing.Point(4, 23)
        Me.lblFilterGroups.Name = "lblFilterGroups"
        Me.lblFilterGroups.Size = New System.Drawing.Size(144, 21)
        Me.lblFilterGroups.TabIndex = 102
        Me.lblFilterGroups.Text = "Filter Groups"
        Me.lblFilterGroups.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnExpandMemorize
        '
        Me.btnExpandMemorize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExpandMemorize.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExpandMemorize.Location = New System.Drawing.Point(176, 23)
        Me.btnExpandMemorize.Name = "btnExpandMemorize"
        Me.btnExpandMemorize.Size = New System.Drawing.Size(22, 75)
        Me.btnExpandMemorize.TabIndex = 101
        Me.btnExpandMemorize.UseVisualStyleBackColor = True
        '
        'lbldisplaymemorized
        '
        Me.lbldisplaymemorized.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbldisplaymemorized.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbldisplaymemorized.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldisplaymemorized.ForeColor = System.Drawing.Color.Gray
        Me.lbldisplaymemorized.Location = New System.Drawing.Point(4, 50)
        Me.lbldisplaymemorized.Name = "lbldisplaymemorized"
        Me.lbldisplaymemorized.Size = New System.Drawing.Size(144, 21)
        Me.lbldisplaymemorized.TabIndex = 100
        Me.lbldisplaymemorized.Text = "Change Display Column"
        Me.lbldisplaymemorized.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblgroupbymemorized
        '
        Me.lblgroupbymemorized.BackColor = System.Drawing.Color.Transparent
        Me.lblgroupbymemorized.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblgroupbymemorized.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblgroupbymemorized.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgroupbymemorized.ForeColor = System.Drawing.Color.Gray
        Me.lblgroupbymemorized.Location = New System.Drawing.Point(3, 77)
        Me.lblgroupbymemorized.Name = "lblgroupbymemorized"
        Me.lblgroupbymemorized.Size = New System.Drawing.Size(144, 21)
        Me.lblgroupbymemorized.TabIndex = 99
        Me.lblgroupbymemorized.Text = "Group By"
        Me.lblgroupbymemorized.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboGroupByMemorized
        '
        Me.cboGroupByMemorized.DropDownHeight = 150
        Me.cboGroupByMemorized.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGroupByMemorized.DropDownWidth = 164
        Me.cboGroupByMemorized.FormattingEnabled = True
        Me.cboGroupByMemorized.IntegralHeight = False
        Me.cboGroupByMemorized.Items.AddRange(New Object() {"", "Primary Product", "Appt. Date", "Sales Result", "Marketing Result", "Sales Rep", "City, State", "Zip Code"})
        Me.cboGroupByMemorized.Location = New System.Drawing.Point(4, 77)
        Me.cboGroupByMemorized.Name = "cboGroupByMemorized"
        Me.cboGroupByMemorized.Size = New System.Drawing.Size(164, 21)
        Me.cboGroupByMemorized.TabIndex = 98
        '
        'cboDisplayMemorized
        '
        Me.cboDisplayMemorized.DropDownHeight = 150
        Me.cboDisplayMemorized.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDisplayMemorized.DropDownWidth = 164
        Me.cboDisplayMemorized.FormattingEnabled = True
        Me.cboDisplayMemorized.IntegralHeight = False
        Me.cboDisplayMemorized.Items.AddRange(New Object() {"", "Record ID (Default)", "Contact(s)", "House Phone", "Products", "Appt. Date/Time", "Rep(s)"})
        Me.cboDisplayMemorized.Location = New System.Drawing.Point(4, 50)
        Me.cboDisplayMemorized.Name = "cboDisplayMemorized"
        Me.cboDisplayMemorized.Size = New System.Drawing.Size(164, 21)
        Me.cboDisplayMemorized.TabIndex = 97
        '
        'cboFilterGroups
        '
        Me.cboFilterGroups.DropDownHeight = 150
        Me.cboFilterGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFilterGroups.DropDownWidth = 164
        Me.cboFilterGroups.FormattingEnabled = True
        Me.cboFilterGroups.IntegralHeight = False
        Me.cboFilterGroups.Items.AddRange(New Object() {"Unfiltered Sales Dept. List", "Leads Needing Sales Results", "Finance Sale Status List", "Sales still within Recission Period", "Unconfirmed Appts. For Today", "Previous Customer List", "Recovery List", "Installation Dept. List", "Issue Leads List", "Custom..."})
        Me.cboFilterGroups.Location = New System.Drawing.Point(4, 23)
        Me.cboFilterGroups.Name = "cboFilterGroups"
        Me.cboFilterGroups.Size = New System.Drawing.Size(164, 21)
        Me.cboFilterGroups.TabIndex = 90
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripComboBox3, Me.ToolStripLabel2, Me.ToolStripButton2, Me.ToolStripSeparator13, Me.ToolStripSplitButton1, Me.ToolStripLabel3})
        Me.ToolStrip1.Location = New System.Drawing.Point(4, 354)
        Me.ToolStrip1.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(786, 33)
        Me.ToolStrip1.TabIndex = 202
        Me.ToolStrip1.Text = "ToolStrip1"
        Me.ToolStrip1.Visible = False
        '
        'ToolStripComboBox3
        '
        Me.ToolStripComboBox3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ToolStripComboBox3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ToolStripComboBox3.Items.AddRange(New Object() {"All", "Marketing Department", "Sales Department", "Finance Department", "Installation Department"})
        Me.ToolStripComboBox3.Margin = New System.Windows.Forms.Padding(1, 0, 10, 0)
        Me.ToolStripComboBox3.Name = "ToolStripComboBox3"
        Me.ToolStripComboBox3.Size = New System.Drawing.Size(160, 33)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.Margin = New System.Windows.Forms.Padding(10, 1, 0, 2)
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(43, 30)
        Me.ToolStripLabel2.Text = "Show"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(36, 30)
        Me.ToolStripButton2.Text = "ShowAFPics"
        Me.ToolStripButton2.ToolTipText = "Show Attached Files and Job Pictures for this Customer"
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(6, 33)
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.ToolStripSplitButton1.Image = CType(resources.GetObject("ToolStripSplitButton1.Image"), System.Drawing.Image)
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(272, 30)
        Me.ToolStripSplitButton1.Text = "Log Phone Conversation with this Customer"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(254, 22)
        Me.ToolStripMenuItem1.Text = "Log Appt. as Called and Cancelled"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel3.Margin = New System.Windows.Forms.Padding(40, 1, 0, 2)
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(150, 30)
        Me.ToolStripLabel3.Text = "Customer History"
        '
        'pnlCustomerHistory
        '
        Me.pnlCustomerHistory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCustomerHistory.AutoScroll = True
        Me.pnlCustomerHistory.Location = New System.Drawing.Point(4, 390)
        Me.pnlCustomerHistory.Name = "pnlCustomerHistory"
        Me.pnlCustomerHistory.Size = New System.Drawing.Size(743, 171)
        Me.pnlCustomerHistory.TabIndex = 200
        '
        'gbContactInfo
        '
        Me.gbContactInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbContactInfo.BackColor = System.Drawing.Color.White
        Me.gbContactInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.gbContactInfo.Controls.Add(Me.txtHousePhone)
        Me.gbContactInfo.Controls.Add(Me.txtaltphone2)
        Me.gbContactInfo.Controls.Add(Me.txtaltphone1)
        Me.gbContactInfo.Controls.Add(Me.lnkEmail)
        Me.gbContactInfo.Controls.Add(Me.lblEmail)
        Me.gbContactInfo.Controls.Add(Me.txtWorkHours)
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
        Me.gbContactInfo.Location = New System.Drawing.Point(5, 3)
        Me.gbContactInfo.Name = "gbContactInfo"
        Me.gbContactInfo.Size = New System.Drawing.Size(621, 198)
        Me.gbContactInfo.TabIndex = 191
        Me.gbContactInfo.TabStop = False
        Me.gbContactInfo.Text = "Contact Info:"
        '
        'txtHousePhone
        '
        Me.txtHousePhone.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHousePhone.BackColor = System.Drawing.Color.White
        Me.txtHousePhone.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtHousePhone.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHousePhone.ForeColor = System.Drawing.Color.Black
        Me.txtHousePhone.Location = New System.Drawing.Point(413, 33)
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
        Me.txtaltphone2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaltphone2.ForeColor = System.Drawing.Color.Black
        Me.txtaltphone2.Location = New System.Drawing.Point(413, 96)
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
        Me.txtaltphone1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaltphone1.ForeColor = System.Drawing.Color.Black
        Me.txtaltphone1.Location = New System.Drawing.Point(413, 64)
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
        Me.lnkEmail.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkEmail.Location = New System.Drawing.Point(360, 144)
        Me.lnkEmail.Name = "lnkEmail"
        Me.lnkEmail.Size = New System.Drawing.Size(144, 16)
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
        Me.lblEmail.Location = New System.Drawing.Point(309, 144)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(45, 16)
        Me.lblEmail.TabIndex = 135
        Me.lblEmail.Text = "Email:"
        '
        'txtWorkHours
        '
        Me.txtWorkHours.BackColor = System.Drawing.Color.White
        Me.txtWorkHours.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtWorkHours.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWorkHours.ForeColor = System.Drawing.Color.Black
        Me.txtWorkHours.Location = New System.Drawing.Point(100, 144)
        Me.txtWorkHours.Multiline = True
        Me.txtWorkHours.Name = "txtWorkHours"
        Me.txtWorkHours.ReadOnly = True
        Me.txtWorkHours.Size = New System.Drawing.Size(185, 38)
        Me.txtWorkHours.TabIndex = 134
        '
        'txtAlt1Type
        '
        Me.txtAlt1Type.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAlt1Type.BackColor = System.Drawing.Color.White
        Me.txtAlt1Type.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAlt1Type.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlt1Type.ForeColor = System.Drawing.Color.Black
        Me.txtAlt1Type.Location = New System.Drawing.Point(545, 64)
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
        Me.txtAlt2Type.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlt2Type.ForeColor = System.Drawing.Color.Black
        Me.txtAlt2Type.Location = New System.Drawing.Point(545, 96)
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
        Me.lblAltPhone2.Location = New System.Drawing.Point(309, 96)
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
        Me.lblAltPhone1.Location = New System.Drawing.Point(309, 64)
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
        Me.lblHousePhone.Location = New System.Drawing.Point(309, 33)
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
        Me.txtAddress.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.txtContact2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.txtContact1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.gbHomeInfo.Location = New System.Drawing.Point(632, 3)
        Me.gbHomeInfo.Name = "gbHomeInfo"
        Me.gbHomeInfo.Size = New System.Drawing.Size(113, 198)
        Me.gbHomeInfo.TabIndex = 183
        Me.gbHomeInfo.TabStop = False
        Me.gbHomeInfo.Text = "Home Info:"
        '
        'txtHomeValue
        '
        Me.txtHomeValue.BackColor = System.Drawing.Color.White
        Me.txtHomeValue.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtHomeValue.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHomeValue.ForeColor = System.Drawing.Color.Black
        Me.txtHomeValue.Location = New System.Drawing.Point(11, 152)
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
        Me.txtYrsOwned.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYrsOwned.ForeColor = System.Drawing.Color.Black
        Me.txtYrsOwned.Location = New System.Drawing.Point(11, 102)
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
        Me.lblYrBuilt.Location = New System.Drawing.Point(18, 33)
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
        Me.lblYrsOwned.Location = New System.Drawing.Point(8, 83)
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
        Me.lblHomeValue.Location = New System.Drawing.Point(13, 133)
        Me.lblHomeValue.Name = "lblHomeValue"
        Me.lblHomeValue.Size = New System.Drawing.Size(89, 16)
        Me.lblHomeValue.TabIndex = 32
        Me.lblHomeValue.Text = "Home Value:"
        '
        'txtYrBuilt
        '
        Me.txtYrBuilt.BackColor = System.Drawing.Color.White
        Me.txtYrBuilt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtYrBuilt.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYrBuilt.ForeColor = System.Drawing.Color.Black
        Me.txtYrBuilt.Location = New System.Drawing.Point(11, 52)
        Me.txtYrBuilt.Name = "txtYrBuilt"
        Me.txtYrBuilt.ReadOnly = True
        Me.txtYrBuilt.Size = New System.Drawing.Size(91, 16)
        Me.txtYrBuilt.TabIndex = 29
        Me.txtYrBuilt.Text = "1960"
        Me.txtYrBuilt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gbSpecialInstructions
        '
        Me.gbSpecialInstructions.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbSpecialInstructions.BackColor = System.Drawing.Color.White
        Me.gbSpecialInstructions.Controls.Add(Me.btnEditSPI)
        Me.gbSpecialInstructions.Controls.Add(Me.rtbSpecialInstructions)
        Me.gbSpecialInstructions.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSpecialInstructions.ForeColor = System.Drawing.Color.Gray
        Me.gbSpecialInstructions.Location = New System.Drawing.Point(445, 207)
        Me.gbSpecialInstructions.Name = "gbSpecialInstructions"
        Me.gbSpecialInstructions.Size = New System.Drawing.Size(300, 144)
        Me.gbSpecialInstructions.TabIndex = 188
        Me.gbSpecialInstructions.TabStop = False
        Me.gbSpecialInstructions.Text = "Special Instructions:"
        '
        'btnEditSPI
        '
        Me.btnEditSPI.Location = New System.Drawing.Point(238, 113)
        Me.btnEditSPI.Name = "btnEditSPI"
        Me.btnEditSPI.Size = New System.Drawing.Size(42, 23)
        Me.btnEditSPI.TabIndex = 147
        Me.btnEditSPI.Text = "Edit"
        Me.btnEditSPI.UseVisualStyleBackColor = True
        '
        'rtbSpecialInstructions
        '
        Me.rtbSpecialInstructions.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbSpecialInstructions.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbSpecialInstructions.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbSpecialInstructions.Location = New System.Drawing.Point(6, 22)
        Me.rtbSpecialInstructions.Name = "rtbSpecialInstructions"
        Me.rtbSpecialInstructions.Size = New System.Drawing.Size(219, 116)
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
        Me.gbProductInfo.Location = New System.Drawing.Point(198, 207)
        Me.gbProductInfo.Name = "gbProductInfo"
        Me.gbProductInfo.Size = New System.Drawing.Size(241, 144)
        Me.gbProductInfo.TabIndex = 187
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
        Me.txtProducts.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.txtColor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.txtQty.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.gbApptInfo.Location = New System.Drawing.Point(4, 207)
        Me.gbApptInfo.Name = "gbApptInfo"
        Me.gbApptInfo.Size = New System.Drawing.Size(188, 144)
        Me.gbApptInfo.TabIndex = 186
        Me.gbApptInfo.TabStop = False
        Me.gbApptInfo.Text = "Appointment Info:"
        '
        'txtApptDate
        '
        Me.txtApptDate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtApptDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.txtApptTime.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.txtApptDay.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApptDay.ForeColor = System.Drawing.Color.Black
        Me.txtApptDay.Location = New System.Drawing.Point(61, 73)
        Me.txtApptDay.Name = "txtApptDay"
        Me.txtApptDay.Size = New System.Drawing.Size(114, 16)
        Me.txtApptDay.TabIndex = 16
        Me.txtApptDay.Text = "Wednesday"
        '
        'tsCustomerLog
        '
        Me.tsCustomerLog.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tsCustomerLog.AutoSize = False
        Me.tsCustomerLog.Dock = System.Windows.Forms.DockStyle.None
        Me.tsCustomerLog.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsCustomerLog.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TScboCustomerHistory, Me.tslblShowDepartment, Me.tsbtnAFPics, Me.ToolStripButton3, Me.btnLogCall, Me.tslblCustomerHistory})
        Me.tsCustomerLog.Location = New System.Drawing.Point(4, 354)
        Me.tsCustomerLog.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.tsCustomerLog.Name = "tsCustomerLog"
        Me.tsCustomerLog.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.tsCustomerLog.Size = New System.Drawing.Size(741, 33)
        Me.tsCustomerLog.TabIndex = 189
        Me.tsCustomerLog.Text = "ToolStrip1"
        Me.tsCustomerLog.Visible = False
        '
        'TScboCustomerHistory
        '
        Me.TScboCustomerHistory.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TScboCustomerHistory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TScboCustomerHistory.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.TScboCustomerHistory.Items.AddRange(New Object() {"All", "Marketing Department", "Sales Department", "Finance Department", "Installation Department", "Recovery Department", "Administration", "Phone Correspondence"})
        Me.TScboCustomerHistory.Margin = New System.Windows.Forms.Padding(1, 0, 10, 0)
        Me.TScboCustomerHistory.Name = "TScboCustomerHistory"
        Me.TScboCustomerHistory.Size = New System.Drawing.Size(160, 33)
        '
        'tslblShowDepartment
        '
        Me.tslblShowDepartment.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tslblShowDepartment.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tslblShowDepartment.Margin = New System.Windows.Forms.Padding(10, 1, 0, 2)
        Me.tslblShowDepartment.Name = "tslblShowDepartment"
        Me.tslblShowDepartment.Size = New System.Drawing.Size(43, 30)
        Me.tslblShowDepartment.Text = "Show"
        '
        'tsbtnAFPics
        '
        Me.tsbtnAFPics.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnAFPics.Image = CType(resources.GetObject("tsbtnAFPics.Image"), System.Drawing.Image)
        Me.tsbtnAFPics.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbtnAFPics.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnAFPics.Name = "tsbtnAFPics"
        Me.tsbtnAFPics.Size = New System.Drawing.Size(36, 30)
        Me.tsbtnAFPics.Text = "ShowAFPics"
        Me.tsbtnAFPics.ToolTipText = "Show Attached Files and Job Pictures for this Customer"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(6, 33)
        '
        'btnLogCall
        '
        Me.btnLogCall.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCalledandCancelled})
        Me.btnLogCall.Image = CType(resources.GetObject("btnLogCall.Image"), System.Drawing.Image)
        Me.btnLogCall.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnLogCall.Name = "btnLogCall"
        Me.btnLogCall.Size = New System.Drawing.Size(272, 30)
        Me.btnLogCall.Text = "Log Phone Conversation with this Customer"
        '
        'btnCalledandCancelled
        '
        Me.btnCalledandCancelled.Image = Global.Latest.My.Resources.Resources.calledcancelled
        Me.btnCalledandCancelled.Name = "btnCalledandCancelled"
        Me.btnCalledandCancelled.Size = New System.Drawing.Size(254, 22)
        Me.btnCalledandCancelled.Text = "Log Appt. as Called and Cancelled"
        '
        'tslblCustomerHistory
        '
        Me.tslblCustomerHistory.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tslblCustomerHistory.Margin = New System.Windows.Forms.Padding(40, 1, 0, 2)
        Me.tslblCustomerHistory.Name = "tslblCustomerHistory"
        Me.tslblCustomerHistory.Size = New System.Drawing.Size(150, 19)
        Me.tslblCustomerHistory.Text = "Customer History"
        '
        'tsAFPics
        '
        Me.tsAFPics.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tsAFPics.AutoSize = False
        Me.tsAFPics.Dock = System.Windows.Forms.DockStyle.None
        Me.tsAFPics.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsAFPics.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tscboAFPicsFilter, Me.ToolStripLabel1, Me.tsbtnShowCH, Me.tsAttachedFilesNAV, Me.ToolStripSeparator2, Me.tslblAFPic})
        Me.tsAFPics.Location = New System.Drawing.Point(4, 354)
        Me.tsAFPics.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.tsAFPics.Name = "tsAFPics"
        Me.tsAFPics.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.tsAFPics.Size = New System.Drawing.Size(741, 33)
        Me.tsAFPics.TabIndex = 201
        Me.tsAFPics.Text = "ToolStrip1"
        '
        'tscboAFPicsFilter
        '
        Me.tscboAFPicsFilter.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tscboAFPicsFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tscboAFPicsFilter.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.tscboAFPicsFilter.Items.AddRange(New Object() {"All", "Job Pictures", "Attached Files"})
        Me.tscboAFPicsFilter.Margin = New System.Windows.Forms.Padding(1, 0, 10, 0)
        Me.tscboAFPicsFilter.Name = "tscboAFPicsFilter"
        Me.tscboAFPicsFilter.Size = New System.Drawing.Size(160, 33)
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
        'tsbtnShowCH
        '
        Me.tsbtnShowCH.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnShowCH.Image = CType(resources.GetObject("tsbtnShowCH.Image"), System.Drawing.Image)
        Me.tsbtnShowCH.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbtnShowCH.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnShowCH.Name = "tsbtnShowCH"
        Me.tsbtnShowCH.Size = New System.Drawing.Size(36, 30)
        Me.tsbtnShowCH.Text = "ShowAFPics"
        Me.tsbtnShowCH.ToolTipText = "Go Back to Customer History"
        '
        'tsAttachedFilesNAV
        '
        Me.tsAttachedFilesNAV.AutoSize = False
        Me.tsAttachedFilesNAV.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsAttachedFilesNAV.Enabled = False
        Me.tsAttachedFilesNAV.Image = CType(resources.GetObject("tsAttachedFilesNAV.Image"), System.Drawing.Image)
        Me.tsAttachedFilesNAV.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsAttachedFilesNAV.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsAttachedFilesNAV.Name = "tsAttachedFilesNAV"
        Me.tsAttachedFilesNAV.Size = New System.Drawing.Size(36, 30)
        Me.tsAttachedFilesNAV.Text = "Up One Level"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 33)
        '
        'tslblAFPic
        '
        Me.tslblAFPic.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tslblAFPic.Margin = New System.Windows.Forms.Padding(5, 1, 0, 2)
        Me.tslblAFPic.Name = "tslblAFPic"
        Me.tslblAFPic.Size = New System.Drawing.Size(279, 30)
        Me.tslblAFPic.Text = "Attached Files and Job Pictures..."
        '
        'tpIssueLeads
        '
        Me.tpIssueLeads.AutoScrollMargin = New System.Drawing.Size(20, 0)
        Me.tpIssueLeads.ImageKey = "Issue Leads.png"
        Me.tpIssueLeads.Location = New System.Drawing.Point(23, 4)
        Me.tpIssueLeads.Name = "tpIssueLeads"
        Me.tpIssueLeads.Padding = New System.Windows.Forms.Padding(3)
        Me.tpIssueLeads.Size = New System.Drawing.Size(963, 567)
        Me.tpIssueLeads.TabIndex = 2
        Me.tpIssueLeads.UseVisualStyleBackColor = True
        '
        'tpReferences
        '
        Me.tpReferences.ImageKey = "References.png"
        Me.tpReferences.Location = New System.Drawing.Point(23, 4)
        Me.tpReferences.Name = "tpReferences"
        Me.tpReferences.Padding = New System.Windows.Forms.Padding(3)
        Me.tpReferences.Size = New System.Drawing.Size(963, 567)
        Me.tpReferences.TabIndex = 3
        Me.tpReferences.UseVisualStyleBackColor = True
        '
        'tpReports
        '
        Me.tpReports.ImageKey = "Reports.png"
        Me.tpReports.Location = New System.Drawing.Point(23, 4)
        Me.tpReports.Name = "tpReports"
        Me.tpReports.Padding = New System.Windows.Forms.Padding(3)
        Me.tpReports.Size = New System.Drawing.Size(963, 567)
        Me.tpReports.TabIndex = 4
        Me.tpReports.UseVisualStyleBackColor = True
        '
        'MarketingManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(990, 600)
        Me.Controls.Add(Me.tbMain)
        Me.Controls.Add(Me.tsMarketingDepartment)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MarketingManager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MarketingManager"
        Me.tsMarketingDepartment.ResumeLayout(False)
        Me.tsMarketingDepartment.PerformLayout()
        Me.tbMain.ResumeLayout(False)
        Me.tpSummary.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.tpCustomerList.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.gbContactInfo.ResumeLayout(False)
        Me.gbContactInfo.PerformLayout()
        CType(Me.pctVerified, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbHomeInfo.ResumeLayout(False)
        Me.gbHomeInfo.PerformLayout()
        Me.gbSpecialInstructions.ResumeLayout(False)
        Me.gbProductInfo.ResumeLayout(False)
        Me.gbProductInfo.PerformLayout()
        Me.gbApptInfo.ResumeLayout(False)
        Me.gbApptInfo.PerformLayout()
        Me.tsCustomerLog.ResumeLayout(False)
        Me.tsCustomerLog.PerformLayout()
        Me.tsAFPics.ResumeLayout(False)
        Me.tsAFPics.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsMarketingDepartment As System.Windows.Forms.ToolStrip
    Friend WithEvents ScheduledTasks As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents btnMarkTaskAsDone As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnEditScheduledTask As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnRemoveThisCompletedTask As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnRemoveAllScheduledTask As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tbMain As System.Windows.Forms.TabControl
    Friend WithEvents tpSummary As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents pnlScheduledTasks As System.Windows.Forms.Panel
    Friend WithEvents tpCustomerList As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents lblDisplayColumn As System.Windows.Forms.Label
    Friend WithEvents lblGroupBy As System.Windows.Forms.Label
    Friend WithEvents cboGroupSales As System.Windows.Forms.ComboBox
    Friend WithEvents cboDisplayColumn As System.Windows.Forms.ComboBox
    Friend WithEvents btnExpandSalesList As System.Windows.Forms.Button
    Friend WithEvents lvSales As System.Windows.Forms.ListView
    Friend WithEvents LeadID As System.Windows.Forms.ColumnHeader
    Friend WithEvents Contact1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Address As System.Windows.Forms.ColumnHeader
    Friend WithEvents HousePhone As System.Windows.Forms.ColumnHeader
    Friend WithEvents Products As System.Windows.Forms.ColumnHeader
    Friend WithEvents ApptDateTime As System.Windows.Forms.ColumnHeader
    Friend WithEvents Reps As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblConfimingPLS As System.Windows.Forms.Label
    Friend WithEvents cboSalesList As System.Windows.Forms.ComboBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents lnkOrderbyMem As System.Windows.Forms.LinkLabel
    Friend WithEvents lvMemorized As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblFilterGroups As System.Windows.Forms.Label
    Friend WithEvents btnExpandMemorize As System.Windows.Forms.Button
    Friend WithEvents lbldisplaymemorized As System.Windows.Forms.Label
    Friend WithEvents lblgroupbymemorized As System.Windows.Forms.Label
    Friend WithEvents cboGroupByMemorized As System.Windows.Forms.ComboBox
    Friend WithEvents cboDisplayMemorized As System.Windows.Forms.ComboBox
    Friend WithEvents cboFilterGroups As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripComboBox3 As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator13 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSplitButton1 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents pnlCustomerHistory As System.Windows.Forms.Panel
    Friend WithEvents gbContactInfo As System.Windows.Forms.GroupBox
    Friend WithEvents txtHousePhone As System.Windows.Forms.TextBox
    Friend WithEvents txtaltphone2 As System.Windows.Forms.TextBox
    Friend WithEvents txtaltphone1 As System.Windows.Forms.TextBox
    Friend WithEvents lnkEmail As System.Windows.Forms.LinkLabel
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtWorkHours As System.Windows.Forms.TextBox
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
    Friend WithEvents gbHomeInfo As System.Windows.Forms.GroupBox
    Friend WithEvents txtHomeValue As System.Windows.Forms.TextBox
    Friend WithEvents txtYrsOwned As System.Windows.Forms.TextBox
    Friend WithEvents lblYrBuilt As System.Windows.Forms.Label
    Friend WithEvents lblYrsOwned As System.Windows.Forms.Label
    Friend WithEvents lblHomeValue As System.Windows.Forms.Label
    Friend WithEvents txtYrBuilt As System.Windows.Forms.TextBox
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
    Friend WithEvents tsCustomerLog As System.Windows.Forms.ToolStrip
    Friend WithEvents TScboCustomerHistory As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents tslblShowDepartment As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tsbtnAFPics As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnLogCall As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents btnCalledandCancelled As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tslblCustomerHistory As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tsAFPics As System.Windows.Forms.ToolStrip
    Private WithEvents tscboAFPicsFilter As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tsbtnShowCH As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsAttachedFilesNAV As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tslblAFPic As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tpIssueLeads As System.Windows.Forms.TabPage
    Friend WithEvents tpReferences As System.Windows.Forms.TabPage
    Friend WithEvents tpReports As System.Windows.Forms.TabPage
    Friend WithEvents btnEditSPI As System.Windows.Forms.Button
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents GenerateWarmCallingListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RecoveryListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PreviewCustomerListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSplitButton2 As System.Windows.Forms.ToolStripSplitButton
End Class
