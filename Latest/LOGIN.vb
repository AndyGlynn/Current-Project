Imports System.Text
Imports System.Xml
Imports System
Imports System.IO
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class LOGIN
    Dim strPath As String = "C:\Users\Public\pref.xml"
    Public Success As Boolean = False
    ''uncomment for production
    '' 
    Public user_name = "Aaron"
    Public PWD = "Spoken1"
    ''

    Private Sub LOGIN_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        Me.Dispose()
        ' Main.tmrmanagealerts.Start()
        'PastDueAlerts.Show()
     
        ''Go Fuck Yourself Aaron
        ''Go Fuck Yourself Andy.

    End Sub

    Private Sub LOGIN_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Success = False Then
            Main.Close()
        End If
    End Sub

   

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
        '' to be done: user snapshotp feature trumps the local xml file
        '' edit : 8-13-2015 Aaron
        Try

            Me.txtPWD.Text = ""
            Me.Text = STATIC_VARIABLES.ProgramName.ToString & " : Login"
            Dim a As New AUTO_COMPLETE_LOGINS

            'Dim doc As New XmlDocument
            'doc.Load(strPath)
            'Dim r1 As XmlNodeReader
            'r1 = New XmlNodeReader(doc)
            'While r1.Read
            '    Select Case r1.NodeType
            '        Case Is = XmlNodeType.Element
            '        Case Is = XmlNodeType.Text
            '            Dim str As String = Nothing
            '            str = r1.Value
            '            Me.txtUserName.Text = str
            '            Exit Select
            '    End Select
            'End While
            'r1.Close()
            'doc = Nothing
            Me.Activate()
            If Me.txtUserName.Text <> "" Then

                Me.txtPWD.Select()
            Else
                Me.txtUserName.Select()
            End If

            'Me.txtPWD.Text = "2527" ''Remove Later


            'Me.btnOK_Click(Nothing, Nothing) ''Remove Later


            '' UNCOMMENT FOR TESTING
            '' AC
            'Me.txtUserName.Text = user_name
            'Me.txtPWD.Text = PWD
            'Me.btnOK_Click(Nothing, Nothing)

        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "LOGIN", "FormCode", "Event", "Load", "0", ex.Message.ToString)
            y = Nothing
        End Try


    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        Try
            Dim x As New MAPPOINT_LOGIC
            x.KillProcess() '' make sure all mappoint instances are not runnning and closed out / free resources 
            Dim c As New USER_LOGICv2
            Try
                If My.Computer.Network.IsAvailable = True Then
                    Dim tstCNN As New System.Data.SqlClient.SqlConnection("SERVER=192.168.1.2;DataBase=Iss;User Id=sa;Password=spoken1;Timeout=5;")
                    Try
                        tstCNN.Open()
                        tstCNN.Close()
                    Catch ex As Exception
                        MsgBox("No connection can be made to SQL server. Settings will not be saved.", MsgBoxStyle.Exclamation, "No Network Present.")
                        Exit Sub
                    End Try
                End If
                Try
                    Dim frmX As Windows.Forms.Form = Me.ActiveMdiChild
                    Dim scrX As Integer = frmX.Location.X
                    Dim scrY As Integer = frmX.Location.Y
                    Dim scrW As Integer = frmX.Width
                    Dim scrH As Integer = frmX.Height
                    'c.LogOut("00", scrX, scrY, scrW, scrH, frm.Name, "", c.Get_MACH_NAME, "")
                    c.LogOutOfSystem(STATIC_VARIABLES.CurrentLoggedInEmployee.UserFirstName, STATIC_VARIABLES.CurrentLoggedInEmployee.UserLastName, scrX, scrY, scrW, scrH, frmX.Name)
                Catch ex As Exception
                    Dim frmX As String = ""
                    Dim scrX As Integer = 0
                    Dim scrY As Integer = 0
                    Dim scrW As Integer = 0
                    Dim scrH As Integer = 0
                    'c.LogOut("99", scrX, scrY, scrW, scrH, "Main", "No Query", My.Computer.Name.ToString, "admin")
                    c.LogOutOfSystem(STATIC_VARIABLES.CurrentLoggedInEmployee.UserFirstName, STATIC_VARIABLES.CurrentLoggedInEmployee.UserLastName, scrX, scrY, scrW, scrH, frmX)
                End Try
                Me.Cursor = Cursors.WaitCursor
                Application.Exit()
                Me.Cursor = Cursors.Default
            Catch ex As Exception

            End Try
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "LOGIN", "FormCode", "Event", "btnCancel_Click", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Try
            If Me.txtPWD.Text.ToString.Length < 2 Then
                MsgBox("You cannot have a blank password.", MsgBoxStyle.Exclamation, "Password Needed")
                Me.txtPWD.Select()
                Exit Sub
            End If
            If txtUserName.Text = "" Then
                MsgBox("You must supply a User Name.", MsgBoxStyle.Exclamation, "Blank Login")
                Exit Sub
            End If
            'If Me.txtUserName.Text = "Admin" Then
            Main.TSMain.Enabled = True

            'If Me.txtPWD.Text <> "1234567890!" Then
            Dim log_In As New USER_LOGIC
            log_In.Login_To_System()
            If Me.Success = False Then
                Me.txtUserName.Text = ""
                Me.txtPWD.Text = ""
                Me.txtUserName.Focus()
                'Me.Success = True
                Exit Sub
            End If
            Main.TSMain.Enabled = True
            'System.IO.File.Delete("C:\Users\Public\Pref.xml")
            'Dim sw As New StreamWriter("C:\Users\Public\Pref.xml")
            'sw.WriteLine("<ROOT>")
            'sw.WriteLine("<LastLogin>" & Me.txtUserName.Text & "</LastLogin>")
            'sw.WriteLine("</ROOT>")
            'sw.Flush()
            'sw.Close()

            'Me.txtPWD.Text = ""
            'Dim b As New ALERT_LOGIC("Admin")
            'Dim x As New ALERT_LOGIC("Admin")
            'Select Case x.CountOfAlerts
            '    Case Is >= 1
            '        Dim response As Integer = MsgBox("You have past due alerts. Would you like to manage them now?", MsgBoxStyle.YesNo, "Past Due Alerts")
            '        If response = 6 Then
            '            ManageAlerts.Show()
            '        ElseIf response = 7 Then
            '            'Exit Sub
            '        End If
            '    Case Is <= 0
            '        Exit Select
            'End Select
            ''PastDueAlerts.Show()
            'Me.Close()
            'Me.Close()
            'End If
            ' If Me.txtPWD.Text = "1234567890!" Then
            'Main.TSMain.Enabled = True
            'System.IO.File.Delete("C:\Users\Public\Pref.xml")
            'Dim sw As New StreamWriter("C:\Users\Public\Pref.xml")
            'sw.WriteLine("<ROOT>")
            'sw.WriteLine("<LastLogin>Admin</LastLogin>")
            'sw.WriteLine("</ROOT>")
            'sw.Flush()
            'sw.Close()
            'Me.txtPWD.Text = ""
            ''Dim b As New ALERT_LOGIC("Admin")
            ''Dim x As New ALERT_LOGIC("Admin")
            ''Select Case x.CountOfAlerts
            ''    Case Is >= 1
            ''        Dim response As Integer = MsgBox("You have past due alerts. Would you like to manage them now?", MsgBoxStyle.YesNo, "Past Due Alerts")
            ''        If response = 6 Then
            ''            ManageAlerts.Show()
            ''        ElseIf response = 7 Then
            ''            Exit Sub
            ''        End If
            ''    Case Is <= 0
            ''        Exit Select
            ''End Select
            ''PastDueAlerts.Show()
            'Me.Close()
            ''Me.Close()
            ' End If

            'End If
            'If Me.txtUserName.Text <> "Admin" Then
            '    Dim log_In As New USER_LOGIC
            '    log_In.Login_To_System()
            '    Main.TSMain.Enabled = True
            '    System.IO.File.Delete("C:\Users\Public\Pref.xml")
            '    Dim sw As New StreamWriter("C:\Users\Public\Pref.xml")
            '    sw.WriteLine("<ROOT>")
            '    sw.WriteLine("<LastLogin>" & STATIC_VARIABLES.Login & "</LastLogin>")
            '    sw.WriteLine("</ROOT>")
            '    sw.Flush()
            '    sw.Close()
            '    Me.txtPWD.Text = ""
            '' now check for past due alerts
            '' 
            'Dim b As New ALERT_LOGIC(STATIC_VARIABLES.CurrentUser)
            'Dim x As New ALERT_LOGIC(STATIC_VARIABLES.CurrentUser)
            'Select Case x.CountOfAlerts
            '    Case Is >= 1
            '        Dim response As Integer = MsgBox("You have past due alerts. Would you like to manage them now?", MsgBoxStyle.YesNo, "Past Due Alerts")
            '        If response = 6 Then
            '            ManageAlerts.Show()
            '        ElseIf response = 7 Then
            '            'Exit Sub
            '        End If
            '    Case Is <= 0
            '        Exit Select
            'End Select
            ''PastDueAlerts.Show()

            Dim usr_obj As New USER_LOGICv2.UserObj
            Dim sql As New USER_LOGICv2
            usr_obj = sql.Get_User_Obj(Me.user_name, Me.PWD)
            Main.tsLoggedInAs.Text = (usr_obj.UserFirstName & " " & usr_obj.UserLastName)
            Dim z As New preLoad
            Main.tsRecCount.Text = z.Count_Of_Total_Records.ToString
            If z.Is_Network_Available = True Then
                Main.tsNetworkStatus.Text = "UP"
            ElseIf z.Is_Network_Available = False Then
                Main.tsNetworkStatus.Text = "DOWN"
            End If
            If z.SQL_Status = True Then
                Main.tsSqlSTatus.Text = "UP"
            ElseIf z.SQL_Status = False Then
                Main.tsSqlSTatus.Text = "DOWN"
            End If
            STATIC_VARIABLES.CurrentLoggedInEmployee = usr_obj
            sql = Nothing
            Me.Close()

            'End If
            'MsgBox(STATIC_VARIABLES.CurrentUser)

        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "LOGIN", "FormCode", "Event", "btnOK_CLick", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Private Sub lnkForgot_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkForgot.LinkClicked
        MsgBox("Contact your system administrator to reset your password!", MsgBoxStyle.Exclamation, "Forgot Password")
    End Sub


    Private Class preLoad
        Private Const cnxSTR As String = "SERVER=192.168.1.2;Database=Iss;User Id=sa;Password=spoken1;"
        Private recCnt As Integer = 0
        Private netAvail As Boolean
        Private sqlSTATUS As Boolean
        Public ReadOnly Property SQL_Status As Boolean
            Get
                Return sqlSTATUS
            End Get
        End Property
        Public ReadOnly Property Is_Network_Available As Boolean
            Get
                Return netAvail
            End Get
        End Property
        Public ReadOnly Property Count_Of_Total_Records As Integer
            Get
                Return recCnt
            End Get
        End Property
        Public Sub New()
            recCnt = getCntEL()
            netAvail = My.Computer.Network.IsAvailable
            sqlSTATUS = getSQL_Status()
        End Sub

        Private Function getSQL_Status()
            Try
                Dim cnx As New SqlConnection(cnxSTR)
                cnx.Open()
                If cnx.State = ConnectionState.Open Then
                    sqlSTATUS = True
                End If
                cnx.Close()
                cnx = Nothing
                Return sqlSTATUS
            Catch ex As Exception
                sqlSTATUS = False
                Return sqlSTATUS
            End Try
        End Function


        Private Function getCntEL()
            Try
                Dim cnx As New SqlConnection(cnxSTR)
                cnx.Open()
                Dim cmdGET As New SqlCommand("SELECT COUNT(ID) from EnterLead;", cnx)
                Dim res As Integer = 0
                res = cmdGET.ExecuteScalar
                cnx.Close()
                cnx = Nothing
                Return res
            Catch ex As Exception
                Return 0
                Dim y As New ErrorLogging_V2
                y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "LOGIN", "FormCode", "Function", "getCntEL()", "0", ex.Message.ToString)
                y = Nothing
            End Try
        End Function

    End Class



End Class
