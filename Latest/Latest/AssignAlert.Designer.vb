<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AssignAlert
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AssignAlert))
        Me.txtLeadNumber = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblPhoneInfo = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.rtfNotes = New System.Windows.Forms.RichTextBox
        Me.dtpExecutionDate = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboUser = New System.Windows.Forms.ComboBox
        Me.dtpTime = New System.Windows.Forms.DateTimePicker
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblAutonotes = New System.Windows.Forms.Label
        Me.cboAutonotes = New System.Windows.Forms.ComboBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtLeadNumber
        '
        Me.txtLeadNumber.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorProvider1.SetIconPadding(Me.txtLeadNumber, 4)
        Me.txtLeadNumber.Location = New System.Drawing.Point(46, 16)
        Me.txtLeadNumber.Name = "txtLeadNumber"
        Me.txtLeadNumber.Size = New System.Drawing.Size(250, 23)
        Me.txtLeadNumber.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ID:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblPhoneInfo)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(13, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(283, 130)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Contact Info:"
        '
        'lblPhoneInfo
        '
        Me.lblPhoneInfo.AutoSize = True
        Me.lblPhoneInfo.Font = New System.Drawing.Font("Tahoma", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhoneInfo.Location = New System.Drawing.Point(6, 22)
        Me.lblPhoneInfo.Name = "lblPhoneInfo"
        Me.lblPhoneInfo.Size = New System.Drawing.Size(222, 16)
        Me.lblPhoneInfo.TabIndex = 1
        Me.lblPhoneInfo.Text = "No Contact Information Available"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 218)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 188
        Me.Label2.Text = "Time:"
        '
        'rtfNotes
        '
        Me.rtfNotes.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtfNotes.Location = New System.Drawing.Point(18, 312)
        Me.rtfNotes.Name = "rtfNotes"
        Me.rtfNotes.Size = New System.Drawing.Size(278, 65)
        Me.rtfNotes.TabIndex = 186
        Me.rtfNotes.Text = ""
        '
        'dtpExecutionDate
        '
        Me.dtpExecutionDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpExecutionDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpExecutionDate.Location = New System.Drawing.Point(160, 243)
        Me.dtpExecutionDate.Name = "dtpExecutionDate"
        Me.dtpExecutionDate.Size = New System.Drawing.Size(136, 21)
        Me.dtpExecutionDate.TabIndex = 185
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 247)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 184
        Me.Label4.Text = "Execution Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 183
        Me.Label3.Text = "User Name:"
        '
        'cboUser
        '
        Me.cboUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUser.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUser.FormattingEnabled = True
        Me.ErrorProvider1.SetIconPadding(Me.cboUser, 4)
        Me.cboUser.Location = New System.Drawing.Point(160, 186)
        Me.cboUser.Name = "cboUser"
        Me.cboUser.Size = New System.Drawing.Size(136, 21)
        Me.cboUser.TabIndex = 182
        '
        'dtpTime
        '
        Me.dtpTime.CustomFormat = "h:mm tt"
        Me.dtpTime.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTime.Location = New System.Drawing.Point(160, 214)
        Me.dtpTime.Name = "dtpTime"
        Me.dtpTime.ShowUpDown = True
        Me.dtpTime.Size = New System.Drawing.Size(136, 21)
        Me.dtpTime.TabIndex = 192
        '
        'Button2
        '
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(166, 389)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(130, 31)
        Me.Button2.TabIndex = 194
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(18, 389)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 31)
        Me.Button1.TabIndex = 193
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider1.ContainerControl = Me
        '
        'lblAutonotes
        '
        Me.lblAutonotes.BackColor = System.Drawing.Color.White
        Me.lblAutonotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAutonotes.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAutonotes.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAutonotes.ForeColor = System.Drawing.Color.Gray
        Me.lblAutonotes.Location = New System.Drawing.Point(18, 276)
        Me.lblAutonotes.Margin = New System.Windows.Forms.Padding(0)
        Me.lblAutonotes.Name = "lblAutonotes"
        Me.lblAutonotes.Size = New System.Drawing.Size(258, 21)
        Me.lblAutonotes.TabIndex = 198
        Me.lblAutonotes.Text = "Select Auto Note Here"
        Me.lblAutonotes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboAutonotes
        '
        Me.cboAutonotes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboAutonotes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboAutonotes.BackColor = System.Drawing.Color.White
        Me.cboAutonotes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAutonotes.FormattingEnabled = True
        Me.cboAutonotes.Location = New System.Drawing.Point(18, 276)
        Me.cboAutonotes.Name = "cboAutonotes"
        Me.cboAutonotes.Size = New System.Drawing.Size(278, 21)
        Me.cboAutonotes.TabIndex = 197
        '
        'AssignAlert
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Button2
        Me.ClientSize = New System.Drawing.Size(316, 431)
        Me.Controls.Add(Me.lblAutonotes)
        Me.Controls.Add(Me.cboAutonotes)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dtpTime)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.rtfNotes)
        Me.Controls.Add(Me.dtpExecutionDate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboUser)
        Me.Controls.Add(Me.txtLeadNumber)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AssignAlert"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Assign Alert"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtLeadNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblPhoneInfo As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rtfNotes As System.Windows.Forms.RichTextBox
    Friend WithEvents dtpExecutionDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboUser As System.Windows.Forms.ComboBox
    Friend WithEvents dtpTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents lblAutonotes As System.Windows.Forms.Label
    Friend WithEvents cboAutonotes As System.Windows.Forms.ComboBox
End Class
