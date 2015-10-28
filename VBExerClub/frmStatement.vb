
Imports System.Data.SqlClient
Public Class frmStatement
    Private objReader As SqlDataReader
    Private objProgPayments As CProgPayments
    Private objMembers As CMembers

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        objProgPayments = New CProgPayments
        objMembers = New CMembers
        
    End Sub


    Private Sub LoadTheMemberData(aMember As CMember)
        If Not aMember Is Nothing Then
            With aMember

                lblId.Text = .MbrID
                lblName.Text = .FName
                lblEmail.Text = .Email
                lblDateJ.Text = .DateJoined

            End With
        End If
    End Sub

    Private Sub LoadListViewData()



        'clear listview first
        lvwStatement.Clear()

        Try
            'Load ListView column headers
            lvwStatement.Columns.Add("Payment ID")
            lvwStatement.Columns.Add("Program ID")
            lvwStatement.Columns.Add("Month Paid")
            lvwStatement.Columns.Add("Date Due")
            lvwStatement.Columns.Add("Date Paid")
            lvwStatement.Columns.Add("Amount Paid")

            'Formatting Columns
            With lvwStatement
                .Columns(PMTID).Width = 100
                .Columns(MBRID).Width = 100
                .Columns(PROGID).Width = 100
                .Columns(DATEDUE).Width = 100
                .Columns(DATEPAID).Width = 100
                .Columns(AMTPAID).Width = 100
                .Columns(AMTPAID).TextAlign = HorizontalAlignment.Right
            End With

            'now get the data
            objReader = objProgPayments.GetProgPaymentListByMbrID(strGMbrID)

            While objReader.Read
                Dim lviRow As New ListViewItem(CStr(objReader.Item("PmtID")))

                'now add the rest of the columns as subitems to the listview

                Dim lsiCol1 As New ListViewItem.ListViewSubItem
                lsiCol1.Text = objReader.Item("MbrID")
                lviRow.SubItems.Add(lsiCol1) 'add teh column to the row
                Dim lsiCol2 As New ListViewItem.ListViewSubItem
                lsiCol2.Text = MonthName(Month(objReader.Item("DatePaid")), True)
                lviRow.SubItems.Add(lsiCol2)
                Dim lsiCol3 As New ListViewItem.ListViewSubItem
                lsiCol3.Text = objReader.Item("DateDue")
                lviRow.SubItems.Add(lsiCol3)
                Dim lsiCol4 As New ListViewItem.ListViewSubItem
                lsiCol4.Text = objReader.Item("DatePaid")
                lviRow.SubItems.Add(lsiCol4)
                Dim lsiCol5 As New ListViewItem.ListViewSubItem
                lsiCol5.Text = FormatCurrency(objReader.Item("AmtPaid"))
                lviRow.SubItems.Add(lsiCol5)

                lvwStatement.Items.Add(lviRow) 'add to listview column
            End While
            objReader.Close()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Private Sub frmStatement_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        objProgPayments.CreateNewProgPayment()

        objMembers.GetMemberByID(strGMbrID)
        LoadTheMemberData(objMembers.CurrentObject)

        LoadListViewData()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        lvwStatement.Clear()
        blnGSwtchForm = False
        intNextAction = ACTION_PAYMENT
        Me.Hide()

    End Sub

    
End Class