Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System


Public Class frmRList
    Public LoadComplete As Boolean = False
    Private Sub RList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cboDateRange.Items.AddRange(New Object() {"All", "Today", "Yesterday", "This Week", "This Week - to date", "This Month", "This Month - to date", "This Year", "This Year - to date", "Next Week", "Next Month", "Last Week", "Last Week - to date", "Last Month", "Last Month - to date", "Last Year", "Last Year - to date", "Custom"})
        Dim mpt As New MAPPOINT_LOGIC_V2
        Dim arStates As ArrayList = mpt.Get_Unique_States
        For Each xx As Object In arStates
            Me.cboStateSelection.Items.Add(xx.ToString)
        Next
        '' make sure lbl and cbo are invisible at launch 
        '' 
        Me.lblStateSelect.Visible = False
        Me.cboStateSelection.Visible = False
        'For x As Integer = 0 To Me.chlstProducts.Items.Count - 1
        '    Me.chlstProducts.SetItemChecked(x, True)
        'Next

        Me.cboDateRange.SelectedItem = Nothing


        Me.btnCheckRehash_Click(Nothing, Nothing)

        Me.chWeekdays.Checked = False

        Me.txtFrom.Tag = Me.dpFrom.Value.ToShortDateString
        Me.txtTo.Tag = Me.dpTo.Value.ToShortDateString
        Me.txtTimeFrom.Tag = Me.tpFrom.Value.ToShortTimeString
        Me.txtTimeTo.Tag = Me.tpTo.Value.ToShortTimeString
        Me.LoadComplete = True
    End Sub
    Private Sub cboDateRange_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDateRange.SelectedIndexChanged
        If Me.cboDateRange.Text <> "Custom" Then
            If Me.cboDateRange.Text = "All" Then
                Me.dpFrom.Value = "1/1/1900"
                Me.dpTo.Value = "1/1/2100"
                Me.txtFrom.Visible = True
                Me.txtTo.Visible = True
                Exit Sub
            End If

            Me.txtFrom.Visible = False
            Me.txtTo.Visible = False
            Dim d As New DTPManipulation(Me.cboDateRange.Text)
            Me.dpFrom.Text = d.retDateFrom
            Me.dpTo.Text = d.retDateTo

        End If
    End Sub
    Private Sub btnCheckRehash_Click(sender As Object, e As EventArgs) Handles btnCheckRehash.Click

        For x As Integer = 0 To Me.chlstRehash.Items.Count - 1
            Me.chlstRehash.SetItemChecked(x, True)
        Next

    End Sub

    Private Sub btnUncheckRehash_Click(sender As Object, e As EventArgs) Handles btnUncheckRehash.Click

        For x As Integer = 0 To Me.chlstRehash.Items.Count - 1
            Me.chlstRehash.SetItemChecked(x, False)
        Next

    End Sub
    Private Sub txtFrom_GotFocus(sender As Object, e As EventArgs) Handles txtFrom.GotFocus
        Me.dpFrom.Focus()
    End Sub

    Private Sub txtTo_GotFocus(sender As Object, e As EventArgs) Handles txtTo.GotFocus
        Me.dpTo.Focus()
    End Sub
    Private Sub dpFrom_GotFocus(sender As Object, e As EventArgs) Handles dpFrom.GotFocus

        If Me.LoadComplete = False Then
            Exit Sub
        End If

        Me.txtFrom.Visible = False
        Me.cboDateRange.SelectedItem = "Custom"
        If Me.dpFrom.Value.ToShortDateString = "1/1/1900" Then
            Me.dpFrom.Value = Today()
        End If

    End Sub
    Private Sub dpTo_GotFocus(sender As Object, e As EventArgs) Handles dpTo.GotFocus
        If Me.LoadComplete = False Then
            Exit Sub
        End If
        Me.txtTo.Visible = False
        Me.cboDateRange.SelectedItem = "Custom"
        If Me.dpTo.Value.ToShortDateString = "1/1/2100" Then
            Me.dpTo.Value = Today()
        End If

    End Sub
    Private Sub dpTo_ValueChanged(sender As Object, e As EventArgs) Handles dpTo.ValueChanged
        If Me.LoadComplete = False Then
            Exit Sub
        End If
        Me.txtTo.Tag = Me.dpTo.Value.ToShortDateString
    End Sub

    Private Sub dpFrom_ValueChanged(sender As Object, e As EventArgs) Handles dpFrom.ValueChanged
        If Me.LoadComplete = False Then
            Exit Sub
        End If
        Me.txtFrom.Tag = Me.dpFrom.Value.ToShortDateString
    End Sub
    Private Sub txtTimeFrom_GotFocus(sender As Object, e As EventArgs) Handles txtTimeFrom.GotFocus
        Me.tpFrom.Focus()
    End Sub

    Private Sub txtTimeTo_GotFocus(sender As Object, e As EventArgs) Handles txtTimeTo.GotFocus
        Me.tpTo.Focus()
    End Sub

    Private Sub tpFrom_GotFocus(sender As Object, e As EventArgs) Handles tpFrom.GotFocus
        Me.txtTimeFrom.Visible = False
        If Me.tpFrom.Value = "1/1/1900 12:00 AM" Then
            Me.tpFrom.Value = "1/1/1900 10:00 AM"
        End If

    End Sub
    Private Sub tpTo_GotFocus(sender As Object, e As EventArgs) Handles tpTo.GotFocus
        Me.txtTimeTo.Visible = False
        If Me.tpTo.Value = "1/1/1900 11:59 PM" Then
            Me.tpTo.Value = "1/1/1900 8:00 PM"
        End If

    End Sub


    Private Sub tpTo_ValueChanged(sender As Object, e As EventArgs) Handles tpTo.ValueChanged
        Me.txtTimeTo.Tag = Me.tpTo.Value.ToShortTimeString
    End Sub

    Private Sub tpFrom_ValueChanged(sender As Object, e As EventArgs) Handles tpFrom.ValueChanged
        Me.txtTimeFrom.Tag = Me.tpFrom.Value.ToShortTimeString
    End Sub
    Private Sub btnCheckProducts_Click(sender As Object, e As EventArgs) Handles btnCheckProducts.Click
        For x As Integer = 0 To Me.chlstProducts.Items.Count - 1
            Me.chlstProducts.SetItemChecked(x, True)
        Next
    End Sub

    Private Sub btnUncheckProducts_Click(sender As Object, e As EventArgs) Handles btnUncheckProducts.Click
        For x As Integer = 0 To Me.chlstProducts.Items.Count - 1
            Me.chlstProducts.SetItemChecked(x, False)
        Next
    End Sub

    Private Sub rdoCity_CheckedChanged(sender As Object, e As EventArgs) Handles rdoCity.CheckedChanged
        Dim rdo As RadioButton = sender
        If rdo.Checked = True Then

            Me.chlstZipCity.Items.Clear()
            Me.txtZipCity.Text = ""
            Me.Label9.Text = "Enter Starting City:"
            Me.Label10.Text = "Show Cities Within"
            Me.Label11.Text = "Miles of Starting City"
            Me.btnShow.Text = "Show Cities"
            Me.lblStateSelect.Visible = True
            Me.cboStateSelection.Visible = True
            Me.tabGeo.Refresh()
            'Me.BackgroundWorkerCity.RunWorkerAsync()
            Me.BackgroundWorkerCity_DoWork(Nothing, Nothing)
        End If


    End Sub

    Private Sub rdoZip_CheckedChanged(sender As Object, e As EventArgs) Handles rdoZip.CheckedChanged

        Dim rdo As RadioButton = sender
        If rdo.Checked = True Then
            Me.chlstZipCity.Items.Clear()
            Me.txtZipCity.Text = ""
            Me.Label9.Text = "Enter Starting Zip Code:"
            Me.Label10.Text = "Show Zip Codes Within"
            Me.Label11.Text = "Miles of Starting Zip Code"
            Me.btnShow.Text = "Show Zip Codes"
            Me.lblStateSelect.Visible = False
            Me.cboStateSelection.Visible = False
            Me.tabGeo.Refresh()
            ' Me.BackgroundWorkerZip.RunWorkerAsync()
            Me.BackgroundWorkerZip_DoWork(Nothing, Nothing)
        End If

    End Sub
    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Me.epGeo.Clear()
        If Me.rdoZip.Checked = True And Me.txtZipCity.Text = "" Then
            Me.epGeo.SetError(Me.txtZipCity, "You Must Enter A Starting Zip Code!")
            Exit Sub
        End If
        Dim x As Integer = Me.txtZipCity.TextLength

        If Me.rdoZip.Checked = True And x <> 5 Then
            Me.epGeo.SetError(Me.txtZipCity, "You Must Enter A Valid Zip Code!")
            Exit Sub
        End If
        If Me.rdoZip.Checked = True Then
            For z As Integer = 1 To Me.txtZipCity.TextLength
                Dim c As Char = GetChar(Me.txtZipCity.Text, z)
                If (c = "0") Or (c = "1") Or (c = "2") Or (c = "3") Or (c = "4") Or (c = "5") Or (c = "6") Or (c = "7") Or (c = "8") Or (c = "9") Then
                Else
                    Me.epGeo.SetError(Me.txtZipCity, "Zip Codes Only Contain Numbers!")
                    Exit Sub
                End If
            Next
        End If
        If Me.rdoCity.Checked = True And Me.txtZipCity.Text = "" Then
            Me.epGeo.SetError(Me.txtZipCity, "You Must Enter A Starting City!")
            Exit Sub
        End If
        If Me.numMiles.Value = 0 Then
            Me.epGeo.SetError(Me.numMiles, "Radius Search Must Be 1 Mile Or More!")
            Exit Sub
        End If
        ''Call Mappoint search for city, if doesnt exist fire code below
        ''msgbox("Cannot Find City!)
        ''Me.txtZipCity.SelectAll()
        ''If more than 1 exists fire form with listview containing city and state to select appropriate city then click ok button and continue mappoint query


        '' MERGE CODE: 10-7-2015
        '' 
        ''    Add Mappoint query code to populate chlstZipCity then loop to check all
        Try
            Dim mpt As New MAPPOINT_LOGIC_V2
            Select Case btnShow.Text
                Case "Show Zip Codes"
                    Me.chlstZipCity.Items.Clear()
                    Dim arResults As New ArrayList
                    Dim BeginList As List(Of MAPPOINT_LOGIC_V2.ZipState)
                    BeginList = mpt.GetUniqueZipState
                    Me.Cursor = Cursors.WaitCursor
                    Dim StartState As String = mpt.Get_STATE_ForZip(Me.txtZipCity.Text)
                    arResults = mpt.Search_Radius_ZipCode(BeginList, Me.numMiles.Value, Me.txtZipCity.Text, StartState)
                    Dim g As Object
                    For Each g In arResults
                        Me.chlstZipCity.Items.Add(g.ToString)
                    Next
                    Me.Cursor = Cursors.Default
                    Exit Select
                Case "Show Cities"
                    Me.chlstZipCity.Items.Clear()
                    Dim arResults As New ArrayList
                    Dim BeginList As List(Of MAPPOINT_LOGIC_V2.CityState)
                    BeginList = mpt.GetUniqueCityState
                    Me.Cursor = Cursors.WaitCursor
                    Dim Start_State As String = mpt.Get_STATE_ForCity(Me.txtZipCity.Text)
                    arResults = mpt.Search_Radius_City(BeginList, Me.numMiles.Value, Me.txtZipCity.Text, Me.cboStateSelection.Text)
                    Dim g As Object
                    For Each g In arResults
                        Me.chlstZipCity.Items.Add(g.ToString)
                    Next
                    Me.Cursor = Cursors.Default
                    Exit Select
            End Select
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmCreateList", "FormCode", "sub", "btnShow_Click", "0", ex.Message.ToString)
            y = Nothing
        End Try


    End Sub
    Private Sub btnCheckZip_Click(sender As Object, e As EventArgs) Handles btnCheckZip.Click
        For x As Integer = 0 To Me.chlstZipCity.Items.Count - 1
            Me.chlstZipCity.SetItemChecked(x, True)
        Next
    End Sub

    Private Sub btnUncheckZip_Click(sender As Object, e As EventArgs) Handles btnUncheckZip.Click
        For x As Integer = 0 To Me.chlstZipCity.Items.Count - 1
            Me.chlstZipCity.SetItemChecked(x, False)
        Next
    End Sub
    Public Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Me.epForm.Clear()
        Me.epGeo.Clear()
        Me.cboDateRange.SelectedItem = Nothing
        Me.txtRecordCount.Text = ""
        'Me.dpGenerated.Value = "1/1/1900 12:00 AM"
        'Me.txtGenerated.Visible = True
        Me.dpFrom.Value = "1/1/1900 12:00 AM"
        Me.txtFrom.Visible = True
        Me.dpTo.Value = "1/1/2100 12:00 AM"
        Me.txtTo.Visible = True
        Me.tpFrom.Value = "1/1/1900 12:00 AM"
        Me.txtTimeFrom.Visible = True
        Me.tpTo.Value = "1/1/1900 11:59 PM"
        Me.txtTimeTo.Visible = True
        Me.chWeekdays.Checked = False
        For x As Integer = 0 To Me.chlstProducts.Items.Count - 1
            Me.chlstProducts.SetItemChecked(x, True)
        Next
        For x As Integer = 0 To Me.chlstMarketers.Items.Count - 1
            Me.chlstMarketers.SetItemChecked(x, True)
        Next
        For x As Integer = 0 To Me.chlstRehash.Items.Count - 1
            Me.chlstRehash.SetItemChecked(x, True)
        Next
        For x As Integer = 0 To Me.chlstOrderBy.Items.Count - 1
            Me.chlstOrderBy.SetItemChecked(x, False)
        Next
        Me.numMiles.Value = 0
        Me.txtZipCity.Text = ""
        Me.chlstZipCity.Items.Clear()
        Me.TabControl1.SelectTab(0)
        'Me.chlstOrderBy.Items.Remove("Reference Rating")
        'Me.chlstOrderBy.Items.Remove("Cash")
        'Me.chlstOrderBy.Items.Remove("Finance")
        'Me.chlstOrderBy.Items.Remove("Sale Closed Date")
        'Me.chlstOrderBy.Items.Remove("Loan Satisfied Date")
        'Me.chlstOrderBy.Items.Remove("Approved Loan Amount")

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub
    Private Sub tabDate_Leave(sender As Object, e As EventArgs) Handles tabDate.Leave
        Try
            Me.chlstMarketers.Items.Clear()
            Dim cnn As SqlConnection = New SqlConnection(STATIC_VARIABLES.Cnn)
            Dim cmdGet As SqlCommand
            Dim r1 As SqlDataReader
            If Me.chWeekdays.Checked = True Then
                cmdGet = New SqlCommand("Select rep1 from enterlead join tblWherecanleadgo on enterlead.id = tblwherecanleadgo.leadnumber where ApptDate Between '" & Me.dpFrom.Value.ToString & "' and '" & Me.dpTo.Value.ToString & "' and ApptTime Between '" & Me.tpFrom.Value.ToString & "' and '" & Me.tpTo.Value.ToString & "' and  (ApptDay <> 'Saturday' and ApptDay <> 'Sunday') and recovery = 'True' Union Select rep2 from enterlead join tblWherecanleadgo on enterlead.id = tblwherecanleadgo.leadnumber where ApptDate Between '" & Me.dpFrom.Value.ToString & "' and '" & Me.dpTo.Value.ToString & "' and ApptTime Between '" & Me.tpFrom.Value.ToString & "' and '" & Me.tpTo.Value.ToString & "' and  (ApptDay <> 'Saturday' and ApptDay <> 'Sunday') and recovery = 'True' order by rep1 asc ", cnn)
            Else
                cmdGet = New SqlCommand("Select rep1 from enterlead join tblWherecanleadgo on enterlead.id = tblwherecanleadgo.leadnumber where ApptDate Between '" & Me.dpFrom.Value.ToString & "' and '" & Me.dpTo.Value.ToString & "' and ApptTime Between '" & Me.tpFrom.Value.ToString & "' and '" & Me.tpTo.Value.ToString & "' and recovery = 'True' Union Select rep2 from enterlead join tblWherecanleadgo on enterlead.id = tblwherecanleadgo.leadnumber where ApptDate Between '" & Me.dpFrom.Value.ToString & "' and '" & Me.dpTo.Value.ToString & "' and ApptTime Between '" & Me.tpFrom.Value.ToString & "'  and '" & Me.tpTo.Value.ToString & "' and recovery = 'True' order by rep1 asc ", cnn)
            End If

            cmdGet.CommandType = CommandType.Text
            cnn.Open()
            r1 = cmdGet.ExecuteReader(CommandBehavior.CloseConnection)
            While r1.Read()
                If r1.Item(0) <> "" Then
                    Me.chlstMarketers.Items.Add(r1.Item(0))
                End If
            End While
            For x As Integer = 0 To Me.chlstMarketers.Items.Count - 1
                Me.chlstMarketers.SetItemChecked(x, True)
            Next

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "tabDate_Leave", "FormCode", "sub", "tabDate_Leave", "0", ex.Message.ToString)
            y = Nothing
        End Try
        Try
            Me.chlstProducts.Items.Clear()
            Dim cnn As SqlConnection = New SqlConnection(STATIC_VARIABLES.Cnn)
            Dim cmdGet As SqlCommand
            Dim r1 As SqlDataReader
            If Me.chWeekdays.Checked = True Then
                cmdGet = New SqlCommand("Select enterlead.product1 from enterlead join tblWherecanleadgo on enterlead.id = tblwherecanleadgo.leadnumber where ApptDate Between '" & Me.dpFrom.Value.ToString & "' and '" & Me.dpTo.Value.ToString & "' and ApptTime Between '" & Me.tpFrom.Value.ToString & "' and '" & Me.tpTo.Value.ToString & "' and (ApptDay <> 'Saturday' and ApptDay <> 'Sunday') and recovery = 'True' union select enterlead.product2 from enterlead join tblWherecanleadgo on enterlead.id = tblwherecanleadgo.leadnumber where ApptDate Between '" & Me.dpFrom.Value.ToString & "' and '" & Me.dpTo.Value.ToString & "' and ApptTime Between '" & Me.tpFrom.Value.ToString & "' and '" & Me.tpTo.Value.ToString & "' and (ApptDay <> 'Saturday' and ApptDay <> 'Sunday') and recovery = 'True' union select enterlead.product3 from enterlead join tblWherecanleadgo on enterlead.id = tblwherecanleadgo.leadnumber where ApptDate Between '" & Me.dpFrom.Value.ToString & "' and '" & Me.dpTo.Value.ToString & "' and ApptTime Between '" & Me.tpFrom.Value.ToString & "' and '" & Me.tpTo.Value.ToString & "' and (ApptDay <> 'Saturday' and ApptDay <> 'Sunday') and recovery = 'True' order by product1 asc", cnn)
            Else
                cmdGet = New SqlCommand("Select enterlead.product1 from enterlead join tblWherecanleadgo on enterlead.id = tblwherecanleadgo.leadnumber where ApptDate Between '" & Me.dpFrom.Value.ToString & "' and '" & Me.dpTo.Value.ToString & "' and ApptTime Between '" & Me.tpFrom.Value.ToString & "' and '" & Me.tpTo.Value.ToString & "' and recovery = 'True' union select enterlead.product2 from enterlead join tblWherecanleadgo on enterlead.id = tblwherecanleadgo.leadnumber where ApptDate Between '" & Me.dpFrom.Value.ToString & "' and '" & Me.dpTo.Value.ToString & "' and ApptTime Between '" & Me.tpFrom.Value.ToString & "' and '" & Me.tpTo.Value.ToString & "' and recovery = 'True' union select enterlead.product3 from enterlead join tblWherecanleadgo on enterlead.id = tblwherecanleadgo.leadnumber where ApptDate Between '" & Me.dpFrom.Value.ToString & "' and '" & Me.dpTo.Value.ToString & "' and ApptTime Between '" & Me.tpFrom.Value.ToString & "' and '" & Me.tpTo.Value.ToString & "' and recovery = 'True' order by Product1 asc", cnn)
            End If

            cmdGet.CommandType = CommandType.Text
            cnn.Open()
            r1 = cmdGet.ExecuteReader(CommandBehavior.CloseConnection)
            While r1.Read()
                If r1.Item(0) <> "" Then
                    Me.chlstProducts.Items.Add(r1.Item(0))
                End If
            End While
            For x As Integer = 0 To Me.chlstProducts.Items.Count - 1
                Me.chlstProducts.SetItemChecked(x, True)
            Next
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "tabDate_Leave", "FormCode", "sub", "tabDate_Leave", "0", ex.Message.ToString)
            y = Nothing
        End Try
        If Me.rdoZip.Checked = True Then
            Me.BackgroundWorkerZip_DoWork(Nothing, Nothing)
        Else
            Me.BackgroundWorkerCity_DoWork(Nothing, Nothing)
        End If

        ' Me.BackgroundWorkerZip.RunWorkerAsync()
    End Sub
    Private Sub btnCheckOrderBy_Click(sender As Object, e As EventArgs) Handles btnCheckOrderBy.Click
        For x As Integer = 0 To Me.chlstOrderBy.Items.Count - 1
            Me.chlstOrderBy.SetItemChecked(x, True)
        Next
    End Sub

    Private Sub btnUnCheckOrderBy_Click(sender As Object, e As EventArgs) Handles btnUnCheckOrderBy.Click
        For x As Integer = 0 To Me.chlstOrderBy.Items.Count - 1
            Me.chlstOrderBy.SetItemChecked(x, False)
        Next
    End Sub

    Private Sub btnUp_Click(sender As Object, e As EventArgs) Handles btnUp.Click
        If Me.chlstOrderBy.SelectedItems.Count = 0 Then
            Exit Sub
        End If
        If Me.chlstOrderBy.SelectedIndex = 0 Then
            Exit Sub
        End If
        If Me.chlstOrderBy.SelectedIndex > 0 Then
            Dim Index As Integer = Me.chlstOrderBy.Items.IndexOf(Me.chlstOrderBy.SelectedItem)
            Dim What As String = Me.chlstOrderBy.SelectedItem.ToString
            Dim ChkState As Boolean = Me.chlstOrderBy.GetItemCheckState(Index)
            Me.chlstOrderBy.Items.RemoveAt(Index)
            Me.chlstOrderBy.Items.Insert(Index - 1, What)
            Me.chlstOrderBy.SelectedItem = What
            If ChkState = True Then
                Me.chlstOrderBy.SetItemCheckState(Index - 1, CheckState.Checked)
            Else
                Me.chlstOrderBy.SetItemCheckState(Index - 1, CheckState.Unchecked)
            End If
        End If
    End Sub

    Private Sub btnDown_Click(sender As Object, e As EventArgs) Handles btnDown.Click
        If Me.chlstOrderBy.SelectedItems.Count = 0 Then
            Exit Sub
        End If
        If Me.chlstOrderBy.SelectedIndex = Me.chlstOrderBy.Items.Count - 1 Then
            Exit Sub
        End If
        If Me.chlstOrderBy.SelectedIndex < Me.chlstOrderBy.Items.Count - 1 Then
            Dim Index As Integer = Me.chlstOrderBy.Items.IndexOf(Me.chlstOrderBy.SelectedItem)
            Dim What As String = Me.chlstOrderBy.SelectedItem.ToString
            Dim ChkState As Boolean = Me.chlstOrderBy.GetItemCheckState(Index)
            Me.chlstOrderBy.Items.RemoveAt(Index)
            Me.chlstOrderBy.Items.Insert(Index + 1, What)
            Me.chlstOrderBy.SelectedItem = What
            If ChkState = True Then
                Me.chlstOrderBy.SetItemCheckState(Index + 1, CheckState.Checked)
            Else
                Me.chlstOrderBy.SetItemCheckState(Index + 1, CheckState.Unchecked)
            End If


        End If
    End Sub
    Private Sub checkMarketers_Click(sender As Object, e As EventArgs) Handles checkMarketers.Click
        For x As Integer = 0 To Me.chlstMarketers.Items.Count - 1
            Me.chlstMarketers.SetItemChecked(x, True)
        Next
    End Sub

    Private Sub uncheckMarketers_Click(sender As Object, e As EventArgs) Handles uncheckMarketers.Click
        For x As Integer = 0 To Me.chlstMarketers.Items.Count - 1
            Me.chlstMarketers.SetItemChecked(x, False)
        Next
    End Sub
    Private Sub txtZipCity_Leave(sender As Object, e As EventArgs) Handles txtZipCity.Leave
        If Me.rdoCity.Checked = True Then
            Try

                Dim cnn As SqlConnection = New SqlConnection(STATIC_VARIABLES.Cnn)
                Dim cmdGet As SqlCommand
                Dim r1 As SqlDataReader

                cmdGet = New SqlCommand("Select Distinct(state) from enterlead where City = '" & Me.txtZipCity.Text & "'", cnn)



                cmdGet.CommandType = CommandType.Text
                Cnn.Open()
                r1 = cmdGet.ExecuteReader(CommandBehavior.CloseConnection)
                While r1.Read()
                    Me.cboStateSelection.Text = r1.Item(0)
                End While


            Catch ex As Exception
                Me.Cursor = Cursors.Default
                Main.Cursor = Cursors.Default
                Dim y As New ErrorLogging_V2
                y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "txtZipCity_Leave", "FormCode", "sub", "tabDate_Leave", "0", ex.Message.ToString)
                y = Nothing
            End Try
        End If
    End Sub

    Private Sub BackgroundWorkerZip_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerZip.DoWork
        Try
            Me.txtZipCity.AutoCompleteCustomSource.Clear()
            Dim cnn As SqlConnection = New SqlConnection(STATIC_VARIABLES.Cnn)
            Dim cmdGet As SqlCommand
            Dim r1 As SqlDataReader
            If Me.chWeekdays.Checked = True Then
                cmdGet = New SqlCommand("Select Distinct(Zip) from enterlead join tblWherecanleadgo on enterlead.id = tblwherecanleadgo.leadnumber where ApptDate Between '" & Me.dpFrom.Value.ToString & "' and '" & Me.dpTo.Value.ToString & "' and ApptTime Between '" & Me.tpFrom.Value.ToString & "' and '" & Me.tpTo.Value.ToString & "' and (ApptDay <> 'Saturday' and ApptDay <> 'Sunday') and tblWhereCanLeadGo.Recovery = 'True' order by Zip desc", cnn)
            Else
                cmdGet = New SqlCommand("Select Distinct(Zip) from enterlead join tblWherecanleadgo on enterlead.id = tblwherecanleadgo.leadnumber where ApptDate Between '" & Me.dpFrom.Value.ToString & "' and '" & Me.dpTo.Value.ToString & "' and ApptTime Between '" & Me.tpFrom.Value.ToString & "' and '" & Me.tpTo.Value.ToString & "' and tblWhereCanLeadGo.Recovery = 'True' order by Zip desc", cnn)
            End If

            cmdGet.CommandType = CommandType.Text
            cnn.Open()
            r1 = cmdGet.ExecuteReader(CommandBehavior.CloseConnection)
            While r1.Read()
                Me.txtZipCity.AutoCompleteCustomSource.Add(r1.Item(0))
            End While


        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "tabDate_Leave", "FormCode", "sub", "tabDate_Leave", "0", ex.Message.ToString)
            y = Nothing
        End Try
    End Sub

    Private Sub BackgroundWorkerCity_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerCity.DoWork
        Try
            Me.txtZipCity.AutoCompleteCustomSource.Clear()
            Dim cnn As SqlConnection = New SqlConnection(STATIC_VARIABLES.Cnn)
            Dim cmdGet As SqlCommand
            Dim r1 As SqlDataReader
            If Me.chWeekdays.Checked = True Then
                cmdGet = New SqlCommand("Select Distinct(City) from enterlead join tblWherecanleadgo on enterlead.id = tblwherecanleadgo.leadnumber where ApptDate Between '" & Me.dpFrom.Value.ToString & "' and '" & Me.dpTo.Value.ToString & "' and ApptTime Between '" & Me.tpFrom.Value.ToString & "' and '" & Me.tpTo.Value.ToString & "' and (ApptDay <> 'Saturday' and ApptDay <> 'Sunday') and tblWhereCanLeadGo.Recovery = 'True' order by City asc", cnn)
            Else
                cmdGet = New SqlCommand("Select Distinct(City) from enterlead join tblWherecanleadgo on enterlead.id = tblwherecanleadgo.leadnumber where ApptDate Between '" & Me.dpFrom.Value.ToString & "' and '" & Me.dpTo.Value.ToString & "' and ApptTime Between '" & Me.tpFrom.Value.ToString & "' and '" & Me.tpTo.Value.ToString & "' and tblWhereCanLeadGo.Recovery = 'True' order by City asc", cnn)
            End If

            cmdGet.CommandType = CommandType.Text
            cnn.Open()
            r1 = cmdGet.ExecuteReader(CommandBehavior.CloseConnection)
            While r1.Read()
                Me.txtZipCity.AutoCompleteCustomSource.Add(r1.Item(0))
            End While


        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "rdoCity_CheckedChanged", "FormCode", "sub", "tabDate_Leave", "0", ex.Message.ToString)
            y = Nothing
        End Try
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        'Me.RichTextBox1.Text = "" ''Remove After Testing 


        Me.tabDate.ImageKey = Nothing
        Me.tabDate.ToolTipText = ""
        Me.tabProducts.ImageKey = Nothing
        Me.tabProducts.ToolTipText = ""
        Me.tabGeo.ImageKey = Nothing
        Me.tabGeo.ToolTipText = ""
        Me.tabRecovery.ImageKey = Nothing
        Me.tabRecovery.ToolTipText = ""
        Me.tabMarketers.ImageKey = Nothing
        Me.tabMarketers.ToolTipText = ""

        Me.epForm.Clear()
        Dim tabDate As Integer = 0
        Dim tabProd As Integer = 0
        Dim tabGeo As Integer = 0
        Dim tabRehash As Integer = 0
        Dim tabMarketer As Integer = 0

        If Me.dpFrom.Value.ToShortDateString <> "1/1/1900" And Me.dpTo.Value.ToShortDateString = "1/1/2100" Then              '' Change If Statement to reflect datepicker value instead of visible properties
            Me.epForm.SetError(Me.dpTo, "You Must Supply a Date!")
            tabDate += 1
        End If
        If Me.dpFrom.Value.ToShortDateString = "1/1/1900" And Me.dpTo.Value.ToShortDateString <> "1/1/2100" Then              '' Change If Statement to reflect datepicker value instead of visible properties
            Me.epForm.SetError(Me.dpFrom, "You Must Supply a Date!")
            tabDate += 1
        End If
        If Me.tpFrom.Value.ToShortTimeString = "12:00 AM" And Me.tpTo.Value.ToShortTimeString <> "11:59 PM" Then
            Me.epForm.SetError(Me.tpFrom, "You Must Supply a Time!")
            tabDate += 1
        End If
        If Me.tpFrom.Value.ToShortTimeString <> "12:00 AM" And Me.tpTo.Value.ToShortTimeString = "11:59 PM" Then
            Me.epForm.SetError(Me.tpTo, "You Must Supply a Time!")
            tabDate += 1
        End If

        ''Sales Rep Tab ''Left tab name marketers due to recycled code
        If Me.chlstMarketers.CheckedItems.Count <= 0 Then
            Me.epForm.SetError(Me.chlstMarketers, "You Must Select at Least One Sales Rep!")
            tabMarketer += 1
        End If
        ''Products Tab
        If Me.chlstProducts.CheckedItems.Count <= 0 Then
            Me.epForm.SetError(Me.chlstProducts, "You Must Select at Least One Product!")
            tabProd += 1
        End If

        ''Geo Tab 
        If Me.chlstZipCity.Items.Count > 0 And Me.chlstZipCity.CheckedItems.Count <= 0 Then
            If Me.rdoZip.Checked = True Then
                Me.epForm.SetError(Me.chlstProducts, "You Must Select at Least One Zip Code!")
                tabGeo += 1
            Else
                Me.epForm.SetError(Me.chlstProducts, "You Must Select at Least One City!")

                Me.epForm.SetIconPadding(Me.chlstProducts, 20)
                tabGeo += 1
            End If
        End If
        ' ''Rehash Tab

        If Me.chlstRehash.CheckedItems.Count <= 0 Then
            Me.epForm.SetError(Me.chlstRehash, "You Must Select at Least One Result!")
            tabRehash += 1
        End If
        For z As Integer = 1 To Me.txtQuoted.TextLength
            Dim c As Char = GetChar(Me.txtQuoted.Text, z)
            If (c = "0") Or (c = "1") Or (c = "2") Or (c = "3") Or (c = "4") Or (c = "5") Or (c = "6") Or (c = "7") Or (c = "8") Or (c = "9") Then
            Else
                Me.epGeo.SetError(Me.txtQuoted, "Field Can Only Contain Numbers!")
                tabRehash += 1
            End If
        Next

        Dim tab As Integer = 0
        If tabDate > 0 Then
            Me.tabDate.ImageIndex = 0
            Me.tabDate.ToolTipText = "Errors on this Tab"
            tab += 1
        End If
        If tabProd > 0 Then
            Me.tabProducts.ImageIndex = 0
            Me.tabProducts.ToolTipText = "Errors on this Tab"
            tab += 1
        End If
        If tabGeo > 0 Then
            Me.tabGeo.ImageIndex = 0
            Me.tabGeo.ToolTipText = "Errors on this Tab"
            tab += 1
        End If
        If tabRehash > 0 Then
            Me.tabRecovery.ImageIndex = 0
            Me.tabRecovery.ToolTipText = "Errors on this Tab"
            tab += 1
        End If
        If tabMarketer > 0 Then
            Me.tabMarketers.ImageIndex = 0
            Me.tabMarketers.ToolTipText = "Errors on this Tab"
            tab += 1
        End If
        If tab > 0 Then
            Exit Sub
        End If
        Dim Where As String = ""
        Dim DateQuery As String = ""
        Dim MarkProdGeo As String = ""
        Dim Rehash As String = ""
        Dim Slct As String = "Select Distinct(Enterlead.ID), Contact1LastName, Contact1FirstName, Contact2LastName, Contact2FirstName, StAddress, City, State, Zip, HousePhone, AltPhone1, AltPhone2, Enterlead.Product1, Enterlead.Product2, Enterlead.Product3, LeadGeneratedOn, ApptDate, ApptDay, ApptTime, Rep1, Rep2, Result, MarketingResults "
        Dim Orderby As String = ""

        Slct = Slct & " From Enterlead join tblWhereCanLeadGo on enterlead.id = tblWhereCanLeadGo.LeadNumber"

        If Me.dpFrom.Value.ToShortDateString <> "1/1/1900" Then
            DateQuery = DateQuery & "ApptDate Between '" & Me.dpFrom.Value.ToString & "' and '" & Me.dpTo.Value.ToString & "'"
        End If
        If Me.tpFrom.Value.ToShortTimeString <> "12:00 AM" Then
            If DateQuery <> "" Then
                DateQuery = DateQuery & " and "
            End If
            DateQuery = DateQuery & "ApptTime Between '" & Me.tpFrom.Value.ToString & "' And '" & Me.tpTo.Value.ToString & "'"
        End If
        If Me.chWeekdays.Checked = True Then
            If DateQuery <> "" Then
                DateQuery = DateQuery & " and "
            End If
            DateQuery = DateQuery & "ApptDay <> 'Saturday' and ApptDay <> 'Sunday'"
        End If

        ''Marketer AKA Sales Rep
        If Me.chlstMarketers.CheckedItems.Count < Me.chlstMarketers.Items.Count Then '' If true we need to add selected marketers to query, if not true we dont need to add marketers at all because date range already filters down marketer for us 
            If MarkProdGeo <> "" Then
                MarkProdGeo = MarkProdGeo & " and "
            End If
            For x As Integer = 0 To Me.chlstMarketers.CheckedItems.Count - 1
                If x = 0 Then
                    MarkProdGeo = MarkProdGeo & "("
                End If
                If x <> Me.chlstMarketers.CheckedItems.Count - 1 Then

                    MarkProdGeo = MarkProdGeo & "(Rep1 = '" & Me.chlstMarketers.CheckedItems(x).ToString & "' or Rep2 = '" & Me.chlstMarketers.CheckedItems(x).ToString & "') or "    ''Add Comma after each item until last item 
                Else
                    MarkProdGeo = MarkProdGeo & "(Rep1 = '" & Me.chlstMarketers.CheckedItems(x).ToString & "' or Rep2 = '" & Me.chlstMarketers.CheckedItems(x).ToString & "'))"       ''Last Item Dont Add comma to end of where 
                End If
            Next
        End If

        ''Products
        If Me.chlstProducts.Items.Count <> Me.chlstProducts.CheckedItems.Count Then ''If true filter by checked products, if false no need to filter products (skip to next step)
            If MarkProdGeo <> "" Then
                MarkProdGeo = MarkProdGeo & " and "
            End If
            For x As Integer = 0 To Me.chlstProducts.CheckedItems.Count - 1
                If x = 0 Then
                    MarkProdGeo = MarkProdGeo & "("
                End If
                If x <> Me.chlstProducts.CheckedItems.Count - 1 Then

                    MarkProdGeo = MarkProdGeo & "(" & "Product1 = '" & Me.chlstProducts.CheckedItems(x).ToString & "' or Product2 = '" & Me.chlstProducts.CheckedItems(x).ToString & "' or Product3 = '" & Me.chlstProducts.CheckedItems(x).ToString & "') or "    ''Add Comma after each item until last item 
                Else
                    MarkProdGeo = MarkProdGeo & "(" & "Product1 = '" & Me.chlstProducts.CheckedItems(x).ToString & "' or Product2 = '" & Me.chlstProducts.CheckedItems(x).ToString & "' or Product3 = '" & Me.chlstProducts.CheckedItems(x).ToString & "'))"       ''Last Item Dont Add comma to end of where 
                End If
            Next
        End If

        ''Geo Tab 
        If Me.chlstZipCity.CheckedItems.Count > 0 Then
            If MarkProdGeo <> "" Then
                MarkProdGeo = MarkProdGeo & " and "
            End If
            Dim CorZ As String = ""
            If Me.rdoZip.Checked = True Then
                CorZ = "Zip"
            Else
                CorZ = "City"
            End If
            For x As Integer = 0 To Me.chlstZipCity.CheckedItems.Count - 1
                If x = 0 Then
                    MarkProdGeo = MarkProdGeo & "("
                End If
                If x <> Me.chlstZipCity.CheckedItems.Count - 1 Then

                    MarkProdGeo = MarkProdGeo & CorZ & " = '" & Me.chlstZipCity.CheckedItems(x).ToString & "' or "    ''Add Comma after each item until last item 
                Else
                    MarkProdGeo = MarkProdGeo & CorZ & " = '" & Me.chlstZipCity.CheckedItems(x).ToString & "')"       ''Last Item Dont Add comma to end of where 
                End If
            Next
        End If

        '' Recovery

        Dim Per As Double = 0
        If Me.numPar.Value <> 0 Then  ''Skip percentage from par portion of query
            Per = Me.numPar.Value / 100
            Per = 1 - Per
            Rehash = "(ParPrice <= (QuotedSold *" & Per & ") and ParPrice > 0)"
        End If
        If Me.txtQuoted.Text <> "" Then
            If Rehash <> "" Then
                Rehash = Rehash & " and "
            End If
            Dim Q As Integer = 0
            Q = CType(Me.txtQuoted.Text, Integer)
            Rehash = Rehash & "QuotedSold >= " & Q & " "
        End If
        If Me.chlstRehash.Items.Count > Me.chlstRehash.CheckedItems.Count Then
            For x As Integer = 0 To Me.chlstRehash.CheckedItems.Count - 1
                If x = 0 Then
                    If Rehash = "" Then
                        Rehash = Rehash & "("
                    Else
                        Rehash = Rehash & "and ("
                    End If
                End If
                Dim Field As String = ""
                If Me.chlstRehash.CheckedItems(x) = "Reset" Or Me.chlstRehash.CheckedItems(x) = "Not Hit" Or Me.chlstRehash.CheckedItems(x) = "Not Issued" Or Me.chlstRehash.CheckedItems(x) = "Demo/No Sale" Or Me.chlstRehash.CheckedItems(x) = "Recission Cancel" Then
                    Field = "Result"
                Else
                    Field = "MarketingResults"
                End If
                If x <> Me.chlstRehash.CheckedItems.Count - 1 Then

                    Rehash = Rehash & "(" & Field & " = '" & Me.chlstRehash.CheckedItems(x).ToString & "') or "    ''Add Comma after each item until last item 
                Else
                    Rehash = Rehash & "(" & Field & " = '" & Me.chlstRehash.CheckedItems(x).ToString & "'))"       ''Last Item Dont Add comma to end of where 
                End If
            Next
        End If
        If Rehash = "" Then
            Rehash = "tblWhereCanLeadGo.Recovery = 'True'"
        Else
            Rehash = Rehash & " and tblWhereCanLeadGo.Recovery = 'True'"
        End If

        ''Reconstruct Where Statement 
        If Rehash <> "" Then ''Constructs Query For Warm Calling 
            If DateQuery <> "" And MarkProdGeo <> "" Then
                Where = "(" & DateQuery & " and " & MarkProdGeo & " and " & Rehash & ")"
            ElseIf DateQuery <> "" And MarkProdGeo = "" Then
                Where = "(" & DateQuery & " and " & Rehash & ")"
            ElseIf DateQuery = "" And MarkProdGeo <> "" Then
                Where = "(" & MarkProdGeo & " and " & Rehash & ")"
            ElseIf DateQuery = "" And MarkProdGeo = "" Then
                Where = Rehash
            End If
        End If

        Where = " Where " & Where

        Slct = Slct & Where
        Dim GrpBy As Boolean
        If Me.chGroupBy.Checked = True Then
            GrpBy = True
        End If
        For x As Integer = 0 To Me.chlstOrderBy.CheckedItems.Count - 1
            Select Case Me.chlstOrderBy.CheckedItems(x).ToString
                Case Is = "City, State"
                    If x = Me.chlstOrderBy.CheckedItems.Count - 1 Then
                        Orderby = Orderby & "City asc"
                    Else
                        Orderby = Orderby & "City asc, "
                    End If
                Case Is = "Zip Code"
                    If x = Me.chlstOrderBy.CheckedItems.Count - 1 Then
                        Orderby = Orderby & "Zip desc"
                    Else
                        Orderby = Orderby & "Zip desc, "
                    End If
                Case Is = "Appointment Date"
                    If x = Me.chlstOrderBy.CheckedItems.Count - 1 Then
                        Orderby = Orderby & "ApptDate desc"
                    Else
                        Orderby = Orderby & "ApptDate desc, "
                    End If
                Case Is = "Appointment Time"
                    If x = Me.chlstOrderBy.CheckedItems.Count - 1 Then
                        Orderby = Orderby & "ApptTime asc"
                    Else
                        Orderby = Orderby & "ApptTime asc, "
                    End If
                Case Is = "Primary Product"
                    If x = Me.chlstOrderBy.CheckedItems.Count - 1 Then
                        Orderby = Orderby & "Product1 asc"
                    Else
                        Orderby = Orderby & "Product1 asc, "
                    End If
                Case Is = "Sales Rep"
                    If x = Me.chlstOrderBy.CheckedItems.Count - 1 Then
                        Orderby = Orderby & "Rep1 asc"
                    Else
                        Orderby = Orderby & "Rep1 asc, "
                    End If
                Case Is = "Marketing Result"
                    If x = Me.chlstOrderBy.CheckedItems.Count - 1 Then
                        Orderby = Orderby & "MarketingResults asc"
                    Else
                        Orderby = Orderby & "MarketingResults asc, "
                    End If
                Case Is = "Sales Result"
                    If x = Me.chlstOrderBy.CheckedItems.Count - 1 Then
                        Orderby = Orderby & "Result asc"
                    Else
                        Orderby = Orderby & "Result asc, "
                    End If
                Case Is = "Quoted Price"
                    If x = Me.chlstOrderBy.CheckedItems.Count - 1 Then
                        Orderby = Orderby & "QuotedSold desc"
                    Else
                        Orderby = Orderby & "QuotedSold desc, "
                    End If
            End Select
        Next
        If Orderby <> "" Then
            Orderby = " Order By " & Orderby
            Slct = Slct & Orderby
        End If
        'Me.RichTextBox1.Text = Slct ''Remove After Testing


        ''Aaron, Use Slct Variable for your Select Statement Query and Use GrpBy Variable to decide if you need to group your list with the top checked item in sort by checked list box


        '' 4-4-2016 - AC
        '' same motif as wclist
        '' distinct query =>
        '' grouped / non grouped
        '' render 
        '' display

        '' append query with QuotedSold Column for EnterLead
        '' Remove all the columns for UniqueHeader Function

        '' compensate for NULL values coming out of QuotedSold
        '' 
        '' the structure for Recovery Leads will be different as different data is pulled out
        '' the HTML render will Show different columns for Recovery as well. 
        '' 

        Slct = Slct.ToString.Replace(" Rep1, Rep2, Result, MarketingResults", " Rep1, Rep2, Result, MarketingResults, QuotedSold ") '' needed for ORDER BY clause
        Dim arSort As New ArrayList
        Dim cntSRT As Integer = Me.chlstOrderBy.CheckedItems.Count - 1
        Dim i As Integer = 0
        For i = 0 To cntSRT
            arSort.Add(Me.chlstOrderBy.CheckedItems(i))
        Next




        ' '' DEBUG ONLY
        ' '' 

        'Dim strHeading As String = "" & vbCrLf & ""

        'Dim xxx As Integer = 0
        'For xxx = 0 To arSort.Count - 1
        '    strHeading += arSort(xxx).ToString
        'Next

        'Dim disT_QUERY As String = ConvertGroup(Me.chlstOrderBy.Items(0), Slct, arSort)

        'Me.Cursor = Cursors.WaitCursor
        'Dim strW As New System.IO.StreamWriter("C:\Users\Clay\Desktop\AngyQRY_List.txt", False)
        'strW.Write(Slct & vbCrLf & vbCrLf & strHeading & vbCrLf & vbCrLf & disT_QUERY)
        'strW.Flush()
        'strW.Close()
        'strW = Nothing
        'System.Diagnostics.Process.Start("C:\Users\Clay\Desktop\AngyQRY_List.txt")

        ' '' 
        ' '' END DEBUG 


        If Me.chGroupBy.CheckState = CheckState.Checked Then

            Dim qrySTR_Headers As String = ConvertGroup(Me.chlstOrderBy.CheckedItems.Item(0), Slct, arSort) '' private function to present selections in UNIFIED SQL StateMent
            '' now we have headings and result set in a unified format
            '' also have query to pull unique heading [data] out of SQL
            '' pipe to html render
            '' 
            Dim cl_XP As New createListPrintOperations
            ' generate for GROUPED RC List
            cl_XP.CreateWireFrameHTML_Recovery(Slct, True, arSort, qrySTR_Headers)
            cl_XP = Nothing
        Else
            Me.chGroupBy.CheckState = CheckState.Unchecked
            '' now we have headings and result set in a unified format
            '' pipe to html render
            '' 
            Dim clP As New createListPrintOperations
            ' Generate for NON GROUPED RC LIST
            clP.CreateWireFrameHTML_Recovery(Slct)
            clP = Nothing
        End If



        Me.Cursor = Cursors.Default



    End Sub


