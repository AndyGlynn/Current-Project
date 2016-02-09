Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class emlTemplateLogic
    Private Const dev_cnx As String = "SERVER=PC-101\DEVMIRROREXPRESS;Database=devMirror;User Id=sa;Password=Legend1!"
    Private Const pro_cnx As String = "SERVER=192.168.1.2;Database=ISS;User Id=sa;Password=spoken1"

    Public Structure TemplateInfo
        Public ID As String
        Public Subject As String
        Public Body As String
        Public TemplateName As String
        Public Department As String
    End Structure

    Public Structure CompanyInfo
        Public StreetName As String
        Public AddressLine2 As String
        Public City As String
        Public Zip As String
        Public State As String
        Public LogoDirectory As String
        Public ContactPhoneNumber As String
        Public ContactFaxNumber As String
        Public CompanyWebSite As String
        Public CompanyName As String
    End Structure

    '' DEFAULT QUERY IF NOTHING SELECTED
    '' 
    Public Function GetMaxID(ByVal Dev_Or_Pro)
        Try
            Dim cnx As SqlConnection
            If Dev_Or_Pro = True Then
                cnx = New SqlConnection(dev_cnx)
            ElseIf Dev_Or_Pro = False Then
                cnx = New SqlConnection(pro_cnx)
            End If
            cnx.Open()
            Dim cmdGET As New SqlCommand("SELECT TOP(1) ID FROM EnterLead;", cnx)
            Dim res As String = cmdGET.ExecuteScalar
            cnx.Close()
            cnx = Nothing
            Return res
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "emlTemplateLogic", "emlTemplateLogic", "Function", "GetMaxID(devorpro)", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Function

    Public Function GetTemplatesByDepartment(ByVal Dev_Or_Pro As Boolean, ByVal Department_Name As String)
        Try
            Dim arTemplates As New List(Of TemplateInfo)
            Dim cnx As SqlConnection
            If Dev_Or_Pro = True Then
                cnx = New SqlConnection(dev_cnx)
            ElseIf Dev_Or_Pro = False Then
                cnx = New SqlConnection(pro_cnx)
            End If
            cnx.Open()
            Dim cmdGET As New SqlCommand("SELECT * From tblEmailTemplates WHERE Department = '" & Department_Name & "';", cnx)
            Dim r1 As SqlDataReader = cmdGET.ExecuteReader
            While r1.Read
                Dim y As New TemplateInfo
                y.ID = r1.Item("ID")
                y.Subject = r1.Item("Subject")
                y.Body = r1.Item("Body")
                y.TemplateName = r1.Item("TemplateName")
                y.Department = r1.Item("Department")
                arTemplates.Add(y)
            End While
            r1.Close()
            cnx.Close()

            '' now get 'DEFAULT' templates and add to array.
            '' 
            cnx.Open()
            Dim cmdGET2 As New SqlCommand("SELECT * FROM tblEmailTemplates WHERE Department = 'DEFAULT';", cnx)
            Dim r2 As SqlDataReader = cmdGET2.ExecuteReader
            While r2.Read
                Dim y As New TemplateInfo
                y.ID = r2.Item("ID")
                y.Subject = r2.Item("Subject")
                y.Body = r2.Item("Body")
                y.TemplateName = r2.Item("TemplateName")
                y.Department = r2.Item("Department")
                arTemplates.Add(y)
            End While
            r2.Close()
            cnx.Close()
            cnx = Nothing
            Return arTemplates
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "emlTemplateLogic", "emlTemplateLogic", "Function", "GetTemplatesbyDepartment(department)", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Function

    Public Function GetSingleTemplate(ByVal TemplateName As String, ByVal Dev_Or_Pro As Boolean)
        Try
            Dim cnx As SqlConnection
            Dim x As New TemplateInfo
            If Dev_Or_Pro = True Then
                cnx = New SqlConnection(dev_cnx)
            ElseIf Dev_Or_Pro = False Then
                cnx = New SqlConnection(pro_cnx)
            End If
            cnx.Open()
            Dim cmdGET As New SqlCommand("SELECT * FROM tblEmailTemplates WHERE TemplateName = '" & TemplateName & "';", cnx)
            Dim r1 As SqlDataReader = cmdGET.ExecuteReader
            While r1.Read
                x.ID = r1.Item("ID")
                x.Subject = r1.Item("Subject")
                x.Body = r1.Item("Body")
                x.TemplateName = r1.Item("TemplateName")
                x.Department = r1.Item("Department")
            End While
            r1.Close()
            cnx.Close()
            cnx = Nothing
            Return x
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "emlTemplateLogic", "emlTemplateLogic", "Function", "GetSingleTemplate(templatename,devorpro)", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Function
    Public Sub InsertNewTemplate(ByVal Template As TemplateInfo, ByVal Dev_Or_Pro As Boolean)
        Try
            Dim cnx As SqlConnection
            If Dev_Or_Pro = True Then
                cnx = New SqlConnection(dev_cnx)
            ElseIf Dev_Or_Pro = False Then
                cnx = New SqlConnection(pro_cnx)
            End If
            cnx.Open()

            Dim x As TemplateInfo = Template

            Dim strINS As String = ""
            x.Body = Replace(x.Body, Chr(39), " ", 1, x.Body.Length - 1, Microsoft.VisualBasic.CompareMethod.Text)
            strINS = "INSERT INTO tblEmailTemplates (Subject,Body,TemplateName,Department) values('" & x.Subject & "','" & x.Body & "','" & x.TemplateName & "','" & x.Department & "');"

            Dim cmdINS As New SqlCommand(strINS, cnx)
            cmdINS.ExecuteScalar()
            cnx.Close()
            cnx = Nothing
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "emlTemplateLogic", "emlTemplateLogic", "Sub", "InsertNewTemplate(template,devorpro)", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Public Sub UpdateBodyOfTemplate(ByVal Dev_Or_Pro As Boolean, ByVal Template_Info As TemplateInfo)
        Try
            Dim cnx As SqlConnection
            If Dev_Or_Pro = True Then
                cnx = New SqlConnection(dev_cnx)
            ElseIf Dev_Or_Pro = False Then
                cnx = New SqlConnection(pro_cnx)
            End If
            cnx.Open()
            Dim strUP As String = "UPDATE tblEmailTemplates" & vbCrLf
            strUP += "SET Body = '" & Template_Info.Body & "'" & vbCrLf
            strUP += "WHERE ID = " & Template_Info.ID & ";"
            Dim cmdUP As New SqlCommand(strUP, cnx)
            cmdUP.ExecuteScalar()
            cnx.Close()
            cnx = Nothing
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "emlTemplateLogic", "emlTemplateLogic", "Sub", "UpdateBodyOfTemplate(devorpro,template_info)", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Public Sub UpdateSubjectOfTemplate(ByVal Dev_Or_Pro As Boolean, ByVal Template_Info As TemplateInfo)
        Try
            Dim cnx As SqlConnection
            If Dev_Or_Pro = True Then
                cnx = New SqlConnection(dev_cnx)
            ElseIf Dev_Or_Pro = False Then
                cnx = New SqlConnection(pro_cnx)
            End If
            cnx.Open()
            Dim strUP As String = "UPDATE tblEmailTemplates" & vbCrLf
            strUP += "SET Subject = '" & Template_Info.Subject & "'" & vbCrLf
            strUP += "WHERE ID = " & Template_Info.ID & ";"
            Dim cmdUP As New SqlCommand(strUP, cnx)
            cmdUP.ExecuteScalar()
            cnx.Close()
            cnx = Nothing
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "emlTemplateLogic", "emlTemplateLogic", "Sub", "UpdateSubjectOfTemplate(devorpro,template_info)", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Public Sub UpdateTemplateName(ByVal Dev_Or_Pro As Boolean, ByVal Template_Info As TemplateInfo)
        Try
            Dim cnx As SqlConnection
            If Dev_Or_Pro = True Then
                cnx = New SqlConnection(dev_cnx)
            ElseIf Dev_Or_Pro = False Then
                cnx = New SqlConnection(pro_cnx)
            End If
            cnx.Open()
            Dim strUP As String = "UPDATE tblEmailTemplates" & vbCrLf
            strUP += "SET TemplateName = '" & Template_Info.TemplateName & "'" & vbCrLf
            strUP += "WHERE ID = " & Template_Info.ID & ";"
            Dim cmdUP As New SqlCommand(strUP, cnx)
            cmdUP.ExecuteScalar()
            cnx.Close()
            cnx = Nothing
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "emlTemplateLogic", "emlTemplateLogic", "Sub", "UpdateTemplateName(devorpro,template_info)", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Public Sub UpdateWholeTemplate(ByVal Dev_Or_Pro As Boolean, ByVal Template_Info As TemplateInfo)
        Try
            Dim cnx As SqlConnection
            If Dev_Or_Pro = True Then
                cnx = New SqlConnection(dev_cnx)
            ElseIf Dev_Or_Pro = False Then
                cnx = New SqlConnection(pro_cnx)
            End If
            cnx.Open()
            Dim strUP As String = "UPDATE tblEmailTemplates" & vbCrLf
            strUP += "SET TemplateName = '" & Template_Info.TemplateName & "'," & vbCrLf
            strUP += "    Subject = '" & Template_Info.Subject & "'," & vbCrLf
            strUP += "    Body = '" & Template_Info.Body & "'," & vbCrLf
            strUP += "    Department = '" & Template_Info.Department & "'"
            strUP += "WHERE TemplateName = '" & Template_Info.TemplateName & "';"
            Dim cmdUP As New SqlCommand(strUP, cnx)
            cmdUP.ExecuteScalar()
            cnx.Close()
            cnx = Nothing
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "emlTemplateLogic", "emlTemplateLogic", "Sub", "UpdateWholeTemplate(devorpro,template_info)", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Public Sub DeleteTemplate(ByVal Dev_Or_Pro As Boolean, ByVal Template_Info As TemplateInfo)
        Try
            Dim cnx As SqlConnection
            If Dev_Or_Pro = True Then
                cnx = New SqlConnection(dev_cnx)
            ElseIf Dev_Or_Pro = False Then
                cnx = New SqlConnection(pro_cnx)
            End If
            cnx.Open()
            Dim cmdDEL As New SqlCommand("DELETE FROM tblEmailTemplates WHERE ID = " & Template_Info.ID & ";", cnx)
            cmdDEL.ExecuteNonQuery()
            cnx.Close()
            cnx = Nothing
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "emlTemplateLogic", "emlTemplateLogic", "Sub", "DeleteTemplate(devorpro,template_info)", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Sub

    Public Function CheckDuplicateTemplateExists(ByVal Dev_Or_Pro As Boolean, ByVal Template_Info As TemplateInfo)
        Try
            Dim Exists As Boolean = False
            Dim cnx As SqlConnection
            If Dev_Or_Pro = True Then
                cnx = New SqlConnection(dev_cnx)
            ElseIf Dev_Or_Pro = False Then
                cnx = New SqlConnection(pro_cnx)
            End If
            cnx.Open()
            Dim cmdCHK As New SqlCommand("select count(ID) from tblEmailTemplates where TemplateName = '" & Template_Info.TemplateName & "';", cnx)
            Dim res As Integer = cmdCHK.ExecuteScalar
            If res <= 0 Then
                Exists = False
            ElseIf res >= 1 Then
                Exists = True
            End If
            cnx.Close()
            cnx = Nothing
            Return Exists
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "emlTemplateLogic", "emlTemplateLogic", "Sub", "CheckDuplicateTemplateExists(devorpro,template_info)", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Function

    Public Function GetEmployeeDepartment(ByVal FName As String, ByVal LName As String, ByVal Dev_Or_Pro As Boolean)
        Try
            Dim name As String = ""
            Dim cnx As SqlConnection
            If Dev_Or_Pro = True Then
                cnx = New SqlConnection(dev_cnx)
            ElseIf Dev_Or_Pro = False Then
                cnx = New SqlConnection(pro_cnx)
            End If
            cnx.Open()
            Dim cmdGET As New SqlCommand("SELECT Department FROM tblTestEmployee WHERE FName like '" & FName & "%' and LName like '" & LName & "%'", cnx)
            name = cmdGET.ExecuteScalar
            cnx.Close()
            cnx = Nothing
            Return name
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "emlTemplateLogic", "emlTemplateLogic", "Function", "GetEmployeeDepartment(Fname,Lname,devorpro)", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Function

    Public Function SubjectScrub(ByVal RecID As String, ByVal Dev_Or_Pro As Boolean, ByVal TemplateName As String, ByVal Department As String)
        Try
            Dim scrubbedText As String = ""
            Dim z As New emlTemplateLogic.TemplateInfo
            Dim rec As convertLeadToStruct.EnterLead_Record
            Dim b As New convertLeadToStruct
            rec = b.ConvertToStructure(RecID, False)
            Dim a As New emlTemplateLogic
            z = a.GetSingleTemplate(TemplateName, False)

            ''  subject tags 
            '' 
            z.Subject = Replace(z.Subject, "<<CustomerName(s)>>", DetermineCustomerName(rec), 1, z.Subject.Length - 1, Microsoft.VisualBasic.CompareMethod.Text)
            z.Subject = Replace(z.Subject, "<<Address>>", rec.StAddress, 1, z.Subject.Length - 1, Microsoft.VisualBasic.CompareMethod.Text)
            z.Subject = Replace(z.Subject, "<<ZipCode>>", rec.Zip, 1, z.Subject.Length - 1, Microsoft.VisualBasic.CompareMethod.Text)
            z.Subject = Replace(z.Subject, "<<MainPhone>>", rec.HousePhone, 1, z.Subject.Length - 1, Microsoft.VisualBasic.CompareMethod.Text)
            z.Subject = Replace(z.Subject, "<<AltPhone1>>", rec.AltPhone1, 1, z.Subject.Length - 1, Microsoft.VisualBasic.CompareMethod.Text)
            z.Subject = Replace(z.Subject, "<<AltPhone2>>", rec.AltPhone2, 1, z.Subject.Length - 1, Microsoft.VisualBasic.CompareMethod.Text)
            z.Subject = Replace(z.Subject, "<<CityState>>", CityStateCorrection(rec), 1, z.Subject.Length - 1, Microsoft.VisualBasic.CompareMethod.Text)
            z.Subject = Replace(z.Subject, "<<Product(s)>>", DetermineProductString(rec), 1, z.Subject.Length - 1, Microsoft.VisualBasic.CompareMethod.Text)
            z.Subject = Replace(z.Subject, "<<SpokeWith>>", rec.SpokeWith, 1, z.Subject.Length - 1, Microsoft.VisualBasic.CompareMethod.Text)
            z.Subject = Replace(z.Subject, "<<ApptDate>>", CorrectApptDate(rec), 1, z.Subject.Length - 1, Microsoft.VisualBasic.CompareMethod.Text)
            z.Subject = Replace(z.Subject, "<<ApptTime>>", CorrectApptTime(rec), 1, z.Subject.Length - 1, Microsoft.VisualBasic.CompareMethod.Text)
            z.Subject = Replace(z.Subject, "<<LastMarketer>>", rec.Marketer, 1, z.Subject.Length - 1, Microsoft.VisualBasic.CompareMethod.Text)
            z.Subject = Replace(z.Subject, "<<Confirmer>>", rec.Confirmer, 1, z.Subject.Length - 1, Microsoft.VisualBasic.CompareMethod.Text)
            z.Subject = Replace(z.Subject, "<<SalesRep>>", CorrectSalesReps(rec), 1, z.Subject.Length - 1, Microsoft.VisualBasic.CompareMethod.Text)
            z.Subject = Replace(z.Subject, "<<CompanyName>>", GetCompanyName(), 1, z.Subject.Length - 1, Microsoft.VisualBasic.CompareMethod.Text)
            z.Subject = Replace(z.Subject, "<<CompanyAddress>>", GetCompanyAddressSingle(), 1, z.Subject.Length - 1, Microsoft.VisualBasic.CompareMethod.Text)
            z.Subject = Replace(z.Subject, "<<CompanyAddressMulti>>", GetCompanyAddressMulti(), 1, z.Subject.Length - 1, Microsoft.VisualBasic.CompareMethod.Text)
            z.Subject = Replace(z.Subject, "<<CompanyPhone>>", GetCompanyPhone(), 1, z.Subject.Length - 1, Microsoft.VisualBasic.CompareMethod.Text)
            z.Subject = Replace(z.Subject, "<<CompanyFax>>", GetCompanyFax(), 1, z.Subject.Length - 1, Microsoft.VisualBasic.CompareMethod.Text)
            z.Subject = Replace(z.Subject, "<<CompanyWebsite>>", GetCompanyWebSite(), 1, z.Subject.Length - 1, Microsoft.VisualBasic.CompareMethod.Text)

            scrubbedText = z.Subject

            Return scrubbedText

        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "emlTemplateLogic", "emlTemplateLogic", "Function", "SubjectScrub(RecID,devorpro,templatename,department)", RecID, ex.Message.ToString)
            y = Nothing
        End Try

    End Function

    Public Function TestTemplateScrub(ByVal RecID As String, ByVal Dev_Or_Pro As Boolean, ByVal TemplateName As String)
        Try
            Dim Scrubbed_TEXT As String = ""

            Dim template_text As String = ""
            Dim z As emlTemplateLogic.TemplateInfo = GetSingleTemplate(TemplateName, False)
            template_text = z.Body
            Dim converter As New convertLeadToStruct
            Dim rec As convertLeadToStruct.EnterLead_Record
            If Len(RecID) >= 1 Then
                '' try to grab the lead, convert it, then onto scrubbing tags.
                rec = converter.ConvertToStructure(RecID, False)
            ElseIf Len(RecID) <= 0 Then
                '' no lead number given , or non-existent lead number
                '' for now, default to first lead in database 
                '' ' 11779'
                '' 
                rec = converter.ConvertToStructure("11779", False)
            End If

            '' valid tags
            '' 
            'InsertValueWhere("<<CustomerName(s)>>")
            template_text = Replace(template_text, "<<CustomerName(s)>>", DetermineCustomerName(rec), 1, template_text.Length - 1, Microsoft.VisualBasic.CompareMethod.Text) & " "
            'InsertValueWhere("<<Address>>")
            template_text = Replace(template_text, "<<Address>>", rec.StAddress, 1, template_text.Length - 1, Microsoft.VisualBasic.CompareMethod.Text) & " "
            'InsertValueWhere("<<ZipCode>>")
            template_text = Replace(template_text, "<<ZipCode>>", rec.Zip, 1, template_text.Length - 1, Microsoft.VisualBasic.CompareMethod.Text) & " "
            'InsertValueWhere("<<MainPhone>>")
            template_text = Replace(template_text, "<<MainPhone>>", rec.HousePhone, 1, template_text.Length - 1, Microsoft.VisualBasic.CompareMethod.Text) & " "
            'InsertValueWhere("<<AltPhone1>>")
            template_text = Replace(template_text, "<<AltPhone1>>", rec.AltPhone1, 1, template_text.Length - 1, Microsoft.VisualBasic.CompareMethod.Text) & " "
            'InsertValueWhere("<<AltPhone2>>")
            template_text = Replace(template_text, "<<AltPhone2>>", rec.AltPhone2, 1, template_text.Length - 1, Microsoft.VisualBasic.CompareMethod.Text) & " "
            'InsertValueWhere("<<CityState>>") 
            template_text = Replace(template_text, "<<CityState>>", CityStateCorrection(rec), 1, template_text.Length - 1, Microsoft.VisualBasic.CompareMethod.Text) & " "
            'InsertValueWhere("<<Product(s)>>")
            template_text = Replace(template_text, "<<Product(s)>>", DetermineProductString(rec), 1, template_text.Length - 1, Microsoft.VisualBasic.CompareMethod.Text) & " "
            'InsertValueWhere("<<SpokeWith>>")
            template_text = Replace(template_text, "<<SpokeWith>>", rec.SpokeWith, 1, template_text.Length - 1, Microsoft.VisualBasic.CompareMethod.Text) & " "
            'InsertValueWhere("<<ApptDate>>")
            template_text = Replace(template_text, "<<ApptDate>>", CorrectApptDate(rec), 1, template_text.Length - 1, Microsoft.VisualBasic.CompareMethod.Text) & " "
            'InsertValueWhere("<<ApptTime>>")
            template_text = Replace(template_text, "<<ApptTime>>", CorrectApptTime(rec), 1, template_text.Length - 1, Microsoft.VisualBasic.CompareMethod.Text) & " "
            'InsertValueWhere("<<LastMarketer>>")
            template_text = Replace(template_text, "<<LastMarketer>>", rec.Marketer, 1, template_text.Length - 1, Microsoft.VisualBasic.CompareMethod.Text) & " "
            'InsertValueWhere("<<Confirmer>>")
            template_text = Replace(template_text, "<<Confirmer>>", rec.Confirmer, 1, template_text.Length - 1, Microsoft.VisualBasic.CompareMethod.Text) & " "
            'InsertValueWhere("<<SalesRep>>")
            template_text = Replace(template_text, "<<SalesRep>>", CorrectSalesReps(rec), 1, template_text.Length - 1, Microsoft.VisualBasic.CompareMethod.Text) & " "
            'InsertValueWhere("<<CompanyName>>")
            template_text = Replace(template_text, "<<CompanyName>>", GetCompanyName(), 1, template_text.Length - 1, Microsoft.VisualBasic.CompareMethod.Text) & " "
            'InsertValueWhere("<<CompanyAddress>>")
            template_text = Replace(template_text, "<<CompanyAddress>>", GetCompanyAddressSingle(), 1, template_text.Length - 1, Microsoft.VisualBasic.CompareMethod.Text) & " "
            'InsertValueWhere("<<CompanyAddressMulti>>")
            template_text = Replace(template_text, "<<CompanyAddressMulti>>", GetCompanyAddressMulti(), 1, template_text.Length - 1, Microsoft.VisualBasic.CompareMethod.Text) & " "
            'InsertValueWhere("<<CompanyPhone>>")
            template_text = Replace(template_text, "<<CompanyPhone>>", GetCompanyPhone(), 1, template_text.Length - 1, Microsoft.VisualBasic.CompareMethod.Text) & " "
            'InsertValueWhere("<<CompanyFax>>")
            template_text = Replace(template_text, "<<CompanyFax>>", GetCompanyFax(), 1, template_text.Length - 1, Microsoft.VisualBasic.CompareMethod.Text) & " "
            'InsertValueWhere("<<CompanyWebsite>>")
            template_text = Replace(template_text, "<<CompanyWebsite>>", GetCompanyWebSite(), 1, template_text.Length - 1, Microsoft.VisualBasic.CompareMethod.Text) & " "

            Return template_text
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "emlTemplateLogic", "emlTemplateLogic", "Function", "TestTemplateScrub(recID,templatename,depart)", RecID, ex.Message.ToString)
            y = Nothing
        End Try

    End Function



    Private Function FormatPhone(ByVal TextToFormat As String)
        Dim ret_str As String = ""
        ret_str = String.Format(TextToFormat, "(###) ###-####")
        Return ret_str
    End Function


    Private Function GetCompanyWebSite()
        Try
            Dim ret_str As String = ""
            Dim cnx As New SqlConnection(pro_cnx)
            cnx.Open()
            Dim cmdGET As New SqlCommand("SELECT * FROM CompanyInfo;", cnx)
            Dim r1 As SqlDataReader = cmdGET.ExecuteReader
            Dim y As New CompanyInfo
            While r1.Read
                y.StreetName = r1.Item("StreetName")
                y.AddressLine2 = r1.Item("AddressLine2")
                y.City = r1.Item("City")
                y.State = r1.Item("State")
                y.Zip = r1.Item("Zip")
                y.CompanyName = r1.Item("CompanyName")
                y.CompanyWebSite = r1.Item("CompanyWebsite")
                y.ContactFaxNumber = r1.Item("ContactFaxNumber")
                y.ContactPhoneNumber = r1.Item("ContactPhoneNumber")
                y.LogoDirectory = r1.Item("LogoDirectory")
            End While
            cnx.Close()
            cnx = Nothing
            ret_str = (y.CompanyWebSite)
            Return ret_str
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "emlTemplateLogic", "emlTemplateLogic", "Function", "GetCompanyWebSite()", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Function
    Private Function GetCompanyFax()
        Try
            Dim ret_str As String = ""
            Dim cnx As New SqlConnection(pro_cnx)
            cnx.Open()
            Dim cmdGET As New SqlCommand("SELECT * FROM CompanyInfo;", cnx)
            Dim r1 As SqlDataReader = cmdGET.ExecuteReader
            Dim y As New CompanyInfo
            While r1.Read
                y.StreetName = r1.Item("StreetName")
                y.AddressLine2 = r1.Item("AddressLine2")
                y.City = r1.Item("City")
                y.State = r1.Item("State")
                y.Zip = r1.Item("Zip")
                y.CompanyName = r1.Item("CompanyName")
                y.CompanyWebSite = r1.Item("CompanyWebsite")
                y.ContactFaxNumber = r1.Item("ContactFaxNumber")
                y.ContactPhoneNumber = r1.Item("ContactPhoneNumber")
                y.LogoDirectory = r1.Item("LogoDirectory")
            End While
            cnx.Close()
            cnx = Nothing
            ret_str = (y.ContactFaxNumber)
            Return ret_str
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "emlTemplateLogic", "emlTemplateLogic", "Function", "GetCompanyfax()", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Function
    Private Function GetCompanyPhone()
        Try
            Dim ret_str As String = ""
            Dim cnx As New SqlConnection(pro_cnx)
            cnx.Open()
            Dim cmdGET As New SqlCommand("SELECT * FROM CompanyInfo;", cnx)
            Dim r1 As SqlDataReader = cmdGET.ExecuteReader
            Dim y As New CompanyInfo
            While r1.Read
                y.StreetName = r1.Item("StreetName")
                y.AddressLine2 = r1.Item("AddressLine2")
                y.City = r1.Item("City")
                y.State = r1.Item("State")
                y.Zip = r1.Item("Zip")
                y.CompanyName = r1.Item("CompanyName")
                y.CompanyWebSite = r1.Item("CompanyWebsite")
                y.ContactFaxNumber = r1.Item("ContactFaxNumber")
                y.ContactPhoneNumber = r1.Item("ContactPhoneNumber")
                y.LogoDirectory = r1.Item("LogoDirectory")
            End While
            cnx.Close()
            cnx = Nothing
            ret_str = (y.ContactPhoneNumber)
            Return ret_str
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "emlTemplateLogic", "emlTemplateLogic", "Function", "GetCompanyPhone()", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Function

    Private Function GetCompanyAddressMulti()
        Try
            Dim ret_str As String = ""
            Dim cnx As New SqlConnection(pro_cnx)
            cnx.Open()
            Dim cmdGET As New SqlCommand("SELECT StreetName,AddressLine2,City,State,Zip FROM CompanyInfo;", cnx)
            Dim r1 As SqlDataReader = cmdGET.ExecuteReader
            Dim y As New CompanyInfo
            While r1.Read
                y.StreetName = r1.Item("StreetName")
                y.AddressLine2 = r1.Item("AddressLine2")
                y.City = r1.Item("City")
                y.State = r1.Item("State")
                y.Zip = r1.Item("Zip")
            End While
            cnx.Close()
            cnx = Nothing
            ret_str = (y.StreetName & vbCrLf & y.AddressLine2 & vbCrLf & y.City & ", " & y.State & " " & y.Zip)
            Return ret_str
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "emlTemplateLogic", "emlTemplateLogic", "Function", "GetCompanyAddressMulti()", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Function

    Private Function GetCompanyAddressSingle()
        Try
            Dim ret_str As String = ""
            Dim cnx As New SqlConnection(pro_cnx)
            cnx.Open()
            Dim cmdGET As New SqlCommand("SELECT StreetName,AddressLine2,City,State,Zip FROM CompanyInfo;", cnx)
            Dim r1 As SqlDataReader = cmdGET.ExecuteReader
            Dim y As New CompanyInfo
            While r1.Read
                y.StreetName = r1.Item("StreetName")
                y.AddressLine2 = r1.Item("AddressLine2")
                y.City = r1.Item("City")
                y.State = r1.Item("State")
                y.Zip = r1.Item("Zip")
            End While
            cnx.Close()
            cnx = Nothing
            ret_str = (y.StreetName & " " & y.AddressLine2 & " " & y.City & ", " & y.State & " " & y.Zip)
            Return ret_str
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "emlTemplateLogic", "emlTemplateLogic", "Function", "GetCompanyAddressSingle()", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Function


    Private Function GetCompanyName()
        Try
            Dim ret_str As String = ""
            Dim cnx As New SqlConnection(pro_cnx)
            cnx.Open()
            Dim cmdGET As New SqlCommand("SELECT CompanyName from companyinfo;", cnx)
            ret_str = cmdGET.ExecuteScalar
            cnx.Close()
            cnx = Nothing
            Return ret_str
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "emlTemplateLogic", "emlTemplateLogic", "Function", "GetCompanyName()", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Function


    Private Function CorrectSalesReps(ByVal objLead As convertLeadToStruct.EnterLead_Record)
        Try
            Dim ret_str As String = ""
            '' r1 and r2 
            If Len(objLead.Rep1) >= 1 And Len(objLead.Rep2) >= 1 Then
                ret_str = (objLead.Rep1 & " and " & objLead.Rep2)
                '' r1 only
            ElseIf Len(objLead.Rep1) >= 1 And Len(objLead.Rep2) <= 0 Then
                ret_str = objLead.Rep1
                '' r2 only
            ElseIf Len(objLead.Rep1) <= 0 And Len(objLead.Rep2) >= 1 Then
                ret_str = objLead.Rep2
            End If

            Return ret_str
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "emlTemplateLogic", "emlTemplateLogic", "Function", "CorrectSalesReps(objlead)", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Function

    Private Function CorrectApptTime(ByVal objLead As convertLeadToStruct.EnterLead_Record)
        Try
            Dim ret_str As Date = "#" & objLead.ApptTime & "#"
            Dim hour As String = ret_str.Hour
            Dim miute As String = ret_str.Minute
            Dim amPM As String = ""
            If hour < 12 Then
                amPM = "AM"
            ElseIf hour > 12 Then
                hour = (hour - 12).ToString
                amPM = "PM"
            End If

            Dim returnString As String = hour & ":00 " & amPM
            Return returnString
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "emlTemplateLogic", "emlTemplateLogic", "Function", "CorrectApptTime(objlead)", "0", ex.Message.ToString)
            y = Nothing
        End Try

        ' ''1900-01-01 11:00:00.000 as it comes out of dbase 
        ' '' MILTARY TIME
        ' '' 
        'Dim sp1() = Split(objLead.ApptTime, " ", -1, Microsoft.VisualBasic.CompareMethod.Text)
        ' '' should be two pieces.
        ' '' 
        'Dim sp2() = Split(sp1(1), ":", -1, Microsoft.VisualBasic.CompareMethod.Text)
        ' '' should be 3 pieces.
        ' '' 
        'Dim Hour As String = ""
        'Dim minute As String = ""
        'Hour = sp2(0)
        'minute = sp2(1)
        'Dim AMPM As String = ""


        'ret_str = (Hour & ":" & minute & " " & AMPM)
        'Return ret_str
    End Function

    Private Function CorrectApptDate(ByVal objLead As convertLeadToStruct.EnterLead_Record)
        Try
            Dim ret_str As String = ""
            ''2015-10-23 00:00:00.000  as it comes out of dbase.
            '' 
            Dim dateSP() = Split(objLead.ApptDate, " ", -1, Microsoft.VisualBasic.CompareMethod.Text)
            '' should be 2 pieces.
            '' 
            Dim split2() = Split(dateSP(0), "-", -1, Microsoft.VisualBasic.CompareMethod.Text)
            '' should be 3 pieces.
            '' 
            '' YEAR | MONTH | DAY
            '' (0)     (1)    (2) 
            '' 
            Dim dt As String = split2(0)

            ret_str = (dt)

            Return ret_str
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "emlTemplateLogic", "emlTemplateLogic", "Function", "CorrectApptDate(objleaD)", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Function

    Private Function DetermineCustomerName(ByVal objLead As convertLeadToStruct.EnterLead_Record)
        Try
            Dim return_string As String = ""

            '' c1fname and c2 fnames not blank | BOTH FIRST NAMES
            If objLead.C1FirstName <> "" And objLead.C2FirstName <> "" Then
                return_string = objLead.C1FirstName & " and " & objLead.C2FirstName & " " & objLead.C1LastName
            End If
            '' c1fname not blank and c2 fname blank | c1 FNAME ONLY
            If objLead.C1FirstName <> "" And objLead.C2FirstName = "" Then
                return_string = objLead.C1FirstName & " " & objLead.C1LastName
            End If

            '' c1fname blank and c2 fname not blank | c2 FNAME ONLY
            If objLead.C1FirstName = "" And objLead.C2FirstName <> "" Then
                return_string = objLead.C2FirstName & " " & objLead.C2LastName
            End If
            Return return_string
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "emlTemplateLogic", "emlTemplateLogic", "Function", "DetermineCustomerName(objlead)", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Function

    Private Function CityStateCorrection(ByVal objLead As convertLeadToStruct.EnterLead_Record)
        Try
            Dim return_string As String = ""
            return_string = objLead.City & ", " & objLead.State
            Return return_string
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "emlTemplateLogic", "emlTemplateLogic", "Function", "CityStateCorrection(objlead)", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Function

    Private Function DetermineProductString(ByVal objlead As convertLeadToStruct.EnterLead_Record)
        Try
            Dim return_str As String = ""
            '' all three products
            If Len(objlead.Product1) >= 1 And Len(objlead.Product2) >= 1 And Len(objlead.Product3) >= 1 Then
                return_str = (objlead.Product1 & ", " & objlead.Product2 & " and " & objlead.Product3)
                '' p1 and p2 only
            ElseIf Len(objlead.Product1) >= 1 And Len(objlead.Product2) >= 1 And Len(objlead.Product3) <= 0 Then
                return_str = (objlead.Product1 & " and " & objlead.Product2)
                '' p1 only 
            ElseIf Len(objlead.Product1) >= 1 And Len(objlead.Product2) <= 0 And Len(objlead.Product3) <= 0 Then
                return_str = objlead.Product1
                '' p1 and p3
            ElseIf Len(objlead.Product1) >= 1 And Len(objlead.Product3) >= 1 And Len(objlead.Product2) <= 0 Then
                return_str = (objlead.Product1 & " and " & objlead.Product3)
                '' p2 only
            ElseIf Len(objlead.Product1) <= 0 And Len(objlead.Product2) >= 1 And Len(objlead.Product3) <= 0 Then
                return_str = objlead.Product2
                '' p3 only
            ElseIf Len(objlead.Product1) <= 0 And Len(objlead.Product2) <= 0 And Len(objlead.Product3) >= 1 Then
                return_str = objlead.Product3
                '' p2 and p3
            ElseIf Len(objlead.Product1) <= 0 And Len(objlead.Product2) >= 1 And Len(objlead.Product1) >= 1 Then
                return_str = (objlead.Product2 & " and " & objlead.Product3)
            End If
            Return return_str
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "emlTemplateLogic", "emlTemplateLogic", "Function", "DetermineProductString(objlead)", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Function
#Region "TEST FORM SUBS AND FUNCS"
    Public Function GetTemplates(ByVal Dev_Or_Pro As Boolean)
        Try
            Dim cnx As SqlConnection
            If Dev_Or_Pro = True Then
                cnx = New SqlConnection(dev_cnx)
            ElseIf Dev_Or_Pro = False Then
                cnx = New SqlConnection(pro_cnx)
            End If
            cnx.Open()
            Dim cmdGET As New SqlCommand("SELECT * from tblEmailTemplates;", cnx)
            Dim r1 As SqlDataReader = cmdGET.ExecuteReader
            Dim arTemplates As New List(Of emlTemplateLogic.TemplateInfo)
            While r1.Read
                Dim z As New emlTemplateLogic.TemplateInfo
                z.ID = r1.Item("ID")
                z.Subject = r1.Item("Subject")
                z.Body = r1.Item("Body")
                z.TemplateName = r1.Item("TemplateName")
                z.Department = r1.Item("Department")
                arTemplates.Add(z)
            End While
            r1.Close()
            cnx.Close()
            cnx = Nothing
            Return arTemplates
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "emlTemplateLogic", "emlTemplateLogic", "Function", "GetTemplates(devorpro)", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Function
#End Region
End Class
