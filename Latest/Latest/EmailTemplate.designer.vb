<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmailTemplate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmailTemplate))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.btnCustomer = New System.Windows.Forms.ToolStripButton
        Me.btnAddress = New System.Windows.Forms.ToolStripButton
        Me.btnCityState = New System.Windows.Forms.ToolStripButton
        Me.btnZipCode = New System.Windows.Forms.ToolStripButton
        Me.btnMainPhone = New System.Windows.Forms.ToolStripButton
        Me.btnAltPhone1 = New System.Windows.Forms.ToolStripButton
        Me.btnAltPhone2 = New System.Windows.Forms.ToolStripButton
        Me.btnProducts = New System.Windows.Forms.ToolStripButton
        Me.btnSpokeWith = New System.Windows.Forms.ToolStripButton
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
        Me.btnApptDate = New System.Windows.Forms.ToolStripButton
        Me.btnApptTime = New System.Windows.Forms.ToolStripButton
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel
        Me.btnLastMarketer = New System.Windows.Forms.ToolStripButton
        Me.btnConfirmer = New System.Windows.Forms.ToolStripButton
        Me.btnSalesRep = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton
        Me.txtsubject = New System.Windows.Forms.TextBox
        Me.txtEmailBody = New System.Windows.Forms.RichTextBox
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.btnCustomer, Me.btnAddress, Me.btnCityState, Me.btnZipCode, Me.btnMainPhone, Me.btnAltPhone1, Me.btnAltPhone2, Me.btnProducts, Me.btnSpokeWith, Me.ToolStripLabel2, Me.btnApptDate, Me.btnApptTime, Me.ToolStripLabel3, Me.btnLastMarketer, Me.btnConfirmer, Me.btnSalesRep, Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripButton5})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(112, 476)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(109, 13)
        Me.ToolStripLabel1.Text = "Customer Info:"
        '
        'btnCustomer
        '
        Me.btnCustomer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnCustomer.Image = CType(resources.GetObject("btnCustomer.Image"), System.Drawing.Image)
        Me.btnCustomer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(109, 19)
        Me.btnCustomer.Text = "Customer Name(s)"
        '
        'btnAddress
        '
        Me.btnAddress.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnAddress.Image = CType(resources.GetObject("btnAddress.Image"), System.Drawing.Image)
        Me.btnAddress.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAddress.Name = "btnAddress"
        Me.btnAddress.Size = New System.Drawing.Size(109, 19)
        Me.btnAddress.Text = "Address"
        '
        'btnCityState
        '
        Me.btnCityState.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnCityState.Image = CType(resources.GetObject("btnCityState.Image"), System.Drawing.Image)
        Me.btnCityState.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCityState.Name = "btnCityState"
        Me.btnCityState.Size = New System.Drawing.Size(109, 19)
        Me.btnCityState.Text = "City/State"
        '
        'btnZipCode
        '
        Me.btnZipCode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnZipCode.Image = CType(resources.GetObject("btnZipCode.Image"), System.Drawing.Image)
        Me.btnZipCode.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnZipCode.Name = "btnZipCode"
        Me.btnZipCode.Size = New System.Drawing.Size(109, 19)
        Me.btnZipCode.Text = "Zip Code"
        '
        'btnMainPhone
        '
        Me.btnMainPhone.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnMainPhone.Image = CType(resources.GetObject("btnMainPhone.Image"), System.Drawing.Image)
        Me.btnMainPhone.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMainPhone.Name = "btnMainPhone"
        Me.btnMainPhone.Size = New System.Drawing.Size(109, 19)
        Me.btnMainPhone.Text = "Main Phone"
        '
        'btnAltPhone1
        '
        Me.btnAltPhone1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnAltPhone1.Image = CType(resources.GetObject("btnAltPhone1.Image"), System.Drawing.Image)
        Me.btnAltPhone1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAltPhone1.Name = "btnAltPhone1"
        Me.btnAltPhone1.Size = New System.Drawing.Size(109, 19)
        Me.btnAltPhone1.Text = "Alt Phone 1"
        '
        'btnAltPhone2
        '
        Me.btnAltPhone2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnAltPhone2.Image = CType(resources.GetObject("btnAltPhone2.Image"), System.Drawing.Image)
        Me.btnAltPhone2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAltPhone2.Name = "btnAltPhone2"
        Me.btnAltPhone2.Size = New System.Drawing.Size(109, 19)
        Me.btnAltPhone2.Text = "Alt Phone 2"
        '
        'btnProducts
        '
        Me.btnProducts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnProducts.Image = CType(resources.GetObject("btnProducts.Image"), System.Drawing.Image)
        Me.btnProducts.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnProducts.Name = "btnProducts"
        Me.btnProducts.Size = New System.Drawing.Size(109, 19)
        Me.btnProducts.Text = "Product(s)"
        '
        'btnSpokeWith
        '
        Me.btnSpokeWith.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnSpokeWith.Image = CType(resources.GetObject("btnSpokeWith.Image"), System.Drawing.Image)
        Me.btnSpokeWith.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSpokeWith.Name = "btnSpokeWith"
        Me.btnSpokeWith.Size = New System.Drawing.Size(109, 19)
        Me.btnSpokeWith.Text = "Spoke With"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(109, 13)
        Me.ToolStripLabel2.Text = "Appt. Info:"
        '
        'btnApptDate
        '
        Me.btnApptDate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnApptDate.Image = CType(resources.GetObject("btnApptDate.Image"), System.Drawing.Image)
        Me.btnApptDate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnApptDate.Name = "btnApptDate"
        Me.btnApptDate.Size = New System.Drawing.Size(109, 19)
        Me.btnApptDate.Text = "Appt. Date "
        '
        'btnApptTime
        '
        Me.btnApptTime.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnApptTime.Image = CType(resources.GetObject("btnApptTime.Image"), System.Drawing.Image)
        Me.btnApptTime.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnApptTime.Name = "btnApptTime"
        Me.btnApptTime.Size = New System.Drawing.Size(109, 19)
        Me.btnApptTime.Text = "Appt. Time"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(109, 13)
        Me.ToolStripLabel3.Text = "Company Info:"
        '
        'btnLastMarketer
        '
        Me.btnLastMarketer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnLastMarketer.Image = CType(resources.GetObject("btnLastMarketer.Image"), System.Drawing.Image)
        Me.btnLastMarketer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnLastMarketer.Name = "btnLastMarketer"
        Me.btnLastMarketer.Size = New System.Drawing.Size(109, 19)
        Me.btnLastMarketer.Text = "Last Marketer"
        '
        'btnConfirmer
        '
        Me.btnConfirmer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnConfirmer.Image = CType(resources.GetObject("btnConfirmer.Image"), System.Drawing.Image)
        Me.btnConfirmer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnConfirmer.Name = "btnConfirmer"
        Me.btnConfirmer.Size = New System.Drawing.Size(109, 19)
        Me.btnConfirmer.Text = "Confirmer"
        '
        'btnSalesRep
        '
        Me.btnSalesRep.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnSalesRep.Image = CType(resources.GetObject("btnSalesRep.Image"), System.Drawing.Image)
        Me.btnSalesRep.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSalesRep.Name = "btnSalesRep"
        Me.btnSalesRep.Size = New System.Drawing.Size(109, 19)
        Me.btnSalesRep.Text = "Last Sales Rep"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(109, 19)
        Me.ToolStripButton1.Text = "Company Name"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(109, 19)
        Me.ToolStripButton2.Text = "Company Address"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(109, 19)
        Me.ToolStripButton3.Text = "Company Phone"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(109, 19)
        Me.ToolStripButton4.Text = "Company Fax"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(109, 19)
        Me.ToolStripButton5.Text = "Company Website"
        '
        'txtsubject
        '
        Me.txtsubject.Location = New System.Drawing.Point(117, 12)
        Me.txtsubject.Name = "txtsubject"
        Me.txtsubject.Size = New System.Drawing.Size(404, 20)
        Me.txtsubject.TabIndex = 2
        '
        'txtEmailBody
        '
        Me.txtEmailBody.Location = New System.Drawing.Point(117, 39)
        Me.txtEmailBody.Name = "txtEmailBody"
        Me.txtEmailBody.Size = New System.Drawing.Size(404, 394)
        Me.txtEmailBody.TabIndex = 3
        Me.txtEmailBody.Text = ""
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(260, 439)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(109, 26)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(145, 439)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(109, 26)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear Form"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(375, 439)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(109, 26)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save and Close"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(136, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Enter Subject Here"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(257, 203)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Enter Body of Email Here"
        '
        'EmailTemplate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(531, 476)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtEmailBody)
        Me.Controls.Add(Me.txtsubject)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EmailTemplate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Create Email Template"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnCustomer As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAddress As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCityState As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnZipCode As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMainPhone As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAltPhone1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAltPhone2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnApptDate As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnProducts As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnApptTime As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnLastMarketer As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnConfirmer As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSalesRep As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtsubject As System.Windows.Forms.TextBox
    Friend WithEvents txtEmailBody As System.Windows.Forms.RichTextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSpokeWith As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
End Class
