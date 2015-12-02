Imports System.Windows.Forms
Imports System.IO
Imports System.Text


Public Class ItemEndDragObj
    '' the questions. . . 
    ''
    '' what am i? File / folder
    '' what is the operation to be performed? Drag? Drop?
    '' what is the source?  Where did I come from?
    '' what is the destination? Where am I Going ? 
    '' what checks do i need to make sure that i dont fail the operation? is my file name blank? is my directory name blank? am I dropping on myself ? do i exist in target destination already ? 
    '' when do I commit these changes ? at drop event? do i exist in target destination already ? 
    '' what do i need to do once changes have been committed? 
    '' who started this operation?
    '' what does the initial construction need in terms of info? name, src directory, filename, filext , foldername, my idx in listview , target destination (gathered after another event) , parent control
    '' 
    '' not a list of these, just one at a time so destroy me after use.
    '' 
    '' no i do not need to hit a database
    '' 


    '' the ' how ' 
    ''
    Private _type As String = ""
    Private _name As String = ""
    Private _IDX As Integer = 0
    Private _Ext As String = ""
    Private _Operation As String = ""
    Private _Parent As ListView
    Private _TargetDest As String = ""
    Private _CommitChange As Boolean

    Public ReadOnly Property Type As String
        Get
            Return _type
        End Get
    End Property

    Public ReadOnly Property Name As String
        Get
            Return _name
        End Get
    End Property
    Public ReadOnly Property IDX As Integer
        Get
            Return _IDX
        End Get
    End Property
    Public ReadOnly Property Ext As String
        Get
            Return _Ext
        End Get
    End Property
    Public ReadOnly Property Operation As String
        Get
            Return _Operation
        End Get
    End Property
    Public ReadOnly Property ParentControl As ListView
        Get
            Return _Parent
        End Get
    End Property
    Public Property TargetDestination As String
        Get
            Return _TargetDest
        End Get
        Set(value As String)
            _TargetDest = value
        End Set
    End Property
    Public Property CommitThisMove As Boolean
        Get
            Return _CommitChange
        End Get
        Set(value As Boolean)
            _CommitChange = value
        End Set
    End Property
    Public Sub New(ByVal Type As String, ByVal Name As String, ByVal Ext As String, ByVal IDX As Integer, ByVal CurrentOperation As String, ByVal OwningControl As ListView)

        _type = Type
        _name = Name
        _IDX = IDX

        If Type = "File" Then
            _Ext = Ext
        ElseIf Type = "Folder" Then
            _Ext = ""
        End If
        _Operation = CurrentOperation

    End Sub

    '' 
    '' any extra utils needed to do this ? or am I just a place holder ? 
    '' 



End Class
