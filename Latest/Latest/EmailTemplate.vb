Public Class EmailTemplate


    Private Sub btnCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCustomer.Click
        If Me.ActiveControl.Name = "txtsubject" Then
            Me.txtsubject.Text = Me.txtsubject.Text.Insert(Me.txtsubject.SelectionStart, "<<Customer Name(s)>>")
            Me.txtsubject.SelectionStart = Me.txtsubject.Text.Length + 1
            Exit Sub
        End If
        If Me.ActiveControl.Name = "txtEmailBody" Then
            Me.txtEmailBody.Text = Me.txtEmailBody.Text.Insert(Me.txtEmailBody.SelectionStart, "<<Customer Name(s)>>")
            Me.txtEmailBody.SelectionStart = Me.txtEmailBody.Text.Length + 1
            Exit Sub
        End If
        MsgBox("You must have cursor in the subject" & vbCr & "or email body to use this feature!", MsgBoxStyle.Exclamation, "Cannot Insert Tag")
    End Sub

    Private Sub EmailTemplate_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.txtEmailBody.Text = ""
        Me.txtsubject.Text = ""
        Me.txtEmailBody_LostFocus(Nothing, Nothing)
        Me.txtsubject_LostFocus(Nothing, Nothing)

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Me.txtEmailBody.Focus()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Me.txtsubject.Focus()
    End Sub

    Private Sub txtsubject_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsubject.GotFocus
        Me.Label1.Visible = False
    End Sub

    Private Sub txtsubject_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsubject.LostFocus
        If Me.txtsubject.Text = "" Then
            Me.Label1.Visible = True
        End If
    End Sub

    Private Sub txtEmailBody_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEmailBody.GotFocus
        Me.Label2.Visible = False
    End Sub

    Private Sub txtEmailBody_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEmailBody.LostFocus
        If Me.txtEmailBody.Text = "" Then
            Me.Label2.Visible = True
        End If
    End Sub

    Private Sub btnAddress_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddress.Click
        If Me.ActiveControl.Name = "txtsubject" Then
            Me.txtsubject.Text = Me.txtsubject.Text.Insert(Me.txtsubject.SelectionStart, "<<Customer Address>>")
            Me.txtsubject.SelectionStart = Me.txtsubject.Text.Length + 1
            Exit Sub
        End If
        If Me.ActiveControl.Name = "txtEmailBody" Then
            Me.txtEmailBody.Text = Me.txtEmailBody.Text.Insert(Me.txtEmailBody.SelectionStart, "<<Customer Address>>")
            Me.txtEmailBody.SelectionStart = Me.txtEmailBody.Text.Length + 1
            Exit Sub
        End If
        MsgBox("You must have cursor in the subject" & vbCr & "or email body to use this feature!", MsgBoxStyle.Exclamation, "Cannot Insert Tag")
    End Sub

    Private Sub btnAltPhone1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAltPhone1.Click
        If Me.ActiveControl.Name = "txtsubject" Then
            Me.txtsubject.Text = Me.txtsubject.Text.Insert(Me.txtsubject.SelectionStart, "<<Alt. Phone 1>>")
            Me.txtsubject.SelectionStart = Me.txtsubject.Text.Length + 1
            Exit Sub
        End If
        If Me.ActiveControl.Name = "txtEmailBody" Then
            Me.txtEmailBody.Text = Me.txtEmailBody.Text.Insert(Me.txtEmailBody.SelectionStart, "<<Alt. Phone 1>>")
            Me.txtEmailBody.SelectionStart = Me.txtEmailBody.Text.Length + 1
            Exit Sub
        End If
        MsgBox("You must have cursor in the subject" & vbCr & "or email body to use this feature!", MsgBoxStyle.Exclamation, "Cannot Insert Tag")
    End Sub

    Private Sub btnAltPhone2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAltPhone2.Click
        If Me.ActiveControl.Name = "txtsubject" Then
            Me.txtsubject.Text = Me.txtsubject.Text.Insert(Me.txtsubject.SelectionStart, "<<Alt. Phone 2>>")
            Me.txtsubject.SelectionStart = Me.txtsubject.Text.Length + 1
            Exit Sub
        End If
        If Me.ActiveControl.Name = "txtEmailBody" Then
            Me.txtEmailBody.Text = Me.txtEmailBody.Text.Insert(Me.txtEmailBody.SelectionStart, "<<Alt. Phone 2>>")
            Me.txtEmailBody.SelectionStart = Me.txtEmailBody.Text.Length + 1
            Exit Sub
        End If
        MsgBox("You must have cursor in the subject" & vbCr & "or email body to use this feature!", MsgBoxStyle.Exclamation, "Cannot Insert Tag")
    End Sub

    Private Sub btnApptDate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnApptDate.Click
        If Me.ActiveControl.Name = "txtsubject" Then
            Me.txtsubject.Text = Me.txtsubject.Text.Insert(Me.txtsubject.SelectionStart, "<<Appt. Date>>")
            Me.txtsubject.SelectionStart = Me.txtsubject.Text.Length + 1
            Exit Sub
        End If
        If Me.ActiveControl.Name = "txtEmailBody" Then
            Me.txtEmailBody.Text = Me.txtEmailBody.Text.Insert(Me.txtEmailBody.SelectionStart, "<<Appt. Date>>")
            Me.txtEmailBody.SelectionStart = Me.txtEmailBody.Text.Length + 1
            Exit Sub
        End If
        MsgBox("You must have cursor in the subject" & vbCr & "or email body to use this feature!", MsgBoxStyle.Exclamation, "Cannot Insert Tag")
    End Sub

    Private Sub btnApptDateTime_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        If Me.ActiveControl.Name = "txtsubject" Then
            Me.txtsubject.Text = Me.txtsubject.Text.Insert(Me.txtsubject.SelectionStart, "<<Appt. Date at Appt. Time>>")
            Me.txtsubject.SelectionStart = Me.txtsubject.Text.Length + 1
            Exit Sub
        End If
        If Me.ActiveControl.Name = "txtEmailBody" Then
            Me.txtEmailBody.Text = Me.txtEmailBody.Text.Insert(Me.txtEmailBody.SelectionStart, "<<Appt. Date at Appt. Time>>")
            Me.txtEmailBody.SelectionStart = Me.txtEmailBody.Text.Length + 1
            Exit Sub
        End If
        MsgBox("You must have cursor in the subject" & vbCr & "or email body to use this feature!", MsgBoxStyle.Exclamation, "Cannot Insert Tag")
    End Sub

    Private Sub btnApptTime_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnApptTime.Click
        If Me.ActiveControl.Name = "txtsubject" Then
            Me.txtsubject.Text = Me.txtsubject.Text.Insert(Me.txtsubject.SelectionStart, "<<Appt. Time>>")
            Me.txtsubject.SelectionStart = Me.txtsubject.Text.Length + 1
            Exit Sub
        End If
        If Me.ActiveControl.Name = "txtEmailBody" Then
            Me.txtEmailBody.Text = Me.txtEmailBody.Text.Insert(Me.txtEmailBody.SelectionStart, "<<Appt. Time>>")
            Me.txtEmailBody.SelectionStart = Me.txtEmailBody.Text.Length + 1
            Exit Sub
        End If
        MsgBox("You must have cursor in the subject" & vbCr & "or email body to use this feature!", MsgBoxStyle.Exclamation, "Cannot Insert Tag")
    End Sub

    Private Sub btnCityState_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCityState.Click
        If Me.ActiveControl.Name = "txtsubject" Then
            Me.txtsubject.Text = Me.txtsubject.Text.Insert(Me.txtsubject.SelectionStart, "<<City, State>>")
            Me.txtsubject.SelectionStart = Me.txtsubject.Text.Length + 1
            Exit Sub
        End If
        If Me.ActiveControl.Name = "txtEmailBody" Then
            Me.txtEmailBody.Text = Me.txtEmailBody.Text.Insert(Me.txtEmailBody.SelectionStart, "<<City, State>>")
            Me.txtEmailBody.SelectionStart = Me.txtEmailBody.Text.Length + 1
            Exit Sub
        End If
        MsgBox("You must have cursor in the subject" & vbCr & "or email body to use this feature!", MsgBoxStyle.Exclamation, "Cannot Insert Tag")
    End Sub

    Private Sub btnConfirmer_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnConfirmer.Click
        If Me.ActiveControl.Name = "txtsubject" Then
            Me.txtsubject.Text = Me.txtsubject.Text.Insert(Me.txtsubject.SelectionStart, "<<Confirmer Name>>")
            Me.txtsubject.SelectionStart = Me.txtsubject.Text.Length + 1
            Exit Sub
        End If
        If Me.ActiveControl.Name = "txtEmailBody" Then
            Me.txtEmailBody.Text = Me.txtEmailBody.Text.Insert(Me.txtEmailBody.SelectionStart, "<<Confirmer Name>>")
            Me.txtEmailBody.SelectionStart = Me.txtEmailBody.Text.Length + 1
            Exit Sub
        End If
        MsgBox("You must have cursor in the subject" & vbCr & "or email body to use this feature!", MsgBoxStyle.Exclamation, "Cannot Insert Tag")
    End Sub

    Private Sub btnLastMarketer_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLastMarketer.Click
        If Me.ActiveControl.Name = "txtsubject" Then
            Me.txtsubject.Text = Me.txtsubject.Text.Insert(Me.txtsubject.SelectionStart, "<<Marketer Name>>")
            Me.txtsubject.SelectionStart = Me.txtsubject.Text.Length + 1
            Exit Sub
        End If
        If Me.ActiveControl.Name = "txtEmailBody" Then
            Me.txtEmailBody.Text = Me.txtEmailBody.Text.Insert(Me.txtEmailBody.SelectionStart, "<<Marketer Name>>")
            Me.txtEmailBody.SelectionStart = Me.txtEmailBody.Text.Length + 1
            Exit Sub
        End If
        MsgBox("You must have cursor in the subject" & vbCr & "or email body to use this feature!", MsgBoxStyle.Exclamation, "Cannot Insert Tag")
    End Sub

    Private Sub btnMainPhone_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMainPhone.Click
        If Me.ActiveControl.Name = "txtsubject" Then
            Me.txtsubject.Text = Me.txtsubject.Text.Insert(Me.txtsubject.SelectionStart, "<<House Phone>>")
            Me.txtsubject.SelectionStart = Me.txtsubject.Text.Length + 1
            Exit Sub
        End If
        If Me.ActiveControl.Name = "txtEmailBody" Then
            Me.txtEmailBody.Text = Me.txtEmailBody.Text.Insert(Me.txtEmailBody.SelectionStart, "<<House Phone>>")
            Me.txtEmailBody.SelectionStart = Me.txtEmailBody.Text.Length + 1
            Exit Sub
        End If
        MsgBox("You must have cursor in the subject" & vbCr & "or email body to use this feature!", MsgBoxStyle.Exclamation, "Cannot Insert Tag")
    End Sub

    Private Sub btnProducts_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnProducts.Click
        If Me.ActiveControl.Name = "txtsubject" Then
            Me.txtsubject.Text = Me.txtsubject.Text.Insert(Me.txtsubject.SelectionStart, "<<Product(s)>>")
            Me.txtsubject.SelectionStart = Me.txtsubject.Text.Length + 1
            Exit Sub
        End If
        If Me.ActiveControl.Name = "txtEmailBody" Then
            Me.txtEmailBody.Text = Me.txtEmailBody.Text.Insert(Me.txtEmailBody.SelectionStart, "<<Product(s)>>")
            Me.txtEmailBody.SelectionStart = Me.txtEmailBody.Text.Length + 1
            Exit Sub
        End If
        MsgBox("You must have cursor in the subject" & vbCr & "or email body to use this feature!", MsgBoxStyle.Exclamation, "Cannot Insert Tag")
    End Sub

    Private Sub btnSalesRep_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSalesRep.Click
        If Me.ActiveControl.Name = "txtsubject" Then
            Me.txtsubject.Text = Me.txtsubject.Text.Insert(Me.txtsubject.SelectionStart, "<<Sales Rep(s)>>")
            Me.txtsubject.SelectionStart = Me.txtsubject.Text.Length + 1
            Exit Sub
        End If
        If Me.ActiveControl.Name = "txtEmailBody" Then
            Me.txtEmailBody.Text = Me.txtEmailBody.Text.Insert(Me.txtEmailBody.SelectionStart, "<<Sales Rep(s)>>")
            Me.txtEmailBody.SelectionStart = Me.txtEmailBody.Text.Length + 1
            Exit Sub
        End If
        MsgBox("You must have cursor in the subject" & vbCr & "or email body to use this feature!", MsgBoxStyle.Exclamation, "Cannot Insert Tag")
    End Sub

    Private Sub btnZipCode_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnZipCode.Click
        If Me.ActiveControl.Name = "txtsubject" Then
            Me.txtsubject.Text = Me.txtsubject.Text.Insert(Me.txtsubject.SelectionStart, "<<Zip Code>>")
            Me.txtsubject.SelectionStart = Me.txtsubject.Text.Length + 1
            Exit Sub
        End If
        If Me.ActiveControl.Name = "txtEmailBody" Then
            Me.txtEmailBody.Text = Me.txtEmailBody.Text.Insert(Me.txtEmailBody.SelectionStart, "<<Zip Code>>")
            Me.txtEmailBody.SelectionStart = Me.txtEmailBody.Text.Length + 1
            Exit Sub
        End If
        MsgBox("You must have cursor in the subject" & vbCr & "or email body to use this feature!", MsgBoxStyle.Exclamation, "Cannot Insert Tag")
    End Sub

    Private Sub btnSpokeWith_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSpokeWith.Click
        If Me.ActiveControl.Name = "txtsubject" Then
            Me.txtsubject.Text = Me.txtsubject.Text.Insert(Me.txtsubject.SelectionStart, "<<Spoke With>>")
            Me.txtsubject.SelectionStart = Me.txtsubject.Text.Length + 1
            Exit Sub
        End If
        If Me.ActiveControl.Name = "txtEmailBody" Then
            Me.txtEmailBody.Text = Me.txtEmailBody.Text.Insert(Me.txtEmailBody.SelectionStart, "<<Spoke With>>")
            Me.txtEmailBody.SelectionStart = Me.txtEmailBody.Text.Length + 1
            Exit Sub
        End If
        MsgBox("You must have cursor in the subject" & vbCr & "or email body to use this feature!", MsgBoxStyle.Exclamation, "Cannot Insert Tag")
    End Sub

    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Me.txtEmailBody.Text = ""
        Me.txtsubject.Text = ""
        Me.txtEmailBody_LostFocus(Nothing, Nothing)
        Me.txtsubject_LostFocus(Nothing, Nothing)
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Me.txtEmailBody.Text = "" Then
            MsgBox("Cannot Save Email Template without an Email body!" & vbCr & "Please enter a body and try saving again.", MsgBoxStyle.Critical, "Email must contain a body")
            Me.txtEmailBody.Focus()
            Exit Sub
        End If
        Me.Close()
        InputBox("Enter a name for your Email Template.", "Save Template as...", Me.txtsubject.Text)
    End Sub
End Class