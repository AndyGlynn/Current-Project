<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.btnImport = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.txtDirectory = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTable = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.lblTotalRecordNum = New System.Windows.Forms.Label()
        Me.lblCurrentRecordNum = New System.Windows.Forms.Label()
        Me.lblTblCurCnt = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnImport
        '
        Me.btnImport.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImport.Location = New System.Drawing.Point(336, 164)
        Me.btnImport.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(207, 26)
        Me.btnImport.TabIndex = 0
        Me.btnImport.Text = "Import Data"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(20, 129)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ProgressBar1.Maximum = 24733
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(522, 26)
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.TabIndex = 1
        '
        'txtDirectory
        '
        Me.txtDirectory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDirectory.Location = New System.Drawing.Point(228, 29)
        Me.txtDirectory.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDirectory.Name = "txtDirectory"
        Me.txtDirectory.Size = New System.Drawing.Size(271, 26)
        Me.txtDirectory.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Select Import Directory : "
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(507, 29)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 26)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "..."
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 66)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 20)
        Me.Label2.TabIndex = 6
        '
        'lblTable
        '
        Me.lblTable.AutoSize = True
        Me.lblTable.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTable.Location = New System.Drawing.Point(31, 93)
        Me.lblTable.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTable.Name = "lblTable"
        Me.lblTable.Size = New System.Drawing.Size(422, 20)
        Me.lblTable.TabIndex = 7
        Me.lblTable.Text = "Inserting Record                   of                   on Temp Table      "
        Me.lblTable.Visible = False
        '
        'lblTotalRecordNum
        '
        Me.lblTotalRecordNum.AutoSize = True
        Me.lblTotalRecordNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalRecordNum.Location = New System.Drawing.Point(280, 93)
        Me.lblTotalRecordNum.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalRecordNum.Name = "lblTotalRecordNum"
        Me.lblTotalRecordNum.Size = New System.Drawing.Size(0, 20)
        Me.lblTotalRecordNum.TabIndex = 8
        Me.lblTotalRecordNum.Visible = False
        '
        'lblCurrentRecordNum
        '
        Me.lblCurrentRecordNum.AutoSize = True
        Me.lblCurrentRecordNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentRecordNum.Location = New System.Drawing.Point(181, 93)
        Me.lblCurrentRecordNum.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCurrentRecordNum.Name = "lblCurrentRecordNum"
        Me.lblCurrentRecordNum.Size = New System.Drawing.Size(0, 20)
        Me.lblCurrentRecordNum.TabIndex = 9
        Me.lblCurrentRecordNum.Visible = False
        '
        'lblTblCurCnt
        '
        Me.lblTblCurCnt.AutoSize = True
        Me.lblTblCurCnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTblCurCnt.Location = New System.Drawing.Point(472, 93)
        Me.lblTblCurCnt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTblCurCnt.Name = "lblTblCurCnt"
        Me.lblTblCurCnt.Size = New System.Drawing.Size(0, 20)
        Me.lblTblCurCnt.TabIndex = 10
        Me.lblTblCurCnt.Visible = False
        '
        'Form6
        '
        Me.AcceptButton = Me.btnImport
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 201)
        Me.Controls.Add(Me.lblTable)
        Me.Controls.Add(Me.lblTblCurCnt)
        Me.Controls.Add(Me.lblCurrentRecordNum)
        Me.Controls.Add(Me.lblTotalRecordNum)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDirectory)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnImport)
        Me.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form6"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Import Data"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnImport As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents txtDirectory As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblTable As System.Windows.Forms.Label
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents lblTotalRecordNum As System.Windows.Forms.Label
    Friend WithEvents lblCurrentRecordNum As System.Windows.Forms.Label
    Friend WithEvents lblTblCurCnt As System.Windows.Forms.Label
End Class
