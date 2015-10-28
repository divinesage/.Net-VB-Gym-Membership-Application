Imports System.Data.SqlClient

Public Class CPrograms

    Private _Program As CProgram

    'constructor to initailize CProgram
    Public Sub New()
        _Program = New CProgram
    End Sub

    Public ReadOnly Property CurrentObject() As CProgram
        Get
            Return _Program
        End Get
    End Property

    Public Sub Clear() 'throw away and create new - brute force
        _Program = New CProgram

    End Sub

    Public Sub CreateNewProgram() 'call me when you are clearing the screen to add a new program
        Clear()
        _Program.isNewProgram = True

    End Sub

    Public Function Save() As Integer
        Return _Program.Save


    End Function

    'Allow to get data from the Database
    Public Function GetAllProgramID() As SqlDataReader
        Return myDB.GetDataReaderBySP("dbo.sp_GetAllProgramIDs")
    End Function

    'Allow user to bring up by descriptions
    Public Function GetProgramByDesc(strDesc As String) As CProgram
        Dim aParam As New SqlParameter("desc", strDesc)

        FillObject(myDB.GetDataReaderBySP("dbo.sp_GetProgramByDesc", aParam))
        Return _Program

    End Function

    Public Function GetProgramByID(strID As String) As CProgram
        Dim aParam As New SqlParameter("progid", strID)

        FillObject(myDB.GetDataReaderBySP("dbo.sp_GetProgramByID", aParam))
        Return _Program
    End Function

    Public Function FillObject(sqlDR As SqlDataReader) As CProgram
        Using sqlDR
            If sqlDR.Read Then 'we have data
                With _Program
                    .ProgID = sqlDR.Item("ProgID") 'use database table field name in quotes
                    .ProgDesc = sqlDR.Item("ProgDesc")
                    .MonthFee = sqlDR.Item("MonthFee")
                    .AnnualDiscount = sqlDR.Item("AnnualDiscount")
                End With
            End If
        End Using
        sqlDR.Close()
        Return _Program
    End Function
End Class
