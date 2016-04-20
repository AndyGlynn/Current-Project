Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Sql
Imports MapPoint
Imports AxMapPoint

Public Class launchSeparateMap
    Private Const pro_cnx As String = "SERVER=192.168.1.2;Database=Iss;User Id=sa;Password=spoken1;"

   Private Structure ExtendedInfo
        Public ID As String
        Public C1FName As String
        Public C2FName As String
        Public C1LName As String
        Public C2LName As String
        Public YearsOwned As String
        Public AgeOfHome As String
        Public HomeValue As String
        Public HomePhone As String
        Public AltPhone1 As String
        Public AltPhone2 As String
        Public InterestedIn As String ' p1 p2 p3 
        Public stAddress As String
        Public city As String
        Public state As String
        Public zip As String
    End Structure

    Public Sub New(ByVal RecID As String)

        'dim oApp As MapPoint.Application = CreateObject("Mappoint.Application")
        Dim oApp As MapPoint.Application = STATIC_VARIABLES.oApp
        Dim oMap As MapPoint.Map = oApp.NewMap()
        Dim ex_INFO As ExtendedInfo = Get_Extended_Info_For_Map(RecID)

        Dim strNote As String = ""

        strNote = ex_INFO.C1FName & " " & ex_INFO.C1LName & vbCrLf
        strNote += ex_INFO.C2FName & " " & ex_INFO.C2LName & vbCrLf
        strNote += "Years Owned: " & ex_INFO.YearsOwned & " Home Value:" & ex_INFO.HomeValue & vbCrLf
        strNote += "Phone(s): " & ex_INFO.HomePhone & " " & ex_INFO.AltPhone1 & " " & ex_INFO.AltPhone2 & vbCrLf
        strNote += "Interested In: " & ex_INFO.InterestedIn & vbCrLf



        Dim cnx As New SqlConnection(pro_cnx)

        cnx.Open()
        Dim oLoc As MapPoint.Location
        Dim oRes As MapPoint.FindResults = oMap.FindAddressResults(ex_INFO.stAddress, ex_INFO.city, , ex_INFO.state, ex_INFO.zip, GeoCountry.geoCountryUnitedStates)
        oLoc = oRes(1)
        Dim p As MapPoint.Pushpin = oMap.AddPushpin(oLoc, ex_INFO.ID)
        With p
            .Highlight = True
            .Name = ex_INFO.ID
            .BalloonState = GeoBalloonState.geoDisplayBalloon
            .Symbol = 313
            .Note = strNote
            .Location.GoTo()
        End With
        With oApp
            .PaneState = GeoPaneState.geoPaneNone
        End With

        oApp.Toolbars(1).Visible = False
        oApp.Toolbars(2).Visible = False
        oApp.Toolbars(3).Visible = False
        oApp.Toolbars(4).Visible = False
        oApp.Visible = True
    End Sub

    Private Function Get_Extended_Info_For_Map(ByVal RecID As String)
        Dim x As New ExtendedInfo
        Dim cnx As New SqlConnection(pro_cnx)
        cnx.Open()
        Dim cmdGET As New SqlCommand("select ID,StAddress,City,State,Zip,Contact1FirstName,Contact2FirstName,Contact1LastName,Contact1LastName,Contact2LastName,YearsOwned,HomeAge,HomeValue,HousePhone, AltPhone1, AltPhone2, Product1, Product2, Product3 FROM EnterLead WHERE ID= '" & RecID & "';", cnx)
        Dim r1 As SqlDataReader = cmdGET.ExecuteReader
        While r1.Read
            x.ID = RecID
            x.C1FName = r1.Item("Contact1FirstName")
            x.C1LName = r1.Item("Contact1LastName")
            x.C2FName = r1.Item("Contact2FirstName")
            x.C2LName = r1.Item("Contact2LastName")
            x.YearsOwned = r1.Item("YearsOwned")
            x.AgeOfHome = r1.Item("HomeAge")
            x.HomeValue = r1.Item("HomeValue")
            x.HomePhone = r1.Item("HousePhone")
            x.AltPhone1 = r1.Item("AltPhone1")
            x.AltPhone2 = r1.Item("AltPhone2")
            x.city = r1.Item("City")
            x.stAddress = r1.Item("StAddress")
            x.state = r1.Item("State")
            x.zip = r1.Item("Zip")
            x.InterestedIn = r1.Item("Product1") & vbCrLf & r1.Item("Product2") & vbCrLf & r1.Item("Product3")
        End While
        r1.Close()
        cnx.Close()
        cnx = Nothing
        Return x
    End Function
End Class
