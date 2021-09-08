Public Class frmorder
    Dim entree1 As Decimal
    Dim entree2 As Decimal
    Dim entree3 As Decimal
    Dim entree4 As Decimal
    Dim entree5 As Decimal
    Dim main1 As Decimal
    Dim main2 As Decimal
    Dim main3 As Decimal
    Dim main4 As Decimal
    Dim main5 As Decimal
    Dim dessert1 As Decimal
    Dim dessert2 As Decimal
    Dim dessert3 As Decimal
    Dim dessert4 As Decimal
    Dim dessert5 As Decimal
    Dim softdrink As Decimal
    Dim beer1 As Decimal
    Dim beer2 As Decimal
    Dim extra1 As Decimal
    Dim extra2 As Decimal
    Dim extra3 As Decimal
    Dim extra4 As Decimal
    Dim extra5 As Decimal
    Dim extra6 As Decimal
    Dim removal1 As Decimal
    Dim removal2 As Decimal
    Dim removal3 As Decimal
    Dim removal4 As Decimal
    Dim GST As Short
    Dim totalprice As Decimal
    Dim totalpricewithgst As Decimal
    Dim totalentrees As Decimal
    Dim totalmains As Decimal
    Dim totaldesserts As Decimal
    Dim totaldrinks As Decimal
    Dim totalextras As Decimal
    Dim totalremovals As Decimal

    Private Sub frmorder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        totalprice = 0
        totalpricewithgst = 0
        totalentrees = 0
        totalmains = 0
        totaldesserts = 0
        totaldrinks = 0
        totalextras = 0
        totalremovals = 0
        GST = 0
        frmconfirmation.lblentree.Text = 0
        frmconfirmation.lblmain.Text = 0
        frmconfirmation.lbldessert.Text = 0
        frmconfirmation.lbldrink.Text = 0
        frmconfirmation.lblextra.Text = 0
        frmconfirmation.lblremoval.Text = 0
        frmconfirmation.lblgst.Text = 0
        frmconfirmation.lbltotal.Text = 0
    End Sub

    Private Sub btnordersumbit_Click(sender As Object, e As EventArgs) Handles btnordersumbit.Click
        'states the price for each item in the menu
        entree1 = 9
        entree2 = 10
        entree3 = 11
        entree4 = 8.5
        entree5 = 6
        main1 = 18.5
        main2 = 13.9
        main3 = 17
        main4 = 15.7
        main5 = 17
        dessert1 = 11
        dessert2 = 9
        dessert3 = 7.9
        dessert4 = 11
        dessert5 = 7.9
        softdrink = 4.5
        beer1 = 6
        beer2 = 6
        extra1 = 2.5
        extra2 = 2.5
        extra3 = 2.5
        extra4 = 2.5
        extra5 = 1
        extra6 = 2.5
        removal1 = 1
        removal2 = 1.5
        removal3 = 1.5
        removal4 = 2.5

        'Food and drink calculations

        If nudentree1.Text = "1" Or "2" Or "3" Or "4" Or "5" Or "6" Or "7" Or "8" Or "9" Or "10" Then
            totalprice = totalprice + (entree1 * nudentree1.Text)
            totalentrees = totalentrees + (entree1 * nudentree1.Text)
        End If

        If nudentree2.Text = "1" Or "2" Or "3" Or "4" Or "5" Or "6" Or "7" Or "8" Or "9" Or "10" Then
            totalprice = totalprice + (entree2 * nudentree2.Text)
            totalentrees = totalentrees + (entree2 * nudentree2.Text)
        End If

        If nudentree3.Text = "1" Or "2" Or "3" Or "4" Or "5" Or "6" Or "7" Or "8" Or "9" Or "10" Then
            totalprice = totalprice + (entree3 * nudentree3.Text)
            totalentrees = totalentrees + (entree3 * nudentree3.Text)
        End If

        If nudentree4.Text = "1" Or "2" Or "3" Or "4" Or "5" Or "6" Or "7" Or "8" Or "9" Or "10" Then
            totalprice = totalprice + (entree4 * nudentree4.Text)
            totalentrees = totalentrees + (entree4 * nudentree4.Text)
        End If

        If nudentree5.Text = "1" Or "2" Or "3" Or "4" Or "5" Or "6" Or "7" Or "8" Or "9" Or "10" Then
            totalprice = totalprice + (entree5 * nudentree5.Text)
            totalentrees = totalentrees + (entree5 * nudentree5.Text)
        End If

        If nudmain1.Text = "1" Or "2" Or "3" Or "4" Or "5" Or "6" Or "7" Or "8" Or "9" Or "10" Then
            totalprice = totalprice + (main1 * nudmain1.Text)
            totalmains = totalmains + (main1 * nudmain1.Text)
        End If

        If nudmain2.Text = "1" Or "2" Or "3" Or "4" Or "5" Or "6" Or "7" Or "8" Or "9" Or "10" Then
            totalprice = totalprice + (main2 * nudmain2.Text)
            totalmains = totalmains + (main2 * nudmain2.Text)
        End If

        If nudmain3.Text = "1" Or "2" Or "3" Or "4" Or "5" Or "6" Or "7" Or "8" Or "9" Or "10" Then
            totalprice = totalprice + (main3 * nudmain3.Text)
            totalmains = totalmains + (main3 * nudmain3.Text)
        End If

        If nudmain4.Text = "1" Or "2" Or "3" Or "4" Or "5" Or "6" Or "7" Or "8" Or "9" Or "10" Then
            totalprice = totalprice + (main4 * nudmain4.Text)
            totalmains = totalmains + (main4 * nudmain4.Text)
        End If

        If nudmain5.Text = "1" Or "2" Or "3" Or "4" Or "5" Or "6" Or "7" Or "8" Or "9" Or "10" Then
            totalprice = totalprice + (main5 * nudmain5.Text)
            totalmains = totalmains + (main5 * nudmain5.Text)
        End If

        If nuddessert1.Text = "1" Or "2" Or "3" Or "4" Or "5" Or "6" Or "7" Or "8" Or "9" Or "10" Then
            totalprice = totalprice + (dessert1 * nuddessert1.Text)
            totaldesserts = totaldesserts + (dessert1 * nuddessert1.Text)
        End If

        If nuddessert2.Text = "1" Or "2" Or "3" Or "4" Or "5" Or "6" Or "7" Or "8" Or "9" Or "10" Then
            totalprice = totalprice + (dessert2 * nuddessert2.Text)
            totaldesserts = totaldesserts + (dessert2 * nuddessert2.Text)
        End If

        If nuddessert3.Text = "1" Or "2" Or "3" Or "4" Or "5" Or "6" Or "7" Or "8" Or "9" Or "10" Then
            totalprice = totalprice + (dessert3 * nuddessert3.Text)
            totaldesserts = totaldesserts + (dessert3 * nuddessert3.Text)
        End If

        If nuddessert4.Text = "1" Or "2" Or "3" Or "4" Or "5" Or "6" Or "7" Or "8" Or "9" Or "10" Then
            totalprice = totalprice + (dessert4 * nuddessert4.Text)
            totaldesserts = totaldesserts + (dessert4 * nuddessert4.Text)
        End If

        If nuddessert5.Text = "1" Or "2" Or "3" Or "4" Or "5" Or "6" Or "7" Or "8" Or "9" Or "10" Then
            totalprice = totalprice + (dessert5 * nuddessert5.Text)
            totaldesserts = totaldesserts + (dessert5 * nuddessert5.Text)
        End If

        If nuddrink1.Text = "1" Or "2" Or "3" Or "4" Or "5" Or "6" Or "7" Or "8" Or "9" Or "10" Then
            totalprice = totalprice + (softdrink * nuddrink1.Text)
            totaldrinks = totaldrinks + (softdrink * nuddrink1.Text)
        End If

        If nuddrink2.Text = "1" Or "2" Or "3" Or "4" Or "5" Or "6" Or "7" Or "8" Or "9" Or "10" Then
            totalprice = totalprice + (softdrink * nuddrink2.Text)
            totaldrinks = totaldrinks + (softdrink * nuddrink2.Text)
        End If

        If nuddrink3.Text = "1" Or "2" Or "3" Or "4" Or "5" Or "6" Or "7" Or "8" Or "9" Or "10" Then
            totalprice = totalprice + (softdrink * nuddrink3.Text)
            totaldrinks = totaldrinks + (softdrink * nuddrink3.Text)
        End If

        If nuddrink4.Text = "1" Or "2" Or "3" Or "4" Or "5" Or "6" Or "7" Or "8" Or "9" Or "10" Then
            totalprice = totalprice + (beer1 * nuddrink4.Text)
            totaldrinks = totaldrinks + (beer1 * nuddrink4.Text)
        End If

        If nuddrink5.Text = "1" Or "2" Or "3" Or "4" Or "5" Or "6" Or "7" Or "8" Or "9" Or "10" Then
            totalprice = totalprice + (beer2 * nuddrink5.Text)
            totaldrinks = totaldrinks + (beer2 * nuddrink5.Text)
        End If

        If ckbextra1.Checked Then
            totalprice = totalprice + extra1
            totalextras = totalextras + extra1
        End If

        If ckbextra2.Checked Then
            totalprice = totalprice + extra2
            totalextras = totalextras + extra2
        End If

        If ckbextra3.Checked Then
            totalprice = totalprice + extra3
            totalextras = totalextras + extra3
        End If

        If ckbextra4.Checked Then
            totalprice = totalprice + extra4
            totalextras = totalextras + extra4
        End If

        If ckbextra5.Checked Then
            totalprice = totalprice + extra5
            totalextras = totalextras + extra5
        End If

        If ckbextra6.Checked Then
            totalprice = totalprice + extra6
            totalextras = totalextras + extra6
        End If

        If ckbremoval1.Checked Then
            totalprice = totalprice - removal1
            totalremovals = totalremovals - removal1
        End If

        If ckbremoval2.Checked Then
            totalprice = totalprice - removal2
            totalremovals = totalremovals - removal2
        End If

        If ckbremoval3.Checked Then
            totalprice = totalprice - removal3
            totalremovals = totalremovals - removal3
        End If

        If ckbremoval4.Checked Then
            totalprice = totalprice - removal4
            totalremovals = totalremovals - removal4
        End If


        'GST calculations

        GST = totalprice * 0.1
        totalpricewithgst = totalprice + GST

        'states the prices on the confirmation form

        frmconfirmation.lblentree.Text = totalentrees
        frmconfirmation.lblmain.Text = totalmains
        frmconfirmation.lbldessert.Text = totaldesserts
        frmconfirmation.lbldrink.Text = totaldrinks
        frmconfirmation.lblextra.Text = totalextras
        frmconfirmation.lblremoval.Text = totalremovals
        frmconfirmation.lblgst.Text = GST
        frmconfirmation.lbltotal.Text = totalpricewithgst

        'closing this form and opening the confirmation form

        Me.Hide()
        frmconfirmation.Show()

    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        End     'closes the application
    End Sub


    'if the bqq extra is checked then the bqq removal disappears and vice versa

    Private Sub ckbextra5_CheckedChanged_1(sender As Object, e As EventArgs) Handles ckbextra5.CheckedChanged
        If ckbextra5.Checked Then
            ckbremoval1.Visible = False
            lblremovalprice1.Visible = False
        Else
            ckbremoval1.Visible = True
            lblremovalprice1.Visible = True
        End If
    End Sub

    Private Sub ckbremoval1_CheckedChanged(sender As Object, e As EventArgs) Handles ckbremoval1.CheckedChanged
        If ckbremoval1.Checked Then
            ckbextra5.Visible = False
            lblextraprice5.Visible = False
        Else
            ckbextra5.Visible = True
            lblextraprice5.Visible = True
        End If
    End Sub


    'if the anchovies extra is checked then the anchovies removal disappears and vice versa

    Private Sub ckbextra3_CheckedChanged_1(sender As Object, e As EventArgs) Handles ckbextra3.CheckedChanged
        If ckbextra3.Checked Then
            ckbremoval4.Visible = False
            lblremovalprice4.Visible = False
        Else
            ckbremoval4.Visible = True
            lblremovalprice4.Visible = True
        End If
    End Sub

    Private Sub ckbremoval4_CheckedChanged(sender As Object, e As EventArgs) Handles ckbremoval4.CheckedChanged
        If ckbremoval4.Checked Then
            ckbextra3.Visible = False
            lblextraprice3.Visible = False
        Else
            ckbextra3.Visible = True
            lblextraprice3.Visible = True
        End If
    End Sub

    'sets all of the total prices, GST, NumericUpDown objects to 0. And unchecks all of the extras and removals (restarts the order form if button is pressed)
    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click

        GST = 0
        totalprice = 0
        totalpricewithgst = 0
        totalentrees = 0
        totalmains = 0
        totaldesserts = 0
        totaldrinks = 0
        totalextras = 0
        totalremovals = 0

        nudentree1.Text = 0
        nudentree2.Text = 0
        nudentree3.Text = 0
        nudentree4.Text = 0
        nudentree5.Text = 0
        nudmain1.Text = 0
        nudmain2.Text = 0
        nudmain3.Text = 0
        nudmain4.Text = 0
        nudmain5.Text = 0
        nuddessert1.Text = 0
        nuddessert2.Text = 0
        nuddessert3.Text = 0
        nuddessert4.Text = 0
        nuddessert5.Text = 0
        nuddrink1.Text = 0
        nuddrink2.Text = 0
        nuddrink3.Text = 0
        nuddrink4.Text = 0
        nuddrink5.Text = 0

        If ckbextra1.checked Then
            ckbextra1.checkstate = CheckState.Unchecked
        End If

        If ckbextra2.Checked Then
            ckbextra2.CheckState = CheckState.Unchecked
        End If

        If ckbextra3.checked Then
            ckbextra3.checkstate = CheckState.Unchecked
        End If

        If ckbextra4.checked Then
            ckbextra4.checkstate = CheckState.Unchecked
        End If

        If ckbextra5.checked Then
            ckbextra5.checkstate = CheckState.Unchecked
        End If

        If ckbremoval1.Checked Then
            ckbremoval1.CheckState = CheckState.Unchecked
        End If

        If ckbremoval2.Checked Then
            ckbremoval2.CheckState = CheckState.Unchecked
        End If

        If ckbremoval3.Checked Then
            ckbremoval3.CheckState = CheckState.Unchecked
        End If

        If ckbremoval4.Checked Then
            ckbremoval4.CheckState = CheckState.Unchecked
        End If

    End Sub

    'showing the extras and removals if the amount of any main course is over 0

    Private Sub nudmain1_ValueChanged(sender As Object, e As EventArgs) Handles nudmain1.ValueChanged
        If nudmain1.Text = "1" Or "2" Or "3" Or "4" Or "5" Or "6" Or "7" Or "8" Or "9" Or "10" Then
            lblextras.Visible = True
            ckbextra1.Visible = True
            ckbextra2.Visible = True
            ckbextra3.Visible = True
            ckbextra4.Visible = True
            ckbextra5.Visible = True
            ckbextra6.Visible = True
            lblremovals.Visible = True
            ckbremoval1.Visible = True
            ckbremoval2.Visible = True
            ckbremoval3.Visible = True
            ckbremoval4.Visible = True
            lblextraprice1.Visible = True
            lblextraprice2.Visible = True
            lblextraprice3.Visible = True
            lblextraprice4.Visible = True
            lblextraprice5.Visible = True
            lblextraprice6.Visible = True
            lblremovalprice1.Visible = True
            lblremovalprice2.Visible = True
            lblremovalprice3.Visible = True
            lblremovalprice4.Visible = True
        Else
            lblextras.Visible = False
            ckbextra1.Visible = False
            ckbextra2.Visible = False
            ckbextra3.Visible = False
            ckbextra4.Visible = False
            ckbextra5.Visible = False
            ckbextra6.Visible = False
            lblremovals.Visible = False
            ckbremoval1.Visible = False
            ckbremoval2.Visible = False
            ckbremoval3.Visible = False
            ckbremoval4.Visible = False
            lblextraprice1.Visible = False
            lblextraprice2.Visible = False
            lblextraprice3.Visible = False
            lblextraprice4.Visible = False
            lblextraprice5.Visible = False
            lblextraprice6.Visible = False
            lblremovalprice1.Visible = False
            lblremovalprice2.Visible = False
            lblremovalprice3.Visible = False
            lblremovalprice4.Visible = False
        End If
    End Sub

    Private Sub nudmain2_ValueChanged(sender As Object, e As EventArgs) Handles nudmain2.ValueChanged
        If nudmain2.Text = "1" Or "2" Or "3" Or "4" Or "5" Or "6" Or "7" Or "8" Or "9" Or "10" Then
            lblextras.Visible = True
            ckbextra1.Visible = True
            ckbextra2.Visible = True
            ckbextra3.Visible = True
            ckbextra4.Visible = True
            ckbextra5.Visible = True
            ckbextra6.Visible = True
            lblremovals.Visible = True
            ckbremoval1.Visible = True
            ckbremoval2.Visible = True
            ckbremoval3.Visible = True
            ckbremoval4.Visible = True
            lblextraprice1.Visible = True
            lblextraprice2.Visible = True
            lblextraprice3.Visible = True
            lblextraprice4.Visible = True
            lblextraprice5.Visible = True
            lblextraprice6.Visible = True
            lblremovalprice1.Visible = True
            lblremovalprice2.Visible = True
            lblremovalprice3.Visible = True
            lblremovalprice4.Visible = True
        Else
            lblextras.Visible = False
            ckbextra1.Visible = False
            ckbextra2.Visible = False
            ckbextra3.Visible = False
            ckbextra4.Visible = False
            ckbextra5.Visible = False
            ckbextra6.Visible = False
            lblremovals.Visible = False
            ckbremoval1.Visible = False
            ckbremoval2.Visible = False
            ckbremoval3.Visible = False
            ckbremoval4.Visible = False
            lblextraprice1.Visible = False
            lblextraprice2.Visible = False
            lblextraprice3.Visible = False
            lblextraprice4.Visible = False
            lblextraprice5.Visible = False
            lblextraprice6.Visible = False
            lblremovalprice1.Visible = False
            lblremovalprice2.Visible = False
            lblremovalprice3.Visible = False
            lblremovalprice4.Visible = False
        End If
    End Sub

    Private Sub nudmain3_ValueChanged(sender As Object, e As EventArgs) Handles nudmain3.ValueChanged
        If nudmain3.Text = "1" Or "2" Or "3" Or "4" Or "5" Or "6" Or "7" Or "8" Or "9" Or "10" Then
            lblextras.Visible = True
            ckbextra1.Visible = True
            ckbextra2.Visible = True
            ckbextra3.Visible = True
            ckbextra4.Visible = True
            ckbextra5.Visible = True
            ckbextra6.Visible = True
            lblremovals.Visible = True
            ckbremoval1.Visible = True
            ckbremoval2.Visible = True
            ckbremoval3.Visible = True
            ckbremoval4.Visible = True
            lblextraprice1.Visible = True
            lblextraprice2.Visible = True
            lblextraprice3.Visible = True
            lblextraprice4.Visible = True
            lblextraprice5.Visible = True
            lblextraprice6.Visible = True
            lblremovalprice1.Visible = True
            lblremovalprice2.Visible = True
            lblremovalprice3.Visible = True
            lblremovalprice4.Visible = True
        Else
            lblextras.Visible = False
            ckbextra1.Visible = False
            ckbextra2.Visible = False
            ckbextra3.Visible = False
            ckbextra4.Visible = False
            ckbextra5.Visible = False
            ckbextra6.Visible = False
            lblremovals.Visible = False
            ckbremoval1.Visible = False
            ckbremoval2.Visible = False
            ckbremoval3.Visible = False
            ckbremoval4.Visible = False
            lblextraprice1.Visible = False
            lblextraprice2.Visible = False
            lblextraprice3.Visible = False
            lblextraprice4.Visible = False
            lblextraprice5.Visible = False
            lblextraprice6.Visible = False
            lblremovalprice1.Visible = False
            lblremovalprice2.Visible = False
            lblremovalprice3.Visible = False
            lblremovalprice4.Visible = False
        End If
    End Sub

    Private Sub nudmain4_ValueChanged(sender As Object, e As EventArgs) Handles nudmain4.ValueChanged
        If nudmain4.Text = "1" Or "2" Or "3" Or "4" Or "5" Or "6" Or "7" Or "8" Or "9" Or "10" Then
            lblextras.Visible = True
            ckbextra1.Visible = True
            ckbextra2.Visible = True
            ckbextra3.Visible = True
            ckbextra4.Visible = True
            ckbextra5.Visible = True
            ckbextra6.Visible = True
            lblremovals.Visible = True
            ckbremoval1.Visible = True
            ckbremoval2.Visible = True
            ckbremoval3.Visible = True
            ckbremoval4.Visible = True
            lblextraprice1.Visible = True
            lblextraprice2.Visible = True
            lblextraprice3.Visible = True
            lblextraprice4.Visible = True
            lblextraprice5.Visible = True
            lblextraprice6.Visible = True
            lblremovalprice1.Visible = True
            lblremovalprice2.Visible = True
            lblremovalprice3.Visible = True
            lblremovalprice4.Visible = True
        Else
            lblextras.Visible = False
            ckbextra1.Visible = False
            ckbextra2.Visible = False
            ckbextra3.Visible = False
            ckbextra4.Visible = False
            ckbextra5.Visible = False
            ckbextra6.Visible = False
            lblremovals.Visible = False
            ckbremoval1.Visible = False
            ckbremoval2.Visible = False
            ckbremoval3.Visible = False
            ckbremoval4.Visible = False
            lblextraprice1.Visible = False
            lblextraprice2.Visible = False
            lblextraprice3.Visible = False
            lblextraprice4.Visible = False
            lblextraprice5.Visible = False
            lblextraprice6.Visible = False
            lblremovalprice1.Visible = False
            lblremovalprice2.Visible = False
            lblremovalprice3.Visible = False
            lblremovalprice4.Visible = False
        End If
    End Sub

    Private Sub nudmain5_ValueChanged(sender As Object, e As EventArgs) Handles nudmain5.ValueChanged
        If nudmain5.Text = "1" Or "2" Or "3" Or "4" Or "5" Or "6" Or "7" Or "8" Or "9" Or "10" Then
            lblextras.Visible = True
            ckbextra1.Visible = True
            ckbextra2.Visible = True
            ckbextra3.Visible = True
            ckbextra4.Visible = True
            ckbextra5.Visible = True
            ckbextra6.Visible = True
            lblremovals.Visible = True
            ckbremoval1.Visible = True
            ckbremoval2.Visible = True
            ckbremoval3.Visible = True
            ckbremoval4.Visible = True
            lblextraprice1.Visible = True
            lblextraprice2.Visible = True
            lblextraprice3.Visible = True
            lblextraprice4.Visible = True
            lblextraprice5.Visible = True
            lblextraprice6.Visible = True
            lblremovalprice1.Visible = True
            lblremovalprice2.Visible = True
            lblremovalprice3.Visible = True
            lblremovalprice4.Visible = True
        Else
            lblextras.Visible = False
            ckbextra1.Visible = False
            ckbextra2.Visible = False
            ckbextra3.Visible = False
            ckbextra4.Visible = False
            ckbextra5.Visible = False
            ckbextra6.Visible = False
            lblremovals.Visible = False
            ckbremoval1.Visible = False
            ckbremoval2.Visible = False
            ckbremoval3.Visible = False
            ckbremoval4.Visible = False
            lblextraprice1.Visible = False
            lblextraprice2.Visible = False
            lblextraprice3.Visible = False
            lblextraprice4.Visible = False
            lblextraprice5.Visible = False
            lblextraprice6.Visible = False
            lblremovalprice1.Visible = False
            lblremovalprice2.Visible = False
            lblremovalprice3.Visible = False
            lblremovalprice4.Visible = False
        End If
    End Sub

    Private Sub btnbacktotables_Click(sender As Object, e As EventArgs) Handles btnbacktotables.Click
        Me.Hide()
        frmtables.Show()
    End Sub

End Class