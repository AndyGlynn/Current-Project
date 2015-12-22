Imports System.IO
Imports System.Text.StringBuilder
Imports System.Drawing.Printing
Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class printToPrinter

    Public Structure MessageBody
        'strLead += r1.Item("ID") & vbCrLf
        Public RecordID As String
        '          strLead += r1.Item("Marketer") & vbCrLf
        Public Marketer As String
        '       strLead += r1.Item("PrimaryLeadSource") & vbCrLf
        Public PLS As String
        '       strLead += r1.Item("SecondaryLeadSource") & vbCrLf
        Public SLS As String
        '       strLead += r1.Item("LeadGeneratedOn") & vbCrLf
        Public LeadGeneratedOn As String
        '   strLead += (r1.Item("Contact1FirstName") & " " & r1.Item("Contact1LastName")) & vbCrLf
        Public C1Name As String
        '   strLead += (r1.Item("Contact2FirstName") & " " & r1.Item("Contact2LastName")) & vbCrLf
        Public C2Name As String
        '   strLead += (r1.Item("StAddress") & " " & r1.Item("City") & " " & r1.Item("state") & " " & r1.Item("Zip")) & vbCrLf
        Public Address As String
        '       strLead += (r1.Item("HousePhone") & " " & r1.Item("Altphone1") & " " & r1.Item("AltPhone2")) & vbCrLf
        Public PhoneNumbers As String
        '   strLead += r1.Item("SpokeWith") & " " & r1.Item("Contact1WorkHours") & " " & r1.Item("Contact2WorkHours") & vbCrLf
        Public SpokeWithAndContactHours As String
        '   strLead += r1.Item("Product1") & " " & r1.Item("Product2") & " " & r1.Item("Product3") & r1.Item("Color") & " " & r1.Item("ProductQTY") & vbCrLf
        Public Products As String
        '   strLead += r1.Item("YearsOwned") & " " & r1.Item("HomeAge") & " " & r1.Item("HomeValue") & vbCrLf
        Public HomeInfo As String
        '   strLead += r1.Item("ApptDate") & " " & r1.Item("ApptDay") & " " & r1.Item("ApptTime") & vbCrLf & vbCrLf
        Public ApptIfno As String
        '   strLead += r1.Item("SpecialInstruction") & vbCrLf & vbCrLf
        Public SpecialInstructions As String
        '   strLead += r1.Item("Result") & vbCrLf
        Public LastResult As String
        '   strLead += r1.Item("QuotedSold") & " " & r1.Item("ParPrice") & vbCrLf
        Public QuotedSoldAmount As String
        '   strLead += r1.Item("ManagerNotes") & vbCrLf
        Public ManagerNotes As String
        '   strLead += r1.Item("Cash") & " " & r1.Item("Finance") & vbCrLf
        Public FinancingOption As String
        '       strLead += r1.Item("MarketingResults") & vbCrLf
        Public MarketingResults As String
        '   strLead += r1.Item("EmailAddress") & vbCrLf
        Public Cust_EmailAddress As String
        '   strLead += r1.Item("IspreviousCustomer") & " " & r1.Item("IsRecovery") & vbCrLf
        Public PreviousCustomer As String
    End Structure

    Private Const pro_cnx As String = "SERVER=192.168.1.2;Database=Iss;User Id=sa;Password=spoken1;"
    Private PD As PrintDocument
    Private CurrentLeadInfo As MessageBody
    Private hdr_font As New System.Drawing.Font("Verdana", 14, FontStyle.Bold)
    Private fld_font As New System.Drawing.Font("Verdana", 10, FontStyle.Bold)
    Private nfo_font As New System.Drawing.Font("Verdana", 10, FontStyle.Regular)

    Public ReadOnly Property Current_DOC As PrintDocument
        Get
            Return PD
        End Get
    End Property

    Public Sub New(ByVal RecID As String)
        PD = New PrintDocument
        CurrentLeadInfo = New MessageBody
        CurrentLeadInfo = Get_Lead_Info(RecID)
        AddHandler PD.PrintPage, AddressOf PD_PrintPage
        Dim pprev As New PrintPreviewDialog
        With PD.DefaultPageSettings
            .Margins.Left = 0.4
            .Margins.Right = 0.4
            .Margins.Top = 0.4
            .Margins.Bottom = 0.4
        End With
        PD.DefaultPageSettings.Landscape = False
        pprev.Document = PD
        pprev.ShowDialog()
    End Sub

    Private Sub PD_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)

        '' appointment sheet hdr
        '' 
        Dim hdr As String = "-- Appointment Sheet --"
        Dim hdr_length As Integer = 280
        Dim rectAppt As New System.Drawing.Rectangle(e.MarginBounds.Left + (e.MarginBounds.Width / 2) - 150, (e.MarginBounds.Top + 15), hdr_length, hdr_font.GetHeight(e.Graphics))
        'e.Graphics.DrawRectangle(Pens.Blue, rectAppt)
        e.Graphics.DrawString(hdr, hdr_font, Brushes.Black, rectAppt)

        '' formatting spacer
        Dim rectSpace1 As New System.Drawing.Rectangle(e.MarginBounds.Left + 20, e.MarginBounds.Top + hdr_font.GetHeight(e.Graphics) + fld_font.GetHeight(e.Graphics), 50, fld_font.GetHeight(e.Graphics))
        ' e.Graphics.DrawRectangle(Pens.Blue, rectSpace1)

        '' appttime
        Dim rectApptTime As New System.Drawing.Rectangle(e.MarginBounds.Left + 20, e.MarginBounds.Top + hdr_font.GetHeight(e.Graphics) + (fld_font.GetHeight(e.Graphics) * 2) + 5, 175, fld_font.GetHeight(e.Graphics))
        'e.Graphics.DrawRectangle(Pens.Blue, rectApptTime)
        e.Graphics.DrawString("Appointment Time: ", fld_font, Brushes.Black, rectApptTime)

        Dim rectApptTimeVal As New System.Drawing.Rectangle(e.MarginBounds.Left + 20 + 185, e.MarginBounds.Top + hdr_font.GetHeight(e.Graphics) + (fld_font.GetHeight(e.Graphics) * 2) + 5, 175, fld_font.GetHeight(e.Graphics))
        ' e.Graphics.DrawRectangle(Pens.Blue, rectApptTimeVal)
        Dim vals() = Split(CurrentLeadInfo.ApptIfno, " ", -1, Microsoft.VisualBasic.CompareMethod.Text)
        '' date | Day | Time1(bogus date) | time2(hours) | AM/PM
        '' 0       1      2                    3              4
        e.Graphics.DrawString(vals(3).ToString & " " & vals(4).ToString, nfo_font, Brushes.Black, rectApptTimeVal)

        '' apptDay
        Dim rectApptDay As New System.Drawing.Rectangle(e.MarginBounds.Left + 20, e.MarginBounds.Top + hdr_font.GetHeight(e.Graphics) + (fld_font.GetHeight(e.Graphics) * 3) + 5, 175, fld_font.GetHeight(e.Graphics))
        'e.Graphics.DrawRectangle(Pens.Blue, rectApptDay)
        e.Graphics.DrawString("Appointment Day: ", fld_font, Brushes.Black, rectApptDay)

        Dim rectApptDayVal As New System.Drawing.Rectangle(e.MarginBounds.Left + 20 + 185, e.MarginBounds.Top + hdr_font.GetHeight(e.Graphics) + (fld_font.GetHeight(e.Graphics) * 3) + 5, 175, fld_font.GetHeight(e.Graphics))
        'e.Graphics.DrawRectangle(Pens.Blue, rectApptDayVal)
        e.Graphics.DrawString(vals(1).ToString, nfo_font, Brushes.Black, rectApptDayVal)

        '' formatting space 2
        Dim rectSpace2 As New System.Drawing.Rectangle(e.MarginBounds.Left + 20, e.MarginBounds.Top + hdr_font.GetHeight(e.Graphics) + (fld_font.GetHeight(e.Graphics) * 4) + 10, 50, fld_font.GetHeight(e.Graphics))
        'e.Graphics.DrawRectangle(Pens.Blue, rectSpace2)

        '' Customer ID:
        Dim rectID As New System.Drawing.Rectangle(e.MarginBounds.Left + 20, e.MarginBounds.Top + hdr_font.GetHeight(e.Graphics) + (fld_font.GetHeight(e.Graphics) * 5) + 15, 175, fld_font.GetHeight(e.Graphics))
        ' e.Graphics.DrawRectangle(Pens.Blue, rectid)
        e.Graphics.DrawString("Customer ID:", fld_font, Brushes.Black, rectID)

        Dim rectIDVal As New System.Drawing.Rectangle(e.MarginBounds.Left + 20 + 185, e.MarginBounds.Top + hdr_font.GetHeight(e.Graphics) + (fld_font.GetHeight(e.Graphics) * 5) + 15, 175, fld_font.GetHeight(e.Graphics))
        ' e.Graphics.DrawRectangle(Pens.Blue, rectIDVal)
        e.Graphics.DrawString(CurrentLeadInfo.RecordID.ToString, nfo_font, Brushes.Black, rectIDVal)

        '' formatting space 3
        Dim rectSpace3 As New System.Drawing.Rectangle(e.MarginBounds.Left + 20, e.MarginBounds.Top + hdr_font.GetHeight(e.Graphics) + (fld_font.GetHeight(e.Graphics) * 6) + 20, 50, fld_font.GetHeight(e.Graphics))
        'e.Graphics.DrawRectangle(Pens.Blue, rectSpace3)

        '' customer name(s)
        Dim rectName As New System.Drawing.Rectangle(e.MarginBounds.Left + 20, e.MarginBounds.Top + hdr_font.GetHeight(e.Graphics) + (fld_font.GetHeight(e.Graphics) * 7) + 25, 175, fld_font.GetHeight(e.Graphics))
        'e.Graphics.DrawRectangle(Pens.Blue, rectName)
        e.Graphics.DrawString("Customer:", fld_font, Brushes.Black, rectName)

        Dim rectNameVal As New System.Drawing.Rectangle(e.MarginBounds.Left + 20 + 185, e.MarginBounds.Top + hdr_font.GetHeight(e.Graphics) + (fld_font.GetHeight(e.Graphics) * 7) + 25, 275, fld_font.GetHeight(e.Graphics))
        'e.Graphics.DrawRectangle(Pens.Blue, rectNameVal)
        e.Graphics.DrawString(CurrentLeadInfo.C1Name & " " & CurrentLeadInfo.C2Name, nfo_font, Brushes.Black, rectNameVal)

        '' formatting space 4
        Dim rectSpace4 As New System.Drawing.Rectangle(e.MarginBounds.Left + 20, e.MarginBounds.Top + hdr_font.GetHeight(e.Graphics) + (fld_font.GetHeight(e.Graphics) * 8) + 30, 50, fld_font.GetHeight(e.Graphics))
        'e.Graphics.DrawRectangle(Pens.Blue, rectSpace4)

        '' staddress
        Dim rectAddy1 As New System.Drawing.Rectangle(e.MarginBounds.Left + 20, e.MarginBounds.Top + hdr_font.GetHeight(e.Graphics) + (fld_font.GetHeight(e.Graphics) * 9) + 35, 175, fld_font.GetHeight(e.Graphics))
        'e.Graphics.DrawRectangle(Pens.Blue, rectAddy1)
        e.Graphics.DrawString("Address:", fld_font, Brushes.Black, rectAddy1)

        Dim rectaddVal1 As New System.Drawing.Rectangle(e.MarginBounds.Left + 20 + 185, e.MarginBounds.Top + hdr_font.GetHeight(e.Graphics) + (fld_font.GetHeight(e.Graphics) * 9) + 35, 375, fld_font.GetHeight(e.Graphics))
        'e.Graphics.DrawRectangle(Pens.Blue, rectaddVal1)
        e.Graphics.DrawString(CurrentLeadInfo.Address, nfo_font, Brushes.Black, rectaddVal1)

        '' formatting space 5
        Dim rectSpace5 As New System.Drawing.Rectangle(e.MarginBounds.Left + 20, e.MarginBounds.Top + hdr_font.GetHeight(e.Graphics) + (fld_font.GetHeight(e.Graphics) * 10) + 40, 50, fld_font.GetHeight(e.Graphics))
        ' e.Graphics.DrawRectangle(Pens.Blue, rectSpace5)

        '' Phones
        Dim rectPhones As New System.Drawing.Rectangle(e.MarginBounds.Left + 20, e.MarginBounds.Top + hdr_font.GetHeight(e.Graphics) + (fld_font.GetHeight(e.Graphics) * 11) + 45, 175, fld_font.GetHeight(e.Graphics))
        ' e.Graphics.DrawRectangle(Pens.Blue, rectPhones)
        e.Graphics.DrawString("Phone(s):", fld_font, Brushes.Black, rectPhones)

        Dim rectPhoneVal As New System.Drawing.Rectangle(e.MarginBounds.Left + 20 + 185, e.MarginBounds.Top + hdr_font.GetHeight(e.Graphics) + (fld_font.GetHeight(e.Graphics) * 11) + 45, 375, fld_font.GetHeight(e.Graphics))
        ' e.Graphics.DrawRectangle(Pens.Blue, rectPhoneVal)
        e.Graphics.DrawString(CurrentLeadInfo.PhoneNumbers.ToString, nfo_font, Brushes.Black, rectPhoneVal)

        '' formatting space 6
        Dim rectSpace6 As New System.Drawing.Rectangle(e.MarginBounds.Left + 20, e.MarginBounds.Top + hdr_font.GetHeight(e.Graphics) + (fld_font.GetHeight(e.Graphics) * 12) + 50, 50, fld_font.GetHeight(e.Graphics))
        'e.Graphics.DrawRectangle(Pens.Blue, rectSpace6)

        '' product(s)
        Dim rectproducts As New System.Drawing.Rectangle(e.MarginBounds.Left + 20, e.MarginBounds.Top + hdr_font.GetHeight(e.Graphics) + (fld_font.GetHeight(e.Graphics) * 13) + 55, 175, fld_font.GetHeight(e.Graphics))
        'e.Graphics.DrawRectangle(Pens.Blue, rectproducts)
        e.Graphics.DrawString("Product(s):", fld_font, Brushes.Black, rectproducts)

        Dim rectprodval As New System.Drawing.Rectangle(e.MarginBounds.Left + 20 + 185, e.MarginBounds.Top + hdr_font.GetHeight(e.Graphics) + (fld_font.GetHeight(e.Graphics) * 13) + 55, 375, fld_font.GetHeight(e.Graphics))
        ' e.Graphics.DrawRectangle(Pens.Blue, rectprodval)
        e.Graphics.DrawString(CurrentLeadInfo.Products, nfo_font, Brushes.Black, rectprodval)

        '' formatting space 7
        Dim rectSpace7 As New System.Drawing.Rectangle(e.MarginBounds.Left + 20, e.MarginBounds.Top + hdr_font.GetHeight(e.Graphics) + (fld_font.GetHeight(e.Graphics) * 14) + 60, 50, fld_font.GetHeight(e.Graphics))
        'e.Graphics.DrawRectangle(Pens.Blue, rectSpace7)

        '' special instructions
        Dim rectspec As New System.Drawing.Rectangle(e.MarginBounds.Left + 20, e.MarginBounds.Top + hdr_font.GetHeight(e.Graphics) + (fld_font.GetHeight(e.Graphics) * 15) + 65, 175, fld_font.GetHeight(e.Graphics))
        ' e.Graphics.DrawRectangle(Pens.Blue, rectspec)
        e.Graphics.DrawString("Special Instruction:", fld_font, Brushes.Black, rectspec)

        Dim rectspecval As New System.Drawing.Rectangle(e.MarginBounds.Left + 20 + 185, e.MarginBounds.Top + hdr_font.GetHeight(e.Graphics) + (fld_font.GetHeight(e.Graphics) * 15) + 65, 400, fld_font.GetHeight(e.Graphics) * 6)
        'e.Graphics.DrawRectangle(Pens.Blue, rectspecval)
        e.Graphics.DrawString(CurrentLeadInfo.SpecialInstructions, nfo_font, Brushes.Black, rectspecval)

        '' formatting space 8
        Dim rectSpace8 As New System.Drawing.Rectangle(e.MarginBounds.Left + 20, e.MarginBounds.Top + hdr_font.GetHeight(e.Graphics) + (fld_font.GetHeight(e.Graphics) * 20) + 90, 50, fld_font.GetHeight(e.Graphics))
        'e.Graphics.DrawRectangle(Pens.Blue, rectSpace8)


        '' lead gen on
        Dim rectLeadGen As New System.Drawing.Rectangle(e.MarginBounds.Left + 20, e.MarginBounds.Top + hdr_font.GetHeight(e.Graphics) + (fld_font.GetHeight(e.Graphics) * 21) + 95, 175, fld_font.GetHeight(e.Graphics))
        ' e.Graphics.DrawRectangle(Pens.Blue, rectLeadGen)
        e.Graphics.DrawString("Lead Generated On:", fld_font, Brushes.Black, rectLeadGen)

        Dim rectLeadGenVal As New System.Drawing.Rectangle(e.MarginBounds.Left + 20 + 185, e.MarginBounds.Top + hdr_font.GetHeight(e.Graphics) + (fld_font.GetHeight(e.Graphics) * 21) + 95, 175, fld_font.GetHeight(e.Graphics))
        'e.Graphics.DrawRectangle(Pens.Blue, rectLeadGenVal)
        e.Graphics.DrawString(CurrentLeadInfo.LeadGeneratedOn, nfo_font, Brushes.Black, rectLeadGenVal)

        '' pls
        Dim rectPLS As New System.Drawing.Rectangle(e.MarginBounds.Left + 20, e.MarginBounds.Top + hdr_font.GetHeight(e.Graphics) + (fld_font.GetHeight(e.Graphics) * 22) + 100, 175, fld_font.GetHeight(e.Graphics))
        ' e.Graphics.DrawRectangle(Pens.Blue, rectPLS)
        e.Graphics.DrawString("Pri. Lead Source:", fld_font, Brushes.Black, rectPLS)

        Dim rectPLSVal As New System.Drawing.Rectangle(e.MarginBounds.Left + 20 + 185, e.MarginBounds.Top + hdr_font.GetHeight(e.Graphics) + (fld_font.GetHeight(e.Graphics) * 22) + 100, 175, fld_font.GetHeight(e.Graphics))
        ' e.Graphics.DrawRectangle(Pens.Blue, rectPLSVal)
        e.Graphics.DrawString(CurrentLeadInfo.PLS, nfo_font, Brushes.Black, rectPLSVal)

        '' sls
        Dim rectsLS As New System.Drawing.Rectangle(e.MarginBounds.Left + 20, e.MarginBounds.Top + hdr_font.GetHeight(e.Graphics) + (fld_font.GetHeight(e.Graphics) * 23) + 105, 175, fld_font.GetHeight(e.Graphics))
        ' e.Graphics.DrawRectangle(Pens.Blue, rectsLS)
        e.Graphics.DrawString("Sec. Lead Source:", fld_font, Brushes.Black, rectsLS)

        Dim rectSLSVal As New System.Drawing.Rectangle(e.MarginBounds.Left + 20 + 185, e.MarginBounds.Top + hdr_font.GetHeight(e.Graphics) + (fld_font.GetHeight(e.Graphics) * 23) + 105, 175, fld_font.GetHeight(e.Graphics))
        ' e.Graphics.DrawRectangle(Pens.Blue, rectSLSVal)
        e.Graphics.DrawString(CurrentLeadInfo.SLS, nfo_font, Brushes.Black, rectSLSVal)

        '' marketer
        Dim rectMARK As New System.Drawing.Rectangle(e.MarginBounds.Left + 20, e.MarginBounds.Top + hdr_font.GetHeight(e.Graphics) + (fld_font.GetHeight(e.Graphics) * 24) + 110, 175, fld_font.GetHeight(e.Graphics))
        'e.Graphics.DrawRectangle(Pens.Blue, rectMARK)
        e.Graphics.DrawString("Marketer:", fld_font, Brushes.Black, rectMARK)

        Dim rectMarkVal As New System.Drawing.Rectangle(e.MarginBounds.Left + 20 + 185, e.MarginBounds.Top + hdr_font.GetHeight(e.Graphics) + (fld_font.GetHeight(e.Graphics) * 24) + 110, 175, fld_font.GetHeight(e.Graphics))
        'e.Graphics.DrawRectangle(Pens.Blue, rectMarkVal)
        e.Graphics.DrawString(CurrentLeadInfo.Marketer, nfo_font, Brushes.Black, rectMarkVal)



    End Sub

    Private Function Get_Lead_Info(ByVal RecID As String)
        Dim x As New MessageBody
        Dim cnx As New SqlConnection(pro_cnx)
        cnx.Open()
        Dim cmdGET As New SqlCommand("SELECT * FROM EnterLead WHERE ID = N'" & RecID & "';", cnx)
        Dim r1 As SqlDataReader = cmdGET.ExecuteReader
        While r1.Read
            x.RecordID = RecID
            x.Marketer = r1.Item("Marketer")
            x.PLS = r1.Item("PrimaryLeadSource")
            x.SLS = r1.Item("SecondaryLeadSource")
            x.LeadGeneratedOn = r1.Item("LeadGeneratedOn")
            x.C1Name = r1.Item("Contact1FirstName") & " " & r1.Item("Contact1LastName")
            x.C2Name = r1.Item("Contact2FirstName") & " " & r1.Item("Contact2LastName")
            x.Address = r1.Item("StAddress") & " " & r1.Item("City") & " " & r1.Item("state") & " " & r1.Item("Zip")
            x.PhoneNumbers = r1.Item("HousePhone") & " " & r1.Item("AltPhone1") & " " & r1.Item("AltPhone2")
            x.SpokeWithAndContactHours = r1.Item("SpokeWith") & " " & r1.Item("Contact1WorkHours") & " " & r1.Item("Contact2WorkHours")
            x.Products = r1.Item("Product1") & " " & r1.Item("Product2") & " " & r1.Item("Product3") & " " & r1.Item("Color") & " " & r1.Item("ProductQTY")
            x.HomeInfo = r1.Item("YearsOwned") & " " & r1.Item("HomeAge") & " " & r1.Item("HomeValue")
            x.ApptIfno = r1.Item("ApptDate") & " " & r1.Item("ApptDay") & " " & r1.Item("ApptTime")
            x.SpecialInstructions = r1.Item("SpecialInstruction")
            x.LastResult = r1.Item("Result")
            x.QuotedSoldAmount = r1.Item("QuotedSold") & " " & r1.Item("ParPrice")
            x.ManagerNotes = r1.Item("ManagerNotes").ToString
            x.FinancingOption = r1.Item("Cash") & " " & r1.Item("Finance")
            x.MarketingResults = r1.Item("MarketingResults")
            x.Cust_EmailAddress = r1.Item("EmailAddress")
            x.PreviousCustomer = r1.Item("IsPreviousCustomer") & " " & r1.Item("IsRecovery")
        End While
        r1.Close()
        cnx.Close()
        cnx = Nothing
        Return x
    End Function
End Class
