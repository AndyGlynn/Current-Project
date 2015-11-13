Public Class frmTesting

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim y As New USER_LOGICv2
        Dim arIPV4 As ArrayList = New ArrayList
        arIPV4 = y.GET_arIPV4s_FROM_LOCAL_MACHINE
        Dim i As Integer = 0
        For i = 0 To arIPV4.Count - 1
            Me.cboIPV4s.Items.Add(arIPV4(i))
        Next

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim y As New USER_LOGICv2
        MsgBox("User Exists : " & vbCrLf & y.Check_User_Exists(Me.txtFName.Text, Me.txtLName.Text), MsgBoxStyle.Information)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim z As New USER_LOGICv2
        MsgBox("Can Connect : " & vbCrLf & z.Check_Password(Me.txtPWD.Text, Me.txtFName.Text, Me.txtLName.Text), MsgBoxStyle.Information, "Check Password")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim z As New USER_LOGICv2
        Dim x As USER_LOGICv2.Employee = z.Get_User_Obj(Me.txtFName.Text, Me.txtLName.Text, Me.txtPWD.Text)
        STATIC_VARIABLES.employee.Add(x)
        z = Nothing
        x = Nothing
        MsgBox(STATIC_VARIABLES.employee(0).ID & " : " & STATIC_VARIABLES.employee(0).FName & ", " & STATIC_VARIABLES.employee(0).LName & " ", MsgBoxStyle.Information, "User Info Dump")
        Main.tsLoggedInAs.Text = STATIC_VARIABLES.employee(0).FName
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim a As New USER_LOGICv2
        Dim lf As USER_LOGICv2.LAST_FORM_AND_SCREEN_SIZE = a.Get_LAST_FORM_AND_SIZES(Me.txtFName.Text, Me.txtLName.Text, Me.txtPWD.Text)
        MsgBox("Form Name :" & lf.FormName.ToString & vbCrLf & "X : " & lf.ScreenX & " | Y : " & lf.ScreenY & vbCrLf & "Width : " & lf.ScreenW & " | Height : " & lf.ScreenH, MsgBoxStyle.Information, "Last Form and Screen Sizes")

    End Sub

     
    Private Sub btnBlast_Click(sender As Object, e As EventArgs) Handles btnBlast.Click
        Dim y As New EmailIssuedLeads
        y.Send_BLAST_MAIL(Me.txtFrom.Text, Me.txtTo.Text, Me.rtfMSG.Text, Me.txtSubject.Text)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.txtFrom.Text = "Valued Person"
        Me.txtTo.Text = "Aaron.Clay79@gmail.com"
        Me.txtSubject.Text = "Make The DEV Laugh"
        Me.rtfMSG.Text = "You know, I just wanted to take the time to say that I think what you're doing here is awesome and worthwhile. Also, don't feed the trolls." & vbCrLf & "http://www.youtube.com/watch?v=a1Y73sPHKxw"

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim x As Form = frmPrint
        x.MdiParent = Main
        x.Show()

    End Sub
End Class