#Region "Record Count Sub"
    Private Sub btnRecordCount_Click(sender As Object, e As EventArgs) Handles btnRecordCount.Click
        Me.txtRecordCount.Text = ""
        Me.tabDate.ImageKey = Nothing
        Me.tabDate.ToolTipText = ""
        Me.tabProducts.ImageKey = Nothing
        Me.tabProducts.ToolTipText = ""
        Me.tabGeo.ImageKey = Nothing
        Me.tabGeo.ToolTipText = ""
        Me.tabRecovery.ImageKey = Nothing
        Me.tabRecovery.ToolTipText = ""
        Me.tabMarketers.ImageKey = Nothing
        Me.tabMarketers.ToolTipText = ""

        Me.epForm.Clear()
        Me.epGeo.Clear()
        Dim tabDate As Integer = 0
        Dim tabProd As Integer = 0
        Dim tabGeo As Integer = 0
        Dim tabRehash As Integer = 0
        Dim tabMarketer As Integer = 0

        If Me.dpFrom.Value.ToShortDateString <> "1/1/1900" And Me.dpTo.Value.ToShortDateString = "1/1/2100" Then              '' Change If Statement to reflect datepicker value instead of visible properties
            Me.epForm.SetError(Me.dpTo, "You Must Supply a Date!")
            tabDate += 1
        End If
        If Me.dpFrom.Value.ToShortDateString = "1/1/1900" And Me.dpTo.Value.ToShortDateString <> "1/1/2100" Then              '' Change If Statement to reflect datepicker value instead of visible properties
            Me.epForm.SetError(Me.dpFrom, "You Must Supply a Date!")
            tabDate += 1
        End If
        If Me.tpFrom.Value.ToShortTimeString = "12:00 AM" And Me.tpTo.Value.ToShortTimeString <> "11:59 PM" Then
            Me.epForm.SetError(Me.tpFrom, "You Must Supply a Time!")
            tabDate += 1
        End If
        If Me.tpFrom.Value.ToShortTimeString <> "12:00 AM" And Me.tpTo.Value.ToShortTimeString = "11:59 PM" Then
            Me.epForm.SetError(Me.tpTo, "You Must Supply a Time!")
            tabDate += 1
        End If

        ''Sales Rep Tab ''Left tab name marketers due to recycled code
        If Me.chlstMarketers.CheckedItems.Count <= 0 Then
            Me.epForm.SetError(Me.chlstMarketers, "You Must Select at Least One Sales Rep!")
            tabMarketer += 1
        End If
        ''Products Tab
        If Me.chlstProducts.CheckedItems.Count <= 0 Then
            Me.epForm.SetError(Me.chlstProducts, "You Must Select at Least One Product!")
            tabProd += 1
        End If

        ''Geo Tab 
        If Me.chlstZipCity.Items.Count > 0 And Me.chlstZipCity.CheckedItems.Count <= 0 Then
            If Me.rdoZip.Checked = True Then
                Me.epForm.SetError(Me.chlstProducts, "You Must Select at Least One Zip Code!")
                tabGeo += 1
            Else
                Me.epForm.SetError(Me.chlstProducts, "You Must Select at Least One City!")

                Me.epForm.SetIconPadding(Me.chlstProducts, 20)
                tabGeo += 1
            End If
        End If
        ' ''Rehash Tab

        If Me.chlstRehash.CheckedItems.Count <= 0 Then
            Me.epForm.SetError(Me.chlstRehash, "You Must Select at Least One Result!")
            tabRehash += 1
        End If
        For z As Integer = 1 To Me.txtQuoted.TextLength
            Dim c As Char = GetChar(Me.txtQuoted.Text, z)
            If (c = "0") Or (c = "1") Or (c = "2") Or (c = "3") Or (c = "4") Or (c = "5") Or (c = "6") Or (c = "7") Or (c = "8") Or (c = "9") Then
            Else
                Me.epGeo.SetError(Me.txtQuoted, "Field Can Only Contain Numbers!")
                tabRehash += 1
            End If
        Next

        Dim tab As Integer = 0
        If tabDate > 0 Then
            Me.tabDate.ImageIndex = 0
            Me.tabDate.ToolTipText = "Errors on this Tab"
            tab += 1
        End If
        If tabProd > 0 Then
            Me.tabProducts.ImageIndex = 0
            Me.tabProducts.ToolTipText = "Errors on this Tab"
            tab += 1
        End If
        If tabGeo > 0 Then
            Me.tabGeo.ImageIndex = 0
            Me.tabGeo.ToolTipText = "Errors on this Tab"
            tab += 1
        End If
        If tabRehash > 0 Then
            Me.tabRecovery.ImageIndex = 0
            Me.tabRecovery.ToolTipText = "Errors on this Tab"
            tab += 1
        End If
        If tabMarketer > 0 Then
            Me.tabMarketers.ImageIndex = 0
            Me.tabMarketers.ToolTipText = "Errors on this Tab"
            tab += 1
        End If
        If tab > 0 Then
            Exit Sub
        End If
        Dim Where As String = ""
        Dim DateQuery As String = ""
        Dim MarkProdGeo As String = ""
        Dim Rehash As String = ""
        Dim Slct As String = "Select Count (distinct (enterlead.id)) "
        Dim Orderby As String = ""

        Slct = Slct & " From Enterlead join tblWhereCanLeadGo on enterlead.id = tblWhereCanLeadGo.LeadNumber"

        If Me.dpFrom.Value.ToShortDateString <> "1/1/1900" Then
            DateQuery = DateQuery & "ApptDate Between '" & Me.dpFrom.Value.ToString & "' and '" & Me.dpTo.Value.ToString & "'"
        End If
        If Me.tpFrom.Value.ToShortTimeString <> "12:00 AM" Then
            If DateQuery <> "" Then
                DateQuery = DateQuery & " and "
            End If
            DateQuery = DateQuery & "ApptTime Between '" & Me.tpFrom.Value.ToString & "' And '" & Me.tpTo.Value.ToString & "'"
        End If
        If Me.chWeekdays.Checked = True Then
            If DateQuery <> "" Then
                DateQuery = DateQuery & " and "
            End If
            DateQuery = DateQuery & "ApptDay <> 'Saturday' and ApptDay <> 'Sunday'"
        End If

        ''Marketer AKA Sales Rep
        If Me.chlstMarketers.CheckedItems.Count < Me.chlstMarketers.Items.Count Then '' If true we need to add selected marketers to query, if not true we dont need to add marketers at all because date range already filters down marketer for us 
            If MarkProdGeo <> "" Then
                MarkProdGeo = MarkProdGeo & " and "
            End If
            For x As Integer = 0 To Me.chlstMarketers.CheckedItems.Count - 1
                If x = 0 Then
                    MarkProdGeo = MarkProdGeo & "("
                End If
                If x <> Me.chlstMarketers.CheckedItems.Count - 1 Then

                    MarkProdGeo = MarkProdGeo & "(Rep1 = '" & Me.chlstMarketers.CheckedItems(x).ToString & "' or Rep2 = '" & Me.chlstMarketers.CheckedItems(x).ToString & "') or "    ''Add Comma after each item until last item 
                Else
                    MarkProdGeo = MarkProdGeo & "(Rep1 = '" & Me.chlstMarketers.CheckedItems(x).ToString & "' or Rep2 = '" & Me.chlstMarketers.CheckedItems(x).ToString & "'))"       ''Last Item Dont Add comma to end of where 
                End If
            Next
        End If

        ''Products
        If Me.chlstProducts.Items.Count <> Me.chlstProducts.CheckedItems.Count Then ''If true filter by checked products, if false no need to filter products (skip to next step)
            If MarkProdGeo <> "" Then
                MarkProdGeo = MarkProdGeo & " and "
            End If
            For x As Integer = 0 To Me.chlstProducts.CheckedItems.Count - 1
                If x = 0 Then
                    MarkProdGeo = MarkProdGeo & "("
                End If
                If x <> Me.chlstProducts.CheckedItems.Count - 1 Then

                    MarkProdGeo = MarkProdGeo & "(" & "Product1 = '" & Me.chlstProducts.CheckedItems(x).ToString & "' or Product2 = '" & Me.chlstProducts.CheckedItems(x).ToString & "' or Product3 = '" & Me.chlstProducts.CheckedItems(x).ToString & "') or "    ''Add Comma after each item until last item 
                Else
                    MarkProdGeo = MarkProdGeo & "(" & "Product1 = '" & Me.chlstProducts.CheckedItems(x).ToString & "' or Product2 = '" & Me.chlstProducts.CheckedItems(x).ToString & "' or Product3 = '" & Me.chlstProducts.CheckedItems(x).ToString & "'))"       ''Last Item Dont Add comma to end of where 
                End If
            Next
        End If

        ''Geo Tab 
        If Me.chlstZipCity.CheckedItems.Count > 0 Then
            If MarkProdGeo <> "" Then
                MarkProdGeo = MarkProdGeo & " and "
            End If
            Dim CorZ As String = ""
            If Me.rdoZip.Checked = True Then
                CorZ = "Zip"
            Else
                CorZ = "City"
            End If
            For x As Integer = 0 To Me.chlstZipCity.CheckedItems.Count - 1
                If x = 0 Then
                    MarkProdGeo = MarkProdGeo & "("
                End If
                If x <> Me.chlstZipCity.CheckedItems.Count - 1 Then

                    MarkProdGeo = MarkProdGeo & CorZ & " = '" & Me.chlstZipCity.CheckedItems(x).ToString & "' or "    ''Add Comma after each item until last item 
                Else
                    MarkProdGeo = MarkProdGeo & CorZ & " = '" & Me.chlstZipCity.CheckedItems(x).ToString & "')"       ''Last Item Dont Add comma to end of where 
                End If
            Next
        End If

        '' Recovery

        Dim Per As Double = 0
        If Me.numPar.Value <> 0 Then  ''Skip percentage from par portion of query
            Per = Me.numPar.Value / 100
            Per = 1 - Per
            Rehash = "(ParPrice <= (QuotedSold *" & Per & ") and ParPrice > 0)"
        End If
        If Me.txtQuoted.Text <> "" Then
            If Rehash <> "" Then
                Rehash = Rehash & " and "
            End If
            Dim Q As Integer = 0
            Q = CType(Me.txtQuoted.Text, Integer)
            Rehash = Rehash & "QuotedSold >= " & Q & " "
        End If
        If Me.chlstRehash.Items.Count > Me.chlstRehash.CheckedItems.Count Then
            For x As Integer = 0 To Me.chlstRehash.CheckedItems.Count - 1
                If x = 0 Then
                    If Rehash = "" Then
                        Rehash = Rehash & "("
                    Else
                        Rehash = Rehash & "and ("
                    End If
                End If
                Dim Field As String = ""
                If Me.chlstRehash.CheckedItems(x) = "Reset" Or Me.chlstRehash.CheckedItems(x) = "Not Hit" Or Me.chlstRehash.CheckedItems(x) = "Not Issued" Or Me.chlstRehash.CheckedItems(x) = "Demo/No Sale" Or Me.chlstRehash.CheckedItems(x) = "Recission Cancel" Then
                    Field = "Result"
                Else
                    Field = "MarketingResults"
                End If
                If x <> Me.chlstRehash.CheckedItems.Count - 1 Then

                    Rehash = Rehash & "(" & Field & " = '" & Me.chlstRehash.CheckedItems(x).ToString & "') or "    ''Add Comma after each item until last item 
                Else
                    Rehash = Rehash & "(" & Field & " = '" & Me.chlstRehash.CheckedItems(x).ToString & "'))"       ''Last Item Dont Add comma to end of where 
                End If
            Next
        End If
        If Rehash = "" Then
            Rehash = "tblWhereCanLeadGo.Recovery = 'True'"
        Else
            Rehash = Rehash & " and tblWhereCanLeadGo.Recovery = 'True'"
        End If

        ''Reconstruct Where Statement 
        If Rehash <> "" Then ''Constructs Query For Warm Calling 
            If DateQuery <> "" And MarkProdGeo <> "" Then
                Where = "(" & DateQuery & " and " & MarkProdGeo & " and " & Rehash & ")"
            ElseIf DateQuery <> "" And MarkProdGeo = "" Then
                Where = "(" & DateQuery & " and " & Rehash & ")"
            ElseIf DateQuery = "" And MarkProdGeo <> "" Then
                Where = "(" & MarkProdGeo & " and " & Rehash & ")"
            ElseIf DateQuery = "" And MarkProdGeo = "" Then
                Where = Rehash
            End If
        End If

        Where = " Where " & Where

        Slct = Slct & Where

        Dim cnn As SqlConnection = New SqlConnection(STATIC_VARIABLES.Cnn)
        Dim cmdGet As SqlCommand
        Dim r1 As SqlDataReader
        cmdGet = New SqlCommand(Slct, cnn)


        cmdGet.CommandType = CommandType.Text
        Try

            cnn.Open()
            r1 = cmdGet.ExecuteReader(CommandBehavior.CloseConnection)
            r1.Read()
            Me.txtRecordCount.Text = r1.Item(0)
            r1.Close()
            cnn.Close()

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default
        End Try
    End Sub

