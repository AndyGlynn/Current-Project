Imports System.Text
Imports System.IO
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class createListPrintOperations


#Region "Structures For 'Lists' "

    Public Structure LeadToPrint ''DEFAULT
        Public ID As String
        Public FName As String
        Public LName As String
        Public FName2 As String
        Public LName2 As String
        Public StAddress As String
        Public City As String
        Public State As String
        Public Zip As String
        Public Phone1 As String
        Public Phone2 As String
        Public Phone3 As String
        Public Prod1 As String
        Public Prod2 As String
        Public Prod3 As String
        Public LeadGeneratedOn As String
        Public ApptDate As String
        Public ApptTime As String
        Public ApptDay As String
        Public Result As String
        Public MarketingResults As String
        Public IsPreviousCustomer As String
        Public IsRecovery As String
        Public Marketer As String '' added 4-1-2016 for Order By Clause
    End Structure

    Public Structure PCInfoToPrint '' in the instance that a previous sale exists for LeadNumber this is the additional info that needs to be pulled 
        Public recID As String
        Public LeadNum As String
        Public LeadHistoryID As String
        Public JobCloseDate As String
        Public ContractAmount As String
        Public Cash As Boolean
        Public Finance As Boolean
        Public Product1 As String
        Public Product2 As String
        Public Product3 As String
    End Structure

    Private Structure Render_Info_Struct
        Public ID As String
        Public Obj As LeadToPrint
        Public Group As String
    End Structure

    Private Structure List_Of_Groups
        Public Group As String
        Public Obj As Render_Info_Struct
    End Structure

#End Region


#Region "Vars"

    Public arListOfLeadsToDisplay As List(Of LeadToPrint)

    Private Const sql_cnx As String = "SERVER=192.168.1.2;DATABASE=ISS;User Id=sa;Password=spoken1;"
    Private Const Test_Directory As String = "C:\Users\Clay\Desktop\Print Leads\"
    Private Const Production_Directory As String = "\\server.greenworks.local\Company\ISS\Print Leads\"
#End Region

#Region "Constructor"
    Public Sub New()
        arListOfLeadsToDisplay = New List(Of LeadToPrint)
    End Sub
#End Region


#Region "Notes: 3-24-2016"
    '' Notes: 3-24-2016
    '' Merge code: Objective=> Split off Warm Calling List and recovery
    '' for two separate lists
    '' Per Request Of AG

    'New General Flow: 3-22-2016
    '-----------------
    'Determine what Criteria is selected. 
    'Determine if Warm Calling is selected.
    'Determine if Recovery is selected.

    'Generate Default Criteria HTML Render

    'If WarmCalling criteria is selected Generate Warm Calling HTML Render

    'if Recovery criteria is selected Generate Recovery HTML Render

    'Display Default HTML Page
    'If warmcalling is there as well, create target='_blank' page for Warm calling List
    'If recovery is there as well, create target='_blank' page for Recovery List 

#End Region
#Region "Notes 3-30-2016"
    '' 
    '' Per AG, now we need to not 'Mash' up lists anymore
    '' just take one list per form that calls it.
    '' also, need a way to display 'headings' per 
    '' group  IF  'group by' selected
    '' 
    '' Also, no cross referencing sales for nested rows. 
    '' 
    '' keeping 'legacy' methods just for shits and giggles.
    '' 


#End Region
#Region "General Notes"
    ''10-7-2015
    ''
    '' 5 structures needed
    ''
    '' DEFAULT = Select Distinct(Enterlead.ID), Contact1LastName, Contact1FirstName, Contact2LastName, Contact2FirstName, StAddress, City, State, Zip, HousePhone, AltPhone1, AltPhone2, Enterlead.Product1, Enterlead.Product2, Enterlead.Product3, LeadGeneratedOn, ApptDate, ApptDay, ApptTime, Result, MarketingResults, IsPreviousCustomer, IsRecovery

    '' 1) for DEFAULT (no order by selected)
    ''    a) no extra info needed
    ''    i) DEFAULT OBJ

    '' 2) ORDER BY: Reference Rating 
    ''    b) col: ReferenceRating
    ''    ii) DEFAULT + col

    '' 3) ORDER BY: Sale Closed Date
    ''    c) col: JobClosed
    ''    iii) DEFAULT + col

    '' 4) ORDER BY: Loan Satisfied Date
    ''    d) col: ExpectedPayOff
    ''   iv) DEFAULT + col

    '' 5) ORDER BY: Approved Load Amount
    ''    e) col: ApprovedFor
    ''    v) DEFAULT + col

    '' idea 1 
    '' Use a Hash Table For Key:Value Pairs  || DONT KNOW IF YOU CAN STORE an arraylist as a 'value' in hash table
    '' MSDN Ref: https://msdn.microsoft.com/en-us/library/system.collections.hashtable(v=vs.110).aspx
    '' MSDN Ref: https://msdn.microsoft.com/en-us/library/system.collections.hashtable.add(v=vs.110).aspx   -> Outlining key and value as OBJECTS
    '' Framework 4 Supports this Method
    '' according to MSDN,    ADD(object,object)  method can use 'object' type when storing either keys or values.
    '' 
    '' 
    '' example  entry1 = Key "List(of type default)" : value = arLstOfDefaultObjs as arraylist housing DEFAULT Structs
    ''          entry2 = Key "List(of type ReferenceRating)" : value = arLstOfRefRating as arraylist housing RefRating Structs
    '' 

    '' When pulling out the 'value' from hastable, should be able to use 'if typeOf ' for a decission struture / select case to know what type of object to expect from return / expression
    '' 

    '' idea 2 || Lengthy work , has to be a better way.
    '' Write a seperate Sub for each type then, depending on what was selected for ORDER BY use respective Sub
    '' 

    '' idea3 || Generic defined Multi-Dim array  arObjects(0,0)   first ordinal = description  ie: 'list of reference rating type' | second ordinal = List(of ReferenceRating) 
    '' 
    '' 

    '' 10-8-2015
    '' hash table idea works, but after more consideration:
    '' all irrelevant ideas. The fields are always the same as defined in the query the only thing that is really changing is the criteria which we don't have to render.
    '' just pass the (slct) string to a method to run query, grab results, then render. 
    '' So, just one structure : DEFAULT
    '' 

#End Region




