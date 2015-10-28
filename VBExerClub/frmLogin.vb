Public Class frmLogin
    Private objMain As frmMain
    Private objSecurities As CSecurities

    'constructor
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        objMain = New frmMain
        objSecurities = New CSecurities
    End Sub

    Private Sub CheckLoginAccess() 

        With objSecurities.CurrentObject
            .UserID = txtUserName.Text
            .Password = txtPassword.Text
        End With

            Try
                Windows.Forms.Cursor.Current = Cursors.WaitCursor
            objSecurities.CheckLoginAccess(objSecurities.CurrentObject.UserID, objSecurities.CurrentObject.Password)
                Windows.Forms.Cursor.Current = Cursors.Default 'Change back or waits forever
            Catch ex As Exception
                MessageBox.Show("Unable to login: " & ex.ToString, "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        CheckLoginAccess()
    End Sub

    Private Sub txtUserName_GotFocus(sender As Object, e As EventArgs) Handles txtUserName.GotFocus
        pnlUser.BackColor = Color.FromArgb(17, 168, 171)
    End Sub

    Private Sub pnlUser_LostFocus(sender As Object, e As EventArgs) Handles txtUserName.LostFocus
        pnlUser.BackColor = Color.Transparent
    End Sub

    Private Sub txtPassword_GotFocus(sender As Object, e As EventArgs) Handles txtPassword.GotFocus
        pnlPassword.BackColor = Color.FromArgb(17, 168, 171)
    End Sub

    Private Sub pnlPassword_LostFocus(sender As Object, e As EventArgs) Handles txtPassword.LostFocus
        pnlPassword.BackColor = Color.Transparent
    End Sub
End Class