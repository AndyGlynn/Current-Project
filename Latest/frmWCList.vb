Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports MapPoint
Imports System.Text
Imports System.Text.RegularExpressions

Public Class frmWCList

#Region "Locally Scoped Vars"

    Private lstMarketers As List(Of GetMarketers.Marketer)
    Private lsProducts As List(Of GetProducts.Product)

    Private Criteria As String = ""

    Private selectedTab_IDX As Integer = 0
    Private _arUniques As List(Of Pull_Unique_States_And_Zips.UniqueCityStateZip)
    Private Structure ZipOrCity
        Public Category As String
        Public Value As String
    End Structure
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

#Region "Validate Geo Tab"


    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        ValidateGeo_Tab()
    End Sub

    Private Sub ValidateGeo_Tab()
        '' clear error provider
        Me.epGeo.Clear()

        '' do the dynamic controls exist or not
        '' 

        Dim ctrl As Control
        Dim fnd_txt As TextBox
        Dim performOPtxt As Boolean = False
        Dim performOPcbo As Boolean = False
        Dim fnd_cbo As ComboBox
        For Each ctrl In Me.grpGeo.Controls
            '' dynamic/static controls
            '' 
            '' Textbox validation
            If TypeOf ctrl Is TextBox Then
                If ctrl.Name = "txtZipCity" Then
                    fnd_txt = ctrl
                    If Len(fnd_txt.Text) <= 0 Then
                        '' no text present
                        Me.epGeo.SetError(fnd_txt, "You must supply a valid zip code.")
                        Exit Sub
                    ElseIf Len(fnd_txt.Text) >= 1 Then
                        If fnd_txt.Text <> "" Then
                            '' valid
                        ElseIf fnd_txt.Text = "" Then
                            Me.epGeo.SetError(fnd_txt, "You must supply a valid zip code.")
                            Exit Sub
                        End If
                        If fnd_txt.Text = " " Then
                            '' invalid
                            Me.epGeo.SetError(fnd_txt, "You must supply a valid zip code.")
                            Exit Sub
                        Else
                            '' valid
                            '' if all of the above are satisfied, check agains regex.
                            If Regex.IsMatch(fnd_txt.Text, "^[0-9]{5}(?:-[0-9]{4})?$") = True Then
                                '        '' valid
                                '        '' carry on)
                            ElseIf Regex.IsMatch(fnd_txt.Text, "^[0-9]{5}(?:-[0-9]{4})?$") = False Then
                                '' invalid
                                Me.epGeo.SetError(fnd_txt, "You must supply a valid zip code.")
                                Exit Sub
                            End If
                        End If
                    End If
                    Dim v As New Validate_Zip_Code_Mappoint(fnd_txt.Text)
                    If v.Valid = True Then
                        '' carry on
                        v = Nothing
                        performOPtxt = True
                    Else
                        Me.epGeo.SetError(fnd_txt, "This zip is either an invalid format or doesn't exist. Check entry and try again.")
                        v = Nothing
                        Exit Sub
                    End If
                End If
                '' End Textbox Validation

                '' combo box validation

            ElseIf TypeOf ctrl Is ComboBox Then
                If ctrl.Name = "cboZipCity" Then
                    fnd_cbo = ctrl
                    If Len(fnd_cbo.Text) <= 0 Then
                        '' no text present
                        Me.epGeo.SetError(fnd_cbo, "You must supply a valid City.")
                        Exit Sub
                    ElseIf Len(fnd_cbo.Text) >= 1 Then
                        If fnd_cbo.Text <> "" Then
                            '' valid
                        ElseIf fnd_cbo.Text = "" Then
                            Me.epGeo.SetError(fnd_cbo, "You must supply a valid City.")
                            Exit Sub
                        End If
                        If fnd_cbo.Text = " " Then
                            '' invalid
                            Me.epGeo.SetError(fnd_cbo, "You must supply a valid City.")
                            Exit Sub
                        Else
                            '' valid
                            performOPcbo = True
                        End If
                    End If
                End If
                '' end combo box validation
            End If
        Next

        '' was / is a state supplied?

        Dim strST As String = Me.cboStateSelection.Text
        If strST <> "" And strST <> " " And Len(strST) > 0 Then
            '' valid
        Else
            Me.epGeo.SetError(Me.cboStateSelection, "You must select a state code.")
            Exit Sub
        End If

        Dim val As Integer = Me.numMiles.Value
        If val <= 0 Then
            Me.epGeo.SetError(Me.numMiles, "You must supply a radius larger then 0.")
            Exit Sub
        Else
            '' valid
        End If


        If performOPtxt = True And performOPcbo = False Then
            Me.chlstZipCity.Items.Clear()
            Me.Cursor = Cursors.WaitCursor
            Me.pbSearch.Value = 1
            Dim a As New Radius_Search(CType(fnd_txt.Text, Integer), Me._arUniques, Me.numMiles.Value, "frmWCList.vb")
            Dim arZip As New ArrayList
            arZip = a.arZips
            For Each aa As String In arZip
                Me.chlstZipCity.Items.Add(aa, False)
            Next
            a = Nothing
            Me.Cursor = Cursors.Default
        ElseIf performOPtxt = False And performOPcbo = True Then
            Me.chlstZipCity.Items.Clear()
            Me.Cursor = Cursors.WaitCursor
            Me.pbSearch.Value = 1
            Dim a As New Radius_Search(fnd_cbo.Text, Me.cboStateSelection.Text, Me._arUniques, Me.numMiles.Value, "frmWCList.vb")
            Dim arCities As New ArrayList
            arCities = a.arCities
            For Each aa As String In arCities
                Me.chlstZipCity.Items.Add(aa, False)
            Next
            a = Nothing
            Me.Cursor = Cursors.Default
        End If
 
    End Sub

