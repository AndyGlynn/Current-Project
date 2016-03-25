Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class frmWCList

#Region "Locally Scoped Vars"

    Private lstMarketers As List(Of GetMarketers.Marketer)
    Private lsProducts As List(Of GetProducts.Product)

    Private Criteria As String = ""

    Private selectedTab_IDX As Integer = 0

#End Region


    Private Sub frmWCList_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        ResetForm()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.ResetForm()
        Me.Close()
    End Sub

    Private Sub btnRecordCount_Click(sender As Object, e As EventArgs) Handles btnRecordCount.Click
        Dim z As New CountRecords(Me.Criteria.ToString)
        Me.txtRecordCount.Text = z.cnt_records.ToString
        z = Nothing
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Me.ResetForm()
    End Sub

#Region "Form Load Events and Stuffs"
    Private Sub frmWCList_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        '' get products and marketers for init pop of criteria lists
        '' 

        lstMarketers = New List(Of GetMarketers.Marketer)
        lsProducts = New List(Of GetProducts.Product)

        Dim b As New GetMarketers
        lstMarketers = b.lstMark
        Dim c As New GetProducts
        lsProducts = c.lstProducts

        '' now pop lists/chklists
        '' 

        For Each y As GetMarketers.Marketer In lstMarketers
            chlstMarketers.Items.Add(y.fname & " " & y.lname, False)
        Next

        For Each z As GetProducts.Product In lsProducts
            chlstProducts.Items.Add(z.PName, False)
        Next

        Dim d As New GetStates
        Dim arStates As New ArrayList
        arStates = d.lstStates
        For Each zz As String In arStates
            Me.cboStateSelection.Items.Add(zz)
        Next

        Me.dpGenerated.Value = Date.Today
        Me.tpFrom.Value = ("1/1/1900 " & Date.Now.Hour & ":00")
        Me.tpTo.Value = ("1/1/1900 " & Date.Now.Hour & ":00")
        Me.dpFrom.Value = Date.Today.ToShortDateString
        Me.dpTo.Value = Date.Today.ToShortDateString

        Me.cboDateRange.Items.AddRange(New Object() {"All", "Today", "Yesterday", "This Week", "This Week - to date", "This Month", "This Month - to date", "This Year", "This Year - to date", "Next Week", "Next Month", "Last Week", "Last Week - to date", "Last Month", "Last Month - to date", "Last Year", "Last Year - to date", "Custom"})



    End Sub
#End Region

#Region "Marketer Check / Uncheck"

    Private Sub checkMarketers_Click(sender As Object, e As EventArgs) Handles checkMarketers.Click
        '' check them all
        Dim c As Object
        Dim arIDX As New ArrayList
        For Each c In Me.chlstMarketers.Items
            Dim idx As Integer = Me.chlstMarketers.Items.IndexOf(c)
            arIDX.Add(idx)
        Next
        For Each zz As Integer In arIDX
            Me.chlstMarketers.SetItemCheckState(zz, CheckState.Checked)
        Next
    End Sub

    Private Sub uncheckMarketers_Click(sender As Object, e As EventArgs) Handles uncheckMarketers.Click
        '' un-check them all
        Dim c As Object
        Dim arIDX As New ArrayList
        For Each c In Me.chlstMarketers.Items
            Dim idx As Integer = Me.chlstMarketers.Items.IndexOf(c)
            arIDX.Add(idx)
        Next
        For Each zz As Integer In arIDX
            Me.chlstMarketers.SetItemCheckState(zz, CheckState.Unchecked)
        Next
    End Sub

#End Region

