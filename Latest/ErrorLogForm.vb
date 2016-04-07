Public Class ErrorLogForm
    Private logger As ErrorLogging_V2
    Private fileList As Hashtable
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.Network.IsAvailable = True Then
            Try
                logger = New ErrorLogging_V2
                fileList = New Hashtable
                fileList = logger.File_List
                Me.ListView1.Items.Clear()
                Me.lblPath.Text = ""
                Me.RichTextBox1.Text = ""
                For Each x As DictionaryEntry In fileList
                    Dim lvItem As New ListViewItem
                    lvItem.Tag = x.Key
                    lvItem.Text = x.Value
                    Me.ListView1.Items.Add(lvItem)
                Next
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                Main.Cursor = Cursors.Default

                Dim y As New ErrorLogging_V2
                y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "ErrorLogForm", "FormCode", "Sub", "Form1_Load", "0", ex.Message.ToString)
                y = Nothing
            End Try
        ElseIf My.Computer.Network.IsAvailable = False Then
            MsgBox("No Network Connection Present.", MsgBoxStyle.Exclamation, "No Network.")
            Exit Sub
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        Try
            Dim lstView As ListView = sender
            Dim idx As Integer = 0
            For Each y As ListViewItem In lstView.Items
                If y.Selected = True Then
                    Me.lblPath.Text = y.Tag
                    Dim strTxt As String = logger.ReadFile(y.Tag)
                    Me.RichTextBox1.Text = ""
                    Me.RichTextBox1.Text = strTxt
                End If
            Next
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            logger.WriteToLog(DateTime.Now, My.Computer.Name, "127.0.0.1", "Form1.vb", "ErrorLogging_V2.vb", "Class", "ReadFiles()", "0", "Test ERROR situation.")
            Me.ListView1.Items.Clear()
            fileList = logger.GetFiles
            RefreshListViewFiles()
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default

        End Try
    End Sub
    Private Sub RefreshListViewFiles()
        Try
            fileList = logger.GetFiles
            Me.ListView1.Items.Clear()
            Me.lblPath.Text = ""
            Me.RichTextBox1.Text = ""
            For Each x As DictionaryEntry In fileList
                Dim lvItem As New ListViewItem
                lvItem.Tag = x.Key
                lvItem.Text = x.Value
                Me.ListView1.Items.Add(lvItem)
            Next
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default

        End Try
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Try
            For Each y As ListViewItem In Me.ListView1.Items
                If y.Selected = True Then
                    Me.lblPath.Text = y.Tag
                    If logger.DeleteLog(y.Tag) = True Then
                        RefreshListViewFiles()
                    Else
                        Exit Sub
                    End If
                End If
            Next
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default

        End Try
    End Sub
End Class
