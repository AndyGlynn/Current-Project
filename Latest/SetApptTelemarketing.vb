Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System

Public Class SetApptTelemarketing


    Private Sub SetApptTelemarketing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Main
        Me.txtID.Text = ""
        Me.ClearForm()
        Me.txtID.Focus()
        Me.txtID.SelectAll()


    End Sub

    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        Me.ErrorProvider1.Clear()
        Dim c As Char = e.KeyChar
        If (c = "0") Or (c = "1") Or (c = "2") Or (c = "3") Or (c = "4") Or (c = "5") Or (c = "6") Or (c = "7") Or (c = "8") Or (c = "9") Or (c = vbBack) Then
        Else
            Me.ErrorProvider1.SetError(Me.btnSearch, "Field Can Only Contain Numbers!")
            e.KeyChar = Nothing
        End If
    End Sub


    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Me.ClearForm()

        Me.ErrorProvider1.Clear()
        Dim cnn As SqlConnection
        Dim cnt As SqlCommand
        Dim c1 As SqlDataReader
        Try
            cnn = New SqlConnection(STATIC_VARIABLES.Cnn)
            cnt = New SqlCommand("Select Count(ID) from enterlead where id = " & Me.txtID.Text, cnn)
            cnt.CommandType = CommandType.Text
            cnn.Open()
            c1 = cnt.ExecuteReader(CommandBehavior.CloseConnection)
            c1.Read()
            If c1.Item(0) = 0 Then
                Me.ErrorProvider1.SetError(Me.btnSearch, "Not a Valid ID")
                c1.Close()
                cnn.Close()
                Exit Sub
            Else
                Me.Cursor = Cursors.Default
                Main.Cursor = Cursors.Default
                c1.Close()
                cnn.Close()
            End If

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default
            c1.Close()
            cnn.Close()
        End Try

        Dim cmdget As SqlCommand
        Dim r1 As SqlDataReader
        Try
            cmdget = New SqlCommand("Select Contact1FirstName, Contact1LastName , Contact2FirstName ,Contact2LastName , StAddress ,city, state, zip, HousePhone ,AltPhone1 ,AltPhone2, Phone1Type ,Phone2Type ,Contact1WorkHours , Contact2WorkHours , EmailAddress , Marketer , PrimaryLeadSource ,SecondaryLeadSource ,Product1 ,Product2 ,Product3 ,Color ,ProductQTY ,ApptDate ,ApptTime ,SpecialInstruction, Spokewith from EnterLead Where id = " & Me.txtID.Text, cnn)
            cmdget.CommandType = CommandType.Text
            cnn.Open()
            r1 = cmdget.ExecuteReader(CommandBehavior.CloseConnection)
            While r1.Read()
                Me.txtContact1.Text = r1.Item(0) & " " & r1.Item(1)
                Me.txtContact2.Text = r1.Item(2) & " " & r1.Item(3)
                Me.txtAddress.Text = r1.Item(4) & vbCrLf & r1.Item(5) & ", " & r1.Item(6) & " " & r1.Item(7)
                Me.txtHousePhone.Text = r1.Item(8)
                Me.txtaltphone1.Text = r1.Item(9)
                Me.txtaltphone2.Text = r1.Item(10)
                Me.txtAlt1Type.Text = r1.Item(11)
                Me.txtAlt2Type.Text = r1.Item(12)
                Me.txtWorkHours.Text = r1.Item(13) & vbCrLf & r1.Item(14)
                Me.lnkEmail.Text = r1.Item(15)
                Me.cboMarketer.SelectedItem = r1.Item(16)
                If Me.cboMarketer.Text = "" And r1.Item(16) <> "" Then
                    Me.cboMarketer.Items.Add(r1.Item(16))
                    Me.cboMarketer.SelectedItem = r1.Item(16)
                End If
                Me.cboPriLead.SelectedItem = r1.Item(17)
                If Me.cboPriLead.Text = "" And r1.Item(17) <> "" Then
                    Me.cboPriLead.Items.Add(r1.Item(17))
                    Me.cboPriLead.SelectedItem = r1.Item(17)
                End If
                Me.cboSecLead.SelectedItem = r1.Item(18)
                If Me.cboSecLead.Text = "" And r1.Item(18) <> "" Then
                    Me.cboSecLead.Items.Add(r1.Item(18))
                    Me.cboSecLead.SelectedItem = r1.Item(18)
                End If
                Me.cboProduct1.SelectedItem = r1.Item(19)
                If Me.cboProduct1.Text = "" And r1.Item(19) <> "" Then
                    Me.cboProduct1.Items.Add(r1.Item(19))
                    Me.cboProduct1.SelectedItem = r1.Item(19)
                End If
                Me.cboProduct2.SelectedItem = r1.Item(20)
                If Me.cboProduct2.Text = "" And r1.Item(20) <> "" Then
                    Me.cboProduct2.Items.Add(r1.Item(20))
                    Me.cboProduct2.SelectedItem = r1.Item(20)
                End If
                Me.cboProduct3.Text = r1.Item(21)
                If Me.cboProduct3.Text = "" And r1.Item(21) <> "" Then
                    Me.cboProduct3.Items.Add(r1.Item(21))
                    Me.cboProduct3.SelectedItem = r1.Item(21)
                End If
                Me.txtProdColor.Text = r1.Item(22)
                Me.txtProdQTY.Text = r1.Item(23)
                Dim dt As Date = r1.Item(24)
                Dim tm As Date = r1.Item(25)
                Me.dtpApptInfo.Value = dt.ToShortDateString
                Me.txtApptTime.Value = tm
                Me.rtfSpecialIns.Text = r1.Item(26)
                Me.cboSpokeWith.Items.Add(r1.Item(0))
                If r1.Item(2) <> "" Then
                    Me.cboSpokeWith.Items.Add(r1.Item(2))
                    Me.cboSpokeWith.Items.Add(r1.Item(0) & " and " & r1.Item(2))
                End If
                Me.cboSpokeWith.SelectedItem = r1.Item(27)
            End While
            r1.Close()
            cnn.Close()


        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default
            r1.Close()
            cnn.Close()

        End Try





    End Sub
    Private Sub DayOfWeek(ByVal dt As Date)
        Try
            Dim d1 = dt.DayOfWeek
            Select Case d1
                Case Is = 0
                    Me.txtApptday.Text = "Sunday"
                    Exit Select
                Case Is = 1
                    Me.txtApptday.Text = "Monday"
                    Exit Select
                Case Is = 2
                    Me.txtApptday.Text = "Tuesday"
                    Exit Select
                Case Is = 3
                    Me.txtApptday.Text = "Wednesday"
                    Exit Select
                Case Is = 4
                    Me.txtApptday.Text = "Thursday"
                    Exit Select
                Case Is = 5
                    Me.txtApptday.Text = "Friday"
                    Exit Select
                Case Is = 6
                    Me.txtApptday.Text = "Saturday"
                    Exit Select
            End Select
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "SetApptTelemarketing", "SetApptTelemarketing", "Sub", "DayOfWeek(ByVal dt As Date)", "0", ex.Message.ToString)
            y = Nothing
        End Try
    End Sub

    Private Sub dtpApptInfo_ValueChanged(sender As Object, e As EventArgs) Handles dtpApptInfo.ValueChanged
        Me.DayOfWeek(Me.dtpApptInfo.Value)
    End Sub
    Private Sub ClearForm()
        Me.txtContact1.Text = ""
        Me.txtContact2.Text = ""
        Me.txtAddress.Text = ""
        Me.txtWorkHours.Text = ""
        Me.txtHousePhone.Text = ""
        Me.txtaltphone1.Text = ""
        Me.txtaltphone2.Text = ""
        Me.txtAlt1Type.Text = ""
        Me.txtAlt2Type.Text = ""
        Me.lnkEmail.Text = ""
        Me.cboMarketer.SelectedItem = Nothing
        Me.cboPriLead.SelectedItem = Nothing
        Me.cboSecLead.SelectedItem = Nothing
        Me.cboProduct1.SelectedItem = Nothing
        Me.cboProduct2.SelectedItem = Nothing
        Me.cboProduct3.SelectedItem = Nothing
        Me.txtProdColor.Text = ""
        Me.txtProdQTY.Text = ""
        Me.rtfSpecialIns.Text = ""
        Me.dtpApptInfo.Value = Today
        Me.txtApptTime.Value = Now
        Me.cboSpokeWith.SelectedItem = Nothing
        Me.cboSpokeWith.Items.Clear()
        Me.cboPriLead.Items.Clear()
        Me.cboSecLead.Items.Clear()
        Me.cboProduct1.Items.Clear()
        Me.cboProduct2.Items.Clear()
        Me.cboProduct3.Items.Clear()
        Me.cboMarketer.Items.Clear()
        Dim x As New cbo_List_Fill(Me.cboPriLead, True, True)
        Dim y As New cbo_List_Fill(Me.cboProduct1, True, True)
        Dim z As New cbo_List_Fill(Me.cboProduct2, True, True)
        Dim a As New cbo_List_Fill(Me.cboProduct3, True, True)
        Dim b As New cbo_List_Fill(Me.cboMarketer, True, True)


    End Sub

    Private Sub cboMarketer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMarketer.SelectedIndexChanged
        If Me.cboMarketer.SelectedItem = "<Add New>" Then
            MarketerLeadSources.Show()
            MarketerLeadSources.Frm = Me
            Exit Sub
        ElseIf Me.cboMarketer.SelectedItem <> Nothing Then
            If Me.cboMarketer.SelectedItem.ToString.Contains("_____") = True Then
                Me.cboMarketer.SelectedItem = Nothing
                Exit Sub
            End If
        End If
        If Me.cboMarketer.SelectedItem <> Nothing Then
            Try
                Dim fname As String = ""
                Dim lname As String = ""
                Dim name
                name = Split(Me.cboMarketer.Text, " ", 2)
                fname = name(0)
                lname = name(1)


                Me.GetMarketerLeadSources(fname, lname)

            Catch ex As Exception
                Me.Cursor = Cursors.Default
                Main.Cursor = Cursors.Default
                Dim y As New ErrorLogging_V2
                y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "EnterLead", "FormCode", "Event", "cboMarketer_SelectedValueChanged(ENTER_LEAD.PopPLSandSLS)", "0", ex.Message.ToString)
                y = Nothing
            End Try
        End If
    End Sub
    Public Sub WriteMarketerToTable(ByVal MFname As String, ByVal MLName As String, ByVal PLS As String, ByVal SLS As String, ByVal MarketingMan As String)
        Dim cnn As SqlConnection = New SqlConnection(STATIC_VARIABLES.Cnn)
        Try

            Dim cmdINS As SqlCommand = New SqlCommand("dbo.InsertMarkter", Cnn)
            cmdINS.CommandType = CommandType.StoredProcedure
            Dim param1 As SqlParameter = New SqlParameter("@Fname", MFname)
            Dim param2 As SqlParameter = New SqlParameter("@LName", MLName)
            Dim param3 As SqlParameter = New SqlParameter("@PriLeadSource", PLS)
            Dim param4 As SqlParameter = New SqlParameter("@SecLeadSource", SLS)
            Dim param5 As SqlParameter = New SqlParameter("@MarketingManager", MarketingMan)
            cmdINS.Parameters.Add(param1)
            cmdINS.Parameters.Add(param2)
            cmdINS.Parameters.Add(param3)
            cmdINS.Parameters.Add(param4)
            cmdINS.Parameters.Add(param5)
            Cnn.Open()
            Dim r1 As SqlDataReader
            r1 = cmdINS.ExecuteReader
            r1.Close()
            Cnn.Close()

            Dim x As New cbo_List_Fill(Me.cboMarketer, True, True)
            Me.cboMarketer.SelectedItem = MFname & " " & MLName
            Dim y As New cbo_List_Fill(Me.cboPriLead, True, True)
            Me.cboPriLead.SelectedItem = PLS
            Me.cboSecLead.SelectedItem = SLS



            MarketerLeadSources.MFName = ""
            MarketerLeadSources.MLName = ""
            MarketerLeadSources.cboSLS.Text = ""
            MarketerLeadSources.cboPRILS.Text = ""
            MarketerLeadSources.cboMM.Text = ""
            MarketerLeadSources.Close()
        Catch ex As Exception
            cnn.Close()
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default
            'Dim err As New ErrorLogFlatFile
            'err.WriteLog("ENTER_LEAD.InsertMarketer", "ByVal MFname As String, ByVal MLName As String, ByVal PLS As String, ByVal SLS As String, ByVal MarketingMan As String", ex.Message.ToString, "Client", STATIC_VARIABLES.CurrentUser & ", " & STATIC_VARIABLES.CurrentForm, "SQL", "WriteMarketerToTable")
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "SetApptTelemarketing", "SetApptTelemarketing", "Sub", "WriteMarketerToTable(MFname,MLname,PLS,SLS,MarketingMan)", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub



    Private Sub cboSecLead_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSecLead.SelectedIndexChanged
        If Me.cboSecLead.SelectedItem = "<Add New>" Then
            Dim z As String = InputBox$("Enter new Secondary Lead Source", "New Secondary Lead Source for " & Me.cboPriLead.SelectedItem.ToString)
            If z.ToString.Length < 2 Then
                Me.cboSecLead.SelectedItem = ""
                Exit Sub
            End If
            Me.InsertSLS(Me.cboPriLead.SelectedItem.ToString, z)
            Dim n As New cbo_List_Fill(Me.cboSecLead, True, True)
            Me.cboSecLead.SelectedItem = z
        ElseIf Me.cboSecLead.SelectedItem <> Nothing Then
            If Me.cboSecLead.SelectedItem.ToString.Contains("_____") = True Then
                Me.cboSecLead.SelectedItem = Nothing
            End If
        End If
    End Sub

    Private Sub cboPriLead_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPriLead.SelectedIndexChanged
        If Me.cboPriLead.SelectedItem = "<Add New>" Then

            Dim pls As String = ""
            pls = Me.CapitalizeText(InputBox$("Enter new Primary Lead Source", "New Primary Lead Source"))
            If pls.ToString.Length < 2 Then
                Me.cboPriLead.SelectedItem = ""
                Me.cboSecLead.Items.Clear()
                Exit Sub
            End If
            Me.InsertNewPLS(pls)
        ElseIf Me.cboPriLead.SelectedItem <> Nothing Then
            If Me.cboPriLead.SelectedItem.ToString.Contains("____") = True Then
                Me.cboPriLead.SelectedItem = Nothing
                Me.cboSecLead.Items.Clear()
                Exit Sub
            End If
        End If
        If Me.cboPriLead.SelectedItem <> Nothing Then
            Dim x As New cbo_List_Fill(Me.cboSecLead, True, True)
        Else
            Me.cboSecLead.Items.Clear()
        End If

    End Sub
    Public Sub InsertNewPLS(ByVal PLS As String)
        Dim cnn As SqlConnection = New SqlConnection(STATIC_VARIABLES.Cnn)
        Try
            Dim cmdCNT As SqlCommand = New SqlCommand("SELECT COUNT(ID) from .PrimaryLeadSource WHERE PrimaryLead = @PLS", Cnn)
            Dim param1 As SqlParameter = New SqlParameter("@PLS", PLS)

            PLS = CapitalizeText(PLS)
            cmdCNT.Parameters.Add(param1)
            Dim cnt As Integer = 0
            Select Case cnt
                Case Is >= 1
                    MsgBox("Duplicate Primary Lead Source Exists. Please enter a new one.", MsgBoxStyle.Exclamation, "ERROR")
                    Exit Sub
                Case Is < 1
                    Dim cmdINS As SqlCommand = New SqlCommand("dbo.InsertPLS", Cnn)
                    Dim param2 As SqlParameter = New SqlParameter("@PLS", PLS)
                    cmdINS.Parameters.Add(param2)
                    cmdINS.CommandType = CommandType.StoredProcedure
                    Cnn.Open()
                    Dim r1 As SqlDataReader
                    r1 = cmdINS.ExecuteReader
                    r1.Close()
                    Cnn.Close()
                    Dim y As New cbo_List_Fill(Me.cboPriLead, True, True)
                    Me.cboPriLead.SelectedItem = PLS
            End Select
        Catch ex As Exception
            cnn.Close()
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default
            'Dim err As New ErrorLogFlatFile
            'err.WriteLog("ENTER_LEAD.InsertPLS", "ByVal PLS As String", ex.Message.ToString, "Client", STATIC_VARIABLES.CurrentUser & ", " & STATIC_VARIABLES.CurrentForm, "SQL", "InsertNewPLS")
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "SetApptTelemarketing", "SetApptTelemarketing", "Sub", "InsertNewPLS(PLS)", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub
    Public Function CapitalizeText(ByVal TextToCap As String)
        Try
            Dim Text
            Text = Mid(TextToCap, 1, 1)
            Text = Text.ToString.ToUpper
            TextToCap = Text & Mid(TextToCap, 2, TextToCap.Length)
            Return TextToCap
        Catch ex As Exception
            Return TextToCap
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default
            'Dim err As New ErrorLogFlatFile
            'err.WriteLog("ENTER_LEAD.InsertMarketer", "ByVal TextToCap as string", ex.Message.ToString, "Client", STATIC_VARIABLES.CurrentUser & ", " & STATIC_VARIABLES.CurrentForm, "Front_End", "CapitalizeText")
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "SetApptTelemarketing", "SetApptTelemarketing", "Function", "CapitalizeText(texttocap)", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Function
    Public Sub InsertSLS(ByVal PLS As String, ByVal SLS As String)
        Dim cnn As SqlConnection = New SqlConnection(STATIC_VARIABLES.Cnn)
        Try
            Dim cmdCNT As SqlCommand = New SqlCommand("SELECT COUNT(ID) from .SecondaryLeadSource WHERE SecondaryLead = @SLS and PrimaryLead = @PLS", Cnn)
            Dim param1 As SqlParameter = New SqlParameter("@SLS", SLS)
            Dim param2 As SqlParameter = New SqlParameter("@PLS", PLS)
            cmdCNT.Parameters.Add(param1)
            cmdCNT.Parameters.Add(param2)
            Cnn.Open()
            Dim cnt As Integer = 0
            Dim r1 As SqlDataReader
            r1 = cmdCNT.ExecuteReader
            While r1.Read
                cnt = r1.Item(0)
            End While
            r1.Close()
            Cnn.Close()
            Select Case cnt
                Case Is >= 1
                    MsgBox("Duplicate Seconadary Lead Source Exists.Please try again.", MsgBoxStyle.Exclamation, "ERROR")
                    Exit Sub
                Case Is < 1
                    Dim cmdINS As SqlCommand = New SqlCommand("dbo.InsertSLS", Cnn)
                    Dim param3 As SqlParameter = New SqlParameter("@PrimaryLead", PLS)
                    Dim param4 As SqlParameter = New SqlParameter("@SecondaryLead", SLS)
                    cmdINS.Parameters.Add(param3)
                    cmdINS.Parameters.Add(param4)
                    cmdINS.CommandType = CommandType.StoredProcedure
                    Cnn.Open()
                    Dim r2 As SqlDataReader
                    r2 = cmdINS.ExecuteReader
                    r2.Close()
                    Cnn.Close()

                    Dim x As New cbo_List_Fill(Me.cboSecLead, True, True)
                    Me.cboSecLead.SelectedItem = SLS
                    Exit Select
            End Select
        Catch ex As Exception
            cnn.Close()
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default
            'Dim err As New ErrorLogFlatFile
            'err.WriteLog("ENTER_LEAD.InsertSLS", "ByVal PLS As String, ByVal SLS As String", ex.Message.ToString, "Client", STATIC_VARIABLES.CurrentUser & ", " & STATIC_VARIABLES.CurrentForm, "SQL", "InsertSLS")
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "SetApptTelemarketing", "SetApptTelemarketing", "Sub", "InserSLS(pls,sls)", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub cboProduct1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProduct1.SelectedIndexChanged
        If Me.cboProduct1.SelectedItem = "<Add New>" Then
            Dim pr As String = ""
            Dim prA As String = ""

            pr = Me.CapitalizeText(InputBox$("Enter new product name", "New Product Name"))
            If pr.ToString.Length < 2 Then
                Me.cboProduct1.Text = ""
                Exit Sub
            End If
            prA = Me.CapitalizeText(InputBox$("Enter product acronym.(2 Letters)", "Product Acronym"))
            If prA.ToString.Length < 2 Then
                Me.cboProduct1.Text = ""
                Exit Sub
            End If
            Me.AddNewProduct(pr, prA, "CBO1")
        ElseIf Me.cboProduct1.SelectedItem <> Nothing Then
            If Me.cboProduct1.SelectedItem.ToString.Contains("_____") = True Then
                Me.cboProduct1.SelectedItem = Nothing
            End If
        End If
    End Sub


    Private Sub AddNewProduct(ByVal Product As String, ByVal ProdACRO As String, ByVal CBO As String)
        Dim cnn As SqlConnection = New SqlConnection(STATIC_VARIABLES.Cnn)
        Try
            Dim cmdCNT As SqlCommand = New SqlCommand("SELECT count(ID) from .products where Product = @Product", Cnn)
            Dim param1 As SqlParameter = New SqlParameter("@Product", Product)
            cmdCNT.Parameters.Add(param1)
            Cnn.Open()
            Dim cnt As Integer = 0
            Dim r1 As SqlDataReader
            r1 = cmdCNT.ExecuteReader
            While r1.Read
                cnt = r1.Item(0)
            End While
            r1.Close()
            Cnn.Close()
            Select Case cnt
                Case Is < 1
                    Dim cmdINS As SqlCommand = New SqlCommand("dbo.InsertProduct", Cnn)
                    cmdINS.CommandType = CommandType.StoredProcedure
                    Dim param2 As SqlParameter = New SqlParameter("@Product", Product)
                    Dim param3 As SqlParameter = New SqlParameter("@ProdACRO", ProdACRO)
                    Cnn.Open()
                    cmdINS.Parameters.Add(param2)
                    cmdINS.Parameters.Add(param3)
                    Dim r2 As SqlDataReader
                    r2 = cmdINS.ExecuteReader
                    r2.Close()
                    Cnn.Close()
                    Dim a As String = Me.cboProduct1.SelectedItem.ToString
                    Dim b As String = Me.cboProduct2.SelectedItem.ToString
                    Dim c As String = Me.cboProduct3.SelectedItem.ToString
                    Dim x As New cbo_List_Fill(Me.cboProduct1, True, True)
                    Dim y As New cbo_List_Fill(Me.cboProduct2, True, True)
                    Dim z As New cbo_List_Fill(Me.cboProduct3, True, True)

                    Select Case CBO
                        Case Is = "CBO1"
                            Me.cboProduct1.SelectedItem = Product
                            Me.cboProduct2.SelectedItem = b
                            If Me.cboProduct2.SelectedItem = Nothing Then
                                Me.cboProduct2.Items.Add(b)
                                Me.cboProduct2.SelectedItem = b
                            End If
                            Me.cboProduct3.SelectedItem = c
                            If Me.cboProduct3.SelectedItem = Nothing Then
                                Me.cboProduct3.Items.Add(c)
                                Me.cboProduct3.SelectedItem = c
                            End If
                            Exit Select
                        Case Is = "CBO2"
                            Me.cboProduct2.SelectedItem = Product
                            Me.cboProduct1.SelectedItem = a
                            If Me.cboProduct1.SelectedItem = Nothing Then
                                Me.cboProduct1.Items.Add(a)
                                Me.cboProduct1.SelectedItem = a
                            End If
                            Me.cboProduct3.SelectedItem = c
                            If Me.cboProduct3.SelectedItem = Nothing Then
                                Me.cboProduct3.Items.Add(c)
                                Me.cboProduct3.SelectedItem = c
                            End If
                            Exit Select
                        Case Is = "CBO3"
                            Me.cboProduct3.SelectedItem = Product
                            Me.cboProduct1.SelectedItem = a
                            If Me.cboProduct1.SelectedItem = Nothing Then
                                Me.cboProduct1.Items.Add(a)
                                Me.cboProduct1.SelectedItem = a
                            End If
                            Me.cboProduct2.SelectedItem = b
                            If Me.cboProduct2.SelectedItem = Nothing Then
                                Me.cboProduct2.Items.Add(b)
                                Me.cboProduct2.SelectedItem = b
                            End If
                            Exit Select
                    End Select
                Case Is >= 1
                    MsgBox("Duplicate Product exists. Please enter a new one.", MsgBoxStyle.Exclamation)
                    Exit Sub
            End Select
        Catch ex As Exception
            cnn.Close()
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default
            'Dim err As New ErrorLogFlatFile
            'err.WriteLog("ENTER_LEAD.AddNewProduct", "None", ex.Message.ToString, "Client", STATIC_VARIABLES.CurrentUser & ", " & STATIC_VARIABLES.CurrentForm, "SQL", "AddNewProduct")
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "SetApptTelemarketing", "SetApptTelemarketing", "Sub", "AddnewProduct(product,acro,cbo)", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub cboProduct2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProduct2.SelectedIndexChanged
        If Me.cboProduct2.SelectedItem = "<Add New>" Then
            Dim pr As String = ""
            Dim prA As String = ""

            pr = Me.CapitalizeText(InputBox$("Enter new product name", "New Product Name"))
            If pr.ToString.Length < 2 Then
                Me.cboProduct2.Text = ""
                Exit Sub
            End If
            prA = Me.CapitalizeText(InputBox$("Enter product acronym.(2 Letters)", "Product Acronym"))
            If prA.ToString.Length < 2 Then
                Me.cboProduct2.Text = ""
                Exit Sub
            End If
            Me.AddNewProduct(pr, prA, "CBO2")
        ElseIf Me.cboProduct2.SelectedItem <> Nothing Then
            If Me.cboProduct2.SelectedItem.ToString.Contains("_____") = True Then
                Me.cboProduct2.SelectedItem = Nothing
            End If
        End If
    End Sub

    Private Sub cboProduct3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProduct3.SelectedIndexChanged
        If Me.cboProduct3.SelectedItem = "<Add New>" Then
            Dim pr As String = ""
            Dim prA As String = ""

            pr = Me.CapitalizeText(InputBox$("Enter new product name", "New Product Name"))
            If pr.ToString.Length < 2 Then
                Me.cboProduct3.Text = ""
                Exit Sub
            End If
            prA = Me.CapitalizeText(InputBox$("Enter product acronym.(2 Letters)", "Product Acronym"))
            If prA.ToString.Length < 2 Then
                Me.cboProduct3.Text = ""
                Exit Sub
            End If
            Me.AddNewProduct(pr, prA, "CBO3")
        ElseIf Me.cboProduct3.SelectedItem <> Nothing Then
            If Me.cboProduct3.SelectedItem.ToString.Contains("_____") = True Then
                Me.cboProduct3.SelectedItem = Nothing
            End If
        End If
    End Sub
    Private MM As String
    Private Sub GetMarketerLeadSources(ByVal FName As String, ByVal LName As String)
        Dim cnn As SqlConnection = New SqlConnection(STATIC_VARIABLES.Cnn)
        Try
            Dim cmdGet As SqlCommand = New SqlCommand("dbo.GetMarketerLeadSources", Cnn)
            Dim param1 As SqlParameter = New SqlParameter("@FName", FName)
            Dim param2 As SqlParameter = New SqlParameter("@LName", LName)
            cmdGet.Parameters.Add(param1)
            cmdGet.Parameters.Add(param2)
            Cnn.Open()
            cmdGet.CommandType = CommandType.StoredProcedure
            Dim r1 As SqlDataReader
            r1 = cmdGet.ExecuteReader
            While r1.Read



                Me.cboPriLead.Text = r1.Item(0)

                MM = r1.Item(2)
                Me.cboSecLead.Text = r1.Item(1)

                Me.cboProduct1.Focus()



            End While
            r1.Close()
            Cnn.Close()
        Catch ex As Exception
            cnn.Close()
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default
            'Dim err As New ErrorLogFlatFile
            'err.WriteLog("ENTER_LEAD.PopulatePLSandSLSByMarketer", "ByVal FName As String, ByVal LName As String", ex.Message.ToString, "Client", STATIC_VARIABLES.CurrentUser & ", " & STATIC_VARIABLES.CurrentForm, "SQL", "GetMarketerLeadSources")
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "SetApptTelemarketing", "SetApptTelemarketing", "Sub", "GetMarketerLeadSources(fname,lname)", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub

    Private Sub btnSaveClose_Click(sender As Object, e As EventArgs) Handles btnSaveClose.Click
        Me.ErrorProvider1.Clear()
        Try
            If Me.cboSpokeWith.Text = "" Then
                Me.ErrorProvider1.SetError(Me.cboSpokeWith, "You Must supply a Name!")
                Exit Sub
            End If
            If Me.cboMarketer.SelectedItem = Nothing Then
                Me.ErrorProvider1.SetError(Me.cboMarketer, "You Must Supply a Marketer")
                Exit Sub
            Else
                If cboMarketer.SelectedItem.ToString = "" Then
                    Me.ErrorProvider1.SetError(Me.cboMarketer, "You Must Supply a Marketer")
                    Exit Sub
                End If
            End If
            If Me.cboSecLead.SelectedItem <> Nothing Then
                'If Me.cboSecLead.SelectedItem <> "Warm Calling" Or Me.cboSecLead.SelectedItem <> "Recovery" Or Me.cboSecLead.SelectedItem <> "Previous Customers" Then
                '    Me.ErrorProvider1.SetError(Me.cboSecLead, "Secondary Lead Source Must be Warm Calling, Recovery, or Previous Customers")
                '    Exit Sub
                'End If
                Select Case Me.cboSecLead.SelectedItem.ToString
                    Case "Warm Calling", "Previous Customers", "Recovery"
                    Case Else
                        Me.ErrorProvider1.SetError(Me.cboSecLead, "Secondary Lead Source Must be Warm Calling, Recovery, or Previous Customers")
                        Exit Sub
                End Select
            Else
                Me.ErrorProvider1.SetError(Me.cboSecLead, "Secondary Lead Source Must be Warm Calling, Recovery, or Previous Customers")
                Exit Sub
            End If
            Dim Description As String

            Dim day = Me.dtpApptInfo.Value.DayOfWeek
            If day = 0 Then
                day = "Sunday"
            ElseIf day = 1 Then
                day = "Monday"
            ElseIf day = 2 Then
                day = "Tuesday"
            ElseIf day = 3 Then
                day = "Wednesday"
            ElseIf day = 4 Then
                day = "Thursday"
            ElseIf day = 5 Then
                day = "Friday"
            ElseIf day = 6 Then
                day = "Saturday"
            End If


            Dim s = Split(Me.dtpApptInfo.Value.ToString, " ")
            Dim dt = s(0) & " 12:00:00 AM"
            Dim s2 = Split(Me.txtApptTime.Value.ToString, " ")
            Dim tm

            Try
                tm = "1/1/1900 " & s2(1) & s2(2)

            Catch ex As Exception
                tm = "1/1/1900 " & s2(0) & s2(1)
            End Try
            If Me.cboSecLead.SelectedItem = "Warm Calling" Then
                Description = "Appt. Set from Warm Calling by " & Me.cboMarketer.SelectedItem.ToString & ", set up with " & Me.cboSpokeWith.Text & " for " & day & ", " & CDate(dt).ToShortDateString & " at " & CDate(tm).ToShortTimeString & "."
            ElseIf Me.cboSecLead.SelectedItem = "Recovery" Then
                Description = "Appt. Set from Recovery by " & Me.cboMarketer.SelectedItem.ToString & ", set up with " & Me.cboSpokeWith.Text & " for " & day & ", " & CDate(dt).ToShortDateString & " at " & CDate(tm).ToShortTimeString & "."
            ElseIf Me.cboSecLead.SelectedItem = "Previous Customers" Then
                Description = "Appt. Set from Previous Customer by " & Me.cboMarketer.SelectedItem.ToString & ", set up with " & Me.cboSpokeWith.Text & " for " & day & ", " & CDate(dt).ToShortDateString & " at " & CDate(tm).ToShortTimeString & "."
            Else
                Description = "Appt. Set from Telemarketing by " & Me.cboMarketer.SelectedItem.ToString & ", set up with " & Me.cboSpokeWith.Text & " for " & day & ", " & CDate(dt).ToShortDateString & " at " & CDate(tm).ToShortTimeString & "."
            End If

            Dim frm As String
            If Me.cboSecLead.SelectedItem <> Nothing Then

                If Me.cboSecLead.SelectedItem.ToString = "Warm Calling" Then
                    frm = "WCaller"
                ElseIf Me.cboSecLead.SelectedItem.ToString = "Recovery" Then
                    frm = "Recovery"
                ElseIf Me.cboSecLead.SelectedItem.ToString = "Previous Customers" Then
                    frm = "PreviousCustomer"
                Else
                    frm = "WCaller"
                End If
            Else
                frm = "WCaller"
            End If
            ''Fix manager problem 
            If MM = "" Or MM = Nothing Then
                MM = "Chris Dames"
            End If
            Dim cnn = New SqlConnection(STATIC_VARIABLES.Cnn)

            Dim cmdIns As SqlCommand = New SqlCommand("dbo.LogSetAppt", cnn)
            Dim param1 As SqlParameter = New SqlParameter("@ID", Me.txtID.Text)
            Dim param2 As SqlParameter = New SqlParameter("@User", Me.cboMarketer.SelectedItem.ToString)
            Dim param3 As SqlParameter = New SqlParameter("@Spokewith", Me.cboSpokeWith.Text)
            Dim param4 As SqlParameter = New SqlParameter("@ApptDate", dt)
            Dim param5 As SqlParameter = New SqlParameter("@Description", Description)
            Dim param6 As SqlParameter = New SqlParameter("@ApptTime", tm)
            Dim param7 As SqlParameter = New SqlParameter("@Notes", "")
            Dim param8 As SqlParameter = New SqlParameter("@Manager", MM)
            Dim param9 As SqlParameter = New SqlParameter("@Confirmed", "False")
            Dim param10 As SqlParameter = New SqlParameter("@Form", frm)

            cmdIns.CommandType = CommandType.StoredProcedure
            cmdIns.Parameters.Add(param1)
            cmdIns.Parameters.Add(param2)
            cmdIns.Parameters.Add(param3)
            cmdIns.Parameters.Add(param4)
            cmdIns.Parameters.Add(param5)
            cmdIns.Parameters.Add(param6)
            cmdIns.Parameters.Add(param7)
            cmdIns.Parameters.Add(param8)
            cmdIns.Parameters.Add(param9)
            cmdIns.Parameters.Add(param10)
            cnn.Open()
            Dim R1 As SqlDataReader
            R1 = cmdIns.ExecuteReader(CommandBehavior.CloseConnection)
            R1.Read()
            R1.Close()
            cnn.close()
            Me.Close()
            Me.Dispose()





        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "SendNotesSM", "FormCode", "Event", "btnSaveClose_Click", "0", ex.Message.ToString)
            y = Nothing
        End Try
    End Sub

    Private Sub btnSaveNew_Click(sender As Object, e As EventArgs) Handles btnSaveNew.Click
        Me.ErrorProvider1.Clear()
        Try
            If Me.cboSpokeWith.Text = "" Then
                Me.ErrorProvider1.SetError(Me.cboSpokeWith, "You Must supply a Name!")
                Exit Sub
            End If
            If Me.cboMarketer.SelectedItem = Nothing Then
                Me.ErrorProvider1.SetError(Me.cboMarketer, "You Must Supply a Marketer")
                Exit Sub
            Else
                If cboMarketer.SelectedItem.ToString = "" Then
                    Me.ErrorProvider1.SetError(Me.cboMarketer, "You Must Supply a Marketer")
                    Exit Sub
                End If
            End If
            If Me.cboSecLead.SelectedItem <> Nothing Then
                'If Me.cboSecLead.SelectedItem <> "Warm Calling" Or Me.cboSecLead.SelectedItem <> "Recovery" Or Me.cboSecLead.SelectedItem <> "Previous Customers" Then
                '    Me.ErrorProvider1.SetError(Me.cboSecLead, "Secondary Lead Source Must be Warm Calling, Recovery, or Previous Customers")
                '    Exit Sub
                'End If
                Select Case Me.cboSecLead.SelectedItem.ToString
                    Case "Warm Calling", "Previous Customers", "Recovery"
                    Case Else
                        Me.ErrorProvider1.SetError(Me.cboSecLead, "Secondary Lead Source Must be Warm Calling, Recovery, or Previous Customers")
                        Exit Sub
                End Select
            Else
                Me.ErrorProvider1.SetError(Me.cboSecLead, "Secondary Lead Source Must be Warm Calling, Recovery, or Previous Customers")
                Exit Sub
            End If
            Dim Description As String

            Dim day = Me.dtpApptInfo.Value.DayOfWeek
            If day = 0 Then
                day = "Sunday"
            ElseIf day = 1 Then
                day = "Monday"
            ElseIf day = 2 Then
                day = "Tuesday"
            ElseIf day = 3 Then
                day = "Wednesday"
            ElseIf day = 4 Then
                day = "Thursday"
            ElseIf day = 5 Then
                day = "Friday"
            ElseIf day = 6 Then
                day = "Saturday"
            End If


            Dim s = Split(Me.dtpApptInfo.Value.ToString, " ")
            Dim dt = s(0) & " 12:00:00 AM"
            Dim s2 = Split(Me.txtApptTime.Value.ToString, " ")
            Dim tm

            Try
                tm = "1/1/1900 " & s2(1) & s2(2)

            Catch ex As Exception
                tm = "1/1/1900 " & s2(0) & s2(1)
            End Try
            If Me.cboSecLead.SelectedItem = "Warm Calling" Then
                Description = "Appt. Set from Warm Calling by " & Me.cboMarketer.SelectedItem.ToString & ", set up with " & Me.cboSpokeWith.Text & " for " & day & ", " & CDate(dt).ToShortDateString & " at " & CDate(tm).ToShortTimeString & "."
            ElseIf Me.cboSecLead.SelectedItem = "Recovery" Then
                Description = "Appt. Set from Recovery by " & Me.cboMarketer.SelectedItem.ToString & ", set up with " & Me.cboSpokeWith.Text & " for " & day & ", " & CDate(dt).ToShortDateString & " at " & CDate(tm).ToShortTimeString & "."
            ElseIf Me.cboSecLead.SelectedItem = "Previous Customers" Then
                Description = "Appt. Set from Previous Customer by " & Me.cboMarketer.SelectedItem.ToString & ", set up with " & Me.cboSpokeWith.Text & " for " & day & ", " & CDate(dt).ToShortDateString & " at " & CDate(tm).ToShortTimeString & "."
            Else
                Description = "Appt. Set from Telemarketing by " & Me.cboMarketer.SelectedItem.ToString & ", set up with " & Me.cboSpokeWith.Text & " for " & day & ", " & CDate(dt).ToShortDateString & " at " & CDate(tm).ToShortTimeString & "."
            End If

            Dim frm As String
            If Me.cboSecLead.SelectedItem <> Nothing Then

                If Me.cboSecLead.SelectedItem.ToString = "Warm Calling" Then
                    frm = "WCaller"
                ElseIf Me.cboSecLead.SelectedItem.ToString = "Recovery" Then
                    frm = "Recovery"
                ElseIf Me.cboSecLead.SelectedItem.ToString = "Previous Customers" Then
                    frm = "PreviousCustomer"
                Else
                    frm = "WCaller"
                End If
            Else
                frm = "WCaller"
            End If
            If MM = "" Or MM = Nothing Then
                MM = "Chris Dames"
            End If



            Dim cnn = New SqlConnection(STATIC_VARIABLES.Cnn)

            Dim cmdIns As SqlCommand = New SqlCommand("dbo.LogSetAppt", cnn)
            Dim param1 As SqlParameter = New SqlParameter("@ID", Me.txtID.Text)
            Dim param2 As SqlParameter = New SqlParameter("@User", Me.cboMarketer.SelectedItem.ToString)
            Dim param3 As SqlParameter = New SqlParameter("@Spokewith", Me.cboSpokeWith.Text)
            Dim param4 As SqlParameter = New SqlParameter("@ApptDate", dt)
            Dim param5 As SqlParameter = New SqlParameter("@Description", Description)
            Dim param6 As SqlParameter = New SqlParameter("@ApptTime", tm)
            Dim param7 As SqlParameter = New SqlParameter("@Notes", "")
            Dim param8 As SqlParameter = New SqlParameter("@Manager", MM)
            Dim param9 As SqlParameter = New SqlParameter("@Confirmed", "False")
            Dim param10 As SqlParameter = New SqlParameter("@Form", frm)

            cmdIns.CommandType = CommandType.StoredProcedure
            cmdIns.Parameters.Add(param1)
            cmdIns.Parameters.Add(param2)
            cmdIns.Parameters.Add(param3)
            cmdIns.Parameters.Add(param4)
            cmdIns.Parameters.Add(param5)
            cmdIns.Parameters.Add(param6)
            cmdIns.Parameters.Add(param7)
            cmdIns.Parameters.Add(param8)
            cmdIns.Parameters.Add(param9)
            cmdIns.Parameters.Add(param10)
            cnn.Open()
            Dim R1 As SqlDataReader
            R1 = cmdIns.ExecuteReader(CommandBehavior.CloseConnection)
            R1.Read()
            R1.Close()
            cnn.close()
            Me.ClearForm()
            Me.txtID.Text = ""





        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "SendNotesSM", "FormCode", "Event", "btnSaveClose_Click", "0", ex.Message.ToString)
            y = Nothing
        End Try
    End Sub
End Class
