
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System


Public Class ConfirmingSingleRecord


    Public Lastbtn As String
    Private DoNotCall
    Private DoNotMail
    Private DoNotCallMail
    Public Rep1 As String
    Public Rep2 As String
    Public MResult As String
    Public NR As Boolean = False
    Public OrigRep1 As String
    Public OrigRep2 As String
    Dim ManagerPrivledges As Boolean = False
    'Private Kill1


    Public ID As String
    Public cnn As SqlConnection = New SqlConnection(STATIC_VARIABLES.Cnn)



    Private Sub btnCandC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCandC.Click
        Dim x As New SubForm_Launcher(sender)
    End Sub

    Private Sub btnLogCall_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim x As New SubForm_Launcher(sender)
    End Sub

    Private Sub ConfirmingSingleRecord_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        STATIC_VARIABLES.CurrentID = ""
        Me.Dispose()
    End Sub

    Private Sub ConfirmingSingleRecord_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        'ID = STATIC_VARIABLES.CurrentID
    End Sub
    Private Sub MGR_Privledges()
        Dim cnt As Integer = 0
        If Me.btnSales.Enabled Then
            cnt += 1
        End If
        If Me.btnAdmin.Enabled Then
            cnt += 1
        End If
        If Me.btnMarketManager.Enabled Then
            cnt += 1
        End If
        If Me.btnFinance.Enabled Then
            cnt += 1
        End If
        If Me.btnInstall.Enabled Then
            cnt += 1
        End If
        If cnt > 0 Then
            ManagerPrivledges = True
        Else
            ManagerPrivledges = False
        End If
    End Sub


    Private Sub ConfirmingSingleRecord_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.btnSpokeWith.Text = "Select who you spoke with" & vbCr & "to Confirm this Appt."
        Me.btnSMNotes.Text = "Attach notes for the" & vbCr & "Issuing Sales Manager"

        ID = STATIC_VARIABLES.CurrentID
        Me.btnConfirmDispatch.Image = Me.ilToolStripIcons.Images(6)

        Me.MdiParent = Main
        Me.TScboCustomerHistory.Text = "All"
        Me.cboRep2.Items.Clear()
        Me.cboRep1.Items.Clear()
        Dim x As New cbo_List_Fill(Me.cboRep1, False, True)
        Dim y As New cbo_List_Fill(Me.cboRep2, False, True)
        Me.lblSalesRep.Text = ""

        Me.Text = Me.Text & ID

        If ID = "" Then
            Me.txtContact1.Text = ""
            Me.txtContact2.Text = ""
            Me.txtAddress.Text = ""
            Me.txtWorkHours.Text = ""
            Me.txtHousePhone.Text = ""
            Me.txtaltphone1.Text = ""
            Me.txtaltphone2.Text = ""
            Me.txtAlt1Type.Text = ""
            Me.txtAlt2Type.Text = ""
            Me.lnkEmail.Text = ""
            Me.txtApptDate.Text = ""
            Me.txtApptDay.Text = ""
            Me.txtApptTime.Text = ""
            Me.txtProducts.Text = ""
            Me.txtColor.Text = ""
            Me.txtQty.Text = ""
            Me.txtYrBuilt.Text = ""
            Me.txtYrsOwned.Text = ""
            Me.txtHomeValue.Text = ""
            Me.rtbSpecialInstructions.Text = ""
            Me.pnlCustomerHistory.Controls.Clear()
        End If


        Dim cmdGet As SqlCommand = New SqlCommand("dbo.GetCustomerINFO", cnn)

        Dim param1 As SqlParameter = New SqlParameter("@ID", ID)
        cmdGet.CommandType = CommandType.StoredProcedure
        cmdGet.Parameters.Add(param1)
        Try



            cnn.Open()


            Dim r1 As SqlDataReader
            r1 = cmdGet.ExecuteReader(CommandBehavior.CloseConnection)
            While r1.Read
                Me.txtContact1.Text = r1.Item(5) & " " & r1.Item(6)
                Me.txtContact2.Text = r1.Item(7) & " " & r1.Item(8)
                Me.txtAddress.Text = r1.Item(9) & " " & vbCrLf & r1.Item(10) & ", " & r1.Item(11) & " " & r1.Item(12)


                If r1.Item(7) = "" Then
                    Me.txtWorkHours.Text = r1.Item(5) & ": " & r1.Item(19)
                Else
                    Me.txtWorkHours.Text = r1.Item(5) & ": " & r1.Item(19) & vbNewLine & r1.Item(7) & ": " & r1.Item(20)
                End If
                Me.txtHousePhone.Text = r1.Item(13)
                Me.txtaltphone1.Text = r1.Item(14)
                Me.txtaltphone2.Text = r1.Item(16)
                Me.txtAlt1Type.Text = r1.Item(15)
                Me.txtAlt2Type.Text = r1.Item(17)
                Me.lnkEmail.Text = r1.Item(52)
                Dim d
                d = Split(r1.Item(29), " ", 2)
                Trim(d(0))

                Me.txtApptDate.Text = d(0)
                Me.txtApptDay.Text = r1.Item(30)
                Dim t = Split(r1.Item(31), " ", 2)
                Dim u = t(1)
                Dim u2 As String
                Dim u3 As String
                If u.Length = 11 Then
                    u2 = Microsoft.VisualBasic.Left(u, 5)
                    u3 = Microsoft.VisualBasic.Right(u, 3)
                    u = u2 & u3
                Else
                    u2 = Microsoft.VisualBasic.Left(u, 4)
                    u3 = Microsoft.VisualBasic.Right(u, 3)
                    u = u2 & u3
                End If
                Me.txtApptTime.Text = u
                Me.txtProducts.Text = r1.Item(21) & vbCrLf & r1.Item(22) & vbCrLf & r1.Item(23)
                Me.txtColor.Text = r1.Item(24)
                Me.txtQty.Text = r1.Item(25)
                Me.txtYrBuilt.Text = r1.Item(27)
                Me.txtYrsOwned.Text = r1.Item(26)
                Me.txtHomeValue.Text = r1.Item(28)
                Me.rtbSpecialInstructions.Text = r1.Item(32)
                Try
                    MResult = r1.Item("MarketingResults")
                Catch ex As Exception
                    MResult = ""
                End Try
                If r1.Item("DoNotCall") = True Or MResult = "Kill" Then
                    Me.btnSetAppt.Enabled = False
                    Me.btnSetAppt.ToolTipText = "Cannot Set Appt. You must undo ""Do Not Call"" or ""Kill"
                End If
                If r1.Item("DoNotCall") = True And r1.Item("DoNotMail") = True Then
                    Me.btnDoNotCall.Text = "Undo Do Not Call"
                    Me.btnDoNotCallOrMail.Text = "Undo Do Not Call Or Mail"
                    Me.btnDoNotMail.Text = "Undo Do Not Mail"
                End If
                If r1.Item("DoNotMail") = True And r1.Item("DoNotCall") = False Then
                    Me.btnDoNotMail.Text = "Undo Do Not Mail"
                End If
                If r1.Item("DoNotMail") = False And r1.Item("DoNotCall") = True Then
                    Me.btnDoNotCall.Text = "Undo Do Not Call"
                End If
                If MResult = "Kill" Then
                    Me.btnKill.Text = "Undo Kill"
                End If
                'MsgBox(r1.Item("DoNotCall").ToString & " | " & r1.Item("DoNotMail").ToString & " | " & r1.Item("MarketingResults"))
                Try
                    If r1.Item(36) <> "" Then
                        Rep1 = r1.Item(36)
                        OrigRep1 = r1.Item(36)
                    Else
                        Rep1 = ""
                        OrigRep1 = ""
                    End If
                Catch ex As Exception
                    Rep1 = ""
                    OrigRep1 = ""
                End Try
                Try
                    If r1.Item(37) <> "" Then
                        Rep2 = r1.Item(37)
                        OrigRep2 = r1.Item(37)
                    Else
                        Rep2 = ""
                        OrigRep2 = ""
                    End If
                Catch ex As Exception
                    Rep2 = ""
                    OrigRep2 = ""
                End Try

                NR = r1.Item("NeedsSaleResult")
            End While
            r1.Close()
            cnn.Close()

        Catch ex As Exception
            cnn.Close()
            'Me.PullCustomerINFO(ID)
            MsgBox("Lost Network Connection! Pull Customer Info" & ex.ToString, MsgBoxStyle.Critical, "Server not Available")
        End Try
        Dim c As New CustomerHistory
        c.SetUp(Me.TScboCustomerHistory)
        'Dim k As Form = Kill

        ''WTF?
        'Kill.Contact1 = Me.txtContact1.Text
        'Kill.Contact2 = Me.txtContact2.Text
        'Kill.frm = "ConfirmingSingleRecord"
        'Kill.ID = ID

        'Kill.ShowInTaskbar = False
        'Kill.ShowDialog()
        Me.tsSingleForm.Items.Clear()
        Me.btnNone_Click(Me.btnNone, Nothing)
        Me.btnAdmin.Enabled = STATIC_VARIABLES.Administration
        Me.btnSales.Enabled = STATIC_VARIABLES.SalesManager
        Me.btnInstall.Enabled = STATIC_VARIABLES.Install
        Me.btnFinance.Enabled = STATIC_VARIABLES.Finance
        Me.btnMarketManager.Enabled = STATIC_VARIABLES.MarketingManager
        Me.btnWarmCall.Enabled = STATIC_VARIABLES.WarmCall
        Me.btnRecovery.Enabled = STATIC_VARIABLES.Recovery
        Me.btnPC.Enabled = STATIC_VARIABLES.PreviousCust
        Me.btnColdCall.Enabled = STATIC_VARIABLES.ColdCall
        Me.btnConfirming.Enabled = STATIC_VARIABLES.Confirmer
        If Me.btnConfirming.Enabled = False And Me.btnMarketManager.Enabled = False And Me.btnColdCall.Enabled = False _
            And Me.btnWarmCall.Enabled = False And Me.btnPC.Enabled = False And Me.btnRecovery.Enabled = False Then
            Me.btnMarketing.Enabled = False
        End If
        Me.btnMainPhone.Text = Me.btnMainPhone.Text & " " & Me.txtHousePhone.Text
        Me.btnAlt1.Text = Me.btnAlt1.Text & " " & Me.txtaltphone1.Text
        Me.btnAlt2.Text = Me.btnAlt2.Text & " " & Me.txtaltphone2.Text
        Me.btnCall.DropDownItems.Add(Me.btnMainPhone)
        If Me.btnAlt1.Text.Contains("(") Then
            Me.btnCall.DropDownItems.Add(Me.btnAlt1)
        End If
        If Me.btnAlt2.Text.Contains("(") Then
            Me.btnCall.DropDownItems.Add(Me.btnAlt2)
        End If
        MGR_Privledges()
        Manage_Buttons()
        Me.BringToFront()
        Me.Activate()


    End Sub

    Public Sub btnSetAppt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x As New SubForm_Launcher(sender)
    End Sub



    Private Sub btnDoNotCall_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim c As New DoNotCallOrMail
        c.DoNot(ID, sender.text.ToString)
        Dim d As New CustomerHistory
        d.SetUp(Me.TScboCustomerHistory)
        Me.Manage_Buttons()



    End Sub

    Private Sub btnDoNotCallOrMail_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim c As New DoNotCallOrMail
        c.DoNot(ID, sender.text.ToString)
        Dim d As New CustomerHistory
        d.SetUp(Me.TScboCustomerHistory)
        Me.Manage_Buttons()

    End Sub

    Private Sub btnDoNotMail_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim x As New DoNotCallOrMail
        x.DoNot(ID, sender.text.ToString)
        Dim d As New CustomerHistory
        d.SetUp(Me.TScboCustomerHistory)
        Me.Manage_Buttons()
    End Sub

    Private Sub btnEditCustomer_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        Dim x As New SubForm_Launcher(sender)
    End Sub

    Private Sub TScboCustomerHistory_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim c As New CustomerHistory
        c.SetUp(Me.TScboCustomerHistory)
    End Sub

    Private Sub rtbSpecialInstructions_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        ''Comeback
        Dim cnn = New SqlConnection(STATIC_VARIABLES.Cnn)
        Dim cmdUP As SqlCommand = New SqlCommand("Update enterlead set SpecialInstruction = @SI where id = @ID", cnn)
        cmdUP.CommandType = CommandType.Text
        cnn.Open()
        Dim param1 As SqlParameter = New SqlParameter("@ID", ID)
        Dim param2 As SqlParameter = New SqlParameter("@SI", Me.rtbSpecialInstructions.Text)
        cmdUP.Parameters.Add(param1)
        cmdUP.Parameters.Add(param2)
        cmdUP.ExecuteNonQuery()
        cnn.Close()
    End Sub

    Private Sub ConfirmingSingleRecord_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
        Me.WindowState = FormWindowState.Normal
    End Sub
    Public Sub Manage_Buttons()
        Dim cmdGet As SqlCommand = New SqlCommand(("Select DoNotCall, DoNotMail, MarketingResults from enterlead where id = " & ID), cnn)
        cmdGet.CommandType = CommandType.Text
        cnn.Open()
        Dim r1 As SqlDataReader
        r1 = cmdGet.ExecuteReader(CommandBehavior.CloseConnection)
        While r1.Read
            If r1.Item(0) = True And r1.Item(1) = True Then
                Me.btnDoNotCall.Text = "Undo Do Not Call"
                Me.btnDoNotMail.Text = "Undo Do Not Mail"
                Me.btnDoNotCallOrMail.Text = "Undo Do Not Call Or Mail"
                If ManagerPrivledges = False Then
                    Me.btnDoNotCall.Enabled = False
                    Me.btnDoNotMail.Enabled = False
                    Me.btnDoNotCallOrMail.Enabled = False
                    Me.btnDoNotCall.ToolTipText = "You must have manager privledges to Undo Do Not Call"
                    Me.btnDoNotMail.ToolTipText = "You must have manager privledges to Undo Do Not Mail"
                    Me.btnDoNotCallOrMail.ToolTipText = "You must have manager privledges to Undo Do Not Call Or Mail"
                End If
            ElseIf r1.Item(0) = False And r1.Item(1) = True Then
                Me.btnDoNotCall.Text = "Mark as Do Not Call"
                Me.btnDoNotMail.Text = "Undo Do Not Mail"
                Me.btnDoNotCallOrMail.Text = "Mark as Do Not Call Or Mail"
                If ManagerPrivledges = False Then
                    Me.btnDoNotMail.Enabled = False
                    Me.btnDoNotMail.ToolTipText = "You must have manager privledges to Undo Do Not Mail"
                End If
            ElseIf r1.Item(0) = False And r1.Item(1) = False Then
                Me.btnDoNotCall.Text = "Mark as Do Not Call"
                Me.btnDoNotMail.Text = "Mark as Do Not Mail"
                Me.btnDoNotCallOrMail.Text = "Mark as Do Not Call Or Mail"

            ElseIf r1.Item(0) = True And r1.Item(1) = False Then
                Me.btnDoNotCall.Text = "Undo Do Not Call"
                Me.btnDoNotMail.Text = "Mark as Do Not Mail"
                Me.btnDoNotCallOrMail.Text = "Mark as Do Not Call Or Mail"
                If ManagerPrivledges = False Then
                    Me.btnDoNotCall.Enabled = False
                    Me.btnDoNotCall.ToolTipText = "You must have manager privledges to Undo Do Not Call"
                End If
            End If
            If r1.Item(0) = True Or r1.Item(2) = "Kill" Then
                Me.btnSetAppt.Enabled = False
                Me.btnAppt.Enabled = False
                Me.btnAppt.ToolTipText = "Cannot Set Appt. You must undo ""Do Not Call"" or ""Kill"
                Me.btnSetAppt.ToolTipText = "Cannot Set Appt. You must undo ""Do Not Call"" or ""Kill"
            ElseIf r1.Item(0) = False And r1.Item(2) <> "Kill" Then
                Me.btnSetAppt.Enabled = True
                Me.btnSetAppt.ToolTipText = ""
                Me.btnAppt.Enabled = True
                Me.btnAppt.ToolTipText = ""
            End If
            If r1.Item(2) = "Kill" Then
                Me.btnKill.Text = "Undo Kill"
                If ManagerPrivledges = False Then
                    Me.btnKill.Enabled = False
                    Me.btnKill.ToolTipText = "You must have manager privledges to Undo Kill"
                End If
            Else
                Me.btnKill.Text = "Kill"
            End If
        End While
        r1.Close()
        cnn.Close()
    End Sub
    Private Sub btnKill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim c As New CustomerHistory
        If Me.btnKill.Text = "Undo Kill" Then
            Dim cnn = New SqlConnection(STATIC_VARIABLES.Cnn)
            Dim cmdIns As SqlCommand = New SqlCommand("dbo.UnKillAppt", cnn)
            Dim param1 As SqlParameter = New SqlParameter("@ID", ID)

            cmdIns.CommandType = CommandType.StoredProcedure
            cmdIns.Parameters.Add(param1)
            cnn.Open()
            Dim R1 As SqlDataReader
            R1 = cmdIns.ExecuteReader(CommandBehavior.CloseConnection)
            R1.Read()
            R1.Close()
            cnn.close()
            Me.Manage_Buttons()
            c.SetUp(Me.TScboCustomerHistory)
            Exit Sub
        End If
        Dim x As New SubForm_Launcher(sender)

    End Sub




    Private Sub btnNone_Click(sender As Object, e As EventArgs)
        Dim btn As Object
        For Each btn In Me.TSMain.Items
            Try
                btn.Checked = False
            Catch ex As Exception
            End Try
        Next
        Dim Mitm As ToolStripMenuItem
        For Each Mitm In Me.btnMarketing.DropDownItems
            Mitm.Checked = False
        Next
        Lastbtn = sender.name
        Me.btnNone.Checked = True
        Tool_Bar_Config(sender)
    End Sub

    Private Sub btnSales_Click(sender As Object, e As EventArgs)
        Dim btn As Object
        For Each btn In Me.TSMain.Items
            Try
                btn.Checked = False
            Catch ex As Exception
            End Try
        Next
        Dim Mitm As ToolStripMenuItem
        For Each Mitm In Me.btnMarketing.DropDownItems
            Mitm.Checked = False
        Next
        Lastbtn = sender.name
        Me.btnSales.Checked = True
        Tool_Bar_Config(sender)
    End Sub
    Private Sub Tool_Bar_Config(sender As Object)
        Me.tsSingleForm.Items.Clear()
        Select Case sender.Name
            Case Is = "btnSales"
                ''Add Code to square up button states ie. Memorize, Undo Memorize   Confirm, Undo Confirm... so on and so forth
                Me.tsSingleForm.Items.Add(Me.btnSalesResult)
                Me.btnSalesResult.DropDownItems.Clear()
                Dim cmdGet As SqlCommand = New SqlCommand("Select Count (id) From MemorizedAppts where form = 'Sales' and Leadnum = '" & ID & "' and UserLoggedOn = '" & STATIC_VARIABLES.CurrentUser & "'", cnn)
                cmdGet.CommandType = CommandType.Text
                cnn.Open()
                Dim r1 As SqlDataReader
                r1 = cmdGet.ExecuteReader(CommandBehavior.CloseConnection)
                While r1.Read
                    If r1.Item(0) > 0 Then
                        Me.btnSalesResult.DropDownItems.Add(Me.btnRemoveFromMemorized)
                    Else
                        Me.btnSalesResult.DropDownItems.Add(Me.btnMemorize)
                    End If
                End While
                r1.Close()
                cnn.Close()
                Me.tsSingleForm.Items.Add(Me.btnCustomerTools)
                Me.btnCustomerTools.DropDownItems.Clear()
                Me.btnCustomerTools.DropDownItems.Add(Me.btnEditCust2)
                Me.btnCustomerTools.DropDownItems.Add(Me.ToolStripSeparator6)
                Me.btnCustomerTools.DropDownItems.Add(Me.btnCall)
                Me.btnCustomerTools.DropDownItems.Add(Me.btnEmail)
                Me.btnEmail.DropDownItems.Clear()
                Me.btnEmail.DropDownItems.Add(Me.btnEmailCust)
                Me.btnEmail.DropDownItems.Add(Me.btnEmailRep)
                Me.btnEmail.DropDownItems.Add(Me.ToolStripSeparator7)
                Me.btnEmail.DropDownItems.Add(Me.btnChooseTemplate)
                Me.btnCustomerTools.DropDownItems.Add(Me.btnLetter)
                Me.btnCustomerTools.DropDownItems.Add(Me.ToolStripSeparator2)
                Me.btnCustomerTools.DropDownItems.Add(Me.btnAppt)
                Me.btnCustomerTools.DropDownItems.Add(Me.btnChangeRep)
                Me.tsSingleForm.Items.Add(Me.btnPrint)
                Me.btnPrint.DropDownItems.Clear()
                Me.btnPrint.DropDownItems.Add(Me.btnPrintAppt)
                Me.btnPrint.DropDownItems.Add(Me.btnPrintInfo)
                Me.btnPrintInfo.DisplayStyle = ToolStripItemDisplayStyle.Text
                If Rep1 <> "" And Rep2 = "" Then
                    Me.lblSalesRep.Text = "Sales Rep: " & Rep1
                ElseIf Rep1 = "" And Rep2 <> "" Then
                    Me.lblSalesRep.Text = "Sales Rep: " & Rep2
                ElseIf Rep1 <> "" And Rep2 <> "" Then
                    Me.lblSalesRep.Text = "Sales Reps: " & Rep1 & " and " & Rep2
                ElseIf Rep1 = "" And Rep2 = "" Then
                    Me.lblSalesRep.Text = ""
                End If
                Me.tsSingleForm.Items.Add(Me.lblSalesRep)
                Me.cboRep1.SelectedItem = Rep1
                If Me.cboRep1.SelectedItem = Nothing And Rep1 <> "" Then
                    Me.cboRep1.Items.Add(Rep1)
                    Me.cboRep1.SelectedItem = Rep1
                End If
                Me.cboRep2.SelectedItem = Rep2
                If Me.cboRep2.SelectedItem = Nothing And Rep2 <> "" Then
                    Me.cboRep2.Items.Add(Rep2)
                    Me.cboRep2.SelectedItem = Rep2
                End If
            Case Is = "btnNone", "btnColdCall", "btnRecovery", "btnMarketManager", "btnInstall", "btnAdmin", "btnFinance", "btnPC", "btnWarmCall"
                Me.tsSingleForm.Items.Add(Me.btnSetAppt)
                Me.tsSingleForm.Items.Add(Me.btnEditCustomer)
                Me.tsSingleForm.Items.Add(Me.btnChangeStatus)
                Me.tsSingleForm.Items.Add(Me.btnPrintInfo)
                Me.btnPrintInfo.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
            Case Is = "btnConfirming"
                If NR = False Then
                    Me.btnConfirmDispatch.Enabled = False
                    Me.btnConfirmDispatch.ToolTipText = "Customer appointment has not been issued by Sales Department"
                Else
                    Me.btnConfirmDispatch.Text = "Switch to Confirming Toolbar"
                    Me.btnConfirmDispatch.Image = Me.ilToolStripIcons.Images(15)
                    Me.btnConfirmDispatch.Enabled = False
                    Me.btnConfirmDispatch.ToolTipText = "Appt. Confirmed and needs Sales Result before it can be changed"
                End If
                If Me.txtApptDate.Text <> Today.ToShortDateString Then
                    Me.btnConfirmDispatch.Enabled = False
                    Me.btnConfirmDispatch.ToolTipText = "You can only dispatch sales appointments on the day of the appointment!"
                End If
                If Me.btnConfirmDispatch.Text = "Switch to Dispatch Sales Toolbar" Then
                    Me.tsSingleForm.Items.Add(Me.btnConfirmDispatch)
                    Me.tsSingleForm.Items.Add(Me.ToolStripSeparator6)
                    If MResult <> "Confirmed" Then
                        Me.tsSingleForm.Items.Add(Me.btnConfirm)
                        Me.btnSpokeWith.DropDownItems.Clear()
                        Me.btnConfirm.DropDownItems.Add(Me.btnSpokeWith)


                        If Me.txtContact1.Text <> "" Then
                            Dim s = Split(Me.txtContact1.Text, " ")
                            Me.btnContact1.Text = s(0)
                            Me.btnSpokeWith.DropDownItems.Add(Me.btnContact1)
                        End If
                        If Me.txtContact1.Text <> "" And Me.txtContact2.Text <> " " Then
                            Dim s = Split(Me.txtContact2.Text, " ")
                            Me.btnContact2.Text = s(0)
                            Me.btnBoth.Text = Me.btnContact1.Text & " and " & Me.btnContact2.Text
                            Me.btnSpokeWith.DropDownItems.Add(Me.btnContact2)
                            Me.btnSpokeWith.DropDownItems.Add(Me.btnBoth)
                        End If
                        Me.btnSpokeWith.DropDownItems.Add(Me.btnOther)
                        Me.btnConfirm.DropDownItems.Add(Me.ToolStripSeparator2)
                        Me.btnConfirm.DropDownItems.Add(Me.btnSMNotes)
                    Else
                        Me.tsSingleForm.Items.Add(Me.btnUndoConfirm)
                        Me.btnUndoConfirm.DropDownItems.Add(Me.btnSMNotes)
                    End If

                    Me.tsSingleForm.Items.Add(Me.btnCustomerTools)
                    Me.btnCustomerTools.DropDownItems.Clear()
                    Me.btnCustomerTools.DropDownItems.Add(Me.btnEditCust2)
                    Me.btnCustomerTools.DropDownItems.Add(Me.ToolStripSeparator3)
                    Me.btnCustomerTools.DropDownItems.Add(Me.btnCall)
                    Me.btnCustomerTools.DropDownItems.Add(Me.btnEmail)
                    Me.btnEmail.DropDownItems.Clear()
                    Me.btnEmail.DropDownItems.Add(Me.btnConfirmationEmail)
                    Me.btnEmail.DropDownItems.Add(Me.btnEmailCust)
                    Me.btnEmail.DropDownItems.Add(Me.ToolStripSeparator7)
                    Me.btnEmail.DropDownItems.Add(Me.btnChooseTemplate)
                    Me.btnChooseTemplate.DropDownItems.Add(Me.cboTemplates)
                    Me.btnChooseTemplate.DropDownItems.Add(Me.btnNewTemplate)
                    Me.btnCustomerTools.DropDownItems.Add(Me.ToolStripSeparator5)
                    Me.btnCustomerTools.DropDownItems.Add(Me.btnAppt)
                    Me.btnAppt.DropDownItems.Add(Me.btnSetAppt2)
                    Me.btnAppt.DropDownItems.Add(Me.btnMoveAppt)
                    Me.tsSingleForm.Items.Add(Me.btnChangeStatus)
                    Me.tsSingleForm.Items.Add(Me.btnPrint)
                    Me.btnPrint.DropDownItems.Clear()
                    Me.btnPrint.DropDownItems.Add(Me.btnPrintAppt)
                    Me.btnPrintInfo.DisplayStyle = ToolStripItemDisplayStyle.Text
                    Me.btnPrint.DropDownItems.Add(Me.btnPrintInfo)
                Else
                    Me.tsSingleForm.Items.Add(Me.btnConfirmDispatch)
                    Me.tsSingleForm.Items.Add(Me.ToolStripSeparator6)
                    Me.tsSingleForm.Items.Add(Me.btnCustomerTools)
                    Me.btnCustomerTools.DropDownItems.Clear()
                    Me.btnCustomerTools.DropDownItems.Add(Me.btnEditCust2)
                    Me.btnCustomerTools.DropDownItems.Add(Me.ToolStripSeparator3)
                    Me.btnCustomerTools.DropDownItems.Add(Me.btnCall)
                    Me.btnCustomerTools.DropDownItems.Add(Me.btnEmail)
                    Me.btnEmail.DropDownItems.Clear()
                    Me.btnEmail.DropDownItems.Add(Me.btnEmailCust)
                    Me.btnEmail.DropDownItems.Add(Me.ToolStripSeparator7)
                    Me.btnEmail.DropDownItems.Add(Me.btnChooseTemplate)
                    Me.btnChooseTemplate.DropDownItems.Add(Me.cboTemplates)
                    Me.btnChooseTemplate.DropDownItems.Add(Me.btnNewTemplate)
                    Me.tsSingleForm.Items.Add(Me.btnEditSales)
                    Me.btnEditSales.DropDownItems.Add(Me.btnChangeRep)
                    Me.tsSingleForm.Items.Add(Me.btnPrint)
                    Me.btnPrint.DropDownItems.Clear()
                    Me.btnPrint.DropDownItems.Add(Me.btnPrintAppt)
                    Me.btnPrint.DropDownItems.Add(Me.btnPrintInfo)
                    Me.btnPrintInfo.DisplayStyle = ToolStripItemDisplayStyle.Text
                    If Rep1 <> "" And Rep2 = "" Then
                        Me.lblSalesRep.Text = "Sales Rep: " & Rep1
                    ElseIf Rep1 = "" And Rep2 <> "" Then
                        Me.lblSalesRep.Text = "Sales Rep: " & Rep2
                    ElseIf Rep1 <> "" And Rep2 <> "" Then
                        Me.lblSalesRep.Text = "Sales Reps: " & Rep1 & " and " & Rep2
                    ElseIf Rep1 = "" And Rep2 = "" Then
                        Me.lblSalesRep.Text = ""
                    End If
                    Me.tsSingleForm.Items.Add(Me.lblSalesRep)
                    Me.cboRep1.SelectedItem = Rep1
                    If Me.cboRep1.SelectedItem = Nothing Then
                        Me.cboRep1.Items.Add(Rep1)
                        Me.cboRep1.SelectedItem = Rep1
                    End If
                    Me.cboRep2.SelectedItem = Rep2
                    If Me.cboRep2.SelectedItem = Nothing Then
                        Me.cboRep2.Items.Add(Rep2)
                        Me.cboRep2.SelectedItem = Rep2
                    End If
                End If
                ''Add Cases as Forms Complete & remove them from None 
                ''Case is = "btnInstall"
                ''Case is = "btnAdmin"
                ''Case is = "btnFinanace"
                ''Case is = "btnMarketManager"
                ''Case is = "btnColdCall"
                ''Case is = "btnWarmCall"
                ''Case is = "btnRecovery"
                ''Case is = "btnPC"
        End Select
    End Sub


    Private Sub btnColdCall_Click(sender As Object, e As EventArgs)
        Dim btn As Object
        For Each btn In Me.TSMain.Items
            Try
                btn.Checked = False
            Catch ex As Exception
            End Try
        Next
        Dim Mitm As ToolStripMenuItem
        For Each Mitm In Me.btnMarketing.DropDownItems
            Mitm.Checked = False
        Next
        Lastbtn = sender.name
        Me.btnColdCall.Checked = True
        Tool_Bar_Config(sender)
    End Sub

    Private Sub btnWarmCall_Click(sender As Object, e As EventArgs)
        Dim btn As Object
        For Each btn In Me.TSMain.Items
            Try
                btn.Checked = False
            Catch ex As Exception
            End Try
        Next
        Dim Mitm As ToolStripMenuItem
        For Each Mitm In Me.btnMarketing.DropDownItems
            Mitm.Checked = False
        Next
        Lastbtn = sender.name
        Me.btnWarmCall.Checked = True
        Tool_Bar_Config(sender)
    End Sub

    Private Sub btnPC_Click(sender As Object, e As EventArgs)
        Dim btn As Object
        For Each btn In Me.TSMain.Items
            Try
                btn.Checked = False
            Catch ex As Exception
            End Try
        Next
        Dim Mitm As ToolStripMenuItem
        For Each Mitm In Me.btnMarketing.DropDownItems
            Mitm.Checked = False
        Next
        Lastbtn = sender.name
        Me.btnPC.Checked = True
        Tool_Bar_Config(sender)
    End Sub

    Private Sub btnRecovery_Click(sender As Object, e As EventArgs)
        Dim btn As Object
        For Each btn In Me.TSMain.Items
            Try
                btn.Checked = False
            Catch ex As Exception
            End Try
        Next
        Dim Mitm As ToolStripMenuItem
        For Each Mitm In Me.btnMarketing.DropDownItems
            Mitm.Checked = False
        Next
        Lastbtn = sender.name
        Me.btnRecovery.Checked = True
        Tool_Bar_Config(sender)
    End Sub

    Private Sub btnConfirming_Click(sender As Object, e As EventArgs)
        Dim btn As Object
        For Each btn In Me.TSMain.Items
            Try
                btn.Checked = False
            Catch ex As Exception
            End Try
        Next
        Dim Mitm As ToolStripMenuItem
        For Each Mitm In Me.btnMarketing.DropDownItems
            Mitm.Checked = False
        Next
        Lastbtn = sender.name
        Me.btnConfirming.Checked = True
        Tool_Bar_Config(sender)
    End Sub

    Private Sub btnMarketManager_Click(sender As Object, e As EventArgs)
        Dim btn As Object
        For Each btn In Me.TSMain.Items
            Try
                btn.Checked = False
            Catch ex As Exception
            End Try
        Next
        Dim Mitm As ToolStripMenuItem
        For Each Mitm In Me.btnMarketing.DropDownItems
            Mitm.Checked = False
        Next
        Lastbtn = sender.name
        Me.btnMarketManager.Checked = True
        Tool_Bar_Config(sender)
    End Sub

    Private Sub btnInstall_Click(sender As Object, e As EventArgs)
        Dim btn As Object
        For Each btn In Me.TSMain.Items
            Try
                btn.Checked = False
            Catch ex As Exception
            End Try
        Next
        Dim Mitm As ToolStripMenuItem
        For Each Mitm In Me.btnMarketing.DropDownItems
            Mitm.Checked = False
        Next
        Lastbtn = sender.name
        Me.btnInstall.Checked = True
        Tool_Bar_Config(sender)
    End Sub

    Private Sub btnFinance_Click(sender As Object, e As EventArgs)
        Dim btn As Object
        For Each btn In Me.TSMain.Items
            Try
                btn.Checked = False
            Catch ex As Exception
            End Try
        Next
        Dim Mitm As ToolStripMenuItem
        For Each Mitm In Me.btnMarketing.DropDownItems
            Mitm.Checked = False
        Next
        Lastbtn = sender.name
        Me.btnFinance.Checked = True
        Tool_Bar_Config(sender)
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs)
        Dim btn As Object
        For Each btn In Me.TSMain.Items
            Try
                btn.Checked = False
            Catch ex As Exception
            End Try
        Next
        Dim Mitm As ToolStripMenuItem
        For Each Mitm In Me.btnMarketing.DropDownItems
            Mitm.Checked = False
        Next
        Lastbtn = sender.name
        Me.btnAdmin.Checked = True
        Tool_Bar_Config(sender)
    End Sub

    Public Sub btnConfirmDispatch_Click(sender As Object, e As EventArgs)
        If Me.btnConfirmDispatch.Text = "Switch to Dispatch Sales Toolbar" Then
            Me.btnConfirmDispatch.Text = "Switch to Confirming Toolbar"
            Me.btnConfirmDispatch.Image = Me.ilToolStripIcons.Images(15)
        Else
            Me.btnConfirmDispatch.Text = "Switch to Dispatch Sales Toolbar"
            Me.btnConfirmDispatch.Image = Me.ilToolStripIcons.Images(6)
        End If
        Tool_Bar_Config(Me.btnConfirming)
    End Sub

    Private Sub btnSalesResult_Click(sender As Object, e As EventArgs)
        Dim x As New SubForm_Launcher(sender)
    End Sub

    Private Sub btnEditCust2_Click(sender As Object, e As EventArgs)
        Dim x As New SubForm_Launcher(sender)

    End Sub

    Private Sub btnRemoveFromMemorized_Click(sender As Object, e As EventArgs)
        Try
            Dim cnn2 As SqlConnection = New SqlConnection(STATIC_VARIABLES.Cnn)
            Dim cmdGet1 As SqlCommand
            Dim r2 As SqlDataReader
            cmdGet1 = New SqlCommand("Delete memorizedappts where leadnum = " & "'" & STATIC_VARIABLES.CurrentID & "'" & " and UserLoggedOn = " & "'" & STATIC_VARIABLES.CurrentUser & "'" & " and Form = 'Sales' ", cnn2)
            cmdGet1.CommandType = CommandType.Text
            cnn2.Open()
            r2 = cmdGet1.ExecuteReader(CommandBehavior.CloseConnection)
            r2.Read()
            r2.Close()
            cnn2.Close()
        Catch ex As Exception

        End Try

        btnSales_Click(Me.btnSales, Nothing)
    End Sub

    Private Sub btnUndoConfirm_Click(sender As Object, e As EventArgs)
        Try
            Dim cmdIns As SqlCommand = New SqlCommand("dbo.ConfirmUndo", cnn)
            Dim param1 As SqlParameter = New SqlParameter("@ID", ID)
            cmdIns.CommandType = CommandType.StoredProcedure
            cmdIns.Parameters.Add(param1)
            cnn.Open()
            Dim R1 = cmdIns.ExecuteReader
            R1.Read()
            R1.Close()
            cnn.Close()
            Dim c As New CustomerHistory
            c.SetUp(Me.TScboCustomerHistory)

        Catch ex As Exception

        End Try
        MResult = "Unconfirmed"
        btnConfirming_Click(Me.btnConfirming, Nothing)
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs)
        Try
            If CType(Me.txtApptDate.Text, Date) < Today Then

                Exit Sub
            Else
                Me.btnSpokeWith.Select()
                Me.btnSpokeWith.ShowDropDown()
            End If



            If Me.txtContact2.Text = " " Then
                Me.btnContact1.Select()
            End If
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, Me.Name, Me.Name, "Event", System.Reflection.MethodBase.GetCurrentMethod().Name, "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub btnBoth_Click(sender As Object, e As EventArgs)

        Try

            Dim cnn As SqlConnection = New SqlConnection(STATIC_VARIABLES.Cnn)
            Dim cmdIns As SqlCommand = New SqlCommand("dbo.Confirm", cnn)
            Dim param1 As SqlParameter = New SqlParameter("@ID", ID)
            Dim param2 As SqlParameter = New SqlParameter("@User", STATIC_VARIABLES.CurrentUser)
            Dim param3 As SqlParameter = New SqlParameter("@Spokewith", sender.text)
            cmdIns.CommandType = CommandType.StoredProcedure
            cmdIns.Parameters.Add(param1)
            cmdIns.Parameters.Add(param2)
            cmdIns.Parameters.Add(param3)
            cnn.Open()
            Dim R1 = cmdIns.ExecuteReader
            R1.Read()
            R1.Close()
            cnn.Close()

            Dim c As New CustomerHistory
            c.SetUp(Me.TScboCustomerHistory)
        Catch ex As Exception
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, Me.Name, Me.Name, "Event", System.Reflection.MethodBase.GetCurrentMethod().Name, ID, ex.Message.ToString)
            y = Nothing
        End Try
        MResult = "Confirmed"
        If Me.txtApptDate.Text = Today.ToShortDateString Then
            NR = True
        End If
        btnConfirming_Click(Me.btnConfirming, Nothing)
    End Sub

    Private Sub btnContact1_Click(sender As Object, e As EventArgs)
        Try

            Dim cnn As SqlConnection = New SqlConnection(STATIC_VARIABLES.Cnn)
            Dim cmdIns As SqlCommand = New SqlCommand("dbo.Confirm", cnn)
            Dim param1 As SqlParameter = New SqlParameter("@ID", ID)
            Dim param2 As SqlParameter = New SqlParameter("@User", STATIC_VARIABLES.CurrentUser)
            Dim param3 As SqlParameter = New SqlParameter("@Spokewith", sender.text)
            cmdIns.CommandType = CommandType.StoredProcedure
            cmdIns.Parameters.Add(param1)
            cmdIns.Parameters.Add(param2)
            cmdIns.Parameters.Add(param3)
            cnn.Open()
            Dim R1 = cmdIns.ExecuteReader
            R1.Read()
            R1.Close()
            cnn.Close()

            Dim c As New CustomerHistory
            c.SetUp(Me.TScboCustomerHistory)
        Catch ex As Exception
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, Me.Name, Me.Name, "Event", System.Reflection.MethodBase.GetCurrentMethod().Name, ID, ex.Message.ToString)
            y = Nothing
        End Try
        MResult = "Confirmed"
        If Me.txtApptDate.Text = Today.ToShortDateString Then
            NR = True
        End If
        btnConfirming_Click(Me.btnConfirming, Nothing)
    End Sub

    Private Sub btnContact2_Click(sender As Object, e As EventArgs)
        Try

            Dim cnn As SqlConnection = New SqlConnection(STATIC_VARIABLES.Cnn)
            Dim cmdIns As SqlCommand = New SqlCommand("dbo.Confirm", cnn)
            Dim param1 As SqlParameter = New SqlParameter("@ID", ID)
            Dim param2 As SqlParameter = New SqlParameter("@User", STATIC_VARIABLES.CurrentUser)
            Dim param3 As SqlParameter = New SqlParameter("@Spokewith", sender.text)
            cmdIns.CommandType = CommandType.StoredProcedure
            cmdIns.Parameters.Add(param1)
            cmdIns.Parameters.Add(param2)
            cmdIns.Parameters.Add(param3)
            cnn.Open()
            Dim R1 = cmdIns.ExecuteReader
            R1.Read()
            R1.Close()
            cnn.Close()

            Dim c As New CustomerHistory
            c.SetUp(Me.TScboCustomerHistory)
        Catch ex As Exception
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, Me.Name, Me.Name, "Event", System.Reflection.MethodBase.GetCurrentMethod().Name, ID, ex.Message.ToString)
            y = Nothing
        End Try
        MResult = "Confirmed"
        If Me.txtApptDate.Text = Today.ToShortDateString Then
            NR = True
        End If
        btnConfirming_Click(Me.btnConfirming, Nothing)
    End Sub

    Private Sub btnOther_Click(sender As Object, e As EventArgs)
        Dim i As String = InputBox$("Please Enter The Name of the Person" & vbCr & "You Confirmed This Appt. With.", "Enter ""Other"" Contact")
        If i = "" Then
            MsgBox("You must enter a Name!", MsgBoxStyle.Exclamation, "Name Required!")
            Exit Sub
        End If
        Try

            Dim cnn As SqlConnection = New SqlConnection(STATIC_VARIABLES.Cnn)
            Dim cmdIns As SqlCommand = New SqlCommand("dbo.Confirm", cnn)
            Dim param1 As SqlParameter = New SqlParameter("@ID", ID)
            Dim param2 As SqlParameter = New SqlParameter("@User", STATIC_VARIABLES.CurrentUser)
            Dim param3 As SqlParameter = New SqlParameter("@Spokewith", i)
            cmdIns.CommandType = CommandType.StoredProcedure
            cmdIns.Parameters.Add(param1)
            cmdIns.Parameters.Add(param2)
            cmdIns.Parameters.Add(param3)
            cnn.Open()
            Dim R1 = cmdIns.ExecuteReader
            R1.Read()
            R1.Close()
            cnn.Close()

            Dim c As New CustomerHistory
            c.SetUp(Me.TScboCustomerHistory)
        Catch ex As Exception
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, Me.Name, Me.Name, "Event", System.Reflection.MethodBase.GetCurrentMethod().Name, ID, ex.Message.ToString)
            y = Nothing
        End Try
        MResult = "Confirmed"
        If Me.txtApptDate.Text = Today.ToShortDateString Then
            NR = True
        End If
        btnConfirming_Click(Me.btnConfirming, Nothing)
    End Sub

    Private Sub btnMemorize_Click(sender As Object, e As EventArgs)
        Try
            If Me.ID = "" Then
                MsgBox("You must Select a Record!", MsgBoxStyle.Exclamation, "No Record Selected")
                Exit Sub
            End If

            STATIC_VARIABLES.ActiveChild = Sales
            MemorizeNotes.ShowDialog()
            STATIC_VARIABLES.ActiveChild = Me
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, Me.Name, "FormCode", "Event", "btnMemorize_click", ID, ex.Message.ToString)
            y = Nothing
        End Try
        btnSales_Click(Me.btnSales, Nothing)
    End Sub


    Private Sub btnSMNotes_Click(sender As Object, e As EventArgs)
        Try

            If MResult = "Confirmed" Then
                SendNotesSM.ID = Me.ID
                SendNotesSM.ShowInTaskbar = False
                SendNotesSM.ShowDialog()
            Else
                MsgBox("You can only attach a note to a Confirmed Appointment!", MsgBoxStyle.Exclamation, "Appointment Must be Confirmed")
            End If

        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, Me.Name, Me.Name, "Event", System.Reflection.MethodBase.GetCurrentMethod().Name, Me.ID, ex.Message.ToString)
            y = Nothing
        End Try
    End Sub

    Private Sub btnResultResched_Click(sender As Object, e As EventArgs)
        Try

            Dim x As New SubForm_Launcher(sender)

        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, Me.Name, Me.Name, "Event", System.Reflection.MethodBase.GetCurrentMethod().Name, Me.ID, ex.Message.ToString)
            y = Nothing
        End Try
    End Sub

    Private Sub btnChangeTime_Click(sender As Object, e As EventArgs)
        Dim x As New SubForm_Launcher(sender)

    End Sub

    Private Sub cboRep1_SelectedIndexChanged(sender As Object, e As EventArgs)

        ''Code Add News You Dumbass



        If Me.cboRep1.Text <> "" Then
            Me.cboRep2.Enabled = True
        End If
        If Me.cboRep1.Text <> OrigRep1 And Me.cboRep1.Text <> Me.cboRep2.Text Then
            Me.btnSaveRep.Enabled = True
            Me.btnSaveRep.Select()
        Else
            Me.btnSaveRep.Enabled = False
        End If
    End Sub

    Private Sub btnSaveRep_Click(sender As Object, e As EventArgs)
        Try
            Dim r1 As String
            Dim r2 As String
            If Me.cboRep1.SelectedItem <> Nothing Then
                r1 = Me.cboRep1.Text
            Else
                r1 = ""
            End If
            If Me.cboRep2.SelectedItem <> Nothing Then
                r2 = Me.cboRep2.Text
            Else
                r2 = ""
            End If
            ChangeRep(Me.ID, r1, r2, OrigRep1, OrigRep2)
            If Me.cboRep1.SelectedItem <> Nothing Then
                Me.OrigRep1 = Me.cboRep1.Text
                Me.Rep1 = Me.cboRep1.Text
            Else
                OrigRep1 = ""
                Me.Rep1 = ""
            End If
            If Me.cboRep2.SelectedItem <> Nothing Then
                Me.OrigRep2 = Me.cboRep2.Text
                Me.Rep2 = Me.cboRep2.Text
            Else
                Me.OrigRep2 = ""
                Me.Rep2 = Me.cboRep2.Text
            End If
            If Rep1 <> "" And Rep2 = "" Then
                Me.lblSalesRep.Text = "Sales Rep: " & Rep1
            ElseIf Rep1 = "" And Rep2 <> "" Then
                Me.lblSalesRep.Text = "Sales Rep: " & Rep2
            ElseIf Rep1 <> "" And Rep2 <> "" Then
                Me.lblSalesRep.Text = "Sales Reps: " & Rep1 & " and " & Rep2
            ElseIf Rep1 = "" And Rep2 = "" Then
                Me.lblSalesRep.Text = ""
            End If
            Me.btnSaveRep.Enabled = False
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, Me.Name, Me.Name, "Event", System.Reflection.MethodBase.GetCurrentMethod().Name, Me.ID, ex.Message.ToString)
            y = Nothing
        End Try
    End Sub

    Private Sub cboRep2_SelectedIndexChanged(sender As Object, e As EventArgs)
        If Me.cboRep2.Text <> OrigRep2 And Me.cboRep1.Text <> Me.cboRep2.Text Then
            Me.btnSaveRep.Enabled = True
            Me.btnSaveRep.Select()
        Else
            Me.btnSaveRep.Enabled = False
        End If
    End Sub
    Public Sub ChangeRep(ByVal ID As String, ByVal Rep1 As String, ByVal Rep2 As String, ByVal origRep1 As String, ByVal OrigRep2 As String)
        Try
            Dim Description As String
            If origRep1 = Rep1 And OrigRep2 = "" And Rep2 <> "" Then
                Description = STATIC_VARIABLES.CurrentUser & " paired " & Rep2 & " up with " & Rep1
            ElseIf origRep1 <> "" And origRep1 <> Rep1 And OrigRep2 = "" And Rep2 = "" Then
                Description = STATIC_VARIABLES.CurrentUser & " changed assigned rep from " & origRep1 & " to " & Rep1
            ElseIf origRep1 = "" And OrigRep2 = "" And Rep2 = "" Then
                Description = STATIC_VARIABLES.CurrentUser & " issued Appt. to " & Rep1
            ElseIf origRep1 = "" And OrigRep2 = "" And Rep2 <> "" Then
                Description = STATIC_VARIABLES.CurrentUser & " issued Appt. to " & Rep1 & " and " & Rep2
            ElseIf origRep1 = "" And OrigRep2 = "" And Rep2 <> "" Then
                Description = STATIC_VARIABLES.CurrentUser & " issued Appt. to " & Rep1 & " and " & Rep2
            ElseIf origRep1 <> "" And OrigRep2 <> "" And Rep2 = "" And Rep1 <> origRep1 And OrigRep2 <> Rep1 Then
                Description = STATIC_VARIABLES.CurrentUser & " changed assigned rep from " & origRep1 & " and " & OrigRep2 & " to " & Rep1
            ElseIf origRep1 = Rep1 And OrigRep2 <> Rep2 And Rep2 <> "" Then
                Description = STATIC_VARIABLES.CurrentUser & " changed Rep 2 from " & OrigRep2 & " to " & Rep2 & ", leaving " & Rep1 & " and " & Rep2 & " paired up"
            ElseIf origRep1 <> Rep1 And OrigRep2 <> "" And OrigRep2 <> Rep2 And Rep2 <> "" And origRep1 <> Rep2 And OrigRep2 <> Rep1 Then
                Description = STATIC_VARIABLES.CurrentUser & " changed assigned pair from " & origRep1 & " and " & OrigRep2 & " to " & Rep1 & " and " & Rep2
            ElseIf origRep1 <> Rep1 And OrigRep2 <> "" And OrigRep2 = Rep2 And Rep2 <> "" Then
                Description = STATIC_VARIABLES.CurrentUser & " changed Rep 1 from " & origRep1 & " to " & Rep1 & ", leaving " & Rep1 & " and " & Rep2 & " paired up"
            ElseIf origRep1 <> Rep1 And OrigRep2 = "" And Rep2 <> "" Then
                Description = STATIC_VARIABLES.CurrentUser & " changed assigned rep from " & origRep1 & ", to pair: " & Rep1 & " and " & Rep2
            ElseIf origRep1 = Rep2 And OrigRep2 = Rep1 Then
                Description = STATIC_VARIABLES.CurrentUser & " changed pair around, making " & Rep1 & " the lead rep and " & Rep2 & " the secondary rep"
            ElseIf origRep1 <> Rep1 And OrigRep2 <> "" And OrigRep2 <> Rep2 And Rep2 <> "" And origRep1 <> Rep2 And OrigRep2 = Rep1 Then
                Description = STATIC_VARIABLES.CurrentUser & " changed assigned pair from " & origRep1 & " and " & OrigRep2 & " to " & Rep1 & " and " & Rep2
            ElseIf origRep1 = Rep1 And OrigRep2 <> "" And Rep2 = "" Then
                Description = STATIC_VARIABLES.CurrentUser & " removed " & OrigRep2 & " from Appt., making " & origRep1 & " the sole Sales Rep"
            ElseIf origRep1 <> "" And OrigRep2 <> "" And Rep2 = "" And Rep1 <> origRep1 And OrigRep2 = Rep1 Then
                Description = STATIC_VARIABLES.CurrentUser & " removed " & origRep1 & " from Appt., moving " & OrigRep2 & " up to Rep 1 as the sole Sales Rep"
            End If



            Dim cnn As SqlConnection = New SqlConnection(STATIC_VARIABLES.Cnn)
            Dim cmdChange As SqlCommand
            cmdChange = New SqlCommand("dbo.SalesRepChanged", cnn)
            Dim param1 As SqlParameter = New SqlParameter("@ID", ID)
            Dim param2 As SqlParameter = New SqlParameter("@User", STATIC_VARIABLES.CurrentUser)
            Dim param3 As SqlParameter = New SqlParameter("@Description", Description)
            Dim param4 As SqlParameter = New SqlParameter("@Rep1", Rep1)
            Dim param5 As SqlParameter = New SqlParameter("@Rep2", Rep2)
            cmdChange.CommandType = CommandType.StoredProcedure
            cmdChange.Parameters.Add(param1)
            cmdChange.Parameters.Add(param2)
            cmdChange.Parameters.Add(param3)
            cmdChange.Parameters.Add(param4)
            cmdChange.Parameters.Add(param5)

            cnn.Open()
            Dim R1 = cmdChange.ExecuteReader
            R1.Read()
            R1.Close()
            cnn.Close()

            Dim c As New CustomerHistory
            c.SetUp(Me.TScboCustomerHistory)
        Catch ex As Exception
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, Me.Name, Me.Name, "Event", System.Reflection.MethodBase.GetCurrentMethod().Name, Me.ID, ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub btnEmailCust_Click(sender As Object, e As EventArgs)
        Dim emailAddress As String = Me.lnkEmail.Text
        If Len(emailAddress) <= 0 Then
            MsgBox("This customer doesn't have an email address to send mail to.", MsgBoxStyle.Exclamation, "No Email Address For Customer")
            Exit Sub
        ElseIf Len(emailAddress) >= 1 Then
            'frmEmailTemplateChoice.Show()
        End If
        Dim lnk As LinkLabel = sender
        frmLinkSendEmail.MdiParent = Main
        frmLinkSendEmail.RecID = STATIC_VARIABLES.CurrentID
        frmLinkSendEmail.Cust_Email = lnk.Text
        frmLinkSendEmail.Show()
        frmLinkSendEmail.BringToFront()
    End Sub

    Private Sub lnkEmail_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Dim lnk As LinkLabel = sender
        Dim emailAddress As String = lnk.Text
        If Len(emailAddress) <= 0 Then
            MsgBox("This customer doesn't have an email address to send mail to.", MsgBoxStyle.Exclamation, "No Email Address For Customer")
            Exit Sub
        End If

        frmLinkSendEmail.MdiParent = Main
        frmLinkSendEmail.RecID = STATIC_VARIABLES.CurrentID
        frmLinkSendEmail.Cust_Email = lnk.Text
        frmLinkSendEmail.Show()
        frmLinkSendEmail.BringToFront()
    End Sub

    Private Sub btnEmailRep_Click(sender As Object, e As EventArgs)
        Try
            If Rep1 = "" And Rep2 = "" Then
                MsgBox("You must assign this Appointment to Email!", MsgBoxStyle.Exclamation, "No Sales Rep Assigned")
                Exit Sub
            End If
            If Rep1 <> "" Then
                EmailSingleRecord(Rep1)
            End If
            If Rep2 <> "" Then
                EmailSingleRecord(Rep2)
            End If

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, Me.Name, "FormCode", "Event", System.Reflection.MethodBase.GetCurrentMethod().Name, Me.ID, ex.Message.ToString)
            y = Nothing
        End Try
    End Sub
    Private Sub EmailSingleRecord(Rep As String)
        Try
            Dim z As New EmailIssuedLeads
            Dim emlBody As String = ""

            Dim y As Panel
            Dim leadNum As String = Me.ID
            Dim strRep() = Split(Rep, " ", -1, Microsoft.VisualBasic.CompareMethod.Text)
            Dim fname As String = strRep(0)
            Dim lname As String = strRep(1)
            Dim canGetEmail As Boolean = z.CanRepGetEmail(fname, lname)
            If canGetEmail = False Then
                MsgBox(fname & " " & lname & " cannot recieve Email.", MsgBoxStyle.Exclamation, "Can't Recieve Email")
                Exit Sub
            End If
            Dim emailAddy As String = z.GetRepEmailAddress(fname, lname)
            Dim exclusionSet As EmailIssuedLeads.Exclusions = z.GetExclusions()
            STATIC_VARIABLES.CurrentExclusionSet = exclusionSet
            'MsgBox(fname & " | " & lname & vbCrLf & "Email ? : " & canGetEmail & vbCrLf & "Email Address: " & emailAddy & vbCrLf & "Lead Num: " & leadNum & vbCrLf & vbCrLf & "Exclusions :>" & vbCrLf & "Generated: " & exclusionSet.Generated & vbCrLf & "Marketer: " & exclusionSet.Marketer & vbCrLf & "PLS: " & exclusionSet.PLS & " | SLS: " & exclusionSet.SLS & vbCrLf & "LastMResult:" & exclusionSet.LastMResult & vbCrLf & "Phone: " & exclusionSet.Phone, MsgBoxStyle.Information, "Debug Info:")
            '' check here to make sure not called an cancelled
            '' 8-26-2014
            If z.IsCalledAndCancelled(leadNum, Me.txtApptDate.Text) = False Then
                MsgBox("This lead was called and cancelled." & vbCrLf & "Please check your marketing results and try again.", MsgBoxStyle.Exclamation, "Lead Called and Cancelled")
                Exit Sub
            End If
            emlBody = z.ConstructMessageWithExclusions(fname, lname, leadNum, exclusionSet, emailAddy)
            'MsgBox(emlBody)
            '' uncomment here to actually send
            z.EMAIL_SINGLE_MarkupEmail_WITH_EXCLUSIONS(fname, lname, leadNum, exclusionSet, emailAddy, emlBody, "Record ID: " & leadNum.ToString)

            ' MsgBox("Successfully emailed Appointment Information to " & Rep & ".", MsgBoxStyle.Exclamation, "Email Sent")

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, Me.Name, "FormCode", "Sub", "EmailSingleRecord()", "0", ex.Message.ToString)
            y = Nothing
            MsgBox("Something went wrong emailing Appointment Information to " & Rep & ".", MsgBoxStyle.Critical, "Email Error")
        End Try


    End Sub

    Private Sub btnConfirmationEmail_Click(sender As Object, e As EventArgs)
        ''comeback
    End Sub
    Public Sub Update()
        Dim cmdGet As SqlCommand = New SqlCommand("dbo.GetCustomerINFO", cnn)

        Dim param1 As SqlParameter = New SqlParameter("@ID", ID)
        cmdGet.CommandType = CommandType.StoredProcedure
        cmdGet.Parameters.Add(param1)
        Try
            cnn.Open()


            Dim r1 As SqlDataReader
            r1 = cmdGet.ExecuteReader(CommandBehavior.CloseConnection)
            While r1.Read
                Me.txtContact1.Text = r1.Item(5) & " " & r1.Item(6)
                Me.txtContact2.Text = r1.Item(7) & " " & r1.Item(8)
                Me.txtAddress.Text = r1.Item(9) & " " & vbCrLf & r1.Item(10) & ", " & r1.Item(11) & " " & r1.Item(12)


                If r1.Item(7) = "" Then
                    Me.txtWorkHours.Text = r1.Item(5) & ": " & r1.Item(19)
                Else
                    Me.txtWorkHours.Text = r1.Item(5) & ": " & r1.Item(19) & vbNewLine & r1.Item(7) & ": " & r1.Item(20)
                End If
                Me.txtHousePhone.Text = r1.Item(13)
                Me.txtaltphone1.Text = r1.Item(14)
                Me.txtaltphone2.Text = r1.Item(16)
                Me.txtAlt1Type.Text = r1.Item(15)
                Me.txtAlt2Type.Text = r1.Item(17)
                Me.lnkEmail.Text = r1.Item(52)
                Dim d
                d = Split(r1.Item(29), " ", 2)
                Trim(d(0))

                Me.txtApptDate.Text = d(0)
                Me.txtApptDay.Text = r1.Item(30)
                Dim t = Split(r1.Item(31), " ", 2)
                Dim u = t(1)
                Dim u2 As String
                Dim u3 As String
                If u.Length = 11 Then
                    u2 = Microsoft.VisualBasic.Left(u, 5)
                    u3 = Microsoft.VisualBasic.Right(u, 3)
                    u = u2 & u3
                Else
                    u2 = Microsoft.VisualBasic.Left(u, 4)
                    u3 = Microsoft.VisualBasic.Right(u, 3)
                    u = u2 & u3
                End If
                Me.txtApptTime.Text = u
                Me.txtProducts.Text = r1.Item(21) & vbCrLf & r1.Item(22) & vbCrLf & r1.Item(23)
                Me.txtColor.Text = r1.Item(24)
                Me.txtQty.Text = r1.Item(25)
                Me.txtYrBuilt.Text = r1.Item(27)
                Me.txtYrsOwned.Text = r1.Item(26)
                Me.txtHomeValue.Text = r1.Item(28)
                Me.rtbSpecialInstructions.Text = r1.Item(32)
                Try
                    MResult = r1.Item("MarketingResults")
                Catch ex As Exception
                    MResult = ""
                End Try
                If r1.Item("DoNotCall") = True Or MResult = "Kill" Then
                    Me.btnSetAppt.Enabled = False
                    Me.btnSetAppt.ToolTipText = "Cannot Set Appt. You must undo ""Do Not Call"" or ""Kill"
                End If
                If r1.Item("DoNotCall") = True And r1.Item("DoNotMail") = True Then
                    Me.btnDoNotCall.Text = "Undo Do Not Call"
                    Me.btnDoNotCallOrMail.Text = "Undo Do Not Call Or Mail"
                    Me.btnDoNotMail.Text = "Undo Do Not Mail"
                End If
                If r1.Item("DoNotMail") = True And r1.Item("DoNotCall") = False Then
                    Me.btnDoNotMail.Text = "Undo Do Not Mail"
                End If
                If r1.Item("DoNotMail") = False And r1.Item("DoNotCall") = True Then
                    Me.btnDoNotCall.Text = "Undo Do Not Call"
                End If
                If MResult = "Kill" Then
                    Me.btnKill.Text = "Undo Kill"
                End If
                'MsgBox(r1.Item("DoNotCall").ToString & " | " & r1.Item("DoNotMail").ToString & " | " & r1.Item("MarketingResults"))
                Try
                    Rep1 = r1.Item(36)
                    OrigRep1 = r1.Item(36)
                Catch ex As Exception
                    Rep1 = ""
                    OrigRep1 = ""
                End Try
                Try
                    Rep2 = r1.Item(37)
                    OrigRep2 = r1.Item(37)
                Catch ex As Exception
                    Rep2 = ""
                    OrigRep2 = ""
                End Try

                NR = r1.Item("NeedsSaleResult")
            End While
            r1.Close()
            cnn.Close()

        Catch ex As Exception
            cnn.Close()
            'Me.PullCustomerINFO(ID)
            MsgBox("Lost Network Connection! Pull Customer Info" & ex.ToString, MsgBoxStyle.Critical, "Server not Available")
        End Try
        Dim c As New CustomerHistory
        c.SetUp(Me.TScboCustomerHistory)
    End Sub

    Private Sub btnSetAppt2_Click(sender As Object, e As EventArgs)
        Dim x As New SubForm_Launcher(sender)
    End Sub

    Private Sub btnEditSPI_Click(sender As Object, e As EventArgs)

        Dim x As New SubForm_Launcher(sender)

    End Sub

    Private Sub btnMoveAppt_Click(sender As Object, e As EventArgs)
        Dim x As New SubForm_Launcher(sender)
    End Sub

    Private Sub btnPrintInfo_Click(sender As Object, e As EventArgs)
        Try
            Dim x As New printToPrinterCustInfoSheet(STATIC_VARIABLES.CurrentID)
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, Me.Name, "FormCode", "Event", "btnPrintInfo_Click", "0", ex.Message.ToString)
            y = Nothing
        End Try
    End Sub

    Private Sub btnPrintAppt_Click(sender As Object, e As EventArgs)
        Try
            Dim x As New printToPrinterApptSheet(STATIC_VARIABLES.CurrentID)
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "Sales", "FormCode", "Event", "btnPrintApptSheet_click", "0", ex.Message.ToString)
            y = Nothing
        End Try
    End Sub

    Private Sub btnConfirm_MouseDown(sender As Object, e As MouseEventArgs)
        If CType(Me.txtApptDate.Text, Date) < Today Then
            Me.btnConfirm.HideDropDown()
            MsgBox("Appointment Date Must be for Today or Future!", MsgBoxStyle.Exclamation, "Cannot Confirm Appt.")
            Exit Sub
        End If
    End Sub
End Class