Imports System.IO
Imports System.Text
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class generateCSVForDataMap
    Private str_Writer As StreamWriter
    Private Const pro_cnx As String = "SERVER=192.168.1.2;Database=Iss;User Id=sa;Password=spoken1;"


    '' \\server.greenworks.local\Company\ISS\PROTOTYPES\Mappoint\DataMap_Files
    '' C:\Users\Clay\Desktop\DataMap_Files

    'Public Structure RecordToPlot
    '    Public ID As String
    '    Public StAddress As String
    '    Public City As String
    '    Public State As String
    '    Public Zip As String
    'End Structure

    '' Reference: https://msdn.microsoft.com/en-us/library/aa562363.aspx

    '' For DataMapping: CSV Format - GeoShowDataBy.geoShowByCity & GeoShowDataBy.geoShowByRegion1
    '' [Lead Type],[Lead Type],[Lead Type],[City],[State]
    ''    cnt         cnt         cnt       city    state
    '' first [3] columns in arFLD() for dataToPlot option

    '' 
    '' Acceptable Chart Formats: UnsizedPie & CategoricalColumn -> Pie shows %'s as well as hard data
    '' 

    '' For DataMapping : CSV Format - GeoShowDataBy.geoShowByStreet 
    '' [lead type],[lead type],[lead type],[St address],[City],[State],[zip]
    ''   cnt          cnt        cnt          item        item   item   item 
    ''
    '' first [3] columns in arFLD() for dataToPlot option

    ''
    '' LegendTitle Needs to be set for each switch between data maps => EX: 'Results By City' , 'Results By State'
    '' 

    '' 
    '' array of fields / data to plot needs to be redimensioned based upon user selection
    '' EX: arFLD(3) for 3 sales results
    ''     arFLD(6) for 6 sales results
    '' Again, These arrays are '1' based, not '0' based. <== LIES! Mappoint ACCEPTS 0 based arrays but gives '1' based arrays back! 

    '' zoom level needs to be adjusted on default view for 'state' data maps.
    '' zoom level needs to be adjusted on default view for 'city' data maps.




    Private File_Path As String = ""

    Public ReadOnly Property FilePath As String
        Get
            Return File_Path
        End Get
    End Property

#Region "Notes On Constructor"
    '' 
    '' arguments should be an arrayofcolumns/sales results/list of string  to 'cnt'
    '' optional: target city only vs/ all cities as argument
    '' date range begin, end
    '' name of csv file for 'path'
    '' cnt of array to redim should be length of array -1 for data to plot
    '' 
