'Affirmation of Authorship: 
'Name: Michael Arufe, Melba Avila, Alexander Lorenzo, and Daniel Llana
'Date:4/24/2015
'I affirm that this program was created by me. It is solely my work and does not include any work done by anyone else.


Public Class frmMain
    Private MemberInfo As frmMember
    Private ProgramInfo As frmProgram
    Private MemberPayment As frmPayment
    Private LoginScreen As frmLogin
    Private Statement As frmStatement


    Private Sub PeformNextAction()
        Select Case intNextAction
            Case ACTION_HOME
                tsbHome.PerformClick()
            Case ACTION_MEMBER
                tsbMember.PerformClick()
            Case ACTION_PROGRAM
                tsbProgram.PerformClick()
            Case ACTION_SHOP
            Case ACTION_CONTACT
            Case ACTION_HELP
            Case ACTION_PAYMENT
                tsbPayment.PerformClick()
            Case ACTION_LOGIN
                'Case ACTION_STATEMENT
                '    Me.Hide() 'had main form
                '    Statement.ShowDialog()
                '    Me.Show()
                PeformNextAction()
            Case Else
                'do nothing
        End Select
    End Sub

    Private Sub tsbMember_Click(sender As Object, e As EventArgs) Handles tsbMember.Click
        Me.Hide() 'hide main form
        MemberInfo.ShowDialog()
        Me.Show()
        PeformNextAction()
    End Sub

    Private Sub tsbProgram_Click(sender As Object, e As EventArgs) Handles tsbProgram.Click
        Me.Hide() 'hide main form
        ProgramInfo.ShowDialog()
        Me.Show()
        PeformNextAction()
    End Sub

    Private Sub tsbPayment_Click(sender As Object, e As EventArgs) Handles tsbPayment.Click
        Me.Hide() 'hide main form
        MemberPayment.ShowDialog()
        'comes back from statement if clicked
        If blnGSwtchForm Then 'switch to statement form
            Me.Hide()
            Statement.ShowDialog()
            Me.Hide()
            MemberPayment.ShowDialog()
        End If
        'comes back from statement if clicked 
        Me.Show()
        PeformNextAction()
    End Sub

    Private Sub tsbExit_Click(sender As Object, e As EventArgs) Handles tsbExit.Click
        EndProgram()
    End Sub

    Private Sub tsbProxy_MouseEnter(sender As Object, e As EventArgs) Handles tsbContact.MouseEnter, tsbExit.MouseEnter, _
        tsbHelp.MouseEnter, tsbHome.MouseEnter, tsbMember.MouseEnter, tsbProgram.MouseEnter, tsbShop.MouseEnter, tsbPayment.MouseEnter
        'We need to do this only because we are not putting our image in the Image property, but
        'instead in the BackgroundImage property

        Dim tsbProxy As ToolStripButton

        tsbProxy = DirectCast(sender, ToolStripButton)
        tsbProxy.DisplayStyle = ToolStripItemDisplayStyle.Text
    End Sub

    Private Sub tsbProxy_MouseLeave(sender As Object, e As EventArgs) Handles tsbContact.MouseLeave, tsbExit.MouseLeave, _
        tsbHelp.MouseLeave, tsbHome.MouseLeave, tsbMember.MouseLeave, tsbProgram.MouseLeave, tsbShop.MouseLeave, tsbPayment.MouseLeave

        'We need to do this only because we are not putting our image in the Image property, but
        'instead in the BackgroundImage property

        Dim tsbProxy As ToolStripButton

        tsbProxy = DirectCast(sender, ToolStripButton)
        tsbProxy.DisplayStyle = ToolStripItemDisplayStyle.Image


    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        'initialize everything here
        MemberInfo = New frmMember
        MemberPayment = New frmPayment
        ProgramInfo = New frmProgram
        LoginScreen = New frmLogin
        Statement = New frmStatement
        Try
            myDB.OpenDB()
        Catch ex As Exception
            MessageBox.Show("Unable to open Database. Connection string =" & gstrConn & "Program will end.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            EndProgram()
        End Try


    End Sub

    Private Sub EndProgram()
        'close every from except main
        Dim f As Form
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        For Each f In Application.OpenForms
            If f.Name <> Me.Name Then
                If Not f Is Nothing Then
                    f.Close()
                End If
            End If
        Next
        'close database connection
        'check if open first
        If Not myDB.sqlConn Is Nothing Then
            myDB.sqlConn.Close()
            myDB.sqlConn.Dispose()
        End If

        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        'end the program
        End
    End Sub

    'Private Sub frmMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    'frmLogin.Show()
    ' Me.Visible = False
    'End Sub

End Class
