Public Class loginForm
    Private Sub loginButton_Click(sender As Object, e As EventArgs) Handles loginButton.Click
        Dim username As String
        Dim password As String
        username = ""
        password = ""

        If usernameTextBox.Text = username AndAlso passwordTextBox.Text = password Then
            webbrowserForm.Show()
            Me.Close()
        Else
            accessdeniedForm.Show()
            System.Media.SystemSounds.Beep.Play()
        End If
    End Sub
End Class
