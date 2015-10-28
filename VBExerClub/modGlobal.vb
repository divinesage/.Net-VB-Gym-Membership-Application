Module modGlobal
    'contains all variables, constants, procedures, and functions that need to be 
    'accessed in more than one form

    Public Const ACTION_NONE As Integer = 0
    Public Const ACTION_HOME As Integer = 1
    Public Const ACTION_MEMBER As Integer = 2
    Public Const ACTION_PROGRAM As Integer = 3
    Public Const ACTION_SHOP As Integer = 4
    Public Const ACTION_CONTACT As Integer = 5
    Public Const ACTION_HELP As Integer = 6
    Public Const ACTION_PAYMENT As Integer = 7
    Public Const ACTION_LOGIN As Integer = 8
    Public Const ACTION_STATEMENT As Integer = 9
    Public intNextAction As Integer

    'constants to manage the listview columns in frmPayment and frmStatement
    Public Const PMTID As Integer = 0
    Public Const MBRID As Integer = 1
    Public Const PROGID As Integer = 2
    Public Const DATEDUE As Integer = 3
    Public Const DATEPAID As Integer = 4
    Public Const AMTPAID As Integer = 5
    'constants to pay memberID between frmPayment and frmStatement
    Public strGMbrID As String
    Public blnGSwtchForm As Boolean = False

    Public ReadOnly NULL_DATE As Date = New Date(1900, 1, 1) 'This is what we will use when we don't have a date

    'build the database connection string - use the one apporiate for your version VS/SQL
    'use this is in GLL 266
    'Public gstrConn As String = "Data Source=(LocalDB)\v11.0;AttachDbFilename='E:\COP4005\VBExerClub - Group\VBExerClubDBU01.mdf';Integrated Security=True;Connect Timeout=30"

    'use this one at home, connected with jumpdrive 
    Public gstrConn As String = "Data Source=(LocalDB)\v11.0;AttachDbFilename='C:\Users\alex\Desktop\VBExerClub - Group\VBExerClubDBU01.mdf';Integrated Security=True;Connect Timeout=30"

    

    Public myDB As New CDB


End Module
