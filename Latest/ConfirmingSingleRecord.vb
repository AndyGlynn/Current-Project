
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System


Public Class ConfirmingSingleRecord



    Private DoNotCall
    Private DoNotMail
    Private DoNotCallMail
    'Private Kill1


    Public ID As String
    Public cnn As SqlConnection = New SqlConnection(STATIC_VARIABLES.Cnn)



    Private Sub calledcancelled_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calledcancelled.Click
        Dim s = Split(Me.txtContact1.Text, " ")
        Dim c1 = s(0)
        Dim s2 = Split(Me.txtContact2.Text, " ")
        Dim c2 = s2(0)
        CandCNotes.ID = ID
        CandCNotes.Contact1 = c1
        CandCNotes.Contact2 = c2
        CandCNotes.OrigApptDate = Me.txtApptDate.Text
        CandCNotes.OrigApptTime = Me.txtApptTime.Text
        CandCNotes.ShowInTaskbar = False
        CandCNotes.ShowDialog()
        Dim c As New CustomerHistory
        c.SetUp(Me, ID, Me.TScboCustomerHistory)
    End Sub

    Private Sub btnLogCall_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogCall.ButtonClick

        LogPhoneCall.frm = Me

        LogPhoneCall.ID = ID

        LogPhoneCall.Contact1 = Me.txtContact1.Text
        LogPhoneCall.Contact2 = Me.txtContact2.Text
        LogPhoneCall.ShowInTaskbar = False
        LogPhoneCall.ShowDialog()
    End Sub

    Private Sub ConfirmingSingleRecord_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        STATIC_VARIABLES.CurrentID = ""
        Me.Dispose()
    End Sub

    Private Sub ConfirmingSingleRecord_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        'ID = STATIC_VARIABLES.CurrentID
    End Sub



    Private Sub ConfirmingSingleRecord_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
  

        ID = STATIC_VARIABLES.CurrentID


        Me.MdiParent = Main
        Me.TScboCustomerHistory.Text = "All"



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
                If r1.Item("DoNotCall") = True Or r1.Item("MarketingResults") = "Kill" Then
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
                If r1.Item("MarketingResults") = "Kill" Then
                    Me.btnKill.Text = "Undo Kill"
                End If
                'MsgBox(r1.Item("DoNotCall").ToString & " | " & r1.Item("DoNotMail").ToString & " | " & r1.Item("MarketingResults"))
            End While
            r1.Close()
            cnn.Close()

        Catch ex As Exception
            cnn.Close()
            'Me.PullCustomerINFO(ID)
            MsgBox("Lost Network Connection! Pull Customer Info" & ex.ToString, MsgBoxStyle.Critical, "Server not Available")
        End Try
        Dim c As New CustomerHistory
        c.SetUp(Me, ID, Me.TScboCustomerHistory)
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
        Me.BringToFront()
        Me.Activate()

    End Sub

    Public Sub btnSetAppt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetAppt.Click
        SetAppt.frm = Me

        SetAppt.ID = ID



        Dim s = Split(Me.txtContact1.Text, " ")
        Dim s2 = Split(Me.txtContact2.Text, " ")
        SetAppt.Contact1 = s(0)
        SetAppt.Contact2 = s2(0)
        SetAppt.OrigApptDate = Me.txtApptDate.Text
        SetAppt.OrigApptTime = Me.txtApptTime.Text
        SetAppt.ShowInTaskbar = False
        SetAppt.ShowDialog()
        Dim c As New CustomerHistory
        c.SetUp(Me, ID, Me.TScboCustomerHistory)
    End Sub



    Private Sub btnDoNotCall_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDoNotCall.Click
        Dim c As New DoNotCallOrMail
        c.DoNot(ID, sender.text.ToString)
        Dim d As New CustomerHistory
        d.SetUp(Me, ID, Me.TScboCustomerHistory)
        Me.Manage_Buttons()



    End Sub

    Private Sub btnDoNotCallOrMail_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDoNotCallOrMail.Click
        Dim c As New DoNotCallOrMail
        c.DoNot(ID, sender.text.ToString)
        Dim d As New CustomerHistory
        d.SetUp(Me, ID, Me.TScboCustomerHistory)
        Me.Manage_Buttons()

    End Sub

    Private Sub btnDoNotMail_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDoNotMail.Click
        Dim x As New DoNotCallOrMail
        x.DoNot(ID, sender.text.ToString)
        Dim d As New CustomerHistory
        d.SetUp(Me, ID, Me.TScboCustomerHistory)
        Me.Manage_Buttons()
    End Sub

    Private Sub btnEditCustomer_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEditCustomer.Click
        EditCustomerInfo.ShowInTaskbar = False
        EditCustomerInfo.Show()

    End Sub

    Private Sub TScboCustomerHistory_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TScboCustomerHistory.SelectedIndexChanged
        Dim c As New CustomerHistory
        c.SetUp(Me, ID, Me.TScboCustomerHistory)
    End Sub

    Private Sub rtbSpecialInstructions_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles rtbSpecialInstructions.LostFocus

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
    Private Sub Manage_Buttons()
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
            ElseIf r1.Item(0) = False And r1.Item(1) = True Then
                Me.btnDoNotCall.Text = "Mark as Do Not Call"
                Me.btnDoNotMail.Text = "Undo Do Not Mail"
                Me.btnDoNotCallOrMail.Text = "Mark as Do Not Call Or Mail"
            ElseIf r1.Item(0) = False And r1.Item(1) = False Then
                Me.btnDoNotCall.Text = "Mark as Do Not Call"
                Me.btnDoNotMail.Text = "Mark as Do Not Mail"
                Me.btnDoNotCallOrMail.Text = "Mark as Do Not Call Or Mail"
            ElseIf r1.Item(0) = True And r1.Item(1) = False Then
                Me.btnDoNotCall.Text = "Undo Do Not Call"
                Me.btnDoNotMail.Text = "Mark as Do Not Mail"
                Me.btnDoNotCallOrMail.Text = "Mark as Do Not Call Or Mail"
            End If
            If r1.Item(0) = True Or r1.Item(2) = "Kill" Then
                Me.btnSetAppt.Enabled = False
                Me.btnSetAppt.ToolTipText = "Cannot Set Appt. You must undo ""Do Not Call"" or ""Kill"
            ElseIf r1.Item(0) = False And r1.Item(2) <> "Kill" Then
                Me.btnSetAppt.Enabled = True
                Me.btnSetAppt.ToolTipText = ""
            End If
            If r1.Item(2) = "Kill" Then
                Me.btnKill.Text = "Undo Kill"
            Else
                Me.btnKill.Text = "Kill"
            End If
        End While
        r1.Close()
        cnn.Close()
    End Sub
    Private Sub btnKill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKill.Click
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
            c.SetUp(Me, ID, Me.TScboCustomerHistory)
            Exit Sub
        End If

        Dim d As New open_kill



        c.SetUp(Me, ID, Me.TScboCustomerHistory)
        Me.Manage_Buttons()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form2.Show()

    End Sub


    Private Sub btnNone_Click(sender As Object, e As EventArgs) Handles btnNone.Click
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
        Me.btnNone.Checked = True
        Tool_Bar_Config(sender)
    End Sub

    Private Sub btnSales_Click(sender As Object, e As EventArgs) Handles btnSales.Click
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
        Me.btnSales.Checked = True
        Tool_Bar_Config(sender)
    End Sub
    Private Sub Tool_Bar_Config(sender As Object)
        Me.tsSingleForm.Items.Clear()
        Select Case sender.Name
            Case Is = "btnSales"
                Me.tsSingleForm.Items.Add(Me.btnSalesResult)
                Me.btnSalesResult.DropDownItems.Add(Me.btnMemorize)
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
            Case Is = "btnNone", "btnColdCall", "btnRecovery", "btnMarketManager", "btnInstall", "btnAdmin", "btnFinance", "btnPC"
                Me.tsSingleForm.Items.Add(Me.btnSetAppt)
                Me.tsSingleForm.Items.Add(Me.btnEditCustomer)
                Me.tsSingleForm.Items.Add(Me.btnChangeStatus)
                Me.tsSingleForm.Items.Add(Me.btnPrintInfo)
                Me.btnPrintInfo.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
            Case Is = "btnConfirming"
                If Me.btnConfirmDispatch.Text = "Switch to Dispatch Sales Toolbar" Then
                    Me.tsSingleForm.Items.Add(Me.btnConfirmDispatch)
                    Me.tsSingleForm.Items.Add(Me.ToolStripSeparator6)
                    Me.tsSingleForm.Items.Add(Me.btnConfirm)
                    Me.btnConfirm.DropDownItems.Add(Me.btnSpokeWith)
                    Me.btnSpokeWith.DropDownItems.Add(Me.btnContact1)
                    If Me.txtContact1.Text <> "" Or Me.txtContact1.Text <> " " Then
                        Dim s = Split(Me.txtContact1.Text, " ")
                        Me.btnContact1.Text = s(0)
                    End If
                    If Me.txtContact2.Text <> "" Or Me.txtContact2.Text <> " " Then
                        Dim s = Split(Me.txtContact2.Text, " ")
                        Me.btnContact2.Text = s(0)
                        Me.btnBoth.Text = Me.btnContact1.Text & " and " & Me.btnContact2.Text
                        Me.btnSpokeWith.DropDownItems.Add(Me.btnContact2)
                        Me.btnSpokeWith.DropDownItems.Add(Me.btnBoth)
                    End If
                    Me.btnSpokeWith.DropDownItems.Add(Me.btnOther)
                    Me.btnConfirm.DropDownItems.Add(Me.ToolStripSeparator2)
                    Me.btnConfirm.DropDownItems.Add(Me.btnSMNotes)
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
                    Me.btnCustomerTools.DropDownItems.Add(Me.ToolStripSeparator5)
                    Me.btnCustomerTools.DropDownItems.Add(Me.btnAppt)
                    Me.btnAppt.DropDownItems.Add(Me.btnSetAppt2)
                    Me.btnAppt.DropDownItems.Add(Me.btnMoveAppt)
                    Me.tsSingleForm.Items.Add(Me.btnEditSales)
                    Me.btnEditSales.DropDownItems.Add(Me.btnChangeRep)
                    Me.tsSingleForm.Items.Add(Me.btnPrint)
                    Me.btnPrint.DropDownItems.Clear()
                    Me.btnPrint.DropDownItems.Add(Me.btnPrintAppt)
                    Me.btnPrint.DropDownItems.Add(Me.btnPrintInfo)
                    Me.btnPrintInfo.DisplayStyle = ToolStripItemDisplayStyle.Text
                    Me.tsSingleForm.Items.Add(Me.lblRep)
                    Me.tsSingleForm.Items.Add(Me.lblSalesRep)

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

  
    Private Sub btnColdCall_Click(sender As Object, e As EventArgs) Handles btnColdCall.Click
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

        Me.btnColdCall.Checked = True
        Tool_Bar_Config(sender)
    End Sub

    Private Sub btnWarmCall_Click(sender As Object, e As EventArgs) Handles btnWarmCall.Click
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

        Me.btnWarmCall.Checked = True
        Tool_Bar_Config(sender)
    End Sub

    Private Sub btnPC_Click(sender As Object, e As EventArgs) Handles btnPC.Click
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

        Me.btnPC.Checked = True
        Tool_Bar_Config(sender)
    End Sub

    Private Sub btnRecovery_Click(sender As Object, e As EventArgs) Handles btnRecovery.Click
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

        Me.btnRecovery.Checked = True
        Tool_Bar_Config(sender)
    End Sub

    Private Sub btnConfirming_Click(sender As Object, e As EventArgs) Handles btnConfirming.Click
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
        Me.btnConfirming.Checked = True
        Tool_Bar_Config(sender)
    End Sub

    Private Sub btnMarketManager_Click(sender As Object, e As EventArgs) Handles btnMarketManager.Click
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
        Me.btnMarketManager.Checked = True
        Tool_Bar_Config(sender)
    End Sub

    Private Sub btnInstall_Click(sender As Object, e As EventArgs) Handles btnInstall.Click
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
        Me.btnInstall.Checked = True
        Tool_Bar_Config(sender)
    End Sub

    Private Sub btnFinance_Click(sender As Object, e As EventArgs) Handles btnFinance.Click
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

        Me.btnFinance.Checked = True
        Tool_Bar_Config(sender)
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
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

        Me.btnAdmin.Checked = True
        Tool_Bar_Config(sender)
    End Sub

    Private Sub btnConfirmDispatch_Click(sender As Object, e As EventArgs) Handles btnConfirmDispatch.Click
        If Me.btnConfirmDispatch.Text = "Switch to Dispatch Sales Toolbar" Then
            Me.btnConfirmDispatch.Text = "Switch to Confirming Toolbar"
            Tool_Bar_Config(Me.btnConfirming)
        Else
            Me.btnConfirmDispatch.Text = "Switch to Dispatch Sales Toolbar"
            Tool_Bar_Config(Me.btnConfirming)
        End If
    End Sub

    Private Sub btnSalesResult_Click(sender As Object, e As EventArgs) Handles btnSalesResult.Click
        SDResult.ID = Me.ID
        SDResult.Frm = Me
        SDResult.ShowDialog()
    End Sub
End Class