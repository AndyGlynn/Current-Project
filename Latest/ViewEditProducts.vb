Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System


Public Class ViewEditProducts
    '' sqlconnection 
    '' 
    Private cnn As SqlConnection = New sqlconnection(STATIC_VARIABLES.cnn)
    '' product arraylist 
    '' 
    Public ArProducts As New ArrayList
    Public ArProdAcro As New ArrayList

    Public Sub PopuluateList()

        Try
            Dim cmdGET As SqlCommand = New SqlCommand("Select Product, ProdAcronym from .products", cnn)
            cnn.Open()
            Dim r1 As SqlDataReader
            r1 = cmdGET.ExecuteReader
            While r1.Read
                ArProducts.Add(r1.Item("Product"))
                ArProdAcro.Add(r1.Item("ProdAcronym"))
            End While
            r1.Close()
            cnn.Close()
        Catch ex As Exception
            Main.Cursor = Cursors.Default
            cnn.Close()
            'Dim err As New ErrorLogFlatFile
            'err.WriteLog("ViewEditProducts", "None", ex.Message.ToString, "Client", STATIC_VARIABLES.CurrentUser & ", " & STATIC_VARIABLES.CurrentForm, "SQL", "PopulateList")
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "ViewEditProducts", "ViewEditProducts", "Sub", "PopulateList()", "0", ex.Message.ToString)
            y = Nothing
        End Try
    End Sub

    Public Sub Add_Product(ByVal ProductName As String, ByVal ProdAcro As String)
        Try
            Dim cmdCNT As SqlCommand = New SqlCommand("SELECT COUNT(ID) From .Products where Product = @PR", cnn)
            Dim param1 As SqlParameter = New SqlParameter("@PR", ProductName)
            cmdCNT.Parameters.Add(param1)
            Dim cnt As Integer = 0
            cnn.Open()
            cnt = cmdCNT.ExecuteScalar
            cnn.Close()
            Select Case cnt
                Case Is <= 0
                    '' doesnt exist
                    '' add it.
                    Try
                        Dim cmdINS As SqlCommand = New SqlCommand("INSERT .products (Product,ProdAcronym) values(@PR,@PRA)", cnn)
                        Dim param2 As SqlParameter = New SqlParameter("@PR", ProductName)
                        Dim param3 As SqlParameter = New SqlParameter("@PRA", ProdAcro)
                        cmdINS.Parameters.Add(param2)
                        cmdINS.Parameters.Add(param3)
                        cnn.Open()
                        cmdINS.ExecuteNonQuery()
                        cnn.Close()
                    Catch ex As Exception
                        cnn.Close()
                    End Try
                   
                Case Is >= 1
                    '' exists 
                    '' flag / warn user
                    '' exit 
                    MsgBox("Product '" & ProductName & "' already exists. Please enter a new product.", MsgBoxStyle.Exclamation, "Error Adding Product")
                    Exit Select
            End Select
        Catch ex As Exception
            cnn.Close()
            Main.Cursor = Cursors.Default
            'Dim err As New ErrorLogFlatFile
            'err.WriteLog("ViewEditProducts", "ByVal ProductName As String, ByVal ProdAcro As String", ex.Message.ToString, "Client", STATIC_VARIABLES.CurrentUser & ", " & STATIC_VARIABLES.CurrentForm, "SQL", "Add_Product")
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "ViewEditProducts", "ViewEditProducts", "Sub", "Add_Product()", "0", ex.Message.ToString)
            y = Nothing
        End Try
    End Sub
End Class
