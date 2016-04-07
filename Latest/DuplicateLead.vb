Public Class DuplicateLead
    Public CloseMethod As String = ""
    Public MapPointVerified As Boolean
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.lstDupes.Items.Clear()
        Me.CloseMethod = ""
        Me.Close()
    End Sub

    Private Sub DuplicateLead_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.lstDupes.Items.Clear()
        Select Case CloseMethod
            Case "SAVE"
                EnterLead.Reset()
                EnterLead.Close()
                Exit Select
            Case "SAVEANDNEW"
                EnterLead.Reset()
                Exit Select
            Case ""
                Exit Select
        End Select
    End Sub

    
    Private Sub btnNew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Try
            Dim c As New ENTER_LEAD.InsertEnterLead
            c.InsertLead(MapPointVerified)
            Me.lstDupes.Items.Clear()
            Me.Close()
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Main.Cursor = Cursors.Default
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "DuplicateLead", "FormCode", "Event", "btnNew_Click()", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

  
End Class