Public Class frmwelcome
    Dim username As String
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        End     'closes the application
    End Sub

    Private Sub btnstart_Click(sender As Object, e As EventArgs) Handles btnstart.Click
        'opens the table form and closes this form
        Me.Hide()
        frmtables.Show()
    End Sub

    Private Sub txtusername_TextChanged(sender As Object, e As EventArgs) Handles txtusername.TextChanged
        username = txtusername.Text          'states that the text that the user typed in what their name
        frmthankyou.lblthankyou.Text = "Thank You " + username + " For Booking At"      'states the user's name in a small message in the thank you form
    End Sub
End Class
