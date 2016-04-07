Imports System.IO
Imports System.Text
Imports System.IO.DirectoryInfo
Imports System.IO.FileInfo
Imports System.Text.StringBuilder
Imports System.IO.StreamWriter
Imports System.IO.StreamReader
Public Class ErrorLogging_V2
    ''
    '' path: \\server\Company\ISS\Logs
    '' 

    '' get files
    '' write to {append if exists}
    ''          {create if doesnt exist}
    '' structure: 1/21/2016 5:29:09 AM,PC-101,192.168.0.3,Aaron Clay,FormXYZ.vb,ImportData_V2,BulkImport(args),Index was outside the bounds of the array.
    '' args: date/time,machine name,IP,user,form,class(with args),[type:Network,Form,Background,Thread...etc.],Method(args),Record ID [if applicable],actual stack error
    '' 
    Private FileList As Hashtable
    Private Const filePath As String = "\\server\company\ISS\Logs\"
    Private wrtr As StreamWriter
    Public ReadOnly Property File_List As Hashtable
        Get
            Return FileList
        End Get
    End Property

    Public Sub New()
        If My.Computer.Network.IsAvailable = True Then
            Try
                FileList = GetFiles()
            Catch ex As Exception

            End Try
        ElseIf My.Computer.Network.IsAvailable = False Then
            MsgBox("No Network Present.", MsgBoxStyle.Exclamation, "No Network.")
        End If
    End Sub
    Public Function GetFiles()
        Try
            Dim f_list As New Hashtable
            Dim dirNFO As New DirectoryInfo(filePath)
            Dim x
            For Each x In dirNFO.GetFiles("*.txt")
                Dim f_info As System.IO.FileInfo = x
                f_list.Add(x.FullName, x.Name)
            Next
            Return f_list
        Catch ex As Exception

            Main.Cursor = Cursors.Default

            MsgBox("There was an error retrieving the error log files on the server. Please check your network connection and try again.", MsgBoxStyle.Exclamation, "Error Getting Logs")
            Return 0
        End Try
    End Function
    Public Sub WriteToLog(ByVal DateTime As DateTime, ByVal MachineName As String, ByVal IP As String, ByVal FormName As String, ByVal ClassName As String, ByVal Type As String, ByVal MethodName As String, ByVal RecordID As String, ByVal StackError As String)
        Try
            Dim fullPath As String = filePath & "ErrorLog.txt"
            If System.IO.File.Exists(filePath & "ErrorLog.txt") = True Then
                wrtr = New StreamWriter(fullPath, True)
                Dim lineOfText As String = DateTime & "," & MachineName & "," & IP & "," & FormName & "," & ClassName & "," & Type & "," & MethodName & "," & RecordID & "," & StackError
                wrtr.WriteLine(lineOfText)
                wrtr.Flush()
                wrtr.Close()
            ElseIf System.IO.File.Exists(filePath & "ErrorLog.txt") = False Then
                wrtr = New StreamWriter(fullPath)
                Dim lineOfText As String = DateTime & "," & MachineName & "," & IP & "," & FormName & "," & ClassName & "," & Type & "," & MethodName & "," & RecordID & "," & StackError
                wrtr.WriteLine(lineOfText)
                wrtr.Flush()
                wrtr.Close()
            End If
        Catch ex As Exception
            Main.Cursor = Cursors.Default

            MsgBox("There was an error writing to the error log files on the server. Please check your network connection and try again.", MsgBoxStyle.Exclamation, "Error Writing Logs")
            Exit Sub
        End Try
    End Sub
    Public Function ReadFile(ByVal FilePath As String)
        Try
            Dim txt As String = ""
            Dim rd As New StreamReader(FilePath)
            Do While rd.Peek() > -1
                txt += rd.ReadLine & vbCrLf
            Loop
            rd.Close()
            rd = Nothing
            Return txt
        Catch ex As Exception
            Main.Cursor = Cursors.Default

            MsgBox("There was an error reading the error log from the server. Please check your network connection and try again.", MsgBoxStyle.Exclamation, "Error Reading Log")
            Return 0
        End Try
    End Function
    Public Function DeleteLog(ByVal FilePath As String)
        Try
            Dim Refresh As Boolean = False
            If System.IO.File.Exists(FilePath) = True Then
                Dim response As Integer = MsgBox("Are you sure you want to delete file: '" & vbCrLf & FilePath & "' ?", MsgBoxStyle.YesNo, "Delete File?")
                If response = vbYes Then
                    System.IO.File.Delete(FilePath)
                    FileList = GetFiles() '' repop hash of files after item deleted.
                    Refresh = True
                ElseIf response = vbNo Then
                    Refresh = False
                End If
            End If
            Return Refresh
        Catch ex As Exception
            Main.Cursor = Cursors.Default

            MsgBox("There was an error deleting the error log on the server. Please check your network connection and try again.", MsgBoxStyle.Exclamation, "Error Deleting Logs")
            Return 0
        End Try
    End Function
End Class

