Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Net.Sockets
Imports MapPoint
Imports AxMapPoint

Module STATIC_VARIABLES
    'Public Const ProgramName As String = "Improveit! 360"
    'Public SMN As New Collection
    'Public oApp As MapPoint.Application
    '' Public CurrentUser As String = ""
    'Public CurrentManager As String = ""
    'Public Cnn As String = "Data Source=192.168.1.2;Initial Catalog=iss;User Id=sa;Password=spoken1;"
    'Public CnnTimedRefresh As String = "Data Source=192.168.1.2;Initial Catalog=iss;User Id=sa;Password=spoken1;"
    'Public CnnCustomerHistory As String = "Data Source=192.168.1.2;Initial Catalog=iss;User Id=sa;Password=spoken1;"
    'Public AttachedFilesDirectory As String = "\\SERVER\Company\ISS\Attached Files\"
    'Public SAAttachedFileDirectory As String = "\\SERVER\Company\ISS\ScheduledActionAttachments\"
    'Public JobPicturesFileDirectory As String = "\\SERVER\Company\ISS\Job Pictures\"
    'Public EmailDirectory As String = "\\SERVER\Company\ISS\Email Leads\" & Date.Now.ToString & "\"
    'Public Update As Boolean = False
    'Public New_SA_Dept As String = ""




    Public Const ProgramName As String = "Improveit! 360"
    Public SMN As New Collection
    Public oApp As MapPoint.Application
    ' Public CurrentUser As String = ""
    Public CurrentManager As String = ""
    'Public Cnn As String = "Data Source=SERVER1;Initial Catalog=iss;User Id=sa;Password=Spoken1!;"
    'Public CnnTimedRefresh As String = "Data Source=SERVER1;Initial Catalog=iss;User Id=sa;Password=Spoken1!;"
    'Public CnnCustomerHistory As String = "Data Source=SERVER1;Initial Catalog=iss;User Id=sa;Password=Spoken1!;"
    'Public Import_cnx As String = "Data Source=SERVER1;Initial Catalog=iss;User Id=sa;Password=Spoken1!;"
    'Public Data_Dump_cnx As String = "Data Source=SERVER1;Initial Catalog=iss;User Id=sa;Password=Spoken1!;"
    'Public Test_cnx As String = "Data Source=SERVER1;Initial Catalog=iss;User Id=sa;Password=Spoken1!;Timeout=5;"

    Public Cnn As String = "SERVER=PC-101\DEVMIRROREXPRESS;DATABASE=ISS_DEV;User Id=sa;Password=Legend1!"
    Public CnnTimedRefresh As String = "SERVER=PC-101\DEVMIRROREXPRESS;DATABASE=ISS_DEV;User Id=sa;Password=Legend1!"
    Public CnnCustomerHistory As String = "SERVER=PC-101\DEVMIRROREXPRESS;DATABASE=ISS_DEV;User Id=sa;Password=Legend1!"
    Public Import_cnx As String = "SERVER=PC-101\DEVMIRROREXPRESS;DATABASE=ISS_DEV;User Id=sa;Password=Legend1!"
    Public Data_Dump_cnx As String = "SERVER=PC-101\DEVMIRROREXPRESS;DATABASE=ISS_DEV;User Id=sa;Password=Legend1!"
    Public Test_cnx As String = "SERVER=PC-101\DEVMIRROREXPRESS;DATABASE=ISS_DEV;User Id=sa;Password=Legend1!"


    'Public AttachedFilesDirectory As String = "\\server1\ISS\Attached Files\"
    Public AttachedFilesDirectory As String = "C:\Users\Clay\Desktop\ISS_DEV\ISS\Attached Files\"
    'Public SAAttachedFileDirectory As String = "\\server1\ISS\ScheduledActionAttachments\"
    Public SAAttachedFileDirectory As String = "C:\Users\Clay\Desktop\ISS_DEV\ISS\ScheduledActionAttachments\"
    'Public JobPicturesFileDirectory As String = "\\server1\ISS\Job Pictures\"
    Public JobPicturesFileDirectory As String = "C:\Users\Clay\Desktop\ISS_DEV\ISS\Job Pictures\"
    'Public EmailDirectory As String = "\\server1\ISS\Email Leads\" & Date.Now.ToString & "\"
    Public EmailDirectory As String = "C:\Users\Clay\Desktop\ISS_DEV\ISS\Email Leads\" & Date.Now.ToString & "\"
    'Public ErrorLogFilePath As String = "\\server1\ISS\Logs\"
    Public ErrorLogFilePath As String = "C:\Users\Clay\Desktop\ISS_DEV\Logs\"
    'Public Server_directory_print As String = "\\server1\ISS\Print Leads\"
    Public Server_directory_print As String = "C:\Users\Clay\Desktop\ISS_DEV\Print Leads\"
    'Public Import_Report As String = "\\server1\ISS\Data Automation Reports\"
    Public Import_Report As String = "C:\Users\Clay\Desktop\ISS_DEV\Data Automation Reports\"
    'Public ReportDirectory As String = "\\server1\ISS\Sales Performance Reports\"
    Public ReportDirectory As String = "C:\Users\Clay\Desktop\ISS_DEV\Sales Performance Reports\"
    'Public Icon_Path As String = "\\server1\ISS\IMGS\print 32.ico"
    Public Icon_Path As String = "C:\Users\Clay\Desktop\ISS_DEV\IMGS\print 32.ico"
    'Public Log_Path As String = "\\server1\ISS\Logs\"
    Public Log_Path As String = "C:\Users\Clay\Desktop\ISS_DEV\Errors\"
    'Public Alert_Wav_File As String = "\\server1\ISS\samsung_whistle.wav"
    Public Alert_Wav_File As String = "C:\Users\Clay\Desktop\ISS_DEV\samsung_whistle.wav"

    Public Update As Boolean = False
    Public New_SA_Dept As String = ""




#Region "User Information"

    '' all of these public vars are essentially useless now due to 
    '' me creating a user obj for public var employee as (userobj) 
    '' just an fyi. 
    '' can access all this information via CLASS: USER_LOGIC_v2 => Func: Get_User_Obj(args) => dim var => "var.[Property/Field]" 
    '' 11-14-2015 AC

    Public Login As String = ""
    Public CurrentUser As String = ""
    Public CurrentID As String = ""
    Public UserPWD As String = ""
    Public ColdCall As Boolean
    Public WarmCall As Boolean
    Public PreviousCust As Boolean
    Public Recovery As Boolean
    Public Confirmer As Boolean
    Public SalesManager As Boolean
    Public MarketingManager As Boolean
    Public Finance As Boolean
    Public Install As Boolean
    Public Administration As Boolean
    Public StartUpForm As String = ""
    Public CurrentForm As String = ""
    Public LoggedOn As Boolean
    Public DoNotShowMapping As Boolean
    Public ManagerFirstName As String = ""
    Public ManagerLastName As String = ""
    Public MachineName As String = ""
    Public IP As String = ""
    Public LicenseKey As String = "AAAAA-BBBBB-CCCCC-DDDDD-FFFFF-1"
    Public LeaseKey As String = "000-00000-001"
    Public Server_Assigned_Hash As String = ""
    Public NET_CLIENT As TcpClient
    Public ActiveChild As Form
    Public PendingXFER As Boolean = False
    Public salesworkaround As Boolean = True


    Public CurrentLoggedInEmployee As USER_LOGICv2.UserObj
    Public employee As New List(Of USER_LOGICv2.UserObj)
    Public CurrentExclusionSet As EmailIssuedLeads.Exclusions





#End Region
End Module

