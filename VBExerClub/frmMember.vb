
Imports System.Data.SqlClient

Public Class frmMember
    Private objMembers As CMembers
    Private objPrograms As CPrograms
    Private objReader As SqlDataReader
    Private blnClearing As Boolean
    Private blnNew As Boolean
    Private strPhotoPath As String

    'constructor
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
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
        'do nothing i'm in this member

    End Sub

    Private Sub tsbReturn_Click(sender As Object, e As EventArgs) Handles tsbReturn.Click
        intNextAction = ACTION_NONE
        btnClear.PerformClick()
        Me.Hide()

    End Sub

    Private Sub tsbHelp_Click(sender As Object, e As EventArgs) Handles tsbHelp.Click
        intNextAction = ACTION_HELP
        btnClear.PerformClick()
        Me.Hide()

    End Sub

    Private Sub tsbContact_Click(sender As Object, e As EventArgs) Handles tsbContact.Click
        intNextAction = ACTION_CONTACT
        btnClear.PerformClick()
        Me.Hide()

    End Sub

    Private Sub tsbProgram_Click(sender As Object, e As EventArgs) Handles tsbProgram.Click

        intNextAction = ACTION_PROGRAM
        btnClear.PerformClick()
        Me.Hide()
    End Sub

    Private Sub tsbShop_Click(sender As Object, e As EventArgs) Handles tsbShop.Click
        intNextAction = ACTION_SHOP
        btnClear.PerformClick()
        Me.Hide()

    End Sub

    Private Sub tsbPayment_Click(sender As Object, e As EventArgs) Handles tsbPayment.Click
        intNextAction = ACTION_PAYMENT
        btnClear.PerformClick()
        Me.Hide()
    End Sub



    Private Sub tsbProxy_MouseEnter(sender As Object, e As EventArgs) Handles tsbContact.MouseEnter, tsbReturn.MouseEnter, _
        tsbHelp.MouseEnter, tsbHome.MouseEnter, tsbMember.MouseEnter, tsbProgram.MouseEnter, tsbShop.MouseEnter, tsbPayment.MouseEnter

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

        'load the programs combo
        objReader = objPrograms.GetAllProgramID
        cboPrograms.Items.Clear()
        While objReader.Read 'rebuild the list to include current records
            cboPrograms.Items.Add(objReader.Item("ProgID"))
        End While
        objReader.Close()

    End Sub


    Private Sub frmMember_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadMemberCombos()
    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        blnClearing = True
        ClearScreenControls(Me)
        cboSearch.Items.Clear()
        tslStatus.Text = ""
        picPhoto.ImageLocation = "" '"$(SolutionDir)\Resources\man-128.png"
        errProv.Clear()
        objMembers.CreateNewMember()
        lblmbrID.Text = ""
        txtLName.ReadOnly = True
        txtFName.ReadOnly = True
        txtAddress.ReadOnly = True
        txtCity.ReadOnly = True
        txtState.ReadOnly = True
        mskZip.ReadOnly = True
        mskPhone.ReadOnly = True
        txtEmail.ReadOnly = True
        blnNew = False
        blnClearing = False

        LoadMemberCombos() 'reload cbo boxes with users to allow to be selected.

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim intResults As Integer 'because in other program return a integer when error
        Dim blnError As Boolean

        'first do form input data validation for proper data types and non-blank fields
        '---add your validation code here----
        errProv.Clear()

        If Not ValidateTextBoxLength(txtLName, errProv) Or Not ValidateTextBoxText(txtLName, errProv) Then
            blnError = True
        End If

        If Not ValidateTextBoxLength(txtFName, errProv) Or Not ValidateTextBoxText(txtFName, errProv) Then
            blnError = True
        End If

        If Not ValidateTextBoxLength(txtAddress, errProv) Then
            blnError = True
        End If

        If Not ValidateTextBoxLength(txtCity, errProv) Or Not ValidateTextBoxText(txtCity, errProv) Then
            blnError = True
        End If

        If Not ValidateTextBoxLength(txtState, errProv) Or Not ValidateTextBoxText(txtState, errProv) Then
            blnError = True
        End If
        'If Not IsValidText(txtLName.Text) Then
        'errProv.SetError(txtLName, "You must enter a last name with letters only")
        'blnError = True
        'End If
        'If Not IsValidText(txtFName.Text) Then
        'errProv.SetError(txtFName, "You must enter a first name with letters only")
        'blnError = True
        'End If
        'If txtAddress.Text = "" Then
        'errProv.SetError(txtAddress, "You must enter an address")
        'blnError = True
        'End If

        'If Not IsValidText(txtCity.Text.Replace(" ", "")) Then
        'errProv.SetError(txtCity, "You must enter a valid city")
        'blnError = True
        'End If
        'If Not IsValidText(txtState.Text) Then
        'errProv.SetError(txtState, "You must enter a valid state")
        'blnError = True
        'End If

        mskZip.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals
        If Not IsNumeric(mskZip.Text) Then
            errProv.SetError(mskZip, "You must enter a valid zip")
            blnError = True
        End If

        If mskZip.Text.Length <> 5 And mskZip.Text.Length <> 9 Then
            errProv.SetError(mskZip, "Your zip must be 5 or 9 digits long")
            blnError = True
        End If

        mskZip.TextMaskFormat = MaskFormat.IncludeLiterals
        mskPhone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals

        If Not IsNumeric(mskPhone.Text) Then
            errProv.SetError(mskPhone, "You must enter a valid phone")
            blnError = True
        End If

        If mskPhone.Text.Length <> 10 Then
            errProv.SetError(mskPhone, "Your phone number must have 10 digits")
            blnError = True
        End If

        mskPhone.TextMaskFormat = MaskFormat.IncludeLiterals
        If dtmJoined.Value.Date <> SafeDate(dtmJoined.Text) Then
            errProv.SetError(dtmJoined, "You must enter a valid date")
            blnError = True
        End If
        If Not IsValidEmail(txtEmail.Text) Then
            errProv.SetError(txtEmail, "You must enter a valid email address")
            blnError = True
        End If
        If cboPrograms.SelectedIndex = -1 Then
            errProv.SetError(cboPrograms, "You must select a program")
            blnError = True
        End If

        'Pic is Optional
        'If picPhoto.ImageLocation Is Nothing Then
        'errProv.SetError(picPhoto, "You must add a Member's Photo")
        ' blnError = True
        'End If

        If blnError Then
            Exit Sub
        End If

        'now load the CMember object with from data
        With objMembers.CurrentObject
            .MbrID = Trim(lblmbrID.Text) 'trim strips off leading and trailing blanks
            .FName = Trim(txtFName.Text)
            .LName = Trim(txtLName.Text)
            .Address = Trim(txtAddress.Text)
            .City = Trim(txtCity.Text)
            .State = Trim(txtState.Text)
            .Zip = mskZip.Text
            .Phone = mskPhone.Text
            .DateJoined = dtmJoined.Value.Date
            .Email = Trim(txtEmail.Text)
            .ProgID = cboPrograms.SelectedItem.ToString
            .PhotoPath = Trim(strPhotoPath)
        End With
        'now give the CMember object back to the business layer
        Try
            Windows.Forms.Cursor.Current = Cursors.WaitCursor
            intResults = objMembers.Save
            tslStatus.Text = "Member record saved"
            Windows.Forms.Cursor.Current = Cursors.Default
        Catch ex As Exception
            If intResults = -1 Then 'id value is not unique
                MessageBox.Show("Member ID must be unique. Unable to save member record.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else ' some other error
                'good case for a mod for error handling
                Throw ex
                MessageBox.Show("Unable to save member record.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End Try

        'clears screen when you do a search and return no info.  Don't want to confuse the user.
        blnClearing = True
        ClearScreenControls(grpSearch)
        ClearScreenControls(grpMemberInfo) 'not sure if I have to do this once I save a new Member
        picPhoto.ImageLocation = "" 'clear pic when done with saving
        lblmbrID.Text = "" 'clear member ID label
        blnClearing = False

        LoadMemberCombos() 'once you save a member add to ComboBox. To reload and show new user

    End Sub


    Private Sub LoadMemberData(aMember As CMember)
        If Not aMember Is Nothing Then
            With aMember
                lblmbrID.Text = .MbrID
                txtLName.Text = .LName
                txtFName.Text = .FName
                txtAddress.Text = .Address
                txtCity.Text = .City
                txtState.Text = .State
                mskZip.Text = .Zip
                mskPhone.Text = .Phone
                dtmJoined.Text = .DateJoined
                txtEmail.Text = .Email
                cboPrograms.SelectedIndex = cboPrograms.FindStringExact(.ProgID)
                picPhoto.ImageLocation = .PhotoPath
            End With
        End If
    End Sub

    Private Sub LoadMemberFormByName(strFullName As String)
        Dim strNames() As String 'a string array
        'clear content of Members form first.
        ClearScreenControls(grpMemberInfo)
        picPhoto.ImageLocation = "" ' clear picPhoto
        strNames = strFullName.Split(","c)
        objMembers.GetMemberByName(Trim(strNames(0)), Trim(strNames(1)))
        LoadMemberData(objMembers.CurrentObject)
    End Sub
    Private Sub LoadMemberFormByPhone(strPhone As String)
        ClearScreenControls(grpMemberInfo)
        objMembers.GetMemberByPhone(strPhone)
        LoadMemberData(objMembers.CurrentObject)
    End Sub

    Private Sub cboName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboName.SelectedIndexChanged
        If Not blnClearing Then
            blnNew = False
            blnClearing = True
            cboPhone.SelectedIndex = -1
            cboSearch.SelectedIndex = -1
            cboSearch.Items.Clear()
            chkNew.Checked = False
            blnClearing = False
            LoadMemberFormByName(cboName.SelectedItem.ToString)
        End If
    End Sub

    Private Sub cboPhone_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPhone.SelectedIndexChanged
        If Not blnClearing Then
            blnNew = False
            blnClearing = True
            cboName.SelectedIndex = -1
            cboSearch.SelectedIndex = -1
            cboSearch.Items.Clear()
            chkNew.Checked = False
            blnClearing = False
            LoadMemberFormByPhone(cboPhone.SelectedItem.ToString)
        End If
    End Sub

    Private Sub chkNew_CheckedChanged(sender As Object, e As EventArgs) Handles chkNew.CheckedChanged
        If chkNew.CheckState = CheckState.Checked Then
            blnNew = True
            ClearScreenControls(grpMemberInfo)
            blnClearing = True
            'nothing in search cbo
            cboName.SelectedIndex = -1
            cboPhone.SelectedIndex = -1
            cboSearch.SelectedIndex = -1
            cboSearch.Items.Clear()

            'make all textboxes writeable
            txtLName.ReadOnly = False
            txtFName.ReadOnly = False
            txtAddress.ReadOnly = False
            txtCity.ReadOnly = False
            txtState.ReadOnly = False
            mskZip.ReadOnly = False
            mskPhone.ReadOnly = False
            txtEmail.ReadOnly = False


            Try
                'here is where you build the next member id value
                GetLastMemberID()

            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString)
            End Try
            blnClearing = False
        Else
            blnNew = False
        End If
    End Sub

    Private Sub GetLastMemberID() 'Used to formulate new Member ID.  If table is empty -1 is returned.  If not empty then we sort table in desc order
        'and pick top member ID.  Strip off the M and add 1 to it.  Then cast it back as a string with M5### format

        Dim strMbrID As String = objMembers.GetLastMemberID()

        If strMbrID.Contains("M") Then 'not first one so add 1 to get next user
            Dim intMbrID As Integer = CInt(strMbrID.Substring(1))
            lblmbrID.Text = "M" & CStr(intMbrID + 1)
            Exit Sub
        End If

        If CInt(strMbrID) = -1 Then 'must be first member in table
            lblmbrID.Text = "M5001"
            Exit Sub
        End If

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        cboSearch.Items.Clear()

        objReader = objMembers.GetMemberList

        Dim strName As String = StrConv(cboSearch.Text, vbProperCase) 'Capatializes first letter


        'cboName.Items.Clear()
        'cboPhone.Items.Clear()
        chkNew.Checked = False


        While objReader.Read 'rebuild the list to include current records
            'cboName.Items.Add(objReader.Item("LName") & ", " & objReader.Item("FName"))
            If objReader.Item("LName").ToString.Contains(strName) Then
                cboSearch.Items.Add(objReader.Item("LName") & ", " & objReader.Item("FName"))
            End If
        End While
        objReader.Close()

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
            blnNew = False
            blnClearing = True
            cboName.SelectedIndex = -1
            cboPhone.SelectedIndex = -1
            chkNew.Checked = False
            blnClearing = False
            LoadMemberFormByName(cboSearch.SelectedItem.ToString)
            cboSearch.Items.Clear()
            cboSearch.Text = ""
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim intResult As Integer

        ofdOpen.InitialDirectory = Application.StartupPath

        'Melba
        ofdOpen.Filter = "All Picture Files (*.*)|*.*|JPEG (*.jpg,*.jpeg,*.jpe,*.jfif)|*.jpg,*.jpeg,*.jpe,*.jfif|GIF(*.gif)|*.gif|PNG (*.png)|*.png"

        'Michael
        'ofdOpen.Filter = "All Picture Files (*.jpg;*.jpeg;*.jpe;*.jfif;*.gif;*.png)|*.jpg;*.jpeg;*.jpe;*.jfif;*.gif;*.png|JPEG (*.jpg;*.jpeg;*.jpe;*.jfif)|*.jpg;*.jpeg;*.jpe;*.jfif|GIF(*.gif)|*.gif|PNG (*.png)|*.png"

        ofdOpen.FilterIndex = 4 'want .png to be default
        intResult = ofdOpen.ShowDialog
        If intResult = DialogResult.Cancel Then 'user clicked cancel button
            Exit Sub
        End If

        strPhotoPath = ofdOpen.FileName

        Try
            picPhoto.ImageLocation = strPhotoPath
        Catch ex As Exception
            MessageBox.Show("Could Not Upload Image", "File Open Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class