#Region "Products Check/Uncheck"
    Private Sub btnCheckProducts_Click(sender As Object, e As EventArgs) Handles btnCheckProducts.Click
        '' check all / products
        Dim c As Object
        Dim arIDX As New ArrayList
        For Each c In Me.chlstProducts.Items
            Dim idx As Integer = Me.chlstProducts.Items.IndexOf(c)
            arIDX.Add(idx)
        Next
        For Each zz As Integer In arIDX
            Me.chlstProducts.SetItemCheckState(zz, CheckState.Checked)
        Next
    End Sub

    Private Sub btnUncheckProducts_Click(sender As Object, e As EventArgs) Handles btnUncheckProducts.Click
        '' uncheck all / products
        Dim c As Object
        Dim arIDX As New ArrayList
        For Each c In Me.chlstProducts.Items
            Dim idx As Integer = Me.chlstProducts.Items.IndexOf(c)
            arIDX.Add(idx)
        Next
        For Each zz As Integer In arIDX
            Me.chlstProducts.SetItemCheckState(zz, CheckState.Unchecked)
        Next
    End Sub

#End Region

#Region "Geography Check/Uncheck"

    Private Sub btnCheckZip_Click(sender As Object, e As EventArgs) Handles btnCheckZip.Click
        '' check all ZipCity
        Dim c As Object
        Dim arIDX As New ArrayList
        For Each c In Me.chlstZipCity.Items
            Dim idx As Integer = Me.chlstZipCity.Items.IndexOf(c)
            arIDX.Add(idx)
        Next
        For Each zz As Integer In arIDX
            Me.chlstZipCity.SetItemCheckState(zz, CheckState.Checked)
        Next
    End Sub

    Private Sub btnUncheckZip_Click(sender As Object, e As EventArgs) Handles btnUncheckZip.Click
        '' Uncheck all ZipCity
        Dim c As Object
        Dim arIDX As New ArrayList
        For Each c In Me.chlstZipCity.Items
            Dim idx As Integer = Me.chlstZipCity.Items.IndexOf(c)
            arIDX.Add(idx)
        Next
        For Each zz As Integer In arIDX
            Me.chlstZipCity.SetItemCheckState(zz, CheckState.Unchecked)
        Next
    End Sub
#End Region

#Region "Marketing Results - Check / Uncheck"

    Private Sub btnCheckWC_Click(sender As Object, e As EventArgs) Handles btnCheckWC.Click
        '' check them all
        Dim c As Object
        Dim arIDX As New ArrayList
        For Each c In Me.chlstWC.Items
            Dim idx As Integer = Me.chlstWC.Items.IndexOf(c)
            arIDX.Add(idx)
        Next
        For Each zz As Integer In arIDX
            Me.chlstWC.SetItemCheckState(zz, CheckState.Checked)
        Next
    End Sub

    Private Sub btnUncheckWC_Click(sender As Object, e As EventArgs) Handles btnUncheckWC.Click
        '' Uncheck them all
        Dim c As Object
        Dim arIDX As New ArrayList
        For Each c In Me.chlstWC.Items
            Dim idx As Integer = Me.chlstWC.Items.IndexOf(c)
            arIDX.Add(idx)
        Next
        For Each zz As Integer In arIDX
            Me.chlstWC.SetItemCheckState(zz, CheckState.Unchecked)
        Next
    End Sub
#End Region

#Region "Private Class - Get Marketers for Criteria List"
    Private Class GetMarketers
        Public Structure Marketer
            Public RecID As String
            Public fname As String
            Public lname As String
            Public PriLeadSource As String
            Public SecLeadSource As String
            Public MarketingManager As String
            Public Active As Boolean
        End Structure
        Public lstMark As List(Of Marketer)
        Private Const cnx As String = "SERVER=192.168.1.2;Database=ISS;User Id=sa;Password=spoken1;"
        Public Sub New()
            lstMark = New List(Of Marketer)
            lstMark = GetMarketers()
        End Sub
        Private Function GetMarketers()
            Try
                Dim cnxM As New SqlConnection(cnx)
                Dim lstMark As New List(Of Marketer)
                cnxM.Open()
                Dim cmdGET As New SqlCommand("SELECT * from MarketerPullList WHERE ACTIVE=1;", cnxM)
                Dim r1 As SqlDataReader = cmdGET.ExecuteReader
                While r1.Read
                    Dim a As New Marketer
                    a.RecID = r1.Item("ID")
                    a.fname = r1.Item("FName")
                    a.lname = r1.Item("LName")
                    a.PriLeadSource = r1.Item("PriLeadSource")
                    a.SecLeadSource = r1.Item("SecLeadSource")
                    a.MarketingManager = r1.Item("MarketingManager")
                    a.Active = r1.Item("Active")
                    lstMark.Add(a)
                End While
                r1.Close()
                cnxM.Close()
                cnxM = Nothing
                Return lstMark
            Catch ex As Exception
                Dim g As New ErrorLogging_V2
                g.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmWCList.vb", "Private-GetMarketers", "Class", "GetMarketers()", "0", ex.Message.ToString)
                g = Nothing
                Return lstMark
            End Try
        End Function
    End Class
