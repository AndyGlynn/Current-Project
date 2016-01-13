<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FinancingDepartment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FinancingDepartment))
        Me.ilScheduledTask = New System.Windows.Forms.ImageList(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblRecID = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ilScheduledTask
        '
        Me.ilScheduledTask.ImageStream = CType(resources.GetObject("ilScheduledTask.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilScheduledTask.TransparentColor = System.Drawing.Color.Transparent
        Me.ilScheduledTask.Images.SetKeyName(0, "done3.ico")
        Me.ilScheduledTask.Images.SetKeyName(1, "6.ico")
        Me.ilScheduledTask.Images.SetKeyName(2, "Notes4.ico")
        Me.ilScheduledTask.Images.SetKeyName(3, "attached files icon.ico")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Current Lead: "
        '
        'lblRecID
        '
        Me.lblRecID.AutoSize = True
        Me.lblRecID.Location = New System.Drawing.Point(110, 13)
        Me.lblRecID.Name = "lblRecID"
        Me.lblRecID.Size = New System.Drawing.Size(10, 13)
        Me.lblRecID.TabIndex = 1
        Me.lblRecID.Text = " "
        '
        'FinancingDepartment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 266)
        Me.Controls.Add(Me.lblRecID)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FinancingDepartment"
        Me.Text = "FinancingDepartment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ilScheduledTask As System.Windows.Forms.ImageList
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblRecID As System.Windows.Forms.Label
End Class
