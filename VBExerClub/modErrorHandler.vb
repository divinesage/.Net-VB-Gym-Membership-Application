Module modErrorHandler
    Public Function ValidateTextBoxLength(ByVal obj As TextBox, ByVal errP As ErrorProvider) As Boolean
        'This function validates that a textbox is not empty.
        If obj.Text.Length = 0 Then ' textbox is empty
            errP.SetIconAlignment(obj, ErrorIconAlignment.MiddleLeft)
            errP.SetError(obj, "You must enter a value here!")
            obj.Focus()
            Return False
        Else
            errP.SetError(obj, "")
            Return True
        End If
    End Function
    Public Function ValidateTextBoxNumeric(ByVal obj As TextBox, ByVal errP As ErrorProvider) As Boolean
        'This function validates that a textbox contains numeric data
        If Not IsNumeric(obj.Text) Then  'data is not numeric
            errP.SetIconAlignment(obj, ErrorIconAlignment.MiddleLeft)
            errP.SetError(obj, "You must enter a numeric value here!")
            obj.Focus()
            Return False
        Else
            errP.SetError(obj, "")
            Return True
        End If
    End Function

    Public Function ValidateTextBoxText(ByVal obj As TextBox, ByVal errP As ErrorProvider) As Boolean
        'This function validates that a textbox contains text only
        Dim strText As String = obj.Text.Replace(" ", "")
        For i = 0 To strText.Length - 1
            If Not Char.IsLetter(strText.Chars(i)) Then
                errP.SetIconAlignment(obj, ErrorIconAlignment.MiddleLeft)
                errP.SetError(obj, "You must enter text only here!")
                obj.Focus()
                Return False
            End If
        Next
        Return True
        errP.SetError(obj, "")
    End Function

    Public Function ValidateMaskedTextBoxDate(ByVal obj As MaskedTextBox, ByVal errP As ErrorProvider) As Boolean
        'This function validates that a maskedtextbox has a valid date in it
        If Not IsDate(obj.Text) Then 'not a valid date
            errP.SetIconAlignment(obj, ErrorIconAlignment.MiddleLeft)
            errP.SetError(obj, "You must enter a valid date here!")
            obj.Focus()
            Return False
        Else
            errP.SetError(obj, "")
            Return True
        End If
    End Function
    Public Function ValidateCombo(ByVal obj As ComboBox, ByVal errP As ErrorProvider) As Boolean
        'This function validates that a combo has a selection
        If obj.SelectedIndex = -1 Then ' no selection was made
            errP.SetIconAlignment(obj, ErrorIconAlignment.MiddleLeft)
            errP.SetError(obj, "You must make a selection here!")
            obj.Focus()
            Return False
        Else
            errP.SetError(obj, "")
            Return True
        End If
    End Function

    Public Function ValidateList(ByVal obj As ListBox, ByVal errP As ErrorProvider) As Boolean
        'This function validates that a list box has a selection
        If obj.SelectedIndex = -1 Then 'no selection was made
            errP.SetIconAlignment(obj, ErrorIconAlignment.MiddleLeft)
            errP.SetError(obj, "You must make a selection here!")
            obj.Focus()
            Return False
        Else
            errP.SetError(obj, "")
            Return True
        End If
    End Function

    Public Function IsValidEmail(strIn As String) As Boolean 'use RegEx to test email field (obtained from MSDN)
        Dim emailRegex As New System.Text.RegularExpressions.Regex(
            "^(?<user>[^@]+)@(?<host>.+)$")
        Dim emailMatch As System.Text.RegularExpressions.Match =
           emailRegex.Match(strIn) 'compare the email text to the RegEx
        Return emailMatch.Success
    End Function


    Public Function ValidateProgID(ByVal obj As TextBox, ByVal errP As ErrorProvider) As Boolean 'use RegEx to test email field (obtained from MSDN)
        Dim idRegex As New System.Text.RegularExpressions.Regex(
            "(([a-z]|[A-Z]){3})(-)([0-9]+)")
        Dim idMatch As System.Text.RegularExpressions.Match =
           idRegex.Match(obj.Text) 'compare the email text to the RegEx
        If Not idMatch.Success Then
            errP.SetIconAlignment(obj, ErrorIconAlignment.MiddleLeft)
            errP.SetError(obj, "You must make a selection here!")
            obj.Focus()
            Return False
        Else
            errP.SetError(obj, "")
            Return True
        End If
    End Function

    Public Function IsValidText(strIn As String) As Boolean
        Dim blnResult As Boolean
        If (strIn = "") Then
            blnResult = False
            Return blnResult
        End If
        For i = 0 To strIn.Length - 1
            If Not Char.IsLetter(strIn.Chars(i)) Then
                blnResult = False
                Return blnResult
            End If
        Next
        blnResult = True
        Return blnResult
    End Function
End Module
