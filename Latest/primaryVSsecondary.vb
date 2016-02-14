Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Imports MapPoint
Imports AxMapPoint

Public Class primaryVSsecondary
    Private Const pro_cnx As String = "SERVER=192.168.1.2;Database=Iss;User Id=sa;Password=spoken1;"

    Private PrimaryList As Dictionary(Of String, RecordToPlot)
    Private SecondaryList As Dictionary(Of String, RecordToPlot)

    Public ReadOnly Property Primary_List As Dictionary(Of String, RecordToPlot)
        Get
            Return PrimaryList
        End Get
    End Property
    Public ReadOnly Property Secondary_List As Dictionary(Of String, RecordToPlot)
        Get
            Return SecondaryList
        End Get
    End Property

    Public Structure RecordToPlot
        Public ID As String
        Public StAddress As String
        Public City As String
        Public State As String
        Public Zip As String
        Public Result As String
        Public ObjID As String
    End Structure


    Public Sub New(ByVal BeginDate As String, ByVal EndDate As String, ByVal ArQueryHeadings As ArrayList, ByVal NumRecordsToGet As String)
        PrimaryList = New Dictionary(Of String, RecordToPlot)
        SecondaryList = New Dictionary(Of String, RecordToPlot)
        PrimaryList = Get_List_Of_PrimayLeads(BeginDate, EndDate, ArQueryHeadings, NumRecordsToGet)
        SecondaryList = Get_List_Of_SecondarLeads(BeginDate, EndDate, ArQueryHeadings, NumRecordsToGet)
    End Sub

    Private Function Get_List_Of_PrimayLeads(ByVal BeginDate As String, ByVal EndDate As String, ByVal ArPrimaries As ArrayList, ByVal NumRecords As String)
        Dim arList As New Dictionary(Of String, RecordToPlot)
        Dim cnx As New SqlConnection(pro_cnx)
        cnx.Open()
        For Each x As String In ArPrimaries
            If InStr(x, "(Sales)") >= 1 Then
                '' this query needs to hit a different column(Result)
                Dim peices() = Split(x, "-", -1, Microsoft.VisualBasic.CompareMethod.Text)
                Dim res As String = Trim(peices(0))
                Dim cmdGET As New SqlCommand("SELECT TOP(" & NumRecords & ") ID,StAddress,City,State,Zip From EnterLead WHERE Result ='" & res & "' and LeadGeneratedOn Between '" & BeginDate & "' and '" & EndDate & "';", cnx)
                Dim r As SqlDataReader = cmdGET.ExecuteReader
                While r.Read
                    Dim a As New RecordToPlot
                    a.ObjID = Guid.NewGuid.ToString
                    a.ID = r.Item("ID")
                    a.StAddress = r.Item("StAddress")
                    a.City = r.Item("City")
                    a.State = r.Item("State")
                    a.Result = res
                    arList.Add(a.ObjID, a)
                End While
                r.Close()
            ElseIf InStr(x, "(Marketing)") >= 1 Then
                '' this query needs to hit a different column(MarketingResults)
                Dim peices() = Split(x, "-", -1, Microsoft.VisualBasic.CompareMethod.Text)
                Dim res As String = Trim(peices(0))
                Dim cmdGET As New SqlCommand("SELECT TOP(" & NumRecords & ") ID,StAddress,City,State,Zip From EnterLead WHERE MarketingResults = '" & res & "' and LeadGeneratedOn Between '" & BeginDate & "' and '" & EndDate & "';", cnx)
                Dim r As SqlDataReader = cmdGET.ExecuteReader
                While r.Read
                    Dim a As New RecordToPlot
                    a.ObjID = Guid.NewGuid.ToString
                    a.ID = r.Item("ID")
                    a.StAddress = r.Item("StAddress")
                    a.City = r.Item("City")
                    a.State = r.Item("State")
                    a.Result = res
                    arList.Add(a.ObjID, a)
                End While
                r.Close()
            End If
        Next
        cnx.Close()
        cnx = Nothing
        Return arList
    End Function

    Private Function Get_List_Of_SecondarLeads(ByVal BeginDate As String, ByVal EndDate As String, ByVal ArSecondaries As ArrayList, ByVal NumRecords As String)
        Dim arList As New Dictionary(Of String, RecordToPlot)
        Dim cnx As New SqlConnection(pro_cnx)
        cnx.Open()
        For Each x As String In ArSecondaries
            If InStr(x, "(Sales)") >= 1 Then
                '' this query needs to hit a different column(Result)
                Dim peices() = Split(x, "-", -1, Microsoft.VisualBasic.CompareMethod.Text)
                Dim res As String = Trim(peices(0))
                Dim cmdGET As New SqlCommand("SELECT TOP(" & NumRecords & ") ID,StAddress,City,State,Zip From EnterLead WHERE Result ='" & res & "' and LeadGeneratedOn Between '" & BeginDate & "' and '" & EndDate & "';", cnx)
                Dim r As SqlDataReader = cmdGET.ExecuteReader
                While r.Read
                    Dim a As New RecordToPlot
                    a.ObjID = Guid.NewGuid.ToString
                    a.ID = r.Item("ID")
                    a.StAddress = r.Item("StAddress")
                    a.City = r.Item("City")
                    a.State = r.Item("State")
                    a.Result = res
                    arList.Add(a.ObjID, a)
                End While
                r.Close()
            ElseIf InStr(x, "(Marketing)") >= 1 Then
                '' this query needs to hit a different column(MarketingResults)
                Dim peices() = Split(x, "-", -1, Microsoft.VisualBasic.CompareMethod.Text)
                Dim res As String = Trim(peices(0))
                Dim cmdGET As New SqlCommand("SELECT TOP(" & NumRecords & ") ID,StAddress,City,State,Zip From EnterLead WHERE MarketingResults = '" & res & "' and LeadGeneratedOn Between '" & BeginDate & "' and '" & EndDate & "';", cnx)
                Dim r As SqlDataReader = cmdGET.ExecuteReader
                While r.Read
                    Dim a As New RecordToPlot
                    a.ObjID = Guid.NewGuid.ToString
                    a.ID = r.Item("ID")
                    a.StAddress = r.Item("StAddress")
                    a.City = r.Item("City")
                    a.State = r.Item("State")
                    a.Result = res
                    arList.Add(a.ObjID, a)
                End While
                r.Close()
            End If
        Next
        cnx.Close()
        cnx = Nothing
        Return arList
    End Function

End Class
