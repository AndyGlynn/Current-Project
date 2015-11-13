<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditCompanyInformation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditCompanyInformation))
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.txtLogoDirectory = New System.Windows.Forms.TextBox()
        Me.txtFaxNumber = New System.Windows.Forms.TextBox()
        Me.txtWebsite = New System.Windows.Forms.TextBox()
        Me.txtContactPhoneNumber = New System.Windows.Forms.TextBox()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtAddressLine2 = New System.Windows.Forms.TextBox()
        Me.txtStreetAddress = New System.Windows.Forms.TextBox()
        Me.txtCompanyName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.chkSameSettings = New System.Windows.Forms.CheckBox()
        Me.rdoPopAuthen = New System.Windows.Forms.RadioButton()
        Me.chkOutgoingRequiresAuthen = New System.Windows.Forms.CheckBox()
        Me.chkOutgoingSSL = New System.Windows.Forms.CheckBox()
        Me.rdoSecurePassword = New System.Windows.Forms.RadioButton()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.rdoClearText = New System.Windows.Forms.RadioButton()
        Me.txtPasswordOut = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtEmailPassword = New System.Windows.Forms.TextBox()
        Me.txtUserOut = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtEmailUser = New System.Windows.Forms.TextBox()
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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(408, 301)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(199, 23)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(615, 301)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(199, 23)
        Me.btnUpdate.TabIndex = 1
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBrowse)
        Me.GroupBox1.Controls.Add(Me.txtLogoDirectory)
        Me.GroupBox1.Controls.Add(Me.txtFaxNumber)
        Me.GroupBox1.Controls.Add(Me.txtWebsite)
        Me.GroupBox1.Controls.Add(Me.txtContactPhoneNumber)
        Me.GroupBox1.Controls.Add(Me.txtZip)
        Me.GroupBox1.Controls.Add(Me.txtState)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtCity)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtAddressLine2)
        Me.GroupBox1.Controls.Add(Me.txtStreetAddress)
        Me.GroupBox1.Controls.Add(Me.txtCompanyName)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(0, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(789, 236)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Company Information"
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(724, 202)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(50, 23)
        Me.btnBrowse.TabIndex = 20
        Me.btnBrowse.Text = "..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'txtLogoDirectory
        '
        Me.txtLogoDirectory.Location = New System.Drawing.Point(149, 204)
        Me.txtLogoDirectory.Name = "txtLogoDirectory"
        Me.txtLogoDirectory.Size = New System.Drawing.Size(567, 21)
        Me.txtLogoDirectory.TabIndex = 19
        '
        'txtFaxNumber
        '
        Me.txtFaxNumber.Location = New System.Drawing.Point(582, 54)
        Me.txtFaxNumber.Name = "txtFaxNumber"
        Me.txtFaxNumber.Size = New System.Drawing.Size(192, 21)
        Me.txtFaxNumber.TabIndex = 17
        '
        'txtWebsite
        '
        Me.txtWebsite.Location = New System.Drawing.Point(149, 170)
        Me.txtWebsite.Name = "txtWebsite"
        Me.txtWebsite.Size = New System.Drawing.Size(625, 21)
        Me.txtWebsite.TabIndex = 18
        '
        'txtContactPhoneNumber
        '
        Me.txtContactPhoneNumber.Location = New System.Drawing.Point(582, 27)
        Me.txtContactPhoneNumber.Name = "txtContactPhoneNumber"
        Me.txtContactPhoneNumber.Size = New System.Drawing.Size(192, 21)
        Me.txtContactPhoneNumber.TabIndex = 16
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(530, 137)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(244, 21)
        Me.txtZip.TabIndex = 15
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(530, 111)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(244, 21)
        Me.txtState.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 174)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Company Website:"
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(149, 140)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(230, 21)
        Me.txtCity.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(19, 204)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Logo Directory:"
        '
        'txtAddressLine2
        '
        Me.txtAddressLine2.Location = New System.Drawing.Point(149, 110)
        Me.txtAddressLine2.Name = "txtAddressLine2"
        Me.txtAddressLine2.Size = New System.Drawing.Size(230, 21)
        Me.txtAddressLine2.TabIndex = 12
        '
        'txtStreetAddress
        '
        Me.txtStreetAddress.Location = New System.Drawing.Point(149, 56)
        Me.txtStreetAddress.Name = "txtStreetAddress"
        Me.txtStreetAddress.Size = New System.Drawing.Size(230, 21)
        Me.txtStreetAddress.TabIndex = 11
        '
        'txtCompanyName
        '
        Me.txtCompanyName.Location = New System.Drawing.Point(149, 29)
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.Size = New System.Drawing.Size(230, 21)
        Me.txtCompanyName.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(394, 57)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(129, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Contact Fax Number:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(394, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Contact Phone Number:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(399, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Zip:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(399, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "State:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "City:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Address Line 2:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Street Address:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Company Name:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(14, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(805, 273)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(797, 247)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Company Information"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.chkSameSettings)
        Me.TabPage2.Controls.Add(Me.rdoPopAuthen)
        Me.TabPage2.Controls.Add(Me.chkOutgoingRequiresAuthen)
        Me.TabPage2.Controls.Add(Me.chkOutgoingSSL)
        Me.TabPage2.Controls.Add(Me.rdoSecurePassword)
        Me.TabPage2.Controls.Add(Me.Label22)
        Me.TabPage2.Controls.Add(Me.rdoClearText)
        Me.TabPage2.Controls.Add(Me.txtPasswordOut)
        Me.TabPage2.Controls.Add(Me.Label19)
        Me.TabPage2.Controls.Add(Me.Label23)
        Me.TabPage2.Controls.Add(Me.txtEmailPassword)
        Me.TabPage2.Controls.Add(Me.txtUserOut)
        Me.TabPage2.Controls.Add(Me.Label20)
        Me.TabPage2.Controls.Add(Me.txtEmailUser)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.txtEmail)
        Me.TabPage2.Controls.Add(Me.chkOutgoingPortSSL)
        Me.TabPage2.Controls.Add(Me.txtOutgoingPort)
        Me.TabPage2.Controls.Add(Me.Label21)
        Me.TabPage2.Controls.Add(Me.chkIncomingPortSSL)
        Me.TabPage2.Controls.Add(Me.txtIncomingPort)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.Label18)
        Me.TabPage2.Controls.Add(Me.txtIncoming)
        Me.TabPage2.Controls.Add(Me.txtOutgoing)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(797, 247)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Default Email Setup"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'chkSameSettings
        '
        Me.chkSameSettings.AutoSize = True
        Me.chkSameSettings.Checked = True
        Me.chkSameSettings.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSameSettings.Location = New System.Drawing.Point(450, 131)
        Me.chkSameSettings.Name = "chkSameSettings"
        Me.chkSameSettings.Size = New System.Drawing.Size(293, 17)
        Me.chkSameSettings.TabIndex = 82
        Me.chkSameSettings.Text = "Use same settings as my incoming mail server"
        Me.chkSameSettings.UseVisualStyleBackColor = True
        '
        'rdoPopAuthen
        '
        Me.rdoPopAuthen.AutoSize = True
        Me.rdoPopAuthen.Location = New System.Drawing.Point(409, 63)
        Me.rdoPopAuthen.Name = "rdoPopAuthen"
        Me.rdoPopAuthen.Size = New System.Drawing.Size(250, 17)
        Me.rdoPopAuthen.TabIndex = 73
        Me.rdoPopAuthen.TabStop = True
        Me.rdoPopAuthen.Text = "Log on using authenticated POP (APOP)"
        Me.rdoPopAuthen.UseVisualStyleBackColor = True
        '
        'chkOutgoingRequiresAuthen
        '
        Me.chkOutgoingRequiresAuthen.AutoSize = True
        Me.chkOutgoingRequiresAuthen.Location = New System.Drawing.Point(451, 97)
        Me.chkOutgoingRequiresAuthen.Name = "chkOutgoingRequiresAuthen"
        Me.chkOutgoingRequiresAuthen.Size = New System.Drawing.Size(271, 17)
        Me.chkOutgoingRequiresAuthen.TabIndex = 81
        Me.chkOutgoingRequiresAuthen.Text = "My outgoing server requires authentication"
        Me.chkOutgoingRequiresAuthen.UseVisualStyleBackColor = True
        '
        'chkOutgoingSSL
        '
        Me.chkOutgoingSSL.AutoSize = True
        Me.chkOutgoingSSL.Enabled = False
        Me.chkOutgoingSSL.Location = New System.Drawing.Point(504, 221)
        Me.chkOutgoingSSL.Name = "chkOutgoingSSL"
        Me.chkOutgoingSSL.Size = New System.Drawing.Size(282, 17)
        Me.chkOutgoingSSL.TabIndex = 85
        Me.chkOutgoingSSL.Text = "Log on using secure password authentication"
        Me.chkOutgoingSSL.UseVisualStyleBackColor = True
        '
        'rdoSecurePassword
        '
        Me.rdoSecurePassword.AutoSize = True
        Me.rdoSecurePassword.Location = New System.Drawing.Point(409, 40)
        Me.rdoSecurePassword.Name = "rdoSecurePassword"
        Me.rdoSecurePassword.Size = New System.Drawing.Size(281, 17)
        Me.rdoSecurePassword.TabIndex = 72
        Me.rdoSecurePassword.TabStop = True
        Me.rdoSecurePassword.Text = "Log on using secure password authentication"
        Me.rdoSecurePassword.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(447, 195)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(66, 13)
        Me.Label22.TabIndex = 87
        Me.Label22.Text = "Password:"
        '
        'rdoClearText
        '
        Me.rdoClearText.AutoSize = True
        Me.rdoClearText.Location = New System.Drawing.Point(409, 17)
        Me.rdoClearText.Name = "rdoClearText"
        Me.rdoClearText.Size = New System.Drawing.Size(239, 17)
        Me.rdoClearText.TabIndex = 71
        Me.rdoClearText.TabStop = True
        Me.rdoClearText.Text = "Log on using clear text authentication"
        Me.rdoClearText.UseVisualStyleBackColor = True
        '
        'txtPasswordOut
        '
        Me.txtPasswordOut.Enabled = False
        Me.txtPasswordOut.Location = New System.Drawing.Point(556, 192)
        Me.txtPasswordOut.Name = "txtPasswordOut"
        Me.txtPasswordOut.Size = New System.Drawing.Size(230, 21)
        Me.txtPasswordOut.TabIndex = 84
        Me.txtPasswordOut.UseSystemPasswordChar = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(7, 83)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(66, 13)
        Me.Label19.TabIndex = 70
        Me.Label19.Text = "Password:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(447, 162)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(110, 13)
        Me.Label23.TabIndex = 86
        Me.Label23.Text = "Email User Name:"
        '
        'txtEmailPassword
        '
        Me.txtEmailPassword.Location = New System.Drawing.Point(145, 80)
        Me.txtEmailPassword.Name = "txtEmailPassword"
        Me.txtEmailPassword.Size = New System.Drawing.Size(230, 21)
        Me.txtEmailPassword.TabIndex = 68
        Me.txtEmailPassword.UseSystemPasswordChar = True
        '
        'txtUserOut
        '
        Me.txtUserOut.Enabled = False
        Me.txtUserOut.Location = New System.Drawing.Point(556, 159)
        Me.txtUserOut.Name = "txtUserOut"
        Me.txtUserOut.Size = New System.Drawing.Size(230, 21)
        Me.txtUserOut.TabIndex = 83
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(7, 50)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(110, 13)
        Me.Label20.TabIndex = 69
        Me.Label20.Text = "Email User Name:"
        '
        'txtEmailUser
        '
        Me.txtEmailUser.Location = New System.Drawing.Point(145, 47)
        Me.txtEmailUser.Name = "txtEmailUser"
        Me.txtEmailUser.Size = New System.Drawing.Size(230, 21)
        Me.txtEmailUser.TabIndex = 67
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(7, 17)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(93, 13)
        Me.Label14.TabIndex = 66
        Me.Label14.Text = "Email Address:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(145, 14)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(230, 21)
        Me.txtEmail.TabIndex = 65
        '
        'chkOutgoingPortSSL
        '
        Me.chkOutgoingPortSSL.AutoSize = True
        Me.chkOutgoingPortSSL.Location = New System.Drawing.Point(204, 214)
        Me.chkOutgoingPortSSL.Name = "chkOutgoingPortSSL"
        Me.chkOutgoingPortSSL.Size = New System.Drawing.Size(224, 17)
        Me.chkOutgoingPortSSL.TabIndex = 60
        Me.chkOutgoingPortSSL.Text = "Requires Secure Connection (SSL)"
        Me.chkOutgoingPortSSL.UseVisualStyleBackColor = True
        '
        'txtOutgoingPort
        '
        Me.txtOutgoingPort.Location = New System.Drawing.Point(145, 212)
        Me.txtOutgoingPort.Name = "txtOutgoingPort"
        Me.txtOutgoingPort.Size = New System.Drawing.Size(54, 21)
        Me.txtOutgoingPort.TabIndex = 59
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(7, 215)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(135, 13)
        Me.Label21.TabIndex = 64
        Me.Label21.Text = "Outgoing Port (SMTP):"
        '
        'chkIncomingPortSSL
        '
        Me.chkIncomingPortSSL.AutoSize = True
        Me.chkIncomingPortSSL.Location = New System.Drawing.Point(204, 181)
        Me.chkIncomingPortSSL.Name = "chkIncomingPortSSL"
        Me.chkIncomingPortSSL.Size = New System.Drawing.Size(224, 17)
        Me.chkIncomingPortSSL.TabIndex = 58
        Me.chkIncomingPortSSL.Text = "Requires Secure Connection (SSL)"
        Me.chkIncomingPortSSL.UseVisualStyleBackColor = True
        '
        'txtIncomingPort
        '
        Me.txtIncomingPort.Location = New System.Drawing.Point(145, 179)
        Me.txtIncomingPort.Name = "txtIncomingPort"
        Me.txtIncomingPort.Size = New System.Drawing.Size(54, 21)
        Me.txtIncomingPort.TabIndex = 57
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(7, 182)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(136, 13)
        Me.Label15.TabIndex = 63
        Me.Label15.Text = "Incoming Port (POP3):"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(7, 149)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(134, 13)
        Me.Label18.TabIndex = 62
        Me.Label18.Text = "Outgoing Mail (SMTP):"
        '
        'txtIncoming
        '
        Me.txtIncoming.Location = New System.Drawing.Point(145, 113)
        Me.txtIncoming.Name = "txtIncoming"
        Me.txtIncoming.Size = New System.Drawing.Size(282, 21)
        Me.txtIncoming.TabIndex = 55
        '
        'txtOutgoing
        '
        Me.txtOutgoing.Location = New System.Drawing.Point(145, 146)
        Me.txtOutgoing.Name = "txtOutgoing"
        Me.txtOutgoing.Size = New System.Drawing.Size(282, 21)
        Me.txtOutgoing.TabIndex = 56
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(7, 116)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(135, 13)
        Me.Label17.TabIndex = 61
        Me.Label17.Text = "Incoming Mail (POP3):"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmEditCompanyInformation
        '
        Me.AcceptButton = Me.btnUpdate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(829, 334)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnCancel)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEditCompanyInformation"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Company Settings"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtWebsite As System.Windows.Forms.TextBox
    Friend WithEvents txtFaxNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtContactPhoneNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtZip As System.Windows.Forms.TextBox
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents txtAddressLine2 As System.Windows.Forms.TextBox
    Friend WithEvents txtStreetAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtCompanyName As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtLogoDirectory As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
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
    Friend WithEvents rdoPopAuthen As System.Windows.Forms.RadioButton
    Friend WithEvents rdoSecurePassword As System.Windows.Forms.RadioButton
    Friend WithEvents rdoClearText As System.Windows.Forms.RadioButton
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtEmailPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtEmailUser As System.Windows.Forms.TextBox
    Friend WithEvents chkSameSettings As System.Windows.Forms.CheckBox
    Friend WithEvents chkOutgoingRequiresAuthen As System.Windows.Forms.CheckBox
    Friend WithEvents chkOutgoingSSL As System.Windows.Forms.CheckBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtPasswordOut As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtUserOut As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog

End Class
