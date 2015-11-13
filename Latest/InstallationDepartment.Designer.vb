<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InstallationDepartment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InstallationDepartment))
        Me.ilScheduledTask = New System.Windows.Forms.ImageList(Me.components)
        Me.pnlScheduledTasks = New System.Windows.Forms.Panel
        Me.tsInstallationDepartment = New System.Windows.Forms.ToolStrip
        Me.ScheduledTasks = New System.Windows.Forms.ToolStripDropDownButton
        Me.btnMarkTaskAsDone = New System.Windows.Forms.ToolStripMenuItem
        Me.btnEditScheduledTask = New System.Windows.Forms.ToolStripMenuItem
        Me.btnRemoveThisCompletedTask = New System.Windows.Forms.ToolStripMenuItem
        Me.btnRemoveAllScheduledTask = New System.Windows.Forms.ToolStripMenuItem
        Me.tsInstallationDepartment.SuspendLayout()
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
        'pnlScheduledTasks
        '
        Me.pnlScheduledTasks.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlScheduledTasks.AutoScroll = True
        Me.pnlScheduledTasks.BackColor = System.Drawing.Color.White
        Me.pnlScheduledTasks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlScheduledTasks.Location = New System.Drawing.Point(94, 18)
        Me.pnlScheduledTasks.Name = "pnlScheduledTasks"
        Me.pnlScheduledTasks.Size = New System.Drawing.Size(628, 231)
        Me.pnlScheduledTasks.TabIndex = 247
        '
        'tsInstallationDepartment
        '
        Me.tsInstallationDepartment.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsInstallationDepartment.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ScheduledTasks})
        Me.tsInstallationDepartment.Location = New System.Drawing.Point(0, 0)
        Me.tsInstallationDepartment.Name = "tsInstallationDepartment"
        Me.tsInstallationDepartment.Size = New System.Drawing.Size(817, 25)
        Me.tsInstallationDepartment.TabIndex = 250
        Me.tsInstallationDepartment.Text = "ToolStrip1"
        '
        'ScheduledTasks
        '
        Me.ScheduledTasks.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnMarkTaskAsDone, Me.btnEditScheduledTask, Me.btnRemoveThisCompletedTask, Me.btnRemoveAllScheduledTask})
        Me.ScheduledTasks.Image = CType(resources.GetObject("ScheduledTasks.Image"), System.Drawing.Image)
        Me.ScheduledTasks.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ScheduledTasks.Name = "ScheduledTasks"
        Me.ScheduledTasks.Size = New System.Drawing.Size(131, 22)
        Me.ScheduledTasks.Text = "Edit Scheduled Task"
        '
        'btnMarkTaskAsDone
        '
        Me.btnMarkTaskAsDone.Name = "btnMarkTaskAsDone"
        Me.btnMarkTaskAsDone.Size = New System.Drawing.Size(225, 22)
        Me.btnMarkTaskAsDone.Text = "Mark Task as Done"
        '
        'btnEditScheduledTask
        '
        Me.btnEditScheduledTask.Name = "btnEditScheduledTask"
        Me.btnEditScheduledTask.Size = New System.Drawing.Size(225, 22)
        Me.btnEditScheduledTask.Text = "Edit Scheduled Task"
        '
        'btnRemoveThisCompletedTask
        '
        Me.btnRemoveThisCompletedTask.Name = "btnRemoveThisCompletedTask"
        Me.btnRemoveThisCompletedTask.Size = New System.Drawing.Size(225, 22)
        Me.btnRemoveThisCompletedTask.Text = "Remove This Completed Task"
        '
        'btnRemoveAllScheduledTask
        '
        Me.btnRemoveAllScheduledTask.Name = "btnRemoveAllScheduledTask"
        Me.btnRemoveAllScheduledTask.Size = New System.Drawing.Size(225, 22)
        Me.btnRemoveAllScheduledTask.Text = "Remove All Completed Tasks"
        '
        'InstallationDepartment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 266)
        Me.Controls.Add(Me.tsInstallationDepartment)
        Me.Controls.Add(Me.pnlScheduledTasks)
        Me.Name = "InstallationDepartment"
        Me.Text = "InstallationDepartment"
        Me.tsInstallationDepartment.ResumeLayout(False)
        Me.tsInstallationDepartment.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ilScheduledTask As System.Windows.Forms.ImageList
    Friend WithEvents pnlScheduledTasks As System.Windows.Forms.Panel
    Friend WithEvents tsInstallationDepartment As System.Windows.Forms.ToolStrip
    Friend WithEvents ScheduledTasks As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents btnMarkTaskAsDone As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnEditScheduledTask As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnRemoveThisCompletedTask As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnRemoveAllScheduledTask As System.Windows.Forms.ToolStripMenuItem
End Class