#End Region

#Region "Private Class - GetProducts()"


    Private Class GetProducts
        Public Structure Product
            Public RecID As String
            Public PName As String
            Public PAcro As String
        End Structure
        Public lstProducts As List(Of Product)
        Private Const cnx As String = "SERVER=192.168.1.2;Database=ISS;User Id=sa;Password=spoken1;"
        Public Sub New()
            lstProducts = New List(Of Product)
            lstProducts = GetProducts()
        End Sub
        Private Function GetProducts()
            Try
                Dim cnxP As New SqlConnection(cnx)
                cnxP.Open()
                Dim cmdGET As New SqlCommand("SELECT * FROM Products ORDER BY Product ASC;", cnxP)
                Dim r1 As SqlDataReader = cmdGET.ExecuteReader
                Dim lstP As New List(Of Product)
                While r1.Read
                    Dim a As New Product
                    a.RecID = r1.Item("ID")
                    a.PName = r1.Item("Product")
                    a.PAcro = r1.Item("ProdAcronym")
                    lstP.Add(a)
                End While
                r1.Close()
                cnxP.Close()
                cnxP = Nothing
                Return lstP
            Catch ex As Exception
                Dim g As New ErrorLogging_V2
                g.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmWCList.vb", "GetProducts()", "Class", "GetProducts()", "0", ex.Message.ToString)
                g = Nothing
                Return lstProducts
            End Try
        End Function
    End Class
#End Region

#Region "Private Class - Record Count - Just Returns Count Of Records Based on Criteria"
    Private Class CountRecords
        Private Const cnx As String = "SERVER=192.168.1.2;Database=ISS;User Id=sa;Password=spoken1;"
        Public cnt_records As Integer = 0
        Public Sub New(ByVal Criteria As String)
            Try
                Dim cnxC As New SqlConnection(cnx)
                cnxC.Open()
                Dim cmdCNT As New SqlCommand("SELECT COUNT(ID) FROM EnterLead WHERE " & Criteria & ";", cnxC)
                Dim res As Integer = cmdCNT.ExecuteScalar
                cnt_records = res
                cnxC.Close()
                cnxC = Nothing
            Catch ex As Exception
                Dim g As New ErrorLogging_V2
                g.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmWCList.vb", "CountRecords", "Class", "New()", "0", ex.Message.ToString)
                g = Nothing
            End Try
        End Sub
    End Class
#End Region

#Region "Populate Unique States in CboStateSel"
    Private Class GetStates
        Private cnx As String = "SERVER=192.168.1.2;Database=ISS;User Id=sa;Password=spoken1;"
        Public lstStates As ArrayList
        Public Sub New()
            lstStates = GetUniqueStates()
        End Sub
        Private Function GetUniqueStates()
            Try
                Dim cnxC As New SqlConnection(cnx)
                cnxC.Open()
                Dim lsStates As New ArrayList
                Dim cmdGET As New SqlCommand("SELECT DISTINCT(State) FROM CityPull ORDER BY State ASC;", cnxC)
                Dim r1 As SqlDataReader = cmdGET.ExecuteReader
                While r1.Read
                    lsStates.Add(r1.Item("State"))
                End While
                r1.Close()
                cnxC.Close()
                cnxC = Nothing
                Return lsStates
            Catch ex As Exception
                Dim g As New ErrorLogging_V2
                g.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmWCList.vb", "GetStates", "Class", "GetUniqueStates", "0", ex.Message.ToString)
                g = Nothing
                Return lstStates
            End Try
        End Function
    End Class
