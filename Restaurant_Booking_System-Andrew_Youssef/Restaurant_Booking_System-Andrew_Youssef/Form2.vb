Public Class frmtables
    Dim people As Integer

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        End     'closes the application
    End Sub

    Private Sub btnpeoplesubmit_Click(sender As Object, e As EventArgs) Handles btnpeoplesubmit.Click
        people = nudpeople.Text                     'makes the computer know that the number that the user inserted was the amount of people at that table
        frmconfirmation.lblpeople.Text = people     'states the amount of people in the confirmation form

        'closes things related to the amount of people and instead shows the rest of the things relating to the table choosing process
        nudpeople.Visible = False
        btnpeoplesubmit.Visible = False
        lblpeopleinstructions.Visible = False
        lbltableinstructions.Visible = True

        'states that if the amount of people is 1 or 2 then only the tables with 2 seats are shown
        If people < 3 Then
            pictable1.Visible = True
            pictable2.Visible = True
            pictable5.Visible = True
        End If

        'states that if the amount of people is 3 or 4 then only the tables with 4 seats are shown
        If people < 5 And people > 2 Then
            pictable6.Visible = True
            pictable7.Visible = True
            pictable8.Visible = True
            pictable9.Visible = True
        End If

        'states that if the amount of people is 5, 6, 7 or 8 then only the tables with 8 seats are shown
        If people < 9 And people > 4 Then
            pictable3.Visible = True
            pictable4.Visible = True
        End If

    End Sub

    'states the table number in the confirmation form, closes this form and opens the ordering form

    Private Sub pictable1_DoubleClick(sender As Object, e As EventArgs) Handles pictable1.DoubleClick
        frmconfirmation.lbltable.Text = 1
        Me.Hide()
        frmorder.Show()
    End Sub

    Private Sub pictable2_DoubleClick(sender As Object, e As EventArgs) Handles pictable2.DoubleClick
        frmconfirmation.lbltable.Text = 2
        Me.Hide()
        frmorder.Show()
    End Sub

    Private Sub pictable3_DoubleClick(sender As Object, e As EventArgs) Handles pictable3.DoubleClick
        frmconfirmation.lbltable.Text = 3
        Me.Hide()
        frmorder.Show()
    End Sub

    Private Sub pictable4_DoubleClick(sender As Object, e As EventArgs) Handles pictable4.DoubleClick
        frmconfirmation.lbltable.Text = 4
        Me.Hide()
        frmorder.Show()
    End Sub

    Private Sub pictable5_DoubleClick(sender As Object, e As EventArgs) Handles pictable5.DoubleClick
        frmconfirmation.lbltable.Text = 5
        Me.Hide()
        frmorder.Show()
    End Sub

    Private Sub pictable6_DoubleClick(sender As Object, e As EventArgs) Handles pictable6.DoubleClick
        frmconfirmation.lbltable.Text = 6
        Me.Hide()
        frmorder.Show()
    End Sub

    Private Sub pictable7_DoubleClick(sender As Object, e As EventArgs) Handles pictable7.DoubleClick
        frmconfirmation.lbltable.Text = 7
        Me.Hide()
        frmorder.Show()
    End Sub

    Private Sub pictable8_DoubleClick(sender As Object, e As EventArgs) Handles pictable8.DoubleClick
        frmconfirmation.lbltable.Text = 8
        Me.Hide()
        frmorder.Show()
    End Sub

    Private Sub pictable9_DoubleClick(sender As Object, e As EventArgs) Handles pictable9.DoubleClick
        frmconfirmation.lbltable.Text = 9
        Me.Hide()
        frmorder.Show()
    End Sub

End Class