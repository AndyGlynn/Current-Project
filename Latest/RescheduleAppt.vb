Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class RescheduleAppt
    Public frm As Form
    Public ID As String = STATIC_VARIABLES.CurrentID

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            Dim s = Split(Me.dtpApptDate.Value.ToString, " ")
            Dim dt = s(0) & " 12:00:00 AM"
            'Dim s2 = Split(Me.dtpApptTime.Value.ToString, " ")
            Dim tm = "1/1/1900 " & Me.dtpApptTime.Value.ToShortTimeString






            If Me.dtpApptDate.Value < Date.Today Then
                MsgBox("Appointment Date Must be for Today or Future!", MsgBoxStyle.Exclamation, "Cannot Move Appt.")
                Exit Sub
            End If
            Dim cnn = New SqlConnection(STATIC_VARIABLES.Cnn)
            Dim cmdINS As SqlCommand = New SqlCommand("dbo.MoveAppt", cnn)

            Dim param1 As SqlParameter = New SqlParameter("@ID", ID)
            Dim param2 As SqlParameter = New SqlParameter("@Date", dt)
            Dim param3 As SqlParameter = New SqlParameter("@Time", tm)
            Dim param4 As SqlParameter = New SqlParameter("@User", STATIC_VARIABLES.CurrentUser)
            cmdINS.Parameters.Add(param1)
            cmdINS.Parameters.Add(param2)
            cmdINS.Parameters.Add(param3)
            cmdINS.Parameters.Add(param4)
            cmdINS.CommandType = CommandType.StoredProcedure
            Dim r1 As SqlDataReader
            cnn.Open()
            r1 = cmdINS.ExecuteReader
            r1.Read()
            r1.Close()
            cnn.Close()

            If frm.Name = "Confirming" Then
                Dim c As New ConfirmingData
                If Confirming.Tab = "Confirm" Then
                    c.Populate(Confirming.Tab, Confirming.cboConfirmingPLS.Text, Confirming.cboConfirmingSLS.Text, Confirming.dpConfirming.Value.ToString, "Populate")
                Else
                    c.Populate(Confirming.Tab, Confirming.cboSalesPLS.Text, Confirming.cboSalesSLS.Text, Confirming.dpSales.Value.ToString, "Populate")
                End If
            ElseIf frm.Name = "ConfirmingSingleRecord" Then
                Dim c As New CustomerHistory
                c.SetUp(ConfirmingSingleRecord.TScboCustomerHistory)
            ElseIf frm.Name = "Sales" Then
                Sales.PullInfo(STATIC_VARIABLES.CurrentID)
            ElseIf frm.Name = "Administration" Then
                'Administration.PullInfo(STATIC_VARIABLES.CurrentID)
            ElseIf frm.Name = "MarketingManager" Then
                'MarketingManager.PullInfo(STATIC_VARIABLES.CurrentID)
            ElseIf frm.Name = "WCaller" Then
                'WCaller.PullInfo(STATIC_VARIABLES.CurrentID)
            ElseIf frm.Name = "Installation" Then
                'Installation.PullInfo(STATIC_VARIABLES.CurrentID)
            ElseIf frm.Name = "PreviousCustomer" Then
                'PreviousCustomer.PullInfo(STATIC_VARIABLES.CurrentID)
            ElseIf frm.Name = "Recovery" Then
                'Recovery.PullInfo(STATIC_VARIABLES.CurrentID)
            ElseIf frm.Name = "EditCustomerInfo" Then
                Dim d = New EDIT_CUSTOMER_INFORMATION
                d.FeedProperties(STATIC_VARIABLES.CurrentID)
            ElseIf frm.Name = "Finance" Then
                'Finance.PullInfo(STATIC_VARIABLES.CurrentID)
            End If
            Me.Close()
            Me.Dispose()
        Catch ex As Exception
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "RescheduleAppt", "FormCode", "Sub", "btnSave_Click", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
        Me.Dispose()
    End Sub
    Private Function Chk_Locked_Sales_Results()
        Try
            Dim lock As Boolean = False
            Dim cnx As New SqlConnection(STATIC_VARIABLES.Cnn)
            cnx.Open()
            Dim cmdGet As New SqlCommand("Select NeedsSaleResult from EnterLead where id = " & ID, cnx)
            lock = cmdGet.ExecuteScalar
            cnx.Close()
            cnx = Nothing
            Return lock
        Catch ex As Exception

            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "SetAppt_V2", "FormCode-PrivateClass", "Function", "Chk_Locked_Sales_Results()", "0", ex.Message.ToString)
            y = Nothing
        End Try
    End Function
   

    Private Sub RescheduleAppt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lock As Boolean = Me.Chk_Locked_Sales_Results
        If lock = True Then
            MsgBox("This Record is locked pending a sales result!" & vbCr & "Cannot Move Appointment at this time!", MsgBoxStyle.Exclamation, "Pending Sales Result")
            Me.Dispose()
        End If


        If frm.Name = "Confirming" Then
            Me.dtpApptDate.Value = Convert.ToDateTime(Confirming.txtApptDate.Text & " 12:00 AM")
            Me.dtpApptTime.Value = Convert.ToDateTime("1/1/1900 " & Confirming.txtApptTime.Text)
        ElseIf frm.Name = "ConfirmingSingleRecord" Then
            Me.dtpApptDate.Value = Convert.ToDateTime(ConfirmingSingleRecord.txtApptDate.Text & " 12:00 AM")
            Me.dtpApptTime.Value = Convert.ToDateTime("1/1/1900 " & ConfirmingSingleRecord.txtApptTime.Text)
        ElseIf frm.Name = "Sales" Then
            Me.dtpApptDate.Value = Convert.ToDateTime(Sales.txtApptDate.Text & " 12:00 AM")
            Me.dtpApptTime.Value = Convert.ToDateTime("1/1/1900 " & Sales.txtApptTime.Text)
        ElseIf frm.Name = "Administration" Then
            'Me.dtpapptdate.Value = Convert.ToDateTime(Administration.txtApptDate.Text & " 12:00 AM")
            'Me.dtpappttime.Value = Convert.ToDateTime("1/1/1900 " & Administration.txtApptTime.Text)
        ElseIf frm.Name = "MarketingManager" Then
            Me.dtpApptDate.Value = Convert.ToDateTime(MarketingManager.txtApptDate.Text & " 12:00 AM")
            Me.dtpApptTime.Value = Convert.ToDateTime("1/1/1900 " & MarketingManager.txtApptTime.Text)
        ElseIf frm.Name = "WCaller" Then
            Me.dtpApptDate.Value = Convert.ToDateTime(WCaller.txtApptDate.Text & " 12:00 AM")
            Me.dtpApptTime.Value = Convert.ToDateTime("1/1/1900 " & WCaller.txtApptTime.Text)
        ElseIf frm.Name = "Installation" Then
            'Me.dtpapptdate.Value = Convert.ToDateTime(Installation.txtApptDate.Text & " 12:00 AM")
            'Me.dtpappttime.Value = Convert.ToDateTime("1/1/1900 " & Installation.txtApptTime.Text)
        ElseIf frm.Name = "PreviousCustomer" Then
            'Me.dtpapptdate.Value = Convert.ToDateTime(PreviousCustomer.txtApptDate.Text & " 12:00 AM")
            'Me.dtpappttime.Value = Convert.ToDateTime("1/1/1900 " & PreviousCustomer.txtApptTime.Text)
        ElseIf frm.Name = "Recovery" Then
            'Me.dtpapptdate.Value = Convert.ToDateTime(Recovery.txtApptDate.Text & " 12:00 AM")
            'Me.dtpappttime.Value = Convert.ToDateTime("1/1/1900 " & Recovery.txtApptTime.Text)
        ElseIf frm.Name = "EditCustomerInfo" Then
            Me.dtpApptDate.Value = Convert.ToDateTime(EditCustomerInfo.txtApptDate.Text & " 12:00 AM")
            Me.dtpApptTime.Value = Convert.ToDateTime("1/1/1900 " & EditCustomerInfo.txtApptTime.Text)
        ElseIf frm.Name = "Finance" Then
            'Me.dtpapptdate.Value = Convert.ToDateTime(Finance.txtApptDate.Text & " 12:00 AM")
            'Me.dtpappttime.Value = Convert.ToDateTime("1/1/1900 " & Finance.txtApptTime.Text)
        End If

    End Sub
End Class