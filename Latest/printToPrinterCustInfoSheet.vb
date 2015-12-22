Imports System.IO
Imports System.Text.StringBuilder
Imports System.Drawing.Printing
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class printToPrinterCustInfoSheet

    Private Const pro_cnx As String = "SERVER=192.168.1.2;Database=Iss;User Id=sa;Password=spoken1;"

    Public Structure CustomerInfo
        Public ID As String
        Public Contact1FName As String
        Public Contact1LName As String
        Public Contact2FName As String
        Public Contact2LName As String
        Public StAddress As String
        Public City As String
        Public State As String
        Public Zip As String
        Public ContactWorkHours As String
        Public HousePhone As String
        Public AltPhone1 As String
        Public AltPhone2 As String
        Public EmailAddress As String
    End Structure

    Private CurrentLead As CustomerInfo
    Private PD As PrintDocument
    Private PPrev As PrintPreviewDialog

    Private hdr_font As New System.Drawing.Font("Verdana", 14, FontStyle.Bold)
    Private fld_font As New System.Drawing.Font("Verdana", 10, FontStyle.Bold)
    Private nfo_font As New System.Drawing.Font("Verdana", 10, FontStyle.Regular)

    Public Sub New(ByVal RecID As String)
        CurrentLead = New CustomerInfo
        CurrentLead = GetCustInfo(RecID)
        PD = New PrintDocument
        PD.DefaultPageSettings.Landscape = False
        AddHandler PD.PrintPage, AddressOf PD_PrintPage
        PPrev = New PrintPreviewDialog
        With PD.DefaultPageSettings
            .Margins.Left = 0.4
            .Margins.Right = 0.4
            .Margins.Top = 0.4
            .Margins.Bottom = 0.4
        End With
        PPrev.Document = PD
        PPrev.ShowDialog()
    End Sub

    Private Function GetCustInfo(ByVal RecID As String)
        Dim x As New CustomerInfo
        Dim cnx As New SqlConnection(pro_cnx)
        cnx.Open()
        Dim cmdGET As New SqlCommand("select Contact1FirstName,Contact1LastName,Contact2FirstName,Contact2LastName,StAddress,City,State,Zip,Contact1WorkHours,HousePhone,AltPhone1,AltPhone2,EmailAddress FROM EnterLead WHERE ID= N'" & RecID & "';", cnx)
        Dim r1 As SqlDataReader = cmdGET.ExecuteReader
        While r1.Read
            x.ID = RecID
            x.Contact1FName = r1.Item("Contact1FirstName")
            x.Contact1LName = r1.Item("Contact1LastName")
            x.Contact2FName = r1.Item("Contact2FirstName")
            x.Contact2LName = r1.Item("Contact2LastName")
            x.StAddress = r1.Item("StAddress")
            x.City = r1.Item("City")
            x.State = r1.Item("State")
            x.Zip = r1.Item("Zip")
            x.ContactWorkHours = r1.Item("Contact1WorkHours")
            x.HousePhone = r1.Item("HousePhone")
            x.AltPhone1 = r1.Item("AltPhone1")
            x.AltPhone2 = r1.Item("AltPhone2")
            x.EmailAddress = r1.Item("EmailAddress")
        End While
        r1.Close()
        cnx.Close()
        cnx = Nothing
        Return x
    End Function

    Private Sub PD_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
        '' Customer Info HDR
        Dim hdr As String = "-- Customer Info Sheet --"
        Dim hdr_length As Integer = 300
        Dim rectAppt As New System.Drawing.Rectangle(e.MarginBounds.Left + (e.MarginBounds.Width / 2) - 150, (e.MarginBounds.Top + 15), hdr_length, hdr_font.GetHeight(e.Graphics))
        'e.Graphics.DrawRectangle(Pens.Blue, rectAppt)
        e.Graphics.DrawString(hdr, hdr_font, Brushes.Black, rectAppt)

        '' formatting spacer
        Dim rectSpace1 As New System.Drawing.Rectangle(e.MarginBounds.Left + 20, e.MarginBounds.Top + hdr_font.GetHeight(e.Graphics) + fld_font.GetHeight(e.Graphics), 50, fld_font.GetHeight(e.Graphics))
        'e.Graphics.DrawRectangle(Pens.Blue, rectSpace1)

        '' Contact1
        Dim rectC1 As New System.Drawing.Rectangle(e.MarginBounds.Left + 20, e.MarginBounds.Top + hdr_font.GetHeight(e.Graphics) + (fld_font.GetHeight(e.Graphics) * 2) + 5, 175, fld_font.GetHeight(e.Graphics))
        'e.Graphics.DrawRectangle(Pens.Blue, rectC1)
        e.Graphics.DrawString("Contact 1: ", fld_font, Brushes.Black, rectC1)

        Dim rectC1Val As New System.Drawing.Rectangle(e.MarginBounds.Left + 20 + 185, e.MarginBounds.Top + hdr_font.GetHeight(e.Graphics) + (fld_font.GetHeight(e.Graphics) * 2) + 5, 175, fld_font.GetHeight(e.Graphics))
        'e.Graphics.DrawRectangle(Pens.Blue, rectC1Val)
        e.Graphics.DrawString(CurrentLead.Contact1FName & " " & CurrentLead.Contact1LName, nfo_font, Brushes.Black, rectC1Val)

        '' formatting spacer 2
        Dim rectSpace2 As New System.Drawing.Rectangle(e.MarginBounds.Left + 20, e.MarginBounds.Top + hdr_font.GetHeight(e.Graphics) + (fld_font.GetHeight(e.Graphics) * 3) + 10, 50, fld_font.GetHeight(e.Graphics))
        'e.Graphics.DrawRectangle(Pens.Blue, rectSpace2)

        '' Contact2
        Dim rectC2 As New System.Drawing.Rectangle(e.MarginBounds.Left + 20, e.MarginBounds.Top + hdr_font.GetHeight(e.Graphics) + (fld_font.GetHeight(e.Graphics) * 4) + 15, 175, fld_font.GetHeight(e.Graphics))
        'e.Graphics.DrawRectangle(Pens.Blue, rectC2)
        e.Graphics.DrawString("Contact 2: ", fld_font, Brushes.Black, rectC2)

        Dim rectC2Val As New System.Drawing.Rectangle(e.MarginBounds.Left + 20 + 185, e.MarginBounds.Top + hdr_font.GetHeight(e.Graphics) + (fld_font.GetHeight(e.Graphics) * 4) + 15, 175, fld_font.GetHeight(e.Graphics))
        'e.Graphics.DrawRectangle(Pens.Blue, rectC2Val)
        e.Graphics.DrawString(CurrentLead.Contact2FName & " " & CurrentLead.Contact2LName, nfo_font, Brushes.Black, rectC2Val)

        '' formatting spacer 3
        Dim rectSpace3 As New System.Drawing.Rectangle(e.MarginBounds.Left + 20, e.MarginBounds.Top + hdr_font.GetHeight(e.Graphics) + (fld_font.GetHeight(e.Graphics) * 5) + 20, 50, fld_font.GetHeight(e.Graphics))
        'e.Graphics.DrawRectangle(Pens.Blue, rectSpace3)

        '' stAddress
        Dim rectSTA As New System.Drawing.Rectangle(e.MarginBounds.Left + 20, e.MarginBounds.Top + hdr_font.GetHeight(e.Graphics) + (fld_font.GetHeight(e.Graphics) * 6) + 25, 175, fld_font.GetHeight(e.Graphics))
        ' e.Graphics.DrawRectangle(Pens.Blue, rectSTA)
        e.Graphics.DrawString("Address: ", fld_font, Brushes.Black, rectSTA)

        Dim rectSTA2 As New System.Drawing.Rectangle(e.MarginBounds.Left + 20 + 185, e.MarginBounds.Top + hdr_font.GetHeight(e.Graphics) + (fld_font.GetHeight(e.Graphics) * 6) + 25, 225, fld_font.GetHeight(e.Graphics) * 2)
        'e.Graphics.DrawRectangle(Pens.Blue, rectSTA2)
        e.Graphics.DrawString(CurrentLead.StAddress & vbCrLf & CurrentLead.City & "," & CurrentLead.State & " " & CurrentLead.Zip, nfo_font, Brushes.Black, rectSTA2)

        '' formatting spacer 4
        Dim rectSpace4 As New System.Drawing.Rectangle(e.MarginBounds.Left + 20, e.MarginBounds.Top + hdr_font.GetHeight(e.Graphics) + (fld_font.GetHeight(e.Graphics) * 8) + 35, 50, fld_font.GetHeight(e.Graphics))
        'e.Graphics.DrawRectangle(Pens.Blue, rectSpace4)

        '' work hours
        Dim rectWH As New System.Drawing.Rectangle(e.MarginBounds.Left + 20, e.MarginBounds.Top + hdr_font.GetHeight(e.Graphics) + (fld_font.GetHeight(e.Graphics) * 9) + 40, 175, fld_font.GetHeight(e.Graphics))
        'e.Graphics.DrawRectangle(Pens.Blue, rectWH)
        e.Graphics.DrawString("Work Hours: ", fld_font, Brushes.Black, rectWH)

        Dim rectWHVal As New System.Drawing.Rectangle(e.MarginBounds.Left + 20 + 185, e.MarginBounds.Top + hdr_font.GetHeight(e.Graphics) + (fld_font.GetHeight(e.Graphics) * 9) + 40, 175, fld_font.GetHeight(e.Graphics))
        'e.Graphics.DrawRectangle(Pens.Blue, rectWHVal)
        e.Graphics.DrawString(CurrentLead.ContactWorkHours, nfo_font, Brushes.Black, rectWHVal)

        '' formatting spacer 5
        Dim rectSpace5 As New System.Drawing.Rectangle(e.MarginBounds.Left + 20, e.MarginBounds.Top + hdr_font.GetHeight(e.Graphics) + (fld_font.GetHeight(e.Graphics) * 10) + 45, 50, fld_font.GetHeight(e.Graphics))
        'e.Graphics.DrawRectangle(Pens.Blue, rectSpace5)

        '' phone numbers
        Dim rectPH As New System.Drawing.Rectangle(e.MarginBounds.Left + 20, e.MarginBounds.Top + hdr_font.GetHeight(e.Graphics) + (fld_font.GetHeight(e.Graphics) * 11) + 50, 175, fld_font.GetHeight(e.Graphics))
        'e.Graphics.DrawRectangle(Pens.Blue, rectPH)
        e.Graphics.DrawString("Phone(s): ", fld_font, Brushes.Black, rectPH)

        Dim rectPHVal As New System.Drawing.Rectangle(e.MarginBounds.Left + 20 + 185, e.MarginBounds.Top + hdr_font.GetHeight(e.Graphics) + (fld_font.GetHeight(e.Graphics) * 11) + 50, 175, fld_font.GetHeight(e.Graphics) * 3)
        'e.Graphics.DrawRectangle(Pens.Blue, rectPHVal)
        e.Graphics.DrawString(CurrentLead.HousePhone & vbCrLf & CurrentLead.AltPhone1 & vbCrLf & CurrentLead.AltPhone2, nfo_font, Brushes.Black, rectPHVal)

        '' formatting spacer 6
        Dim rectSpace6 As New System.Drawing.Rectangle(e.MarginBounds.Left + 20, e.MarginBounds.Top + hdr_font.GetHeight(e.Graphics) + (fld_font.GetHeight(e.Graphics) * 14) + 60, 50, fld_font.GetHeight(e.Graphics))
        'e.Graphics.DrawRectangle(Pens.Blue, rectSpace6)

        '' email 
        Dim rectEM As New System.Drawing.Rectangle(e.MarginBounds.Left + 20, e.MarginBounds.Top + hdr_font.GetHeight(e.Graphics) + (fld_font.GetHeight(e.Graphics) * 15) + 65, 175, fld_font.GetHeight(e.Graphics))
        'e.Graphics.DrawRectangle(Pens.Blue, rectEM)
        e.Graphics.DrawString("Email: ", fld_font, Brushes.Black, rectEM)

        Dim rectEMVal As New System.Drawing.Rectangle(e.MarginBounds.Left + 20 + 185, e.MarginBounds.Top + hdr_font.GetHeight(e.Graphics) + (fld_font.GetHeight(e.Graphics) * 15) + 65, 325, fld_font.GetHeight(e.Graphics))
        'e.Graphics.DrawRectangle(Pens.Blue, rectEMVal)
        e.Graphics.DrawString(CurrentLead.EmailAddress, nfo_font, Brushes.Black, rectEMVal)

    End Sub


End Class
