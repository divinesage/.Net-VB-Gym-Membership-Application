Public Class CProgram
    'represent a single record in the Program table
    Private _mstrProgID As String
    Private _mstrProgDesc As String
    Private _msngMonthFee As Single
    Private _msngAnnualDiscount As Single
    Private _isNewProgram As Boolean

    Public Property ProgID() As String
        Get
            Return _mstrProgID
        End Get
        Set(strValue As String)
            _mstrProgID = strValue
        End Set
    End Property

    Public Property ProgDesc() As String
        Get
            Return _mstrProgDesc
        End Get
        Set(strValue As String)
            _mstrProgDesc = strValue
        End Set
    End Property

    Public Property MonthFee() As Single
        Get
            Return _msngMonthFee
        End Get
        Set(strValue As Single)
            _msngMonthFee = strValue
        End Set
    End Property

    Public Property AnnualDiscount() As Single
        Get
            Return _msngAnnualDiscount
        End Get
        Set(strValue As Single)
            _msngAnnualDiscount = strValue
        End Set
    End Property

    Public Property IsNewProgram() As Boolean
        Get
            Return _isNewProgram
        End Get
        Set(blnValue As Boolean)
            _isNewProgram = blnValue
        End Set
    End Property

    Public ReadOnly Property GetSaveParameters() As ArrayList
        Get
            Dim paramList As New ArrayList
            paramList.Add(New SqlClient.SqlParameter("progid", _mstrProgID))
            paramList.Add(New SqlClient.SqlParameter("progdesc", _mstrProgDesc))
            paramList.Add(New SqlClient.SqlParameter("monthfee", _msngMonthFee))
            paramList.Add(New SqlClient.SqlParameter("annualdisc", _msngAnnualDiscount))
            Return paramList
        End Get
    End Property

    Public Function Save() As Integer
        'return -1 if the ID already exists and we can't create a new record
        If IsNewProgram Then
            Dim strRes As String = myDB.GetSingleValueFromSP("sp_CheckProgramIDExists", New SqlClient.SqlParameter("PROGID", _mstrProgID))
            If Not strRes = 0 Then
                Return -1 'ID NOT unique!!
            End If
        End If
        'if not a new member or it is new and is unique, then do the save (update or insert)
        Return myDB.ExecSP("sp_SaveProgram", GetSaveParameters)
    End Function

End Class
