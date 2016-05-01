Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System

Public Class cbo_List_Fill
    Dim frm As Form
    Dim cbo
    Dim Dept As String
    Dim QueryString As String = ""


    Public Sub New(Combo As Object, Add_New As Boolean, Blank_Selection As Boolean)
        Try
            Select Case Combo.GetType.ToString
                Case Is = "System.Windows.Forms.ToolStripComboBox"
                    frm = Get_Parent_Form(Combo)
                    cbo = Combo
                    cbo = DirectCast(Combo, ToolStripComboBox)
                Case Is = "System.Windows.Forms.ComboBox"
                    frm = cbo.FindForm
                    Combo = cbo
                    cbo = DirectCast(Combo, ComboBox)
            End Select


            cbo.Items.Clear()
            If Add_New = True Then
                Add_New_Setup()
            End If
            If Blank_Selection = True Then
                Add_Blank()
            End If
            Select Case cbo.Name
                Case Is = "cboManager", "cboSM", "cboMM", "cboFM", "cboIM", "cboAM"
                    Get_Department()
                    Query()
                Case Else
                    Query()
            End Select
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "cbo_List_Fill", "Class", "Sub", "New", "0", ex.Message.ToString)
            y = Nothing
        End Try



    End Sub
    Function Get_Parent_Form(sender As Object)
        Try
            Dim x As Form
            Dim b As Boolean = False
            Dim ctrl As Object = sender.GetCurrentParent
            Do
                Select Case ctrl.GetType.ToString
                    Case Is = "System.Windows.Forms.ToolStripMenuItem", "System.Windows.Forms.ToolStripSplitButton", "System.Windows.Forms.ToolStripButton", "System.Windows.Forms.ToolStripComboBox"
                        ctrl = ctrl.getcurrentparent
                    Case Is = "System.Windows.Forms.ToolStripDropDown", "System.Windows.Forms.ToolStripDropDownButton", "System.Windows.Forms.ToolStripDropDownMenu"
                        Dim q = ctrl.owneritem
                        ctrl = q.getcurrentparent
                    Case Is = "System.Windows.Forms.ToolStrip"
                        Dim q As ToolStrip = ctrl
                        x = q.FindForm
                        b = True
                End Select
            Loop Until b = True
            Return x
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "cbo_List_Fill", "Class", "Function", "Get_Parent_Form", "0", ex.Message.ToString)
            y = Nothing
        End Try
    End Function
    Private Sub Add_Blank()
        Try
            cbo.Items.Add("")
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "cbo_List_Fill", "Class", "Sub", "Add_Blank", "0", ex.Message.ToString)
            y = Nothing
        End Try
    End Sub
    Private Sub Add_New_Setup()
        Try
            cbo.Items.Add("<Add New>")

            Dim y = Sep_Line(cbo, cbo.Font)
            cbo.Items.Add(y)
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "cbo_List_Fill", "Class", "Sub", "Add_New_Setup", "0", ex.Message.ToString)
            y = Nothing
        End Try
    End Sub
    Private Sub Query()
        Try
            If Dept <> "" Then
                QueryString = "select Distinct (ManFName + ' ' + ManLName), ManLName, department from ManagerMaster where department like '" & Dept & "' order by Department , ManLname asc "

            End If
            Select Case cbo.Name
                Case Is = "cboRep1", "cboRep2"
                    QueryString = "Select Distinct(FName + ' ' + LName ), Lname from SalesRepPull order by Lname "
                Case Is = "cboMarketer"
                    QueryString = "Select Distinct(FName + ' ' + LName ), Lname from MarketerPullList  order by Lname"
                Case Is = "cboProduct1", "cboProduct2", "cboProduct3"
                    QueryString = "Select Distinct (Product ) from Products order by Product Asc"
                Case Is = "cboPriLead", "cboConfirmingPLS", "cboSalesPLS", "cboPLS"
                    QueryString = "Select distinct(PrimaryLead ) from PrimaryLeadSource order by PrimaryLead"
                Case Is = "cboSecLead", "cboConfirmingSLS", "cboSalesSLS", "cboSLS"
                    Dim PLS As String
                    Select Case frm.Name
                        Case Is = "Confirming"
                            If cbo.Name = "cboConfirming" Then
                                PLS = Confirming.cboConfirmingPLS.Text
                            Else
                                PLS = Confirming.cboSalesPLS.Text
                            End If
                        Case Is = "WCaller"
                            PLS = WCaller.cboPLSWarmCalling.Text
                        Case Is = "Recovery"
                            'PLS = Recovery.cboPLS.Text 'uncomment when form done revisit
                        Case Is = "PreviousCustomer"
                            'PLS = PreviousCustomer.cboPLS.Text    ' uncomment when form done revisit
                        Case Is = "EnterLead"
                            PLS = EnterLead.cboPriLead.Text
                        Case Is = "MarketerLeadSources"
                            PLS = MarketerLeadSources.cboPRILS.Text
                        Case Is = "SetApptTelemarketing"
                            PLS = SetApptTelemarketing.cboPriLead.Text

                    End Select
                    QueryString = "select Distinct (SecondaryLead ) from SecondaryLeadSource Where PrimaryLead = '" & PLS & "' order by SecondaryLead asc "
            End Select   ''AddCases for all combos 
            SQL_List()
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "cbo_List_Fill", "Class", "Sub", "Query", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub SQL_List()
        Try
            Try
                Dim cnx As SqlConnection = New SqlConnection(STATIC_VARIABLES.Cnn)
                Dim cmdGet As SqlCommand = New SqlCommand(Me.QueryString, cnx)
                cnx.Open()
                Dim r As SqlDataReader
                r = cmdGet.ExecuteReader
                While r.Read
                    cbo.Items.Add(r.Item(0))
                End While
                r.Close()
                cnx.Close()
            Catch ex As Exception

                Main.Cursor = Cursors.Default
            End Try
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "cbo_List_Fill", "Class", "Sub", "SQL_List", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub
    Private Sub Get_Department()
        Try
            Select Case cbo.Name
                Case Is = "cboManager"
                    Me.Dept = "%"
                Case Is = "cboMM"
                    Me.Dept = "Marketing"
                Case Is = "cboSM"
                    Me.Dept = "Sales"
                Case Is = "cboFM"
                    Dept = "Financing"
                Case Is = "cboIM"
                    Dept = "Installation"
                Case Is = "cboAM"
                    Dept = "Administation"
            End Select
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "cbo_List_Fill", "Class", "Sub", "Get_Department", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub



    Dim strsize As New SizeF()
    Dim Width As Integer
    Dim fnt As Font
    Dim sepline As String = "_"
    Public Function Sep_Line(combo As Object, fnt As Font)
        Try
            strsize = Me.MeasureString(sepline, combo.Font)
            Width = combo.Width
            Do Until Me.strsize.Width >= Me.Width
                sepline = sepline & "_"
                strsize = Me.MeasureString(sepline, combo.Font)
            Loop

            Return Me.sepline
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "cbo_List_Fill", "Class", "Function", "Sep_Line", "0", ex.Message.ToString)
            y = Nothing
        End Try
    End Function
    Private Function MeasureString(ByVal text As String, ByVal font As Font) As SizeF

        Try
            Dim size As SizeF

            size = TextRenderer.MeasureText(text, font)

            Return size
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "cbo_List_Fill", "Class", "Function", "Measure_String", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Function
End Class
