Public Class frmExpandedRolodex
    Public selItem As ListViewItem
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.ListView1.Items.Clear()

            Dim x As New Rolodex_Logic_V2
            Dim ardeparts As New ArrayList
            ardeparts = x.GetDepartments
            Dim emps As New List(Of Rolodex_Logic_V2.EmployeeOBJ)
            emps = x.Get_All_Employees

            For Each emp As Rolodex_Logic_V2.EmployeeOBJ In emps
                Dim lv As New ListViewItem
                lv.Tag = emp.ID
                lv.SubItems.Add(emp.LastName)
                lv.SubItems.Add(emp.FirstName)
                lv.SubItems.Add(emp.Phone1)
                lv.Group = ListView1.Groups(emp.Department.ToString)
                Me.ListView1.Items.Add(lv)
            Next
            Me.cboDepartment.SelectedIndex = 0
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmExpandedRolodex", "FormCode", "Event", "Form1_Load()", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.ListView1.Items.Clear()
        Me.Close()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            If selItem IsNot Nothing Then
                Dim b As New Rolodex_Logic_V2
                Dim obj As Rolodex_Logic_V2.EmployeeOBJ
                obj = b.GetEmpObject(selItem.Tag)
                RolodexEdit.emp_obj = obj
                RolodexEdit.btnAddUp.Text = "Update"
                RolodexEdit.ShowDialog()
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmExpandedRolodex", "FormCode", "Event", "btnEdit_Click", "0", ex.Message.ToString)
            y = Nothing

        End Try

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        Dim lv As ListView = sender
        For Each item As ListViewItem In lv.Items
            If item.Selected = True Then
                selItem = item
            End If
        Next
    End Sub

    Public Sub ReFreshForm()
        Try
            Me.ListView1.Items.Clear()
            Dim x As New Rolodex_Logic_V2
            Dim ardeparts As New ArrayList
            ardeparts = x.GetDepartments
            Dim emps As New List(Of Rolodex_Logic_V2.EmployeeOBJ)
            emps = x.Get_All_Employees

            For Each emp As Rolodex_Logic_V2.EmployeeOBJ In emps
                Dim lv As New ListViewItem
                lv.Tag = emp.ID
                lv.SubItems.Add(emp.LastName)
                lv.SubItems.Add(emp.FirstName)
                lv.SubItems.Add(emp.Phone1)
                lv.Group = ListView1.Groups(emp.Department.ToString)
                Me.ListView1.Items.Add(lv)
            Next
            Me.cboDepartment.SelectedIndex = 0
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmExpandedRolodex", "FormCode", "Event", "ReFreshForm()", "0", ex.Message.ToString)
            y = Nothing

        End Try

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If selItem IsNot Nothing Then
                Dim recID As String = selItem.Tag
                Dim v As New Rolodex_Logic_V2
                Dim empOBJ As New Rolodex_Logic_V2.EmployeeOBJ
                empOBJ = v.GetEmpObject(recID)
                'MsgBox("ID: " & recID.ToString, MsgBoxStyle.Information, "RECORD ID TARGETED")
                v.DeleteEmployee(empOBJ)
                selItem = Nothing

            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmExpandedRolodex", "FormCode", "Event", "btnDelete_Click", "0", ex.Message.ToString)
            y = Nothing

        End Try

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        RolodexEdit.btnAddUp.Text = "Add"
        RolodexEdit.ShowDialog()

    End Sub

    Private Sub cboDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDepartment.SelectedIndexChanged
        Try
            Dim cbo As ComboBox = sender
            Dim sel_txt As String = cbo.Text
            If sel_txt = "All" Then
                Me.ReFreshForm()
                Exit Sub
            End If
            Dim v As New Rolodex_Logic_V2
            Dim arListEmp As New List(Of Rolodex_Logic_V2.EmployeeOBJ)
            arListEmp = v.Get_Employee_By_Department(sel_txt)
            Me.ListView1.Items.Clear()
            For Each xx As Rolodex_Logic_V2.EmployeeOBJ In arListEmp
                Dim lv As New ListViewItem
                lv.Tag = xx.ID
                lv.SubItems.Add(xx.LastName)
                lv.SubItems.Add(xx.FirstName)
                lv.SubItems.Add(xx.Phone1)
                lv.Group = ListView1.Groups(xx.Department.ToString)
                Me.ListView1.Items.Add(lv)
            Next
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmExpandedRolodex", "FormCode", "Event", "cboDepartment_SelectedIndexChange", "0", ex.Message.ToString)
            y = Nothing

        End Try

    End Sub



    Private Sub btnDial_Click(sender As Object, e As EventArgs) Handles btnDial.Click
        Try
            If selItem IsNot Nothing Then
                Dim recID As String = selItem.Tag
                Dim v As New Rolodex_Logic_V2
                Dim empOBJ As New Rolodex_Logic_V2.EmployeeOBJ
                empOBJ = v.GetEmpObject(recID)
                selItem = Nothing
                frmSMS.Emp_OBJ = empOBJ
                frmSMS.ShowDialog()
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmExpandedRolodex", "FormCode", "Event", "btnDial_click", "0", ex.Message.ToString)
            y = Nothing

        End Try

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Try
            Dim g As ListViewItem
            Dim gg As ListViewGroup
            Dim arRecIDS As New Dictionary(Of String, String)
            Dim arGroups As New ArrayList
            For Each gg In Me.ListView1.Groups
                arGroups.Add(gg.ToString)
            Next
            For Each g In Me.ListView1.Items
                arRecIDS.Add(g.Tag, g.Group.ToString)
            Next
            prntChoice.arRecords = arRecIDS
            prntChoice.arDepartments = arGroups
            prntChoice.ShowDialog()
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmExpandedRolodex", "FormCode", "Event", "btnPrint_Click", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub
End Class
