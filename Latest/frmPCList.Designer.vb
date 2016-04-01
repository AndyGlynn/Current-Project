<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPCList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPCList))
        Me.btnUncheckProducts = New System.Windows.Forms.Label()
        Me.chlstProducts = New System.Windows.Forms.CheckedListBox()
        Me.tabGeo = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cboStateSelection = New System.Windows.Forms.ComboBox()
        Me.lblStateSelect = New System.Windows.Forms.Label()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnUncheckZip = New System.Windows.Forms.Label()
        Me.btnCheckZip = New System.Windows.Forms.Label()
        Me.chlstZipCity = New System.Windows.Forms.CheckedListBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.numMiles = New System.Windows.Forms.NumericUpDown()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtZipCity = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.rdoCity = New System.Windows.Forms.RadioButton()
        Me.rdoZip = New System.Windows.Forms.RadioButton()
        Me.btnCheckProducts = New System.Windows.Forms.Label()
        Me.tabSort = New System.Windows.Forms.TabPage()
        Me.btnUnCheckOrderBy = New System.Windows.Forms.Label()
        Me.btnCheckOrderBy = New System.Windows.Forms.Label()
        Me.chlstOrderBy = New System.Windows.Forms.CheckedListBox()
        Me.chGroupBy = New System.Windows.Forms.CheckBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.epGeo = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.epForm = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.BackgroundWorkerCity = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabPC = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.chFutureInterest = New System.Windows.Forms.CheckBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cboPCDateRange = New System.Windows.Forms.ComboBox()
        Me.numReferences = New System.Windows.Forms.NumericUpDown()
        Me.txtDate2PC = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtApprovedDollars = New System.Windows.Forms.TextBox()
        Me.txtDate1PC = New System.Windows.Forms.TextBox()
        Me.chApprovedFor = New System.Windows.Forms.CheckBox()
        Me.dpDate1PC = New System.Windows.Forms.DateTimePicker()
        Me.numMonths = New System.Windows.Forms.NumericUpDown()
        Me.dpDate2PC = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.rdoCash = New System.Windows.Forms.RadioButton()
        Me.rdoAll = New System.Windows.Forms.RadioButton()
        Me.rdoLoan = New System.Windows.Forms.RadioButton()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.chLoanSatisfied = New System.Windows.Forms.CheckBox()
        Me.tabMarketers = New System.Windows.Forms.TabPage()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.uncheckMarketers = New System.Windows.Forms.Label()
        Me.checkMarketers = New System.Windows.Forms.Label()
        Me.chlstMarketers = New System.Windows.Forms.CheckedListBox()
        Me.tabProducts = New System.Windows.Forms.TabPage()
        Me.BackgroundWorkerZip = New System.ComponentModel.BackgroundWorker()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.tabGeo.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.numMiles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSort.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.epGeo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tabPC.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.numReferences, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numMonths, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.tabMarketers.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.tabProducts.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnUncheckProducts
        '
        Me.btnUncheckProducts.AutoSize = True
        Me.btnUncheckProducts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUncheckProducts.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUncheckProducts.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnUncheckProducts.Location = New System.Drawing.Point(323, 204)
        Me.btnUncheckProducts.Name = "btnUncheckProducts"
        Me.btnUncheckProducts.Size = New System.Drawing.Size(83, 16)
        Me.btnUncheckProducts.TabIndex = 9
        Me.btnUncheckProducts.Text = "Uncheck All"
        '
        'chlstProducts
        '
        Me.chlstProducts.FormattingEnabled = True
        Me.chlstProducts.Location = New System.Drawing.Point(18, 22)
        Me.chlstProducts.MultiColumn = True
        Me.chlstProducts.Name = "chlstProducts"
        Me.chlstProducts.Size = New System.Drawing.Size(607, 154)
        Me.chlstProducts.TabIndex = 7
        '
        'tabGeo
        '
        Me.tabGeo.Controls.Add(Me.GroupBox3)
        Me.tabGeo.Location = New System.Drawing.Point(4, 22)
        Me.tabGeo.Name = "tabGeo"
        Me.tabGeo.Size = New System.Drawing.Size(666, 288)
        Me.tabGeo.TabIndex = 4
        Me.tabGeo.Text = "Geography"
        Me.tabGeo.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cboStateSelection)
        Me.GroupBox3.Controls.Add(Me.lblStateSelect)
        Me.GroupBox3.Controls.Add(Me.btnShow)
        Me.GroupBox3.Controls.Add(Me.btnUncheckZip)
        Me.GroupBox3.Controls.Add(Me.btnCheckZip)
        Me.GroupBox3.Controls.Add(Me.chlstZipCity)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.numMiles)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.txtZipCity)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.rdoCity)
        Me.GroupBox3.Controls.Add(Me.rdoZip)
        Me.GroupBox3.Location = New System.Drawing.Point(14, 11)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(638, 237)
        Me.GroupBox3.TabIndex = 39
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Geography"
        '
        'cboStateSelection
        '
        Me.cboStateSelection.FormattingEnabled = True
        Me.cboStateSelection.Location = New System.Drawing.Point(266, 99)
        Me.cboStateSelection.Name = "cboStateSelection"
        Me.cboStateSelection.Size = New System.Drawing.Size(62, 21)
        Me.cboStateSelection.TabIndex = 12
        '
        'lblStateSelect
        '
        Me.lblStateSelect.AutoSize = True
        Me.lblStateSelect.Location = New System.Drawing.Point(15, 102)
        Me.lblStateSelect.Name = "lblStateSelect"
        Me.lblStateSelect.Size = New System.Drawing.Size(110, 13)
        Me.lblStateSelect.TabIndex = 11
        Me.lblStateSelect.Text = "Select Starting State :"
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(492, 200)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(140, 24)
        Me.btnShow.TabIndex = 10
        Me.btnShow.Text = "Show Zip Codes"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'btnUncheckZip
        '
        Me.btnUncheckZip.AutoSize = True
        Me.btnUncheckZip.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUncheckZip.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUncheckZip.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnUncheckZip.Location = New System.Drawing.Point(521, 164)
        Me.btnUncheckZip.Name = "btnUncheckZip"
        Me.btnUncheckZip.Size = New System.Drawing.Size(83, 16)
        Me.btnUncheckZip.TabIndex = 9
        Me.btnUncheckZip.Text = "Uncheck All"
        '
        'btnCheckZip
        '
        Me.btnCheckZip.AutoSize = True
        Me.btnCheckZip.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCheckZip.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckZip.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnCheckZip.Location = New System.Drawing.Point(430, 164)
        Me.btnCheckZip.Name = "btnCheckZip"
        Me.btnCheckZip.Size = New System.Drawing.Size(67, 16)
        Me.btnCheckZip.TabIndex = 8
        Me.btnCheckZip.Text = "Check All"
        '
        'chlstZipCity
        '
        Me.chlstZipCity.FormattingEnabled = True
        Me.chlstZipCity.Location = New System.Drawing.Point(412, 22)
        Me.chlstZipCity.Name = "chlstZipCity"
        Me.chlstZipCity.Size = New System.Drawing.Size(213, 124)
        Me.chlstZipCity.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(227, 136)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(128, 13)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Miles of Starting Zip Code"
        '
        'numMiles
        '
        Me.numMiles.Location = New System.Drawing.Point(179, 134)
        Me.numMiles.Name = "numMiles"
        Me.numMiles.Size = New System.Drawing.Size(42, 20)
        Me.numMiles.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 136)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(115, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Show Zip Codes within"
        '
        'txtZipCity
        '
        Me.txtZipCity.Location = New System.Drawing.Point(191, 67)
        Me.txtZipCity.Name = "txtZipCity"
        Me.txtZipCity.Size = New System.Drawing.Size(137, 20)
        Me.txtZipCity.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 70)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Enter Starting Zip Code:"
        '
        'rdoCity
        '
        Me.rdoCity.AutoSize = True
        Me.rdoCity.Location = New System.Drawing.Point(235, 35)
        Me.rdoCity.Name = "rdoCity"
        Me.rdoCity.Size = New System.Drawing.Size(129, 17)
        Me.rdoCity.TabIndex = 1
        Me.rdoCity.Text = "Search by City Radius"
        Me.rdoCity.UseVisualStyleBackColor = True
        '
        'rdoZip
        '
        Me.rdoZip.AutoSize = True
        Me.rdoZip.Checked = True
        Me.rdoZip.Location = New System.Drawing.Point(18, 35)
        Me.rdoZip.Name = "rdoZip"
        Me.rdoZip.Size = New System.Drawing.Size(155, 17)
        Me.rdoZip.TabIndex = 0
        Me.rdoZip.TabStop = True
        Me.rdoZip.Text = "Search by Zip Code Radius"
        Me.rdoZip.UseVisualStyleBackColor = True
        '
        'btnCheckProducts
        '
        Me.btnCheckProducts.AutoSize = True
        Me.btnCheckProducts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCheckProducts.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckProducts.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnCheckProducts.Location = New System.Drawing.Point(232, 204)
        Me.btnCheckProducts.Name = "btnCheckProducts"
        Me.btnCheckProducts.Size = New System.Drawing.Size(67, 16)
        Me.btnCheckProducts.TabIndex = 8
        Me.btnCheckProducts.Text = "Check All"
        '
        'tabSort
        '
        Me.tabSort.Controls.Add(Me.btnUnCheckOrderBy)
        Me.tabSort.Controls.Add(Me.btnCheckOrderBy)
        Me.tabSort.Controls.Add(Me.btnDown)
        Me.tabSort.Controls.Add(Me.btnUp)
        Me.tabSort.Controls.Add(Me.chlstOrderBy)
        Me.tabSort.Controls.Add(Me.chGroupBy)
        Me.tabSort.Location = New System.Drawing.Point(4, 22)
        Me.tabSort.Name = "tabSort"
        Me.tabSort.Size = New System.Drawing.Size(666, 288)
        Me.tabSort.TabIndex = 6
        Me.tabSort.Text = "Sort By/Group By"
        Me.tabSort.UseVisualStyleBackColor = True
        '
        'btnUnCheckOrderBy
        '
        Me.btnUnCheckOrderBy.AutoSize = True
        Me.btnUnCheckOrderBy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUnCheckOrderBy.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUnCheckOrderBy.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnUnCheckOrderBy.Location = New System.Drawing.Point(337, 216)
        Me.btnUnCheckOrderBy.Name = "btnUnCheckOrderBy"
        Me.btnUnCheckOrderBy.Size = New System.Drawing.Size(83, 16)
        Me.btnUnCheckOrderBy.TabIndex = 40
        Me.btnUnCheckOrderBy.Text = "Uncheck All"
        '
        'btnCheckOrderBy
        '
        Me.btnCheckOrderBy.AutoSize = True
        Me.btnCheckOrderBy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCheckOrderBy.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckOrderBy.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnCheckOrderBy.Location = New System.Drawing.Point(246, 216)
        Me.btnCheckOrderBy.Name = "btnCheckOrderBy"
        Me.btnCheckOrderBy.Size = New System.Drawing.Size(67, 16)
        Me.btnCheckOrderBy.TabIndex = 39
        Me.btnCheckOrderBy.Text = "Check All"
        '
        'chlstOrderBy
        '
        Me.chlstOrderBy.ColumnWidth = 200
        Me.chlstOrderBy.FormattingEnabled = True
        Me.chlstOrderBy.Items.AddRange(New Object() {"City, State", "Zip Code", "Job Completed Date", "Products"})
        Me.chlstOrderBy.Location = New System.Drawing.Point(55, 56)
        Me.chlstOrderBy.MultiColumn = True
        Me.chlstOrderBy.Name = "chlstOrderBy"
        Me.chlstOrderBy.Size = New System.Drawing.Size(578, 139)
        Me.chlstOrderBy.TabIndex = 1
        '
        'chGroupBy
        '
        Me.chGroupBy.AutoSize = True
        Me.chGroupBy.Location = New System.Drawing.Point(23, 18)
        Me.chGroupBy.Name = "chGroupBy"
        Me.chGroupBy.Size = New System.Drawing.Size(137, 17)
        Me.chGroupBy.TabIndex = 0
        Me.chGroupBy.Text = "Group By Top Sort Item"
        Me.chGroupBy.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.RichTextBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(666, 288)
        Me.TabPage1.TabIndex = 8
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(56, 59)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(555, 146)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = ""
        '
        'epGeo
        '
        Me.epGeo.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.epGeo.ContainerControl = Me
        '
        'epForm
        '
        Me.epForm.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.epForm.ContainerControl = Me
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "danger.ico")
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnUncheckProducts)
        Me.GroupBox4.Controls.Add(Me.btnCheckProducts)
        Me.GroupBox4.Controls.Add(Me.chlstProducts)
        Me.GroupBox4.Location = New System.Drawing.Point(14, 11)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(638, 237)
        Me.GroupBox4.TabIndex = 38
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Products"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(608, 342)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 57
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnGenerate
        '
        Me.btnGenerate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenerate.Location = New System.Drawing.Point(387, 342)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(183, 23)
        Me.btnGenerate.TabIndex = 56
        Me.btnGenerate.Text = "Generate Marketing List"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClear.Location = New System.Drawing.Point(166, 342)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(183, 23)
        Me.btnClear.TabIndex = 55
        Me.btnClear.Text = "Clear Criteria"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabPC)
        Me.TabControl1.Controls.Add(Me.tabMarketers)
        Me.TabControl1.Controls.Add(Me.tabProducts)
        Me.TabControl1.Controls.Add(Me.tabGeo)
        Me.TabControl1.Controls.Add(Me.tabSort)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(13, 12)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.ShowToolTips = True
        Me.TabControl1.Size = New System.Drawing.Size(674, 314)
        Me.TabControl1.TabIndex = 54
        '
        'tabPC
        '
        Me.tabPC.Controls.Add(Me.GroupBox5)
        Me.tabPC.Location = New System.Drawing.Point(4, 22)
        Me.tabPC.Name = "tabPC"
        Me.tabPC.Size = New System.Drawing.Size(666, 288)
        Me.tabPC.TabIndex = 2
        Me.tabPC.Text = "Previous Customers Criteria"
        Me.tabPC.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.chFutureInterest)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.cboPCDateRange)
        Me.GroupBox5.Controls.Add(Me.numReferences)
        Me.GroupBox5.Controls.Add(Me.txtDate2PC)
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.txtApprovedDollars)
        Me.GroupBox5.Controls.Add(Me.txtDate1PC)
        Me.GroupBox5.Controls.Add(Me.chApprovedFor)
        Me.GroupBox5.Controls.Add(Me.dpDate1PC)
        Me.GroupBox5.Controls.Add(Me.numMonths)
        Me.GroupBox5.Controls.Add(Me.dpDate2PC)
        Me.GroupBox5.Controls.Add(Me.GroupBox6)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.chLoanSatisfied)
        Me.GroupBox5.Location = New System.Drawing.Point(14, 11)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(638, 237)
        Me.GroupBox5.TabIndex = 38
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "List Criteria"
        '
        'chFutureInterest
        '
        Me.chFutureInterest.AutoSize = True
        Me.chFutureInterest.Location = New System.Drawing.Point(18, 62)
        Me.chFutureInterest.Name = "chFutureInterest"
        Me.chFutureInterest.Size = New System.Drawing.Size(273, 17)
        Me.chFutureInterest.TabIndex = 35
        Me.chFutureInterest.Text = "Only Include Customers With Future Product Interest"
        Me.chFutureInterest.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(15, 29)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(68, 13)
        Me.Label18.TabIndex = 24
        Me.Label18.Text = "Sales Closed"
        '
        'cboPCDateRange
        '
        Me.cboPCDateRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPCDateRange.FormattingEnabled = True
        Me.cboPCDateRange.Location = New System.Drawing.Point(108, 26)
        Me.cboPCDateRange.Name = "cboPCDateRange"
        Me.cboPCDateRange.Size = New System.Drawing.Size(139, 21)
        Me.cboPCDateRange.TabIndex = 25
        '
        'numReferences
        '
        Me.numReferences.DecimalPlaces = 1
        Me.numReferences.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numReferences.Location = New System.Drawing.Point(276, 204)
        Me.numReferences.Maximum = New Decimal(New Integer() {60, 0, 0, 65536})
        Me.numReferences.Name = "numReferences"
        Me.numReferences.Size = New System.Drawing.Size(62, 20)
        Me.numReferences.TabIndex = 33
        '
        'txtDate2PC
        '
        Me.txtDate2PC.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDate2PC.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate2PC.Location = New System.Drawing.Point(500, 29)
        Me.txtDate2PC.Name = "txtDate2PC"
        Me.txtDate2PC.Size = New System.Drawing.Size(96, 19)
        Me.txtDate2PC.TabIndex = 31
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(10, 206)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(285, 13)
        Me.Label19.TabIndex = 32
        Me.Label19.Text = "Customers With A Reference Rating Of                Or Higher"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(253, 29)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(49, 13)
        Me.Label17.TabIndex = 26
        Me.Label17.Text = "Between"
        '
        'txtApprovedDollars
        '
        Me.txtApprovedDollars.Enabled = False
        Me.txtApprovedDollars.Location = New System.Drawing.Point(483, 155)
        Me.txtApprovedDollars.Name = "txtApprovedDollars"
        Me.txtApprovedDollars.Size = New System.Drawing.Size(149, 20)
        Me.txtApprovedDollars.TabIndex = 8
        '
        'txtDate1PC
        '
        Me.txtDate1PC.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDate1PC.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate1PC.Location = New System.Drawing.Point(324, 29)
        Me.txtDate1PC.Name = "txtDate1PC"
        Me.txtDate1PC.Size = New System.Drawing.Size(96, 19)
        Me.txtDate1PC.TabIndex = 30
        '
        'chApprovedFor
        '
        Me.chApprovedFor.AutoSize = True
        Me.chApprovedFor.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chApprovedFor.Location = New System.Drawing.Point(13, 158)
        Me.chApprovedFor.Name = "chApprovedFor"
        Me.chApprovedFor.Size = New System.Drawing.Size(418, 17)
        Me.chApprovedFor.TabIndex = 7
        Me.chApprovedFor.Text = "Show Customers With an Available Loan Balance of $                               " & _
    "  Or More"
        Me.chApprovedFor.UseVisualStyleBackColor = True
        '
        'dpDate1PC
        '
        Me.dpDate1PC.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpDate1PC.Location = New System.Drawing.Point(322, 27)
        Me.dpDate1PC.Name = "dpDate1PC"
        Me.dpDate1PC.Size = New System.Drawing.Size(133, 20)
        Me.dpDate1PC.TabIndex = 27
        Me.dpDate1PC.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'numMonths
        '
        Me.numMonths.Enabled = False
        Me.numMonths.Location = New System.Drawing.Point(390, 118)
        Me.numMonths.Name = "numMonths"
        Me.numMonths.Size = New System.Drawing.Size(51, 20)
        Me.numMonths.TabIndex = 5
        '
        'dpDate2PC
        '
        Me.dpDate2PC.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpDate2PC.Location = New System.Drawing.Point(498, 27)
        Me.dpDate2PC.Name = "dpDate2PC"
        Me.dpDate2PC.Size = New System.Drawing.Size(133, 20)
        Me.dpDate2PC.TabIndex = 29
        Me.dpDate2PC.Value = New Date(2100, 1, 1, 0, 0, 0, 0)
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.rdoCash)
        Me.GroupBox6.Controls.Add(Me.rdoAll)
        Me.GroupBox6.Controls.Add(Me.rdoLoan)
        Me.GroupBox6.Location = New System.Drawing.Point(13, 94)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(239, 47)
        Me.GroupBox6.TabIndex = 3
        Me.GroupBox6.TabStop = False
        '
        'rdoCash
        '
        Me.rdoCash.AutoSize = True
        Me.rdoCash.Location = New System.Drawing.Point(17, 20)
        Me.rdoCash.Name = "rdoCash"
        Me.rdoCash.Size = New System.Drawing.Size(49, 17)
        Me.rdoCash.TabIndex = 0
        Me.rdoCash.Text = "Cash"
        Me.rdoCash.UseVisualStyleBackColor = True
        '
        'rdoAll
        '
        Me.rdoAll.AutoSize = True
        Me.rdoAll.Checked = True
        Me.rdoAll.Location = New System.Drawing.Point(180, 20)
        Me.rdoAll.Name = "rdoAll"
        Me.rdoAll.Size = New System.Drawing.Size(36, 17)
        Me.rdoAll.TabIndex = 2
        Me.rdoAll.TabStop = True
        Me.rdoAll.Text = "All"
        Me.rdoAll.UseVisualStyleBackColor = True
        '
        'rdoLoan
        '
        Me.rdoLoan.AutoSize = True
        Me.rdoLoan.Location = New System.Drawing.Point(89, 20)
        Me.rdoLoan.Name = "rdoLoan"
        Me.rdoLoan.Size = New System.Drawing.Size(63, 17)
        Me.rdoLoan.TabIndex = 1
        Me.rdoLoan.Text = "Finance"
        Me.rdoLoan.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(461, 29)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(26, 13)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "And"
        '
        'chLoanSatisfied
        '
        Me.chLoanSatisfied.AutoSize = True
        Me.chLoanSatisfied.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chLoanSatisfied.Location = New System.Drawing.Point(296, 89)
        Me.chLoanSatisfied.Name = "chLoanSatisfied"
        Me.chLoanSatisfied.Size = New System.Drawing.Size(236, 43)
        Me.chLoanSatisfied.TabIndex = 6
        Me.chLoanSatisfied.Text = "Show Loans That Have Been Satisfied Or" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Are Within             Months Of Being " & _
    "Satisfied"
        Me.chLoanSatisfied.UseVisualStyleBackColor = True
        '
        'tabMarketers
        '
        Me.tabMarketers.Controls.Add(Me.GroupBox8)
        Me.tabMarketers.Location = New System.Drawing.Point(4, 22)
        Me.tabMarketers.Name = "tabMarketers"
        Me.tabMarketers.Size = New System.Drawing.Size(666, 288)
        Me.tabMarketers.TabIndex = 7
        Me.tabMarketers.Text = "Marketers"
        Me.tabMarketers.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.uncheckMarketers)
        Me.GroupBox8.Controls.Add(Me.checkMarketers)
        Me.GroupBox8.Controls.Add(Me.chlstMarketers)
        Me.GroupBox8.Location = New System.Drawing.Point(14, 11)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(638, 237)
        Me.GroupBox8.TabIndex = 39
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Marketers"
        '
        'uncheckMarketers
        '
        Me.uncheckMarketers.AutoSize = True
        Me.uncheckMarketers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.uncheckMarketers.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uncheckMarketers.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.uncheckMarketers.Location = New System.Drawing.Point(323, 204)
        Me.uncheckMarketers.Name = "uncheckMarketers"
        Me.uncheckMarketers.Size = New System.Drawing.Size(83, 16)
        Me.uncheckMarketers.TabIndex = 9
        Me.uncheckMarketers.Text = "Uncheck All"
        '
        'checkMarketers
        '
        Me.checkMarketers.AutoSize = True
        Me.checkMarketers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.checkMarketers.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkMarketers.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.checkMarketers.Location = New System.Drawing.Point(232, 204)
        Me.checkMarketers.Name = "checkMarketers"
        Me.checkMarketers.Size = New System.Drawing.Size(67, 16)
        Me.checkMarketers.TabIndex = 8
        Me.checkMarketers.Text = "Check All"
        '
        'chlstMarketers
        '
        Me.chlstMarketers.ColumnWidth = 303
        Me.chlstMarketers.FormattingEnabled = True
        Me.chlstMarketers.Location = New System.Drawing.Point(18, 22)
        Me.chlstMarketers.MultiColumn = True
        Me.chlstMarketers.Name = "chlstMarketers"
        Me.chlstMarketers.Size = New System.Drawing.Size(607, 154)
        Me.chlstMarketers.TabIndex = 7
        '
        'tabProducts
        '
        Me.tabProducts.Controls.Add(Me.GroupBox4)
        Me.tabProducts.Location = New System.Drawing.Point(4, 22)
        Me.tabProducts.Name = "tabProducts"
        Me.tabProducts.Size = New System.Drawing.Size(666, 288)
        Me.tabProducts.TabIndex = 5
        Me.tabProducts.Text = "Products"
        Me.tabProducts.UseVisualStyleBackColor = True
        '
        'btnDown
        '
        Me.btnDown.Image = CType(resources.GetObject("btnDown.Image"), System.Drawing.Image)
        Me.btnDown.Location = New System.Drawing.Point(23, 100)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(26, 38)
        Me.btnDown.TabIndex = 3
        Me.btnDown.UseVisualStyleBackColor = True
        '
        'btnUp
        '
        Me.btnUp.Image = CType(resources.GetObject("btnUp.Image"), System.Drawing.Image)
        Me.btnUp.Location = New System.Drawing.Point(23, 56)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(26, 38)
        Me.btnUp.TabIndex = 2
        Me.btnUp.UseVisualStyleBackColor = True
        '
        'frmPCList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 377)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmPCList"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Create Previous Customer List"
        Me.tabGeo.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.numMiles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSort.ResumeLayout(False)
        Me.tabSort.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        CType(Me.epGeo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tabPC.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.numReferences, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numMonths, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.tabMarketers.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.tabProducts.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnUncheckProducts As System.Windows.Forms.Label
    Friend WithEvents chlstProducts As System.Windows.Forms.CheckedListBox
    Friend WithEvents tabGeo As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cboStateSelection As System.Windows.Forms.ComboBox
    Friend WithEvents lblStateSelect As System.Windows.Forms.Label
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents btnUncheckZip As System.Windows.Forms.Label
    Friend WithEvents btnCheckZip As System.Windows.Forms.Label
    Friend WithEvents chlstZipCity As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents numMiles As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtZipCity As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents rdoCity As System.Windows.Forms.RadioButton
    Friend WithEvents rdoZip As System.Windows.Forms.RadioButton
    Friend WithEvents btnCheckProducts As System.Windows.Forms.Label
    Friend WithEvents tabSort As System.Windows.Forms.TabPage
    Friend WithEvents btnUnCheckOrderBy As System.Windows.Forms.Label
    Friend WithEvents btnCheckOrderBy As System.Windows.Forms.Label
    Friend WithEvents btnDown As System.Windows.Forms.Button
    Friend WithEvents btnUp As System.Windows.Forms.Button
    Friend WithEvents chlstOrderBy As System.Windows.Forms.CheckedListBox
    Friend WithEvents chGroupBy As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents epGeo As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabPC As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents chFutureInterest As System.Windows.Forms.CheckBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cboPCDateRange As System.Windows.Forms.ComboBox
    Friend WithEvents numReferences As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtDate2PC As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtApprovedDollars As System.Windows.Forms.TextBox
    Friend WithEvents txtDate1PC As System.Windows.Forms.TextBox
    Friend WithEvents chApprovedFor As System.Windows.Forms.CheckBox
    Friend WithEvents dpDate1PC As System.Windows.Forms.DateTimePicker
    Friend WithEvents numMonths As System.Windows.Forms.NumericUpDown
    Friend WithEvents dpDate2PC As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents rdoCash As System.Windows.Forms.RadioButton
    Friend WithEvents rdoAll As System.Windows.Forms.RadioButton
    Friend WithEvents rdoLoan As System.Windows.Forms.RadioButton
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents chLoanSatisfied As System.Windows.Forms.CheckBox
    Friend WithEvents tabMarketers As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents uncheckMarketers As System.Windows.Forms.Label
    Friend WithEvents checkMarketers As System.Windows.Forms.Label
    Friend WithEvents chlstMarketers As System.Windows.Forms.CheckedListBox
    Friend WithEvents tabProducts As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents epForm As System.Windows.Forms.ErrorProvider
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents BackgroundWorkerCity As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorkerZip As System.ComponentModel.BackgroundWorker
End Class
