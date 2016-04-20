Imports System.IO
Imports System.Text.StringBuilder
Imports System.Drawing.Printing
Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class Sales_Print_Operations_V2

    Public Exclu_ As Exclusions

    Public Structure Exclusions
        Public Generated As Boolean
        Public Marketer As Boolean
        Public PLS As Boolean
        Public SLS As Boolean
        Public LastMResult As Boolean
        Public Phone As Boolean
    End Structure

    Public Structure MessageBody
        Public RecordID As String
        Public ApptDayOfWeek As String
        Public customerLName As String
        Public customer1FName As String
        Public customer2LName As String
        Public ApptDate As String
        Public ApptTime As String '' split this up or reformat to make it look better
        Public Product1 As String
        Public Product2 As String
        Public Product3 As String
        Public SpecialInstruction As String
        Public LeadGeneratedOn As String '' need to split this up to show date and not time
        Public PLS As String
        Public SLS As String
        Public Marketer As String
        Public LastMResult As String
        Public StAddress As String
        Public City As String
        Public State As String
        Public Zip As String
        Public HousePhone As String
        Public AltPhone1 As String
        Public AltPhone2 As String
    End Structure

    Private Const sqlCNX As String = "SERVER=192.168.1.2;Database=ISS;User Id=sa;Password=spoken1"

#Region "Get Exclusions"
    Private Function GetExclusions()
        Try
            Dim cnx_ex As SqlConnection = New SqlConnection(sqlCNX)
            Dim cmdGet As SqlCommand = New SqlCommand("SELECT * From iss.dbo.Exclusions", cnx_ex)
            cnx_ex.Open()
            Dim exclusion_ As New Exclusions
            Dim r1 As SqlDataReader = cmdGet.ExecuteReader
            While r1.Read
                exclusion_.Generated = r1.Item("Generated")
                exclusion_.Marketer = r1.Item("Marketer")
                exclusion_.PLS = r1.Item("PLS")
                exclusion_.SLS = r1.Item("SLS")
                exclusion_.LastMResult = r1.Item("LastMResult")
                exclusion_.Phone = r1.Item("Phone")
            End While
            r1.Close()
            cnx_ex.Close()
            cnx_ex = Nothing
            Return exclusion_
        Catch ex As Exception
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now.ToString, My.Computer.Name, STATIC_VARIABLES.IP, "Sales_Print_Operations_V2", "Sales_Print_Operations_V2", "Function", "GetExclusions()", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Function

    Public Property ExclusionList As Exclusions
        Get
            Return Exclu_
        End Get
        Set(value As Exclusions)
            Exclu_ = value
        End Set
    End Property


#End Region

    Public Sub New(ByVal WithOrWithOutExclusions As Boolean, ByVal RecID As String)

        '' withorwithout
        '' Sales.vb Lines {5119 - 5132}
        '' false = dont use them
        '' true = use them 
        '' 
        If WithOrWithOutExclusions = True Then
            Exclu_ = GetExclusions()
            '' pipe to single record print WITH exclusions
            Dim y As New printToPrinterApptSheet(RecID, True, Exclu_)
        Else
            Dim y As New printToPrinterApptSheet(RecID)
        End If
    End Sub
    Public Sub New(ByVal WithOrWithoutExclusions As Boolean, ByVal ArRecIDs As ArrayList)

        '' withorwithout
        '' Sales.vb Lines {5119 - 5132}
        '' false = dont use them
        '' true = use them 
        '' 

        If WithOrWithoutExclusions = True Then
            Exclu_ = GetExclusions()
            '' pipe to MULTI record print WITH exclusions
            Dim y As New printToPrinterApptSheet(ArRecIDs, Exclu_)
        Else
            Dim y As New printToPrinterApptSheet(ArRecIDs)
        End If
    End Sub

     

End Class
