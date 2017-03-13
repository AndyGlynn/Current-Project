Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data


Public Class Rolodex_Logic_V2
    Private dev_cnx As String = STATIC_VARIABLES.Cnn
    Private DoesDuplicateExist As Boolean

    Public Structure EmployeeOBJ
        Public ID As String
        Public FirstName As String
        Public LastName As String
        Public Department As String
        Public Phone1 As String
        Public Phone1Type As String
        Public Phone2 As String
        Public Phone2Type As String
        Public Phone3 As String
        Public Phone3Type As String
        Public PhoneExt As String
        Public ContactEmail1 As String
        Public ContactEmailCompany As String
        Public PhoneCarrier As String

    End Structure

    Private arDepartments As ArrayList
    Private listOfEmployess As List(Of EmployeeOBJ)

    Public Function GetDepartments()
        Try
            arDepartments = New ArrayList
            Dim cnx As New SqlConnection(dev_cnx)
            cnx.Open()
            Dim cmdGET As New SqlCommand("SELECT DISTINCT(Department) FROM CompanyRolodex;", cnx)
            Dim r1 As SqlDataReader = cmdGET.ExecuteReader
            While r1.Read
                arDepartments.Add(r1.Item("Department"))
            End While
            r1.Close()
            cnx.Close()
            cnx = Nothing
            Return arDepartments
        Catch ex As Exception
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "Rolodex_Logic_V2", "Rolodex_Logic_V2", "Function", "GetDepartments()", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Function

    Public Function Get_All_Employees()
        Try
            listOfEmployess = New List(Of EmployeeOBJ)
            Dim cnx As New SqlConnection(dev_cnx)
            cnx.Open()
            Dim cmdGET As New SqlCommand("SELECT * FROM tblCompanyRolodex2;", cnx)
            Dim r1 As SqlDataReader = cmdGET.ExecuteReader
            While r1.Read
                Dim a As New EmployeeOBJ
                a.ID = r1.Item("ID")
                a.FirstName = r1.Item("FName")
                a.LastName = r1.Item("LName")
                a.Department = r1.Item("Department")
                a.Phone1 = r1.Item("Phone1")
                a.Phone1Type = r1.Item("Phone1Type")
                a.Phone2 = r1.Item("Phone2")
                a.Phone2Type = r1.Item("Phone2Type")
                a.Phone3 = r1.Item("Phone3")
                a.Phone3Type = r1.Item("Phone3Type")
                a.PhoneExt = r1.Item("PhoneExt")
                a.ContactEmail1 = r1.Item("ContactEmail1")
                a.ContactEmailCompany = r1.Item("ContactEmailCompany")
                a.PhoneCarrier = r1.Item("PhoneCarrier")
                listOfEmployess.Add(a)
            End While
            r1.Close()
            cnx.Close()
            cnx = Nothing
            Return listOfEmployess
        Catch ex As Exception
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "Rolodex_Logic_V2", "Rolodex_Logic_V2", "Function", "Get_All_Employees", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Function

    Public Function GetEmpObject(ByVal ID As String)
        Try
            Dim a As New EmployeeOBJ
            Dim cnx As New SqlConnection(dev_cnx)
            cnx.Open()
            Dim cmdGET As New SqlCommand("SELECT * FROM tblCompanyRolodex2 WHERE ID ='" & ID & "';", cnx)
            Dim r1 As SqlDataReader = cmdGET.ExecuteReader
            While r1.Read
                a.ID = r1.Item("ID")
                a.FirstName = r1.Item("FName")
                a.LastName = r1.Item("LName")
                a.Department = r1.Item("Department")
                a.Phone1 = r1.Item("Phone1")
                a.Phone1Type = r1.Item("Phone1Type")
                a.Phone2 = r1.Item("Phone2")
                a.Phone2Type = r1.Item("Phone2Type")
                a.Phone3 = r1.Item("Phone3")
                a.Phone3Type = r1.Item("Phone3Type")
                a.PhoneExt = r1.Item("PhoneExt")
                a.ContactEmail1 = r1.Item("ContactEmail1")
                a.ContactEmailCompany = r1.Item("ContactEmailCompany")
                a.PhoneCarrier = r1.Item("PhoneCarrier")

            End While
            r1.Close()
            cnx.Close()
            cnx = Nothing
            Return a
        Catch ex As Exception
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "Rolodex_Logic_V2", "Rolodex_Logic_V2", "Function", "GetEmpObject", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Function

    Public Function Check_Duplicates(ByVal Employee As EmployeeOBJ)
        Try
            Dim cnx As New SqlConnection(dev_cnx)
            cnx.Open()
            Dim cmdCNT As New SqlCommand("SELECT COUNT(ID) from tblCompanyRolodex2 WHERE FName = '" & Employee.FirstName & "' and LName = '" & Employee.LastName & "';", cnx)
            Dim cnt As Integer = cmdCNT.ExecuteScalar
            cnx.Close()
            cnx = Nothing
            If cnt >= 1 Then
                DoesDuplicateExist = True
            ElseIf cnt <= 0 Then
                DoesDuplicateExist = False
            End If
            Return DoesDuplicateExist
        Catch ex As Exception
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "Rolodex_Logic_V2", "Rolodex_Logic_V2", "Function", "Check_Duplicates(employee)", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Function
    Public Function Check_Duplicates(ByVal EmployeeID As String)
        Try
            Dim cnx As New SqlConnection(dev_cnx)
            cnx.Open()
            Dim cmdCNT As New SqlCommand("SELECT COUNT(ID) from tblCompanyRolodex2 WHERE ID = '" & EmployeeID & "';", cnx)
            Dim cnt As Integer = cmdCNT.ExecuteScalar
            cnx.Close()
            cnx = Nothing
            If cnt >= 1 Then
                DoesDuplicateExist = True
            ElseIf cnt <= 0 Then
                DoesDuplicateExist = False
            End If
            Return DoesDuplicateExist
        Catch ex As Exception
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "Rolodex_Logic_V2", "Rolodex_Logic_V2", "Function", "CheckDuplicates(EmployeeID)", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Function
    Public Function Check_Duplicates(ByVal FirstName As String, ByVal LastName As String)
        Try
            Dim cnx As New SqlConnection(dev_cnx)
            cnx.Open()
            Dim cmdCNT As New SqlCommand("SELECT COUNT(ID) from tblCompanyRolodex2 WHERE FName = '" & FirstName & "' and LName = '" & LastName & "';", cnx)
            Dim cnt As Integer = cmdCNT.ExecuteScalar
            cnx.Close()
            cnx = Nothing
            If cnt >= 1 Then
                DoesDuplicateExist = True
            ElseIf cnt <= 0 Then
                DoesDuplicateExist = False
            End If
            Return DoesDuplicateExist
        Catch ex As Exception
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "Rolodex_Logic_V2", "Rolodex_Logic_V2", "Function", "Check_Duplicates(fname,lname)", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Function

    Public Sub Update_Information(ByVal RecID As String, ByVal EmployeeInfo As EmployeeOBJ)
        Try
            Dim cnx As New SqlConnection(dev_cnx)
            cnx.Open()
            Dim cmdUP As New SqlCommand("UPDATE tblCompanyRolodex2 SET FName = '" & EmployeeInfo.FirstName & "',LName='" & EmployeeInfo.LastName & "',Department='" & EmployeeInfo.Department & "',Phone1='" & EmployeeInfo.Phone1 & "',Phone1Type='" & EmployeeInfo.Phone1Type & "',Phone2='" & EmployeeInfo.Phone2 & "',Phone2Type = '" & EmployeeInfo.Phone2Type & "',Phone3 = '" & EmployeeInfo.Phone3 & "',Phone3Type = '" & EmployeeInfo.Phone3Type & "',PhoneExt='" & EmployeeInfo.PhoneExt & "',ContactEmail1='" & EmployeeInfo.ContactEmail1 & "',	ContactEmailCompany='" & EmployeeInfo.ContactEmailCompany & "',PhoneCarrier='" & EmployeeInfo.PhoneCarrier & "' WHERE ID = '" & RecID & "';", cnx)
            cmdUP.ExecuteScalar()
            cnx.Close()
            cnx = Nothing
        Catch ex As Exception
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "Rolodex_Logic_V2", "Rolodex_Logic_V2", "Function", "Update_Information", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Public Sub DeleteEmployee(ByVal Employee_Obj As EmployeeOBJ)
        Try
            Dim response As Integer = MsgBox("Are you sure you want to delete the Rolodex information for: " & Employee_Obj.FirstName & " " & Employee_Obj.LastName & "?", MsgBoxStyle.YesNo, "Delete Record?")
            If response = vbYes Then
                Dim cnx As New SqlConnection(dev_cnx)
                cnx.Open()
                Dim cmdDEL As New SqlCommand("DELETE tblCompanyRolodex2 WHERE ID = '" & Employee_Obj.ID & "';", cnx)
                cmdDEL.ExecuteScalar()
                cnx.Close()
                cnx = Nothing
                frmExpandedRolodex.ReFreshForm()
            ElseIf response = vbNo Then
                frmExpandedRolodex.ReFreshForm()
                Exit Sub
            End If
        Catch ex As Exception
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "Rolodex_Logic_V2", "Rolodex_Logic_V2", "Function", "DeleteEmployee", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Public Sub AddEmployee(ByVal Emp_Obj As EmployeeOBJ)
        '' --------FRONT END----------
        '' 1) Validate Inputs
        ''    a)valid - next step
        ''    b)invalid - trigger ep / loop til valid 
        '' --------CLASS LOGIC--------
        '' 2) check duplicates
        ''     a) yes - warn send to update if wanted.
        ''     b) no - insert new employee -> refresh control to reflect new stuffs.
        ''      
        Try
            Dim cnt As Integer = 0
            Dim cnx As New SqlConnection(dev_cnx)
            cnx.Open()
            Dim cmdCNT As New SqlCommand("SELECT COUNT(ID) FROM tblCompanyRolodex2 Where FName = '" & Emp_Obj.FirstName & "' and LName = '" & Emp_Obj.LastName & "';", cnx)
            cnt = cmdCNT.ExecuteScalar
            cnx.Close()
            If cnt >= 1 Then
                '' found one
                Dim response As Integer = MsgBox("The Employee: '" & Emp_Obj.FirstName & " " & Emp_Obj.LastName & "' already Exists." & vbCrLf & "Would you like update this employees info?", MsgBoxStyle.YesNo, "Employee Exists Already")
                If response = vbYes Then
                    RolodexEdit.emp_obj = Emp_Obj
                    RolodexEdit.btnAddUp.Text = "Update"
                    Exit Sub
                ElseIf response = vbNo Then
                    RolodexEdit.emp_obj = Nothing
                    RolodexEdit.ResetForm()
                    RolodexEdit.Close()
                    Exit Sub
                End If
            ElseIf cnt <= 0 Then
                '' not found
                '' insert it.
                cnx.Open()
                Dim cmdINS As New SqlCommand("Insert tblCompanyRolodex2(FName,LName,Department,Phone1,Phone1Type,Phone2,Phone2Type,Phone3,Phone3Type," _
                                            & "PhoneExt,ContactEmail1,ContactEmailCompany,PhoneCarrier)" _
                                            & "Values ('" & Emp_Obj.FirstName & "','" & Emp_Obj.LastName & "','" & Emp_Obj.Department & "','" & Emp_Obj.Phone1 & "'," _
                                            & "'" & Emp_Obj.Phone1Type & "','" & Emp_Obj.Phone2 & "','" & Emp_Obj.Phone2Type & "','" & Emp_Obj.Phone3 & "','" & Emp_Obj.Phone3Type & "'," _
                                            & "'" & Emp_Obj.PhoneExt & "','" & Emp_Obj.ContactEmail1 & "','" & Emp_Obj.ContactEmailCompany & "','" & Emp_Obj.PhoneCarrier & "');", cnx)
                cmdINS.ExecuteScalar()
                cnx.Close()
                cnx = Nothing
                frmExpandedRolodex.ReFreshForm()
                RolodexEdit.emp_obj = Nothing
                frmExpandedRolodex.selItem = Nothing
                RolodexEdit.Close()
            End If
        Catch ex As Exception
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "Rolodex_Logic_V2", "Rolodex_Logic_V2", "Sub", "AddEmployee()", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Public Function Get_Employee_By_Department(ByVal Department As String)
        Try
            listOfEmployess = New List(Of EmployeeOBJ)
            Dim cnx As New SqlConnection(dev_cnx)
            cnx.Open()
            Dim cmdGET As New SqlCommand("SELECT * FROM tblCompanyRolodex2 WHERE Department = '" & Department & "';", cnx)
            Dim r1 As SqlDataReader = cmdGET.ExecuteReader
            While r1.Read
                Dim a As New EmployeeOBJ
                a.ID = r1.Item("ID")
                a.FirstName = r1.Item("FName")
                a.LastName = r1.Item("LName")
                a.Department = r1.Item("Department")
                a.Phone1 = r1.Item("Phone1")
                a.Phone1Type = r1.Item("Phone1Type")
                a.Phone2 = r1.Item("Phone2")
                a.Phone2Type = r1.Item("Phone2Type")
                a.Phone3 = r1.Item("Phone3")
                a.Phone3Type = r1.Item("Phone3Type")
                a.PhoneExt = r1.Item("PhoneExt")
                a.ContactEmail1 = r1.Item("ContactEmail1")
                a.ContactEmailCompany = r1.Item("ContactEmailCompany")
                a.PhoneCarrier = r1.Item("PhoneCarrier")
                listOfEmployess.Add(a)
            End While
            r1.Close()
            cnx.Close()
            cnx = Nothing
            Return listOfEmployess
        Catch ex As Exception
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "Rolodex_Logic_V2", "Rolodex_Logic_V2", "Function", "Get_Employee_By_Department", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Function

    Public Function GenerateEmp_Obj_List(ByVal EmployeeList As Dictionary(Of String, String))
        Try
            Dim arEmps As New List(Of EmployeeOBJ)
            Dim x
            For Each x In EmployeeList
                Dim Emp_Obj As New EmployeeOBJ
                arEmps.Add(GetEmpObject(x.Key))
            Next
            Return arEmps
        Catch ex As Exception
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "Rolodex_Logic_V2", "Rolodex_Logic_V2", "Function", "Generate_obj_List()", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Function

    Public Function GenerateEmp_Obj_List(ByVal EmployeeList As ArrayList)
        Try
            Dim arEmps As New List(Of EmployeeOBJ)
            For Each x As String In EmployeeList
                Dim Emp_Obj As New EmployeeOBJ
                arEmps.Add(GetEmpObject(x))
            Next
            Return arEmps
        Catch ex As Exception
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "Rolodex_Logic_V2", "Rolodex_Logic_V2", "Function", "GenerateEmp_obj_list()", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Function

    Public Function Lookup_Lead_Number_For_Text_Location(ByVal LeadNumber As String)
        Try
            Dim str As String = ""
            Dim cnx As New SqlConnection(dev_cnx)
            cnx.Open()
            '' reference: https://www.google.com/maps/places/staddy+city+state+zip/ 

            Dim cmdGET As New SqlCommand("SELECT StAddress,City,State,Zip FROM EnterLead where ID = '" & LeadNumber & "';", cnx)
            Dim r1 As SqlDataReader = cmdGET.ExecuteReader
            Dim str2 = "maps.google.com/?q="
            While r1.Read
                str += "http://" & str2 & r1.Item("StAddress") & ",+" & r1.Item("City") & ",+" & r1.Item("State") & "+" & r1.Item("Zip") & "/"
            End While
            str = str.Replace(" ", "+")
            r1.Close()
            cnx.Close()
            Return str
        Catch ex As Exception
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "Rolodex_Logic_V2", "Rolodex_Logic_V2", "Function", "Lookup_Lead_Number_for_text_Location()", LeadNumber, ex.Message.ToString)
            y = Nothing
        End Try

    End Function

End Class