#End Region

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

        '' pull unique zips / city / state => Util class
        Dim un As New Pull_Unique_States_And_Zips
        Me._arUniques = New List(Of Pull_Unique_States_And_Zips.UniqueCityStateZip)
        Me._arUniques = un.ar_UniqueCityStateZip
        Me.lblUniques.Text = Me._arUniques.Count.ToString
        Me.pbSearch.Maximum = CType(Me.lblUniques.Text, Integer)
        Me.pbSearch.Minimum = 1
        Me.pbSearch.Value = 1

        Me.dpGenerated.Value = Date.Today
        Me.tpFrom.Value = ("1/1/1900 " & Date.Now.Hour & ":00")
        Me.tpTo.Value = ("1/1/1900 " & Date.Now.Hour & ":00")
        Me.dpFrom.Value = Date.Today.ToShortDateString
        Me.dpTo.Value = Date.Today.ToShortDateString

        Me.cboDateRange.Items.AddRange(New Object() {"All", "Today", "Yesterday", "This Week", "This Week - to date", "This Month", "This Month - to date", "This Year", "This Year - to date", "Next Week", "Next Month", "Last Week", "Last Week - to date", "Last Month", "Last Month - to date", "Last Year", "Last Year - to date", "Custom"})


        Me.Cursor = Cursors.Default

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
                Dim cmdGET As New SqlCommand("SELECT * from MarketerPullList;", cnxM)
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
        Dim cmdTXT As String = "select product1 as AllProducts FROM EnterLead WHERE product1 is not null and product1 <> '' and product1 <> ' ' UNION select product2 FROM EnterLead WHERE product2 is not null and product2 <> '' and product2 <> ' ' UNION select product3 FROM EnterLead WHERE product3 is not null and product3 <> '' and product3 <> ' ' UNION select Product FROM Products ORDER BY AllProducts ASC;"
        Public Sub New()
            lstProducts = New List(Of Product)
            lstProducts = GetProducts()
        End Sub
        Private Function GetProducts()
            Try
                Dim cnxP As New SqlConnection(cnx)
                cnxP.Open()
                Dim cmdGET As New SqlCommand(cmdTXT, cnxP)
                Dim r1 As SqlDataReader = cmdGET.ExecuteReader
                Dim lstP As New List(Of Product)
                While r1.Read
                    Dim a As New Product
                    a.RecID = "0"
                    a.PName = r1.Item("AllProducts")
                    a.PAcro = ""
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

        Me.epGeo.Clear()
        Me.pbSearch.Maximum = CType(Me._arUniques.Count.ToString, Integer)
        Me.pbSearch.Minimum = 1
        Me.pbSearch.Value = 1
        Me.btnShow.Text = "Show Zip Codes"

        '' for dynamicaly replaced controls
        '' 
        Dim ctrlT As Control = Me.grpGeo.Controls("txtZipCity")
        If ctrlT IsNot Nothing Then
            ctrlT.Text = ""
        End If
        Dim ctrlZ As ComboBox = Me.grpGeo.Controls("cboZipCity")
        If ctrlZ IsNot Nothing Then
            ctrlZ.Items.Clear()
            ctrlZ.Text = ""
        End If
        '' end dynamic controls

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
        'Me.lblStateSelect.Text = ""
        Me.cboStateSelection.Text = ""
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

