<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSMS
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
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.txtLeadNumberLookup = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboPhoneNumbers = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.txtContactCarrier = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboCarrier = New System.Windows.Forms.ComboBox()
        Me.lblChars = New System.Windows.Forms.Label()
        Me.rtfSMS = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(12, 132)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(410, 20)
        Me.txtLocation.TabIndex = 29
        '
        'txtLeadNumberLookup
        '
        Me.txtLeadNumberLookup.Location = New System.Drawing.Point(337, 103)
        Me.txtLeadNumberLookup.Name = "txtLeadNumberLookup"
        Me.txtLeadNumberLookup.Size = New System.Drawing.Size(85, 20)
        Me.txtLeadNumberLookup.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Location For Lead Number (Optional):"
        '
        'cboPhoneNumbers
        '
        Me.cboPhoneNumbers.FormattingEnabled = True
        Me.cboPhoneNumbers.Location = New System.Drawing.Point(12, 29)
        Me.cboPhoneNumbers.Name = "cboPhoneNumbers"
        Me.cboPhoneNumbers.Size = New System.Drawing.Size(181, 21)
        Me.cboPhoneNumbers.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Phone Number(s):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Subject (Optional): "
        '
        'txtSubject
        '
        Me.txtSubject.Location = New System.Drawing.Point(12, 77)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(410, 20)
        Me.txtSubject.TabIndex = 23
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(12, 273)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 22
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(350, 273)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(75, 23)
        Me.btnSend.TabIndex = 21
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'txtContactCarrier
        '
        Me.txtContactCarrier.Location = New System.Drawing.Point(301, 4)
        Me.txtContactCarrier.Name = "txtContactCarrier"
        Me.txtContactCarrier.Size = New System.Drawing.Size(121, 20)
        Me.txtContactCarrier.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(210, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Contacts Carrier:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(210, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Carrier Gateway:"
        '
        'cboCarrier
        '
        Me.cboCarrier.FormattingEnabled = True
        Me.cboCarrier.Location = New System.Drawing.Point(301, 32)
        Me.cboCarrier.Name = "cboCarrier"
        Me.cboCarrier.Size = New System.Drawing.Size(121, 21)
        Me.cboCarrier.TabIndex = 17
        '
        'lblChars
        '
        Me.lblChars.AutoSize = True
        Me.lblChars.Location = New System.Drawing.Point(12, 155)
        Me.lblChars.Name = "lblChars"
        Me.lblChars.Size = New System.Drawing.Size(184, 13)
        Me.lblChars.TabIndex = 16
        Me.lblChars.Text = "Text Message ( 160 Characters Max )"
        '
        'rtfSMS
        '
        Me.rtfSMS.Location = New System.Drawing.Point(12, 171)
        Me.rtfSMS.Name = "rtfSMS"
        Me.rtfSMS.Size = New System.Drawing.Size(413, 96)
        Me.rtfSMS.TabIndex = 15
        Me.rtfSMS.Text = ""
        '
        'frmSMS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 299)
        Me.Controls.Add(Me.txtLocation)
        Me.Controls.Add(Me.txtLeadNumberLookup)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboPhoneNumbers)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSubject)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.txtContactCarrier)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboCarrier)
        Me.Controls.Add(Me.lblChars)
        Me.Controls.Add(Me.rtfSMS)
        Me.Name = "frmSMS"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Send Text Message"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtLocation As System.Windows.Forms.TextBox
    Friend WithEvents txtLeadNumberLookup As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboPhoneNumbers As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSubject As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents txtContactCarrier As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboCarrier As System.Windows.Forms.ComboBox
    Friend WithEvents lblChars As System.Windows.Forms.Label
    Friend WithEvents rtfSMS As System.Windows.Forms.RichTextBox
End Class
