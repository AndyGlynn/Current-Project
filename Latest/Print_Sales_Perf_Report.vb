Imports System.Windows.Forms
Imports System.IO
Imports System.Text
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Drawing.Printing


Public Class Print_Sales_Perf_Report


#Region "Notes - Print Report Button"
    '' 12-14 AC
    '' need a method here to generate an inline document to be printed off.
    '' or at least gather the 'lines' of the report and send to an array to be deterined if a report needs to be printed or not.
    '' 
    '' couple of options here.. . . 
    '' 1) cache data then use/dont use as button press dictates
    '' 2) pull/render print object from data already displayed on front end
    '' 3) run a separate class to 're-generate' generated report and THEN render print obj / create file for printing. 
    ''    basically re-run the queries but only for a print obj/html doc this time
    '' 

    '' report file naming convention [ yyyy-mm-dd-HH-MM-SS-PerfReport.htm ] 
    '' 


#End Region

    Private arLinesOfData As List(Of LineOfData)
    Private reportWriter As StreamWriter

    Private Const Pro_ReportDirectory As String = "\\192.168.1.2\Company\ISS\Sales Performance Reports\"
    Private Const Dev_ReportDirectory As String = "C:\Users\Clay\Desktop\Sales Performance Reports\"

    Private Const cnx As String = "SERVER=192.168.1.2;Database=ISS;User Id=sa;Password=spoken1;"

    Public Structure LineOfData
        Public ControlName As String
        Public SalesRep As String
        Public Issued As Integer
        Public DemoNoSaleCount As Integer
        Public DemoNoSalePercent As String
        Public NotHitCount As Integer
        Public NotHitPercent As String
        Public ResetCount As Integer
        Public ResetCountPercent As String
        Public NoDemoCount As Integer
        Public NoDemoCountPercent As String
        Public SalesCount As Integer
        Public SalesCountPercent As String
        Public RecissionCancelCount As Integer
        Public RecissionCancelPercent As String
        Public TotalSoldPerRep As String
    End Structure

    ''
    '' r1.item(0) [ Complete Line ] 
    ''
    Public Structure TotalsData
        Public Name As String
        Public ttlNumIssued As Integer
        Public ttlDemoNoSales As Integer
        Public ttlDemoNoPer As Integer
        Public ttlNotHits As Integer
        Public ttlNotHitsPer As Integer
        Public ttlResets As Integer
        Public ttlResetsPer As Integer
        Public ttlNoDemos As Integer
        Public ttlNotDemosPer As Integer
        Public ttlSales As Integer
        Public ttlSalesPer As Integer
        Public ttlRecissionCancel As Integer
        Public ttlRecissionCancelPer As Integer
        Public ttlSold As Double
    End Structure


    Public Sub New(ByVal StartDate As Date, ByVal EndDate As Date, ByVal Accuracy As String)

        Dim year As Integer = Date.Today.Year
        Dim month As Integer = Date.Today.Month
        Dim day As Integer = Date.Today.Day

        Dim hour As Integer = Date.Now.Hour
        Dim minute As Integer = Date.Now.Minute
        Dim second As Integer = Date.Now.Second

        Dim strFileName As String = (Dev_ReportDirectory & year.ToString & "-" & month.ToString & "-" & day.ToString & "-" & hour.ToString & "-" & minute.ToString & "-" & second.ToString & "-PerfReport.htm")
        If System.IO.File.Exists(strFileName) = True Then
            System.IO.File.Delete(strFileName)
        ElseIf System.IO.File.Exists(strFileName) = False Then
            reportWriter = New StreamWriter(strFileName)
        End If

        Dim arData As List(Of LineOfData) = GenerateLines(StartDate, EndDate)
        Write_HTML_Doc(arData, StartDate, EndDate, Accuracy)

        'reportWriter.WriteLine("ID | Rep | Issued | Demos | DemoPer | Resets | ResetsPer | NotHit | NotHitPer | NoDemo | NoDemoPer | Sale | SalePer | RC | RCPer | Sold | NoResults ")
        'reportWriter.WriteLine("int  var    numer   numer   numer     numer      numer      numer   numer        numer     numer      numer  numer    numer numer   money  numer")
        'reportWriter.WriteLine("-----DATA----")
        'If arData.Count >= 1 Then
        '    For Each x As LineOfData In arData
        '        reportWriter.Write(x.ControlName & " | " & x.SalesRep & " | " & x.DemoNoSaleCount & " | " & x.DemoNoSalePercent & "% | " & x.ResetCount & " | " & x.ResetCountPercent & "% | " & x.NotHitCount & " | " & x.NotHitPercent & "% | " & x.NoDemoCount & " | " & x.NoDemoCountPercent & "% | " & x.SalesCount & " | " & x.SalesCountPercent & "% | " & x.RecissionCancelCount & " | " & x.RecissionCancelPercent & "% | $" & Math.Round(CType(x.TotalSoldPerRep, Double), 2).ToString & vbCrLf)
        '    Next
        '    reportWriter.Flush()
        '    reportWriter.Close()
        '    System.Diagnostics.Process.Start(strFileName)
        'ElseIf arData.Count <= 0 Then
        '    reportWriter.Flush()
        '    reportWriter.Close()
        '    Exit Sub
        'End If

    End Sub

    Private Function GenerateLines(ByVal StartDate As Date, ByVal EndDate As Date)
        arLinesOfData = New List(Of LineOfData)

        Try
            Dim cnx1 As New SqlConnection(cnx)
            cnx1.Open()
            Dim dt1 As String = Date_Strip(Sales.dtpSummary.Value)
            Dim dt2 As String = Date_Strip(Sales.dtpSummary2.Value)
            Dim cmdGet As SqlCommand
            cmdGet = New SqlCommand("dbo.SalesPerformanceReport", cnx1)
            Dim param1 As SqlParameter = New SqlParameter("@Date1", dt2)
            Dim param2 As SqlParameter = New SqlParameter("@Date2", dt1)
            cmdGet.CommandType = CommandType.StoredProcedure
            cmdGet.Parameters.Add(param1)
            cmdGet.Parameters.Add(param2)
            Dim r1 As SqlDataReader
            r1 = cmdGet.ExecuteReader
            ''
            '' tmp table structure
            '' ID | Rep | Issued | Demos | DemoPer | Resets | ResetsPer | NotHit | NotHitPer | NoDemo | NoDemoPer | Sale | SalePer | RC | RCPer | Sold | NoResults 
            '' int  var    numer   numer   numer     numer      numer      numer   numer        numer     numer      numer  numer    numer numer   money  numer
            ''
            While r1.Read
                Dim g As New LineOfData
                g.ControlName = r1.Item("ID")
                g.SalesRep = r1.Item("Rep")
                g.Issued = r1.Item("Issued")
                g.DemoNoSaleCount = r1.Item("Demos")
                g.DemoNoSalePercent = r1.Item("DemoPer")
                g.ResetCount = r1.Item("Resets")
                g.ResetCountPercent = r1.Item("ResetsPer")
                g.NotHitCount = r1.Item("NotHit")
                g.NotHitPercent = r1.Item("NotHitPer")
                g.NoDemoCount = r1.Item("NoDemo")
                g.NoDemoCountPercent = r1.Item("NoDemoPer")
                g.SalesCount = r1.Item("Sale")
                g.SalesCountPercent = r1.Item("SalePer")
                g.RecissionCancelCount = r1.Item("RC")
                g.RecissionCancelPercent = r1.Item("RcPer")
                g.TotalSoldPerRep = r1.Item("Sold")
                arLinesOfData.Add(g)
            End While
            cnx1.Close()
            cnx1 = Nothing
            Return arLinesOfData

        Catch ex As Exception
            Dim err As String = ex.Message
            MsgBox("Error: Performance Report.", MsgBoxStyle.Critical, "DEBUG INFO - Error On Perf Report")
        End Try

    End Function
    Private Function Date_Strip(ByVal Dt As Date)
        Dim dts As String = Dt.ToString
        Dim x = InStr(dts, " ")
        If x <> 0 Then
            dts = Microsoft.VisualBasic.Left(dts, x - 1)
        End If

        dts = dts & " 12:00:00 AM"
        Return dts
    End Function

