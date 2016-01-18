Imports System.Data
Imports MapPoint
Imports System.Data.Sql
Imports System
Imports System.Text
Imports System.Diagnostics.Process
Imports System.Data.SqlClient


Public Class VerifyAddressBulk
    Public oMap As MapPoint.Map
    Public oResults As MapPoint.FindResults
    Public oRoute As MapPoint.Route
    Public oWayPoints As MapPoint.Waypoints
    Public Loc As MapPoint.Location
    Public Loc2 As MapPoint.Location
    Public cntFilter1 As Integer = 0
    Public cntFilter2 As Integer = 0
    Public cntFilter3 As Integer = 0

    Public StAddress As String = ""
    Public City As String = ""
    Public State As String = ""
    Public Zip As String = ""

    Public NextFilterSwitch As Boolean = False

    Public Valid As Boolean
    Public CntValid As Integer = 0
    Public RunCnt As Integer = 1



    Public Morethan1 As Boolean
    Public LookForValid As Boolean = True
    Public ArValues As ArrayList
    Public MapPointVerified As Boolean
    Public CountOfLeads As Integer = 0

    Public CloseMethod As String = ""


    Private cnn As SqlConnection = New SqlConnection(STATIC_VARIABLES.Cnn)
    Private oApp As MapPoint.Application

    Public Sub New()

        oApp = CreateObject("MapPoint.Application")
        oMap = oApp.NewMap()
        oMap.Saved = True
        oApp.Visible = False

    End Sub

    Public Sub filter(ByVal obj As ImportData_V2.sqlOperations.Record_And_Address)

        Try
            Dim StAddress As String = obj.StreetAddress
            Dim State As String = obj.State
            Dim Zip As String = obj.Zip
            Dim City As String = obj.Zip

            oResults = oMap.FindAddressResults(StAddress, City, , State, Zip, MapPoint.GeoCountry.geoCountryUnitedStates)

            Dim cntRes As Integer = oResults.Count
            Dim arValidAddresses As New List(Of MapPoint.Location)
            For Each item As MapPoint.Location In oResults
                If LookForValidAddress(item) = True Then
                    arValidAddresses.Add(item)
                Else
                    '' not a valid address that we want.
                End If
            Next

            Dim arValid As New List(Of MapPoint.Location)
            Select Case arValidAddresses.Count
                Case Is <= 0 '' re-scrub the address to see if it will give you more choices
                    '' if there are no valid results, keep broadening the search
                    '' 
                    '' just gather the next two lists.
                    '' 
                    '' staddress, city , state
                    Dim arStaCityStateList As New List(Of MapPoint.FindResults)
                    arStaCityStateList = Filter2(StAddress, State, City)
                    '' staddress, city 
                    Dim arCityStateList As New List(Of MapPoint.FindResults)
                    arCityStateList = Filter3(StAddress, City)

                    Dim cntValid As Integer = 0

                    For Each y As MapPoint.Location In arStaCityStateList '' st address, city, state scrub.
                        If LookForValidAddress(y) = True Then
                            cntValid += 1
                            arValid.Add(y)
                        End If
                    Next

                    If cntValid <= 0 Then
                        For Each yy As MapPoint.Location In arCityStateList '' staddress, city scrub.
                            If LookForValidAddress(yy) = True Then
                                cntValid += 1
                                arValid.Add(yy)
                            End If
                        Next
                    End If

                    '' now at the end of all this:
                    If arValid.Count <= 0 Then
                        '' NO results found. 
                        '' use original address and flag as NOT verified.
                        CheckCity(City, State) '' bounce the city to sql if we don't have it.
                        '' bounce the city to sql if we don't have it.
                        'Dim loc As MapPoint.Location = oRes.Item(1) '' Results are NON ZERO BASED INDEXES

                        Dim Id As String = obj.Id_FromTable
                        Dim t_name As String = "i360__Prospect__c"
                        Dim v As New ImportData_V2.sqlOperations.Record_And_Address
                        v.Id_FromTable = Id
                        v.StreetAddress = StAddress
                        v.City = City
                        v.Zip = Zip
                        v.State = State
                        Dim b As New ImportData_V2.sqlOperations
                        b.Update_Table(v, False)
                        v = Nothing
                    ElseIf arValid.Count >= 1 Then
                        '' use the FIRST one.
                        Dim oLoc As MapPoint.Location = arValid(0)
                        CheckCity(oLoc.StreetAddress.City, oLoc.StreetAddress.Region) '' bounce the city to sql if we don't have it.
                        'Dim loc As MapPoint.Location = oRes.Item(1) '' Results are NON ZERO BASED INDEXES
                        Dim _stAddress As String = oLoc.StreetAddress.Street
                        Dim _City As String = oLoc.StreetAddress.City
                        Dim _zip As String = oLoc.StreetAddress.PostalCode
                        Dim _State As String = oLoc.StreetAddress.Region
                        Dim Id As String = obj.Id_FromTable
                        Dim t_name As String = "i360__Prospect__c"
                        Dim v As New ImportData_V2.sqlOperations.Record_And_Address
                        v.Id_FromTable = Id
                        v.StreetAddress = _stAddress
                        v.City = _City
                        v.Zip = _zip
                        v.State = _State
                        Dim b As New ImportData_V2.sqlOperations
                        b.Update_Table(v, False)
                        v = Nothing
                    End If
                    Exit Select
                Case Is > 1 '' multiple valid addresses returned. 
                    '' use the FIRST one.
                    Dim oLoc As MapPoint.Location = arValid(0)
                    CheckCity(oLoc.StreetAddress.City, oLoc.StreetAddress.Region) '' bounce the city to sql if we don't have it.
                    'Dim loc As MapPoint.Location = oRes.Item(1) '' Results are NON ZERO BASED INDEXES
                    Dim _stAddress As String = oLoc.StreetAddress.Street
                    Dim _City As String = oLoc.StreetAddress.City
                    Dim _zip As String = oLoc.StreetAddress.PostalCode
                    Dim _State As String = oLoc.StreetAddress.Region
                    Dim Id As String = obj.Id_FromTable
                    Dim t_name As String = "i360__Prospect__c"
                    Dim v As New ImportData_V2.sqlOperations.Record_And_Address
                    v.Id_FromTable = Id
                    v.StreetAddress = _stAddress
                    v.City = _City
                    v.Zip = _zip
                    v.State = _State
                    Dim b As New ImportData_V2.sqlOperations
                    b.Update_Table(v, False)
                    v = Nothing
                    Exit Select
                Case Is = 1 '' the one
                    Dim oLoc As MapPoint.Location = arValid(0)
                    CheckCity(oLoc.StreetAddress.City, oLoc.StreetAddress.Region) '' bounce the city to sql if we don't have it.
                    'Dim loc As MapPoint.Location = oRes.Item(1) '' Results are NON ZERO BASED INDEXES
                    Dim _stAddress As String = oLoc.StreetAddress.Street
                    Dim _City As String = oLoc.StreetAddress.City
                    Dim _zip As String = oLoc.StreetAddress.PostalCode
                    Dim _State As String = oLoc.StreetAddress.Region
                    Dim Id As String = obj.Id_FromTable
                    Dim t_name As String = "i360__Prospect__c"
                    Dim v As New ImportData_V2.sqlOperations.Record_And_Address
                    v.Id_FromTable = Id
                    v.StreetAddress = _stAddress
                    v.City = _City
                    v.Zip = _zip
                    v.State = _State
                    Dim b As New ImportData_V2.sqlOperations
                    b.Update_Table(v, False)
                    v = Nothing
                    Exit Select
                Case Else   '' any other garbage that comes out 
                    Exit Select
            End Select
        Catch ex As Exception
            Dim err As String = ex.Message
            Dim stAddress As String = obj.StreetAddress
            Dim City As String = obj.City
            Dim zip As String = obj.Zip
            Dim State As String = obj.State
            Dim Id As String = obj.Id_FromTable
            Dim t_name As String = "i360__Prospect__c"
            Dim v As New ImportData_V2.sqlOperations.Record_And_Address
            v.Id_FromTable = Id
            v.StreetAddress = stAddress
            v.City = City
            v.Zip = zip
            v.State = State
            v = Nothing
        End Try
    End Sub
    Private Function Filter2(ByVal StAddress As String, ByVal State As String, ByVal City As String)
        Dim res As MapPoint.FindResults = oMap.FindAddressResults(StAddress, City, , State, , GeoCountry.geoCountryUnitedStates)
        Return res
    End Function
    Private Function Filter3(ByVal Staddress As String, ByVal City As String)
        Dim res As MapPoint.FindResults = oMap.FindAddressResults(Staddress, City, , , , GeoCountry.geoCountryUnitedStates)
        Return res
    End Function



    Private Function LookForValidAddress(ByVal Loc As MapPoint.Location)
        '' conditions: No addresses like "W Main st", "Ohio [OH] (Ohio)"
        ''             MUST begin with Numbers
        Valid = False ''Forgot to reset variable dude AG
        Try
            Dim Name As String = Loc.Name
            Dim ch As Char
            Dim cnt As Integer = 0
            For Each ch In Name
                If ch = "," Then
                    cnt += 1
                End If
            Next
            '' if there aren't enough commas, we dont want this address
            If cnt < 2 Then
                Valid = False
                Exit Function
            End If
            '' there are too many commas, we dont want this address
            If cnt > 2 Then
                Valid = False
                Exit Function
            End If
            '' if there exactly two commas, this is the address we want
            If cnt = 2 Then
                Dim STA As String = Loc.StreetAddress.Street
                Dim CTY As String = Loc.StreetAddress.City
                Dim ST As String = Loc.StreetAddress.Region
                Dim ZP As String = Loc.StreetAddress.PostalCode
                Dim LOCNAME = Split(Loc.Name, ",", 3)
                STA = LOCNAME(0)
                CTY = LOCNAME(1)
                Dim STATEZIP = Split(Trim(LOCNAME(2)), " ", 2)
                ST = STATEZIP(0)
                ZP = STATEZIP(1)
                If STA.Contains(" ") = False Then
                    Valid = False
                    Exit Function
                End If
                '' now we need to check the first part of the array
                '' to make sure it has a numeric street value
                '' otherwise it is garbage to us
                Dim i As Integer
                Dim c As Char
                For Each c In STA
                    i += 1
                    If i >= 4 Or c = " " Then
                        Exit For
                    End If
                    Select Case c
                        Case "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"
                            Valid = True
                            'CntValid += 1
                        Case Else
                            Valid = False
                    End Select
                Next
            End If
            Return Valid
        Catch ex As Exception
            Dim err As New ErrorLogFlatFile
            'err.WriteLog("VerifyAddress", "ByVal StAddress As String, ByVal City As String, ByVal State As String, ByVal Zip As String", ex.Message.ToString, "Client", STATIC_VARIABLES.CurrentUser & ", " & STATIC_VARIABLES.CurrentForm, "Mappoint", "LookForValidAddress")

        End Try

    End Function
    Public Sub CheckCity(ByVal City As String, ByVal State As String)
        Try
            Dim cmdGet As SqlCommand = New SqlCommand("dbo.CountCity", cnn)
            cmdGet.CommandType = CommandType.StoredProcedure
            Dim param1 As SqlParameter = New SqlParameter("@CTY", City)
            cmdGet.Parameters.Add(param1)
            cnn.Open()
            Dim r1 As SqlDataReader
            r1 = cmdGet.ExecuteReader
            Dim cnt As Integer = 0
            While r1.Read
                cnt = r1.Item(0)
            End While
            r1.Close()
            cnn.Close()
            Select Case cnt
                Case Is >= 1
                    Exit Sub
                Case Is <= 0
                    Dim cmdINS As SqlCommand = New SqlCommand("dbo.InsertNewCity", cnn)
                    cmdINS.CommandType = CommandType.StoredProcedure
                    Dim param2 As SqlParameter = New SqlParameter("@CITY", City)
                    Dim param3 As SqlParameter = New SqlParameter("@STATE", State)
                    cmdINS.Parameters.Add(param2)
                    cmdINS.Parameters.Add(param3)
                    cnn.Open()
                    Dim r2 As SqlDataReader
                    r2 = cmdINS.ExecuteReader(CommandBehavior.CloseConnection)
                    r2.Close()
                    cnn.Close()
                    EnterLead.txtCity.AutoCompleteCustomSource.Add(City)
                    Exit Select
            End Select
            cnn = Nothing
        Catch ex As Exception
            cnn.Close()
            cnn = Nothing
            Dim err As New ErrorLogFlatFile
            'err.WriteLog("VerifyAddress", "ByVal City As String, ByVal State As String", ex.Message.ToString, "Client", STATIC_VARIABLES.CurrentUser & ", " & STATIC_VARIABLES.CurrentForm, "Mappoint", "CheckCity")

        End Try

    End Sub

End Class
