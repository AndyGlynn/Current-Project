<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sales
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
        Me.components = New System.ComponentModel.Container()
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"12/12/2007", "12345", "Earnest VanDielen"}, -1)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sales))
        Me.tsSalesDepartment = New System.Windows.Forms.ToolStrip()
        Me.tbMain = New System.Windows.Forms.TabControl()
        Me.tpSummary = New System.Windows.Forms.TabPage()
        Me.lblRC = New System.Windows.Forms.Label()
        Me.lblND = New System.Windows.Forms.Label()
        Me.lblRep = New System.Windows.Forms.Label()
        Me.lblDNS = New System.Windows.Forms.Label()
        Me.lblNH = New System.Windows.Forms.Label()
        Me.lblsales = New System.Windows.Forms.Label()
        Me.lblSold = New System.Windows.Forms.Label()
        Me.lblAccuracy = New System.Windows.Forms.Label()
        Me.pnlPerformanceReport = New System.Windows.Forms.Panel()
        Me.lblNoData = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.lvnoresults = New System.Windows.Forms.ListView()
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmlvnoresults = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SCsalesresult = New System.Windows.Forms.ToolStripMenuItem()
        Me.SCCustomerList = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.pnlScheduledTasks = New System.Windows.Forms.Panel()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MarkTaskAsDoneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditScheduledTaskToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HideThisCompletedTaskToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblResets = New System.Windows.Forms.Label()
        Me.lblIssued = New System.Windows.Forms.Label()
        Me.tpCustomerList = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lblCntFiltered = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
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
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ShowNotesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.EnterSalesResultToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MemorizeThisApptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveThisApptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.CallThisCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SendALetterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.SetAppointmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetAppointmentToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoveAppointmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AssignChangeSalesRepToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripComboBox2 = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveChangesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintAppointmentSheetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintCustomerInformationSheetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.ilCustomerHistory = New System.Windows.Forms.ImageList(Me.components)
        Me.lblFilterGroups = New System.Windows.Forms.Label()
        Me.btnExpandMemorize = New System.Windows.Forms.Button()
        Me.lbldisplaymemorized = New System.Windows.Forms.Label()
        Me.lblgroupbymemorized = New System.Windows.Forms.Label()
        Me.cboGroupByMemorized = New System.Windows.Forms.ComboBox()
        Me.cboDisplayMemorized = New System.Windows.Forms.ComboBox()
        Me.cboFilterGroups = New System.Windows.Forms.ComboBox()
        Me.ilToolbarButtons = New System.Windows.Forms.ImageList(Me.components)
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
        Me.btnUpdateSPI = New System.Windows.Forms.Button()
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
        Me.btnCandC = New System.Windows.Forms.ToolStripMenuItem()
        Me.tslblCustomerHistory = New System.Windows.Forms.ToolStripLabel()
        Me.pnlAFPics = New System.Windows.Forms.Panel()
        Me.lsAttachedFiles = New System.Windows.Forms.ListView()
        Me.cmAF = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btnOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSendtoDesktop = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCreateSC = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnRename = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnView = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnXLarge = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnLarge = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnMedium = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSmall = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnList = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnDetails = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnTiles = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSortby = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAscending = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnDescending = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnRefresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnNewFolder = New System.Windows.Forms.ToolStripMenuItem()
        Me.lsJobPictures = New System.Windows.Forms.ListView()
        Me.cmJP = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSendtoDesktopJP = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCutJP = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCopyJP = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator15 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCreateSCJP = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnDeleteJP = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnRenameJP = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnJPViews = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmJPExtraLarge = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmJPLarge = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmJPMedium = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmJPSmall = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator16 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmJPList = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmJPDetails = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmJPTiles = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem17 = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAscendingJP = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnDescJP = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnRefreshJP = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator18 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnPasteJP = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator19 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnNewFolderJP = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsAFPics = New System.Windows.Forms.ToolStrip()
        Me.tscboAFPicsFilter = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.tsbtnShowCH = New System.Windows.Forms.ToolStripButton()
        Me.tsAttachedFilesNAV = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tslblAFPic = New System.Windows.Forms.ToolStripLabel()
        Me.pnlCustomerHistory = New System.Windows.Forms.Panel()
        Me.tpIssueLeads = New System.Windows.Forms.TabPage()
        Me.pnlIssue = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tpReferences = New System.Windows.Forms.TabPage()
        Me.tpReports = New System.Windows.Forms.TabPage()
        Me.ilTabLabels = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CallHousePhone4194724000ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToThisCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportListToLetterWizardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoToLetterWizardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImgLst256 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImgLst128 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImgLst48 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImgLst32 = New System.Windows.Forms.ImageList(Me.components)
        Me.imgLst16 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImgIssued = New System.Windows.Forms.ImageList(Me.components)
        Me.ImgIssued2 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImgIssued3 = New System.Windows.Forms.ImageList(Me.components)
        Me.cmIssue = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PrintThisLeadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmailThisLeadToAssignedRepsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.bgGetImages = New System.ComponentModel.BackgroundWorker()
        Me.bgSalesQuery = New System.ComponentModel.BackgroundWorker()
        Me.bgNoResults = New System.ComponentModel.BackgroundWorker()
        Me.bgCustomerHistory = New System.ComponentModel.BackgroundWorker()
        Me.tmrdtpCustList = New System.Windows.Forms.Timer(Me.components)
        Me.tmrSum = New System.Windows.Forms.Timer(Me.components)
        Me.tbMain.SuspendLayout()
        Me.tpSummary.SuspendLayout()
        Me.pnlPerformanceReport.SuspendLayout()
        Me.cmlvnoresults.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.tpCustomerList.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.gbContactInfo.SuspendLayout()
        CType(Me.pctVerified, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbHomeInfo.SuspendLayout()
        Me.gbSpecialInstructions.SuspendLayout()
        Me.gbProductInfo.SuspendLayout()
        Me.gbApptInfo.SuspendLayout()
        Me.tsCustomerLog.SuspendLayout()
        Me.pnlAFPics.SuspendLayout()
        Me.cmAF.SuspendLayout()
        Me.cmJP.SuspendLayout()
        Me.tsAFPics.SuspendLayout()
        Me.tpIssueLeads.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.cmIssue.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsSalesDepartment
        '
        Me.tsSalesDepartment.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsSalesDepartment.Location = New System.Drawing.Point(0, 0)
        Me.tsSalesDepartment.Name = "tsSalesDepartment"
        Me.tsSalesDepartment.Size = New System.Drawing.Size(1115, 25)
        Me.tsSalesDepartment.TabIndex = 0
        Me.tsSalesDepartment.Text = "ToolStrip1"
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
        Me.tbMain.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMain.ImageList = Me.ilTabLabels
        Me.tbMain.Location = New System.Drawing.Point(0, 25)
        Me.tbMain.Margin = New System.Windows.Forms.Padding(0)
        Me.tbMain.Multiline = True
        Me.tbMain.Name = "tbMain"
        Me.tbMain.Padding = New System.Drawing.Point(0, 0)
        Me.tbMain.SelectedIndex = 0
        Me.tbMain.Size = New System.Drawing.Size(1115, 576)
        Me.tbMain.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.tbMain.TabIndex = 1
        '
        'tpSummary
        '
        Me.tpSummary.Controls.Add(Me.lblRC)
        Me.tpSummary.Controls.Add(Me.lblND)
        Me.tpSummary.Controls.Add(Me.lblRep)
        Me.tpSummary.Controls.Add(Me.lblDNS)
        Me.tpSummary.Controls.Add(Me.lblNH)
        Me.tpSummary.Controls.Add(Me.lblsales)
        Me.tpSummary.Controls.Add(Me.lblSold)
        Me.tpSummary.Controls.Add(Me.lblAccuracy)
        Me.tpSummary.Controls.Add(Me.pnlPerformanceReport)
        Me.tpSummary.Controls.Add(Me.Label4)
        Me.tpSummary.Controls.Add(Me.Label38)
        Me.tpSummary.Controls.Add(Me.lvnoresults)
        Me.tpSummary.Controls.Add(Me.GroupBox4)
        Me.tpSummary.Controls.Add(Me.lblResets)
        Me.tpSummary.Controls.Add(Me.lblIssued)
        Me.tpSummary.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tpSummary.ImageKey = "Summary- Selected.png"
        Me.tpSummary.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.tpSummary.Location = New System.Drawing.Point(30, 4)
        Me.tpSummary.Name = "tpSummary"
        Me.tpSummary.Padding = New System.Windows.Forms.Padding(3)
        Me.tpSummary.Size = New System.Drawing.Size(1081, 568)
        Me.tpSummary.TabIndex = 0
        Me.tpSummary.UseVisualStyleBackColor = True
        '
        'lblRC
        '
        Me.lblRC.BackColor = System.Drawing.Color.Transparent
        Me.lblRC.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRC.ForeColor = System.Drawing.Color.Black
        Me.lblRC.Location = New System.Drawing.Point(738, 329)
        Me.lblRC.Name = "lblRC"
        Me.lblRC.Size = New System.Drawing.Size(122, 20)
        Me.lblRC.TabIndex = 256
        Me.lblRC.Text = "Recission Cancels"
        Me.lblRC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblND
        '
        Me.lblND.BackColor = System.Drawing.Color.Transparent
        Me.lblND.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblND.ForeColor = System.Drawing.Color.Black
        Me.lblND.Location = New System.Drawing.Point(512, 329)
        Me.lblND.Name = "lblND"
        Me.lblND.Size = New System.Drawing.Size(122, 20)
        Me.lblND.TabIndex = 257
        Me.lblND.Text = "No Demos"
        Me.lblND.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRep
        '
        Me.lblRep.BackColor = System.Drawing.Color.Transparent
        Me.lblRep.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRep.ForeColor = System.Drawing.Color.Black
        Me.lblRep.Location = New System.Drawing.Point(12, 329)
        Me.lblRep.Name = "lblRep"
        Me.lblRep.Size = New System.Drawing.Size(71, 20)
        Me.lblRep.TabIndex = 249
        Me.lblRep.Text = "Sales Rep"
        Me.lblRep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDNS
        '
        Me.lblDNS.BackColor = System.Drawing.Color.Transparent
        Me.lblDNS.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDNS.ForeColor = System.Drawing.Color.Black
        Me.lblDNS.Location = New System.Drawing.Point(173, 329)
        Me.lblDNS.Name = "lblDNS"
        Me.lblDNS.Size = New System.Drawing.Size(122, 20)
        Me.lblDNS.TabIndex = 251
        Me.lblDNS.Text = "Demo/No Sales"
        Me.lblDNS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNH
        '
        Me.lblNH.BackColor = System.Drawing.Color.Transparent
        Me.lblNH.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNH.ForeColor = System.Drawing.Color.Black
        Me.lblNH.Location = New System.Drawing.Point(286, 329)
        Me.lblNH.Name = "lblNH"
        Me.lblNH.Size = New System.Drawing.Size(122, 20)
        Me.lblNH.TabIndex = 253
        Me.lblNH.Text = "Not Hits"
        Me.lblNH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblsales
        '
        Me.lblsales.BackColor = System.Drawing.Color.Transparent
        Me.lblsales.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsales.ForeColor = System.Drawing.Color.Black
        Me.lblsales.Location = New System.Drawing.Point(625, 329)
        Me.lblsales.Name = "lblsales"
        Me.lblsales.Size = New System.Drawing.Size(122, 20)
        Me.lblsales.TabIndex = 254
        Me.lblsales.Text = "Sales"
        Me.lblsales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSold
        '
        Me.lblSold.BackColor = System.Drawing.Color.Transparent
        Me.lblSold.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSold.ForeColor = System.Drawing.Color.Black
        Me.lblSold.Location = New System.Drawing.Point(851, 329)
        Me.lblSold.Name = "lblSold"
        Me.lblSold.Size = New System.Drawing.Size(122, 20)
        Me.lblSold.TabIndex = 255
        Me.lblSold.Text = "$Sold$"
        Me.lblSold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAccuracy
        '
        Me.lblAccuracy.AutoSize = True
        Me.lblAccuracy.BackColor = System.Drawing.Color.Transparent
        Me.lblAccuracy.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccuracy.ForeColor = System.Drawing.Color.Black
        Me.lblAccuracy.Location = New System.Drawing.Point(12, 300)
        Me.lblAccuracy.Name = "lblAccuracy"
        Me.lblAccuracy.Size = New System.Drawing.Size(0, 16)
        Me.lblAccuracy.TabIndex = 229
        '
        'pnlPerformanceReport
        '
        Me.pnlPerformanceReport.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlPerformanceReport.AutoScroll = True
        Me.pnlPerformanceReport.BackColor = System.Drawing.Color.White
        Me.pnlPerformanceReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlPerformanceReport.Controls.Add(Me.lblNoData)
        Me.pnlPerformanceReport.Controls.Add(Me.Label64)
        Me.pnlPerformanceReport.Location = New System.Drawing.Point(3, 353)
        Me.pnlPerformanceReport.Name = "pnlPerformanceReport"
        Me.pnlPerformanceReport.Size = New System.Drawing.Size(1070, 212)
        Me.pnlPerformanceReport.TabIndex = 231
        '
        'lblNoData
        '
        Me.lblNoData.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblNoData.AutoSize = True
        Me.lblNoData.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoData.Location = New System.Drawing.Point(470, -232)
        Me.lblNoData.Name = "lblNoData"
        Me.lblNoData.Size = New System.Drawing.Size(616, 25)
        Me.lblNoData.TabIndex = 204
        Me.lblNoData.Text = "There is No Data to Report for The Date Range Provided!"
        '
        'Label64
        '
        Me.Label64.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label64.AutoSize = True
        Me.Label64.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.Location = New System.Drawing.Point(465, 220)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(38, 16)
        Me.Label64.TabIndex = 203
        Me.Label64.Text = "35%"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(368, 295)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 18)
        Me.Label4.TabIndex = 225
        Me.Label4.Text = "Performance Report"
        '
        'Label38
        '
        Me.Label38.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(669, 6)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(229, 16)
        Me.Label38.TabIndex = 224
        Me.Label38.Text = "All Records Needing Sales Results"
        '
        'lvnoresults
        '
        Me.lvnoresults.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvnoresults.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvnoresults.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader8, Me.ColumnHeader7})
        Me.lvnoresults.ContextMenuStrip = Me.cmlvnoresults
        Me.lvnoresults.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvnoresults.FullRowSelect = True
        Me.lvnoresults.HideSelection = False
        Me.lvnoresults.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.lvnoresults.Location = New System.Drawing.Point(672, 25)
        Me.lvnoresults.MultiSelect = False
        Me.lvnoresults.Name = "lvnoresults"
        Me.lvnoresults.Size = New System.Drawing.Size(401, 263)
        Me.lvnoresults.TabIndex = 223
        Me.lvnoresults.UseCompatibleStateImageBehavior = False
        Me.lvnoresults.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Date"
        Me.ColumnHeader6.Width = 85
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "ID"
        Me.ColumnHeader8.Width = 67
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Sales Rep(s)"
        Me.ColumnHeader7.Width = 221
        '
        'cmlvnoresults
        '
        Me.cmlvnoresults.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SCsalesresult, Me.SCCustomerList})
        Me.cmlvnoresults.Name = "cmlvnoresults"
        Me.cmlvnoresults.Size = New System.Drawing.Size(180, 48)
        '
        'SCsalesresult
        '
        Me.SCsalesresult.Image = Global.Latest.My.Resources.Resources.cash2
        Me.SCsalesresult.Name = "SCsalesresult"
        Me.SCsalesresult.Size = New System.Drawing.Size(179, 22)
        Me.SCsalesresult.Text = "Enter Sales Result"
        '
        'SCCustomerList
        '
        Me.SCCustomerList.Name = "SCCustomerList"
        Me.SCCustomerList.Size = New System.Drawing.Size(179, 22)
        Me.SCCustomerList.Text = "Go to Customer List"
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.pnlScheduledTasks)
        Me.GroupBox4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox4.Size = New System.Drawing.Size(657, 282)
        Me.GroupBox4.TabIndex = 221
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Scheduled Tasks - Sales Department"
        '
        'pnlScheduledTasks
        '
        Me.pnlScheduledTasks.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlScheduledTasks.AutoScroll = True
        Me.pnlScheduledTasks.BackColor = System.Drawing.Color.White
        Me.pnlScheduledTasks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlScheduledTasks.ContextMenuStrip = Me.ContextMenuStrip2
        Me.pnlScheduledTasks.Location = New System.Drawing.Point(8, 22)
        Me.pnlScheduledTasks.Name = "pnlScheduledTasks"
        Me.pnlScheduledTasks.Size = New System.Drawing.Size(639, 254)
        Me.pnlScheduledTasks.TabIndex = 246
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MarkTaskAsDoneToolStripMenuItem, Me.EditScheduledTaskToolStripMenuItem, Me.HideThisCompletedTaskToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(211, 70)
        '
        'MarkTaskAsDoneToolStripMenuItem
        '
        Me.MarkTaskAsDoneToolStripMenuItem.Name = "MarkTaskAsDoneToolStripMenuItem"
        Me.MarkTaskAsDoneToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.MarkTaskAsDoneToolStripMenuItem.Text = "Mark Task as Done"
        '
        'EditScheduledTaskToolStripMenuItem
        '
        Me.EditScheduledTaskToolStripMenuItem.Name = "EditScheduledTaskToolStripMenuItem"
        Me.EditScheduledTaskToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.EditScheduledTaskToolStripMenuItem.Text = "Edit Scheduled Task"
        '
        'HideThisCompletedTaskToolStripMenuItem
        '
        Me.HideThisCompletedTaskToolStripMenuItem.Name = "HideThisCompletedTaskToolStripMenuItem"
        Me.HideThisCompletedTaskToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.HideThisCompletedTaskToolStripMenuItem.Text = "HideThis Completed Task"
        '
        'lblResets
        '
        Me.lblResets.BackColor = System.Drawing.Color.Transparent
        Me.lblResets.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResets.ForeColor = System.Drawing.Color.Black
        Me.lblResets.Location = New System.Drawing.Point(399, 329)
        Me.lblResets.Name = "lblResets"
        Me.lblResets.Size = New System.Drawing.Size(122, 20)
        Me.lblResets.TabIndex = 252
        Me.lblResets.Text = "Resets"
        Me.lblResets.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblIssued
        '
        Me.lblIssued.BackColor = System.Drawing.Color.Transparent
        Me.lblIssued.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIssued.ForeColor = System.Drawing.Color.Black
        Me.lblIssued.Location = New System.Drawing.Point(74, 329)
        Me.lblIssued.Name = "lblIssued"
        Me.lblIssued.Size = New System.Drawing.Size(122, 20)
        Me.lblIssued.TabIndex = 250
        Me.lblIssued.Text = "Issued"
        Me.lblIssued.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tpCustomerList
        '
        Me.tpCustomerList.Controls.Add(Me.SplitContainer1)
        Me.tpCustomerList.ImageKey = "Customer List.png"
        Me.tpCustomerList.Location = New System.Drawing.Point(30, 4)
        Me.tpCustomerList.Name = "tpCustomerList"
        Me.tpCustomerList.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCustomerList.Size = New System.Drawing.Size(1081, 568)
        Me.tpCustomerList.TabIndex = 1
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbContactInfo)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbHomeInfo)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbSpecialInstructions)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbProductInfo)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbApptInfo)
        Me.SplitContainer1.Panel2.Controls.Add(Me.tsCustomerLog)
        Me.SplitContainer1.Panel2.Controls.Add(Me.pnlAFPics)
        Me.SplitContainer1.Panel2.Controls.Add(Me.tsAFPics)
        Me.SplitContainer1.Panel2.Controls.Add(Me.pnlCustomerHistory)
        Me.SplitContainer1.Size = New System.Drawing.Size(1075, 562)
        Me.SplitContainer1.SplitterDistance = 215
        Me.SplitContainer1.SplitterWidth = 1
        Me.SplitContainer1.TabIndex = 0
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage1)
        Me.TabControl2.Controls.Add(Me.TabPage2)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl2.ImageList = Me.ilToolbarButtons
        Me.TabControl2.Location = New System.Drawing.Point(0, 0)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.ShowToolTips = True
        Me.TabControl2.Size = New System.Drawing.Size(215, 562)
        Me.TabControl2.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lblCntFiltered)
        Me.TabPage1.Controls.Add(Me.Label3)
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
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(207, 535)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Sales List"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lblCntFiltered
        '
        Me.lblCntFiltered.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblCntFiltered.AutoSize = True
        Me.lblCntFiltered.Location = New System.Drawing.Point(92, 519)
        Me.lblCntFiltered.Name = "lblCntFiltered"
        Me.lblCntFiltered.Size = New System.Drawing.Size(11, 13)
        Me.lblCntFiltered.TabIndex = 99
        Me.lblCntFiltered.Text = " "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label3.Location = New System.Drawing.Point(3, 519)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 98
        Me.Label3.Text = "Records: "
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
        Me.lvSales.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lvSales.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvSales.FullRowSelect = True
        Me.lvSales.HideSelection = False
        Me.lvSales.Location = New System.Drawing.Point(0, 104)
        Me.lvSales.MultiSelect = False
        Me.lvSales.Name = "lvSales"
        Me.lvSales.Size = New System.Drawing.Size(207, 407)
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
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowNotesToolStripMenuItem, Me.ToolStripSeparator1, Me.EnterSalesResultToolStripMenuItem, Me.MemorizeThisApptToolStripMenuItem, Me.RemoveThisApptToolStripMenuItem, Me.CustomerToolsToolStripMenuItem, Me.PrintToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(193, 142)
        '
        'ShowNotesToolStripMenuItem
        '
        Me.ShowNotesToolStripMenuItem.Image = CType(resources.GetObject("ShowNotesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ShowNotesToolStripMenuItem.Name = "ShowNotesToolStripMenuItem"
        Me.ShowNotesToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.ShowNotesToolStripMenuItem.Text = "Show Notes"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(189, 6)
        '
        'EnterSalesResultToolStripMenuItem
        '
        Me.EnterSalesResultToolStripMenuItem.Image = CType(resources.GetObject("EnterSalesResultToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EnterSalesResultToolStripMenuItem.Name = "EnterSalesResultToolStripMenuItem"
        Me.EnterSalesResultToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.EnterSalesResultToolStripMenuItem.Text = "Enter Sales Result"
        '
        'MemorizeThisApptToolStripMenuItem
        '
        Me.MemorizeThisApptToolStripMenuItem.Image = CType(resources.GetObject("MemorizeThisApptToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MemorizeThisApptToolStripMenuItem.Name = "MemorizeThisApptToolStripMenuItem"
        Me.MemorizeThisApptToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.MemorizeThisApptToolStripMenuItem.Text = "Memorize This Record"
        '
        'RemoveThisApptToolStripMenuItem
        '
        Me.RemoveThisApptToolStripMenuItem.Image = CType(resources.GetObject("RemoveThisApptToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RemoveThisApptToolStripMenuItem.Name = "RemoveThisApptToolStripMenuItem"
        Me.RemoveThisApptToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.RemoveThisApptToolStripMenuItem.Text = "Remove This Record"
        '
        'CustomerToolsToolStripMenuItem
        '
        Me.CustomerToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditCustomerToolStripMenuItem, Me.ToolStripSeparator3, Me.CallThisCustomerToolStripMenuItem, Me.EmaToolStripMenuItem, Me.SendALetterToolStripMenuItem, Me.ToolStripSeparator4, Me.SetAppointmentToolStripMenuItem, Me.AssignChangeSalesRepToolStripMenuItem})
        Me.CustomerToolsToolStripMenuItem.Image = CType(resources.GetObject("CustomerToolsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CustomerToolsToolStripMenuItem.Name = "CustomerToolsToolStripMenuItem"
        Me.CustomerToolsToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.CustomerToolsToolStripMenuItem.Text = "Customer Tools"
        '
        'EditCustomerToolStripMenuItem
        '
        Me.EditCustomerToolStripMenuItem.Image = CType(resources.GetObject("EditCustomerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EditCustomerToolStripMenuItem.Name = "EditCustomerToolStripMenuItem"
        Me.EditCustomerToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.EditCustomerToolStripMenuItem.Text = "Edit Customer"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(204, 6)
        '
        'CallThisCustomerToolStripMenuItem
        '
        Me.CallThisCustomerToolStripMenuItem.Image = CType(resources.GetObject("CallThisCustomerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CallThisCustomerToolStripMenuItem.Name = "CallThisCustomerToolStripMenuItem"
        Me.CallThisCustomerToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.CallThisCustomerToolStripMenuItem.Text = "Call This Customer"
        '
        'EmaToolStripMenuItem
        '
        Me.EmaToolStripMenuItem.Image = CType(resources.GetObject("EmaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EmaToolStripMenuItem.Name = "EmaToolStripMenuItem"
        Me.EmaToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.EmaToolStripMenuItem.Text = "Email This Customer"
        '
        'SendALetterToolStripMenuItem
        '
        Me.SendALetterToolStripMenuItem.Image = CType(resources.GetObject("SendALetterToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SendALetterToolStripMenuItem.Name = "SendALetterToolStripMenuItem"
        Me.SendALetterToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.SendALetterToolStripMenuItem.Text = "Send a Letter"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(204, 6)
        '
        'SetAppointmentToolStripMenuItem
        '
        Me.SetAppointmentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetAppointmentToolStripMenuItem1, Me.MoveAppointmentToolStripMenuItem})
        Me.SetAppointmentToolStripMenuItem.Image = CType(resources.GetObject("SetAppointmentToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SetAppointmentToolStripMenuItem.Name = "SetAppointmentToolStripMenuItem"
        Me.SetAppointmentToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.SetAppointmentToolStripMenuItem.Text = "Appointment"
        '
        'SetAppointmentToolStripMenuItem1
        '
        Me.SetAppointmentToolStripMenuItem1.Image = Global.Latest.My.Resources.Resources.tranfer1
        Me.SetAppointmentToolStripMenuItem1.Name = "SetAppointmentToolStripMenuItem1"
        Me.SetAppointmentToolStripMenuItem1.Size = New System.Drawing.Size(178, 22)
        Me.SetAppointmentToolStripMenuItem1.Text = "Set Appointment"
        '
        'MoveAppointmentToolStripMenuItem
        '
        Me.MoveAppointmentToolStripMenuItem.Image = Global.Latest.My.Resources.Resources.arrow_right
        Me.MoveAppointmentToolStripMenuItem.Name = "MoveAppointmentToolStripMenuItem"
        Me.MoveAppointmentToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.MoveAppointmentToolStripMenuItem.Text = "Move Appointment"
        '
        'AssignChangeSalesRepToolStripMenuItem
        '
        Me.AssignChangeSalesRepToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripComboBox1, Me.ToolStripComboBox2, Me.ToolStripSeparator5, Me.SaveChangesToolStripMenuItem})
        Me.AssignChangeSalesRepToolStripMenuItem.Name = "AssignChangeSalesRepToolStripMenuItem"
        Me.AssignChangeSalesRepToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.AssignChangeSalesRepToolStripMenuItem.Text = "Assign/Change Sales Rep"
        '
        'ToolStripComboBox1
        '
        Me.ToolStripComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
        Me.ToolStripComboBox1.Size = New System.Drawing.Size(150, 23)
        '
        'ToolStripComboBox2
        '
        Me.ToolStripComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.ToolStripComboBox2.Name = "ToolStripComboBox2"
        Me.ToolStripComboBox2.Size = New System.Drawing.Size(150, 23)
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(207, 6)
        '
        'SaveChangesToolStripMenuItem
        '
        Me.SaveChangesToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveChangesToolStripMenuItem.Name = "SaveChangesToolStripMenuItem"
        Me.SaveChangesToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.SaveChangesToolStripMenuItem.Text = "Save Changes"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintAppointmentSheetToolStripMenuItem, Me.PrintCustomerInformationSheetToolStripMenuItem})
        Me.PrintToolStripMenuItem.Image = CType(resources.GetObject("PrintToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'PrintAppointmentSheetToolStripMenuItem
        '
        Me.PrintAppointmentSheetToolStripMenuItem.Name = "PrintAppointmentSheetToolStripMenuItem"
        Me.PrintAppointmentSheetToolStripMenuItem.Size = New System.Drawing.Size(252, 22)
        Me.PrintAppointmentSheetToolStripMenuItem.Text = "Print Appointment Sheet"
        '
        'PrintCustomerInformationSheetToolStripMenuItem
        '
        Me.PrintCustomerInformationSheetToolStripMenuItem.Name = "PrintCustomerInformationSheetToolStripMenuItem"
        Me.PrintCustomerInformationSheetToolStripMenuItem.Size = New System.Drawing.Size(252, 22)
        Me.PrintCustomerInformationSheetToolStripMenuItem.Text = "Print Customer Information Sheet"
        '
        'lblConfimingPLS
        '
        Me.lblConfimingPLS.AutoSize = True
        Me.lblConfimingPLS.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblConfimingPLS.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfimingPLS.ForeColor = System.Drawing.Color.Black
        Me.lblConfimingPLS.Location = New System.Drawing.Point(12, 3)
        Me.lblConfimingPLS.Name = "lblConfimingPLS"
        Me.lblConfimingPLS.Size = New System.Drawing.Size(76, 13)
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
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
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
        Me.lvMemorized.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lvMemorized.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvMemorized.FullRowSelect = True
        Me.lvMemorized.HideSelection = False
        Me.lvMemorized.LabelEdit = True
        Me.lvMemorized.Location = New System.Drawing.Point(0, 104)
        Me.lvMemorized.MultiSelect = False
        Me.lvMemorized.Name = "lvMemorized"
        Me.lvMemorized.Size = New System.Drawing.Size(207, 431)
        Me.lvMemorized.SmallImageList = Me.ilCustomerHistory
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
        'ilToolbarButtons
        '
        Me.ilToolbarButtons.ImageStream = CType(resources.GetObject("ilToolbarButtons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilToolbarButtons.TransparentColor = System.Drawing.Color.Transparent
        Me.ilToolbarButtons.Images.SetKeyName(0, "cash2.ico")
        Me.ilToolbarButtons.Images.SetKeyName(1, "user-16.png")
        Me.ilToolbarButtons.Images.SetKeyName(2, "done2.ico")
        Me.ilToolbarButtons.Images.SetKeyName(3, "print.ico")
        Me.ilToolbarButtons.Images.SetKeyName(4, "reminder.ico")
        Me.ilToolbarButtons.Images.SetKeyName(5, "C&C24.ico")
        Me.ilToolbarButtons.Images.SetKeyName(6, "transfer6.ico")
        Me.ilToolbarButtons.Images.SetKeyName(7, "wordicon_200.ico")
        Me.ilToolbarButtons.Images.SetKeyName(8, "tranfer.ico")
        Me.ilToolbarButtons.Images.SetKeyName(9, "notes2.ico")
        Me.ilToolbarButtons.Images.SetKeyName(10, "Cancel.ico")
        Me.ilToolbarButtons.Images.SetKeyName(11, "Call&Cancel48.ico")
        Me.ilToolbarButtons.Images.SetKeyName(12, "lightoff16x16 copy.ico")
        Me.ilToolbarButtons.Images.SetKeyName(13, "greenlighton16x16 copy.ico")
        Me.ilToolbarButtons.Images.SetKeyName(14, "arrow-right.ico")
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
        Me.gbContactInfo.Size = New System.Drawing.Size(699, 198)
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
        Me.txtHousePhone.Location = New System.Drawing.Point(491, 33)
        Me.txtHousePhone.Name = "txtHousePhone"
        Me.txtHousePhone.ReadOnly = True
        Me.txtHousePhone.Size = New System.Drawing.Size(116, 16)
        Me.txtHousePhone.TabIndex = 141
        '
        'txtaltphone2
        '
        Me.txtaltphone2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtaltphone2.BackColor = System.Drawing.Color.White
        Me.txtaltphone2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtaltphone2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaltphone2.ForeColor = System.Drawing.Color.Black
        Me.txtaltphone2.Location = New System.Drawing.Point(491, 96)
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
        Me.txtaltphone1.Location = New System.Drawing.Point(491, 64)
        Me.txtaltphone1.Name = "txtaltphone1"
        Me.txtaltphone1.ReadOnly = True
        Me.txtaltphone1.Size = New System.Drawing.Size(116, 16)
        Me.txtaltphone1.TabIndex = 139
        '
        'lnkEmail
        '
        Me.lnkEmail.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lnkEmail.AutoSize = True
        Me.lnkEmail.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkEmail.Location = New System.Drawing.Point(438, 144)
        Me.lnkEmail.Name = "lnkEmail"
        Me.lnkEmail.Size = New System.Drawing.Size(0, 16)
        Me.lnkEmail.TabIndex = 136
        '
        'lblEmail
        '
        Me.lblEmail.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.Gray
        Me.lblEmail.Location = New System.Drawing.Point(387, 144)
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
        Me.txtAlt1Type.Location = New System.Drawing.Point(623, 64)
        Me.txtAlt1Type.Name = "txtAlt1Type"
        Me.txtAlt1Type.ReadOnly = True
        Me.txtAlt1Type.Size = New System.Drawing.Size(57, 16)
        Me.txtAlt1Type.TabIndex = 126
        '
        'txtAlt2Type
        '
        Me.txtAlt2Type.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAlt2Type.BackColor = System.Drawing.Color.White
        Me.txtAlt2Type.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAlt2Type.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlt2Type.ForeColor = System.Drawing.Color.Black
        Me.txtAlt2Type.Location = New System.Drawing.Point(623, 96)
        Me.txtAlt2Type.Name = "txtAlt2Type"
        Me.txtAlt2Type.ReadOnly = True
        Me.txtAlt2Type.Size = New System.Drawing.Size(57, 16)
        Me.txtAlt2Type.TabIndex = 125
        '
        'lblAltPhone2
        '
        Me.lblAltPhone2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAltPhone2.AutoSize = True
        Me.lblAltPhone2.BackColor = System.Drawing.Color.Transparent
        Me.lblAltPhone2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAltPhone2.ForeColor = System.Drawing.Color.Gray
        Me.lblAltPhone2.Location = New System.Drawing.Point(387, 96)
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
        Me.lblAltPhone1.Location = New System.Drawing.Point(387, 64)
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
        Me.lblHousePhone.Location = New System.Drawing.Point(387, 33)
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
        Me.gbHomeInfo.Location = New System.Drawing.Point(710, 3)
        Me.gbHomeInfo.Name = "gbHomeInfo"
        Me.gbHomeInfo.Size = New System.Drawing.Size(138, 198)
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
        Me.txtHomeValue.Location = New System.Drawing.Point(26, 152)
        Me.txtHomeValue.Name = "txtHomeValue"
        Me.txtHomeValue.ReadOnly = True
        Me.txtHomeValue.Size = New System.Drawing.Size(91, 16)
        Me.txtHomeValue.TabIndex = 35
        Me.txtHomeValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtYrsOwned
        '
        Me.txtYrsOwned.BackColor = System.Drawing.Color.White
        Me.txtYrsOwned.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtYrsOwned.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYrsOwned.ForeColor = System.Drawing.Color.Black
        Me.txtYrsOwned.Location = New System.Drawing.Point(24, 102)
        Me.txtYrsOwned.Name = "txtYrsOwned"
        Me.txtYrsOwned.ReadOnly = True
        Me.txtYrsOwned.Size = New System.Drawing.Size(91, 16)
        Me.txtYrsOwned.TabIndex = 34
        Me.txtYrsOwned.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblYrBuilt
        '
        Me.lblYrBuilt.AutoSize = True
        Me.lblYrBuilt.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYrBuilt.ForeColor = System.Drawing.Color.Gray
        Me.lblYrBuilt.Location = New System.Drawing.Point(21, 33)
        Me.lblYrBuilt.Name = "lblYrBuilt"
        Me.lblYrBuilt.Size = New System.Drawing.Size(97, 16)
        Me.lblYrBuilt.TabIndex = 28
        Me.lblYrBuilt.Text = "Age Of Home:"
        '
        'lblYrsOwned
        '
        Me.lblYrsOwned.AutoSize = True
        Me.lblYrsOwned.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYrsOwned.ForeColor = System.Drawing.Color.Gray
        Me.lblYrsOwned.Location = New System.Drawing.Point(20, 83)
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
        Me.lblHomeValue.Location = New System.Drawing.Point(27, 133)
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
        Me.txtYrBuilt.Location = New System.Drawing.Point(22, 52)
        Me.txtYrBuilt.Name = "txtYrBuilt"
        Me.txtYrBuilt.ReadOnly = True
        Me.txtYrBuilt.Size = New System.Drawing.Size(91, 16)
        Me.txtYrBuilt.TabIndex = 29
        Me.txtYrBuilt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gbSpecialInstructions
        '
        Me.gbSpecialInstructions.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbSpecialInstructions.BackColor = System.Drawing.Color.White
        Me.gbSpecialInstructions.Controls.Add(Me.btnUpdateSPI)
        Me.gbSpecialInstructions.Controls.Add(Me.rtbSpecialInstructions)
        Me.gbSpecialInstructions.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSpecialInstructions.ForeColor = System.Drawing.Color.Gray
        Me.gbSpecialInstructions.Location = New System.Drawing.Point(445, 207)
        Me.gbSpecialInstructions.Name = "gbSpecialInstructions"
        Me.gbSpecialInstructions.Size = New System.Drawing.Size(403, 144)
        Me.gbSpecialInstructions.TabIndex = 188
        Me.gbSpecialInstructions.TabStop = False
        Me.gbSpecialInstructions.Text = "Special Instructions:"
        '
        'btnUpdateSPI
        '
        Me.btnUpdateSPI.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdateSPI.Location = New System.Drawing.Point(343, 114)
        Me.btnUpdateSPI.Name = "btnUpdateSPI"
        Me.btnUpdateSPI.Size = New System.Drawing.Size(54, 22)
        Me.btnUpdateSPI.TabIndex = 147
        Me.btnUpdateSPI.Text = "Edit"
        Me.btnUpdateSPI.UseVisualStyleBackColor = True
        '
        'rtbSpecialInstructions
        '
        Me.rtbSpecialInstructions.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbSpecialInstructions.BackColor = System.Drawing.SystemColors.Window
        Me.rtbSpecialInstructions.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbSpecialInstructions.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbSpecialInstructions.Location = New System.Drawing.Point(6, 22)
        Me.rtbSpecialInstructions.Name = "rtbSpecialInstructions"
        Me.rtbSpecialInstructions.ReadOnly = True
        Me.rtbSpecialInstructions.Size = New System.Drawing.Size(391, 116)
        Me.rtbSpecialInstructions.TabIndex = 146
        Me.rtbSpecialInstructions.Text = ""
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
        Me.tsCustomerLog.Size = New System.Drawing.Size(856, 33)
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
        Me.tslblShowDepartment.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tslblShowDepartment.Margin = New System.Windows.Forms.Padding(10, 1, 0, 2)
        Me.tslblShowDepartment.Name = "tslblShowDepartment"
        Me.tslblShowDepartment.Size = New System.Drawing.Size(44, 30)
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
        Me.btnLogCall.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCandC})
        Me.btnLogCall.Image = CType(resources.GetObject("btnLogCall.Image"), System.Drawing.Image)
        Me.btnLogCall.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnLogCall.Name = "btnLogCall"
        Me.btnLogCall.Size = New System.Drawing.Size(272, 30)
        Me.btnLogCall.Text = "Log Phone Conversation with this Customer"
        '
        'btnCandC
        '
        Me.btnCandC.Image = Global.Latest.My.Resources.Resources.calledcancelled
        Me.btnCandC.Name = "btnCandC"
        Me.btnCandC.Size = New System.Drawing.Size(254, 22)
        Me.btnCandC.Text = "Log Appt. as Called and Cancelled"
        '
        'tslblCustomerHistory
        '
        Me.tslblCustomerHistory.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tslblCustomerHistory.Margin = New System.Windows.Forms.Padding(40, 1, 0, 2)
        Me.tslblCustomerHistory.Name = "tslblCustomerHistory"
        Me.tslblCustomerHistory.Size = New System.Drawing.Size(150, 30)
        Me.tslblCustomerHistory.Text = "Customer History"
        '
        'pnlAFPics
        '
        Me.pnlAFPics.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlAFPics.AutoScroll = True
        Me.pnlAFPics.Controls.Add(Me.lsAttachedFiles)
        Me.pnlAFPics.Controls.Add(Me.lsJobPictures)
        Me.pnlAFPics.Location = New System.Drawing.Point(4, 390)
        Me.pnlAFPics.Name = "pnlAFPics"
        Me.pnlAFPics.Size = New System.Drawing.Size(855, 172)
        Me.pnlAFPics.TabIndex = 201
        Me.pnlAFPics.Visible = False
        '
        'lsAttachedFiles
        '
        Me.lsAttachedFiles.AllowDrop = True
        Me.lsAttachedFiles.BackColor = System.Drawing.SystemColors.Window
        Me.lsAttachedFiles.ContextMenuStrip = Me.cmAF
        Me.lsAttachedFiles.LabelEdit = True
        Me.lsAttachedFiles.Location = New System.Drawing.Point(8, 8)
        Me.lsAttachedFiles.Name = "lsAttachedFiles"
        Me.lsAttachedFiles.Size = New System.Drawing.Size(415, 159)
        Me.lsAttachedFiles.TabIndex = 0
        Me.lsAttachedFiles.UseCompatibleStateImageBehavior = False
        '
        'cmAF
        '
        Me.cmAF.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnOpen, Me.ToolStripSeparator6, Me.btnSendtoDesktop, Me.ToolStripSeparator7, Me.btnCut, Me.btnCopy, Me.ToolStripSeparator8, Me.btnCreateSC, Me.btnDelete, Me.btnRename, Me.btnView, Me.btnSortby, Me.btnRefresh, Me.ToolStripSeparator11, Me.btnPaste, Me.ToolStripSeparator12, Me.btnNewFolder})
        Me.cmAF.Name = "cmsAF"
        Me.cmAF.Size = New System.Drawing.Size(161, 298)
        '
        'btnOpen
        '
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(160, 22)
        Me.btnOpen.Text = "Open"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(157, 6)
        '
        'btnSendtoDesktop
        '
        Me.btnSendtoDesktop.Name = "btnSendtoDesktop"
        Me.btnSendtoDesktop.Size = New System.Drawing.Size(160, 22)
        Me.btnSendtoDesktop.Text = "Send to Desktop"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(157, 6)
        '
        'btnCut
        '
        Me.btnCut.Name = "btnCut"
        Me.btnCut.Size = New System.Drawing.Size(160, 22)
        Me.btnCut.Text = "Cut"
        '
        'btnCopy
        '
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(160, 22)
        Me.btnCopy.Text = "Copy"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(157, 6)
        '
        'btnCreateSC
        '
        Me.btnCreateSC.Name = "btnCreateSC"
        Me.btnCreateSC.Size = New System.Drawing.Size(160, 22)
        Me.btnCreateSC.Text = "Create Shortcut"
        '
        'btnDelete
        '
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(160, 22)
        Me.btnDelete.Text = "Delete"
        '
        'btnRename
        '
        Me.btnRename.Name = "btnRename"
        Me.btnRename.Size = New System.Drawing.Size(160, 22)
        Me.btnRename.Text = "Rename"
        '
        'btnView
        '
        Me.btnView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnXLarge, Me.btnLarge, Me.btnMedium, Me.btnSmall, Me.ToolStripSeparator9, Me.btnList, Me.btnDetails, Me.btnTiles})
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(160, 22)
        Me.btnView.Text = "View"
        '
        'btnXLarge
        '
        Me.btnXLarge.Name = "btnXLarge"
        Me.btnXLarge.Size = New System.Drawing.Size(162, 22)
        Me.btnXLarge.Text = "Extra Large Icons"
        '
        'btnLarge
        '
        Me.btnLarge.Name = "btnLarge"
        Me.btnLarge.Size = New System.Drawing.Size(162, 22)
        Me.btnLarge.Text = "Large Icons"
        '
        'btnMedium
        '
        Me.btnMedium.Name = "btnMedium"
        Me.btnMedium.Size = New System.Drawing.Size(162, 22)
        Me.btnMedium.Text = "Medium Icons"
        '
        'btnSmall
        '
        Me.btnSmall.Name = "btnSmall"
        Me.btnSmall.Size = New System.Drawing.Size(162, 22)
        Me.btnSmall.Text = "Small Icons"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(159, 6)
        '
        'btnList
        '
        Me.btnList.Name = "btnList"
        Me.btnList.Size = New System.Drawing.Size(162, 22)
        Me.btnList.Text = "List"
        '
        'btnDetails
        '
        Me.btnDetails.Name = "btnDetails"
        Me.btnDetails.Size = New System.Drawing.Size(162, 22)
        Me.btnDetails.Text = "Details"
        '
        'btnTiles
        '
        Me.btnTiles.Name = "btnTiles"
        Me.btnTiles.Size = New System.Drawing.Size(162, 22)
        Me.btnTiles.Text = "Tiles"
        '
        'btnSortby
        '
        Me.btnSortby.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAscending, Me.btnDescending})
        Me.btnSortby.Name = "btnSortby"
        Me.btnSortby.Size = New System.Drawing.Size(160, 22)
        Me.btnSortby.Text = "Sort By"
        '
        'btnAscending
        '
        Me.btnAscending.Checked = True
        Me.btnAscending.CheckState = System.Windows.Forms.CheckState.Checked
        Me.btnAscending.Name = "btnAscending"
        Me.btnAscending.Size = New System.Drawing.Size(136, 22)
        Me.btnAscending.Text = "Ascending"
        '
        'btnDescending
        '
        Me.btnDescending.Name = "btnDescending"
        Me.btnDescending.Size = New System.Drawing.Size(136, 22)
        Me.btnDescending.Text = "Descending"
        '
        'btnRefresh
        '
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(160, 22)
        Me.btnRefresh.Text = "Refresh"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(157, 6)
        '
        'btnPaste
        '
        Me.btnPaste.Enabled = False
        Me.btnPaste.Name = "btnPaste"
        Me.btnPaste.Size = New System.Drawing.Size(160, 22)
        Me.btnPaste.Text = "Paste"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(157, 6)
        '
        'btnNewFolder
        '
        Me.btnNewFolder.Name = "btnNewFolder"
        Me.btnNewFolder.Size = New System.Drawing.Size(160, 22)
        Me.btnNewFolder.Text = "New Folder"
        '
        'lsJobPictures
        '
        Me.lsJobPictures.BackColor = System.Drawing.SystemColors.Window
        Me.lsJobPictures.ContextMenuStrip = Me.cmJP
        Me.lsJobPictures.LabelEdit = True
        Me.lsJobPictures.Location = New System.Drawing.Point(435, 8)
        Me.lsJobPictures.Name = "lsJobPictures"
        Me.lsJobPictures.Size = New System.Drawing.Size(411, 159)
        Me.lsJobPictures.TabIndex = 1
        Me.lsJobPictures.UseCompatibleStateImageBehavior = False
        '
        'cmJP
        '
        Me.cmJP.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripSeparator13, Me.btnSendtoDesktopJP, Me.ToolStripSeparator14, Me.btnCutJP, Me.btnCopyJP, Me.ToolStripSeparator15, Me.btnCreateSCJP, Me.btnDeleteJP, Me.btnRenameJP, Me.btnJPViews, Me.ToolStripMenuItem17, Me.btnRefreshJP, Me.ToolStripSeparator18, Me.btnPasteJP, Me.ToolStripSeparator19, Me.btnNewFolderJP})
        Me.cmJP.Name = "cmsAF"
        Me.cmJP.Size = New System.Drawing.Size(161, 298)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(160, 22)
        Me.ToolStripMenuItem1.Text = "Open"
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(157, 6)
        '
        'btnSendtoDesktopJP
        '
        Me.btnSendtoDesktopJP.Name = "btnSendtoDesktopJP"
        Me.btnSendtoDesktopJP.Size = New System.Drawing.Size(160, 22)
        Me.btnSendtoDesktopJP.Text = "Send to Desktop"
        '
        'ToolStripSeparator14
        '
        Me.ToolStripSeparator14.Name = "ToolStripSeparator14"
        Me.ToolStripSeparator14.Size = New System.Drawing.Size(157, 6)
        '
        'btnCutJP
        '
        Me.btnCutJP.Name = "btnCutJP"
        Me.btnCutJP.Size = New System.Drawing.Size(160, 22)
        Me.btnCutJP.Text = "Cut"
        '
        'btnCopyJP
        '
        Me.btnCopyJP.Name = "btnCopyJP"
        Me.btnCopyJP.Size = New System.Drawing.Size(160, 22)
        Me.btnCopyJP.Text = "Copy"
        '
        'ToolStripSeparator15
        '
        Me.ToolStripSeparator15.Name = "ToolStripSeparator15"
        Me.ToolStripSeparator15.Size = New System.Drawing.Size(157, 6)
        '
        'btnCreateSCJP
        '
        Me.btnCreateSCJP.Name = "btnCreateSCJP"
        Me.btnCreateSCJP.Size = New System.Drawing.Size(160, 22)
        Me.btnCreateSCJP.Text = "Create Shortcut"
        '
        'btnDeleteJP
        '
        Me.btnDeleteJP.Name = "btnDeleteJP"
        Me.btnDeleteJP.Size = New System.Drawing.Size(160, 22)
        Me.btnDeleteJP.Text = "Delete"
        '
        'btnRenameJP
        '
        Me.btnRenameJP.Name = "btnRenameJP"
        Me.btnRenameJP.Size = New System.Drawing.Size(160, 22)
        Me.btnRenameJP.Text = "Rename"
        '
        'btnJPViews
        '
        Me.btnJPViews.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmJPExtraLarge, Me.cmJPLarge, Me.cmJPMedium, Me.cmJPSmall, Me.ToolStripSeparator16, Me.cmJPList, Me.cmJPDetails, Me.cmJPTiles})
        Me.btnJPViews.Name = "btnJPViews"
        Me.btnJPViews.Size = New System.Drawing.Size(160, 22)
        Me.btnJPViews.Text = "View"
        '
        'cmJPExtraLarge
        '
        Me.cmJPExtraLarge.Name = "cmJPExtraLarge"
        Me.cmJPExtraLarge.Size = New System.Drawing.Size(162, 22)
        Me.cmJPExtraLarge.Text = "Extra Large Icons"
        '
        'cmJPLarge
        '
        Me.cmJPLarge.Name = "cmJPLarge"
        Me.cmJPLarge.Size = New System.Drawing.Size(162, 22)
        Me.cmJPLarge.Text = "Large Icons"
        '
        'cmJPMedium
        '
        Me.cmJPMedium.Name = "cmJPMedium"
        Me.cmJPMedium.Size = New System.Drawing.Size(162, 22)
        Me.cmJPMedium.Text = "Medium Icons"
        '
        'cmJPSmall
        '
        Me.cmJPSmall.Name = "cmJPSmall"
        Me.cmJPSmall.Size = New System.Drawing.Size(162, 22)
        Me.cmJPSmall.Text = "Small Icons"
        '
        'ToolStripSeparator16
        '
        Me.ToolStripSeparator16.Name = "ToolStripSeparator16"
        Me.ToolStripSeparator16.Size = New System.Drawing.Size(159, 6)
        '
        'cmJPList
        '
        Me.cmJPList.Name = "cmJPList"
        Me.cmJPList.Size = New System.Drawing.Size(162, 22)
        Me.cmJPList.Text = "List"
        '
        'cmJPDetails
        '
        Me.cmJPDetails.Name = "cmJPDetails"
        Me.cmJPDetails.Size = New System.Drawing.Size(162, 22)
        Me.cmJPDetails.Text = "Details"
        '
        'cmJPTiles
        '
        Me.cmJPTiles.Name = "cmJPTiles"
        Me.cmJPTiles.Size = New System.Drawing.Size(162, 22)
        Me.cmJPTiles.Text = "Tiles"
        '
        'ToolStripMenuItem17
        '
        Me.ToolStripMenuItem17.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAscendingJP, Me.btnDescJP})
        Me.ToolStripMenuItem17.Name = "ToolStripMenuItem17"
        Me.ToolStripMenuItem17.Size = New System.Drawing.Size(160, 22)
        Me.ToolStripMenuItem17.Text = "Sort By"
        '
        'btnAscendingJP
        '
        Me.btnAscendingJP.Checked = True
        Me.btnAscendingJP.CheckState = System.Windows.Forms.CheckState.Checked
        Me.btnAscendingJP.Name = "btnAscendingJP"
        Me.btnAscendingJP.Size = New System.Drawing.Size(136, 22)
        Me.btnAscendingJP.Text = "Ascending"
        '
        'btnDescJP
        '
        Me.btnDescJP.Name = "btnDescJP"
        Me.btnDescJP.Size = New System.Drawing.Size(136, 22)
        Me.btnDescJP.Text = "Descending"
        '
        'btnRefreshJP
        '
        Me.btnRefreshJP.Name = "btnRefreshJP"
        Me.btnRefreshJP.Size = New System.Drawing.Size(160, 22)
        Me.btnRefreshJP.Text = "Refresh"
        '
        'ToolStripSeparator18
        '
        Me.ToolStripSeparator18.Name = "ToolStripSeparator18"
        Me.ToolStripSeparator18.Size = New System.Drawing.Size(157, 6)
        '
        'btnPasteJP
        '
        Me.btnPasteJP.Name = "btnPasteJP"
        Me.btnPasteJP.Size = New System.Drawing.Size(160, 22)
        Me.btnPasteJP.Text = "Paste"
        '
        'ToolStripSeparator19
        '
        Me.ToolStripSeparator19.Name = "ToolStripSeparator19"
        Me.ToolStripSeparator19.Size = New System.Drawing.Size(157, 6)
        '
        'btnNewFolderJP
        '
        Me.btnNewFolderJP.Name = "btnNewFolderJP"
        Me.btnNewFolderJP.Size = New System.Drawing.Size(160, 22)
        Me.btnNewFolderJP.Text = "New Folder"
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
        Me.tsAFPics.Size = New System.Drawing.Size(856, 33)
        Me.tsAFPics.TabIndex = 201
        Me.tsAFPics.Text = "ToolStrip1"
        '
        'tscboAFPicsFilter
        '
        Me.tscboAFPicsFilter.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tscboAFPicsFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tscboAFPicsFilter.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.tscboAFPicsFilter.Items.AddRange(New Object() {"All", "Attached Files", "Job Pictures"})
        Me.tscboAFPicsFilter.Margin = New System.Windows.Forms.Padding(1, 0, 10, 0)
        Me.tscboAFPicsFilter.Name = "tscboAFPicsFilter"
        Me.tscboAFPicsFilter.Size = New System.Drawing.Size(160, 33)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Margin = New System.Windows.Forms.Padding(10, 1, 0, 2)
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(44, 30)
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
        Me.tslblAFPic.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tslblAFPic.Margin = New System.Windows.Forms.Padding(5, 1, 0, 2)
        Me.tslblAFPic.Name = "tslblAFPic"
        Me.tslblAFPic.Size = New System.Drawing.Size(283, 30)
        Me.tslblAFPic.Text = "Attached Files and Job Pictures..."
        '
        'pnlCustomerHistory
        '
        Me.pnlCustomerHistory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCustomerHistory.AutoScroll = True
        Me.pnlCustomerHistory.Location = New System.Drawing.Point(4, 390)
        Me.pnlCustomerHistory.Name = "pnlCustomerHistory"
        Me.pnlCustomerHistory.Size = New System.Drawing.Size(852, 172)
        Me.pnlCustomerHistory.TabIndex = 200
        '
        'tpIssueLeads
        '
        Me.tpIssueLeads.AutoScrollMargin = New System.Drawing.Size(20, 0)
        Me.tpIssueLeads.Controls.Add(Me.pnlIssue)
        Me.tpIssueLeads.Controls.Add(Me.Panel1)
        Me.tpIssueLeads.ImageKey = "Issue Leads.png"
        Me.tpIssueLeads.Location = New System.Drawing.Point(30, 4)
        Me.tpIssueLeads.Name = "tpIssueLeads"
        Me.tpIssueLeads.Padding = New System.Windows.Forms.Padding(3)
        Me.tpIssueLeads.Size = New System.Drawing.Size(1081, 568)
        Me.tpIssueLeads.TabIndex = 2
        Me.tpIssueLeads.UseVisualStyleBackColor = True
        '
        'pnlIssue
        '
        Me.pnlIssue.AutoScroll = True
        Me.pnlIssue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlIssue.Location = New System.Drawing.Point(3, 51)
        Me.pnlIssue.Name = "pnlIssue"
        Me.pnlIssue.Size = New System.Drawing.Size(1075, 514)
        Me.pnlIssue.TabIndex = 0
        Me.pnlIssue.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1075, 48)
        Me.Panel1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(630, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "There are no Appointments to Issue for Monday, 12/26/14"
        '
        'tpReferences
        '
        Me.tpReferences.ImageKey = "References.png"
        Me.tpReferences.Location = New System.Drawing.Point(30, 4)
        Me.tpReferences.Name = "tpReferences"
        Me.tpReferences.Padding = New System.Windows.Forms.Padding(3)
        Me.tpReferences.Size = New System.Drawing.Size(1081, 568)
        Me.tpReferences.TabIndex = 3
        Me.tpReferences.UseVisualStyleBackColor = True
        '
        'tpReports
        '
        Me.tpReports.ImageKey = "Reports.png"
        Me.tpReports.Location = New System.Drawing.Point(30, 4)
        Me.tpReports.Name = "tpReports"
        Me.tpReports.Padding = New System.Windows.Forms.Padding(3)
        Me.tpReports.Size = New System.Drawing.Size(1081, 568)
        Me.tpReports.TabIndex = 4
        Me.tpReports.UseVisualStyleBackColor = True
        '
        'ilTabLabels
        '
        Me.ilTabLabels.ImageStream = CType(resources.GetObject("ilTabLabels.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilTabLabels.TransparentColor = System.Drawing.Color.Transparent
        Me.ilTabLabels.Images.SetKeyName(0, "Customer List.png")
        Me.ilTabLabels.Images.SetKeyName(1, "Customer List- Selected.png")
        Me.ilTabLabels.Images.SetKeyName(2, "Issue Leads.png")
        Me.ilTabLabels.Images.SetKeyName(3, "Issue Leads- Selected.png")
        Me.ilTabLabels.Images.SetKeyName(4, "References.png")
        Me.ilTabLabels.Images.SetKeyName(5, "References- Selected.png")
        Me.ilTabLabels.Images.SetKeyName(6, "Reports.png")
        Me.ilTabLabels.Images.SetKeyName(7, "Reports- Selected.png")
        Me.ilTabLabels.Images.SetKeyName(8, "Summary.png")
        Me.ilTabLabels.Images.SetKeyName(9, "Summary- Selected.png")
        '
        'CallHousePhone4194724000ToolStripMenuItem
        '
        Me.CallHousePhone4194724000ToolStripMenuItem.Name = "CallHousePhone4194724000ToolStripMenuItem"
        Me.CallHousePhone4194724000ToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.CallHousePhone4194724000ToolStripMenuItem.Text = "Call House Phone - (419) 4724000"
        '
        'ToThisCustomerToolStripMenuItem
        '
        Me.ToThisCustomerToolStripMenuItem.Name = "ToThisCustomerToolStripMenuItem"
        Me.ToThisCustomerToolStripMenuItem.Size = New System.Drawing.Size(286, 22)
        Me.ToThisCustomerToolStripMenuItem.Text = "To This Customer"
        '
        'ExportListToLetterWizardToolStripMenuItem
        '
        Me.ExportListToLetterWizardToolStripMenuItem.Name = "ExportListToLetterWizardToolStripMenuItem"
        Me.ExportListToLetterWizardToolStripMenuItem.Size = New System.Drawing.Size(286, 22)
        Me.ExportListToLetterWizardToolStripMenuItem.Text = "Export List to Letter Wizard"
        '
        'GoToLetterWizardToolStripMenuItem
        '
        Me.GoToLetterWizardToolStripMenuItem.Name = "GoToLetterWizardToolStripMenuItem"
        Me.GoToLetterWizardToolStripMenuItem.Size = New System.Drawing.Size(286, 22)
        Me.GoToLetterWizardToolStripMenuItem.Text = "Go to Letter Wizard and Create List There"
        '
        'ImgLst256
        '
        Me.ImgLst256.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImgLst256.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImgLst256.TransparentColor = System.Drawing.Color.Transparent
        '
        'ImgLst128
        '
        Me.ImgLst128.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImgLst128.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImgLst128.TransparentColor = System.Drawing.Color.Transparent
        '
        'ImgLst48
        '
        Me.ImgLst48.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImgLst48.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImgLst48.TransparentColor = System.Drawing.Color.Transparent
        '
        'ImgLst32
        '
        Me.ImgLst32.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImgLst32.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImgLst32.TransparentColor = System.Drawing.Color.Transparent
        '
        'imgLst16
        '
        Me.imgLst16.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.imgLst16.ImageSize = New System.Drawing.Size(16, 16)
        Me.imgLst16.TransparentColor = System.Drawing.Color.Transparent
        '
        'ImgIssued
        '
        Me.ImgIssued.ImageStream = CType(resources.GetObject("ImgIssued.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImgIssued.TransparentColor = System.Drawing.Color.Transparent
        Me.ImgIssued.Images.SetKeyName(0, "recoveryIcon.ico")
        Me.ImgIssued.Images.SetKeyName(1, "cash sale.ico")
        Me.ImgIssued.Images.SetKeyName(2, "excalmation24.ico")
        Me.ImgIssued.Images.SetKeyName(3, "new record24.ico")
        Me.ImgIssued.Images.SetKeyName(4, "SpecialInstructions24.ico")
        Me.ImgIssued.Images.SetKeyName(5, "0176.ico")
        Me.ImgIssued.Images.SetKeyName(6, "notesnew.ico")
        Me.ImgIssued.Images.SetKeyName(7, "0176minus.ico")
        '
        'ImgIssued2
        '
        Me.ImgIssued2.ImageStream = CType(resources.GetObject("ImgIssued2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImgIssued2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImgIssued2.Images.SetKeyName(0, "recoveryIcon.ico")
        Me.ImgIssued2.Images.SetKeyName(1, "cash sale.ico")
        Me.ImgIssued2.Images.SetKeyName(2, "excalmation24.ico")
        Me.ImgIssued2.Images.SetKeyName(3, "new record24.ico")
        Me.ImgIssued2.Images.SetKeyName(4, "SpecialInstructions24.ico")
        Me.ImgIssued2.Images.SetKeyName(5, "0176.ico")
        Me.ImgIssued2.Images.SetKeyName(6, "notesnew.ico")
        '
        'ImgIssued3
        '
        Me.ImgIssued3.ImageStream = CType(resources.GetObject("ImgIssued3.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImgIssued3.TransparentColor = System.Drawing.Color.Transparent
        Me.ImgIssued3.Images.SetKeyName(0, "recoveryused.ico")
        Me.ImgIssued3.Images.SetKeyName(1, "cash sale.ico")
        Me.ImgIssued3.Images.SetKeyName(2, "0135.ico")
        Me.ImgIssued3.Images.SetKeyName(3, "new record32.ico")
        Me.ImgIssued3.Images.SetKeyName(4, "Clipboard.ico")
        Me.ImgIssued3.Images.SetKeyName(5, "0176.ico")
        Me.ImgIssued3.Images.SetKeyName(6, "NOTES1.ICO")
        Me.ImgIssued3.Images.SetKeyName(7, "Call&Cancel32.ico")
        Me.ImgIssued3.Images.SetKeyName(8, "Call&Cancel48.ico")
        '
        'cmIssue
        '
        Me.cmIssue.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintThisLeadToolStripMenuItem, Me.EmailThisLeadToAssignedRepsToolStripMenuItem})
        Me.cmIssue.Name = "cmIssue"
        Me.cmIssue.Size = New System.Drawing.Size(255, 48)
        '
        'PrintThisLeadToolStripMenuItem
        '
        Me.PrintThisLeadToolStripMenuItem.Image = Global.Latest.My.Resources.Resources.print_32
        Me.PrintThisLeadToolStripMenuItem.Name = "PrintThisLeadToolStripMenuItem"
        Me.PrintThisLeadToolStripMenuItem.Size = New System.Drawing.Size(254, 22)
        Me.PrintThisLeadToolStripMenuItem.Text = "Print this Lead"
        '
        'EmailThisLeadToAssignedRepsToolStripMenuItem
        '
        Me.EmailThisLeadToAssignedRepsToolStripMenuItem.Image = Global.Latest.My.Resources.Resources.transfer6
        Me.EmailThisLeadToAssignedRepsToolStripMenuItem.Name = "EmailThisLeadToAssignedRepsToolStripMenuItem"
        Me.EmailThisLeadToAssignedRepsToolStripMenuItem.Size = New System.Drawing.Size(254, 22)
        Me.EmailThisLeadToAssignedRepsToolStripMenuItem.Text = "Email this Lead to Assigned Rep(s)"
        '
        'bgGetImages
        '
        '
        'bgSalesQuery
        '
        '
        'bgCustomerHistory
        '
        '
        'tmrdtpCustList
        '
        Me.tmrdtpCustList.Interval = 3000
        '
        'tmrSum
        '
        Me.tmrSum.Interval = 3000
        '
        'Sales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1115, 601)
        Me.Controls.Add(Me.tbMain)
        Me.Controls.Add(Me.tsSalesDepartment)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Sales"
        Me.Text = " "
        Me.tbMain.ResumeLayout(False)
        Me.tpSummary.ResumeLayout(False)
        Me.tpSummary.PerformLayout()
        Me.pnlPerformanceReport.ResumeLayout(False)
        Me.pnlPerformanceReport.PerformLayout()
        Me.cmlvnoresults.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.tpCustomerList.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
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
        Me.pnlAFPics.ResumeLayout(False)
        Me.cmAF.ResumeLayout(False)
        Me.cmJP.ResumeLayout(False)
        Me.tsAFPics.ResumeLayout(False)
        Me.tsAFPics.PerformLayout()
        Me.tpIssueLeads.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.cmIssue.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsSalesDepartment As System.Windows.Forms.ToolStrip
    Friend WithEvents tbMain As System.Windows.Forms.TabControl
    Friend WithEvents tpSummary As System.Windows.Forms.TabPage
    Friend WithEvents tpCustomerList As System.Windows.Forms.TabPage
    Friend WithEvents tpIssueLeads As System.Windows.Forms.TabPage
    Friend WithEvents tpReferences As System.Windows.Forms.TabPage
    Friend WithEvents tpReports As System.Windows.Forms.TabPage
    Friend WithEvents ilTabLabels As System.Windows.Forms.ImageList
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
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
    Friend WithEvents tslblShowDepartment As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnLogCall As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents tslblCustomerHistory As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ilCustomerHistory As System.Windows.Forms.ImageList
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
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents pnlScheduledTasks As System.Windows.Forms.Panel
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents lvnoresults As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblAccuracy As System.Windows.Forms.Label
    Friend WithEvents pnlPerformanceReport As System.Windows.Forms.Panel
    Friend WithEvents lblNoData As System.Windows.Forms.Label
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents lblDisplayColumn As System.Windows.Forms.Label
    Friend WithEvents lblGroupBy As System.Windows.Forms.Label
    Friend WithEvents cboGroupSales As System.Windows.Forms.ComboBox
    Friend WithEvents cboDisplayColumn As System.Windows.Forms.ComboBox
    Friend WithEvents btnExpandSalesList As System.Windows.Forms.Button
    Friend WithEvents lvSales As System.Windows.Forms.ListView
    Friend WithEvents LeadID As System.Windows.Forms.ColumnHeader
    Friend WithEvents Contact1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Address As System.Windows.Forms.ColumnHeader
    Friend WithEvents Products As System.Windows.Forms.ColumnHeader
    Friend WithEvents ApptDateTime As System.Windows.Forms.ColumnHeader
    Friend WithEvents HousePhone As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblConfimingPLS As System.Windows.Forms.Label
    Friend WithEvents cboSalesList As System.Windows.Forms.ComboBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents btnExpandMemorize As System.Windows.Forms.Button
    Friend WithEvents lbldisplaymemorized As System.Windows.Forms.Label
    Friend WithEvents lblgroupbymemorized As System.Windows.Forms.Label
    Friend WithEvents cboGroupByMemorized As System.Windows.Forms.ComboBox
    Friend WithEvents cboDisplayMemorized As System.Windows.Forms.ComboBox
    Friend WithEvents cboFilterGroups As System.Windows.Forms.ComboBox
    Friend WithEvents lvMemorized As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblFilterGroups As System.Windows.Forms.Label
    Friend WithEvents Reps As System.Windows.Forms.ColumnHeader
    Friend WithEvents tsbtnAFPics As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents pnlCustomerHistory As System.Windows.Forms.Panel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents tsAFPics As System.Windows.Forms.ToolStrip
    Private WithEvents tscboAFPicsFilter As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tsbtnShowCH As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents pnlAFPics As System.Windows.Forms.Panel
    Friend WithEvents CallHousePhone4194724000ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToThisCustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportListToLetterWizardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GoToLetterWizardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnCandC As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TScboCustomerHistory As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents tsAttachedFilesNAV As System.Windows.Forms.ToolStripButton
    Friend WithEvents tslblAFPic As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ilToolbarButtons As System.Windows.Forms.ImageList
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lnkOrderbyMem As System.Windows.Forms.LinkLabel
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ShowNotesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EnterSalesResultToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MemorizeThisApptToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditCustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CallThisCustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SendALetterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SetAppointmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AssignChangeSalesRepToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintAppointmentSheetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintCustomerInformationSheetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveThisApptToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripComboBox1 As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripComboBox2 As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveChangesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MarkTaskAsDoneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditScheduledTaskToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HideThisCompletedTaskToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmlvnoresults As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SCsalesresult As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SCCustomerList As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblND As System.Windows.Forms.Label
    Friend WithEvents lblResets As System.Windows.Forms.Label
    Friend WithEvents lblRep As System.Windows.Forms.Label
    Friend WithEvents lblIssued As System.Windows.Forms.Label
    Friend WithEvents lblDNS As System.Windows.Forms.Label
    Friend WithEvents lblNH As System.Windows.Forms.Label
    Friend WithEvents lblsales As System.Windows.Forms.Label
    Friend WithEvents lblSold As System.Windows.Forms.Label
    Friend WithEvents lblRC As System.Windows.Forms.Label
    Public WithEvents ImgLst256 As System.Windows.Forms.ImageList
    Public WithEvents ImgLst128 As System.Windows.Forms.ImageList
    Public WithEvents ImgLst48 As System.Windows.Forms.ImageList
    Public WithEvents ImgLst32 As System.Windows.Forms.ImageList
    Public WithEvents imgLst16 As System.Windows.Forms.ImageList
    Friend WithEvents cmAF As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents btnOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCreateSC As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnSendtoDesktop As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnCopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnRename As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnXLarge As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnLarge As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnMedium As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnSmall As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnList As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnDetails As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnTiles As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnRefresh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnPaste As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnNewFolder As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImgIssued As System.Windows.Forms.ImageList
    Friend WithEvents ImgIssued2 As System.Windows.Forms.ImageList
    Friend WithEvents ImgIssued3 As System.Windows.Forms.ImageList
    Friend WithEvents pnlIssue As System.Windows.Forms.Panel
    Friend WithEvents cmIssue As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents PrintThisLeadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmailThisLeadToAssignedRepsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lsJobPictures As System.Windows.Forms.ListView
    Friend WithEvents lsAttachedFiles As System.Windows.Forms.ListView
    Friend WithEvents cmJP As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator13 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnSendtoDesktopJP As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator14 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCutJP As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnCopyJP As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator15 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCreateSCJP As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnDeleteJP As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnRenameJP As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnJPViews As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmJPExtraLarge As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmJPLarge As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmJPMedium As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmJPSmall As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator16 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmJPList As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmJPDetails As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmJPTiles As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem17 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnAscendingJP As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnDescJP As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnRefreshJP As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator18 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnPasteJP As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator19 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnNewFolderJP As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents bgGetImages As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnSortby As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnAscending As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnDescending As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblCntFiltered As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnUpdateSPI As System.Windows.Forms.Button
    Friend WithEvents bgSalesQuery As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgNoResults As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgCustomerHistory As System.ComponentModel.BackgroundWorker
    Friend WithEvents SetAppointmentToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MoveAppointmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmrdtpCustList As System.Windows.Forms.Timer
    Friend WithEvents tmrSum As System.Windows.Forms.Timer
End Class
