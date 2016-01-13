<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ColdCalling
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
        Me.pnlCustomerHistory = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TScboCustomerHistory = New System.Windows.Forms.ToolStripComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblRecID = New System.Windows.Forms.Label()
        Me.pnlCustomerHistory.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlCustomerHistory
        '
        Me.pnlCustomerHistory.Controls.Add(Me.ToolStrip1)
        Me.pnlCustomerHistory.Location = New System.Drawing.Point(80, 161)
        Me.pnlCustomerHistory.Name = "pnlCustomerHistory"
        Me.pnlCustomerHistory.Size = New System.Drawing.Size(200, 100)
        Me.pnlCustomerHistory.TabIndex = 0
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Current Record: "
        '
        'lblRecID
        '
        Me.lblRecID.AutoSize = True
        Me.lblRecID.Location = New System.Drawing.Point(105, 25)
        Me.lblRecID.Name = "lblRecID"
        Me.lblRecID.Size = New System.Drawing.Size(10, 13)
        Me.lblRecID.TabIndex = 2
        Me.lblRecID.Text = " "
        '
        'ColdCalling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.lblRecID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pnlCustomerHistory)
        Me.Name = "ColdCalling"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ColdCalling"
        Me.pnlCustomerHistory.ResumeLayout(False)
        Me.pnlCustomerHistory.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlCustomerHistory As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents TScboCustomerHistory As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblRecID As System.Windows.Forms.Label
End Class
