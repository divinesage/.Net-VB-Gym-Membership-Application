Public Class CProgPayment
    'represents a single record in the progpayment table

    Private _mstrPmtID As String
    Private _mstrMbrID As String
    Private _mstrProgID As String
    Private _mdtmDateDue As Date
    Private _mdtmDatePaid As Date
    Private _msngAmtPaid As Single
    Private _isNewProgPayment As Boolean

    'constructor
    Public Sub New()
        'initialize class instance variables
        _mstrPmtID = ""
        _mstrMbrID = ""
        _mstrProgID = ""
        _mdtmDateDue = New Date(Now.Year, Now.Month, Now.Day)
        _mdtmDatePaid = New Date(Now.Year, Now.Month, Now.Day)
        _msngAmtPaid = 0.0

    End Sub

    'Setters and Getters
    Public Property PmtID() As String
        Get
            Return _mstrPmtID
        End Get
        Set(strValue As String)
            _mstrPmtID = strValue
        End Set
    End Property

    Public Property MbrID() As String
        Get
            Return _mstrMbrID
        End Get
        Set(strValue As String)
            _mstrMbrID = strValue
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


    Public Property DateDue() As Date
        Get
            Return _mdtmDateDue
        End Get
        Set(dtmValue As Date)
            _mdtmDateDue = dtmValue
        End Set
    End Property

    Public Property DatePaid() As Date
        Get
            Return _mdtmDatePaid
        End Get
        Set(dtmValue As Date)
            _mdtmDatePaid = dtmValue
        End Set
    End Property

    Public Property AmtPaid() As Single
        Get
            Return _msngAmtPaid
        End Get
        Set(sngValue As Single)
            _msngAmtPaid = sngValue
        End Set
    End Property

    Public Property IsNewProgPayment() As Boolean
        Get
            Return _isNewProgPayment
        End Get
        Set(blnValue As Boolean)
            _isNewProgPayment = blnValue
        End Set
    End Property


    Public ReadOnly Property GetSaveParameters() As ArrayList
        Get
            Dim paramList As New ArrayList
            paramList.Add(New SqlClient.SqlParameter("pmtID", _mstrPmtID))
            paramList.Add(New SqlClient.SqlParameter("mbrID", _mstrMbrID))
            paramList.Add(New SqlClient.SqlParameter("progID", _mstrProgID))
            paramList.Add(New SqlClient.SqlParameter("datedue", _mdtmDateDue))
            paramList.Add(New SqlClient.SqlParameter("datepaid", _mdtmDatePaid))
            paramList.Add(New SqlClient.SqlParameter("amtpaid", _msngAmtPaid))

            Return paramList

        End Get
    End Property

    Public Function Save() As Integer
        'return -1 if the ID already exists and we can't create a new record
        If IsNewProgPayment Then
            Dim strRes As String = myDB.GetSingleValueFromSP("sp_CheckPaymentIDExists", New SqlClient.SqlParameter("pmtID", _mstrPmtID))
            If Not strRes = 0 Then
                Return -1 'ID NOT unique!!
            End If
        End If
        'if not a new  progpayment or it is new and is unique, then do the save (update and insert)
        Return myDB.ExecSP("sp_SaveProgPayment", GetSaveParameters)
    End Function

End Class