#Region "Warm Calling List Generation - Grouped / Non Grouped"

    Public Sub CreateWireFrameHTML_WarmCalling(ByVal QueryString As String, ByVal Grouped As Boolean, ByVal GroupHeading As ArrayList, ByVal HeadingData_QRY As String)
        '' list a heading depeding on group
        '' 
        '' [Example] 
        '' 
        '' heading
        ''-------------------
        '' Row item x
        ''   --Sub Item a
        '' Row item y
        '' Row item z
        ''   --Sub Item b
        '' 
        '' heading
        '' ------------------
        '' Row item x
        '' Row item y 
        '' Row item z
        '' 
        ''

        '' two queries:
        '' one) subquery to get Unique [order by] field => For headers on HTML doc
        '' Example:
        '' 
        '' 
        'select distinct(City), State FROM (
        'Select Distinct(Enterlead.ID), Contact1LastName, Contact1FirstName, Contact2LastName, Contact2FirstName, StAddress, City, State, Zip, HousePhone, AltPhone1, AltPhone2, Enterlead.Product1, Enterlead.Product2, Enterlead.Product3, LeadGeneratedOn, ApptDate, ApptDay, ApptTime, MarketingResults  From Enterlead join tblWhereCanLeadGo on enterlead.id = tblWhereCanLeadGo.LeadNumber 
        'Where (LeadGeneratedOn >= '1/1/2009 12:00:00 AM' and ApptDate Between '1/1/2010 12:00:00 AM' and '4/1/2016 12:00:00 AM' and ApptTime Between '1/1/1900 11:00:00 AM' And '1/1/1900 7:00:00 PM' and ApptDay <> 'Saturday' and ApptDay <> 'Sunday' and (Zip = '43542' or Zip = '43528' or Zip = '43537' or Zip = '43615' or Zip = '43504' or Zip = '49276' or Zip = '43617' or Zip = '43560' or Zip = '43560' or Zip = '49267' or Zip = '43614' or Zip = '43607' or Zip = '43609' or Zip = '43623' or Zip = '43606' or Zip = '43613' or Zip = '48144' or Zip = '48144' or Zip = '43620' or Zip = '43610' or Zip = '43612') and tblWhereCanLeadGo.WarmCall = 'True') 
        ') AS SUBQUERY
        '' Produces: List of Unique Cities WHERE "Group By" Selected for "City,State"
        '' 
        '' two) the result set of the encompassing query => Actual Rows of data
        '' Produces: The result set of the Initial Criteria {Data Rows} 
        ''

        Try

            frmWCList.Cursor = Cursors.WaitCursor


            arListOfLeadsToDisplay = GrabRowsForHTML(QueryString)
            Dim recCNT As Integer = 0
            recCNT = arListOfLeadsToDisplay.Count
            Dim arHeadingData As New Hashtable
            arHeadingData = GrabUniqueHeadings(HeadingData_QRY)
            Dim g As DictionaryEntry
            Dim target_column As String = ""
            Dim target_headings As New ArrayList
            For Each g In arHeadingData '' should only be one entry here.
                target_column = g.Key
                target_headings = g.Value
            Next
            Dim guid As Guid = guid.NewGuid
            Dim dateTime As String = Date.Now
            Dim ext As String = ".htm"

            Dim doc As String = "" '' var for ENTIRE html doc after built and to write to disk once complete

            'Dim style As String = "<style type='text/css'>.elem1{font-family:""Verdana"",sans-serif;font-size:1.2em;color:blue;}.fancyTable{position:fixed;left:2em;top:3em;padding:2px;margin:3px;text-align:center;"
            'style = style + "border-right-style:solid;border-right-width:1px;border-right-color:black;box-shadow:2px 2px 2px grey;border-collapse: collapse;}"
            'style = style + "th{padding:3px;border-bottom-style:solid;border-bottom-color:black;border-bottom-width:1px;border-right-style:solid;border-right-color:grey;border-right-width:1px;"
            'style = style + "background-color:hsl(30,75%,74%);color:hsl(30,100%,33%);font-family:""Verdana"",sans-serif;font-size:1.1em;}"
            'style = style + "td{padding:3px;font-family:""Verdana"",sans-serif;font-size:0.7em;}"
            'style = style + "tr:nth-child(even){background-color:hsl(30,100%,94%);}tr:nth-child(odd){background-color:hsl(30,100%,80%);}"
            'style = style + "</style>"

            Dim title As String = "<title>Create List For Warm Calling -" & Date.Today.ToShortDateString & "</title>"

            Dim style As String = "<style type='text/css'>" & vbCrLf
            style += "span.data {font-family:""Verdana"",sans-serif;font-size:1.3em;color:black;}" & vbCrLf
            style += ".elem1 {font-family:""Verdana"",sans-serif;color:blue;font-size:1.3em;}" & vbCrLf
            style += ".tbl {font-family:""Verdana"",sans-serif;color:black;border-collapse:collapse;margin:5px;box-shadow:2px 2px 2px grey;}" & vbCrLf
            style += "tr {padding:3px;border-bottom-width:1px;border-bottom-color:black;border-style:solid;border-top-width:0px;border-right-width:0px;border-left-width:0px;}" & vbCrLf
            style += "tr:nth-child(odd) {background-color:white;}" & vbCrLf
            style += "tr:nth-child(even) {background-color:hsl(0,0%,90%);}" & vbCrLf
            style += "th {font-family:""Verdana"",sans-serif;font-size:1.1em;color:black;padding:3px;text-align:center;background-color:hsl(0,0%,80%);}" & vbCrLf
            style += "th.lg {font-family:""Verdana"",sans-serif;font-size:1.2em;font-weight:bold;color:black;padding:3px;text-align:center;background-color:white;text-align:left;}"
            style += "td {font-family:""Verdana"",sans-serif;font-size:0.8em;padding:7px;text-align:center;}" & vbCrLf
            style += "tr.sale {font-family:""Verdana"",sans-serif;font-weight:normal;font-size:1em;background-color:hsl(120,100%,75%);}" & vbCrLf
            style += "@media print { span.data {display:none;} tr:nth-child(even){background-color:white;}tr:nth-child(odd){background-color:white;}" & vbCrLf
            style += "tr.sale{background-color:white;font-size:0.8em;}th{font-size:0.7em;}td{font-size:0.5em;}.tbl{box-shadow:0px 0px 0px white;} @page{size:landscape;}}" & vbCrLf
            style += "</style>"


            Dim jScript As String = "<script type='text/javascript'></script>"



            doc += "<!DOCTYPE html>" & vbCrLf
            doc += "<head>" & vbCrLf
            doc += "<meta charset=""UTF-8"">" & vbCrLf
            doc += "" & title & "" & vbCrLf
            doc += "" & style & "" & vbCrLf
            doc += "" & jScript & "" & vbCrLf
            doc += " " & vbCrLf
            doc += " " & vbCrLf
            doc += "<!-- AUTO GENERATED CODE FOR: " & Date.Now.ToString & " -->" & vbCrLf
            doc += "<!-- Header Query: " & vbCrLf
            doc += "" & HeadingData_QRY.ToString & " -->" & vbCrLf
            doc += " " & vbCrLf
            doc += " " & vbCrLf
            doc += "<!-- Query ACTUAL: " & vbCrLf
            doc += "" & QueryString.ToString & " -->"
            doc += " " & vbCrLf
            doc += " " & vbCrLf
            doc += "</head>" & vbCrLf
            doc += "<body>" & vbCrLf
            doc += "<span id='elem1' class='elem1'>Warm Calling List - " & recCNT.ToString & " Item(s)  [ " & target_column & " ] Grouping Applied </span>" & vbCrLf
            doc += "<br /><br />" & vbCrLf
            doc += "<table id='tbDat' class='tbl'>" & vbCrLf
            doc += "<tr><th></th><th>ID</th><th>Name(s)</th><th>Address</th><th width=""215"" >Phone(s)</th><th>Product(s)</th><th>Gen. On</th><th>Appt. Date</th><th>Appt. Time</th><th>Result</th></tr>" & vbCrLf
            '' 
            '' Appt Date. Header Dropped.
            '' 

            '' for each 'Heading' determine if the lead.field is = to heading , if it is=> put row 'under heading'
            '' if it isnt => do nothing with it

            Dim arFilteredRows As New ArrayList

            Dim hashGroups As New Hashtable
            'For Each xx As LeadToPrint In arListOfLeadsToDisplay


            Select Case target_column
                Case Is = "City"
                    For Each y As String In target_headings
                        '' sort leads by 'heading'
                        Dim arObjs As New List(Of LeadToPrint)
                        For Each xyz As LeadToPrint In arListOfLeadsToDisplay
                            If xyz.City = y Then
                                arObjs.Add(xyz)
                            End If
                        Next
                        Try
                            hashGroups.Add(y, arObjs)
                        Catch ex As Exception

                        End Try
                    Next


                    '' now break sorted list apart and render according per 'group'

                    For Each d As DictionaryEntry In hashGroups
                        Dim arObjss As New List(Of LeadToPrint)
                        arObjss = d.Value
                        Dim cnt_Local As Integer = arObjss.Count
                        Dim Item0 As LeadToPrint = arObjss(0)
                        Dim hdrSTR As String = "<!-- BEGIN ROW Group Heading --><tr><td colspan=""11"" style='font-family:""Verdana"",sans-serif;font-size:0.8em;font-weight:bold;text-align:left;'><em>" & d.Key & ", " & Item0.State & " - [" & cnt_Local & " Items]  </em></td></tr><!-- END ROW Group Heading -->"
                        Item0 = Nothing
                        doc += hdrSTR

                        For Each obj As LeadToPrint In arObjss

                            Dim rowData As String = ""

                            Dim timeSplit() = Split(obj.ApptTime, " ", 2)
                            Dim apptTime As String = splitTime(timeSplit(1).ToString)
                            Dim LeadGenSplit() = Split(obj.LeadGeneratedOn, " ", 2)

                            Dim leadGen As String = LeadGenSplit(0)
                            Dim recID As String = obj.ID
                            Dim prodString = (obj.Prod1 & "<br />" & obj.Prod2 & "<br />" & obj.Prod3)
                            '' type the phones only phone 2 & three if present
                            Dim arPhoneType(1)
                            arPhoneType = Get_Phone_Type(obj.ID)
                            Dim phone1Type As String = arPhoneType(0)
                            Dim phone2Type As String = arPhoneType(1)

                            If Len(phone1Type) > 1 = True Then
                                If phone1Type <> "" Then
                                    If phone1Type <> " " Then
                                        arPhoneType(0) = " - " & phone1Type
                                    End If
                                End If
                            End If

                            If Len(phone2Type) > 1 = True Then
                                If phone1Type <> "" Then
                                    If phone1Type <> " " Then
                                        arPhoneType(1) = " - " & phone2Type
                                    End If
                                End If
                            End If

                            Dim PhoneString = (obj.Phone1 & "<br />" & obj.Phone2 & " " & arPhoneType(0) & "<br />" & obj.Phone3 & " " & arPhoneType(1) & "<br />")
                            Dim AddyString = (obj.StAddress & " " & obj.City & ", " & obj.State & " " & obj.Zip)
                            Dim nameStr As String = (obj.FName & " " & obj.LName & "<br />" & obj.FName2 & " " & obj.LName2)

                            rowData = "<!--BEGIN ROW Group Data--><tr><td></td><td>" & obj.ID & "</td>"
                            rowData += "<td>" & nameStr & "</td>"
                            rowData += "<td>" & AddyString & "</td>"
                            rowData += "<td>" & PhoneString & "</td>"
                            rowData += "<td>" & prodString & "</td>"
                            rowData += "<td>" & leadGen & "</td>"
                            rowData += "<td>" & obj.ApptDate & "</td>"
                            'rowData += "<td></td>"
                            rowData += "<td>" & apptTime & "</td>"
                            rowData += "<td>" & obj.Result & "</td></tr><!-- END ROW Group Data-->"
                            '' now, does this lead have any Previous sales or what not? => dropping this per AG "No mash up lists"
                            doc += (rowData & vbCrLf)
                            rowData = ""
                        Next '' end each obj in arobjs

                    Next '' end each dictionary entry 

                    doc += "</table></body></html>" '' put the end cap on it. . . 
                    Exit Select '' end city state catch
                Case Is = "Zip"
                    For Each y As String In target_headings
                        '' sort leads by 'heading'
                        Dim arObjs As New List(Of LeadToPrint)
                        For Each xyz As LeadToPrint In arListOfLeadsToDisplay
                            If xyz.Zip = y Then
                                arObjs.Add(xyz)
                            End If
                        Next
                        Try
                            hashGroups.Add(y, arObjs)
                        Catch ex As Exception

                        End Try
                    Next


                    '' now break sorted list apart and render according per 'group'

                    For Each d As DictionaryEntry In hashGroups
                        Dim arObjss As New List(Of LeadToPrint)
                        arObjss = d.Value
                        Dim cnt_Local As Integer = arObjss.Count
                        Dim Item0 As LeadToPrint = arObjss(0)
                        Dim hdrSTR As String = "<!-- BEGIN ROW Group Heading --><tr><td colspan=""11"" style='font-family:""Verdana"",sans-serif;font-size:0.8em;font-weight:bold;text-align:left;'><em>" & d.Key & "  [" & Item0.State & "] - [" & cnt_Local & " Items] </em></td></tr><!-- END ROW Group Heading -->"
                        Item0 = Nothing
                        doc += hdrSTR

                        For Each obj As LeadToPrint In arObjss

                            Dim rowData As String = ""

                            Dim timeSplit() = Split(obj.ApptTime, " ", 2)
                            Dim apptTime As String = splitTime(timeSplit(1).ToString)
                            Dim LeadGenSplit() = Split(obj.LeadGeneratedOn, " ", 2)

                            Dim leadGen As String = LeadGenSplit(0)
                            Dim recID As String = obj.ID
                            Dim prodString = (obj.Prod1 & "<br />" & obj.Prod2 & "<br />" & obj.Prod3)
                            '' type the phones only phone 2 & three if present
                            Dim arPhoneType(1)
                            arPhoneType = Get_Phone_Type(obj.ID)
                            Dim phone1Type As String = arPhoneType(0)
                            Dim phone2Type As String = arPhoneType(1)

                            If Len(phone1Type) > 1 = True Then
                                If phone1Type <> "" Then
                                    If phone1Type <> " " Then
                                        arPhoneType(0) = " - " & phone1Type
                                    End If
                                End If
                            End If

                            If Len(phone2Type) > 1 = True Then
                                If phone1Type <> "" Then
                                    If phone1Type <> " " Then
                                        arPhoneType(1) = " - " & phone2Type
                                    End If
                                End If
                            End If

                            Dim PhoneString = (obj.Phone1 & "<br />" & obj.Phone2 & " " & arPhoneType(0) & "<br />" & obj.Phone3 & " " & arPhoneType(1) & "<br />")
                            Dim AddyString = (obj.StAddress & " " & obj.City & ", " & obj.State & " " & obj.Zip)
                            Dim nameStr As String = (obj.FName & " " & obj.LName & "<br />" & obj.FName2 & " " & obj.LName2)

                            rowData = "<!--BEGIN ROW Group Data--><tr><td></td><td>" & obj.ID & "</td>"
                            rowData += "<td>" & nameStr & "</td>"
                            rowData += "<td>" & AddyString & "</td>"
                            rowData += "<td>" & PhoneString & "</td>"
                            rowData += "<td>" & prodString & "</td>"
                            rowData += "<td>" & leadGen & "</td>"
                            rowData += "<td>" & obj.ApptDate & "</td>"
                            'rowData += "<td></td>"
                            rowData += "<td>" & apptTime & "</td>"
                            rowData += "<td>" & obj.Result & "</td></tr><!-- END ROW Group Data-->"
                            '' now, does this lead have any Previous sales or what not? => dropping this per AG "No mash up lists"
                            doc += (rowData & vbCrLf)
                            rowData = ""
                        Next '' end each obj in arobjs

                    Next '' end each dictionary entry 

                    doc += "</table></body></html>" '' put the end cap on it. . . 
                    Exit Select '' end zip code catch
                Case Is = "LeadGeneratedOn"
                    For Each y As String In target_headings
                        '' sort leads by 'heading'
                        Dim arObjs As New List(Of LeadToPrint)

                        For Each xyz As LeadToPrint In arListOfLeadsToDisplay
                            If xyz.LeadGeneratedOn = y Then
                                arObjs.Add(xyz)
                            End If
                        Next

                        Try
                            hashGroups.Add(y, arObjs)
                        Catch ex As Exception

                        End Try
                    Next


                    '' now break sorted list apart and render according per 'group'

                    For Each d As DictionaryEntry In hashGroups
                        Dim arObjss As New List(Of LeadToPrint)
                        arObjss = d.Value
                        Dim cnt_Local As Integer = arObjss.Count
                        Dim Item0 As LeadToPrint = arObjss(0)

                        '' for this grouping, split off time: 
                        '' comes out like: [ Gen. On: 11/29/2014 5:13:14 PM - [1 Items] ]
                        '' 
                        Dim split3() = Split(d.Key, " ", 2)


                        Dim hdrSTR As String = "<!-- BEGIN ROW Group Heading --><tr><td colspan=""11"" style='font-family:""Verdana"",sans-serif;font-size:0.8em;font-weight:bold;text-align:left;'><em>Gen. On: " & split3(0).ToString & " - [" & cnt_Local & " Items] </em></td></tr><!-- END ROW Group Heading -->"
                        Item0 = Nothing
                        doc += hdrSTR

                        For Each obj As LeadToPrint In arObjss

                            Dim rowData As String = ""

                            Dim timeSplit() = Split(obj.ApptTime, " ", 2)
                            Dim apptTime As String = splitTime(timeSplit(1).ToString)
                            Dim LeadGenSplit() = Split(obj.LeadGeneratedOn, " ", 2)

                            Dim leadGen As String = LeadGenSplit(0)
                            Dim split2() = Split(leadGen(0), " ")
                            Dim leadGen2 As String = split2(0)
                            Dim recID As String = obj.ID
                            Dim prodString = (obj.Prod1 & "<br />" & obj.Prod2 & "<br />" & obj.Prod3)
                            '' type the phones only phone 2 & three if present
                            Dim arPhoneType(1)
                            arPhoneType = Get_Phone_Type(obj.ID)
                            Dim phone1Type As String = arPhoneType(0)
                            Dim phone2Type As String = arPhoneType(1)

                            If Len(phone1Type) > 1 = True Then
                                If phone1Type <> "" Then
                                    If phone1Type <> " " Then
                                        arPhoneType(0) = " - " & phone1Type
                                    End If
                                End If
                            End If

                            If Len(phone2Type) > 1 = True Then
                                If phone1Type <> "" Then
                                    If phone1Type <> " " Then
                                        arPhoneType(1) = " - " & phone2Type
                                    End If
                                End If
                            End If

                            Dim PhoneString = (obj.Phone1 & "<br />" & obj.Phone2 & " " & arPhoneType(0) & "<br />" & obj.Phone3 & " " & arPhoneType(1) & "<br />")
                            Dim AddyString = (obj.StAddress & " " & obj.City & ", " & obj.State & " " & obj.Zip)
                            Dim nameStr As String = (obj.FName & " " & obj.LName & "<br />" & obj.FName2 & " " & obj.LName2)

                            rowData = "<!--BEGIN ROW Group Data--><tr><td></td><td>" & obj.ID & "</td>"
                            rowData += "<td>" & nameStr & "</td>"
                            rowData += "<td>" & AddyString & "</td>"
                            rowData += "<td>" & PhoneString & "</td>"
                            rowData += "<td>" & prodString & "</td>"
                            rowData += "<td>" & leadGen & "</td>"
                            rowData += "<td>" & obj.ApptDate & "</td>"
                            'rowData += "<td></td>"
                            rowData += "<td>" & apptTime & "</td>"
                            rowData += "<td>" & obj.Result & "</td></tr><!-- END ROW Group Data-->"
                            '' now, does this lead have any Previous sales or what not? => dropping this per AG "No mash up lists"
                            doc += (rowData & vbCrLf)
                            rowData = ""
                        Next '' end each obj in arobjs

                    Next '' end each dictionary entry 

                    doc += "</table></body></html>" '' put the end cap on it. . . 
                    Exit Select '' end lead generated on catch
                Case Is = "ApptDate"
                    For Each y As String In target_headings
                        '' sort leads by 'heading'
                        Dim arObjs As New List(Of LeadToPrint)
                        For Each xyz As LeadToPrint In arListOfLeadsToDisplay
                            If xyz.ApptDate = y Then
                                arObjs.Add(xyz)
                            End If
                        Next
                        Try
                            hashGroups.Add(y, arObjs)
                        Catch ex As Exception

                        End Try
                    Next


                    '' now break sorted list apart and render according per 'group'

                    For Each d As DictionaryEntry In hashGroups
                        Dim arObjss As New List(Of LeadToPrint)
                        arObjss = d.Value
                        Dim cnt_Local As Integer = arObjss.Count
                        Dim Item0 As LeadToPrint = arObjss(0)
                        Dim hdrSTR As String = "<!-- BEGIN ROW Group Heading --><tr><td colspan=""11"" style='font-family:""Verdana"",sans-serif;font-size:0.8em;font-weight:bold;text-align:left;'><em> " & d.Key & "  - [" & cnt_Local & " Items]  </em></td></tr><!-- END ROW Group Heading -->"
                        Item0 = Nothing
                        doc += hdrSTR

                        For Each obj As LeadToPrint In arObjss

                            Dim rowData As String = ""

                            Dim timeSplit() = Split(obj.ApptTime, " ", 2)
                            Dim apptTime As String = splitTime(timeSplit(1).ToString)
                            Dim LeadGenSplit() = Split(obj.LeadGeneratedOn, " ", 2)

                            Dim leadGen As String = LeadGenSplit(0)
                            Dim recID As String = obj.ID
                            Dim prodString = (obj.Prod1 & "<br />" & obj.Prod2 & "<br />" & obj.Prod3)
                            '' type the phones only phone 2 & three if present
                            Dim arPhoneType(1)
                            arPhoneType = Get_Phone_Type(obj.ID)
                            Dim phone1Type As String = arPhoneType(0)
                            Dim phone2Type As String = arPhoneType(1)

                            If Len(phone1Type) > 1 = True Then
                                If phone1Type <> "" Then
                                    If phone1Type <> " " Then
                                        arPhoneType(0) = " - " & phone1Type
                                    End If
                                End If
                            End If

                            If Len(phone2Type) > 1 = True Then
                                If phone1Type <> "" Then
                                    If phone1Type <> " " Then
                                        arPhoneType(1) = " - " & phone2Type
                                    End If
                                End If
                            End If

                            Dim PhoneString = (obj.Phone1 & "<br />" & obj.Phone2 & " " & arPhoneType(0) & "<br />" & obj.Phone3 & " " & arPhoneType(1) & "<br />")
                            Dim AddyString = (obj.StAddress & " " & obj.City & ", " & obj.State & " " & obj.Zip)
                            Dim nameStr As String = (obj.FName & " " & obj.LName & "<br />" & obj.FName2 & " " & obj.LName2)

                            rowData = "<!--BEGIN ROW Group Data--><tr><td></td><td>" & obj.ID & "</td>"
                            rowData += "<td>" & nameStr & "</td>"
                            rowData += "<td>" & AddyString & "</td>"
                            rowData += "<td>" & PhoneString & "</td>"
                            rowData += "<td>" & prodString & "</td>"
                            rowData += "<td>" & leadGen & "</td>"
                            rowData += "<td>" & obj.ApptDate & "</td>"
                            'rowData += "<td></td>"
                            rowData += "<td>" & apptTime & "</td>"
                            rowData += "<td>" & obj.Result & "</td></tr><!-- END ROW Group Data-->"
                            '' now, does this lead have any Previous sales or what not? => dropping this per AG "No mash up lists"
                            doc += (rowData & vbCrLf)
                            rowData = ""
                        Next '' end each obj in arobjs

                    Next '' end each dictionary entry 

                    doc += "</table></body></html>" '' put the end cap on it. . . 
                    Exit Select '' end appt date catch


                Case Is = "ApptTime"
                    For Each y As String In target_headings
                        '' sort leads by 'heading'
                        Dim arObjs As New List(Of LeadToPrint)
                        For Each xyz As LeadToPrint In arListOfLeadsToDisplay
                            If xyz.ApptTime = y Then
                                arObjs.Add(xyz)
                            End If
                        Next
                        Try
                            hashGroups.Add(y, arObjs)
                        Catch ex As Exception

                        End Try
                    Next


                    '' now break sorted list apart and render according per 'group'

                    For Each d As DictionaryEntry In hashGroups
                        Dim arObjss As New List(Of LeadToPrint)
                        arObjss = d.Value
                        Dim cnt_Local As Integer = arObjss.Count
                        Dim Item0 As LeadToPrint = arObjss(0)
                        Dim split2() = Split(Item0.ApptTime, " ", 2)
                        Dim spTIME As String = ""
                        spTIME = splitTime(split2(1))
                        Dim hdrSTR As String = "<!-- BEGIN ROW Group Heading --><tr><td colspan=""11"" style='font-family:""Verdana"",sans-serif;font-size:0.8em;font-weight:bold;text-align:left;'><em> " & spTIME & "  - [" & cnt_Local & " Items] </em></td></tr><!-- END ROW Group Heading -->"
                        Item0 = Nothing
                        doc += hdrSTR

                        For Each obj As LeadToPrint In arObjss

                            Dim rowData As String = ""

                            Dim timeSplit() = Split(obj.ApptTime, " ", 2)
                            Dim apptTime As String = splitTime(timeSplit(1).ToString)
                            Dim LeadGenSplit() = Split(obj.LeadGeneratedOn, " ", 2)

                            Dim leadGen As String = LeadGenSplit(0)
                            Dim recID As String = obj.ID
                            Dim prodString = (obj.Prod1 & "<br />" & obj.Prod2 & "<br />" & obj.Prod3)
                            '' type the phones only phone 2 & three if present
                            Dim arPhoneType(1)
                            arPhoneType = Get_Phone_Type(obj.ID)
                            Dim phone1Type As String = arPhoneType(0)
                            Dim phone2Type As String = arPhoneType(1)

                            If Len(phone1Type) > 1 = True Then
                                If phone1Type <> "" Then
                                    If phone1Type <> " " Then
                                        arPhoneType(0) = " - " & phone1Type
                                    End If
                                End If
                            End If

                            If Len(phone2Type) > 1 = True Then
                                If phone1Type <> "" Then
                                    If phone1Type <> " " Then
                                        arPhoneType(1) = " - " & phone2Type
                                    End If
                                End If
                            End If

                            Dim PhoneString = (obj.Phone1 & "<br />" & obj.Phone2 & " " & arPhoneType(0) & "<br />" & obj.Phone3 & " " & arPhoneType(1) & "<br />")
                            Dim AddyString = (obj.StAddress & " " & obj.City & ", " & obj.State & " " & obj.Zip)
                            Dim nameStr As String = (obj.FName & " " & obj.LName & "<br />" & obj.FName2 & " " & obj.LName2)

                            rowData = "<!--BEGIN ROW Group Data--><tr><td></td><td>" & obj.ID & "</td>"
                            rowData += "<td>" & nameStr & "</td>"
                            rowData += "<td>" & AddyString & "</td>"
                            rowData += "<td>" & PhoneString & "</td>"
                            rowData += "<td>" & prodString & "</td>"
                            rowData += "<td>" & leadGen & "</td>"
                            rowData += "<td>" & obj.ApptDate & "</td>"
                            'rowData += "<td></td>"
                            rowData += "<td>" & apptTime & "</td>"
                            rowData += "<td>" & obj.Result & "</td></tr><!-- END ROW Group Data-->"
                            '' now, does this lead have any Previous sales or what not? => dropping this per AG "No mash up lists"
                            doc += (rowData & vbCrLf)
                            rowData = ""
                        Next '' end each obj in arobjs

                    Next '' end each dictionary entry 

                    doc += "</table></body></html>" '' put the end cap on it. . . 
                    Exit Select '' end appt time catch



                Case Is = "Product1"
                    For Each y As String In target_headings
                        '' sort leads by 'heading'
                        Dim arObjs As New List(Of LeadToPrint)
                        For Each xyz As LeadToPrint In arListOfLeadsToDisplay
                            If xyz.Prod1 = y Then
                                arObjs.Add(xyz)
                            End If
                        Next
                        Try
                            hashGroups.Add(y, arObjs)
                        Catch ex As Exception

                        End Try
                    Next


                    '' now break sorted list apart and render according per 'group'

                    For Each d As DictionaryEntry In hashGroups
                        Dim arObjss As New List(Of LeadToPrint)
                        arObjss = d.Value
                        Dim cnt_Local As Integer = arObjss.Count
                        Dim Item0 As LeadToPrint = arObjss(0)
                        Dim hdrSTR As String = "<!-- BEGIN ROW Group Heading --><tr><td colspan=""11"" style='font-family:""Verdana"",sans-serif;font-size:0.8em;font-weight:bold;text-align:left;'><em>" & d.Key & "  - [" & cnt_Local & " Items] </em></td></tr><!-- END ROW Group Heading -->"
                        Item0 = Nothing
                        doc += hdrSTR

                        For Each obj As LeadToPrint In arObjss

                            Dim rowData As String = ""

                            Dim timeSplit() = Split(obj.ApptTime, " ", 2)
                            Dim apptTime As String = splitTime(timeSplit(1).ToString)
                            Dim LeadGenSplit() = Split(obj.LeadGeneratedOn, " ", 2)

                            Dim leadGen As String = LeadGenSplit(0)
                            Dim recID As String = obj.ID
                            Dim prodString = (obj.Prod1 & "<br />" & obj.Prod2 & "<br />" & obj.Prod3)
                            '' type the phones only phone 2 & three if present
                            Dim arPhoneType(1)
                            arPhoneType = Get_Phone_Type(obj.ID)
                            Dim phone1Type As String = arPhoneType(0)
                            Dim phone2Type As String = arPhoneType(1)

                            If Len(phone1Type) > 1 = True Then
                                If phone1Type <> "" Then
                                    If phone1Type <> " " Then
                                        arPhoneType(0) = " - " & phone1Type
                                    End If
                                End If
                            End If

                            If Len(phone2Type) > 1 = True Then
                                If phone1Type <> "" Then
                                    If phone1Type <> " " Then
                                        arPhoneType(1) = " - " & phone2Type
                                    End If
                                End If
                            End If

                            Dim PhoneString = (obj.Phone1 & "<br />" & obj.Phone2 & " " & arPhoneType(0) & "<br />" & obj.Phone3 & " " & arPhoneType(1) & "<br />")
                            Dim AddyString = (obj.StAddress & " " & obj.City & ", " & obj.State & " " & obj.Zip)
                            Dim nameStr As String = (obj.FName & " " & obj.LName & "<br />" & obj.FName2 & " " & obj.LName2)

                            rowData = "<!--BEGIN ROW Group Data--><tr><td></td><td>" & obj.ID & "</td>"
                            rowData += "<td>" & nameStr & "</td>"
                            rowData += "<td>" & AddyString & "</td>"
                            rowData += "<td>" & PhoneString & "</td>"
                            rowData += "<td>" & prodString & "</td>"
                            rowData += "<td>" & leadGen & "</td>"
                            rowData += "<td>" & obj.ApptDate & "</td>"
                            'rowData += "<td></td>"
                            rowData += "<td>" & apptTime & "</td>"
                            rowData += "<td>" & obj.Result & "</td></tr><!-- END ROW Group Data-->"
                            '' now, does this lead have any Previous sales or what not? => dropping this per AG "No mash up lists"
                            doc += (rowData & vbCrLf)
                            rowData = ""
                        Next '' end each obj in arobjs

                    Next '' end each dictionary entry 

                    doc += "</table></body></html>" '' put the end cap on it. . . 
                    Exit Select '' end product1 catch


                Case Is = "Marketer"
                    For Each y As String In target_headings
                        '' sort leads by 'heading'
                        Dim arObjs As New List(Of LeadToPrint)
                        For Each xyz As LeadToPrint In arListOfLeadsToDisplay
                            If xyz.Marketer = y Then
                                arObjs.Add(xyz)
                            End If
                        Next
                        Try
                            hashGroups.Add(y, arObjs)
                        Catch ex As Exception

                        End Try
                    Next


                    '' now break sorted list apart and render according per 'group'

                    For Each d As DictionaryEntry In hashGroups
                        Dim arObjss As New List(Of LeadToPrint)
                        arObjss = d.Value
                        Dim cnt_Local As Integer = arObjss.Count
                        Dim Item0 As LeadToPrint = arObjss(0)
                        Dim hdrSTR As String = "<!-- BEGIN ROW Group Heading --><tr><td colspan=""11"" style='font-family:""Verdana"",sans-serif;font-size:0.8em;font-weight:bold;text-align:left;'><em>" & d.Key & "  - [" & cnt_Local & " Items] </em></td></tr><!-- END ROW Group Heading -->"
                        Item0 = Nothing
                        doc += hdrSTR

                        For Each obj As LeadToPrint In arObjss

                            Dim rowData As String = ""

                            Dim timeSplit() = Split(obj.ApptTime, " ", 2)
                            Dim apptTime As String = splitTime(timeSplit(1).ToString)
                            Dim LeadGenSplit() = Split(obj.LeadGeneratedOn, " ", 2)

                            Dim leadGen As String = LeadGenSplit(0)
                            Dim recID As String = obj.ID
                            Dim prodString = (obj.Prod1 & "<br />" & obj.Prod2 & "<br />" & obj.Prod3)
                            '' type the phones only phone 2 & three if present
                            Dim arPhoneType(1)
                            arPhoneType = Get_Phone_Type(obj.ID)
                            Dim phone1Type As String = arPhoneType(0)
                            Dim phone2Type As String = arPhoneType(1)

                            If Len(phone1Type) > 1 = True Then
                                If phone1Type <> "" Then
                                    If phone1Type <> " " Then
                                        arPhoneType(0) = " - " & phone1Type
                                    End If
                                End If
                            End If

                            If Len(phone2Type) > 1 = True Then
                                If phone1Type <> "" Then
                                    If phone1Type <> " " Then
                                        arPhoneType(1) = " - " & phone2Type
                                    End If
                                End If
                            End If

                            Dim PhoneString = (obj.Phone1 & "<br />" & obj.Phone2 & " " & arPhoneType(0) & "<br />" & obj.Phone3 & " " & arPhoneType(1) & "<br />")
                            Dim AddyString = (obj.StAddress & " " & obj.City & ", " & obj.State & " " & obj.Zip)
                            Dim nameStr As String = (obj.FName & " " & obj.LName & "<br />" & obj.FName2 & " " & obj.LName2)

                            rowData = "<!--BEGIN ROW Group Data--><tr><td></td><td>" & obj.ID & "</td>"
                            rowData += "<td>" & nameStr & "</td>"
                            rowData += "<td>" & AddyString & "</td>"
                            rowData += "<td>" & PhoneString & "</td>"
                            rowData += "<td>" & prodString & "</td>"
                            rowData += "<td>" & leadGen & "</td>"
                            rowData += "<td>" & obj.ApptDate & "</td>"
                            'rowData += "<td></td>"
                            rowData += "<td>" & apptTime & "</td>"
                            rowData += "<td>" & obj.Result & "</td></tr><!-- END ROW Group Data-->"
                            '' now, does this lead have any Previous sales or what not? => dropping this per AG "No mash up lists"
                            doc += (rowData & vbCrLf)
                            rowData = ""
                        Next '' end each obj in arobjs

                    Next '' end each dictionary entry 

                    doc += "</table></body></html>" '' put the end cap on it. . . 
                    Exit Select '' end marketer catch



                Case Is = "MarketingResults"
                    For Each y As String In target_headings
                        '' sort leads by 'heading'
                        Dim arObjs As New List(Of LeadToPrint)
                        For Each xyz As LeadToPrint In arListOfLeadsToDisplay
                            If xyz.MarketingResults = y Then
                                arObjs.Add(xyz)
                            End If
                        Next
                        Try
                            hashGroups.Add(y, arObjs)
                        Catch ex As Exception

                        End Try
                    Next


                    '' now break sorted list apart and render according per 'group'

                    For Each d As DictionaryEntry In hashGroups
                        Dim arObjss As New List(Of LeadToPrint)
                        arObjss = d.Value
                        Dim cnt_Local As Integer = arObjss.Count
                        Dim Item0 As LeadToPrint = arObjss(0)
                        Dim hdrSTR As String = "<!-- BEGIN ROW Group Heading --><tr><td colspan=""11"" style='font-family:""Verdana"",sans-serif;font-size:0.8em;font-weight:bold;text-align:left;'><em>" & d.Key & "  - [" & cnt_Local & " Items] </em></td></tr><!-- END ROW Group Heading -->"
                        Item0 = Nothing
                        doc += hdrSTR

                        For Each obj As LeadToPrint In arObjss

                            Dim rowData As String = ""

                            Dim timeSplit() = Split(obj.ApptTime, " ", 2)
                            Dim apptTime As String = splitTime(timeSplit(1).ToString)
                            Dim LeadGenSplit() = Split(obj.LeadGeneratedOn, " ", 2)

                            Dim leadGen As String = LeadGenSplit(0)
                            Dim recID As String = obj.ID
                            Dim prodString = (obj.Prod1 & "<br />" & obj.Prod2 & "<br />" & obj.Prod3)
                            '' type the phones only phone 2 & three if present
                            Dim arPhoneType(1)
                            arPhoneType = Get_Phone_Type(obj.ID)
                            Dim phone1Type As String = arPhoneType(0)
                            Dim phone2Type As String = arPhoneType(1)

                            If Len(phone1Type) > 1 = True Then
                                If phone1Type <> "" Then
                                    If phone1Type <> " " Then
                                        arPhoneType(0) = " - " & phone1Type
                                    End If
                                End If
                            End If

                            If Len(phone2Type) > 1 = True Then
                                If phone1Type <> "" Then
                                    If phone1Type <> " " Then
                                        arPhoneType(1) = " - " & phone2Type
                                    End If
                                End If
                            End If

                            Dim PhoneString = (obj.Phone1 & "<br />" & obj.Phone2 & " " & arPhoneType(0) & "<br />" & obj.Phone3 & " " & arPhoneType(1) & "<br />")
                            Dim AddyString = (obj.StAddress & " " & obj.City & ", " & obj.State & " " & obj.Zip)
                            Dim nameStr As String = (obj.FName & " " & obj.LName & "<br />" & obj.FName2 & " " & obj.LName2)

                            rowData = "<!--BEGIN ROW Group Data--><tr><td></td><td>" & obj.ID & "</td>"
                            rowData += "<td>" & nameStr & "</td>"
                            rowData += "<td>" & AddyString & "</td>"
                            rowData += "<td>" & PhoneString & "</td>"
                            rowData += "<td>" & prodString & "</td>"
                            rowData += "<td>" & leadGen & "</td>"
                            rowData += "<td>" & obj.ApptDate & "</td>"
                            'rowData += "<td></td>"
                            rowData += "<td>" & apptTime & "</td>"
                            rowData += "<td>" & obj.Result & "</td></tr><!-- END ROW Group Data-->"
                            '' now, does this lead have any Previous sales or what not? => dropping this per AG "No mash up lists"
                            doc += (rowData & vbCrLf)
                            rowData = ""
                        Next '' end each obj in arobjs

                    Next '' end each dictionary entry 

                    doc += "</table></body></html>" '' put the end cap on it. . . 
                    Exit Select '' end marketing results catch


            End Select








            '' doc += "</table></body></html>" & vbCrLf ' shouldn't need double cap, dont' know why I put this here.....AC


            '' 4-3-2016 Changes: AC
            '' var "doc" constructed first, then doc passed as entire arg to streamwriter(doc), then written to disk. 
            '' much faster => doc should actually be a "stringbuilder" instead of string var  
            '' stringbuilder optimized for string concatenation.
            '' src: http://www.dotnetperls.com/stringbuilder-vbnet
            '' this runs fast enough, so I am going to leave for now. . . .


            Dim stWriter As New StreamWriter(Production_Directory & guid.ToString & ext)
            stWriter.Write(doc)
            stWriter.Flush()
            stWriter.Close()

            System.Diagnostics.Process.Start(Production_Directory & guid.ToString & ext)
            frmWCList.Cursor = Cursors.Default

        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "createListPrintOperations", "createListPrintOperations", "Sub", "CreateWireFrameHTML_WarmCalling(ByVal QueryString As String, ByVal Grouped As Boolean, ByVal GroupHeading As ArrayList)", "0", ex.Message.ToString)
            y = Nothing
        End Try

        'frmWCList.Cursor = Cursors.Default

    End Sub

    Private Function GrabUniqueHeadings(ByVal HeadingData_QRY As String)
        Try
            Dim arHeadings As New ArrayList
            Dim cnx As New SqlConnection(sql_cnx)
            Dim cmdG As New SqlCommand(HeadingData_QRY, cnx)
            cnx.Open()
            Dim hsh As New Hashtable

            Dim r1 As SqlDataReader = cmdG.ExecuteReader
            Dim colName As String = ""
            While r1.Read
                colName = r1.GetName(0)
                arHeadings.Add(r1.Item(0))
            End While
            hsh.Add(colName, arHeadings)
            r1.Close()
            cnx.Close()
            cnx = Nothing
            Return hsh
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "createListPrintOperations", "createListPrintOperations", "Func", " GrabUniqueHeadings(ByVal HeadingData_QRY As String)", "0", ex.Message.ToString)
            y = Nothing
        End Try
    End Function

    Public Sub CreateWireFrameHTML(ByVal QueryString As String)
        Try
            arListOfLeadsToDisplay = GrabRowsForHTML(QueryString)

            Dim guid As Guid = guid.NewGuid
            Dim dateTime As String = Date.Now
            Dim ext As String = ".htm"

            Dim doc As String = "" '' variable for ENTIRE HTML doc

            'Dim style As String = "<style type='text/css'>.elem1{font-family:""Verdana"",sans-serif;font-size:1.2em;color:blue;}.fancyTable{position:fixed;left:2em;top:3em;padding:2px;margin:3px;text-align:center;"
            'style = style + "border-right-style:solid;border-right-width:1px;border-right-color:black;box-shadow:2px 2px 2px grey;border-collapse: collapse;}"
            'style = style + "th{padding:3px;border-bottom-style:solid;border-bottom-color:black;border-bottom-width:1px;border-right-style:solid;border-right-color:grey;border-right-width:1px;"
            'style = style + "background-color:hsl(30,75%,74%);color:hsl(30,100%,33%);font-family:""Verdana"",sans-serif;font-size:1.1em;}"
            'style = style + "td{padding:3px;font-family:""Verdana"",sans-serif;font-size:0.7em;}"
            'style = style + "tr:nth-child(even){background-color:hsl(30,100%,94%);}tr:nth-child(odd){background-color:hsl(30,100%,80%);}"
            'style = style + "</style>"

            Dim title As String = "<title>Create List For - " & Date.Today.ToShortDateString & "</title>"

            Dim style As String = "<style type='text/css'>" & vbCrLf
            style += "span.data {font-family:""Verdana"",sans-serif;font-size:1.3em;color:black;}" & vbCrLf
            style += ".elem1 {font-family:""Verdana"",sans-serif;color:blue;font-size:1.3em;}" & vbCrLf
            style += ".tbl {font-family:""Verdana"",sans-serif;color:black;border-collapse:collapse;margin:5px;box-shadow:2px 2px 2px grey;}" & vbCrLf
            style += "tr {padding:3px;border-bottom-width:1px;border-bottom-color:black;border-style:solid;border-top-width:0px;border-right-width:0px;border-left-width:0px;}" & vbCrLf
            style += "tr:nth-child(odd) {background-color:white;}" & vbCrLf
            style += "tr:nth-child(even) {background-color:hsl(0,0%,90%);}" & vbCrLf
            style += "th {font-family:""Verdana"",sans-serif;font-size:1.1em;color:black;padding:3px;text-align:center;background-color:hsl(0,0%,80%);}" & vbCrLf
            'style += "th.lg {font-family:""Verdana"",sans-serif;font-size:1.2em;font-weight:bold;color:black;padding:3px;text-align:center;background-color:white;text-align:left;}td {font-family:"Verdana",sans-serif;font-size:0.8em;padding:7px;text-align:center;}"
            style += "td {font-family:""Verdana"",sans-serif;font-size:0.8em;padding:7px;text-align:center;}" & vbCrLf
            style += "tr.sale {font-family:""Verdana"",sans-serif;font-weight:normal;font-size:1em;background-color:hsl(120,100%,75%);}" & vbCrLf
            style += "@media print { span.data {display:none;} tr:nth-child(even){background-color:white;}tr:nth-child(odd){background-color:white;}" & vbCrLf
            style += "tr.sale{background-color:white;font-size:0.8em;}th{font-size:0.7em;}td{font-size:0.5em;}.tbl{box-shadow:0px 0px 0px white;} @page{size:landscape;}}" & vbCrLf
            style += "</style>"


            Dim jScript As String = "<script type='text/javascript'></script>"

            doc += "<!DOCTYPE html>" & vbCrLf
            doc += "<head>" & vbCrLf
            doc += "<meta charset=""UTF-8"">" & vbCrLf
            doc += "" & title & "" & vbCrLf
            doc += "" & style & "" & vbCrLf
            doc += "" & jScript & "" & vbCrLf
            doc += "<!-- AUTO GENERATED CODE FOR: " & Date.Now.ToString & " -->" & vbCrLf
            doc += "<!-- QUERY ACTUAL: " & vbCrLf
            doc += "" & QueryString & " -->" & vbCrLf
            doc += "" & vbCrLf
            doc += "" & vbCrLf
            doc += "</head>" & vbCrLf
            doc += "<body>" & vbCrLf
            doc += "<span id='elem1' class='elem1'> Warm Calling List " & arListOfLeadsToDisplay.Count.ToString & " Items(s) </span>" & vbCrLf
            doc += "<br /><br />" & vbCrLf
            doc += "<table id='tbDat' class='tbl'>" & vbCrLf
            doc += "" & vbCrLf
            doc += "" & vbCrLf
            doc += "<tr><th></th><th>ID</th><th>Name</th><th>Address</th><th>Phone</th><th>Product(s)</th><th>Gen. On</th><th>Appt. Date</th><th>Appt. Time</th><th>Result</th></tr>" & vbCrLf

            Dim z As LeadToPrint
            For Each z In arListOfLeadsToDisplay

                Dim rowData As String = ""

                Dim timeSplit() = Split(z.ApptTime, " ", 2)
                Dim apptTime As String = splitTime(timeSplit(1).ToString)
                Dim LeadGenSplit() = Split(z.LeadGeneratedOn, " ", 2)

                Dim leadGen As String = LeadGenSplit(0)
                Dim recID As String = z.ID
                Dim prodString = (z.Prod1 & "<br />" & z.Prod2 & "<br />" & z.Prod3)
                '' type the phones only phone 2 & three if present
                Dim arPhoneType(1)
                arPhoneType = Get_Phone_Type(z.ID)
                Dim phone1Type As String = arPhoneType(0)
                Dim phone2Type As String = arPhoneType(1)

                If Len(phone1Type) > 1 = True Then
                    If phone1Type <> "" Then
                        If phone1Type <> " " Then
                            arPhoneType(0) = " - " & phone1Type
                        End If
                    End If
                End If

                If Len(phone2Type) > 1 = True Then
                    If phone1Type <> "" Then
                        If phone1Type <> " " Then
                            arPhoneType(1) = " - " & phone2Type
                        End If
                    End If
                End If

                Dim PhoneString = (z.Phone1 & "<br />" & z.Phone2 & " " & arPhoneType(0) & "<br />" & z.Phone3 & " " & arPhoneType(1) & "<br />")
                Dim AddyString = (z.StAddress & " " & z.City & ", " & z.State & " " & z.Zip)
                Dim nameStr As String = (z.FName & " " & z.LName & "<br />" & z.FName2 & " " & z.LName2)

                rowData = "<!--BEGIN ROW Data--><tr><td></td><td>" & z.ID & "</td>"
                rowData += "<td>" & nameStr & "</td>"
                rowData += "<td>" & AddyString & "</td>"
                rowData += "<td>" & PhoneString & "</td>"
                rowData += "<td>" & prodString & "</td>"
                rowData += "<td>" & leadGen & "</td>"
                rowData += "<td>" & z.ApptDate & "</td>"
                'rowData += "<td></td>"
                rowData += "<td>" & apptTime & "</td>"
                rowData += "<td>" & z.Result & "</td></tr><!-- END ROW Data-->"
                '' now, does this lead have any Previous sales or what not? => dropping this per AG "No mash up lists"
                doc += (rowData & vbCrLf)
                rowData = ""


                ''10-8-2015 8:20am
                '' dont' worry about icons just yet
                '' double check methods are working correctly.

                ''10-8-2015 9:45am
                '' split for icons per result
                '' 

                '' 4-3-2016 Nested rows are deprecated now
                '' AC
                '' 
                ''Select Case z.Result
                ''    Case Is = "Sale"
                ''        streamWriter.WriteLine("<tr><td><img src='IMGS\sale28x28.jpg' alt='Sale' title='Sale'/><td>" & z.ID & "</td><td>" & z.FName & " " & z.LName & "<br />" & z.FName2 & " " & z.LName2 & "</td><td>" & AddyString & "</td><td>" & PhoneString & "</td><td>" & prodString & "</td><td>" & leadGen & "</td><td>" & z.ApptDate & "</td><td>" & z.ApptDay & "</td><td>" & apptTime & "</td><td>" & z.Result & "</td></tr>")
                ''        '' grab sales cross query
                ''        Dim g As New List(Of PCInfoToPrint)
                ''        g = GrabSaleInfo(z.ID)
                ''        Dim a As PCInfoToPrint
                ''        Dim cnt As Integer = 0
                ''        For Each a In g
                ''            cnt += 1
                ''            Dim p_String As String = (a.Product1 & "<br />" & a.Product2 & "<br />" & a.Product3)
                ''            If a.Cash = True Then
                ''                Dim f_currency As String = FormatCurrency(a.ContractAmount, 2, Microsoft.VisualBasic.TriState.UseDefault, Microsoft.VisualBasic.TriState.UseDefault, Microsoft.VisualBasic.TriState.UseDefault)
                ''                streamWriter.WriteLine("<tr class='sale'><td/><td /><td >Job " & cnt & "</td><td>" & p_String & "</td><td>Job Closed<br />" & a.JobCloseDate & "</td><td>Contract Amt<br />" & f_currency & "</td><td>Cash</td><td/><td/><td/><td/></tr>")
                ''            ElseIf a.Finance = True Then
                ''                Dim f_currency As String = FormatCurrency(a.ContractAmount, 2, Microsoft.VisualBasic.TriState.UseDefault, Microsoft.VisualBasic.TriState.UseDefault, Microsoft.VisualBasic.TriState.UseDefault)
                ''                streamWriter.WriteLine("<tr class='sale'><td/><td /><td >Job " & cnt & "</td><td>" & p_String & "</td><td>Job Closed<br />" & a.JobCloseDate & "</td><td>Contract Amt<br />" & f_currency & "</td><td>Finance</td><td/><td/><td/><td/></tr>")
                ''            End If
                ''        Next
                ''        Exit Select
                ''    Case Is = "Demo/No Sale"
                ''        streamWriter.WriteLine("<tr><td><img src='IMGS\DemoNoSale28x28.jpg' alt='Demo/No Sale' title='Demo/No Sale'/><td>" & z.ID & "</td><td>" & z.FName & " " & z.LName & "<br />" & z.FName2 & " " & z.LName2 & "</td><td>" & AddyString & "</td><td>" & PhoneString & "</td><td>" & prodString & "</td><td>" & leadGen & "</td><td>" & z.ApptDate & "</td><td>" & z.ApptDay & "</td><td>" & apptTime & "</td><td>" & z.Result & "</td></tr>")
                ''        Exit Select
                ''    Case Is = "Reset"
                ''        streamWriter.WriteLine("<tr><td><img src='IMGS\reset28x28.jpg' alt='Reset' title='Reset'/><td>" & z.ID & "</td><td>" & z.FName & " " & z.LName & "<br />" & z.FName2 & " " & z.LName2 & "</td><td>" & AddyString & "</td><td>" & PhoneString & "</td><td>" & prodString & "</td><td>" & leadGen & "</td><td>" & z.ApptDate & "</td><td>" & z.ApptDay & "</td><td>" & apptTime & "</td><td>" & z.Result & "</td></tr>")
                ''        Exit Select
                ''    Case Else
                ''        streamWriter.WriteLine("<tr><td /><td>" & z.ID & "</td><td>" & z.FName & " " & z.LName & "<br />" & z.FName2 & " " & z.LName2 & "</td><td>" & AddyString & "</td><td>" & PhoneString & "</td><td>" & prodString & "</td><td>" & leadGen & "</td><td>" & z.ApptDate & "</td><td>" & z.ApptDay & "</td><td>" & apptTime & "</td><td>" & z.Result & "</td></tr>")
                ''        Exit Select
                ''End Select



                '' mockup example only format
                'streamWriter.WriteLine("<tr><td>" & z.ID & "</td><td>" & z.FName & "</td><td>" & z.LName & "</td><td>" & z.StAddress & " " & z.City & " " & z.State & " " & z.Zip & "</td><td>" & z.Phone1 & "</td><td>" & z.Phone2 & "</td><td>" & z.Prod1 & "</td><td>" & z.Prod2 & "</td><td>" & z.Prod3 & "</td><td>" & z.ApptDate & "</td><td>" & timeSplit(1).ToString & "</td></tr>")

                '' printLeadExample.xls Format
                '' 10-6-2015




            Next


            '' 4-3-2016 Changes: AC
            '' var "doc" constructed first, then doc passed as entire arg to streamwriter(doc), then written to disk. 
            '' much faster => doc should actually be a "stringbuilder" instead of string var  
            '' stringbuilder optimized for string concatenation.
            '' src: http://www.dotnetperls.com/stringbuilder-vbnet
            '' this runs fast enough, so I am going to leave for now. . . .

            Dim strWriter As New StreamWriter(Production_Directory & guid.ToString & ext)

            doc += "</table></body></html>" & vbCrLf
            strWriter.Write(doc)
            strWriter.Flush()
            strWriter.Close()

            System.Diagnostics.Process.Start(Production_Directory & guid.ToString & ext)

        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "createListPrintOperations", "createListPrintOperations", "Sub", "CreateWireFrameHTML(QueryString)", "0", ex.Message.ToString)
            y = Nothing
        End Try
    End Sub '' specific for warm calling

    Private Function GrabRowsForHTML(ByVal Query_String As String)
        Try
            Dim cnx As New SqlConnection(sql_cnx)
            cnx.Open()
            Dim arResults As New List(Of LeadToPrint)
            Dim cmdGET As New SqlCommand(Query_String, cnx)
            Dim r1 As SqlDataReader = cmdGET.ExecuteReader
            '' DEFAULT = Select Distinct(Enterlead.ID), Contact1LastName, Contact1FirstName, Contact2LastName, Contact2FirstName, StAddress, City, State, Zip, 
            '' HousePhone, AltPhone1, AltPhone2, EnterLead.Product1, EnterLead.Product2, EnterLead.Product3, 
            '' LeadGeneratedOn, ApptDate, ApptDay, ApptTime, Result, MarketingResults, IsPreviousCustomer, IsRecovery
            Try
                While r1.Read
                    Dim y As New LeadToPrint
                    y.ID = r1.Item("ID")
                    y.FName = r1.Item("Contact1FirstName")
                    y.LName = r1.Item("Contact1LastName")
                    y.FName2 = r1.Item("Contact2FirstName")
                    y.LName2 = r1.Item("Contact2LastName")
                    y.StAddress = r1.Item("StAddress")
                    y.City = r1.Item("City")
                    y.State = r1.Item("State")
                    y.Zip = r1.Item("Zip")
                    y.Phone1 = r1.Item("HousePhone")
                    y.Phone2 = r1.Item("AltPhone1")
                    y.Phone3 = r1.Item("AltPhone2")
                    y.Prod1 = r1.Item("Product1")
                    y.Prod2 = r1.Item("Product2")
                    y.Prod3 = r1.Item("Product3")
                    y.LeadGeneratedOn = r1.Item("LeadGeneratedOn")
                    y.ApptDate = r1.Item("ApptDate")
                    y.ApptTime = r1.Item("ApptTime")
                    y.ApptDay = r1.Item("ApptDay")
                    y.Result = r1.Item("Result")
                    y.MarketingResults = r1.Item("MarketingResults")
                    y.IsPreviousCustomer = r1.Item("IsPreviousCustomer")
                    y.IsRecovery = r1.Item("IsRecovery")
                    y.Marketer = r1.Item("Marketer")
                    arResults.Add(y)
                End While
            Catch ex As Exception
                '' fail it for now.
                '' record count of failed items to report they are missing from 'list'? 
                '' 
            End Try
            r1.Close()
            cnx.Close()
            cnx = Nothing
            Return arResults
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "createListPrintOperations", "createListPrintOperations", "Function", "GrabRowsForHTML(Query_String)", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Function '' specific for Warm Calling

    Public Sub CreateWireFrameHTML_WarmCalling(ByVal QueryString As String)
        '' 
        '' no group by / sort top item here
        '' 
        '' 
        CreateWireFrameHTML(QueryString)

    End Sub


