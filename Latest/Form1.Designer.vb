<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.imgLst16 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImgLst32 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImgLst64 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImgLst128 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImgLst256 = New System.Windows.Forms.ImageList(Me.components)
        Me.Button1 = New System.Windows.Forms.Button
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton
        Me.ViewAsSmallPicturesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CreateNewDirectoryHereToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenCurrentLocationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TsCutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DesktopCreateShortcutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VwLargeIcons = New System.Windows.Forms.ToolStripMenuItem
        Me.VwList = New System.Windows.Forms.ToolStripMenuItem
        Me.VsDetails = New System.Windows.Forms.ToolStripMenuItem
        Me.AscendingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DescendingZAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TsRefresh = New System.Windows.Forms.ToolStripMenuItem
        Me.VwSmallIcons = New System.Windows.Forms.ToolStripMenuItem
        Me.TileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeletEFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TsCut = New System.Windows.Forms.ToolStripMenuItem
        Me.TsCopy = New System.Windows.Forms.ToolStripMenuItem
        Me.TsPaste = New System.Windows.Forms.ToolStripMenuItem
        Me.PasteAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.DomainUpDown1 = New System.Windows.Forms.DomainUpDown
        Me.ListView2 = New System.Windows.Forms.ListView
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(144, 230)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(472, 198)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'imgLst16
        '
        Me.imgLst16.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.imgLst16.ImageSize = New System.Drawing.Size(16, 16)
        Me.imgLst16.TransparentColor = System.Drawing.Color.Transparent
        '
        'ImgLst32
        '
        Me.ImgLst32.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImgLst32.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImgLst32.TransparentColor = System.Drawing.Color.Transparent
        '
        'ImgLst64
        '
        Me.ImgLst64.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImgLst64.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImgLst64.TransparentColor = System.Drawing.Color.Transparent
        '
        'ImgLst128
        '
        Me.ImgLst128.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImgLst128.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImgLst128.TransparentColor = System.Drawing.Color.Transparent
        '
        'ImgLst256
        '
        Me.ImgLst256.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImgLst256.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImgLst256.TransparentColor = System.Drawing.Color.Transparent
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(25, 320)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(675, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewAsSmallPicturesToolStripMenuItem, Me.CreateNewDirectoryHereToolStripMenuItem, Me.OpenCurrentLocationToolStripMenuItem, Me.TsCutToolStripMenuItem, Me.DesktopCreateShortcutToolStripMenuItem, Me.VwLargeIcons, Me.VwList, Me.VsDetails, Me.AscendingToolStripMenuItem, Me.DescendingZAToolStripMenuItem, Me.TsRefresh, Me.VwSmallIcons, Me.TileToolStripMenuItem, Me.DeletEFToolStripMenuItem, Me.TsCut, Me.TsCopy, Me.TsPaste, Me.PasteAllToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(29, 22)
        Me.ToolStripDropDownButton1.Text = "ToolStripDropDownButton1"
        '
        'ViewAsSmallPicturesToolStripMenuItem
        '
        Me.ViewAsSmallPicturesToolStripMenuItem.Name = "ViewAsSmallPicturesToolStripMenuItem"
        Me.ViewAsSmallPicturesToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.ViewAsSmallPicturesToolStripMenuItem.Text = "ViewAsSmallPictures"
        '
        'CreateNewDirectoryHereToolStripMenuItem
        '
        Me.CreateNewDirectoryHereToolStripMenuItem.Name = "CreateNewDirectoryHereToolStripMenuItem"
        Me.CreateNewDirectoryHereToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.CreateNewDirectoryHereToolStripMenuItem.Text = "CreateNewDirectoryHere"
        '
        'OpenCurrentLocationToolStripMenuItem
        '
        Me.OpenCurrentLocationToolStripMenuItem.Name = "OpenCurrentLocationToolStripMenuItem"
        Me.OpenCurrentLocationToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.OpenCurrentLocationToolStripMenuItem.Text = "OpenCurrentLocation"
        '
        'TsCutToolStripMenuItem
        '
        Me.TsCutToolStripMenuItem.Name = "TsCutToolStripMenuItem"
        Me.TsCutToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.TsCutToolStripMenuItem.Text = "tsCut"
        '
        'DesktopCreateShortcutToolStripMenuItem
        '
        Me.DesktopCreateShortcutToolStripMenuItem.Name = "DesktopCreateShortcutToolStripMenuItem"
        Me.DesktopCreateShortcutToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.DesktopCreateShortcutToolStripMenuItem.Text = "DesktopCreateShortcut"
        '
        'VwLargeIcons
        '
        Me.VwLargeIcons.Name = "VwLargeIcons"
        Me.VwLargeIcons.Size = New System.Drawing.Size(205, 22)
        Me.VwLargeIcons.Text = "vwLargeIcons"
        '
        'VwList
        '
        Me.VwList.Name = "VwList"
        Me.VwList.Size = New System.Drawing.Size(205, 22)
        Me.VwList.Text = "vwList"
        '
        'VsDetails
        '
        Me.VsDetails.Name = "VsDetails"
        Me.VsDetails.Size = New System.Drawing.Size(205, 22)
        Me.VsDetails.Text = "vsDetails"
        '
        'AscendingToolStripMenuItem
        '
        Me.AscendingToolStripMenuItem.Name = "AscendingToolStripMenuItem"
        Me.AscendingToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.AscendingToolStripMenuItem.Text = "Ascending"
        '
        'DescendingZAToolStripMenuItem
        '
        Me.DescendingZAToolStripMenuItem.Name = "DescendingZAToolStripMenuItem"
        Me.DescendingZAToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.DescendingZAToolStripMenuItem.Text = "DescendingZA"
        '
        'TsRefresh
        '
        Me.TsRefresh.Name = "TsRefresh"
        Me.TsRefresh.Size = New System.Drawing.Size(205, 22)
        Me.TsRefresh.Text = "tsRefresh"
        '
        'VwSmallIcons
        '
        Me.VwSmallIcons.Name = "VwSmallIcons"
        Me.VwSmallIcons.Size = New System.Drawing.Size(205, 22)
        Me.VwSmallIcons.Text = "vwSmallIcons"
        '
        'TileToolStripMenuItem
        '
        Me.TileToolStripMenuItem.Name = "TileToolStripMenuItem"
        Me.TileToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.TileToolStripMenuItem.Text = "Tile"
        '
        'DeletEFToolStripMenuItem
        '
        Me.DeletEFToolStripMenuItem.Name = "DeletEFToolStripMenuItem"
        Me.DeletEFToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.DeletEFToolStripMenuItem.Text = "DeletEF"
        '
        'TsCut
        '
        Me.TsCut.Name = "TsCut"
        Me.TsCut.Size = New System.Drawing.Size(205, 22)
        Me.TsCut.Text = "tsCut"
        '
        'TsCopy
        '
        Me.TsCopy.Name = "TsCopy"
        Me.TsCopy.Size = New System.Drawing.Size(205, 22)
        Me.TsCopy.Text = "tsCopy"
        '
        'TsPaste
        '
        Me.TsPaste.Name = "TsPaste"
        Me.TsPaste.Size = New System.Drawing.Size(205, 22)
        Me.TsPaste.Text = "tsPaste"
        '
        'PasteAllToolStripMenuItem
        '
        Me.PasteAllToolStripMenuItem.Name = "PasteAllToolStripMenuItem"
        Me.PasteAllToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.PasteAllToolStripMenuItem.Text = "PasteAll"
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.SelectedPath = "\\SERVER\Company\ISS\Attached Files\11779"
        '
        'DomainUpDown1
        '
        Me.DomainUpDown1.Location = New System.Drawing.Point(322, 136)
        Me.DomainUpDown1.Name = "DomainUpDown1"
        Me.DomainUpDown1.Size = New System.Drawing.Size(120, 20)
        Me.DomainUpDown1.TabIndex = 3
        Me.DomainUpDown1.Text = "DomainUpDown1"
        '
        'ListView2
        '
        Me.ListView2.Location = New System.Drawing.Point(156, 102)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(121, 97)
        Me.ListView2.TabIndex = 4
        Me.ListView2.UseCompatibleStateImageBehavior = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 470)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.DomainUpDown1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents imgLst16 As System.Windows.Forms.ImageList
    Friend WithEvents ImgLst32 As System.Windows.Forms.ImageList
    Friend WithEvents ImgLst64 As System.Windows.Forms.ImageList
    Friend WithEvents ImgLst128 As System.Windows.Forms.ImageList
    Friend WithEvents ImgLst256 As System.Windows.Forms.ImageList
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ViewAsSmallPicturesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateNewDirectoryHereToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenCurrentLocationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TsCutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DesktopCreateShortcutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VwLargeIcons As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VwList As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VsDetails As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AscendingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DescendingZAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TsRefresh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VwSmallIcons As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeletEFToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TsCut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TsCopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TsPaste As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents DomainUpDown1 As System.Windows.Forms.DomainUpDown
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
End Class
