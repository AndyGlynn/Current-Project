Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmEditSpecialInstructions
    Public RecID As String = STATIC_VARIABLES.CurrentID
    Public frm As Form

    Private Sub frmEditSpecialInstructions_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmEditSpecialInstructions_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        If RecID <> "" Then
            Try
                Dim y As New GetSpecialInstructions(RecID)
                Me.rtfSpecialInstructions.Text = y.SpecialInstructions
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                Main.Cursor = Cursors.Default
                Dim y As New ErrorLogging_V2
                y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmEditSpecialInstructions", "FormCode", "Event", "frmEditSpecialInstructions_Load", "0", ex.Message.ToString)
                y = Nothing
            End Try

        End If
    End Sub

    Private Sub ResetForm()
        Me.RecID = ""
        Me.rtfSpecialInstructions.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.ResetForm()
        Me.Close()
        Me.Dispose()
    End Sub

    Private Class GetSpecialInstructions
        Private Const pro_cnx As String = "SERVER=192.168.1.2;Database=Iss;User Id=sa;Password=spoken1;"
        Private _spi As String = ""
        Public ReadOnly Property SpecialInstructions As String
            Get
                Return _spi
            End Get
        End Property
        Public Sub New(ByVal RecID As String)
            _spi = Get_SPI(RecID)
        End Sub

        Private Function Get_SPI(ByVal RecID As String)
            Try
                Dim cnx As New SqlConnection(pro_cnx)
                Dim retSTR As String = ""
                cnx.Open()
                Dim cmdGET As New SqlCommand("SELECT SpecialInstruction FROM EnterLead WHERE ID = '" & RecID & "';", cnx)
                retSTR = cmdGET.ExecuteScalar
                cnx.Close()
                cnx = Nothing
                Return retSTR
            Catch ex As Exception

                Main.Cursor = Cursors.Default
                Dim y As New ErrorLogging_V2
                y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmEditSpecialInstructions.GetSpecialInstructions", "FormCode-Private Class", "Function", "Get_SPI(recID)", RecID, ex.Message.ToString)
                y = Nothing
            End Try

        End Function
    End Class

    Private Class UpdateSpecialInstructions
        Private Const pro_cnx As String = "SERVER=192.168.1.2;Database=Iss;User Id=sa;Password=spoken1;"

        Public Sub New(ByVal RecID As String, ByVal SPI As String)
            UpdateSPI(RecID, SPI)
        End Sub

        Private Sub UpdateSPI(ByVal RecID As String, ByVal SPI As String)
            Try
                Dim cnx As New SqlConnection(pro_cnx)
                cnx.Open()
                Dim cmdGET As New SqlCommand("UPDATE EnterLead SET SpecialInstruction = '" & SPI & "' WHERE ID = '" & RecID & "';", cnx)
                cmdGET.ExecuteReader()
                cnx.Close()
                cnx = Nothing
            Catch ex As Exception

                Main.Cursor = Cursors.Default
                Dim y As New ErrorLogging_V2
                y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmEditSpecialInstructions.UpdateSpecialInstructions", "FormCode-Private Class", "Function", "Update_SPI(recID)", RecID, ex.Message.ToString)
                y = Nothing
            End Try

        End Sub

    End Class

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.rtfSpecialInstructions.Text.Length >= 1 Then
            Dim y As New UpdateSpecialInstructions(Me.RecID, Me.rtfSpecialInstructions.Text)
            Select Case frm.Name
                Case Is = "Sales"
                    Sales.rtbSpecialInstructions.Text = Me.rtfSpecialInstructions.Text
                    Exit Select
                Case Is = "Confirming"
                    Confirming.rtbSpecialInstructions.Text = Me.rtfSpecialInstructions.Text
                    Exit Select
                Case Is = "WCaller"
                    WCaller.rtbSpecialInstructions.Text = Me.rtfSpecialInstructions.Text
                    Exit Select
                Case Is = "MarketingManager"
                    MarketingManager.rtbSpecialInstructions.Text = Me.rtfSpecialInstructions.Text
                    Exit Select
                Case Is = "ConfirmingSingleRecord"
                    ConfirmingSingleRecord.rtbSpecialInstructions.Text = Me.rtfSpecialInstructions.Text
            End Select
            Me.ResetForm()
            Me.Close()
        End If
    End Sub
End Class