#End Region

#Region "Recovery List Generation - Grouped / Non Grouped"

#End Region


#Region "Private Util Funcs - For all Methods"

    Private Function Get_Phone_Type(ByVal RecID As String)
        Dim arPhone(1) '' generic two dimension array for type of phones if exists
        Try
            Dim cnx As New SqlConnection(sql_cnx)
            cnx.Open()
            Dim cmdGET As New SqlCommand("select AltPhone1,AltPhone2,Phone1Type,Phone2Type from Enterlead WHERE ID = '" & RecID & "';", cnx)
            Dim r1 As SqlDataReader = cmdGET.ExecuteReader
            While r1.Read
                arPhone(0) = r1.Item("Phone1Type")
                arPhone(1) = r1.Item("Phone2Type")
            End While
            r1.Close()
            cnx.Close()
            cnx = Nothing

            Return arPhone

        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "createListPrintOperations", "createListPrintOperations", "Func", " Get_Phone_Type(recID) ", "0", ex.Message.ToString)
            y = Nothing
            Return arPhone
        End Try
    End Function

    Private Function GrabSaleInfo(ByVal LeadNum As String)
        Try
            Dim cnxS As New SqlConnection(sql_cnx)
            cnxS.Open()
            Dim cmdGET As New SqlCommand("SELECT ID,LeadNum,LeadHistoryID,Product1,Product2,Product3,JobClosed,ContractAmount,Cash,Finance FROM SaleDetail WHERE LeadNum = '" & LeadNum & "';", cnxS)
            Dim arResults As New List(Of PCInfoToPrint)
            Dim r1 As SqlDataReader = cmdGET.ExecuteReader
            While r1.Read
                Try
                    Dim y As New PCInfoToPrint
                    y.recID = r1.Item("ID")
                    y.LeadNum = r1.Item("LeadNum")
                    y.LeadHistoryID = r1.Item("LeadHistoryID")
                    y.Product1 = r1.Item("Product1")
                    y.Product2 = r1.Item("Product2")
                    y.Product3 = r1.Item("Product3")
                    y.JobCloseDate = r1.Item("JobClosed")
                    y.ContractAmount = r1.Item("ContractAmount")
                    y.Cash = r1.Item("Cash")
                    y.Finance = r1.Item("Finance")
                    arResults.Add(y)
                Catch ex As Exception
                    '' just fail it
                End Try
            End While
            r1.Close()
            cnxS.Close()
            cnxS = Nothing

            Return arResults
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "createListPrintOperations", "createListPrintOperations", "Function", "GrabSalesInfo(leadnum)", LeadNum, ex.Message.ToString)
            y = Nothing
        End Try

    End Function

    Private Function splitTime(ByVal InputTime As String)
        '' should be "11:00:00" "AM"
        ''               0        1
        Dim retVal As String = ""
        Try
            Dim arPC = Split(InputTime, " ", 2)
            '' should be "11","00","00" 
            ''             0    1    2
            Dim arPC2 = Split(arPC(0), ":")

            retVal = (arPC2(0) & ":" & arPC2(1) & " " & arPC(1))
            Return retVal
        Catch ex As Exception
            retVal = "0:00 AM/PM"
            Return retVal
        End Try

    End Function

#End Region


#Region " Unknown Function - TestList()"

    Public Function TestList()
        Try
            Dim cnx As New SqlConnection(sql_cnx)
            cnx.Open()
            Dim cmdGET As New SqlCommand("SELECT TOP(10)ID FROM EnterLead;", cnx)
            Dim arLeadNum As New ArrayList
            Dim r1 As SqlDataReader = cmdGET.ExecuteReader
            While r1.Read
                arLeadNum.Add(r1.Item("ID"))
            End While
            r1.Close()
            cnx.Close()
            cnx = Nothing
            Return arLeadNum
        Catch ex As Exception
            Dim y As New ErrorLogging_V2
            y.WriteToLog(Date.Now, My.Computer.Name, STATIC_VARIABLES.IP, "createListPrintOperations", "createListPrintOperations", "Sub", "TestLIst()", "0", ex.Message.ToString)
            y = Nothing
        End Try

    End Function

#End Region

End Class