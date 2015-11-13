<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreateList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCreateList))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabDate = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtGenerated = New System.Windows.Forms.TextBox()
        Me.dpGenerated = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chWeekdays = New System.Windows.Forms.CheckBox()
        Me.txtTimeTo = New System.Windows.Forms.TextBox()
        Me.txtTimeFrom = New System.Windows.Forms.TextBox()
        Me.tpTo = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tpFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTo = New System.Windows.Forms.TextBox()
        Me.txtFrom = New System.Windows.Forms.TextBox()
        Me.dpTo = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dpFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboDateRange = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabMarketers = New System.Windows.Forms.TabPage()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.uncheckMarketers = New System.Windows.Forms.Label()
        Me.checkMarketers = New System.Windows.Forms.Label()
        Me.chlstMarketers = New System.Windows.Forms.CheckedListBox()
        Me.tabProducts = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnUncheckProducts = New System.Windows.Forms.Label()
        Me.btnCheckProducts = New System.Windows.Forms.Label()
        Me.chlstProducts = New System.Windows.Forms.CheckedListBox()
        Me.tabGeo = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
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
        Me.tabWC = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkWC = New System.Windows.Forms.CheckBox()
        Me.btnUncheckWC = New System.Windows.Forms.Label()
        Me.btnCheckWC = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chlstWC = New System.Windows.Forms.CheckedListBox()
        Me.tabPC = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.chFutureInterest = New System.Windows.Forms.CheckBox()
        Me.chPC = New System.Windows.Forms.CheckBox()
        Me.numReferences = New System.Windows.Forms.NumericUpDown()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtDate2PC = New System.Windows.Forms.TextBox()
        Me.txtDate1PC = New System.Windows.Forms.TextBox()
        Me.dpDate2PC = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.dpDate1PC = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cboPCDateRange = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtApprovedDollars = New System.Windows.Forms.TextBox()
        Me.chApprovedFor = New System.Windows.Forms.CheckBox()
        Me.numMonths = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.rdoCash = New System.Windows.Forms.RadioButton()
        Me.rdoAll = New System.Windows.Forms.RadioButton()
        Me.rdoLoan = New System.Windows.Forms.RadioButton()
        Me.chLoanSatisfied = New System.Windows.Forms.CheckBox()
        Me.tabRecovery = New System.Windows.Forms.TabPage()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.txtQuoted = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.numPar = New System.Windows.Forms.NumericUpDown()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.btnUncheckRehash = New System.Windows.Forms.Label()
        Me.btnCheckRehash = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.chlstRehash = New System.Windows.Forms.CheckedListBox()
        Me.chRehash = New System.Windows.Forms.CheckBox()
        Me.tabSort = New System.Windows.Forms.TabPage()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.epGeo = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.epForm = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cboStateSelection = New System.Windows.Forms.ComboBox()
        Me.lblStateSelection = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.tabDate.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tabMarketers.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.tabProducts.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.tabGeo.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.numMiles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabWC.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.tabPC.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.numReferences, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numMonths, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.tabRecovery.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.numPar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSort.SuspendLayout()
        CType(Me.epGeo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabDate)
        Me.TabControl1.Controls.Add(Me.tabMarketers)
        Me.TabControl1.Controls.Add(Me.tabProducts)
        Me.TabControl1.Controls.Add(Me.tabGeo)
        Me.TabControl1.Controls.Add(Me.tabWC)
        Me.TabControl1.Controls.Add(Me.tabPC)
        Me.TabControl1.Controls.Add(Me.tabRecovery)
        Me.TabControl1.Controls.Add(Me.tabSort)
        Me.TabControl1.ImageList = Me.ImageList1
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.ShowToolTips = True
        Me.TabControl1.Size = New System.Drawing.Size(674, 314)
        Me.TabControl1.TabIndex = 38
        '
        'tabDate
        '
        Me.tabDate.Controls.Add(Me.GroupBox1)
        Me.epForm.SetIconAlignment(Me.tabDate, System.Windows.Forms.ErrorIconAlignment.TopLeft)
        Me.tabDate.Location = New System.Drawing.Point(4, 46)
        Me.tabDate.Name = "tabDate"
        Me.tabDate.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDate.Size = New System.Drawing.Size(666, 264)
        Me.tabDate.TabIndex = 0
        Me.tabDate.Text = "Date/Time"
        Me.tabDate.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtGenerated)
        Me.GroupBox1.Controls.Add(Me.dpGenerated)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.chWeekdays)
        Me.GroupBox1.Controls.Add(Me.txtTimeTo)
        Me.GroupBox1.Controls.Add(Me.txtTimeFrom)
        Me.GroupBox1.Controls.Add(Me.tpTo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.tpFrom)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtTo)
        Me.GroupBox1.Controls.Add(Me.txtFrom)
        Me.GroupBox1.Controls.Add(Me.dpTo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dpFrom)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cboDateRange)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(638, 237)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Date/Time Criteria"
        '
        'txtGenerated
        '
        Me.txtGenerated.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtGenerated.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGenerated.Location = New System.Drawing.Point(172, 41)
        Me.txtGenerated.Name = "txtGenerated"
        Me.txtGenerated.Size = New System.Drawing.Size(96, 19)
        Me.txtGenerated.TabIndex = 33
        '
        'dpGenerated
        '
        Me.dpGenerated.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpGenerated.Location = New System.Drawing.Point(170, 39)
        Me.dpGenerated.Name = "dpGenerated"
        Me.dpGenerated.Size = New System.Drawing.Size(133, 23)
        Me.dpGenerated.TabIndex = 32
        Me.dpGenerated.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(150, 16)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Appt Generated After"
        '
        'chWeekdays
        '
        Me.chWeekdays.AutoSize = True
        Me.chWeekdays.Location = New System.Drawing.Point(446, 129)
        Me.chWeekdays.Name = "chWeekdays"
        Me.chWeekdays.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chWeekdays.Size = New System.Drawing.Size(168, 20)
        Me.chWeekdays.TabIndex = 30
        Me.chWeekdays.Text = "Weekday Appts. Only"
        Me.chWeekdays.UseVisualStyleBackColor = True
        '
        'txtTimeTo
        '
        Me.txtTimeTo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTimeTo.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimeTo.Location = New System.Drawing.Point(299, 127)
        Me.txtTimeTo.Name = "txtTimeTo"
        Me.txtTimeTo.Size = New System.Drawing.Size(95, 19)
        Me.txtTimeTo.TabIndex = 29
        '
        'txtTimeFrom
        '
        Me.txtTimeFrom.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTimeFrom.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimeFrom.Location = New System.Drawing.Point(147, 127)
        Me.txtTimeFrom.Name = "txtTimeFrom"
        Me.txtTimeFrom.Size = New System.Drawing.Size(95, 19)
        Me.txtTimeFrom.TabIndex = 28
        '
        'tpTo
        '
        Me.tpTo.CustomFormat = "h:mm tt"
        Me.tpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tpTo.Location = New System.Drawing.Point(296, 125)
        Me.tpTo.Name = "tpTo"
        Me.tpTo.ShowUpDown = True
        Me.tpTo.Size = New System.Drawing.Size(116, 23)
        Me.tpTo.TabIndex = 27
        Me.tpTo.Value = New Date(1900, 1, 1, 23, 59, 0, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(267, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 16)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "To"
        '
        'tpFrom
        '
        Me.tpFrom.CustomFormat = "h:mm tt"
        Me.tpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tpFrom.Location = New System.Drawing.Point(145, 125)
        Me.tpFrom.Name = "tpFrom"
        Me.tpFrom.ShowUpDown = True
        Me.tpFrom.Size = New System.Drawing.Size(116, 23)
        Me.tpFrom.TabIndex = 25
        Me.tpFrom.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 16)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Appt. Times From"
        '
        'txtTo
        '
        Me.txtTo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTo.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTo.Location = New System.Drawing.Point(494, 81)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.Size = New System.Drawing.Size(96, 19)
        Me.txtTo.TabIndex = 23
        '
        'txtFrom
        '
        Me.txtFrom.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFrom.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFrom.Location = New System.Drawing.Point(324, 81)
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.Size = New System.Drawing.Size(96, 19)
        Me.txtFrom.TabIndex = 22
        '
        'dpTo
        '
        Me.dpTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpTo.Location = New System.Drawing.Point(492, 79)
        Me.dpTo.Name = "dpTo"
        Me.dpTo.Size = New System.Drawing.Size(133, 23)
        Me.dpTo.TabIndex = 21
        Me.dpTo.Value = New Date(2100, 1, 1, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(461, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 16)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "To"
        '
        'dpFrom
        '
        Me.dpFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpFrom.Location = New System.Drawing.Point(322, 79)
        Me.dpFrom.Name = "dpFrom"
        Me.dpFrom.Size = New System.Drawing.Size(133, 23)
        Me.dpFrom.TabIndex = 19
        Me.dpFrom.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(276, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 16)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "From"
        '
        'cboDateRange
        '
        Me.cboDateRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDateRange.FormattingEnabled = True
        Me.cboDateRange.Location = New System.Drawing.Point(108, 78)
        Me.cboDateRange.Name = "cboDateRange"
        Me.cboDateRange.Size = New System.Drawing.Size(162, 24)
        Me.cboDateRange.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 16)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Appt. Dates"
        '
        'tabMarketers
        '
        Me.tabMarketers.Controls.Add(Me.GroupBox8)
        Me.tabMarketers.Location = New System.Drawing.Point(4, 46)
        Me.tabMarketers.Name = "tabMarketers"
        Me.tabMarketers.Size = New System.Drawing.Size(666, 264)
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
        Me.epGeo.SetIconAlignment(Me.chlstMarketers, System.Windows.Forms.ErrorIconAlignment.TopLeft)
        Me.epForm.SetIconAlignment(Me.chlstMarketers, System.Windows.Forms.ErrorIconAlignment.TopLeft)
        Me.epForm.SetIconPadding(Me.chlstMarketers, 30)
        Me.chlstMarketers.Location = New System.Drawing.Point(18, 22)
        Me.chlstMarketers.MultiColumn = True
        Me.chlstMarketers.Name = "chlstMarketers"
        Me.chlstMarketers.Size = New System.Drawing.Size(607, 166)
        Me.chlstMarketers.TabIndex = 7
        '
        'tabProducts
        '
        Me.tabProducts.Controls.Add(Me.GroupBox4)
        Me.epForm.SetIconAlignment(Me.tabProducts, System.Windows.Forms.ErrorIconAlignment.TopLeft)
        Me.epForm.SetIconPadding(Me.tabProducts, -200)
        Me.tabProducts.Location = New System.Drawing.Point(4, 46)
        Me.tabProducts.Name = "tabProducts"
        Me.tabProducts.Size = New System.Drawing.Size(666, 264)
        Me.tabProducts.TabIndex = 5
        Me.tabProducts.Text = "Products"
        Me.tabProducts.UseVisualStyleBackColor = True
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
        'chlstProducts
        '
        Me.chlstProducts.FormattingEnabled = True
        Me.epGeo.SetIconAlignment(Me.chlstProducts, System.Windows.Forms.ErrorIconAlignment.TopLeft)
        Me.epForm.SetIconAlignment(Me.chlstProducts, System.Windows.Forms.ErrorIconAlignment.TopLeft)
        Me.epForm.SetIconPadding(Me.chlstProducts, 30)
        Me.chlstProducts.Location = New System.Drawing.Point(18, 22)
        Me.chlstProducts.MultiColumn = True
        Me.chlstProducts.Name = "chlstProducts"
        Me.chlstProducts.Size = New System.Drawing.Size(607, 166)
        Me.chlstProducts.TabIndex = 7
        '
        'tabGeo
        '
        Me.tabGeo.Controls.Add(Me.GroupBox3)
        Me.tabGeo.Location = New System.Drawing.Point(4, 46)
        Me.tabGeo.Name = "tabGeo"
        Me.tabGeo.Size = New System.Drawing.Size(666, 264)
        Me.tabGeo.TabIndex = 4
        Me.tabGeo.Text = "Geography"
        Me.tabGeo.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblStateSelection)
        Me.GroupBox3.Controls.Add(Me.cboStateSelection)
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
        Me.chlstZipCity.Size = New System.Drawing.Size(213, 130)
        Me.chlstZipCity.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(227, 133)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(179, 16)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Miles of Starting Zip Code"
        '
        'numMiles
        '
        Me.numMiles.Location = New System.Drawing.Point(179, 131)
        Me.numMiles.Name = "numMiles"
        Me.numMiles.Size = New System.Drawing.Size(42, 23)
        Me.numMiles.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 133)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(158, 16)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Show Zip Codes within"
        '
        'txtZipCity
        '
        Me.txtZipCity.Location = New System.Drawing.Point(191, 67)
        Me.txtZipCity.Name = "txtZipCity"
        Me.txtZipCity.Size = New System.Drawing.Size(137, 23)
        Me.txtZipCity.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 70)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(170, 16)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Enter Starting Zip Code:"
        '
        'rdoCity
        '
        Me.rdoCity.AutoSize = True
        Me.rdoCity.Location = New System.Drawing.Point(235, 35)
        Me.rdoCity.Name = "rdoCity"
        Me.rdoCity.Size = New System.Drawing.Size(171, 20)
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
        Me.rdoZip.Size = New System.Drawing.Size(203, 20)
        Me.rdoZip.TabIndex = 0
        Me.rdoZip.TabStop = True
        Me.rdoZip.Text = "Search by Zip Code Radius"
        Me.rdoZip.UseVisualStyleBackColor = True
        '
        'tabWC
        '
        Me.tabWC.Controls.Add(Me.GroupBox2)
        Me.tabWC.Location = New System.Drawing.Point(4, 46)
        Me.tabWC.Name = "tabWC"
        Me.tabWC.Padding = New System.Windows.Forms.Padding(3)
        Me.tabWC.Size = New System.Drawing.Size(666, 264)
        Me.tabWC.TabIndex = 1
        Me.tabWC.Text = "Warm Calling"
        Me.tabWC.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkWC)
        Me.GroupBox2.Controls.Add(Me.btnUncheckWC)
        Me.GroupBox2.Controls.Add(Me.btnCheckWC)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.chlstWC)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(638, 237)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Warm Calling Criteria"
        '
        'chkWC
        '
        Me.chkWC.AutoSize = True
        Me.chkWC.Location = New System.Drawing.Point(13, 28)
        Me.chkWC.Name = "chkWC"
        Me.chkWC.Size = New System.Drawing.Size(163, 20)
        Me.chkWC.TabIndex = 35
        Me.chkWC.Text = "Include Warm Calling"
        Me.chkWC.UseVisualStyleBackColor = True
        '
        'btnUncheckWC
        '
        Me.btnUncheckWC.AutoSize = True
        Me.btnUncheckWC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUncheckWC.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUncheckWC.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnUncheckWC.Location = New System.Drawing.Point(323, 205)
        Me.btnUncheckWC.Name = "btnUncheckWC"
        Me.btnUncheckWC.Size = New System.Drawing.Size(83, 16)
        Me.btnUncheckWC.TabIndex = 27
        Me.btnUncheckWC.Text = "Uncheck All"
        '
        'btnCheckWC
        '
        Me.btnCheckWC.AutoSize = True
        Me.btnCheckWC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCheckWC.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckWC.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnCheckWC.Location = New System.Drawing.Point(232, 205)
        Me.btnCheckWC.Name = "btnCheckWC"
        Me.btnCheckWC.Size = New System.Drawing.Size(67, 16)
        Me.btnCheckWC.TabIndex = 26
        Me.btnCheckWC.Text = "Check All"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(205, 16)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Last Known Marketing Results"
        '
        'chlstWC
        '
        Me.chlstWC.Enabled = False
        Me.chlstWC.FormattingEnabled = True
        Me.chlstWC.Items.AddRange(New Object() {"Unconfirmed", "Called and Cancelled", "Reset", "Not Hit", "Not Issued"})
        Me.chlstWC.Location = New System.Drawing.Point(11, 79)
        Me.chlstWC.Name = "chlstWC"
        Me.chlstWC.Size = New System.Drawing.Size(617, 112)
        Me.chlstWC.TabIndex = 17
        '
        'tabPC
        '
        Me.tabPC.Controls.Add(Me.GroupBox5)
        Me.tabPC.Location = New System.Drawing.Point(4, 46)
        Me.tabPC.Name = "tabPC"
        Me.tabPC.Size = New System.Drawing.Size(666, 264)
        Me.tabPC.TabIndex = 2
        Me.tabPC.Text = "Previous Customers"
        Me.tabPC.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.chFutureInterest)
        Me.GroupBox5.Controls.Add(Me.chPC)
        Me.GroupBox5.Controls.Add(Me.numReferences)
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Controls.Add(Me.txtDate2PC)
        Me.GroupBox5.Controls.Add(Me.txtDate1PC)
        Me.GroupBox5.Controls.Add(Me.dpDate2PC)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.dpDate1PC)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.cboPCDateRange)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.txtApprovedDollars)
        Me.GroupBox5.Controls.Add(Me.chApprovedFor)
        Me.GroupBox5.Controls.Add(Me.numMonths)
        Me.GroupBox5.Controls.Add(Me.GroupBox6)
        Me.GroupBox5.Controls.Add(Me.chLoanSatisfied)
        Me.GroupBox5.Location = New System.Drawing.Point(14, 11)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(638, 237)
        Me.GroupBox5.TabIndex = 38
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Previous Customers"
        '
        'chFutureInterest
        '
        Me.chFutureInterest.AutoSize = True
        Me.chFutureInterest.Enabled = False
        Me.chFutureInterest.Location = New System.Drawing.Point(246, 18)
        Me.chFutureInterest.Name = "chFutureInterest"
        Me.chFutureInterest.Size = New System.Drawing.Size(380, 20)
        Me.chFutureInterest.TabIndex = 35
        Me.chFutureInterest.Text = "Only Include Customers With Future Product Interest"
        Me.chFutureInterest.UseVisualStyleBackColor = True
        '
        'chPC
        '
        Me.chPC.AutoSize = True
        Me.chPC.Location = New System.Drawing.Point(13, 28)
        Me.chPC.Name = "chPC"
        Me.chPC.Size = New System.Drawing.Size(209, 20)
        Me.chPC.TabIndex = 34
        Me.chPC.Text = "Include Previous Customers"
        Me.chPC.UseVisualStyleBackColor = True
        '
        'numReferences
        '
        Me.numReferences.DecimalPlaces = 1
        Me.numReferences.Enabled = False
        Me.numReferences.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numReferences.Location = New System.Drawing.Point(276, 204)
        Me.numReferences.Maximum = New Decimal(New Integer() {60, 0, 0, 65536})
        Me.numReferences.Name = "numReferences"
        Me.numReferences.Size = New System.Drawing.Size(62, 23)
        Me.numReferences.TabIndex = 33
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Enabled = False
        Me.Label19.Location = New System.Drawing.Point(10, 206)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(404, 16)
        Me.Label19.TabIndex = 32
        Me.Label19.Text = "Customers With A Reference Rating Of                Or Higher"
        '
        'txtDate2PC
        '
        Me.txtDate2PC.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDate2PC.Enabled = False
        Me.txtDate2PC.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate2PC.Location = New System.Drawing.Point(495, 166)
        Me.txtDate2PC.Name = "txtDate2PC"
        Me.txtDate2PC.Size = New System.Drawing.Size(96, 19)
        Me.txtDate2PC.TabIndex = 31
        '
        'txtDate1PC
        '
        Me.txtDate1PC.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDate1PC.Enabled = False
        Me.txtDate1PC.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate1PC.Location = New System.Drawing.Point(319, 166)
        Me.txtDate1PC.Name = "txtDate1PC"
        Me.txtDate1PC.Size = New System.Drawing.Size(96, 19)
        Me.txtDate1PC.TabIndex = 30
        '
        'dpDate2PC
        '
        Me.dpDate2PC.Enabled = False
        Me.dpDate2PC.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpDate2PC.Location = New System.Drawing.Point(493, 164)
        Me.dpDate2PC.Name = "dpDate2PC"
        Me.dpDate2PC.Size = New System.Drawing.Size(133, 23)
        Me.dpDate2PC.TabIndex = 29
        Me.dpDate2PC.Value = New Date(2100, 1, 1, 0, 0, 0, 0)
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Enabled = False
        Me.Label16.Location = New System.Drawing.Point(456, 166)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(33, 16)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "And"
        '
        'dpDate1PC
        '
        Me.dpDate1PC.Enabled = False
        Me.dpDate1PC.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpDate1PC.Location = New System.Drawing.Point(317, 164)
        Me.dpDate1PC.Name = "dpDate1PC"
        Me.dpDate1PC.Size = New System.Drawing.Size(133, 23)
        Me.dpDate1PC.TabIndex = 27
        Me.dpDate1PC.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Enabled = False
        Me.Label17.Location = New System.Drawing.Point(248, 166)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(65, 16)
        Me.Label17.TabIndex = 26
        Me.Label17.Text = "Between"
        '
        'cboPCDateRange
        '
        Me.cboPCDateRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPCDateRange.Enabled = False
        Me.cboPCDateRange.FormattingEnabled = True
        Me.cboPCDateRange.Location = New System.Drawing.Point(103, 163)
        Me.cboPCDateRange.Name = "cboPCDateRange"
        Me.cboPCDateRange.Size = New System.Drawing.Size(139, 24)
        Me.cboPCDateRange.TabIndex = 25
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Enabled = False
        Me.Label18.Location = New System.Drawing.Point(10, 166)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(91, 16)
        Me.Label18.TabIndex = 24
        Me.Label18.Text = "Sales Closed"
        '
        'txtApprovedDollars
        '
        Me.txtApprovedDollars.Enabled = False
        Me.txtApprovedDollars.Location = New System.Drawing.Point(335, 116)
        Me.txtApprovedDollars.Name = "txtApprovedDollars"
        Me.txtApprovedDollars.Size = New System.Drawing.Size(130, 23)
        Me.txtApprovedDollars.TabIndex = 8
        '
        'chApprovedFor
        '
        Me.chApprovedFor.AutoSize = True
        Me.chApprovedFor.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chApprovedFor.Enabled = False
        Me.chApprovedFor.Location = New System.Drawing.Point(13, 118)
        Me.chApprovedFor.Name = "chApprovedFor"
        Me.chApprovedFor.Size = New System.Drawing.Size(531, 20)
        Me.chApprovedFor.TabIndex = 7
        Me.chApprovedFor.Text = "Show Customers Previously Approved For $                                 Or More"
        Me.chApprovedFor.UseVisualStyleBackColor = True
        '
        'numMonths
        '
        Me.numMonths.Enabled = False
        Me.numMonths.Location = New System.Drawing.Point(390, 78)
        Me.numMonths.Name = "numMonths"
        Me.numMonths.Size = New System.Drawing.Size(51, 23)
        Me.numMonths.TabIndex = 5
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.rdoCash)
        Me.GroupBox6.Controls.Add(Me.rdoAll)
        Me.GroupBox6.Controls.Add(Me.rdoLoan)
        Me.GroupBox6.Enabled = False
        Me.GroupBox6.Location = New System.Drawing.Point(13, 54)
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
        Me.rdoCash.Size = New System.Drawing.Size(58, 20)
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
        Me.rdoAll.Size = New System.Drawing.Size(41, 20)
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
        Me.rdoLoan.Size = New System.Drawing.Size(77, 20)
        Me.rdoLoan.TabIndex = 1
        Me.rdoLoan.Text = "Finance"
        Me.rdoLoan.UseVisualStyleBackColor = True
        '
        'chLoanSatisfied
        '
        Me.chLoanSatisfied.AutoSize = True
        Me.chLoanSatisfied.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chLoanSatisfied.Enabled = False
        Me.chLoanSatisfied.Location = New System.Drawing.Point(296, 49)
        Me.chLoanSatisfied.Name = "chLoanSatisfied"
        Me.chLoanSatisfied.Size = New System.Drawing.Size(330, 52)
        Me.chLoanSatisfied.TabIndex = 6
        Me.chLoanSatisfied.Text = "Show Loans That Have Been Satisfied Or" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Are Within             Months Of Being " & _
    "Satisfied"
        Me.chLoanSatisfied.UseVisualStyleBackColor = True
        '
        'tabRecovery
        '
        Me.tabRecovery.Controls.Add(Me.GroupBox7)
        Me.tabRecovery.Location = New System.Drawing.Point(4, 46)
        Me.tabRecovery.Name = "tabRecovery"
        Me.tabRecovery.Size = New System.Drawing.Size(666, 264)
        Me.tabRecovery.TabIndex = 3
        Me.tabRecovery.Text = "Recovery/Rehash"
        Me.tabRecovery.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.txtQuoted)
        Me.GroupBox7.Controls.Add(Me.Label27)
        Me.GroupBox7.Controls.Add(Me.numPar)
        Me.GroupBox7.Controls.Add(Me.Label26)
        Me.GroupBox7.Controls.Add(Me.btnUncheckRehash)
        Me.GroupBox7.Controls.Add(Me.btnCheckRehash)
        Me.GroupBox7.Controls.Add(Me.Label25)
        Me.GroupBox7.Controls.Add(Me.chlstRehash)
        Me.GroupBox7.Controls.Add(Me.chRehash)
        Me.GroupBox7.Location = New System.Drawing.Point(14, 11)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(638, 237)
        Me.GroupBox7.TabIndex = 39
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Recovery/Rehash"
        '
        'txtQuoted
        '
        Me.txtQuoted.Enabled = False
        Me.txtQuoted.Location = New System.Drawing.Point(122, 111)
        Me.txtQuoted.Name = "txtQuoted"
        Me.txtQuoted.Size = New System.Drawing.Size(100, 23)
        Me.txtQuoted.TabIndex = 42
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(10, 114)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(283, 16)
        Me.Label27.TabIndex = 41
        Me.Label27.Text = "Quoted Price $                         Or More"
        '
        'numPar
        '
        Me.numPar.Enabled = False
        Me.numPar.Location = New System.Drawing.Point(109, 63)
        Me.numPar.Name = "numPar"
        Me.numPar.Size = New System.Drawing.Size(51, 23)
        Me.numPar.TabIndex = 40
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(10, 65)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(310, 16)
        Me.Label26.TabIndex = 39
        Me.Label26.Text = "Quoted Price               % Or More Above Par"
        '
        'btnUncheckRehash
        '
        Me.btnUncheckRehash.AutoSize = True
        Me.btnUncheckRehash.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUncheckRehash.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUncheckRehash.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnUncheckRehash.Location = New System.Drawing.Point(516, 207)
        Me.btnUncheckRehash.Name = "btnUncheckRehash"
        Me.btnUncheckRehash.Size = New System.Drawing.Size(83, 16)
        Me.btnUncheckRehash.TabIndex = 38
        Me.btnUncheckRehash.Text = "Uncheck All"
        '
        'btnCheckRehash
        '
        Me.btnCheckRehash.AutoSize = True
        Me.btnCheckRehash.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCheckRehash.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckRehash.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnCheckRehash.Location = New System.Drawing.Point(425, 207)
        Me.btnCheckRehash.Name = "btnCheckRehash"
        Me.btnCheckRehash.Size = New System.Drawing.Size(67, 16)
        Me.btnCheckRehash.TabIndex = 37
        Me.btnCheckRehash.Text = "Check All"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(406, 28)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(205, 16)
        Me.Label25.TabIndex = 36
        Me.Label25.Text = "Last Known Marketing Results"
        '
        'chlstRehash
        '
        Me.chlstRehash.Enabled = False
        Me.chlstRehash.FormattingEnabled = True
        Me.chlstRehash.Items.AddRange(New Object() {"Unconfirmed", "Called and Cancelled", "Reset", "Not Hit", "Not Issued", "Demo/No Sale", "Recission Cancel"})
        Me.chlstRehash.Location = New System.Drawing.Point(409, 51)
        Me.chlstRehash.Name = "chlstRehash"
        Me.chlstRehash.Size = New System.Drawing.Size(210, 148)
        Me.chlstRehash.TabIndex = 35
        '
        'chRehash
        '
        Me.chRehash.AutoSize = True
        Me.chRehash.Location = New System.Drawing.Point(13, 28)
        Me.chRehash.Name = "chRehash"
        Me.chRehash.Size = New System.Drawing.Size(194, 20)
        Me.chRehash.TabIndex = 34
        Me.chRehash.Text = "Include Recovery/Rehash"
        Me.chRehash.UseVisualStyleBackColor = True
        '
        'tabSort
        '
        Me.tabSort.Controls.Add(Me.RichTextBox1)
        Me.tabSort.Location = New System.Drawing.Point(4, 46)
        Me.tabSort.Name = "tabSort"
        Me.tabSort.Size = New System.Drawing.Size(666, 264)
        Me.tabSort.TabIndex = 6
        Me.tabSort.Text = "Sort By/Group By"
        Me.tabSort.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(29, 24)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(555, 146)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "danger.ico")
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClear.Location = New System.Drawing.Point(165, 347)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(183, 23)
        Me.btnClear.TabIndex = 39
        Me.btnClear.Text = "Clear Criteria"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnGenerate
        '
        Me.btnGenerate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenerate.Location = New System.Drawing.Point(386, 347)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(183, 23)
        Me.btnGenerate.TabIndex = 40
        Me.btnGenerate.Text = "Generate Marketing List"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(607, 347)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 41
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
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
        'cboStateSelection
        '
        Me.cboStateSelection.FormattingEnabled = True
        Me.cboStateSelection.Location = New System.Drawing.Point(267, 96)
        Me.cboStateSelection.Name = "cboStateSelection"
        Me.cboStateSelection.Size = New System.Drawing.Size(61, 24)
        Me.cboStateSelection.TabIndex = 11
        '
        'lblStateSelection
        '
        Me.lblStateSelection.AutoSize = True
        Me.lblStateSelection.Location = New System.Drawing.Point(15, 99)
        Me.lblStateSelection.Name = "lblStateSelection"
        Me.lblStateSelection.Size = New System.Drawing.Size(200, 16)
        Me.lblStateSelection.TabIndex = 12
        Me.lblStateSelection.Text = "Enter State For Starting City"
        '
        'frmCreateList
        '
        Me.AcceptButton = Me.btnGenerate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(695, 377)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCreateList"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Create Marketing List"
        Me.TabControl1.ResumeLayout(False)
        Me.tabDate.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tabMarketers.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.tabProducts.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.tabGeo.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.numMiles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabWC.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.tabPC.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.numReferences, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numMonths, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.tabRecovery.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.numPar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSort.ResumeLayout(False)
        CType(Me.epGeo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabDate As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtGenerated As System.Windows.Forms.TextBox
    Friend WithEvents dpGenerated As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chWeekdays As System.Windows.Forms.CheckBox
    Friend WithEvents txtTimeTo As System.Windows.Forms.TextBox
    Friend WithEvents txtTimeFrom As System.Windows.Forms.TextBox
    Friend WithEvents tpTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tpFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTo As System.Windows.Forms.TextBox
    Friend WithEvents txtFrom As System.Windows.Forms.TextBox
    Friend WithEvents dpTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dpFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboDateRange As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tabProducts As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnUncheckProducts As System.Windows.Forms.Label
    Friend WithEvents btnCheckProducts As System.Windows.Forms.Label
    Friend WithEvents chlstProducts As System.Windows.Forms.CheckedListBox
    Friend WithEvents tabGeo As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
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
    Friend WithEvents tabWC As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkWC As System.Windows.Forms.CheckBox
    Friend WithEvents btnUncheckWC As System.Windows.Forms.Label
    Friend WithEvents btnCheckWC As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents chlstWC As System.Windows.Forms.CheckedListBox
    Friend WithEvents tabPC As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents chFutureInterest As System.Windows.Forms.CheckBox
    Friend WithEvents chPC As System.Windows.Forms.CheckBox
    Friend WithEvents numReferences As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtDate2PC As System.Windows.Forms.TextBox
    Friend WithEvents txtDate1PC As System.Windows.Forms.TextBox
    Friend WithEvents dpDate2PC As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents dpDate1PC As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cboPCDateRange As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtApprovedDollars As System.Windows.Forms.TextBox
    Friend WithEvents chApprovedFor As System.Windows.Forms.CheckBox
    Friend WithEvents numMonths As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents rdoCash As System.Windows.Forms.RadioButton
    Friend WithEvents rdoAll As System.Windows.Forms.RadioButton
    Friend WithEvents rdoLoan As System.Windows.Forms.RadioButton
    Friend WithEvents chLoanSatisfied As System.Windows.Forms.CheckBox
    Friend WithEvents tabRecovery As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents txtQuoted As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents numPar As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents btnUncheckRehash As System.Windows.Forms.Label
    Friend WithEvents btnCheckRehash As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents chlstRehash As System.Windows.Forms.CheckedListBox
    Friend WithEvents chRehash As System.Windows.Forms.CheckBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents epGeo As System.Windows.Forms.ErrorProvider
    Friend WithEvents tabSort As System.Windows.Forms.TabPage
    Friend WithEvents epForm As System.Windows.Forms.ErrorProvider
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents tabMarketers As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents uncheckMarketers As System.Windows.Forms.Label
    Friend WithEvents checkMarketers As System.Windows.Forms.Label
    Friend WithEvents chlstMarketers As System.Windows.Forms.CheckedListBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents lblStateSelection As System.Windows.Forms.Label
    Friend WithEvents cboStateSelection As System.Windows.Forms.ComboBox
End Class
