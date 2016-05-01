
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System

Public Class AlertNotify
    Public ID As String
    Public i As ListViewItem
#Region "Connection String"

    Private cnn As SqlConnection = New System.Data.SqlClient.SqlConnection(STATIC_VARIABLES.Cnn)
#End Region
    Private iter As Integer = 0

    Private Sub AlertNotify_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Dim cnn As SqlConnection = New SqlConnection(STATIC_VARIABLES.Cnn)
        'Dim cmdDEL As SqlCommand = New SqlCommand("DELETE Iss.dbo.alerttable where ID = @ID", cnn)
        'Dim param1 As SqlParameter = New SqlParameter("@ID", ID)
        'cmdDEL.Parameters.Add(param1)
        'cnn.Open()
        'Dim r1 As SqlDataReader
        'r1 = cmdDEL.ExecuteReader
        'r1.Close()
        'cnn.Close()
        'Me.Close()
        'Me.Dispose()
    End Sub

    Private Sub AlertNotify_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim cnn As SqlConnection = New SqlConnection(STATIC_VARIABLES.Cnn)
            Dim cmdGET As SqlCommand = New SqlCommand("SELECT ID, Contact1FirstName,Contact1LastName,Contact2FirstName,Contact2LastName,Staddress,city,state,zip,housephone,altphone1,altphone2,phone1type,phone2type,(select notes from AlertTable where id = @id ) from iss.dbo.enterlead where ID = (select leadnum from alerttable where @ID = id)", cnn)
            Dim param1 As SqlParameter = New SqlParameter("@ID", ID)
            cmdGET.Parameters.Add(param1)
            cnn.Open()
            Dim r1 As SqlDataReader
            r1 = cmdGET.ExecuteReader
            While r1.Read
                Me.lblCustomerNFO.Text = r1.Item("Contact1FirstName") & " " & r1.Item("Contact1LastName") & " and " & r1.Item("Contact2FirstName") & " " & r1.Item("Contact2LastName") & vbCrLf & r1.Item("Staddress") & vbCrLf & r1.Item("City") & ", " & r1.Item("State") & ", " & r1.Item("Zip") & _
                     vbCrLf & r1.Item("HousePhone") & vbCrLf & r1.Item("AltPhone1") & "     " & r1.Item("Phone1Type") & vbCrLf & r1.Item("AltPhone2") & "     " & r1.Item("Phone2Type")
                Me.lnkID.Text = r1.Item("ID")
                Me.lblnotes.Text = r1.Item(14)
            End While


            r1.Close()
            cnn.Close()



            Me.MdiParent = Main
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.lblTime.Text = Format(DateTime.Now(), "h:mm tt").ToString
            Me.Text = "Alert Notification" & " for Record ID: " _
                    & Me.lnkID.Text.ToString
            'Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Timer1.Start()
            My.Computer.Audio.Play("C:\Users\Public\ISS Logs\samsung_whistle.wav", _
                       AudioPlayMode.Background)
            Main.Refresh()
        Catch ex As Exception
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now.ToString, My.Computer.Name, STATIC_VARIABLES.IP, "AlertNotify", "FormCode", "Sub", "AlertNotify_Load", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub



    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclosewindow.Click
        Try
            Dim cnn As SqlConnection = New SqlConnection(STATIC_VARIABLES.Cnn)
            Dim cmdDEL As SqlCommand = New SqlCommand("DELETE Iss.dbo.alerttable where ID = @ID", cnn)
            Dim param1 As SqlParameter = New SqlParameter("@ID", ID)
            cmdDEL.Parameters.Add(param1)
            cnn.Open()
            Dim r1 As SqlDataReader
            r1 = cmdDEL.ExecuteReader
            r1.Close()
            cnn.Close()
            Me.Close()
            Me.Dispose()
        Catch ex As Exception
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now.ToString, My.Computer.Name, STATIC_VARIABLES.IP, "AlertNotify", "FormCode", "Sub", "Label5_Click", "0", ex.Message.ToString)
            y = Nothing
        End Try



    End Sub

    Private Sub btnRemind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemind.Click
        'need to push timer by 5 minutes
        Try
            Dim time = Format(DateTime.Now.AddMinutes(5), "HH:mm:00")
            Dim dt = Date.Today()
            time = "01/01/1900 " & time
            dt = dt & " 00:00:00"


            'MsgBox(dt & "   " & time)
            Dim cnn As SqlConnection = New SqlConnection(STATIC_VARIABLES.Cnn)
            Dim cmdUP As SqlCommand = New SqlCommand("UPDATE iss.dbo.alerttable SET ExecutionDate = @Date, AlertTime = @Time, completed = 0 WHERE ID = @ID", cnn)
            Dim param1 As SqlParameter = New SqlParameter("@Date", dt)
            Dim param2 As SqlParameter = New SqlParameter("@Time", time)
            Dim param3 As SqlParameter = New SqlParameter("@ID", ID)
            cmdUP.Parameters.Add(param1)
            cmdUP.Parameters.Add(param2)
            cmdUP.Parameters.Add(param3)
            cnn.Open()
            Dim r1 As SqlDataReader
            r1 = cmdUP.ExecuteReader
            r1.Close()
            cnn.Close()
            Me.Close()
            Me.Dispose()

        Catch ex As Exception
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now.ToString, My.Computer.Name, STATIC_VARIABLES.IP, "AlertNotify", "FormCode", "Event", "btnRemind_Click", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub lnkID_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkID.LinkClicked
        Dim focused As Form
        Dim foundinform As String = ""
        Dim selitem As New ListViewItem
        selitem.Text = Me.lnkID.Text

        STATIC_VARIABLES.CurrentID = selitem.Text
        Dim found As Integer = 0
        Dim open As Integer = 0
        Dim frmName As String
        If STATIC_VARIABLES.ActiveChild IsNot Nothing Then
            focused = STATIC_VARIABLES.ActiveChild
        End If
        For Each frm As Form In Main.MdiChildren
            Select Case frm.Name
                Case "Confirming", "Sales", "Administration", "ColdCalling", "WCaller", "Finance", "MarketingManager", _
                        "Recovery", "PreviousCustomer", "SecondSource", "Installation"
                    open += 1
                    Select Case frm.Name
                        Case Is = "Confirming"

                            Dim tab As String = Confirming.Tab
                            If tab = "Confirm" Then
                                If Confirming.lvConfirming.Items.Count > 0 Then
                                    For Each Me.i In Confirming.lvConfirming.Items
                                        If Me.i.Text = selitem.Text Then
                                            Me.i.Selected = True
                                            Me.i.EnsureVisible()
                                            found += 1
                                            frmName = "Confirming"
                                            If foundinform <> "" Then
                                                foundinform = foundinform & " " & frmName
                                            Else
                                                foundinform = frmName
                                            End If
                                        End If
                                    Next
                                End If
                            Else
                                If Confirming.lvSales.Items.Count > 0 Then
                                    For Each Me.i In Confirming.lvSales.Items
                                        If Me.i.Text = selitem.Text Then
                                            Me.i.Selected = True
                                            Me.i.EnsureVisible()
                                            found += 1
                                            frmName = "Confirming"
                                            If foundinform <> "" Then
                                                foundinform = foundinform & " " & frmName
                                            Else
                                                foundinform = frmName
                                            End If
                                        End If
                                    Next
                                End If
                            End If
                            '' run query to see if it is open to form (this case being confirming) if confirming form = true get date, 
                            ''switch date picker then rerun for each and get lead , add tool tip explaining date has been changed to find the lead 
                            '' change below message box to say lead not available for confirming form 

                        Case Is = "Sales"
                            If Sales.TabControl2.SelectedIndex = 0 Then
                                If Sales.lvSales.Items.Count > 0 Then
                                    For Each i In Sales.lvSales.Items
                                        If Me.i.Text = selitem.Text Then
                                            Me.i.Selected = True
                                            Me.i.EnsureVisible()
                                            found += 1
                                            frmName = "Sales"
                                            If foundinform <> "" Then
                                                foundinform = foundinform & " " & frmName
                                            Else
                                                foundinform = frmName
                                            End If
                                        End If
                                    Next
                                End If
                            Else
                                If Sales.lvMemorized.Items.Count > 0 Then
                                    For Each i In Sales.lvMemorized.Items
                                        If Me.i.Text = selitem.Text Then
                                            Me.i.Selected = True
                                            Me.i.EnsureVisible()
                                            found += 1
                                            frmName = "Sales"
                                            If foundinform <> "" Then
                                                foundinform = foundinform & " " & frmName
                                            Else
                                                foundinform = frmName
                                            End If
                                        End If
                                    Next
                                End If
                            End If
                        Case Is = "Installation"
                            frmName = "Installation"
                            open += 1
                            If foundinform <> "" Then
                                foundinform = foundinform & " " & frmName
                            Else
                                foundinform = frmName
                            End If
                        Case Is = "Administration"
                            frmName = "Administration"
                            open += 1
                            If foundinform <> "" Then
                                foundinform = foundinform & " " & frmName
                            Else
                                foundinform = frmName
                            End If
                        Case Is = "WCaller"
                            frmName = "WCaller"
                            open += 1
                            If foundinform <> "" Then
                                foundinform = foundinform & " " & frmName
                            Else
                                foundinform = frmName
                            End If
                        Case Is = "MarketingManager"
                            frmName = "MarketingManager"
                            open += 1
                            If foundinform <> "" Then
                                foundinform = foundinform & " " & frmName
                            Else
                                foundinform = frmName
                            End If
                        Case Is = "Recovery"
                            frmName = "Recovery"
                            open += 1
                            If foundinform <> "" Then
                                foundinform = foundinform & " " & frmName
                            Else
                                foundinform = frmName
                            End If
                        Case Is = "PreviousCustomer"
                            frmName = "PreviousCustomer"
                            open += 1
                            If foundinform <> "" Then
                                foundinform = foundinform & " " & frmName
                            Else
                                foundinform = frmName
                            End If
                        Case Is = "Financing"
                            frmName = "Financing"
                            open += 1
                            If foundinform <> "" Then
                                foundinform = foundinform & " " & frmName
                            Else
                                foundinform = frmName
                            End If
                        Case Is = "ColdCalling"
                            frmName = "ColdCalling"
                            open += 1
                            If foundinform <> "" Then
                                foundinform = foundinform & " " & frmName
                            Else
                                foundinform = frmName
                            End If
                        Case Is = "SecondSource"
                            frmName = "SecondSource"
                            open += 1
                            If foundinform <> "" Then
                                foundinform = foundinform & " " & frmName
                            Else
                                foundinform = frmName
                            End If
                    End Select
            End Select

        Next
        If focused IsNot Nothing And foundinform.Contains(focused.Name) Then
            focused.Activate()
        ElseIf foundinform.Contains(" ") = False And foundinform <> "" Then
            For Each frm As Form In Main.MdiChildren
                If frm.Name = foundinform Then
                    frm.Activate()
                    Exit For
                End If
            Next
        End If


        If found = 0 And open <> 0 Then
            ConfirmingSingleRecord.ID = selitem.Text
            If STATIC_VARIABLES.ActiveChild IsNot Nothing Then
                STATIC_VARIABLES.ActiveChild.WindowState = FormWindowState.Normal
            End If
            ConfirmingSingleRecord.Show()
            'MsgBox("Cannot find record anywhere in your" & vbCr & "open forms with customer lists!", MsgBoxStyle.Critical, "Alert Link Failed")
        ElseIf open = 0 Then
            ConfirmingSingleRecord.ID = selitem.Text
            If STATIC_VARIABLES.ActiveChild IsNot Nothing Then
                STATIC_VARIABLES.ActiveChild.WindowState = FormWindowState.Normal
            End If
            ConfirmingSingleRecord.Show()
            'MsgBox("You have no lists open to link to!", MsgBoxStyle.Critical, "Alert Link Failed")
        End If
        Label5_Click(Nothing, Nothing)


    End Sub




    Private Sub AlertNotify_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged

        'Me.Opacity = 0
        Me.WindowState = FormWindowState.Normal

    End Sub
    Dim cnt As Integer = 0
    Dim cnt2 As Integer = 0
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            Me.cnt += 1
            'If Me.pctOn1.Location.X <> 220 Then
            '    Me.pctOn1.Location = New System.Drawing.Point((Me.pctOn1.Location.X + 22), 11)
            '    Me.pctOn1.BringToFront()
            'Else
            '    Me.pctOn1.Location = New System.Drawing.Point(66, 11)
            'End If
            Select Case cnt
                Case 1
                    Me.pctOn1.Visible = True
                    Me.pctOn1.BringToFront()
                Case 2
                    Me.pctOn2.Visible = True
                    Me.pctOn2.BringToFront()
                Case 3
                    Me.pctOn3.Visible = True
                    Me.pctOn3.BringToFront()
                Case 4
                    Me.pctOn4.Visible = True
                    Me.pctOn4.BringToFront()
                Case 5
                    Me.pctOn5.Visible = True
                    Me.pctOn5.BringToFront()
                Case 6
                    Me.pctOn6.Visible = True
                    Me.pctOn6.BringToFront()
                Case 7
                    Me.pctOn7.Visible = True
                    Me.pctOn7.BringToFront()
                Case 8
                    Me.pctOn8.Visible = True
                    Me.pctOn8.BringToFront()
                Case 9
                    Me.pctOn1.Visible = False
                    Me.pctOn2.Visible = False
                    Me.pctOn3.Visible = False
                    Me.pctOn4.Visible = False
                    Me.pctOn5.Visible = False
                    Me.pctOn6.Visible = False
                    Me.pctOn7.Visible = False
                    Me.pctOn8.Visible = False
                    Me.cnt = 0
            End Select


            If cnt2 = 150 Then
                My.Computer.Audio.Play("C:\Users\Public\ISS Logs\samsung_whistle.wav", _
                    AudioPlayMode.Background)
                cnt2 = 0
            End If
            cnt2 += 1
        Catch ex As Exception
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now.ToString, My.Computer.Name, STATIC_VARIABLES.IP, "AlertNotify", "FormCode", "Event", "Timer1_Tick", "0", ex.Message.ToString)
            y = Nothing
        End Try
    End Sub
End Class