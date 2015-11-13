<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImportBulkData
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
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblMessage = New System.Windows.Forms.ToolStripStatusLabel()
        Me.chkDisplayReport = New System.Windows.Forms.CheckBox()
        Me.btnOFD = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDirectory = New System.Windows.Forms.TextBox()
        Me.chkAllFiles = New System.Windows.Forms.CheckBox()
        Me.chkAutoInsert = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboFiles = New System.Windows.Forms.ComboBox()
        Me.lblCnt = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lstScrubbed = New System.Windows.Forms.ListView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.rtfPreview = New System.Windows.Forms.RichTextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblCntFiles = New System.Windows.Forms.Label()
        Me.lblTableTotal = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tblCurCnt = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblProcTable = New System.Windows.Forms.Label()
        Me.lblTable = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.pbMemory = New System.Windows.Forms.ProgressBar()
        Me.lblTotalRecordNums = New System.Windows.Forms.Label()
        Me.lblCurrentRecordNum = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.pbRows = New System.Windows.Forms.ProgressBar()
        Me.lblOperation = New System.Windows.Forms.Label()
        Me.chkAutoScrubAddress = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lblMessage})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 535)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(502, 22)
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(69, 17)
        Me.ToolStripStatusLabel1.Text = "Message(s):"
        '
        'lblMessage
        '
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(10, 17)
        Me.lblMessage.Text = " "
        '
        'chkDisplayReport
        '
        Me.chkDisplayReport.AutoSize = True
        Me.chkDisplayReport.Location = New System.Drawing.Point(12, 397)
        Me.chkDisplayReport.Name = "chkDisplayReport"
        Me.chkDisplayReport.Size = New System.Drawing.Size(247, 17)
        Me.chkDisplayReport.TabIndex = 8
        Me.chkDisplayReport.Text = "Display Report When Operation(s) are Finished"
        Me.chkDisplayReport.UseVisualStyleBackColor = True
        '
        'btnOFD
        '
        Me.btnOFD.Location = New System.Drawing.Point(111, 18)
        Me.btnOFD.Name = "btnOFD"
        Me.btnOFD.Size = New System.Drawing.Size(29, 23)
        Me.btnOFD.TabIndex = 9
        Me.btnOFD.Text = "..."
        Me.btnOFD.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = " Directory For Files"
        '
        'txtDirectory
        '
        Me.txtDirectory.Location = New System.Drawing.Point(146, 20)
        Me.txtDirectory.Name = "txtDirectory"
        Me.txtDirectory.Size = New System.Drawing.Size(352, 20)
        Me.txtDirectory.TabIndex = 11
        '
        'chkAllFiles
        '
        Me.chkAllFiles.AutoSize = True
        Me.chkAllFiles.Location = New System.Drawing.Point(15, 51)
        Me.chkAllFiles.Name = "chkAllFiles"
        Me.chkAllFiles.Size = New System.Drawing.Size(101, 17)
        Me.chkAllFiles.TabIndex = 12
        Me.chkAllFiles.Text = "Process all Files"
        Me.chkAllFiles.UseVisualStyleBackColor = True
        '
        'chkAutoInsert
        '
        Me.chkAutoInsert.AutoSize = True
        Me.chkAutoInsert.Location = New System.Drawing.Point(113, 51)
        Me.chkAutoInsert.Name = "chkAutoInsert"
        Me.chkAutoInsert.Size = New System.Drawing.Size(103, 17)
        Me.chkAutoInsert.TabIndex = 13
        Me.chkAutoInsert.Text = "Auto Insert Data"
        Me.chkAutoInsert.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Select File :"
        '
        'cboFiles
        '
        Me.cboFiles.FormattingEnabled = True
        Me.cboFiles.Location = New System.Drawing.Point(146, 80)
        Me.cboFiles.Name = "cboFiles"
        Me.cboFiles.Size = New System.Drawing.Size(344, 21)
        Me.cboFiles.TabIndex = 14
        '
        'lblCnt
        '
        Me.lblCnt.AutoSize = True
        Me.lblCnt.Location = New System.Drawing.Point(448, 110)
        Me.lblCnt.Name = "lblCnt"
        Me.lblCnt.Size = New System.Drawing.Size(10, 13)
        Me.lblCnt.TabIndex = 21
        Me.lblCnt.Text = " "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(368, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Record Count :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 246)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(163, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Pieced Out ( Preview 4 'Items' ) : "
        '
        'lstScrubbed
        '
        Me.lstScrubbed.Enabled = False
        Me.lstScrubbed.Location = New System.Drawing.Point(12, 274)
        Me.lstScrubbed.Name = "lstScrubbed"
        Me.lstScrubbed.Size = New System.Drawing.Size(478, 107)
        Me.lstScrubbed.TabIndex = 18
        Me.lstScrubbed.UseCompatibleStateImageBehavior = False
        Me.lstScrubbed.View = System.Windows.Forms.View.Details
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 110)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(164, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "File Contents ( Preview 4 Lines ) :"
        '
        'rtfPreview
        '
        Me.rtfPreview.Location = New System.Drawing.Point(12, 126)
        Me.rtfPreview.Name = "rtfPreview"
        Me.rtfPreview.ReadOnly = True
        Me.rtfPreview.Size = New System.Drawing.Size(478, 117)
        Me.rtfPreview.TabIndex = 16
        Me.rtfPreview.Text = ""
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(359, 510)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(131, 23)
        Me.btnOK.TabIndex = 22
        Me.btnOK.Text = "Close"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(405, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Count Of Files :"
        Me.Label9.Visible = False
        '
        'lblCntFiles
        '
        Me.lblCntFiles.AutoSize = True
        Me.lblCntFiles.Location = New System.Drawing.Point(474, 52)
        Me.lblCntFiles.Name = "lblCntFiles"
        Me.lblCntFiles.Size = New System.Drawing.Size(10, 13)
        Me.lblCntFiles.TabIndex = 24
        Me.lblCntFiles.Text = " "
        Me.lblCntFiles.Visible = False
        '
        'lblTableTotal
        '
        Me.lblTableTotal.AutoSize = True
        Me.lblTableTotal.Location = New System.Drawing.Point(286, 486)
        Me.lblTableTotal.Name = "lblTableTotal"
        Me.lblTableTotal.Size = New System.Drawing.Size(10, 13)
        Me.lblTableTotal.TabIndex = 50
        Me.lblTableTotal.Text = " "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(258, 486)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(18, 13)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "Of"
        '
        'tblCurCnt
        '
        Me.tblCurCnt.AutoSize = True
        Me.tblCurCnt.Location = New System.Drawing.Point(234, 485)
        Me.tblCurCnt.Name = "tblCurCnt"
        Me.tblCurCnt.Size = New System.Drawing.Size(10, 13)
        Me.tblCurCnt.TabIndex = 48
        Me.tblCurCnt.Text = " "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(185, 485)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Table : "
        '
        'lblProcTable
        '
        Me.lblProcTable.AutoSize = True
        Me.lblProcTable.Location = New System.Drawing.Point(14, 510)
        Me.lblProcTable.Name = "lblProcTable"
        Me.lblProcTable.Size = New System.Drawing.Size(10, 13)
        Me.lblProcTable.TabIndex = 46
        Me.lblProcTable.Text = " "
        '
        'lblTable
        '
        Me.lblTable.AutoSize = True
        Me.lblTable.Location = New System.Drawing.Point(32, 483)
        Me.lblTable.Name = "lblTable"
        Me.lblTable.Size = New System.Drawing.Size(77, 13)
        Me.lblTable.TabIndex = 45
        Me.lblTable.Text = "Current Table :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(10, 425)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(129, 13)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "Adding Table To Memory:"
        '
        'pbMemory
        '
        Me.pbMemory.Location = New System.Drawing.Point(146, 420)
        Me.pbMemory.MarqueeAnimationSpeed = 1000
        Me.pbMemory.Name = "pbMemory"
        Me.pbMemory.Size = New System.Drawing.Size(344, 23)
        Me.pbMemory.Step = 1
        Me.pbMemory.TabIndex = 43
        '
        'lblTotalRecordNums
        '
        Me.lblTotalRecordNums.AutoSize = True
        Me.lblTotalRecordNums.Location = New System.Drawing.Point(455, 486)
        Me.lblTotalRecordNums.Name = "lblTotalRecordNums"
        Me.lblTotalRecordNums.Size = New System.Drawing.Size(10, 13)
        Me.lblTotalRecordNums.TabIndex = 42
        Me.lblTotalRecordNums.Text = " "
        '
        'lblCurrentRecordNum
        '
        Me.lblCurrentRecordNum.AutoSize = True
        Me.lblCurrentRecordNum.Location = New System.Drawing.Point(391, 486)
        Me.lblCurrentRecordNum.Name = "lblCurrentRecordNum"
        Me.lblCurrentRecordNum.Size = New System.Drawing.Size(10, 13)
        Me.lblCurrentRecordNum.TabIndex = 41
        Me.lblCurrentRecordNum.Text = " "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(436, 486)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(21, 13)
        Me.Label13.TabIndex = 40
        Me.Label13.Text = "Of "
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(344, 486)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(51, 13)
        Me.lblStatus.TabIndex = 39
        Me.lblStatus.Text = "Record : "
        '
        'pbRows
        '
        Me.pbRows.Location = New System.Drawing.Point(146, 449)
        Me.pbRows.MarqueeAnimationSpeed = 1000
        Me.pbRows.Name = "pbRows"
        Me.pbRows.Size = New System.Drawing.Size(344, 23)
        Me.pbRows.TabIndex = 38
        '
        'lblOperation
        '
        Me.lblOperation.AutoSize = True
        Me.lblOperation.Location = New System.Drawing.Point(14, 452)
        Me.lblOperation.Name = "lblOperation"
        Me.lblOperation.Size = New System.Drawing.Size(121, 13)
        Me.lblOperation.TabIndex = 37
        Me.lblOperation.Text = "Insert Record Progress :"
        '
        'chkAutoScrubAddress
        '
        Me.chkAutoScrubAddress.AutoSize = True
        Me.chkAutoScrubAddress.Location = New System.Drawing.Point(213, 51)
        Me.chkAutoScrubAddress.Name = "chkAutoScrubAddress"
        Me.chkAutoScrubAddress.Size = New System.Drawing.Size(167, 17)
        Me.chkAutoScrubAddress.TabIndex = 51
        Me.chkAutoScrubAddress.Text = "Auto Scrub Customer Address"
        Me.chkAutoScrubAddress.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(146, 510)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 23)
        Me.Button1.TabIndex = 52
        Me.Button1.Text = "Move Data To ISS"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmImportBulkData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 557)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.chkAutoScrubAddress)
        Me.Controls.Add(Me.lblTableTotal)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.tblCurCnt)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblProcTable)
        Me.Controls.Add(Me.lblTable)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.pbMemory)
        Me.Controls.Add(Me.lblTotalRecordNums)
        Me.Controls.Add(Me.lblCurrentRecordNum)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.pbRows)
        Me.Controls.Add(Me.lblOperation)
        Me.Controls.Add(Me.lblCntFiles)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lblCnt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lstScrubbed)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.rtfPreview)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboFiles)
        Me.Controls.Add(Me.chkAutoInsert)
        Me.Controls.Add(Me.chkAllFiles)
        Me.Controls.Add(Me.txtDirectory)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnOFD)
        Me.Controls.Add(Me.chkDisplayReport)
        Me.Controls.Add(Me.StatusStrip1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmImportBulkData"
        Me.Opacity = 0.0R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import Data"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblMessage As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents chkDisplayReport As System.Windows.Forms.CheckBox
    Friend WithEvents btnOFD As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDirectory As System.Windows.Forms.TextBox
    Friend WithEvents chkAllFiles As System.Windows.Forms.CheckBox
    Friend WithEvents chkAutoInsert As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboFiles As System.Windows.Forms.ComboBox
    Friend WithEvents lblCnt As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lstScrubbed As System.Windows.Forms.ListView
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents rtfPreview As System.Windows.Forms.RichTextBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblCntFiles As System.Windows.Forms.Label
    Friend WithEvents lblTableTotal As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tblCurCnt As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblProcTable As System.Windows.Forms.Label
    Friend WithEvents lblTable As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents pbMemory As System.Windows.Forms.ProgressBar
    Friend WithEvents lblTotalRecordNums As System.Windows.Forms.Label
    Friend WithEvents lblCurrentRecordNum As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents pbRows As System.Windows.Forms.ProgressBar
    Friend WithEvents lblOperation As System.Windows.Forms.Label
    Friend WithEvents chkAutoScrubAddress As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
