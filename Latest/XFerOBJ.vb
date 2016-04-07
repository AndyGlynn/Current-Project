Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports Microsoft.VisualBasic.Interaction
Imports Microsoft.VisualBasic.Strings
Imports System
Imports System.Windows.Forms
Imports System.IO

Public Class XFerOBJ
    '' Notes: 2-10-16
    '' not used any more. xfer lead was tossed to wayside.
    '' 
    '' here for reference only.
    '' AC

    Public TM As String = ""
    Public TIP As String = ""
    Public Sub New(ByVal msg As String, ByVal tm As String, ByVal tip As String)
        Try
            Dim cli As New TcpClient
            Dim ip As IPAddress = IPAddress.Parse(tip)
            cli.Connect(ip, 5587)
            Dim ns As NetworkStream = cli.GetStream
            Dim SendByte(1024) As Byte
            SendByte = Encoding.ASCII.GetBytes(msg)
            ns = cli.GetStream
            ns.Write(SendByte, 0, SendByte.Length)
            cli.Close()
        Catch ex As Exception
            Main.Cursor = Cursors.Default
            MsgBox(ex.Message.ToString)
            Dim err As New ErrorLogFlatFile
            err.WriteLog("XFerOBJ", "ByVal msg As String, ByVal tm As String, ByVal tip As String", ex.Message.ToString, "Client", STATIC_VARIABLES.CurrentUser & ", " & STATIC_VARIABLES.CurrentForm, "XFER", "'New'")

        End Try
    End Sub
End Class
