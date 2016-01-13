<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditCustomerInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditCustomerInfo))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lblC2WorkHours = New System.Windows.Forms.Label()
        Me.lblC1Work = New System.Windows.Forms.Label()
        Me.cboC2WorkHours = New System.Windows.Forms.ComboBox()
        Me.cboC1WorkHours = New System.Windows.Forms.ComboBox()
        Me.cboAlt2Type = New System.Windows.Forms.ComboBox()
        Me.cboalt1type = New System.Windows.Forms.ComboBox()
        Me.txtaltphone2 = New System.Windows.Forms.MaskedTextBox()
        Me.txtaltphone1 = New System.Windows.Forms.MaskedTextBox()
        Me.txtHousePhone = New System.Windows.Forms.MaskedTextBox()
        Me.lblAltPhone2 = New System.Windows.Forms.Label()
        Me.lblAltPhone1 = New System.Windows.Forms.Label()
        Me.lblHousePhone = New System.Windows.Forms.Label()
        Me.lnkEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtContact2 = New System.Windows.Forms.TextBox()
        Me.txtContact1 = New System.Windows.Forms.TextBox()
        Me.lblContact2 = New System.Windows.Forms.Label()
        Me.lblContact1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.pctVerified = New System.Windows.Forms.PictureBox()
        Me.btnMap = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtHomeValue = New System.Windows.Forms.TextBox()
        Me.txtYrsOwned = New System.Windows.Forms.TextBox()
        Me.lblYrBuilt = New System.Windows.Forms.Label()
        Me.lblYrsOwned = New System.Windows.Forms.Label()
        Me.lblHomeValue = New System.Windows.Forms.Label()
        Me.txtYrBuilt = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.cboProduct3 = New System.Windows.Forms.ComboBox()
        Me.cboProduct2 = New System.Windows.Forms.ComboBox()
        Me.cboProduct1 = New System.Windows.Forms.ComboBox()
        Me.lblQty = New System.Windows.Forms.Label()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.lblProducts = New System.Windows.Forms.Label()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSetAppt2 = New System.Windows.Forms.Button()
        Me.txtApptTime = New System.Windows.Forms.TextBox()
        Me.txtApptDate = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lblApptDate = New System.Windows.Forms.Label()
        Me.lblApptDay = New System.Windows.Forms.Label()
        Me.txtApptDay = New System.Windows.Forms.TextBox()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.cboPriLead = New System.Windows.Forms.ComboBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.cboSecLead = New System.Windows.Forms.ComboBox()
        Me.cboMarketer = New System.Windows.Forms.ComboBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.rtbSpecialInstructions = New System.Windows.Forms.RichTextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.ep = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.pctVerified, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        CType(Me.ep, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(10, 7)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(478, 340)
        Me.TabControl1.TabIndex = 197
        Me.ToolTip1.SetToolTip(Me.TabControl1, "Set a New Appointmrnt for this Customer")
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lblC2WorkHours)
        Me.TabPage1.Controls.Add(Me.lblC1Work)
        Me.TabPage1.Controls.Add(Me.cboC2WorkHours)
        Me.TabPage1.Controls.Add(Me.cboC1WorkHours)
        Me.TabPage1.Controls.Add(Me.cboAlt2Type)
        Me.TabPage1.Controls.Add(Me.cboalt1type)
        Me.TabPage1.Controls.Add(Me.txtaltphone2)
        Me.TabPage1.Controls.Add(Me.txtaltphone1)
        Me.TabPage1.Controls.Add(Me.txtHousePhone)
        Me.TabPage1.Controls.Add(Me.lblAltPhone2)
        Me.TabPage1.Controls.Add(Me.lblAltPhone1)
        Me.TabPage1.Controls.Add(Me.lblHousePhone)
        Me.TabPage1.Controls.Add(Me.lnkEmail)
        Me.TabPage1.Controls.Add(Me.lblEmail)
        Me.TabPage1.Controls.Add(Me.txtContact2)
        Me.TabPage1.Controls.Add(Me.txtContact1)
        Me.TabPage1.Controls.Add(Me.lblContact2)
        Me.TabPage1.Controls.Add(Me.lblContact1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 46)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(470, 290)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Contact Info"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lblC2WorkHours
        '
        Me.lblC2WorkHours.AutoSize = True
        Me.lblC2WorkHours.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC2WorkHours.ForeColor = System.Drawing.Color.Gray
        Me.lblC2WorkHours.Location = New System.Drawing.Point(7, 258)
        Me.lblC2WorkHours.Name = "lblC2WorkHours"
        Me.lblC2WorkHours.Size = New System.Drawing.Size(156, 16)
        Me.lblC2WorkHours.TabIndex = 175
        Me.lblC2WorkHours.Text = "Contact 2 Work Hours:"
        '
        'lblC1Work
        '
        Me.lblC1Work.AutoSize = True
        Me.lblC1Work.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC1Work.ForeColor = System.Drawing.Color.Gray
        Me.lblC1Work.Location = New System.Drawing.Point(7, 220)
        Me.lblC1Work.Name = "lblC1Work"
        Me.lblC1Work.Size = New System.Drawing.Size(156, 16)
        Me.lblC1Work.TabIndex = 174
        Me.lblC1Work.Text = "Contact 1 Work Hours:"
        '
        'cboC2WorkHours
        '
        Me.cboC2WorkHours.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboC2WorkHours.FormattingEnabled = True
        Me.cboC2WorkHours.Items.AddRange(New Object() {"1st Shift", "2nd Shift", "3rd Shift", "Varies", "Retired", "Home Maker"})
        Me.cboC2WorkHours.Location = New System.Drawing.Point(201, 252)
        Me.cboC2WorkHours.Name = "cboC2WorkHours"
        Me.cboC2WorkHours.Size = New System.Drawing.Size(220, 24)
        Me.cboC2WorkHours.TabIndex = 9
        '
        'cboC1WorkHours
        '
        Me.cboC1WorkHours.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboC1WorkHours.FormattingEnabled = True
        Me.ep.SetIconPadding(Me.cboC1WorkHours, 5)
        Me.cboC1WorkHours.Items.AddRange(New Object() {"1st Shift", "2nd Shift", "3rd Shift", "Varies", "Retired", "Home Maker"})
        Me.cboC1WorkHours.Location = New System.Drawing.Point(201, 217)
        Me.cboC1WorkHours.Name = "cboC1WorkHours"
        Me.cboC1WorkHours.Size = New System.Drawing.Size(220, 24)
        Me.cboC1WorkHours.TabIndex = 8
        '
        'cboAlt2Type
        '
        Me.cboAlt2Type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboAlt2Type.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboAlt2Type.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAlt2Type.FormattingEnabled = True
        Me.cboAlt2Type.Items.AddRange(New Object() {"Work", "Cell"})
        Me.cboAlt2Type.Location = New System.Drawing.Point(332, 148)
        Me.cboAlt2Type.Name = "cboAlt2Type"
        Me.cboAlt2Type.Size = New System.Drawing.Size(88, 24)
        Me.cboAlt2Type.TabIndex = 6
        '
        'cboalt1type
        '
        Me.cboalt1type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboalt1type.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboalt1type.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboalt1type.FormattingEnabled = True
        Me.cboalt1type.Items.AddRange(New Object() {"Work", "Cell"})
        Me.cboalt1type.Location = New System.Drawing.Point(332, 114)
        Me.cboalt1type.Name = "cboalt1type"
        Me.cboalt1type.Size = New System.Drawing.Size(88, 24)
        Me.cboalt1type.TabIndex = 4
        '
        'txtaltphone2
        '
        Me.txtaltphone2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaltphone2.Location = New System.Drawing.Point(148, 149)
        Me.txtaltphone2.Mask = "(999) 000-0000"
        Me.txtaltphone2.Name = "txtaltphone2"
        Me.txtaltphone2.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtaltphone2.Size = New System.Drawing.Size(161, 23)
        Me.txtaltphone2.TabIndex = 5
        '
        'txtaltphone1
        '
        Me.txtaltphone1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaltphone1.Location = New System.Drawing.Point(148, 115)
        Me.txtaltphone1.Mask = "(999) 000-0000"
        Me.txtaltphone1.Name = "txtaltphone1"
        Me.txtaltphone1.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtaltphone1.Size = New System.Drawing.Size(161, 23)
        Me.txtaltphone1.TabIndex = 3
        '
        'txtHousePhone
        '
        Me.txtHousePhone.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ep.SetIconPadding(Me.txtHousePhone, 5)
        Me.txtHousePhone.Location = New System.Drawing.Point(148, 81)
        Me.txtHousePhone.Mask = "(999) 000-0000"
        Me.txtHousePhone.Name = "txtHousePhone"
        Me.txtHousePhone.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtHousePhone.Size = New System.Drawing.Size(161, 23)
        Me.txtHousePhone.TabIndex = 2
        '
        'lblAltPhone2
        '
        Me.lblAltPhone2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAltPhone2.AutoSize = True
        Me.lblAltPhone2.BackColor = System.Drawing.Color.Transparent
        Me.lblAltPhone2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAltPhone2.ForeColor = System.Drawing.Color.Gray
        Me.lblAltPhone2.Location = New System.Drawing.Point(28, 152)
        Me.lblAltPhone2.Name = "lblAltPhone2"
        Me.lblAltPhone2.Size = New System.Drawing.Size(84, 16)
        Me.lblAltPhone2.TabIndex = 169
        Me.lblAltPhone2.Text = "Alt Phone2:"
        '
        'lblAltPhone1
        '
        Me.lblAltPhone1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAltPhone1.AutoSize = True
        Me.lblAltPhone1.BackColor = System.Drawing.Color.Transparent
        Me.lblAltPhone1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAltPhone1.ForeColor = System.Drawing.Color.Gray
        Me.lblAltPhone1.Location = New System.Drawing.Point(23, 118)
        Me.lblAltPhone1.Name = "lblAltPhone1"
        Me.lblAltPhone1.Size = New System.Drawing.Size(88, 16)
        Me.lblAltPhone1.TabIndex = 168
        Me.lblAltPhone1.Text = "Alt Phone 1:"
        '
        'lblHousePhone
        '
        Me.lblHousePhone.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHousePhone.AutoSize = True
        Me.lblHousePhone.BackColor = System.Drawing.Color.Transparent
        Me.lblHousePhone.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHousePhone.ForeColor = System.Drawing.Color.Gray
        Me.lblHousePhone.Location = New System.Drawing.Point(13, 84)
        Me.lblHousePhone.Name = "lblHousePhone"
        Me.lblHousePhone.Size = New System.Drawing.Size(97, 16)
        Me.lblHousePhone.TabIndex = 167
        Me.lblHousePhone.Text = "House Phone:"
        '
        'lnkEmail
        '
        Me.lnkEmail.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkEmail.Location = New System.Drawing.Point(148, 183)
        Me.lnkEmail.Name = "lnkEmail"
        Me.lnkEmail.Size = New System.Drawing.Size(272, 23)
        Me.lnkEmail.TabIndex = 7
        '
        'lblEmail
        '
        Me.lblEmail.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.Gray
        Me.lblEmail.Location = New System.Drawing.Point(73, 186)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(45, 16)
        Me.lblEmail.TabIndex = 162
        Me.lblEmail.Text = "Email:"
        '
        'txtContact2
        '
        Me.txtContact2.BackColor = System.Drawing.Color.White
        Me.txtContact2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact2.ForeColor = System.Drawing.Color.Black
        Me.txtContact2.Location = New System.Drawing.Point(148, 47)
        Me.txtContact2.Name = "txtContact2"
        Me.txtContact2.Size = New System.Drawing.Size(272, 23)
        Me.txtContact2.TabIndex = 1
        '
        'txtContact1
        '
        Me.txtContact1.BackColor = System.Drawing.Color.White
        Me.txtContact1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact1.ForeColor = System.Drawing.Color.Black
        Me.ep.SetIconPadding(Me.txtContact1, 5)
        Me.txtContact1.Location = New System.Drawing.Point(148, 13)
        Me.txtContact1.Name = "txtContact1"
        Me.txtContact1.Size = New System.Drawing.Size(272, 23)
        Me.txtContact1.TabIndex = 0
        '
        'lblContact2
        '
        Me.lblContact2.AutoSize = True
        Me.lblContact2.BackColor = System.Drawing.Color.Transparent
        Me.lblContact2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact2.ForeColor = System.Drawing.Color.Gray
        Me.lblContact2.Location = New System.Drawing.Point(37, 50)
        Me.lblContact2.Name = "lblContact2"
        Me.lblContact2.Size = New System.Drawing.Size(76, 16)
        Me.lblContact2.TabIndex = 159
        Me.lblContact2.Text = "Contact 2:"
        '
        'lblContact1
        '
        Me.lblContact1.AutoSize = True
        Me.lblContact1.BackColor = System.Drawing.Color.Transparent
        Me.lblContact1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact1.ForeColor = System.Drawing.Color.Gray
        Me.lblContact1.Location = New System.Drawing.Point(37, 16)
        Me.lblContact1.Name = "lblContact1"
        Me.lblContact1.Size = New System.Drawing.Size(76, 16)
        Me.lblContact1.TabIndex = 158
        Me.lblContact1.Text = "Contact 1:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.pctVerified)
        Me.TabPage2.Controls.Add(Me.btnMap)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.txtZip)
        Me.TabPage2.Controls.Add(Me.txtState)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.txtCity)
        Me.TabPage2.Controls.Add(Me.txtAddress)
        Me.TabPage2.Controls.Add(Me.lblAddress)
        Me.TabPage2.Location = New System.Drawing.Point(4, 46)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(470, 290)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Address Info"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'pctVerified
        '
        Me.pctVerified.Image = CType(resources.GetObject("pctVerified.Image"), System.Drawing.Image)
        Me.pctVerified.Location = New System.Drawing.Point(407, 23)
        Me.pctVerified.Name = "pctVerified"
        Me.pctVerified.Size = New System.Drawing.Size(42, 24)
        Me.pctVerified.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctVerified.TabIndex = 197
        Me.pctVerified.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pctVerified, "Address has not been Verified!")
        Me.pctVerified.Visible = False
        '
        'btnMap
        '
        Me.btnMap.Enabled = False
        Me.btnMap.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMap.Image = CType(resources.GetObject("btnMap.Image"), System.Drawing.Image)
        Me.btnMap.Location = New System.Drawing.Point(34, 226)
        Me.btnMap.Name = "btnMap"
        Me.btnMap.Size = New System.Drawing.Size(71, 48)
        Me.btnMap.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.btnMap, "Click Here to Verify Address")
        Me.btnMap.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gray
        Me.Label7.Location = New System.Drawing.Point(38, 179)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 16)
        Me.Label7.TabIndex = 163
        Me.Label7.Text = "Zip:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(30, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 16)
        Me.Label4.TabIndex = 162
        Me.Label4.Text = "State:"
        '
        'txtZip
        '
        Me.txtZip.BackColor = System.Drawing.Color.White
        Me.txtZip.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZip.ForeColor = System.Drawing.Color.Black
        Me.txtZip.Location = New System.Drawing.Point(150, 176)
        Me.txtZip.Multiline = True
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(136, 23)
        Me.txtZip.TabIndex = 3
        '
        'txtState
        '
        Me.txtState.BackColor = System.Drawing.Color.White
        Me.txtState.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtState.ForeColor = System.Drawing.Color.Black
        Me.ep.SetIconPadding(Me.txtState, 5)
        Me.txtState.Location = New System.Drawing.Point(150, 125)
        Me.txtState.Multiline = True
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(47, 23)
        Me.txtState.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(30, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 16)
        Me.Label3.TabIndex = 159
        Me.Label3.Text = "City:"
        '
        'txtCity
        '
        Me.txtCity.BackColor = System.Drawing.Color.White
        Me.txtCity.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCity.ForeColor = System.Drawing.Color.Black
        Me.ep.SetIconPadding(Me.txtCity, 5)
        Me.txtCity.Location = New System.Drawing.Point(150, 74)
        Me.txtCity.Multiline = True
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(221, 23)
        Me.txtCity.TabIndex = 1
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.Color.White
        Me.txtAddress.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.ForeColor = System.Drawing.Color.Black
        Me.ep.SetIconPadding(Me.txtAddress, 5)
        Me.txtAddress.Location = New System.Drawing.Point(150, 23)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(221, 23)
        Me.txtAddress.TabIndex = 0
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.BackColor = System.Drawing.Color.Transparent
        Me.lblAddress.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.Color.Gray
        Me.lblAddress.Location = New System.Drawing.Point(30, 26)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(67, 16)
        Me.lblAddress.TabIndex = 156
        Me.lblAddress.Text = "Address:"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Controls.Add(Me.Label2)
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Controls.Add(Me.txtHomeValue)
        Me.TabPage3.Controls.Add(Me.txtYrsOwned)
        Me.TabPage3.Controls.Add(Me.lblYrBuilt)
        Me.TabPage3.Controls.Add(Me.lblYrsOwned)
        Me.TabPage3.Controls.Add(Me.lblHomeValue)
        Me.TabPage3.Controls.Add(Me.txtYrBuilt)
        Me.TabPage3.Location = New System.Drawing.Point(4, 46)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(470, 290)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Home Info"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gray
        Me.Label8.Location = New System.Drawing.Point(234, 89)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 16)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "(xxxx Year)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gray
        Me.Label6.Location = New System.Drawing.Point(234, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 16)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "(xxxx Year)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(153, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 16)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "$"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(234, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 16)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "K"
        '
        'txtHomeValue
        '
        Me.txtHomeValue.BackColor = System.Drawing.Color.White
        Me.txtHomeValue.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHomeValue.ForeColor = System.Drawing.Color.Black
        Me.txtHomeValue.Location = New System.Drawing.Point(178, 137)
        Me.txtHomeValue.Name = "txtHomeValue"
        Me.txtHomeValue.Size = New System.Drawing.Size(48, 23)
        Me.txtHomeValue.TabIndex = 2
        Me.txtHomeValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtYrsOwned
        '
        Me.txtYrsOwned.BackColor = System.Drawing.Color.White
        Me.txtYrsOwned.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYrsOwned.ForeColor = System.Drawing.Color.Black
        Me.txtYrsOwned.Location = New System.Drawing.Point(156, 86)
        Me.txtYrsOwned.Name = "txtYrsOwned"
        Me.txtYrsOwned.Size = New System.Drawing.Size(70, 23)
        Me.txtYrsOwned.TabIndex = 1
        Me.txtYrsOwned.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblYrBuilt
        '
        Me.lblYrBuilt.AutoSize = True
        Me.lblYrBuilt.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYrBuilt.ForeColor = System.Drawing.Color.Gray
        Me.lblYrBuilt.Location = New System.Drawing.Point(28, 38)
        Me.lblYrBuilt.Name = "lblYrBuilt"
        Me.lblYrBuilt.Size = New System.Drawing.Size(76, 16)
        Me.lblYrBuilt.TabIndex = 39
        Me.lblYrBuilt.Text = "Year Built:"
        '
        'lblYrsOwned
        '
        Me.lblYrsOwned.AutoSize = True
        Me.lblYrsOwned.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYrsOwned.ForeColor = System.Drawing.Color.Gray
        Me.lblYrsOwned.Location = New System.Drawing.Point(28, 89)
        Me.lblYrsOwned.Name = "lblYrsOwned"
        Me.lblYrsOwned.Size = New System.Drawing.Size(116, 16)
        Me.lblYrsOwned.TabIndex = 38
        Me.lblYrsOwned.Text = "Year Purchased:"
        '
        'lblHomeValue
        '
        Me.lblHomeValue.AutoSize = True
        Me.lblHomeValue.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHomeValue.ForeColor = System.Drawing.Color.Gray
        Me.lblHomeValue.Location = New System.Drawing.Point(28, 140)
        Me.lblHomeValue.Name = "lblHomeValue"
        Me.lblHomeValue.Size = New System.Drawing.Size(89, 16)
        Me.lblHomeValue.TabIndex = 41
        Me.lblHomeValue.Text = "Home Value:"
        '
        'txtYrBuilt
        '
        Me.txtYrBuilt.BackColor = System.Drawing.Color.White
        Me.txtYrBuilt.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYrBuilt.ForeColor = System.Drawing.Color.Black
        Me.txtYrBuilt.Location = New System.Drawing.Point(156, 35)
        Me.txtYrBuilt.Name = "txtYrBuilt"
        Me.txtYrBuilt.Size = New System.Drawing.Size(70, 23)
        Me.txtYrBuilt.TabIndex = 0
        Me.txtYrBuilt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.cboProduct3)
        Me.TabPage4.Controls.Add(Me.cboProduct2)
        Me.TabPage4.Controls.Add(Me.cboProduct1)
        Me.TabPage4.Controls.Add(Me.lblQty)
        Me.TabPage4.Controls.Add(Me.txtColor)
        Me.TabPage4.Controls.Add(Me.lblColor)
        Me.TabPage4.Controls.Add(Me.txtQty)
        Me.TabPage4.Controls.Add(Me.lblProducts)
        Me.TabPage4.Location = New System.Drawing.Point(4, 46)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(470, 290)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Product Info"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'cboProduct3
        '
        Me.cboProduct3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProduct3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProduct3.FormattingEnabled = True
        Me.cboProduct3.Location = New System.Drawing.Point(150, 134)
        Me.cboProduct3.Name = "cboProduct3"
        Me.cboProduct3.Size = New System.Drawing.Size(277, 24)
        Me.cboProduct3.TabIndex = 2
        '
        'cboProduct2
        '
        Me.cboProduct2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProduct2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProduct2.FormattingEnabled = True
        Me.cboProduct2.Location = New System.Drawing.Point(150, 80)
        Me.cboProduct2.Name = "cboProduct2"
        Me.cboProduct2.Size = New System.Drawing.Size(277, 24)
        Me.cboProduct2.TabIndex = 1
        '
        'cboProduct1
        '
        Me.cboProduct1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProduct1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProduct1.FormattingEnabled = True
        Me.ep.SetIconPadding(Me.cboProduct1, 5)
        Me.cboProduct1.Location = New System.Drawing.Point(150, 26)
        Me.cboProduct1.Name = "cboProduct1"
        Me.cboProduct1.Size = New System.Drawing.Size(277, 24)
        Me.cboProduct1.TabIndex = 0
        '
        'lblQty
        '
        Me.lblQty.AutoSize = True
        Me.lblQty.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQty.ForeColor = System.Drawing.Color.Gray
        Me.lblQty.Location = New System.Drawing.Point(31, 244)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(63, 16)
        Me.lblQty.TabIndex = 165
        Me.lblQty.Text = "Quanity:"
        '
        'txtColor
        '
        Me.txtColor.BackColor = System.Drawing.Color.White
        Me.txtColor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColor.ForeColor = System.Drawing.Color.Black
        Me.txtColor.Location = New System.Drawing.Point(150, 188)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(277, 23)
        Me.txtColor.TabIndex = 3
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColor.ForeColor = System.Drawing.Color.Gray
        Me.lblColor.Location = New System.Drawing.Point(31, 191)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(46, 16)
        Me.lblColor.TabIndex = 163
        Me.lblColor.Text = "Color:"
        '
        'txtQty
        '
        Me.txtQty.BackColor = System.Drawing.Color.White
        Me.txtQty.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.ForeColor = System.Drawing.Color.Black
        Me.txtQty.Location = New System.Drawing.Point(150, 241)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(277, 23)
        Me.txtQty.TabIndex = 4
        '
        'lblProducts
        '
        Me.lblProducts.AutoSize = True
        Me.lblProducts.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProducts.ForeColor = System.Drawing.Color.Gray
        Me.lblProducts.Location = New System.Drawing.Point(31, 29)
        Me.lblProducts.Name = "lblProducts"
        Me.lblProducts.Size = New System.Drawing.Size(83, 16)
        Me.lblProducts.TabIndex = 161
        Me.lblProducts.Text = "Product(s):"
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.Label5)
        Me.TabPage5.Controls.Add(Me.btnSetAppt2)
        Me.TabPage5.Controls.Add(Me.txtApptTime)
        Me.TabPage5.Controls.Add(Me.txtApptDate)
        Me.TabPage5.Controls.Add(Me.Label22)
        Me.TabPage5.Controls.Add(Me.lblApptDate)
        Me.TabPage5.Controls.Add(Me.lblApptDay)
        Me.TabPage5.Controls.Add(Me.txtApptDay)
        Me.TabPage5.Location = New System.Drawing.Point(4, 46)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(470, 290)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Appt. Info"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(132, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(304, 51)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Appt. Info is Read Only, To Set New Appt. for this customer Use Set Appt. Button " & _
    "Provided"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSetAppt2
        '
        Me.btnSetAppt2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetAppt2.Image = CType(resources.GetObject("btnSetAppt2.Image"), System.Drawing.Image)
        Me.btnSetAppt2.Location = New System.Drawing.Point(36, 213)
        Me.btnSetAppt2.Name = "btnSetAppt2"
        Me.btnSetAppt2.Size = New System.Drawing.Size(71, 48)
        Me.btnSetAppt2.TabIndex = 30
        Me.ToolTip1.SetToolTip(Me.btnSetAppt2, "Click Here to Verify Address")
        Me.btnSetAppt2.UseVisualStyleBackColor = True
        '
        'txtApptTime
        '
        Me.txtApptTime.BackColor = System.Drawing.Color.White
        Me.txtApptTime.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApptTime.ForeColor = System.Drawing.Color.Black
        Me.txtApptTime.Location = New System.Drawing.Point(97, 135)
        Me.txtApptTime.Name = "txtApptTime"
        Me.txtApptTime.ReadOnly = True
        Me.txtApptTime.Size = New System.Drawing.Size(245, 23)
        Me.txtApptTime.TabIndex = 29
        '
        'txtApptDate
        '
        Me.txtApptDate.BackColor = System.Drawing.Color.White
        Me.txtApptDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApptDate.ForeColor = System.Drawing.Color.Black
        Me.txtApptDate.Location = New System.Drawing.Point(97, 25)
        Me.txtApptDate.Name = "txtApptDate"
        Me.txtApptDate.ReadOnly = True
        Me.txtApptDate.Size = New System.Drawing.Size(245, 23)
        Me.txtApptDate.TabIndex = 28
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Gray
        Me.Label22.Location = New System.Drawing.Point(33, 138)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(42, 16)
        Me.Label22.TabIndex = 27
        Me.Label22.Text = "Time:"
        '
        'lblApptDate
        '
        Me.lblApptDate.AutoSize = True
        Me.lblApptDate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApptDate.ForeColor = System.Drawing.Color.Gray
        Me.lblApptDate.Location = New System.Drawing.Point(33, 28)
        Me.lblApptDate.Name = "lblApptDate"
        Me.lblApptDate.Size = New System.Drawing.Size(44, 16)
        Me.lblApptDate.TabIndex = 24
        Me.lblApptDate.Text = "Date:"
        '
        'lblApptDay
        '
        Me.lblApptDay.AutoSize = True
        Me.lblApptDay.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApptDay.ForeColor = System.Drawing.Color.Gray
        Me.lblApptDay.Location = New System.Drawing.Point(33, 81)
        Me.lblApptDay.Name = "lblApptDay"
        Me.lblApptDay.Size = New System.Drawing.Size(38, 16)
        Me.lblApptDay.TabIndex = 26
        Me.lblApptDay.Text = "Day:"
        '
        'txtApptDay
        '
        Me.txtApptDay.BackColor = System.Drawing.Color.White
        Me.txtApptDay.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApptDay.ForeColor = System.Drawing.Color.Black
        Me.txtApptDay.Location = New System.Drawing.Point(97, 78)
        Me.txtApptDay.Name = "txtApptDay"
        Me.txtApptDay.ReadOnly = True
        Me.txtApptDay.Size = New System.Drawing.Size(245, 23)
        Me.txtApptDay.TabIndex = 1
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.cboPriLead)
        Me.TabPage6.Controls.Add(Me.Label41)
        Me.TabPage6.Controls.Add(Me.Label42)
        Me.TabPage6.Controls.Add(Me.cboSecLead)
        Me.TabPage6.Controls.Add(Me.cboMarketer)
        Me.TabPage6.Controls.Add(Me.Label43)
        Me.TabPage6.Location = New System.Drawing.Point(4, 46)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(470, 290)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Lead Source"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'cboPriLead
        '
        Me.cboPriLead.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboPriLead.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboPriLead.BackColor = System.Drawing.SystemColors.Window
        Me.cboPriLead.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPriLead.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPriLead.FormattingEnabled = True
        Me.ep.SetIconPadding(Me.cboPriLead, 5)
        Me.cboPriLead.Location = New System.Drawing.Point(201, 69)
        Me.cboPriLead.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cboPriLead.Name = "cboPriLead"
        Me.cboPriLead.Size = New System.Drawing.Size(237, 21)
        Me.cboPriLead.TabIndex = 1
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.BackColor = System.Drawing.Color.Transparent
        Me.Label41.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.Gray
        Me.Label41.Location = New System.Drawing.Point(12, 116)
        Me.Label41.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(142, 13)
        Me.Label41.TabIndex = 24
        Me.Label41.Text = "Secondary Lead Source:"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.BackColor = System.Drawing.Color.Transparent
        Me.Label42.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.Gray
        Me.Label42.Location = New System.Drawing.Point(26, 72)
        Me.Label42.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(130, 13)
        Me.Label42.TabIndex = 25
        Me.Label42.Text = "Primary  Lead Source:"
        '
        'cboSecLead
        '
        Me.cboSecLead.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSecLead.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSecLead.BackColor = System.Drawing.SystemColors.Window
        Me.cboSecLead.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSecLead.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSecLead.FormattingEnabled = True
        Me.cboSecLead.Location = New System.Drawing.Point(201, 113)
        Me.cboSecLead.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cboSecLead.Name = "cboSecLead"
        Me.cboSecLead.Size = New System.Drawing.Size(237, 21)
        Me.cboSecLead.TabIndex = 2
        '
        'cboMarketer
        '
        Me.cboMarketer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboMarketer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboMarketer.BackColor = System.Drawing.SystemColors.Window
        Me.cboMarketer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMarketer.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMarketer.FormattingEnabled = True
        Me.cboMarketer.Location = New System.Drawing.Point(201, 25)
        Me.cboMarketer.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cboMarketer.Name = "cboMarketer"
        Me.cboMarketer.Size = New System.Drawing.Size(237, 21)
        Me.cboMarketer.TabIndex = 0
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.BackColor = System.Drawing.Color.Transparent
        Me.Label43.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.Gray
        Me.Label43.Location = New System.Drawing.Point(104, 28)
        Me.Label43.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(63, 13)
        Me.Label43.TabIndex = 21
        Me.Label43.Text = "Marketer:"
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.rtbSpecialInstructions)
        Me.TabPage7.Location = New System.Drawing.Point(4, 46)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(470, 290)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "Special Instructions"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'rtbSpecialInstructions
        '
        Me.rtbSpecialInstructions.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbSpecialInstructions.Location = New System.Drawing.Point(19, 15)
        Me.rtbSpecialInstructions.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.rtbSpecialInstructions.Name = "rtbSpecialInstructions"
        Me.rtbSpecialInstructions.Size = New System.Drawing.Size(432, 257)
        Me.rtbSpecialInstructions.TabIndex = 0
        Me.rtbSpecialInstructions.Text = ""
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(10, 353)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(204, 30)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(280, 353)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(204, 30)
        Me.btnUpdate.TabIndex = 0
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'ep
        '
        Me.ep.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ep.ContainerControl = Me
        '
        'EditCustomerInfo
        '
        Me.AcceptButton = Me.btnUpdate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(499, 390)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EditCustomerInfo"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Customer Information"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.pctVerified, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        Me.TabPage7.ResumeLayout(False)
        CType(Me.ep, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents lblC2WorkHours As System.Windows.Forms.Label
    Friend WithEvents lblC1Work As System.Windows.Forms.Label
    Friend WithEvents cboC2WorkHours As System.Windows.Forms.ComboBox
    Friend WithEvents cboC1WorkHours As System.Windows.Forms.ComboBox
    Friend WithEvents cboAlt2Type As System.Windows.Forms.ComboBox
    Friend WithEvents cboalt1type As System.Windows.Forms.ComboBox
    Friend WithEvents txtaltphone2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtaltphone1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtHousePhone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblAltPhone2 As System.Windows.Forms.Label
    Friend WithEvents lblAltPhone1 As System.Windows.Forms.Label
    Friend WithEvents lblHousePhone As System.Windows.Forms.Label
    Friend WithEvents lnkEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtContact2 As System.Windows.Forms.TextBox
    Friend WithEvents txtContact1 As System.Windows.Forms.TextBox
    Friend WithEvents lblContact2 As System.Windows.Forms.Label
    Friend WithEvents lblContact1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents pctVerified As System.Windows.Forms.PictureBox
    Friend WithEvents btnMap As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtZip As System.Windows.Forms.TextBox
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtHomeValue As System.Windows.Forms.TextBox
    Friend WithEvents txtYrsOwned As System.Windows.Forms.TextBox
    Friend WithEvents lblYrBuilt As System.Windows.Forms.Label
    Friend WithEvents lblYrsOwned As System.Windows.Forms.Label
    Friend WithEvents lblHomeValue As System.Windows.Forms.Label
    Friend WithEvents txtYrBuilt As System.Windows.Forms.TextBox
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents cboProduct3 As System.Windows.Forms.ComboBox
    Friend WithEvents cboProduct2 As System.Windows.Forms.ComboBox
    Friend WithEvents cboProduct1 As System.Windows.Forms.ComboBox
    Friend WithEvents lblQty As System.Windows.Forms.Label
    Public WithEvents txtColor As System.Windows.Forms.TextBox
    Friend WithEvents lblColor As System.Windows.Forms.Label
    Public WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents lblProducts As System.Windows.Forms.Label
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents lblApptDate As System.Windows.Forms.Label
    Friend WithEvents lblApptDay As System.Windows.Forms.Label
    Friend WithEvents txtApptDay As System.Windows.Forms.TextBox
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents cboPriLead As System.Windows.Forms.ComboBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents cboSecLead As System.Windows.Forms.ComboBox
    Friend WithEvents cboMarketer As System.Windows.Forms.ComboBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents rtbSpecialInstructions As System.Windows.Forms.RichTextBox
    Friend WithEvents ep As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtApptTime As System.Windows.Forms.TextBox
    Friend WithEvents txtApptDate As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnSetAppt2 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