#End Region


#Region "Create Unified SQL State for Group / Sort Options"

    Private Function ConvertGroup(ByVal GroupVerbage As String, ByVal InitQuery As String, ByVal SortHeadings As ArrayList)
        '' in a single sort / group scenario this works
        '' fails for multi sort / and group scenario.
        '' need to take off the "ORDER BY ....asc/desc" on ALL fields selected for sort as well
        '' for subquery to pull uniques

        '' take array of headings, and look for them in initquery to strip them out of the "Order By clause for Unique query" 

        '' 4-3-2016 AC
        '' these need to be adjusted for "Recovery List"
        '' same premise though. . . 
        '' 
        '' Recovery Headers/Verbage:
        '' City, State **
        '' Zip Code **
        '' Appointment Date **
        '' Appointment Time **
        '' Products **
        '' Sales Rep *!*
        '' Sales Result *!*
        '' Marketing Result **
        '' Quoted Price *!*
        '' 

        '' ** = Original
        '' *! = Converted Not Swapped
        '' *!* = converted swapped

        Dim i As Integer = 0
        For i = 0 To SortHeadings.Count - 1
            Select Case SortHeadings(i)
                Case Is = "City, State" ' keep
                    InitQuery = InitQuery.ToString.Replace("City asc,", " ")
                    InitQuery = InitQuery.ToString.Replace("City desc,", " ")
                    InitQuery = InitQuery.ToString.Replace("State asc,", " ")
                    InitQuery = InitQuery.ToString.Replace("State desc,", " ")
                    InitQuery = InitQuery.ToString.Replace("City asc", " ")
                    InitQuery = InitQuery.ToString.Replace("City desc", " ")
                    InitQuery = InitQuery.ToString.Replace("State asc", " ")
                    InitQuery = InitQuery.ToString.Replace("State desc", " ")
                    Exit Select
                Case Is = "Zip Code" ' keep
                    InitQuery = InitQuery.ToString.Replace("Zip asc,", " ")
                    InitQuery = InitQuery.ToString.Replace("Zip desc,", " ")
                    InitQuery = InitQuery.ToString.Replace("Zip asc", " ")
                    InitQuery = InitQuery.ToString.Replace("Zip desc", " ")
                    Exit Select
                Case Is = "Sales Result" ' swapped [EnterLead].[Result]
                    InitQuery = InitQuery.ToString.Replace("Result asc,", " ")
                    InitQuery = InitQuery.ToString.Replace("Result desc,", " ")
                    InitQuery = InitQuery.ToString.Replace("Result asc", " ")
                    InitQuery = InitQuery.ToString.Replace("Result desc", " ")
                    Exit Select
                Case Is = "Appointment Date" ' keep
                    InitQuery = InitQuery.ToString.Replace("ApptDate asc,", " ")
                    InitQuery = InitQuery.ToString.Replace("ApptDate desc,", " ")
                    InitQuery = InitQuery.ToString.Replace("ApptDate asc", " ")
                    InitQuery = InitQuery.ToString.Replace("ApptDate desc", " ")
                    Exit Select
                Case Is = "Appointment Time" ' keep
                    InitQuery = InitQuery.ToString.Replace("ApptTime asc,", " ")
                    InitQuery = InitQuery.ToString.Replace("ApptTime desc,", " ")
                    InitQuery = InitQuery.ToString.Replace("ApptTime asc", " ")
                    InitQuery = InitQuery.ToString.Replace("ApptTime desc", " ")
                    Exit Select
                Case Is = "Products" ' keep
                    InitQuery = InitQuery.ToString.Replace("Product1 asc,", " ")
                    InitQuery = InitQuery.ToString.Replace("Product1 desc,", " ")
                    InitQuery = InitQuery.ToString.Replace("Product1 asc", " ")
                    InitQuery = InitQuery.ToString.Replace("Product1 desc", " ")
                    Exit Select
                Case Is = "Sales Rep" ' swapped [EnterLead].[Rep1]
                    InitQuery = InitQuery.ToString.Replace("Rep1 asc,", " ")
                    InitQuery = InitQuery.ToString.Replace("Rep1 desc,", " ")
                    InitQuery = InitQuery.ToString.Replace("Rep1 asc", " ")
                    InitQuery = InitQuery.ToString.Replace("Rep1 desc", " ")
                    Exit Select
                Case Is = "Marketing Result" ' keep 
                    InitQuery = InitQuery.ToString.Replace("MarketingResults asc,", " ")
                    InitQuery = InitQuery.ToString.Replace("MarketingResults desc,", " ")
                    InitQuery = InitQuery.ToString.Replace("MarketingResults asc", " ")
                    InitQuery = InitQuery.ToString.Replace("MarketingResults desc", " ")
                    Exit Select
                Case Is = "Quoted Price" ' added => [EnterLead].[QuotedSold]
                    InitQuery = InitQuery.ToString.Replace("QuotedSold asc,", " ")
                    InitQuery = InitQuery.ToString.Replace("QuotedSold desc,", " ")
                    InitQuery = InitQuery.ToString.Replace("QuotedSold asc", " ")
                    InitQuery = InitQuery.ToString.Replace("QuotedSold desc", " ")
                    Exit Select
                Case Else
                    Return InitQuery
                    Exit Select
            End Select
        Next



        '' Reconstruct for SubQuery
        '' 
        '' City, State ***
        '' Zip Code ***
        '' Appointment Date ***
        '' Appointment Time ***
        '' Products ***
        '' Sales Rep *!**
        '' Sales Result *!**
        '' Marketing Result ***
        '' Quoted Price *!**
        '' 

        '' ** = Original
        '' *! = Converted Not Swapped
        '' *!* = converted swapped


        Dim retSTR As String = ""
        Select Case GroupVerbage
            Case Is = "City, State"
                retSTR = "SELECT DISTINCT(City),State "
                InitQuery = InitQuery.ToString.Replace("Order By City asc", " ")
                InitQuery = InitQuery.ToString.Replace("Order By City desc", " ")
                Exit Select
            Case Is = "Zip Code"
                retSTR = "SELECT DISTINCT(Zip) "
                InitQuery = InitQuery.ToString.Replace("Order By Zip asc", " ")
                InitQuery = InitQuery.ToString.Replace("Order By Zip desc", " ")
                Exit Select
            Case Is = "Sales Result"
                retSTR = "SELECT DISTINCT(Result) "
                InitQuery = InitQuery.ToString.Replace("Order By Result asc", " ")
                InitQuery = InitQuery.ToString.Replace("Order By Result desc", " ")
                Exit Select
            Case Is = "Appointment Date"
                retSTR = "SELECT DISTINCT(ApptDate) "
                InitQuery = InitQuery.ToString.Replace("Order By ApptDate asc", " ")
                InitQuery = InitQuery.ToString.Replace("Order By ApptDate desc", " ")
                Exit Select
            Case Is = "Appointment Time"
                retSTR = "SELECT DISTINCT(ApptTime) "
                InitQuery = InitQuery.ToString.Replace("Order By ApptTime asc", " ")
                InitQuery = InitQuery.ToString.Replace("Order By ApptTime desc", " ")
                Exit Select
            Case Is = "Products"
                retSTR = "SELECT DISTINCT(Product1) "
                InitQuery = InitQuery.ToString.Replace("Order By Product1 asc", " ")
                InitQuery = InitQuery.ToString.Replace("Order By Product1 desc", " ")

                Exit Select
            Case Is = "Sales Rep"
                retSTR = "SELECT DISTINCT(Rep1) "
                InitQuery = InitQuery.ToString.Replace("Order By Rep1 asc", " ")
                InitQuery = InitQuery.ToString.Replace("Order By Rep1 desc", " ")
                Exit Select
            Case Is = "Marketing Result"
                retSTR = "SELECT DISTINCT(MarketingResults) "
                InitQuery = InitQuery.ToString.Replace("Order By MarketingResults asc", " ")
                InitQuery = InitQuery.ToString.Replace("Order By MarketingResults desc", " ")
                Exit Select
            Case Is = "Quoted Price"
                retSTR = "SELECT DISTINCT(QuotedSold) "
                InitQuery = InitQuery.ToString.Replace("Order By QuotedSold asc", " ")
                InitQuery = InitQuery.ToString.Replace("Order By QuotedSold desc", " ")
                Exit Select
            Case Else
                Return InitQuery
                Exit Select
        End Select

        InitQuery = InitQuery.Replace("Order By", " ")

        Dim tailEnd As String = ""
        Select Case GroupVerbage
            Case Is = "City, State"
                tailEnd = "Order By City asc"
                Exit Select
            Case Is = "Zip Code"
                tailEnd = "Order By Zip desc"
                Exit Select
            Case Is = "Sales Result"
                tailEnd = "Order By Result asc"
                Exit Select
            Case Is = "Appointment Date"
                tailEnd = "Order By ApptDate asc"
                Exit Select
            Case Is = "Appointment Time"
                tailEnd = "Order By ApptTime asc"
                Exit Select
            Case Is = "Products"
                tailEnd = "Order By Product1 asc"
                Exit Select
            Case Is = "Sales Rep"
                tailEnd = "Order By Rep1 asc"
                Exit Select
            Case Is = "Marketing Result"
                tailEnd = "Order By MarketingResults asc"
                Exit Select
            Case Is = "Quoted Price"
                tailEnd = "Order By QuotedSold desc"
                Exit Select
            Case Else
                tailEnd = ";"
                Exit Select
        End Select

        Dim SUB_QUERY_STR As String = (retSTR & " FROM (" & InitQuery & ") AS SUBQUERY " & tailEnd)

        Return SUB_QUERY_STR

    End Function

#End Region


End Class