#End Region

#Region "Universal Reset Sub"
    Private Sub ResetForm()

        selectedTab_IDX = 0

        Me.dpGenerated.Value = Date.Today
        Me.txtGenerated.Text = (Date.Today.Month & "-" & Date.Today.Day & "-" & Date.Today.Year)
        Me.tpFrom.Value = ("1/1/1900 " & Date.Now.Hour & ":00")
        Me.tpTo.Value = ("1/1/1900 " & Date.Now.Hour & ":00")

        Me.dpFrom.Value = Date.Today.ToShortDateString
        Me.txtFrom.Text = (Date.Today.Month & "-" & Date.Today.Day & "-" & Date.Today.Year)
        Me.txtTo.Text = (Date.Today.Month & "-" & Date.Today.Day & "-" & Date.Today.Year)
        Me.dpTo.Value = Date.Today.ToShortDateString

        Me.chlstMarketers.Items.Clear()
        Me.chlstProducts.Items.Clear()
        Me.lblStateSelect.Text = ""
        Me.txtRecordCount.Text = ""
        Me.chGroupBy.CheckState = CheckState.Unchecked

        Dim x As Object
        Dim idxs As New ArrayList
        For Each x In Me.chlstOrderBy.CheckedItems
            idxs.Add(Me.chlstOrderBy.CheckedItems.IndexOf(x))
        Next
        If idxs.Count >= 1 Then
            For Each zz As Integer In idxs
                Me.chlstOrderBy.SetItemCheckState(zz, CheckState.Unchecked)
            Next
        End If
        Dim y As Object
        Dim idx2 As New ArrayList
        For Each y In Me.chlstWC.CheckedItems
            idx2.Add(Me.chlstWC.CheckedItems.IndexOf(y))
        Next
        If idx2.Count >= 1 Then
            For Each yy As Integer In idx2
                Me.chlstWC.SetItemCheckState(yy, CheckState.Unchecked)
            Next
        End If

        Me.dpGenerated.Value = Date.Today.ToShortDateString

        Me.cboDateRange.SelectedItem = "Custom"

        Me.dpFrom.Value = Date.Today.ToShortDateString


        Me.dpTo.Value = Date.Today.ToShortDateString


        Me.tpFrom.Value = Date.Today

        Me.tpTo.Value = Date.Today

        Me.chWeekdays.CheckState = CheckState.Unchecked

        Me.rdoZip.Checked = True
        Me.rdoCity.Checked = False
        Me.txtZipCity.Text = ""
        Me.cboStateSelection.Text = ""
        Me.numMiles.Value = 0
        Me.chlstZipCity.Items.Clear()

        Dim a As New GetProducts
        Dim lstProducts As New List(Of GetProducts.Product)
        lstProducts = a.lstProducts
        For Each aa As GetProducts.Product In lstProducts
            Me.chlstProducts.Items.Add(aa.PName, False)
        Next

        a = Nothing

        Dim b As New GetMarketers
        Dim lstMarketers As New List(Of GetMarketers.Marketer)
        lstMarketers = b.lstMark
        For Each bb As GetMarketers.Marketer In lstMarketers
            Me.chlstMarketers.Items.Add(bb.fname & " " & bb.lname, False)
        Next


    End Sub
#End Region

#Region "Order By Check / UnCheck"

    Private Sub btnCheckOrderBy_Click(sender As Object, e As EventArgs) Handles btnCheckOrderBy.Click
        '' check them all
        Dim c As Object
        Dim arIDX As New ArrayList
        For Each c In Me.chlstOrderBy.Items
            Dim idx As Integer = Me.chlstOrderBy.Items.IndexOf(c)
            arIDX.Add(idx)
        Next
        For Each zz As Integer In arIDX
            Me.chlstOrderBy.SetItemCheckState(zz, CheckState.Checked)
        Next
    End Sub

    Private Sub btnUnCheckOrderBy_Click(sender As Object, e As EventArgs) Handles btnUnCheckOrderBy.Click
        '' Uncheck them all
        Dim c As Object
        Dim arIDX As New ArrayList
        For Each c In Me.chlstOrderBy.Items
            Dim idx As Integer = Me.chlstOrderBy.Items.IndexOf(c)
            arIDX.Add(idx)
        Next
        For Each zz As Integer In arIDX
            Me.chlstOrderBy.SetItemCheckState(zz, CheckState.Unchecked)
        Next
    End Sub


