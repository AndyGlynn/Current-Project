Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System

Public Class TScbo_List_Fill
    Dim frm As Form
    Dim cbo As ToolStripComboBox
    Dim Dept As String
    Dim QueryString As String = ""


    Public Sub New(Combo As ToolStripComboBox, Add_New As Boolean, Blank_Selection As Boolean)

        cbo = Combo
        Dim p As Control = cbo.GetCurrentParent
        frm = p.FindForm

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


    End Sub
    Private Sub Add_Blank()
        cbo.Items.Add("")
    End Sub
    Private Sub Add_New_Setup()
        cbo.Items.Add("<Add New>")

        Dim y = Sep_Line(cbo, cbo.Font)
        cbo.Items.Add(y)
    End Sub
    Private Sub Query()
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

    End Sub

    Private Sub SQL_List()
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

    End Sub
    Private Sub Get_Department()
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

    End Sub




    Dim strsize As New SizeF()
    Dim Width As Integer
    Dim fnt As Font
    Dim sepline As String = "_"
    Public Function Sep_Line(combo As ToolStripComboBox, fnt As Font)
        strsize = Me.MeasureString(sepline, combo.Font)
        Width = combo.Width
        Do Until Me.strsize.Width >= Me.Width
            sepline = sepline & "_"
            strsize = Me.MeasureString(sepline, combo.Font)
        Loop

        Return Me.sepline
    End Function
    Private Function MeasureString(ByVal text As String, ByVal font As Font) As SizeF

        Dim size As SizeF

        size = TextRenderer.MeasureText(text, font)

        Return size

    End Function
End Class
