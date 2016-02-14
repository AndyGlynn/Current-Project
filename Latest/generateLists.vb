Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class generateLists

    Private Const pro_cnx As String = "SERVER=192.168.1.2;Database=Iss;User Id=sa;Password=spoken1;"
    Private SalesResults As List(Of String)
    Private MarketingResults As List(Of String)
    Private CityList As List(Of String)


    Public ReadOnly Property Sales_Results As List(Of String)
        Get
            Return SalesResults
        End Get
    End Property
    Public ReadOnly Property Marketing_Results As List(Of String)
        Get
            Return MarketingResults
        End Get
    End Property
    Public ReadOnly Property City_List As List(Of String)
        Get
            Return CityList
        End Get
    End Property


    Public Sub New()
        SalesResults = New List(Of String)
        SalesResults = Get_SResults()
        MarketingResults = New List(Of String)
        MarketingResults = Get_MResults()
        CityList = New List(Of String)
        CityList = get_Cities()
    End Sub


    Private Function Get_Cities()
        Dim arRes As New List(Of String)
        Dim cnx As New SqlConnection(pro_cnx)
        cnx.Open()
        Dim cmdGET As New SqlCommand("select Distinct(City),state FROM EnterLead WHERE City is not Null and City != ' ';", cnx)
        Dim r1 As SqlDataReader = cmdGET.ExecuteReader
        While r1.Read
            arRes.Add(r1.Item("City") & "-" & r1.Item("State"))
        End While
        r1.Close()
        cnx.Close()
        cnx = Nothing
        Return arRes
    End Function

    Private Function Get_MResults()
        Dim arRes As New List(Of String)
        Dim cnx As New SqlConnection(pro_cnx)
        cnx.Open()
        Dim cmdGET As New SqlCommand("select Distinct(MarketingResults) FROM EnterLead WHERE MarketingResults is not Null and MarketingResults != ' ';", cnx)
        Dim r1 As SqlDataReader = cmdGET.ExecuteReader
        While r1.Read
            arRes.Add(r1.Item("MarketingResults"))
        End While
        r1.Close()
        cnx.Close()
        cnx = Nothing
        Return arRes
    End Function
    Private Function Get_SResults()
        Dim arRes As New List(Of String)
        Dim cnx As New SqlConnection(pro_cnx)
        cnx.Open()
        Dim cmdGET As New SqlCommand("select Distinct(Result) FROM EnterLead WHERE Result is not Null and Result != ' ';", cnx)
        Dim r1 As SqlDataReader = cmdGET.ExecuteReader
        While r1.Read
            arRes.Add(r1.Item("Result"))
        End While
        r1.Close()
        cnx.Close()
        cnx = Nothing
        Return arRes
    End Function


End Class
