﻿Public Class FrmChangeForDollar
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'this is the variable'
        Dim amount, cents25, cents10, cents5, cents1 As Double
        'convert todouble'
        amount = CDbl(txtAmount.Text)

        cents25 = Int(amount / 25)
        txt25.Text = cents25

        amount = amount - (25 * cents25)

        cents10 = Int(amount / 10)
        txt10.Text = cents10

        amount = amount - (10 * cents10)

        cents5 = Int(amount / 5)
        txt5.Text = cents5

        amount = amount - (5 * cents5)

        cents1 = amount
        txt1.Text = cents1


    End Sub
End Class
