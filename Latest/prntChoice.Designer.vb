<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class prntChoice
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdoPlainText = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdoSingleDepart = New System.Windows.Forms.RadioButton()
        Me.rdoAllDeparts = New System.Windows.Forms.RadioButton()
        Me.cboDepartments = New System.Windows.Forms.ComboBox()
        Me.lblSelDepart = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdoPlainText)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(137, 45)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Print Type Choice:"
        '
        'rdoPlainText
        '
        Me.rdoPlainText.AutoSize = True
        Me.rdoPlainText.Location = New System.Drawing.Point(24, 19)
        Me.rdoPlainText.Name = "rdoPlainText"
        Me.rdoPlainText.Size = New System.Drawing.Size(72, 17)
        Me.rdoPlainText.TabIndex = 1
        Me.rdoPlainText.TabStop = True
        Me.rdoPlainText.Text = "Plain Text"
        Me.rdoPlainText.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdoSingleDepart)
        Me.GroupBox2.Controls.Add(Me.rdoAllDeparts)
        Me.GroupBox2.Location = New System.Drawing.Point(153, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(238, 45)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        '
        'rdoSingleDepart
        '
        Me.rdoSingleDepart.AutoSize = True
        Me.rdoSingleDepart.Location = New System.Drawing.Point(124, 19)
        Me.rdoSingleDepart.Name = "rdoSingleDepart"
        Me.rdoSingleDepart.Size = New System.Drawing.Size(112, 17)
        Me.rdoSingleDepart.TabIndex = 1
        Me.rdoSingleDepart.TabStop = True
        Me.rdoSingleDepart.Text = "Single Department"
        Me.rdoSingleDepart.UseVisualStyleBackColor = True
        '
        'rdoAllDeparts
        '
        Me.rdoAllDeparts.AutoSize = True
        Me.rdoAllDeparts.Location = New System.Drawing.Point(19, 19)
        Me.rdoAllDeparts.Name = "rdoAllDeparts"
        Me.rdoAllDeparts.Size = New System.Drawing.Size(99, 17)
        Me.rdoAllDeparts.TabIndex = 0
        Me.rdoAllDeparts.TabStop = True
        Me.rdoAllDeparts.Text = "All Departments"
        Me.rdoAllDeparts.UseVisualStyleBackColor = True
        '
        'cboDepartments
        '
        Me.cboDepartments.FormattingEnabled = True
        Me.cboDepartments.Location = New System.Drawing.Point(162, 64)
        Me.cboDepartments.Name = "cboDepartments"
        Me.cboDepartments.Size = New System.Drawing.Size(227, 21)
        Me.cboDepartments.TabIndex = 12
        '
        'lblSelDepart
        '
        Me.lblSelDepart.AutoSize = True
        Me.lblSelDepart.Location = New System.Drawing.Point(14, 66)
        Me.lblSelDepart.Name = "lblSelDepart"
        Me.lblSelDepart.Size = New System.Drawing.Size(141, 13)
        Me.lblSelDepart.TabIndex = 11
        Me.lblSelDepart.Text = "Select Department To Print: "
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(316, 88)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 10
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(10, 88)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'prntChoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 122)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cboDepartments)
        Me.Controls.Add(Me.lblSelDepart)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnCancel)
        Me.Name = "prntChoice"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print Options"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdoPlainText As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rdoSingleDepart As System.Windows.Forms.RadioButton
    Friend WithEvents rdoAllDeparts As System.Windows.Forms.RadioButton
    Friend WithEvents cboDepartments As System.Windows.Forms.ComboBox
    Friend WithEvents lblSelDepart As System.Windows.Forms.Label
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
