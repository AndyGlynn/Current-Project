<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SendNotesSM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SendNotesSM))
        Me.cboautonotes = New System.Windows.Forms.ComboBox()
        Me.lblautonotes = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cboautonotes
        '
        Me.cboautonotes.BackColor = System.Drawing.Color.White
        Me.cboautonotes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboautonotes.FormattingEnabled = True
        Me.cboautonotes.Location = New System.Drawing.Point(10, 9)
        Me.cboautonotes.Name = "cboautonotes"
        Me.cboautonotes.Size = New System.Drawing.Size(166, 21)
        Me.cboautonotes.TabIndex = 0
        Me.cboautonotes.TabStop = False
        '
        'lblautonotes
        '
        Me.lblautonotes.BackColor = System.Drawing.Color.White
        Me.lblautonotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblautonotes.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblautonotes.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblautonotes.ForeColor = System.Drawing.Color.Gray
        Me.lblautonotes.Location = New System.Drawing.Point(10, 9)
        Me.lblautonotes.Name = "lblautonotes"
        Me.lblautonotes.Size = New System.Drawing.Size(144, 21)
        Me.lblautonotes.TabIndex = 18
        Me.lblautonotes.Text = "Select Auto Note Here"
        Me.lblautonotes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(10, 36)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(165, 94)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = ""
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.Black
        Me.btnsave.Location = New System.Drawing.Point(95, 136)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(67, 21)
        Me.btnsave.TabIndex = 19
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.ForeColor = System.Drawing.Color.Black
        Me.btncancel.Location = New System.Drawing.Point(22, 136)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(67, 21)
        Me.btncancel.TabIndex = 20
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'SendNotesSM
        '
        Me.AcceptButton = Me.btnsave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(184, 167)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.lblautonotes)
        Me.Controls.Add(Me.cboautonotes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(25, 125)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SendNotesSM"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Send Notes"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cboautonotes As System.Windows.Forms.ComboBox
    Friend WithEvents lblautonotes As System.Windows.Forms.Label
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
End Class