#Region "Rdo's Check Change  - Zip / City Search"

    Private Sub rdoZip_CheckedChanged(sender As Object, e As EventArgs) Handles rdoZip.CheckedChanged

        '' target control to toggle: txtZipCity  [textbox]
        ''                           cboZipCity  [comboBox]

        '' default location {x,y} = 191, 67
        '' default size     {w,h} = 137, 20

        If Me.rdoZip.Checked = True Then
            Me.btnShow.Text = "Show Zip Codes"
            For Each ctrl As Control In Me.grpGeo.Controls
                If TypeOf ctrl Is TextBox Then
                    If ctrl.Name = "txtZipCity" Then
                        Me.grpGeo.Controls.Remove(ctrl)
                    End If
                End If
            Next
            '' control name: lblCityZip 
            '' default text: "Enter Starting Zip Code:"
            Me.lblCityZip.Text = "Enter Starting Zip Code:"
            Me.Label10.Text = "Show Zip Codes within"
            Me.Label11.Text = "Miles of Starting Zip Code"
            Dim tControl As Control = Me.grpGeo.Controls("cboZipCity")
            For Each ctrl As Control In Me.grpGeo.Controls
                If ctrl.Name = "cboZipCity" Then
                    Me.grpGeo.Controls.Remove(tControl)
                End If
            Next
            Dim txtCityZip As New TextBox
            txtCityZip.Name = "txtZipCity"
            txtCityZip.Size = New Size(137, 20)
            txtCityZip.Location = New Point(191, 67)
            Me.grpGeo.Controls.Add(txtCityZip)
        End If





    End Sub

    Private Sub rdoCity_CheckedChanged(sender As Object, e As EventArgs) Handles rdoCity.CheckedChanged
        '' target control to toggle: txtZipCity  [textbox]
        ''                           cboZipCity  [comboBox]

        '' default location {x,y} = 191, 67
        '' default size     {w,h} = 137, 20

        If Me.rdoCity.Checked = True Then
            Me.btnShow.Text = "Show Cities"
            Me.lblCityZip.Text = "Enter Starting City: "
            Me.Label10.Text = "Show Cities within"
            Me.Label11.Text = "Miles of Starting City"
            Dim tControl As Control = Me.grpGeo.Controls("txtZipCity")
            For Each ctrl As Control In Me.grpGeo.Controls
                If ctrl.Name = "txtZipCity" Then
                    ctrl.Visible = False
                    Me.grpGeo.Controls.Remove(tControl)
                End If
                If ctrl.Name = "cboZipCity" Then
                    Me.grpGeo.Controls.Remove(ctrl)
                End If
            Next
            Dim cboCity As New ComboBox
            cboCity.SuspendLayout()
            cboCity.Name = "cboZipCity"
            cboCity.Size = New Size(137, 20)
            cboCity.Location = New Point(191, 67)
            cboCity.AutoCompleteMode = AutoCompleteMode.Suggest
            cboCity.AllowDrop = True
            cboCity.DropDownStyle = ComboBoxStyle.DropDown
            For Each x As Pull_Unique_States_And_Zips.UniqueCityStateZip In Me._arUniques
                '' attempt to weed out duplicates(city) for combo box Items.
                If cboCity.Items.Contains(Trim(x.City)) = True Then
                    '' dont add it
                ElseIf cboCity.Items.Contains(Trim(x.City)) = False Then
                    If x.City <> " " And x.City <> "" Then
                        cboCity.Items.Add(Trim(x.City))
                    End If
                End If
            Next
            Me.grpGeo.Controls.Add(cboCity)
            cboCity.ResumeLayout()
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









    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        MsgBox("Query: " & vbCrLf & vbCrLf & BuildQuery(), MsgBoxStyle.Information, "Query String")
    End Sub


