Public Class frmconfirmation
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        End     'closes the application
    End Sub

    Private Sub btnconfirm_Click(sender As Object, e As EventArgs) Handles btnconfirm.Click
        Me.Hide()
        frmthankyou.Show()
    End Sub

    Private Sub btnbacktotables_Click(sender As Object, e As EventArgs) Handles btnbacktotables.Click
        Me.Hide()
        frmtables.Show()
    End Sub

    Private Sub btnbacktoorders_Click(sender As Object, e As EventArgs) Handles btnbacktoorders.Click
        lblentree.Text = 0
        lblmain.Text = 0
        lbldessert.Text = 0
        lbldrink.Text = 0
        lblextra.Text = 0
        lblremoval.Text = 0
        lblgst.Text = 0
        lbltotal.Text = 0

        Me.Hide()
        frmorder.Show()
        frmorder.btnreset.PerformClick()
    End Sub
End Class