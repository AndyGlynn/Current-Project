Public Class frmMappointEX

    '' \\server.greenworks.local\Company\ISS\PROTOTYPES\Mappoint\DataMap_Files
    '' C:\Users\Clay\Desktop\DataMap_Files


    Private coINFO As companyInfoSQL.CompanyAddress
    Private List_Of_SRes As List(Of String)
    Private List_Of_MRes As List(Of String)
    Private List_Of_City As List(Of String)

    Private SandMRecordGetter As generateDataSets
    Private list_of_Sales_Results As Dictionary(Of String, generateDataSets.RecordToPlot)
    Private list_of_Marketing_Results As Dictionary(Of String, generateDataSets.RecordToPlot)
    Private List_Of_Previous_Customers As Dictionary(Of String, generateDataSets.RecordToPlotSale)
    Private list_of_Unconfirmed As Dictionary(Of String, generateDataSets.RecordToPlot)

    Private PrimaryListToBePlotted As Dictionary(Of String, primaryVSsecondary.RecordToPlot)
    Private SecondaryListToBePlotted As Dictionary(Of String, primaryVSsecondary.RecordToPlot)

    Private ActiveTabPage As String = ""
    Private currentSelectionShape As MapPoint.Shape

    Private charType As MapPoint.GeoDataMapType

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.axTarget.ActiveMap.Saved = True
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            ActiveTabPage = "Single Result Plot"
            List_Of_MRes = New List(Of String)
            List_Of_SRes = New List(Of String)
            List_Of_City = New List(Of String)
            Dim z As New generateLists
            List_Of_MRes = z.Marketing_Results
            For Each a As String In List_Of_MRes
                Me.cboMarketingSPR.Items.Add(a)
            Next
            List_Of_SRes = z.Sales_Results
            For Each b As String In List_Of_SRes
                Me.cboSalesSPR.Items.Add(b)
            Next
            List_Of_City = z.City_List
            For Each c As String In List_Of_City
                Me.cboTargetCity.Items.Add(c)
            Next

            z = Nothing

            Application.DoEvents()
            bgGetDataSet_DoWork(Nothing, Nothing)

            SandMRecordGetter = New generateDataSets
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmMappointEX", "FormCode", "Event", "Load", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub



    Private Sub bgGetDataSet_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgGetDataSet.DoWork
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim y As New companyInfoSQL
            coINFO = y.Comp_Info
            Me.axTarget.NewMap(MapPoint.GeoMapRegion.geoMapNorthAmerica)
            Me.axTarget.Units = MapPoint.GeoUnits.geoMiles
            Me.axTarget.Toolbars(1).Visible = False
            Me.axTarget.Toolbars(2).Visible = False
            Me.axTarget.Toolbars(3).Visible = False
            Me.axTarget.Toolbars(4).Visible = False
            Dim oLoc As MapPoint.Location
            Dim oRes As MapPoint.FindResults = Me.axTarget.ActiveMap.FindAddressResults(coINFO.streetNumber & " " & coINFO.StreenName, coINFO.City, , coINFO.State, coINFO.Zip, MapPoint.GeoCountry.geoCountryUnitedStates)
            oLoc = oRes(1)
            Dim p As MapPoint.Pushpin = Me.axTarget.ActiveMap.AddPushpin(oLoc, coINFO.CompanyName)
            With p
                .BalloonState = MapPoint.GeoBalloonState.geoDisplayBalloon
                .Highlight = True
                .Symbol = 70
            End With

            Dim oLoc2 As MapPoint.Location
            Dim oRes2 As MapPoint.FindResults = Me.axTarget.ActiveMap.FindAddressResults(, coINFO.City, , coINFO.State, , MapPoint.GeoCountry.geoCountryUnitedStates)
            oLoc2 = oRes2(1)
            oLoc2.GoTo()
            Me.tslblStatus.Text = "Waiting. . ."
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Me.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmMappointEX", "FormCode", "Sub", "BgGetDataSet_DoWork", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub



    Private Sub rdoSales_CheckedChanged(sender As Object, e As EventArgs) Handles rdoSales.CheckedChanged
        If Me.rdoSales.Checked = True Then
            Me.cboSalesSPR.Enabled = True
            Me.lblSales.Enabled = True
            Me.lblMarketing.Enabled = False
            Me.cboMarketingSPR.Enabled = False
            Me.rdoMarketing.Checked = False
            Me.rdoPCs.Checked = False
        End If
    End Sub

    Private Sub rdoMarketing_CheckedChanged(sender As Object, e As EventArgs) Handles rdoMarketing.CheckedChanged
        If Me.rdoMarketing.Checked = True Then
            Me.cboMarketingSPR.Enabled = True
            Me.lblMarketing.Enabled = True
            Me.lblSales.Enabled = False
            Me.cboSalesSPR.Enabled = False
            Me.rdoSales.Checked = False
            Me.rdoPCs.Checked = False
        End If
    End Sub

    Private Sub cboSalesSPR_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSalesSPR.SelectedIndexChanged
        Try
            Dim cbo As ComboBox = sender
            Dim strChoice As String = cbo.Text
            list_of_Sales_Results = New Dictionary(Of String, generateDataSets.RecordToPlot)
            list_of_Sales_Results = SandMRecordGetter.Get_Sales_Results_Data_Set(Me.dtpBeginSPR.Value, Me.dtpEndSPR.Value, strChoice, Me.nmNumRecords.Value.ToString)
            bgPlotDataSet_DoWork(Nothing, Nothing)
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmMappointEX", "FormCode", "Event", "cboSalesSPR_SelectedIndexChanged", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub bgPlotDataSet_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgPlotDataSet.DoWork
        Try
            Me.Cursor = Cursors.WaitCursor
            Me.lsFound.Items.Clear()
            Me.lblContact.Text = ""
            Me.lblPhones.Text = ""
            Me.lblGeneratedOn.Text = ""
            Me.lblInterest.Text = ""
            For Each x As MapPoint.DataSet In Me.axTarget.ActiveMap.DataSets
                If Me.cboMarketingSPR.Enabled = True Then
                    If x.Name = Me.cboMarketingSPR.Text Then
                        x.Delete()
                    ElseIf x.Name <> Me.cboMarketingSPR.Text Then
                        x.PushpinsVisible = False
                    End If
                End If

                If Me.cboSalesSPR.Enabled = True Then
                    If x.Name = Me.cboSalesSPR.Text Then
                        x.Delete()
                    ElseIf x.Name <> Me.cboSalesSPR.Text Then
                        x.PushpinsVisible = False
                    End If
                End If

                If Me.rdoPCs.Enabled = True Then
                    If Me.rdoPCs.Checked = True Then
                        If x.Name = "Previous Customers" Then
                            x.Delete()
                        End If
                    End If
                End If
            Next
            Dim ds As MapPoint.DataSet

            If cboMarketingSPR.Enabled = True Then
                ds = Me.axTarget.ActiveMap.DataSets.AddPushpinSet(Me.cboMarketingSPR.Text)
                Me.tspbOperationProgress.Minimum = 0
                'Me.tspbOperationProgress.Value = 1
                Me.tspbOperationProgress.Maximum = list_of_Marketing_Results.Count
                Me.tslblStatus.Text = "Plotting Marketing DataSet. . . "
                Dim a
                For Each a In list_of_Marketing_Results
                    Dim record As generateDataSets.RecordToPlot = a.Value
                    Try
                        Dim oRes As MapPoint.FindResults
                        Dim oLoc As MapPoint.Location
                        oRes = Me.axTarget.ActiveMap.FindAddressResults(record.StAddress, record.City, , record.State, record.Zip, MapPoint.GeoCountry.geoCountryUnitedStates)
                        oLoc = oRes(1)
                        Dim p As MapPoint.Pushpin = Me.axTarget.ActiveMap.AddPushpin(oLoc, record.ID)
                        p.Symbol = 29
                        p.BalloonState = MapPoint.GeoBalloonState.geoDisplayNone
                        p.MoveTo(ds)
                        oRes = Nothing
                        oLoc = Nothing
                        p = Nothing
                        Dim lvItem As New ListViewItem
                        lvItem.Text = record.ID.ToString
                        Me.lsFound.Items.Add(lvItem)
                    Catch ex As Exception
                        Me.tspbOperationProgress.Increment(1)
                    End Try
                    Me.tspbOperationProgress.Increment(1)
                Next
                Me.lblPlotCount.Text = list_of_Marketing_Results.Count.ToString
                Me.tslblStatus.Text = "Waiting. . ."

            ElseIf Me.rdoPCs.Checked = True Then
                ds = Me.axTarget.ActiveMap.DataSets.AddPushpinSet("Previous Customers")
                Me.tspbOperationProgress.Minimum = 0
                ' Me.tspbOperationProgress.Value = 1
                Me.tspbOperationProgress.Maximum = List_Of_Previous_Customers.Count
                Me.tslblStatus.Text = "Plotting Previous Customers DataSet. . . "
                Dim a
                For Each a In List_Of_Previous_Customers
                    Dim record As generateDataSets.RecordToPlotSale = a.Value
                    Try
                        Dim oRes As MapPoint.FindResults
                        Dim oLoc As MapPoint.Location
                        Dim strNote As String = ""
                        strNote += vbCrLf
                        strNote += "ParPrice: " & record.ParPrice & vbCrLf
                        strNote += "QuotedSold:" & record.QuotedSold & vbCrLf
                        If record.Cash = True Then
                            strNote += "Cash: Yes" & vbCrLf
                        ElseIf record.Finance = True Then
                            strNote += "Finance: Yes"
                        End If
                        oRes = Me.axTarget.ActiveMap.FindAddressResults(record.StAddress, record.City, , record.State, record.Zip, MapPoint.GeoCountry.geoCountryUnitedStates)
                        oLoc = oRes(1)
                        Dim p As MapPoint.Pushpin = Me.axTarget.ActiveMap.AddPushpin(oLoc, record.ID)
                        p.Symbol = 120
                        p.Note = strNote
                        p.BalloonState = MapPoint.GeoBalloonState.geoDisplayNone
                        p.MoveTo(ds)
                        oRes = Nothing
                        oLoc = Nothing
                        p = Nothing
                        Dim lvItem As New ListViewItem
                        lvItem.Text = record.ID.ToString
                        Me.lsFound.Items.Add(lvItem)
                    Catch ex As Exception
                        Me.tspbOperationProgress.Increment(1)
                    End Try
                    Me.tspbOperationProgress.Increment(1)
                Next
                Me.lblPlotCount.Text = List_Of_Previous_Customers.Count.ToString
                Me.tslblStatus.Text = "Waiting. . ."


            ElseIf Me.cboSalesSPR.Enabled = True Then
                ds = Me.axTarget.ActiveMap.DataSets.AddPushpinSet(Me.cboSalesSPR.Text)
                Me.tspbOperationProgress.Minimum = 0
                'Me.tspbOperationProgress.Value = 1
                Me.tspbOperationProgress.Maximum = list_of_Sales_Results.Count
                Me.tslblStatus.Text = "Plotting Sales DataSet. . . "
                Dim a
                For Each a In list_of_Sales_Results
                    Dim record As generateDataSets.RecordToPlot = a.Value
                    Try
                        Dim oRes As MapPoint.FindResults
                        Dim oLoc As MapPoint.Location
                        oRes = Me.axTarget.ActiveMap.FindAddressResults(record.StAddress, record.City, , record.State, record.Zip, MapPoint.GeoCountry.geoCountryUnitedStates)
                        oLoc = oRes(1)
                        Dim p As MapPoint.Pushpin = Me.axTarget.ActiveMap.AddPushpin(oLoc, record.ID)
                        p.Symbol = 29
                        p.BalloonState = MapPoint.GeoBalloonState.geoDisplayNone
                        p.MoveTo(ds)
                        oRes = Nothing
                        oLoc = Nothing
                        p = Nothing
                        Dim lvItem As New ListViewItem
                        lvItem.Text = record.ID.ToString
                        Me.lsFound.Items.Add(lvItem)
                    Catch ex As Exception
                        Me.tspbOperationProgress.Increment(1)
                    End Try
                    Me.tspbOperationProgress.Increment(1)
                Next
                Me.lblPlotCount.Text = list_of_Sales_Results.Count.ToString
                Me.tslblStatus.Text = "Waiting. . ."
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmMappointEX", "FormCode", "Event", "bgPlotDataSet_DoWork", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub pnUP_Click(sender As Object, e As EventArgs) Handles pnUP.Click
        Me.axTarget.ActiveMap.Pan(MapPoint.GeoPanCmd.geoNorth)
    End Sub

    Private Sub pnDown_Click(sender As Object, e As EventArgs) Handles pnDown.Click
        Me.axTarget.ActiveMap.Pan(MapPoint.GeoPanCmd.geoSouth)
    End Sub

    Private Sub pnLeft_Click(sender As Object, e As EventArgs) Handles pnLeft.Click
        Me.axTarget.ActiveMap.Pan(MapPoint.GeoPanCmd.geoWest)
    End Sub

    Private Sub pnRight_Click(sender As Object, e As EventArgs) Handles pnRight.Click
        Me.axTarget.ActiveMap.Pan(MapPoint.GeoPanCmd.geoEast)
    End Sub

    Private Sub zoomOut_Click(sender As Object, e As EventArgs) Handles zoomOut.Click
        Me.axTarget.ActiveMap.ZoomOut()
    End Sub

    Private Sub zoomIn_Click(sender As Object, e As EventArgs) Handles zoomIn.Click
        Me.axTarget.ActiveMap.ZoomIn()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.axTarget.ActiveMap.Pan(MapPoint.GeoPanCmd.geoNorthWest)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.axTarget.ActiveMap.Pan(MapPoint.GeoPanCmd.geoNorthEast)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.axTarget.ActiveMap.Pan(MapPoint.GeoPanCmd.geoSouthWest)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.axTarget.ActiveMap.Pan(MapPoint.GeoPanCmd.geoSouthEast)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'Dim oLoc As MapPoint.Location
        'Dim oRes As MapPoint.FindResults = Me.axTarget.ActiveMap.FindAddressResults(coINFO.streetNumber & " " & coINFO.StreenName, coINFO.City, , coINFO.State, coINFO.Zip, MapPoint.GeoCountry.geoCountryUnitedStates)
        'oLoc = oRes(1)
        'Dim p As MapPoint.Pushpin = Me.axTarget.ActiveMap.AddPushpin(oLoc, coINFO.CompanyName)
        'With p
        '    .BalloonState = MapPoint.GeoBalloonState.geoDisplayBalloon
        '    .Highlight = True
        '    .Symbol = 70
        'End With
        Try
            Dim oLoc2 As MapPoint.Location
            Dim oRes2 As MapPoint.FindResults = Me.axTarget.ActiveMap.FindAddressResults(, coINFO.City, , coINFO.State, , MapPoint.GeoCountry.geoCountryUnitedStates)
            oLoc2 = oRes2(1)
            oLoc2.GoTo()
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmMappointEX", "FormCode", "Event", "Button6_Click", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub lsFound_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsFound.SelectedIndexChanged
        Try
            Dim lView As ListView = sender
            For Each item As ListViewItem In lView.Items
                If item.Selected = True Then
                    Dim x As quickINFO.QuickInfo
                    Dim z As New quickINFO(item.Text)
                    x = z.Single_Rec
                    Me.lblContact.Text = (x.C1FName & " " & x.C1LName & vbCrLf & x.C2FName & " " & x.C2LName)
                    Me.lblPhones.Text = (x.HousePhone & vbCrLf & x.AltPhone1 & vbCrLf & x.AltPhone2)
                    Me.lblInterest.Text = (x.P1 & vbCrLf & x.P2 & x.P3)
                    Me.lblGeneratedOn.Text = x.LeadGenOn
                    Dim p As MapPoint.Pushpin = Me.axTarget.ActiveMap.FindPushpin(item.Text)
                    p.Highlight = True
                    p.BalloonState = MapPoint.GeoBalloonState.geoDisplayBalloon
                    p.Location.GoTo()
                    z = Nothing
                End If
            Next
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmMappointEX", "FormCode", "Event", "lsFound_SelectedINdexChanged", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub axTarget_SelectionChange(sender As Object, e As AxMapPoint._IMappointCtrlEvents_SelectionChangeEvent) Handles axTarget.SelectionChange
        Try
            Select Case ActiveTabPage
                Case Is = "Single Result Plot"
                    Dim p As Object = e.pNewSelection
                    Dim xx As Object = e.pOldSelection
                    If TypeOf (xx) Is MapPoint.Pushpin Then
                        xx.balloonstate = MapPoint.GeoBalloonState.geoDisplayNone
                    End If
                    Exit Select
                Case Is = "Data Maps"
                    Dim p As Object = e.pNewSelection
                    Dim xx As Object = e.pOldSelection
                    If TypeOf (xx) Is MapPoint.Pushpin Then
                        xx.balloonstate = MapPoint.GeoBalloonState.geoDisplayNone
                    End If
                    Exit Select
                Case Is = "Radius Plotting"
                    '' need to draw a radius on selection here
                    '' 
                    Dim p As Object = e.pNewSelection
                    If TypeOf (p) Is MapPoint.Pushpin Then
                        Dim y As MapPoint.Pushpin = p
                        Dim sh As MapPoint.Shape
                        For Each sh In Me.axTarget.ActiveMap.Shapes
                            sh.Delete()
                        Next

                        If Me.nmRadiusPlot.Value <= 0 Then
                            MsgBox("You must select a radius to search from on the current map.", MsgBoxStyle.Critical, "No Radius Defined.")
                            Exit Sub
                        End If
                        Dim loc As MapPoint.Location = y.Location
                        Dim oShape As MapPoint.Shape
                        oShape = Me.axTarget.ActiveMap.Shapes.AddShape(MapPoint.GeoAutoShapeType.geoShapeRadius, loc, Me.nmRadiusPlot.Value, Me.nmRadiusPlot.Value)
                        currentSelectionShape = oShape
                        Me.btnXReference.Enabled = True
                        Me.chkSecondaryDataSet.Enabled = True
                    End If
                    Exit Select
                Case Is = "References"
                    Dim p As Object = e.pNewSelection
                    Dim xx As Object = e.pOldSelection
                    If TypeOf (xx) Is MapPoint.Pushpin Then
                        xx.balloonstate = MapPoint.GeoBalloonState.geoDisplayNone
                    End If
                    Exit Select
                Case Is = "Drive Time And Distances"
                    Dim p As Object = e.pNewSelection
                    Dim xx As Object = e.pOldSelection
                    If TypeOf (xx) Is MapPoint.Pushpin Then
                        xx.balloonstate = MapPoint.GeoBalloonState.geoDisplayNone
                    End If
                    Exit Select
            End Select

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmMappointEX", "FormCode", "Event", "axTarget_SelectionChange", "0", ex.Message.ToString)
            y = Nothing
        End Try


    End Sub

    Private Sub cboMarketingSPR_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMarketingSPR.SelectedIndexChanged
        Try
            Dim cbo As ComboBox = sender
            Dim strChoice As String = cbo.Text
            list_of_Marketing_Results = New Dictionary(Of String, generateDataSets.RecordToPlot)
            list_of_Marketing_Results = SandMRecordGetter.Get_Marketing_Results_Data_Set(Me.dtpBeginSPR.Value, Me.dtpEndSPR.Value, strChoice, Me.nmNumRecords.Value.ToString)
            bgPlotDataSet_DoWork(Nothing, Nothing)
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmMappointEX", "FormCode", "Event", "cboMarketingSPR", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub SeparateMapToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeparateMapToolStripMenuItem.Click
        Try
            Select Case ActiveTabPage
                Case Is = "Radius Plotting"
                    Dim lView As ListView = Me.lsRadiusFound
                    For Each item As ListViewItem In lView.Items
                        If item.Selected = True Then
                            Dim g As New launchSeparateMap(item.Text)
                            g = Nothing
                        End If
                    Next
                Case Is = "Single Result Plot"
                    Dim lView As ListView = Me.lsFound
                    For Each item As ListViewItem In lView.Items
                        If item.Selected = True Then
                            Dim g As New launchSeparateMap(item.Text)
                            g = Nothing
                        End If
                    Next
                    Exit Select
            End Select
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmMappointEX", "FormCode", "Event", "SeparateMapToolStripMenuItem_Click", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub rdoPCs_CheckedChanged(sender As Object, e As EventArgs) Handles rdoPCs.CheckedChanged
        Try
            If Me.rdoPCs.Checked = True Then
                Me.cboSalesSPR.Enabled = False
                Me.lblSales.Enabled = False
                Me.lblMarketing.Enabled = False
                Me.cboMarketingSPR.Enabled = False
                Me.rdoMarketing.Checked = False

                List_Of_Previous_Customers = New Dictionary(Of String, generateDataSets.RecordToPlotSale)
                List_Of_Previous_Customers = SandMRecordGetter.Get_Previous_Customers_Data_Set(Me.dtpBeginSPR.Value, Me.dtpEndSPR.Value, Me.nmNumRecords.Value.ToString)
                bgPlotDataSet_DoWork(Nothing, Nothing)

            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmMappointEX", "FormCode", "Event", "rdoPCs_CheckChanged", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each x As MapPoint.DataSet In Me.axTarget.ActiveMap.DataSets
            x.PushpinsVisible = False
            x.Delete()
        Next
        For Each y As MapPoint.Shape In Me.axTarget.ActiveMap.Shapes
            y.Delete()
            currentSelectionShape = Nothing
            btnXReference.Enabled = False
        Next
        Me.lsFound.Items.Clear()
        Me.lblPhones.Text = ""
        Me.lblContact.Text = ""
        Me.lblGeneratedOn.Text = ""
        Me.lblInterest.Text = ""
        Me.rdoSales.Checked = False
        Me.rdoMarketing.Checked = False
        Me.rdoPCs.Checked = False
        Me.dtpBeginSPR.Value = Date.Today.ToShortDateString
        Me.dtpEndSPR.Value = Date.Today.ToShortDateString
        Me.lblPlotCount.Text = ""
        Me.cboSalesSPR.Text = ""
        Me.cboMarketingSPR.Text = ""
        Me.cboSalesSPR.Enabled = False
        Me.cboMarketingSPR.Enabled = False
        Me.nmNumRecords.Value = 100
        Me.nmPvsSRecords.Value = 100
        Me.nmRadiusPlot.Value = 5
        Me.chkSecondaryDataSet.Enabled = False
        Me.lsRadiusFound.Items.Clear()

    End Sub

    Private Sub btnGenDataMap_Click(sender As Object, e As EventArgs) Handles btnGenDataMap.Click
        Me.Cursor = Cursors.WaitCursor
        Dim whichONe As String = ""
        If Me.grpDataOptions.Enabled = True Then
            whichONe = "Marketing"
        ElseIf Me.grpDataOptionsSales.Enabled = True Then
            whichONe = "Sales"
        End If
        Select Case whichONe
            Case Is = "Marketing"
                bgDM_DoWork(Nothing, Nothing)
                Exit Select
            Case Is = "Sales"
                bgDMSalesResults_DoWork(Nothing, Nothing)
                Exit Select
            Case Else
                MsgBox("Please check your selections again. Some Items are missing.", MsgBoxStyle.Critical, "Error")
                Exit Select
        End Select
        Me.Cursor = Cursors.Default
    End Sub


    Private Sub chkFocusTargetCity_CheckedChanged(sender As Object, e As EventArgs) Handles chkFocusTargetCity.CheckedChanged
        If Me.chkFocusTargetCity.Checked = True Then
            Me.cboTargetCity.Enabled = True
        ElseIf Me.chkFocusTargetCity.Checked = False Then
            Me.cboTargetCity.Enabled = False
        End If
    End Sub

    Private Sub cboCityStateFlag_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCityStateFlag.SelectedIndexChanged
        Dim cbo As ComboBox = sender
        Dim strCHoice As String = cbo.Text
        Select Case strCHoice
            Case Is = "City"
                Me.chkFocusTargetCity.Enabled = True
                Me.chkFocusTargetCity.Checked = False
                Me.cboTargetCity.Enabled = True
                Me.cboTargetCity.Text = ""
                Exit Select
            Case Is = "State"
                Me.chkFocusTargetCity.Enabled = False
                Me.chkFocusTargetCity.Checked = False
                Me.cboTargetCity.Enabled = False
                Me.cboTargetCity.Text = ""
                Exit Select
        End Select
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rdoPie.CheckedChanged
        If Me.rdoPie.Checked = True Then
            Me.rdoColumn.Checked = False
            charType = MapPoint.GeoDataMapType.geoDataMapTypeUnsizedPie
        End If
    End Sub

    Private Sub rdoColumn_CheckedChanged(sender As Object, e As EventArgs) Handles rdoColumn.CheckedChanged
        If Me.rdoColumn.Checked = True Then
            Me.rdoPie.Checked = False
            charType = MapPoint.GeoDataMapType.geoDataMapTypeCategoricalColumn
        End If
    End Sub

    Private Sub bgDM_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgDM.DoWork
        Try
            Me.Cursor = Cursors.WaitCursor
            ' Me.tspbOperationProgress.Value = 1
            Me.tspbOperationProgress.Maximum = 5

            Dim arColumnHeadings As New List(Of String)
            For Each x As CheckBox In Me.grpDataOptions.Controls
                If x.Checked = True Then
                    arColumnHeadings.Add(x.Text)
                End If
            Next
            Me.tspbOperationProgress.Increment(1)
            Me.tslblStatus.Text = "Generating Columns. . ."
            Application.DoEvents()
            Dim strFocusCity As String = ""
            If Me.cboTargetCity.Enabled = True Then
                strFocusCity = Me.cboTargetCity.Text
                If strFocusCity = "" Then
                    strFocusCity = "NONE"
                End If
            ElseIf Me.cboTargetCity.Enabled = False Then
                strFocusCity = "NONE"
            End If
            Me.tspbOperationProgress.Increment(1)
            Me.tslblStatus.Text = "Setting Options. . . "

            Me.tspbOperationProgress.Increment(1)
            Me.tslblStatus.Text = "Generating Data . . ."
            Application.DoEvents()
            Dim strCityStateFlag As String = Me.cboCityStateFlag.Text
            Dim y As New generateCSVForDataMap(arColumnHeadings, Me.dtpBeginDM.Value, Me.dtpEndDM.Value, strCityStateFlag, strFocusCity, "Marketing")
            Dim file_path As String = y.FilePath

            Dim dm As MapPoint.DataMap
            Dim lColorRange As Long = 15
            Dim ds As MapPoint.DataSet = Me.axTarget.ActiveMap.DataSets.ImportData(file_path, , MapPoint.GeoCountry.geoCountryUnitedStates, MapPoint.GeoDelimiter.geoDelimiterComma, 0)
            Me.tspbOperationProgress.Increment(1)
            Me.tslblStatus.Text = "Creating DataSets. . . "
            Application.DoEvents()
            Dim arFLDS(arColumnHeadings.Count)
            Dim iteration As Integer = 0
            For Each item As String In arColumnHeadings
                iteration += 1
            Next
            ReDim arFLDS(iteration - 1)
            iteration = 0
            For Each item As String In arColumnHeadings
                iteration += 1
                If item IsNot Nothing Then
                    arFLDS(iteration - 1) = ds.Fields(item)
                End If
            Next

            Dim flag As MapPoint.GeoShowDataBy
            Dim legendTitle As String = ""
            Select Case Me.cboCityStateFlag.Text
                Case Is = "City"
                    flag = MapPoint.GeoShowDataBy.geoShowByCity
                    legendTitle = "Results By City"
                Case Is = "State"
                    flag = MapPoint.GeoShowDataBy.geoShowByRegion1
                    legendTitle = "Results By State"
            End Select

            dm = ds.DisplayDataMap(charType, arFLDS, flag, , , , 15)
            dm.LegendTitle = legendTitle

            If Me.chkFocusTargetCity.Checked = False Then
                If Me.cboCityStateFlag.Text = "State" Then
                    Dim ores As MapPoint.FindResults
                    Dim oloc As MapPoint.Location

                    ores = Me.axTarget.ActiveMap.FindAddressResults(, , , coINFO.State, , MapPoint.GeoCountry.geoCountryUnitedStates)
                    oloc = ores(1)
                    oloc.GoTo()
                    Me.axTarget.ActiveMap.Altitude = 1500
                End If
            ElseIf Me.chkFocusTargetCity.Checked = True Then
                Dim cityState() = Split(Me.cboTargetCity.Text, "-", -1, Microsoft.VisualBasic.CompareMethod.Text.Text)
                Dim cty As String = cityState(0)
                Dim st As String = cityState(1)
                If Me.cboTargetCity.Text <> "" Then
                    Dim ores As MapPoint.FindResults
                    Dim oloc As MapPoint.Location
                    ores = Me.axTarget.ActiveMap.FindAddressResults(, cty, , st, , MapPoint.GeoCountry.geoCountryUnitedStates)
                    oloc = ores(1)
                    Dim p As MapPoint.Pushpin = Me.axTarget.ActiveMap.AddPushpin(oloc, cty)
                    p.BalloonState = MapPoint.GeoBalloonState.geoDisplayBalloon
                    p.Highlight = True
                    p.Location.GoTo()
                    Me.axTarget.ActiveMap.Altitude = 50
                End If
            End If
            Me.tspbOperationProgress.Increment(1)
            Me.tslblStatus.Text = "Waiting. . . "
            Application.DoEvents()
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmMappointEX", "FormCode", "Event", "bgDM_DoWork", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Me.axTarget.ActiveMap.Pan(MapPoint.GeoPanCmd.geoNorth)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Me.axTarget.ActiveMap.Pan(MapPoint.GeoPanCmd.geoSouth)
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Me.axTarget.ActiveMap.Pan(MapPoint.GeoPanCmd.geoWest)
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Me.axTarget.ActiveMap.Pan(MapPoint.GeoPanCmd.geoEast)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.axTarget.ActiveMap.Pan(MapPoint.GeoPanCmd.geoNorthWest)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.axTarget.ActiveMap.Pan(MapPoint.GeoPanCmd.geoNorthEast)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.axTarget.ActiveMap.Pan(MapPoint.GeoPanCmd.geoSouthWest)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.axTarget.ActiveMap.Pan(MapPoint.GeoPanCmd.geoSouthEast)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Me.axTarget.ActiveMap.ZoomOut()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Me.axTarget.ActiveMap.ZoomIn()
    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        Dim oLoc2 As MapPoint.Location
        Dim oRes2 As MapPoint.FindResults = Me.axTarget.ActiveMap.FindAddressResults(, coINFO.City, , coINFO.State, , MapPoint.GeoCountry.geoCountryUnitedStates)
        oLoc2 = oRes2(1)
        oLoc2.GoTo()
    End Sub

    Private Sub rdoSalesDM_CheckedChanged(sender As Object, e As EventArgs) Handles rdoSalesDM.CheckedChanged
        If Me.rdoSalesDM.Checked = True Then
            Me.rdoMarketingDM.Checked = False
            Me.grpDataOptions.Enabled = False
            Me.grpDataOptionsSales.Enabled = True
        End If
    End Sub

    Private Sub rdoMarketingDM_CheckedChanged(sender As Object, e As EventArgs) Handles rdoMarketingDM.CheckedChanged
        If Me.rdoMarketingDM.Checked = True Then
            Me.rdoSalesDM.Checked = False
            Me.grpDataOptionsSales.Enabled = False
            Me.grpDataOptions.Enabled = True
        End If
    End Sub

    Private Sub bgDMSalesResults_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgDMSalesResults.DoWork
        'Me.tspbOperationProgress.Value = 1
        Try
            Me.Cursor = Cursors.WaitCursor
            Me.tspbOperationProgress.Maximum = 5

            Dim arColumnHeadings As New List(Of String)
            For Each x As CheckBox In Me.grpDataOptionsSales.Controls
                If x.Checked = True Then
                    arColumnHeadings.Add(x.Text)
                End If
            Next
            Me.tspbOperationProgress.Increment(1)
            Me.tslblStatus.Text = "Generating Columns. . ."
            Application.DoEvents()
            Dim strFocusCity As String = ""
            If Me.cboTargetCity.Enabled = True Then
                strFocusCity = Me.cboTargetCity.Text
                If strFocusCity = "" Then
                    strFocusCity = "NONE"
                End If
            ElseIf Me.cboTargetCity.Enabled = False Then
                strFocusCity = "NONE"
            End If
            Me.tspbOperationProgress.Increment(1)
            Me.tslblStatus.Text = "Setting Options. . . "

            Me.tspbOperationProgress.Increment(1)
            Me.tslblStatus.Text = "Generating Data . . ."
            Application.DoEvents()
            Dim strCityStateFlag As String = Me.cboCityStateFlag.Text
            Dim y As New generateCSVForDataMap(arColumnHeadings, Me.dtpBeginDM.Value, Me.dtpEndDM.Value, strCityStateFlag, strFocusCity, "Sales")
            Dim file_path As String = y.FilePath

            Dim dm As MapPoint.DataMap
            Dim lColorRange As Long = 15
            Dim ds As MapPoint.DataSet = Me.axTarget.ActiveMap.DataSets.ImportData(file_path, , MapPoint.GeoCountry.geoCountryUnitedStates, MapPoint.GeoDelimiter.geoDelimiterComma, 0)
            Me.tspbOperationProgress.Increment(1)
            Me.tslblStatus.Text = "Creating DataSets. . . "
            Application.DoEvents()
            Dim arFLDS(arColumnHeadings.Count)
            Dim iteration As Integer = 0
            For Each item As String In arColumnHeadings
                iteration += 1
            Next
            ReDim arFLDS(iteration - 1)
            iteration = 0
            For Each item As String In arColumnHeadings
                iteration += 1
                If item IsNot Nothing Then
                    arFLDS(iteration - 1) = ds.Fields(item)
                End If
            Next

            Dim flag As MapPoint.GeoShowDataBy
            Dim legendTitle As String = ""
            Select Case Me.cboCityStateFlag.Text
                Case Is = "City"
                    flag = MapPoint.GeoShowDataBy.geoShowByCity
                    legendTitle = "Results By City"
                Case Is = "State"
                    flag = MapPoint.GeoShowDataBy.geoShowByRegion1
                    legendTitle = "Results By State"
            End Select

            dm = ds.DisplayDataMap(charType, arFLDS, flag, , , , 15)
            dm.LegendTitle = legendTitle

            If Me.chkFocusTargetCity.Checked = False Then
                If Me.cboCityStateFlag.Text = "State" Then
                    Dim ores As MapPoint.FindResults
                    Dim oloc As MapPoint.Location

                    ores = Me.axTarget.ActiveMap.FindAddressResults(, , , coINFO.State, , MapPoint.GeoCountry.geoCountryUnitedStates)
                    oloc = ores(1)
                    oloc.GoTo()
                    Me.axTarget.ActiveMap.Altitude = 1500
                End If
            ElseIf Me.chkFocusTargetCity.Checked = True Then
                Dim cityState() = Split(Me.cboTargetCity.Text, "-", -1, Microsoft.VisualBasic.CompareMethod.Text)
                Dim cty As String = cityState(0)
                Dim st As String = cityState(1)
                If Me.cboTargetCity.Text <> "" Then
                    Dim ores As MapPoint.FindResults
                    Dim oloc As MapPoint.Location
                    ores = Me.axTarget.ActiveMap.FindAddressResults(, cty, , st, , MapPoint.GeoCountry.geoCountryUnitedStates)
                    oloc = ores(1)
                    Dim p As MapPoint.Pushpin = Me.axTarget.ActiveMap.AddPushpin(oloc, cty)
                    p.BalloonState = MapPoint.GeoBalloonState.geoDisplayBalloon
                    p.Highlight = True
                    p.Location.GoTo()
                    Me.axTarget.ActiveMap.Altitude = 50
                End If
            End If
            Me.tspbOperationProgress.Increment(1)
            Me.tslblStatus.Text = "Waiting. . . "
            Application.DoEvents()
            Me.Cursor = Cursors.WaitCursor
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmMappointEX", "FormCode", "Event", "bgDMSalesResults_DoWork", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub btnGenerateRadius_Click(sender As Object, e As EventArgs) Handles btnGenerateRadius.Click


        Try
            Dim arQueryItems As New ArrayList

            Dim i As Integer = 0
            For i = 0 To Me.chkListPrimaryDataSet.CheckedItems.Count - 1
                arQueryItems.Add(chkListPrimaryDataSet.CheckedItems(i).ToString)
            Next
            i = 0

            Dim x As New primaryVSsecondary(Me.dtpPvsSBegin.Value, Me.dtpPvsSEnd.Value, arQueryItems, Me.nmPvsSRecords.Value)
            Dim Pri_List As New Dictionary(Of String, primaryVSsecondary.RecordToPlot)
            Pri_List = x.Primary_List

            PrimaryListToBePlotted = New Dictionary(Of String, primaryVSsecondary.RecordToPlot)
            PrimaryListToBePlotted = Pri_List

            bgPlotPriAndSecDSETS_DoWork(Nothing, Nothing)
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmMappointEX", "FormCode", "Event", "btnGenerateRaidus_Click", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub bgPlotPriAndSecDSETS_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgPlotPriDSETS.DoWork
        Try
            Me.Cursor = Cursors.WaitCursor
            For Each y As MapPoint.DataSet In Me.axTarget.ActiveMap.DataSets
                If y.Name = "PriDSET" Then
                    y.Delete()
                End If

            Next

            Me.tslblStatus.Text = "Generating Primary DataSet..."


            Dim ds As MapPoint.DataSet = Me.axTarget.ActiveMap.DataSets.AddPushpinSet("PriDSET")
            Dim cnt As Integer = PrimaryListToBePlotted.Count
            Dim oMap As MapPoint.Map = Me.axTarget.ActiveMap

            Me.tspbOperationProgress.Maximum = cnt
            Me.tspbOperationProgress.Minimum = 1
            Dim x
            For Each x In PrimaryListToBePlotted
                Try
                    Dim id As String = x.Key
                    Dim g As primaryVSsecondary.RecordToPlot = x.Value
                    Dim oLoc As MapPoint.Location
                    Dim oRes As MapPoint.FindResults = oMap.FindAddressResults(g.StAddress, g.City, , g.State, g.Zip, MapPoint.GeoCountry.geoCountryUnitedStates)
                    oLoc = oRes(1)
                    Dim p As MapPoint.Pushpin = oMap.AddPushpin(oLoc, g.ID)
                    With p
                        .BalloonState = MapPoint.GeoBalloonState.geoDisplayNone
                        .Note = ("------" & vbCrLf & g.Result & vbCrLf & "------")
                        Select Case g.Result
                            Case Is = "Not Issued"
                                .Symbol = 77
                                Exit Select
                            Case Is = "Reset"
                                .Symbol = 22
                                Exit Select
                            Case Is = "Recission Cancel"
                                .Symbol = 78
                                Exit Select
                            Case Is = "Sale"
                                .Symbol = 120
                                Exit Select
                            Case Is = "Bank Rejected"
                                .Symbol = 25
                                Exit Select
                            Case Is = "Demo/No Sale"
                                .Symbol = 204
                                Exit Select
                            Case Is = "Lost Result"
                                .Symbol = 103
                                Exit Select
                            Case Is = "No Demo"
                                .Symbol = 181
                                Exit Select
                            Case Is = "Not Hit"
                                .Symbol = 183
                                Exit Select
                            Case Is = "Kill"
                                .Symbol = 134
                                Exit Select
                            Case Is = "Confirmed"
                                .Symbol = 132
                                Exit Select
                            Case Is = "Called And Cancelled"
                                .Symbol = 211
                                Exit Select
                            Case Is = "Unconfirmed"
                                .Symbol = 184
                                Exit Select
                        End Select
                    End With
                    p.MoveTo(ds)
                Catch ex As Exception
                    Me.tspbOperationProgress.Increment(1)
                    Application.DoEvents()
                End Try
                Me.tspbOperationProgress.Increment(1)
                Application.DoEvents()
            Next

            Me.tslblStatus.Text = "Waiting . . . "

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmMappointEX", "FormCode", "Event", "bgPlotPriDSETS_DoWork", "0", ex.Message.ToString)
            y = Nothing
        End Try


    End Sub


    Private Sub tbMain_Click(sender As Object, e As EventArgs) Handles tbMain.Click
        Dim tab As TabControl = sender
        Dim idx As String = ""
        idx = tab.SelectedTab.Text
        ActiveTabPage = idx
        ' MsgBox(ActiveTabPage)
    End Sub

    Private Sub btnXReference_Click(sender As Object, e As EventArgs) Handles btnXReference.Click
        Try
            Dim cnt As Integer = 0
            Dim ii
            For ii = 0 To Me.chkSecondaryDataSet.CheckedItems.Count - 1
                cnt += 1
            Next
            If cnt <= 0 Then
                MsgBox("You must select at least one type of lead to search for.", MsgBoxStyle.Critical, "No Secondary Lead Type(s) selected.")
                Exit Sub
            End If

            Dim arQueryItems As New ArrayList

            Dim i As Integer = 0
            For i = 0 To Me.chkSecondaryDataSet.CheckedItems.Count - 1
                arQueryItems.Add(chkSecondaryDataSet.CheckedItems(i).ToString)
            Next
            i = 0

            Dim x As New primaryVSsecondary(Me.dtpPvsSBegin.Value, Me.dtpPvsSEnd.Value, arQueryItems, Me.nmPvsSRecords.Value)
            Dim Sec_List As New Dictionary(Of String, primaryVSsecondary.RecordToPlot)
            Sec_List = x.Secondary_List

            SecondaryListToBePlotted = New Dictionary(Of String, primaryVSsecondary.RecordToPlot)
            SecondaryListToBePlotted = Sec_List

            bgPlotSecDSETS_DoWork(Nothing, Nothing)
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmMappointEX", "FormCode", "Event", "btnXREFERENCE_Click", "0", ex.Message.ToString)
            y = Nothing
        End Try


    End Sub

    Private Sub bgPlotSecDSETS_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgPlotSecDSETS.DoWork
        Try
            Me.Cursor = Cursors.WaitCursor
            For Each y As MapPoint.DataSet In Me.axTarget.ActiveMap.DataSets
                If y.Name = "SecDSET" Then
                    y.Delete()
                End If

            Next

            If currentSelectionShape Is Nothing Then
                MsgBox("No radius to query by defined.", MsgBoxStyle.Critical, "Error Querying Shape")
                Exit Sub
            End If

            Me.tslblStatus.Text = "Generating Secondary DataSet..."


            Dim ds As MapPoint.DataSet = Me.axTarget.ActiveMap.DataSets.AddPushpinSet("SecDSET")
            Dim cnt As Integer = SecondaryListToBePlotted.Count
            Dim oMap As MapPoint.Map = Me.axTarget.ActiveMap

            Me.tspbOperationProgress.Maximum = cnt
            Me.tspbOperationProgress.Minimum = 1
            Me.lsRadiusFound.Items.Clear()
            Dim x
            For Each x In SecondaryListToBePlotted
                Try
                    Dim id As String = x.Key
                    Dim g As primaryVSsecondary.RecordToPlot = x.Value
                    Dim oLoc As MapPoint.Location
                    Dim oRes As MapPoint.FindResults = oMap.FindAddressResults(g.StAddress, g.City, , g.State, g.Zip, MapPoint.GeoCountry.geoCountryUnitedStates)
                    oLoc = oRes(1)
                    Dim p As MapPoint.Pushpin = oMap.AddPushpin(oLoc, g.ID)
                    With p
                        .BalloonState = MapPoint.GeoBalloonState.geoDisplayNone
                        .Note = ("------" & vbCrLf & g.Result & vbCrLf & "------")
                        Select Case g.Result
                            Case Is = "Not Issued"
                                .Symbol = 77
                                Exit Select
                            Case Is = "Reset"
                                .Symbol = 22
                                Exit Select
                            Case Is = "Recission Cancel"
                                .Symbol = 78
                                Exit Select
                            Case Is = "Sale"
                                .Symbol = 120
                                Exit Select
                            Case Is = "Bank Rejected"
                                .Symbol = 25
                                Exit Select
                            Case Is = "Demo/No Sale"
                                .Symbol = 204
                                Exit Select
                            Case Is = "Lost Result"
                                .Symbol = 103
                                Exit Select
                            Case Is = "No Demo"
                                .Symbol = 181
                                Exit Select
                            Case Is = "Not Hit"
                                .Symbol = 183
                                Exit Select
                            Case Is = "Kill"
                                .Symbol = 134
                                Exit Select
                            Case Is = "Confirmed"
                                .Symbol = 132
                                Exit Select
                            Case Is = "Called And Cancelled"
                                .Symbol = 211
                                Exit Select
                            Case Is = "Unconfirmed"
                                .Symbol = 184
                                Exit Select
                        End Select
                    End With
                    p.MoveTo(ds)
                Catch ex As Exception
                    Me.tspbOperationProgress.Increment(1)
                    Application.DoEvents()
                End Try
                ds.PushpinsVisible = False
                Me.tspbOperationProgress.Increment(1)
                Application.DoEvents()
            Next

            Me.tslblStatus.Text = "Querying Radius For records. . . "

            Dim rs As MapPoint.Recordset = ds.QueryShape(currentSelectionShape)
            While Not rs.EOF
                cnt += 1
                Dim y As New ListViewItem
                y.Text = rs.Location.Name
                Me.lsRadiusFound.Items.Add(y)
                rs.MoveNext()
                rs.MoveNext()
            End While

            Me.tslblStatus.Text = "Waiting . . . "
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmMappointEX", "FormCode", "Event", "bgPlotSecDSETS_DoWork", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        Me.axTarget.ActiveMap.Pan(MapPoint.GeoPanCmd.geoNorth)
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        Me.axTarget.ActiveMap.Pan(MapPoint.GeoPanCmd.geoSouth)
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        Me.axTarget.ActiveMap.Pan(MapPoint.GeoPanCmd.geoWest)
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        Me.axTarget.ActiveMap.Pan(MapPoint.GeoPanCmd.geoEast)
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Me.axTarget.ActiveMap.Pan(MapPoint.GeoPanCmd.geoNorthWest)
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Me.axTarget.ActiveMap.Pan(MapPoint.GeoPanCmd.geoNorthEast)
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Me.axTarget.ActiveMap.Pan(MapPoint.GeoPanCmd.geoSouthWest)
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Me.axTarget.ActiveMap.Pan(MapPoint.GeoPanCmd.geoSouthEast)
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Me.axTarget.ActiveMap.ZoomOut()
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Me.axTarget.ActiveMap.ZoomIn()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Dim oLoc2 As MapPoint.Location
        Dim oRes2 As MapPoint.FindResults = Me.axTarget.ActiveMap.FindAddressResults(, coINFO.City, , coINFO.State, , MapPoint.GeoCountry.geoCountryUnitedStates)
        oLoc2 = oRes2(1)
        oLoc2.GoTo()
    End Sub
End Class
