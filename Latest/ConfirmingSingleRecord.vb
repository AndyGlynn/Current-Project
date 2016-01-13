
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
        STATIC_VARIABLES.CurrentID = ID

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


        Dim cmdGet As SqlCommand = New SqlCommand("dbo.GetCustomerINFO", Cnn)

        Dim param1 As SqlParameter = New SqlParameter("@ID", ID)
        cmdGet.CommandType = CommandType.StoredProcedure
        cmdGet.Parameters.Add(param1)
        Try



            Cnn.Open()


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
            Cnn.Close()

        Catch ex As Exception
            cnn.Close()
            'Me.PullCustomerINFO(ID)
            MsgBox("Lost Network Connection! Pull Customer Info" & ex.ToString, MsgBoxStyle.Critical, "Server not Available")
        End Try
        Dim c As New CustomerHistory
        c.SetUp(Me, ID, Me.TScboCustomerHistory)
        Dim k As Form = Kill
        Kill.Contact1 = Me.txtContact1.Text
        Kill.Contact2 = Me.txtContact2.Text
        Kill.frm = "ConfirmingSingleRecord"
        Kill.ID = ID

        Kill.ShowInTaskbar = False
        Kill.ShowDialog()

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

    Private Sub lnkEmail_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkEmail.LinkClicked
        frmLinkSendEmail.Cust_Email = Me.lnkEmail.Text
        frmLinkSendEmail.RecID = STATIC_VARIABLES.CurrentID
        frmLinkSendEmail.Show()
        frmLinkSendEmail.BringToFront()
    End Sub

    Private Sub FinancingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FinancingToolStripMenuItem.Click
        FinancingDepartment.RecID = Me.ID
        FinancingDepartment.Show()
        FinancingDepartment.BringToFront()
    End Sub

    Private Sub ConfirmingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfirmingToolStripMenuItem.Click
        STATIC_VARIABLES.CurrentID = Me.ID
        Dim y As convertLeadToStruct.EnterLead_Record
        Dim z As New convertLeadToStruct
        y = z.ConvertToStructure(Me.ID, False)
        Dim dt As Date = CType(y.ApptDate, Date)
        y = Nothing
        Confirming.MdiParent = Main
        Confirming.Show()
        Confirming.BringToFront()
        Confirming.dpConfirming.Value = dt
        MsgBox("The date picker value has been changed in order to show you this lead.", MsgBoxStyle.Information, "Date Changed.")
    End Sub

    Private Sub InstallationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstallationToolStripMenuItem.Click

        STATIC_VARIABLES.CurrentID = Me.ID
        Installation.RecID = STATIC_VARIABLES.CurrentID
        Installation.MdiParent = Main
        Installation.Show()
        Installation.BringToFront()

    End Sub

    Private Sub SalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesToolStripMenuItem.Click
        STATIC_VARIABLES.CurrentID = Me.ID
        Sales.ID = STATIC_VARIABLES.CurrentID
        Sales.MdiParent = Main
        Sales.Show()
        Sales.BringToFront()
        Dim y As convertLeadToStruct.EnterLead_Record
        Dim z As New convertLeadToStruct
        y = z.ConvertToStructure(Me.ID, False)
        Dim dt As Date = CType(y.ApptDate, Date)
        y = Nothing
        Sales.dtp1CustomerList.Value = dt
        Sales.dtp2CustomerList.Value = dt
        Sales.tbMain.SelectedIndex = 1
        MsgBox("The date picker value has been changed in order to show you this lead.", MsgBoxStyle.Information, "Date Changed.")

    End Sub

    Private Sub RecoveryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecoveryToolStripMenuItem.Click
        STATIC_VARIABLES.CurrentID = Me.ID
        Recovery.RecID = STATIC_VARIABLES.CurrentID
        Recovery.MdiParent = Main
        Recovery.Show()
        Recovery.BringToFront()
    End Sub

    Private Sub WarmCallingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WarmCallingToolStripMenuItem.Click
        STATIC_VARIABLES.CurrentID = Me.ID
        WCaller.ID = STATIC_VARIABLES.CurrentID
        WCaller.MdiParent = Main
        WCaller.Show()
        WCaller.BringToFront()
        MsgBox("Warm calling was opened from 'Find'. Some Of your date values / lists may be effected by this.", MsgBoxStyle.Information, "Opened From Find Lead")


    End Sub

    Private Sub MarketingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarketingToolStripMenuItem.Click
        STATIC_VARIABLES.CurrentID = Me.ID
        MarketingManager.RecID = STATIC_VARIABLES.CurrentID
        MarketingManager.MdiParent = Main
        MarketingManager.Show()
        MarketingManager.BringToFront()
        Dim y As convertLeadToStruct.EnterLead_Record
        Dim z As New convertLeadToStruct
        y = z.ConvertToStructure(Me.ID, False)
        Dim dt As Date = CType(y.ApptDate, Date)
        y = Nothing
        MarketingManager.tbMain.SelectedIndex = 1
        MsgBox("This whole form needs to be built. Demonstration purposes only.", MsgBoxStyle.Information, "Whole Form")
        'MsgBox("The date picker value has been changed in order to show you this lead.", MsgBoxStyle.Information, "Date Changed.")

    End Sub

    Private Sub ColdCallingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColdCallingToolStripMenuItem.Click
        STATIC_VARIABLES.CurrentID = Me.ID
        ColdCalling.recID = STATIC_VARIABLES.CurrentID
        ColdCalling.MdiParent = Main
        ColdCalling.Show()
        ColdCalling.BringToFront()
    End Sub
End Class