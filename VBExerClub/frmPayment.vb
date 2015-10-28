
Imports System.Data.SqlClient
Public Class frmPayment

    Private objProgPayments As CProgPayments
    Private objMembers As CMembers
    Private objPrograms As CPrograms
    Private objReader As SqlDataReader
    Private blnClearing As Boolean
    'Private blnNewPayment As Boolean
    Private strFileName As String
    Private strAmountSelected As String ' to hold value when amount radiobutton is selected
    Private strPaymentInfoSelected As String 'to hold value when payment info radiobutton is selected
    Private strPaymentID As String
    Private dtmDueDate As Date
    Private dtmDateJoined As Date
    Private sngDiscountAmt As Single

    Private arrRadAmount(2) As RadioButton 'array of 3 RadioButton objects for Amount selection
    Private arrRadPaymentInfo(1) As RadioButton 'array of 2 RadioButton objects for Payment info section

    Private numMonths As Integer = 12 'Fixed number of months in a year

    'constructor
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        objProgPayments = New CProgPayments
        objMembers = New CMembers
        objPrograms = New CPrograms

    End Sub
    Private Sub tsbHome_Click(sender As Object, e As EventArgs) Handles tsbHome.Click
        intNextAction = ACTION_HOME
        btnClear.PerformClick()
        Me.Hide()
        'Set the action and hide
    End Sub

    Private Sub tsbMember_Click(sender As Object, e As EventArgs) Handles tsbMember.Click
        btnClear.PerformClick()
        intNextAction = ACTION_MEMBER
        Me.Hide()

    End Sub

    Private Sub tsbReturn_Click(sender As Object, e As EventArgs) Handles tsbReturn.Click
        btnClear.PerformClick()
        intNextAction = ACTION_NONE
        Me.Hide()

    End Sub

    Private Sub tsbHelp_Click(sender As Object, e As EventArgs) Handles tsbHelp.Click
        intNextAction = ACTION_HELP
        Me.Hide()

    End Sub

    Private Sub tsbContact_Click(sender As Object, e As EventArgs) Handles tsbContact.Click
        intNextAction = ACTION_CONTACT
        Me.Hide()

    End Sub

    Private Sub tsbProgram_Click(sender As Object, e As EventArgs) Handles tsbProgram.Click
        intNextAction = ACTION_PROGRAM
        Me.Hide()
    End Sub

    Private Sub tsbShop_Click(sender As Object, e As EventArgs) Handles tsbShop.Click
        intNextAction = ACTION_SHOP
        Me.Hide()

    End Sub

    Private Sub tsbPayment_Click(sender As Object, e As EventArgs) Handles tsbPayment.Click
        'do nothing. on this form
    End Sub

    Private Sub tsbProxy_MouseEnter(sender As Object, e As EventArgs) Handles tsbContact.MouseEnter, tsbReturn.MouseEnter, _
        tsbHelp.MouseEnter, tsbHome.MouseEnter, tsbMember.MouseEnter, tsbProgram.MouseEnter, tsbShop.MouseEnter, tsbPayment.MouseEnter

        'We need to do this only because we are not putting our image in the Image property, but
        'instead in the BackgroundImage property

        Dim tsbProxy As ToolStripButton

        tsbProxy = DirectCast(sender, ToolStripButton)
        tsbProxy.DisplayStyle = ToolStripItemDisplayStyle.Text

    End Sub

    Private Sub tsbProxy_MouseLeave(sender As Object, e As EventArgs) Handles tsbContact.MouseLeave, tsbReturn.MouseLeave, _
        tsbHelp.MouseLeave, tsbHome.MouseLeave, tsbMember.MouseLeave, tsbProgram.MouseLeave, tsbShop.MouseLeave, tsbPayment.MouseLeave


        'We need to do this only because we are not putting our image in the Image property, but
        'instead in the BackgroundImage property

        Dim tsbProxy As ToolStripButton

        tsbProxy = DirectCast(sender, ToolStripButton)
        tsbProxy.DisplayStyle = ToolStripItemDisplayStyle.Image

    End Sub

    Private Sub LoadMemberCombos()
        'load the member name search combo

        objReader = objMembers.GetMemberList

        
        cboName.Items.Clear()
        While objReader.Read 'rebuild the list to include current records
            cboName.Items.Add(objReader.Item("LName") & ", " & objReader.Item("FName"))
        End While
        objReader.Close()

        'Load the phone search combo
        objReader = objMembers.GetMemberPhoneList
        cboPhone.Items.Clear()
        While objReader.Read 'rebuild the list to include current records
            cboPhone.Items.Add(objReader.Item("Phone"))
        End While
        objReader.Close()


    End Sub

    Private Sub frmPayment_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim i As Integer
        

        LoadMemberCombos()

        'load the control arrays for radiobuttons
        arrRadAmount(0) = radSingleMonthAmt
        arrRadAmount(1) = radAnnualAmt
        arrRadAmount(2) = radOtherAmt

        'Disable until radOtherAmt is selected.
        cboAmtMonthOther.Visible = False


        arrRadPaymentInfo(0) = radCreditCard
        arrRadPaymentInfo(1) = radCash

        'Load Expiration Months into combobox
        For i = 1 To numMonths

            If i < 10 Then
                cboExpirationMonth.Items.Add(0 & i) 'add 0 in front of single digit months
            Else
                cboExpirationMonth.Items.Add(i)
            End If

        Next
        'Load Expiration Years into combobox
        For i = Today.Year To Today.Year + 15
            cboExpirationYear.Items.Add(i)
        Next
        'Load Other amount Months into combobox
        For i = 2 To numMonths - 1
            cboAmtMonthOther.Items.Add(i)
        Next

        tslStatus.Text = "Select Member who wants to make a Payment."
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        
        blnClearing = True
        ClearScreenControls(grpAmount)
        ClearScreenControls(grpMemberInfo)
        ClearScreenControls(grpSelect)
        ClearScreenControls(grpPaymentInfo)
        cboSearch.Items.Clear()
        picPhoto.ImageLocation = ""
        lblAnnualTotal.Text = ""
        lblMonthTotal.Text = ""
        lblOtherTotal.Text = ""
        lblProgDesc.Text = ""

        tslStatus.Text = "Select Member who wants to make a Payment."

        'Clear cbo and put back Month and year as key words
        cboExpirationMonth.Text = "Month"
        cboExpirationYear.Text = "Year"
        'Hide cbo until selected
        cboAmtMonthOther.Visible = False
        'hide groups to make a payment since member isn't selected
        grpPayment.Visible = False
        grpHistory.Visible = False

        strAmountSelected = ""
        strPaymentInfoSelected = ""

        errProv.Clear() 'clear errProv of any errors
        lvwMemHistory.Clear() 'Clear listview of Members data



        blnClearing = False

        
        LoadMemberCombos() 'reload cbo to be able to make a selection

        cboName.SelectedIndex = -1
        cboPhone.SelectedIndex = -1

    End Sub

    Private Sub LoadMemberFormByName(strFullName As String)
        Dim strNames() As String 'a string array
        'clear content of Members form first.
        ClearScreenControls(grpMemberInfo)
        strNames = strFullName.Split(","c)
        objMembers.GetMemberByName(Trim(strNames(0)), Trim(strNames(1)))
        LoadMemberData(objMembers.CurrentObject)
        'Load ProgID and calculate Payment Options specific to this user
        ClearScreenControls(grpAmount)
        objPrograms.GetProgramByID(txtProgID.Text)
        LoadAmountData(objPrograms.CurrentObject)

    End Sub
    Private Sub LoadMemberFormByPhone(strPhone As String)
        ClearScreenControls(grpMemberInfo)
        objMembers.GetMemberByPhone(strPhone)
        LoadMemberData(objMembers.CurrentObject)
        'Load ProgID and calculate Payment Options specific to this user
        ClearScreenControls(grpAmount)
        objPrograms.GetProgramByID(txtProgID.Text)
        LoadAmountData(objPrograms.CurrentObject)

    End Sub

    Private Sub cboName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboName.SelectedIndexChanged
        If Not blnClearing Then

            blnClearing = True
            cboPhone.SelectedIndex = -1
            cboSearch.SelectedIndex = -1
            cboSearch.Items.Clear()

            blnClearing = False

            LoadMemberFormByName(cboName.SelectedItem.ToString)
        End If
    End Sub

    Private Sub cboPhone_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPhone.SelectedIndexChanged
        If Not blnClearing Then

            blnClearing = True

            cboName.SelectedIndex = -1
            cboSearch.SelectedIndex = -1
            cboSearch.Items.Clear()

            blnClearing = False
            LoadMemberFormByPhone(cboPhone.SelectedItem.ToString)
        End If
    End Sub
    Private Sub LoadMemberData(aMember As CMember)
        If Not aMember Is Nothing Then
            With aMember
                txtID.Text = .MbrID
                txtLName.Text = .LName
                txtFName.Text = .FName
                txtProgID.Text = .ProgID
                picPhoto.ImageLocation = .PhotoPath
                dtmDateJoined = .DateJoined
            End With

            'Member has been selected so enable to make a payment and see payment history
            grpPayment.Visible = True
            grpHistory.Visible = True

            tslStatus.Text = "Select the Amount the Member wants to Pay and Payment Form."
            LoadListViewData() 'Load payment history of selected user
        End If
    End Sub


    Private Sub radiobuttons_CheckedChanged(sender As Object, e As EventArgs) Handles radAnnualAmt.CheckedChanged, radSingleMonthAmt.CheckedChanged, radOtherAmt.CheckedChanged
        'used to make selections in grpAmount
        If blnClearing Then
            Exit Sub
        End If

        'Dim rad As RadioButton
        'rad = DirectCast(sender, RadioButton)
        'strAmountSelected = rad.Text

        If radSingleMonthAmt.Checked Then
            'disable other just in case it was selected
            cboAmtMonthOther.Visible = False
            lblOtherTotal.Text = ""
            strAmountSelected = "Month"
        End If

        If radAnnualAmt.Checked Then
            'disable other just in case it was selected
            cboAmtMonthOther.Visible = False
            lblOtherTotal.Text = ""
            strAmountSelected = "Annual"
        End If

        If radOtherAmt.Checked Then
            'Enable to view cbo to make a month selection
            blnClearing = True

            cboAmtMonthOther.SelectedIndex = -1 'incase something was selected before
            blnClearing = False
            cboAmtMonthOther.Visible = True
            strAmountSelected = "Other"
        End If

    End Sub

    Private Sub cboAmtMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAmtMonthOther.SelectedIndexChanged
        If blnClearing Then 'Clearing and just exit sub
            Exit Sub
        End If

        'not clearing and Other Amt of Payment is selected.
        objPrograms.GetProgramByID(txtProgID.Text)
        LoadOtherAmountData(objPrograms.CurrentObject)
    End Sub

    Private Sub LoadOtherAmountData(aProgram As CProgram)
        If Not aProgram Is Nothing Then
            With aProgram
                lblOtherTotal.Text = CStr(FormatCurrency(.MonthFee * CDbl(cboAmtMonthOther.SelectedItem.ToString)))
            End With
        End If
    End Sub

    Private Sub LoadAmountData(aProgram As CProgram)
        If Not aProgram Is Nothing Then
            With aProgram
                lblProgDesc.Text = .ProgDesc
                lblMonthTotal.Text = CStr(FormatCurrency(.MonthFee))
                lblAnnualTotal.Text = CStr(FormatCurrency((.MonthFee * 12) - ((.MonthFee * 12) * .AnnualDiscount)))
                sngDiscountAmt = CSng((.MonthFee * 12) * .AnnualDiscount)

            End With
        End If
    End Sub


    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        cboSearch.Items.Clear()
        objReader = objMembers.GetMemberList

        Dim strName As String = StrConv(cboSearch.Text, vbProperCase) 'Capatializes first letter 

        'cboName.Items.Clear()
        'cboPhone.Items.Clear()
        While objReader.Read 'rebuild the list with search results

            If objReader.Item("LName").ToString.Contains(strName) Then
                cboSearch.Items.Add(objReader.Item("LName") & ", " & objReader.Item("FName"))
            End If

        End While
        objReader.Close()

        'If only one instance then pick it
        If cboSearch.Items.Count = 1 Then
            cboSearch.SelectedIndex = 0
            Exit Sub
        End If

        cboSearch.DroppedDown = True
    End Sub

    Private Sub cboSearch_KeyUp(sender As Object, e As KeyEventArgs) Handles cboSearch.KeyUp
        If e.KeyCode = Keys.Enter Then
            btnSearch.PerformClick()
            cboSearch.SelectionStart = cboSearch.Text.Length
        End If
    End Sub


    Private Sub cboSearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSearch.SelectedIndexChanged
        If Not blnClearing Then
            blnClearing = True

            cboName.SelectedIndex = -1
            cboPhone.SelectedIndex = -1
            blnClearing = False

            LoadMemberFormByName(cboSearch.SelectedItem.ToString)
        End If
    End Sub

    Private Sub radiobuttonsPaymentInfo_CheckedChanged(sender As Object, e As EventArgs) Handles radCreditCard.CheckedChanged, radCash.CheckedChanged
        'used to make selections in grpPaymentInfo
        If blnClearing Then
            Exit Sub
        End If

        Dim rad As RadioButton
        rad = DirectCast(sender, RadioButton)
        strPaymentInfoSelected = rad.Text

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        'Dim intResults As Integer
        Dim blnError As Boolean

        errProv.Clear()
        'Input Validation

        If strAmountSelected = "" Then 'an amount hasn't been selected
            errProv.SetError(grpAmount, "You must select an amount you want to pay.")
            blnError = True
        End If

        If strPaymentInfoSelected = "" Then 'a payment form wasn't selected
            errProv.SetError(grpPaymentInfo, "You must select what payment form you are going to do.")
            blnError = True
        End If

        If radOtherAmt.Checked = True And cboAmtMonthOther.SelectedIndex = -1 Then 'other radiobutton checked but didn't selected how many months
            errProv.SetError(cboAmtMonthOther, "You must make a selection here.")
            blnError = True
        End If


        If radCreditCard.Checked Then 'Check Credit Card Information is valid only if that's the form of payment being used

            mskCardNum.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals
            If Not IsNumeric(mskCardNum.Text) Then
                errProv.SetError(mskCardNum, "You must enter a valid Credit Card Number")
                blnError = True
            End If

            If Not ValidateCombo(cboExpirationMonth, errProv) Then
                blnError = True
            End If

            If Not ValidateCombo(cboExpirationYear, errProv) Then
                blnError = True
            End If

            If Not IsNumeric(mskCVV.Text) Then
                errProv.SetError(mskCVV, "You must enter a valid CVV")
                blnError = True
            End If

            If (mskCVV.Text.Length <> 3) Then
                errProv.SetError(mskCVV, "You must enter a 3 digit CVV")
                blnError = True
            End If

            If Not ValidateTextBoxLength(txtFullName, errProv) Then
                blnError = True
            End If

        End If


        If blnError = True Then
            Exit Sub
        End If

        'Depending on amount selected 
        Dim i As Integer 'for loop 
        Dim sngMonthPmt As Single 'used to pass in the monthly payment 
        sngMonthPmt = CSng(lblMonthTotal.Text)

        Select Case strAmountSelected
            Case "Month" 'Make one month Payment
                SaveProgPayment(sngMonthPmt)
            Case "Annual" 'Make 12 month Payment
                For i = 1 To 12
                    If i < 12 Then
                        SaveProgPayment(sngMonthPmt)
                    Else
                        SaveProgPayment(sngDiscountAmt)
                    End If
                Next
            Case "Other" 'Make other amount Payment based on cbo number of months picked
                For i = 1 To CSng(cboAmtMonthOther.Text)
                    SaveProgPayment(sngMonthPmt)
                Next
            Case Else
                MessageBox.Show("btnSubmit: unexpected case value", "Progrm Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Select

        'Update ListViewdata with new payment just submitted
        LoadListViewData()

        'Clear some info from screen
        For i = 0 To arrRadAmount.Length - 1
            arrRadAmount(i).Checked = False
        Next

        'For i = 0 To arrRadPaymentInfo.Length - 1
        'arrRadPaymentInfo(i).Checked = False
        'Next

        ClearScreenControls(grpPaymentInfo)

    End Sub

    Private Sub GetLastPaymentID() 'Used to formulate new Payment ID.  If table is empty -1 is returned.  If not empty then we sort table in desc order
        'and pick top payment ID.  Strip off the P and add 1 to it.  Then cast it back as a string with P1###### format

        Dim strPmtID As String = objProgPayments.GetLastPaymentID()

        If strPmtID.Contains("P") Then 'not first one so add 1 to get next user
            Dim intMbrID As Integer = CInt(strPmtID.Substring(1))
            strPaymentID = "P" & CStr(intMbrID + 1)
            Exit Sub
        End If

        If CInt(strPmtID) = -1 Then 'must be first member in table
            strPaymentID = "P1000000"
            Exit Sub
        End If

    End Sub

    Private Sub GetNextDueDate()

        Dim dtmLastDate As Date

        'Get the last DATEDUE 
        objReader = objProgPayments.GetLastPaymentDateByMbrID(CStr(txtID.Text))

        If Not objReader Is Nothing Then
            If objReader.Read() Then
                dtmLastDate = objReader.Item("DateDue")
            Else
                'no data, so have to create new DateDue based on when user joined
                dtmLastDate = dtmDateJoined
                Dim intDay As Integer = (dtmLastDate.Day) - 1 'get day to roll back to 1st of month
                dtmLastDate = dtmLastDate.AddDays(-intDay)
            End If
        End If
        objReader.Close()

        dtmDueDate = dtmLastDate.AddMonths(+1)

    End Sub

    Private Sub SaveProgPayment(aMonth As Single) 'used to enter a progpayment
        Dim intResults As Integer

        Try
            'here is where I get the next payment id value
            GetLastPaymentID()
            'strPaymentID = "P1000000"
        Catch ex As Exception
            'MessageBox.Show(ex.Message.ToString)
            MessageBox.Show("Unable to get Next Payment ID.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        'Calcuate payment Due Date
        Try
            GetNextDueDate()
        Catch ex As Exception
            'MessageBox.Show(ex.Message.ToString)
            MessageBox.Show("Unable to get Next Due Date.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        'Only able to make payments upto one year in advance from today
        If dtmDueDate > Today.AddMonths(+12) Then
            MessageBox.Show("You can only make Payments upto 1 year in advance", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'Have to do only one entry into ProgPayment table.  Storing information in objProgPayment to fill Table
        With objProgPayments.CurrentObject
            .PmtID = Trim(strPaymentID)
            .MbrID = Trim(txtID.Text)
            .ProgID = Trim(txtProgID.Text)
            .DateDue = Trim(dtmDueDate)
            .DatePaid = Today.Date
            .AmtPaid = aMonth
        End With
        Try
            Windows.Forms.Cursor.Current = Cursors.WaitCursor
            intResults = objProgPayments.Save
            tslStatus.Text = "Payment record saved"
            Windows.Forms.Cursor.Current = Cursors.Default
        Catch ex As Exception
            If intResults = -1 Then 'id value is not unique
                MessageBox.Show("Payment ID must be unique. Unable to save member record.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else ' some other error
                'good case for a mod for error handling
                Throw ex
                MessageBox.Show("Unable to save payment record.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End Try
    End Sub


    'Create ListViewData with Information
    Private Sub LoadListViewData()

        'clear listview first
        lvwMemHistory.Clear()

        Try
            'Load ListView column headers
            lvwMemHistory.Columns.Add("Payment ID")
            lvwMemHistory.Columns.Add("Member ID")
            lvwMemHistory.Columns.Add("Program ID")
            lvwMemHistory.Columns.Add("Date Due")
            lvwMemHistory.Columns.Add("Date Paid")
            lvwMemHistory.Columns.Add("Amount Paid")

            'Formatting Columns
            With lvwMemHistory
                .Columns(PMTID).Width = 100
                .Columns(MBRID).Width = 100
                .Columns(PROGID).Width = 100
                .Columns(DATEDUE).Width = 100
                .Columns(DATEPAID).Width = 100
                .Columns(AMTPAID).Width = 100
                .Columns(AMTPAID).TextAlign = HorizontalAlignment.Right
            End With

            'now get the data
            objReader = objProgPayments.GetProgPaymentListByMbrID(txtID.Text)

            While objReader.Read
                Dim lviRow As New ListViewItem(CStr(objReader.Item("PmtID")))

                'now add the rest of the columns as subitems to the listview

                Dim lsiCol1 As New ListViewItem.ListViewSubItem
                lsiCol1.Text = objReader.Item("MbrID")
                lviRow.SubItems.Add(lsiCol1) 'add teh column to the row
                Dim lsiCol2 As New ListViewItem.ListViewSubItem
                lsiCol2.Text = objReader.Item("ProgID")
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

                lvwMemHistory.Items.Add(lviRow) 'add to listview column
            End While
            objReader.Close()

        Catch ex As Exception
            'Throw ex
            MessageBox.Show("Unable to Load ListViewData.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub btnStatement_Click(sender As Object, e As EventArgs) Handles btnStatement.Click
        strGMbrID = CStr(txtID.Text)
        blnGSwtchForm = True 'going to statement form
        'intNextAction = ACTION_STATEMENT
        Me.Hide()
    End Sub

    
End Class