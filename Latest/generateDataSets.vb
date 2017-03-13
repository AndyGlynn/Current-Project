Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class generateDataSets

    Private pro_cnx As String = STATIC_VARIABLES.Cnn
    Private cntSRES As Integer = 0
    Private cntMRES As Integer = 0
    Private cntSales As Integer = 0
    Private cntUnconfirmed As Integer = 0

    Public Structure RecordToPlot
        Public ID As String
        Public StAddress As String
        Public City As String
        Public State As String
        Public Zip As String
    End Structure

    Public Structure RecordToPlotSale
        Public ID As String
        Public StAddress As String
        Public City As String
        Public State As String
        Public Zip As String
        Public ParPrice As String
        Public QuotedSold As String
        Public Cash As Boolean
        Public Finance As Boolean
    End Structure


    Public ReadOnly Property Count_Of_Sales As Integer
        Get
            Return cntSRES
        End Get
    End Property
    Public ReadOnly Property Count_Of_Marketing As Integer
        Get
            Return cntMRES
        End Get
    End Property
    Public ReadOnly Property Count_Of_PCs As Integer
        Get
            Return cntSales
        End Get
    End Property
    Public ReadOnly Property Count_Of_Unconfirmed As Integer
        Get
            Return cntUnconfirmed
        End Get
    End Property
    Public Function Get_Num_Unconfirmed(ByVal Begindate As String, ByVal EndDate As String, ByVal NumRecords As String)
        Dim res As New Dictionary(Of String, RecordToPlot)
        cntUnconfirmed = 0
        Dim cnx As New SqlConnection(STATIC_VARIABLES.Cnn)
        cnx.Open()
        Dim cmdGET As New SqlCommand("select top(" & NumRecords & ") ID,StAddress,City,State,zip from Enterlead where MarketingResults = 'Unconfirmed' and LeadGeneratedOn Between '" & Begindate & "' and '" & EndDate & "';", cnx)
        Dim r1 As SqlDataReader = cmdGET.ExecuteReader
        While r1.Read
            Dim a As New RecordToPlot
            a.ID = r1.Item("ID")
            a.StAddress = r1.Item("StAddress")
            a.City = r1.Item("City")
            a.Zip = r1.Item("Zip")
            a.State = r1.Item("State")
            cntUnconfirmed += 1
            res.Add(a.ID, a)
        End While
        r1.Close()
        cnx.Close()
        cnx = Nothing
        Return res
    End Function
    Public Function Get_Previous_Customers_Data_Set(ByVal BeginDate As String, ByVal EndDate As String, ByVal NumRecords As String)
        Dim res As New Dictionary(Of String, RecordToPlotSale)
        cntSRES = 0
        Dim cnx As New SqlConnection(STATIC_VARIABLES.Cnn)
        cnx.Open()
        Dim cmdGET As New SqlCommand("select top(" & NumRecords & ") ID,StAddress,City,State,zip,QuotedSold,ParPrice,Cash,Finance from Enterlead where Result = 'Sale' and LeadGeneratedOn Between '" & BeginDate & "' and '" & EndDate & "';", cnx)
        Dim r1 As SqlDataReader = cmdGET.ExecuteReader
        While r1.Read
            Dim a As New RecordToPlotSale
            a.ID = r1.Item("ID")
            a.StAddress = r1.Item("StAddress")
            a.City = r1.Item("City")
            a.Zip = r1.Item("Zip")
            a.State = r1.Item("State")
            a.ParPrice = r1.Item("ParPrice")
            a.QuotedSold = r1.Item("QuotedSold")
            a.Cash = r1.Item("Cash")
            a.Finance = r1.Item("Finance")
            cntSales += 1
            res.Add(a.ID, a)
        End While
        r1.Close()
        cnx.Close()
        cnx = Nothing
        Return res
    End Function

    Public Function Get_Sales_Results_Data_Set(ByVal BeginDate As String, ByVal EndDate As String, ByVal SalesResult As String, ByVal NumRecords As String)
        Dim res As New Dictionary(Of String, RecordToPlot)
        cntSRES = 0
        Dim cnx As New SqlConnection(STATIC_VARIABLES.Cnn)
        cnx.Open()
        Dim cmdGET As New SqlCommand("select top(" & NumRecords & ") ID,StAddress,City,State,zip from Enterlead where Result = '" & SalesResult & "' and LeadGeneratedOn Between '" & BeginDate & "' and '" & EndDate & "';", cnx)
        Dim r1 As SqlDataReader = cmdGET.ExecuteReader
        While r1.Read
            Dim a As New RecordToPlot
            a.ID = r1.Item("ID")
            a.StAddress = r1.Item("StAddress")
            a.City = r1.Item("City")
            a.Zip = r1.Item("Zip")
            a.State = r1.Item("State")
            cntSRES += 1
            res.Add(a.ID, a)
        End While
        r1.Close()
        cnx.Close()
        cnx = Nothing
        Return res
    End Function

    Public Function Get_Marketing_Results_Data_Set(ByVal BeginDate As String, ByVal EndDate As String, ByVal MarketingResult As String, ByVal NumRecords As String)
        Dim res As New Dictionary(Of String, RecordToPlot)
        cntMRES = 0
        Dim cnx As New SqlConnection(STATIC_VARIABLES.Cnn)
        cnx.Open()
        Dim cmdGET As New SqlCommand("select top(" & NumRecords & ") ID,StAddress,City,State,zip from Enterlead where MarketingResults = '" & MarketingResult & "' and LeadGeneratedOn Between '" & BeginDate & "' and '" & EndDate & "';", cnx)
        Dim r1 As SqlDataReader = cmdGET.ExecuteReader
        While r1.Read
            Dim a As New RecordToPlot
            a.ID = r1.Item("ID")
            a.StAddress = r1.Item("StAddress")
            a.City = r1.Item("City")
            a.Zip = r1.Item("Zip")
            a.State = r1.Item("State")
            cntMRES += 1
            res.Add(a.ID, a)
        End While
        r1.Close()
        cnx.Close()
        cnx = Nothing
        Return res
    End Function

End Class
