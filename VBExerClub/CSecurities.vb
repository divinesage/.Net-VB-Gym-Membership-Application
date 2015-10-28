Imports System.Data.SqlClient

Public Class CSecurities

    Private _Security As CSecurity

    'constructor to initailize CSecurity
    Public Sub New()
        _Security = New CSecurity
    End Sub

    Public ReadOnly Property CurrentObject() As CSecurity
        Get
            Return _Security
        End Get
    End Property

    Public Sub Clear() 'throw away and create new - brute force
        _Security = New CSecurity

    End Sub

    Public Sub CreateNewSecurity() 'call me when you are clearing the screen to add a new program
        Clear()
        _Security.IsNewSecurity = True

    End Sub

    Public Function Login() As Integer
        Return _Security.Login
    End Function

    'Allow to get data from the Database
    Public Function CheckLoginAccess(strUserID As String, strPassword As String) As CSecurity
        Dim params As New ArrayList
        Dim aParam1 As New SqlParameter("userID", strUserID)
        params.Add(aParam1)
        Dim aParam2 As New SqlParameter("password", strPassword)
        params.Add(aParam2)
        FillObject(myDB.GetDataReaderBySP("dbo.sp_CheckSecurityAccess", params))
        Return _Security
    End Function

    Public Function FillObject(sqlDR As SqlDataReader) As CSecurity
        Using sqlDR
            If sqlDR.Read Then 'have a row to read always have to check
                With _Security
                    .UserID = sqlDR.Item("UserID") & ""
                    .Password = sqlDR.Item("password") & ""
                End With
                'failed for some reason.  need to program this
            End If
        End Using
        Return _Security
        sqlDR.Close()
    End Function
End Class
