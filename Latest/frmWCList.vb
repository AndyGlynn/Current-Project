Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System

Public Class frmWCList

    Public LoadComplete As Boolean = False

#Region "Aaron's Rewrite Code Blunder - 3-30-2016"
    '#Region "Locally Scoped Vars"

    '    Private lstMarketers As List(Of GetMarketers.Marketer)
    '    Private lsProducts As List(Of GetProducts.Product)

    '    Private Criteria As String = ""

    '    Private selectedTab_IDX As Integer = 0
    '    Private _arUniques As List(Of Pull_Unique_States_And_Zips.UniqueCityStateZip)
    '    Private Structure ZipOrCity
    '        Public Category As String
    '        Public Value As String
    '    End Structure
    '#End Region


    '    Private Sub frmWCList_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
    '        ResetForm()
    '    End Sub

    '    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
    '        Me.ResetForm()
    '        Me.Close()
    '    End Sub

    '    Private Sub btnRecordCount_Click(sender As Object, e As EventArgs) Handles btnRecordCount.Click
    '        Dim z As New CountRecords(Me.Criteria.ToString)
    '        Me.txtRecordCount.Text = z.cnt_records.ToString
    '        z = Nothing
    '    End Sub

    '    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
    '        Me.ResetForm()
    '    End Sub

    '#Region "Validate Geo Tab"


    '    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
    '        ValidateGeo_Tab()
    '    End Sub

    '    Private Sub ValidateGeo_Tab()
    '        '' clear error provider
    '        Me.epGeo.Clear()

    '        '' do the dynamic controls exist or not
    '        '' 

    '        Dim ctrl As Control
    '        Dim fnd_txt As TextBox
    '        Dim performOPtxt As Boolean = False
    '        Dim performOPcbo As Boolean = False
    '        Dim fnd_cbo As ComboBox
    '        For Each ctrl In Me.grpGeo.Controls
    '            '' dynamic/static controls
    '            '' 
    '            '' Textbox validation
    '            If TypeOf ctrl Is TextBox Then
    '                If ctrl.Name = "txtZipCity" Then
    '                    fnd_txt = ctrl
    '                    If Len(fnd_txt.Text) <= 0 Then
    '                        '' no text present
    '                        Me.epGeo.SetError(fnd_txt, "You must supply a valid zip code.")
    '                        Exit Sub
    '                    ElseIf Len(fnd_txt.Text) >= 1 Then
    '                        If fnd_txt.Text <> "" Then
    '                            '' valid
    '                        ElseIf fnd_txt.Text = "" Then
    '                            Me.epGeo.SetError(fnd_txt, "You must supply a valid zip code.")
    '                            Exit Sub
    '                        End If
    '                        If fnd_txt.Text = " " Then
    '                            '' invalid
    '                            Me.epGeo.SetError(fnd_txt, "You must supply a valid zip code.")
    '                            Exit Sub
    '                        Else
    '                            '' valid
    '                            '' if all of the above are satisfied, check agains regex.
    '                            If Regex.IsMatch(fnd_txt.Text, "^[0-9]{5}(?:-[0-9]{4})?$") = True Then
    '                                '        '' valid
    '                                '        '' carry on)
    '                            ElseIf Regex.IsMatch(fnd_txt.Text, "^[0-9]{5}(?:-[0-9]{4})?$") = False Then
    '                                '' invalid
    '                                Me.epGeo.SetError(fnd_txt, "You must supply a valid zip code.")
    '                                Exit Sub
    '                            End If
    '                        End If
    '                    End If
    '                    Dim v As New Validate_Zip_Code_Mappoint(fnd_txt.Text)
    '                    If v.Valid = True Then
    '                        '' carry on
    '                        v = Nothing
    '                        performOPtxt = True
    '                    Else
    '                        Me.epGeo.SetError(fnd_txt, "This zip is either an invalid format or doesn't exist. Check entry and try again.")
    '                        v = Nothing
    '                        Exit Sub
    '                    End If
    '                End If
    '                '' End Textbox Validation

    '                '' combo box validation

    '            ElseIf TypeOf ctrl Is ComboBox Then
    '                If ctrl.Name = "cboZipCity" Then
    '                    fnd_cbo = ctrl
    '                    If Len(fnd_cbo.Text) <= 0 Then
    '                        '' no text present
    '                        Me.epGeo.SetError(fnd_cbo, "You must supply a valid City.")
    '                        Exit Sub
    '                    ElseIf Len(fnd_cbo.Text) >= 1 Then
    '                        If fnd_cbo.Text <> "" Then
    '                            '' valid
    '                        ElseIf fnd_cbo.Text = "" Then
    '                            Me.epGeo.SetError(fnd_cbo, "You must supply a valid City.")
    '                            Exit Sub
    '                        End If
    '                        If fnd_cbo.Text = " " Then
    '                            '' invalid
    '                            Me.epGeo.SetError(fnd_cbo, "You must supply a valid City.")
    '                            Exit Sub
    '                        Else
    '                            '' valid
    '                            performOPcbo = True
    '                        End If
    '                    End If
    '                End If
    '                '' end combo box validation
    '            End If
    '        Next

    '        '' was / is a state supplied?

    '        Dim strST As String = Me.cboStateSelection.Text
    '        If strST <> "" And strST <> " " And Len(strST) > 0 Then
    '            '' valid
    '        Else
    '            Me.epGeo.SetError(Me.cboStateSelection, "You must select a state code.")
    '            Exit Sub
    '        End If

    '        Dim val As Integer = Me.numMiles.Value
    '        If val <= 0 Then
    '            Me.epGeo.SetError(Me.numMiles, "You must supply a radius larger then 0.")
    '            Exit Sub
    '        Else
    '            '' valid
    '        End If


    '        If performOPtxt = True And performOPcbo = False Then
    '            Me.chlstZipCity.Items.Clear()
    '            Me.Cursor = Cursors.WaitCursor
    '            Me.pbSearch.Value = 1
    '            Dim a As New Radius_Search(CType(fnd_txt.Text, Integer), Me._arUniques, Me.numMiles.Value, "frmWCList.vb")
    '            Dim arZip As New ArrayList
    '            arZip = a.arZips
    '            For Each aa As String In arZip
    '                Me.chlstZipCity.Items.Add(aa, False)
    '            Next
    '            a = Nothing
    '            Me.Cursor = Cursors.Default
    '        ElseIf performOPtxt = False And performOPcbo = True Then
    '            Me.chlstZipCity.Items.Clear()
    '            Me.Cursor = Cursors.WaitCursor
    '            Me.pbSearch.Value = 1
    '            Dim a As New Radius_Search(fnd_cbo.Text, Me.cboStateSelection.Text, Me._arUniques, Me.numMiles.Value, "frmWCList.vb")
    '            Dim arCities As New ArrayList
    '            arCities = a.arCities
    '            For Each aa As String In arCities
    '                Me.chlstZipCity.Items.Add(aa, False)
    '            Next
    '            a = Nothing
    '            Me.Cursor = Cursors.Default
    '        End If

    '    End Sub

    '#End Region

    '#Region "Form Load Events and Stuffs"
    '    Private Sub frmWCList_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    '        '' get products and marketers for init pop of criteria lists
    '        '' 

    '        lstMarketers = New List(Of GetMarketers.Marketer)
    '        lsProducts = New List(Of GetProducts.Product)

    '        Dim b As New GetMarketers
    '        lstMarketers = b.lstMark
    '        Dim c As New GetProducts
    '        lsProducts = c.lstProducts

    '        '' now pop lists/chklists
    '        '' 

    '        For Each y As GetMarketers.Marketer In lstMarketers
    '            chlstMarketers.Items.Add(y.fname & " " & y.lname, False)
    '        Next

    '        For Each z As GetProducts.Product In lsProducts
    '            chlstProducts.Items.Add(z.PName, False)
    '        Next

    '        Dim d As New GetStates
    '        Dim arStates As New ArrayList
    '        arStates = d.lstStates
    '        For Each zz As String In arStates
    '            Me.cboStateSelection.Items.Add(zz)
    '        Next

    '        '' pull unique zips / city / state => Util class
    '        Dim un As New Pull_Unique_States_And_Zips
    '        Me._arUniques = New List(Of Pull_Unique_States_And_Zips.UniqueCityStateZip)
    '        Me._arUniques = un.ar_UniqueCityStateZip
    '        Me.lblUniques.Text = Me._arUniques.Count.ToString
    '        Me.pbSearch.Maximum = CType(Me.lblUniques.Text, Integer)
    '        Me.pbSearch.Minimum = 1
    '        Me.pbSearch.Value = 1

    '        Me.dpGenerated.Value = Date.Today
    '        Me.tpFrom.Value = ("1/1/1900 " & Date.Now.Hour & ":00")
    '        Me.tpTo.Value = ("1/1/1900 " & Date.Now.Hour & ":00")
    '        Me.dpFrom.Value = Date.Today.ToShortDateString
    '        Me.dpTo.Value = Date.Today.ToShortDateString

    '        Me.cboDateRange.Items.AddRange(New Object() {"All", "Today", "Yesterday", "This Week", "This Week - to date", "This Month", "This Month - to date", "This Year", "This Year - to date", "Next Week", "Next Month", "Last Week", "Last Week - to date", "Last Month", "Last Month - to date", "Last Year", "Last Year - to date", "Custom"})


    '        Me.Cursor = Cursors.Default

    '    End Sub
    '#End Region

    '#Region "Marketer Check / Uncheck"

    '    Private Sub checkMarketers_Click(sender As Object, e As EventArgs) Handles checkMarketers.Click
    '        '' check them all
    '        Dim c As Object
    '        Dim arIDX As New ArrayList
    '        For Each c In Me.chlstMarketers.Items
    '            Dim idx As Integer = Me.chlstMarketers.Items.IndexOf(c)
    '            arIDX.Add(idx)
    '        Next
    '        For Each zz As Integer In arIDX
    '            Me.chlstMarketers.SetItemCheckState(zz, CheckState.Checked)
    '        Next
    '    End Sub

    '    Private Sub uncheckMarketers_Click(sender As Object, e As EventArgs) Handles uncheckMarketers.Click
    '        '' un-check them all
    '        Dim c As Object
    '        Dim arIDX As New ArrayList
    '        For Each c In Me.chlstMarketers.Items
    '            Dim idx As Integer = Me.chlstMarketers.Items.IndexOf(c)
    '            arIDX.Add(idx)
    '        Next
    '        For Each zz As Integer In arIDX
    '            Me.chlstMarketers.SetItemCheckState(zz, CheckState.Unchecked)
    '        Next
    '    End Sub

    '#End Region

    '#Region "Products Check/Uncheck"
    '    Private Sub btnCheckProducts_Click(sender As Object, e As EventArgs) Handles btnCheckProducts.Click
    '        '' check all / products
    '        Dim c As Object
    '        Dim arIDX As New ArrayList
    '        For Each c In Me.chlstProducts.Items
    '            Dim idx As Integer = Me.chlstProducts.Items.IndexOf(c)
    '            arIDX.Add(idx)
    '        Next
    '        For Each zz As Integer In arIDX
    '            Me.chlstProducts.SetItemCheckState(zz, CheckState.Checked)
    '        Next
    '    End Sub

    '    Private Sub btnUncheckProducts_Click(sender As Object, e As EventArgs) Handles btnUncheckProducts.Click
    '        '' uncheck all / products
    '        Dim c As Object
    '        Dim arIDX As New ArrayList
    '        For Each c In Me.chlstProducts.Items
    '            Dim idx As Integer = Me.chlstProducts.Items.IndexOf(c)
    '            arIDX.Add(idx)
    '        Next
    '        For Each zz As Integer In arIDX
    '            Me.chlstProducts.SetItemCheckState(zz, CheckState.Unchecked)
    '        Next
    '    End Sub

    '#End Region

    '#Region "Geography Check/Uncheck"

    '    Private Sub btnCheckZip_Click(sender As Object, e As EventArgs) Handles btnCheckZip.Click
    '        '' check all ZipCity
    '        Dim c As Object
    '        Dim arIDX As New ArrayList
    '        For Each c In Me.chlstZipCity.Items
    '            Dim idx As Integer = Me.chlstZipCity.Items.IndexOf(c)
    '            arIDX.Add(idx)
    '        Next
    '        For Each zz As Integer In arIDX
    '            Me.chlstZipCity.SetItemCheckState(zz, CheckState.Checked)
    '        Next
    '    End Sub

    '    Private Sub btnUncheckZip_Click(sender As Object, e As EventArgs) Handles btnUncheckZip.Click
    '        '' Uncheck all ZipCity
    '        Dim c As Object
    '        Dim arIDX As New ArrayList
    '        For Each c In Me.chlstZipCity.Items
    '            Dim idx As Integer = Me.chlstZipCity.Items.IndexOf(c)
    '            arIDX.Add(idx)
    '        Next
    '        For Each zz As Integer In arIDX
    '            Me.chlstZipCity.SetItemCheckState(zz, CheckState.Unchecked)
    '        Next
    '    End Sub
    '#End Region

    '#Region "Marketing Results - Check / Uncheck"

    '    Private Sub btnCheckWC_Click(sender As Object, e As EventArgs) Handles btnCheckWC.Click
    '        '' check them all
    '        Dim c As Object
    '        Dim arIDX As New ArrayList
    '        For Each c In Me.chlstWC.Items
    '            Dim idx As Integer = Me.chlstWC.Items.IndexOf(c)
    '            arIDX.Add(idx)
    '        Next
    '        For Each zz As Integer In arIDX
    '            Me.chlstWC.SetItemCheckState(zz, CheckState.Checked)
    '        Next
    '    End Sub

    '    Private Sub btnUncheckWC_Click(sender As Object, e As EventArgs) Handles btnUncheckWC.Click
    '        '' Uncheck them all
    '        Dim c As Object
    '        Dim arIDX As New ArrayList
    '        For Each c In Me.chlstWC.Items
    '            Dim idx As Integer = Me.chlstWC.Items.IndexOf(c)
    '            arIDX.Add(idx)
    '        Next
    '        For Each zz As Integer In arIDX
    '            Me.chlstWC.SetItemCheckState(zz, CheckState.Unchecked)
    '        Next
    '    End Sub
    '#End Region

    '#Region "Private Class - Get Marketers for Criteria List"
    '    Private Class GetMarketers
    '        Public Structure Marketer
    '            Public RecID As String
    '            Public fname As String
    '            Public lname As String
    '            Public PriLeadSource As String
    '            Public SecLeadSource As String
    '            Public MarketingManager As String
    '            Public Active As Boolean
    '        End Structure
    '        Public lstMark As List(Of Marketer)
    '        Private Const cnx As String = "SERVER=192.168.1.2;Database=ISS;User Id=sa;Password=spoken1;"
    '        Public Sub New()
    '            lstMark = New List(Of Marketer)
    '            lstMark = GetMarketers()
    '        End Sub
    '        Private Function GetMarketers()
    '            Try
    '                Dim cnxM As New SqlConnection(cnx)
    '                Dim lstMark As New List(Of Marketer)
    '                cnxM.Open()
    '                Dim cmdGET As New SqlCommand("SELECT * from MarketerPullList;", cnxM)
    '                Dim r1 As SqlDataReader = cmdGET.ExecuteReader
    '                While r1.Read
    '                    Dim a As New Marketer
    '                    a.RecID = r1.Item("ID")
    '                    a.fname = r1.Item("FName")
    '                    a.lname = r1.Item("LName")
    '                    a.PriLeadSource = r1.Item("PriLeadSource")
    '                    a.SecLeadSource = r1.Item("SecLeadSource")
    '                    a.MarketingManager = r1.Item("MarketingManager")
    '                    a.Active = r1.Item("Active")
    '                    lstMark.Add(a)
    '                End While
    '                r1.Close()
    '                cnxM.Close()
    '                cnxM = Nothing
    '                Return lstMark
    '            Catch ex As Exception
    '                Dim g As New ErrorLogging_V2
    '                g.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmWCList.vb", "Private-GetMarketers", "Class", "GetMarketers()", "0", ex.Message.ToString)
    '                g = Nothing
    '                Return lstMark
    '            End Try
    '        End Function
    '    End Class
    '#End Region

    '#Region "Private Class - GetProducts()"


    '    Private Class GetProducts
    '        Public Structure Product
    '            Public RecID As String
    '            Public PName As String
    '            Public PAcro As String
    '        End Structure
    '        Public lstProducts As List(Of Product)
    '        Private Const cnx As String = "SERVER=192.168.1.2;Database=ISS;User Id=sa;Password=spoken1;"
    '        Dim cmdTXT As String = "select product1 as AllProducts FROM EnterLead WHERE product1 is not null and product1 <> '' and product1 <> ' ' UNION select product2 FROM EnterLead WHERE product2 is not null and product2 <> '' and product2 <> ' ' UNION select product3 FROM EnterLead WHERE product3 is not null and product3 <> '' and product3 <> ' ' UNION select Product FROM Products ORDER BY AllProducts ASC;"
    '        Public Sub New()
    '            lstProducts = New List(Of Product)
    '            lstProducts = GetProducts()
    '        End Sub
    '        Private Function GetProducts()
    '            Try
    '                Dim cnxP As New SqlConnection(cnx)
    '                cnxP.Open()
    '                Dim cmdGET As New SqlCommand(cmdTXT, cnxP)
    '                Dim r1 As SqlDataReader = cmdGET.ExecuteReader
    '                Dim lstP As New List(Of Product)
    '                While r1.Read
    '                    Dim a As New Product
    '                    a.RecID = "0"
    '                    a.PName = r1.Item("AllProducts")
    '                    a.PAcro = ""
    '                    lstP.Add(a)
    '                End While
    '                r1.Close()
    '                cnxP.Close()
    '                cnxP = Nothing
    '                Return lstP
    '            Catch ex As Exception
    '                Dim g As New ErrorLogging_V2
    '                g.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmWCList.vb", "GetProducts()", "Class", "GetProducts()", "0", ex.Message.ToString)
    '                g = Nothing
    '                Return lstProducts
    '            End Try
    '        End Function
    '    End Class
    '#End Region

    '#Region "Private Class - Record Count - Just Returns Count Of Records Based on Criteria"
    '    Private Class CountRecords
    '        Private Const cnx As String = "SERVER=192.168.1.2;Database=ISS;User Id=sa;Password=spoken1;"
    '        Public cnt_records As Integer = 0
    '        Public Sub New(ByVal Criteria As String)
    '            Try
    '                Dim cnxC As New SqlConnection(cnx)
    '                cnxC.Open()
    '                Dim cmdCNT As New SqlCommand("SELECT COUNT(ID) FROM EnterLead WHERE " & Criteria & ";", cnxC)
    '                Dim res As Integer = cmdCNT.ExecuteScalar
    '                cnt_records = res
    '                cnxC.Close()
    '                cnxC = Nothing
    '            Catch ex As Exception
    '                Dim g As New ErrorLogging_V2
    '                g.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmWCList.vb", "CountRecords", "Class", "New()", "0", ex.Message.ToString)
    '                g = Nothing
    '            End Try
    '        End Sub
    '    End Class
    '#End Region

    '#Region "Populate Unique States in CboStateSel"
    '    Private Class GetStates
    '        Private cnx As String = "SERVER=192.168.1.2;Database=ISS;User Id=sa;Password=spoken1;"
    '        Public lstStates As ArrayList
    '        Public Sub New()
    '            lstStates = GetUniqueStates()
    '        End Sub
    '        Private Function GetUniqueStates()
    '            Try
    '                Dim cnxC As New SqlConnection(cnx)
    '                cnxC.Open()
    '                Dim lsStates As New ArrayList
    '                Dim cmdGET As New SqlCommand("SELECT DISTINCT(State) FROM CityPull ORDER BY State ASC;", cnxC)
    '                Dim r1 As SqlDataReader = cmdGET.ExecuteReader
    '                While r1.Read
    '                    lsStates.Add(r1.Item("State"))
    '                End While
    '                r1.Close()
    '                cnxC.Close()
    '                cnxC = Nothing
    '                Return lsStates
    '            Catch ex As Exception
    '                Dim g As New ErrorLogging_V2
    '                g.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmWCList.vb", "GetStates", "Class", "GetUniqueStates", "0", ex.Message.ToString)
    '                g = Nothing
    '                Return lstStates
    '            End Try
    '        End Function
    '    End Class
    '#End Region

    '#Region "Universal Reset Sub"
    '    Private Sub ResetForm()

    '        selectedTab_IDX = 0

    '        Me.epGeo.Clear()
    '        Me.pbSearch.Maximum = CType(Me._arUniques.Count.ToString, Integer)
    '        Me.pbSearch.Minimum = 1
    '        Me.pbSearch.Value = 1
    '        Me.btnShow.Text = "Show Zip Codes"

    '        '' for dynamicaly replaced controls
    '        '' 
    '        Dim ctrlT As Control = Me.grpGeo.Controls("txtZipCity")
    '        If ctrlT IsNot Nothing Then
    '            ctrlT.Text = ""
    '        End If
    '        Dim ctrlZ As ComboBox = Me.grpGeo.Controls("cboZipCity")
    '        If ctrlZ IsNot Nothing Then
    '            ctrlZ.Items.Clear()
    '            ctrlZ.Text = ""
    '        End If
    '        '' end dynamic controls

    '        Me.dpGenerated.Value = Date.Today
    '        Me.txtGenerated.Text = (Date.Today.Month & "-" & Date.Today.Day & "-" & Date.Today.Year)
    '        Me.tpFrom.Value = ("1/1/1900 " & Date.Now.Hour & ":00")
    '        Me.tpTo.Value = ("1/1/1900 " & Date.Now.Hour & ":00")

    '        Me.dpFrom.Value = Date.Today.ToShortDateString
    '        Me.txtFrom.Text = (Date.Today.Month & "-" & Date.Today.Day & "-" & Date.Today.Year)
    '        Me.txtTo.Text = (Date.Today.Month & "-" & Date.Today.Day & "-" & Date.Today.Year)
    '        Me.dpTo.Value = Date.Today.ToShortDateString

    '        Me.chlstMarketers.Items.Clear()
    '        Me.chlstProducts.Items.Clear()
    '        'Me.lblStateSelect.Text = ""
    '        Me.cboStateSelection.Text = ""
    '        Me.txtRecordCount.Text = ""
    '        Me.chGroupBy.CheckState = CheckState.Unchecked

    '        Dim x As Object
    '        Dim idxs As New ArrayList
    '        For Each x In Me.chlstOrderBy.CheckedItems
    '            idxs.Add(Me.chlstOrderBy.CheckedItems.IndexOf(x))
    '        Next
    '        If idxs.Count >= 1 Then
    '            For Each zz As Integer In idxs
    '                Me.chlstOrderBy.SetItemCheckState(zz, CheckState.Unchecked)
    '            Next
    '        End If
    '        Dim y As Object
    '        Dim idx2 As New ArrayList
    '        For Each y In Me.chlstWC.CheckedItems
    '            idx2.Add(Me.chlstWC.CheckedItems.IndexOf(y))
    '        Next
    '        If idx2.Count >= 1 Then
    '            For Each yy As Integer In idx2
    '                Me.chlstWC.SetItemCheckState(yy, CheckState.Unchecked)
    '            Next
    '        End If

    '        Me.dpGenerated.Value = Date.Today.ToShortDateString

    '        Me.cboDateRange.SelectedItem = "Custom"

    '        Me.dpFrom.Value = Date.Today.ToShortDateString


    '        Me.dpTo.Value = Date.Today.ToShortDateString


    '        Me.tpFrom.Value = Date.Today

    '        Me.tpTo.Value = Date.Today

    '        Me.chWeekdays.CheckState = CheckState.Unchecked

    '        Me.rdoZip.Checked = True
    '        Me.rdoCity.Checked = False
    '        Me.txtZipCity.Text = ""
    '        Me.cboStateSelection.Text = ""
    '        Me.numMiles.Value = 0
    '        Me.chlstZipCity.Items.Clear()

    '        Dim a As New GetProducts
    '        Dim lstProducts As New List(Of GetProducts.Product)
    '        lstProducts = a.lstProducts
    '        For Each aa As GetProducts.Product In lstProducts
    '            Me.chlstProducts.Items.Add(aa.PName, False)
    '        Next

    '        a = Nothing

    '        Dim b As New GetMarketers
    '        Dim lstMarketers As New List(Of GetMarketers.Marketer)
    '        lstMarketers = b.lstMark
    '        For Each bb As GetMarketers.Marketer In lstMarketers
    '            Me.chlstMarketers.Items.Add(bb.fname & " " & bb.lname, False)
    '        Next


    '    End Sub
    '#End Region

    '#Region "Order By Check / UnCheck"

    '    Private Sub btnCheckOrderBy_Click(sender As Object, e As EventArgs) Handles btnCheckOrderBy.Click
    '        '' check them all
    '        Dim c As Object
    '        Dim arIDX As New ArrayList
    '        For Each c In Me.chlstOrderBy.Items
    '            Dim idx As Integer = Me.chlstOrderBy.Items.IndexOf(c)
    '            arIDX.Add(idx)
    '        Next
    '        For Each zz As Integer In arIDX
    '            Me.chlstOrderBy.SetItemCheckState(zz, CheckState.Checked)
    '        Next
    '    End Sub

    '    Private Sub btnUnCheckOrderBy_Click(sender As Object, e As EventArgs) Handles btnUnCheckOrderBy.Click
    '        '' Uncheck them all
    '        Dim c As Object
    '        Dim arIDX As New ArrayList
    '        For Each c In Me.chlstOrderBy.Items
    '            Dim idx As Integer = Me.chlstOrderBy.Items.IndexOf(c)
    '            arIDX.Add(idx)
    '        Next
    '        For Each zz As Integer In arIDX
    '            Me.chlstOrderBy.SetItemCheckState(zz, CheckState.Unchecked)
    '        Next
    '    End Sub


    '#End Region

    '#Region "Groub By - Up / Down Reordering"
    '    Private Sub btnUp_Click(sender As Object, e As EventArgs) Handles btnUp.Click
    '        '' first check to see if there is anything selected in this set of options
    '        '' 
    '        Dim selItems As CheckedListBox.CheckedItemCollection = Me.chlstOrderBy.CheckedItems


    '        '' now get where it is, and where it needs to go
    '        '' only if at least one item selected....
    '        Dim idx_Current As Integer = 0
    '        Dim idx_Next As Integer = 0

    '        If selItems(0) <> Nothing Then
    '            If selItems.Count > 1 Then
    '                MsgBox("You can only select 1 (one) item for reordering.", MsgBoxStyle.Information, "Can Reorder 1 Item At a Time")
    '                Exit Sub
    '            End If
    '            idx_Current = Me.chlstOrderBy.Items.IndexOf(selItems(0))
    '        End If


    '        '' the whole entire array to re-order
    '        '' 
    '        Dim arItems As New ArrayList
    '        For Each x As Object In Me.chlstOrderBy.Items
    '            arItems.Add(x)
    '        Next

    '        '' get the count of the original array
    '        ''
    '        Dim cntAr As Integer = arItems.Count

    '        If idx_Current >= 1 Then
    '            idx_Next = (idx_Current - 1)
    '        ElseIf idx_Current <= 0 Then
    '            Exit Sub
    '        End If

    '        '' now get the two items to swap
    '        '' 
    '        Dim selitem As String = arItems(idx_Current)
    '        Dim swapItem As String = arItems(idx_Next)

    '        '' now move them
    '        '' 

    '        arItems(idx_Next) = selitem
    '        arItems(idx_Current) = swapItem

    '        '' clear control
    '        '' then repop with new order
    '        Me.chlstOrderBy.Items.Clear()
    '        For Each x As String In arItems
    '            If x = selitem.ToString Then
    '                '' Edit: don't forget to keep them 'selected & checked => 3-25-2016 AC
    '                Me.chlstOrderBy.Items.Add(x, True)
    '                Me.chlstOrderBy.SelectedIndex = idx_Next
    '            ElseIf x <> selitem.ToString Then
    '                Me.chlstOrderBy.Items.Add(x, False)
    '            End If
    '        Next




    '    End Sub

    '    Private Sub btnDown_Click(sender As Object, e As EventArgs) Handles btnDown.Click
    '        '' first check to see if there is anything selected in this set of options
    '        '' 
    '        Dim selItems As CheckedListBox.CheckedItemCollection = Me.chlstOrderBy.CheckedItems


    '        '' now get where it is, and where it needs to go
    '        '' only if at least one item selected....
    '        Dim idx_Current As Integer = 0
    '        Dim idx_Next As Integer = 0

    '        If selItems(0) <> Nothing Then
    '            If selItems.Count > 1 Then
    '                MsgBox("You can only select 1 (one) item for reordering.", MsgBoxStyle.Information, "Can Reorder 1 Item At a Time")
    '                Exit Sub
    '            End If
    '            idx_Current = Me.chlstOrderBy.Items.IndexOf(selItems(0))
    '        End If


    '        '' the whole entire array to re-order
    '        '' 
    '        Dim arItems As New ArrayList
    '        For Each x As Object In Me.chlstOrderBy.Items
    '            arItems.Add(x)
    '        Next

    '        '' get the count of the original array
    '        ''
    '        Dim cntAr As Integer = arItems.Count

    '        If idx_Current >= 1 Then
    '            idx_Next = (idx_Current + 1)
    '            If idx_Next >= cntAr Then
    '                Exit Sub
    '            End If
    '        ElseIf idx_Current >= cntAr - 1 Then
    '            Exit Sub
    '        ElseIf idx_Current = 0 Then
    '            idx_Next += 1
    '        End If

    '        '' now get the two items to swap
    '        '' 
    '        Dim selitem As String = arItems(idx_Current)
    '        Dim swapItem As String = arItems(idx_Next)

    '        '' now move them
    '        '' 
    '        arItems(idx_Next) = selitem
    '        arItems(idx_Current) = swapItem

    '        '' clear control
    '        '' then repop with new order
    '        Me.chlstOrderBy.Items.Clear()
    '        For Each x As String In arItems
    '            If x = selitem.ToString Then
    '                '' Edit: don't forget to keep them 'selected & checked => 3-25-2016 AC
    '                Me.chlstOrderBy.Items.Add(x, True)
    '                Me.chlstOrderBy.SelectedIndex = idx_Next
    '            ElseIf x <> selitem.ToString Then
    '                Me.chlstOrderBy.Items.Add(x, False)
    '            End If
    '        Next
    '    End Sub

    '#End Region

    '#Region "Time Pick / Custom Date Ranges - Value Change and Formatting"

    '    Private Sub dpGenerated_ValueChanged(sender As Object, e As EventArgs) Handles dpGenerated.ValueChanged
    '        Dim sel_Val As Date = Me.dpGenerated.Value

    '        Dim month As Integer = sel_Val.Month
    '        Dim day As Integer = sel_Val.Day
    '        Dim year As Integer = sel_Val.Year

    '        Me.txtGenerated.Text = (month & "-" & day & "-" & year)

    '    End Sub

    '    Private Sub tpFrom_ValueChanged(sender As Object, e As EventArgs) Handles tpFrom.ValueChanged
    '        Me.txtTimeFrom.Text = Me.tpFrom.Value.ToShortTimeString
    '    End Sub

    '    Private Sub dpFrom_ValueChanged(sender As Object, e As EventArgs) Handles dpFrom.ValueChanged

    '        Dim sel_Val As Date = Me.dpFrom.Value

    '        Dim month As Integer = sel_Val.Month
    '        Dim day As Integer = sel_Val.Day
    '        Dim year As Integer = sel_Val.Year

    '        Me.txtFrom.Text = (month & "-" & day & "-" & year)

    '    End Sub

    '    Private Sub dpTo_ValueChanged(sender As Object, e As EventArgs) Handles dpTo.ValueChanged
    '        Dim sel_Val As Date = Me.dpTo.Value

    '        Dim month As Integer = sel_Val.Month
    '        Dim day As Integer = sel_Val.Day
    '        Dim year As Integer = sel_Val.Year

    '        Me.txtTo.Text = (month & "-" & day & "-" & year)

    '    End Sub

    '    Private Sub tpTo_ValueChanged(sender As Object, e As EventArgs) Handles tpTo.ValueChanged
    '        Me.txtTimeTo.Text = Me.tpTo.Value.ToShortTimeString
    '    End Sub

    '    Private Sub cboDateRange_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboDateRange.SelectedValueChanged
    '        If Me.cboDateRange.Text <> "Custom" Then
    '            If Me.cboDateRange.Text = "All" Then
    '                Me.dpFrom.Value = "1/1/1900"
    '                Me.dpTo.Value = "1/1/2100"
    '                'Me.txtFrom.Visible = True
    '                'Me.txtTo.Visible = True
    '                Exit Sub
    '            End If

    '            'Me.txtFrom.Visible = False
    '            'Me.txtTo.Visible = False
    '            Dim d As New DTPManipulation(Me.cboDateRange.Text)
    '            Me.dpFrom.Text = d.retDateFrom
    '            Me.dpTo.Text = d.retDateTo
    '        End If
    '    End Sub

    '#End Region

    '#Region "Rdo's Check Change  - Zip / City Search"

    '    Private Sub rdoZip_CheckedChanged(sender As Object, e As EventArgs) Handles rdoZip.CheckedChanged

    '        '' target control to toggle: txtZipCity  [textbox]
    '        ''                           cboZipCity  [comboBox]

    '        '' default location {x,y} = 191, 67
    '        '' default size     {w,h} = 137, 20

    '        If Me.rdoZip.Checked = True Then
    '            Me.btnShow.Text = "Show Zip Codes"
    '            For Each ctrl As Control In Me.grpGeo.Controls
    '                If TypeOf ctrl Is TextBox Then
    '                    If ctrl.Name = "txtZipCity" Then
    '                        Me.grpGeo.Controls.Remove(ctrl)
    '                    End If
    '                End If
    '            Next
    '            '' control name: lblCityZip 
    '            '' default text: "Enter Starting Zip Code:"
    '            Me.lblCityZip.Text = "Enter Starting Zip Code:"
    '            Me.Label10.Text = "Show Zip Codes within"
    '            Me.Label11.Text = "Miles of Starting Zip Code"
    '            Dim tControl As Control = Me.grpGeo.Controls("cboZipCity")
    '            For Each ctrl As Control In Me.grpGeo.Controls
    '                If ctrl.Name = "cboZipCity" Then
    '                    Me.grpGeo.Controls.Remove(tControl)
    '                End If
    '            Next
    '            Dim txtCityZip As New TextBox
    '            txtCityZip.Name = "txtZipCity"
    '            txtCityZip.Size = New Size(137, 20)
    '            txtCityZip.Location = New Point(191, 67)
    '            Me.grpGeo.Controls.Add(txtCityZip)
    '        End If





    '    End Sub

    '    Private Sub rdoCity_CheckedChanged(sender As Object, e As EventArgs) Handles rdoCity.CheckedChanged
    '        '' target control to toggle: txtZipCity  [textbox]
    '        ''                           cboZipCity  [comboBox]

    '        '' default location {x,y} = 191, 67
    '        '' default size     {w,h} = 137, 20

    '        If Me.rdoCity.Checked = True Then
    '            Me.btnShow.Text = "Show Cities"
    '            Me.lblCityZip.Text = "Enter Starting City: "
    '            Me.Label10.Text = "Show Cities within"
    '            Me.Label11.Text = "Miles of Starting City"
    '            Dim tControl As Control = Me.grpGeo.Controls("txtZipCity")
    '            For Each ctrl As Control In Me.grpGeo.Controls
    '                If ctrl.Name = "txtZipCity" Then
    '                    ctrl.Visible = False
    '                    Me.grpGeo.Controls.Remove(tControl)
    '                End If
    '                If ctrl.Name = "cboZipCity" Then
    '                    Me.grpGeo.Controls.Remove(ctrl)
    '                End If
    '            Next
    '            Dim cboCity As New ComboBox
    '            cboCity.SuspendLayout()
    '            cboCity.Name = "cboZipCity"
    '            cboCity.Size = New Size(137, 20)
    '            cboCity.Location = New Point(191, 67)
    '            cboCity.AutoCompleteMode = AutoCompleteMode.Suggest
    '            cboCity.AllowDrop = True
    '            cboCity.DropDownStyle = ComboBoxStyle.DropDown
    '            For Each x As Pull_Unique_States_And_Zips.UniqueCityStateZip In Me._arUniques
    '                '' attempt to weed out duplicates(city) for combo box Items.
    '                If cboCity.Items.Contains(Trim(x.City)) = True Then
    '                    '' dont add it
    '                ElseIf cboCity.Items.Contains(Trim(x.City)) = False Then
    '                    If x.City <> " " And x.City <> "" Then
    '                        cboCity.Items.Add(Trim(x.City))
    '                    End If
    '                End If
    '            Next
    '            Me.grpGeo.Controls.Add(cboCity)
    '            cboCity.ResumeLayout()
    '        End If

    '    End Sub
    '#End Region

    '    Private Sub tbCriteria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tbCriteria.SelectedIndexChanged
    '        selectedTab_IDX = Me.tbCriteria.SelectedIndex
    '        CheckTab(selectedTab_IDX)
    '    End Sub

    '    Private Sub CheckTab(ByVal TabIDX As Integer)
    '        Select Case TabIDX
    '            Case Is = 0
    '                'MsgBox("DateTime")
    '                Exit Select
    '            Case Is = 1
    '                'MsgBox("Marketers")
    '                Exit Select
    '            Case Is = 2
    '                'MsgBox("Products")
    '                Exit Select
    '            Case Is = 3
    '                'MsgBox("Geo")
    '                Exit Select
    '            Case Is = 4
    '                'MsgBox("MarketingResults")
    '                Exit Select
    '            Case Is = 5
    '                'MsgBox("OrderBy/GroupBy")
    '                Exit Select
    '            Case Else
    '                'MsgBox("Else")
    '                Exit Select
    '        End Select
    '    End Sub









    '    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click


    '    End Sub


    '#Region "Build The Select Query"

    '    Private Function BuildQuery()
    '        '' date(s)
    '        ''  need to be represented as "#date#"
    '        Dim slct As String = ""
    '        Dim _gen As Date = CType(Me.txtGenerated.Text, Date)
    '        _gen = _gen.ToShortDateString
    '        slct += ("Gen: " & _gen) & vbCrLf
    '        Dim _from As Date = CType(Me.txtFrom.Text, Date)
    '        _from = _from.ToShortDateString
    '        slct += ("From: " & _from) & vbCrLf
    '        Dim _to As Date = CType(Me.txtTo.Text, Date)
    '        _to = _to.ToShortDateString
    '        slct += ("To: " & _to) & vbCrLf
    '        Dim _TimeFrom As Date = CType(Me.txtTimeFrom.Text, Date)
    '        _TimeFrom = _TimeFrom.ToShortTimeString
    '        slct += ("Time From: " & _TimeFrom) & vbCrLf
    '        Dim _TimeTo As Date = CType(Me.txtTimeTo.Text, Date)
    '        _TimeTo = _TimeTo.ToShortTimeString
    '        slct += ("Time To: " & _TimeTo) & vbCrLf
    '        Dim Weekdays As Boolean = Me.chWeekdays.CheckState
    '        slct += ("Weekdays: " & Weekdays.ToString) & vbCrLf

    '        '' marketers
    '        Dim arMarketers As New ArrayList
    '        Dim y As CheckedListBox.CheckedItemCollection = Me.chlstMarketers.CheckedItems
    '        Dim z As String
    '        For Each z In y
    '            arMarketers.Add(z)
    '        Next

    '        '' DEBUG purposes only
    '        Dim cnt As Integer = arMarketers.Count
    '        slct += "Marketers Selected:(" & cnt.ToString & ")" & vbCrLf
    '        Dim mark As String = ""
    '        For Each zz As String In arMarketers
    '            mark += (zz) & vbCrLf
    '        Next
    '        slct += mark
    '        '' END DEBUG

    '        '' products
    '        Dim arProducts As New ArrayList
    '        Dim p As CheckedListBox.CheckedItemCollection = Me.chlstProducts.CheckedItems
    '        Dim pp As String
    '        For Each pp In p
    '            arProducts.Add(pp)
    '        Next

    '        '' DEBUG purposes only
    '        Dim cntP As Integer = arProducts.Count
    '        slct += ("Product(s):(" & cntP.ToString & ")" & vbCrLf)
    '        Dim pro As String = ""
    '        For Each pr As String In arProducts
    '            pro += (pr) & vbCrLf
    '        Next
    '        slct += pro
    '        '' END DEBUG

    '        '' Geo
    '        '' city or zip
    '        ''
    '        Dim arZipCity As New ArrayList
    '        If Me.btnShow.Text = "Show Zip Codes" Then
    '            Dim zc As CheckedListBox.CheckedItemCollection = Me.chlstZipCity.CheckedItems
    '            Dim cntZ As Integer = zc.Count
    '            Dim zci As String = ""
    '            For Each zci In zc
    '                Dim x As New ZipOrCity
    '                x.Category = "Zip"
    '                x.Value = zci.ToString
    '                arZipCity.Add(x)
    '            Next
    '            slct += ("Zip(s):(" & cntZ & ")") & vbCrLf
    '            Dim gc As ZipOrCity
    '            Dim zps As String = ""
    '            For Each gc In arZipCity
    '                zps += (gc.Category & ":=" & gc.Value) & vbCrLf
    '            Next
    '            slct += zps
    '        Else
    '            Dim zc As CheckedListBox.CheckedItemCollection = Me.chlstZipCity.CheckedItems
    '            Dim cntZ As Integer = zc.Count
    '            Dim zci As String = ""
    '            For Each zci In zc
    '                Dim x As New ZipOrCity
    '                x.Category = "City"
    '                x.Value = zci.ToString
    '                arZipCity.Add(x)
    '            Next
    '            slct += ("City(s):(" & cntZ & ")") & vbCrLf
    '            Dim ga As ZipOrCity
    '            Dim zps As String = ""
    '            For Each ga In arZipCity
    '                zps += (ga.Category & ":=" & ga.Value) & vbCrLf
    '            Next
    '            slct += zps
    '        End If


    '        '' marketing results
    '        '' 
    '        Dim arMarketing As New ArrayList
    '        Dim m As CheckedListBox.CheckedItemCollection = Me.chlstWC.CheckedItems
    '        Dim mm As String
    '        For Each mm In m
    '            arMarketing.Add(mm)
    '        Next

    '        ''DEBUG purposes only
    '        '' 
    '        Dim cntM As Integer = arMarketing.Count
    '        slct += ("Marketing Results(s):(" & cntM.ToString & ")" & vbCrLf)
    '        Dim mar As String = ""
    '        For Each bc As String In arMarketing
    '            mar += (bc) & vbCrLf
    '        Next
    '        slct += mar
    '        '' END DEBUG


    '        '' Group By / Sorting

    '        Dim arGroups As New ArrayList
    '        Dim g As CheckedListBox.CheckedItemCollection = Me.chlstOrderBy.CheckedItems
    '        Dim gg As String
    '        For Each gg In g
    '            arGroups.Add(gg)
    '        Next

    '        ''DEBUG purposes only
    '        '' 
    '        Dim cntG As Integer = arGroups.Count
    '        Dim grp As String = ""
    '        For Each pr As String In arGroups
    '            grp += ("Sort Item: " & pr) & vbCrLf
    '        Next
    '        '' END DEBUG

    '        If Me.chGroupBy.CheckState = CheckState.Checked Then
    '            slct += "Group Top Item?: True" & vbCrLf
    '            slct += "Grouping: " & arGroups(0).ToString & vbCrLf
    '            Dim selSTR As String = ""
    '            For cntG = 1 To arGroups.Count - 1
    '                selSTR += ("Sort Item: " & arGroups(cntG).ToString) & vbCrLf
    '            Next
    '            slct += selSTR
    '        Else
    '            slct += "Group Top Item?: False" & vbCrLf
    '            slct += grp
    '        End If



    '        ''
    '        '' on to setting error provider when no criteria selected per tab
    '        '' build tandem: count records query
    '        '' 
    '        Dim strLine1 As String = ""
    '        Dim strQuery As String = ""


    '        '' date time:
    '        '' 

    '        strQuery += "WHERE EnterLead.LeadGeneratedOn > '" & Me.txtGenerated.Text & "' " & vbCrLf
    '        strQuery += " and EnterLead.LeadGeneratedOn Between '" & Me.txtFrom.Text & "' and '" & Me.txtTo.Text & "' " & vbCrLf
    '        strQuery += " and EnterLead.ApptTime Between '" & Me.txtTimeFrom.Text & "' and '" & Me.txtTimeTo.Text & "' " & vbCrLf
    '        If Me.chWeekdays.CheckState = CheckState.Checked Then
    '            strQuery += " and (EnterLead.ApptDay = 'Monday' or EnterLead.ApptDay = 'Tuesday' or EnterLead.ApptDay = 'Wednesday' or  EnterLead.ApptDay = 'Thursday' or  EnterLead.ApptDay = 'Friday') " & vbCrLf
    '        Else
    '            strQuery += " and (EnterLead.ApptDay = 'Monday' or EnterLead.ApptDay = 'Tuesday' or EnterLead.ApptDay = 'Wednesday' or  EnterLead.ApptDay = 'Thursday' or  EnterLead.ApptDay = 'Friday' or EnterLead.ApptDay = 'Saturday' or EnterLead.ApptDay = 'Sunday') " & vbCrLf
    '        End If

    '        '' marketers
    '        ''
    '        If arMarketers.Count > 0 Then
    '            strQuery += " and (EnterLead.Marketer = "

    '            Dim MarketerStr As String = ""
    '            Dim cnt_M As Integer = 0
    '            For cnt_M = 0 To arMarketers.Count - 1
    '                If cnt_M = (arMarketers.Count - 1) Then
    '                    '' end of line 
    '                    '' no comma 
    '                    MarketerStr += ("'" & arMarketers(cnt_M) & "')") & vbCrLf
    '                Else
    '                    '' add a comma because there is more.
    '                    '' 
    '                    MarketerStr += "'" & arMarketers(cnt_M) & "' or EnterLead.Marketer = "
    '                End If
    '            Next
    '            strQuery += MarketerStr
    '        Else
    '            strQuery = strQuery
    '        End If





    '        '' Products

    '        If arProducts.Count > 0 Then
    '            strQuery += " and ( "
    '            Dim ProdSTR As String = ""
    '            Dim cnt_P As Integer = 0

    '            For cnt_P = 0 To arProducts.Count - 1
    '                If cnt_P = (arProducts.Count - 1) Then
    '                    '' end of line
    '                    '' no comma
    '                    ProdSTR += ("EnterLead.Product1 = '" & arProducts(cnt_P) & "' or EnterLead.Product2 = '" & arProducts(cnt_P) & "' or EnterLead.Product3 = '" & arProducts(cnt_P) & "') ") & vbCrLf
    '                Else
    '                    ProdSTR += " EnterLead.Product1 = '" & arProducts(cnt_P) & "' or EnterLead.Product2 = '" & arProducts(cnt_P) & "' or EnterLead.Product3 = '" & arProducts(cnt_P) & "' or "
    '                End If
    '            Next
    '            strQuery += ProdSTR
    '        Else
    '            strQuery = strQuery
    '        End If

    '        If arZipCity.Count > 0 Then
    '            strQuery += " and ( "
    '            Dim zipCitySTR As String = ""
    '            Dim Item0 As ZipOrCity = arZipCity.Item(0)
    '            Dim cat As String = Item0.Category
    '            Dim cntZC As Integer = 0

    '            For cntZC = 0 To arZipCity.Count - 1
    '                If cntZC = (arZipCity.Count - 1) Then
    '                    '' end of line
    '                    '' no comma
    '                    Dim item As ZipOrCity = arZipCity(cntZC)
    '                    zipCitySTR += "EnterLead." & cat.ToString & " = '" & item.Value & "') "
    '                Else
    '                    Dim item As ZipOrCity = arZipCity(cntZC)
    '                    zipCitySTR += "EnterLead." & cat.ToString & " = '" & item.Value & "' or "
    '                End If
    '            Next
    '            strQuery += zipCitySTR
    '        Else
    '            strQuery = strQuery
    '        End If

    '        '' MarketingResults

    '        If arMarketing.Count > 0 Then
    '            strQuery += " and ( "
    '            Dim markSTR As String = ""
    '            Dim cntMRK As Integer = 0
    '            For cntMRK = 0 To arMarketing.Count - 1
    '                If cntMRK = (arMarketing.Count - 1) Then
    '                    markSTR += "EnterLead.MarketingResults = '" & arMarketing(cntMRK) & "') "
    '                Else
    '                    markSTR += "EnterLead.MarketingResults = '" & arMarketing(cntMRK) & "' or "
    '                End If
    '            Next
    '            strQuery += markSTR
    '        Else
    '            strQuery = strQuery
    '        End If



    '        '' Group BY 
    '        ''
    '        Dim chkState As CheckState = Me.chGroupBy.CheckState
    '        Dim grpING As String = ""
    '        Select Case chkState
    '            Case Is = CheckState.Checked
    '                '' grouping 'yes'
    '                If arGroups.Count >= 1 Then
    '                    strLine1 = "SELECT DISTINCT(dbo.[EnterLead].[ID]), " & arGroups(0).ToString & " AS '" & arGroups(0).ToString & "' FROM dbo.[EnterLead] " & vbCrLf
    '                    strQuery += "GROUP BY EnterLead." & arGroups(0).ToString & ", EnterLead.ID " & vbCrLf
    '                    strQuery += "ORDER BY EnterLead." & arGroups(0).ToString & " ASC;" & vbCrLf
    '                    grpING = arGroups(0).ToString
    '                    Dim qryP As String = strQuery
    '                    strQuery = (strLine1 & vbCrLf & qryP) & vbCrLf
    '                Else
    '                    strLine1 = "SELECT DISTINCT(dbo.[EnterLead].[ID]) FROM dbo.[EnterLead] " & vbCrLf
    '                    strQuery = (strLine1 & vbCrLf & strQuery)
    '                End If
    '                Exit Select
    '            Case Is = CheckState.Unchecked
    '                '' grouping 'no'
    '                strLine1 = "SELECT DISTINCT(dbo.[EnterLead].[ID]) FROM dbo.[EnterLead] " & vbCrLf
    '                strQuery = (strLine1 & vbCrLf & strQuery)
    '                Exit Select
    '            Case Is = CheckState.Indeterminate
    '                '' grouping 'no'
    '                strLine1 = "SELECT DISTINCT(dbo.[EnterLead].[ID]) FROM dbo.[EnterLead] " & vbCrLf
    '                strQuery = (strLine1 & vbCrLf & strQuery)
    '                Exit Select
    '            Case Else
    '                '' grouping 'no'
    '                strLine1 = "SELECT DISTINCT(dbo.[EnterLead].[ID]) FROM dbo.[EnterLead] " & vbCrLf
    '                strQuery = (strLine1 & vbCrLf & strQuery)
    '                Exit Select
    '        End Select

    '        Return strQuery

    '    End Function

    '#End Region