#End Region

#Region "Groub By - Up / Down Reordering"
    Private Sub btnUp_Click(sender As Object, e As EventArgs) Handles btnUp.Click
        '' first check to see if there is anything selected in this set of options
        '' 
        Dim selItems As CheckedListBox.CheckedItemCollection = Me.chlstOrderBy.CheckedItems


        '' now get where it is, and where it needs to go
        '' only if at least one item selected....
        Dim idx_Current As Integer = 0
        Dim idx_Next As Integer = 0

        If selItems(0) <> Nothing Then
            If selItems.Count > 1 Then
                MsgBox("You can only select 1 (one) item for reordering.", MsgBoxStyle.Information, "Can Reorder 1 Item At a Time")
                Exit Sub
            End If
            idx_Current = Me.chlstOrderBy.Items.IndexOf(selItems(0))
        End If


        '' the whole entire array to re-order
        '' 
        Dim arItems As New ArrayList
        For Each x As Object In Me.chlstOrderBy.Items
            arItems.Add(x)
        Next

        '' get the count of the original array
        ''
        Dim cntAr As Integer = arItems.Count

        If idx_Current >= 1 Then
            idx_Next = (idx_Current - 1)
        ElseIf idx_Current <= 0 Then
            Exit Sub
        End If

        '' now get the two items to swap
        '' 
        Dim selitem As String = arItems(idx_Current)
        Dim swapItem As String = arItems(idx_Next)

        '' now move them
        '' 

        arItems(idx_Next) = selitem
        arItems(idx_Current) = swapItem

        '' clear control
        '' then repop with new order
        Me.chlstOrderBy.Items.Clear()
        For Each x As String In arItems
            If x = selitem.ToString Then
                '' Edit: don't forget to keep them 'selected & checked => 3-25-2016 AC
                Me.chlstOrderBy.Items.Add(x, True)
                Me.chlstOrderBy.SelectedIndex = idx_Next
            ElseIf x <> selitem.ToString Then
                Me.chlstOrderBy.Items.Add(x, False)
            End If
        Next




    End Sub

    Private Sub btnDown_Click(sender As Object, e As EventArgs) Handles btnDown.Click
        '' first check to see if there is anything selected in this set of options
        '' 
        Dim selItems As CheckedListBox.CheckedItemCollection = Me.chlstOrderBy.CheckedItems


        '' now get where it is, and where it needs to go
        '' only if at least one item selected....
        Dim idx_Current As Integer = 0
        Dim idx_Next As Integer = 0

        If selItems(0) <> Nothing Then
            If selItems.Count > 1 Then
                MsgBox("You can only select 1 (one) item for reordering.", MsgBoxStyle.Information, "Can Reorder 1 Item At a Time")
                Exit Sub
            End If
            idx_Current = Me.chlstOrderBy.Items.IndexOf(selItems(0))
        End If


        '' the whole entire array to re-order
        '' 
        Dim arItems As New ArrayList
        For Each x As Object In Me.chlstOrderBy.Items
            arItems.Add(x)
        Next

        '' get the count of the original array
        ''
        Dim cntAr As Integer = arItems.Count

        If idx_Current >= 1 Then
            idx_Next = (idx_Current + 1)
            If idx_Next >= cntAr Then
                Exit Sub
            End If
        ElseIf idx_Current >= cntAr - 1 Then
            Exit Sub
        ElseIf idx_Current = 0 Then
            idx_Next += 1
        End If

        '' now get the two items to swap
        '' 
        Dim selitem As String = arItems(idx_Current)
        Dim swapItem As String = arItems(idx_Next)

        '' now move them
        '' 
        arItems(idx_Next) = selitem
        arItems(idx_Current) = swapItem

        '' clear control
        '' then repop with new order
        Me.chlstOrderBy.Items.Clear()
        For Each x As String In arItems
            If x = selitem.ToString Then
                '' Edit: don't forget to keep them 'selected & checked => 3-25-2016 AC
                Me.chlstOrderBy.Items.Add(x, True)
                Me.chlstOrderBy.SelectedIndex = idx_Next
            ElseIf x <> selitem.ToString Then
                Me.chlstOrderBy.Items.Add(x, False)
            End If
        Next
    End Sub

