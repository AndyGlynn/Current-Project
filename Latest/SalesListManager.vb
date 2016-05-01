Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System
Public Class SalesListManager



    Private lvSalesCnt As Integer = 0
    Public ReadOnly Property LV_Sales_Cnt As Integer
        Get
            Return lvSalesCnt
        End Get
    End Property

    Private _arLVSalesItems As ArrayList
    Public ReadOnly Property LV_Sales_Items As ArrayList
        Get
            Return _arLVSalesItems
        End Get
    End Property



    Private Sub Count()
        Try
            Dim PLS As String = Sales.PLS
            Dim SLS As String = Sales.SLS
            Dim Rep As String = Sales.Rep
            Dim Product As String = Sales.Product
            Dim City As String
            Dim State As String
            Dim Date1 As String
            Dim Date2 As String
            If Sales.txt1CustomerList.Text = "" And Sales.txt2CustomerList.Text = "" Then
                Date1 = "1/1/1900 12:00 AM"
                Date2 = "1/1/2100 12:00 AM"
            ElseIf Sales.txt1CustomerList.Text <> "" And Sales.txt2CustomerList.Text = "" Then
                Date1 = Sales.txt1CustomerList.Text & " 12:00 AM"
                Date2 = "1/1/2100 12:00 AM"
            ElseIf Sales.txt1CustomerList.Text = "" And Sales.txt2CustomerList.Text <> "" Then
                Date1 = "1/1/1900 12:00 AM"
                Date2 = Sales.txt2CustomerList.Text & " 12:00 AM"
            Else
                Date1 = Sales.txt1CustomerList.Text & " 12:00 AM"
                Date2 = Sales.txt2CustomerList.Text & " 12:00 AM"
            End If
            Date1 = CDate(Date1)
            Date2 = CDate(Date2)
            If PLS = "" Then
                PLS = "%"
            End If
            If SLS = "" Then
                SLS = "%"
            End If
            If Rep = "" Then
                Rep = "%"
            End If
            If Product = "" Then
                Product = "%"
            End If
            If Sales.CityState <> "" Then
                Dim x = Split(Sales.CityState, ", ", 2)
                City = x(0)
                State = x(1)
            Else
                City = "%"
                State = "%"
            End If
            Dim param1 As SqlParameter = New SqlParameter("@PLS", PLS)
            Dim param2 As SqlParameter = New SqlParameter("@SLS", SLS)
            Dim param3 As SqlParameter = New SqlParameter("@Date1", Date1)
            Dim param4 As SqlParameter = New SqlParameter("@Date2", Date2)
            Dim param5 As SqlParameter = New SqlParameter("@List", Sales.cboSalesList.Text)
            Dim param6 As SqlParameter = New SqlParameter("@Rep", Rep)
            Dim param7 As SqlParameter = New SqlParameter("@R1", Sales.R1)
            Dim param8 As SqlParameter = New SqlParameter("@R2", Sales.R2)
            Dim param9 As SqlParameter = New SqlParameter("@R3", Sales.R3)
            Dim param10 As SqlParameter = New SqlParameter("@R4", Sales.R4)
            Dim param11 As SqlParameter = New SqlParameter("@R5", Sales.R5)
            Dim param12 As SqlParameter = New SqlParameter("@R6", Sales.R6)
            Dim param13 As SqlParameter = New SqlParameter("@R7", Sales.R7)
            Dim param14 As SqlParameter = New SqlParameter("@Product", Product)
            Dim param15 As SqlParameter = New SqlParameter("@City", City)
            Dim param16 As SqlParameter = New SqlParameter("@State", State)
            Dim param17 As SqlParameter = New SqlParameter("@Recovery", Sales.Recovery)
            Dim param18 As SqlParameter = New SqlParameter("@R8", Sales.R8)
            Dim cnn As SqlConnection = New SqlConnection(STATIC_VARIABLES.Cnn)
            Dim cmdGet As SqlCommand
            Dim r As SqlDataReader
            cmdGet = New SqlCommand("dbo.SalesDepartment", cnn)
            cmdGet.CommandType = CommandType.StoredProcedure
            cmdGet.Parameters.Add(param1)
            cmdGet.Parameters.Add(param2)
            cmdGet.Parameters.Add(param3)
            cmdGet.Parameters.Add(param4)
            cmdGet.Parameters.Add(param5)
            cmdGet.Parameters.Add(param6)
            cmdGet.Parameters.Add(param7)
            cmdGet.Parameters.Add(param8)
            cmdGet.Parameters.Add(param9)
            cmdGet.Parameters.Add(param10)
            cmdGet.Parameters.Add(param11)
            cmdGet.Parameters.Add(param12)
            cmdGet.Parameters.Add(param13)
            cmdGet.Parameters.Add(param14)
            cmdGet.Parameters.Add(param15)
            cmdGet.Parameters.Add(param16)
            cmdGet.Parameters.Add(param17)
            cmdGet.Parameters.Add(param18)
            cnn.Open()
            r = cmdGet.ExecuteReader(CommandBehavior.CloseConnection)
            Dim cnt As Integer = 0
            r.Read()
            Try
                Dim Cntres As String = r.Item(0)
                If Cntres = "" Then
                    lvSalesCnt = 0
                ElseIf Cntres = " " Then
                    lvSalesCnt = 0
                ElseIf Len(Cntres) <= -0 Then
                    lvSalesCnt = 0
                ElseIf Cntres Is Nothing Then
                    lvSalesCnt = 0
                Else
                    lvSalesCnt = r.Item(0)
                End If

            Catch ex As Exception
                Sales.Cursor = Cursors.Default
                lvSalesCnt = 0
            End Try

            If lvSalesCnt >= 500 Then
                While r.Read
                    cnt += 1
                End While

                lvSalesCnt = cnt

                If cnt >= 750 Then
                    ''progressbar class
                    frmGenericPBar.ProgressBar1.Minimum = 1
                    frmGenericPBar.ProgressBar1.Maximum = cnt
                    frmGenericPBar.lblMax.Text = cnt.ToString
                End If
            End If
            r.Close()
            cnn.Close()
            cnn = Nothing
            Sales.Cursor = Cursors.Default
        Catch ex As Exception
            lvSalesCnt = 0
            Sales.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "SalesListManager", "SalesListManager", "Sub", "Count()", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub
    Public Sub New()
        'Dim type = sender.GetType
        'MsgBox("Sender: " & sender.ToString, MsgBoxStyle.Information, "DEBUG INFO")
        'Application.DoEvents()

        ''
        Try
            Count()
            Dim Itemcnt As Integer = lvSalesCnt
            If Itemcnt >= 750 Then
                frmGenericPBar.MdiParent = Main
                frmGenericPBar.TopMost = True
                frmGenericPBar.Show()
            Else
                '' carry on.
            End If

            Dim arItems As New ArrayList
            '' 

            Sales.lvSales.Groups.Clear()
            If Sales.cboGroupSales.Text <> "" Then
                Me.Groupby()
            End If
            Sales.lvSales.Items.Clear()

            Dim lvCol As New ListView.ListViewItemCollection(Sales.lvSales)

            Dim PLS As String = Sales.PLS
            Dim SLS As String = Sales.SLS
            Dim Rep As String = Sales.Rep
            Dim Product As String = Sales.Product
            Dim City As String
            Dim State As String
            Dim Date1 As String
            Dim Date2 As String
            If Sales.txt1CustomerList.Text = "" And Sales.txt2CustomerList.Text = "" Then
                Date1 = "1/1/1900 12:00 AM"
                Date2 = "1/1/2100 12:00 AM"
            ElseIf Sales.txt1CustomerList.Text <> "" And Sales.txt2CustomerList.Text = "" Then
                Date1 = Sales.txt1CustomerList.Text & " 12:00 AM"
                Date2 = "1/1/2100 12:00 AM"
            ElseIf Sales.txt1CustomerList.Text = "" And Sales.txt2CustomerList.Text <> "" Then
                Date1 = "1/1/1900 12:00 AM"
                Date2 = Sales.txt2CustomerList.Text & " 12:00 AM"
            Else
                Date1 = Sales.txt1CustomerList.Text & " 12:00 AM"
                Date2 = Sales.txt2CustomerList.Text & " 12:00 AM"
            End If
            Date1 = CDate(Date1)
            Date2 = CDate(Date2)
            If PLS = "" Then
                PLS = "%"
            End If
            If SLS = "" Then
                SLS = "%"
            End If
            If Rep = "" Then
                Rep = "%"
            End If
            If Product = "" Then
                Product = "%"
            End If
            If Sales.CityState <> "" Then
                Dim x = Split(Sales.CityState, ", ", 2)
                City = x(0)
                State = x(1)
            Else
                City = "%"
                State = "%"
            End If
            Dim param1 As SqlParameter = New SqlParameter("@PLS", PLS)
            Dim param2 As SqlParameter = New SqlParameter("@SLS", SLS)
            Dim param3 As SqlParameter = New SqlParameter("@Date1", Date1)
            Dim param4 As SqlParameter = New SqlParameter("@Date2", Date2)
            Dim param5 As SqlParameter = New SqlParameter("@List", Sales.cboSalesList.Text)
            Dim param6 As SqlParameter = New SqlParameter("@Rep", Rep)
            Dim param7 As SqlParameter = New SqlParameter("@R1", Sales.R1)
            Dim param8 As SqlParameter = New SqlParameter("@R2", Sales.R2)
            Dim param9 As SqlParameter = New SqlParameter("@R3", Sales.R3)
            Dim param10 As SqlParameter = New SqlParameter("@R4", Sales.R4)
            Dim param11 As SqlParameter = New SqlParameter("@R5", Sales.R5)
            Dim param12 As SqlParameter = New SqlParameter("@R6", Sales.R6)
            Dim param13 As SqlParameter = New SqlParameter("@R7", Sales.R7)
            Dim param14 As SqlParameter = New SqlParameter("@Product", Product)
            Dim param15 As SqlParameter = New SqlParameter("@City", City)
            Dim param16 As SqlParameter = New SqlParameter("@State", State)
            Dim param17 As SqlParameter = New SqlParameter("@Recovery", Sales.Recovery)
            Dim param18 As SqlParameter = New SqlParameter("@R8", Sales.R8)
            Dim cnn As SqlConnection = New SqlConnection(STATIC_VARIABLES.Cnn)
            Dim cmdGet As SqlCommand
            Dim r As SqlDataReader
            cmdGet = New SqlCommand("dbo.SalesDepartment", cnn)
            cmdGet.CommandType = CommandType.StoredProcedure
            cmdGet.Parameters.Add(param1)
            cmdGet.Parameters.Add(param2)
            cmdGet.Parameters.Add(param3)
            cmdGet.Parameters.Add(param4)
            cmdGet.Parameters.Add(param5)
            cmdGet.Parameters.Add(param6)
            cmdGet.Parameters.Add(param7)
            cmdGet.Parameters.Add(param8)
            cmdGet.Parameters.Add(param9)
            cmdGet.Parameters.Add(param10)
            cmdGet.Parameters.Add(param11)
            cmdGet.Parameters.Add(param12)
            cmdGet.Parameters.Add(param13)
            cmdGet.Parameters.Add(param14)
            cmdGet.Parameters.Add(param15)
            cmdGet.Parameters.Add(param16)
            cmdGet.Parameters.Add(param17)
            cmdGet.Parameters.Add(param18)
            cnn.Open()
            r = cmdGet.ExecuteReader(CommandBehavior.CloseConnection)
            Dim cnt As Integer = 0
            Dim cntRecs As Integer = 0
            Dim id As String = ""
            While r.Read
                cntRecs += 1
                If lvSalesCnt >= 750 Then
                    If cntRecs < lvSalesCnt Then
                        frmGenericPBar.Cursor = Cursors.WaitCursor
                        frmGenericPBar.ProgressBar1.Increment(1)
                        frmGenericPBar.lblCurrent.Text = cntRecs.ToString
                        Application.DoEvents()
                    ElseIf cntRecs = lvSalesCnt Then
                        Main.Cursor = Cursors.Default
                        Sales.Cursor = Cursors.Default
                        frmGenericPBar.Cursor = Cursors.Default
                        frmGenericPBar.Close()
                    End If
                Else
                    ''carry on.
                End If
                id = r.Item(0)
                Dim lv As New ListViewItem
                lv.Name = r.Item(0)
                lv.Text = r.Item(0)
                If r.Item(3) = "" And r.Item(4) = "" Then
                    lv.SubItems.Add(r.Item(2) & ", " & r.Item(1))
                ElseIf r.Item(3) <> "" And r.Item(4) <> "" And r.Item(2) = r.Item(4) Then
                    lv.SubItems.Add(r.Item(2) & ", " & r.Item(1) & " & " & r.Item(3))
                ElseIf r.Item(3) <> "" And r.Item(4) <> "" And r.Item(2) <> r.Item(4) Then
                    lv.SubItems.Add(r.Item(2) & ", " & r.Item(1) & " & " & r.Item(4) & ", " & r.Item(3))
                End If
                lv.SubItems.Add(r.Item(5) & " " & r.Item(6) & ", " & r.Item(7) & " " & r.Item(8))
                lv.SubItems.Add(r.Item(17))
                If r.Item(10) = "" And r.Item(11) = "" Then
                    lv.SubItems.Add(r.Item(9))
                ElseIf r.Item(10) <> "" And r.Item(11) = "" Then
                    lv.SubItems.Add(r.Item(9) & " - " & r.Item(10))
                ElseIf r.Item(10) = "" And r.Item(11) <> "" Then
                    lv.SubItems.Add(r.Item(9) & " - " & r.Item(11))
                ElseIf r.Item(10) <> "" And r.Item(11) <> "" Then
                    lv.SubItems.Add(r.Item(9) & " - " & r.Item(10) & " - " & r.Item(11))
                End If
                Dim u As String = r.Item(16).ToString
                Dim w = InStr(u, " ")
                u = Microsoft.VisualBasic.Right(u, w + 2)
                Trim(u)
                Dim u2 As String
                Dim u3 As String
                If u.Length = 11 Then
                    u2 = Microsoft.VisualBasic.Left(u, 5)
                    u3 = Microsoft.VisualBasic.Right(u, 3)
                    u = u2 & u3
                Else
                    u2 = Microsoft.VisualBasic.Left(u, 4)
                    u3 = Microsoft.VisualBasic.Right(u, 3)
                    u = u2 & u3
                End If
                Dim ApptTime As String = u
                Dim ApptDate As Date = r.Item(15)
                ApptDate.ToShortDateString()
                lv.SubItems.Add(ApptDate & " - " & ApptTime)
                Dim Rep1 As String
                Dim Rep2 As String
                Try
                    Rep1 = r.Item(18)
                Catch ex As Exception
                    Rep1 = ""
                End Try
                Try
                    Rep2 = r.Item(19)
                Catch ex As Exception
                    Rep2 = ""
                End Try
                If Rep1 <> "" And Rep2 <> "" Then
                    lv.SubItems.Add(Rep1 & " - " & Rep2)
                ElseIf Rep1 <> "" And Rep2 = "" Then
                    lv.SubItems.Add(Rep1)
                ElseIf Rep1 = "" And Rep2 <> "" Then
                    lv.SubItems.Add(Rep2)
                ElseIf Rep1 = "" And Rep2 = "" Then
                    lv.SubItems.Add("")
                End If
                If Sales.cboGroupSales.Text = "Primary Product" Then
                    lv.Group = Sales.lvSales.Groups(r.Item(9))
                ElseIf Sales.cboGroupSales.Text = "Appt. Date" Then
                    lv.Group = Sales.lvSales.Groups(ApptDate)
                ElseIf Sales.cboGroupSales.Text = "Sales Result" Then
                    If Trim(r.Item(21)) = "" Then
                        Sales.lvSales.Groups.Add("No Result", "No Result")
                        lv.Group = Sales.lvSales.Groups("No Result")
                    Else
                        lv.Group = Sales.lvSales.Groups(r.Item(21))
                    End If
                ElseIf Sales.cboGroupSales.Text = "Marketing Result" Then
                    If Trim(r.Item(22)) = "" Then
                        Sales.lvSales.Groups.Add("No Result", "No Result")
                        lv.Group = Sales.lvSales.Groups("No Result")
                    Else
                        lv.Group = Sales.lvSales.Groups(r.Item(22))
                    End If
                ElseIf Sales.cboGroupSales.Text = "Sales Rep" Then
                    If Trim(r.Item(18)) = "" Then
                        Sales.lvSales.Groups.Add("No Sales Rep Assigned", "No Sales Rep Assigned")
                        lv.Group = Sales.lvSales.Groups("No Sales Rep Assigned")
                    Else
                        lv.Group = Sales.lvSales.Groups(r.Item(18))
                    End If
                ElseIf Sales.cboGroupSales.Text = "City, State" Then
                    lv.Group = Sales.lvSales.Groups(r.Item(6) & ", " & r.Item(7))
                ElseIf Sales.cboGroupSales.Text = "Zip Code" Then
                    If Trim(r.Item(8)) = "" Then
                        Sales.lvSales.Groups.Add("No Zip Code", "No Zip Code")
                        lv.Group = Sales.lvSales.Groups("No Zip Code")
                    Else
                        lv.Group = Sales.lvSales.Groups(r.Item(8))
                    End If
                End If
                lv.SubItems.Add(r.Item(20))
                ' Sales.lvSales.Items.Add(lv)
                lvCol.Add(lv)

                ' arItems.Add(lv)

                If lv.Text = Sales.ID Then
                    lv.Selected = True
                    lv.EnsureVisible()
                End If
                ' Application.DoEvents()
                id = ""
            End While

            Itemcnt = arItems.Count
            Me.lvSalesCnt = Itemcnt
            'Me._arLVSalesItems = arItems
            r.Close()
            cnn.Close()
            'Itemcnt = arItems.Count
            'Sales.lvSales.VirtualMode = True
            Sales.lvSales.View = View.Details
            'Sales.lvSales.VirtualListSize = Itemcnt
            Main.tsProgress.Minimum = 0
            If Itemcnt <= 0 Then
                Main.tsProgress.Maximum = 1
            Else
                Main.tsProgress.Maximum = Itemcnt
            End If
            Main.tsProgress.Value = 1
            Dim ii As Integer
            For ii = 0 To Itemcnt
                Main.tsProgress.Increment(1)
            Next
            'Sales.arItemCache = arItems
            Sales.lblCntFiltered.Text = cntRecs.ToString

            If Sales.lvSales.SelectedItems.Count = 0 And Sales.lvSales.Items.Count <> 0 Then
                Sales.lvSales.TopItem.Selected = True
                Sales.ID = Sales.lvSales.SelectedItems(0).Text
                STATIC_VARIABLES.CurrentID = Sales.ID
            End If


            If Sales.lvSales.Items.Count = 0 Then
                Sales.PullInfo("")
                Sales.ID = ""
                STATIC_VARIABLES.CurrentID = Sales.ID
            End If
            Sales.LastD1 = Date1
            Sales.LastD2 = Date2


            '' now get default top item for Static_Variables.ID
            '' 
            'If Sales.lvSales.Items.Count > 0 Then
            '    Dim lv As New ListViewItem
            '    lv = Sales.lvSales.Items.Item(0)
            '    STATIC_VARIABLES.CurrentID = lv.Text.ToString
            '    lv = Nothing
            'Else
            '    '' just trap it. 
            'End If

            Sales.Cursor = Cursors.Default

        Catch ex As Exception
            Sales.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "SalesListManager", "SalesListManager", "Constructor", "New()", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub
    Private Sub Groupby()
        Try
            Dim PLS As String = Sales.PLS
            Dim SLS As String = Sales.SLS
            Dim Rep As String = Sales.Rep
            Dim Product As String = Sales.Product
            Dim City As String
            Dim State As String
            Dim Date1 As String
            Dim Date2 As String
            If Sales.txt1CustomerList.Text = "" And Sales.txt2CustomerList.Text = "" Then
                Date1 = "1/1/1900 12:00 AM"
                Date2 = "1/1/2100 12:00 AM"
            ElseIf Sales.txt1CustomerList.Text <> "" And Sales.txt2CustomerList.Text = "" Then
                Date1 = Sales.txt1CustomerList.Text & " 12:00 AM"
                Date2 = "1/1/2100 12:00 AM"
            ElseIf Sales.txt1CustomerList.Text = "" And Sales.txt2CustomerList.Text <> "" Then
                Date1 = "1/1/1900 12:00 AM"
                Date2 = Sales.txt2CustomerList.Text & " 12:00 AM"
            Else
                Date1 = Sales.txt1CustomerList.Text & " 12:00 AM"
                Date2 = Sales.txt2CustomerList.Text & " 12:00 AM"
            End If
            Date1 = CDate(Date1)
            Date2 = CDate(Date2)
            If PLS = "" Then
                PLS = "%"
            End If
            If SLS = "" Then
                SLS = "%"
            End If
            If Rep = "" Then
                Rep = "%"
            End If
            If Product = "" Then
                Product = "%"
            End If

            If Sales.CityState <> "" Then
                Dim x = Split(Sales.CityState, ", ", 2)
                City = x(0)
                State = x(1)
            Else
                City = "%"
                State = "%"
            End If
            Dim param1 As SqlParameter = New SqlParameter("@PLS", PLS)
            Dim param2 As SqlParameter = New SqlParameter("@SLS", SLS)
            Dim param3 As SqlParameter = New SqlParameter("@Date1", Date1)
            Dim param4 As SqlParameter = New SqlParameter("@Date2", Date2)
            Dim param5 As SqlParameter = New SqlParameter("@List", Sales.cboSalesList.Text)
            Dim param6 As SqlParameter = New SqlParameter("@Rep", Rep)
            Dim param7 As SqlParameter = New SqlParameter("@R1", Sales.R1)
            Dim param8 As SqlParameter = New SqlParameter("@R2", Sales.R2)
            Dim param9 As SqlParameter = New SqlParameter("@R3", Sales.R3)
            Dim param10 As SqlParameter = New SqlParameter("@R4", Sales.R4)
            Dim param11 As SqlParameter = New SqlParameter("@R5", Sales.R5)
            Dim param12 As SqlParameter = New SqlParameter("@R6", Sales.R6)
            Dim param13 As SqlParameter = New SqlParameter("@R7", Sales.R7)
            Dim param14 As SqlParameter = New SqlParameter("@Product", Product)
            Dim param15 As SqlParameter = New SqlParameter("@City", City)
            Dim param16 As SqlParameter = New SqlParameter("@State", State)
            Dim param17 As SqlParameter = New SqlParameter("@Recovery", Sales.Recovery)
            Dim param18 As SqlParameter = New SqlParameter("@Group", Sales.cboGroupSales.Text)
            Dim param19 As SqlParameter = New SqlParameter("@R8", Sales.R8)
            Dim cnn As SqlConnection = New SqlConnection(STATIC_VARIABLES.Cnn)
            Dim cmdGet As SqlCommand
            Dim r As SqlDataReader
            cmdGet = New SqlCommand("dbo.SalesDepartmentGroups", cnn)
            cmdGet.CommandType = CommandType.StoredProcedure
            cmdGet.Parameters.Add(param1)
            cmdGet.Parameters.Add(param2)
            cmdGet.Parameters.Add(param3)
            cmdGet.Parameters.Add(param4)
            cmdGet.Parameters.Add(param5)
            cmdGet.Parameters.Add(param6)
            cmdGet.Parameters.Add(param7)
            cmdGet.Parameters.Add(param8)
            cmdGet.Parameters.Add(param9)
            cmdGet.Parameters.Add(param10)
            cmdGet.Parameters.Add(param11)
            cmdGet.Parameters.Add(param12)
            cmdGet.Parameters.Add(param13)
            cmdGet.Parameters.Add(param14)
            cmdGet.Parameters.Add(param15)
            cmdGet.Parameters.Add(param16)
            cmdGet.Parameters.Add(param17)
            cmdGet.Parameters.Add(param18)
            cmdGet.Parameters.Add(param19)
            cnn.Open()
            r = cmdGet.ExecuteReader(CommandBehavior.CloseConnection)
            While r.Read
                Sales.lvSales.Groups.Add(r.Item(0), r.Item(0))
            End While
            r.Close()
            cnn.Close()
        Catch ex As Exception

            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "SalesListManager", "SalesListManager", "Sub", "GroupBy()", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub
End Class
