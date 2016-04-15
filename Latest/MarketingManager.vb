Public Class MarketingManager

    Public RecID As String = ""

    ''*****************************************************************
    '' READ THIS !!!
    ''*****************************************************************
    '' When this gets built => 
    '' '' vars for auto calcs
    '' 1-13-2015 AC
    'Dim curYear As Integer = Date.Today.Year
    'Dim builtYear As Integer = CType(r1.Item(27), Integer)
    'Dim AgeOfHome As Integer = (curYear - builtYear)
    '            marketingmanager.txtYrBuilt.Text = AgeOfHome.ToString
    'Dim yrPur As Integer = CType(r1.Item(26), Integer)
    'Dim YrsOwned As Integer = (curYear - yrPur)
    '            marketingmanager.txtYrsOwned.Text = YrsOwned.ToString
    ' 
    '******************************************************************




    Private Sub MarketingManager_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.MdiParent = Main
            Dim y As New ScheduledActions
            y.SetUp(Me)
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default

            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "MarketingManager", "FormCode", "Event", "MarketingManager_Load", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub btnMarkTaskAsDone_Click(sender As Object, e As EventArgs) Handles btnMarkTaskAsDone.Click
        Try
            Dim toggle As String = ""
            Dim btn As ToolStripMenuItem = sender
            Dim strLen As Integer = 0
            toggle = btn.Text.ToString
            strLen = toggle.ToString.Length

            Select Case strLen
                Case Is <> 24 '' All Else / Mark as Done
                    For Each x As Control In Me.pnlScheduledTasks.Controls
                        If TypeOf x Is Panel Then
                            Dim pnlTarget As Panel = x
                            If pnlTarget.BorderStyle = BorderStyle.FixedSingle Then
                                Dim ID As String = Replace(pnlTarget.Name, "pnl", "")
                                Dim z As New ScheduledActions
                                z.Completed(ID)
                                Me.pnlScheduledTasks.Controls.Clear()
                                z.SetUp(Me)
                            End If
                        End If
                    Next
                    Exit Select
                Case Is = 24 '' Undo "Mark Task as Done"
                    For Each x As Control In Me.pnlScheduledTasks.Controls
                        If TypeOf x Is Panel Then
                            Dim pnlTarget As Panel = x
                            If pnlTarget.BorderStyle = BorderStyle.FixedSingle Then
                                Dim ID As String = Replace(pnlTarget.Name, "pnl", "")
                                Dim z As New ScheduledActions
                                z.UndoCompleted(ID)
                                Me.pnlScheduledTasks.Controls.Clear()
                                z.SetUp(Me)
                            End If
                        End If
                    Next
                    Exit Select
            End Select
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default

            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "MarketingManager", "FormCode", "Event", "btnMarkTaskAsDone_Click", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub btnEditScheduledTask_Click(sender As Object, e As EventArgs) Handles btnEditScheduledTask.Click
        Try
            ScheduleAction.edit = True
            Dim c As Integer = Me.pnlScheduledTasks.Controls.Count
            Dim i As Integer
            For i = 1 To c
                Dim all As Panel = Me.pnlScheduledTasks.Controls(i - 1)
                If all.BorderStyle = BorderStyle.FixedSingle Then
                    ScheduleAction.EditId = all.Name.ToString.Substring(3)
                End If
            Next
            If ScheduleAction.EditId = "" Then
                MsgBox("You must select a Task.", MsgBoxStyle.Exclamation, "Please Select a Task")
                Exit Sub
            End If
            ScheduleAction.ShowDialog()
            Dim x As New ScheduledActions
            x.SetUp(Me)
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default

            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "MarketingManager", "FormCode", "Event", "btnEditScheduledTask_Click", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub btnRemoveThisCompletedTask_Click(sender As Object, e As EventArgs) Handles btnRemoveThisCompletedTask.Click
        Try
            For Each x As Control In Me.pnlScheduledTasks.Controls
                If TypeOf x Is Panel Then
                    Dim pnlTarget As Panel = x
                    If pnlTarget.BorderStyle = BorderStyle.FixedSingle Then
                        Dim ID As String = Replace(pnlTarget.Name, "pnl", "")
                        Dim z As New ScheduledActions
                        z.HideTask(ID)
                        Me.pnlScheduledTasks.Controls.Clear()
                        z.SetUp(Me)
                    End If
                End If
            Next
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default

            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "MarketingManager", "FormCode", "Event", "btnRemoveThisCompletedTask_Click", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub btnRemoveAllScheduledTask_Click(sender As Object, e As EventArgs) Handles btnRemoveAllScheduledTask.Click
        Try
            Dim x As New ScheduledActions
            x.HideAll(Me)
            Me.pnlScheduledTasks.Controls.Clear()
            x.SetUp(Me)
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default

            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "MarketingManager", "FormCode", "Event", "btnRemoveAllScheduledTask_Click", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub tsCreateList_Click(sender As Object, e As EventArgs)
        'frmCreateList.Show()
        'frmCreateList.MdiParent = Main

    End Sub

    Private Sub lnkEmail_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkEmail.LinkClicked
        frmLinkSendEmail.Cust_Email = Me.lnkEmail.Text
        frmLinkSendEmail.RecID = STATIC_VARIABLES.CurrentID
        frmLinkSendEmail.Show()
        frmLinkSendEmail.BringToFront()
    End Sub

    Private Sub btnEditSPI_Click(sender As Object, e As EventArgs) Handles btnEditSPI.Click

        frmEditSpecialInstructions.frm = Me
        frmEditSpecialInstructions.ShowDialog()
    End Sub

    Private Sub PreviewCustomerListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreviewCustomerListToolStripMenuItem.Click
        frmPCList.MdiParent = Main
        frmPCList.Show()
    End Sub

    Private Sub RecoveryListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecoveryListToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        frmRList.MdiParent = Main
        frmRList.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub GenerateWarmCallingListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerateWarmCallingListToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        frmWCList.MdiParent = Main
        frmWCList.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ToolStripSplitButton2_ButtonClick(sender As Object, e As EventArgs) Handles ToolStripSplitButton2.ButtonClick
        SetApptTelemarketing.Show()
    End Sub
End Class