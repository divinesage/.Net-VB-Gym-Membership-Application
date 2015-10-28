Public Class frmProgram

    Private objPrograms As CPrograms
    Private blnClearing As Boolean

    'constructor
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        objPrograms = New CPrograms

    End Sub

    Private Sub tsbHome_Click(sender As Object, e As EventArgs) Handles tsbHome.Click
        intNextAction = ACTION_HOME
        btnClear.PerformClick()
        Me.Hide()
        'Set the action and hide
    End Sub

    Private Sub tsbMember_Click(sender As Object, e As EventArgs) Handles tsbMember.Click
        intNextAction = ACTION_MEMBER
        btnClear.PerformClick()
        Me.Hide()

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
        'do nothing i'm in this program

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

    Private Sub LoadPrograms() 'load listbox 
        Dim objReader As SqlClient.SqlDataReader
        lstPrograms.Items.Clear()

        objReader = objPrograms.GetAllProgramID()
        Do While objReader.Read 'has data
            lstPrograms.Items.Add(objReader.Item("ProgID")) 'name of db

        Loop
        'after loading all data

        objReader.Close() 'must close the reader.  if you don't you won't be able to open another.  VERY IMPORTANT!!!
    End Sub


    Private Sub lstPrograms_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPrograms.SelectedIndexChanged
        'Load textboxes when user selects a program ID from the listbox

        If blnClearing Then
            Exit Sub
        End If

        Try
            objPrograms.GetProgramByID(lstPrograms.SelectedItem.ToString) 'go to program and get this programID
            'now load the textboxes
            With objPrograms.CurrentObject
                txtProgID.Text = .ProgID
                txtDesc.Text = .ProgDesc
                txtMonthlyFee.Text = FormatNumber(.MonthFee)
                txtAnnDiscount.Text = FormatNumber(.AnnualDiscount)
            End With
        Catch ex As Exception
            MessageBox.Show("Error Loading program values", "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmProgram_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        LoadPrograms()

    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        blnClearing = True
        ClearScreenControls(Me)
        tslStatus.Text = ""
        blnClearing = False
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'First do input data validation

        Dim blnError As Boolean

        errProv.Clear()

        '-----add your data validation here--------
        If Not ValidateProgID(txtProgID, errProv) Or ValidateTextBoxLength(txtProgID, errProv) Then
            blnError = True
        End If
        If Not ValidateTextBoxText(txtDesc, errProv) Or ValidateTextBoxLength(txtDesc, errProv) Then
            blnError = True
        End If
        If Not ValidateTextBoxNumeric(txtMonthlyFee, errProv) Or ValidateTextBoxLength(txtMonthlyFee, errProv) Then
            blnError = True
        End If
        If Not ValidateTextBoxNumeric(txtAnnDiscount, errProv) Or ValidateTextBoxLength(txtAnnDiscount, errProv) Then
            blnError = True
        End If
        If blnError Then
            Exit Sub
        End If

        'if we get here , all the data is good
        With objPrograms.CurrentObject
            .ProgID = txtProgID.Text
            .ProgDesc = txtDesc.Text
            .MonthFee = CSng(txtMonthlyFee.Text)
            .AnnualDiscount = CSng(txtAnnDiscount.Text)
        End With

        Try
            Windows.Forms.Cursor.Current = Cursors.WaitCursor
            objPrograms.Save()
            Windows.Forms.Cursor.Current = Cursors.Default 'Change back or waits forever
            tslStatus.Text = "Record sucessfully saved"
        Catch ex As Exception
            MessageBox.Show("Unable to save program record: " & ex.ToString, "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class