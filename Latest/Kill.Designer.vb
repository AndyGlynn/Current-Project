<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kill
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Kill))
        Me.cboSpokeWith = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblautonotes = New System.Windows.Forms.Label()
        Me.txtNotes = New System.Windows.Forms.RichTextBox()
        Me.cboautonote = New System.Windows.Forms.ComboBox()
        Me.lblNotes = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboSpokeWith
        '
        Me.cboSpokeWith.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSpokeWith.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSpokeWith.FormattingEnabled = True
        Me.cboSpokeWith.Location = New System.Drawing.Point(119, 9)
        Me.cboSpokeWith.Name = "cboSpokeWith"
        Me.cboSpokeWith.Size = New System.Drawing.Size(285, 21)
        Me.cboSpokeWith.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Spoke With:"
        '
        'lblautonotes
        '
        Me.lblautonotes.BackColor = System.Drawing.Color.White
        Me.lblautonotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblautonotes.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblautonotes.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblautonotes.ForeColor = System.Drawing.Color.Gray
        Me.lblautonotes.Location = New System.Drawing.Point(29, 36)
        Me.lblautonotes.Name = "lblautonotes"
        Me.lblautonotes.Size = New System.Drawing.Size(352, 21)
        Me.lblautonotes.TabIndex = 31
        Me.lblautonotes.Text = "Select Reason From Standard Reason List (Required)"
        Me.lblautonotes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(29, 63)
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(375, 113)
        Me.txtNotes.TabIndex = 3
        Me.txtNotes.Text = ""
        '
        'cboautonote
        '
        Me.cboautonote.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboautonote.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboautonote.FormattingEnabled = True
        Me.cboautonote.Items.AddRange(New Object() {"<Add New>", "___________________________________________________"})
        Me.cboautonote.Location = New System.Drawing.Point(29, 36)
        Me.cboautonote.Name = "cboautonote"
        Me.cboautonote.Size = New System.Drawing.Size(375, 21)
        Me.cboautonote.TabIndex = 2
        '
        'lblNotes
        '
        Me.lblNotes.AutoSize = True
        Me.lblNotes.BackColor = System.Drawing.Color.White
        Me.lblNotes.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblNotes.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotes.ForeColor = System.Drawing.Color.Gray
        Me.lblNotes.Location = New System.Drawing.Point(108, 106)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Size = New System.Drawing.Size(222, 26)
        Me.lblNotes.TabIndex = 34
        Me.lblNotes.Text = "Please Provide a Detailed Explanation" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "for Killing this Appointment (Optional)"
        Me.lblNotes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(112, 184)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(99, 27)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(218, 184)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(99, 27)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Kill
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(429, 218)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblNotes)
        Me.Controls.Add(Me.cboSpokeWith)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblautonotes)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.cboautonote)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Kill"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Kill This Appointment"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboSpokeWith As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblautonotes As System.Windows.Forms.Label
    Friend WithEvents txtNotes As System.Windows.Forms.RichTextBox
    Friend WithEvents cboautonote As System.Windows.Forms.ComboBox
    Friend WithEvents lblNotes As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
