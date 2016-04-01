<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWCList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWCList))
        Me.txtRecordCount = New System.Windows.Forms.TextBox()
        Me.BackgroundWorkerCity = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorkerZip = New System.ComponentModel.BackgroundWorker()
        Me.epForm = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.epGeo = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnRecordCount = New System.Windows.Forms.Button()
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
        Me.tabWC = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnUncheckWC = New System.Windows.Forms.Label()
        Me.btnCheckWC = New System.Windows.Forms.Label()
        Me.chlstWC = New System.Windows.Forms.CheckedListBox()
        Me.tabSort = New System.Windows.Forms.TabPage()
        Me.chGroupBy = New System.Windows.Forms.CheckBox()
        Me.btnUnCheckOrderBy = New System.Windows.Forms.Label()
        Me.btnCheckOrderBy = New System.Windows.Forms.Label()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.chlstOrderBy = New System.Windows.Forms.CheckedListBox()
        CType(Me.epForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epGeo, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabSort.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtRecordCount
        '
        Me.txtRecordCount.BackColor = System.Drawing.SystemColors.Window
        Me.txtRecordCount.Location = New System.Drawing.Point(132, 342)
        Me.txtRecordCount.Name = "txtRecordCount"
        Me.txtRecordCount.ReadOnly = True
        Me.txtRecordCount.Size = New System.Drawing.Size(114, 20)
        Me.txtRecordCount.TabIndex = 58
        '
        'epForm
        '
        Me.epForm.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.epForm.ContainerControl = Me
        '
        'epGeo
        '
        Me.epGeo.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.epGeo.ContainerControl = Me
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "danger.ico")
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
        Me.btnGenerate.Location = New System.Drawing.Point(425, 342)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(177, 23)
        Me.btnGenerate.TabIndex = 56
        Me.btnGenerate.Text = "Generate Marketing List"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClear.Location = New System.Drawing.Point(310, 342)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(109, 23)
        Me.btnClear.TabIndex = 55
        Me.btnClear.Text = "Clear Criteria"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnRecordCount
        '
        Me.btnRecordCount.Location = New System.Drawing.Point(13, 342)
        Me.btnRecordCount.Name = "btnRecordCount"
        Me.btnRecordCount.Size = New System.Drawing.Size(113, 23)
        Me.btnRecordCount.TabIndex = 59
        Me.btnRecordCount.Text = "Record Count"
        Me.btnRecordCount.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabDate)
        Me.TabControl1.Controls.Add(Me.tabMarketers)
        Me.TabControl1.Controls.Add(Me.tabProducts)
        Me.TabControl1.Controls.Add(Me.tabGeo)
        Me.TabControl1.Controls.Add(Me.tabWC)
        Me.TabControl1.Controls.Add(Me.tabSort)
        Me.TabControl1.ImageList = Me.ImageList1
        Me.TabControl1.Location = New System.Drawing.Point(9, 12)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.ShowToolTips = True
        Me.TabControl1.Size = New System.Drawing.Size(674, 314)
        Me.TabControl1.TabIndex = 60
        '
        'tabDate
        '
        Me.tabDate.Controls.Add(Me.GroupBox1)
        Me.tabDate.Location = New System.Drawing.Point(4, 23)
        Me.tabDate.Name = "tabDate"
        Me.tabDate.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDate.Size = New System.Drawing.Size(666, 287)
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
        Me.dpGenerated.Size = New System.Drawing.Size(133, 20)
        Me.dpGenerated.TabIndex = 32
        Me.dpGenerated.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 13)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Appt Generated After"
        '
        'chWeekdays
        '
        Me.chWeekdays.AutoSize = True
        Me.chWeekdays.Location = New System.Drawing.Point(446, 129)
        Me.chWeekdays.Name = "chWeekdays"
        Me.chWeekdays.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chWeekdays.Size = New System.Drawing.Size(129, 17)
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
        Me.tpTo.Size = New System.Drawing.Size(116, 20)
        Me.tpTo.TabIndex = 27
        Me.tpTo.Value = New Date(1900, 1, 1, 23, 59, 0, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(267, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 13)
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
        Me.tpFrom.Size = New System.Drawing.Size(116, 20)
        Me.tpFrom.TabIndex = 25
        Me.tpFrom.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
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
        Me.dpTo.Size = New System.Drawing.Size(133, 20)
        Me.dpTo.TabIndex = 21
        Me.dpTo.Value = New Date(2100, 1, 1, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(461, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "To"
        '
        'dpFrom
        '
        Me.dpFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpFrom.Location = New System.Drawing.Point(322, 79)
        Me.dpFrom.Name = "dpFrom"
        Me.dpFrom.Size = New System.Drawing.Size(133, 20)
        Me.dpFrom.TabIndex = 19
        Me.dpFrom.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(276, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "From"
        '
        'cboDateRange
        '
        Me.cboDateRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDateRange.FormattingEnabled = True
        Me.cboDateRange.Location = New System.Drawing.Point(108, 78)
        Me.cboDateRange.Name = "cboDateRange"
        Me.cboDateRange.Size = New System.Drawing.Size(162, 21)
        Me.cboDateRange.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Appt. Dates"
        '
        'tabMarketers
        '
        Me.tabMarketers.Controls.Add(Me.GroupBox8)
        Me.tabMarketers.Location = New System.Drawing.Point(4, 23)
        Me.tabMarketers.Name = "tabMarketers"
        Me.tabMarketers.Size = New System.Drawing.Size(666, 287)
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
        Me.tabProducts.Location = New System.Drawing.Point(4, 23)
        Me.tabProducts.Name = "tabProducts"
        Me.tabProducts.Size = New System.Drawing.Size(666, 287)
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
        Me.chlstProducts.Location = New System.Drawing.Point(18, 22)
        Me.chlstProducts.MultiColumn = True
        Me.chlstProducts.Name = "chlstProducts"
        Me.chlstProducts.Size = New System.Drawing.Size(607, 154)
        Me.chlstProducts.TabIndex = 7
        '
        'tabGeo
        '
        Me.tabGeo.Controls.Add(Me.GroupBox3)
        Me.tabGeo.Location = New System.Drawing.Point(4, 23)
        Me.tabGeo.Name = "tabGeo"
        Me.tabGeo.Size = New System.Drawing.Size(666, 287)
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
        Me.txtZipCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtZipCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
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
        'tabWC
        '
        Me.tabWC.Controls.Add(Me.GroupBox2)
        Me.tabWC.Location = New System.Drawing.Point(4, 23)
        Me.tabWC.Name = "tabWC"
        Me.tabWC.Padding = New System.Windows.Forms.Padding(3)
        Me.tabWC.Size = New System.Drawing.Size(666, 287)
        Me.tabWC.TabIndex = 1
        Me.tabWC.Text = "Marketing Results"
        Me.tabWC.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnUncheckWC)
        Me.GroupBox2.Controls.Add(Me.btnCheckWC)
        Me.GroupBox2.Controls.Add(Me.chlstWC)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(638, 237)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Last Known Marketing Result"
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
        'chlstWC
        '
        Me.chlstWC.FormattingEnabled = True
        Me.chlstWC.Items.AddRange(New Object() {"Unconfirmed", "Called and Cancelled", "Reset", "Not Hit", "Not Issued"})
        Me.chlstWC.Location = New System.Drawing.Point(11, 25)
        Me.chlstWC.Name = "chlstWC"
        Me.chlstWC.Size = New System.Drawing.Size(617, 154)
        Me.chlstWC.TabIndex = 17
        '
        'tabSort
        '
        Me.tabSort.Controls.Add(Me.chGroupBy)
        Me.tabSort.Controls.Add(Me.btnUnCheckOrderBy)
        Me.tabSort.Controls.Add(Me.btnCheckOrderBy)
        Me.tabSort.Controls.Add(Me.btnDown)
        Me.tabSort.Controls.Add(Me.btnUp)
        Me.tabSort.Controls.Add(Me.chlstOrderBy)
        Me.tabSort.Location = New System.Drawing.Point(4, 23)
        Me.tabSort.Name = "tabSort"
        Me.tabSort.Size = New System.Drawing.Size(666, 287)
        Me.tabSort.TabIndex = 6
        Me.tabSort.Text = "Sort By/Group By"
        Me.tabSort.UseVisualStyleBackColor = True
        '
        'chGroupBy
        '
        Me.chGroupBy.AutoSize = True
        Me.chGroupBy.Location = New System.Drawing.Point(23, 18)
        Me.chGroupBy.Name = "chGroupBy"
        Me.chGroupBy.Size = New System.Drawing.Size(137, 17)
        Me.chGroupBy.TabIndex = 41
        Me.chGroupBy.Text = "Group By Top Sort Item"
        Me.chGroupBy.UseVisualStyleBackColor = True
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
        'chlstOrderBy
        '
        Me.chlstOrderBy.ColumnWidth = 200
        Me.chlstOrderBy.FormattingEnabled = True
        Me.chlstOrderBy.Items.AddRange(New Object() {"City, State", "Zip Code", "Generated On", "Appointment Date", "Appointment Time", "Primary Product", "Marketer", "Marketing Result"})
        Me.chlstOrderBy.Location = New System.Drawing.Point(55, 56)
        Me.chlstOrderBy.MultiColumn = True
        Me.chlstOrderBy.Name = "chlstOrderBy"
        Me.chlstOrderBy.Size = New System.Drawing.Size(578, 139)
        Me.chlstOrderBy.TabIndex = 1
        '
        'frmWCList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 377)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.txtRecordCount)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnRecordCount)
        Me.Name = "frmWCList"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Create Warm Calling List"
        CType(Me.epForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epGeo, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.tabSort.ResumeLayout(False)
        Me.tabSort.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtRecordCount As System.Windows.Forms.TextBox
    Friend WithEvents BackgroundWorkerCity As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorkerZip As System.ComponentModel.BackgroundWorker
    Friend WithEvents epForm As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents btnRecordCount As System.Windows.Forms.Button
    Friend WithEvents epGeo As System.Windows.Forms.ErrorProvider
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
    Friend WithEvents tabMarketers As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents uncheckMarketers As System.Windows.Forms.Label
    Friend WithEvents checkMarketers As System.Windows.Forms.Label
    Friend WithEvents chlstMarketers As System.Windows.Forms.CheckedListBox
    Friend WithEvents tabProducts As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnUncheckProducts As System.Windows.Forms.Label
    Friend WithEvents btnCheckProducts As System.Windows.Forms.Label
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
    Friend WithEvents tabWC As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnUncheckWC As System.Windows.Forms.Label
    Friend WithEvents btnCheckWC As System.Windows.Forms.Label
    Friend WithEvents chlstWC As System.Windows.Forms.CheckedListBox
    Friend WithEvents tabSort As System.Windows.Forms.TabPage
    Friend WithEvents chGroupBy As System.Windows.Forms.CheckBox
    Friend WithEvents btnUnCheckOrderBy As System.Windows.Forms.Label
    Friend WithEvents btnCheckOrderBy As System.Windows.Forms.Label
    Friend WithEvents btnDown As System.Windows.Forms.Button
    Friend WithEvents btnUp As System.Windows.Forms.Button
    Friend WithEvents chlstOrderBy As System.Windows.Forms.CheckedListBox
End Class
