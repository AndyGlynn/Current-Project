<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfirmingSingleRecord
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConfirmingSingleRecord))
        Me.gbSpecialInstructions = New System.Windows.Forms.GroupBox
        Me.rtbSpecialInstructions = New System.Windows.Forms.RichTextBox
        Me.gbProductInfo = New System.Windows.Forms.GroupBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.txtProducts = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblQty = New System.Windows.Forms.Label
        Me.ComboBox5 = New System.Windows.Forms.ComboBox
        Me.txtColor = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblColor = New System.Windows.Forms.Label
        Me.ComboBox6 = New System.Windows.Forms.ComboBox
        Me.txtQty = New System.Windows.Forms.TextBox
        Me.lblProducts = New System.Windows.Forms.Label
        Me.gbApptInfo = New System.Windows.Forms.GroupBox
        Me.txtApptDate = New System.Windows.Forms.TextBox
        Me.txtApptTime = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.lblApptDate = New System.Windows.Forms.Label
        Me.lblApptDay = New System.Windows.Forms.Label
        Me.txtApptDay = New System.Windows.Forms.TextBox
        Me.gbHomeInfo = New System.Windows.Forms.GroupBox
        Me.txtHomeValue = New System.Windows.Forms.TextBox
        Me.txtYrsOwned = New System.Windows.Forms.TextBox
        Me.lblYrBuilt = New System.Windows.Forms.Label
        Me.lblYrsOwned = New System.Windows.Forms.Label
        Me.lblHomeValue = New System.Windows.Forms.Label
        Me.txtYrBuilt = New System.Windows.Forms.TextBox
        Me.gbContactInfo = New System.Windows.Forms.GroupBox
        Me.txtHousePhone = New System.Windows.Forms.TextBox
        Me.txtaltphone2 = New System.Windows.Forms.TextBox
        Me.txtaltphone1 = New System.Windows.Forms.TextBox
        Me.lnkEmail = New System.Windows.Forms.LinkLabel
        Me.lblEmail = New System.Windows.Forms.Label
        Me.txtWorkHours = New System.Windows.Forms.TextBox
        Me.txtAlt1Type = New System.Windows.Forms.TextBox
        Me.txtAlt2Type = New System.Windows.Forms.TextBox
        Me.lblAltPhone2 = New System.Windows.Forms.Label
        Me.lblAltPhone1 = New System.Windows.Forms.Label
        Me.pctVerified = New System.Windows.Forms.PictureBox
        Me.lblHousePhone = New System.Windows.Forms.Label
        Me.lblWorkHours = New System.Windows.Forms.Label
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.lblAddress = New System.Windows.Forms.Label
        Me.txtContact2 = New System.Windows.Forms.TextBox
        Me.txtContact1 = New System.Windows.Forms.TextBox
        Me.lblContact2 = New System.Windows.Forms.Label
        Me.lblContact1 = New System.Windows.Forms.Label
        Me.ListView4 = New System.Windows.Forms.ListView
        Me.tsConfirming = New System.Windows.Forms.ToolStrip
        Me.btnSetAppt = New System.Windows.Forms.ToolStripButton
        Me.btnEditCustomer = New System.Windows.Forms.ToolStripButton
        Me.btnChangeStatus = New System.Windows.Forms.ToolStripDropDownButton
        Me.btnKill = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.btnDoNotCall = New System.Windows.Forms.ToolStripMenuItem
        Me.btnDoNotMail = New System.Windows.Forms.ToolStripMenuItem
        Me.btnDoNotCallOrMail = New System.Windows.Forms.ToolStripMenuItem
        Me.tsCustomerLog = New System.Windows.Forms.ToolStrip
        Me.TScboCustomerHistory = New System.Windows.Forms.ToolStripComboBox
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.btnLogCall = New System.Windows.Forms.ToolStripSplitButton
        Me.calledcancelled = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
        Me.ilCustomerHistory = New System.Windows.Forms.ImageList(Me.components)
        Me.ttCustomerHistoryNotes = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttconfirming = New System.Windows.Forms.ToolTip(Me.components)
        Me.ilToolStripIcons = New System.Windows.Forms.ImageList(Me.components)
        Me.pnlCustomerHistory = New System.Windows.Forms.Panel
        Me.gbSpecialInstructions.SuspendLayout()
        Me.gbProductInfo.SuspendLayout()
        Me.gbApptInfo.SuspendLayout()
        Me.gbHomeInfo.SuspendLayout()
        Me.gbContactInfo.SuspendLayout()
        CType(Me.pctVerified, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsConfirming.SuspendLayout()
        Me.tsCustomerLog.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbSpecialInstructions
        '
        Me.gbSpecialInstructions.BackColor = System.Drawing.Color.White
        Me.gbSpecialInstructions.Controls.Add(Me.rtbSpecialInstructions)
        Me.gbSpecialInstructions.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSpecialInstructions.ForeColor = System.Drawing.Color.Gray
        Me.gbSpecialInstructions.Location = New System.Drawing.Point(458, 235)
        Me.gbSpecialInstructions.Name = "gbSpecialInstructions"
        Me.gbSpecialInstructions.Size = New System.Drawing.Size(308, 144)
        Me.gbSpecialInstructions.TabIndex = 190
        Me.gbSpecialInstructions.TabStop = False
        Me.gbSpecialInstructions.Text = "Special Instructions:"
        '
        'rtbSpecialInstructions
        '
        Me.rtbSpecialInstructions.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbSpecialInstructions.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbSpecialInstructions.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbSpecialInstructions.Location = New System.Drawing.Point(8, 22)
        Me.rtbSpecialInstructions.Name = "rtbSpecialInstructions"
        Me.rtbSpecialInstructions.Size = New System.Drawing.Size(292, 116)
        Me.rtbSpecialInstructions.TabIndex = 146
        Me.rtbSpecialInstructions.Text = "The customer only wants a rough frame in the basement and they are interested in " & _
            "upper grids in the windows"
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
        Me.gbProductInfo.Location = New System.Drawing.Point(211, 235)
        Me.gbProductInfo.Name = "gbProductInfo"
        Me.gbProductInfo.Size = New System.Drawing.Size(241, 144)
        Me.gbProductInfo.TabIndex = 189
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
        Me.txtProducts.Text = "Roofing" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Basement Finish" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Windows"
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
        Me.txtColor.Text = "Onyx Black"
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
        Me.txtQty.Text = "16"
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
        Me.gbApptInfo.Location = New System.Drawing.Point(17, 235)
        Me.gbApptInfo.Name = "gbApptInfo"
        Me.gbApptInfo.Size = New System.Drawing.Size(188, 144)
        Me.gbApptInfo.TabIndex = 188
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
        Me.txtApptDate.Text = "12/24/2007"
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
        Me.txtApptTime.Text = "11:00 AM"
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
        Me.txtApptDay.Text = "Wednesday"
        '
        'gbHomeInfo
        '
        Me.gbHomeInfo.BackColor = System.Drawing.Color.White
        Me.gbHomeInfo.Controls.Add(Me.txtHomeValue)
        Me.gbHomeInfo.Controls.Add(Me.txtYrsOwned)
        Me.gbHomeInfo.Controls.Add(Me.lblYrBuilt)
        Me.gbHomeInfo.Controls.Add(Me.lblYrsOwned)
        Me.gbHomeInfo.Controls.Add(Me.lblHomeValue)
        Me.gbHomeInfo.Controls.Add(Me.txtYrBuilt)
        Me.gbHomeInfo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbHomeInfo.ForeColor = System.Drawing.Color.Gray
        Me.gbHomeInfo.Location = New System.Drawing.Point(637, 31)
        Me.gbHomeInfo.Name = "gbHomeInfo"
        Me.gbHomeInfo.Size = New System.Drawing.Size(129, 198)
        Me.gbHomeInfo.TabIndex = 187
        Me.gbHomeInfo.TabStop = False
        Me.gbHomeInfo.Text = "Home Info:"
        '
        'txtHomeValue
        '
        Me.txtHomeValue.BackColor = System.Drawing.Color.White
        Me.txtHomeValue.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtHomeValue.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHomeValue.ForeColor = System.Drawing.Color.Black
        Me.txtHomeValue.Location = New System.Drawing.Point(21, 166)
        Me.txtHomeValue.Name = "txtHomeValue"
        Me.txtHomeValue.ReadOnly = True
        Me.txtHomeValue.Size = New System.Drawing.Size(91, 16)
        Me.txtHomeValue.TabIndex = 35
        Me.txtHomeValue.Text = "25"
        Me.txtHomeValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtYrsOwned
        '
        Me.txtYrsOwned.BackColor = System.Drawing.Color.White
        Me.txtYrsOwned.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtYrsOwned.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYrsOwned.ForeColor = System.Drawing.Color.Black
        Me.txtYrsOwned.Location = New System.Drawing.Point(22, 114)
        Me.txtYrsOwned.Name = "txtYrsOwned"
        Me.txtYrsOwned.ReadOnly = True
        Me.txtYrsOwned.Size = New System.Drawing.Size(91, 16)
        Me.txtYrsOwned.TabIndex = 34
        Me.txtYrsOwned.Text = "25"
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
        Me.txtYrBuilt.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYrBuilt.ForeColor = System.Drawing.Color.Black
        Me.txtYrBuilt.Location = New System.Drawing.Point(21, 60)
        Me.txtYrBuilt.Name = "txtYrBuilt"
        Me.txtYrBuilt.ReadOnly = True
        Me.txtYrBuilt.Size = New System.Drawing.Size(91, 16)
        Me.txtYrBuilt.TabIndex = 29
        Me.txtYrBuilt.Text = "1960"
        Me.txtYrBuilt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gbContactInfo
        '
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
        Me.gbContactInfo.Location = New System.Drawing.Point(17, 31)
        Me.gbContactInfo.Name = "gbContactInfo"
        Me.gbContactInfo.Size = New System.Drawing.Size(614, 198)
        Me.gbContactInfo.TabIndex = 186
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
        Me.txtHousePhone.Location = New System.Drawing.Point(410, 33)
        Me.txtHousePhone.Name = "txtHousePhone"
        Me.txtHousePhone.ReadOnly = True
        Me.txtHousePhone.Size = New System.Drawing.Size(116, 16)
        Me.txtHousePhone.TabIndex = 141
        Me.txtHousePhone.Text = "(419) 472-4000"
        '
        'txtaltphone2
        '
        Me.txtaltphone2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtaltphone2.BackColor = System.Drawing.Color.White
        Me.txtaltphone2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtaltphone2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaltphone2.ForeColor = System.Drawing.Color.Black
        Me.txtaltphone2.Location = New System.Drawing.Point(410, 96)
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
        Me.txtaltphone1.Location = New System.Drawing.Point(410, 64)
        Me.txtaltphone1.Name = "txtaltphone1"
        Me.txtaltphone1.ReadOnly = True
        Me.txtaltphone1.Size = New System.Drawing.Size(116, 16)
        Me.txtaltphone1.TabIndex = 139
        Me.txtaltphone1.Text = "(419) 467-4926"
        '
        'lnkEmail
        '
        Me.lnkEmail.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lnkEmail.AutoSize = True
        Me.lnkEmail.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkEmail.Location = New System.Drawing.Point(409, 144)
        Me.lnkEmail.Name = "lnkEmail"
        Me.lnkEmail.Size = New System.Drawing.Size(144, 16)
        Me.lnkEmail.TabIndex = 136
        Me.lnkEmail.TabStop = True
        Me.lnkEmail.Text = "SuzzieN@yahoo.com"
        '
        'lblEmail
        '
        Me.lblEmail.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.Gray
        Me.lblEmail.Location = New System.Drawing.Point(306, 144)
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
        Me.txtAlt1Type.Location = New System.Drawing.Point(542, 64)
        Me.txtAlt1Type.Name = "txtAlt1Type"
        Me.txtAlt1Type.ReadOnly = True
        Me.txtAlt1Type.Size = New System.Drawing.Size(57, 16)
        Me.txtAlt1Type.TabIndex = 126
        Me.txtAlt1Type.Text = "Cell"
        '
        'txtAlt2Type
        '
        Me.txtAlt2Type.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAlt2Type.BackColor = System.Drawing.Color.White
        Me.txtAlt2Type.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAlt2Type.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlt2Type.ForeColor = System.Drawing.Color.Black
        Me.txtAlt2Type.Location = New System.Drawing.Point(542, 96)
        Me.txtAlt2Type.Name = "txtAlt2Type"
        Me.txtAlt2Type.ReadOnly = True
        Me.txtAlt2Type.Size = New System.Drawing.Size(57, 16)
        Me.txtAlt2Type.TabIndex = 125
        Me.txtAlt2Type.Text = "Work"
        '
        'lblAltPhone2
        '
        Me.lblAltPhone2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAltPhone2.AutoSize = True
        Me.lblAltPhone2.BackColor = System.Drawing.Color.Transparent
        Me.lblAltPhone2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAltPhone2.ForeColor = System.Drawing.Color.Gray
        Me.lblAltPhone2.Location = New System.Drawing.Point(306, 96)
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
        Me.lblAltPhone1.Location = New System.Drawing.Point(306, 64)
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
        Me.lblHousePhone.Location = New System.Drawing.Point(306, 33)
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
        Me.txtAddress.Text = "12345 Main St." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Toledo, OH 43613"
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
        Me.txtContact2.Text = "Suzzana NameWaytolong"
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
        Me.txtContact1.Text = "Alexander Namewaytolong"
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
        Me.tsConfirming.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSetAppt, Me.btnEditCustomer, Me.btnChangeStatus})
        Me.tsConfirming.Location = New System.Drawing.Point(0, 0)
        Me.tsConfirming.Name = "tsConfirming"
        Me.tsConfirming.Size = New System.Drawing.Size(783, 25)
        Me.tsConfirming.TabIndex = 191
        Me.tsConfirming.Text = "ToolStrip1"
        '
        'btnSetAppt
        '
        Me.btnSetAppt.Image = CType(resources.GetObject("btnSetAppt.Image"), System.Drawing.Image)
        Me.btnSetAppt.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSetAppt.Name = "btnSetAppt"
        Me.btnSetAppt.Size = New System.Drawing.Size(117, 22)
        Me.btnSetAppt.Text = "Set Appointment"
        '
        'btnEditCustomer
        '
        Me.btnEditCustomer.Image = CType(resources.GetObject("btnEditCustomer.Image"), System.Drawing.Image)
        Me.btnEditCustomer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEditCustomer.Name = "btnEditCustomer"
        Me.btnEditCustomer.Size = New System.Drawing.Size(102, 22)
        Me.btnEditCustomer.Text = "Edit Customer"
        '
        'btnChangeStatus
        '
        Me.btnChangeStatus.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnKill, Me.ToolStripSeparator4, Me.btnDoNotCall, Me.btnDoNotMail, Me.btnDoNotCallOrMail})
        Me.btnChangeStatus.Image = CType(resources.GetObject("btnChangeStatus.Image"), System.Drawing.Image)
        Me.btnChangeStatus.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnChangeStatus.Name = "btnChangeStatus"
        Me.btnChangeStatus.Size = New System.Drawing.Size(112, 22)
        Me.btnChangeStatus.Text = "Change Status"
        '
        'btnKill
        '
        Me.btnKill.Image = CType(resources.GetObject("btnKill.Image"), System.Drawing.Image)
        Me.btnKill.Name = "btnKill"
        Me.btnKill.Size = New System.Drawing.Size(221, 22)
        Me.btnKill.Text = "Kill Appointment"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(218, 6)
        '
        'btnDoNotCall
        '
        Me.btnDoNotCall.Image = CType(resources.GetObject("btnDoNotCall.Image"), System.Drawing.Image)
        Me.btnDoNotCall.Name = "btnDoNotCall"
        Me.btnDoNotCall.Size = New System.Drawing.Size(221, 22)
        Me.btnDoNotCall.Text = "Mark as Do Not Call"
        '
        'btnDoNotMail
        '
        Me.btnDoNotMail.Image = CType(resources.GetObject("btnDoNotMail.Image"), System.Drawing.Image)
        Me.btnDoNotMail.Name = "btnDoNotMail"
        Me.btnDoNotMail.Size = New System.Drawing.Size(221, 22)
        Me.btnDoNotMail.Text = "Mark as Do Not Mail"
        '
        'btnDoNotCallOrMail
        '
        Me.btnDoNotCallOrMail.Image = CType(resources.GetObject("btnDoNotCallOrMail.Image"), System.Drawing.Image)
        Me.btnDoNotCallOrMail.Name = "btnDoNotCallOrMail"
        Me.btnDoNotCallOrMail.Size = New System.Drawing.Size(221, 22)
        Me.btnDoNotCallOrMail.Text = "Mark as Do Not Call Or Mail"
        '
        'tsCustomerLog
        '
        Me.tsCustomerLog.AutoSize = False
        Me.tsCustomerLog.Dock = System.Windows.Forms.DockStyle.None
        Me.tsCustomerLog.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsCustomerLog.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TScboCustomerHistory, Me.ToolStripLabel1, Me.btnLogCall, Me.ToolStripLabel2})
        Me.tsCustomerLog.Location = New System.Drawing.Point(8, 382)
        Me.tsCustomerLog.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.tsCustomerLog.Name = "tsCustomerLog"
        Me.tsCustomerLog.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.tsCustomerLog.Size = New System.Drawing.Size(767, 33)
        Me.tsCustomerLog.TabIndex = 192
        Me.tsCustomerLog.Text = "ToolStrip1"
        '
        'TScboCustomerHistory
        '
        Me.TScboCustomerHistory.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TScboCustomerHistory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TScboCustomerHistory.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.TScboCustomerHistory.Items.AddRange(New Object() {"All", "Marketing Department", "Sales Department", "Finance Department", "Installation Department"})
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
        Me.calledcancelled.Image = Global.Latest.My.Resources.Resources.Call_Cancel48
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
        '
        'ttCustomerHistoryNotes
        '
        Me.ttCustomerHistoryNotes.AutoPopDelay = 30000
        Me.ttCustomerHistoryNotes.InitialDelay = 500
        Me.ttCustomerHistoryNotes.ReshowDelay = 100
        '
        'ilToolStripIcons
        '
        Me.ilToolStripIcons.ImageStream = CType(resources.GetObject("ilToolStripIcons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilToolStripIcons.TransparentColor = System.Drawing.Color.Transparent
        Me.ilToolStripIcons.Images.SetKeyName(0, "Confirmer.ico")
        Me.ilToolStripIcons.Images.SetKeyName(1, "tranfer7.ico")
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
        '
        'pnlCustomerHistory
        '
        Me.pnlCustomerHistory.AutoScroll = True
        Me.pnlCustomerHistory.Location = New System.Drawing.Point(13, 418)
        Me.pnlCustomerHistory.Name = "pnlCustomerHistory"
        Me.pnlCustomerHistory.Size = New System.Drawing.Size(753, 197)
        Me.pnlCustomerHistory.TabIndex = 193
        '
        'ConfirmingSingleRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(783, 634)
        Me.Controls.Add(Me.pnlCustomerHistory)
        Me.Controls.Add(Me.tsCustomerLog)
        Me.Controls.Add(Me.tsConfirming)
        Me.Controls.Add(Me.gbSpecialInstructions)
        Me.Controls.Add(Me.gbProductInfo)
        Me.Controls.Add(Me.gbApptInfo)
        Me.Controls.Add(Me.gbHomeInfo)
        Me.Controls.Add(Me.gbContactInfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ConfirmingSingleRecord"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Information for Record ID: "
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
        Me.tsConfirming.ResumeLayout(False)
        Me.tsConfirming.PerformLayout()
        Me.tsCustomerLog.ResumeLayout(False)
        Me.tsCustomerLog.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents gbHomeInfo As System.Windows.Forms.GroupBox
    Friend WithEvents txtHomeValue As System.Windows.Forms.TextBox
    Friend WithEvents txtYrsOwned As System.Windows.Forms.TextBox
    Friend WithEvents lblYrBuilt As System.Windows.Forms.Label
    Friend WithEvents lblYrsOwned As System.Windows.Forms.Label
    Friend WithEvents lblHomeValue As System.Windows.Forms.Label
    Friend WithEvents txtYrBuilt As System.Windows.Forms.TextBox
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
    Friend WithEvents tsConfirming As System.Windows.Forms.ToolStrip
    Friend WithEvents tsCustomerLog As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnLogCall As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents calledcancelled As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ttCustomerHistoryNotes As System.Windows.Forms.ToolTip
    Friend WithEvents ttconfirming As System.Windows.Forms.ToolTip
    Friend WithEvents ilCustomerHistory As System.Windows.Forms.ImageList
    Friend WithEvents ilToolStripIcons As System.Windows.Forms.ImageList
    Friend WithEvents btnEditCustomer As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSetAppt As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnChangeStatus As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents btnKill As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnDoNotCall As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnDoNotMail As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnDoNotCallOrMail As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlCustomerHistory As System.Windows.Forms.Panel
    Friend WithEvents TScboCustomerHistory As System.Windows.Forms.ToolStripComboBox
End Class
