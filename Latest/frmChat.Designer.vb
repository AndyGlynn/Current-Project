<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChat))
        Me.lstUsers = New System.Windows.Forms.ListBox
        Me.contxtXFER = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SenderXFERRequestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.lstChat = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.txtMSG = New System.Windows.Forms.TextBox
        Me.btnSend = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.tmrChat = New System.Windows.Forms.Timer(Me.components)
        Me.contxtXFER.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstUsers
        '
        Me.lstUsers.ContextMenuStrip = Me.contxtXFER
        Me.lstUsers.FormattingEnabled = True
        Me.lstUsers.Location = New System.Drawing.Point(509, 38)
        Me.lstUsers.Name = "lstUsers"
        Me.lstUsers.Size = New System.Drawing.Size(128, 238)
        Me.lstUsers.TabIndex = 0
        '
        'contxtXFER
        '
        Me.contxtXFER.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SenderXFERRequestToolStripMenuItem})
        Me.contxtXFER.Name = "contxtXFER"
        Me.contxtXFER.Size = New System.Drawing.Size(185, 26)
        '
        'SenderXFERRequestToolStripMenuItem
        '
        Me.SenderXFERRequestToolStripMenuItem.Image = CType(resources.GetObject("SenderXFERRequestToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SenderXFERRequestToolStripMenuItem.Name = "SenderXFERRequestToolStripMenuItem"
        Me.SenderXFERRequestToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.SenderXFERRequestToolStripMenuItem.Text = "Sender XFER Request"
        '
        'lstChat
        '
        Me.lstChat.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lstChat.Location = New System.Drawing.Point(10, 38)
        Me.lstChat.Name = "lstChat"
        Me.lstChat.Size = New System.Drawing.Size(481, 198)
        Me.lstChat.TabIndex = 1
        Me.lstChat.UseCompatibleStateImageBehavior = False
        Me.lstChat.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "User:"
        Me.ColumnHeader1.Width = 124
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Message"
        Me.ColumnHeader2.Width = 352
        '
        'txtMSG
        '
        Me.txtMSG.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMSG.Location = New System.Drawing.Point(12, 252)
        Me.txtMSG.Name = "txtMSG"
        Me.txtMSG.Size = New System.Drawing.Size(414, 23)
        Me.txtMSG.TabIndex = 2
        '
        'btnSend
        '
        Me.btnSend.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSend.Location = New System.Drawing.Point(431, 250)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(60, 26)
        Me.btnSend.TabIndex = 3
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(509, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Online Now:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Chat Log:"
        '
        'tmrChat
        '
        Me.tmrChat.Interval = 500
        '
        'frmChat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 285)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.txtMSG)
        Me.Controls.Add(Me.lstChat)
        Me.Controls.Add(Me.lstUsers)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmChat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Local Chat"
        Me.contxtXFER.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstUsers As System.Windows.Forms.ListBox
    Friend WithEvents lstChat As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtMSG As System.Windows.Forms.TextBox
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents contxtXFER As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SenderXFERRequestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tmrChat As System.Windows.Forms.Timer
End Class
