Imports System.Net.Sockets
Imports System.Data.SqlClient

Public Class frmChat
    Private cnn As SqlConnection = New sqlconnection(STATIC_VARIABLES.cnn)

    Private Sub frmChat_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.tmrChat.Enabled = False
    End Sub

    Private Sub frmChat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = Main
        Me.tmrChat.Enabled = True
        'Me.MdiParent = Main
        GetUsers()

    End Sub
    Private Sub GetUsers()
        Try
            Dim cmdGET As SqlCommand = New SqlCommand("SELECT UserName from  userpermissiontable", cnn)
            Dim arUser As New ArrayList
            Dim r1 As SqlDataReader
            cnn.Open()
            r1 = cmdGET.ExecuteReader
            While r1.Read
                arUser.Add(r1.Item("UserName"))
            End While
            r1.Close()
            cnn.Close()

            Dim c As Integer = 0
            For c = 0 To arUser.Count - 1
                If UserOnline(arUser(c).ToString) = True Then
                    Me.lstUsers.Items.Add(arUser(c).ToString)
                End If
            Next
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmChat", "FormCode", "sub", "GetUsers()", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub
    Private Function UserOnline(ByVal UserName As String) As Boolean
        Try
            Dim cmdONLINE As SqlCommand = New SqlCommand("SELECT LOGGEDON from  userpermissiontable where UserName = @USR", cnn)
            Dim param1 As SqlParameter = New SqlParameter("@USR", UserName)
            cmdONLINE.Parameters.Add(param1)
            Dim ONLINE As Boolean
            Dim r1 As SqlDataReader
            cnn.Open()
            r1 = cmdONLINE.ExecuteReader
            While r1.Read
                ONLINE = r1.Item(0)
            End While
            r1.Close()
            cnn.Close()
            Return ONLINE
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmChat", "FormCode", "sub", "GetUsers()", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        Try
            Control.CheckForIllegalCrossThreadCalls = False
            Dim port As Int32 = 5586 '' currently unassigned by IANA as of 2-17-2007
            Dim ip1 As Net.IPAddress ' holder for local machine name.
            Dim strMachineName As String = ""
            strMachineName = My.Computer.Name
            Dim ipHost As Net.IPHostEntry
            ipHost = Net.Dns.GetHostByName(strMachineName)
            Dim ipAddr1() As Net.IPAddress = ipHost.AddressList
            ip1 = ipAddr1(0)

            Dim dnsEntry As String = ""
            dnsEntry = Net.Dns.GetHostEntry(ip1).HostName

            'Try
            '    MsgBox(STATIC_VARIABLES.NET_CLIENT.Connected)
            '    send("| |Test Send|CHAT||")
            'Catch ex As Exception
            '    MsgBox(ex.Message.ToString)
            'End Try

            ' packet structure 
            ' machinename|ipaddress|msg|cmd|user|recipient (if any)|"
            Dim usrMSG As String = Me.txtMSG.Text.ToString
            Dim str As String = (strMachineName & "|" & ip1.ToString & "|" & usrMSG & "|CHAT|" & STATIC_VARIABLES.Server_Assigned_Hash & "| |")
            If str.ToString.Length <= 0 Then
                Exit Sub
            ElseIf str.ToString.ToString.Length >= 1 Then
                send(str)
                Me.txtMSG.Text = ""
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmChat", "FormCode", "Sub", "btnSend_Click", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub
    Private Sub send(ByVal t As String)
        Try
            Dim mobjclient As New TcpClient
            mobjclient = STATIC_VARIABLES.NET_CLIENT
            Dim ns As New IO.StreamWriter(mobjclient.GetStream)
            ns.Write(t & vbCr)
            ns.Flush()
            'ns.Close()
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmChat", "FormCode", "sub", "Send(t as string)", "0", ex.Message.ToString)
            y = Nothing
        End Try
    End Sub

    Private Sub tmrChat_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrChat.Tick
        Try
            If PENDING_REQUEST_INFO.IncommingChatMsg = True Then
                Dim lv As New ListViewItem
                lv.Font = New Font("Tahoma", 10.25!, FontStyle.Bold, GraphicsUnit.Pixel, CType(0, Byte))
                lv.Text = PENDING_REQUEST_INFO.Sender.ToString
                Dim crntUSR As String = STATIC_VARIABLES.CurrentUser.ToString

                If crntUSR = STATIC_VARIABLES.CurrentUser.ToString Then
                    lv.ForeColor = Color.Green
                ElseIf crntUSR <> STATIC_VARIABLES.CurrentUser.ToString Then
                    lv.ForeColor = Color.Red
                End If

                lv.SubItems.Add(PENDING_REQUEST_INFO.MSG.ToString)
                Me.lstChat.Items.Add(lv)
                Me.lstChat.Refresh()
                PENDING_REQUEST_INFO.IncommingChatMsg = False
                PENDING_REQUEST_INFO.Sender = ""
                PENDING_REQUEST_INFO.MSG = ""
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmChat", "FormCode", "sub", "tmrChat_Tick", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub SenderXFERRequestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SenderXFERRequestToolStripMenuItem.Click
        Dim x As Form
        'x = Transfer_Lead
        'x.ShowInTaskbar = False
        'x.ShowDialog()
    End Sub
End Class