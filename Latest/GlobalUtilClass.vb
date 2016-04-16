Imports System
Imports System.Collections
Imports System.IO
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Net
Imports System.Net.Sockets
Imports System.Net.Mail '' used for email validation
Imports Microsoft.VisualBasic



Public Class Input_Utility_Class

    Private state_list As Hashtable
    Private carrier_sms_gateways As Hashtable
    Private email_list As ArrayList
    Private zip_code_list As List(Of ZipCodeInfoFED)

    Public Structure ZipCodeInfoFED
        '' CSV STRUCTURE
        '' ZipCode | ZipCodeType | City | State | LocationType | Lat | Long | Location | Decommissioned | TaxReturnsFiled | EstimatedPopulation | TotalWages 
        '' 
        '' my struct modified.
        Public ZipCode As String '' record ID
        Public ZipType As String '' STANDARD || PO BOX
        Public City As String
        Public State As String
        Public Lattitude As String '' ctype this double
        Public Longitude As String '' ctype this double
        Public RegionCountryStateCity As String  '' NA-US-OH-SYLVANIA
        Public Population As String '' ctype this double
        Public TotalWages As String '' ctype this double/integer

        '' DESC From Site: 
        'Name 	                Type 	        Description
        'Zipcode     	        Text 	        5 digit Zipcode or military postal code(FPO/APO)
        'ZipCodeType 	        Text 	        Standard, PO BOX Only, Unique, Military(implies APO or FPO)
        'City 	                Text 	        USPS offical city name(s)
        'State 	                Text 	        USPS offical state, territory, or quasi-state (AA, AE, AP) abbreviation code
        'LocationType 	        Text 	        Primary, Acceptable,Not Acceptable
        'Lat 	                Double 	        Decimal Latitude, if available
        'Long 	                Double 	        Decimal Longitude, if available
        'Location 	            Text 	        Standard Display  (eg Phoenix, AZ ; Pago Pago, AS ; Melbourne, AU )
        'Decommisioned 	        Text 	        If Primary location, Yes implies historical Zipcode, No Implies current Zipcode; If not Primary, Yes implies Historical Placename
        'TaxReturnsFiled 	    Long Integer 	Number of Individual Tax Returns Filed in 2008
        'EstimatedPopulation    Long Integer 	Tax returns filed + Married filing jointly + Dependents
        'TotalWages 	        Long Integer 	Total of Wages Salaries and Tips
    End Structure


    '' 
    '' purpose of this class is to help standardize all inputs
    '' and hopefully validate most of it as well. 
    '' 
    '' v1.0.0 AC
    ''
    '' zip, names, telephone numbers. . . 
    '' 

    '' C1 Fname, C1 LName

    '' TextCap

    '' ASCII Character(s) according to MSOFT
    '' srcs: https://msdn.microsoft.com/en-us/library/4z4t9ed1%28v=vs.80%29.aspx
    '' 
    '' Regex:
    '' srcs: https://msdn.microsoft.com/en-us/library/az24scfc%28v=vs.110%29.aspx
    '' 
    '' States:
    '' srcs:  http://www.50states.com/abbreviations.htm
    ''
    '' SMS/MMS:
    '' srcs: https://en.wikipedia.org/wiki/SMS_gateway
    '' 
    '' expand 'Regions' for more Info
    '' 
    '' Considerations:
    '' Site: http://www.geonames.org/ //** FREE **//
    ''
    '' src: http://www.geonames.org/export/ws-overview.html
    '' WEB SERVICES REST | XML || JSON
    '' 
    '' src: http://download.geonames.org/export/zip/
    '' RAW DUMPS => Looks Tab Delimited
    ''
    '' src: http://federalgovernmentzipcodes.us
    '' CSV Dump 
    '' # SEE ZipCodeInfoFED Struct #
    '' 



