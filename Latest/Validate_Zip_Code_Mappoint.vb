Imports MapPoint

Public Class Validate_Zip_Code_Mappoint
    Private is_Valid As Boolean = False
    Public ReadOnly Property Valid As Boolean
        Get
            Return is_Valid
        End Get
    End Property
    Public Sub New(ByVal ZipToValidate As String)
        is_Valid = IsZipValid(ZipToValidate)
    End Sub
    Private Function IsZipValid(ByVal ZipToValidate As String)
        Dim isValid As Boolean = False
        Try
            Dim oApp As MapPoint.Application
            'oApp = CreateObject("Mappoint.Application")
            oApp = STATIC_VARIABLES.oApp
            oApp.Visible = False
            Dim oMap As MapPoint.Map
            oMap = oApp.NewMap
            Dim oRes As MapPoint.FindResults
            oRes = oMap.FindAddressResults(, , , , ZipToValidate, GeoCountry.geoCountryUnitedStates)
            Dim cnt As Integer = oRes.Count
            If cnt >= 1 Then
                isValid = True
            ElseIf cnt <= 0 Then
                isValid = False
            End If
            Return isValid
            oMap.Saved = True
            'oApp.Quit()
            ' oApp = Nothing

        Catch ex As Exception
            Main.Cursor = Cursors.Default
            Dim a As New ErrorLogging_V2
            a.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "frmWCList.vb", "Validate_Zip_Code_Mappoint", "Class", "IzZipValid()", "0", ex.Message.ToString)
            a = Nothing
            isValid = False
            Return isValid
        End Try
    End Function

End Class
