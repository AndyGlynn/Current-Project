<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMappoint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMappoint))
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnResetSingle = New System.Windows.Forms.Button()
        Me.txtLeadNumLookup = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btnMapSingle = New System.Windows.Forms.Button()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtStreetAddress = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnResetPointToPoint = New System.Windows.Forms.Button()
        Me.txtDestinationLookup = New System.Windows.Forms.TextBox()
        Me.txtBeginLookup = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtEndZip = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtEndState = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtEndCity = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtEndAddress = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnMapPointToPoint = New System.Windows.Forms.Button()
        Me.txtBeginZip = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBeginState = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtBeginCity = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtBeginAddress = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.cboCustomRange = New System.Windows.Forms.ComboBox()
        Me.lblCustom = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdoCustomDateRange = New System.Windows.Forms.RadioButton()
        Me.rdoUserDefinedDateRange = New System.Windows.Forms.RadioButton()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpBeginDate = New System.Windows.Forms.DateTimePicker()
        Me.lblUserDef = New System.Windows.Forms.Label()
        Me.cboSalesResults = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.cboPointBState = New System.Windows.Forms.ComboBox()
        Me.cboPointAState = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtDriveTime = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.txtDinMiles = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtPointB = New System.Windows.Forms.TextBox()
        Me.txtPointA = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.AxMappointControl1 = New AxMapPoint.AxMappointControl()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.AxMappointControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 702)
        Me.Splitter1.TabIndex = 0
        Me.Splitter1.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(12, 30)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(417, 386)
        Me.TabControl1.TabIndex = 11
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnResetSingle)
        Me.TabPage1.Controls.Add(Me.txtLeadNumLookup)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.btnMapSingle)
        Me.TabPage1.Controls.Add(Me.txtZip)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txtState)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txtCity)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txtStreetAddress)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(409, 360)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Single Address Lookup"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnResetSingle
        '
        Me.btnResetSingle.Location = New System.Drawing.Point(26, 325)
        Me.btnResetSingle.Name = "btnResetSingle"
        Me.btnResetSingle.Size = New System.Drawing.Size(113, 23)
        Me.btnResetSingle.TabIndex = 6
        Me.btnResetSingle.Text = "Reset Form"
        Me.btnResetSingle.UseVisualStyleBackColor = True
        '
        'txtLeadNumLookup
        '
        Me.txtLeadNumLookup.Location = New System.Drawing.Point(244, 31)
        Me.txtLeadNumLookup.Name = "txtLeadNumLookup"
        Me.txtLeadNumLookup.Size = New System.Drawing.Size(100, 20)
        Me.txtLeadNumLookup.TabIndex = 1
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(15, 31)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(119, 13)
        Me.Label18.TabIndex = 21
        Me.Label18.Text = "Lookup Lead Number : "
        '
        'btnMapSingle
        '
        Me.btnMapSingle.Location = New System.Drawing.Point(231, 325)
        Me.btnMapSingle.Name = "btnMapSingle"
        Me.btnMapSingle.Size = New System.Drawing.Size(113, 23)
        Me.btnMapSingle.TabIndex = 7
        Me.btnMapSingle.Text = "Map It"
        Me.btnMapSingle.UseVisualStyleBackColor = True
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(258, 148)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(86, 20)
        Me.txtZip.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(202, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Zip :"
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(69, 148)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(86, 20)
        Me.txtState.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "State : "
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(119, 114)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(225, 20)
        Me.txtCity.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "City : "
        '
        'txtStreetAddress
        '
        Me.txtStreetAddress.Location = New System.Drawing.Point(119, 82)
        Me.txtStreetAddress.Name = "txtStreetAddress"
        Me.txtStreetAddress.Size = New System.Drawing.Size(225, 20)
        Me.txtStreetAddress.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Street Address :"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnResetPointToPoint)
        Me.TabPage2.Controls.Add(Me.txtDestinationLookup)
        Me.TabPage2.Controls.Add(Me.txtBeginLookup)
        Me.TabPage2.Controls.Add(Me.Label19)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.txtEndZip)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.txtEndState)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.txtEndCity)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.txtEndAddress)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.btnMapPointToPoint)
        Me.TabPage2.Controls.Add(Me.txtBeginZip)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.txtBeginState)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.txtBeginCity)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.txtBeginAddress)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(409, 360)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Point To Point Directions"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnResetPointToPoint
        '
        Me.btnResetPointToPoint.Location = New System.Drawing.Point(26, 325)
        Me.btnResetPointToPoint.Name = "btnResetPointToPoint"
        Me.btnResetPointToPoint.Size = New System.Drawing.Size(113, 23)
        Me.btnResetPointToPoint.TabIndex = 18
        Me.btnResetPointToPoint.Text = "Reset Form"
        Me.btnResetPointToPoint.UseVisualStyleBackColor = True
        '
        'txtDestinationLookup
        '
        Me.txtDestinationLookup.Location = New System.Drawing.Point(244, 157)
        Me.txtDestinationLookup.Name = "txtDestinationLookup"
        Me.txtDestinationLookup.Size = New System.Drawing.Size(100, 20)
        Me.txtDestinationLookup.TabIndex = 13
        '
        'txtBeginLookup
        '
        Me.txtBeginLookup.Location = New System.Drawing.Point(244, 14)
        Me.txtBeginLookup.Name = "txtBeginLookup"
        Me.txtBeginLookup.Size = New System.Drawing.Size(100, 20)
        Me.txtBeginLookup.TabIndex = 8
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(26, 17)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(194, 13)
        Me.Label19.TabIndex = 40
        Me.Label19.Text = "Lookup Start Address ( Lead Number ) :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(26, 160)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(222, 13)
        Me.Label14.TabIndex = 39
        Me.Label14.Text = "Lookup Destination Address (Lead Number) : "
        '
        'txtEndZip
        '
        Me.txtEndZip.Location = New System.Drawing.Point(259, 254)
        Me.txtEndZip.Name = "txtEndZip"
        Me.txtEndZip.Size = New System.Drawing.Size(86, 20)
        Me.txtEndZip.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(203, 257)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 13)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Zip :"
        '
        'txtEndState
        '
        Me.txtEndState.Location = New System.Drawing.Point(70, 254)
        Me.txtEndState.Name = "txtEndState"
        Me.txtEndState.Size = New System.Drawing.Size(86, 20)
        Me.txtEndState.TabIndex = 16
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(23, 257)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 13)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "State : "
        '
        'txtEndCity
        '
        Me.txtEndCity.Location = New System.Drawing.Point(120, 220)
        Me.txtEndCity.Name = "txtEndCity"
        Me.txtEndCity.Size = New System.Drawing.Size(225, 20)
        Me.txtEndCity.TabIndex = 15
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(23, 223)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(33, 13)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "City : "
        '
        'txtEndAddress
        '
        Me.txtEndAddress.Location = New System.Drawing.Point(120, 188)
        Me.txtEndAddress.Name = "txtEndAddress"
        Me.txtEndAddress.Size = New System.Drawing.Size(225, 20)
        Me.txtEndAddress.TabIndex = 14
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(23, 191)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 13)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Street Address :"
        '
        'btnMapPointToPoint
        '
        Me.btnMapPointToPoint.Location = New System.Drawing.Point(231, 325)
        Me.btnMapPointToPoint.Name = "btnMapPointToPoint"
        Me.btnMapPointToPoint.Size = New System.Drawing.Size(113, 23)
        Me.btnMapPointToPoint.TabIndex = 19
        Me.btnMapPointToPoint.Text = "Map It"
        Me.btnMapPointToPoint.UseVisualStyleBackColor = True
        '
        'txtBeginZip
        '
        Me.txtBeginZip.Location = New System.Drawing.Point(259, 114)
        Me.txtBeginZip.Name = "txtBeginZip"
        Me.txtBeginZip.Size = New System.Drawing.Size(86, 20)
        Me.txtBeginZip.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(203, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Zip :"
        '
        'txtBeginState
        '
        Me.txtBeginState.Location = New System.Drawing.Point(70, 114)
        Me.txtBeginState.Name = "txtBeginState"
        Me.txtBeginState.Size = New System.Drawing.Size(86, 20)
        Me.txtBeginState.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 117)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "State : "
        '
        'txtBeginCity
        '
        Me.txtBeginCity.Location = New System.Drawing.Point(120, 80)
        Me.txtBeginCity.Name = "txtBeginCity"
        Me.txtBeginCity.Size = New System.Drawing.Size(225, 20)
        Me.txtBeginCity.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "City : "
        '
        'txtBeginAddress
        '
        Me.txtBeginAddress.Location = New System.Drawing.Point(120, 48)
        Me.txtBeginAddress.Name = "txtBeginAddress"
        Me.txtBeginAddress.Size = New System.Drawing.Size(225, 20)
        Me.txtBeginAddress.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Street Address :"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.cboCustomRange)
        Me.TabPage3.Controls.Add(Me.lblCustom)
        Me.TabPage3.Controls.Add(Me.GroupBox1)
        Me.TabPage3.Controls.Add(Me.Button3)
        Me.TabPage3.Controls.Add(Me.Label17)
        Me.TabPage3.Controls.Add(Me.dtpEndDate)
        Me.TabPage3.Controls.Add(Me.dtpBeginDate)
        Me.TabPage3.Controls.Add(Me.lblUserDef)
        Me.TabPage3.Controls.Add(Me.cboSalesResults)
        Me.TabPage3.Controls.Add(Me.Label15)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(409, 360)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Plot Sales Results"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'cboCustomRange
        '
        Me.cboCustomRange.FormattingEnabled = True
        Me.cboCustomRange.Location = New System.Drawing.Point(223, 126)
        Me.cboCustomRange.Name = "cboCustomRange"
        Me.cboCustomRange.Size = New System.Drawing.Size(121, 21)
        Me.cboCustomRange.TabIndex = 23
        '
        'lblCustom
        '
        Me.lblCustom.AutoSize = True
        Me.lblCustom.Location = New System.Drawing.Point(17, 129)
        Me.lblCustom.Name = "lblCustom"
        Me.lblCustom.Size = New System.Drawing.Size(117, 13)
        Me.lblCustom.TabIndex = 10
        Me.lblCustom.Text = "Custom Date Ranges : "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdoCustomDateRange)
        Me.GroupBox1.Controls.Add(Me.rdoUserDefinedDateRange)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(327, 54)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Date Ranges :"
        '
        'rdoCustomDateRange
        '
        Me.rdoCustomDateRange.AutoSize = True
        Me.rdoCustomDateRange.Location = New System.Drawing.Point(33, 22)
        Me.rdoCustomDateRange.Name = "rdoCustomDateRange"
        Me.rdoCustomDateRange.Size = New System.Drawing.Size(121, 17)
        Me.rdoCustomDateRange.TabIndex = 21
        Me.rdoCustomDateRange.TabStop = True
        Me.rdoCustomDateRange.Text = "Custom Date Range"
        Me.rdoCustomDateRange.UseVisualStyleBackColor = True
        '
        'rdoUserDefinedDateRange
        '
        Me.rdoUserDefinedDateRange.AutoSize = True
        Me.rdoUserDefinedDateRange.Location = New System.Drawing.Point(180, 22)
        Me.rdoUserDefinedDateRange.Name = "rdoUserDefinedDateRange"
        Me.rdoUserDefinedDateRange.Size = New System.Drawing.Size(121, 17)
        Me.rdoUserDefinedDateRange.TabIndex = 22
        Me.rdoUserDefinedDateRange.TabStop = True
        Me.rdoUserDefinedDateRange.Text = "User Defined Dates "
        Me.rdoUserDefinedDateRange.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(17, 325)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(327, 23)
        Me.Button3.TabIndex = 26
        Me.Button3.Text = "Plot Results On Map"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(162, 189)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(26, 13)
        Me.Label17.TabIndex = 5
        Me.Label17.Text = "To :"
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEndDate.Location = New System.Drawing.Point(223, 185)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(121, 20)
        Me.dtpEndDate.TabIndex = 25
        '
        'dtpBeginDate
        '
        Me.dtpBeginDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBeginDate.Location = New System.Drawing.Point(17, 185)
        Me.dtpBeginDate.Name = "dtpBeginDate"
        Me.dtpBeginDate.Size = New System.Drawing.Size(111, 20)
        Me.dtpBeginDate.TabIndex = 24
        '
        'lblUserDef
        '
        Me.lblUserDef.AutoSize = True
        Me.lblUserDef.Location = New System.Drawing.Point(14, 160)
        Me.lblUserDef.Name = "lblUserDef"
        Me.lblUserDef.Size = New System.Drawing.Size(106, 13)
        Me.lblUserDef.TabIndex = 2
        Me.lblUserDef.Text = "User Defined Dates :"
        '
        'cboSalesResults
        '
        Me.cboSalesResults.FormattingEnabled = True
        Me.cboSalesResults.Location = New System.Drawing.Point(226, 16)
        Me.cboSalesResults.Name = "cboSalesResults"
        Me.cboSalesResults.Size = New System.Drawing.Size(121, 21)
        Me.cboSalesResults.TabIndex = 20
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(17, 19)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(75, 13)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Sales Result : "
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.cboPointBState)
        Me.TabPage4.Controls.Add(Me.cboPointAState)
        Me.TabPage4.Controls.Add(Me.Label24)
        Me.TabPage4.Controls.Add(Me.Label23)
        Me.TabPage4.Controls.Add(Me.txtDriveTime)
        Me.TabPage4.Controls.Add(Me.Label22)
        Me.TabPage4.Controls.Add(Me.btnCalc)
        Me.TabPage4.Controls.Add(Me.txtDinMiles)
        Me.TabPage4.Controls.Add(Me.Label21)
        Me.TabPage4.Controls.Add(Me.txtPointB)
        Me.TabPage4.Controls.Add(Me.txtPointA)
        Me.TabPage4.Controls.Add(Me.Label20)
        Me.TabPage4.Controls.Add(Me.Label16)
        Me.TabPage4.Controls.Add(Me.Label9)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(409, 360)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Distances"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'cboPointBState
        '
        Me.cboPointBState.FormattingEnabled = True
        Me.cboPointBState.Location = New System.Drawing.Point(238, 82)
        Me.cboPointBState.Name = "cboPointBState"
        Me.cboPointBState.Size = New System.Drawing.Size(86, 21)
        Me.cboPointBState.TabIndex = 30
        '
        'cboPointAState
        '
        Me.cboPointAState.FormattingEnabled = True
        Me.cboPointAState.Location = New System.Drawing.Point(238, 54)
        Me.cboPointAState.Name = "cboPointAState"
        Me.cboPointAState.Size = New System.Drawing.Size(86, 21)
        Me.cboPointAState.TabIndex = 28
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(194, 82)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(38, 13)
        Me.Label24.TabIndex = 11
        Me.Label24.Text = "State :"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(194, 57)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(38, 13)
        Me.Label23.TabIndex = 10
        Me.Label23.Text = "State :"
        '
        'txtDriveTime
        '
        Me.txtDriveTime.Location = New System.Drawing.Point(224, 162)
        Me.txtDriveTime.Name = "txtDriveTime"
        Me.txtDriveTime.Size = New System.Drawing.Size(100, 20)
        Me.txtDriveTime.TabIndex = 32
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(17, 165)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(168, 13)
        Me.Label22.TabIndex = 8
        Me.Label22.Text = "Estimated Drive Time In Minutes : "
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(17, 325)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(327, 23)
        Me.btnCalc.TabIndex = 33
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'txtDinMiles
        '
        Me.txtDinMiles.Location = New System.Drawing.Point(224, 124)
        Me.txtDinMiles.Name = "txtDinMiles"
        Me.txtDinMiles.Size = New System.Drawing.Size(100, 20)
        Me.txtDinMiles.TabIndex = 31
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(17, 124)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(94, 13)
        Me.Label21.TabIndex = 5
        Me.Label21.Text = "Distance In Miles :"
        '
        'txtPointB
        '
        Me.txtPointB.Location = New System.Drawing.Point(84, 80)
        Me.txtPointB.Name = "txtPointB"
        Me.txtPointB.Size = New System.Drawing.Size(104, 20)
        Me.txtPointB.TabIndex = 29
        '
        'txtPointA
        '
        Me.txtPointA.Location = New System.Drawing.Point(84, 54)
        Me.txtPointA.Name = "txtPointA"
        Me.txtPointA.Size = New System.Drawing.Size(104, 20)
        Me.txtPointA.TabIndex = 27
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(17, 83)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(47, 13)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "Point B :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(17, 57)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(47, 13)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Point A :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Distance Between Cities :"
        '
        'AxMappointControl1
        '
        Me.AxMappointControl1.Enabled = True
        Me.AxMappointControl1.Location = New System.Drawing.Point(435, 30)
        Me.AxMappointControl1.Name = "AxMappointControl1"
        Me.AxMappointControl1.OcxState = CType(resources.GetObject("AxMappointControl1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxMappointControl1.Size = New System.Drawing.Size(714, 660)
        Me.AxMappointControl1.TabIndex = 12
        '
        'frmMappoint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1161, 702)
        Me.Controls.Add(Me.AxMappointControl1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Splitter1)
        Me.Name = "frmMappoint"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mapping"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.AxMappointControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents btnMapSingle As System.Windows.Forms.Button
    Friend WithEvents txtZip As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtStreetAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtEndZip As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtEndState As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtEndCity As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtEndAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnMapPointToPoint As System.Windows.Forms.Button
    Friend WithEvents txtBeginZip As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtBeginState As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtBeginCity As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtBeginAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents dtpEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpBeginDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblUserDef As System.Windows.Forms.Label
    Friend WithEvents cboSalesResults As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtLeadNumLookup As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtDestinationLookup As System.Windows.Forms.TextBox
    Friend WithEvents txtBeginLookup As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents btnResetPointToPoint As System.Windows.Forms.Button
    Friend WithEvents btnResetSingle As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdoCustomDateRange As System.Windows.Forms.RadioButton
    Friend WithEvents rdoUserDefinedDateRange As System.Windows.Forms.RadioButton
    Friend WithEvents cboCustomRange As System.Windows.Forms.ComboBox
    Friend WithEvents lblCustom As System.Windows.Forms.Label
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents txtDinMiles As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtPointB As System.Windows.Forms.TextBox
    Friend WithEvents txtPointA As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtDriveTime As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cboPointBState As System.Windows.Forms.ComboBox
    Friend WithEvents cboPointAState As System.Windows.Forms.ComboBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents AxMappointControl1 As AxMapPoint.AxMappointControl
End Class
