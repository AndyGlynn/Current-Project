<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Confirming
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
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("UnConfirmed Appointments", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup2 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Confirmed Appointments", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup3 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Called & Cancelled", System.Windows.Forms.HorizontalAlignment.Left)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Confirming))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnExpandConfirming = New System.Windows.Forms.Button()
        Me.lblToChangeConfirming = New System.Windows.Forms.Label()
        Me.lblConfirmingSLS = New System.Windows.Forms.Label()
        Me.lblConfimingPLS = New System.Windows.Forms.Label()
        Me.cboConfirmingSLS = New System.Windows.Forms.ComboBox()
        Me.cboConfirmingPLS = New System.Windows.Forms.ComboBox()
        Me.lvConfirming = New System.Windows.Forms.ListView()
        Me.LeadID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ApptTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Contact1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Contact2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Address = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Products = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.HousePhone = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnExpandSales = New System.Windows.Forms.Button()
        Me.lblToChangeSales = New System.Windows.Forms.Label()
        Me.lblSalesSLS = New System.Windows.Forms.Label()
        Me.lblSalesPLS = New System.Windows.Forms.Label()
        Me.cboSalesSLS = New System.Windows.Forms.ComboBox()
        Me.cboSalesPLS = New System.Windows.Forms.ComboBox()
        Me.lvSales = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ilCustomerHistory = New System.Windows.Forms.ImageList(Me.components)
        Me.pnlCustomerHistory = New System.Windows.Forms.Panel()
        Me.tsAutoDial = New System.Windows.Forms.ToolStrip()
        Me.tsbtnPreviousRecord = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnNextRecord = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnHousePhone = New System.Windows.Forms.ToolStripSplitButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tslblCalling = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnCloseDialer = New System.Windows.Forms.ToolStripButton()
        Me.tsCustomerLog = New System.Windows.Forms.ToolStrip()
        Me.TScboCustomerHistory = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.btnLogCall = New System.Windows.Forms.ToolStripSplitButton()
        Me.calledcancelled = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
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
        Me.gbHomeInfo = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtHomeValue = New System.Windows.Forms.TextBox()
        Me.txtYrsOwned = New System.Windows.Forms.TextBox()
        Me.lblYrBuilt = New System.Windows.Forms.Label()
        Me.lblYrsOwned = New System.Windows.Forms.Label()
        Me.lblHomeValue = New System.Windows.Forms.Label()
        Me.txtYrBuilt = New System.Windows.Forms.TextBox()
        Me.gbContactInfo = New System.Windows.Forms.GroupBox()
        Me.txtWorkHours = New System.Windows.Forms.RichTextBox()
        Me.txtHousePhone = New System.Windows.Forms.TextBox()
        Me.txtaltphone2 = New System.Windows.Forms.TextBox()
        Me.txtaltphone1 = New System.Windows.Forms.TextBox()
        Me.lnkEmail = New System.Windows.Forms.LinkLabel()
        Me.lblEmail = New System.Windows.Forms.Label()
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
        Me.tsConfirming = New System.Windows.Forms.ToolStrip()
        Me.ilToolStripIcons = New System.Windows.Forms.ImageList(Me.components)
        Me.ttconfirming = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttCustomerHistoryNotes = New System.Windows.Forms.ToolTip(Me.components)
        Me.RefreshData = New System.Windows.Forms.Timer(Me.components)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.tsAutoDial.SuspendLayout()
        Me.tsCustomerLog.SuspendLayout()
        Me.gbSpecialInstructions.SuspendLayout()
        Me.gbProductInfo.SuspendLayout()
        Me.gbApptInfo.SuspendLayout()
        Me.gbHomeInfo.SuspendLayout()
        Me.gbContactInfo.SuspendLayout()
        CType(Me.pctVerified, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.TabControl1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.pnlCustomerHistory)
        Me.SplitContainer1.Panel2.Controls.Add(Me.tsAutoDial)
        Me.SplitContainer1.Panel2.Controls.Add(Me.tsCustomerLog)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbSpecialInstructions)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbProductInfo)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbApptInfo)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbHomeInfo)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbContactInfo)
        Me.SplitContainer1.Size = New System.Drawing.Size(990, 576)
        Me.SplitContainer1.SplitterDistance = 226
        Me.SplitContainer1.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.ImageList = Me.ilCustomerHistory
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(226, 576)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnExpandConfirming)
        Me.TabPage1.Controls.Add(Me.lblToChangeConfirming)
        Me.TabPage1.Controls.Add(Me.lblConfirmingSLS)
        Me.TabPage1.Controls.Add(Me.lblConfimingPLS)
        Me.TabPage1.Controls.Add(Me.cboConfirmingSLS)
        Me.TabPage1.Controls.Add(Me.cboConfirmingPLS)
        Me.TabPage1.Controls.Add(Me.lvConfirming)
        Me.TabPage1.ImageIndex = 7
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(218, 549)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Confirming"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnExpandConfirming
        '
        Me.btnExpandConfirming.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExpandConfirming.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExpandConfirming.Location = New System.Drawing.Point(189, 7)
        Me.btnExpandConfirming.Name = "btnExpandConfirming"
        Me.btnExpandConfirming.Size = New System.Drawing.Size(25, 48)
        Me.btnExpandConfirming.TabIndex = 6
        Me.btnExpandConfirming.UseVisualStyleBackColor = True
        '
        'lblToChangeConfirming
        '
        Me.lblToChangeConfirming.AutoSize = True
        Me.lblToChangeConfirming.Font = New System.Drawing.Font("Tahoma", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToChangeConfirming.ForeColor = System.Drawing.Color.Gray
        Me.lblToChangeConfirming.Location = New System.Drawing.Point(266, 16)
        Me.lblToChangeConfirming.Name = "lblToChangeConfirming"
        Me.lblToChangeConfirming.Size = New System.Drawing.Size(559, 23)
        Me.lblToChangeConfirming.TabIndex = 5
        Me.lblToChangeConfirming.Text = "To Change Column Order Click And Drag Column Headers"
        '
        'lblConfirmingSLS
        '
        Me.lblConfirmingSLS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblConfirmingSLS.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblConfirmingSLS.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmingSLS.ForeColor = System.Drawing.Color.Gray
        Me.lblConfirmingSLS.Location = New System.Drawing.Point(6, 34)
        Me.lblConfirmingSLS.Name = "lblConfirmingSLS"
        Me.lblConfirmingSLS.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.lblConfirmingSLS.Size = New System.Drawing.Size(156, 21)
        Me.lblConfirmingSLS.TabIndex = 4
        Me.lblConfirmingSLS.Text = "Filter by Sec. Lead Source"
        Me.lblConfirmingSLS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblConfimingPLS
        '
        Me.lblConfimingPLS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblConfimingPLS.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblConfimingPLS.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfimingPLS.ForeColor = System.Drawing.Color.Gray
        Me.lblConfimingPLS.Location = New System.Drawing.Point(6, 7)
        Me.lblConfimingPLS.Margin = New System.Windows.Forms.Padding(0)
        Me.lblConfimingPLS.Name = "lblConfimingPLS"
        Me.lblConfimingPLS.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.lblConfimingPLS.Size = New System.Drawing.Size(156, 21)
        Me.lblConfimingPLS.TabIndex = 3
        Me.lblConfimingPLS.Text = "Filter by Primary Lead Source"
        Me.lblConfimingPLS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboConfirmingSLS
        '
        Me.cboConfirmingSLS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboConfirmingSLS.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboConfirmingSLS.FormattingEnabled = True
        Me.cboConfirmingSLS.Location = New System.Drawing.Point(6, 34)
        Me.cboConfirmingSLS.Name = "cboConfirmingSLS"
        Me.cboConfirmingSLS.Size = New System.Drawing.Size(176, 21)
        Me.cboConfirmingSLS.TabIndex = 2
        '
        'cboConfirmingPLS
        '
        Me.cboConfirmingPLS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboConfirmingPLS.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboConfirmingPLS.FormattingEnabled = True
        Me.cboConfirmingPLS.Items.AddRange(New Object() {"Canvassing"})
        Me.cboConfirmingPLS.Location = New System.Drawing.Point(6, 7)
        Me.cboConfirmingPLS.Name = "cboConfirmingPLS"
        Me.cboConfirmingPLS.Size = New System.Drawing.Size(176, 21)
        Me.cboConfirmingPLS.TabIndex = 1
        '
        'lvConfirming
        '
        Me.lvConfirming.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvConfirming.AllowColumnReorder = True
        Me.lvConfirming.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvConfirming.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.LeadID, Me.ApptTime, Me.Contact1, Me.Contact2, Me.Address, Me.Products, Me.HousePhone})
        Me.lvConfirming.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvConfirming.FullRowSelect = True
        ListViewGroup1.Header = "UnConfirmed Appointments"
        ListViewGroup1.Name = "lgUnconfirmed"
        ListViewGroup2.Header = "Confirmed Appointments"
        ListViewGroup2.Name = "lgconfirmed"
        ListViewGroup3.Header = "Called & Cancelled"
        ListViewGroup3.Name = "lgC&C"
        Me.lvConfirming.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1, ListViewGroup2, ListViewGroup3})
        Me.lvConfirming.HideSelection = False
        Me.lvConfirming.Location = New System.Drawing.Point(3, 61)
        Me.lvConfirming.MultiSelect = False
        Me.lvConfirming.Name = "lvConfirming"
        Me.lvConfirming.Size = New System.Drawing.Size(211, 488)
        Me.lvConfirming.TabIndex = 0
        Me.lvConfirming.UseCompatibleStateImageBehavior = False
        Me.lvConfirming.View = System.Windows.Forms.View.Details
        '
        'LeadID
        '
        Me.LeadID.Text = "ID"
        '
        'ApptTime
        '
        Me.ApptTime.Text = "Appt. Time"
        Me.ApptTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ApptTime.Width = 77
        '
        'Contact1
        '
        Me.Contact1.Text = "Contact 1"
        Me.Contact1.Width = 160
        '
        'Contact2
        '
        Me.Contact2.Text = "Contact 2"
        Me.Contact2.Width = 160
        '
        'Address
        '
        Me.Address.Text = "Address"
        Me.Address.Width = 275
        '
        'Products
        '
        Me.Products.Text = "Product(s)"
        Me.Products.Width = 142
        '
        'HousePhone
        '
        Me.HousePhone.Text = "House Phone"
        Me.HousePhone.Width = 101
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnExpandSales)
        Me.TabPage2.Controls.Add(Me.lblToChangeSales)
        Me.TabPage2.Controls.Add(Me.lblSalesSLS)
        Me.TabPage2.Controls.Add(Me.lblSalesPLS)
        Me.TabPage2.Controls.Add(Me.cboSalesSLS)
        Me.TabPage2.Controls.Add(Me.cboSalesPLS)
        Me.TabPage2.Controls.Add(Me.lvSales)
        Me.TabPage2.ImageIndex = 1
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(218, 549)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Dispatch Sales"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnExpandSales
        '
        Me.btnExpandSales.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExpandSales.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExpandSales.Location = New System.Drawing.Point(189, 7)
        Me.btnExpandSales.Name = "btnExpandSales"
        Me.btnExpandSales.Size = New System.Drawing.Size(25, 48)
        Me.btnExpandSales.TabIndex = 10
        Me.btnExpandSales.UseVisualStyleBackColor = True
        '
        'lblToChangeSales
        '
        Me.lblToChangeSales.AutoSize = True
        Me.lblToChangeSales.Font = New System.Drawing.Font("Tahoma", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToChangeSales.ForeColor = System.Drawing.Color.Gray
        Me.lblToChangeSales.Location = New System.Drawing.Point(266, 16)
        Me.lblToChangeSales.Name = "lblToChangeSales"
        Me.lblToChangeSales.Size = New System.Drawing.Size(559, 23)
        Me.lblToChangeSales.TabIndex = 9
        Me.lblToChangeSales.Text = "To Change Column Order Click And Drag Column Headers"
        '
        'lblSalesSLS
        '
        Me.lblSalesSLS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSalesSLS.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSalesSLS.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalesSLS.ForeColor = System.Drawing.Color.Gray
        Me.lblSalesSLS.Location = New System.Drawing.Point(6, 34)
        Me.lblSalesSLS.Name = "lblSalesSLS"
        Me.lblSalesSLS.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.lblSalesSLS.Size = New System.Drawing.Size(156, 21)
        Me.lblSalesSLS.TabIndex = 8
        Me.lblSalesSLS.Text = "Filter by Sec. Lead Source"
        Me.lblSalesSLS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSalesPLS
        '
        Me.lblSalesPLS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSalesPLS.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSalesPLS.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalesPLS.ForeColor = System.Drawing.Color.Gray
        Me.lblSalesPLS.Location = New System.Drawing.Point(6, 7)
        Me.lblSalesPLS.Margin = New System.Windows.Forms.Padding(0)
        Me.lblSalesPLS.Name = "lblSalesPLS"
        Me.lblSalesPLS.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.lblSalesPLS.Size = New System.Drawing.Size(156, 21)
        Me.lblSalesPLS.TabIndex = 7
        Me.lblSalesPLS.Text = "Filter by Primary Lead Source"
        Me.lblSalesPLS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboSalesSLS
        '
        Me.cboSalesSLS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSalesSLS.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSalesSLS.FormattingEnabled = True
        Me.cboSalesSLS.Location = New System.Drawing.Point(6, 34)
        Me.cboSalesSLS.Name = "cboSalesSLS"
        Me.cboSalesSLS.Size = New System.Drawing.Size(176, 21)
        Me.cboSalesSLS.TabIndex = 6
        '
        'cboSalesPLS
        '
        Me.cboSalesPLS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSalesPLS.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSalesPLS.FormattingEnabled = True
        Me.cboSalesPLS.Items.AddRange(New Object() {"Canvassing"})
        Me.cboSalesPLS.Location = New System.Drawing.Point(6, 7)
        Me.cboSalesPLS.Name = "cboSalesPLS"
        Me.cboSalesPLS.Size = New System.Drawing.Size(176, 21)
        Me.cboSalesPLS.TabIndex = 5
        '
        'lvSales
        '
        Me.lvSales.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvSales.AllowColumnReorder = True
        Me.lvSales.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvSales.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader6, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader2})
        Me.lvSales.Cursor = System.Windows.Forms.Cursors.Default
        Me.lvSales.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvSales.FullRowSelect = True
        Me.lvSales.HideSelection = False
        Me.lvSales.Location = New System.Drawing.Point(3, 61)
        Me.lvSales.MultiSelect = False
        Me.lvSales.Name = "lvSales"
        Me.lvSales.Size = New System.Drawing.Size(211, 488)
        Me.lvSales.TabIndex = 1
        Me.lvSales.UseCompatibleStateImageBehavior = False
        Me.lvSales.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Appt. Time"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 77
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Contact 1"
        Me.ColumnHeader8.Width = 135
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.DisplayIndex = 6
        Me.ColumnHeader9.Text = "Sales Rep(s)"
        Me.ColumnHeader9.Width = 135
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.DisplayIndex = 3
        Me.ColumnHeader4.Text = "Address"
        Me.ColumnHeader4.Width = 275
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.DisplayIndex = 4
        Me.ColumnHeader5.Text = "Product(s)"
        Me.ColumnHeader5.Width = 142
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.DisplayIndex = 5
        Me.ColumnHeader2.Text = "Issue Notes"
        Me.ColumnHeader2.Width = 155
        '
        'ilCustomerHistory
        '
        Me.ilCustomerHistory.ImageStream = CType(resources.GetObject("ilCustomerHistory.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilCustomerHistory.TransparentColor = System.Drawing.Color.Transparent
        Me.ilCustomerHistory.Images.SetKeyName(0, "marketing manager4.ico")
        Me.ilCustomerHistory.Images.SetKeyName(1, "cash.ico")
        Me.ilCustomerHistory.Images.SetKeyName(2, "Finance Dept.ico")
        Me.ilCustomerHistory.Images.SetKeyName(3, "hammerused.ico")
        Me.ilCustomerHistory.Images.SetKeyName(4, "recovery2.ico")
        Me.ilCustomerHistory.Images.SetKeyName(5, "phone4.ico")
        Me.ilCustomerHistory.Images.SetKeyName(6, "lock.ico")
        Me.ilCustomerHistory.Images.SetKeyName(7, "inetcpl_4480.ico")
        Me.ilCustomerHistory.Images.SetKeyName(8, "Previous Customer.ico")
        Me.ilCustomerHistory.Images.SetKeyName(9, "Warm Caller.ico")
        Me.ilCustomerHistory.Images.SetKeyName(10, "Notes4.ico")
        Me.ilCustomerHistory.Images.SetKeyName(11, "Cancel.ico")
        Me.ilCustomerHistory.Images.SetKeyName(12, "Do not call2.ico")
        Me.ilCustomerHistory.Images.SetKeyName(13, "done2.ico")
        '
        'pnlCustomerHistory
        '
        Me.pnlCustomerHistory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCustomerHistory.AutoScroll = True
        Me.pnlCustomerHistory.Location = New System.Drawing.Point(3, 390)
        Me.pnlCustomerHistory.Name = "pnlCustomerHistory"
        Me.pnlCustomerHistory.Size = New System.Drawing.Size(754, 183)
        Me.pnlCustomerHistory.TabIndex = 187
        '
        'tsAutoDial
        '
        Me.tsAutoDial.Dock = System.Windows.Forms.DockStyle.None
        Me.tsAutoDial.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsAutoDial.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnPreviousRecord, Me.tsbtnNextRecord, Me.ToolStripSeparator3, Me.tsbtnHousePhone, Me.ToolStripSeparator1, Me.tslblCalling, Me.ToolStripSeparator2, Me.tsbtnCloseDialer})
        Me.tsAutoDial.Location = New System.Drawing.Point(103, 0)
        Me.tsAutoDial.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.tsAutoDial.Name = "tsAutoDial"
        Me.tsAutoDial.Size = New System.Drawing.Size(501, 25)
        Me.tsAutoDial.TabIndex = 176
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
        Me.tsbtnCloseDialer.Image = CType(resources.GetObject("tsbtnCloseDialer.Image"), System.Drawing.Image)
        Me.tsbtnCloseDialer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnCloseDialer.Name = "tsbtnCloseDialer"
        Me.tsbtnCloseDialer.Size = New System.Drawing.Size(89, 22)
        Me.tsbtnCloseDialer.Text = "Close Dialer"
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
        Me.tsCustomerLog.Size = New System.Drawing.Size(751, 33)
        Me.tsCustomerLog.TabIndex = 186
        Me.tsCustomerLog.Text = "ToolStrip1"
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
        Me.btnLogCall.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.calledcancelled})
        Me.btnLogCall.Image = CType(resources.GetObject("btnLogCall.Image"), System.Drawing.Image)
        Me.btnLogCall.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnLogCall.Name = "btnLogCall"
        Me.btnLogCall.Size = New System.Drawing.Size(272, 30)
        Me.btnLogCall.Text = "Log Phone Conversation with this Customer"
        '
        'calledcancelled
        '
        Me.calledcancelled.Image = Global.Latest.My.Resources.Resources.calledcancelled
        Me.calledcancelled.Name = "calledcancelled"
        Me.calledcancelled.Size = New System.Drawing.Size(254, 22)
        Me.calledcancelled.Text = "Log Appt. as Called and Cancelled"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.Margin = New System.Windows.Forms.Padding(40, 1, 0, 2)
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(150, 30)
        Me.ToolStripLabel2.Text = "Customer History"
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
        Me.gbSpecialInstructions.Location = New System.Drawing.Point(444, 207)
        Me.gbSpecialInstructions.Name = "gbSpecialInstructions"
        Me.gbSpecialInstructions.Size = New System.Drawing.Size(310, 144)
        Me.gbSpecialInstructions.TabIndex = 185
        Me.gbSpecialInstructions.TabStop = False
        Me.gbSpecialInstructions.Text = "Special Instructions"
        '
        'btnEditSPI
        '
        Me.btnEditSPI.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditSPI.Location = New System.Drawing.Point(251, 115)
        Me.btnEditSPI.Name = "btnEditSPI"
        Me.btnEditSPI.Size = New System.Drawing.Size(53, 23)
        Me.btnEditSPI.TabIndex = 147
        Me.btnEditSPI.Text = "Edit"
        Me.btnEditSPI.UseVisualStyleBackColor = True
        '
        'rtbSpecialInstructions
        '
        Me.rtbSpecialInstructions.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbSpecialInstructions.BackColor = System.Drawing.Color.White
        Me.rtbSpecialInstructions.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbSpecialInstructions.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbSpecialInstructions.Location = New System.Drawing.Point(6, 22)
        Me.rtbSpecialInstructions.Name = "rtbSpecialInstructions"
        Me.rtbSpecialInstructions.ReadOnly = True
        Me.rtbSpecialInstructions.Size = New System.Drawing.Size(298, 116)
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
        Me.gbProductInfo.Location = New System.Drawing.Point(197, 207)
        Me.gbProductInfo.Name = "gbProductInfo"
        Me.gbProductInfo.Size = New System.Drawing.Size(241, 144)
        Me.gbProductInfo.TabIndex = 184
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
        Me.txtProducts.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.txtColor.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.txtQty.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.gbApptInfo.Location = New System.Drawing.Point(3, 207)
        Me.gbApptInfo.Name = "gbApptInfo"
        Me.gbApptInfo.Size = New System.Drawing.Size(188, 144)
        Me.gbApptInfo.TabIndex = 183
        Me.gbApptInfo.TabStop = False
        Me.gbApptInfo.Text = "Appointment Info:"
        '
        'txtApptDate
        '
        Me.txtApptDate.BackColor = System.Drawing.Color.White
        Me.txtApptDate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtApptDate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApptDate.ForeColor = System.Drawing.Color.Black
        Me.txtApptDate.Location = New System.Drawing.Point(61, 30)
        Me.txtApptDate.Name = "txtApptDate"
        Me.txtApptDate.ReadOnly = True
        Me.txtApptDate.Size = New System.Drawing.Size(114, 16)
        Me.txtApptDate.TabIndex = 21
        '
        'txtApptTime
        '
        Me.txtApptTime.BackColor = System.Drawing.Color.White
        Me.txtApptTime.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtApptTime.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApptTime.ForeColor = System.Drawing.Color.Black
        Me.txtApptTime.Location = New System.Drawing.Point(61, 116)
        Me.txtApptTime.Name = "txtApptTime"
        Me.txtApptTime.ReadOnly = True
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
        Me.txtApptDay.BackColor = System.Drawing.Color.White
        Me.txtApptDay.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtApptDay.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApptDay.ForeColor = System.Drawing.Color.Black
        Me.txtApptDay.Location = New System.Drawing.Point(61, 73)
        Me.txtApptDay.Name = "txtApptDay"
        Me.txtApptDay.ReadOnly = True
        Me.txtApptDay.Size = New System.Drawing.Size(114, 16)
        Me.txtApptDay.TabIndex = 16
        '
        'gbHomeInfo
        '
        Me.gbHomeInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbHomeInfo.BackColor = System.Drawing.Color.White
        Me.gbHomeInfo.Controls.Add(Me.Label2)
        Me.gbHomeInfo.Controls.Add(Me.Label1)
        Me.gbHomeInfo.Controls.Add(Me.txtHomeValue)
        Me.gbHomeInfo.Controls.Add(Me.txtYrsOwned)
        Me.gbHomeInfo.Controls.Add(Me.lblYrBuilt)
        Me.gbHomeInfo.Controls.Add(Me.lblYrsOwned)
        Me.gbHomeInfo.Controls.Add(Me.lblHomeValue)
        Me.gbHomeInfo.Controls.Add(Me.txtYrBuilt)
        Me.gbHomeInfo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbHomeInfo.ForeColor = System.Drawing.Color.Gray
        Me.gbHomeInfo.Location = New System.Drawing.Point(627, 3)
        Me.gbHomeInfo.Name = "gbHomeInfo"
        Me.gbHomeInfo.Size = New System.Drawing.Size(127, 198)
        Me.gbHomeInfo.TabIndex = 182
        Me.gbHomeInfo.TabStop = False
        Me.gbHomeInfo.Text = "Home Info:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(20, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 16)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "$"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(90, 166)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 16)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "K"
        '
        'txtHomeValue
        '
        Me.txtHomeValue.BackColor = System.Drawing.Color.White
        Me.txtHomeValue.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtHomeValue.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHomeValue.ForeColor = System.Drawing.Color.Black
        Me.txtHomeValue.Location = New System.Drawing.Point(42, 166)
        Me.txtHomeValue.Name = "txtHomeValue"
        Me.txtHomeValue.ReadOnly = True
        Me.txtHomeValue.Size = New System.Drawing.Size(42, 16)
        Me.txtHomeValue.TabIndex = 35
        Me.txtHomeValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtYrsOwned
        '
        Me.txtYrsOwned.BackColor = System.Drawing.Color.White
        Me.txtYrsOwned.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtYrsOwned.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYrsOwned.ForeColor = System.Drawing.Color.Black
        Me.txtYrsOwned.Location = New System.Drawing.Point(22, 114)
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
        Me.txtYrBuilt.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYrBuilt.ForeColor = System.Drawing.Color.Black
        Me.txtYrBuilt.Location = New System.Drawing.Point(21, 60)
        Me.txtYrBuilt.Name = "txtYrBuilt"
        Me.txtYrBuilt.ReadOnly = True
        Me.txtYrBuilt.Size = New System.Drawing.Size(91, 16)
        Me.txtYrBuilt.TabIndex = 29
        Me.txtYrBuilt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gbContactInfo
        '
        Me.gbContactInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbContactInfo.BackColor = System.Drawing.Color.White
        Me.gbContactInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.gbContactInfo.Controls.Add(Me.txtWorkHours)
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
        Me.gbContactInfo.Size = New System.Drawing.Size(618, 198)
        Me.gbContactInfo.TabIndex = 180
        Me.gbContactInfo.TabStop = False
        Me.gbContactInfo.Text = "Contact Info:"
        '
        'txtWorkHours
        '
        Me.txtWorkHours.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtWorkHours.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWorkHours.Location = New System.Drawing.Point(100, 144)
        Me.txtWorkHours.Name = "txtWorkHours"
        Me.txtWorkHours.Size = New System.Drawing.Size(185, 38)
        Me.txtWorkHours.TabIndex = 142
        Me.txtWorkHours.Text = ""
        '
        'txtHousePhone
        '
        Me.txtHousePhone.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHousePhone.BackColor = System.Drawing.Color.White
        Me.txtHousePhone.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtHousePhone.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHousePhone.ForeColor = System.Drawing.Color.Black
        Me.txtHousePhone.Location = New System.Drawing.Point(414, 33)
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
        Me.txtaltphone2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaltphone2.ForeColor = System.Drawing.Color.Black
        Me.txtaltphone2.Location = New System.Drawing.Point(414, 96)
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
        Me.txtaltphone1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaltphone1.ForeColor = System.Drawing.Color.Black
        Me.txtaltphone1.Location = New System.Drawing.Point(414, 64)
        Me.txtaltphone1.Name = "txtaltphone1"
        Me.txtaltphone1.ReadOnly = True
        Me.txtaltphone1.Size = New System.Drawing.Size(116, 16)
        Me.txtaltphone1.TabIndex = 139
        '
        'lnkEmail
        '
        Me.lnkEmail.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lnkEmail.AutoSize = True
        Me.lnkEmail.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkEmail.Location = New System.Drawing.Point(361, 144)
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
        Me.lblEmail.Location = New System.Drawing.Point(310, 144)
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
        Me.txtAlt1Type.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlt1Type.ForeColor = System.Drawing.Color.Black
        Me.txtAlt1Type.Location = New System.Drawing.Point(546, 64)
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
        Me.txtAlt2Type.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlt2Type.ForeColor = System.Drawing.Color.Black
        Me.txtAlt2Type.Location = New System.Drawing.Point(546, 96)
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
        Me.lblAltPhone2.Location = New System.Drawing.Point(310, 96)
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
        Me.lblAltPhone1.Location = New System.Drawing.Point(310, 64)
        Me.lblAltPhone1.Name = "lblAltPhone1"
        Me.lblAltPhone1.Size = New System.Drawing.Size(88, 16)
        Me.lblAltPhone1.TabIndex = 81
        Me.lblAltPhone1.Text = "Alt Phone 1:"
        '
        'pctVerified
        '
        Me.pctVerified.Image = CType(resources.GetObject("pctVerified.Image"), System.Drawing.Image)
        Me.pctVerified.Location = New System.Drawing.Point(29, 114)
        Me.pctVerified.Name = "pctVerified"
        Me.pctVerified.Size = New System.Drawing.Size(24, 24)
        Me.pctVerified.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctVerified.TabIndex = 133
        Me.pctVerified.TabStop = False
        Me.ttconfirming.SetToolTip(Me.pctVerified, "This Icon indicates that" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the address has been" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "verified through our software")
        Me.pctVerified.Visible = False
        '
        'lblHousePhone
        '
        Me.lblHousePhone.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHousePhone.AutoSize = True
        Me.lblHousePhone.BackColor = System.Drawing.Color.Transparent
        Me.lblHousePhone.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHousePhone.ForeColor = System.Drawing.Color.Gray
        Me.lblHousePhone.Location = New System.Drawing.Point(310, 33)
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
        Me.txtAddress.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.txtContact2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.txtContact1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        'tsConfirming
        '
        Me.tsConfirming.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsConfirming.Location = New System.Drawing.Point(0, 0)
        Me.tsConfirming.Name = "tsConfirming"
        Me.tsConfirming.Size = New System.Drawing.Size(990, 25)
        Me.tsConfirming.TabIndex = 1
        Me.tsConfirming.Text = "ToolStrip1"
        '
        'ilToolStripIcons
        '
        Me.ilToolStripIcons.ImageStream = CType(resources.GetObject("ilToolStripIcons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilToolStripIcons.TransparentColor = System.Drawing.Color.Transparent
        Me.ilToolStripIcons.Images.SetKeyName(0, "inetcpl_4480.ico")
        Me.ilToolStripIcons.Images.SetKeyName(1, "user.ico")
        Me.ilToolStripIcons.Images.SetKeyName(2, "marketing manager4.ico")
        Me.ilToolStripIcons.Images.SetKeyName(3, "Cancel.ico")
        Me.ilToolStripIcons.Images.SetKeyName(4, "transfer6.ico")
        Me.ilToolStripIcons.Images.SetKeyName(5, "C&C24.ico")
        Me.ilToolStripIcons.Images.SetKeyName(6, "cash.ico")
        Me.ilToolStripIcons.Images.SetKeyName(7, "NOTES1.ICO")
        Me.ilToolStripIcons.Images.SetKeyName(8, "tranfer.ico")
        Me.ilToolStripIcons.Images.SetKeyName(9, "Cancel.ico")
        Me.ilToolStripIcons.Images.SetKeyName(10, "phone4.ico")
        Me.ilToolStripIcons.Images.SetKeyName(11, "Do Not Call!!.ico")
        Me.ilToolStripIcons.Images.SetKeyName(12, "donotmail.ico")
        Me.ilToolStripIcons.Images.SetKeyName(13, "Do not call!.ico")
        Me.ilToolStripIcons.Images.SetKeyName(14, "notes2.ico")
        Me.ilToolStripIcons.Images.SetKeyName(15, "arrow-right.ico")
        '
        'ttCustomerHistoryNotes
        '
        Me.ttCustomerHistoryNotes.AutoPopDelay = 30000
        Me.ttCustomerHistoryNotes.InitialDelay = 500
        Me.ttCustomerHistoryNotes.ReshowDelay = 100
        '
        'RefreshData
        '
        Me.RefreshData.Interval = 10000
        '
        'Confirming
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(990, 601)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.tsConfirming)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Confirming"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Confiming"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.tsAutoDial.ResumeLayout(False)
        Me.tsAutoDial.PerformLayout()
        Me.tsCustomerLog.ResumeLayout(False)
        Me.tsCustomerLog.PerformLayout()
        Me.gbSpecialInstructions.ResumeLayout(False)
        Me.gbProductInfo.ResumeLayout(False)
        Me.gbProductInfo.PerformLayout()
        Me.gbApptInfo.ResumeLayout(False)
        Me.gbApptInfo.PerformLayout()
        Me.gbHomeInfo.ResumeLayout(False)
        Me.gbHomeInfo.PerformLayout()
        Me.gbContactInfo.ResumeLayout(False)
        Me.gbContactInfo.PerformLayout()
        CType(Me.pctVerified, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents lvConfirming As System.Windows.Forms.ListView
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents tsConfirming As System.Windows.Forms.ToolStrip
    Friend WithEvents LeadID As System.Windows.Forms.ColumnHeader
    Friend WithEvents Contact1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Contact2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Address As System.Windows.Forms.ColumnHeader
    Friend WithEvents Products As System.Windows.Forms.ColumnHeader
    Friend WithEvents ApptTime As System.Windows.Forms.ColumnHeader
    Friend WithEvents HousePhone As System.Windows.Forms.ColumnHeader
    Friend WithEvents cboConfirmingSLS As System.Windows.Forms.ComboBox
    Friend WithEvents cboConfirmingPLS As System.Windows.Forms.ComboBox
    Friend WithEvents lblToChangeConfirming As System.Windows.Forms.Label
    Friend WithEvents lblConfirmingSLS As System.Windows.Forms.Label
    Friend WithEvents lblConfimingPLS As System.Windows.Forms.Label
    Friend WithEvents btnExpandConfirming As System.Windows.Forms.Button
    Friend WithEvents lvSales As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblSalesSLS As System.Windows.Forms.Label
    Friend WithEvents lblSalesPLS As System.Windows.Forms.Label
    Friend WithEvents cboSalesSLS As System.Windows.Forms.ComboBox
    Friend WithEvents cboSalesPLS As System.Windows.Forms.ComboBox
    Friend WithEvents btnExpandSales As System.Windows.Forms.Button
    Friend WithEvents lblToChangeSales As System.Windows.Forms.Label
    Friend WithEvents gbContactInfo As System.Windows.Forms.GroupBox
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
    Friend WithEvents gbHomeInfo As System.Windows.Forms.GroupBox
    Friend WithEvents txtYrsOwned As System.Windows.Forms.TextBox
    Friend WithEvents lblYrBuilt As System.Windows.Forms.Label
    Friend WithEvents lblYrsOwned As System.Windows.Forms.Label
    Friend WithEvents lblHomeValue As System.Windows.Forms.Label
    Friend WithEvents txtYrBuilt As System.Windows.Forms.TextBox
    Friend WithEvents tsCustomerLog As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
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
    Friend WithEvents txtApptTime As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents lblApptDate As System.Windows.Forms.Label
    Friend WithEvents lblApptDay As System.Windows.Forms.Label
    Friend WithEvents txtApptDay As System.Windows.Forms.TextBox
    Friend WithEvents txtHomeValue As System.Windows.Forms.TextBox
    Friend WithEvents txtHousePhone As System.Windows.Forms.TextBox
    Friend WithEvents ilToolStripIcons As System.Windows.Forms.ImageList
    Friend WithEvents ilCustomerHistory As System.Windows.Forms.ImageList
    Friend WithEvents ttconfirming As System.Windows.Forms.ToolTip
    Friend WithEvents ttCustomerHistoryNotes As System.Windows.Forms.ToolTip
    Friend WithEvents btnLogCall As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents calledcancelled As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsAutoDial As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbtnPreviousRecord As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnNextRecord As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbtnHousePhone As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tslblCalling As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbtnCloseDialer As System.Windows.Forms.ToolStripButton
    Friend WithEvents RefreshData As System.Windows.Forms.Timer
    Friend WithEvents txtApptDate As System.Windows.Forms.TextBox
    Friend WithEvents pnlCustomerHistory As System.Windows.Forms.Panel
    Friend WithEvents TScboCustomerHistory As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtWorkHours As System.Windows.Forms.RichTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnEditSPI As System.Windows.Forms.Button

End Class
