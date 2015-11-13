<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reissue
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reissue))
        Me.lblautonotes = New System.Windows.Forms.Label()
        Me.cboautonotes = New System.Windows.Forms.ComboBox()
        Me.lblsalesnotes = New System.Windows.Forms.Label()
        Me.rtfAutoNote = New System.Windows.Forms.RichTextBox()
        Me.Label141 = New System.Windows.Forms.Label()
        Me.Label140 = New System.Windows.Forms.Label()
        Me.cboSalesResults = New System.Windows.Forms.ComboBox()
        Me.cboRep2 = New System.Windows.Forms.ComboBox()
        Me.Label139 = New System.Windows.Forms.Label()
        Me.cboRep1 = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dtpapptdate = New System.Windows.Forms.DateTimePicker()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.dtpappttime = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboSpokeWith = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblautonotes
        '
        Me.lblautonotes.BackColor = System.Drawing.Color.White
        Me.lblautonotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblautonotes.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblautonotes.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblautonotes.ForeColor = System.Drawing.Color.Gray
        Me.lblautonotes.Location = New System.Drawing.Point(11, 93)
        Me.lblautonotes.Name = "lblautonotes"
        Me.lblautonotes.Size = New System.Drawing.Size(215, 21)
        Me.lblautonotes.TabIndex = 511
        Me.lblautonotes.Text = "select auto note here"
        Me.lblautonotes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboautonotes
        '
        Me.cboautonotes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboautonotes.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboautonotes.FormattingEnabled = True
        Me.cboautonotes.Items.AddRange(New Object() {"<<ADD NEW>>", "____________________________________", "Nobody Home", "Do it Yourselfer", "No Money", "No Interest"})
        Me.cboautonotes.Location = New System.Drawing.Point(11, 93)
        Me.cboautonotes.Name = "cboautonotes"
        Me.cboautonotes.Size = New System.Drawing.Size(238, 21)
        Me.cboautonotes.TabIndex = 4
        '
        'lblsalesnotes
        '
        Me.lblsalesnotes.AutoSize = True
        Me.lblsalesnotes.BackColor = System.Drawing.Color.White
        Me.lblsalesnotes.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblsalesnotes.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsalesnotes.ForeColor = System.Drawing.Color.Gray
        Me.lblsalesnotes.Location = New System.Drawing.Point(34, 145)
        Me.lblsalesnotes.Name = "lblsalesnotes"
        Me.lblsalesnotes.Size = New System.Drawing.Size(180, 13)
        Me.lblsalesnotes.TabIndex = 509
        Me.lblsalesnotes.Text = "Enter notes to log w/ this sale result"
        '
        'rtfAutoNote
        '
        Me.rtfAutoNote.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rtfAutoNote.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtfAutoNote.Location = New System.Drawing.Point(11, 120)
        Me.rtfAutoNote.Name = "rtfAutoNote"
        Me.rtfAutoNote.Size = New System.Drawing.Size(238, 66)
        Me.rtfAutoNote.TabIndex = 5
        Me.rtfAutoNote.Text = ""
        '
        'Label141
        '
        Me.Label141.AutoSize = True
        Me.Label141.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label141.ForeColor = System.Drawing.Color.Black
        Me.Label141.Location = New System.Drawing.Point(14, 15)
        Me.Label141.Name = "Label141"
        Me.Label141.Size = New System.Drawing.Size(41, 13)
        Me.Label141.TabIndex = 503
        Me.Label141.Text = "Rep1:"
        '
        'Label140
        '
        Me.Label140.AutoSize = True
        Me.Label140.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label140.ForeColor = System.Drawing.Color.Black
        Me.Label140.Location = New System.Drawing.Point(14, 42)
        Me.Label140.Name = "Label140"
        Me.Label140.Size = New System.Drawing.Size(41, 13)
        Me.Label140.TabIndex = 504
        Me.Label140.Text = "Rep2:"
        '
        'cboSalesResults
        '
        Me.cboSalesResults.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSalesResults.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSalesResults.BackColor = System.Drawing.SystemColors.Window
        Me.cboSalesResults.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSalesResults.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSalesResults.FormattingEnabled = True
        Me.cboSalesResults.Location = New System.Drawing.Point(59, 66)
        Me.cboSalesResults.Name = "cboSalesResults"
        Me.cboSalesResults.Size = New System.Drawing.Size(190, 21)
        Me.cboSalesResults.TabIndex = 3
        '
        'cboRep2
        '
        Me.cboRep2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboRep2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboRep2.BackColor = System.Drawing.SystemColors.Window
        Me.cboRep2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRep2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRep2.FormattingEnabled = True
        Me.cboRep2.Location = New System.Drawing.Point(59, 39)
        Me.cboRep2.Name = "cboRep2"
        Me.cboRep2.Size = New System.Drawing.Size(190, 21)
        Me.cboRep2.TabIndex = 2
        '
        'Label139
        '
        Me.Label139.AutoSize = True
        Me.Label139.BackColor = System.Drawing.Color.Transparent
        Me.Label139.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label139.ForeColor = System.Drawing.Color.Black
        Me.Label139.Location = New System.Drawing.Point(14, 69)
        Me.Label139.Name = "Label139"
        Me.Label139.Size = New System.Drawing.Size(47, 13)
        Me.Label139.TabIndex = 505
        Me.Label139.Text = "Result:"
        '
        'cboRep1
        '
        Me.cboRep1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboRep1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboRep1.BackColor = System.Drawing.SystemColors.Window
        Me.cboRep1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRep1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRep1.FormattingEnabled = True
        Me.cboRep1.Location = New System.Drawing.Point(59, 12)
        Me.cboRep1.Name = "cboRep1"
        Me.cboRep1.Size = New System.Drawing.Size(190, 21)
        Me.cboRep1.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(145, 364)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(81, 24)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(43, 364)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 24)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dtpapptdate
        '
        Me.dtpapptdate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpapptdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpapptdate.Location = New System.Drawing.Point(110, 22)
        Me.dtpapptdate.Name = "dtpapptdate"
        Me.dtpapptdate.Size = New System.Drawing.Size(113, 23)
        Me.dtpapptdate.TabIndex = 6
        Me.dtpapptdate.Value = New Date(2008, 3, 21, 0, 0, 0, 0)
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(17, 61)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(45, 16)
        Me.Label22.TabIndex = 19
        Me.Label22.Text = "Time:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(17, 25)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(45, 16)
        Me.Label23.TabIndex = 3
        Me.Label23.Text = "Date:"
        '
        'dtpappttime
        '
        Me.dtpappttime.CustomFormat = "hh:ss tt"
        Me.dtpappttime.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpappttime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpappttime.Location = New System.Drawing.Point(110, 58)
        Me.dtpappttime.Name = "dtpappttime"
        Me.dtpappttime.ShowUpDown = True
        Me.dtpappttime.Size = New System.Drawing.Size(113, 23)
        Me.dtpappttime.TabIndex = 7
        Me.dtpappttime.Value = New Date(2008, 3, 17, 11, 0, 0, 0)
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.cboSpokeWith)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpapptdate)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.dtpappttime)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(11, 221)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(238, 137)
        Me.GroupBox1.TabIndex = 519
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reschedule Appt. for"
        '
        'cboSpokeWith
        '
        Me.cboSpokeWith.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSpokeWith.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSpokeWith.BackColor = System.Drawing.SystemColors.Window
        Me.cboSpokeWith.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSpokeWith.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSpokeWith.FormattingEnabled = True
        Me.cboSpokeWith.Location = New System.Drawing.Point(110, 94)
        Me.cboSpokeWith.Name = "cboSpokeWith"
        Me.cboSpokeWith.Size = New System.Drawing.Size(113, 21)
        Me.cboSpokeWith.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(17, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 16)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Spoke With:"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider1.ContainerControl = Me
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(48, 195)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(175, 20)
        Me.CheckBox1.TabIndex = 520
        Me.CheckBox1.Text = "Reschedule Appt. Now"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Reissue
        '
        Me.AcceptButton = Me.Button2
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.Button1
        Me.ClientSize = New System.Drawing.Size(268, 415)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblautonotes)
        Me.Controls.Add(Me.cboautonotes)
        Me.Controls.Add(Me.lblsalesnotes)
        Me.Controls.Add(Me.rtfAutoNote)
        Me.Controls.Add(Me.Label141)
        Me.Controls.Add(Me.Label140)
        Me.Controls.Add(Me.cboSalesResults)
        Me.Controls.Add(Me.cboRep2)
        Me.Controls.Add(Me.Label139)
        Me.Controls.Add(Me.cboRep1)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Reissue"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Sales Result"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblautonotes As System.Windows.Forms.Label
    Friend WithEvents cboautonotes As System.Windows.Forms.ComboBox
    Friend WithEvents lblsalesnotes As System.Windows.Forms.Label
    Friend WithEvents rtfAutoNote As System.Windows.Forms.RichTextBox
    Friend WithEvents Label141 As System.Windows.Forms.Label
    Friend WithEvents Label140 As System.Windows.Forms.Label
    Friend WithEvents cboSalesResults As System.Windows.Forms.ComboBox
    Friend WithEvents cboRep2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label139 As System.Windows.Forms.Label
    Friend WithEvents cboRep1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dtpapptdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents dtpappttime As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents cboSpokeWith As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
End Class
