<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductDetail
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
        Me.cboUnit = New System.Windows.Forms.ComboBox()
        Me.spnQTY = New System.Windows.Forms.NumericUpDown()
        Me.cboColor = New System.Windows.Forms.ComboBox()
        Me.cboMake = New System.Windows.Forms.ComboBox()
        Me.cboMan = New System.Windows.Forms.ComboBox()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.btnSaveClose = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboStyle = New System.Windows.Forms.ComboBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.spnQTY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboUnit
        '
        Me.cboUnit.BackColor = System.Drawing.SystemColors.Window
        Me.cboUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUnit.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUnit.FormattingEnabled = True
        Me.cboUnit.Location = New System.Drawing.Point(120, 147)
        Me.cboUnit.Name = "cboUnit"
        Me.cboUnit.Size = New System.Drawing.Size(147, 21)
        Me.cboUnit.TabIndex = 5
        '
        'spnQTY
        '
        Me.spnQTY.Location = New System.Drawing.Point(120, 121)
        Me.spnQTY.Name = "spnQTY"
        Me.spnQTY.Size = New System.Drawing.Size(64, 21)
        Me.spnQTY.TabIndex = 4
        '
        'cboColor
        '
        Me.cboColor.BackColor = System.Drawing.SystemColors.Window
        Me.cboColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboColor.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboColor.FormattingEnabled = True
        Me.cboColor.Location = New System.Drawing.Point(120, 94)
        Me.cboColor.Name = "cboColor"
        Me.cboColor.Size = New System.Drawing.Size(244, 21)
        Me.cboColor.TabIndex = 3
        '
        'cboMake
        '
        Me.cboMake.BackColor = System.Drawing.SystemColors.Window
        Me.cboMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMake.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMake.FormattingEnabled = True
        Me.cboMake.Location = New System.Drawing.Point(120, 38)
        Me.cboMake.Name = "cboMake"
        Me.cboMake.Size = New System.Drawing.Size(244, 21)
        Me.cboMake.TabIndex = 1
        '
        'cboMan
        '
        Me.cboMan.BackColor = System.Drawing.SystemColors.Window
        Me.cboMan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMan.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMan.FormattingEnabled = True
        Me.cboMan.Location = New System.Drawing.Point(120, 11)
        Me.cboMan.Name = "cboMan"
        Me.cboMan.Size = New System.Drawing.Size(244, 21)
        Me.cboMan.TabIndex = 0
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.ForeColor = System.Drawing.Color.Black
        Me.Label67.Location = New System.Drawing.Point(15, 97)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(43, 13)
        Me.Label67.TabIndex = 194
        Me.Label67.Text = "Color:"
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.ForeColor = System.Drawing.Color.Black
        Me.Label66.Location = New System.Drawing.Point(15, 150)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(34, 13)
        Me.Label66.TabIndex = 193
        Me.Label66.Text = "Unit:"
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.ForeColor = System.Drawing.Color.Black
        Me.Label59.Location = New System.Drawing.Point(15, 123)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(32, 13)
        Me.Label59.TabIndex = 192
        Me.Label59.Text = "Qty:"
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.ForeColor = System.Drawing.Color.Black
        Me.Label58.Location = New System.Drawing.Point(15, 41)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(45, 13)
        Me.Label58.TabIndex = 191
        Me.Label58.Text = "Model:"
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.ForeColor = System.Drawing.Color.Black
        Me.Label57.Location = New System.Drawing.Point(15, 14)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(87, 13)
        Me.Label57.TabIndex = 190
        Me.Label57.Text = "Manufacturer:"
        '
        'btnSaveClose
        '
        Me.btnSaveClose.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveClose.Location = New System.Drawing.Point(192, 174)
        Me.btnSaveClose.Name = "btnSaveClose"
        Me.btnSaveClose.Size = New System.Drawing.Size(120, 22)
        Me.btnSaveClose.TabIndex = 6
        Me.btnSaveClose.Text = "Save and Close"
        Me.btnSaveClose.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(65, 174)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(120, 22)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(15, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 200
        Me.Label1.Text = "Style:"
        '
        'cboStyle
        '
        Me.cboStyle.BackColor = System.Drawing.SystemColors.Window
        Me.cboStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStyle.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStyle.FormattingEnabled = True
        Me.cboStyle.Location = New System.Drawing.Point(120, 67)
        Me.cboStyle.Name = "cboStyle"
        Me.cboStyle.Size = New System.Drawing.Size(244, 21)
        Me.cboStyle.TabIndex = 2
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ProductDetail
        '
        Me.AcceptButton = Me.btnSaveClose
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(379, 204)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboStyle)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSaveClose)
        Me.Controls.Add(Me.Label67)
        Me.Controls.Add(Me.Label66)
        Me.Controls.Add(Me.Label59)
        Me.Controls.Add(Me.Label58)
        Me.Controls.Add(Me.Label57)
        Me.Controls.Add(Me.cboUnit)
        Me.Controls.Add(Me.spnQTY)
        Me.Controls.Add(Me.cboColor)
        Me.Controls.Add(Me.cboMake)
        Me.Controls.Add(Me.cboMan)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ProductDetail"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.spnQTY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboUnit As System.Windows.Forms.ComboBox
    Friend WithEvents spnQTY As System.Windows.Forms.NumericUpDown
    Friend WithEvents cboColor As System.Windows.Forms.ComboBox
    Friend WithEvents cboMake As System.Windows.Forms.ComboBox
    Friend WithEvents cboMan As System.Windows.Forms.ComboBox
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents btnSaveClose As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboStyle As System.Windows.Forms.ComboBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
