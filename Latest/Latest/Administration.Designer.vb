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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Administration))
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Resets")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Not Hits")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Not Issued")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sales ", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3})
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Called & Cancelled")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Unconfirmed")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Marketing", New System.Windows.Forms.TreeNode() {TreeNode5, TreeNode6})
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Results ", New System.Windows.Forms.TreeNode() {TreeNode4, TreeNode7})
        Me.ilScheduledTask = New System.Windows.Forms.ImageList(Me.components)
        Me.pnlScheduledTasks = New System.Windows.Forms.Panel
        Me.tsInstallationDepartment = New System.Windows.Forms.ToolStrip
        Me.ScheduledTasks = New System.Windows.Forms.ToolStripDropDownButton
        Me.btnMarkTaskAsDone = New System.Windows.Forms.ToolStripMenuItem
        Me.btnEditScheduledTask = New System.Windows.Forms.ToolStripMenuItem
        Me.btnRemoveThisCompletedTask = New System.Windows.Forms.ToolStripMenuItem
        Me.btnRemoveAllScheduledTask = New System.Windows.Forms.ToolStripMenuItem
        Me.TreeView1 = New System.Windows.Forms.TreeView
        Me.Button1 = New System.Windows.Forms.Button
        Me.pnlCustomerHistory = New System.Windows.Forms.Panel
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.TScboCustomerHistory = New System.Windows.Forms.ToolStripComboBox
        Me.tsInstallationDepartment.SuspendLayout()
        Me.pnlCustomerHistory.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
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
        Me.pnlScheduledTasks.Location = New System.Drawing.Point(656, 18)
        Me.pnlScheduledTasks.Name = "pnlScheduledTasks"
        Me.pnlScheduledTasks.Size = New System.Drawing.Size(51, 231)
        Me.pnlScheduledTasks.TabIndex = 247
        '
        'tsInstallationDepartment
        '
        Me.tsInstallationDepartment.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsInstallationDepartment.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ScheduledTasks})
        Me.tsInstallationDepartment.Location = New System.Drawing.Point(0, 0)
        Me.tsInstallationDepartment.Name = "tsInstallationDepartment"
        Me.tsInstallationDepartment.Size = New System.Drawing.Size(786, 25)
        Me.tsInstallationDepartment.TabIndex = 251
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
        'TreeView1
        '
        Me.TreeView1.CheckBoxes = True
        Me.TreeView1.LabelEdit = True
        Me.TreeView1.Location = New System.Drawing.Point(12, 46)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "Node1"
        TreeNode1.Text = "Resets"
        TreeNode2.Name = "Node2"
        TreeNode2.Text = "Not Hits"
        TreeNode3.Name = "Node3"
        TreeNode3.Text = "Not Issued"
        TreeNode4.Name = "Node1"
        TreeNode4.Text = "Sales "
        TreeNode5.Name = "Node5"
        TreeNode5.Text = "Called & Cancelled"
        TreeNode6.Name = "Node6"
        TreeNode6.Text = "Unconfirmed"
        TreeNode7.Name = "Node2"
        TreeNode7.Text = "Marketing"
        TreeNode8.Checked = True
        TreeNode8.Name = "Node0"
        TreeNode8.Text = "Results "
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode8})
        Me.TreeView1.Size = New System.Drawing.Size(288, 208)
        Me.TreeView1.TabIndex = 252
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(346, 115)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(58, 33)
        Me.Button1.TabIndex = 253
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pnlCustomerHistory
        '
        Me.pnlCustomerHistory.Controls.Add(Me.ToolStrip1)
        Me.pnlCustomerHistory.Location = New System.Drawing.Point(425, 28)
        Me.pnlCustomerHistory.Name = "pnlCustomerHistory"
        Me.pnlCustomerHistory.Size = New System.Drawing.Size(200, 100)
        Me.pnlCustomerHistory.TabIndex = 254
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TScboCustomerHistory})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(200, 25)
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
        Me.ClientSize = New System.Drawing.Size(786, 266)
        Me.Controls.Add(Me.pnlCustomerHistory)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.tsInstallationDepartment)
        Me.Controls.Add(Me.pnlScheduledTasks)
        Me.Name = "Administration"
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
    Friend WithEvents ilScheduledTask As System.Windows.Forms.ImageList
    Friend WithEvents pnlScheduledTasks As System.Windows.Forms.Panel
    Friend WithEvents tsInstallationDepartment As System.Windows.Forms.ToolStrip
    Friend WithEvents ScheduledTasks As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents btnMarkTaskAsDone As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnEditScheduledTask As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnRemoveThisCompletedTask As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnRemoveAllScheduledTask As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents pnlCustomerHistory As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents TScboCustomerHistory As System.Windows.Forms.ToolStripComboBox
End Class
