<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Finance
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Finance))
        Me.pnlCustomerHistory = New System.Windows.Forms.Panel
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.TScboCustomerHistory = New System.Windows.Forms.ToolStripComboBox
        Me.tsFinancingDepartment = New System.Windows.Forms.ToolStrip
        Me.ScheduledTasks = New System.Windows.Forms.ToolStripDropDownButton
        Me.btnMarkTaskAsDone = New System.Windows.Forms.ToolStripMenuItem
        Me.btnEditScheduledTask = New System.Windows.Forms.ToolStripMenuItem
        Me.btnRemoveThisCompletedTask = New System.Windows.Forms.ToolStripMenuItem
        Me.btnRemoveAllScheduledTask = New System.Windows.Forms.ToolStripMenuItem
        Me.pnlScheduledTasks = New System.Windows.Forms.Panel
        Me.pnlCustomerHistory.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.tsFinancingDepartment.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlCustomerHistory
        '
        Me.pnlCustomerHistory.Controls.Add(Me.ToolStrip1)
        Me.pnlCustomerHistory.Location = New System.Drawing.Point(46, 86)
        Me.pnlCustomerHistory.Name = "pnlCustomerHistory"
        Me.pnlCustomerHistory.Size = New System.Drawing.Size(200, 100)
        Me.pnlCustomerHistory.TabIndex = 1
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
        'tsFinancingDepartment
        '
        Me.tsFinancingDepartment.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsFinancingDepartment.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ScheduledTasks})
        Me.tsFinancingDepartment.Location = New System.Drawing.Point(0, 0)
        Me.tsFinancingDepartment.Name = "tsFinancingDepartment"
        Me.tsFinancingDepartment.Size = New System.Drawing.Size(673, 25)
        Me.tsFinancingDepartment.TabIndex = 251
        Me.tsFinancingDepartment.Text = "ToolStrip1"
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
        'pnlScheduledTasks
        '
        Me.pnlScheduledTasks.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlScheduledTasks.AutoScroll = True
        Me.pnlScheduledTasks.BackColor = System.Drawing.Color.White
        Me.pnlScheduledTasks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlScheduledTasks.Location = New System.Drawing.Point(52, 193)
        Me.pnlScheduledTasks.Name = "pnlScheduledTasks"
        Me.pnlScheduledTasks.Size = New System.Drawing.Size(628, 231)
        Me.pnlScheduledTasks.TabIndex = 250
        '
        'Finance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 599)
        Me.Controls.Add(Me.tsFinancingDepartment)
        Me.Controls.Add(Me.pnlScheduledTasks)
        Me.Controls.Add(Me.pnlCustomerHistory)
        Me.Name = "Finance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Finance"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlCustomerHistory.ResumeLayout(False)
        Me.pnlCustomerHistory.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.tsFinancingDepartment.ResumeLayout(False)
        Me.tsFinancingDepartment.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlCustomerHistory As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents TScboCustomerHistory As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents tsFinancingDepartment As System.Windows.Forms.ToolStrip
    Friend WithEvents ScheduledTasks As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents btnMarkTaskAsDone As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnEditScheduledTask As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnRemoveThisCompletedTask As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnRemoveAllScheduledTask As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlScheduledTasks As System.Windows.Forms.Panel
End Class
