<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class exclusions
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
        Me.chkMarketer = New System.Windows.Forms.CheckBox
        Me.chkPLS = New System.Windows.Forms.CheckBox
        Me.chkSLS = New System.Windows.Forms.CheckBox
        Me.chkGenerated = New System.Windows.Forms.CheckBox
        Me.chkPhone = New System.Windows.Forms.CheckBox
        Me.chkMResult = New System.Windows.Forms.CheckBox
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.ep = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ep, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkMarketer
        '
        Me.chkMarketer.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkMarketer.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkMarketer.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMarketer.Location = New System.Drawing.Point(18, 49)
        Me.chkMarketer.Name = "chkMarketer"
        Me.chkMarketer.Size = New System.Drawing.Size(307, 31)
        Me.chkMarketer.TabIndex = 5
        Me.chkMarketer.Text = "Exclude Marketer"
        Me.chkMarketer.UseVisualStyleBackColor = True
        '
        'chkPLS
        '
        Me.chkPLS.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkPLS.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkPLS.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPLS.Location = New System.Drawing.Point(18, 86)
        Me.chkPLS.Name = "chkPLS"
        Me.chkPLS.Size = New System.Drawing.Size(307, 31)
        Me.chkPLS.TabIndex = 6
        Me.chkPLS.Text = "Exclude Primary Lead Source"
        Me.chkPLS.UseVisualStyleBackColor = True
        '
        'chkSLS
        '
        Me.chkSLS.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkSLS.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkSLS.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSLS.Location = New System.Drawing.Point(18, 123)
        Me.chkSLS.Name = "chkSLS"
        Me.chkSLS.Size = New System.Drawing.Size(307, 31)
        Me.chkSLS.TabIndex = 7
        Me.chkSLS.Text = "Exclude Secondary Lead Source"
        Me.chkSLS.UseVisualStyleBackColor = True
        '
        'chkGenerated
        '
        Me.chkGenerated.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkGenerated.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkGenerated.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGenerated.Location = New System.Drawing.Point(18, 12)
        Me.chkGenerated.Name = "chkGenerated"
        Me.chkGenerated.Size = New System.Drawing.Size(307, 31)
        Me.chkGenerated.TabIndex = 8
        Me.chkGenerated.Text = "Exclude Date Lead Generated"
        Me.chkGenerated.UseVisualStyleBackColor = True
        '
        'chkPhone
        '
        Me.chkPhone.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkPhone.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkPhone.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPhone.Location = New System.Drawing.Point(18, 160)
        Me.chkPhone.Name = "chkPhone"
        Me.chkPhone.Size = New System.Drawing.Size(307, 31)
        Me.chkPhone.TabIndex = 9
        Me.chkPhone.Text = "Exclude Phone Number(s)"
        Me.chkPhone.UseVisualStyleBackColor = True
        '
        'chkMResult
        '
        Me.chkMResult.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkMResult.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkMResult.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMResult.Location = New System.Drawing.Point(18, 197)
        Me.chkMResult.Name = "chkMResult"
        Me.chkMResult.Size = New System.Drawing.Size(307, 31)
        Me.chkMResult.TabIndex = 10
        Me.chkMResult.Text = "Exclude Previous Marketing Result"
        Me.chkMResult.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(175, 252)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(154, 23)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(13, 252)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(154, 23)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'ep
        '
        Me.ep.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ep.ContainerControl = Me
        '
        'exclusions
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(342, 289)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.chkMResult)
        Me.Controls.Add(Me.chkPhone)
        Me.Controls.Add(Me.chkGenerated)
        Me.Controls.Add(Me.chkSLS)
        Me.Controls.Add(Me.chkPLS)
        Me.Controls.Add(Me.chkMarketer)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "exclusions"
        Me.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Exclude from Appointment Print/Email Information"
        CType(Me.ep, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents chkMarketer As System.Windows.Forms.CheckBox
    Friend WithEvents chkPLS As System.Windows.Forms.CheckBox
    Friend WithEvents chkSLS As System.Windows.Forms.CheckBox
    Friend WithEvents chkGenerated As System.Windows.Forms.CheckBox
    Friend WithEvents chkPhone As System.Windows.Forms.CheckBox
    Friend WithEvents chkMResult As System.Windows.Forms.CheckBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents ep As System.Windows.Forms.ErrorProvider
End Class
