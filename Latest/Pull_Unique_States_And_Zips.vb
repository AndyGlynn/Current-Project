Imports System.Data
Imports System.Data.SqlClient
Imports System
Imports System.Collections

Public Class Pull_Unique_States_And_Zips
    '' 
    '' This is a utility class for basically all 
    '' Geo Spatial classes / methods 
    '' 

    Public Structure UniqueCityStateZip

        Public Zip As String
        Public State As String
        Public City As String
    End Structure

    Private cmdTXT As String = "select Distinct(dbo.[EnterLead].[Zip]), dbo.[EnterLead].[City], dbo.[EnterLead].[State] from dbo.[EnterLead] Right Join dbo.[CityPull] On dbo.[EnterLead].[State] = dbo.[CityPull].[State] and dbo.[EnterLead].Zip is not null and dbo.[EnterLead].Zip <> ' ' and dbo.[EnterLead].[State] is not null and dbo.[EnterLead].[State] <> ' ' and dbo.[EnterLead].[City] is not null and dbo.[EnterLead].[City] <> '' and dbo.[EnterLead].[City] <> ' ';"
    Private cnx As String = "SERVER=192.168.1.2;Database=ISS;User Id=sa;Password=spoken1;"

    Public ar_UniqueCityStateZip As List(Of UniqueCityStateZip)

    Public Sub New()
        ar_UniqueCityStateZip = New List(Of UniqueCityStateZip)
        ar_UniqueCityStateZip = Get_Uniques()
    End Sub

    Private Function Get_Uniques()
        Dim arUniques As New List(Of UniqueCityStateZip)
        Try
            Dim cnxG As New SqlConnection(cnx)
            cnxG.Open()
            Dim cmdGET As New SqlCommand(cmdTXT, cnxG)
            Dim r1 As SqlDataReader = cmdGET.ExecuteReader
            While r1.Read
                Dim a As New UniqueCityStateZip

                a.City = r1.Item("City")
                a.Zip = r1.Item("Zip")
                a.State = r1.Item("State")
                arUniques.Add(a)
            End While
            r1.Close()
            cnxG.Close()
            Return arUniques
        Catch ex As Exception
            Main.Cursor = Cursors.Default
            Dim b As New ErrorLogging_V2
            b.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "Pull_Unique_States_And_Zip.vb", "Pull_Unique_States_And_Zip.vb", "Utility Class", "Get_Uniques()", "0", ex.Message.ToString)
            b = Nothing
            Return arUniques
        End Try
    End Function
End Class
