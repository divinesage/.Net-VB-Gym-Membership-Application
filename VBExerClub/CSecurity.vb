Public Class CSecurity
    'represent a single record in the Security table
    Private _mstrEmpID As String
    Private _mstrUserID As String
    Private _mstrPassword As String
    Private _mbyteMbrArea As Byte
    Private _mbyteEmpArea As Byte
    Private _mbyteShopArea As Byte
    Private _isNewSecurity As Boolean

    Public Property EmpID() As String
        Get
            Return _mstrEmpID
        End Get
        Set(strValue As String)
            _mstrEmpID = strValue
        End Set
    End Property

    Public Property UserID() As String
        Get
            Return _mstrUserID
        End Get
        Set(strValue As String)
            _mstrUserID = strValue
        End Set
    End Property

    Public Property Password() As String
        Get
            Return _mstrPassword
        End Get
        Set(strValue As String)
            _mstrPassword = strValue
        End Set
    End Property

    Public Property MbrArea() As Byte
        Get
            Return _mbyteMbrArea
        End Get
        Set(byteValue As Byte)
            _mbyteMbrArea = byteValue
        End Set
    End Property

    Public Property EmpArea() As Byte
        Get
            Return _mbyteEmpArea
        End Get
        Set(byteValue As Byte)
            _mbyteEmpArea = byteValue
        End Set
    End Property

    Public Property ShopArea() As Byte
        Get
            Return _mbyteShopArea
        End Get
        Set(byteValue As Byte)
            _mbyteShopArea = byteValue
        End Set
    End Property

    Public Property IsNewSecurity() As Boolean
        Get
            Return _isNewSecurity
        End Get
        Set(blnValue As Boolean)
            _isNewSecurity = blnValue
        End Set
    End Property

    Public ReadOnly Property GetSaveParameters() As ArrayList
        Get
            Dim paramList As New ArrayList
            paramList.Add(New SqlClient.SqlParameter("UserID", _mstrUserID))
            paramList.Add(New SqlClient.SqlParameter("lname", _mstrPassword))
            Return paramList
        End Get
    End Property

    Public Function Login() As Integer
        If IsNewSecurity 
            Dim strRes As String = myDB.GetSingleValueFromSP("sp_CheckSecurityAccess", GetSaveParameters())
            If Not strRes = 0 Then
                Return -1
            End If
        End If
        Return 0
    End Function



End Class
