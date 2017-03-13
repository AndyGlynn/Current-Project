Imports System.Net.Mail
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient



Public Class bulkEmail
    Private dev_cnx = STATIC_VARIABLES.Cnn
    Private pro_cnx As String = STATIC_VARIABLES.Cnn

    '' Purpose: Take a (list) of "leads" and apply a template to them, then send out to be mailed.
    '' 
    Public Sub EmailList(ByVal List_Of_Leads As List(Of convertLeadToStruct.EnterLead_Record), ByVal TemplateName As String)


    End Sub

    Public Structure User
        Public FName As String
        Public LName As String
        Public Department As String
    End Structure

    Public Structure EmailMessageScrubbed
        Public recID As String
        Public Subject As String
        Public Body As String
    End Structure

    Public Current_User_Info As User = Nothing
    Public ListOfLeads As List(Of convertLeadToStruct.EnterLead_Record)

#Region "Testing Subs and Funcs - NOT FOR PRODUCTION - PRO IS SUBJECT TO CHANGE"
    ''11-3-2015 AC
    '' 

    Public Property CurrentUser As User
        Get
            Return Current_User_Info
        End Get
        Set(value As User)
            Current_User_Info = value
        End Set
    End Property

    Public Sub New(ByVal Dev_Or_Pro As Boolean)
        Try
            Me.CurrentUser = Get_CurrentUser_AND_Department(Dev_Or_Pro)
            Dim arLeads As New ArrayList
            arLeads = Grab_Top_TwentyFiveLeads(Dev_Or_Pro)
            Me.ListOfLeads = New List(Of convertLeadToStruct.EnterLead_Record)
            Me.ListOfLeads = Grab_Top_TwentyFiveLeadsCONVERTED(arLeads, Dev_Or_Pro)
        Catch ex As Exception

            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now.ToString, My.Computer.Name, STATIC_VARIABLES.IP, "bulkEmail", "bulkEmail", "Class", "Constructor(dev or pro)", "0", ex.Message.ToString)
            y = Nothing
        End Try
    End Sub

    Private Function Grab_Top_TwentyFiveLeads(ByVal Dev_or_Pro)
        Try
            Dim arLeadIds As New ArrayList
            Dim cnx As SqlConnection
            If Dev_or_Pro = False Then
                cnx = New SqlConnection(STATIC_VARIABLES.Cnn)
            ElseIf Dev_or_Pro = True Then
                cnx = New SqlConnection(dev_cnx)
            End If
            cnx.Open()
            Dim cmdGET As New SqlCommand("SELECT TOP(25) ID from enterlead;", cnx)
            Dim r1 As SqlDataReader = cmdGET.ExecuteReader
            While r1.Read
                arLeadIds.Add(r1.Item("ID"))
            End While
            r1.Close()
            cnx.Close()
            cnx = Nothing
            Return arLeadIds
        Catch ex As Exception
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now.ToString, My.Computer.Name, STATIC_VARIABLES.IP, "bulkEmail", "bulkEmail", "Function", "Grab_Top_TwentyFiveLeads(dev_or_pro)", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Function

    Private Function Grab_Top_TwentyFiveLeadsCONVERTED(ByVal ListOfRecIDs As ArrayList, ByVal Dev_Or_Pro As Boolean)
        Try
            Dim z As New convertLeadToStruct
            For Each x As Integer In ListOfRecIDs
                ListOfLeads.Add(z.ConvertToStructure(x.ToString, Dev_Or_Pro))
            Next
            Return ListOfLeads
        Catch ex As Exception
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now.ToString, My.Computer.Name, STATIC_VARIABLES.IP, "bulkEmail", "bulkEmail", "Function", "Grab_Top_TwentyFiveLeadsConverted(listofrecids,devorpro)", "0", ex.Message.ToString)
            y = Nothing

        End Try

    End Function

    Public Function Get_CurrentUser_AND_Department(ByVal Dev_Or_Pro As Boolean)
        Try
            Dim x As New User
            Dim name() = Split(STATIC_VARIABLES.CurrentUser, " ", -1, Microsoft.VisualBasic.CompareMethod.Text)
            x.FName = name(0)
            x.LName = name(1)
            x.Department = Get_User_Department(x.FName, x.LName, Dev_Or_Pro)
            Return x
        Catch ex As Exception
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now.ToString, My.Computer.Name, STATIC_VARIABLES.IP, "bulkEmail", "bulkEmail", "Function", "Get_CurrentUser_AND_Department(devorpro)", "0", ex.Message.ToString)
            y = Nothing

        End Try

    End Function

    Private Function Get_User_Department(ByVal FName As String, ByVal LName As String, ByVal Dev_Or_Pro As Boolean)
        Try
            Dim depart_ As String = ""
            Dim cnx As SqlConnection
            If Dev_Or_Pro = False Then
                cnx = New SqlConnection(STATIC_VARIABLES.Cnn)
            ElseIf Dev_Or_Pro = True Then
                cnx = New SqlConnection(dev_cnx)
            End If
            cnx.Open()
            Dim cmdGET As New SqlCommand("SELECT Department FROM tblTestEmployee WHERE FName = '" & FName & "' and LName = '" & LName & "';", cnx)
            depart_ = cmdGET.ExecuteScalar
            cnx.Close()
            cnx = Nothing
            Return depart_
        Catch ex As Exception
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now.ToString, My.Computer.Name, STATIC_VARIABLES.IP, "bulkEmail", "bulkEmail", "Function", "Get_User_Department(FName,LName,DevOrPro)", "0", ex.Message.ToString)
            y = Nothing

        End Try

    End Function

#End Region

End Class