#End Region


#Region "Andy's Copy And Paste Code - Project MarketingLists"






    Private Sub frmWCList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cboDateRange.Items.AddRange(New Object() {"All", "Today", "Yesterday", "This Week", "This Week - to date", "This Month", "This Month - to date", "This Year", "This Year - to date", "Next Week", "Next Month", "Last Week", "Last Week - to date", "Last Month", "Last Month - to date", "Last Year", "Last Year - to date", "Custom"})

        '' MERGE CODE 10-7-2015
        Dim mpt As New MAPPOINT_LOGIC_V2
        Dim arStates As ArrayList = mpt.Get_Unique_States
        For Each xx As Object In arStates
            Me.cboStateSelection.Items.Add(xx.ToString)
        Next
        '' make sure lbl and cbo are invisible at launch 
        '' 
        Me.lblStateSelect.Visible = False
        Me.cboStateSelection.Visible = False

        'Dim cnn As SqlConnection = New SqlConnection(STATIC_VARIABLES.Cnn)
        'Dim cmdGet As SqlCommand = New SqlCommand("dbo.GetProducts", cnn)
        'cmdGet.CommandType = CommandType.StoredProcedure
        'Try
        '    cnn.Open()
        '    Dim r1 As SqlDataReader
        '    r1 = cmdGet.ExecuteReader(CommandBehavior.CloseConnection)
        '    Me.chlstProducts.Items.Clear()

        '    While r1.Read
        '        Me.chlstProducts.Items.Add(r1.Item(0))
        '    End While
        '    cnn.Close()
        'Catch ex As Exception
        '    Dim y As New ErrorLogging_V2
        '    y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmCreateList", "FormCode", "sub", "LoadComplete", "0", ex.Message.ToString)
        '    y = Nothing
        'End Try




        'For x As Integer = 0 To Me.chlstProducts.Items.Count - 1
        '    Me.chlstProducts.SetItemChecked(x, True)
        'Next

        Me.cboDateRange.SelectedItem = Nothing


        Me.btnCheckWC_Click(Nothing, Nothing)

        Me.chWeekdays.Checked = False

        Me.txtFrom.Tag = Me.dpFrom.Value.ToShortDateString
        Me.txtTo.Tag = Me.dpTo.Value.ToShortDateString
        Me.txtTimeFrom.Tag = Me.tpFrom.Value.ToShortTimeString
        Me.txtTimeTo.Tag = Me.tpTo.Value.ToShortTimeString
        Me.LoadComplete = True
    End Sub

    Private Sub cboDateRange_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDateRange.SelectedIndexChanged
        If Me.cboDateRange.Text <> "Custom" Then
            If Me.cboDateRange.Text = "All" Then
                Me.dpFrom.Value = "1/1/1900"
                Me.dpTo.Value = "1/1/2100"
                Me.txtFrom.Visible = True
                Me.txtTo.Visible = True
                Exit Sub
            End If

            Me.txtFrom.Visible = False
            Me.txtTo.Visible = False
            Dim d As New DTPManipulation(Me.cboDateRange.Text)
            Me.dpFrom.Text = d.retDateFrom
            Me.dpTo.Text = d.retDateTo

        End If
    End Sub

    Private Sub txtFrom_GotFocus(sender As Object, e As EventArgs) Handles txtFrom.GotFocus
        Me.dpFrom.Focus()
    End Sub

    Private Sub txtTo_DragDrop(sender As Object, e As DragEventArgs) Handles txtTo.DragDrop
        Me.dpTo.Focus()
    End Sub

    Private Sub dpFrom_GotFocus(sender As Object, e As EventArgs) Handles dpFrom.GotFocus
        If Me.LoadComplete = False Then
            Exit Sub
        End If

        Me.txtFrom.Visible = False
        Me.cboDateRange.SelectedItem = "Custom"
        If Me.dpFrom.Value.ToShortDateString = "1/1/1900" Then
            Me.dpFrom.Value = Today()
        End If
    End Sub

    Private Sub dpTo_GotFocus(sender As Object, e As EventArgs) Handles dpTo.GotFocus
        If Me.LoadComplete = False Then
            Exit Sub
        End If
        Me.txtTo.Visible = False
        Me.cboDateRange.SelectedItem = "Custom"
        If Me.dpTo.Value.ToShortDateString = "1/1/2100" Then
            Me.dpTo.Value = Today()
        End If
    End Sub

    Private Sub dpTo_ValueChanged1(sender As Object, e As EventArgs) Handles dpTo.ValueChanged
        If Me.LoadComplete = False Then
            Exit Sub
        End If
        Me.txtTo.Tag = Me.dpTo.Value.ToShortDateString
    End Sub

    Private Sub dpFrom_ValueChanged1(sender As Object, e As EventArgs) Handles dpFrom.ValueChanged
        If Me.LoadComplete = False Then
            Exit Sub
        End If
        Me.txtFrom.Tag = Me.dpFrom.Value.ToShortDateString
    End Sub

    Private Sub dpGenerated_GotFocus(sender As Object, e As EventArgs) Handles dpGenerated.GotFocus
        Me.txtGenerated.Visible = False
        If Me.dpGenerated.Value = "1/1/1900 12:00 AM" Then
            'MsgBox("hit")
            Me.dpGenerated.Value = Today()
        End If


    End Sub

    Private Sub txtGenerated_GotFocus(sender As Object, e As EventArgs) Handles txtGenerated.GotFocus
        Me.dpGenerated.Focus()
    End Sub

    Private Sub dpGenerated_ValueChanged1(sender As Object, e As EventArgs) Handles dpGenerated.ValueChanged
        Me.txtGenerated.Tag = Me.dpGenerated.Value.ToShortDateString
    End Sub

    Private Sub txtTimeFrom_GotFocus(sender As Object, e As EventArgs) Handles txtTimeFrom.GotFocus
        Me.tpFrom.Focus()
    End Sub

    Private Sub txtTimeTo_GotFocus(sender As Object, e As EventArgs) Handles txtTimeTo.GotFocus
        Me.tpTo.Focus()
    End Sub

    Private Sub tpFrom_GotFocus(sender As Object, e As EventArgs) Handles tpFrom.GotFocus
        Me.txtTimeFrom.Visible = False
        If Me.tpFrom.Value = "1/1/1900 12:00 AM" Then
            Me.tpFrom.Value = "1/1/1900 10:00 AM"
        End If
    End Sub

    Private Sub tpTo_GotFocus(sender As Object, e As EventArgs) Handles tpTo.GotFocus
        Me.txtTimeTo.Visible = False
        If Me.tpTo.Value = "1/1/1900 11:59 PM" Then
            Me.tpTo.Value = "1/1/1900 8:00 PM"
        End If
    End Sub

    Private Sub tpTo_ValueChanged1(sender As Object, e As EventArgs) Handles tpTo.ValueChanged
        Me.txtTimeTo.Tag = Me.tpTo.Value.ToShortTimeString
    End Sub

    Private Sub tpFrom_ValueChanged1(sender As Object, e As EventArgs) Handles tpFrom.ValueChanged
        Me.txtTimeFrom.Tag = Me.tpFrom.Value.ToShortTimeString
    End Sub

    Private Sub btnCheckProducts_Click1(sender As Object, e As EventArgs) Handles btnCheckProducts.Click
        For x As Integer = 0 To Me.chlstProducts.Items.Count - 1
            Me.chlstProducts.SetItemChecked(x, True)
        Next
    End Sub

    Private Sub btnUncheckProducts_Click1(sender As Object, e As EventArgs) Handles btnUncheckProducts.Click
        For x As Integer = 0 To Me.chlstProducts.Items.Count - 1
            Me.chlstProducts.SetItemChecked(x, False)
        Next
    End Sub

    Private Sub rdoCity_CheckedChanged1(sender As Object, e As EventArgs) Handles rdoCity.CheckedChanged
        Dim rdo As RadioButton = sender
        If rdo.Checked = True Then

            Me.chlstZipCity.Items.Clear()
            Me.txtZipCity.Text = ""
            Me.Label9.Text = "Enter Starting City:"
            Me.Label10.Text = "Show Cities Within"
            Me.Label11.Text = "Miles of Starting City"
            Me.btnShow.Text = "Show Cities"
            Me.lblStateSelect.Visible = True
            Me.cboStateSelection.Visible = True
            Me.tabGeo.Refresh()
            'Me.BackgroundWorkerCity.RunWorkerAsync()
            Me.BackgroundWorkerCity_DoWork(Nothing, Nothing)
        End If

    End Sub

    Private Sub rdoZip_CheckedChanged1(sender As Object, e As EventArgs) Handles rdoZip.CheckedChanged
        Dim rdo As RadioButton = sender
        If rdo.Checked = True Then
            Me.chlstZipCity.Items.Clear()
            Me.txtZipCity.Text = ""
            Me.Label9.Text = "Enter Starting Zip Code:"
            Me.Label10.Text = "Show Zip Codes Within"
            Me.Label11.Text = "Miles of Starting Zip Code"
            Me.btnShow.Text = "Show Zip Codes"
            Me.lblStateSelect.Visible = False
            Me.cboStateSelection.Visible = False
            Me.tabGeo.Refresh()
            ' Me.BackgroundWorkerZip.RunWorkerAsync()
            Me.BackgroundWorkerZip_DoWork(Nothing, Nothing)
        End If
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Me.epGeo.Clear()
        If Me.rdoZip.Checked = True And Me.txtZipCity.Text = "" Then
            Me.epGeo.SetError(Me.txtZipCity, "You Must Enter A Starting Zip Code!")
            Exit Sub
        End If
        Dim x As Integer = Me.txtZipCity.TextLength

        If Me.rdoZip.Checked = True And x <> 5 Then
            Me.epGeo.SetError(Me.txtZipCity, "You Must Enter A Valid Zip Code!")
            Exit Sub
        End If
        If Me.rdoZip.Checked = True Then
            For z As Integer = 1 To Me.txtZipCity.TextLength
                Dim c As Char = GetChar(Me.txtZipCity.Text, z)
                If (c = "0") Or (c = "1") Or (c = "2") Or (c = "3") Or (c = "4") Or (c = "5") Or (c = "6") Or (c = "7") Or (c = "8") Or (c = "9") Then
                Else
                    Me.epGeo.SetError(Me.txtZipCity, "Zip Codes Only Contain Numbers!")
                    Exit Sub
                End If
            Next
        End If
        If Me.rdoCity.Checked = True And Me.txtZipCity.Text = "" Then
            Me.epGeo.SetError(Me.txtZipCity, "You Must Enter A Starting City!")
            Exit Sub
        End If
        If Me.numMiles.Value = 0 Then
            Me.epGeo.SetError(Me.numMiles, "Radius Search Must Be 1 Mile Or More!")
            Exit Sub
        End If
        ''Call Mappoint search for city, if doesnt exist fire code below
        ''msgbox("Cannot Find City!)
        ''Me.txtZipCity.SelectAll()
        ''If more than 1 exists fire form with listview containing city and state to select appropriate city then click ok button and continue mappoint query


        '' MERGE CODE: 10-7-2015
        '' 
        ''    Add Mappoint query code to populate chlstZipCity then loop to check all
        Try
            Dim mpt As New MAPPOINT_LOGIC_V2
            Select Case btnShow.Text
                Case "Show Zip Codes"
                    Me.chlstZipCity.Items.Clear()
                    Dim arResults As New ArrayList
                    Dim BeginList As List(Of MAPPOINT_LOGIC_V2.ZipState)
                    BeginList = mpt.GetUniqueZipState
                    Me.Cursor = Cursors.WaitCursor
                    Dim StartState As String = mpt.Get_STATE_ForZip(Me.txtZipCity.Text)
                    arResults = mpt.Search_Radius_ZipCode(BeginList, Me.numMiles.Value, Me.txtZipCity.Text, StartState)
                    Dim g As Object
                    For Each g In arResults
                        Me.chlstZipCity.Items.Add(g.ToString)
                    Next
                    Me.Cursor = Cursors.Default
                    Exit Select
                Case "Show Cities"
                    Me.chlstZipCity.Items.Clear()
                    Dim arResults As New ArrayList
                    Dim BeginList As List(Of MAPPOINT_LOGIC_V2.CityState)
                    BeginList = mpt.GetUniqueCityState
                    Me.Cursor = Cursors.WaitCursor
                    Dim Start_State As String = mpt.Get_STATE_ForCity(Me.txtZipCity.Text)
                    arResults = mpt.Search_Radius_City(BeginList, Me.numMiles.Value, Me.txtZipCity.Text, Me.cboStateSelection.Text)
                    Dim g As Object
                    For Each g In arResults
                        Me.chlstZipCity.Items.Add(g.ToString)
                    Next
                    Me.Cursor = Cursors.Default
                    Exit Select
            End Select
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmCreateList", "FormCode", "sub", "btnShow_Click", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub btnCheckZip_Click(sender As Object, e As EventArgs) Handles btnCheckZip.Click
        For x As Integer = 0 To Me.chlstZipCity.Items.Count - 1
            Me.chlstZipCity.SetItemChecked(x, True)
        Next
    End Sub

    Private Sub btnUncheckZip_Click(sender As Object, e As EventArgs) Handles btnUncheckZip.Click
        For x As Integer = 0 To Me.chlstZipCity.Items.Count - 1
            Me.chlstZipCity.SetItemChecked(x, False)
        Next
    End Sub

    Private Sub btnCheckWC_Click(sender As Object, e As EventArgs) Handles btnCheckWC.Click
        For x As Integer = 0 To Me.chlstWC.Items.Count - 1
            Me.chlstWC.SetItemChecked(x, True)
        Next
    End Sub

    Private Sub btnUncheckWC_Click1(sender As Object, e As EventArgs) Handles btnUncheckWC.Click
        If Me.chlstWC.Enabled = False Then
            Exit Sub
        End If
        For x As Integer = 0 To Me.chlstWC.Items.Count - 1
            Me.chlstWC.SetItemChecked(x, False)
        Next
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Me.epForm.Clear()
        Me.epGeo.Clear()
        Me.cboDateRange.SelectedItem = Nothing
        Me.txtRecordCount.Text = ""
        Me.dpGenerated.Value = "1/1/1900 12:00 AM"
        Me.txtGenerated.Visible = True
        Me.dpFrom.Value = "1/1/1900 12:00 AM"
        Me.txtFrom.Visible = True
        Me.dpTo.Value = "1/1/2100 12:00 AM"
        Me.txtTo.Visible = True
        Me.tpFrom.Value = "1/1/1900 12:00 AM"
        Me.txtTimeFrom.Visible = True
        Me.tpTo.Value = "1/1/1900 11:59 PM"
        Me.txtTimeTo.Visible = True
        Me.chWeekdays.Checked = False
        For x As Integer = 0 To Me.chlstProducts.Items.Count - 1
            Me.chlstProducts.SetItemChecked(x, True)
        Next
        Me.numMiles.Value = 0
        Me.txtZipCity.Text = ""
        Me.chlstZipCity.Items.Clear()
        Me.TabControl1.SelectTab(0)
        'Me.chlstOrderBy.Items.Remove("Reference Rating")
        'Me.chlstOrderBy.Items.Remove("Cash")
        'Me.chlstOrderBy.Items.Remove("Finance")
        'Me.chlstOrderBy.Items.Remove("Sale Closed Date")
        'Me.chlstOrderBy.Items.Remove("Loan Satisfied Date")
        'Me.chlstOrderBy.Items.Remove("Approved Loan Amount")
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub

    Private Sub tabDate_Leave(sender As Object, e As EventArgs) Handles tabDate.Leave
        Try
            Me.chlstMarketers.Items.Clear()
            Dim cnn As SqlConnection = New SqlConnection(STATIC_VARIABLES.Cnn)
            Dim cmdGet As SqlCommand
            Dim r1 As SqlDataReader
            If Me.chWeekdays.Checked = True Then
                cmdGet = New SqlCommand("Select Distinct(Marketer) from enterlead join tblWherecanleadgo on enterlead.id = tblwherecanleadgo.leadnumber where ApptDate Between '" & Me.dpFrom.Value.ToString & "' and '" & Me.dpTo.Value.ToString & "' and ApptTime Between '" & Me.tpFrom.Value.ToString & "' and '" & Me.tpTo.Value.ToString & "' and LeadGeneratedOn >= '" & Me.dpGenerated.Value.ToString & "' and (ApptDay <> 'Saturday' and ApptDay <> 'Sunday') and warmcall = 'True' order by marketer asc", cnn)
            Else
                cmdGet = New SqlCommand("Select Distinct(Marketer) from enterlead join tblWherecanleadgo on enterlead.id = tblwherecanleadgo.leadnumber where ApptDate Between '" & Me.dpFrom.Value.ToString & "' and '" & Me.dpTo.Value.ToString & "' and ApptTime Between '" & Me.tpFrom.Value.ToString & "' and '" & Me.tpTo.Value.ToString & "' and LeadGeneratedOn >= '" & Me.dpGenerated.Value.ToString & "' and warmcall = 'True' order by marketer asc", cnn)
            End If

            cmdGet.CommandType = CommandType.Text
            cnn.Open()
            r1 = cmdGet.ExecuteReader(CommandBehavior.CloseConnection)
            While r1.Read()
                If r1.Item(0) <> "" Then
                    Me.chlstMarketers.Items.Add(r1.Item(0))
                End If
            End While
            For x As Integer = 0 To Me.chlstMarketers.Items.Count - 1
                Me.chlstMarketers.SetItemChecked(x, True)
            Next

        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "tabDate_Leave", "FormCode", "sub", "tabDate_Leave", "0", ex.Message.ToString)
            y = Nothing
        End Try
        Try
            Me.chlstProducts.Items.Clear()
            Dim cnn As SqlConnection = New SqlConnection(STATIC_VARIABLES.Cnn)
            Dim cmdGet As SqlCommand
            Dim r1 As SqlDataReader
            If Me.chWeekdays.Checked = True Then
                cmdGet = New SqlCommand("Select enterlead.product1 from enterlead join tblWherecanleadgo on enterlead.id = tblwherecanleadgo.leadnumber where ApptDate Between '" & Me.dpFrom.Value.ToString & "' and '" & Me.dpTo.Value.ToString & "' and ApptTime Between '" & Me.tpFrom.Value.ToString & "' and '" & Me.tpTo.Value.ToString & "' and LeadGeneratedOn >= '" & Me.dpGenerated.Value.ToString & "' and (ApptDay <> 'Saturday' and ApptDay <> 'Sunday') and warmcall = 'True' union select enterlead.product2 from enterlead join tblWherecanleadgo on enterlead.id = tblwherecanleadgo.leadnumber where ApptDate Between '" & Me.dpFrom.Value.ToString & "' and '" & Me.dpTo.Value.ToString & "' and ApptTime Between '" & Me.tpFrom.Value.ToString & "' and '" & Me.tpTo.Value.ToString & "' and LeadGeneratedOn >= '" & Me.dpGenerated.Value.ToString & "' and (ApptDay <> 'Saturday' and ApptDay <> 'Sunday') and warmcall = 'True' union select enterlead.product3 from enterlead join tblWherecanleadgo on enterlead.id = tblwherecanleadgo.leadnumber where ApptDate Between '" & Me.dpFrom.Value.ToString & "' and '" & Me.dpTo.Value.ToString & "' and ApptTime Between '" & Me.tpFrom.Value.ToString & "' and '" & Me.tpTo.Value.ToString & "' and LeadGeneratedOn >= '" & Me.dpGenerated.Value.ToString & "' and (ApptDay <> 'Saturday' and ApptDay <> 'Sunday') and warmcall = 'True' order by product1 asc", cnn)
            Else
                cmdGet = New SqlCommand("Select enterlead.product1 from enterlead join tblWherecanleadgo on enterlead.id = tblwherecanleadgo.leadnumber where ApptDate Between '" & Me.dpFrom.Value.ToString & "' and '" & Me.dpTo.Value.ToString & "' and ApptTime Between '" & Me.tpFrom.Value.ToString & "' and '" & Me.tpTo.Value.ToString & "' and LeadGeneratedOn >= '" & Me.dpGenerated.Value.ToString & "' and warmcall = 'True' union select enterlead.product2 from enterlead join tblWherecanleadgo on enterlead.id = tblwherecanleadgo.leadnumber where ApptDate Between '" & Me.dpFrom.Value.ToString & "' and '" & Me.dpTo.Value.ToString & "' and ApptTime Between '" & Me.tpFrom.Value.ToString & "' and '" & Me.tpTo.Value.ToString & "' and LeadGeneratedOn >= '" & Me.dpGenerated.Value.ToString & "' and warmcall = 'True' union select enterlead.product3 from enterlead join tblWherecanleadgo on enterlead.id = tblwherecanleadgo.leadnumber where ApptDate Between '" & Me.dpFrom.Value.ToString & "' and '" & Me.dpTo.Value.ToString & "' and ApptTime Between '" & Me.tpFrom.Value.ToString & "' and '" & Me.tpTo.Value.ToString & "' and LeadGeneratedOn >= '" & Me.dpGenerated.Value.ToString & "' and warmcall = 'True' order by Product1 asc", cnn)
            End If

            cmdGet.CommandType = CommandType.Text
            cnn.Open()
            r1 = cmdGet.ExecuteReader(CommandBehavior.CloseConnection)
            While r1.Read()
                If r1.Item(0) <> "" Then
                    Me.chlstProducts.Items.Add(r1.Item(0))
                End If
            End While
            For x As Integer = 0 To Me.chlstProducts.Items.Count - 1
                Me.chlstProducts.SetItemChecked(x, True)
            Next
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "tabDate_Leave", "FormCode", "sub", "tabDate_Leave", "0", ex.Message.ToString)
            y = Nothing
        End Try
        If Me.rdoZip.Checked = True Then
            Me.BackgroundWorkerZip_DoWork(Nothing, Nothing)
        Else
            Me.BackgroundWorkerCity_DoWork(Nothing, Nothing)
        End If
        ' Me.BackgroundWorkerZip.RunWorkerAsync()
    End Sub

    Private Sub btnCheckOrderBy_Click1(sender As Object, e As EventArgs) Handles btnCheckOrderBy.Click
        For x As Integer = 0 To Me.chlstOrderBy.Items.Count - 1
            Me.chlstOrderBy.SetItemChecked(x, True)
        Next
    End Sub

    Private Sub btnUnCheckOrderBy_Click1(sender As Object, e As EventArgs) Handles btnUnCheckOrderBy.Click
        For x As Integer = 0 To Me.chlstOrderBy.Items.Count - 1
            Me.chlstOrderBy.SetItemChecked(x, False)
        Next
    End Sub

    Private Sub btnUp_Click1(sender As Object, e As EventArgs) Handles btnUp.Click
        If Me.chlstOrderBy.SelectedItems.Count = 0 Then
            Exit Sub
        End If
        If Me.chlstOrderBy.SelectedIndex = 0 Then
            Exit Sub
        End If
        If Me.chlstOrderBy.SelectedIndex > 0 Then
            Dim Index As Integer = Me.chlstOrderBy.Items.IndexOf(Me.chlstOrderBy.SelectedItem)
            Dim What As String = Me.chlstOrderBy.SelectedItem.ToString
            Dim ChkState As Boolean = Me.chlstOrderBy.GetItemCheckState(Index)
            Me.chlstOrderBy.Items.RemoveAt(Index)
            Me.chlstOrderBy.Items.Insert(Index - 1, What)
            Me.chlstOrderBy.SelectedItem = What
            If ChkState = True Then
                Me.chlstOrderBy.SetItemCheckState(Index - 1, CheckState.Checked)
            Else
                Me.chlstOrderBy.SetItemCheckState(Index - 1, CheckState.Unchecked)
            End If
        End If
    End Sub

    Private Sub btnDown_Click1(sender As Object, e As EventArgs) Handles btnDown.Click
        If Me.chlstOrderBy.SelectedItems.Count = 0 Then
            Exit Sub
        End If
        If Me.chlstOrderBy.SelectedIndex = Me.chlstOrderBy.Items.Count - 1 Then
            Exit Sub
        End If
        If Me.chlstOrderBy.SelectedIndex < Me.chlstOrderBy.Items.Count - 1 Then
            Dim Index As Integer = Me.chlstOrderBy.Items.IndexOf(Me.chlstOrderBy.SelectedItem)
            Dim What As String = Me.chlstOrderBy.SelectedItem.ToString
            Dim ChkState As Boolean = Me.chlstOrderBy.GetItemCheckState(Index)
            Me.chlstOrderBy.Items.RemoveAt(Index)
            Me.chlstOrderBy.Items.Insert(Index + 1, What)
            Me.chlstOrderBy.SelectedItem = What
            If ChkState = True Then
                Me.chlstOrderBy.SetItemCheckState(Index + 1, CheckState.Checked)
            Else
                Me.chlstOrderBy.SetItemCheckState(Index + 1, CheckState.Unchecked)
            End If


        End If
    End Sub

    Private Sub checkMarketers_Click1(sender As Object, e As EventArgs) Handles checkMarketers.Click
        For x As Integer = 0 To Me.chlstMarketers.Items.Count - 1
            Me.chlstMarketers.SetItemChecked(x, True)
        Next
    End Sub

    Private Sub uncheckMarketers_Click1(sender As Object, e As EventArgs) Handles uncheckMarketers.Click
        For x As Integer = 0 To Me.chlstMarketers.Items.Count - 1
            Me.chlstMarketers.SetItemChecked(x, False)
        Next
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        'Try
        'Me.RichTextBox1.Text = "" ''Remove After Testing 


        Me.tabDate.ImageKey = Nothing
        Me.tabDate.ToolTipText = ""
        Me.tabProducts.ImageKey = Nothing
        Me.tabProducts.ToolTipText = ""
        Me.tabGeo.ImageKey = Nothing
        Me.tabGeo.ToolTipText = ""
        Me.tabWC.ImageKey = Nothing
        Me.tabWC.ToolTipText = ""

        Me.tabMarketers.ImageKey = Nothing
        Me.tabMarketers.ToolTipText = ""

        Me.epForm.Clear()
        Me.epGeo.Clear()
        Dim tabDate As Integer = 0
        Dim tabProd As Integer = 0
        Dim tabGeo As Integer = 0
        Dim tabWC As Integer = 0
        Dim tabPC As Integer = 0
        Dim tabRehash As Integer = 0
        Dim tabMarketer As Integer = 0

        ''Date/Time Tab 
        If Me.dpFrom.Value.ToShortDateString <> "1/1/1900" And Me.dpTo.Value.ToShortDateString = "1/1/2100" Then              '' Change If Statement to reflect datepicker value instead of visible properties
            Me.epForm.SetError(Me.dpTo, "You Must Supply a Date!")
            tabDate += 1
        End If
        If Me.dpFrom.Value.ToShortDateString = "1/1/1900" And Me.dpTo.Value.ToShortDateString <> "1/1/2100" Then              '' Change If Statement to reflect datepicker value instead of visible properties
            Me.epForm.SetError(Me.dpFrom, "You Must Supply a Date!")
            tabDate += 1
        End If
        If Me.tpFrom.Value.ToShortTimeString = "12:00 AM" And Me.tpTo.Value.ToShortTimeString <> "11:59 PM" Then
            Me.epForm.SetError(Me.tpFrom, "You Must Supply a Time!")
            tabDate += 1
        End If
        If Me.tpFrom.Value.ToShortTimeString <> "12:00 AM" And Me.tpTo.Value.ToShortTimeString = "11:59 PM" Then
            Me.epForm.SetError(Me.tpTo, "You Must Supply a Time!")
            tabDate += 1
        End If

        ''Marketers Tab 
        If Me.chlstMarketers.CheckedItems.Count <= 0 Then
            Me.epForm.SetError(Me.chlstMarketers, "You Must Select at Least One Marketer!")
            tabMarketer += 1
        End If
        ''Products Tab
        If Me.chlstProducts.CheckedItems.Count <= 0 Then
            Me.epForm.SetError(Me.chlstProducts, "You Must Select at Least One Product!")
            tabProd += 1
        End If

        ''Geo Tab 
        If Me.chlstZipCity.Items.Count > 0 And Me.chlstZipCity.CheckedItems.Count <= 0 Then
            If Me.rdoZip.Checked = True Then
                Me.epForm.SetError(Me.chlstProducts, "You Must Select at Least One Zip Code!")
                tabGeo += 1
            Else
                Me.epForm.SetError(Me.chlstProducts, "You Must Select at Least One City!")

                Me.epForm.SetIconPadding(Me.chlstProducts, 20)
                tabGeo += 1
            End If
        End If

        ''Warm Calling Tab
        If Me.chlstWC.CheckedItems.Count <= 0 Then
            Me.epForm.SetError(Me.chlstWC, "You Must Select at Least One Marketing Result!")
            tabWC += 1
        End If

        ' ''Previous Customer Tab
        'If Me.chPC.Checked = True Then
        '    If Me.chApprovedFor.Checked = True And Me.txtApprovedDollars.Text = "" Then
        '        Me.epForm.SetError(Me.txtApprovedDollars, "You Must Supply a Dollar Amount! ")
        '        tabPC += 1
        '    End If
        '    If Me.chApprovedFor.Checked = True Then
        '        For z As Integer = 1 To Me.txtApprovedDollars.TextLength
        '            Dim c As Char = GetChar(Me.txtApprovedDollars.Text, z)
        '            If (c = "0") Or (c = "1") Or (c = "2") Or (c = "3") Or (c = "4") Or (c = "5") Or (c = "6") Or (c = "7") Or (c = "8") Or (c = "9") Then
        '            Else
        '                Me.epGeo.SetError(Me.txtApprovedDollars, "Field Can Only Contain Numbers!")
        '                tabPC += 1

        '            End If
        '        Next
        '    End If
        '    If Me.dpDate1PC.Value.ToShortDateString = "1/1/1900" And Me.dpDate2PC.Value.ToShortDateString <> "1/1/2100" Then
        '        Me.epForm.SetError(Me.dpDate1PC, "You Must Supply a Date!")
        '        tabPC += 1
        '    End If
        '    If Me.dpDate1PC.Value.ToShortDateString <> "1/1/1900" And Me.dpDate2PC.Value.ToShortDateString = "1/1/2100" Then
        '        Me.epForm.SetError(Me.dpDate2PC, "You Must Supply a Date!")
        '        tabPC += 1
        '    End If
        'End If

        ' ''Rehash Tab
        'If Me.chRehash.Checked = True Then
        '    If Me.chlstRehash.CheckedItems.Count <= 0 Then
        '        Me.epForm.SetError(Me.chlstRehash, "You Must Select at Least One Result!")
        '        tabRehash += 1
        '    End If
        '    For z As Integer = 1 To Me.txtQuoted.TextLength
        '        Dim c As Char = GetChar(Me.txtQuoted.Text, z)
        '        If (c = "0") Or (c = "1") Or (c = "2") Or (c = "3") Or (c = "4") Or (c = "5") Or (c = "6") Or (c = "7") Or (c = "8") Or (c = "9") Then
        '        Else
        '            Me.epGeo.SetError(Me.txtQuoted, "Field Can Only Contain Numbers!")
        '            tabRehash += 1
        '        End If
        '    Next
        'End If
        Dim tab As Integer = 0
        If tabDate > 0 Then
            Me.tabDate.ImageIndex = 0
            Me.tabDate.ToolTipText = "Errors on this Tab"
            tab += 1
        End If
        If tabProd > 0 Then
            Me.tabProducts.ImageIndex = 0
            Me.tabProducts.ToolTipText = "Errors on this Tab"
            tab += 1
        End If
        If tabGeo > 0 Then
            Me.tabGeo.ImageIndex = 0
            Me.tabGeo.ToolTipText = "Errors on this Tab"
            tab += 1
        End If
        If tabWC > 0 Then
            Me.tabWC.ImageIndex = 0
            Me.tabWC.ToolTipText = "Errors on this Tab"
            tab += 1
        End If
        'If tabPC > 0 Then
        '    Me.tabPC.ImageIndex = 0
        '    Me.tabPC.ToolTipText = "Errors on this Tab"
        '    tab += 1
        'End If
        'If tabRehash > 0 Then
        '    Me.tabRecovery.ImageIndex = 0
        '    Me.tabRecovery.ToolTipText = "Errors on this Tab"
        '    tab += 1
        'End If
        If tabMarketer > 0 Then
            Me.tabMarketers.ImageIndex = 0
            Me.tabMarketers.ToolTipText = "Errors on this Tab"
            tab += 1
        End If
        If tab > 0 Then
            Exit Sub
        End If

        ''ADD SQL QUERY CODE HERE 
        'MsgBox("Creating List")

        ''Date Tab
        Dim Where As String = ""
        Dim DateQuery As String = ""
        Dim MarkProdGeo As String = ""
        Dim WCQuery As String = ""
        Dim Rehash As String = ""
        Dim PCQuery As String = ""
        Dim Slct As String = "Select Distinct(Enterlead.ID), Contact1LastName, Contact1FirstName, Contact2LastName, Contact2FirstName, StAddress, City, State, Zip, HousePhone, AltPhone1, AltPhone2, Enterlead.Product1, Enterlead.Product2, Enterlead.Product3, LeadGeneratedOn, ApptDate, ApptDay, ApptTime, MarketingResults "
        Dim Orderby As String = ""
        Dim checked As Integer = 0

        ''Add columns depending on orderby clause 
        'For x As Integer = 0 To Me.chlstOrderBy.CheckedItems.Count - 1
        '    Select Case Me.chlstOrderBy.CheckedItems(x).ToString
        '        Case Is = "Reference Rating"
        '            Slct = Slct & ", ReferenceRating"
        '            checked += 1
        '        Case Is = "Sale Closed Date"
        '            Slct = Slct & ", JobClosed"
        '            checked += 1
        '        Case Is = "Loan Satisfied Date"
        '            Slct = Slct & ", ExpectedPayOff"
        '        Case Is = "Approved Loan Amount"
        '            Slct = Slct & ", ApprovedFor"
        '    End Select
        'Next

        Slct = Slct & " From Enterlead join tblWhereCanLeadGo on enterlead.id = tblWhereCanLeadGo.LeadNumber"


        'If Me.chPC.Checked = True Then
        '    If Me.chLoanSatisfied.Checked = True Or Me.chApprovedFor.Checked = True Then
        '        Slct = Slct & " Left Join tblFinance on Enterlead.ID = tblFinance.LeadNum"
        '    End If
        '    If Me.numReferences.Value > 0 Or Me.dpDate1PC.Value.ToShortDateString <> "1/1/1900" Or checked > 0 Then
        '        Slct = Slct & " Left Join SaleDetail on Enterlead.ID = SaleDetail.LeadNum"
        '    End If
        'End If


        Dim Fby As Integer = 0
        If Me.dpGenerated.Value.ToShortDateString <> "1/1/1900" Then
            DateQuery = "LeadGeneratedOn >= '" & Me.dpGenerated.Value.ToString & "'"
            Fby += 1
        End If
        If Me.dpFrom.Value.ToShortDateString <> "1/1/1900" Then
            If DateQuery <> "" Then
                DateQuery = DateQuery & " and "
            End If
            DateQuery = DateQuery & "ApptDate Between '" & Me.dpFrom.Value.ToString & "' and '" & Me.dpTo.Value.ToString & "'"
            Fby += 1
        End If
        If Me.tpFrom.Value.ToShortTimeString <> "12:00 AM" Then
            If DateQuery <> "" Then
                DateQuery = DateQuery & " and "
            End If
            DateQuery = DateQuery & "ApptTime Between '" & Me.tpFrom.Value.ToString & "' And '" & Me.tpTo.Value.ToString & "'"
            Fby += 1
        End If
        If Me.chWeekdays.Checked = True Then
            If DateQuery <> "" Then
                DateQuery = DateQuery & " and "
            End If
            DateQuery = DateQuery & "ApptDay <> 'Saturday' and ApptDay <> 'Sunday'"
            Fby += 1
        End If
        ''Marketer Tab 
        Dim cnn As SqlConnection = New SqlConnection(STATIC_VARIABLES.Cnn)
        Dim cmdGet As SqlCommand
        Dim r1 As SqlDataReader
        cmdGet = New SqlCommand("Select Count(distinct(marketer)) from EnterLead where marketer <> ''", cnn)


        cmdGet.CommandType = CommandType.Text
        cnn.Open()
        r1 = cmdGet.ExecuteReader(CommandBehavior.CloseConnection)
        r1.Read()
        If r1.Item(0) > Me.chlstMarketers.Items.Count Then    '' If true were working with a filtered down set of Marketers 
            If Me.chlstMarketers.CheckedItems.Count < Me.chlstMarketers.Items.Count Then '' If true we need to add selected marketers to query, if not true we dont need to add marketers at all because date range already filters down marketer for us 
                If MarkProdGeo <> "" Then
                    MarkProdGeo = MarkProdGeo & " and "
                End If
                For x As Integer = 0 To Me.chlstMarketers.CheckedItems.Count - 1
                    If x = 0 Then
                        MarkProdGeo = MarkProdGeo & "("
                    End If
                    If x <> Me.chlstMarketers.CheckedItems.Count - 1 Then

                        MarkProdGeo = MarkProdGeo & "Marketer = '" & Me.chlstMarketers.CheckedItems(x).ToString & "' or "    ''Add Comma after each item until last item 
                        Fby += 1
                    Else
                        MarkProdGeo = MarkProdGeo & "Marketer = '" & Me.chlstMarketers.CheckedItems(x).ToString & "')"       ''Last Item Dont Add comma to end of where 
                        Fby += 1
                    End If
                Next
            End If
        Else
            If Me.chlstMarketers.Items.Count <> Me.chlstMarketers.CheckedItems.Count Then  ''If all items are checked in list checkbox and were not working with a filtered down marketer list then no need to query by marketer at all
                If MarkProdGeo <> "" Then
                    MarkProdGeo = MarkProdGeo & " and "
                End If
                For x As Integer = 0 To Me.chlstMarketers.CheckedItems.Count - 1
                    If x = 0 Then
                        MarkProdGeo = MarkProdGeo & "("
                    End If
                    If x <> Me.chlstMarketers.CheckedItems.Count - 1 Then

                        MarkProdGeo = MarkProdGeo & "Marketer = '" & Me.chlstMarketers.CheckedItems(x).ToString & "' or "    ''Add Comma after each item until last item 
                        Fby += 1
                    Else
                        MarkProdGeo = MarkProdGeo & "Marketer = '" & Me.chlstMarketers.CheckedItems(x).ToString & "')"       ''Last Item Dont Add comma to end of where 
                        Fby += 1
                    End If
                Next
            End If
        End If
        r1.Close()
        cnn.Close()

        ''Products
        If Me.chlstProducts.Items.Count <> Me.chlstProducts.CheckedItems.Count Then ''If true filter by checked products, if false no need to filter products (skip to next step)
            If MarkProdGeo <> "" Then
                MarkProdGeo = MarkProdGeo & " and "
            End If
            For x As Integer = 0 To Me.chlstProducts.CheckedItems.Count - 1
                If x = 0 Then
                    MarkProdGeo = MarkProdGeo & "("
                End If
                If x <> Me.chlstProducts.CheckedItems.Count - 1 Then

                    MarkProdGeo = MarkProdGeo & "(" & "Product1 = '" & Me.chlstProducts.CheckedItems(x).ToString & "' or Product2 = '" & Me.chlstProducts.CheckedItems(x).ToString & "' or Product3 = '" & Me.chlstProducts.CheckedItems(x).ToString & "') or "    ''Add Comma after each item until last item 
                    Fby += 1
                Else
                    MarkProdGeo = MarkProdGeo & "(" & "Product1 = '" & Me.chlstProducts.CheckedItems(x).ToString & "' or Product2 = '" & Me.chlstProducts.CheckedItems(x).ToString & "' or Product3 = '" & Me.chlstProducts.CheckedItems(x).ToString & "'))"       ''Last Item Dont Add comma to end of where 
                    Fby += 1
                End If
            Next
        End If

        ''Geo Tab 
        If Me.chlstZipCity.CheckedItems.Count > 0 Then
            If MarkProdGeo <> "" Then
                MarkProdGeo = MarkProdGeo & " and "
            End If
            Dim CorZ As String = ""
            If Me.rdoZip.Checked = True Then
                CorZ = "Zip"
            Else
                CorZ = "City"
            End If
            For x As Integer = 0 To Me.chlstZipCity.CheckedItems.Count - 1
                If x = 0 Then
                    MarkProdGeo = MarkProdGeo & "("
                End If
                If x <> Me.chlstZipCity.CheckedItems.Count - 1 Then

                    MarkProdGeo = MarkProdGeo & CorZ & " = '" & Me.chlstZipCity.CheckedItems(x).ToString & "' or "    ''Add Comma after each item until last item 
                    Fby += 1
                Else
                    MarkProdGeo = MarkProdGeo & CorZ & " = '" & Me.chlstZipCity.CheckedItems(x).ToString & "')"       ''Last Item Dont Add comma to end of where 
                    Fby += 1
                End If
            Next
        End If

        '' Warm Calling Tab 

        'If Me.chkWC.Checked = True Then
        WCQuery = "tblWhereCanLeadGo.WarmCall = 'True'"
        'If WCQuery <> "" Then

        'End If
        If Me.chlstWC.Items.Count > Me.chlstWC.CheckedItems.Count Then      '' No need to execute this step if all checked 
            WCQuery = WCQuery & " and "

            For x As Integer = 0 To Me.chlstWC.CheckedItems.Count - 1
                If x = 0 Then
                    WCQuery = WCQuery & "("
                End If
                Dim Field As String = ""
                If Me.chlstWC.CheckedItems(x) = "Reset" Or Me.chlstWC.CheckedItems(x) = "Not Hit" Or Me.chlstWC.CheckedItems(x) = "Not Issued" Then
                    Field = "Result"
                Else
                    Field = "MarketingResults"
                End If
                If x <> Me.chlstWC.CheckedItems.Count - 1 Then

                    WCQuery = WCQuery & "(" & Field & " = '" & Me.chlstWC.CheckedItems(x).ToString & "') or "    ''Add Comma after each item until last item 
                    Fby += 1
                Else
                    WCQuery = WCQuery & "(" & Field & " = '" & Me.chlstWC.CheckedItems(x).ToString & "'))"       ''Last Item Dont Add comma to end of where 
                    Fby += 1
                End If
            Next
        End If
        'End If

        '' Recovery
        'If Me.chRehash.Checked = True Then
        '    Dim Per As Double = 0
        '    If Me.numPar.Value = 0 Then
        '        Per = 100

        '    End If
        '    Per = Me.numPar.Value / 100
        '    Per = 1 - Per
        '    Dim Q As Integer = 0
        '    If Me.txtQuoted.Text <> "" Then
        '        Q = CType(Me.txtQuoted.Text, Integer)
        '    End If

        '    For x As Integer = 0 To Me.chlstRehash.CheckedItems.Count - 1
        '        If x = 0 Then
        '            Rehash = Rehash & "("
        '        End If
        '        Dim Field As String = ""
        '        If Me.chlstRehash.CheckedItems(x) = "Reset" Or Me.chlstRehash.CheckedItems(x) = "Not Hit" Or Me.chlstRehash.CheckedItems(x) = "Not Issued" Or Me.chlstRehash.CheckedItems(x) = "Demo/No Sale" Or Me.chlstRehash.CheckedItems(x) = "Recission Cancel" Then
        '            Field = "Result"
        '        Else
        '            Field = "MarketingResults"
        '        End If
        '        If x <> Me.chlstRehash.CheckedItems.Count - 1 Then

        '            Rehash = Rehash & "(" & Field & " = '" & Me.chlstRehash.CheckedItems(x).ToString & "' and isRecovery = 'True' and isPreviousCustomer = 'False' and (QuotedSold *" & Per & ") >= ParPrice and QuotedSold >= " & Q & " ) or "    ''Add Comma after each item until last item 
        '            Fby += 1
        '        Else
        '            Rehash = Rehash & "(" & Field & " = '" & Me.chlstRehash.CheckedItems(x).ToString & "' and isRecovery = 'True' and isPreviousCustomer = 'False' and (QuotedSold *" & Per & ") >= ParPrice and QuotedSold >= " & Q & "))"       ''Last Item Dont Add comma to end of where 
        '            Fby += 1
        '        End If
        '    Next




        'End If

        ''Reconstruct Where Statement 
        If WCQuery <> "" Then ''Constructs Query For Warm Calling 
            If DateQuery <> "" And MarkProdGeo <> "" Then
                Where = "(" & DateQuery & " and " & MarkProdGeo & " and " & WCQuery & ")"
            ElseIf DateQuery <> "" And MarkProdGeo = "" Then
                Where = "(" & DateQuery & " and " & WCQuery & ")"
            ElseIf DateQuery = "" And MarkProdGeo <> "" Then
                Where = "(" & MarkProdGeo & " and " & WCQuery & ")"
            ElseIf DateQuery = "" And MarkProdGeo = "" Then
                Where = WCQuery
            End If
        End If

        'If Where <> "" And Rehash <> "" Then
        '    Where = Where & " or "
        'End If

        'If Rehash <> "" Then ''Constructs Query For Rehash 
        '    If DateQuery <> "" And MarkProdGeo <> "" Then
        '        Where = Where & "(" & DateQuery & " and " & MarkProdGeo & " and " & Rehash & ")"
        '    ElseIf DateQuery <> "" And MarkProdGeo = "" Then
        '        Where = Where & "(" & DateQuery & " and " & Rehash & ")"
        '    ElseIf DateQuery = "" And MarkProdGeo <> "" Then
        '        Where = Where & "(" & MarkProdGeo & " and " & Rehash & ")"
        '    ElseIf DateQuery = "" And MarkProdGeo = "" Then
        '        Where = Where & Rehash
        '    End If
        'End If

        'If Me.chPC.Checked = True Then ''Build PC Query Here 

        '    If Me.chFutureInterest.Checked = True Then
        '        PCQuery = PCQuery & "(Enterlead.Product1 <> '' and Enterlead.Product2 <> '' and Enterlead.Product3 <> '')"
        '    End If

        '    If Me.rdoCash.Checked = True Then
        '        If PCQuery <> "" Then
        '            PCQuery = PCQuery & " and "
        '        End If
        '        PCQuery = PCQuery & "Enterlead.Cash = 'True'"
        '    End If

        '    If Me.rdoLoan.Checked = True Then
        '        If PCQuery <> "" Then
        '            PCQuery = PCQuery & " and "
        '        End If
        '        PCQuery = PCQuery & "Enterlead.Finance = 'True'"
        '    End If

        '    If Me.chApprovedFor.Checked = True Then
        '        If PCQuery <> "" Then
        '            PCQuery = PCQuery & " and "
        '        End If
        '        PCQuery = PCQuery & "ApprovedFor >= " & CType(Me.txtApprovedDollars.Text, Integer)
        '    End If

        '    If Me.chLoanSatisfied.Checked = True Then
        '        If PCQuery <> "" Then
        '            PCQuery = PCQuery & " and "
        '        End If
        '        Dim Dt As Date = Today
        '        Dt = Dt.Month & "/1/" & Dt.Year
        '        If Me.numMonths.Value > 0 Then
        '            Dt = Dt.AddMonths(Me.numMonths.Value)
        '        End If
        '        PCQuery = PCQuery & "ExpectedPayOff <= '" & Dt.ToShortDateString & "'"
        '    End If

        '    If Me.numReferences.Value > 0 Then
        '        If PCQuery <> "" Then
        '            PCQuery = PCQuery & " and "
        '        End If
        '        PCQuery = PCQuery & "ReferenceRating >= " & Me.numReferences.Value
        '    End If

        '    If Me.dpDate1PC.Value.ToShortDateString <> "1/1/1900" Then
        '        If PCQuery <> "" Then
        '            PCQuery = PCQuery & " and "
        '        End If
        '        PCQuery = PCQuery & "JobClosed Between '" & Me.dpDate1PC.Value.ToShortDateString & "' and '" & Me.dpDate2PC.Value.ToShortDateString & "'"
        '    End If

        '    If PCQuery <> "" Then
        '        PCQuery = PCQuery & " and isPreviousCustomer = 'True'"
        '    End If

        'End If




        'If PCQuery <> "" And (WCQuery <> "" Or Rehash <> "") Then
        '    Where = Where & " or "
        'End If

        'If Me.chPC.Checked = True Then


        '    If PCQuery <> "" Then ''Constructs Query For PC's 
        '        If MarkProdGeo <> "" Then
        '            Where = Where & "(" & MarkProdGeo & " and " & PCQuery & ")"
        '        Else
        '            Where = Where & PCQuery
        '        End If
        '    Else
        '        If MarkProdGeo <> "" And Me.chPC.Checked = True Then
        '            Where = Where & "(" & MarkProdGeo & " and " & "isPreviousCustomer = 'True')"
        '        Else
        '            If Where = "" Then
        '                Where = "isPreviousCustomer = 'True'"
        '            Else
        '                If PCQuery = "" Then
        '                    Where = Where & " or isPreviousCustomer = 'True'"
        '                End If
        '            End If
        '        End If
        '    End If
        'End If

        If Where <> "" Then
            Where = " Where " & Where
        End If
        'If Me.chkWC.Checked = False And Me.chRehash.Checked = False And Me.chPC.Checked = False Then
        '    MsgBox("You Must Check At Least One Type Of Lead To Generate List!", MsgBoxStyle.Exclamation, "No Lead Types Checked")
        '    Exit Sub
        'End If
        Slct = Slct & Where
        ''Add Order by Here
        Dim GrpBy As Boolean
        If Me.chGroupBy.Checked = True Then
            GrpBy = True
        End If
        For x As Integer = 0 To Me.chlstOrderBy.CheckedItems.Count - 1
            Select Case Me.chlstOrderBy.CheckedItems(x).ToString
                Case Is = "City, State"
                    If x = Me.chlstOrderBy.CheckedItems.Count - 1 Then
                        Orderby = Orderby & "City asc"
                    Else
                        Orderby = Orderby & "City asc, "
                    End If
                Case Is = "Zip Code"
                    If x = Me.chlstOrderBy.CheckedItems.Count - 1 Then
                        Orderby = Orderby & "Zip desc"
                    Else
                        Orderby = Orderby & "Zip desc, "
                    End If
                Case Is = "Generated On"
                    If x = Me.chlstOrderBy.CheckedItems.Count - 1 Then
                        Orderby = Orderby & "LeadGeneratedOn desc"
                    Else
                        Orderby = Orderby & "LeadGeneratedOn desc, "
                    End If
                Case Is = "Appointment Date"
                    If x = Me.chlstOrderBy.CheckedItems.Count - 1 Then
                        Orderby = Orderby & "ApptDate desc"
                    Else
                        Orderby = Orderby & "ApptDate desc, "
                    End If
                Case Is = "Appointment Time"
                    If x = Me.chlstOrderBy.CheckedItems.Count - 1 Then
                        Orderby = Orderby & "ApptTime asc"
                    Else
                        Orderby = Orderby & "ApptTime asc, "
                    End If
                Case Is = "Primary Product"
                    If x = Me.chlstOrderBy.CheckedItems.Count - 1 Then
                        Orderby = Orderby & "Product1 asc"
                    Else
                        Orderby = Orderby & "Product1 asc, "
                    End If
                Case Is = "Marketer"
                    If x = Me.chlstOrderBy.CheckedItems.Count - 1 Then
                        Orderby = Orderby & "Marketer asc"
                    Else
                        Orderby = Orderby & "Marketer asc, "
                    End If
                Case Is = "Marketing Result"
                    If x = Me.chlstOrderBy.CheckedItems.Count - 1 Then
                        Orderby = Orderby & "MarketingResults asc"
                    Else
                        Orderby = Orderby & "MarketingResults asc, "
                    End If

            End Select
        Next
        If Orderby <> "" Then
            Orderby = " Order By " & Orderby
            Slct = Slct & Orderby
        End If




        ''Aaron, Use Slct Variable for your Select Statement Query and Use GrpBy Variable to decide if you need to group your list with the top checked item in sort by checked list box

        'Me.RichTextBox1.Text = Slct

        ''Done Now Must Debug the shit out of Select Statement 
        ''Also need to Add Order By Statements to end 
        '' 


        ' Dim cl As New createListPrintOperations uncomment
        'cl.CreateWireFrameHTML(Slct)






        '' 4-1-2016 AC
        '' 

        '' Two Things: 
        '' IF Grouped, gather Grouped By Column
        '' Convert Selected Criteria to respective fields for Sub Query of Unique Vals {Headings} 
        '' 
        '' basically need to translate verbage on front end to columns that are mapped on SQL
        '' 
        '' aslo, append select to reflect what 'columns' are sorted by
        '' 'Marketer' Field was/is left off for some reason, concat back in.

        Slct = Slct.ToString.Replace(" ApptTime, MarketingResults", " ApptTime, MarketingResults, Marketer, Result,IsPreviousCustomer,IsRecovery ") '' needed for ORDER BY clause
        Dim arSort As New ArrayList
        Dim cntSRT As Integer = Me.chlstOrderBy.CheckedItems.Count - 1
        Dim i As Integer = 0
        For i = 0 To cntSRT
            arSort.Add(Me.chlstOrderBy.CheckedItems(i))
        Next
        If Me.chGroupBy.CheckState = CheckState.Checked Then

            Dim qrySTR_Headers As String = ConvertGroup(Me.chlstOrderBy.CheckedItems.Item(0), Slct, arSort) '' private function to present selections in UNIFIED SQL StateMent
            '' now we have headings and result set in a unified format
            '' also have query to pull unique heading [data] out of SQL
            '' pipe to html render
            '' 
            Dim cl_XP As New createListPrintOperations
            cl_XP.CreateWireFrameHTML_WarmCalling(Slct, True, arSort, qrySTR_Headers)
            cl_XP = Nothing
        Else
            Me.chGroupBy.CheckState = CheckState.Unchecked
            '' now we have headings and result set in a unified format
            '' pipe to html render
            '' 
            Dim clP As New createListPrintOperations
            clP.CreateWireFrameHTML_WarmCalling(Slct)
            clP = Nothing
        End If







        'Catch ex As Exception
        '    Dim y As New ErrorLogging_V2
        '    y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmCreateList", "FormCode", "Sub", "btnGenerate_Click", "0", ex.Message.ToString)
        '    y = Nothing
        'End Try

    End Sub

    Private Sub txtZipCity_Leave(sender As Object, e As EventArgs) Handles txtZipCity.Leave
        If Me.rdoCity.Checked = True Then
            Try

                Dim cnn As SqlConnection = New SqlConnection(STATIC_VARIABLES.Cnn)
                Dim cmdGet As SqlCommand
                Dim r1 As SqlDataReader

                cmdGet = New SqlCommand("Select Distinct(state) from enterlead where City = '" & Me.txtZipCity.Text & "'", cnn)



                cmdGet.CommandType = CommandType.Text
                Cnn.Open()
                r1 = cmdGet.ExecuteReader(CommandBehavior.CloseConnection)
                While r1.Read()
                    Me.cboStateSelection.Text = r1.Item(0)
                End While


            Catch ex As Exception
                Dim y As New ErrorLogging_V2
                y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "txtZipCity_Leave", "FormCode", "sub", "tabDate_Leave", "0", ex.Message.ToString)
                y = Nothing
            End Try
        End If
    End Sub

    Private Sub BackgroundWorkerZip_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerZip.DoWork
        Try
            Me.txtZipCity.AutoCompleteCustomSource.Clear()
            Dim cnn As SqlConnection = New SqlConnection(STATIC_VARIABLES.Cnn)
            Dim cmdGet As SqlCommand
            Dim r1 As SqlDataReader
            If Me.chWeekdays.Checked = True Then
                cmdGet = New SqlCommand("Select Distinct(Zip) from enterlead join tblWherecanleadgo on enterlead.id = tblwherecanleadgo.leadnumber where ApptDate Between '" & Me.dpFrom.Value.ToString & "' and '" & Me.dpTo.Value.ToString & "' and ApptTime Between '" & Me.tpFrom.Value.ToString & "' and '" & Me.tpTo.Value.ToString & "' and LeadGeneratedOn >= '" & Me.dpGenerated.Value.ToString & "' and (ApptDay <> 'Saturday' and ApptDay <> 'Sunday') and tblWhereCanLeadGo.WarmCall = 'True' order by Zip desc", cnn)
            Else
                cmdGet = New SqlCommand("Select Distinct(Zip) from enterlead join tblWherecanleadgo on enterlead.id = tblwherecanleadgo.leadnumber where ApptDate Between '" & Me.dpFrom.Value.ToString & "' and '" & Me.dpTo.Value.ToString & "' and ApptTime Between '" & Me.tpFrom.Value.ToString & "' and '" & Me.tpTo.Value.ToString & "' and LeadGeneratedOn >= '" & Me.dpGenerated.Value.ToString & "' and tblWhereCanLeadGo.WarmCall = 'True' order by Zip desc", cnn)
            End If

            cmdGet.CommandType = CommandType.Text
            cnn.Open()
            r1 = cmdGet.ExecuteReader(CommandBehavior.CloseConnection)
            While r1.Read()
                Me.txtZipCity.AutoCompleteCustomSource.Add(r1.Item(0))
            End While


        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "tabDate_Leave", "FormCode", "sub", "tabDate_Leave", "0", ex.Message.ToString)
            y = Nothing
        End Try
    End Sub

    Private Sub BackgroundWorkerCity_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerCity.DoWork
        Try
            Me.txtZipCity.AutoCompleteCustomSource.Clear()
            Dim cnn As SqlConnection = New SqlConnection(STATIC_VARIABLES.Cnn)
            Dim cmdGet As SqlCommand
            Dim r1 As SqlDataReader
            If Me.chWeekdays.Checked = True Then
                cmdGet = New SqlCommand("Select Distinct(City) from enterlead join tblWherecanleadgo on enterlead.id = tblwherecanleadgo.leadnumber where ApptDate Between '" & Me.dpFrom.Value.ToString & "' and '" & Me.dpTo.Value.ToString & "' and ApptTime Between '" & Me.tpFrom.Value.ToString & "' and '" & Me.tpTo.Value.ToString & "' and LeadGeneratedOn >= '" & Me.dpGenerated.Value.ToString & "' and (ApptDay <> 'Saturday' and ApptDay <> 'Sunday') and tblWhereCanLeadGo.WarmCall = 'True' order by City asc", cnn)
            Else
                cmdGet = New SqlCommand("Select Distinct(City) from enterlead join tblWherecanleadgo on enterlead.id = tblwherecanleadgo.leadnumber where ApptDate Between '" & Me.dpFrom.Value.ToString & "' and '" & Me.dpTo.Value.ToString & "' and ApptTime Between '" & Me.tpFrom.Value.ToString & "' and '" & Me.tpTo.Value.ToString & "' and LeadGeneratedOn >= '" & Me.dpGenerated.Value.ToString & "' and tblWhereCanLeadGo.WarmCall = 'True' order by City asc", cnn)
            End If

            cmdGet.CommandType = CommandType.Text
            cnn.Open()
            r1 = cmdGet.ExecuteReader(CommandBehavior.CloseConnection)
            While r1.Read()
                Me.txtZipCity.AutoCompleteCustomSource.Add(r1.Item(0))
            End While


        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "rdoCity_CheckedChanged", "FormCode", "sub", "tabDate_Leave", "0", ex.Message.ToString)
            y = Nothing
        End Try
    End Sub

    Private Sub btnRecordCount_Click(sender As Object, e As EventArgs) Handles btnRecordCount.Click
        Me.txtRecordCount.Text = ""
        Me.tabDate.ImageKey = Nothing
        Me.tabDate.ToolTipText = ""
        Me.tabProducts.ImageKey = Nothing
        Me.tabProducts.ToolTipText = ""
        Me.tabGeo.ImageKey = Nothing
        Me.tabGeo.ToolTipText = ""
        Me.tabWC.ImageKey = Nothing
        Me.tabWC.ToolTipText = ""

        Me.tabMarketers.ImageKey = Nothing
        Me.tabMarketers.ToolTipText = ""

        Me.epForm.Clear()
        Me.epGeo.Clear()
        Dim tabDate As Integer = 0
        Dim tabProd As Integer = 0
        Dim tabGeo As Integer = 0
        Dim tabWC As Integer = 0
        Dim tabPC As Integer = 0
        Dim tabRehash As Integer = 0
        Dim tabMarketer As Integer = 0

        ''Date/Time Tab 
        If Me.dpFrom.Value.ToShortDateString <> "1/1/1900" And Me.dpTo.Value.ToShortDateString = "1/1/2100" Then              '' Change If Statement to reflect datepicker value instead of visible properties
            Me.epForm.SetError(Me.dpTo, "You Must Supply a Date!")
            tabDate += 1
        End If
        If Me.dpFrom.Value.ToShortDateString = "1/1/1900" And Me.dpTo.Value.ToShortDateString <> "1/1/2100" Then              '' Change If Statement to reflect datepicker value instead of visible properties
            Me.epForm.SetError(Me.dpFrom, "You Must Supply a Date!")
            tabDate += 1
        End If
        If Me.tpFrom.Value.ToShortTimeString = "12:00 AM" And Me.tpTo.Value.ToShortTimeString <> "11:59 PM" Then
            Me.epForm.SetError(Me.tpFrom, "You Must Supply a Time!")
            tabDate += 1
        End If
        If Me.tpFrom.Value.ToShortTimeString <> "12:00 AM" And Me.tpTo.Value.ToShortTimeString = "11:59 PM" Then
            Me.epForm.SetError(Me.tpTo, "You Must Supply a Time!")
            tabDate += 1
        End If

        ''Marketers Tab 
        If Me.chlstMarketers.CheckedItems.Count <= 0 Then
            Me.epForm.SetError(Me.chlstMarketers, "You Must Select at Least One Marketer!")
            tabMarketer += 1
        End If
        ''Products Tab
        If Me.chlstProducts.CheckedItems.Count <= 0 Then
            Me.epForm.SetError(Me.chlstProducts, "You Must Select at Least One Product!")
            tabProd += 1
        End If

        ''Geo Tab 
        If Me.chlstZipCity.Items.Count > 0 And Me.chlstZipCity.CheckedItems.Count <= 0 Then
            If Me.rdoZip.Checked = True Then
                Me.epForm.SetError(Me.chlstProducts, "You Must Select at Least One Zip Code!")
                tabGeo += 1
            Else
                Me.epForm.SetError(Me.chlstProducts, "You Must Select at Least One City!")

                Me.epForm.SetIconPadding(Me.chlstProducts, 20)
                tabGeo += 1
            End If
        End If

        ''Warm Calling Tab
        If Me.chlstWC.CheckedItems.Count <= 0 Then
            Me.epForm.SetError(Me.chlstWC, "You Must Select at Least One Marketing Result!")
            tabWC += 1
        End If

        ' ''Previous Customer Tab
        'If Me.chPC.Checked = True Then
        '    If Me.chApprovedFor.Checked = True And Me.txtApprovedDollars.Text = "" Then
        '        Me.epForm.SetError(Me.txtApprovedDollars, "You Must Supply a Dollar Amount! ")
        '        tabPC += 1
        '    End If
        '    If Me.chApprovedFor.Checked = True Then
        '        For z As Integer = 1 To Me.txtApprovedDollars.TextLength
        '            Dim c As Char = GetChar(Me.txtApprovedDollars.Text, z)
        '            If (c = "0") Or (c = "1") Or (c = "2") Or (c = "3") Or (c = "4") Or (c = "5") Or (c = "6") Or (c = "7") Or (c = "8") Or (c = "9") Then
        '            Else
        '                Me.epGeo.SetError(Me.txtApprovedDollars, "Field Can Only Contain Numbers!")
        '                tabPC += 1

        '            End If
        '        Next
        '    End If
        '    If Me.dpDate1PC.Value.ToShortDateString = "1/1/1900" And Me.dpDate2PC.Value.ToShortDateString <> "1/1/2100" Then
        '        Me.epForm.SetError(Me.dpDate1PC, "You Must Supply a Date!")
        '        tabPC += 1
        '    End If
        '    If Me.dpDate1PC.Value.ToShortDateString <> "1/1/1900" And Me.dpDate2PC.Value.ToShortDateString = "1/1/2100" Then
        '        Me.epForm.SetError(Me.dpDate2PC, "You Must Supply a Date!")
        '        tabPC += 1
        '    End If
        'End If

        ' ''Rehash Tab
        'If Me.chRehash.Checked = True Then
        '    If Me.chlstRehash.CheckedItems.Count <= 0 Then
        '        Me.epForm.SetError(Me.chlstRehash, "You Must Select at Least One Result!")
        '        tabRehash += 1
        '    End If
        '    For z As Integer = 1 To Me.txtQuoted.TextLength
        '        Dim c As Char = GetChar(Me.txtQuoted.Text, z)
        '        If (c = "0") Or (c = "1") Or (c = "2") Or (c = "3") Or (c = "4") Or (c = "5") Or (c = "6") Or (c = "7") Or (c = "8") Or (c = "9") Then
        '        Else
        '            Me.epGeo.SetError(Me.txtQuoted, "Field Can Only Contain Numbers!")
        '            tabRehash += 1
        '        End If
        '    Next
        'End If
        Dim tab As Integer = 0
        If tabDate > 0 Then
            Me.tabDate.ImageIndex = 0
            Me.tabDate.ToolTipText = "Errors on this Tab"
            tab += 1
        End If
        If tabProd > 0 Then
            Me.tabProducts.ImageIndex = 0
            Me.tabProducts.ToolTipText = "Errors on this Tab"
            tab += 1
        End If
        If tabGeo > 0 Then
            Me.tabGeo.ImageIndex = 0
            Me.tabGeo.ToolTipText = "Errors on this Tab"
            tab += 1
        End If
        If tabWC > 0 Then
            Me.tabWC.ImageIndex = 0
            Me.tabWC.ToolTipText = "Errors on this Tab"
            tab += 1
        End If
        'If tabPC > 0 Then
        '    Me.tabPC.ImageIndex = 0
        '    Me.tabPC.ToolTipText = "Errors on this Tab"
        '    tab += 1
        'End If
        'If tabRehash > 0 Then
        '    Me.tabRecovery.ImageIndex = 0
        '    Me.tabRecovery.ToolTipText = "Errors on this Tab"
        '    tab += 1
        'End If
        If tabMarketer > 0 Then
            Me.tabMarketers.ImageIndex = 0
            Me.tabMarketers.ToolTipText = "Errors on this Tab"
            tab += 1
        End If
        If tab > 0 Then
            Exit Sub
        End If

        ''ADD SQL QUERY CODE HERE 
        'MsgBox("Creating List")

        ''Date Tab
        Dim Where As String = ""
        Dim DateQuery As String = ""
        Dim MarkProdGeo As String = ""
        Dim WCQuery As String = ""
        Dim Rehash As String = ""
        Dim PCQuery As String = ""
        Dim Slct As String = "Select Count(Distinct(Enterlead.ID)) "
        Dim Orderby As String = ""
        Dim checked As Integer = 0

        ''Add columns depending on orderby clause 
        'For x As Integer = 0 To Me.chlstOrderBy.CheckedItems.Count - 1
        '    Select Case Me.chlstOrderBy.CheckedItems(x).ToString
        '        Case Is = "Reference Rating"
        '            Slct = Slct & ", ReferenceRating"
        '            checked += 1
        '        Case Is = "Sale Closed Date"
        '            Slct = Slct & ", JobClosed"
        '            checked += 1
        '        Case Is = "Loan Satisfied Date"
        '            Slct = Slct & ", ExpectedPayOff"
        '        Case Is = "Approved Loan Amount"
        '            Slct = Slct & ", ApprovedFor"
        '    End Select
        'Next

        Slct = Slct & " From Enterlead join tblWhereCanLeadGo on enterlead.id = tblWhereCanLeadGo.LeadNumber"


        'If Me.chPC.Checked = True Then
        '    If Me.chLoanSatisfied.Checked = True Or Me.chApprovedFor.Checked = True Then
        '        Slct = Slct & " Left Join tblFinance on Enterlead.ID = tblFinance.LeadNum"
        '    End If
        '    If Me.numReferences.Value > 0 Or Me.dpDate1PC.Value.ToShortDateString <> "1/1/1900" Or checked > 0 Then
        '        Slct = Slct & " Left Join SaleDetail on Enterlead.ID = SaleDetail.LeadNum"
        '    End If
        'End If


        Dim Fby As Integer = 0
        If Me.dpGenerated.Value.ToShortDateString <> "1/1/1900" Then
            DateQuery = "LeadGeneratedOn >= '" & Me.dpGenerated.Value.ToString & "'"
            Fby += 1
        End If
        If Me.dpFrom.Value.ToShortDateString <> "1/1/1900" Then
            If DateQuery <> "" Then
                DateQuery = DateQuery & " and "
            End If
            DateQuery = DateQuery & "ApptDate Between '" & Me.dpFrom.Value.ToString & "' and '" & Me.dpTo.Value.ToString & "'"
            Fby += 1
        End If
        If Me.tpFrom.Value.ToShortTimeString <> "12:00 AM" Then
            If DateQuery <> "" Then
                DateQuery = DateQuery & " and "
            End If
            DateQuery = DateQuery & "ApptTime Between '" & Me.tpFrom.Value.ToString & "' And '" & Me.tpTo.Value.ToString & "'"
            Fby += 1
        End If
        If Me.chWeekdays.Checked = True Then
            If DateQuery <> "" Then
                DateQuery = DateQuery & " and "
            End If
            DateQuery = DateQuery & "ApptDay <> 'Saturday' and ApptDay <> 'Sunday'"
            Fby += 1
        End If
        ''Marketer Tab 
        Dim cnn As SqlConnection = New SqlConnection(STATIC_VARIABLES.Cnn)
        Dim cmdGet As SqlCommand
        Dim r1 As SqlDataReader
        cmdGet = New SqlCommand("Select Count(distinct(marketer)) from EnterLead where marketer <> ''", cnn)


        cmdGet.CommandType = CommandType.Text
        Try

            cnn.Open()
            r1 = cmdGet.ExecuteReader(CommandBehavior.CloseConnection)
            r1.Read()
            If r1.Item(0) > Me.chlstMarketers.Items.Count Then    '' If true were working with a filtered down set of Marketers 
                If Me.chlstMarketers.CheckedItems.Count < Me.chlstMarketers.Items.Count Then '' If true we need to add selected marketers to query, if not true we dont need to add marketers at all because date range already filters down marketer for us 
                    If MarkProdGeo <> "" Then
                        MarkProdGeo = MarkProdGeo & " and "
                    End If
                    For x As Integer = 0 To Me.chlstMarketers.CheckedItems.Count - 1
                        If x = 0 Then
                            MarkProdGeo = MarkProdGeo & "("
                        End If
                        If x <> Me.chlstMarketers.CheckedItems.Count - 1 Then

                            MarkProdGeo = MarkProdGeo & "Marketer = '" & Me.chlstMarketers.CheckedItems(x).ToString & "' or "    ''Add Comma after each item until last item 
                            Fby += 1
                        Else
                            MarkProdGeo = MarkProdGeo & "Marketer = '" & Me.chlstMarketers.CheckedItems(x).ToString & "')"       ''Last Item Dont Add comma to end of where 
                            Fby += 1
                        End If
                    Next
                End If
            Else
                If Me.chlstMarketers.Items.Count <> Me.chlstMarketers.CheckedItems.Count Then  ''If all items are checked in list checkbox and were not working with a filtered down marketer list then no need to query by marketer at all
                    If MarkProdGeo <> "" Then
                        MarkProdGeo = MarkProdGeo & " and "
                    End If
                    For x As Integer = 0 To Me.chlstMarketers.CheckedItems.Count - 1
                        If x = 0 Then
                            MarkProdGeo = MarkProdGeo & "("
                        End If
                        If x <> Me.chlstMarketers.CheckedItems.Count - 1 Then

                            MarkProdGeo = MarkProdGeo & "Marketer = '" & Me.chlstMarketers.CheckedItems(x).ToString & "' or "    ''Add Comma after each item until last item 
                            Fby += 1
                        Else
                            MarkProdGeo = MarkProdGeo & "Marketer = '" & Me.chlstMarketers.CheckedItems(x).ToString & "')"       ''Last Item Dont Add comma to end of where 
                            Fby += 1
                        End If
                    Next
                End If
            End If
            r1.Close()
            cnn.Close()

        Catch ex As Exception

        End Try
        ''Products
        If Me.chlstProducts.Items.Count <> Me.chlstProducts.CheckedItems.Count Then ''If true filter by checked products, if false no need to filter products (skip to next step)
            If MarkProdGeo <> "" Then
                MarkProdGeo = MarkProdGeo & " and "
            End If
            For x As Integer = 0 To Me.chlstProducts.CheckedItems.Count - 1
                If x = 0 Then
                    MarkProdGeo = MarkProdGeo & "("
                End If
                If x <> Me.chlstProducts.CheckedItems.Count - 1 Then

                    MarkProdGeo = MarkProdGeo & "(" & "Product1 = '" & Me.chlstProducts.CheckedItems(x).ToString & "' or Product2 = '" & Me.chlstProducts.CheckedItems(x).ToString & "' or Product3 = '" & Me.chlstProducts.CheckedItems(x).ToString & "') or "    ''Add Comma after each item until last item 
                    Fby += 1
                Else
                    MarkProdGeo = MarkProdGeo & "(" & "Product1 = '" & Me.chlstProducts.CheckedItems(x).ToString & "' or Product2 = '" & Me.chlstProducts.CheckedItems(x).ToString & "' or Product3 = '" & Me.chlstProducts.CheckedItems(x).ToString & "'))"       ''Last Item Dont Add comma to end of where 
                    Fby += 1
                End If
            Next
        End If

        ''Geo Tab 
        If Me.chlstZipCity.CheckedItems.Count > 0 Then
            If MarkProdGeo <> "" Then
                MarkProdGeo = MarkProdGeo & " and "
            End If
            Dim CorZ As String = ""
            If Me.rdoZip.Checked = True Then
                CorZ = "Zip"
            Else
                CorZ = "City"
            End If
            For x As Integer = 0 To Me.chlstZipCity.CheckedItems.Count - 1
                If x = 0 Then
                    MarkProdGeo = MarkProdGeo & "("
                End If
                If x <> Me.chlstZipCity.CheckedItems.Count - 1 Then

                    MarkProdGeo = MarkProdGeo & CorZ & " = '" & Me.chlstZipCity.CheckedItems(x).ToString & "' or "    ''Add Comma after each item until last item 
                    Fby += 1
                Else
                    MarkProdGeo = MarkProdGeo & CorZ & " = '" & Me.chlstZipCity.CheckedItems(x).ToString & "')"       ''Last Item Dont Add comma to end of where 
                    Fby += 1
                End If
            Next
        End If

        '' Warm Calling Tab 

        'If Me.chkWC.Checked = True Then
        WCQuery = "tblWhereCanLeadGo.WarmCall = 'True'"
        'If WCQuery <> "" Then

        'End If
        If Me.chlstWC.Items.Count > Me.chlstWC.CheckedItems.Count Then      '' No need to execute this step if all checked 
            WCQuery = WCQuery & " and "

            For x As Integer = 0 To Me.chlstWC.CheckedItems.Count - 1
                If x = 0 Then
                    WCQuery = WCQuery & "("
                End If
                Dim Field As String = ""
                If Me.chlstWC.CheckedItems(x) = "Reset" Or Me.chlstWC.CheckedItems(x) = "Not Hit" Or Me.chlstWC.CheckedItems(x) = "Not Issued" Then
                    Field = "Result"
                Else
                    Field = "MarketingResults"
                End If
                If x <> Me.chlstWC.CheckedItems.Count - 1 Then

                    WCQuery = WCQuery & "(" & Field & " = '" & Me.chlstWC.CheckedItems(x).ToString & "') or "    ''Add Comma after each item until last item 
                    Fby += 1
                Else
                    WCQuery = WCQuery & "(" & Field & " = '" & Me.chlstWC.CheckedItems(x).ToString & "'))"       ''Last Item Dont Add comma to end of where 
                    Fby += 1
                End If
            Next
        End If
        'End If

        '' Recovery
        'If Me.chRehash.Checked = True Then
        '    Dim Per As Double = 0
        '    If Me.numPar.Value = 0 Then
        '        Per = 100

        '    End If
        '    Per = Me.numPar.Value / 100
        '    Per = 1 - Per
        '    Dim Q As Integer = 0
        '    If Me.txtQuoted.Text <> "" Then
        '        Q = CType(Me.txtQuoted.Text, Integer)
        '    End If

        '    For x As Integer = 0 To Me.chlstRehash.CheckedItems.Count - 1
        '        If x = 0 Then
        '            Rehash = Rehash & "("
        '        End If
        '        Dim Field As String = ""
        '        If Me.chlstRehash.CheckedItems(x) = "Reset" Or Me.chlstRehash.CheckedItems(x) = "Not Hit" Or Me.chlstRehash.CheckedItems(x) = "Not Issued" Or Me.chlstRehash.CheckedItems(x) = "Demo/No Sale" Or Me.chlstRehash.CheckedItems(x) = "Recission Cancel" Then
        '            Field = "Result"
        '        Else
        '            Field = "MarketingResults"
        '        End If
        '        If x <> Me.chlstRehash.CheckedItems.Count - 1 Then

        '            Rehash = Rehash & "(" & Field & " = '" & Me.chlstRehash.CheckedItems(x).ToString & "' and isRecovery = 'True' and isPreviousCustomer = 'False' and (QuotedSold *" & Per & ") >= ParPrice and QuotedSold >= " & Q & " ) or "    ''Add Comma after each item until last item 
        '            Fby += 1
        '        Else
        '            Rehash = Rehash & "(" & Field & " = '" & Me.chlstRehash.CheckedItems(x).ToString & "' and isRecovery = 'True' and isPreviousCustomer = 'False' and (QuotedSold *" & Per & ") >= ParPrice and QuotedSold >= " & Q & "))"       ''Last Item Dont Add comma to end of where 
        '            Fby += 1
        '        End If
        '    Next




        'End If

        ''Reconstruct Where Statement 
        If WCQuery <> "" Then ''Constructs Query For Warm Calling 
            If DateQuery <> "" And MarkProdGeo <> "" Then
                Where = "(" & DateQuery & " and " & MarkProdGeo & " and " & WCQuery & ")"
            ElseIf DateQuery <> "" And MarkProdGeo = "" Then
                Where = "(" & DateQuery & " and " & WCQuery & ")"
            ElseIf DateQuery = "" And MarkProdGeo <> "" Then
                Where = "(" & MarkProdGeo & " and " & WCQuery & ")"
            ElseIf DateQuery = "" And MarkProdGeo = "" Then
                Where = WCQuery
            End If
        End If

        'If Where <> "" And Rehash <> "" Then
        '    Where = Where & " or "
        'End If

        'If Rehash <> "" Then ''Constructs Query For Rehash 
        '    If DateQuery <> "" And MarkProdGeo <> "" Then
        '        Where = Where & "(" & DateQuery & " and " & MarkProdGeo & " and " & Rehash & ")"
        '    ElseIf DateQuery <> "" And MarkProdGeo = "" Then
        '        Where = Where & "(" & DateQuery & " and " & Rehash & ")"
        '    ElseIf DateQuery = "" And MarkProdGeo <> "" Then
        '        Where = Where & "(" & MarkProdGeo & " and " & Rehash & ")"
        '    ElseIf DateQuery = "" And MarkProdGeo = "" Then
        '        Where = Where & Rehash
        '    End If
        'End If

        'If Me.chPC.Checked = True Then ''Build PC Query Here 

        '    If Me.chFutureInterest.Checked = True Then
        '        PCQuery = PCQuery & "(Enterlead.Product1 <> '' and Enterlead.Product2 <> '' and Enterlead.Product3 <> '')"
        '    End If

        '    If Me.rdoCash.Checked = True Then
        '        If PCQuery <> "" Then
        '            PCQuery = PCQuery & " and "
        '        End If
        '        PCQuery = PCQuery & "Enterlead.Cash = 'True'"
        '    End If

        '    If Me.rdoLoan.Checked = True Then
        '        If PCQuery <> "" Then
        '            PCQuery = PCQuery & " and "
        '        End If
        '        PCQuery = PCQuery & "Enterlead.Finance = 'True'"
        '    End If

        '    If Me.chApprovedFor.Checked = True Then
        '        If PCQuery <> "" Then
        '            PCQuery = PCQuery & " and "
        '        End If
        '        PCQuery = PCQuery & "ApprovedFor >= " & CType(Me.txtApprovedDollars.Text, Integer)
        '    End If

        '    If Me.chLoanSatisfied.Checked = True Then
        '        If PCQuery <> "" Then
        '            PCQuery = PCQuery & " and "
        '        End If
        '        Dim Dt As Date = Today
        '        Dt = Dt.Month & "/1/" & Dt.Year
        '        If Me.numMonths.Value > 0 Then
        '            Dt = Dt.AddMonths(Me.numMonths.Value)
        '        End If
        '        PCQuery = PCQuery & "ExpectedPayOff <= '" & Dt.ToShortDateString & "'"
        '    End If

        '    If Me.numReferences.Value > 0 Then
        '        If PCQuery <> "" Then
        '            PCQuery = PCQuery & " and "
        '        End If
        '        PCQuery = PCQuery & "ReferenceRating >= " & Me.numReferences.Value
        '    End If

        '    If Me.dpDate1PC.Value.ToShortDateString <> "1/1/1900" Then
        '        If PCQuery <> "" Then
        '            PCQuery = PCQuery & " and "
        '        End If
        '        PCQuery = PCQuery & "JobClosed Between '" & Me.dpDate1PC.Value.ToShortDateString & "' and '" & Me.dpDate2PC.Value.ToShortDateString & "'"
        '    End If

        '    If PCQuery <> "" Then
        '        PCQuery = PCQuery & " and isPreviousCustomer = 'True'"
        '    End If

        'End If




        'If PCQuery <> "" And (WCQuery <> "" Or Rehash <> "") Then
        '    Where = Where & " or "
        'End If

        'If Me.chPC.Checked = True Then


        '    If PCQuery <> "" Then ''Constructs Query For PC's 
        '        If MarkProdGeo <> "" Then
        '            Where = Where & "(" & MarkProdGeo & " and " & PCQuery & ")"
        '        Else
        '            Where = Where & PCQuery
        '        End If
        '    Else
        '        If MarkProdGeo <> "" And Me.chPC.Checked = True Then
        '            Where = Where & "(" & MarkProdGeo & " and " & "isPreviousCustomer = 'True')"
        '        Else
        '            If Where = "" Then
        '                Where = "isPreviousCustomer = 'True'"
        '            Else
        '                If PCQuery = "" Then
        '                    Where = Where & " or isPreviousCustomer = 'True'"
        '                End If
        '            End If
        '        End If
        '    End If
        'End If

        If Where <> "" Then
            Where = " Where " & Where
        End If
        'If Me.chkWC.Checked = False And Me.chRehash.Checked = False And Me.chPC.Checked = False Then
        '    MsgBox("You Must Check At Least One Type Of Lead To Generate List!", MsgBoxStyle.Exclamation, "No Lead Types Checked")
        '    Exit Sub
        'End If
        Slct = Slct & Where
        Dim cnn1 As SqlConnection = New SqlConnection(STATIC_VARIABLES.Cnn)
        Dim cmdGet1 As SqlCommand
        Dim r2 As SqlDataReader
        cmdGet1 = New SqlCommand(Slct, cnn1)


        cmdGet1.CommandType = CommandType.Text
        Try

            cnn1.Open()
            r2 = cmdGet1.ExecuteReader(CommandBehavior.CloseConnection)
            r2.Read()
            Me.txtRecordCount.Text = r2.Item(0)
            r2.Close()
            cnn1.Close()

        Catch ex As Exception
            Me.txtRecordCount.Text = "Error!"
        End Try

    End Sub



