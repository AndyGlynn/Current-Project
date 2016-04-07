Imports MapPoint


Public Class frmMappoint
    Private arResults As New ArrayList
    Private Sub frmMappoint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            PopulateCboSalesResults()
            Me.dtpBeginDate.Value = Date.Today
            Me.dtpEndDate.Value = Date.Today
            Me.rdoUserDefinedDateRange.Checked = True
            Me.cboCustomRange.Enabled = False
            Me.cboCustomRange.Items.AddRange(New Object() {"Today", "Yesterday", "This Week", "This Week - to date", "This Month", "This Month - to date", "This Year", "This Year - to date", "Next Week", "Next Month", "Last Week", "Last Week - to date", "Last Month", "Last Month - to date", "Last Year", "Last Year - to date"})
            Dim x As New MAPPOINT_LOGIC_V2
            Dim arStates As New ArrayList
            arStates = x.Get_Unique_States
            Dim b
            For Each b In arStates
                Me.cboPointAState.Items.Add(b)
                Me.cboPointBState.Items.Add(b)
            Next
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmMappoint", "FormCode", "Event", "frmMappoint_Load()", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim y As New MAPPOINT_LOGIC_V2
            y.Map_Single_Address(Me.txtStreetAddress.Text, Me.txtCity.Text, Me.txtState.Text, Me.txtZip.Text)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmMappoint", "FormCode", "Event", "Button1_Click", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnMapPointToPoint.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim y As New MAPPOINT_LOGIC_V2
            y.PointToPointDirections(Me.txtBeginAddress.Text, Me.txtBeginCity.Text, Me.txtBeginState.Text, Me.txtBeginZip.Text, Me.txtEndAddress.Text, Me.txtEndCity.Text, Me.txtEndState.Text, Me.txtEndZip.Text)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmMappoint", "FormCode", "Event", "Button2_Click", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub


    Private Sub PopulateCboSalesResults()
        Try
            Dim y As New MAPPOINT_LOGIC_V2
            arResults = y.Get_Unique_Sales_Results
            Dim i As Integer = 0
            Dim g As Object
            For Each g In arResults
                i += 1
            Next
            Dim a As Integer = 0
            For a = 0 To i - 1
                Me.cboSalesResults.Items.Add(arResults(a).ToString)
            Next
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmMappoint", "FormCode", "Event", "PopulateCboSalesResults()", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim strSelection As String = Me.cboSalesResults.Text
            Me.Cursor = Cursors.WaitCursor
            Select Case strSelection
                Case Is = "Sale"
                    Dim y As New MAPPOINT_LOGIC_V2
                    Dim arResults As List(Of MAPPOINT_LOGIC_V2.LeadToPlotSales)
                    arResults = y.Get_Leads_By_Result_Sales(Me.dtpBeginDate.Value.ToString, Me.dtpEndDate.Value.ToString)
                    y.PlotSales(arResults)
                    Exit Select
                Case Is = "Demo/No Sale"
                    Dim y As New MAPPOINT_LOGIC_V2
                    Dim arResults As List(Of MAPPOINT_LOGIC_V2.LeadToPlotDemoNoSale)
                    arResults = y.Get_Leads_By_Result_DemoNoSale(Me.dtpBeginDate.Value.ToString, Me.dtpEndDate.Value.ToString)
                    y.PlotDemoNoSale(arResults)
                    Exit Select
                Case Is = "Not Hit"
                    Dim y As New MAPPOINT_LOGIC_V2
                    Dim arResults As List(Of MAPPOINT_LOGIC_V2.LeadToPlotNotHit)
                    arResults = y.Get_Leads_By_Result_NotHit(Me.dtpBeginDate.Value.ToString, Me.dtpEndDate.Value.ToString)
                    y.PlotNotHot(arResults)
                    Exit Select
                Case Is = "Recission Cancel"
                    Dim y As New MAPPOINT_LOGIC_V2
                    Dim arResults As List(Of MAPPOINT_LOGIC_V2.LeadToPlotRecissionCancel)
                    arResults = y.Get_Leads_By_Result_RecissionCancel(Me.dtpBeginDate.Value.ToString, Me.dtpEndDate.Value.ToString)
                    y.PlotRecissionCancel(arResults)
                    Exit Select
                Case Is = "Reset"
                    Dim y As New MAPPOINT_LOGIC_V2
                    Dim arResults As List(Of MAPPOINT_LOGIC_V2.LeadToPlotReset)
                    arResults = y.Get_Leads_By_Result_Reset(Me.dtpBeginDate.Value.ToString, Me.dtpEndDate.Value.ToString)
                    y.PlotResets(arResults)
                    Exit Select
                Case Is = "No Demo"
                    Dim y As New MAPPOINT_LOGIC_V2
                    Dim arResults As List(Of MAPPOINT_LOGIC_V2.LeadToPlotNoDemo)
                    arResults = y.Get_Leads_By_Result_NoDemo(Me.dtpBeginDate.Value.ToString, Me.dtpEndDate.Value.ToString)
                    y.PlotNoDemo(arResults)
                    Exit Select
            End Select
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmMappoint", "FormCode", "Event", "Button3_Click", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    

    Private Sub txtLeadNumLookup_TextChanged(sender As Object, e As EventArgs) Handles txtLeadNumLookup.TextChanged
        Try
            Dim strNum As String = Me.txtLeadNumLookup.Text

            If Len(strNum) >= 1 Then
                Dim y As New MAPPOINT_LOGIC_V2
                Dim x As MAPPOINT_LOGIC_V2.SingleLeadLookup
                x = y.LookUpLeadNumberAddress(strNum)
                Me.txtStreetAddress.Text = x.StAddress
                Me.txtCity.Text = x.City
                Me.txtZip.Text = x.Zip
                Me.txtState.Text = x.State
            ElseIf Len(strNum) <= 0 Then
                Me.txtStreetAddress.Text = ""
                Me.txtCity.Text = ""
                Me.txtZip.Text = ""
                Me.txtState.Text = ""
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmMappoint", "FormCode", "Event", "txtLeadNumLookup_TextChanged", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub txtBeginLookup_TextChanged(sender As Object, e As EventArgs) Handles txtBeginLookup.TextChanged
        Try
            Dim strNum As String = Me.txtBeginLookup.Text

            If Len(strNum) >= 1 Then
                Dim y As New MAPPOINT_LOGIC_V2
                Dim x As MAPPOINT_LOGIC_V2.SingleLeadLookup
                x = y.LookUpLeadNumberAddress(strNum)
                Me.txtBeginAddress.Text = x.StAddress
                Me.txtBeginCity.Text = x.City
                Me.txtBeginZip.Text = x.Zip
                Me.txtBeginState.Text = x.State
            ElseIf Len(strNum) <= 0 Then
                Me.txtBeginAddress.Text = ""
                Me.txtBeginCity.Text = ""
                Me.txtBeginZip.Text = ""
                Me.txtBeginState.Text = ""
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmMappoint", "FormCode", "Event", "txtBeginLookup_TextChanged", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub txtDestinationLookup_TextChanged(sender As Object, e As EventArgs) Handles txtDestinationLookup.TextChanged
        Try
            Dim strNum As String = Me.txtDestinationLookup.Text

            If Len(strNum) >= 1 Then
                Dim y As New MAPPOINT_LOGIC_V2
                Dim x As MAPPOINT_LOGIC_V2.SingleLeadLookup
                x = y.LookUpLeadNumberAddress(strNum)
                Me.txtEndAddress.Text = x.StAddress
                Me.txtEndCity.Text = x.City
                Me.txtEndZip.Text = x.Zip
                Me.txtEndState.Text = x.State
            ElseIf Len(strNum) <= 0 Then
                Me.txtEndAddress.Text = ""
                Me.txtEndCity.Text = ""
                Me.txtEndZip.Text = ""
                Me.txtEndState.Text = ""
            End If

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmMappoint", "FormCode", "Event", "txtDestinationLookup_TextChanged", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub btnResetSingle_Click(sender As Object, e As EventArgs) Handles btnResetSingle.Click
        ResetSingle()
    End Sub

    Private Sub ResetSingle()
        Me.txtLeadNumLookup.Text = ""
        Me.txtStreetAddress.Text = ""
        Me.txtCity.Text = ""
        Me.txtZip.Text = ""
        Me.txtState.Text = ""
    End Sub

    Private Sub ResetPointToPoint()

        Me.txtBeginLookup.Text = ""
        Me.txtEndAddress.Text = ""
        Me.txtEndCity.Text = ""
        Me.txtEndZip.Text = ""
        Me.txtEndState.Text = ""

        Me.txtDestinationLookup.Text = ""
        Me.txtBeginAddress.Text = ""
        Me.txtBeginCity.Text = ""
        Me.txtBeginZip.Text = ""
        Me.txtBeginState.Text = ""
    End Sub

    Private Sub btnResetPointToPoint_Click(sender As Object, e As EventArgs) Handles btnResetPointToPoint.Click
        ResetPointToPoint()
    End Sub

    Private Sub rdoCustomDateRange_CheckedChanged(sender As Object, e As EventArgs) Handles rdoCustomDateRange.CheckedChanged
        Dim rdo As RadioButton = sender
        Dim checkState As Boolean = rdo.Checked
        Select Case checkState
            Case True
                Me.cboCustomRange.Enabled = True
                Me.dtpBeginDate.Enabled = False
                Me.dtpEndDate.Enabled = False
                Exit Select
            Case False
                Me.cboCustomRange.Enabled = False
                Me.dtpBeginDate.Enabled = True
                Me.dtpEndDate.Enabled = True
                Exit Select
            Case Else
                Me.dtpBeginDate.Enabled = False
                Me.dtpEndDate.Enabled = False
                Exit Select
        End Select
    End Sub

    Private Sub cboCustomRange_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCustomRange.SelectedIndexChanged
        Try
            Dim d As New DTPManipulation(Me.cboCustomRange.Text)
            Me.dtpBeginDate.Text = d.retDateFrom
            Me.dtpEndDate.Text = d.retDateTo
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmMappoint", "FormCode", "Event", "cboCustomRange_selectedIndexchanged", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Try
            Dim y As New MAPPOINT_LOGIC_V2
            Me.Cursor = Cursors.WaitCursor
            Dim obj As MAPPOINT_LOGIC_V2.DriveTimeAndDistance = y.GetDistanceBetweenCities(Me.txtPointA.Text, Me.cboPointAState.Text, Me.txtPointB.Text, Me.cboPointBState.Text)
            Me.txtDriveTime.Text = obj.DriveTime
            Me.txtDinMiles.Text = obj.Distance
            y = Nothing
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmMappoint", "FormCode", "Event", "btnCalc_Click", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    
    Private Sub btnMapSingle_Click(sender As Object, e As EventArgs) Handles btnMapSingle.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim y As New MAPPOINT_LOGIC_V2
            y.Map_Single_Address(Me.txtStreetAddress.Text, Me.txtCity.Text, Me.txtState.Text, Me.txtZip.Text)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmMappoint", "FormCode", "Event", "btnMapSingle_click", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub
End Class