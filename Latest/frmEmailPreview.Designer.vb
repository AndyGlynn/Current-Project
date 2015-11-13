<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmailPreview
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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSendEmail = New System.Windows.Forms.Button()
        Me.rtfPreview = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblLeadNum = New System.Windows.Forms.Label()
        Me.cboTemplates = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblAppliedTemplate = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblSubject = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(12, 494)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(83, 23)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSendEmail
        '
        Me.btnSendEmail.Location = New System.Drawing.Point(572, 494)
        Me.btnSendEmail.Name = "btnSendEmail"
        Me.btnSendEmail.Size = New System.Drawing.Size(85, 23)
        Me.btnSendEmail.TabIndex = 2
        Me.btnSendEmail.Text = "Send Email"
        Me.btnSendEmail.UseVisualStyleBackColor = True
        '
        'rtfPreview
        '
        Me.rtfPreview.BackColor = System.Drawing.Color.White
        Me.rtfPreview.Location = New System.Drawing.Point(12, 118)
        Me.rtfPreview.Name = "rtfPreview"
        Me.rtfPreview.ReadOnly = True
        Me.rtfPreview.Size = New System.Drawing.Size(645, 370)
        Me.rtfPreview.TabIndex = 3
        Me.rtfPreview.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Email Preview :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Lead Number :"
        '
        'lblLeadNum
        '
        Me.lblLeadNum.AutoSize = True
        Me.lblLeadNum.Location = New System.Drawing.Point(95, 27)
        Me.lblLeadNum.Name = "lblLeadNum"
        Me.lblLeadNum.Size = New System.Drawing.Size(10, 13)
        Me.lblLeadNum.TabIndex = 6
        Me.lblLeadNum.Text = " "
        '
        'cboTemplates
        '
        Me.cboTemplates.FormattingEnabled = True
        Me.cboTemplates.Location = New System.Drawing.Point(339, 23)
        Me.cboTemplates.Name = "cboTemplates"
        Me.cboTemplates.Size = New System.Drawing.Size(318, 21)
        Me.cboTemplates.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(204, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Templates :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(206, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Current Template Applied :"
        '
        'lblAppliedTemplate
        '
        Me.lblAppliedTemplate.AutoSize = True
        Me.lblAppliedTemplate.Location = New System.Drawing.Point(339, 54)
        Me.lblAppliedTemplate.Name = "lblAppliedTemplate"
        Me.lblAppliedTemplate.Size = New System.Drawing.Size(10, 13)
        Me.lblAppliedTemplate.TabIndex = 10
        Me.lblAppliedTemplate.Text = " "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Subject : "
        '
        'lblSubject
        '
        Me.lblSubject.AutoSize = True
        Me.lblSubject.Location = New System.Drawing.Point(66, 99)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(10, 13)
        Me.lblSubject.TabIndex = 12
        Me.lblSubject.Text = " "
        '
        'frmEmailPreview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 525)
        Me.Controls.Add(Me.lblSubject)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblAppliedTemplate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboTemplates)
        Me.Controls.Add(Me.lblLeadNum)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rtfPreview)
        Me.Controls.Add(Me.btnSendEmail)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "frmEmailPreview"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Email Preview"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSendEmail As System.Windows.Forms.Button
    Friend WithEvents rtfPreview As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblLeadNum As System.Windows.Forms.Label
    Friend WithEvents cboTemplates As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblAppliedTemplate As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblSubject As System.Windows.Forms.Label
End Class
