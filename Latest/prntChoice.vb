Public Class prntChoice
    Public arRecords As Dictionary(Of String, String)
    Public arDepartments As ArrayList
    Private selDepartment As String = ""
    Private Sub prntChoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        resetform()

    End Sub

    Private Sub resetform()
        Me.rdoAllDeparts.Checked = False
        Me.rdoSingleDepart.Checked = False

        Me.rdoPlainText.Checked = False
        Me.lblSelDepart.Visible = False
        Me.cboDepartments.Visible = False
        Me.cboDepartments.Items.Clear()
        selDepartment = ""
        For Each b As String In Me.arDepartments
            If b <> "All" Then
                Me.cboDepartments.Items.Add(b)
            End If
        Next
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.resetform()
        Me.Close()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        Dim strOptions As String = ""

        'If Me.rdoHTML.Checked = False And Me.rdoPlainText.Checked = False Then
        '    MsgBox("You haven't selected any print options to print.", MsgBoxStyle.Critical, "PRINT ERROR")
        '    Exit Sub
        'End If
        If Me.rdoAllDeparts.Checked = False And Me.rdoSingleDepart.Checked = False Then
            MsgBox("You haven't selected any print formats to print.", MsgBoxStyle.Critical, "PRINT ERROR")
            Exit Sub
        End If

        If Me.rdoAllDeparts.Checked = False Then
            If Me.rdoSingleDepart.Checked = False Then
                'If Me.rdoHTML.Checked = False Then
                If Me.rdoPlainText.Checked = False Then
                    MsgBox("You have not select ANY print options. Please go back and make a valid selection.", MsgBoxStyle.Critical, "ERROR PRINTING")
                    Exit Sub
                End If
                'End If
            End If
        End If


        'If Me.rdoHTML.Checked = True Then
        '    strOptions += "HTML"
        'End If
        If Me.rdoPlainText.Checked = True Then
            strOptions += "PLAIN"
        End If
        If Me.rdoSingleDepart.Checked = True Then
            Me.lblSelDepart.Visible = True
            Me.cboDepartments.Visible = True
            Me.cboDepartments.Focus()
            strOptions += " | SINGLE | " & selDepartment
        End If
        If Me.rdoAllDeparts.Checked = True Then
            strOptions += " | ALL | ALL"
        End If

        Dim filteredList As New Dictionary(Of String, String)
        Dim a
        For Each a In arRecords
            If a.Value = selDepartment Then
                filteredList.Add(a.Key, a.Value)
            End If
        Next

        If Me.cboDepartments.Visible = True Then
            If Len(selDepartment) <= 0 Then
                MsgBox("Please select a department for single department printing.", MsgBoxStyle.Critical, "ERROR PRINTING")
                Exit Sub
            End If
        End If

        Dim strList As String = ""
        Dim de
        For Each de In filteredList
            strList += vbCrLf & de.Key & ":=" & de.Value
        Next

        'MsgBox("Print Options Selected for record(s): " & vbCrLf & strOptions.ToString & vbCrLf & "List: " & vbCr & strList, MsgBoxStyle.Information, "DEBUG Print Options")

        If Me.cboDepartments.Visible = True Then
            Dim z As New Rolodex_Logic_V2
            Dim listToPrint As New List(Of Rolodex_Logic_V2.EmployeeOBJ)
            listToPrint = z.GenerateEmp_Obj_List(filteredList)
            '' now render based on user selection
            '' 
            Dim opt() = Split(strOptions, "|")
            Select Case Trim(opt(0).ToString)
                Case Is = "PLAIN"
                    'MsgBox("Fitered List: Plain text print.", MsgBoxStyle.Information, "DEBUG PRINT")
                    Dim y As New printClassRolodex(listToPrint)
                    Exit Select
                    'Case Is = "HTML"
                    '    '  MsgBox("Fitered List: html print.", MsgBoxStyle.Information, "DEBUG PRINT")
                    '    Exit Select
            End Select

        ElseIf Me.cboDepartments.Visible = False Then
            Dim z As New Rolodex_Logic_V2
            Dim listToPrint As New List(Of Rolodex_Logic_V2.EmployeeOBJ)
            listToPrint = z.GenerateEmp_Obj_List(arRecords)
            '' now render based on user selection
            '' 
            Dim opt() = Split(strOptions, "|")
            Select Case Trim(opt(0).ToString)
                Case Is = "PLAIN"
                    'MsgBox("UN-Fitered List: Plain text print.", MsgBoxStyle.Information, "DEBUG PRINT")
                    Dim y As New printClassRolodex(listToPrint)
                    Exit Select
                    'Case Is = "HTML"
                    '    ' MsgBox("UN-Fitered List: HTML print.", MsgBoxStyle.Information, "DEBUG PRINT")
                    '    Exit Select
            End Select
        End If

    End Sub

    Private Sub rdoSingleDepart_CheckedChanged(sender As Object, e As EventArgs) Handles rdoSingleDepart.CheckedChanged
        Dim rdo As RadioButton = sender
        If rdo.Checked = True Then
            Me.cboDepartments.Visible = True
            Me.lblSelDepart.Visible = True
        ElseIf rdo.Checked = False Then
            Me.cboDepartments.Visible = False
            Me.lblSelDepart.Visible = False
        End If
    End Sub

    Private Sub cboDepartments_TextChanged(sender As Object, e As EventArgs) Handles cboDepartments.TextChanged
        If Me.cboDepartments.Visible = True Then
            Me.selDepartment = Me.cboDepartments.Text
        ElseIf Me.cboDepartments.Visible = False Then
            Me.selDepartment = ""
        End If
    End Sub
End Class