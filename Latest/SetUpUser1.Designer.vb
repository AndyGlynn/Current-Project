<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SetUpUser1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SetUpUser1))
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.pnlUserName = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboManager = New System.Windows.Forms.ComboBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblLName = New System.Windows.Forms.Label()
        Me.lblFName = New System.Windows.Forms.Label()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlAccess = New System.Windows.Forms.Panel()
        Me.lblUncheckAll = New System.Windows.Forms.Label()
        Me.lblCheckAll = New System.Windows.Forms.Label()
        Me.chkCanEmail = New System.Windows.Forms.CheckBox()
        Me.cboStartForm = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.chklstForms = New System.Windows.Forms.CheckedListBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlEmail = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.chkOutgoingPortSSL = New System.Windows.Forms.CheckBox()
        Me.txtOutgoingPort = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.chkIncomingPortSSL = New System.Windows.Forms.CheckBox()
        Me.txtIncomingPort = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtIncoming = New System.Windows.Forms.TextBox()
        Me.txtOutgoing = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.rdoPopAuthen = New System.Windows.Forms.RadioButton()
        Me.rdoSecurePassword = New System.Windows.Forms.RadioButton()
        Me.rdoClearText = New System.Windows.Forms.RadioButton()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtEmailPassword = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtEmailUser = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.chkSameSettings = New System.Windows.Forms.CheckBox()
        Me.chkOutgoingRequiresAuthen = New System.Windows.Forms.CheckBox()
        Me.chkOutgoingSSL = New System.Windows.Forms.CheckBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtPasswordOut = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtUserOut = New System.Windows.Forms.TextBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnlUserName.SuspendLayout()
        Me.pnlAccess.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlEmail.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(87, 263)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(105, 22)
        Me.btnBack.TabIndex = 90
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(239, 263)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(105, 22)
        Me.btnSave.TabIndex = 70
        Me.btnSave.Text = "Finish"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(391, 263)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(105, 22)
        Me.btnCancel.TabIndex = 80
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'pnlUserName
        '
        Me.pnlUserName.Controls.Add(Me.Label8)
        Me.pnlUserName.Controls.Add(Me.cboManager)
        Me.pnlUserName.Controls.Add(Me.txtUserName)
        Me.pnlUserName.Controls.Add(Me.Label11)
        Me.pnlUserName.Controls.Add(Me.Label10)
        Me.pnlUserName.Controls.Add(Me.txtConfirmPassword)
        Me.pnlUserName.Controls.Add(Me.txtPassword)
        Me.pnlUserName.Controls.Add(Me.Label7)
        Me.pnlUserName.Controls.Add(Me.Label6)
        Me.pnlUserName.Controls.Add(Me.lblLName)
        Me.pnlUserName.Controls.Add(Me.lblFName)
        Me.pnlUserName.Controls.Add(Me.txtLName)
        Me.pnlUserName.Controls.Add(Me.txtFName)
        Me.pnlUserName.Controls.Add(Me.Label3)
        Me.pnlUserName.Controls.Add(Me.Label2)
        Me.pnlUserName.Controls.Add(Me.Label1)
        Me.pnlUserName.Location = New System.Drawing.Point(87, 6)
        Me.pnlUserName.Name = "pnlUserName"
        Me.pnlUserName.Size = New System.Drawing.Size(410, 239)
        Me.pnlUserName.TabIndex = 25
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(22, 79)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Login:"
        '
        'cboManager
        '
        Me.cboManager.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboManager.FormattingEnabled = True
        Me.cboManager.Location = New System.Drawing.Point(134, 208)
        Me.cboManager.Name = "cboManager"
        Me.cboManager.Size = New System.Drawing.Size(198, 21)
        Me.cboManager.TabIndex = 6
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(134, 76)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(198, 20)
        Me.txtUserName.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(338, 212)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 13)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "(Optional)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(22, 212)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 13)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Manager Name:"
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Location = New System.Drawing.Point(134, 175)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.Size = New System.Drawing.Size(198, 20)
        Me.txtConfirmPassword.TabIndex = 5
        Me.txtConfirmPassword.UseSystemPasswordChar = True
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(134, 142)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(198, 20)
        Me.txtPassword.TabIndex = 4
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 178)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Confirm Password:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Password:"
        '
        'lblLName
        '
        Me.lblLName.AutoSize = True
        Me.lblLName.BackColor = System.Drawing.Color.White
        Me.lblLName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblLName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLName.ForeColor = System.Drawing.Color.Gray
        Me.lblLName.Location = New System.Drawing.Point(243, 113)
        Me.lblLName.Name = "lblLName"
        Me.lblLName.Size = New System.Drawing.Size(58, 13)
        Me.lblLName.TabIndex = 31
        Me.lblLName.Text = "Last Name"
        '
        'lblFName
        '
        Me.lblFName.AutoSize = True
        Me.lblFName.BackColor = System.Drawing.Color.White
        Me.lblFName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblFName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFName.ForeColor = System.Drawing.Color.Gray
        Me.lblFName.Location = New System.Drawing.Point(141, 113)
        Me.lblFName.Name = "lblFName"
        Me.lblFName.Size = New System.Drawing.Size(57, 13)
        Me.lblFName.TabIndex = 30
        Me.lblFName.Text = "First Name"
        '
        'txtLName
        '
        Me.txtLName.Location = New System.Drawing.Point(236, 109)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(96, 20)
        Me.txtLName.TabIndex = 3
        '
        'txtFName
        '
        Me.txtFName.Location = New System.Drawing.Point(134, 109)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(96, 20)
        Me.txtFName.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "User Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(265, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Provide a name and an optional password for this user."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 23)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "User Name and Password"
        '
        'pnlAccess
        '
        Me.pnlAccess.Controls.Add(Me.lblUncheckAll)
        Me.pnlAccess.Controls.Add(Me.lblCheckAll)
        Me.pnlAccess.Controls.Add(Me.chkCanEmail)
        Me.pnlAccess.Controls.Add(Me.cboStartForm)
        Me.pnlAccess.Controls.Add(Me.Label9)
        Me.pnlAccess.Controls.Add(Me.chklstForms)
        Me.pnlAccess.Controls.Add(Me.Label12)
        Me.pnlAccess.Controls.Add(Me.Label13)
        Me.pnlAccess.Location = New System.Drawing.Point(87, 6)
        Me.pnlAccess.Name = "pnlAccess"
        Me.pnlAccess.Size = New System.Drawing.Size(410, 239)
        Me.pnlAccess.TabIndex = 26
        '
        'lblUncheckAll
        '
        Me.lblUncheckAll.AutoSize = True
        Me.lblUncheckAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblUncheckAll.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUncheckAll.ForeColor = System.Drawing.Color.Gray
        Me.lblUncheckAll.Location = New System.Drawing.Point(120, 221)
        Me.lblUncheckAll.Name = "lblUncheckAll"
        Me.lblUncheckAll.Size = New System.Drawing.Size(72, 13)
        Me.lblUncheckAll.TabIndex = 9
        Me.lblUncheckAll.Text = "Uncheck All"
        '
        'lblCheckAll
        '
        Me.lblCheckAll.AutoSize = True
        Me.lblCheckAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblCheckAll.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCheckAll.ForeColor = System.Drawing.Color.Gray
        Me.lblCheckAll.Location = New System.Drawing.Point(22, 221)
        Me.lblCheckAll.Name = "lblCheckAll"
        Me.lblCheckAll.Size = New System.Drawing.Size(58, 13)
        Me.lblCheckAll.TabIndex = 8
        Me.lblCheckAll.Text = "Check All"
        '
        'chkCanEmail
        '
        Me.chkCanEmail.AutoSize = True
        Me.chkCanEmail.Location = New System.Drawing.Point(211, 175)
        Me.chkCanEmail.Name = "chkCanEmail"
        Me.chkCanEmail.Size = New System.Drawing.Size(165, 17)
        Me.chkCanEmail.TabIndex = 11
        Me.chkCanEmail.Text = "Allow Access to Email Wizard"
        Me.chkCanEmail.UseVisualStyleBackColor = True
        '
        'cboStartForm
        '
        Me.cboStartForm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStartForm.FormattingEnabled = True
        Me.cboStartForm.Location = New System.Drawing.Point(211, 126)
        Me.cboStartForm.Name = "cboStartForm"
        Me.cboStartForm.Size = New System.Drawing.Size(150, 21)
        Me.cboStartForm.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label9.Location = New System.Drawing.Point(208, 98)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(154, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Select this User's Startup Form:"
        '
        'chklstForms
        '
        Me.chklstForms.CheckOnClick = True
        Me.chklstForms.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chklstForms.FormattingEnabled = True
        Me.chklstForms.Items.AddRange(New Object() {"Cold Calling", "Warm Calling", "Previous Customers", "Recovery", "Confirming", "Marketing Manager", "Sales Department", "Installation Department", "Finance Department", "Administration"})
        Me.chklstForms.Location = New System.Drawing.Point(25, 54)
        Me.chklstForms.Name = "chklstForms"
        Me.chklstForms.Size = New System.Drawing.Size(167, 164)
        Me.chklstForms.TabIndex = 7
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(22, 35)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(262, 13)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Select the forms you want this user to have access to."
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(21, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(179, 23)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "Access for this User:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(73, 239)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'pnlEmail
        '
        Me.pnlEmail.Controls.Add(Me.Label16)
        Me.pnlEmail.Controls.Add(Me.TabControl1)
        Me.pnlEmail.Location = New System.Drawing.Point(87, 6)
        Me.pnlEmail.Name = "pnlEmail"
        Me.pnlEmail.Size = New System.Drawing.Size(410, 239)
        Me.pnlEmail.TabIndex = 27
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(21, 9)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(325, 23)
        Me.Label16.TabIndex = 7
        Me.Label16.Text = "Email Automation Setup for this User:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.ImageList = Me.ImageList1
        Me.TabControl1.Location = New System.Drawing.Point(3, 45)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.ShowToolTips = True
        Me.TabControl1.Size = New System.Drawing.Size(406, 194)
        Me.TabControl1.TabIndex = 12
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label14)
        Me.TabPage3.Controls.Add(Me.txtEmail)
        Me.TabPage3.Controls.Add(Me.chkOutgoingPortSSL)
        Me.TabPage3.Controls.Add(Me.txtOutgoingPort)
        Me.TabPage3.Controls.Add(Me.Label21)
        Me.TabPage3.Controls.Add(Me.chkIncomingPortSSL)
        Me.TabPage3.Controls.Add(Me.txtIncomingPort)
        Me.TabPage3.Controls.Add(Me.Label15)
        Me.TabPage3.Controls.Add(Me.Label18)
        Me.TabPage3.Controls.Add(Me.txtIncoming)
        Me.TabPage3.Controls.Add(Me.txtOutgoing)
        Me.TabPage3.Controls.Add(Me.Label17)
        Me.TabPage3.Location = New System.Drawing.Point(4, 23)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(398, 167)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Server Information"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(14, 10)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(76, 13)
        Me.Label14.TabIndex = 54
        Me.Label14.Text = "Email Address:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(145, 7)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(198, 20)
        Me.txtEmail.TabIndex = 53
        '
        'chkOutgoingPortSSL
        '
        Me.chkOutgoingPortSSL.AutoSize = True
        Me.chkOutgoingPortSSL.Location = New System.Drawing.Point(198, 141)
        Me.chkOutgoingPortSSL.Name = "chkOutgoingPortSSL"
        Me.chkOutgoingPortSSL.Size = New System.Drawing.Size(191, 17)
        Me.chkOutgoingPortSSL.TabIndex = 18
        Me.chkOutgoingPortSSL.Text = "Requires Secure Connection (SSL)"
        Me.chkOutgoingPortSSL.UseVisualStyleBackColor = True
        '
        'txtOutgoingPort
        '
        Me.txtOutgoingPort.Location = New System.Drawing.Point(145, 139)
        Me.txtOutgoingPort.Name = "txtOutgoingPort"
        Me.txtOutgoingPort.Size = New System.Drawing.Size(47, 20)
        Me.txtOutgoingPort.TabIndex = 17
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(14, 142)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(114, 13)
        Me.Label21.TabIndex = 49
        Me.Label21.Text = "Outgoing Port (SMTP):"
        '
        'chkIncomingPortSSL
        '
        Me.chkIncomingPortSSL.AutoSize = True
        Me.chkIncomingPortSSL.Location = New System.Drawing.Point(198, 108)
        Me.chkIncomingPortSSL.Name = "chkIncomingPortSSL"
        Me.chkIncomingPortSSL.Size = New System.Drawing.Size(191, 17)
        Me.chkIncomingPortSSL.TabIndex = 16
        Me.chkIncomingPortSSL.Text = "Requires Secure Connection (SSL)"
        Me.chkIncomingPortSSL.UseVisualStyleBackColor = True
        '
        'txtIncomingPort
        '
        Me.txtIncomingPort.Location = New System.Drawing.Point(145, 106)
        Me.txtIncomingPort.Name = "txtIncomingPort"
        Me.txtIncomingPort.Size = New System.Drawing.Size(47, 20)
        Me.txtIncomingPort.TabIndex = 15
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(14, 109)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(112, 13)
        Me.Label15.TabIndex = 46
        Me.Label15.Text = "Incoming Port (POP3):"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(14, 76)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(114, 13)
        Me.Label18.TabIndex = 45
        Me.Label18.Text = "Outgoing Mail (SMTP):"
        '
        'txtIncoming
        '
        Me.txtIncoming.Location = New System.Drawing.Point(145, 40)
        Me.txtIncoming.Name = "txtIncoming"
        Me.txtIncoming.Size = New System.Drawing.Size(242, 20)
        Me.txtIncoming.TabIndex = 13
        '
        'txtOutgoing
        '
        Me.txtOutgoing.Location = New System.Drawing.Point(145, 73)
        Me.txtOutgoing.Name = "txtOutgoing"
        Me.txtOutgoing.Size = New System.Drawing.Size(242, 20)
        Me.txtOutgoing.TabIndex = 14
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(14, 43)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(112, 13)
        Me.Label17.TabIndex = 43
        Me.Label17.Text = "Incoming Mail (POP3):"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.rdoPopAuthen)
        Me.TabPage1.Controls.Add(Me.rdoSecurePassword)
        Me.TabPage1.Controls.Add(Me.rdoClearText)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.txtEmailPassword)
        Me.TabPage1.Controls.Add(Me.Label20)
        Me.TabPage1.Controls.Add(Me.txtEmailUser)
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(398, 167)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Incoming Mail Server"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'rdoPopAuthen
        '
        Me.rdoPopAuthen.AutoSize = True
        Me.rdoPopAuthen.Location = New System.Drawing.Point(78, 127)
        Me.rdoPopAuthen.Name = "rdoPopAuthen"
        Me.rdoPopAuthen.Size = New System.Drawing.Size(217, 17)
        Me.rdoPopAuthen.TabIndex = 59
        Me.rdoPopAuthen.TabStop = True
        Me.rdoPopAuthen.Text = "Log on using authenticated POP (APOP)"
        Me.rdoPopAuthen.UseVisualStyleBackColor = True
        '
        'rdoSecurePassword
        '
        Me.rdoSecurePassword.AutoSize = True
        Me.rdoSecurePassword.Location = New System.Drawing.Point(78, 104)
        Me.rdoSecurePassword.Name = "rdoSecurePassword"
        Me.rdoSecurePassword.Size = New System.Drawing.Size(239, 17)
        Me.rdoSecurePassword.TabIndex = 58
        Me.rdoSecurePassword.TabStop = True
        Me.rdoSecurePassword.Text = "Log on using secure password authentication"
        Me.rdoSecurePassword.UseVisualStyleBackColor = True
        '
        'rdoClearText
        '
        Me.rdoClearText.AutoSize = True
        Me.rdoClearText.Location = New System.Drawing.Point(78, 81)
        Me.rdoClearText.Name = "rdoClearText"
        Me.rdoClearText.Size = New System.Drawing.Size(202, 17)
        Me.rdoClearText.TabIndex = 57
        Me.rdoClearText.TabStop = True
        Me.rdoClearText.Text = "Log on using clear text authentication"
        Me.rdoClearText.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(14, 43)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(56, 13)
        Me.Label19.TabIndex = 56
        Me.Label19.Text = "Password:"
        '
        'txtEmailPassword
        '
        Me.txtEmailPassword.Location = New System.Drawing.Point(145, 40)
        Me.txtEmailPassword.Name = "txtEmailPassword"
        Me.txtEmailPassword.Size = New System.Drawing.Size(198, 20)
        Me.txtEmailPassword.TabIndex = 21
        Me.txtEmailPassword.UseSystemPasswordChar = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(14, 10)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(91, 13)
        Me.Label20.TabIndex = 54
        Me.Label20.Text = "Email User Name:"
        '
        'txtEmailUser
        '
        Me.txtEmailUser.Location = New System.Drawing.Point(145, 7)
        Me.txtEmailUser.Name = "txtEmailUser"
        Me.txtEmailUser.Size = New System.Drawing.Size(198, 20)
        Me.txtEmailUser.TabIndex = 20
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.chkSameSettings)
        Me.TabPage2.Controls.Add(Me.chkOutgoingRequiresAuthen)
        Me.TabPage2.Controls.Add(Me.chkOutgoingSSL)
        Me.TabPage2.Controls.Add(Me.Label22)
        Me.TabPage2.Controls.Add(Me.txtPasswordOut)
        Me.TabPage2.Controls.Add(Me.Label23)
        Me.TabPage2.Controls.Add(Me.txtUserOut)
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(398, 167)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Outgoing Mail Server"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'chkSameSettings
        '
        Me.chkSameSettings.AutoSize = True
        Me.chkSameSettings.Checked = True
        Me.chkSameSettings.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSameSettings.Location = New System.Drawing.Point(17, 45)
        Me.chkSameSettings.Name = "chkSameSettings"
        Me.chkSameSettings.Size = New System.Drawing.Size(240, 17)
        Me.chkSameSettings.TabIndex = 26
        Me.chkSameSettings.Text = "Use same settings as my incoming mail server"
        Me.chkSameSettings.UseVisualStyleBackColor = True
        '
        'chkOutgoingRequiresAuthen
        '
        Me.chkOutgoingRequiresAuthen.AutoSize = True
        Me.chkOutgoingRequiresAuthen.Location = New System.Drawing.Point(18, 11)
        Me.chkOutgoingRequiresAuthen.Name = "chkOutgoingRequiresAuthen"
        Me.chkOutgoingRequiresAuthen.Size = New System.Drawing.Size(226, 17)
        Me.chkOutgoingRequiresAuthen.TabIndex = 25
        Me.chkOutgoingRequiresAuthen.Text = "My outgoing server requires authentication"
        Me.chkOutgoingRequiresAuthen.UseVisualStyleBackColor = True
        '
        'chkOutgoingSSL
        '
        Me.chkOutgoingSSL.AutoSize = True
        Me.chkOutgoingSSL.Enabled = False
        Me.chkOutgoingSSL.Location = New System.Drawing.Point(83, 144)
        Me.chkOutgoingSSL.Name = "chkOutgoingSSL"
        Me.chkOutgoingSSL.Size = New System.Drawing.Size(240, 17)
        Me.chkOutgoingSSL.TabIndex = 29
        Me.chkOutgoingSSL.Text = "Log on using secure password authentication"
        Me.chkOutgoingSSL.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(14, 109)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(56, 13)
        Me.Label22.TabIndex = 61
        Me.Label22.Text = "Password:"
        '
        'txtPasswordOut
        '
        Me.txtPasswordOut.Enabled = False
        Me.txtPasswordOut.Location = New System.Drawing.Point(145, 106)
        Me.txtPasswordOut.Name = "txtPasswordOut"
        Me.txtPasswordOut.Size = New System.Drawing.Size(198, 20)
        Me.txtPasswordOut.TabIndex = 28
        Me.txtPasswordOut.UseSystemPasswordChar = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(14, 76)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(91, 13)
        Me.Label23.TabIndex = 59
        Me.Label23.Text = "Email User Name:"
        '
        'txtUserOut
        '
        Me.txtUserOut.Enabled = False
        Me.txtUserOut.Location = New System.Drawing.Point(145, 73)
        Me.txtUserOut.Name = "txtUserOut"
        Me.txtUserOut.Size = New System.Drawing.Size(198, 20)
        Me.txtUserOut.TabIndex = 27
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "danger.ico")
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        '
        'SetUpUser1
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(513, 297)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pnlAccess)
        Me.Controls.Add(Me.pnlUserName)
        Me.Controls.Add(Me.pnlEmail)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SetUpUser1"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "User Name and Password"
        Me.pnlUserName.ResumeLayout(False)
        Me.pnlUserName.PerformLayout()
        Me.pnlAccess.ResumeLayout(False)
        Me.pnlAccess.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlEmail.ResumeLayout(False)
        Me.pnlEmail.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents pnlUserName As System.Windows.Forms.Panel
    Friend WithEvents pnlAccess As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboManager As System.Windows.Forms.ComboBox
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtConfirmPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblLName As System.Windows.Forms.Label
    Friend WithEvents lblFName As System.Windows.Forms.Label
    Friend WithEvents txtLName As System.Windows.Forms.TextBox
    Friend WithEvents txtFName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboStartForm As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents chklstForms As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents pnlEmail As System.Windows.Forms.Panel
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents chkOutgoingPortSSL As System.Windows.Forms.CheckBox
    Friend WithEvents txtOutgoingPort As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents chkIncomingPortSSL As System.Windows.Forms.CheckBox
    Friend WithEvents txtIncomingPort As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtIncoming As System.Windows.Forms.TextBox
    Friend WithEvents txtOutgoing As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents txtEmailPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtEmailUser As System.Windows.Forms.TextBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents chkSameSettings As System.Windows.Forms.CheckBox
    Friend WithEvents chkOutgoingRequiresAuthen As System.Windows.Forms.CheckBox
    Friend WithEvents chkOutgoingSSL As System.Windows.Forms.CheckBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtPasswordOut As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtUserOut As System.Windows.Forms.TextBox
    Friend WithEvents chkCanEmail As System.Windows.Forms.CheckBox
    Friend WithEvents lblUncheckAll As System.Windows.Forms.Label
    Friend WithEvents lblCheckAll As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents rdoPopAuthen As System.Windows.Forms.RadioButton
    Friend WithEvents rdoSecurePassword As System.Windows.Forms.RadioButton
    Friend WithEvents rdoClearText As System.Windows.Forms.RadioButton
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
