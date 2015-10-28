Imports System.Data.SqlClient
Public Class CProgPayments
    'This class represents the progpayment table and the associated buisness rules
    Private _ProgPayment As CProgPayment

    'constructor
    Public Sub New()
        'instaintiate the CProgPayment object
        _ProgPayment = New CProgPayment
    End Sub

    Public ReadOnly Property CurrentObject() As CProgPayment
        Get
            Return _ProgPayment
        End Get
    End Property

    Public Sub Clear()
        _ProgPayment = New CProgPayment
    End Sub

    Public Sub CreateNewProgPayment() 'call me when you are clearing the screen to create a new progpayment
        Clear()
        _ProgPayment.IsNewProgPayment = True

    End Sub

    Public Function Save() As Integer
        Return _ProgPayment.Save
    End Function

    Public Function GetLastPaymentID() As String
        'get last ID so we can add next member
        Dim strPaymentID = myDB.GetSingleValueFromSP("dbo.sp_GetLastPaymentID")
        Return strPaymentID
    End Function

    'Not sure I need this yet
    Public Function FillObject(sqlDR As SqlDataReader) As CProgPayment
        Using sqlDR
            If sqlDR.Read Then 'have a row to read always have to check
                With _ProgPayment
                    .PmtID = sqlDR.Item("PmtID") & "" 'Used to make sure we have a value and not NULL
                    .MbrID = sqlDR.Item("MbrID") & ""
                    .ProgID = sqlDR.Item("ProgID") & ""
                    .DateDue = sqlDR.Item("DateDue") & ""
                    .DatePaid = sqlDR.Item("DatePaid") & ""
                    .AmtPaid = sqlDR.Item("AmtPaid") & ""
                End With
                'failed for some reason.  need to program this
            End If
        End Using
        sqlDR.Close()
        Return _ProgPayment
    End Function

    Public Function GetProgPaymentListByMbrID(strMbrID As String) As SqlDataReader
        Dim aParam As New SqlParameter("id", strMbrID)
        Return myDB.GetDataReaderBySP("dbo.sp_GetProgPaymentListByMbrID", aParam)
    End Function


    Public Function GetLastPaymentDateByMbrID(strMbrID As String) As SqlDataReader
        Dim aParam As New SqlParameter("id", strMbrID)
        Return myDB.GetDataReaderBySP("dbo.sp_GetLastPaymentDateByMbrID", aParam)
    End Function
End Class
