Imports System.Text.RegularExpressions

Public Class RolodexEdit
    Public emp_obj As Rolodex_Logic_V2.EmployeeOBJ

    Private Sub RolodexEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim v As New Rolodex_Logic_V2
        Dim arDeparts As New ArrayList
        arDeparts = v.GetDepartments
        For Each b As String In arDeparts
            Me.cboDepart.Items.Add(b)
        Next
        Me.cboDepart.SelectedText = emp_obj.Department
        Me.txtFName.Text = emp_obj.FirstName
        Me.txtLName.Text = emp_obj.LastName
        Me.txtPrimaryPhone.Text = emp_obj.Phone1
        Me.txtPhone2.Text = emp_obj.Phone2
        Me.cbo1Type.Text = emp_obj.Phone1Type
        Me.cbo2Type.Text = emp_obj.Phone2Type
        Me.cbo3Type.Text = emp_obj.Phone3Type
        Me.txtPhone3.Text = emp_obj.Phone3
        Me.txtCarrier.Text = emp_obj.PhoneCarrier
        Me.txtPersonalEmail.Text = emp_obj.ContactEmail1
        Me.txtCompanyEmail.Text = emp_obj.ContactEmailCompany
        Me.txtPhoneExt.Text = emp_obj.PhoneExt
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ResetForm()
        Me.Close()
    End Sub

    Public Sub ResetForm()
        Me.cboDepart.SelectedText = ""
        Me.cboDepart.Text = ""
        Me.cboDepart.Items.Clear()
        Me.txtFName.Text = ""
        Me.txtLName.Text = ""
        Me.txtPrimaryPhone.Text = ""
        Me.txtCarrier.Text = ""
        Me.txtPhone2.Text = ""
        Me.cbo1Type.Text = ""
        Me.cbo2Type.Text = ""
        Me.cbo3Type.Text = ""
        Me.txtPhone3.Text = ""
        Me.txtPersonalEmail.Text = ""
        Me.txtCompanyEmail.Text = ""
        Me.txtPhoneExt.Text = ""
        Me.ErrorProvider1.Clear()
        frmExpandedRolodex.selItem = Nothing
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAddUp.Click
        Dim z As New Rolodex_Logic_V2
        If Me.btnAddUp.Text = "Update" Then
            Dim isStringValid As Boolean = ValidateInput(emp_obj)
            If isStringValid = True Then
                z.Update_Information(emp_obj.ID, emp_obj)
                ResetForm()
                frmExpandedRolodex.ReFreshForm()
                Me.Close()
            ElseIf isStringValid = False Then
                Exit Sub
            End If
        ElseIf Me.btnAddUp.Text = "Add" Then
            Dim empOBJ As New Rolodex_Logic_V2.EmployeeOBJ
            empOBJ.FirstName = Me.txtFName.Text
            empOBJ.LastName = Me.txtLName.Text
            empOBJ.Department = Me.cboDepart.Text
            empOBJ.Phone1 = Me.txtPrimaryPhone.Text
            empOBJ.Phone1Type = Me.cbo1Type.Text
            empOBJ.Phone2 = Me.txtPhone2.Text
            empOBJ.Phone2Type = Me.cbo2Type.Text
            empOBJ.Phone3 = Me.txtPhone3.Text
            empOBJ.Phone3Type = Me.cbo3Type.Text
            empOBJ.PhoneExt = Me.txtPhoneExt.Text
            empOBJ.ContactEmail1 = Me.txtPersonalEmail.Text
            empOBJ.ContactEmailCompany = Me.txtCompanyEmail.Text
            empOBJ.PhoneCarrier = Me.txtCarrier.Text
            If Me.ValidateInput(empOBJ) = True Then
                '' onto check dupes
                z.AddEmployee(empOBJ)
            ElseIf Me.ValidateInput(empOBJ) = False Then
                Exit Sub
            End If
        End If
    End Sub

    Private Function ValidateInput(ByVal EmployeeObj As Rolodex_Logic_V2.EmployeeOBJ)
        Dim valid As Boolean = False
        '' 
        '' zero length strings on certain fields
        '' invalid characters 
        '' email must contain certain characters
        '' email2 must contain certain characters.
        '' 
        '' mandatory fields: 
        '' fname,lname,primaryphone,department,primary phone type
        '' 
        Dim searchPattern As String = "[^a-zA-Z]"
        Dim searchPatternPH As String = "^(\+\d{1,2}\s)?\(?\d{3}\)?[\s.-]\d{3}[\s.-]\d{4}$"


        If EmployeeObj.FirstName.Length <= 0 Then
            valid = False
        ElseIf EmployeeObj.FirstName.Length >= 1 Then
            Dim rgx As New Regex(searchPattern)
            If rgx.IsMatch(EmployeeObj.FirstName) = True Then
                valid = False
                'MsgBox("You have illegal characters in your [First Name] field.", MsgBoxStyle.Critical, "ERROR IN STRING")
                Me.ErrorProvider1.SetError(Me.txtFName, "You have illegal characters in your First Name.")
                Return valid
                Exit Function
            End If
        End If

        If EmployeeObj.LastName.Length <= 0 Then
            valid = False
        ElseIf EmployeeObj.LastName.Length >= 1 Then
            Dim rgx As New Regex(searchPattern)
            If rgx.IsMatch(EmployeeObj.LastName) = True Then
                valid = False
                ' MsgBox("You have illegal characters in your [Last Name] field.", MsgBoxStyle.Critical, "ERROR IN STRING")
                Me.ErrorProvider1.SetError(Me.txtLName, "You have illegal characters in your Last Name.")
                Return valid
                Exit Function
            End If
        End If


        If EmployeeObj.Phone1.Length <= 0 Then
            valid = False
        ElseIf EmployeeObj.Phone1.Length >= 1 Then
            Dim rgx As New Regex(searchPatternPH)
            If rgx.IsMatch(EmployeeObj.Phone1) = False Then
                valid = False
                'MsgBox("Please check formatting of [Primary Phone] field." & vbCrLf & "Example: (111) 123-1234", MsgBoxStyle.Critical, "ERROR IN STRING")
                Me.ErrorProvider1.SetError(Me.txtPrimaryPhone, "Your phone format is not correct or has illegal characters in it. Ex: (419) 123-3456")
                Return valid
                Exit Function
            End If
        End If
        If EmployeeObj.Phone2.Length >= 1 Then
            Dim rgx As New Regex(searchPatternPH)
            If rgx.IsMatch(EmployeeObj.Phone2) = False Then
                valid = False
                'MsgBox("Please check formatting of [ Phone2 ] field." & vbCrLf & "Example: (111) 123-1234", MsgBoxStyle.Critical, "ERROR IN STRING")
                Me.ErrorProvider1.SetError(Me.txtPhone2, "Your phone format is not correct or has illegal characters in it. Ex: (419) 123-3456")
                Return valid
                Exit Function
            End If
        End If
        If EmployeeObj.Phone3.Length >= 1 Then
            Dim rgx As New Regex(searchPatternPH)
            If rgx.IsMatch(EmployeeObj.Phone3) = False Then
                valid = False
                'MsgBox("Please check formatting of [ Phone3 ] field." & vbCrLf & "Example: (111) 123-1234", MsgBoxStyle.Critical, "ERROR IN STRING")
                Me.ErrorProvider1.SetError(Me.txtPhone3, "Your phone format is not correct or has illegal characters in it. Ex: (419) 123-3456")
                Return valid
                Exit Function
            End If
        End If

        If EmployeeObj.Department.Length <= 0 Then
            valid = False
        ElseIf EmployeeObj.Department.Length >= 1 Then
            Dim rgx As New Regex(searchPattern)
            If rgx.IsMatch(EmployeeObj.Department) = True Then
                valid = False
                'MsgBox("You have illegal characters in your [Department] field.", MsgBoxStyle.Critical, "ERROR IN STRING")
                Me.ErrorProvider1.SetError(Me.cboDepart, "You have illegal characters in your Department.")
                Return valid
                Exit Function
            End If
        End If
        If EmployeeObj.Phone1Type.Length <= 0 Then
            valid = False
        ElseIf EmployeeObj.Phone1Type.Length >= 1 Then
            Dim rgx As New Regex(searchPattern)
            If rgx.IsMatch(EmployeeObj.Phone1Type) = True Then
                valid = False
                'MsgBox("You have illegal characters in your [Phone 1 Type] field.", MsgBoxStyle.Critical, "ERROR IN STRING")
                Me.ErrorProvider1.SetError(Me.cbo1Type, "You have illegal characters in your Phone 1 Type.")
                Return valid
                Exit Function
            End If
        End If

        If EmployeeObj.ContactEmail1.Length >= 1 Then
            Dim pos As Integer = 0
            pos = InStr(EmployeeObj.ContactEmail1.ToString, ".com")
            Dim pos2 As Integer = 0
            pos2 = InStr(EmployeeObj.ContactEmail1.ToString, "@")
            If pos >= 1 And pos2 >= 1 Then
                valid = True
            ElseIf pos <= 0 Then
                valid = False
            ElseIf pos2 <= 0 Then
                valid = False
            End If
            If valid = False Then
                'MsgBox("Your email format is incorrect. Please correct it before submitting." & vbCrLf & "Example: someone@microsoft.com .", MsgBoxStyle.Critical, "Email Format Error")
                Me.ErrorProvider1.SetError(Me.txtPersonalEmail, "Your email format is incorrect or you have illegal characters in your email address." & vbCrLf & "Example: someone@microsoft.com ")
                Return valid
                Exit Function
            End If
        End If

        If EmployeeObj.ContactEmailCompany.Length >= 1 Then
            Dim pos As Integer = 0
            Dim pos2 As Integer = 0
            pos = InStr(EmployeeObj.ContactEmailCompany.ToString, ".com")
            pos2 = InStr(EmployeeObj.ContactEmailCompany.ToString, "@")
            If pos >= 1 And pos2 >= 1 Then
                valid = True
            ElseIf pos <= 0 Then
                valid = False
            ElseIf pos2 <= 0 Then
                valid = False
            End If
            If valid = False Then
                'MsgBox("Your email format is incorrect. Please correct it before submitting." & vbCrLf & "Example: someone@microsoft.com .", MsgBoxStyle.Critical, "Email Format Error")
                Me.ErrorProvider1.SetError(Me.txtCompanyEmail, "Your email format is incorrect or you have illegal characters in your email address." & vbCrLf & "Example: someone@microsoft.com ")
                Return valid
                Exit Function
            End If
        End If


        Return valid
    End Function

    Private Sub cboDepart_TextChanged(sender As Object, e As EventArgs) Handles cboDepart.TextChanged
        emp_obj.Department = Me.cboDepart.Text
    End Sub

    Private Sub txtFName_TextChanged(sender As Object, e As EventArgs) Handles txtFName.TextChanged
        emp_obj.FirstName = Me.txtFName.Text
    End Sub

    Private Sub txtLName_TextChanged(sender As Object, e As EventArgs) Handles txtLName.TextChanged
        emp_obj.LastName = Me.txtLName.Text
    End Sub

    Private Sub txtPrimaryPhone_TextChanged(sender As Object, e As EventArgs) Handles txtPrimaryPhone.TextChanged
        emp_obj.Phone1 = Me.txtPrimaryPhone.Text
    End Sub

    Private Sub cbo1Type_TextChanged(sender As Object, e As EventArgs) Handles cbo1Type.TextChanged
        emp_obj.Phone1Type = Me.cbo1Type.Text
    End Sub

    Private Sub txtPhone2_TextChanged(sender As Object, e As EventArgs) Handles txtPhone2.TextChanged
        emp_obj.Phone2 = Me.txtPhone2.Text
    End Sub

    Private Sub cbo2Type_TextChanged(sender As Object, e As EventArgs) Handles cbo2Type.TextChanged
        emp_obj.Phone2Type = Me.cbo2Type.Text
    End Sub

    Private Sub txtPhone3_TextChanged(sender As Object, e As EventArgs) Handles txtPhone3.TextChanged
        emp_obj.Phone3 = Me.txtPhone3.Text
    End Sub

    Private Sub cbo3Type_TextChanged(sender As Object, e As EventArgs) Handles cbo3Type.TextChanged
        emp_obj.Phone3Type = Me.cbo3Type.Text
    End Sub

    Private Sub txtPhoneExt_TextChanged(sender As Object, e As EventArgs) Handles txtPhoneExt.TextChanged
        emp_obj.PhoneExt = Me.txtPhoneExt.Text
    End Sub

    Private Sub txtCarrier_TextChanged(sender As Object, e As EventArgs) Handles txtCarrier.TextChanged
        emp_obj.PhoneCarrier = Me.txtCarrier.Text
    End Sub

    Private Sub txtPersonalEmail_TextChanged(sender As Object, e As EventArgs) Handles txtPersonalEmail.TextChanged
        emp_obj.ContactEmail1 = Me.txtPersonalEmail.Text
    End Sub

    Private Sub txtCompanyEmail_TextChanged(sender As Object, e As EventArgs) Handles txtCompanyEmail.TextChanged
        emp_obj.ContactEmailCompany = Me.txtCompanyEmail.Text
    End Sub
End Class