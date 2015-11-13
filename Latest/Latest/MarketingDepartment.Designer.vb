<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MarketingDepartment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MarketingDepartment))
        Me.ilScheduledTask = New System.Windows.Forms.ImageList(Me.components)
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
        'MarketingDepartment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(815, 266)
        Me.Name = "MarketingDepartment"
        Me.Text = "MarketingDepartment"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ilScheduledTask As System.Windows.Forms.ImageList
End Class
