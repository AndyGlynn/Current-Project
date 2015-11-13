<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employee_Contacts
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Employee_Contacts))
        Me.Label1 = New System.Windows.Forms.Label
        Me.cboDepartment = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lstEmployees = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Pctautodial = New System.Windows.Forms.Button
        Me.pctClose = New System.Windows.Forms.Button
        Me.pctnew = New System.Windows.Forms.Button
        Me.pctEdit = New System.Windows.Forms.Button
        Me.pctDelete = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(18, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Select Department"
        '
        'cboDepartment
        '
        Me.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDepartment.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDepartment.FormattingEnabled = True
        Me.cboDepartment.Location = New System.Drawing.Point(12, 37)
        Me.cboDepartment.Name = "cboDepartment"
        Me.cboDepartment.Size = New System.Drawing.Size(162, 24)
        Me.cboDepartment.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(193, 203)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(260, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Highlight Employee and Click Auto Dial to Call"
        '
        'lstEmployees
        '
        Me.lstEmployees.AutoArrange = False
        Me.lstEmployees.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader3})
        Me.lstEmployees.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstEmployees.FullRowSelect = True
        Me.lstEmployees.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lstEmployees.Location = New System.Drawing.Point(181, 6)
        Me.lstEmployees.Name = "lstEmployees"
        Me.lstEmployees.Size = New System.Drawing.Size(284, 193)
        Me.lstEmployees.TabIndex = 1
        Me.lstEmployees.UseCompatibleStateImageBehavior = False
        Me.lstEmployees.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "FName"
        Me.ColumnHeader1.Width = 175
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "PrimaryNumber"
        Me.ColumnHeader3.Width = 100
        '
        'Pctautodial
        '
        Me.Pctautodial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Pctautodial.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Pctautodial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Pctautodial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Pctautodial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Pctautodial.Image = CType(resources.GetObject("Pctautodial.Image"), System.Drawing.Image)
        Me.Pctautodial.Location = New System.Drawing.Point(54, 147)
        Me.Pctautodial.Name = "Pctautodial"
        Me.Pctautodial.Size = New System.Drawing.Size(36, 36)
        Me.Pctautodial.TabIndex = 5
        Me.Pctautodial.UseVisualStyleBackColor = True
        '
        'pctClose
        '
        Me.pctClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pctClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.pctClose.FlatAppearance.BorderSize = 0
        Me.pctClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.pctClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue
        Me.pctClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pctClose.Image = CType(resources.GetObject("pctClose.Image"), System.Drawing.Image)
        Me.pctClose.Location = New System.Drawing.Point(96, 147)
        Me.pctClose.Name = "pctClose"
        Me.pctClose.Size = New System.Drawing.Size(36, 36)
        Me.pctClose.TabIndex = 6
        Me.pctClose.UseVisualStyleBackColor = True
        '
        'pctnew
        '
        Me.pctnew.BackgroundImage = CType(resources.GetObject("pctnew.BackgroundImage"), System.Drawing.Image)
        Me.pctnew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pctnew.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.pctnew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.pctnew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pctnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pctnew.Location = New System.Drawing.Point(12, 64)
        Me.pctnew.Name = "pctnew"
        Me.pctnew.Size = New System.Drawing.Size(50, 45)
        Me.pctnew.TabIndex = 2
        Me.pctnew.UseVisualStyleBackColor = True
        '
        'pctEdit
        '
        Me.pctEdit.BackgroundImage = CType(resources.GetObject("pctEdit.BackgroundImage"), System.Drawing.Image)
        Me.pctEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pctEdit.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.pctEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.pctEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pctEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pctEdit.Location = New System.Drawing.Point(68, 64)
        Me.pctEdit.Name = "pctEdit"
        Me.pctEdit.Size = New System.Drawing.Size(50, 45)
        Me.pctEdit.TabIndex = 3
        Me.pctEdit.UseVisualStyleBackColor = True
        '
        'pctDelete
        '
        Me.pctDelete.BackgroundImage = CType(resources.GetObject("pctDelete.BackgroundImage"), System.Drawing.Image)
        Me.pctDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pctDelete.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.pctDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.pctDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pctDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pctDelete.Location = New System.Drawing.Point(124, 64)
        Me.pctDelete.Name = "pctDelete"
        Me.pctDelete.Size = New System.Drawing.Size(50, 45)
        Me.pctDelete.TabIndex = 4
        Me.pctDelete.UseVisualStyleBackColor = True
        '
        'Employee_Contacts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 218)
        Me.Controls.Add(Me.pctDelete)
        Me.Controls.Add(Me.pctEdit)
        Me.Controls.Add(Me.pctnew)
        Me.Controls.Add(Me.pctClose)
        Me.Controls.Add(Me.Pctautodial)
        Me.Controls.Add(Me.lstEmployees)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboDepartment)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Employee_Contacts"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lstEmployees As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Pctautodial As System.Windows.Forms.Button
    Friend WithEvents pctClose As System.Windows.Forms.Button
    Friend WithEvents pctnew As System.Windows.Forms.Button
    Friend WithEvents pctEdit As System.Windows.Forms.Button
    Friend WithEvents pctDelete As System.Windows.Forms.Button
End Class
