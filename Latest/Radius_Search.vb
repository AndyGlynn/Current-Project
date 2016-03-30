Imports MapPoint


Public Class Radius_Search
    ''
    '' city
    '' zip code
    ''
    Public arCities As ArrayList
    Public arZips As ArrayList
    Public Sub New(ByVal StartCity As String, ByVal StartState As String, ByVal Unique_List As List(Of Pull_Unique_States_And_Zips.UniqueCityStateZip), ByVal Radius As Integer, ByVal Form As String)

        '' 
        '' take as string
        '' perform search 
        '' pass back list of cities as list(of string)
        '' 
        arCities = New ArrayList

        Dim oApp As MapPoint.Application

        oApp = CreateObject("MapPoint.Application")
        oApp.Toolbars(1).Visible = False
        oApp.Toolbars(2).Visible = False
        oApp.Toolbars(3).Visible = False
        oApp.Toolbars(4).Visible = False
        oApp.Units = GeoUnits.geoMiles
        Dim oMap As MapPoint.Map
        oMap = oApp.NewMap
        oApp.PaneState = GeoPaneState.geoPaneNone
        oApp.Visible = False
        '' supply start point 
        Dim start_loc As MapPoint.Location
        Dim startResults As MapPoint.FindResults
        startResults = oMap.FindAddressResults(, StartCity, , StartState, , GeoCountry.geoCountryUnitedStates)
        start_loc = startResults.Item(1)
        start_loc.GoTo()
        Dim start_push As MapPoint.Pushpin = oMap.AddPushpin(start_loc, "Start")
        
        For Each y As Pull_Unique_States_And_Zips.UniqueCityStateZip In Unique_List
            Dim oRoute As MapPoint.Route = oMap.ActiveRoute
            Dim itemLoc As MapPoint.Location
            Dim itemRes As MapPoint.FindResults
            itemRes = oMap.FindAddressResults(, y.City, , y.State, , GeoMapRegion.geoMapNorthAmerica)
            itemLoc = itemRes.Item(1)
            Dim stWaypoint As MapPoint.Waypoint
            oRoute.Waypoints.Add(start_loc, "start")
            oRoute.Waypoints.Add(itemLoc, "end")
            Try
                oRoute.Calculate()
            Catch ex As Exception

            End Try
            Dim distance As Double = oRoute.Distance
            If distance < (Radius) Then
                If arCities.Contains(y.City) = False Then
                    arCities.Add(y.City)
                End If
            End If
            oRoute.Clear()
            Select Case Form
                Case Is = "frmWCList.vb"
                    frmWCList.pbSearch.Increment(1)
                    Exit Select
            End Select
        Next

        oMap.Saved = True
        oApp.Quit()
        oApp = Nothing

    End Sub
    Public Sub New(ByVal Zip As Integer, ByVal Unique_List As List(Of Pull_Unique_States_And_Zips.UniqueCityStateZip), ByVal Radius As Integer, ByVal Form As String)
        '' 
        '' take as integer
        '' convert to string
        '' perform search 
        '' pass back list of zips as list(of string)
        '' 
        '' 
        '' open mappoint
        arZips = New ArrayList
        Dim oApp As MapPoint.Application

        oApp = CreateObject("MapPoint.Application")
        oApp.Toolbars(1).Visible = False
        oApp.Toolbars(2).Visible = False
        oApp.Toolbars(3).Visible = False
        oApp.Toolbars(4).Visible = False
        oApp.Units = GeoUnits.geoMiles
        Dim oMap As MapPoint.Map
        oMap = oApp.NewMap
        oApp.PaneState = GeoPaneState.geoPaneNone
        oApp.Visible = False
        '' supply start point 
        Dim start_loc As MapPoint.Location
        Dim startResults As MapPoint.FindResults
        Dim STzip As String = CType(Zip, String)
        startResults = oMap.FindAddressResults(, , , , STzip, GeoCountry.geoCountryUnitedStates)
        start_loc = startResults.Item(1)
        start_loc.GoTo()
        Dim start_push As MapPoint.Pushpin = oMap.AddPushpin(start_loc, "Start")
        
        For Each y As Pull_Unique_States_And_Zips.UniqueCityStateZip In Unique_List
            Dim itemLoc As MapPoint.Location
            Dim itemRes As MapPoint.FindResults
            itemRes = oMap.FindAddressResults(, , , y.State, y.Zip, GeoMapRegion.geoMapNorthAmerica)
            itemLoc = itemRes.Item(1)
            Dim itemP As MapPoint.Pushpin = oMap.AddPushpin(itemLoc, y.Zip)
            Dim stWaypoint As MapPoint.Waypoint
            Dim oRoute As MapPoint.Route
            oRoute = oMap.ActiveRoute
            oRoute.Waypoints.Add(start_loc, "start")
            oRoute.Waypoints.Add(itemLoc, "end")
            Try
                oRoute.Calculate()
            Catch ex As Exception

            End Try
            Dim distance As Double = oRoute.Distance
            If distance < (CType(Radius, Double)) Then
                If arZips.Contains(y.Zip) = False Then
                    arZips.Add(y.Zip)
                End If
            End If
            oRoute.Clear()
            Select Case Form
                Case Is = "frmWCList.vb"
                    frmWCList.pbSearch.Increment(1)
                    Exit Select
            End Select
        Next

        oMap.Saved = True
        oApp.Quit()
        oApp = Nothing



    End Sub
    Private Function ConvertState(ByVal StartState As String)
        Dim retString As String = ""
        Select Case StartState
            Case Is = "OH"
                retString = "OH [Ohio]"
                Exit Select
            Case Is = "MI"
                retString = "MI [Michigan]"
                Exit Select 
        End Select
        Return retString
    End Function

End Class