#Region "Write_HTML_DOC()"
    Private Sub Write_HTML_Doc(ByVal ListData As List(Of LineOfData), ByVal StartDate As String, ByVal EndDate As String, ByVal Accuracy As String)
        Dim cntData As Integer = 0
        cntData = ListData.Count
        If cntData <= 0 Then
            Exit Sub
        End If

        Dim path As String = Pro_ReportDirectory

        Dim year As Integer = Date.Now.Year
        Dim month As Integer = Date.Now.Month
        Dim day As Integer = Date.Now.Day

        Dim hour As Integer = Date.Now.Hour
        Dim minute As Integer = Date.Now.Minute
        Dim second As Integer = Date.Now.Second

        Dim ext As String = ".htm"

        Dim complete_File_Path As String = (Pro_ReportDirectory & year & "-" & month & "-" & day & "-" & hour & "-" & minute & "-" & second & ext)
        Dim sr As StreamWriter


        If System.IO.File.Exists(complete_File_Path) = True Then
            System.IO.File.Delete(complete_File_Path)
            sr = New StreamWriter(complete_File_Path)
        ElseIf System.IO.File.Exists(complete_File_Path) = False Then
            sr = New StreamWriter(complete_File_Path)
        End If

        '' 
        '' This portion is going to dimension a variable to hold the 'css/style' for PRINT info ONLY
        '' 

        Dim mediaScreen As String = ""
        mediaScreen += "<style type='text/css' media='screen'>" & vbCrLf
        mediaScreen += "@media screen  " & vbCrLf
        mediaScreen += "{" & vbCrLf

        mediaScreen += "@-ms-viewport" & vbCrLf
        mediaScreen += "{" & vbCrLf
        mediaScreen += "width:1024px;" & vbCrLf
        mediaScreen += "height:768px;" & vbCrLf
        mediaScreen += "}" & vbCrLf

        'mediaScreen += "div.screen" & vbCrLf
        'mediaScreen += "{" & vbCrLf
        'mediaScreen += "position:fixed;" & vbCrLf

        'mediaScreen += "width:1024px;" & vbCrLf
        'mediaScreen += "margin-left:12px;" & vbCrLf
        'mediaScreen += "margin-right:12px;" & vbCrLf
        'mediaScreen += "border-style-solid;" & vbCrLf
        'mediaScreen += "border-width:1px;" & vbCrLf
        'mediaScreen += "border-color:black;" & vbCrLf
        'mediaScreen += "border-radius:3px;" & vbCrLf

        'mediaScreen += "}" & vbCrLf

        mediaScreen += "span.lblTitleHeader" & vbCrLf
        mediaScreen += "{" & vbCrLf
        mediaScreen += "position:relative;" & vbCrLf
        mediaScreen += "font-family:""Verdana"",sans-serif;" & vbCrLf
        mediaScreen += "font-size:1.2em;" & vbCrLf
        mediaScreen += "left:415px;" & vbCrLf
        mediaScreen += "top:5px;" & vbCrLf
        mediaScreen += "padding-top:3px;" & vbCrLf
        mediaScreen += "padding-bottom:3px;" & vbCrLf
        mediaScreen += "height:25px;" & vbCrLf
        mediaScreen += "width:auto;" & vbCrLf
        mediaScreen += "color:black;" & vbCrLf
        mediaScreen += "text-decoration:none;" & vbCrLf
        mediaScreen += "text-align:center;" & vbCrLf

        mediaScreen += "}" & vbCrLf

        mediaScreen += "span.lblAccuracyHeader" & vbCrLf
        mediaScreen += "{" & vbCrLf
        mediaScreen += "position:fixed;" & vbCrLf
        mediaScreen += "font-family:""Verdana"",sans-serif;" & vbCrLf
        mediaScreen += "font-size:0.6em;" & vbCrLf
        mediaScreen += "font-style:italic;" & vbCrLf
        mediaScreen += "left:42px;" & vbCrLf
        mediaScreen += "top:18px;" & vbCrLf
        mediaScreen += "padding-top:3px;" & vbCrLf
        mediaScreen += "padding-bottom:3px;" & vbCrLf
        mediaScreen += "height:25px;" & vbCrLf
        mediaScreen += "width:auto;" & vbCrLf
        mediaScreen += "color:black;" & vbCrLf
        mediaScreen += "text-align:left;" & vbCrLf
        mediaScreen += "}" & vbCrLf

        mediaScreen += "span.lblDateRangeHeader" & vbCrLf
        mediaScreen += "{" & vbCrLf
        mediaScreen += "position:relative;" & vbCrLf
        mediaScreen += "font-family:""Verdana"",sans-serif;" & vbCrLf
        mediaScreen += "font-size:0.6em;" & vbCrLf
        mediaScreen += "font-style:italic;" & vbCrLf
        mediaScreen += "margin-right:11px;" & vbCrLf
        mediaScreen += "float:right;" & vbCrLf
        mediaScreen += "top:9px;" & vbCrLf
        mediaScreen += "padding-top:3px;" & vbCrLf
        mediaScreen += "padding-bottom:3px;" & vbCrLf
        mediaScreen += "height:25px;" & vbCrLf
        mediaScreen += "width:auto;" & vbCrLf
        mediaScreen += "color:black;" & vbCrLf
        mediaScreen += "text-align:right;" & vbCrLf
        mediaScreen += "}" & vbCrLf

        mediaScreen += "div.screen" & vbCrLf
        mediaScreen += "{" & vbCrLf
        mediaScreen += "position:fixed;" & vbCrLf
        mediaScreen += "left:30px;" & vbCrLf
        mediaScreen += "margin-left:0px;" & vbCrLf
        mediaScreen += "margin-right:0px;" & vbCrLf
        mediaScreen += "margin-top:0px;" & vbCrLf
        mediaScreen += "margin-bottom:0px;" & vbCrLf
        mediaScreen += "width:1024px;" & vbCrLf
        mediaScreen += "height:750px;" & vbCrLf
        mediaScreen += "box-shadow:0px 0px 12px grey;" & vbCrLf
        mediaScreen += "border-style-solid;" & vbCrLf
        mediaScreen += "border-width:1px;" & vbCrLf
        mediaScreen += "border-color:black;" & vbCrLf
        mediaScreen += "border-radius:2px;" & vbCrLf

        mediaScreen += "}" & vbCrLf

        mediaScreen += "div.hdrLbls" & vbCrLf
        mediaScreen += "{" & vbCrLf
        mediaScreen += "position:fixed;" & vbCrLf
        mediaScreen += "border-style:solid;" & vbCrLf
        mediaScreen += "border-width:1px;" & vbCrLf
        mediaScreen += "border-color:black;" & vbCrLf
        mediaScreen += "height:auto;" & vbCrLf
        mediaScreen += "width:1000px;" & vbCrLf
        mediaScreen += "margin-left:12px;" & vbCrLf
        mediaScreen += "margin-right:12px;" & vbCrLf
        mediaScreen += "margin-top:5px;" & vbCrLf
        mediaScreen += "height:30px;" & vbCrLf
        mediaScreen += "}" & vbCrLf

        mediaScreen += "span.lblSalesRep" & vbCrLf
        mediaScreen += "{" & vbCrLf
        mediaScreen += "position:fixed;" & vbCrLf
        mediaScreen += "width:140px;" & vbCrLf
        mediaScreen += "margin-left:5px;" & vbCrLf
        mediaScreen += "text-align:center;" & vbCrLf
        mediaScreen += "font-family:""Verdana"",sans-serif;" & vbCrLf
        mediaScreen += "font-size:0.9em;" & vbCrLf
        mediaScreen += "font-weight:bold;" & vbCrLf
        mediaScreen += "height:auto;" & vbCrLf
        mediaScreen += "margin-top:5px;" & vbCrLf
        mediaScreen += "padding-bottom:2px;" & vbCrLf
        mediaScreen += "}" & vbCrLf

        mediaScreen += "span.lblNumIssued" & vbCrLf
        mediaScreen += "{" & vbCrLf
        mediaScreen += "position:fixed;" & vbCrLf
        mediaScreen += "width:100px;" & vbCrLf
        mediaScreen += "margin-left:5px;" & vbCrLf
        mediaScreen += "text-align:center;" & vbCrLf
        mediaScreen += "font-family:""Verdana"",sans-serif;" & vbCrLf
        mediaScreen += "font-size:0.9em;" & vbCrLf
        mediaScreen += "font-weight:bold;" & vbCrLf
        mediaScreen += "height:auto;" & vbCrLf
        mediaScreen += "margin-top:5px;" & vbCrLf
        mediaScreen += "padding-bottom:2px;" & vbCrLf
        mediaScreen += "left:155px;" & vbCrLf

        mediaScreen += "}" & vbCrLf

        mediaScreen += "span.lblDemoNoSales" & vbCrLf
        mediaScreen += "{" & vbCrLf
        mediaScreen += "position:fixed;" & vbCrLf
        mediaScreen += "width:160px;" & vbCrLf
        mediaScreen += "margin-left:5px;" & vbCrLf
        mediaScreen += "text-align:center;" & vbCrLf
        mediaScreen += "font-family:""Verdana"",sans-serif;" & vbCrLf
        mediaScreen += "font-size:0.9em;" & vbCrLf
        mediaScreen += "font-weight:bold;" & vbCrLf
        mediaScreen += "height:auto;" & vbCrLf
        mediaScreen += "margin-top:5px;" & vbCrLf
        mediaScreen += "padding-bottom:2px;" & vbCrLf
        mediaScreen += "left:235px;" & vbCrLf

        mediaScreen += "}" & vbCrLf
        mediaScreen += "span.lblNotHits" & vbCrLf
        mediaScreen += "{" & vbCrLf
        mediaScreen += "position:fixed;" & vbCrLf
        mediaScreen += "width:90px;" & vbCrLf
        mediaScreen += "margin-left:5px;" & vbCrLf
        mediaScreen += "text-align:center;" & vbCrLf
        mediaScreen += "font-family:""Verdana"",sans-serif;" & vbCrLf
        mediaScreen += "font-size:0.9em;" & vbCrLf
        mediaScreen += "font-weight:bold;" & vbCrLf
        mediaScreen += "height:auto;" & vbCrLf
        mediaScreen += "margin-top:5px;" & vbCrLf
        mediaScreen += "padding-bottom:2px;" & vbCrLf
        mediaScreen += "left:375px;" & vbCrLf

        mediaScreen += "}" & vbCrLf

        mediaScreen += "span.lblResets" & vbCrLf
        mediaScreen += "{" & vbCrLf
        mediaScreen += "position:fixed;" & vbCrLf
        mediaScreen += "width:70px;" & vbCrLf
        mediaScreen += "margin-left:5px;" & vbCrLf
        mediaScreen += "text-align:center;" & vbCrLf
        mediaScreen += "font-family:""Verdana"",sans-serif;" & vbCrLf
        mediaScreen += "font-size:0.9em;" & vbCrLf
        mediaScreen += "font-weight:bold;" & vbCrLf
        mediaScreen += "height:auto;" & vbCrLf
        mediaScreen += "margin-top:5px;" & vbCrLf
        mediaScreen += "padding-bottom:2px;" & vbCrLf
        mediaScreen += "left:455px;" & vbCrLf

        mediaScreen += "}" & vbCrLf
        mediaScreen += "span.lblNoDemos" & vbCrLf
        mediaScreen += "{" & vbCrLf
        mediaScreen += "position:fixed;" & vbCrLf
        mediaScreen += "width:90px;" & vbCrLf
        mediaScreen += "margin-left:5px;" & vbCrLf
        mediaScreen += "text-align:center;" & vbCrLf
        mediaScreen += "font-family:""Verdana"",sans-serif;" & vbCrLf
        mediaScreen += "font-size:0.9em;" & vbCrLf
        mediaScreen += "font-weight:bold;" & vbCrLf
        mediaScreen += "height:auto;" & vbCrLf
        mediaScreen += "margin-top:5px;" & vbCrLf
        mediaScreen += "padding-bottom:2px;" & vbCrLf
        mediaScreen += "left:525px;" & vbCrLf

        mediaScreen += "}" & vbCrLf

        mediaScreen += "span.lblSales" & vbCrLf
        mediaScreen += "{" & vbCrLf
        mediaScreen += "position:fixed;" & vbCrLf
        mediaScreen += "width:70px;" & vbCrLf
        mediaScreen += "margin-left:5px;" & vbCrLf
        mediaScreen += "text-align:center;" & vbCrLf
        mediaScreen += "font-family:""Verdana"",sans-serif;" & vbCrLf
        mediaScreen += "font-size:0.9em;" & vbCrLf
        mediaScreen += "font-weight:bold;" & vbCrLf
        mediaScreen += "height:auto;" & vbCrLf
        mediaScreen += "margin-top:5px;" & vbCrLf
        mediaScreen += "padding-bottom:2px;" & vbCrLf
        mediaScreen += "left:615px;" & vbCrLf

        mediaScreen += "}" & vbCrLf

        mediaScreen += "span.lblRecissionCancels" & vbCrLf
        mediaScreen += "{" & vbCrLf
        mediaScreen += "position:fixed;" & vbCrLf
        mediaScreen += "width:170px;" & vbCrLf
        mediaScreen += "margin-left:5px;" & vbCrLf
        mediaScreen += "text-align:center;" & vbCrLf
        mediaScreen += "font-family:""Verdana"",sans-serif;" & vbCrLf
        mediaScreen += "font-size:0.9em;" & vbCrLf
        mediaScreen += "font-weight:bold;" & vbCrLf
        mediaScreen += "height:auto;" & vbCrLf
        mediaScreen += "margin-top:5px;" & vbCrLf
        mediaScreen += "padding-bottom:2px;" & vbCrLf
        mediaScreen += "left:685px;" & vbCrLf

        mediaScreen += "}" & vbCrLf

        mediaScreen += "span.lblTotalSold" & vbCrLf
        mediaScreen += "{" & vbCrLf
        mediaScreen += "position:fixed;" & vbCrLf
        mediaScreen += "width:170px;" & vbCrLf
        mediaScreen += "margin-left:5px;" & vbCrLf
        mediaScreen += "text-align:center;" & vbCrLf
        mediaScreen += "font-family:""Verdana"",sans-serif;" & vbCrLf
        mediaScreen += "font-size:0.9em;" & vbCrLf
        mediaScreen += "font-weight:bold;" & vbCrLf
        mediaScreen += "height:auto;" & vbCrLf
        mediaScreen += "margin-top:5px;" & vbCrLf
        mediaScreen += "padding-bottom:2px;" & vbCrLf
        mediaScreen += "left:855px;" & vbCrLf

        mediaScreen += "}	" & vbCrLf

        mediaScreen += "div.subCont" & vbCrLf
        mediaScreen += "{" & vbCrLf
        mediaScreen += "position:fixed;" & vbCrLf
        mediaScreen += "width:1000px;" & vbCrLf
        mediaScreen += "border-style:solid;" & vbCrLf
        mediaScreen += "border-width:1px;" & vbCrLf
        mediaScreen += "border-color:black;" & vbCrLf
        mediaScreen += "border-top-width:0px;" & vbCrLf
        mediaScreen += "top:68px;" & vbCrLf
        mediaScreen += "left:42px;" & vbCrLf
        mediaScreen += "height:auto;" & vbCrLf


        mediaScreen += "}" & vbCrLf

        mediaScreen += "div.zebra:nth-child(even)" & vbCrLf
        mediaScreen += "{" & vbCrLf
        mediaScreen += "background-color:#D3D3D3;" & vbCrLf
        mediaScreen += "}" & vbCrLf

        mediaScreen += "span.subSalesRep" & vbCrLf
        mediaScreen += "{" & vbCrLf
        mediaScreen += "position:fixed;" & vbCrLf
        mediaScreen += "text-align:left;" & vbCrLf
        mediaScreen += "left:48px;" & vbCrLf
        mediaScreen += "width:120px;" & vbCrLf
        mediaScreen += "height:20px;" & vbCrLf


        mediaScreen += "}" & vbCrLf

        mediaScreen += "span.subIssuedCNT" & vbCrLf
        mediaScreen += "{" & vbCrLf

        mediaScreen += "position:fixed;" & vbCrLf
        mediaScreen += "text-align:center;" & vbCrLf
        mediaScreen += "left:168px;" & vbCrLf
        mediaScreen += "width:80px;" & vbCrLf
        mediaScreen += "height:20px;" & vbCrLf

        mediaScreen += "font-size:0.9em;" & vbCrLf

        mediaScreen += "}" & vbCrLf

        mediaScreen += "span.subDemoNoCNT" & vbCrLf
        mediaScreen += "{" & vbCrLf
        mediaScreen += "position:fixed;" & vbCrLf
        mediaScreen += "text-align:center;" & vbCrLf
        mediaScreen += "left:268px;" & vbCrLf
        mediaScreen += "width:35px;" & vbCrLf
        mediaScreen += "height:20px;" & vbCrLf

        mediaScreen += "font-size:0.9em;" & vbCrLf
        mediaScreen += "}" & vbCrLf

        mediaScreen += "span.subDemoNoPer" & vbCrLf
        mediaScreen += "{" & vbCrLf
        mediaScreen += "position:fixed;" & vbCrLf
        mediaScreen += "text-align:center;" & vbCrLf
        mediaScreen += "left:327px;" & vbCrLf
        mediaScreen += "width:41px;" & vbCrLf
        mediaScreen += "height:20px;" & vbCrLf

        mediaScreen += "font-size:0.9em;" & vbCrLf
        mediaScreen += "}" & vbCrLf

        mediaScreen += "span.subNotHitsCNT" & vbCrLf
        mediaScreen += "{" & vbCrLf
        mediaScreen += "position:fixed;" & vbCrLf
        mediaScreen += "text-align:center;" & vbCrLf
        mediaScreen += "left:378px;" & vbCrLf
        mediaScreen += "width:41px;" & vbCrLf
        mediaScreen += "height:20px;" & vbCrLf

        mediaScreen += "font-size:0.9em;" & vbCrLf
        mediaScreen += "}" & vbCrLf


        mediaScreen += "span.subNotHitsPer" & vbCrLf
        mediaScreen += "{" & vbCrLf
        mediaScreen += "position:fixed;" & vbCrLf
        mediaScreen += "text-align:center;" & vbCrLf
        mediaScreen += "left:414px;" & vbCrLf
        mediaScreen += "width:41px;" & vbCrLf
        mediaScreen += "height:20px;" & vbCrLf

        mediaScreen += "font-size:0.9em;" & vbCrLf
        mediaScreen += "}" & vbCrLf

        mediaScreen += "span.subResetsCNT" & vbCrLf
        mediaScreen += "{" & vbCrLf
        mediaScreen += "position:fixed;" & vbCrLf
        mediaScreen += "text-align:center;" & vbCrLf
        mediaScreen += "left:455px;" & vbCrLf
        mediaScreen += "width:41px;" & vbCrLf
        mediaScreen += "height:20px;" & vbCrLf

        mediaScreen += "font-size:0.9em;" & vbCrLf
        mediaScreen += "}" & vbCrLf

        mediaScreen += "span.subResetsPer" & vbCrLf
        mediaScreen += "{" & vbCrLf
        mediaScreen += "position:fixed;" & vbCrLf
        mediaScreen += "text-align:center;" & vbCrLf
        mediaScreen += "left:496px;" & vbCrLf
        mediaScreen += "width:41px;" & vbCrLf
        mediaScreen += "height:20px;" & vbCrLf

        mediaScreen += "font-size:0.9em;" & vbCrLf
        mediaScreen += "}" & vbCrLf

        mediaScreen += "span.subNoDemosCNT" & vbCrLf
        mediaScreen += "{" & vbCrLf
        mediaScreen += "position:fixed;" & vbCrLf
        mediaScreen += "text-align:center;" & vbCrLf
        mediaScreen += "left:537px;" & vbCrLf
        mediaScreen += "width:41px;" & vbCrLf
        mediaScreen += "height:20px;" & vbCrLf

        mediaScreen += "font-size:0.9em;" & vbCrLf

        mediaScreen += "}" & vbCrLf

        mediaScreen += "span.subNoDemosPer" & vbCrLf
        mediaScreen += "{" & vbCrLf
        mediaScreen += "position:fixed;" & vbCrLf
        mediaScreen += "text-align:center;" & vbCrLf
        mediaScreen += "left:578px;" & vbCrLf
        mediaScreen += "width:41px;" & vbCrLf
        mediaScreen += "height:20px;" & vbCrLf

        mediaScreen += "font-size:0.9em;" & vbCrLf
        mediaScreen += "}" & vbCrLf

        mediaScreen += "span.subSalesCNT" & vbCrLf
        mediaScreen += "{" & vbCrLf
        mediaScreen += "position:fixed;" & vbCrLf
        mediaScreen += "text-align:center;" & vbCrLf
        mediaScreen += "left:619px;" & vbCrLf
        mediaScreen += "width:41px;" & vbCrLf
        mediaScreen += "height:20px;" & vbCrLf

        mediaScreen += "font-size:0.9em;" & vbCrLf
        mediaScreen += "}" & vbCrLf

        mediaScreen += "span.subSalesPer" & vbCrLf
        mediaScreen += "{" & vbCrLf
        mediaScreen += "position:fixed;" & vbCrLf
        mediaScreen += "text-align:center;" & vbCrLf
        mediaScreen += "left:660px;" & vbCrLf
        mediaScreen += "width:41px;" & vbCrLf
        mediaScreen += "height:20px;" & vbCrLf

        mediaScreen += "font-size:0.9em;" & vbCrLf
        mediaScreen += "}" & vbCrLf

        mediaScreen += "span.subRecCanCNT" & vbCrLf
        mediaScreen += "{" & vbCrLf
        mediaScreen += "position:fixed;" & vbCrLf
        mediaScreen += "text-align:center;" & vbCrLf
        mediaScreen += "left:721px;" & vbCrLf
        mediaScreen += "width:41px;" & vbCrLf
        mediaScreen += "height:20px;" & vbCrLf

        mediaScreen += "font-size:0.9em;" & vbCrLf

        mediaScreen += "}" & vbCrLf

        mediaScreen += "span.subRecCanPer" & vbCrLf
        mediaScreen += "{" & vbCrLf
        mediaScreen += "position:fixed;" & vbCrLf
        mediaScreen += "text-align:center;" & vbCrLf
        mediaScreen += "left:782px;" & vbCrLf
        mediaScreen += "width:41px;" & vbCrLf
        mediaScreen += "height:20px;" & vbCrLf

        mediaScreen += "font-size:0.9em;" & vbCrLf

        mediaScreen += "}" & vbCrLf

        mediaScreen += "span.subSold" & vbCrLf
        mediaScreen += "{" & vbCrLf
        mediaScreen += "position:fixed;" & vbCrLf
        mediaScreen += "text-align:center;" & vbCrLf
        mediaScreen += "left:863px;" & vbCrLf
        mediaScreen += "width:161px;" & vbCrLf
        mediaScreen += "height:20px;" & vbCrLf

        mediaScreen += "font-size:0.9em;" & vbCrLf

        mediaScreen += "}" & vbCrLf

        mediaScreen += "div.totals" & vbCrLf
        mediaScreen += "{" & vbCrLf
        mediaScreen += "position:relative;" & vbCrLf
        mediaScreen += "height:46px;" & vbCrLf
        mediaScreen += "border-style:solid;" & vbCrLf
        mediaScreen += "border-width:1px;" & vbCrLf
        mediaScreen += "border-color:black;" & vbCrLf
        mediaScreen += "border-top-width:0px;" & vbCrLf
        mediaScreen += "border-right-width:0px;" & vbCrLf
        mediaScreen += "border-left-width:0px;" & vbCrLf
        mediaScreen += "border-bottom-width:0px;" & vbCrLf
        mediaScreen += "margin-top:0px;" & vbCrLf
        mediaScreen += "}" & vbCrLf

        mediaScreen += "span.lblTotal" & vbCrLf
        mediaScreen += "{" & vbCrLf
        mediaScreen += "position:fixed;" & vbCrLf
        mediaScreen += "text-align:center;" & vbCrLf
        mediaScreen += "left:68px;" & vbCrLf
        mediaScreen += "width:100px;" & vbCrLf
        mediaScreen += "height:20px;" & vbCrLf

        mediaScreen += "font-size:1.0em;" & vbCrLf
        mediaScreen += "font-weight:bold;" & vbCrLf
        mediaScreen += "margin-top:14px;" & vbCrLf
        mediaScreen += "}" & vbCrLf

        mediaScreen += "span.lblTotalIssueCnt" & vbCrLf
        mediaScreen += "{" & vbCrLf
        mediaScreen += "position:fixed;" & vbCrLf
        mediaScreen += "text-align:center;" & vbCrLf
        mediaScreen += "left:168px;" & vbCrLf
        mediaScreen += "width:78px;" & vbCrLf
        mediaScreen += "height:20px;" & vbCrLf

        mediaScreen += "font-size:1.0em;" & vbCrLf
        mediaScreen += "font-weight:bold;" & vbCrLf
        mediaScreen += "margin-top:14px;" & vbCrLf
        mediaScreen += "}" & vbCrLf


        mediaScreen += "span.lblTotalDemoNoSalesCnt" & vbCrLf
        mediaScreen += "{" & vbCrLf
        mediaScreen += "position:fixed;" & vbCrLf
        mediaScreen += "text-align:center;" & vbCrLf
        mediaScreen += "left:266px;" & vbCrLf
        mediaScreen += "width:41px;" & vbCrLf
        mediaScreen += "height:20px;" & vbCrLf

        mediaScreen += "font-size:1.0em;" & vbCrLf
        mediaScreen += "font-weight:bold;" & vbCrLf
        mediaScreen += "margin-top:14px;" & vbCrLf
        mediaScreen += "}" & vbCrLf


        mediaScreen += "span.lblTotalDemoNoSalesPer" & vbCrLf
        mediaScreen += "{" & vbCrLf
        mediaScreen += "position:fixed;" & vbCrLf
        mediaScreen += "text-align:center;" & vbCrLf
        mediaScreen += "left:331px;" & vbCrLf
        mediaScreen += "width:41px;" & vbCrLf
        mediaScreen += "height:20px;" & vbCrLf

        mediaScreen += "font-size:1.0em;" & vbCrLf
        mediaScreen += "font-weight:bold;" & vbCrLf
        mediaScreen += "margin-top:14px;" & vbCrLf
        mediaScreen += "}" & vbCrLf


        mediaScreen += "span.lblTotalNotHitsCnt" & vbCrLf
        mediaScreen += "{" & vbCrLf
        mediaScreen += "position:fixed;" & vbCrLf
        mediaScreen += "text-align:center;" & vbCrLf
        mediaScreen += "left:375px;" & vbCrLf
        mediaScreen += "width:41px;" & vbCrLf
        mediaScreen += "height:20px;" & vbCrLf

        mediaScreen += "font-size:1.0em;" & vbCrLf
        mediaScreen += "font-weight:bold;" & vbCrLf
        mediaScreen += "margin-top:14px;" & vbCrLf
        mediaScreen += "}" & vbCrLf

        mediaScreen += "span.lblTotalNotHitsPer" & vbCrLf
        mediaScreen += "{" & vbCrLf
        mediaScreen += "position:fixed;" & vbCrLf
        mediaScreen += "text-align:center;" & vbCrLf
        mediaScreen += "left:416px;" & vbCrLf
        mediaScreen += "width:41px;" & vbCrLf
        mediaScreen += "height:20px;" & vbCrLf

        mediaScreen += "font-size:1.0em;" & vbCrLf
        mediaScreen += "font-weight:bold;" & vbCrLf
        mediaScreen += "margin-top:14px;" & vbCrLf
        mediaScreen += "}" & vbCrLf

        mediaScreen += "span.lblTotalResetsCnt" & vbCrLf
        mediaScreen += "{" & vbCrLf
        mediaScreen += "position:fixed;" & vbCrLf
        mediaScreen += "text-align:center;" & vbCrLf
        mediaScreen += "left:456px;" & vbCrLf
        mediaScreen += "width:41px;" & vbCrLf
        mediaScreen += "height:20px;" & vbCrLf

        mediaScreen += "font-size:1.0em;" & vbCrLf
        mediaScreen += "font-weight:bold;" & vbCrLf
        mediaScreen += "margin-top:14px;" & vbCrLf
        mediaScreen += "}" & vbCrLf

        mediaScreen += "span.lblTotalResetsPer" & vbCrLf
        mediaScreen += "{" & vbCrLf
        mediaScreen += "position:fixed;" & vbCrLf
        mediaScreen += "text-align:center;" & vbCrLf
        mediaScreen += "left:497px;" & vbCrLf
        mediaScreen += "width:41px;" & vbCrLf
        mediaScreen += "height:20px;" & vbCrLf

        mediaScreen += "font-size:1.0em;" & vbCrLf
        mediaScreen += "font-weight:bold;" & vbCrLf
        mediaScreen += "margin-top:14px;" & vbCrLf
        mediaScreen += "}" & vbCrLf

        mediaScreen += "span.lblTotalNoDemosCnt" & vbCrLf
        mediaScreen += "{" & vbCrLf
        mediaScreen += "position:fixed;" & vbCrLf
        mediaScreen += "text-align:center;" & vbCrLf
        mediaScreen += "left:537px;" & vbCrLf
        mediaScreen += "width:41px;" & vbCrLf
        mediaScreen += "height:20px;" & vbCrLf

        mediaScreen += "font-size:1.0em;" & vbCrLf
        mediaScreen += "font-weight:bold;" & vbCrLf
        mediaScreen += "margin-top:14px;" & vbCrLf

        mediaScreen += "}" & vbCrLf


        mediaScreen += "span.lblTotalNoDemosPer" & vbCrLf
        mediaScreen += "{" & vbCrLf
        mediaScreen += "position:fixed;" & vbCrLf
        mediaScreen += "text-align:center;" & vbCrLf
        mediaScreen += "left:582px;" & vbCrLf
        mediaScreen += "width:41px;" & vbCrLf
        mediaScreen += "height:20px;" & vbCrLf

        mediaScreen += "font-size:1.0em;" & vbCrLf
        mediaScreen += "font-weight:bold;" & vbCrLf
        mediaScreen += "margin-top:14px;" & vbCrLf
        mediaScreen += "}" & vbCrLf

        mediaScreen += "span.lblTotalSalesCnt" & vbCrLf
        mediaScreen += "{" & vbCrLf
        mediaScreen += "position:fixed;" & vbCrLf
        mediaScreen += "text-align:center;" & vbCrLf
        mediaScreen += "left:622px;" & vbCrLf
        mediaScreen += "width:37px;" & vbCrLf
        mediaScreen += "height:20px;" & vbCrLf

        mediaScreen += "font-size:1.0em;" & vbCrLf
        mediaScreen += "font-weight:bold;" & vbCrLf
        mediaScreen += "margin-top:14px;" & vbCrLf
        mediaScreen += "}" & vbCrLf

        mediaScreen += "span.lblTotalSalesPer" & vbCrLf
        mediaScreen += "{" & vbCrLf
        mediaScreen += "position:fixed;" & vbCrLf
        mediaScreen += "text-align:center;" & vbCrLf
        mediaScreen += "left:663px;" & vbCrLf
        mediaScreen += "width:41px;" & vbCrLf
        mediaScreen += "height:20px;" & vbCrLf

        mediaScreen += "font-size:1.0em;" & vbCrLf
        mediaScreen += "font-weight:bold;" & vbCrLf
        mediaScreen += "margin-top:14px;" & vbCrLf
        mediaScreen += "}" & vbCrLf

        mediaScreen += "span.lblTotalRecCanCnt" & vbCrLf
        mediaScreen += "{" & vbCrLf
        mediaScreen += "position:fixed;" & vbCrLf
        mediaScreen += "text-align:center;" & vbCrLf
        mediaScreen += "left:719px;" & vbCrLf
        mediaScreen += "width:41px;" & vbCrLf
        mediaScreen += "height:20px;" & vbCrLf

        mediaScreen += "font-size:1.0em;" & vbCrLf
        mediaScreen += "font-weight:bold;" & vbCrLf
        mediaScreen += "margin-top:14px;" & vbCrLf
        mediaScreen += "}" & vbCrLf

        mediaScreen += "span.lblTotalRecCanPer" & vbCrLf
        mediaScreen += "{" & vbCrLf
        mediaScreen += "position:fixed;" & vbCrLf
        mediaScreen += "text-align:center;" & vbCrLf
        mediaScreen += "left:783px;" & vbCrLf
        mediaScreen += "width:41px;" & vbCrLf
        mediaScreen += "height:20px;" & vbCrLf

        mediaScreen += "font-size:1.0em;" & vbCrLf
        mediaScreen += "font-weight:bold;" & vbCrLf
        mediaScreen += "margin-top:14px;" & vbCrLf
        mediaScreen += "}" & vbCrLf

        mediaScreen += "span.lblTotalSoldMoney" & vbCrLf
        mediaScreen += "{" & vbCrLf
        mediaScreen += "position:fixed;" & vbCrLf
        mediaScreen += "text-align:center;" & vbCrLf
        mediaScreen += "left:872px;" & vbCrLf
        mediaScreen += "width:141px;" & vbCrLf
        mediaScreen += "height:20px;" & vbCrLf

        mediaScreen += "font-size:1.0em;" & vbCrLf
        mediaScreen += "font-weight:bold;" & vbCrLf
        mediaScreen += "margin-top:14px;" & vbCrLf
        mediaScreen += "}" & vbCrLf
        mediaScreen += "}" & vbCrLf

        mediaScreen += "</style>" & vbCrLf




        '' printScreen Render styles [Landscape / Portrait]
        '' 

        Dim printScreen As String = "<style type='text/css' media='print'>"


        printScreen += "@media print and (orientation:landscape)" & vbCrLf
        printScreen += "{" & vbCrLf

        printScreen += "span.lblTitleHeader " & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:relative;" & vbCrLf
        printScreen += "font-family:""Verdana"",sans-serif;" & vbCrLf
        printScreen += "font-size:1.2em;" & vbCrLf
        printScreen += "left:355px;" & vbCrLf
        printScreen += "top:5px;" & vbCrLf
        printScreen += "padding-top:3px;" & vbCrLf
        printScreen += "padding-bottom:3px;" & vbCrLf
        printScreen += "height:25px;" & vbCrLf
        printScreen += "width:auto;" & vbCrLf
        printScreen += "color:black;" & vbCrLf
        printScreen += "text-decoration:none;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf

        printScreen += "}" & vbCrLf

        printScreen += "span.lblAccuracyHeader" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "font-family:""Verdana"",sans-serif;" & vbCrLf
        printScreen += "font-size:0.6em;" & vbCrLf
        printScreen += "font-style:italic;" & vbCrLf
        printScreen += "left:12px;" & vbCrLf
        printScreen += "top:18px;" & vbCrLf
        printScreen += "padding-top:3px;" & vbCrLf
        printScreen += "padding-bottom:3px;" & vbCrLf
        printScreen += "height:25px;" & vbCrLf
        printScreen += "width:auto;" & vbCrLf
        printScreen += "color:black;" & vbCrLf
        printScreen += "text-align:left;" & vbCrLf
        printScreen += "}" & vbCrLf

        printScreen += "span.lblDateRangeHeader" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "font-family:""Verdana"",sans-serif;" & vbCrLf
        printScreen += "font-size:0.6em;" & vbCrLf
        printScreen += "font-style:italic;" & vbCrLf
        printScreen += "right:28px;" & vbCrLf
        printScreen += "top:20px;" & vbCrLf
        printScreen += "padding-top:3px;" & vbCrLf
        printScreen += "padding-bottom:3px;" & vbCrLf
        printScreen += "height:25px;" & vbCrLf
        printScreen += "width:auto;" & vbCrLf
        printScreen += "color:black;" & vbCrLf
        printScreen += "text-align:right;" & vbCrLf
        printScreen += "}" & vbCrLf

        printScreen += ".lblSalesRep" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "width:140px;" & vbCrLf
        printScreen += "margin-left:5px;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "font-family:""Verdana"",sans-serif;" & vbCrLf
        printScreen += "font-size:0.9em;" & vbCrLf
        printScreen += "font-weight:bold;" & vbCrLf
        printScreen += "height:auto;" & vbCrLf
        printScreen += "margin-top:5px;" & vbCrLf
        printScreen += "padding-bottom:2px;" & vbCrLf

        printScreen += "}" & vbCrLf

        printScreen += ".lblNumIssued" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "width:100px;" & vbCrLf
        printScreen += "margin-left:5px;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "font-family:""Verdana"",sans-serif;" & vbCrLf
        printScreen += "font-size:0.9em;" & vbCrLf
        printScreen += "font-weight:bold;" & vbCrLf
        printScreen += "height:auto;" & vbCrLf
        printScreen += "margin-top:5px;" & vbCrLf
        printScreen += "padding-bottom:2px;" & vbCrLf
        printScreen += "left:155px;" & vbCrLf

        printScreen += "}" & vbCrLf

        printScreen += ".lblDemoNoSales" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "width:160px;" & vbCrLf
        printScreen += "margin-left:5px;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "font-family:""Verdana"",sans-serif;" & vbCrLf
        printScreen += "font-size:0.9em;" & vbCrLf
        printScreen += "font-weight:bold;" & vbCrLf
        printScreen += "height:auto;" & vbCrLf
        printScreen += "margin-top:5px;" & vbCrLf
        printScreen += "padding-bottom:2px;" & vbCrLf
        printScreen += "left:235px;" & vbCrLf

        printScreen += "}" & vbCrLf

        printScreen += ".lblNotHits" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "width:90px;" & vbCrLf
        printScreen += "margin-left:5px;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "font-family:""Verdana"",sans-serif;" & vbCrLf
        printScreen += "font-size:0.9em;" & vbCrLf
        printScreen += "font-weight:bold;" & vbCrLf
        printScreen += "height:auto;" & vbCrLf
        printScreen += "margin-top:5px;" & vbCrLf
        printScreen += "padding-bottom:2px;" & vbCrLf
        printScreen += "left:395px;" & vbCrLf

        printScreen += "}" & vbCrLf


        printScreen += ".lblResets" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "width:100px;" & vbCrLf
        printScreen += "margin-left:5px;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "font-family:""Verdana"",sans-serif;" & vbCrLf
        printScreen += "font-size:0.9em;" & vbCrLf
        printScreen += "font-weight:bold;" & vbCrLf
        printScreen += "height:auto;" & vbCrLf
        printScreen += "margin-top:5px;" & vbCrLf
        printScreen += "padding-bottom:2px;" & vbCrLf

        printScreen += "left:475px;" & vbCrLf

        printScreen += "}" & vbCrLf

        printScreen += ".subResetsCNT" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "width:100px;" & vbCrLf
        printScreen += "margin-left:5px;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "font-family:""Verdana"",sans-serif;" & vbCrLf
        printScreen += "font-size:0.9em;" & vbCrLf
        printScreen += "height:auto;" & vbCrLf
        printScreen += "margin-top:25px;" & vbCrLf
        printScreen += "padding-bottom:2px;" & vbCrLf

        printScreen += "left:455px;" & vbCrLf
        printScreen += "}" & vbCrLf


        printScreen += ".subResetsPer"
        printScreen += "{"
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "width:100px;" & vbCrLf
        printScreen += "margin-left:5px;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "font-family:""Verdana"",sans-serif;" & vbCrLf
        printScreen += "font-size:0.9em;" & vbCrLf
        printScreen += "height:auto;" & vbCrLf
        printScreen += "margin-top:25px;" & vbCrLf
        printScreen += "padding-bottom:2px;" & vbCrLf

        printScreen += "left:495px;" & vbCrLf
        printScreen += "}" & vbCrLf

        printScreen += "span.lblTotalResetsPer" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "left:530px;" & vbCrLf
        printScreen += "width:41px;" & vbCrLf
        printScreen += "height:20px;" & vbCrLf

        printScreen += "font-size:1.0em;" & vbCrLf
        printScreen += "font-weight:bold;" & vbCrLf
        printScreen += "margin-top:14px;" & vbCrLf
        printScreen += "}" & vbCrLf


        printScreen += "span.lblTotalResetsCnt" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "left:490px;" & vbCrLf
        printScreen += "width:41px;" & vbCrLf
        printScreen += "height:20px;" & vbCrLf

        printScreen += "font-size:1.0em;" & vbCrLf
        printScreen += "font-weight:bold;" & vbCrLf
        printScreen += "margin-top:14px;" & vbCrLf
        printScreen += "}" & vbCrLf

        printScreen += ".lblNoDemos" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "width:90px;" & vbCrLf
        printScreen += "margin-left:5px;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "font-family:""Verdana"",sans-serif;" & vbCrLf
        printScreen += "font-size:0.9em;" & vbCrLf
        printScreen += "font-weight:bold;" & vbCrLf
        printScreen += "height:auto;" & vbCrLf
        printScreen += "margin-top:5px;" & vbCrLf
        printScreen += "padding-bottom:2px;" & vbCrLf

        printScreen += "left:575px;" & vbCrLf

        printScreen += "}" & vbCrLf

        printScreen += ".subNoDemosCNT" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "width:90px;" & vbCrLf
        printScreen += "margin-left:5px;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "font-family:""Verdana"",sans-serif;" & vbCrLf
        printScreen += "font-size:0.9em;" & vbCrLf
        printScreen += "height:auto;" & vbCrLf
        printScreen += "margin-top:25px;" & vbCrLf
        printScreen += "padding-bottom:2px;" & vbCrLf
        printScreen += "left:555px;" & vbCrLf

        printScreen += "}" & vbCrLf

        printScreen += ".subNoDemosPer" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "width:90px;" & vbCrLf
        printScreen += "margin-left:5px;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "font-family:""Verdana"",sans-serif;" & vbCrLf
        printScreen += "font-size:0.9em;" & vbCrLf
        printScreen += "height:auto;" & vbCrLf
        printScreen += "margin-top:25px;" & vbCrLf
        printScreen += "padding-bottom:2px;" & vbCrLf
        printScreen += "left:595px;" & vbCrLf
        printScreen += "}" & vbCrLf

        printScreen += "span.lblTotalNoDemosCnt" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "left:585px;" & vbCrLf
        printScreen += "width:41px;" & vbCrLf
        printScreen += "height:20px;" & vbCrLf

        printScreen += "font-size:1.0em;" & vbCrLf
        printScreen += "font-weight:bold;" & vbCrLf
        printScreen += "margin-top:14px;" & vbCrLf

        printScreen += "}" & vbCrLf

        printScreen += "span.lblTotalNoDemosPer" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "left:625px;" & vbCrLf
        printScreen += "width:41px;" & vbCrLf
        printScreen += "height:20px;" & vbCrLf

        printScreen += "font-size:1.0em;" & vbCrLf
        printScreen += "font-weight:bold;" & vbCrLf
        printScreen += "margin-top:14px;" & vbCrLf
        printScreen += "}" & vbCrLf

        printScreen += ".lblSales" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "width:70px;" & vbCrLf
        printScreen += "margin-left:5px;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "font-family:""Verdana"",sans-serif;" & vbCrLf
        printScreen += "font-size:0.9em;" & vbCrLf
        printScreen += "font-weight:bold;" & vbCrLf
        printScreen += "height:auto;" & vbCrLf
        printScreen += "margin-top:5px;" & vbCrLf
        printScreen += "padding-bottom:2px;" & vbCrLf

        printScreen += "left:665px;" & vbCrLf

        printScreen += "}" & vbCrLf
        printScreen += ".subSalesCNT" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "width:90px;" & vbCrLf
        printScreen += "margin-left:5px;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "font-family:""Verdana"",sans-serif;" & vbCrLf
        printScreen += "font-size:0.9em;" & vbCrLf
        printScreen += "height:auto;" & vbCrLf
        printScreen += "margin-top:25px;" & vbCrLf
        printScreen += "padding-bottom:2px;" & vbCrLf
        printScreen += "left:635px;" & vbCrLf

        printScreen += "}" & vbCrLf

        printScreen += ".subSalesPer" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "width:90px;" & vbCrLf
        printScreen += "margin-left:5px;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "font-family:""Verdana"",sans-serif;" & vbCrLf
        printScreen += "font-size:0.9em;" & vbCrLf
        printScreen += "height:auto;" & vbCrLf
        printScreen += "margin-top:25px;" & vbCrLf
        printScreen += "padding-bottom:2px;" & vbCrLf
        printScreen += "left:675px;" & vbCrLf
        printScreen += "}" & vbCrLf

        printScreen += "span.lblTotalSalesCnt" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "left:665px;" & vbCrLf
        printScreen += "width:37px;" & vbCrLf
        printScreen += "height:20px;" & vbCrLf

        printScreen += "font-size:1.0em;" & vbCrLf
        printScreen += "font-weight:bold;" & vbCrLf
        printScreen += "margin-top:14px;" & vbCrLf
        printScreen += "}" & vbCrLf

        printScreen += "span.lblTotalSalesPer" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "left:705px;" & vbCrLf
        printScreen += "width:41px;" & vbCrLf
        printScreen += "height:20px;" & vbCrLf

        printScreen += "font-size:1.0em;" & vbCrLf
        printScreen += "font-weight:bold;" & vbCrLf
        printScreen += "margin-top:14px;" & vbCrLf
        printScreen += "}" & vbCrLf

        printScreen += ".lblRecissionCancels" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "width:170px;" & vbCrLf
        printScreen += "margin-left:5px;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "font-family:""Verdana"",sans-serif;" & vbCrLf
        printScreen += "font-size:0.9em;" & vbCrLf
        printScreen += "font-weight:bold;" & vbCrLf
        printScreen += "height:auto;" & vbCrLf
        printScreen += "margin-top:5px;" & vbCrLf
        printScreen += "padding-bottom:2px;" & vbCrLf

        printScreen += "left:735px;" & vbCrLf

        printScreen += "}" & vbCrLf
        printScreen += ".subRecCanCNT" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "width:90px;" & vbCrLf
        printScreen += "margin-left:5px;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "font-family:""Verdana"",sans-serif;" & vbCrLf
        printScreen += "font-size:0.9em;" & vbCrLf
        printScreen += "height:auto;" & vbCrLf
        printScreen += "margin-top:25px;" & vbCrLf
        printScreen += "padding-bottom:2px;" & vbCrLf
        printScreen += "left:750px;" & vbCrLf
        printScreen += "}" & vbCrLf

        printScreen += ".subRecCanPer" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "width:90px;" & vbCrLf
        printScreen += "margin-left:5px;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "font-family:""Verdana"",sans-serif;" & vbCrLf
        printScreen += "font-size:0.9em;" & vbCrLf
        printScreen += "height:auto;" & vbCrLf
        printScreen += "margin-top:25px;" & vbCrLf
        printScreen += "padding-bottom:2px;" & vbCrLf
        printScreen += "left:820px;" & vbCrLf
        printScreen += "}" & vbCrLf

        printScreen += "span.lblTotalRecCanCnt" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "left:780px;" & vbCrLf
        printScreen += "width:41px;" & vbCrLf
        printScreen += "height:20px;" & vbCrLf

        printScreen += "font-size:1.0em;" & vbCrLf
        printScreen += "font-weight:bold;" & vbCrLf
        printScreen += "margin-top:14px;" & vbCrLf
        printScreen += "}" & vbCrLf

        printScreen += "span.lblTotalRecCanPer" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "left:850px;" & vbCrLf
        printScreen += "width:41px;" & vbCrLf
        printScreen += "height:20px;" & vbCrLf

        printScreen += "font-size:1.0em;" & vbCrLf
        printScreen += "font-weight:bold;" & vbCrLf
        printScreen += "margin-top:14px;" & vbCrLf
        printScreen += "}" & vbCrLf


        printScreen += ".lblTotalSold" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "width:170px;" & vbCrLf
        printScreen += "margin-left:5px;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "font-family:""Verdana"",sans-serif;" & vbCrLf
        printScreen += "font-size:0.9em;" & vbCrLf
        printScreen += "font-weight:bold;" & vbCrLf
        printScreen += "height:auto;" & vbCrLf
        printScreen += "margin-top:5px;" & vbCrLf
        printScreen += "padding-bottom:2px;" & vbCrLf

        printScreen += "left:875px;" & vbCrLf

        printScreen += "}	" & vbCrLf

        printScreen += ".subSalesRep" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "width:140px;" & vbCrLf
        printScreen += "margin-left:5px;" & vbCrLf
        printScreen += "text-align:left;" & vbCrLf
        printScreen += "font-family:""Verdana"",sans-serif;" & vbCrLf
        printScreen += "font-size:0.9em;" & vbCrLf
        printScreen += "height:auto;" & vbCrLf
        printScreen += "margin-top:25px;" & vbCrLf
        printScreen += "padding-bottom:2px;" & vbCrLf
        printScreen += "left:0px;" & vbCrLf
        printScreen += "}" & vbCrLf

        printScreen += ".subIssuedCNT" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "width:140px;" & vbCrLf
        printScreen += "margin-left:5px;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "font-family:""Verdana"",sans-serif;" & vbCrLf
        printScreen += "font-size:0.9em;" & vbCrLf
        printScreen += "height:auto;" & vbCrLf
        printScreen += "margin-top:25px;" & vbCrLf
        printScreen += "padding-bottom:2px;" & vbCrLf
        printScreen += "left:130px;" & vbCrLf
        printScreen += "}" & vbCrLf

        printScreen += ".subDemoNoCNT" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "width:70px;" & vbCrLf
        printScreen += "margin-left:5px;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "font-family:""Verdana"",sans-serif;" & vbCrLf
        printScreen += "font-size:0.9em;" & vbCrLf
        printScreen += "height:auto;" & vbCrLf
        printScreen += "margin-top:25px;" & vbCrLf
        printScreen += "padding-bottom:2px;" & vbCrLf
        printScreen += "left:240px;" & vbCrLf
        printScreen += "}" & vbCrLf

        printScreen += ".subDemoNoPer" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "width:70px;" & vbCrLf
        printScreen += "margin-left:5px;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "font-family:""Verdana"",sans-serif;" & vbCrLf
        printScreen += "font-size:0.9em;" & vbCrLf
        printScreen += "height:auto;" & vbCrLf
        printScreen += "margin-top:25px;" & vbCrLf
        printScreen += "padding-bottom:2px;" & vbCrLf
        printScreen += "left:310px;" & vbCrLf

        printScreen += "}" & vbCrLf





        printScreen += ".subNotHitsCNT" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "width:70px;" & vbCrLf
        printScreen += "margin-left:5px;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "font-family:""Verdana"",sans-serif;" & vbCrLf
        printScreen += "font-size:0.9em;" & vbCrLf
        printScreen += "height:auto;" & vbCrLf
        printScreen += "margin-top:25px;" & vbCrLf
        printScreen += "padding-bottom:2px;" & vbCrLf
        printScreen += "left:380px;" & vbCrLf
        printScreen += "}" & vbCrLf

        printScreen += ".subNotHitsPer" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "width:70px;" & vbCrLf
        printScreen += "margin-left:5px;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "font-family:""Verdana"",sans-serif;" & vbCrLf
        printScreen += "font-size:0.9em;" & vbCrLf
        printScreen += "height:auto;" & vbCrLf
        printScreen += "margin-top:25px;" & vbCrLf
        printScreen += "padding-bottom:2px;" & vbCrLf
        printScreen += "left:420px;" & vbCrLf
        printScreen += "}" & vbCrLf

        printScreen += ".subSold" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "width:170px;" & vbCrLf
        printScreen += "margin-left:5px;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "font-family:""Verdana"",sans-serif;" & vbCrLf
        printScreen += "font-size:0.9em;" & vbCrLf

        printScreen += "height:auto;" & vbCrLf
        printScreen += "margin-top:25px;" & vbCrLf
        printScreen += "padding-bottom:2px;" & vbCrLf

        printScreen += "left:875px;" & vbCrLf
        printScreen += "}" & vbCrLf

        printScreen += "span.lblTotalSoldMoney" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "left:895px;" & vbCrLf
        printScreen += "width:141px;" & vbCrLf
        printScreen += "height:auto;" & vbCrLf

        printScreen += "font-size:1.0em;" & vbCrLf
        printScreen += "font-weight:bold;" & vbCrLf
        printScreen += "margin-top:15px;" & vbCrLf
        printScreen += "}" & vbCrLf

        printScreen += "div.totals"
        printScreen += "{" & vbCrLf
        printScreen += "position:relative;" & vbCrLf
        printScreen += "height:46px;" & vbCrLf
        printScreen += "border-style:solid;" & vbCrLf
        printScreen += "border-width:1px;" & vbCrLf
        printScreen += "border-color:black;" & vbCrLf
        printScreen += "border-top-width:0px;" & vbCrLf
        printScreen += "border-right-width:0px;" & vbCrLf
        printScreen += "border-left-width:0px;" & vbCrLf
        printScreen += "border-bottom-width:0px;" & vbCrLf
        printScreen += "margin-top:15px;" & vbCrLf
        printScreen += "}" & vbCrLf

        printScreen += "span.lblTotal" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "left:28px;" & vbCrLf
        printScreen += "width:100px;" & vbCrLf
        printScreen += "height:20px;" & vbCrLf

        printScreen += "font-size:1.0em;" & vbCrLf
        printScreen += "font-weight:bold;" & vbCrLf
        printScreen += "margin-top:14px;" & vbCrLf
        printScreen += "}" & vbCrLf

        printScreen += "span.lblTotalIssueCnt" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "left:168px;" & vbCrLf
        printScreen += "width:78px;" & vbCrLf
        printScreen += "height:20px;" & vbCrLf

        printScreen += "font-size:1.0em;" & vbCrLf
        printScreen += "font-weight:bold;" & vbCrLf
        printScreen += "margin-top:14px;" & vbCrLf
        printScreen += "}" & vbCrLf

        printScreen += "span.lblTotalDemoNoSalesCnt" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "left:259px;" & vbCrLf
        printScreen += "width:41px;" & vbCrLf
        printScreen += "height:20px;" & vbCrLf

        printScreen += "font-size:1.0em;" & vbCrLf
        printScreen += "font-weight:bold;" & vbCrLf
        printScreen += "margin-top:14px;" & vbCrLf
        printScreen += "}" & vbCrLf

        printScreen += "span.lblTotalDemoNoSalesPer" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "left:331px;" & vbCrLf
        printScreen += "width:41px;" & vbCrLf
        printScreen += "height:20px;" & vbCrLf

        printScreen += "font-size:1.0em;" & vbCrLf
        printScreen += "font-weight:bold;" & vbCrLf
        printScreen += "margin-top:14px;" & vbCrLf
        printScreen += "}" & vbCrLf

        printScreen += "span.lblTotalNotHitsCnt" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "left:400px;" & vbCrLf
        printScreen += "width:41px;" & vbCrLf
        printScreen += "height:20px;" & vbCrLf

        printScreen += "font-size:1.0em;" & vbCrLf
        printScreen += "font-weight:bold;" & vbCrLf
        printScreen += "margin-top:14px;" & vbCrLf
        printScreen += "}" & vbCrLf

        printScreen += "span.lblTotalNotHitsPer" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "left:440px;" & vbCrLf
        printScreen += "width:41px;" & vbCrLf
        printScreen += "height:20px;" & vbCrLf

        printScreen += "font-size:1.0em;" & vbCrLf
        printScreen += "font-weight:bold;" & vbCrLf
        printScreen += "margin-top:14px;" & vbCrLf
        printScreen += "}" & vbCrLf
        printScreen += "}	" & vbCrLf


        printScreen += "@media print and (orientation:portrait)" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "span.lblTitleHeader" & vbCrLf
        printScreen += "    {" & vbCrLf
        printScreen += "position:relative;" & vbCrLf
        printScreen += "font-family:""Verdana"",sans-serif;" & vbCrLf
        printScreen += "font-size:1.2em;" & vbCrLf
        printScreen += "left:255px;" & vbCrLf
        printScreen += "top:5px;" & vbCrLf
        printScreen += "padding-top:3px;" & vbCrLf
        printScreen += "padding-bottom:3px;" & vbCrLf
        printScreen += "height:25px;" & vbCrLf
        printScreen += "width:auto;" & vbCrLf
        printScreen += "color:black;" & vbCrLf
        printScreen += "text-decoration:none;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "    }" & vbCrLf

        printScreen += "span.lblAccuracyHeader" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "font-family:""Verdana"",sans-serif;" & vbCrLf
        printScreen += "font-size:0.6em;" & vbCrLf
        printScreen += "font-style:italic;" & vbCrLf
        printScreen += "left:12px;" & vbCrLf
        printScreen += "top:18px;" & vbCrLf
        printScreen += "padding-top:3px;" & vbCrLf
        printScreen += "padding-bottom:3px;" & vbCrLf
        printScreen += "height:25px;" & vbCrLf
        printScreen += "width:auto;" & vbCrLf
        printScreen += "color:black;" & vbCrLf
        printScreen += "text-align:left;" & vbCrLf
        printScreen += "}" & vbCrLf

        printScreen += "span.lblDateRangeHeader" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "font-family:""Verdana"",sans-serif;" & vbCrLf
        printScreen += "font-size:0.6em;" & vbCrLf
        printScreen += "font-style:italic;" & vbCrLf
        printScreen += "right:28px;" & vbCrLf
        printScreen += "top:20px;" & vbCrLf
        printScreen += "padding-top:3px;" & vbCrLf
        printScreen += "padding-bottom:3px;" & vbCrLf
        printScreen += "height:25px;" & vbCrLf
        printScreen += "width:auto;" & vbCrLf
        printScreen += "color:black;" & vbCrLf
        printScreen += "text-align:right;" & vbCrLf
        printScreen += "}" & vbCrLf

        printScreen += ".lblSalesRep" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "width:140px;" & vbCrLf
        printScreen += "margin-left:5px;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "font-family:""Verdana"",sans-serif;" & vbCrLf
        printScreen += "font-size:0.9em;" & vbCrLf
        printScreen += "font-weight:bold;" & vbCrLf
        printScreen += "height:auto;" & vbCrLf
        printScreen += "margin-top:5px;" & vbCrLf
        printScreen += "padding-bottom:2px;" & vbCrLf
        printScreen += "}" & vbCrLf


        printScreen += ".lblNumIssued" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "width:100px;" & vbCrLf
        printScreen += "margin-left:5px;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "font-family:""Verdana"",sans-serif;" & vbCrLf
        printScreen += "font-size:0.9em;" & vbCrLf
        printScreen += "font-weight:bold;" & vbCrLf
        printScreen += "height:auto;" & vbCrLf
        printScreen += "margin-top:5px;" & vbCrLf
        printScreen += "padding-bottom:2px;" & vbCrLf
        printScreen += "left:155px;" & vbCrLf
        printScreen += "}" & vbCrLf

        printScreen += ".lblDemoNoSales" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "width:160px;" & vbCrLf
        printScreen += "margin-left:5px;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "font-family:""Verdana"",sans-serif;" & vbCrLf
        printScreen += "font-size:0.9em;" & vbCrLf
        printScreen += "font-weight:bold;" & vbCrLf
        printScreen += "height:auto;" & vbCrLf
        printScreen += "margin-top:5px;" & vbCrLf
        printScreen += "padding-bottom:2px;" & vbCrLf
        printScreen += "left:235px;" & vbCrLf
        printScreen += "}" & vbCrLf

        printScreen += ".lblNotHits" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "width:90px;" & vbCrLf
        printScreen += "margin-left:5px;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "font-family:""Verdana"",sans-serif;" & vbCrLf
        printScreen += "font-size:0.9em;" & vbCrLf
        printScreen += "font-weight:bold;" & vbCrLf
        printScreen += "height:auto;" & vbCrLf
        printScreen += "margin-top:5px;" & vbCrLf
        printScreen += "padding-bottom:2px;" & vbCrLf
        printScreen += "left:395px;" & vbCrLf
        printScreen += "}" & vbCrLf

        printScreen += "/* Cut Off */ " & vbCrLf

        printScreen += ".lblResets" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "width:100px;" & vbCrLf
        printScreen += "margin-left:5px;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "font-family:""Verdana"",sans-serif;" & vbCrLf
        printScreen += "font-size:0.9em;" & vbCrLf
        printScreen += "font-weight:bold;" & vbCrLf
        printScreen += "height:auto;" & vbCrLf
        printScreen += "margin-top:5px;" & vbCrLf
        printScreen += "padding-bottom:2px;" & vbCrLf
        printScreen += "top:355px;" & vbCrLf
        printScreen += "left:155px;" & vbCrLf
        printScreen += "}" & vbCrLf


        printScreen += ".subResetsCNT" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "width:100px;" & vbCrLf
        printScreen += "margin-left:5px;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "font-family:""Verdana"",sans-serif;" & vbCrLf
        printScreen += "font-size:0.9em;" & vbCrLf
        printScreen += "height:auto;" & vbCrLf
        printScreen += "margin-top:355px;" & vbCrLf
        printScreen += "padding-bottom:2px;" & vbCrLf
        printScreen += "left:135px;" & vbCrLf
        printScreen += "}" & vbCrLf

        printScreen += ".subResetsPer" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "width:100px;" & vbCrLf
        printScreen += "margin-left:5px;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "font-family:""Verdana"",sans-serif;" & vbCrLf
        printScreen += "font-size:0.9em;" & vbCrLf
        printScreen += "height:auto;" & vbCrLf
        printScreen += "margin-top:355px;" & vbCrLf
        printScreen += "padding-bottom:2px;" & vbCrLf
        printScreen += "left:185px;" & vbCrLf
        printScreen += "}" & vbCrLf

        printScreen += "span.lblTotalResetsPer" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "left:218px;" & vbCrLf
        printScreen += "width:41px;" & vbCrLf
        printScreen += "height:20px;" & vbCrLf

        printScreen += "font-size:1.0em;" & vbCrLf
        printScreen += "font-weight:bold;" & vbCrLf
        printScreen += "margin-top:355px;" & vbCrLf
        printScreen += "}" & vbCrLf

        printScreen += "span.lblTotalResetsCnt" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "left:170px;" & vbCrLf
        printScreen += "width:41px;" & vbCrLf
        printScreen += "height:20px;" & vbCrLf

        printScreen += "font-size:1.0em;" & vbCrLf
        printScreen += "font-weight:bold;" & vbCrLf
        printScreen += "margin-top:355px;" & vbCrLf
        printScreen += "}" & vbCrLf

        printScreen += ".lblNoDemos" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "width:90px;" & vbCrLf
        printScreen += "margin-left:5px;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "font-family:""Verdana"",sans-serif;" & vbCrLf
        printScreen += "font-size:0.9em;" & vbCrLf
        printScreen += "font-weight:bold;" & vbCrLf
        printScreen += "height:auto;" & vbCrLf
        printScreen += "margin-top:5px;" & vbCrLf
        printScreen += "padding-bottom:2px;" & vbCrLf
        printScreen += "top:355px;" & vbCrLf
        printScreen += "left:255px;" & vbCrLf
        printScreen += "}" & vbCrLf

        printScreen += ".subNoDemosCNT" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "width:90px;" & vbCrLf
        printScreen += "margin-left:5px;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "font-family:""Verdana"",sans-serif;" & vbCrLf
        printScreen += "font-size:0.9em;" & vbCrLf
        printScreen += "height:auto;" & vbCrLf
        printScreen += "margin-top:355px;" & vbCrLf
        printScreen += "padding-bottom:2px;" & vbCrLf
        printScreen += "left:235px;" & vbCrLf
        printScreen += "}" & vbCrLf

        printScreen += ".subNoDemosPer" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "width:90px;" & vbCrLf
        printScreen += "margin-left:5px;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "font-family:""Verdana"",sans-serif;" & vbCrLf
        printScreen += "font-size:0.9em;" & vbCrLf
        printScreen += "height:auto;" & vbCrLf
        printScreen += "margin-top:355px;" & vbCrLf
        printScreen += "padding-bottom:2px;" & vbCrLf
        printScreen += "left:275px;" & vbCrLf
        printScreen += "}" & vbCrLf

        printScreen += ".lblSales" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "width:70px;" & vbCrLf
        printScreen += "margin-left:5px;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "font-family:""Verdana"",sans-serif;" & vbCrLf
        printScreen += "font-size:0.9em;" & vbCrLf
        printScreen += "font-weight:bold;" & vbCrLf
        printScreen += "height:auto;" & vbCrLf
        printScreen += "margin-top:5px;" & vbCrLf
        printScreen += "padding-bottom:2px;" & vbCrLf
        printScreen += "top:355px;" & vbCrLf
        printScreen += "left:365px;" & vbCrLf

        printScreen += "}" & vbCrLf

        printScreen += ".subSalesCNT" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "width:90px;" & vbCrLf
        printScreen += "margin-left:5px;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "font-family:""Verdana"",sans-serif;" & vbCrLf
        printScreen += "font-size:0.9em;" & vbCrLf
        printScreen += "height:auto;" & vbCrLf
        printScreen += "margin-top:355px;" & vbCrLf
        printScreen += "padding-bottom:2px;" & vbCrLf
        printScreen += "left:335px;" & vbCrLf

        printScreen += "}" & vbCrLf

        printScreen += ".subSalesPer" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "width:90px;" & vbCrLf
        printScreen += "margin-left:5px;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "font-family:""Verdana"",sans-serif;" & vbCrLf
        printScreen += "font-size:0.9em;" & vbCrLf
        printScreen += "height:auto;" & vbCrLf
        printScreen += "margin-top:355px;" & vbCrLf
        printScreen += "padding-bottom:2px;" & vbCrLf
        printScreen += "left:375px;" & vbCrLf
        printScreen += "}" & vbCrLf

        printScreen += "span.lblTotalSalesCnt" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "left:370px;" & vbCrLf
        printScreen += "width:37px;" & vbCrLf
        printScreen += "height:20px;" & vbCrLf

        printScreen += "font-size:1.0em;" & vbCrLf
        printScreen += "font-weight:bold;" & vbCrLf
        printScreen += "margin-top:355px;" & vbCrLf
        printScreen += "}" & vbCrLf

        printScreen += "span.lblTotalSalesPer" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "left:410px;" & vbCrLf
        printScreen += "width:41px;" & vbCrLf
        printScreen += "height:20px;" & vbCrLf

        printScreen += "font-size:1.0em;" & vbCrLf
        printScreen += "font-weight:bold;" & vbCrLf
        printScreen += "margin-top:355px;" & vbCrLf
        printScreen += "}" & vbCrLf

        printScreen += ".lblRecissionCancels" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "width:170px;" & vbCrLf
        printScreen += "margin-left:5px;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "font-family:""Verdana"",sans-serif;" & vbCrLf
        printScreen += "font-size:0.9em;" & vbCrLf
        printScreen += "font-weight:bold;" & vbCrLf
        printScreen += "height:auto;" & vbCrLf
        printScreen += "margin-top:5px;" & vbCrLf
        printScreen += "padding-bottom:2px;" & vbCrLf
        printScreen += "top:355px;" & vbCrLf
        printScreen += "left:455px;" & vbCrLf

        printScreen += "}" & vbCrLf

        printScreen += ".subRecCanCNT" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "width:90px;" & vbCrLf
        printScreen += "margin-left:5px;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "font-family:""Verdana"",sans-serif;" & vbCrLf
        printScreen += "font-size:0.9em;" & vbCrLf
        printScreen += "height:auto;" & vbCrLf
        printScreen += "margin-top:355px;" & vbCrLf
        printScreen += "padding-bottom:2px;" & vbCrLf
        printScreen += "left:470px;" & vbCrLf
        printScreen += "}" & vbCrLf

        printScreen += ".subRecCanPer" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "width:90px;" & vbCrLf
        printScreen += "margin-left:5px;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "font-family:""Verdana"",sans-serif;" & vbCrLf
        printScreen += "font-size:0.9em;" & vbCrLf
        printScreen += "height:auto;" & vbCrLf
        printScreen += "margin-top:355px;" & vbCrLf
        printScreen += "padding-bottom:2px;" & vbCrLf
        printScreen += "left:520px;" & vbCrLf
        printScreen += "}" & vbCrLf

        printScreen += "span.lblTotalRecCanCnt" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "left:500px;" & vbCrLf
        printScreen += "width:41px;" & vbCrLf
        printScreen += "height:20px;" & vbCrLf

        printScreen += "font-size:1.0em;" & vbCrLf
        printScreen += "font-weight:bold;" & vbCrLf
        printScreen += "margin-top:355px;" & vbCrLf
        printScreen += "}" & vbCrLf

        printScreen += "span.lblTotalRecCanPer" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "left:550px;" & vbCrLf
        printScreen += "width:41px;" & vbCrLf
        printScreen += "height:20px;" & vbCrLf

        printScreen += "font-size:1.0em;" & vbCrLf
        printScreen += "font-weight:bold;" & vbCrLf
        printScreen += "margin-top:355px;" & vbCrLf
        printScreen += "}" & vbCrLf


        printScreen += ".lblTotalSold" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "width:170px;" & vbCrLf
        printScreen += "margin-left:5px;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "font-family:""Verdana"",sans-serif;" & vbCrLf
        printScreen += "font-size:0.9em;" & vbCrLf
        printScreen += "font-weight:bold;" & vbCrLf
        printScreen += "height:auto;" & vbCrLf
        printScreen += "margin-top:5px;" & vbCrLf
        printScreen += "padding-bottom:2px;" & vbCrLf

        printScreen += "left:505px;" & vbCrLf

        printScreen += "}" & vbCrLf

        printScreen += ".subSalesRep" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "width:140px;" & vbCrLf
        printScreen += "margin-left:5px;" & vbCrLf
        printScreen += "text-align:left;" & vbCrLf
        printScreen += "font-family:""Verdana"",sans-serif;" & vbCrLf
        printScreen += "font-size:0.9em;" & vbCrLf
        printScreen += "height:auto;" & vbCrLf
        printScreen += "margin-top:25px;" & vbCrLf
        printScreen += "padding-bottom:2px;" & vbCrLf
        printScreen += "left:0px;" & vbCrLf
        printScreen += "}" & vbCrLf

        printScreen += ".subIssuedCNT" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "width:140px;" & vbCrLf
        printScreen += "margin-left:5px;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "font-family:""Verdana"",sans-serif;" & vbCrLf
        printScreen += "font-size:0.9em;" & vbCrLf
        printScreen += "height:auto;" & vbCrLf
        printScreen += "margin-top:25px;" & vbCrLf
        printScreen += "padding-bottom:2px;" & vbCrLf
        printScreen += "left:130px;" & vbCrLf
        printScreen += "}" & vbCrLf

        printScreen += ".subDemoNoCNT" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "width:70px;" & vbCrLf
        printScreen += "margin-left:5px;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "font-family:""Verdana"",sans-serif;" & vbCrLf
        printScreen += "font-size:0.9em;" & vbCrLf
        printScreen += "height:auto;" & vbCrLf
        printScreen += "margin-top:25px;" & vbCrLf
        printScreen += "padding-bottom:2px;" & vbCrLf
        printScreen += "left:240px;" & vbCrLf
        printScreen += "}" & vbCrLf

        printScreen += ".subDemoNoPer" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "width:70px;" & vbCrLf
        printScreen += "margin-left:5px;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "font-family:""Verdana"",sans-serif;" & vbCrLf
        printScreen += "font-size:0.9em;" & vbCrLf
        printScreen += "height:auto;" & vbCrLf
        printScreen += "margin-top:25px;" & vbCrLf
        printScreen += "padding-bottom:2px;" & vbCrLf
        printScreen += "left:310px;" & vbCrLf

        printScreen += "}" & vbCrLf

        printScreen += "span.lblTotalNoDemosCnt" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "left:265px;" & vbCrLf
        printScreen += "width:41px;""& vbCrLf"
        printScreen += "height:20px;" & vbCrLf

        printScreen += "font-size:1.0em;" & vbCrLf
        printScreen += "font-weight:bold;" & vbCrLf
        printScreen += "margin-top:355px;" & vbCrLf

        printScreen += "}" & vbCrLf

        printScreen += "span.lblTotalNoDemosPer" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "left:305px;" & vbCrLf
        printScreen += "width:41px;" & vbCrLf
        printScreen += "height:20px;" & vbCrLf

        printScreen += "font-size:1.0em;" & vbCrLf
        printScreen += "font-weight:bold;" & vbCrLf
        printScreen += "margin-top:355px;" & vbCrLf
        printScreen += "}" & vbCrLf

        printScreen += ".subNotHitsCNT" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "width:70px;" & vbCrLf
        printScreen += "margin-left:5px;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "font-family:""Verdana"",sans-serif;" & vbCrLf
        printScreen += "font-size:0.9em;" & vbCrLf
        printScreen += "height:auto;" & vbCrLf
        printScreen += "margin-top:25px;" & vbCrLf
        printScreen += "padding-bottom:2px;" & vbCrLf
        printScreen += "left:380px;" & vbCrLf
        printScreen += "}" & vbCrLf

        printScreen += ".subNotHitsPer" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "width:70px;" & vbCrLf
        printScreen += "margin-left:5px;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "font-family:""Verdana"",sans-serif;" & vbCrLf
        printScreen += "font-size:0.9em;" & vbCrLf
        printScreen += "height:auto;" & vbCrLf
        printScreen += "margin-top:25px;" & vbCrLf
        printScreen += "padding-bottom:2px;" & vbCrLf
        printScreen += "left:450px;" & vbCrLf
        printScreen += "}" & vbCrLf

        printScreen += ".subSold" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "width:170px;" & vbCrLf
        printScreen += "margin-left:5px;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "font-family:""Verdana"",sans-serif;" & vbCrLf
        printScreen += "font-size:0.9em;" & vbCrLf

        printScreen += "height:auto;" & vbCrLf
        printScreen += "margin-top:25px;" & vbCrLf
        printScreen += "padding-bottom:2px;" & vbCrLf

        printScreen += "left:505px;" & vbCrLf
        printScreen += "}" & vbCrLf

        printScreen += "span.lblTotalSoldMoney" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "left:525px;" & vbCrLf
        printScreen += "width:141px;" & vbCrLf
        printScreen += "height:auto;" & vbCrLf

        printScreen += "font-size:1.0em;" & vbCrLf
        printScreen += "font-weight:bold;" & vbCrLf
        printScreen += "margin-top:15px;" & vbCrLf
        printScreen += "}" & vbCrLf

        printScreen += "div.totals" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:relative;" & vbCrLf
        printScreen += "height:46px;" & vbCrLf
        printScreen += "border-style:solid;" & vbCrLf
        printScreen += "border-width:1px;" & vbCrLf
        printScreen += "border-color:black;" & vbCrLf
        printScreen += "border-top-width:0px;" & vbCrLf
        printScreen += "border-right-width:0px;" & vbCrLf
        printScreen += "border-left-width:0px;" & vbCrLf
        printScreen += "border-bottom-width:0px;" & vbCrLf
        printScreen += "margin-top:15px;" & vbCrLf
        printScreen += "}" & vbCrLf

        printScreen += "span.lblTotal" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "left:28px;" & vbCrLf
        printScreen += "width:100px;" & vbCrLf
        printScreen += "height:20px;" & vbCrLf

        printScreen += "font-size:1.0em;" & vbCrLf
        printScreen += "font-weight:bold;" & vbCrLf
        printScreen += "margin-top:14px;" & vbCrLf
        printScreen += "}" & vbCrLf

        printScreen += "span.lblTotalIssueCnt" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "left:168px;" & vbCrLf
        printScreen += "width:78px;" & vbCrLf
        printScreen += "height:20px;" & vbCrLf

        printScreen += "font-size:1.0em;" & vbCrLf
        printScreen += "font-weight:bold;" & vbCrLf
        printScreen += "margin-top:14px;" & vbCrLf
        printScreen += "}" & vbCrLf

        printScreen += "span.lblTotalDemoNoSalesCnt" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "left:259px;" & vbCrLf
        printScreen += "width:41px;" & vbCrLf
        printScreen += "height:20px;" & vbCrLf

        printScreen += "font-size:1.0em;" & vbCrLf
        printScreen += "font-weight:bold;" & vbCrLf
        printScreen += "margin-top:14px;" & vbCrLf
        printScreen += "}" & vbCrLf

        printScreen += "span.lblTotalDemoNoSalesPer" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "left:331px;" & vbCrLf
        printScreen += "width:41px;" & vbCrLf
        printScreen += "height:20px;" & vbCrLf

        printScreen += "font-size:1.0em;" & vbCrLf
        printScreen += "font-weight:bold;" & vbCrLf
        printScreen += "margin-top:14px;" & vbCrLf
        printScreen += "}" & vbCrLf

        printScreen += "span.lblTotalNotHitsCnt" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "left:400px;" & vbCrLf
        printScreen += "width:41px;" & vbCrLf
        printScreen += "height:20px;" & vbCrLf

        printScreen += "font-size:1.0em;" & vbCrLf
        printScreen += "font-weight:bold;" & vbCrLf
        printScreen += "margin-top:14px;" & vbCrLf
        printScreen += "}" & vbCrLf

        printScreen += "span.lblTotalNotHitsPer" & vbCrLf
        printScreen += "{" & vbCrLf
        printScreen += "position:fixed;" & vbCrLf
        printScreen += "text-align:center;" & vbCrLf
        printScreen += "left:470px;" & vbCrLf
        printScreen += "width:41px;" & vbCrLf
        printScreen += "height:20px;" & vbCrLf

        printScreen += "font-size:1.0em;" & vbCrLf
        printScreen += "font-weight:bold;" & vbCrLf
        printScreen += "margin-top:14px;" & vbCrLf
        printScreen += "}" & vbCrLf
        printScreen += "}" & vbCrLf

        printScreen += "</style>"


        '' construct "page"
        '' <!DOCTYPE HTML><HEAD></ Title> </head><body> . . . . 
        '' 
        '' 

        Dim accuracyPer As String = Accuracy

        Try


            '' testing purposes only
            '' 
            sr.WriteLine("<!DOCTYPE html>")
            sr.WriteLine("<head>")
            sr.WriteLine("<meta charset = 'UTF-8'>")
            sr.WriteLine("<!--- AUTO GENERATED CODE BY APPLICATION --> ")
            sr.WriteLine("<title>Sales Performance Report For: " & Date.Now.ToShortDateString & "</title>")
            sr.WriteLine("<!-- Code Executed On:> " & Date.Now.ToShortDateString & " " & Date.Now.TimeOfDay.ToString & "-->")
            sr.WriteLine(mediaScreen)
            sr.WriteLine(printScreen)
            sr.WriteLine("</head>")
            sr.WriteLine("<body>")
            sr.WriteLine("<div class='screen'> <!--- Screen Div --->")
            sr.WriteLine("<span class='lblAccuracyHeader'>This report is " & accuracyPer & "% accurate.</span><span class='lblTitleHeader'>Performance Report</span><span class='lblDateRangeHeader'>Report Date Range: " & StartDate & " to " & EndDate & "</span>")
            sr.WriteLine("<div class='hdrLbls'> <!-- headers --><span class='lblSalesRep'>Sales Rep</span><span class='lblNumIssued'>Issued</span><span class='lblDemoNoSales'>Demo/No Sales</span><span class='lblNotHits'>Not Hits</span><span class='lblResets'>Resets</span><span class='lblNoDemos'>No Demos</span><span class='lblSales'>Sales</span><span class='lblRecissionCancels'>Recission Cancels</span><span class='lblTotalSold'>Sold</span>")
            sr.WriteLine("<div class='subCont'><!-- Rows of data -->")

            Dim cnt As Integer = 0
            For cnt = 1 To ListData.Count - 1 '' first line is 'totals' row ? ? 
                Dim g As LineOfData = ListData.Item(cnt)
                sr.WriteLine("<div class='zebra'><!-- Zebra 'Row'-->")
                sr.WriteLine("      <!-- Row --><span class='subSalesRep'>" & g.SalesRep & "</span><span class='subIssuedCNT'>" & g.Issued & "</span> </span><span class='subDemoNoCNT'>" & g.DemoNoSaleCount & "</span><span class='subDemoNoPer'>" & g.DemoNoSalePercent & "%</span><span class='subNotHitsCNT'>" & g.NotHitCount & "</span>")
                sr.WriteLine(" 		<span class='subNotHitsPer'>" & g.NotHitPercent & "%</span><span class='subResetsCNT'>" & g.ResetCount & "</span><span class='subResetsPer'>" & g.ResetCountPercent & "%</span><span class='subNoDemosCNT'>" & g.NoDemoCount & "</span><span class='subNoDemosPer'>" & g.NoDemoCountPercent & "%</span>")
                sr.WriteLine("		<span class='subSalesCNT'>" & g.SalesCount & "</span><span class='subSalesPer'>" & g.SalesCountPercent & "%</span><span class='subRecCanCNT'>" & g.RecissionCancelCount & "</span><span class='subRecCanPer'>" & g.RecissionCancelPercent & "%</span><span class='subSold'>" & FormatCurrency(g.TotalSoldPerRep, 2, Microsoft.VisualBasic.TriState.False, False, Microsoft.VisualBasic.TriState.True) & "</span><br />")
                sr.WriteLine("</div><!--END Zebra 'Row' -->")
            Next

            Dim gg As LineOfData
            gg = ListData.Item(0)

            sr.WriteLine("<div class='totals'> <!-- Totals -->")
            sr.WriteLine("      <span class='lblTotal'>Totals: </span><span class='lblTotalIssueCnt'>" & gg.Issued & "</span> <span class='lblTotalDemoNoSalesCnt'>" & gg.DemoNoSaleCount & "</span><span class='lblTotalDemoNoSalesPer'>" & gg.DemoNoSalePercent & "%</span>")
            sr.WriteLine("  	<span class='lblTotalNotHitsCnt'>" & gg.NotHitCount & "</span><span class='lblTotalNotHitsPer'>" & gg.NotHitPercent & "%</span><span class='lblTotalResetsCnt'>" & gg.ResetCount & "</span><span class='lblTotalResetsPer'>" & gg.ResetCountPercent & "%</span>")
            sr.WriteLine("		<span class='lblTotalNoDemosCnt'>" & gg.NoDemoCount & "</span><span class='lblTotalNoDemosPer'>" & gg.NoDemoCountPercent & "%</span><span class='lblTotalSalesCnt'>" & gg.SalesCount & "</span><span class='lblTotalSalesPer'>" & gg.SalesCountPercent & "%</span>")
            sr.WriteLine("  	<span class='lblTotalRecCanCnt'>" & gg.RecissionCancelCount & "</span><span class='lblTotalRecCanPer'>" & gg.RecissionCancelPercent & "%</span><span class='lblTotalSoldMoney'>" & FormatCurrency(gg.TotalSoldPerRep, 2, Microsoft.VisualBasic.TriState.False, Microsoft.VisualBasic.TriState.False, Microsoft.VisualBasic.TriState.True) & "</span>")
            sr.WriteLine("</div><!--Totals-->")

            sr.WriteLine("</div><!--Sub Cont -->")
            sr.WriteLine("</div><!--Header Labels -->")
            sr.WriteLine("</div><!--Screen-->")
            sr.WriteLine("</body>")
            sr.WriteLine("</html>")

            sr.Flush()
            sr.Close()

            System.Diagnostics.Process.Start("IExplore.exe", complete_File_Path)

        Catch ex As Exception
            Dim err As String = ex.Message
            MsgBox("Error: " & vbCrLf & err.ToString, MsgBoxStyle.Critical, "DEBUG INFO - Error Write_HTML_Doc()")

            sr = Nothing
        End Try




    End Sub



#End Region


End Class
