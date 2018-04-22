Public Class webbrowserForm
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub webbrowserForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        WebBrowser1.ScriptErrorsSuppressed = True
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If WebBrowser1.CanGoBack Then
            WebBrowser1.GoBack()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If WebBrowser1.CanGoForward Then
            WebBrowser1.GoForward()
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        WebBrowser1.Navigate("www.google.com")
    End Sub

    Private Sub addressTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles addressTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            WebBrowser1.Navigate(addressTextBox.Text)
        End If
    End Sub

    Private Sub searchTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles searchTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            WebBrowser1.Navigate(My.Settings.Google + searchTextBox.Text)
        End If
    End Sub

    Private Sub ProxySettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProxySettingsToolStripMenuItem.Click
        proxysettingsForm.Show()
    End Sub
End Class