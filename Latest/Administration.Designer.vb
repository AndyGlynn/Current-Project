<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Administration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Administration))
        Me.tsInstallationDepartment = New System.Windows.Forms.ToolStrip()
        Me.ScheduledTasks = New System.Windows.Forms.ToolStripDropDownButton()
        Me.btnMarkTaskAsDone = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnEditScheduledTask = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnRemoveThisCompletedTask = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnRemoveAllScheduledTask = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsbtnUsers = New System.Windows.Forms.ToolStripButton()
        Me.ilScheduledTask = New System.Windows.Forms.ImageList(Me.components)
        Me.pnlScheduledTasks = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pnlCustomerHistory = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TScboCustomerHistory = New System.Windows.Forms.ToolStripComboBox()
        Me.tsInstallationDepartment.SuspendLayout()
        Me.pnlCustomerHistory.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsInstallationDepartment
        '
        Me.tsInstallationDepartment.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsInstallationDepartment.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ScheduledTasks, Me.tsbtnUsers})
        Me.tsInstallationDepartment.Location = New System.Drawing.Point(0, 0)
        Me.tsInstallationDepartment.Name = "tsInstallationDepartment"
        Me.tsInstallationDepartment.Size = New System.Drawing.Size(889, 25)
        Me.tsInstallationDepartment.TabIndex = 253
        Me.tsInstallationDepartment.Text = "ToolStrip1"
        '
        'ScheduledTasks
        '
        Me.ScheduledTasks.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnMarkTaskAsDone, Me.btnEditScheduledTask, Me.btnRemoveThisCompletedTask, Me.btnRemoveAllScheduledTask})
        Me.ScheduledTasks.Image = CType(resources.GetObject("ScheduledTasks.Image"), System.Drawing.Image)
        Me.ScheduledTasks.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ScheduledTasks.Name = "ScheduledTasks"
        Me.ScheduledTasks.Size = New System.Drawing.Size(141, 22)
        Me.ScheduledTasks.Text = "Edit Scheduled Task"
        '
        'btnMarkTaskAsDone
        '
        Me.btnMarkTaskAsDone.Name = "btnMarkTaskAsDone"
        Me.btnMarkTaskAsDone.Size = New System.Drawing.Size(231, 22)
        Me.btnMarkTaskAsDone.Text = "Mark Task as Done"
        '
        'btnEditScheduledTask
        '
        Me.btnEditScheduledTask.Name = "btnEditScheduledTask"
        Me.btnEditScheduledTask.Size = New System.Drawing.Size(231, 22)
        Me.btnEditScheduledTask.Text = "Edit Scheduled Task"
        '
        'btnRemoveThisCompletedTask
        '
        Me.btnRemoveThisCompletedTask.Name = "btnRemoveThisCompletedTask"
        Me.btnRemoveThisCompletedTask.Size = New System.Drawing.Size(231, 22)
        Me.btnRemoveThisCompletedTask.Text = "Remove This Completed Task"
        '
        'btnRemoveAllScheduledTask
        '
        Me.btnRemoveAllScheduledTask.Name = "btnRemoveAllScheduledTask"
        Me.btnRemoveAllScheduledTask.Size = New System.Drawing.Size(231, 22)
        Me.btnRemoveAllScheduledTask.Text = "Remove All Completed Tasks"
        '
        'tsbtnUsers
        '
        Me.tsbtnUsers.Image = Global.Latest.My.Resources.Resources.user
        Me.tsbtnUsers.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnUsers.Name = "tsbtnUsers"
        Me.tsbtnUsers.Size = New System.Drawing.Size(101, 22)
        Me.tsbtnUsers.Text = "Manage Users"
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
        Me.pnlScheduledTasks.Location = New System.Drawing.Point(12, 28)
        Me.pnlScheduledTasks.Name = "pnlScheduledTasks"
        Me.pnlScheduledTasks.Size = New System.Drawing.Size(865, 268)
        Me.pnlScheduledTasks.TabIndex = 254
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(819, 313)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(58, 33)
        Me.Button1.TabIndex = 255
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pnlCustomerHistory
        '
        Me.pnlCustomerHistory.Controls.Add(Me.ToolStrip1)
        Me.pnlCustomerHistory.Location = New System.Drawing.Point(12, 369)
        Me.pnlCustomerHistory.Name = "pnlCustomerHistory"
        Me.pnlCustomerHistory.Size = New System.Drawing.Size(865, 100)
        Me.pnlCustomerHistory.TabIndex = 256
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TScboCustomerHistory})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(865, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'TScboCustomerHistory
        '
        Me.TScboCustomerHistory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TScboCustomerHistory.Name = "TScboCustomerHistory"
        Me.TScboCustomerHistory.Size = New System.Drawing.Size(121, 25)
        '
        'Administration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 481)
        Me.Controls.Add(Me.pnlCustomerHistory)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pnlScheduledTasks)
        Me.Controls.Add(Me.tsInstallationDepartment)
        Me.Name = "Administration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administration"
        Me.tsInstallationDepartment.ResumeLayout(False)
        Me.tsInstallationDepartment.PerformLayout()
        Me.pnlCustomerHistory.ResumeLayout(False)
        Me.pnlCustomerHistory.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsInstallationDepartment As System.Windows.Forms.ToolStrip
    Friend WithEvents ScheduledTasks As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents btnMarkTaskAsDone As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnEditScheduledTask As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnRemoveThisCompletedTask As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnRemoveAllScheduledTask As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsbtnUsers As System.Windows.Forms.ToolStripButton
    Friend WithEvents ilScheduledTask As System.Windows.Forms.ImageList
    Friend WithEvents pnlScheduledTasks As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents pnlCustomerHistory As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents TScboCustomerHistory As System.Windows.Forms.ToolStripComboBox
End Class
