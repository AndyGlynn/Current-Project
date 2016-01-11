<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SetAppt_V2
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
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.chkDelayInstall = New System.Windows.Forms.CheckBox()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.dtpApptTime = New System.Windows.Forms.DateTimePicker()
        Me.dtpApptDate = New System.Windows.Forms.DateTimePicker()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.rtfNotes = New System.Windows.Forms.RichTextBox()
        Me.lblautonotes = New System.Windows.Forms.Label()
        Me.cboautonotes = New System.Windows.Forms.ComboBox()
        Me.lblSpokeWith = New System.Windows.Forms.Label()
        Me.cboSpokeWith = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox7.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox7.Controls.Add(Me.chkDelayInstall)
        Me.GroupBox7.Controls.Add(Me.txtTime)
        Me.GroupBox7.Controls.Add(Me.txtDate)
        Me.GroupBox7.Controls.Add(Me.dtpApptTime)
        Me.GroupBox7.Controls.Add(Me.dtpApptDate)
        Me.GroupBox7.Controls.Add(Me.Label22)
        Me.GroupBox7.Controls.Add(Me.Label23)
        Me.GroupBox7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.ForeColor = System.Drawing.Color.Black
        Me.GroupBox7.Location = New System.Drawing.Point(12, 43)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(193, 123)
        Me.GroupBox7.TabIndex = 172
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Set Appt. For:"
        '
        'chkDelayInstall
        '
        Me.chkDelayInstall.AutoSize = True
        Me.chkDelayInstall.Location = New System.Drawing.Point(44, 100)
        Me.chkDelayInstall.Name = "chkDelayInstall"
        Me.chkDelayInstall.Size = New System.Drawing.Size(123, 17)
        Me.chkDelayInstall.TabIndex = 174
        Me.chkDelayInstall.Text = "Delayed Install ? "
        Me.chkDelayInstall.UseVisualStyleBackColor = True
        '
        'txtTime
        '
        Me.txtTime.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTime.Location = New System.Drawing.Point(73, 69)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(74, 14)
        Me.txtTime.TabIndex = 24
        '
        'txtDate
        '
        Me.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDate.Location = New System.Drawing.Point(74, 25)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(74, 14)
        Me.txtDate.TabIndex = 23
        '
        'dtpApptTime
        '
        Me.dtpApptTime.CustomFormat = "h:mm tt"
        Me.dtpApptTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpApptTime.Location = New System.Drawing.Point(71, 66)
        Me.dtpApptTime.Name = "dtpApptTime"
        Me.dtpApptTime.ShowUpDown = True
        Me.dtpApptTime.Size = New System.Drawing.Size(96, 21)
        Me.dtpApptTime.TabIndex = 6
        '
        'dtpApptDate
        '
        Me.dtpApptDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpApptDate.Location = New System.Drawing.Point(71, 21)
        Me.dtpApptDate.Name = "dtpApptDate"
        Me.dtpApptDate.Size = New System.Drawing.Size(96, 21)
        Me.dtpApptDate.TabIndex = 5
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(4, 69)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(38, 13)
        Me.Label22.TabIndex = 19
        Me.Label22.Text = "Time:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(4, 25)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(37, 13)
        Me.Label23.TabIndex = 3
        Me.Label23.Text = "Date:"
        '
        'rtfNotes
        '
        Me.rtfNotes.Location = New System.Drawing.Point(211, 70)
        Me.rtfNotes.Name = "rtfNotes"
        Me.rtfNotes.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.rtfNotes.Size = New System.Drawing.Size(166, 94)
        Me.rtfNotes.TabIndex = 168
        Me.rtfNotes.Text = ""
        '
        'lblautonotes
        '
        Me.lblautonotes.BackColor = System.Drawing.Color.White
        Me.lblautonotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblautonotes.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblautonotes.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblautonotes.ForeColor = System.Drawing.Color.Gray
        Me.lblautonotes.Location = New System.Drawing.Point(210, 43)
        Me.lblautonotes.Name = "lblautonotes"
        Me.lblautonotes.Size = New System.Drawing.Size(146, 21)
        Me.lblautonotes.TabIndex = 171
        Me.lblautonotes.Text = "Select Auto Note Here"
        Me.lblautonotes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboautonotes
        '
        Me.cboautonotes.BackColor = System.Drawing.Color.White
        Me.cboautonotes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboautonotes.FormattingEnabled = True
        Me.cboautonotes.Location = New System.Drawing.Point(210, 43)
        Me.cboautonotes.Name = "cboautonotes"
        Me.cboautonotes.Size = New System.Drawing.Size(166, 21)
        Me.cboautonotes.TabIndex = 167
        '
        'lblSpokeWith
        '
        Me.lblSpokeWith.BackColor = System.Drawing.Color.White
        Me.lblSpokeWith.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSpokeWith.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSpokeWith.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpokeWith.ForeColor = System.Drawing.Color.Gray
        Me.lblSpokeWith.Location = New System.Drawing.Point(12, 9)
        Me.lblSpokeWith.Name = "lblSpokeWith"
        Me.lblSpokeWith.Size = New System.Drawing.Size(344, 21)
        Me.lblSpokeWith.TabIndex = 170
        Me.lblSpokeWith.Text = "Spoke With"
        Me.lblSpokeWith.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboSpokeWith
        '
        Me.cboSpokeWith.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSpokeWith.FormattingEnabled = True
        Me.cboSpokeWith.Location = New System.Drawing.Point(12, 9)
        Me.cboSpokeWith.Name = "cboSpokeWith"
        Me.cboSpokeWith.Size = New System.Drawing.Size(364, 21)
        Me.cboSpokeWith.TabIndex = 166
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(244, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 173
        Me.Label1.Text = "Appointment Notes"
        '
        'btncancel
        '
        Me.btncancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btncancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.ForeColor = System.Drawing.Color.Black
        Me.btncancel.Location = New System.Drawing.Point(11, 180)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(147, 21)
        Me.btncancel.TabIndex = 169
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.Black
        Me.btnsave.Location = New System.Drawing.Point(229, 180)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(147, 21)
        Me.btnsave.TabIndex = 165
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(244, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 174
        Me.Label2.Text = "Appointment Notes"
        '
        'SetAppt_V2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 212)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.rtfNotes)
        Me.Controls.Add(Me.lblautonotes)
        Me.Controls.Add(Me.cboautonotes)
        Me.Controls.Add(Me.lblSpokeWith)
        Me.Controls.Add(Me.cboSpokeWith)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnsave)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SetAppt_V2"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Set Appointment"
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTime As System.Windows.Forms.TextBox
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents dtpApptTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpApptDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents rtfNotes As System.Windows.Forms.RichTextBox
    Friend WithEvents lblautonotes As System.Windows.Forms.Label
    Friend WithEvents cboautonotes As System.Windows.Forms.ComboBox
    Friend WithEvents lblSpokeWith As System.Windows.Forms.Label
    Friend WithEvents cboSpokeWith As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents chkDelayInstall As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