#End Region

    Public Sub New(ByVal ColumnsToPlot As List(Of String), ByVal BeginDate As String, ByVal EndDate As String, ByVal City_or_State As String, ByVal TargetCity_Or_ALL As String, ByVal Sales_Or_Marketing As String)

        'Dim dir_info As New DirectoryInfo("C:\Users\Clay\Desktop\DataMap_Files\")
        'For Each x As FileInfo In dir_info.GetFiles("*.csv")
        '    x.Delete()
        'Next

        Dim dir_info As New DirectoryInfo("\\server.greenworks.local\Company\ISS\PROTOTYPES\Mappoint\DataMap_Files\")
        For Each x As FileInfo In dir_info.GetFiles("*.csv")
            x.Delete()
        Next


        Dim csvHeader As String = ""
        Dim cntOfCols As Integer = 0
        For Each s As String In ColumnsToPlot
            cntOfCols += 1
        Next
        Dim arFLDS()
        Dim i As Integer = 0
        For i = 1 To cntOfCols
            If i < cntOfCols Then
                csvHeader += ColumnsToPlot(i - 1) & ","
            ElseIf i = cntOfCols Then
                csvHeader += ColumnsToPlot(i - 1)
            End If
        Next
        ReDim arFLDS(ColumnsToPlot.Count)
        Dim ii
        For ii = 1 To ColumnsToPlot.Count
            arFLDS(ii) = ColumnsToPlot(ii - 1)
        Next

        ''
        '' for arFLDS() DONT use index 0
        '' start '1' based like mappoint
        '' 

        '' get counts of records for each 'result' 
        '' with options supplied. 
        Dim resultsList As New ArrayList
        Select Case Sales_Or_Marketing
            Case Is = "Sales"
                resultsList = Get_Counts_Sales(arFLDS, BeginDate, EndDate)
                Exit Select
            Case Is = "Marketing"
                resultsList = Get_Counts_Marketing(arFLDS, BeginDate, EndDate)
                Exit Select
        End Select
        
        Dim id As Guid = Guid.NewGuid

        File_Path = ("\\server.greenworks.local\Company\ISS\PROTOTYPES\Mappoint\DataMap_Files\" & id.ToString & ".csv")

        Dim strWriter As New StreamWriter(File_Path)

        strWriter.WriteLine(csvHeader & ",City,State")
        For Each item As String In resultsList
            strWriter.WriteLine(item)
        Next
        strWriter.Flush()
        strWriter.Close()
        'System.Diagnostics.Process.Start("notepad", File_Path)

    End Sub

    Private Structure CityStates
        Public City As String
        Public State As String
    End Structure

    Private Structure CityStateResultCount
        Public City As String
        Public State As String
        Public Result As String
        Public Count As Integer
    End Structure

    Private Function Get_Counts_Marketing(ByVal Fields As Array, ByVal BeginDate As String, ByVal EndDate As String)
        Dim arResults As New ArrayList
        ''
        '' first get a list of unique states in dbase
        '' second get a list of each city by state in database
        '' third for each fld query city/state combo for result
        ''
        Dim arStates As New ArrayList
        Dim cnx As New SqlConnection(pro_cnx)
        cnx.Open()
        Dim cmdGET As New SqlCommand("select distinct(State) from EnterLead WHERE State is not null and State != ' ';", cnx)
        Dim r1 As SqlDataReader = cmdGET.ExecuteReader
        While r1.Read
            arStates.Add(r1.Item("State"))
        End While
        r1.Close()
        cnx.Close()

        Dim cityState As New Dictionary(Of String, CityStates)
        Dim cntCity As Integer = 0
        For Each x As String In arStates
            cnx.Open()

            Dim cmdGETCITYSTATE As New SqlCommand("select distinct(City),state from EnterLead WHERE State is not null and State != ' ' and City is not null and City !=' ' and State = '" & x.ToString & "';", cnx)
            Dim res As New CityStates
            Dim r As SqlDataReader = cmdGETCITYSTATE.ExecuteReader
            While r.Read
                cntCity += 1
                res.City = r.Item("City")
                res.State = r.Item("State")
                cityState.Add(cntCity.ToString, res)
            End While
            r1.Close()
            cnx.Close()
        Next
        Dim xx
        For Each xx In cityState
            Dim c As CityStates = xx.Value
            Dim cntResIteration As Integer = 0
            Dim strLine As String = ""
            Dim b
            For Each b In Fields
                If Len(b) >= 1 Then
                    cnx.Open()
                    cntResIteration += 1
                    Dim cmdCNT As New SqlCommand("SELECT COUNT(ID) FROM EnterLead WHERE City='" & c.City & "' and State = '" & c.State & "' and MarketingResults = '" & b.ToString & "' and LeadGeneratedOn Between '" & BeginDate & "' and '" & EndDate & "';", cnx)
                    Dim cnt As Integer = cmdCNT.ExecuteScalar
                    cnx.Close()
                    strLine += cnt.ToString & ","
                End If
            Next
            strLine += c.City & "," & c.State
            arResults.Add(strLine)
        Next
        cnx = Nothing
        Return arResults
    End Function
    Private Function Get_Counts_Sales(ByVal Fields As Array, ByVal BeginDate As String, ByVal EndDate As String)
        Dim arResults As New ArrayList
        ''
        '' first get a list of unique states in dbase
        '' second get a list of each city by state in database
        '' third for each fld query city/state combo for result
        ''
        Dim arStates As New ArrayList
        Dim cnx As New SqlConnection(pro_cnx)
        cnx.Open()
        Dim cmdGET As New SqlCommand("select distinct(State) from EnterLead WHERE State is not null and State != ' ';", cnx)
        Dim r1 As SqlDataReader = cmdGET.ExecuteReader
        While r1.Read
            arStates.Add(r1.Item("State"))
        End While
        r1.Close()
        cnx.Close()

        Dim cityState As New Dictionary(Of String, CityStates)
        Dim cntCity As Integer = 0
        For Each x As String In arStates
            cnx.Open()

            Dim cmdGETCITYSTATE As New SqlCommand("select distinct(City),state from EnterLead WHERE State is not null and State != ' ' and City is not null and City !=' ' and State = '" & x.ToString & "';", cnx)
            Dim res As New CityStates
            Dim r As SqlDataReader = cmdGETCITYSTATE.ExecuteReader
            While r.Read
                cntCity += 1
                res.City = r.Item("City")
                res.State = r.Item("State")
                cityState.Add(cntCity.ToString, res)
            End While
            r1.Close()
            cnx.Close()
        Next
        Dim xx
        For Each xx In cityState
            Dim c As CityStates = xx.Value
            Dim cntResIteration As Integer = 0
            Dim strLine As String = ""
            Dim b
            For Each b In Fields
                If Len(b) >= 1 Then
                    cnx.Open()
                    cntResIteration += 1
                    Dim cmdCNT As New SqlCommand("SELECT COUNT(ID) FROM EnterLead WHERE City='" & c.City & "' and State = '" & c.State & "' and Result = '" & b.ToString & "' and LeadGeneratedOn Between '" & BeginDate & "' and '" & EndDate & "';", cnx)
                    Dim cnt As Integer = cmdCNT.ExecuteScalar
                    cnx.Close()
                    strLine += cnt.ToString & ","
                End If
            Next
            strLine += c.City & "," & c.State
            arResults.Add(strLine)
        Next
        cnx = Nothing
        Return arResults
    End Function
End Class
