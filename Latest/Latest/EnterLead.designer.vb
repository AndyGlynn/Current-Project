<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EnterLead
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EnterLead))
        Me.txtProdQTY = New System.Windows.Forms.MaskedTextBox
        Me.cboProduct1 = New System.Windows.Forms.ComboBox
        Me.txtZip = New System.Windows.Forms.MaskedTextBox
        Me.Label58 = New System.Windows.Forms.Label
        Me.Label59 = New System.Windows.Forms.Label
        Me.txtProdColor = New System.Windows.Forms.TextBox
        Me.txtAltPhone2 = New System.Windows.Forms.MaskedTextBox
        Me.cboProduct3 = New System.Windows.Forms.ComboBox
        Me.txtAltPhone1 = New System.Windows.Forms.MaskedTextBox
        Me.txtHousePhone = New System.Windows.Forms.MaskedTextBox
        Me.cboAltPhone2Type = New System.Windows.Forms.ComboBox
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.txtP3acro = New System.Windows.Forms.TextBox
        Me.txtP2acro = New System.Windows.Forms.TextBox
        Me.txtP1acro = New System.Windows.Forms.TextBox
        Me.cboProduct2 = New System.Windows.Forms.ComboBox
        Me.Label60 = New System.Windows.Forms.Label
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.txtCity = New System.Windows.Forms.TextBox
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label46 = New System.Windows.Forms.Label
        Me.cboAlt1Type = New System.Windows.Forms.ComboBox
        Me.cboC2Work = New System.Windows.Forms.ComboBox
        Me.Label47 = New System.Windows.Forms.Label
        Me.Label48 = New System.Windows.Forms.Label
        Me.cboSpokeWith = New System.Windows.Forms.ComboBox
        Me.txtState = New System.Windows.Forms.TextBox
        Me.Label49 = New System.Windows.Forms.Label
        Me.cboC1Work = New System.Windows.Forms.ComboBox
        Me.Label50 = New System.Windows.Forms.Label
        Me.Label51 = New System.Windows.Forms.Label
        Me.Label52 = New System.Windows.Forms.Label
        Me.txtStAddy = New System.Windows.Forms.TextBox
        Me.Label53 = New System.Windows.Forms.Label
        Me.Label54 = New System.Windows.Forms.Label
        Me.Label55 = New System.Windows.Forms.Label
        Me.txtC2LName = New System.Windows.Forms.TextBox
        Me.txtC2FName = New System.Windows.Forms.TextBox
        Me.txtC1LName = New System.Windows.Forms.TextBox
        Me.txtC1FName = New System.Windows.Forms.TextBox
        Me.Label56 = New System.Windows.Forms.Label
        Me.Label57 = New System.Windows.Forms.Label
        Me.txtHomeVal = New System.Windows.Forms.MaskedTextBox
        Me.txtAgeOfHome = New System.Windows.Forms.MaskedTextBox
        Me.txtYearsOwned = New System.Windows.Forms.MaskedTextBox
        Me.cboMarketer = New System.Windows.Forms.ComboBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.cboPriLead = New System.Windows.Forms.ComboBox
        Me.epEnterLead = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox13 = New System.Windows.Forms.GroupBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.txtApptTime = New System.Windows.Forms.DateTimePicker
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.dtpApptInfo = New System.Windows.Forms.DateTimePicker
        Me.txtApptday = New System.Windows.Forms.TextBox
        Me.Label63 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label68 = New System.Windows.Forms.Label
        Me.rtfSpecialIns = New System.Windows.Forms.RichTextBox
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnSaveNew = New System.Windows.Forms.Button
        Me.btnSaveClose = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtpLeadGen = New System.Windows.Forms.DateTimePicker
        Me.Label41 = New System.Windows.Forms.Label
        Me.Label69 = New System.Windows.Forms.Label
        Me.Label70 = New System.Windows.Forms.Label
        Me.Label42 = New System.Windows.Forms.Label
        Me.Label43 = New System.Windows.Forms.Label
        Me.cboSecLead = New System.Windows.Forms.ComboBox
        Me.GroupBox11 = New System.Windows.Forms.GroupBox
        Me.txtMarketingManager = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        CType(Me.epEnterLead, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox13.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtProdQTY
        '
        Me.txtProdQTY.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProdQTY.Location = New System.Drawing.Point(107, 173)
        Me.txtProdQTY.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProdQTY.Mask = "000"
        Me.txtProdQTY.Name = "txtProdQTY"
        Me.txtProdQTY.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtProdQTY.Size = New System.Drawing.Size(44, 21)
        Me.txtProdQTY.TabIndex = 25
        Me.txtProdQTY.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'cboProduct1
        '
        Me.cboProduct1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboProduct1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboProduct1.BackColor = System.Drawing.SystemColors.Window
        Me.cboProduct1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.epEnterLead.SetError(Me.cboProduct1, "k")
        Me.cboProduct1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProduct1.FormattingEnabled = True
        Me.cboProduct1.Location = New System.Drawing.Point(104, 24)
        Me.cboProduct1.Margin = New System.Windows.Forms.Padding(4)
        Me.cboProduct1.Name = "cboProduct1"
        Me.cboProduct1.Size = New System.Drawing.Size(145, 21)
        Me.cboProduct1.TabIndex = 21
        '
        'txtZip
        '
        Me.txtZip.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZip.Location = New System.Drawing.Point(501, 110)
        Me.txtZip.Margin = New System.Windows.Forms.Padding(4)
        Me.txtZip.Mask = "00000"
        Me.txtZip.Name = "txtZip"
        Me.txtZip.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtZip.Size = New System.Drawing.Size(76, 21)
        Me.txtZip.TabIndex = 16
        Me.txtZip.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.ForeColor = System.Drawing.Color.Black
        Me.Label58.Location = New System.Drawing.Point(11, 176)
        Me.Label58.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(56, 13)
        Me.Label58.TabIndex = 0
        Me.Label58.Text = "Quanity:"
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.ForeColor = System.Drawing.Color.Black
        Me.Label59.Location = New System.Drawing.Point(11, 140)
        Me.Label59.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(43, 13)
        Me.Label59.TabIndex = 0
        Me.Label59.Text = "Color:"
        '
        'txtProdColor
        '
        Me.txtProdColor.AutoCompleteCustomSource.AddRange(New String() {"Black", "Brown", "White", "Red", "Maroon", "Turquois", "Yellow", "Magenta", "Ash", "Colonial White"})
        Me.txtProdColor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtProdColor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtProdColor.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProdColor.Location = New System.Drawing.Point(104, 136)
        Me.txtProdColor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProdColor.Name = "txtProdColor"
        Me.txtProdColor.Size = New System.Drawing.Size(145, 21)
        Me.txtProdColor.TabIndex = 24
        '
        'txtAltPhone2
        '
        Me.txtAltPhone2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAltPhone2.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.txtAltPhone2.Location = New System.Drawing.Point(410, 81)
        Me.txtAltPhone2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAltPhone2.Mask = "(999) 000-0000"
        Me.txtAltPhone2.Name = "txtAltPhone2"
        Me.txtAltPhone2.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtAltPhone2.Size = New System.Drawing.Size(105, 21)
        Me.txtAltPhone2.TabIndex = 11
        '
        'cboProduct3
        '
        Me.cboProduct3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboProduct3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboProduct3.BackColor = System.Drawing.SystemColors.Window
        Me.cboProduct3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProduct3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProduct3.FormattingEnabled = True
        Me.cboProduct3.Location = New System.Drawing.Point(104, 99)
        Me.cboProduct3.Margin = New System.Windows.Forms.Padding(4)
        Me.cboProduct3.Name = "cboProduct3"
        Me.cboProduct3.Size = New System.Drawing.Size(145, 21)
        Me.cboProduct3.TabIndex = 23
        '
        'txtAltPhone1
        '
        Me.txtAltPhone1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAltPhone1.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.txtAltPhone1.Location = New System.Drawing.Point(410, 51)
        Me.txtAltPhone1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAltPhone1.Mask = "(999) 000-0000"
        Me.txtAltPhone1.Name = "txtAltPhone1"
        Me.txtAltPhone1.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtAltPhone1.Size = New System.Drawing.Size(105, 21)
        Me.txtAltPhone1.TabIndex = 9
        '
        'txtHousePhone
        '
        Me.txtHousePhone.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHousePhone.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.txtHousePhone.Location = New System.Drawing.Point(410, 22)
        Me.txtHousePhone.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHousePhone.Mask = "(999) 000-0000"
        Me.txtHousePhone.Name = "txtHousePhone"
        Me.txtHousePhone.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtHousePhone.Size = New System.Drawing.Size(105, 21)
        Me.txtHousePhone.TabIndex = 8
        '
        'cboAltPhone2Type
        '
        Me.cboAltPhone2Type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboAltPhone2Type.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboAltPhone2Type.BackColor = System.Drawing.SystemColors.Window
        Me.cboAltPhone2Type.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAltPhone2Type.FormattingEnabled = True
        Me.cboAltPhone2Type.Items.AddRange(New Object() {"Work", "Cell"})
        Me.cboAltPhone2Type.Location = New System.Drawing.Point(523, 81)
        Me.cboAltPhone2Type.Margin = New System.Windows.Forms.Padding(4)
        Me.cboAltPhone2Type.Name = "cboAltPhone2Type"
        Me.cboAltPhone2Type.Size = New System.Drawing.Size(66, 21)
        Me.cboAltPhone2Type.TabIndex = 12
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox8.Controls.Add(Me.txtP3acro)
        Me.GroupBox8.Controls.Add(Me.txtP2acro)
        Me.GroupBox8.Controls.Add(Me.txtP1acro)
        Me.GroupBox8.Controls.Add(Me.txtProdQTY)
        Me.GroupBox8.Controls.Add(Me.cboProduct1)
        Me.GroupBox8.Controls.Add(Me.Label58)
        Me.GroupBox8.Controls.Add(Me.Label59)
        Me.GroupBox8.Controls.Add(Me.txtProdColor)
        Me.GroupBox8.Controls.Add(Me.cboProduct3)
        Me.GroupBox8.Controls.Add(Me.cboProduct2)
        Me.GroupBox8.Controls.Add(Me.Label60)
        Me.GroupBox8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.ForeColor = System.Drawing.Color.Black
        Me.GroupBox8.Location = New System.Drawing.Point(639, 75)
        Me.GroupBox8.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox8.Size = New System.Drawing.Size(270, 207)
        Me.GroupBox8.TabIndex = 23
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Product Info:"
        '
        'txtP3acro
        '
        Me.txtP3acro.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtP3acro.Location = New System.Drawing.Point(8, 95)
        Me.txtP3acro.Margin = New System.Windows.Forms.Padding(4)
        Me.txtP3acro.Name = "txtP3acro"
        Me.txtP3acro.Size = New System.Drawing.Size(56, 21)
        Me.txtP3acro.TabIndex = 27
        Me.txtP3acro.Visible = False
        '
        'txtP2acro
        '
        Me.txtP2acro.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtP2acro.Location = New System.Drawing.Point(8, 79)
        Me.txtP2acro.Margin = New System.Windows.Forms.Padding(4)
        Me.txtP2acro.Name = "txtP2acro"
        Me.txtP2acro.Size = New System.Drawing.Size(56, 21)
        Me.txtP2acro.TabIndex = 26
        Me.txtP2acro.Visible = False
        '
        'txtP1acro
        '
        Me.txtP1acro.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtP1acro.Location = New System.Drawing.Point(8, 63)
        Me.txtP1acro.Margin = New System.Windows.Forms.Padding(4)
        Me.txtP1acro.Name = "txtP1acro"
        Me.txtP1acro.Size = New System.Drawing.Size(56, 21)
        Me.txtP1acro.TabIndex = 25
        Me.txtP1acro.Visible = False
        '
        'cboProduct2
        '
        Me.cboProduct2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboProduct2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboProduct2.BackColor = System.Drawing.SystemColors.Window
        Me.cboProduct2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProduct2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProduct2.FormattingEnabled = True
        Me.cboProduct2.Location = New System.Drawing.Point(104, 61)
        Me.cboProduct2.Margin = New System.Windows.Forms.Padding(4)
        Me.cboProduct2.Name = "cboProduct2"
        Me.cboProduct2.Size = New System.Drawing.Size(145, 21)
        Me.cboProduct2.TabIndex = 22
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.ForeColor = System.Drawing.Color.Black
        Me.Label60.Location = New System.Drawing.Point(11, 27)
        Me.Label60.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(71, 13)
        Me.Label60.TabIndex = 0
        Me.Label60.Text = "Product(s):"
        '
        'GroupBox9
        '
        Me.GroupBox9.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox9.Controls.Add(Me.txtCity)
        Me.GroupBox9.Controls.Add(Me.txtEmail)
        Me.GroupBox9.Controls.Add(Me.Label4)
        Me.GroupBox9.Controls.Add(Me.txtZip)
        Me.GroupBox9.Controls.Add(Me.txtAltPhone2)
        Me.GroupBox9.Controls.Add(Me.txtAltPhone1)
        Me.GroupBox9.Controls.Add(Me.txtHousePhone)
        Me.GroupBox9.Controls.Add(Me.cboAltPhone2Type)
        Me.GroupBox9.Controls.Add(Me.Label46)
        Me.GroupBox9.Controls.Add(Me.cboAlt1Type)
        Me.GroupBox9.Controls.Add(Me.cboC2Work)
        Me.GroupBox9.Controls.Add(Me.Label47)
        Me.GroupBox9.Controls.Add(Me.Label48)
        Me.GroupBox9.Controls.Add(Me.cboSpokeWith)
        Me.GroupBox9.Controls.Add(Me.txtState)
        Me.GroupBox9.Controls.Add(Me.Label49)
        Me.GroupBox9.Controls.Add(Me.cboC1Work)
        Me.GroupBox9.Controls.Add(Me.Label50)
        Me.GroupBox9.Controls.Add(Me.Label51)
        Me.GroupBox9.Controls.Add(Me.Label52)
        Me.GroupBox9.Controls.Add(Me.txtStAddy)
        Me.GroupBox9.Controls.Add(Me.Label53)
        Me.GroupBox9.Controls.Add(Me.Label54)
        Me.GroupBox9.Controls.Add(Me.Label55)
        Me.GroupBox9.Controls.Add(Me.txtC2LName)
        Me.GroupBox9.Controls.Add(Me.txtC2FName)
        Me.GroupBox9.Controls.Add(Me.txtC1LName)
        Me.GroupBox9.Controls.Add(Me.txtC1FName)
        Me.GroupBox9.Controls.Add(Me.Label56)
        Me.GroupBox9.Controls.Add(Me.Label57)
        Me.GroupBox9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox9.ForeColor = System.Drawing.Color.Black
        Me.GroupBox9.Location = New System.Drawing.Point(8, 75)
        Me.GroupBox9.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox9.Size = New System.Drawing.Size(623, 207)
        Me.GroupBox9.TabIndex = 22
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Contact Info:"
        '
        'txtCity
        '
        Me.txtCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCity.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCity.Location = New System.Drawing.Point(83, 110)
        Me.txtCity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(220, 21)
        Me.txtCity.TabIndex = 14
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(83, 172)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(220, 21)
        Me.txtEmail.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(9, 175)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Email:"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.BackColor = System.Drawing.Color.Transparent
        Me.Label46.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.ForeColor = System.Drawing.Color.Black
        Me.Label46.Location = New System.Drawing.Point(327, 175)
        Me.Label46.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(124, 13)
        Me.Label46.TabIndex = 0
        Me.Label46.Text = "Contact 2 Work Hrs:"
        '
        'cboAlt1Type
        '
        Me.cboAlt1Type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboAlt1Type.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboAlt1Type.BackColor = System.Drawing.SystemColors.Window
        Me.cboAlt1Type.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAlt1Type.FormattingEnabled = True
        Me.cboAlt1Type.Items.AddRange(New Object() {"Work", "Cell"})
        Me.cboAlt1Type.Location = New System.Drawing.Point(523, 51)
        Me.cboAlt1Type.Margin = New System.Windows.Forms.Padding(4)
        Me.cboAlt1Type.Name = "cboAlt1Type"
        Me.cboAlt1Type.Size = New System.Drawing.Size(66, 21)
        Me.cboAlt1Type.TabIndex = 10
        '
        'cboC2Work
        '
        Me.cboC2Work.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboC2Work.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboC2Work.BackColor = System.Drawing.SystemColors.Window
        Me.cboC2Work.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboC2Work.FormattingEnabled = True
        Me.cboC2Work.Location = New System.Drawing.Point(459, 172)
        Me.cboC2Work.Margin = New System.Windows.Forms.Padding(4)
        Me.cboC2Work.Name = "cboC2Work"
        Me.cboC2Work.Size = New System.Drawing.Size(132, 21)
        Me.cboC2Work.TabIndex = 19
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.BackColor = System.Drawing.Color.Transparent
        Me.Label47.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.Color.Black
        Me.Label47.Location = New System.Drawing.Point(327, 143)
        Me.Label47.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(124, 13)
        Me.Label47.TabIndex = 0
        Me.Label47.Text = "Contact 1 Work Hrs:"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.BackColor = System.Drawing.Color.Transparent
        Me.Label48.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.Black
        Me.Label48.Location = New System.Drawing.Point(9, 143)
        Me.Label48.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(77, 13)
        Me.Label48.TabIndex = 0
        Me.Label48.Text = "Spoke With:"
        '
        'cboSpokeWith
        '
        Me.cboSpokeWith.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSpokeWith.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSpokeWith.BackColor = System.Drawing.SystemColors.Window
        Me.cboSpokeWith.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSpokeWith.FormattingEnabled = True
        Me.cboSpokeWith.Location = New System.Drawing.Point(90, 140)
        Me.cboSpokeWith.Margin = New System.Windows.Forms.Padding(4)
        Me.cboSpokeWith.MaxDropDownItems = 3
        Me.cboSpokeWith.Name = "cboSpokeWith"
        Me.cboSpokeWith.Size = New System.Drawing.Size(213, 21)
        Me.cboSpokeWith.TabIndex = 17
        '
        'txtState
        '
        Me.txtState.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtState.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtState.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtState.Location = New System.Drawing.Point(377, 110)
        Me.txtState.Margin = New System.Windows.Forms.Padding(4)
        Me.txtState.MaxLength = 2
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(44, 21)
        Me.txtState.TabIndex = 15
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.BackColor = System.Drawing.Color.Transparent
        Me.Label49.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.ForeColor = System.Drawing.Color.Black
        Me.Label49.Location = New System.Drawing.Point(429, 113)
        Me.Label49.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(64, 13)
        Me.Label49.TabIndex = 16
        Me.Label49.Text = "Zip Code:"
        '
        'cboC1Work
        '
        Me.cboC1Work.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboC1Work.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboC1Work.BackColor = System.Drawing.SystemColors.Window
        Me.cboC1Work.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboC1Work.FormattingEnabled = True
        Me.cboC1Work.Location = New System.Drawing.Point(459, 140)
        Me.cboC1Work.Margin = New System.Windows.Forms.Padding(4)
        Me.cboC1Work.Name = "cboC1Work"
        Me.cboC1Work.Size = New System.Drawing.Size(132, 21)
        Me.cboC1Work.TabIndex = 18
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.BackColor = System.Drawing.Color.Transparent
        Me.Label50.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.ForeColor = System.Drawing.Color.Black
        Me.Label50.Location = New System.Drawing.Point(327, 113)
        Me.Label50.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(42, 13)
        Me.Label50.TabIndex = 0
        Me.Label50.Text = "State:"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.BackColor = System.Drawing.Color.Transparent
        Me.Label51.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.ForeColor = System.Drawing.Color.Black
        Me.Label51.Location = New System.Drawing.Point(8, 112)
        Me.Label51.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(35, 13)
        Me.Label51.TabIndex = 0
        Me.Label51.Text = "City:"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.BackColor = System.Drawing.Color.Transparent
        Me.Label52.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.ForeColor = System.Drawing.Color.Black
        Me.Label52.Location = New System.Drawing.Point(8, 82)
        Me.Label52.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(58, 13)
        Me.Label52.TabIndex = 0
        Me.Label52.Text = "Address:"
        '
        'txtStAddy
        '
        Me.txtStAddy.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStAddy.Location = New System.Drawing.Point(83, 80)
        Me.txtStAddy.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStAddy.Name = "txtStAddy"
        Me.txtStAddy.Size = New System.Drawing.Size(220, 21)
        Me.txtStAddy.TabIndex = 13
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.BackColor = System.Drawing.Color.Transparent
        Me.Label53.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.ForeColor = System.Drawing.Color.Black
        Me.Label53.Location = New System.Drawing.Point(325, 83)
        Me.Label53.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(73, 13)
        Me.Label53.TabIndex = 0
        Me.Label53.Text = "Alt Phone2:"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.BackColor = System.Drawing.Color.Transparent
        Me.Label54.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.ForeColor = System.Drawing.Color.Black
        Me.Label54.Location = New System.Drawing.Point(325, 54)
        Me.Label54.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(77, 13)
        Me.Label54.TabIndex = 0
        Me.Label54.Text = "Alt Phone 1:"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.BackColor = System.Drawing.Color.Transparent
        Me.Label55.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.ForeColor = System.Drawing.Color.Black
        Me.Label55.Location = New System.Drawing.Point(325, 24)
        Me.Label55.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(86, 13)
        Me.Label55.TabIndex = 0
        Me.Label55.Text = "House Phone:"
        '
        'txtC2LName
        '
        Me.epEnterLead.SetError(Me.txtC2LName, "j")
        Me.txtC2LName.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtC2LName.Location = New System.Drawing.Point(198, 50)
        Me.txtC2LName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtC2LName.Name = "txtC2LName"
        Me.txtC2LName.Size = New System.Drawing.Size(105, 21)
        Me.txtC2LName.TabIndex = 7
        '
        'txtC2FName
        '
        Me.txtC2FName.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtC2FName.Location = New System.Drawing.Point(83, 50)
        Me.txtC2FName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtC2FName.Name = "txtC2FName"
        Me.txtC2FName.Size = New System.Drawing.Size(105, 21)
        Me.txtC2FName.TabIndex = 6
        '
        'txtC1LName
        '
        Me.txtC1LName.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtC1LName.Location = New System.Drawing.Point(198, 21)
        Me.txtC1LName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtC1LName.Name = "txtC1LName"
        Me.txtC1LName.Size = New System.Drawing.Size(105, 21)
        Me.txtC1LName.TabIndex = 5
        '
        'txtC1FName
        '
        Me.txtC1FName.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtC1FName.Location = New System.Drawing.Point(83, 21)
        Me.txtC1FName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtC1FName.Name = "txtC1FName"
        Me.txtC1FName.Size = New System.Drawing.Size(105, 21)
        Me.txtC1FName.TabIndex = 4
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.BackColor = System.Drawing.Color.Transparent
        Me.Label56.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.ForeColor = System.Drawing.Color.Black
        Me.Label56.Location = New System.Drawing.Point(8, 53)
        Me.Label56.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(67, 13)
        Me.Label56.TabIndex = 0
        Me.Label56.Text = "Contact 2:"
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.BackColor = System.Drawing.Color.Transparent
        Me.Label57.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.ForeColor = System.Drawing.Color.Black
        Me.Label57.Location = New System.Drawing.Point(8, 23)
        Me.Label57.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(67, 13)
        Me.Label57.TabIndex = 0
        Me.Label57.Text = "Contact 1:"
        '
        'txtHomeVal
        '
        Me.txtHomeVal.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHomeVal.Location = New System.Drawing.Point(121, 96)
        Me.txtHomeVal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHomeVal.Mask = "000"
        Me.txtHomeVal.Name = "txtHomeVal"
        Me.txtHomeVal.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtHomeVal.Size = New System.Drawing.Size(44, 21)
        Me.txtHomeVal.TabIndex = 28
        '
        'txtAgeOfHome
        '
        Me.txtAgeOfHome.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAgeOfHome.Location = New System.Drawing.Point(121, 59)
        Me.txtAgeOfHome.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAgeOfHome.Mask = "000"
        Me.txtAgeOfHome.Name = "txtAgeOfHome"
        Me.txtAgeOfHome.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtAgeOfHome.Size = New System.Drawing.Size(44, 21)
        Me.txtAgeOfHome.TabIndex = 27
        '
        'txtYearsOwned
        '
        Me.txtYearsOwned.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYearsOwned.Location = New System.Drawing.Point(121, 24)
        Me.txtYearsOwned.Margin = New System.Windows.Forms.Padding(4)
        Me.txtYearsOwned.Mask = "000"
        Me.txtYearsOwned.Name = "txtYearsOwned"
        Me.txtYearsOwned.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtYearsOwned.Size = New System.Drawing.Size(44, 21)
        Me.txtYearsOwned.TabIndex = 26
        '
        'cboMarketer
        '
        Me.cboMarketer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboMarketer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboMarketer.BackColor = System.Drawing.SystemColors.Window
        Me.cboMarketer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMarketer.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMarketer.FormattingEnabled = True
        Me.cboMarketer.Location = New System.Drawing.Point(91, 10)
        Me.cboMarketer.Margin = New System.Windows.Forms.Padding(4)
        Me.cboMarketer.Name = "cboMarketer"
        Me.cboMarketer.Size = New System.Drawing.Size(215, 21)
        Me.cboMarketer.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(52, 438)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 25)
        Me.Button1.TabIndex = 30
        Me.Button1.TabStop = False
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(97, 100)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "$"
        '
        'cboPriLead
        '
        Me.cboPriLead.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboPriLead.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboPriLead.BackColor = System.Drawing.SystemColors.Window
        Me.cboPriLead.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPriLead.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPriLead.FormattingEnabled = True
        Me.cboPriLead.Location = New System.Drawing.Point(547, 10)
        Me.cboPriLead.Margin = New System.Windows.Forms.Padding(4)
        Me.cboPriLead.Name = "cboPriLead"
        Me.cboPriLead.Size = New System.Drawing.Size(211, 21)
        Me.cboPriLead.TabIndex = 2
        '
        'epEnterLead
        '
        Me.epEnterLead.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.epEnterLead.ContainerControl = Me
        '
        'GroupBox13
        '
        Me.GroupBox13.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox13.Controls.Add(Me.Label26)
        Me.GroupBox13.Controls.Add(Me.txtApptTime)
        Me.GroupBox13.Controls.Add(Me.Label25)
        Me.GroupBox13.Controls.Add(Me.Label23)
        Me.GroupBox13.Controls.Add(Me.dtpApptInfo)
        Me.GroupBox13.Controls.Add(Me.txtApptday)
        Me.GroupBox13.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox13.ForeColor = System.Drawing.Color.Black
        Me.GroupBox13.Location = New System.Drawing.Point(204, 290)
        Me.GroupBox13.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox13.Size = New System.Drawing.Size(215, 137)
        Me.GroupBox13.TabIndex = 25
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "Appointment Info:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(8, 100)
        Me.Label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(40, 13)
        Me.Label26.TabIndex = 0
        Me.Label26.Text = "Time:"
        '
        'txtApptTime
        '
        Me.txtApptTime.CustomFormat = "h:mm tt"
        Me.txtApptTime.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApptTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtApptTime.Location = New System.Drawing.Point(80, 94)
        Me.txtApptTime.Margin = New System.Windows.Forms.Padding(4)
        Me.txtApptTime.Name = "txtApptTime"
        Me.txtApptTime.ShowUpDown = True
        Me.txtApptTime.Size = New System.Drawing.Size(107, 21)
        Me.txtApptTime.TabIndex = 31
        Me.txtApptTime.Value = New Date(1900, 1, 1, 12, 36, 0, 0)
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(8, 63)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(35, 13)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "Day:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(8, 26)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(39, 13)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "Date:"
        '
        'dtpApptInfo
        '
        Me.dtpApptInfo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpApptInfo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpApptInfo.Location = New System.Drawing.Point(80, 21)
        Me.dtpApptInfo.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpApptInfo.Name = "dtpApptInfo"
        Me.dtpApptInfo.Size = New System.Drawing.Size(107, 21)
        Me.dtpApptInfo.TabIndex = 29
        Me.dtpApptInfo.Value = New Date(2014, 10, 30, 0, 0, 0, 0)
        '
        'txtApptday
        '
        Me.txtApptday.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApptday.Location = New System.Drawing.Point(80, 59)
        Me.txtApptday.Margin = New System.Windows.Forms.Padding(4)
        Me.txtApptday.Name = "txtApptday"
        Me.txtApptday.Size = New System.Drawing.Size(107, 21)
        Me.txtApptday.TabIndex = 30
        Me.txtApptday.TabStop = False
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.BackColor = System.Drawing.Color.Transparent
        Me.Label63.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.ForeColor = System.Drawing.Color.Black
        Me.Label63.Location = New System.Drawing.Point(450, 290)
        Me.Label63.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(124, 13)
        Me.Label63.TabIndex = 17
        Me.Label63.Text = "Special Instructions:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(167, 100)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "K"
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label68.ForeColor = System.Drawing.Color.Black
        Me.Label68.Location = New System.Drawing.Point(8, 100)
        Me.Label68.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(81, 13)
        Me.Label68.TabIndex = 0
        Me.Label68.Text = "Home Value:"
        '
        'rtfSpecialIns
        '
        Me.rtfSpecialIns.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtfSpecialIns.Location = New System.Drawing.Point(453, 315)
        Me.rtfSpecialIns.Margin = New System.Windows.Forms.Padding(4)
        Me.rtfSpecialIns.Name = "rtfSpecialIns"
        Me.rtfSpecialIns.Size = New System.Drawing.Size(456, 107)
        Me.rtfSpecialIns.TabIndex = 32
        Me.rtfSpecialIns.Text = ""
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(547, 430)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(144, 34)
        Me.btnCancel.TabIndex = 35
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSaveNew
        '
        Me.btnSaveNew.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveNew.Location = New System.Drawing.Point(395, 430)
        Me.btnSaveNew.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSaveNew.Name = "btnSaveNew"
        Me.btnSaveNew.Size = New System.Drawing.Size(144, 34)
        Me.btnSaveNew.TabIndex = 34
        Me.btnSaveNew.Text = "Save and New"
        Me.btnSaveNew.UseVisualStyleBackColor = True
        '
        'btnSaveClose
        '
        Me.btnSaveClose.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveClose.Location = New System.Drawing.Point(243, 430)
        Me.btnSaveClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSaveClose.Name = "btnSaveClose"
        Me.btnSaveClose.Size = New System.Drawing.Size(144, 34)
        Me.btnSaveClose.TabIndex = 33
        Me.btnSaveClose.Text = "Save and Close"
        Me.btnSaveClose.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(17, 46)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Lead Generated On:"
        '
        'dtpLeadGen
        '
        Me.dtpLeadGen.CalendarMonthBackground = System.Drawing.SystemColors.Control
        Me.dtpLeadGen.CalendarTitleBackColor = System.Drawing.SystemColors.Control
        Me.dtpLeadGen.CalendarTitleForeColor = System.Drawing.SystemColors.ControlText
        Me.dtpLeadGen.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpLeadGen.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpLeadGen.Location = New System.Drawing.Point(148, 43)
        Me.dtpLeadGen.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpLeadGen.Name = "dtpLeadGen"
        Me.dtpLeadGen.Size = New System.Drawing.Size(136, 21)
        Me.dtpLeadGen.TabIndex = 15
        Me.dtpLeadGen.TabStop = False
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.BackColor = System.Drawing.Color.Transparent
        Me.Label41.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.Black
        Me.Label41.Location = New System.Drawing.Point(391, 46)
        Me.Label41.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(148, 13)
        Me.Label41.TabIndex = 18
        Me.Label41.Text = "Secondary Lead Source:"
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label69.ForeColor = System.Drawing.Color.Black
        Me.Label69.Location = New System.Drawing.Point(8, 63)
        Me.Label69.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(86, 13)
        Me.Label69.TabIndex = 0
        Me.Label69.Text = "Age of Home:"
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label70.ForeColor = System.Drawing.Color.Black
        Me.Label70.Location = New System.Drawing.Point(8, 26)
        Me.Label70.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(87, 13)
        Me.Label70.TabIndex = 0
        Me.Label70.Text = "Years Owned:"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.BackColor = System.Drawing.Color.Transparent
        Me.Label42.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.Black
        Me.Label42.Location = New System.Drawing.Point(391, 14)
        Me.Label42.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(136, 13)
        Me.Label42.TabIndex = 20
        Me.Label42.Text = "Primary  Lead Source:"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.BackColor = System.Drawing.Color.Transparent
        Me.Label43.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.Black
        Me.Label43.Location = New System.Drawing.Point(20, 12)
        Me.Label43.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(63, 13)
        Me.Label43.TabIndex = 19
        Me.Label43.Text = "Marketer:"
        '
        'cboSecLead
        '
        Me.cboSecLead.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSecLead.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSecLead.BackColor = System.Drawing.SystemColors.Window
        Me.cboSecLead.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSecLead.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSecLead.FormattingEnabled = True
        Me.cboSecLead.Location = New System.Drawing.Point(547, 43)
        Me.cboSecLead.Margin = New System.Windows.Forms.Padding(4)
        Me.cboSecLead.Name = "cboSecLead"
        Me.cboSecLead.Size = New System.Drawing.Size(212, 21)
        Me.cboSecLead.TabIndex = 3
        '
        'GroupBox11
        '
        Me.GroupBox11.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox11.Controls.Add(Me.Label3)
        Me.GroupBox11.Controls.Add(Me.Label1)
        Me.GroupBox11.Controls.Add(Me.txtHomeVal)
        Me.GroupBox11.Controls.Add(Me.txtAgeOfHome)
        Me.GroupBox11.Controls.Add(Me.txtYearsOwned)
        Me.GroupBox11.Controls.Add(Me.Label68)
        Me.GroupBox11.Controls.Add(Me.Label69)
        Me.GroupBox11.Controls.Add(Me.Label70)
        Me.GroupBox11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox11.ForeColor = System.Drawing.Color.Black
        Me.GroupBox11.Location = New System.Drawing.Point(8, 286)
        Me.GroupBox11.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox11.Size = New System.Drawing.Size(188, 137)
        Me.GroupBox11.TabIndex = 24
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Home Info:"
        '
        'txtMarketingManager
        '
        Me.txtMarketingManager.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarketingManager.Location = New System.Drawing.Point(783, 14)
        Me.txtMarketingManager.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMarketingManager.Name = "txtMarketingManager"
        Me.txtMarketingManager.Size = New System.Drawing.Size(96, 21)
        Me.txtMarketingManager.TabIndex = 202
        Me.txtMarketingManager.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(28, 437)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 203
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'BackgroundWorker1
        '
        '
        'EnterLead
        '
        Me.AcceptButton = Me.btnSaveNew
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 471)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtMarketingManager)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.cboMarketer)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cboPriLead)
        Me.Controls.Add(Me.GroupBox13)
        Me.Controls.Add(Me.Label63)
        Me.Controls.Add(Me.rtfSpecialIns)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSaveNew)
        Me.Controls.Add(Me.btnSaveClose)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpLeadGen)
        Me.Controls.Add(Me.Label41)
        Me.Controls.Add(Me.Label42)
        Me.Controls.Add(Me.Label43)
        Me.Controls.Add(Me.cboSecLead)
        Me.Controls.Add(Me.GroupBox11)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EnterLead"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enter New Record"
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        CType(Me.epEnterLead, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtProdQTY As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cboProduct1 As System.Windows.Forms.ComboBox
    Friend WithEvents txtZip As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents txtProdColor As System.Windows.Forms.TextBox
    Friend WithEvents txtAltPhone2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cboProduct3 As System.Windows.Forms.ComboBox
    Friend WithEvents txtAltPhone1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtHousePhone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cboAltPhone2Type As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents cboProduct2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents cboAlt1Type As System.Windows.Forms.ComboBox
    Friend WithEvents cboC2Work As System.Windows.Forms.ComboBox
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents cboSpokeWith As System.Windows.Forms.ComboBox
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents cboC1Work As System.Windows.Forms.ComboBox
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents txtStAddy As System.Windows.Forms.TextBox
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents txtC2LName As System.Windows.Forms.TextBox
    Friend WithEvents txtC2FName As System.Windows.Forms.TextBox
    Friend WithEvents txtC1LName As System.Windows.Forms.TextBox
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents txtHomeVal As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtAgeOfHome As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtYearsOwned As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cboMarketer As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboPriLead As System.Windows.Forms.ComboBox
    Friend WithEvents epEnterLead As System.Windows.Forms.ErrorProvider
    Friend WithEvents GroupBox13 As System.Windows.Forms.GroupBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents dtpApptInfo As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtApptday As System.Windows.Forms.TextBox
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents rtfSpecialIns As System.Windows.Forms.RichTextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSaveNew As System.Windows.Forms.Button
    Friend WithEvents btnSaveClose As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpLeadGen As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents cboSecLead As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtC1FName As System.Windows.Forms.TextBox
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents txtApptTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtP1acro As System.Windows.Forms.TextBox
    Friend WithEvents txtP3acro As System.Windows.Forms.TextBox
    Friend WithEvents txtP2acro As System.Windows.Forms.TextBox
    Friend WithEvents txtMarketingManager As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
