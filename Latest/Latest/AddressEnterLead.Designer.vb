<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddressEnterLead
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Address 1")
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Address 2")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddressEnterLead))
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.btnDoNotUpdate = New System.Windows.Forms.Button
        Me.btnBack = New System.Windows.Forms.Button
        Me.lvAddresses = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(358, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = " found multiple selections for this address, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "select the appropriate match or go" & _
            " ""Back"" to edit the address"
        '
        'btnUpdate
        '
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.Location = New System.Drawing.Point(283, 165)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(142, 40)
        Me.btnUpdate.TabIndex = 2
        Me.btnUpdate.Text = "Update ""My Address"" with this Address "
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDoNotUpdate
        '
        Me.btnDoNotUpdate.Location = New System.Drawing.Point(163, 165)
        Me.btnDoNotUpdate.Name = "btnDoNotUpdate"
        Me.btnDoNotUpdate.Size = New System.Drawing.Size(113, 40)
        Me.btnDoNotUpdate.TabIndex = 3
        Me.btnDoNotUpdate.Text = "Use My Address (Do Not Verify)"
        Me.btnDoNotUpdate.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBack.Location = New System.Drawing.Point(14, 165)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(142, 40)
        Me.btnBack.TabIndex = 4
        Me.btnBack.Text = "Go Back and Manually Edit ""My Address"""
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lvAddresses
        '
        Me.lvAddresses.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.lvAddresses.FullRowSelect = True
        Me.lvAddresses.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lvAddresses.HideSelection = False
        Me.lvAddresses.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2})
        Me.lvAddresses.Location = New System.Drawing.Point(14, 38)
        Me.lvAddresses.MultiSelect = False
        Me.lvAddresses.Name = "lvAddresses"
        Me.lvAddresses.Size = New System.Drawing.Size(411, 121)
        Me.lvAddresses.TabIndex = 5
        Me.lvAddresses.UseCompatibleStateImageBehavior = False
        Me.lvAddresses.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Matching Address(es)"
        Me.ColumnHeader1.Width = 340
        '
        'AddressEnterLead
        '
        Me.AcceptButton = Me.btnUpdate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnBack
        Me.ClientSize = New System.Drawing.Size(437, 215)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnDoNotUpdate)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lvAddresses)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddressEnterLead"
        Me.Text = "Multiple Addresses Found"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDoNotUpdate As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents lvAddresses As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader

End Class
