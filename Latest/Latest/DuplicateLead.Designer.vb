<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DuplicateLead
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
        Me.lstDupes = New System.Windows.Forms.ListView
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.btnCancel = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.btnNew = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lstDupes
        '
        Me.lstDupes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lstDupes.FullRowSelect = True
        Me.lstDupes.GridLines = True
        Me.lstDupes.Location = New System.Drawing.Point(12, 12)
        Me.lstDupes.Name = "lstDupes"
        Me.lstDupes.Size = New System.Drawing.Size(659, 253)
        Me.lstDupes.TabIndex = 0
        Me.lstDupes.UseCompatibleStateImageBehavior = False
        Me.lstDupes.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Lead Number"
        Me.ColumnHeader3.Width = 89
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Contact Name"
        Me.ColumnHeader1.Width = 209
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Address"
        Me.ColumnHeader2.Width = 356
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(12, 271)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Previous"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(427, 271)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(508, 271)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(163, 23)
        Me.btnNew.TabIndex = 3
        Me.btnNew.Text = "Enter As New Lead"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'DuplicateLead
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 300)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lstDupes)
        Me.Name = "DuplicateLead"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "DuplicateLead"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstDupes As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
End Class
