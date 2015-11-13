Public Class Form1
    Private id As String = STATIC_VARIABLES.CurrentID
    Private g As jbPicsAttachedFiles
    Private xx As imgLSTS
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        Dim a As New jbPicsAttachedFiles
        Dim xx As New imgLSTS(STATIC_VARIABLES.AttachedFilesDirectory & STATIC_VARIABLES.CurrentID) '' will have to change to static vars 
        Me.imgLst16 = xx.ImgList16
        Me.ImgLst32 = xx.ImgList32
        Me.ImgLst64 = xx.ImgList64
        Me.ImgLst128 = xx.ImgList128
        Me.ImgLst256 = xx.ImgList256

        Dim b As Integer
        g = a
        Me.ListView1.SmallImageList = Me.ImgLst32
        Dim cnt As Integer = g.ArFileNameOnly.Count
        For b = 0 To cnt - 1
            Dim xxx As New ListViewItem
            xxx.Text = g.ArFileNameOnly(b).ToString
            Me.ListView1.Items.Add(xxx)
            '' Me.ListView1.Items.Add(g.ArFileNameOnly(b).ToString)
        Next
        Me.ListView1.View = View.SmallIcon
        Me.ListView1.SmallImageList = Me.ImgLst32

        Me.AssignImageKeys()

    End Sub


    Private Sub vwList_Click(ByVal sender As Object, ByVal e As EventArgs) Handles vwList.Click
        Me.ListView1.View = View.List
        Me.ListView1.Columns.RemoveByKey("File Name")
        Me.ListView1.SmallImageList = Me.ImgLst32
        AssignImageKeys()
    End Sub

    Private Sub vsDetails_Click(ByVal sender As Object, ByVal e As EventArgs) Handles vsDetails.Click
        ReorderList("Details")
        Me.ListView1.SmallImageList = Me.imgLst16
        AssignImageKeys()
    End Sub



    Private Sub ListView1_MouseDoubleClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles ListView1.MouseDoubleClick
        Dim fl As ListViewItem
        For Each fl In Me.ListView1.SelectedItems
            If fl.Selected = True Then
                g.LaunchAttachedFile(id, fl.Text)
            End If
        Next
    End Sub

  

    Private Sub AscendingToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AscendingToolStripMenuItem.Click
        If Me.ListView1.View = View.Details Then
            Me.ListView1.Columns.Clear()
            Me.ListView1.Items.Clear()
            g.SortFiles(g.ArFileNameOnly, "Ascending")
            Me.ListView1.Columns.Add("Item Name")
            Me.ListView1.Columns(0).Width = 50
            Me.ListView1.Refresh()
            Dim i As Integer = 0
            For i = 0 To g.SortedFiles.Count - 1
                Dim x As New ListViewItem
                x.Text = g.SortedFiles(i)
                Me.ListView1.Items.Add(x)
            Next
        ElseIf Me.ListView1.View <> View.Details Then
            RefreshList1()
        End If




    End Sub

    Private Sub DescendingZAToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DescendingZAToolStripMenuItem.Click
        If Me.ListView1.View = View.Details Then
            Me.ListView1.Columns.Clear()
            Me.ListView1.Items.Clear()
            g.SortFiles(g.ArFileNameOnly, "Descending")
            Me.ListView1.Columns.Add("File Name")
            Me.ListView1.Columns(0).Width = 50
            Me.ListView1.Refresh()
            Dim i As Integer = 0
            For i = 0 To g.SortedFiles.Count - 1
                Dim x As New ListViewItem
                x.Text = g.SortedFiles(i)
                Me.ListView1.Items.Add(x)
            Next
        ElseIf Me.ListView1.View <> View.Details Then
            RefreshList1()
        End If

    End Sub

    Private Sub tsRefresh_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsRefresh.Click
        Clipboard.Clear()
        g._arCopiedAttachedFiles.Clear()
        g._arCopiedOperation.Clear()
        Dim x As ListView = Me.ListView1
        Dim vw = x.View
        ReorderList(vw.ToString)
    End Sub

    Private Sub tsRename_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim b As ListViewItem
        Dim oldFileName As String
        Dim arSplit()
        Dim fileExt As String = ""
        For Each b In Me.ListView1.SelectedItems
            If b.Selected = True Then
                oldFileName = b.Text
                '' now split it to get file extension
                '' 
                arSplit = Split(oldFileName, ".")
                oldFileName = arSplit(0)
                fileExt = arSplit(1)
            End If

        Next
        If Len(oldFileName) <= 0 Then
            MsgBox("Name cannot be empty.", MsgBoxStyle.Exclamation, "Error Getting File to Rename")
            Exit Sub
        ElseIf Len(oldFileName) > 0 Then
            Dim str = InputBox("Enter the name of the new file.", "Rename File")
            If Len(str) <= 0 Then
                MsgBox("Must have a file name.", MsgBoxStyle.Critical, "Error Renaming File")
                Exit Sub
            ElseIf Len(str) > 0 Then
                g.RenameFile(oldFileName, str, fileExt)
            End If
        End If

        g.GetAttachedFiles(id)


    End Sub
    Private Sub RefreshList1()
        g.GetAttachedFiles(id)
        Me.ListView1.Items.Clear()
        Dim b As Integer
        Dim cnt As Integer = g.ArFileNameOnly.Count
        For b = 0 To cnt - 1
            Dim subSplit = Split(g.ArFileNameOnly(b), ".")
            Dim fileName As String = subSplit(0)
            Dim FileExt As String = subSplit(1)
            Dim hh As New ListViewItem
            hh.Text = g.ArFileNameOnly(b).ToString
            hh.ImageKey = FileExt
            Me.ListView1.Items.Add(hh)

        Next
        AssignImageKeys()
    End Sub
    Private Sub ReorderList(ByVal View As String)
        Select Case View
            Case Is = "List"
                RefreshList1()
                Exit Select
            Case Is = "Details"
                Me.ListView1.Items.Clear()
                Me.ListView1.Columns.Clear()
                Me.ListView1.Columns.Add("File Name")
                Me.ListView1.Columns(0).Width = 50
                Me.ListView1.Refresh()
                g.GetAttachedFiles(id)
                Dim cnt As Integer = g.ArFileNameOnly.Count
                Dim b As Integer
                For b = 0 To cnt - 1
                    Dim subSplit = Split(g.ArFileNameOnly(b), ".")
                    Dim fileName As String = subSplit(0)
                    Dim FileExt As String = subSplit(1)
                    Dim hh As New ListViewItem
                    hh.Text = g.ArFileNameOnly(b).ToString
                    hh.ImageKey = FileExt
                    Me.ListView1.Items.Add(hh)
                Next
                Me.ListView1.View = Windows.Forms.View.Details
                Me.ListView1.SmallImageList = Me.ImgLst32
                Exit Select
            Case Is = "SmallIcon"
                RefreshList1()
                Me.ListView1.SmallImageList = Me.imgLst16
                Exit Select
            Case Is = "LargeIcon"
                Me.ListView1.LargeImageList = Me.ImgLst64
                RefreshList1()
                Exit Select
            Case Is = "Tile"
                Me.ListView1.LargeImageList = Me.ImgLst128
                RefreshList1()
                Exit Select
        End Select
    End Sub

    Private Sub vwLargeIcons_Click(ByVal sender As Object, ByVal e As EventArgs) Handles vwLargeIcons.Click
        Me.ListView1.View = View.LargeIcon
        Me.ListView1.LargeImageList = Me.ImgLst64
    End Sub

    Private Sub vwSmallIcons_Click(ByVal sender As Object, ByVal e As EventArgs) Handles vwSmallIcons.Click
        Me.ListView1.View = View.SmallIcon
        Me.ListView1.SmallImageList = Me.imgLst16
    End Sub


    Private Sub TileToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileToolStripMenuItem.Click
        Me.ListView1.View = View.LargeIcon
        Me.ListView1.LargeImageList = Me.ImgLst128
    End Sub

    Private Sub DeletEFToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DeletEFToolStripMenuItem.Click
        Dim b As ListViewItem
        For Each b In Me.ListView1.Items
            If b.Selected = True Then
                '' this is the one to delete 
                '' 
                g.DeleteFile(b.Text)
                RefreshList1()
            End If
        Next
    End Sub

    Private Sub CreateNewDirectoryHereToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CreateNewDirectoryHereToolStripMenuItem.Click
        Dim x As String = InputBox("Please enter the name of the folder you want to create.", "New Folder Name")
        g.CreateDirectoryAttachedFiles("C:\Users\Clay\Desktop\Test Directory\Iss\10000\Attached Files\", x)

    End Sub

    Private Sub OpenCurrentLocationToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles OpenCurrentLocationToolStripMenuItem.Click
        System.Diagnostics.Process.Start("C:\Users\Clay\Desktop\Test Directory\Iss\10000\Attached Files")
    End Sub

    Private Sub tsCut_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsCut.Click
        '' no file operations yet
        ''
        Dim h As ListViewItem
        g._arCopiedAttachedFiles.Clear()
        g._arCopiedOperation.Clear()
        Clipboard.Clear()
        For Each h In Me.ListView1.Items
            If h.Selected = True Then
                Dim arNameAndExt = Split(h.Text, ".")
                Dim FullName As String = g.ConvertFilePath(arNameAndExt(0), arNameAndExt(1))
                g._arCopiedAttachedFiles.Add(FullName)
                g._arCopiedOperation.Add("Cut")
                Me.ListView1.Items.Remove(h)
            End If
        Next
    End Sub

    Private Sub tsCopy_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsCopy.Click
        '' this is actually paste - named it wrong on the front end
        '' 
        '' no file operations yet 
        '' 
        '' assumes last position in array 
        '' 
        Try
            Dim h As New ListViewItem
            Dim pos As Integer = (g._arCopiedAttachedFiles.Count - 1)
            h.Text = g.SplitOffName(g._arCopiedAttachedFiles(pos).ToString)
            '' before adding now perform ' copy file operations'
            '' 
            g.MoveCopyFile(g._arCopiedAttachedFiles(pos), g._arCopiedOperation(pos))

            Me.ListView1.Items.Add(h)
            RefreshList1()
        Catch ex As Exception
            '' call to error log 
            '' 
        End Try

    End Sub

    Private Sub tsPaste_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsPaste.Click
        '' this is actually copy - named it wrong on the front end 
        ''
        '' 
        '' no file operations yet 

        Try

            Dim a As ListViewItem
            For Each a In Me.ListView1.Items
                If a.Selected = True Then
                    Dim arNameAndExt = Split(a.Text, ".")
                    Dim FullName As String = g.ConvertFilePath(arNameAndExt(0), arNameAndExt(1))
                    g._arCopiedAttachedFiles.Add(FullName)
                    g._arCopiedOperation.Add("Copy")
                End If
            Next
        Catch ex As Exception
            '' catch the error and call log 
        End Try
    End Sub

    Private Sub PasteAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PasteAllToolStripMenuItem.Click
        MsgBox("Dunno if we are going to use this or not.", MsgBoxStyle.Information, "Undecided")
    End Sub
    Private Sub AssignImageKeys()
        Dim bb
        For bb = 0 To Me.ListView1.Items.Count - 1
            Dim gg As ListViewItem
            gg = Me.ListView1.Items.Item(bb)
            Dim strName = gg.Text
            Dim FileNameAndExt = Split(strName, ".")
            gg.ImageKey = (FileNameAndExt(1))

        Next

        Me.ListView1.Refresh()
    End Sub

    Private Sub ViewAsSmallPicturesToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ViewAsSmallPicturesToolStripMenuItem.Click
        Me.ListView1.View = View.LargeIcon
        Me.ListView1.LargeImageList = Me.ImgLst256
    End Sub

    Private Sub DesktopCreateShortcutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DesktopCreateShortcutToolStripMenuItem.Click
        Dim a As ListViewItem
        For Each a In Me.ListView1.Items
            If a.Selected = True Then
                Dim arNameAndExt = Split(a.Text, ".")
                Dim FullName As String = g.ConvertFilePath(arNameAndExt(0), arNameAndExt(1))
                '' 
                '' source / where the shortcut will point to ->
                '' 
                '' FullName
                ''
                '' what the shortCut will be called ->
                ''
                '' shortName
                '' 
                Dim shortName As String = InputBox("Enter a name for the shortcut: ", "ShortCut Name", "" & arNameAndExt(0) & ".lnk")
                If shortName <> "" Then
                    Dim v As New createAShortCut(shortName, FullName)
                ElseIf Len(shortName) <= 0 Then
                    MsgBox("Please check the name of your shortcut and try again.", MsgBoxStyle.Exclamation, "Shortcut Name Required")
                    Exit Sub
                End If
            End If
        Next
    End Sub


    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub

  

End Class