#End Region


#Region "Create Unified SQL State for Group / Sort Options"

    Private Function ConvertGroup(ByVal GroupVerbage As String, ByVal InitQuery As String, ByVal SortHeadings As ArrayList)
        '' in a single sort / group scenario this works
        '' fails for multi sort / and group scenario.
        '' need to take off the "ORDER BY ....asc/desc" on ALL fields selected for sort as well
        '' for subquery to pull uniques

        '' take array of headings, and look for them in initquery to strip them out of the "Order By clause for Unique query" 

        Dim i As Integer = 0
        For i = 0 To SortHeadings.Count - 1
            Select Case SortHeadings(i)
                Case Is = "City, State"
                    InitQuery = InitQuery.ToString.Replace("City asc,", " ")
                    InitQuery = InitQuery.ToString.Replace("City desc,", " ")
                    InitQuery = InitQuery.ToString.Replace("State asc,", " ")
                    InitQuery = InitQuery.ToString.Replace("State desc,", " ")
                    InitQuery = InitQuery.ToString.Replace("City asc", " ")
                    InitQuery = InitQuery.ToString.Replace("City desc", " ")
                    InitQuery = InitQuery.ToString.Replace("State asc", " ")
                    InitQuery = InitQuery.ToString.Replace("State desc", " ")
                    Exit Select
                Case Is = "Zip Code"
                    InitQuery = InitQuery.ToString.Replace("Zip asc,", " ")
                    InitQuery = InitQuery.ToString.Replace("Zip desc,", " ")
                    InitQuery = InitQuery.ToString.Replace("Zip asc", " ")
                    InitQuery = InitQuery.ToString.Replace("Zip desc", " ")
                    Exit Select
                Case Is = "Generated On"
                    InitQuery = InitQuery.ToString.Replace("LeadGeneratedOn asc,", " ")
                    InitQuery = InitQuery.ToString.Replace("LeadGeneratedOn desc,", " ")
                    InitQuery = InitQuery.ToString.Replace("LeadGeneratedOn asc", " ")
                    InitQuery = InitQuery.ToString.Replace("LeadGeneratedOn desc", " ")
                    Exit Select
                Case Is = "Appointment Date"
                    InitQuery = InitQuery.ToString.Replace("ApptDate asc,", " ")
                    InitQuery = InitQuery.ToString.Replace("ApptDate desc,", " ")
                    InitQuery = InitQuery.ToString.Replace("ApptDate asc", " ")
                    InitQuery = InitQuery.ToString.Replace("ApptDate desc", " ")
                    Exit Select
                Case Is = "Appointment Time"
                    InitQuery = InitQuery.ToString.Replace("ApptTime asc,", " ")
                    InitQuery = InitQuery.ToString.Replace("ApptTime desc,", " ")
                    InitQuery = InitQuery.ToString.Replace("ApptTime asc", " ")
                    InitQuery = InitQuery.ToString.Replace("ApptTime desc", " ")
                    Exit Select
                Case Is = "Primary Product"
                    InitQuery = InitQuery.ToString.Replace("Product1 asc,", " ")
                    InitQuery = InitQuery.ToString.Replace("Product1 desc,", " ")
                    InitQuery = InitQuery.ToString.Replace("Product1 asc", " ")
                    InitQuery = InitQuery.ToString.Replace("Product1 desc", " ")
                    Exit Select
                Case Is = "Marketer"
                    InitQuery = InitQuery.ToString.Replace("Marketer asc,", " ")
                    InitQuery = InitQuery.ToString.Replace("Marketer desc,", " ")
                    InitQuery = InitQuery.ToString.Replace("Marketer asc", " ")
                    InitQuery = InitQuery.ToString.Replace("Marketer desc", " ")
                    Exit Select
                Case Is = "Marketing Result"
                    InitQuery = InitQuery.ToString.Replace("MarketingResults asc,", " ")
                    InitQuery = InitQuery.ToString.Replace("MarketingResults desc,", " ")
                    InitQuery = InitQuery.ToString.Replace("MarketingResults asc", " ")
                    InitQuery = InitQuery.ToString.Replace("MarketingResults desc", " ")
                    Exit Select
                Case Else
                    Return InitQuery
                    Exit Select
            End Select
        Next


        Dim retSTR As String = ""
        Select Case GroupVerbage
            Case Is = "City, State"
                retSTR = "SELECT DISTINCT(City),State "
                InitQuery = InitQuery.ToString.Replace("Order By City asc", " ")
                InitQuery = InitQuery.ToString.Replace("Order By City desc", " ")
                Exit Select
            Case Is = "Zip Code"
                retSTR = "SELECT DISTINCT(Zip) "
                InitQuery = InitQuery.ToString.Replace("Order By Zip asc", " ")
                InitQuery = InitQuery.ToString.Replace("Order By Zip desc", " ")
                Exit Select
            Case Is = "Generated On"
                retSTR = "SELECT DISTINCT(LeadGeneratedOn) "
                InitQuery = InitQuery.ToString.Replace("Order By LeadGeneratedOn asc", " ")
                InitQuery = InitQuery.ToString.Replace("Order By LeadGeneratedOn desc", " ")
                Exit Select
            Case Is = "Appointment Date"
                retSTR = "SELECT DISTINCT(ApptDate) "
                InitQuery = InitQuery.ToString.Replace("Order By ApptDate asc", " ")
                InitQuery = InitQuery.ToString.Replace("Order By ApptDate desc", " ")
                Exit Select
            Case Is = "Appointment Time"
                retSTR = "SELECT DISTINCT(ApptTime) "
                InitQuery = InitQuery.ToString.Replace("Order By ApptTime asc", " ")
                InitQuery = InitQuery.ToString.Replace("Order By ApptTime desc", " ")
                Exit Select
            Case Is = "Primary Product"
                retSTR = "SELECT DISTINCT(Product1) "
                InitQuery = InitQuery.ToString.Replace("Order By Product1 asc", " ")
                InitQuery = InitQuery.ToString.Replace("Order By Product1 desc", " ")

                Exit Select
            Case Is = "Marketer"
                retSTR = "SELECT DISTINCT(Marketer) "
                InitQuery = InitQuery.ToString.Replace("Order By Marketer asc", " ")
                InitQuery = InitQuery.ToString.Replace("Order By Marketer desc", " ")
                Exit Select
            Case Is = "Marketing Result"
                retSTR = "SELECT DISTINCT(MarketingResults) "
                InitQuery = InitQuery.ToString.Replace("Order By MarketingResults asc", " ")
                InitQuery = InitQuery.ToString.Replace("Order By MarketingResults desc", " ")
                Exit Select
            Case Else
                Return InitQuery
                Exit Select
        End Select



        InitQuery = InitQuery.Replace("Order By", " ")

        Dim tailEnd As String = ""
        Select Case GroupVerbage
            Case Is = "City, State"
                tailEnd = "Order By City asc"
                Exit Select
            Case Is = "Zip Code"
                tailEnd = "Order By Zip desc"
                Exit Select
            Case Is = "Generated On"
                tailEnd = "Order By LeadGeneratedOn asc"
                Exit Select
            Case Is = "Appointment Date"
                tailEnd = "Order By ApptDate asc"
                Exit Select
            Case Is = "Appointment Time"
                tailEnd = "Order By ApptTime asc"
                Exit Select
            Case Is = "Primary Product"
                tailEnd = "Order By Product1 asc"
                Exit Select
            Case Is = "Marketer"
                tailEnd = "Order By Marketer asc"
                Exit Select
            Case Is = "Marketing Result"
                tailEnd = "Order By MarketingResults asc"
                Exit Select
            Case Else
                tailEnd = ";"
                Exit Select
        End Select

        Dim SUB_QUERY_STR As String = (retSTR & " FROM (" & InitQuery & ") AS SUBQUERY " & tailEnd)

        Return SUB_QUERY_STR

    End Function

#End Region

End Class