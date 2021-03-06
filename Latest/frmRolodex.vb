Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data
Imports System

Imports System.Net.Mail

Public Class frmRolodex
    Public SelItem As ListViewItem
    Private cnn As SqlConnection = New SqlConnection(STATIC_VARIABLES.Cnn)

    ' public Emp_OBJ As Rolodex_Logic_V2.EmployeeOBJ

    Private Sub PopululateCarrierList()
        '' list of common sms free gateways per carrier
        '' 
        'Me.cboCarrier.Items.Clear()
        'Me.cboCarrier.Items.Add("@text.wireless.alltel.com") '' AllTel
        'Me.cboCarrier.Items.Add("@txt.att.net") '' AT & T
        'Me.cboCarrier.Items.Add("@myboostmobile.com") '' Boost Mobile
        'Me.cboCarrier.Items.Add("@sms.mycricket.com") '' Cricket
        'Me.cboCarrier.Items.Add("@messaging.sprintpcs.com") '' sprint
        'Me.cboCarrier.Items.Add("@tmomail.net") '' T-Mobile
        'Me.cboCarrier.Items.Add("@email.uscc.net") '' US Cellular
        'Me.cboCarrier.Items.Add("@vtext.com") '' Verizon
        'Me.cboCarrier.Items.Add("@vmobl.com") '' Virgin Mobile
    End Sub
    Private Sub Populate_Phone_And_Carrier(ByVal EmployeeOBJ As Rolodex_Logic_V2.EmployeeOBJ)
     
    End Sub
    Private Sub ResetForm()
        'Me.cboCarrier.Text = ""
        'Me.cboPhoneNumbers.Items.Clear()
        'Me.cboCarrier.Items.Clear()
        'Me.txtSubject.Text = ""
        'Me.rtfSMS.Text = ""
        'Me.txtLocation.Text = ""
        'Me.txtLeadNumberLookup.Text = ""
    End Sub
    Private Sub frmRolodex_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''Me.cboDepartment.Items.Clear()
        Me.cboDepartment.SelectedIndex = 0

        ''PopulateDefaultList(Me.cboDepartment.SelectedItem.ToString)

       


    End Sub
    
    Private Sub frmRolodex_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim g As Graphics = e.Graphics
        g.DrawLine(Pens.SlateGray, 10, 10, 550, 10)
        g.DrawLine(Pens.White, 11, 11, 550, 11)
        g.DrawLine(Pens.White, 11, 41, 550, 41)
        g.DrawLine(Pens.SlateGray, 10, 40, 550, 40)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.ListView1.Items.Clear()
        Me.Close()
    End Sub
    Public Sub PopulateDefaultList(ByVal Department As String)
        Try
            Dim cmdGET As SqlCommand = New SqlCommand("SELECT ID,EmpFirstName,EmpLastName,Department,PrimaryPhone FROM .tblCompanyRolodex2 where Department like @DEP order by LName asc", cnn)
            Dim param1 As SqlParameter = New SqlParameter("@DEP", Department)
            cmdGET.Parameters.Add(param1)
            cnn.Open()
            Dim r1 As SqlDataReader
            r1 = cmdGET.ExecuteReader
            While r1.Read
                Dim lv As New ListViewItem()
                lv.Text = r1.Item("ID")
                lv.SubItems.Add(r1.Item("EmpLastName"))
                lv.SubItems.Add(r1.Item("EmpFirstName"))
                'Me.ListView1.Groups.Add(r1.Item("Department"))
                lv.Group = Me.ListView1.Groups(r1.Item("Department"))
                'lv.SubItems.Add(r1.Item("Department"))
                Dim ph As String = r1.Item("PrimaryPhone")
                ph = Mid(ph, 1, 3)
                ph = "(" & ph & ") "
                Dim firstSet As String = Mid(r1.Item("PrimaryPhone"), 4, 3)
                firstSet = firstSet & "-"
                Dim secondset As String = Mid(r1.Item("PrimaryPhone"), 7, 4)
                Dim correctedLiteral As String = ph & firstSet & secondset
                lv.SubItems.Add(correctedLiteral)
                Me.ListView1.Items.Add(lv)
            End While
            r1.Close()
            cnn.Close()
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmRolodex", "FormCode", "sub", "PopulateDefaultList(department)", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub cboDepartment_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDepartment.SelectedValueChanged
        Dim str As String = Me.cboDepartment.Text
        If str = "All" Then
            str = "%"
        End If
        If str.ToString.Length <= 0 Then
            Exit Sub
        ElseIf str.ToString.Length >= 1 Then
            Me.ListView1.Items.Clear()
            PopulateDefaultList(str)
        End If

    End Sub

    Private Sub ListView1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListView1.MouseClick
        SelItem = Me.ListView1.GetItemAt(e.X, e.Y)
        If SelItem Is Nothing Then
            Exit Sub
        End If
        'MsgBox(SelItem.Text)
        '' selitem.text = Record ID of target ITEM
        '' 

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If SelItem Is Nothing Then
            MsgBox("You must select an employee to edit.")
            Exit Sub
        End If
        EditRolodex.Target_ID = SelItem.Text
        EditRolodex.Text = " Edit Employee"
        EditRolodex.txtFirstName.Text = ""
        EditRolodex.txtLastName.Text = ""
        EditRolodex.cboDepartment.Text = ""
        EditRolodex.txtPhoneNumber.Text = ""
        EditRolodex.btnAction.Text = "Edit"
        EditRolodex.ShowDialog()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Dim result As Integer = 0
            result = MsgBox("Are you sure you wish to delete this employee?", MsgBoxStyle.YesNo, "Delete Employee")
            Select Case result
                Case Is = 6
                    Dim cmdDEL As SqlCommand = New SqlCommand("DELETE .tblCompanyRolodex2 where ID = @ID", cnn)
                    Dim param1 As SqlParameter = New SqlParameter("@ID", SelItem.Text)
                    cmdDEL.Parameters.Add(param1)
                    cnn.Open()
                    cmdDEL.ExecuteNonQuery()
                    cnn.Close()
                    Me.ListView1.Items.Clear()
                    PopulateDefaultList(Me.cboDepartment.Text)
                    SelItem = Nothing
                    Exit Select
                Case Is = 7
                    SelItem = Nothing
                    Exit Select
            End Select
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmRolodex", "FormCode", "sub", "Button3_Click", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        EditRolodex.Text = " Add Employee"
        Dim str As String = Me.cboDepartment.Text
        EditRolodex.txtFirstName.Text = ""
        EditRolodex.txtLastName.Text = ""
        EditRolodex.txtPhoneNumber.Text = ""
        EditRolodex.cboDepartment.SelectedItem = str
        EditRolodex.Target_ID = "0"
        EditRolodex.btnAction.Text = "Add"
        EditRolodex.ShowDialog()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim Area_Code As String = ""
        Dim Number As String = ""

        Try

            Dim lv_c As ListView.SelectedListViewItemCollection = Me.ListView1.SelectedItems
            If lv_c.Count <= 0 Then
                MsgBox("You must select an individual to dial.", MsgBoxStyle.Exclamation, "Error Placing Call")
                Exit Sub
            End If
            Dim lv1 As ListViewItem = lv_c(0)

            Dim c As ListViewItem.ListViewSubItem
            'For Each c In lv1.SubItems
            'MsgBox(lv1.SubItems.IndexOf(c).ToString & " " & c.Text)
            'Next

            Dim str As String = lv1.SubItems(4).Text
            str = Replace(str, "(", "")
            str = Replace(str, ")", "")
            str = Replace(str, "-", "")
            str = Trim(str)
            Dim str2
            str2 = Split(str, " ", -1)


            Area_Code = Trim(str2(0).ToString)
            Number = Trim(str2(1).ToString)
            'MsgBox(area_code & number)

            'Dim dn As New DialTelephoneNumber(area_code & number)

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default
            MsgBox("Error Placing Call: " & Area_Code & Number & "." & vbCrLf & ex.Message.ToString, MsgBoxStyle.Critical, "Error Placing Call")
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmRolodex", "FormCode", "Sub", "Button4_Click", "0", ex.Message.ToString)
            y = Nothing
        End Try


    End Sub
End Class
