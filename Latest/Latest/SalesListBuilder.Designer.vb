<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesListBuilder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SalesListBuilder))
        Me.chklbResult = New System.Windows.Forms.CheckedListBox
        Me.cboRep = New System.Windows.Forms.ComboBox
        Me.cboProduct = New System.Windows.Forms.ComboBox
        Me.cboCity = New System.Windows.Forms.ComboBox
        Me.lblUncheckAll = New System.Windows.Forms.Label
        Me.lblCheckAll = New System.Windows.Forms.Label
        Me.Label86 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.chkRecovery = New System.Windows.Forms.CheckBox
        Me.cboPLS = New System.Windows.Forms.ComboBox
        Me.cboSLS = New System.Windows.Forms.ComboBox
        Me.btnSearch = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'chklbResult
        '
        Me.chklbResult.CheckOnClick = True
        Me.chklbResult.FormattingEnabled = True
        Me.chklbResult.Items.AddRange(New Object() {"Demo/No Sale", "No Demo", "Reset", "Not Hit", "Not Issued", "Sale", "Recission Cancel", "No Results"})
        Me.chklbResult.Location = New System.Drawing.Point(376, 32)
        Me.chklbResult.Name = "chklbResult"
        Me.chklbResult.Size = New System.Drawing.Size(142, 124)
        Me.chklbResult.TabIndex = 7
        '
        'cboRep
        '
        Me.cboRep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRep.FormattingEnabled = True
        Me.cboRep.Location = New System.Drawing.Point(184, 12)
        Me.cboRep.Name = "cboRep"
        Me.cboRep.Size = New System.Drawing.Size(166, 21)
        Me.cboRep.TabIndex = 1
        '
        'cboProduct
        '
        Me.cboProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProduct.FormattingEnabled = True
        Me.cboProduct.Location = New System.Drawing.Point(184, 39)
        Me.cboProduct.Name = "cboProduct"
        Me.cboProduct.Size = New System.Drawing.Size(166, 21)
        Me.cboProduct.TabIndex = 2
        '
        'cboCity
        '
        Me.cboCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCity.FormattingEnabled = True
        Me.cboCity.Location = New System.Drawing.Point(184, 66)
        Me.cboCity.Name = "cboCity"
        Me.cboCity.Size = New System.Drawing.Size(166, 21)
        Me.cboCity.TabIndex = 3
        '
        'lblUncheckAll
        '
        Me.lblUncheckAll.AutoSize = True
        Me.lblUncheckAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblUncheckAll.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUncheckAll.ForeColor = System.Drawing.Color.Gray
        Me.lblUncheckAll.Location = New System.Drawing.Point(446, 161)
        Me.lblUncheckAll.Name = "lblUncheckAll"
        Me.lblUncheckAll.Size = New System.Drawing.Size(72, 13)
        Me.lblUncheckAll.TabIndex = 9
        Me.lblUncheckAll.Text = "Uncheck All"
        '
        'lblCheckAll
        '
        Me.lblCheckAll.AutoSize = True
        Me.lblCheckAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblCheckAll.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCheckAll.ForeColor = System.Drawing.Color.Gray
        Me.lblCheckAll.Location = New System.Drawing.Point(373, 161)
        Me.lblCheckAll.Name = "lblCheckAll"
        Me.lblCheckAll.Size = New System.Drawing.Size(58, 13)
        Me.lblCheckAll.TabIndex = 8
        Me.lblCheckAll.Text = "Check All"
        '
        'Label86
        '
        Me.Label86.AutoSize = True
        Me.Label86.BackColor = System.Drawing.Color.Transparent
        Me.Label86.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label86.ForeColor = System.Drawing.Color.Black
        Me.Label86.Location = New System.Drawing.Point(12, 13)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(76, 16)
        Me.Label86.TabIndex = 82
        Me.Label86.Text = "Sales Rep:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(400, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 16)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "Sales Result:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 16)
        Me.Label2.TabIndex = 84
        Me.Label2.Text = "City/State:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(12, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 16)
        Me.Label3.TabIndex = 85
        Me.Label3.Text = "Primary Product:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(12, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 16)
        Me.Label4.TabIndex = 86
        Me.Label4.Text = "Primary Lead Source:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(12, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(166, 16)
        Me.Label5.TabIndex = 87
        Me.Label5.Text = "Secondary Lead Source:"
        '
        'chkRecovery
        '
        Me.chkRecovery.AutoSize = True
        Me.chkRecovery.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkRecovery.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRecovery.ForeColor = System.Drawing.Color.Black
        Me.chkRecovery.Location = New System.Drawing.Point(95, 158)
        Me.chkRecovery.Name = "chkRecovery"
        Me.chkRecovery.Size = New System.Drawing.Size(242, 20)
        Me.chkRecovery.TabIndex = 6
        Me.chkRecovery.Text = "Show Recovery Department Only"
        Me.chkRecovery.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkRecovery.UseVisualStyleBackColor = True
        '
        'cboPLS
        '
        Me.cboPLS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPLS.FormattingEnabled = True
        Me.cboPLS.Location = New System.Drawing.Point(184, 93)
        Me.cboPLS.Name = "cboPLS"
        Me.cboPLS.Size = New System.Drawing.Size(166, 21)
        Me.cboPLS.TabIndex = 4
        '
        'cboSLS
        '
        Me.cboSLS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSLS.FormattingEnabled = True
        Me.cboSLS.Location = New System.Drawing.Point(184, 120)
        Me.cboSLS.Name = "cboSLS"
        Me.cboSLS.Size = New System.Drawing.Size(166, 21)
        Me.cboSLS.TabIndex = 5
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.Location = New System.Drawing.Point(336, 187)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(124, 23)
        Me.btnSearch.TabIndex = 12
        Me.btnSearch.Text = "Create List"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnClear.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.Location = New System.Drawing.Point(206, 187)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(124, 23)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "Clear Criteria"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(76, 187)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SalesListBuilder
        '
        Me.AcceptButton = Me.btnSearch
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 222)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.cboSLS)
        Me.Controls.Add(Me.cboPLS)
        Me.Controls.Add(Me.chkRecovery)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label86)
        Me.Controls.Add(Me.lblUncheckAll)
        Me.Controls.Add(Me.lblCheckAll)
        Me.Controls.Add(Me.cboCity)
        Me.Controls.Add(Me.cboProduct)
        Me.Controls.Add(Me.cboRep)
        Me.Controls.Add(Me.chklbResult)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SalesListBuilder"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Build Custom Sales List..."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chklbResult As System.Windows.Forms.CheckedListBox
    Friend WithEvents cboRep As System.Windows.Forms.ComboBox
    Friend WithEvents cboProduct As System.Windows.Forms.ComboBox
    Friend WithEvents cboCity As System.Windows.Forms.ComboBox
    Friend WithEvents lblUncheckAll As System.Windows.Forms.Label
    Friend WithEvents lblCheckAll As System.Windows.Forms.Label
    Friend WithEvents Label86 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chkRecovery As System.Windows.Forms.CheckBox
    Friend WithEvents cboPLS As System.Windows.Forms.ComboBox
    Friend WithEvents cboSLS As System.Windows.Forms.ComboBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
