Imports System.IO
Imports System.Text.StringBuilder
Imports System.Drawing.Printing
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class printToPrinterContactList


    '' Notes: 12-25-2015 AC
    '' need methods to clean up appt time / date - "12/1/2015-10:00 AM"
    '' product logic - convert over to acro's to save space / readability -"RF-WN-SD"
    '' need contact names logic - "Clay, Aaron and Nicole"
    '' get rid of layout rectangles
    '' clean up Rep names - Rep1.FName & Last Init. & Rep2.FName & Last Init. -> Save space - > Readability => "John S. & Mark P."
    ''
    '' New() constructor takes List Of Records as argument(?)
    '' same stored procedure for entire 'list' building -> same data struct returned -> only criteria changes 
    '' depending on "Sales.cboSalesList" selection
    '' 
    '' Why Fire query again, pull data from front end list view collection and convert to structures then pass to class for print-preview/print.
    '' data is already there depending on user selection.
    '' 
    '' logic already performed for readability. 
    '' 
    '' PASS THE LIST VIEW ITEM COLLECTION as an argument then convert to structs within class.
    '' class houses implementation logic -> keep off front end. 
    '' dim xyz as new printToPrinterContactList(lvSales.ListViewItemCollection) 

    Private Const pro_cnx As String = "SERVER=192.168.1.2;Database=Iss;User Id=sa;Password=spoken1;"

    Public Structure RecordOBJ
        Public ID As String
        Public ContactInfo As String
        Public Address As String
        Public Phone As String
        Public Products As String
        Public ApptDateAndTime As String
        Public Reps As String
    End Structure

    Private PD As PrintDocument
    Private PPrev As PrintPreviewDialog
    Private arRecs As List(Of RecordOBJ)
    Private pr_font As New System.Drawing.Font("Verdana", 10, FontStyle.Regular)
    Dim page As Integer = 0
    Dim posIDX As Integer = 0
    Dim curIDX As Integer = -1
    Dim ttlPages As Integer = 0
    Dim lvCol As ListView.ListViewItemCollection

    Public ReadOnly Property List_Of_Records As List(Of RecordOBJ)
        Get
            Return arRecs
        End Get
    End Property
    Public Sub New(ByVal Data As ListView.ListViewItemCollection)
        PD = New PrintDocument
        lvCol = Data
        PPrev = New PrintPreviewDialog
        arRecs = New List(Of RecordOBJ)
        '' fill in list of records here 
        '' with query from sales-> contact list filler
        '' 
        If Data.Count >= 1 Then
            For Each y As ListViewItem In lvCol
                '' convert to struct here
                Dim b As New RecordOBJ
                b.ID = y.Text
                b.ContactInfo = y.SubItems(1).Text
                b.Address = y.SubItems(2).Text
                b.Phone = y.SubItems(3).Text
                b.Products = y.SubItems(4).Text
                b.ApptDateAndTime = y.SubItems(5).Text
                b.Reps = y.SubItems(6).Text
                arRecs.Add(b)
            Next

            PD.DefaultPageSettings.Landscape = True
            With PD.DefaultPageSettings
                .Margins.Top = 0.25
                .Margins.Left = 0.25
                .Margins.Right = 0.25
                .Margins.Bottom = 0.25
            End With
            AddHandler PD.PrintPage, AddressOf PD_PrintPage
            PPrev.Document = PD
        ElseIf Data.Count <= 0 Then
            Exit Sub
        End If

    End Sub

    Public Sub ShowDoc()
        PPrev.ClientSize = New System.Drawing.Size(600, 600)
        PPrev.ShowDialog()

    End Sub

    Private Sub PD_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)

        '' layout rectangles -> e.graphics.drawRectangle() is for debug purpose only.
        ''

        Dim ttlcnt As Integer = arRecs.Count - 1
        Dim currentIteration As Integer = -1
        Dim linesPerPage As Single = CInt(e.MarginBounds.Height / pr_font.GetHeight(e.Graphics)) - 1
        Dim yPos As Integer = 0
        Dim a As Integer = 0
        Dim totalRect As New System.Drawing.Rectangle(e.MarginBounds.Left + 5, e.MarginBounds.Top + 5, e.MarginBounds.Width - 10, e.MarginBounds.Height - 10)

        'e.Graphics.DrawRectangle(Pens.Blue, totalRect)
        'For a = 0 To linesPerPage - 1
        Dim numPages As Integer = CInt(ttlcnt / (linesPerPage - 1)) + 1
        ttlPages = numPages

        For a = 0 To linesPerPage - 1
            posIDX += 1
            curIDX += 1

            currentIteration += 1
            yPos = (currentIteration * pr_font.GetHeight(e.Graphics)) + e.MarginBounds.Top + 10
            Dim height As Integer = CInt(pr_font.GetHeight(e.Graphics))

            '' ID Rect
            Dim rectF As New System.Drawing.Rectangle(e.MarginBounds.Left + 10, yPos, 70, height)
            'e.Graphics.DrawRectangle(Pens.Blue, rectF)
            e.Graphics.DrawString(arRecs(curIDX).ID.ToString, pr_font, Brushes.Black, rectF)

            '' contacts
            Dim rectG As New System.Drawing.Rectangle(e.MarginBounds.Left + 80, yPos, 200, height)
            'e.Graphics.DrawRectangle(Pens.Blue, rectG)
            e.Graphics.DrawString(arRecs(curIDX).ContactInfo, pr_font, Brushes.Black, rectG)

            '' address
            Dim rectA As New System.Drawing.Rectangle(e.MarginBounds.Left + 280, yPos, 250, height)
            'e.Graphics.DrawRectangle(Pens.Blue, rectA)
            e.Graphics.DrawString(arRecs(curIDX).Address, pr_font, Brushes.Black, rectA)

            ''house phone
            Dim rectP As New System.Drawing.Rectangle(e.MarginBounds.Left + 530, yPos, 125, height)
            ' e.Graphics.DrawRectangle(Pens.Blue, rectP)
            e.Graphics.DrawString(arRecs(curIDX).Phone, pr_font, Brushes.Black, rectP)

            ''products
            Dim rectPR As New System.Drawing.Rectangle(e.MarginBounds.Left + 655, yPos, 75, height)
            'e.Graphics.DrawRectangle(Pens.Blue, rectPR)
            e.Graphics.DrawString(arRecs(curIDX).Products, pr_font, Brushes.Black, rectPR)

            '' appt date/time
            Dim rectDT As New System.Drawing.Rectangle(e.MarginBounds.Left + 730, yPos, 200, height)
            'e.Graphics.DrawRectangle(Pens.Blue, rectDT)
            e.Graphics.DrawString(arRecs(curIDX).ApptDateAndTime, pr_font, Brushes.Black, rectDT)

            ''Rep(s)
            Dim rectREP As New System.Drawing.Rectangle(e.MarginBounds.Left + 930, yPos, 160, height)
            'e.Graphics.DrawRectangle(Pens.Blue, rectREP)
            e.Graphics.DrawString(arRecs(curIDX).Reps, pr_font, Brushes.Black, rectREP)

            If posIDX = ttlcnt Then
                Exit For
            End If
        Next
        page += 1

        e.HasMorePages = page < numPages

        '' according to msdn and various forum posts
        '' the 'build document' portion is run 2x
        '' once for preview, once for actual print
        '' have to reinitialize the variables (reset them) for when you actually
        '' decide to hit 'print' from print preview.
        '' 

        '' resetting of the vars
        '' for actual print call
        If Not e.HasMorePages Then
            ttlPages = 0
            page = 0
            posIDX = 0
            curIDX = -1
            arRecs = New List(Of RecordOBJ)
            '' repop list of structs
            For Each y As ListViewItem In lvCol
                '' convert to struct here
                Dim b As New RecordOBJ
                b.ID = y.Text
                b.ContactInfo = y.SubItems(1).Text
                b.Address = y.SubItems(2).Text
                b.Phone = y.SubItems(3).Text
                b.Products = y.SubItems(4).Text
                b.ApptDateAndTime = y.SubItems(5).Text
                b.Reps = y.SubItems(6).Text
                arRecs.Add(b)
            Next
        End If
    End Sub

End Class
