<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlertNotify
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AlertNotify))
        Me.lnkID = New System.Windows.Forms.LinkLabel()
        Me.lblCustomerNFO = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.btnclosewindow = New System.Windows.Forms.Label()
        Me.btnRemind = New System.Windows.Forms.Label()
        Me.lblUID = New System.Windows.Forms.Label()
        Me.lblnotes = New System.Windows.Forms.RichTextBox()
        Me.pctOff1 = New System.Windows.Forms.PictureBox()
        Me.pctOn1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pctOff2 = New System.Windows.Forms.PictureBox()
        Me.pctOff3 = New System.Windows.Forms.PictureBox()
        Me.pctOff4 = New System.Windows.Forms.PictureBox()
        Me.pctOff5 = New System.Windows.Forms.PictureBox()
        Me.pctOff6 = New System.Windows.Forms.PictureBox()
        Me.pctOff7 = New System.Windows.Forms.PictureBox()
        Me.pctOff8 = New System.Windows.Forms.PictureBox()
        Me.pctOn2 = New System.Windows.Forms.PictureBox()
        Me.pctOn3 = New System.Windows.Forms.PictureBox()
        Me.pctOn4 = New System.Windows.Forms.PictureBox()
        Me.pctOn5 = New System.Windows.Forms.PictureBox()
        Me.pctOn6 = New System.Windows.Forms.PictureBox()
        Me.pctOn7 = New System.Windows.Forms.PictureBox()
        Me.pctOn8 = New System.Windows.Forms.PictureBox()
        CType(Me.pctOff1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctOn1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctOff2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctOff3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctOff4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctOff5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctOff6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctOff7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctOff8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctOn2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctOn3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctOn4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctOn5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctOn6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctOn7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctOn8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lnkID
        '
        Me.lnkID.AutoSize = True
        Me.lnkID.Location = New System.Drawing.Point(14, 11)
        Me.lnkID.Name = "lnkID"
        Me.lnkID.Size = New System.Drawing.Size(42, 13)
        Me.lnkID.TabIndex = 1
        Me.lnkID.TabStop = True
        Me.lnkID.Text = "20548"
        '
        'lblCustomerNFO
        '
        Me.lblCustomerNFO.AutoSize = True
        Me.lblCustomerNFO.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerNFO.Location = New System.Drawing.Point(14, 35)
        Me.lblCustomerNFO.Name = "lblCustomerNFO"
        Me.lblCustomerNFO.Size = New System.Drawing.Size(129, 78)
        Me.lblCustomerNFO.TabIndex = 2
        Me.lblCustomerNFO.Text = "John and Betty Smith" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1234 Main St. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Toledo, Oh 43613" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(419)472-4000" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(419)467-4" & _
    "926" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(419)350-5369" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(14, 127)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(53, 13)
        Me.lblTime.TabIndex = 3
        Me.lblTime.Text = "5:00 PM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnclosewindow
        '
        Me.btnclosewindow.AutoSize = True
        Me.btnclosewindow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnclosewindow.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclosewindow.ForeColor = System.Drawing.Color.DarkGray
        Me.btnclosewindow.Location = New System.Drawing.Point(204, 207)
        Me.btnclosewindow.Name = "btnclosewindow"
        Me.btnclosewindow.Size = New System.Drawing.Size(81, 13)
        Me.btnclosewindow.TabIndex = 3
        Me.btnclosewindow.Text = "Dismiss Alert"
        '
        'btnRemind
        '
        Me.btnRemind.AutoSize = True
        Me.btnRemind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemind.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemind.ForeColor = System.Drawing.Color.DarkGray
        Me.btnRemind.Location = New System.Drawing.Point(12, 207)
        Me.btnRemind.Name = "btnRemind"
        Me.btnRemind.Size = New System.Drawing.Size(144, 13)
        Me.btnRemind.TabIndex = 250
        Me.btnRemind.Text = "Remind me in 5 Minutes"
        '
        'lblUID
        '
        Me.lblUID.AutoSize = True
        Me.lblUID.Location = New System.Drawing.Point(258, 11)
        Me.lblUID.Name = "lblUID"
        Me.lblUID.Size = New System.Drawing.Size(11, 13)
        Me.lblUID.TabIndex = 251
        Me.lblUID.Text = " "
        Me.lblUID.Visible = False
        '
        'lblnotes
        '
        Me.lblnotes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblnotes.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnotes.Location = New System.Drawing.Point(17, 146)
        Me.lblnotes.Name = "lblnotes"
        Me.lblnotes.Size = New System.Drawing.Size(279, 49)
        Me.lblnotes.TabIndex = 252
        Me.lblnotes.Text = ""
        '
        'pctOff1
        '
        Me.pctOff1.ErrorImage = Nothing
        Me.pctOff1.Image = CType(resources.GetObject("pctOff1.Image"), System.Drawing.Image)
        Me.pctOff1.InitialImage = Nothing
        Me.pctOff1.Location = New System.Drawing.Point(77, 11)
        Me.pctOff1.Name = "pctOff1"
        Me.pctOff1.Size = New System.Drawing.Size(19, 16)
        Me.pctOff1.TabIndex = 253
        Me.pctOff1.TabStop = False
        '
        'pctOn1
        '
        Me.pctOn1.ErrorImage = Nothing
        Me.pctOn1.Image = CType(resources.GetObject("pctOn1.Image"), System.Drawing.Image)
        Me.pctOn1.InitialImage = Nothing
        Me.pctOn1.Location = New System.Drawing.Point(77, 11)
        Me.pctOn1.Name = "pctOn1"
        Me.pctOn1.Size = New System.Drawing.Size(19, 16)
        Me.pctOn1.TabIndex = 254
        Me.pctOn1.TabStop = False
        Me.pctOn1.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 200
        '
        'pctOff2
        '
        Me.pctOff2.ErrorImage = Nothing
        Me.pctOff2.Image = CType(resources.GetObject("pctOff2.Image"), System.Drawing.Image)
        Me.pctOff2.InitialImage = Nothing
        Me.pctOff2.Location = New System.Drawing.Point(103, 11)
        Me.pctOff2.Name = "pctOff2"
        Me.pctOff2.Size = New System.Drawing.Size(19, 16)
        Me.pctOff2.TabIndex = 255
        Me.pctOff2.TabStop = False
        '
        'pctOff3
        '
        Me.pctOff3.ErrorImage = Nothing
        Me.pctOff3.Image = CType(resources.GetObject("pctOff3.Image"), System.Drawing.Image)
        Me.pctOff3.InitialImage = Nothing
        Me.pctOff3.Location = New System.Drawing.Point(128, 11)
        Me.pctOff3.Name = "pctOff3"
        Me.pctOff3.Size = New System.Drawing.Size(19, 16)
        Me.pctOff3.TabIndex = 256
        Me.pctOff3.TabStop = False
        '
        'pctOff4
        '
        Me.pctOff4.ErrorImage = Nothing
        Me.pctOff4.Image = CType(resources.GetObject("pctOff4.Image"), System.Drawing.Image)
        Me.pctOff4.InitialImage = Nothing
        Me.pctOff4.Location = New System.Drawing.Point(154, 11)
        Me.pctOff4.Name = "pctOff4"
        Me.pctOff4.Size = New System.Drawing.Size(19, 16)
        Me.pctOff4.TabIndex = 257
        Me.pctOff4.TabStop = False
        '
        'pctOff5
        '
        Me.pctOff5.ErrorImage = Nothing
        Me.pctOff5.Image = CType(resources.GetObject("pctOff5.Image"), System.Drawing.Image)
        Me.pctOff5.InitialImage = Nothing
        Me.pctOff5.Location = New System.Drawing.Point(180, 11)
        Me.pctOff5.Name = "pctOff5"
        Me.pctOff5.Size = New System.Drawing.Size(19, 16)
        Me.pctOff5.TabIndex = 258
        Me.pctOff5.TabStop = False
        '
        'pctOff6
        '
        Me.pctOff6.ErrorImage = Nothing
        Me.pctOff6.Image = CType(resources.GetObject("pctOff6.Image"), System.Drawing.Image)
        Me.pctOff6.InitialImage = Nothing
        Me.pctOff6.Location = New System.Drawing.Point(205, 11)
        Me.pctOff6.Name = "pctOff6"
        Me.pctOff6.Size = New System.Drawing.Size(19, 16)
        Me.pctOff6.TabIndex = 259
        Me.pctOff6.TabStop = False
        '
        'pctOff7
        '
        Me.pctOff7.ErrorImage = Nothing
        Me.pctOff7.Image = CType(resources.GetObject("pctOff7.Image"), System.Drawing.Image)
        Me.pctOff7.InitialImage = Nothing
        Me.pctOff7.Location = New System.Drawing.Point(231, 11)
        Me.pctOff7.Name = "pctOff7"
        Me.pctOff7.Size = New System.Drawing.Size(19, 16)
        Me.pctOff7.TabIndex = 260
        Me.pctOff7.TabStop = False
        '
        'pctOff8
        '
        Me.pctOff8.ErrorImage = Nothing
        Me.pctOff8.Image = CType(resources.GetObject("pctOff8.Image"), System.Drawing.Image)
        Me.pctOff8.InitialImage = Nothing
        Me.pctOff8.Location = New System.Drawing.Point(257, 11)
        Me.pctOff8.Name = "pctOff8"
        Me.pctOff8.Size = New System.Drawing.Size(19, 16)
        Me.pctOff8.TabIndex = 261
        Me.pctOff8.TabStop = False
        '
        'pctOn2
        '
        Me.pctOn2.ErrorImage = Nothing
        Me.pctOn2.Image = CType(resources.GetObject("pctOn2.Image"), System.Drawing.Image)
        Me.pctOn2.InitialImage = Nothing
        Me.pctOn2.Location = New System.Drawing.Point(103, 11)
        Me.pctOn2.Name = "pctOn2"
        Me.pctOn2.Size = New System.Drawing.Size(19, 16)
        Me.pctOn2.TabIndex = 262
        Me.pctOn2.TabStop = False
        Me.pctOn2.Visible = False
        '
        'pctOn3
        '
        Me.pctOn3.ErrorImage = Nothing
        Me.pctOn3.Image = CType(resources.GetObject("pctOn3.Image"), System.Drawing.Image)
        Me.pctOn3.InitialImage = Nothing
        Me.pctOn3.Location = New System.Drawing.Point(128, 11)
        Me.pctOn3.Name = "pctOn3"
        Me.pctOn3.Size = New System.Drawing.Size(19, 16)
        Me.pctOn3.TabIndex = 263
        Me.pctOn3.TabStop = False
        Me.pctOn3.Visible = False
        '
        'pctOn4
        '
        Me.pctOn4.ErrorImage = Nothing
        Me.pctOn4.Image = CType(resources.GetObject("pctOn4.Image"), System.Drawing.Image)
        Me.pctOn4.InitialImage = Nothing
        Me.pctOn4.Location = New System.Drawing.Point(154, 11)
        Me.pctOn4.Name = "pctOn4"
        Me.pctOn4.Size = New System.Drawing.Size(19, 16)
        Me.pctOn4.TabIndex = 264
        Me.pctOn4.TabStop = False
        Me.pctOn4.Visible = False
        '
        'pctOn5
        '
        Me.pctOn5.ErrorImage = Nothing
        Me.pctOn5.Image = CType(resources.GetObject("pctOn5.Image"), System.Drawing.Image)
        Me.pctOn5.InitialImage = Nothing
        Me.pctOn5.Location = New System.Drawing.Point(180, 11)
        Me.pctOn5.Name = "pctOn5"
        Me.pctOn5.Size = New System.Drawing.Size(19, 16)
        Me.pctOn5.TabIndex = 265
        Me.pctOn5.TabStop = False
        Me.pctOn5.Visible = False
        '
        'pctOn6
        '
        Me.pctOn6.ErrorImage = Nothing
        Me.pctOn6.Image = CType(resources.GetObject("pctOn6.Image"), System.Drawing.Image)
        Me.pctOn6.InitialImage = Nothing
        Me.pctOn6.Location = New System.Drawing.Point(205, 11)
        Me.pctOn6.Name = "pctOn6"
        Me.pctOn6.Size = New System.Drawing.Size(19, 16)
        Me.pctOn6.TabIndex = 266
        Me.pctOn6.TabStop = False
        Me.pctOn6.Visible = False
        '
        'pctOn7
        '
        Me.pctOn7.ErrorImage = Nothing
        Me.pctOn7.Image = CType(resources.GetObject("pctOn7.Image"), System.Drawing.Image)
        Me.pctOn7.InitialImage = Nothing
        Me.pctOn7.Location = New System.Drawing.Point(231, 11)
        Me.pctOn7.Name = "pctOn7"
        Me.pctOn7.Size = New System.Drawing.Size(19, 16)
        Me.pctOn7.TabIndex = 267
        Me.pctOn7.TabStop = False
        Me.pctOn7.Visible = False
        '
        'pctOn8
        '
        Me.pctOn8.ErrorImage = Nothing
        Me.pctOn8.Image = CType(resources.GetObject("pctOn8.Image"), System.Drawing.Image)
        Me.pctOn8.InitialImage = Nothing
        Me.pctOn8.Location = New System.Drawing.Point(257, 11)
        Me.pctOn8.Name = "pctOn8"
        Me.pctOn8.Size = New System.Drawing.Size(19, 16)
        Me.pctOn8.TabIndex = 268
        Me.pctOn8.TabStop = False
        Me.pctOn8.Visible = False
        '
        'AlertNotify
        '
        Me.AcceptButton = Me.lnkID
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(310, 236)
        Me.ControlBox = False
        Me.Controls.Add(Me.pctOn8)
        Me.Controls.Add(Me.pctOn7)
        Me.Controls.Add(Me.pctOn6)
        Me.Controls.Add(Me.pctOn5)
        Me.Controls.Add(Me.pctOn4)
        Me.Controls.Add(Me.pctOn3)
        Me.Controls.Add(Me.pctOn2)
        Me.Controls.Add(Me.pctOff8)
        Me.Controls.Add(Me.pctOff7)
        Me.Controls.Add(Me.pctOff6)
        Me.Controls.Add(Me.pctOff5)
        Me.Controls.Add(Me.pctOff4)
        Me.Controls.Add(Me.pctOff3)
        Me.Controls.Add(Me.pctOff2)
        Me.Controls.Add(Me.pctOn1)
        Me.Controls.Add(Me.pctOff1)
        Me.Controls.Add(Me.lblUID)
        Me.Controls.Add(Me.btnRemind)
        Me.Controls.Add(Me.btnclosewindow)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblCustomerNFO)
        Me.Controls.Add(Me.lnkID)
        Me.Controls.Add(Me.lblnotes)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(312, 250)
        Me.MinimizeBox = False
        Me.Name = "AlertNotify"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.TopMost = True
        CType(Me.pctOff1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctOn1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctOff2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctOff3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctOff4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctOff5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctOff6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctOff7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctOff8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctOn2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctOn3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctOn4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctOn5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctOn6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctOn7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctOn8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lnkID As System.Windows.Forms.LinkLabel
    Friend WithEvents lblCustomerNFO As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents btnclosewindow As System.Windows.Forms.Label
    Friend WithEvents btnRemind As System.Windows.Forms.Label
    Friend WithEvents lblUID As System.Windows.Forms.Label
    Friend WithEvents lblnotes As System.Windows.Forms.RichTextBox
    Friend WithEvents pctOff1 As System.Windows.Forms.PictureBox
    Friend WithEvents pctOn1 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents pctOff2 As System.Windows.Forms.PictureBox
    Friend WithEvents pctOff3 As System.Windows.Forms.PictureBox
    Friend WithEvents pctOff4 As System.Windows.Forms.PictureBox
    Friend WithEvents pctOff5 As System.Windows.Forms.PictureBox
    Friend WithEvents pctOff6 As System.Windows.Forms.PictureBox
    Friend WithEvents pctOff7 As System.Windows.Forms.PictureBox
    Friend WithEvents pctOff8 As System.Windows.Forms.PictureBox
    Friend WithEvents pctOn2 As System.Windows.Forms.PictureBox
    Friend WithEvents pctOn3 As System.Windows.Forms.PictureBox
    Friend WithEvents pctOn4 As System.Windows.Forms.PictureBox
    Friend WithEvents pctOn5 As System.Windows.Forms.PictureBox
    Friend WithEvents pctOn6 As System.Windows.Forms.PictureBox
    Friend WithEvents pctOn7 As System.Windows.Forms.PictureBox
    Friend WithEvents pctOn8 As System.Windows.Forms.PictureBox
End Class
