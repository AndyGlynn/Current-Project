<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SecondSource
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
        Me.pnlCustomerHistory = New System.Windows.Forms.Panel
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.TScboCustomerHistory = New System.Windows.Forms.ToolStripComboBox
        Me.pnlCustomerHistory.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlCustomerHistory
        '
        Me.pnlCustomerHistory.Controls.Add(Me.ToolStrip1)
        Me.pnlCustomerHistory.Location = New System.Drawing.Point(42, 81)
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
        'SecondSource
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.pnlCustomerHistory)
        Me.Name = "SecondSource"
        Me.Text = "SecondSource"
        Me.pnlCustomerHistory.ResumeLayout(False)
        Me.pnlCustomerHistory.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlCustomerHistory As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents TScboCustomerHistory As System.Windows.Forms.ToolStripComboBox
End Class
