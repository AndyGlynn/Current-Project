<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CandCNotes
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
        Me.btncancel = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.lblautonotes = New System.Windows.Forms.Label
        Me.cboautonotes = New System.Windows.Forms.ComboBox
        Me.cbCallBack = New System.Windows.Forms.CheckBox
        Me.cboSpokeWith = New System.Windows.Forms.ComboBox
        Me.lblSpokeWith = New System.Windows.Forms.Label
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cbNoReschedule = New System.Windows.Forms.CheckBox
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.txtTime = New System.Windows.Forms.TextBox
        Me.txtDate = New System.Windows.Forms.TextBox
        Me.dtpApptTime = New System.Windows.Forms.DateTimePicker
        Me.dtpApptDate = New System.Windows.Forms.DateTimePicker
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'btncancel
        '
        Me.btncancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btncancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.ForeColor = System.Drawing.Color.Black
        Me.btncancel.Location = New System.Drawing.Point(21, 214)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(162, 21)
        Me.btncancel.TabIndex = 10
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.Black
        Me.btnsave.Location = New System.Drawing.Point(210, 214)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(162, 21)
        Me.btnsave.TabIndex = 1
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(212, 102)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(165, 94)
        Me.RichTextBox1.TabIndex = 6
        Me.RichTextBox1.Text = ""
        '
        'lblautonotes
        '
        Me.lblautonotes.BackColor = System.Drawing.Color.White
        Me.lblautonotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblautonotes.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblautonotes.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblautonotes.ForeColor = System.Drawing.Color.Gray
        Me.lblautonotes.Location = New System.Drawing.Point(212, 73)
        Me.lblautonotes.Margin = New System.Windows.Forms.Padding(0)
        Me.lblautonotes.Name = "lblautonotes"
        Me.lblautonotes.Size = New System.Drawing.Size(146, 21)
        Me.lblautonotes.TabIndex = 23
        Me.lblautonotes.Text = "Select Auto Note Here"
        Me.lblautonotes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboautonotes
        '
        Me.cboautonotes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboautonotes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboautonotes.BackColor = System.Drawing.Color.White
        Me.cboautonotes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboautonotes.FormattingEnabled = True
        Me.cboautonotes.Location = New System.Drawing.Point(212, 73)
        Me.cboautonotes.Name = "cboautonotes"
        Me.cboautonotes.Size = New System.Drawing.Size(166, 21)
        Me.cboautonotes.TabIndex = 5
        '
        'cbCallBack
        '
        Me.cbCallBack.AutoSize = True
        Me.cbCallBack.Location = New System.Drawing.Point(210, 41)
        Me.cbCallBack.Name = "cbCallBack"
        Me.cbCallBack.Size = New System.Drawing.Size(139, 17)
        Me.cbCallBack.TabIndex = 4
        Me.cbCallBack.Text = "Callback to Reschedule"
        Me.cbCallBack.UseVisualStyleBackColor = True
        '
        'cboSpokeWith
        '
        Me.cboSpokeWith.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSpokeWith.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSpokeWith.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSpokeWith.FormattingEnabled = True
        Me.cboSpokeWith.Location = New System.Drawing.Point(14, 14)
        Me.cboSpokeWith.Name = "cboSpokeWith"
        Me.cboSpokeWith.Size = New System.Drawing.Size(364, 21)
        Me.cboSpokeWith.TabIndex = 2
        '
        'lblSpokeWith
        '
        Me.lblSpokeWith.BackColor = System.Drawing.Color.White
        Me.lblSpokeWith.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSpokeWith.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSpokeWith.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpokeWith.ForeColor = System.Drawing.Color.Gray
        Me.lblSpokeWith.Location = New System.Drawing.Point(14, 14)
        Me.lblSpokeWith.Margin = New System.Windows.Forms.Padding(0)
        Me.lblSpokeWith.Name = "lblSpokeWith"
        Me.lblSpokeWith.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblSpokeWith.Size = New System.Drawing.Size(344, 21)
        Me.lblSpokeWith.TabIndex = 28
        Me.lblSpokeWith.Text = "Spoke With"
        Me.lblSpokeWith.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'cbNoReschedule
        '
        Me.cbNoReschedule.AutoSize = True
        Me.cbNoReschedule.Location = New System.Drawing.Point(14, 41)
        Me.cbNoReschedule.Name = "cbNoReschedule"
        Me.cbNoReschedule.Size = New System.Drawing.Size(157, 17)
        Me.cbNoReschedule.TabIndex = 3
        Me.cbNoReschedule.Tag = ""
        Me.cbNoReschedule.Text = "No Interest in Rescheduling"
        Me.cbNoReschedule.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox7.Controls.Add(Me.txtTime)
        Me.GroupBox7.Controls.Add(Me.txtDate)
        Me.GroupBox7.Controls.Add(Me.dtpApptTime)
        Me.GroupBox7.Controls.Add(Me.dtpApptDate)
        Me.GroupBox7.Controls.Add(Me.Label22)
        Me.GroupBox7.Controls.Add(Me.Label23)
        Me.GroupBox7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.ForeColor = System.Drawing.Color.Black
        Me.GroupBox7.Location = New System.Drawing.Point(14, 73)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(193, 123)
        Me.GroupBox7.TabIndex = 29
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Reschedule Appt. For:"
        '
        'txtTime
        '
        Me.txtTime.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTime.Location = New System.Drawing.Point(67, 85)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(91, 14)
        Me.txtTime.TabIndex = 24
        Me.txtTime.TabStop = False
        '
        'txtDate
        '
        Me.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDate.Location = New System.Drawing.Point(67, 40)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(81, 14)
        Me.txtDate.TabIndex = 23
        Me.txtDate.TabStop = False
        '
        'dtpApptTime
        '
        Me.dtpApptTime.CustomFormat = "h:mm tt"
        Me.dtpApptTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpApptTime.Location = New System.Drawing.Point(64, 82)
        Me.dtpApptTime.Name = "dtpApptTime"
        Me.dtpApptTime.ShowUpDown = True
        Me.dtpApptTime.Size = New System.Drawing.Size(114, 21)
        Me.dtpApptTime.TabIndex = 9
        '
        'dtpApptDate
        '
        Me.dtpApptDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpApptDate.Location = New System.Drawing.Point(64, 37)
        Me.dtpApptDate.Name = "dtpApptDate"
        Me.dtpApptDate.Size = New System.Drawing.Size(114, 21)
        Me.dtpApptDate.TabIndex = 8
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(14, 85)
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
        Me.Label23.Location = New System.Drawing.Point(14, 40)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(37, 13)
        Me.Label23.TabIndex = 3
        Me.Label23.Text = "Date:"
        '
        'CandCNotes
        '
        Me.AcceptButton = Me.btnsave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.btncancel
        Me.ClientSize = New System.Drawing.Size(393, 243)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.cbNoReschedule)
        Me.Controls.Add(Me.lblSpokeWith)
        Me.Controls.Add(Me.cboSpokeWith)
        Me.Controls.Add(Me.cbCallBack)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.lblautonotes)
        Me.Controls.Add(Me.cboautonotes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CandCNotes"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Log Cancelled Appt."
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents lblautonotes As System.Windows.Forms.Label
    Friend WithEvents cboautonotes As System.Windows.Forms.ComboBox
    Friend WithEvents cbCallBack As System.Windows.Forms.CheckBox
    Friend WithEvents cboSpokeWith As System.Windows.Forms.ComboBox
    Friend WithEvents lblSpokeWith As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents cbNoReschedule As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTime As System.Windows.Forms.TextBox
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents dtpApptTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpApptDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
End Class