#Region "Capitalizing/Standardizing Text"



    '' 
    '' use:      text = x.CapText(text)
    ''

    Public Function CapText(ByVal TextToCap As String)
        Dim retval As String = ""
        If Len(TextToCap) >= 1 And TextToCap <> "" And TextToCap <> " " Then
            '' first trim whitespace
            TextToCap = LTrim(TextToCap)
            TextToCap = RTrim(TextToCap)
            '' Second strip or replace all apostrophes with _ char
            TextToCap = Replace(TextToCap, "'", "_", 1, TextToCap.Length, CompareMethod.Text)
            'Dim arTest() = TextToCap.ToCharArray
            If Regex.IsMatch(TextToCap, "^[A-Za-z.\s_-]+$") Then
                If TextToCap.ToString.LastIndexOf(" ") > 1 Then
                    '' it has a space. 
                    '' pipe to array and cap both items
                    Dim a() = Split(TextToCap, " ", -1, CompareMethod.Text)
                    Dim p1 = a(0)
                    Dim p2 = a(1)
                    p1 = CapText(p1)
                    p2 = CapText(p2)
                    Dim strComposit As String = (p1 & " " & p2)
                    retval = strComposit
                    Return retval
                ElseIf TextToCap.ToString.LastIndexOf("-") > 1 Then
                    '' they have a hyphenated name
                    '' 
                    Dim a() = Split(TextToCap, "-", -1, CompareMethod.Text)
                    Dim p1 = a(0)
                    Dim p2 = a(1)
                    p1 = CapText(p1)
                    p2 = CapText(p2)
                    Dim strComposit As String = (p1 & "-" & p2)
                    retval = strComposit
                    Return retval
                ElseIf TextToCap.ToString.LastIndexOf("_"c) >= 1 Then
                    '' they have a substituted apostrophe
                    Dim a() = Split(TextToCap, "_", -1, CompareMethod.Text)
                    Dim p1 = a(0)
                    Dim p2 = a(1)
                    p1 = CapText(p1)
                    p2 = CapText(p2)
                    Dim strComposit As String = (p1 & "_" & p2)
                    retval = strComposit
                    Return retval

                ElseIf TextToCap.ToString.LastIndexOf(".") >= 1 Then
                    '' they have a period [.] in their name IE: 'Dr.' or 'Mrs.'
                    Dim a() = Split(TextToCap, ".", -1, CompareMethod.Text)
                    Dim p1 = a(0)
                    Dim p2 = a(1)
                    p1 = CapText(p1)
                    p2 = CapText(p2)
                    Dim strComposit As String = (p1 & ". " & p2)
                    retval = strComposit
                    Return retval

                Else
                    Dim c = TextToCap.ToCharArray
                    Dim FirstLetter As Char = c(0)
                    FirstLetter = (FirstLetter.ToString.ToUpper)
                    c(0) = FirstLetter
                    Dim strComposite As String = c
                    retval = strComposite
                End If
            Else
                retval = "<Invalid>"
            End If
        Else
            retval = "<Invalid>"
        End If
        Return retval
    End Function

    '' 
    '' use validText = IsTextValid(text to check)
    '' 
    '' use this just to make sure no special chars in text.
    '' 
    Public Function IsTextValid(ByVal TextToCheck As String)
        Dim valid As Boolean = False
        Dim pattern As String = "^[a-zA-Z0-9 ]*$"
        If Regex.IsMatch(TextToCheck, pattern) = True Then
            valid = True
            Return valid
        Else
            Return valid '' default false
        End If
        Return valid
    End Function

    '' 
    '' use text = StripOutSpecials(Text to clean)
    '' 
    Public Function StripOutSpecials(ByVal TextToStrip As String)
        Dim retVal As String = ""
        Dim arSpecials As New ArrayList
        '' chars according to MSDN
        '' 
        arSpecials.Add("~")
        arSpecials.Add("!")
        arSpecials.Add("@")
        arSpecials.Add("#")
        arSpecials.Add("$")
        arSpecials.Add("%")
        arSpecials.Add("^")
        arSpecials.Add("&")
        arSpecials.Add("*")
        arSpecials.Add("(")
        arSpecials.Add(")")
        arSpecials.Add("-")
        arSpecials.Add("+")
        arSpecials.Add("=")
        arSpecials.Add("[")
        arSpecials.Add("]")
        arSpecials.Add("{")
        arSpecials.Add("}")
        arSpecials.Add("|")
        arSpecials.Add("\")
        arSpecials.Add(";")
        arSpecials.Add(":")
        arSpecials.Add("'")
        arSpecials.Add(Chr(34)) '' double quotes in ascii
        arSpecials.Add(",")
        arSpecials.Add("/")
        arSpecials.Add(">")
        arSpecials.Add("<")
        Dim y As String = ""
        For Each y In arSpecials
            TextToStrip = Replace(TextToStrip, y, " ", 1, TextToStrip.Length, CompareMethod.Text)
        Next
        retVal = TextToStrip
        Return retVal
    End Function

#End Region

#Region "Standardizing Phone Numbers"
    '' use: phone = checkPhone(phoneSTR)
    Public Function CheckPhone(ByVal Phone_STR As String)
        Dim corrected As String = "<invalid>"
        Dim phLen As Integer = Len(Phone_STR)
        If phLen > 1 And Phone_STR <> "" And Phone_STR <> " " Then
            ''
            '' 10 digit telephone num required.
            ''
            If phLen < 10 Then
                corrected = "<invalid>"
                Return corrected
                Exit Function
            ElseIf phLen > 10 Then
                corrected = "<invalid>"
                Return corrected
                Exit Function
            End If
            If phLen = 10 Then
                Phone_STR = LTrim(Phone_STR)
                Phone_STR = RTrim(Phone_STR)
                Phone_STR = Replace(Phone_STR, "(", "", 1, Phone_STR.Length)
                Phone_STR = Replace(Phone_STR, ")", "", 1, Phone_STR.Length)
                Phone_STR = Replace(Phone_STR, " ", "", 1, Phone_STR.Length)
                Phone_STR = Replace(Phone_STR, "-", "", 1, Phone_STR.Length)
                Phone_STR = Replace(Phone_STR, "+", "", 1, Phone_STR.Length)
                Phone_STR = LTrim(Phone_STR)
                Phone_STR = RTrim(Phone_STR)
                Dim arPH = Phone_STR.ToCharArray
                ''clear it
                Phone_STR = ""
                '' add the first '('
                Phone_STR += ("(")
                '' next 3 digits
                Dim i As Integer = 0
                For i = 0 To 2
                    Phone_STR += arPH(i)
                Next
                Phone_STR += ")"
                Phone_STR += " "
                Dim ii As Integer = 0 '' (123) xxx
                For ii = 3 To 5
                    Phone_STR += arPH(ii)
                Next
                Phone_STR += "-"
                Dim iii As Integer = 0
                For iii = 6 To 9
                    Phone_STR += arPH(iii)
                Next
                corrected = Phone_STR
                Return corrected
            Else
                corrected = "<Invalid>"
                Return corrected
            End If
            Return corrected
        End If
    End Function

#End Region

#Region "Standardizing Zip Codes"
    '' use: zip = check_zip(zip)
    Public Function Check_Zip(ByVal Zip As String)
        ''
        '' 5 digit zips
        ''
        Zip = LTrim(Zip) '' no leading whitespaces
        Zip = RTrim(Zip) '' no trailing whitespaces

        Dim retVal As String = "<invalid>"
        Dim searchPatter As String = "^\d{5}$" '' only ' 12345 ' digit zip codes. ONLY.
        Dim zip_length As Integer = Len(Zip)

        If zip_length < 5 Then
            Return retVal
            Exit Function
        End If

        If zip_length = 5 And Zip <> "" And Zip <> " " Then
            '' make sure patter matches
            If Regex.IsMatch(Zip, searchPatter) = True Then
                retVal = Zip
                Return retVal
                Exit Function
            ElseIf Regex.IsMatch(Zip, searchPatter) = False Then
                Return retVal
                Exit Function
            End If
        ElseIf zip_length > 5 And Zip <> "" And Zip <> " " Then
            Return retVal
            Exit Function
        End If

        Return retVal
    End Function

    '' get a list of zip codes from the federal government.
    '' src: http://federalgovernmentzipcodes.us/
    Public Function Download_Federal_Zip_Code_List()
        Dim path As String = "\\server.greenworks.local\Company\ISS\Data Imports"
        Dim fileName As String = "free-zipcode-database.csv"
        Dim lstZP As New List(Of ZipCodeInfoFED)

        Try
            If My.Computer.Network.IsAvailable = True Then
                If System.IO.File.Exists(path & "\" & fileName) = False Then
                    My.Computer.Network.DownloadFile("http://federalgovernmentzipcodes.us/free-zipcode-database-Primary.csv", (path & "\" & fileName))
                    '' 
                    '' according to site approx (4.2megs)
                    ''
                    '' 1st) break the file apart
                    '' 2nd) dump to memory
                    '' 3rd) convert to a list of structures
                    '' 4th) clean up / release mem
                    '' because file is "bigger", i am choosing to leave this file on the local machine. 
                    '' 
                    Dim strReader As New StreamReader(path & "\" & fileName)
                    Dim arFile As New ArrayList
                    While strReader.Peek() >= 0
                        If arFile.Count < 1 Then
                            '' first line are headings.
                            arFile.Add(Replace(strReader.ReadLine(), Chr(34), "", 1, -1, CompareMethod.Text))
                        ElseIf arFile.Count >= 1 Then
                            '' these are the structures.
                            Dim line As String = Replace(strReader.ReadLine(), Chr(34), "", 1, -1, CompareMethod.Text)
                            Dim peices() = line.Split(",", 12, StringSplitOptions.None)
                            Dim struct As New ZipCodeInfoFED
                            '' ZipCode | ZipCodeType | City | State | LocationType | Lat | Long | Location | Decommissioned | TaxReturnsFiled | EstimatedPopulation | TotalWages 
                            ''  0           1             2     3         4           5     6      7            8              9                  10                   11 
                            struct.City = peices(2)
                            struct.State = peices(3)
                            struct.Lattitude = peices(5)
                            struct.Longitude = peices(6)
                            struct.RegionCountryStateCity = peices(7)
                            struct.ZipCode = peices(0)
                            struct.ZipType = peices(1)
                            struct.Population = peices(10)
                            struct.TotalWages = peices(11)
                            lstZP.Add(struct)
                        End If
                    End While
                    strReader.Close()
                    strReader = Nothing
                    Dim arStructs As New List(Of ZipCodeInfoFED)
                    arStructs = lstZP
                    Return arStructs
                ElseIf System.IO.File.Exists(path & "\" & fileName) = True Then
                    '' skip download in this step
                    '' 
                    '' 1st) break the file apart
                    '' 2nd) dump to memory
                    '' 3rd) convert to a list of structures
                    '' 4th) clean up / release mem
                    Dim strReader As New StreamReader(path & "\" & fileName)
                    Dim arFile As New ArrayList
                    While strReader.Peek() >= 0
                        If arFile.Count < 1 Then
                            '' first line are headings.
                            arFile.Add(Replace(strReader.ReadLine(), Chr(34), "", 1, -1, CompareMethod.Text))
                        ElseIf arFile.Count >= 1 Then
                            '' these are the structures.
                            Dim line As String = Replace(strReader.ReadLine(), Chr(34), "", 1, -1, CompareMethod.Text)
                            Dim peices() = line.Split(",", 12, StringSplitOptions.None)
                            Dim struct As New ZipCodeInfoFED
                            '' ZipCode | ZipCodeType | City | State | LocationType | Lat | Long | Location | Decommissioned | TaxReturnsFiled | EstimatedPopulation | TotalWages 
                            ''  0           1             2     3         4           5     6      7            8              9                  10                   11 
                            struct.City = peices(2)
                            struct.State = peices(3)
                            struct.Lattitude = peices(5)
                            struct.Longitude = peices(6)
                            struct.RegionCountryStateCity = peices(7)
                            struct.ZipCode = peices(0)
                            struct.ZipType = peices(1)
                            struct.Population = peices(10)
                            struct.TotalWages = peices(11)
                            lstZP.Add(struct)
                        End If
                    End While
                    strReader.Close()
                    strReader = Nothing
                    Dim arStructs As New List(Of ZipCodeInfoFED)
                    arStructs = lstZP
                    Return arStructs
                End If
            End If
        Catch ex As Exception
            MsgBox("There was an error retrieving the Current zip code information." & vbCrLf & "Please try again.", MsgBoxStyle.Information, "Zip Code list Error")
            Dim zpLST As New List(Of ZipCodeInfoFED)
            Return zpLST
            Exit Function
        End Try
        Return lstZP
    End Function

    '' the returned 'list' in structure format
    Public ReadOnly Property List_Of_Zip_Structures As List(Of ZipCodeInfoFED)
        Get
            Return zip_code_list
        End Get
    End Property

#End Region

#Region "Standardize State I/O"
    '' use: state = convert_state_two_Char(state)
    Public Function Convert_State_Two_Char(ByVal State As String) '' converts from "oh" to "ohio" and validates state
        State = LTrim(State)
        State = RTrim(State)
        State = State.ToUpper
        Dim retVal As String = State
        Dim state_length As Integer = Len(State)
        If state_length = 2 Then
            Dim valid As Boolean = Double_Check_Two_Char_State(State)
            If valid = True Then
                Dim c_state As String = Convert_State_By_Abbrev(State)
                Return c_state
                Exit Function
            Else
                Return "<invalid>"
                Exit Function
            End If
        Else
            Return "<invalid>"
        End If
    End Function

    '' use: state_abbrev = convert_state_byname_to_abbreviation(state)
    Public Function Convert_State_ByName_To_Abbreviation(ByVal State As String)
        State = RTrim(State)
        State = LTrim(State)
        State = CapText(State)
        Dim retVal As String = "<invalid>"
        Dim length As Integer = State.Length
        If length > 0 And State <> "" And State <> " " Then
            retVal = Convert_State_By_Name_To_Abbreviation(State)
            Return retVal
        Else
            Return retVal
            Exit Function
        End If
    End Function


    '' Internals
    Private Function Double_Check_Two_Char_State(ByVal TwoChar As String)

        TwoChar = LTrim(TwoChar)
        TwoChar = RTrim(TwoChar)

        Dim valid As Boolean = False

        If TwoChar <> "" And TwoChar <> " " Then
            TwoChar = TwoChar.ToUpper
            Select Case TwoChar
                Case Is = "AL"
                    valid = True
                    Return valid
                    Exit Function
                Case Is = "AK"
                    valid = True
                    Return valid
                    Exit Function
                Case Is = "AZ"
                    valid = True
                    Return valid
                    Exit Function
                Case Is = "AR"
                    valid = True
                    Return valid
                    Exit Function
                Case Is = "CA"
                    valid = True
                    Return valid
                    Exit Function
                Case Is = "CO"
                    valid = True
                    Return valid
                    Exit Function
                Case Is = "CT"
                    valid = True
                    Return valid
                    Exit Function
                Case Is = "DE"
                    valid = True
                    Return valid
                    Exit Function
                Case Is = "FL"
                    valid = True
                    Return valid
                    Exit Function
                Case Is = "GA"
                    valid = True
                    Return valid
                    Exit Function
                Case Is = "HI"
                    valid = True
                    Return valid
                    Exit Function
                Case Is = "ID"
                    valid = True
                    Return valid
                    Exit Function
                Case Is = "IL"
                    valid = True
                    Return valid
                    Exit Function
                Case Is = "IN"
                    valid = True
                    Return valid
                    Exit Function
                Case Is = "IA"
                    valid = True
                    Return valid
                    Exit Function
                Case Is = "KS"
                    valid = True
                    Return valid
                    Exit Function
                Case Is = "KY"
                    valid = True
                    Return valid
                    Exit Function
                Case Is = "LA"
                    valid = True
                    Return valid
                    Exit Function
                Case Is = "ME"
                    valid = True
                    Return valid
                    Exit Function
                Case Is = "MD"
                    valid = True
                    Return valid
                    Exit Function
                Case Is = "MA"
                    valid = True
                    Return valid
                    Exit Function
                Case Is = "MI"
                    valid = True
                    Return valid
                    Exit Function
                Case Is = "MN"
                    valid = True
                    Return valid
                    Exit Function
                Case Is = "MS"
                    valid = True
                    Return valid
                    Exit Function
                Case Is = "MO"
                    valid = True
                    Return valid
                    Exit Function
                Case Is = "MT"
                    valid = True
                    Return valid
                    Exit Function
                Case Is = "NE"
                    valid = True
                    Return valid
                    Exit Function
                Case Is = "NV"
                    valid = True
                    Return valid
                    Exit Function
                Case Is = "NH"
                    valid = True
                    Return valid
                    Exit Function
                Case Is = "NJ"
                    valid = True
                    Return valid
                    Exit Function
                Case Is = "NM"
                    valid = True
                    Return valid
                    Exit Function
                Case Is = "NY"
                    valid = True
                    Return valid
                    Exit Function
                Case Is = "NC"
                    valid = True
                    Return valid
                    Exit Function
                Case Is = "ND"
                    valid = True
                    Return valid
                    Exit Function
                Case Is = "OH"
                    valid = True
                    Return valid
                    Exit Function
                Case Is = "OK"
                    valid = True
                    Return valid
                    Exit Function
                Case Is = "OR"
                    valid = True
                    Return valid
                    Exit Function
                Case Is = "PA"
                    valid = True
                    Return valid
                    Exit Function
                Case Is = "RI"
                    valid = True
                    Return valid
                    Exit Function
                Case Is = "SC"
                    valid = True
                    Return valid
                    Exit Function
                Case Is = "SD"
                    valid = True
                    Return valid
                    Exit Function
                Case Is = "TN"
                    valid = True
                    Return valid
                    Exit Function
                Case Is = "TX"
                    valid = True
                    Return valid
                    Exit Function
                Case Is = "UT"
                    valid = True
                    Return valid
                    Exit Function
                Case Is = "VT"
                    valid = True
                    Return valid
                    Exit Function
                Case Is = "VA"
                    valid = True
                    Return valid
                    Exit Function
                Case Is = "WA"
                    valid = True
                    Return valid
                    Exit Function
                Case Is = "WV"
                    valid = True
                    Return valid
                    Exit Function
                Case Is = "WI"
                    valid = True
                    Return valid
                    Exit Function
                Case Is = "WY"
                    valid = True
                    Return valid
                    Exit Function
                Case Else
                    valid = False
                    Return valid
                    Exit Function
            End Select
        Else
            valid = False
            Return valid
            Exit Function
        End If
    End Function
    Private Function Convert_State_By_Abbrev(ByVal State As String)
        Dim retVal As String = "<invalid>"
        Select Case State
            Case Is = "AL"
                Return "Alabama"
                Exit Function
            Case Is = "AK"
                Return "Alaska"
                Exit Function
            Case Is = "AZ"
                Return "Arizona"
                Exit Function
            Case Is = "AR"
                Return "Arkansas"
                Exit Function
            Case Is = "CA"
                Return "California"
                Exit Function
            Case Is = "CO"
                Return "Colorado"
                Exit Function
            Case Is = "CT"
                Return "Connecticut"
                Exit Function
            Case Is = "DE"
                Return "Deleware"
                Exit Function
            Case Is = "FL"
                Return "Florida"
                Exit Function
            Case Is = "GA"
                Return "Georgia"
                Exit Function
            Case Is = "HI"
                Return "Hawaii"
                Exit Function
            Case Is = "ID"
                Return "Idaho"
                Exit Function
            Case Is = "IL"
                Return "Illinois"
                Exit Function
            Case Is = "IN"
                Return "Indiana"
                Exit Function
            Case Is = "IA"
                Return "Iowa"
                Exit Function
            Case Is = "KS"
                Return "Kansas"
                Exit Function
            Case Is = "KY"
                Return "Kentucky"
                Exit Function
            Case Is = "LA"
                Return "Louisiana"
                Exit Function
            Case Is = "ME"
                Return "Maine"
                Exit Function
            Case Is = "MD"
                Return "Maryland"
                Exit Function
            Case Is = "MA"
                Return "Massachusetts"
                Exit Function
            Case Is = "MI"
                Return "Michigan"
                Exit Function
            Case Is = "MN"
                Return "Minnesota"
                Exit Function
            Case Is = "MS"
                Return "Mississippi"
                Exit Function
            Case Is = "MO"
                Return "Missouri"
                Exit Function
            Case Is = "MT"
                Return "Montana"
                Exit Function
            Case Is = "NE"
                Return "Nebraska"
                Exit Function
            Case Is = "NV"
                Return "Nevada"
                Exit Function
            Case Is = "NH"
                Return "New Hampshire"
                Exit Function
            Case Is = "NJ"
                Return "New Jersey"
                Exit Function
            Case Is = "NM"
                Return "New Mexico"
                Exit Function
            Case Is = "NY"
                Return "New York"
                Exit Function
            Case Is = "NC"
                Return "North Carolina"
                Exit Function
            Case Is = "ND"
                Return "North Dakota"
                Exit Function
            Case Is = "OH"
                Return "Ohio"
                Exit Function
            Case Is = "OK"
                Return "Oklahoma"
                Exit Function
            Case Is = "OR"
                Return "Oregon"
                Exit Function
            Case Is = "PA"
                Return "Pennsylvania"
                Exit Function
            Case Is = "RI"
                Return "Rhode Island"
                Exit Function
            Case Is = "SC"
                Return "South Carolina"
                Exit Function
            Case Is = "SD"
                Return "South Dakota"
                Exit Function
            Case Is = "TN"
                Return "Tennessee"
                Exit Function
            Case Is = "TX"
                Return "Texas"
                Exit Function
            Case Is = "UT"
                Return "Utah"
                Exit Function
            Case Is = "VT"
                Return "Vermont"
                Exit Function
            Case Is = "VA"
                Return "Virginia"
                Exit Function
            Case Is = "WA"
                Return "Washington"
                Exit Function
            Case Is = "WV"
                Return "West Virginia"
                Exit Function
            Case Is = "WI"
                Return "Wisconsin"
                Exit Function
            Case Is = "WY"
                Return "Wyoming"
                Exit Function
            Case Else
                Return "<invalid>"
                Exit Function
        End Select
        Return retVal
    End Function
    Private Function Convert_State_By_Name_To_Abbreviation(ByVal State As String)
        State = LTrim(State)
        State = RTrim(State)
        State = CapText(State)
        Select Case State
            Case Is = "Alabama"
                Return "AL"
                Exit Function
            Case Is = "Alaska"
                Return "AK"
                Exit Function
            Case Is = "Arizona"
                Return "AZ"
                Exit Function
            Case Is = "Arkansas"
                Return "AR"
                Exit Function
            Case Is = "California"
                Return "CA"
                Exit Function
            Case Is = "Colorado"
                Return "CO"
                Exit Function
            Case Is = "Connecticut"
                Return "CT"
                Exit Function
            Case Is = "Deleware"
                Return "DE"
                Exit Function
            Case Is = "Florida"
                Return "FL"
                Exit Function
            Case Is = "Georgia"
                Return "GA"
                Exit Function
            Case Is = "Hawaii"
                Return "HI"
                Exit Function
            Case Is = "Idaho"
                Return "ID"
                Exit Function
            Case Is = "Illinois"
                Return "IL"
                Exit Function
            Case Is = "Indiana"
                Return "IN"
                Exit Function
            Case Is = "Iowa"
                Return "IA"
                Exit Function
            Case Is = "Kansas"
                Return "KA"
                Exit Function
            Case Is = "Kentucky"
                Return "KY"
                Exit Function
            Case Is = "Louisiana"
                Return "LA"
                Exit Function
            Case Is = "Maine"
                Return "ME"
                Exit Function
            Case Is = "Maryland"
                Return "MD"
                Exit Function
            Case Is = "Massachusetts"
                Return "MS"
                Exit Function
            Case Is = "Michigan"
                Return "MI"
                Exit Function
            Case Is = "Minnesota"
                Return "MN"
                Exit Function
            Case Is = "Mississippi"
                Return "MS"
                Exit Function
            Case Is = "Missouri"
                Return "MO"
                Exit Function
            Case Is = "Montana"
                Return "MT"
                Exit Function
            Case Is = "Nebraska"
                Return "NE"
                Exit Function
            Case Is = "Nevada"
                Return "NE"
                Exit Function
            Case Is = "New Hampshire"
                Return "NH"
                Exit Function
            Case Is = "New Jersey"
                Return "NJ"
                Exit Function
            Case Is = "New Mexico"
                Return "NM"
                Exit Function
            Case Is = "New York"
                Return "NY"
                Exit Function
            Case Is = "North Carolina"
                Return "NC"
                Exit Function
            Case Is = "North Dakota"
                Return "ND"
                Exit Function
            Case Is = "Ohio"
                Return "OH"
                Exit Function
            Case Is = "Oklahoma"
                Return "OK"
                Exit Function
            Case Is = "Oregon"
                Return "OR"
                Exit Function
            Case Is = "Pennsylvania"
                Return "PA"
                Exit Function
            Case Is = "Rhode Island"
                Return "RI"
                Exit Function
            Case Is = "South Carolina"
                Return "SC"
                Exit Function
            Case Is = "South Dakota"
                Return "SD"
                Exit Function
            Case Is = "Tennessee"
                Return "TN"
                Exit Function
            Case Is = "Texas"
                Return "TX"
                Exit Function
            Case Is = "Utah"
                Return "UT"
                Exit Function
            Case Is = "Vermont"
                Return "VT"
                Exit Function
            Case Is = "Virginia"
                Return "VA"
                Exit Function
            Case Is = "Washington"
                Return "WA"
                Exit Function
            Case Is = "West Virginia"
                Return "WV"
                Exit Function
            Case Is = "Wisconsin"
                Return "WI"
                Exit Function
            Case Is = "Wyoming"
                Return "WI"
                Exit Function
            Case Else
                Return "<invalid>"
                Exit Function
        End Select
    End Function

    '' creates hashtable of {state_abbrev:=state_name} pairs
    Private Function GenStateList_And_Abbreviations()
        state_list.Add("AL", "Alabama")
        state_list.Add("AK", "Alaska")
        state_list.Add("AZ", "Arizona")
        state_list.Add("AR", "Arkansas")
        state_list.Add("CA", "California")
        state_list.Add("CO", "Colorado")
        state_list.Add("CT", "Connecticut")
        state_list.Add("DE", "Deleware")
        state_list.Add("FL", "Florida")
        state_list.Add("GA", "Georgia")
        state_list.Add("HI", "Hawaii")
        state_list.Add("ID", "Idaho")
        state_list.Add("IL", "Illinois")
        state_list.Add("IN", "Indiana")
        state_list.Add("IA", "Iowa")
        state_list.Add("KS", "Kansas")
        state_list.Add("KY", "Kentucky")
        state_list.Add("LA", "Louisiana")
        state_list.Add("ME", "Maine")
        state_list.Add("MD", "Maryland")
        state_list.Add("MA", "Massachusetts")
        state_list.Add("MI", "Michigan")
        state_list.Add("MN", "Minnesota")
        state_list.Add("MS", "Mississippi")
        state_list.Add("MO", "Missouri")
        state_list.Add("MT", "Montana")
        state_list.Add("NE", "Nebraska")
        state_list.Add("NV", "Nevada")
        state_list.Add("NH", "New Hampshire")
        state_list.Add("NJ", "New Jersey")
        state_list.Add("NM", "New Mexico")
        state_list.Add("NY", "New York")
        state_list.Add("NC", "North Carolina")
        state_list.Add("ND", "North Dakota")
        state_list.Add("OH", "Ohio")
        state_list.Add("OK", "Oklahoma")
        state_list.Add("OR", "Oregon")
        state_list.Add("PA", "Pennsylvania")
        state_list.Add("RI", "Rhode Island")
        state_list.Add("SC", "South Carolina")
        state_list.Add("SD", "South Dakota")
        state_list.Add("TN", "Tennesee")
        state_list.Add("TX", "Texas")
        state_list.Add("UT", "Utah")
        state_list.Add("VT", "Vermont")
        state_list.Add("VA", "Virginia")
        state_list.Add("WA", "Washington")
        state_list.Add("WV", "West Virginia")
        state_list.Add("WI", "Wisonsin")
        state_list.Add("WY", "Wyoming")
        Return state_list
    End Function

    '' Hashtable Property for StateListGen()
    Public ReadOnly Property List_Of_States_And_Abbreviations As Hashtable
        Get
            Return state_list
        End Get
    End Property

#End Region

#Region "Standardize Time Format"
    '' For OUT operation | use:  time = splitTime(raw val from sql datetime field)
    Public Function splitTime(ByVal InputTime As String)
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

#Region "Standardize Name String"
    '' for OUT operation / printing / labeling / HTML Renders
    '' use: name = determine_name_string(fname1,lname1,fname2,lname2)
    Public Function Determine_Name_String(ByVal FName1 As String, ByVal LName1 As String, ByVal FName2 As String, ByVal LName2 As String)
        Try
            Dim retVal As String = "<invalid>"
            Dim c1_FN As Integer = FName1.Length
            Dim c1_LN As Integer = LName1.Length
            Dim c2_FN As Integer = FName2.Length
            Dim c2_LN As Integer = LName2.Length
            If c1_FN > 1 And FName1 <> " " Then '' contact1 present?
                If c2_LN > 1 And LName2 <> " " Then
                    If c1_LN = c2_LN Then   '' same last name?
                        Dim con_STR As String = (CapText(LName1) & ", " & CapText(FName1) & " and " & CapText(FName2))
                        retVal = con_STR
                        Return retVal
                        Exit Function
                    ElseIf c1_LN <> c2_LN Then '' not same last name? 
                        Dim con_STR As String = (CapText(FName1) & " " & CapText(LName1) & vbCrLf & CapText(FName2) & " " & CapText(LName2))
                        retVal = con_STR
                        Return retVal
                        Exit Function
                    End If
                ElseIf c2_FN > 1 Or FName2 <> "" Or FName2 <> " " Then '' no secondary contact info?
                    Dim con_STR As String = (CapText(FName1) & " " & CapText(LName1))
                    retVal = con_STR
                    Return retVal
                    Exit Function
                ElseIf c2_FN > 1 Or FName2 = " " Then '' Blank secondary contact info?
                    Dim con_STR As String = (CapText(FName1) & " " & CapText(LName1))
                    retVal = con_STR
                    Return retVal
                    Exit Function
                End If
            ElseIf c1_FN < 1 Or FName1 = "" Or FName1 = " " Then '' blank contact1 info?
                If c2_FN > 1 And FName2 <> " " Then '' but contact2 present?
                    Dim con_STR As String = (CapText(FName2) & " " & CapText(LName2))
                    retVal = con_STR
                    Return retVal
                    Exit Function
                End If
            End If
            Return retVal
        Catch ex As Exception
            Dim retVal As String = "<invalid>"
            Return retVal
        End Try
    End Function

#End Region

#Region "SMS Info"
    Private Function GenCarrierSMS()
        carrier_sms_gateways.Add("AllTel", "@sms.alltelwireless.com")
        carrier_sms_gateways.Add("At&t", "@txt.att.net")
        carrier_sms_gateways.Add("Boost Mobile", "@sms.myboostmobile.com")
        carrier_sms_gateways.Add("Republic Wireless", "@text.republicwireless.com")
        carrier_sms_gateways.Add("Sprint", "@messaging.sprintpcs.com")
        carrier_sms_gateways.Add("T-Mobile", "@tmomail.net")
        carrier_sms_gateways.Add("U.S. Cellular", "email.uscc.net")
        carrier_sms_gateways.Add("Verizon Wireless", "@vtext.com")
        carrier_sms_gateways.Add("Virgin Mobile", "@vmobl.com")
        Return carrier_sms_gateways
    End Function
    Public ReadOnly Property Common_SMS_Gateways As Hashtable
        Get
            Return carrier_sms_gateways
        End Get
    End Property
#End Region

#Region "Valid Email Domains - ' https://gist.githubusercontent.com/tbrianjones/5992856/raw/87f527af7bdd21997722fa65143a9af7bee92583/free_email_provider_domains.txt ' "


    '' downloads the file if not present.
    '' 
    Public Function dl_list()
        Try
            Dim lst As New ArrayList
            Dim path As String = "\\server.greenworks.local\Company\ISS\Data Imports"
            Dim fName As String = "email_domain_list.txt"
            If My.Computer.Network.IsAvailable = True Then
                If System.IO.File.Exists(path & "\" & fName) = False Then
                    My.Computer.Network.DownloadFile("https://gist.githubusercontent.com/tbrianjones/5992856/raw/87f527af7bdd21997722fa65143a9af7bee92583/free_email_provider_domains.txt", (path & "\" & fName))
                    '' now convert to an array => sorted list
                    '' 
                    Dim strReader As New StreamReader(path & "\" & fName)
                    While strReader.Peek() >= 0
                        Dim line As String = strReader.ReadLine
                        lst.Add(line)
                    End While
                    strReader.Close()
                    strReader = Nothing
                    Return lst
                    'System.IO.File.Delete(path & "\" & fName)
                    Exit Function
                ElseIf System.IO.File.Exists(path & "\" & fName) = True Then
                    'System.IO.File.Delete(path & "\" & fName)
                    ' My.Computer.Network.DownloadFile("https://gist.githubusercontent.com/tbrianjones/5992856/raw/87f527af7bdd21997722fa65143a9af7bee92583/free_email_provider_domains.txt", (path & "\" & fName))
                    '' now convert to an array => sorted list
                    '' 
                    Dim strReader As New StreamReader(path & "\" & fName)
                    While strReader.Peek() >= 0
                        Dim line As String = strReader.ReadLine
                        lst.Add(line)
                    End While
                    strReader.Close()
                    strReader = Nothing
                    Return lst
                    'System.IO.File.Delete(path & "\" & fName)
                    Exit Function
                End If
            ElseIf My.Computer.Network.IsAvailable = False Then
                MsgBox("There was a problem downloading and generating the email domain list." & vbCrLf & "Please check your network and or file paths: '%systemroot%\Temp' , and try again.", MsgBoxStyle.Information, "Problem Downloading File.")
                Return lst
                Exit Function
            End If
        Catch ex As Exception
            MsgBox("There was a problem downloading and generating the email domain list." & vbCrLf & "Please check your network and or file paths: '%systemroot%\Temp' , and try again.", MsgBoxStyle.Information, "Problem Downloading File.")
            Dim lst As New ArrayList
            Return lst
            Exit Function
        End Try
    End Function

    '' property for List Downloaded.
    Public ReadOnly Property Valid_Email_Domains As ArrayList
        Get
            Return email_list
        End Get
    End Property

#End Region

#Region "Validate Email String format only."

    '' dim returnVal as boolean = IsThisEmailValidFormat(address to check)
    ''
    Public Function IsThisEmailValidFormat(ByVal Address As String) As Boolean
        '' 
        '' copy paste code 
        '' src: http://stackoverflow.com/questions/1331084/how-do-i-validate-email-address-formatting-with-the-net-framework
        '' reason: don't reinvent the wheel.
        '' also not worth the effort [according to replies] to re-write/write your own
        '' 
        '' let .Net determine if it's valid or not
        '' function returns True if valid
        '' False if not. 
        '' 
        '' compared to: https://msdn.microsoft.com/en-us/library/01escwtf%28v=vs.110%29.aspx
        '' 

        Try
            Dim b As New System.Net.Mail.MailAddress(Address)
            b = Nothing
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function
#End Region


    Public Sub New()

        state_list = New Hashtable
        state_list = GenStateList_And_Abbreviations()
        carrier_sms_gateways = New Hashtable
        carrier_sms_gateways = GenCarrierSMS() '' wiki entry for top 10 carriers 
        email_list = New ArrayList '' list of valid email domains to compare to. {3148 Domains as of 4-14-2016}
        'email_list = dl_list()
        zip_code_list = New List(Of ZipCodeInfoFED)
        'zip_code_list = Download_Federal_Zip_Code_List()

    End Sub

End Class
