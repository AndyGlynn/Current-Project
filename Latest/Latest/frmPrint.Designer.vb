<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrint
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
        Me.wbPrint = New System.Windows.Forms.WebBrowser()
        Me.btnPrintThisOne = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnPrinterOptions = New System.Windows.Forms.Button()
        Me.lsLeadIds = New System.Windows.Forms.ListView()
        Me.colID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLayout = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ttListHints = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'wbPrint
        '
        Me.wbPrint.Location = New System.Drawing.Point(152, 67)
        Me.wbPrint.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbPrint.Name = "wbPrint"
        Me.wbPrint.Size = New System.Drawing.Size(906, 615)
        Me.wbPrint.TabIndex = 0
        '
        'btnPrintThisOne
        '
        Me.btnPrintThisOne.Location = New System.Drawing.Point(939, 688)
        Me.btnPrintThisOne.Name = "btnPrintThisOne"
        Me.btnPrintThisOne.Size = New System.Drawing.Size(119, 23)
        Me.btnPrintThisOne.TabIndex = 2
        Me.btnPrintThisOne.Text = "Print"
        Me.btnPrintThisOne.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(12, 688)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(121, 23)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = " Close"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnPrinterOptions
        '
        Me.btnPrinterOptions.Location = New System.Drawing.Point(685, 688)
        Me.btnPrinterOptions.Name = "btnPrinterOptions"
        Me.btnPrinterOptions.Size = New System.Drawing.Size(121, 23)
        Me.btnPrinterOptions.TabIndex = 4
        Me.btnPrinterOptions.Text = "Show Printer Options"
        Me.btnPrinterOptions.UseVisualStyleBackColor = True
        '
        'lsLeadIds
        '
        Me.lsLeadIds.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colID})
        Me.lsLeadIds.Location = New System.Drawing.Point(12, 67)
        Me.lsLeadIds.Name = "lsLeadIds"
        Me.lsLeadIds.Size = New System.Drawing.Size(121, 586)
        Me.lsLeadIds.TabIndex = 5
        Me.ttListHints.SetToolTip(Me.lsLeadIds, "Hold Down 'Ctrl' Key and Click Lead Numbers to select more then one lead.")
        Me.lsLeadIds.UseCompatibleStateImageBehavior = False
        Me.lsLeadIds.View = System.Windows.Forms.View.Details
        '
        'colID
        '
        Me.colID.Text = "Record ID: "
        Me.colID.Width = 116
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Available Lead For Today :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(149, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Document Review :"
        '
        'btnLayout
        '
        Me.btnLayout.Location = New System.Drawing.Point(812, 688)
        Me.btnLayout.Name = "btnLayout"
        Me.btnLayout.Size = New System.Drawing.Size(121, 23)
        Me.btnLayout.TabIndex = 10
        Me.btnLayout.Text = "Layout Preview"
        Me.btnLayout.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 659)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Print ALL"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1080, 723)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnLayout)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lsLeadIds)
        Me.Controls.Add(Me.btnPrinterOptions)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnPrintThisOne)
        Me.Controls.Add(Me.wbPrint)
        Me.Name = "frmPrint"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Print Leads Options"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents wbPrint As System.Windows.Forms.WebBrowser
    Friend WithEvents btnPrintThisOne As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnPrinterOptions As System.Windows.Forms.Button
    Friend WithEvents lsLeadIds As System.Windows.Forms.ListView
    Friend WithEvents colID As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnLayout As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ttListHints As System.Windows.Forms.ToolTip
End Class
