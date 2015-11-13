<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageAlerts
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageAlerts))
        Me.btnNext = New System.Windows.Forms.Button()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblCustomerNFO = New System.Windows.Forms.Label()
        Me.btnChangeTime = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpTime = New System.Windows.Forms.DateTimePicker()
        Me.lvExpiredAlerts = New System.Windows.Forms.ListView()
        Me.DateTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CustN = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CustPh = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.grpChange = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lnkID = New System.Windows.Forms.LinkLabel()
        Me.lblNotes = New System.Windows.Forms.RichTextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpChange.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(325, 309)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(139, 26)
        Me.btnNext.TabIndex = 1
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(114, 178)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(0, 13)
        Me.lblTime.TabIndex = 8
        '
        'lblCustomerNFO
        '
        Me.lblCustomerNFO.AutoSize = True
        Me.lblCustomerNFO.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerNFO.Location = New System.Drawing.Point(10, 38)
        Me.lblCustomerNFO.Name = "lblCustomerNFO"
        Me.lblCustomerNFO.Size = New System.Drawing.Size(0, 13)
        Me.lblCustomerNFO.TabIndex = 7
        '
        'btnChangeTime
        '
        Me.btnChangeTime.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangeTime.Location = New System.Drawing.Point(14, 309)
        Me.btnChangeTime.Name = "btnChangeTime"
        Me.btnChangeTime.Size = New System.Drawing.Size(164, 26)
        Me.btnChangeTime.TabIndex = 196
        Me.btnChangeTime.Text = "Change Date\Time..."
        Me.btnChangeTime.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(185, 309)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(133, 26)
        Me.btnDelete.TabIndex = 197
        Me.btnDelete.Text = "Delete Alert"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider1.ContainerControl = Me
        '
        'dtpDate
        '
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(14, 54)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(137, 23)
        Me.dtpDate.TabIndex = 2
        '
        'dtpTime
        '
        Me.dtpTime.CustomFormat = "hh:mm tt"
        Me.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTime.Location = New System.Drawing.Point(14, 121)
        Me.dtpTime.Name = "dtpTime"
        Me.dtpTime.ShowUpDown = True
        Me.dtpTime.Size = New System.Drawing.Size(137, 23)
        Me.dtpTime.TabIndex = 199
        '
        'lvExpiredAlerts
        '
        Me.lvExpiredAlerts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.DateTime, Me.Id, Me.CustN, Me.CustPh})
        Me.lvExpiredAlerts.Cursor = System.Windows.Forms.Cursors.No
        Me.lvExpiredAlerts.FullRowSelect = True
        Me.lvExpiredAlerts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lvExpiredAlerts.HideSelection = False
        Me.lvExpiredAlerts.Location = New System.Drawing.Point(14, 210)
        Me.lvExpiredAlerts.Name = "lvExpiredAlerts"
        Me.lvExpiredAlerts.Size = New System.Drawing.Size(450, 86)
        Me.lvExpiredAlerts.TabIndex = 200
        Me.lvExpiredAlerts.TabStop = False
        Me.lvExpiredAlerts.UseCompatibleStateImageBehavior = False
        Me.lvExpiredAlerts.View = System.Windows.Forms.View.Details
        '
        'DateTime
        '
        Me.DateTime.Text = "Date-Time"
        Me.DateTime.Width = 130
        '
        'Id
        '
        Me.Id.Text = "Customer ID"
        Me.Id.Width = 62
        '
        'CustN
        '
        Me.CustN.Text = "Customer Name"
        Me.CustN.Width = 120
        '
        'CustPh
        '
        Me.CustPh.Text = "Phone #"
        Me.CustPh.Width = 109
        '
        'grpChange
        '
        Me.grpChange.Controls.Add(Me.Label2)
        Me.grpChange.Controls.Add(Me.Label1)
        Me.grpChange.Controls.Add(Me.dtpTime)
        Me.grpChange.Controls.Add(Me.dtpDate)
        Me.grpChange.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpChange.Location = New System.Drawing.Point(295, 14)
        Me.grpChange.Name = "grpChange"
        Me.grpChange.Size = New System.Drawing.Size(173, 177)
        Me.grpChange.TabIndex = 201
        Me.grpChange.TabStop = False
        Me.grpChange.Text = "Change Date/Time"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 201
        Me.Label2.Text = "New Time"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 200
        Me.Label1.Text = "New Date"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(14, 178)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(0, 13)
        Me.lblDate.TabIndex = 202
        '
        'lnkID
        '
        Me.lnkID.AutoSize = True
        Me.lnkID.Location = New System.Drawing.Point(10, 14)
        Me.lnkID.Name = "lnkID"
        Me.lnkID.Size = New System.Drawing.Size(0, 13)
        Me.lnkID.TabIndex = 203
        '
        'lblNotes
        '
        Me.lblNotes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblNotes.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotes.Location = New System.Drawing.Point(14, 124)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Size = New System.Drawing.Size(264, 48)
        Me.lblNotes.TabIndex = 204
        Me.lblNotes.Text = ""
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'ManageAlerts
        '
        Me.AcceptButton = Me.btnDelete
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(482, 347)
        Me.Controls.Add(Me.lblNotes)
        Me.Controls.Add(Me.lnkID)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.grpChange)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnChangeTime)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblCustomerNFO)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lvExpiredAlerts)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ManageAlerts"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage Expired Alerts..."
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpChange.ResumeLayout(False)
        Me.grpChange.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblCustomerNFO As System.Windows.Forms.Label
    Friend WithEvents btnChangeTime As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents dtpTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lvExpiredAlerts As System.Windows.Forms.ListView
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents grpChange As System.Windows.Forms.GroupBox
    Friend WithEvents Id As System.Windows.Forms.ColumnHeader
    Friend WithEvents CustN As System.Windows.Forms.ColumnHeader
    Friend WithEvents CustPh As System.Windows.Forms.ColumnHeader
    Friend WithEvents DateTime As System.Windows.Forms.ColumnHeader
    Friend WithEvents lnkID As System.Windows.Forms.LinkLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblNotes As System.Windows.Forms.RichTextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
