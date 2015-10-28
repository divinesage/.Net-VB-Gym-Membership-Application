Public Class CMember
    'represents a single record in the members table

    Private _mstrMbrID As String
    Private _mstrLName As String
    Private _mstrFName As String
    Private _mstrAddress As String
    Private _mstrCity As String
    Private _mstrState As String
    Private _mstrZip As String
    Private _mstrPhone As String
    Private _mdtmDateJoined As Date
    Private _mstrEmail As String
    Private _mstrProgID As String
    Private _mstrPhotoPath As String
    Private _isNewMember As Boolean

    'constructor
    Public Sub New()
        'initialize class instance variables
        _mstrMbrID = ""
        _mstrLName = ""
        _mstrFName = ""
        _mstrAddress = ""
        _mstrCity = ""
        _mstrState = ""
        _mstrZip = ""
        _mstrPhone = ""
        _mstrEmail = ""
        _mstrProgID = ""
        _mstrPhotoPath = ""
        'do the rest here
        'date values are initialized to 1/1/0001 by default, so we set it to today
        _mdtmDateJoined = New Date(Now.Year, Now.Month, Now.Day)

    End Sub

    Public Property MbrID() As String
        Get
            Return _mstrMbrID
        End Get
        Set(strValue As String)
            _mstrMbrID = strValue

        End Set
    End Property

    Public Property LName() As String
        Get
            Return _mstrLName
        End Get
        Set(strValue As String)
            _mstrLName = strValue

        End Set
    End Property

    Public Property FName() As String
        Get
            Return _mstrFName
        End Get
        Set(strValue As String)
            _mstrFName = strValue

        End Set
    End Property

    Public Property Address() As String
        Get
            Return _mstrAddress
        End Get
        Set(strValue As String)
            _mstrAddress = strValue

        End Set
    End Property

    Public Property City() As String
        Get
            Return _mstrCity
        End Get
        Set(strValue As String)
            _mstrCity = strValue

        End Set
    End Property

    Public Property State() As String
        Get
            Return _mstrState
        End Get
        Set(strValue As String)
            _mstrState = strValue

        End Set
    End Property

    Public Property Zip() As String
        Get
            Return _mstrZip
        End Get
        Set(strValue As String)
            _mstrZip = strValue

        End Set
    End Property


    Public Property Phone() As String
        Get
            Return _mstrPhone
        End Get
        Set(strValue As String)
            _mstrPhone = strValue

        End Set
    End Property

    Public Property Email() As String
        Get
            Return _mstrEmail
        End Get
        Set(strValue As String)
            _mstrEmail = strValue

        End Set
    End Property

    Public Property ProgID() As String
        Get
            Return _mstrProgID
        End Get
        Set(strValue As String)
            _mstrProgID = strValue

        End Set
    End Property

    Public Property DateJoined() As Date
        Get
            Return _mdtmDateJoined
        End Get
        Set(dtmValue As Date)
            _mdtmDateJoined = dtmValue
        End Set
    End Property

    Public Property PhotoPath() As String
        Get
            Return _mstrPhotoPath
        End Get
        Set(strVal As String)
            _mstrPhotoPath = strVal
        End Set
    End Property

    Public Property IsNewMember() As Boolean
        Get
            Return _isNewMember
        End Get
        Set(blnVal As Boolean)
            _isNewMember = blnVal
        End Set
    End Property

    Public ReadOnly Property GetSaveParameters() As ArrayList
        Get
            Dim paramList As New ArrayList
            paramList.Add(New SqlClient.SqlParameter("mbrID", _mstrMbrID))
            paramList.Add(New SqlClient.SqlParameter("lname", _mstrLName))
            paramList.Add(New SqlClient.SqlParameter("fname", _mstrFName))
            paramList.Add(New SqlClient.SqlParameter("address", _mstrAddress))
            paramList.Add(New SqlClient.SqlParameter("city", _mstrCity))
            paramList.Add(New SqlClient.SqlParameter("state", _mstrState))
            paramList.Add(New SqlClient.SqlParameter("zip", _mstrZip))
            paramList.Add(New SqlClient.SqlParameter("phone", _mstrPhone))
            paramList.Add(New SqlClient.SqlParameter("datejoined", _mdtmDateJoined))
            paramList.Add(New SqlClient.SqlParameter("email", _mstrEmail))
            paramList.Add(New SqlClient.SqlParameter("progid", _mstrProgID))
            paramList.Add(New SqlClient.SqlParameter("photopath", _mstrPhotoPath))

            Return paramList
        End Get
    End Property

    
    Public Function Save() As Integer
        'return -1 if the ID already exists and we can't create a new record
        If IsNewMember Then
            Dim strRes As String = myDB.GetSingleValueFromSP("sp_CheckMemberIDExists", New SqlClient.SqlParameter("MbrID", _mstrMbrID))
            If Not strRes = 0 Then
                Return -1 'ID NOT unique!!
            End If
        End If
        'if not a new member or it is new and is unique, then do the save (update or insert)
        Return myDB.ExecSP("sp_SaveMember", GetSaveParameters)
    End Function
End Class