#Region "Build The Select Query"

    Private Function BuildQuery()
        '' date(s)
        ''  need to be represented as "#date#"
        Dim slct As String = ""
        Dim _gen As Date = CType(Me.txtGenerated.Text, Date)
        _gen = _gen.ToShortDateString
        slct += ("Gen: " & _gen) & vbCrLf
        Dim _from As Date = CType(Me.txtFrom.Text, Date)
        _from = _from.ToShortDateString
        slct += ("From: " & _from) & vbCrLf
        Dim _to As Date = CType(Me.txtTo.Text, Date)
        _to = _to.ToShortDateString
        slct += ("To: " & _to) & vbCrLf
        Dim _TimeFrom As Date = CType(Me.txtTimeFrom.Text, Date)
        _TimeFrom = _TimeFrom.ToShortTimeString
        slct += ("Time From: " & _TimeFrom) & vbCrLf
        Dim _TimeTo As Date = CType(Me.txtTimeTo.Text, Date)
        _TimeTo = _TimeTo.ToShortTimeString
        slct += ("Time To: " & _TimeTo) & vbCrLf
        Dim Weekdays As Boolean = Me.chWeekdays.CheckState
        slct += ("Weekdays: " & Weekdays.ToString) & vbCrLf

        '' marketers
        Dim arMarketers As New ArrayList
        Dim y As CheckedListBox.CheckedItemCollection = Me.chlstMarketers.CheckedItems
        Dim z As String
        For Each z In y
            arMarketers.Add(z)
        Next

        '' DEBUG purposes only
        Dim cnt As Integer = arMarketers.Count
        slct += "Marketers Selected:(" & cnt.ToString & ")" & vbCrLf
        Dim mark As String = ""
        For Each zz As String In arMarketers
            mark += (zz) & vbCrLf
        Next
        slct += mark
        '' END DEBUG

        '' products
        Dim arProducts As New ArrayList
        Dim p As CheckedListBox.CheckedItemCollection = Me.chlstProducts.CheckedItems
        Dim pp As String
        For Each pp In p
            arProducts.Add(pp)
        Next

        '' DEBUG purposes only
        Dim cntP As Integer = arProducts.Count
        slct += ("Product(s):(" & cntP.ToString & ")" & vbCrLf)
        Dim pro As String = ""
        For Each pr As String In arProducts
            pro += (pr) & vbCrLf
        Next
        slct += pro

        '' Geo
        '' city or zip
        ''
        Dim arZipCity As New ArrayList
        If Me.btnShow.Text = "Show Zip Codes" Then
            Dim zc As CheckedListBox.CheckedItemCollection = Me.chlstZipCity.CheckedItems
            Dim cntZ As Integer = zc.Count
            Dim zci As String = ""
            For Each zci In zc
                Dim x As New ZipOrCity
                x.Category = "Zip"
                x.Value = zci.ToString
                arZipCity.Add(x)
            Next
            slct += ("Zip(s):(" & cntZ & ")") & vbCrLf
            Dim gc As ZipOrCity
            Dim zps As String = ""
            For Each gc In arZipCity
                zps += (gc.Category & ":=" & gc.Value) & vbCrLf
            Next
            slct += zps
        Else
            Dim zc As CheckedListBox.CheckedItemCollection = Me.chlstZipCity.CheckedItems
            Dim cntZ As Integer = zc.Count
            Dim zci As String = ""
            For Each zci In zc
                Dim x As New ZipOrCity
                x.Category = "City"
                x.Value = zci.ToString
                arZipCity.Add(x)
            Next
            slct += ("City(s):(" & cntZ & ")") & vbCrLf
            Dim ga As ZipOrCity
            Dim zps As String = ""
            For Each ga In arZipCity
                zps += (ga.Category & ":=" & ga.Value) & vbCrLf
            Next
            slct += zps
        End If


        '' marketing results
        '' 
        Dim arMarketing As New ArrayList
        Dim m As CheckedListBox.CheckedItemCollection = Me.chlstWC.CheckedItems
        Dim mm As String
        For Each mm In m
            arMarketing.Add(mm)
        Next

        ''DEBUG purposes only
        '' 
        Dim cntM As Integer = arMarketing.Count
        slct += ("Marketing Results(s):(" & cntM.ToString & ")" & vbCrLf)
        Dim mar As String = ""
        For Each bc As String In arMarketing
            mar += (bc) & vbCrLf
        Next
        slct += mar
        '' END DEBUG


        '' Group By / Sorting

        Dim arGroups As New ArrayList
        Dim g As CheckedListBox.CheckedItemCollection = Me.chlstOrderBy.CheckedItems
        Dim gg As String
        For Each gg In g
            arGroups.Add(gg)
        Next

        ''DEBUG purposes only
        '' 
        Dim cntG As Integer = arGroups.Count
        Dim grp As String = ""
        For Each pr As String In arGroups
            grp += ("Sort Item: " & pr) & vbCrLf
        Next
        '' END DEBUG

        If Me.chGroupBy.CheckState = CheckState.Checked Then
            slct += "Group Top Item?: True" & vbCrLf
            slct += "Grouping: " & arGroups(0).ToString & vbCrLf
            Dim selSTR As String = ""
            For cntG = 1 To arGroups.Count - 1
                selSTR += ("Sort Item: " & arGroups(cntG).ToString) & vbCrLf
            Next
            slct += selSTR
        Else
            slct += "Group Top Item?: False" & vbCrLf
            slct += grp
        End If

        Return slct

    End Function

#End Region


End Class