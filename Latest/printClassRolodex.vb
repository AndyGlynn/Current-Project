Imports System.IO
Imports System.Text
Imports System.IO.FileInfo
Imports System.IO.DirectoryInfo
Imports System.IO.StreamReader
Imports System.IO.StreamWriter
Imports System.Drawing.Printing



Public Class printClassRolodex
    Private pprev As PrintPreviewDialog
    Private p_fontHDR As New System.Drawing.Font("Trebuchet MS", 12, FontStyle.Regular)
    Private p_fontItem As New System.Drawing.Font("Trebuchet MS", 10, FontStyle.Regular)
    Private PD As PrintDocument
    Private printableList As List(Of Rolodex_Logic_V2.EmployeeOBJ)

    Public Sub New(ByVal ListToPrint As List(Of Rolodex_Logic_V2.EmployeeOBJ))
        Try
            pprev = New PrintPreviewDialog
            PD = New PrintDocument
            printableList = ListToPrint
            AddHandler PD.PrintPage, AddressOf PD_PrintPage
            PD.DefaultPageSettings.Landscape = False
            With PD.DefaultPageSettings.Margins
                .Top = 0.25
                .Bottom = 0.25
                .Left = 0.25
                .Right = 0.25
            End With
            pprev.Document = PD
            pprev.ClientSize = New System.Drawing.Size(700, 700)
            pprev.ShowDialog()
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "printClassRolodex", "printClassRolodex", "Constructor", "New(listtoprint)", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub PD_PrintPage(ByVal sender As Object, e As PrintPageEventArgs)
        Try
            Dim linesPerPage As Integer = 0
            Dim numPages As Integer = 0
            Dim cnt As Integer = 0

            linesPerPage = (e.PageBounds.Height / p_fontItem.GetHeight(e.Graphics))
            Dim font_height As Integer = CInt(p_fontItem.GetHeight(e.Graphics))


            For Each x As Rolodex_Logic_V2.EmployeeOBJ In printableList
                cnt += 1
                Dim yPos As New System.Drawing.Point(e.MarginBounds.Left + 5, (cnt * font_height) + 5)
                e.Graphics.DrawString(x.Department & " - " & x.FirstName & " " & x.LastName & " " & x.Phone1 & " " & x.Phone1Type & " " & x.ContactEmail1 & " " & x.ContactEmailCompany, p_fontItem, Brushes.Black, yPos)
            Next

            e.HasMorePages = False
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "printClassRolodex", "printClassRolodex", "Event", "PD_PrintPage()", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub
End Class

