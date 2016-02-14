Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class quickINFO
    Private Const pro_cnx As String = "SERVER=192.168.1.2;Database=Iss;User Id=sa;Password=spoken1;"

    Public Structure QuickInfo
        Public ID As String
        Public C1FName As String
        Public C1LName As String
        Public C2FName As String
        Public C2LName As String
        Public HousePhone As String
        Public AltPhone1 As String
        Public AltPhone2 As String
        Public P1 As String
        Public P2 As String
        Public P3 As String
        Public LeadGenOn As String
    End Structure

    Private SingleRecord As QuickInfo
    Public ReadOnly Property Single_Rec As QuickInfo
        Get
            Return SingleRecord
        End Get
    End Property
    Public Sub New(ByVal RecID As String)
        SingleRecord = New QuickInfo
        SingleRecord = Get_Quick_Info(RecID)
    End Sub
    Private Function Get_Quick_Info(ByVal RecID As String)
        Dim a As New QuickInfo
        Dim cnx As New SqlConnection(pro_cnx)
        cnx.Open()
        Dim cmdGET As New SqlCommand("select Contact1FirstName,Contact1LastName,Contact2FirstName,Contact2LastName,Product1,Product2,Product3,HousePhone, LeadGeneratedOn, AltPhone1, AltPhone2 FROM EnterLead where ID = N'" & RecID & "'; ", cnx)
        Dim r1 As SqlDataReader = cmdGET.ExecuteReader
        While r1.Read
            a.ID = RecID
            a.C1FName = r1.Item("Contact1FirstName")
            a.C1LName = r1.Item("Contact1LastName")
            a.C2FName = r1.Item("Contact2FirstName")
            a.C2LName = r1.Item("Contact2LastName")
            a.HousePhone = r1.Item("HousePhone")
            a.AltPhone1 = r1.Item("AltPhone1")
            a.AltPhone2 = r1.Item("AltPhone2")
            a.P1 = r1.Item("Product1")
            a.P2 = r1.Item("Product2")
            a.P3 = r1.Item("Product3")
            a.LeadGenOn = r1.Item("LeadGeneratedOn")
        End While
        r1.Close()
        cnx.Close()
        cnx = Nothing
        Return a
    End Function
End Class
