Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports MapPoint
Imports AxMapPoint


Public Class companyInfoSQL


#Region "Constructor"
    Public Sub New()
        CoINFO = New CompanyAddress
        CoINFO = Get_Company_Info()
    End Sub
#End Region
#Region "Company Info Operations"
    Public Structure CompanyAddress
        Public streetNumber As String
        Public StreenName As String
        Public AddressLine2 As String
        Public City As String
        Public State As String
        Public Zip As String
        Public CompanyName As String
    End Structure
    Private CoINFO As CompanyAddress
    Private pro_cnx As String = STATIC_VARIABLES.Cnn
    Public ReadOnly Property Comp_Info As CompanyAddress
        Get
            Return CoINFO
        End Get
    End Property
    Public Function Get_Company_Info()
        Dim z As New CompanyAddress
        Dim cnx As New SqlConnection(STATIC_VARIABLES.Cnn)
        cnx.Open()
        Dim cmdGET As New SqlCommand("SELECT streetNumber,StreetName,AddressLine2,City,State,Zip,CompanyName FROM companyInfo;", cnx)
        Dim r1 As SqlDataReader = cmdGET.ExecuteReader
        While r1.Read
            z.streetNumber = r1.Item("streetNumber")
            z.StreenName = r1.Item("StreetName")
            z.City = r1.Item("City")
            z.State = r1.Item("State")
            z.Zip = r1.Item("Zip")
            z.CompanyName = r1.Item("CompanyName")
        End While
        r1.Close()
        cnx.Close()
        cnx = Nothing
        Return z
    End Function
#End Region

End Class
