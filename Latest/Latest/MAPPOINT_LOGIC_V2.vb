Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports MapPoint


Public Class MAPPOINT_LOGIC_V2

    Public Structure CityAndZip
        Public CityName As String
        Public ZipCode As String
        Public TargetState As String
    End Structure

    Public Structure ZipState
        Public ZipCode As String
        Public TargetState As String
    End Structure

    Public Structure CityState
        Public City As String
        Public TargetState As String
    End Structure

    Public arCityAndZips As List(Of CityAndZip)
    Public arCityState As List(Of CityState)
    Public arZipState As List(Of ZipState)

    Private Const sql_cnx As String = "SERVER=192.168.1.2;DATABASE=ISS;User Id=sa;Password=spoken1;"

    Public Function Begin()
        arCityAndZips = GetUniqueCityAndZips()
        Return arCityAndZips
    End Function


    '' split into two initial lists to NOT show duplicates
    '' two different DISTINCT queries
    '' 

    Public Function GetUniqueZipState()
        Dim cnx As New SqlConnection(sql_cnx)
        Dim arRes As New List(Of ZipState)
        cnx.Open()
        Dim cmdGET As New SqlCommand("SELECT DISTINCT(Zip),State FROM EnterLead;", cnx)
        Dim r1 As SqlDataReader = cmdGET.ExecuteReader
        While r1.Read
            Dim g As New ZipState
            g.ZipCode = r1.Item("Zip")
            g.TargetState = r1.Item("State")
            arRes.Add(g)
        End While
        r1.Close()
        cnx.Close()
        cnx = Nothing
        Return arRes
    End Function

    Public Function GetUniqueCityState()
        Dim cnx As New SqlConnection(sql_cnx)
        Dim arRes As New List(Of CityState)
        cnx.Open()
        Dim cmdGET As New SqlCommand("SELECT DISTINCT(City),State FROM EnterLead;", cnx)
        Dim r1 As SqlDataReader = cmdGET.ExecuteReader
        While r1.Read
            Dim g As New CityState
            g.City = r1.Item("City")
            g.TargetState = r1.Item("State")
            arRes.Add(g)
        End While
        r1.Close()
        cnx.Close()
        cnx = Nothing
        Return arRes
    End Function

    Private Function GetUniqueCityAndZips()
        Dim cnx_get As New SqlConnection(sql_cnx)
        Dim arCityZip As New List(Of CityAndZip)
        cnx_get.Open()
        Dim cmdGET As SqlCommand = New SqlCommand("SELECT distinct(City),State,Zip from enterlead;", cnx_get)
        Dim r1 As SqlDataReader = cmdGET.ExecuteReader
        While r1.Read
            Dim CityZip As New CityAndZip
            CityZip.CityName = r1.Item("City")
            CityZip.ZipCode = r1.Item("Zip")
            CityZip.TargetState = r1.Item("State")
            arCityZip.Add(CityZip)
        End While
        r1.Close()
        cnx_get.Close()
        cnx_get = Nothing
        Return arCityZip
    End Function

    Public Function Search_Radius_City(ByVal ListOfCityAndZips As List(Of CityState), ByVal Search_Radius As Double, ByVal StartCity As String, ByVal StartState As String)
        Dim listResults As New List(Of CityState)
        listResults = ListOfCityAndZips
        Dim oApp As MapPoint.Application
        oApp = CreateObject("MapPoint.Application")
        oApp.Visible = False
        Dim oMap As MapPoint.Map = oApp.NewMap
        Dim start_loc As MapPoint.Location
        Dim start_res As MapPoint.FindResults = oMap.FindAddressResults(, StartCity, , StartState, , GeoMapRegion.geoMapNorthAmerica)
        start_loc = start_res.Item(1)
        start_loc.GoTo()

        Dim oShape As MapPoint.Shape
        oShape = oMap.Shapes.AddShape(GeoAutoShapeType.geoShapeRadius, start_loc, Search_Radius * 2, Search_Radius * 2)

        Dim oDset As MapPoint.DataSet = oApp.ActiveMap.DataSets.AddPushpinSet("SEARCHSET")

        Dim g As CityState
        For Each g In listResults
            Dim F_Res As MapPoint.FindResults
            Dim F_loc As MapPoint.Location
            F_Res = oMap.FindAddressResults(, g.City, , g.TargetState, , GeoMapRegion.geoMapNorthAmerica)
            F_loc = F_Res.Item(1)
            Dim item_P As MapPoint.Pushpin = oMap.AddPushpin(F_loc, g.City)
            item_P.MoveTo(oDset)
        Next

        oShape.Select()
        Dim oRset As MapPoint.Recordset = oDset.QueryShape(oShape)
        oRset.MoveFirst()
        Dim arCityFoundName As New ArrayList
        Do While Not oRset.EOF
            arCityFoundName.Add(oRset.Location.Name.ToString)
            oRset.MoveNext()
        Loop

        oMap.Saved = True
        oApp.Quit()
        oApp = Nothing
        Return arCityFoundName
    End Function

    Public Function Search_Radius_ZipCode(ByVal ListOfCityAndZips As List(Of ZipState), ByVal Search_Radius As Double, ByVal StartZip As String, ByVal StartState As String)
        Dim listResults As New List(Of ZipState)
        listResults = ListOfCityAndZips
        Dim oApp As MapPoint.Application
        oApp = CreateObject("MapPoint.Application")
        oApp.Visible = False
        Dim oMap As MapPoint.Map = oApp.NewMap
        Dim start_loc As MapPoint.Location
        Dim start_res As MapPoint.FindResults = oMap.FindAddressResults(, , , , StartZip)
        start_loc = start_res.Item(1)
        start_loc.GoTo()

        Dim oShape As MapPoint.Shape
        oShape = oMap.Shapes.AddShape(GeoAutoShapeType.geoShapeRadius, start_loc, (Search_Radius * 2), (Search_Radius * 2))

        Dim oDset As MapPoint.DataSet = oApp.ActiveMap.DataSets.AddPushpinSet("SEARCHSET")

        Dim g As ZipState
        For Each g In listResults
            If g.ZipCode.ToString.Length <= 0 Then
                '' dont do anthing with a blank zip code
            ElseIf g.ZipCode.ToString >= 1 Then
                Dim F_Res As MapPoint.FindResults
                Dim F_loc As MapPoint.Location
                F_Res = oMap.FindAddressResults(, , , , g.ZipCode)
                If F_Res.Count <= 0 Then
                ElseIf F_Res.Count >= 1 Then
                    If F_Res IsNot Nothing Then
                        F_loc = F_Res.Item(1)
                    End If
                    If F_loc IsNot Nothing Then
                        Dim item_P As MapPoint.Pushpin = oMap.AddPushpin(F_loc, g.ZipCode)
                        item_P.Symbol = 73
                        item_P.BalloonState = GeoBalloonState.geoDisplayBalloon
                        item_P.Note = g.ZipCode
                        item_P.MoveTo(oDset)
                    End If
                End If
            End If
        Next

        oShape.Select()
        Dim oRset As MapPoint.Recordset = oDset.QueryShape(oShape)
        oRset.MoveFirst()
        Dim arZipFoundName As New ArrayList
        Do While Not oRset.EOF
            arZipFoundName.Add(oRset.Location.Name.ToString)
            oRset.MoveNext()
        Loop

        oMap.Saved = True
        oApp.Quit()
        oApp = Nothing
        Return arZipFoundName
    End Function

    Public Function Get_STATE_ForCity(ByVal City As String)
        Dim cnx_st As New SqlConnection(sql_cnx)
        cnx_st.Open()
        Dim cmdGET As New SqlCommand("SELECT Distinct(State) from enterlead WHERE City ='" & City & "';", cnx_st)
        Dim res As String = cmdGET.ExecuteScalar()
        cnx_st.Close()
        cnx_st = Nothing
        Return res
    End Function
    Public Function Get_STATE_ForZip(ByVal Zip As String)
        Dim cnx_st As New SqlConnection(sql_cnx)
        cnx_st.Open()
        Dim cmdGET As New SqlCommand("SELECT Distinct(State) from enterlead WHERE Zip ='" & Zip & "';", cnx_st)
        Dim res As String = cmdGET.ExecuteScalar()
        cnx_st.Close()
        cnx_st = Nothing
        Return res
    End Function

    Public Function Get_Unique_States()
        Dim cnx_st As New SqlConnection(sql_cnx)
        cnx_st.Open()
        Dim cmdGET As New SqlCommand("SELECT Distinct(State) FROM EnterLead;", cnx_st)
        Dim res As New ArrayList
        Dim r1 As SqlDataReader = cmdGET.ExecuteReader
        While r1.Read
            res.Add(r1.Item("State"))
        End While
        r1.Close()
        cnx_st.Close()
        cnx_st = Nothing
        Return res
    End Function

End Class