#End Region

#Region "Time Pick / Custom Date Ranges - Value Change and Formatting"

    Private Sub dpGenerated_ValueChanged(sender As Object, e As EventArgs) Handles dpGenerated.ValueChanged
        Dim sel_Val As Date = Me.dpGenerated.Value

        Dim month As Integer = sel_Val.Month
        Dim day As Integer = sel_Val.Day
        Dim year As Integer = sel_Val.Year

        Me.txtGenerated.Text = (month & "-" & day & "-" & year)

    End Sub

    Private Sub tpFrom_ValueChanged(sender As Object, e As EventArgs) Handles tpFrom.ValueChanged
        Me.txtTimeFrom.Text = Me.tpFrom.Value.ToShortTimeString
    End Sub

    Private Sub dpFrom_ValueChanged(sender As Object, e As EventArgs) Handles dpFrom.ValueChanged

        Dim sel_Val As Date = Me.dpFrom.Value

        Dim month As Integer = sel_Val.Month
        Dim day As Integer = sel_Val.Day
        Dim year As Integer = sel_Val.Year

        Me.txtFrom.Text = (month & "-" & day & "-" & year)

    End Sub

    Private Sub dpTo_ValueChanged(sender As Object, e As EventArgs) Handles dpTo.ValueChanged
        Dim sel_Val As Date = Me.dpTo.Value

        Dim month As Integer = sel_Val.Month
        Dim day As Integer = sel_Val.Day
        Dim year As Integer = sel_Val.Year

        Me.txtTo.Text = (month & "-" & day & "-" & year)

    End Sub

    Private Sub tpTo_ValueChanged(sender As Object, e As EventArgs) Handles tpTo.ValueChanged
        Me.txtTimeTo.Text = Me.tpTo.Value.ToShortTimeString
    End Sub

    Private Sub cboDateRange_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboDateRange.SelectedValueChanged
        If Me.cboDateRange.Text <> "Custom" Then
            If Me.cboDateRange.Text = "All" Then
                Me.dpFrom.Value = "1/1/1900"
                Me.dpTo.Value = "1/1/2100"
                'Me.txtFrom.Visible = True
                'Me.txtTo.Visible = True
                Exit Sub
            End If

            'Me.txtFrom.Visible = False
            'Me.txtTo.Visible = False
            Dim d As New DTPManipulation(Me.cboDateRange.Text)
            Me.dpFrom.Text = d.retDateFrom
            Me.dpTo.Text = d.retDateTo
        End If
    End Sub

#End Region

    Private Sub tbCriteria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tbCriteria.SelectedIndexChanged
        selectedTab_IDX = Me.tbCriteria.SelectedIndex
        CheckTab(selectedTab_IDX)
    End Sub

    Private Sub CheckTab(ByVal TabIDX As Integer)
        Select Case TabIDX
            Case Is = 0
                'MsgBox("DateTime")
                Exit Select
            Case Is = 1
                'MsgBox("Marketers")
                Exit Select
            Case Is = 2
                'MsgBox("Products")
                Exit Select
            Case Is = 3
                'MsgBox("Geo")
                Exit Select
            Case Is = 4
                'MsgBox("MarketingResults")
                Exit Select
            Case Is = 5
                'MsgBox("OrderBy/GroupBy")
                Exit Select
            Case Else
                'MsgBox("Else")
                Exit Select
        End Select
    End Sub



    
    
    
    
End Class