﻿Public Class frmCarLoan
  Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
    Dim monthlyPayment, loanAmount, interestRate as Double
    Dim numOfYears as Integer

    loanAmount = CDbl(txtAmount.Text)
    interestRate = Cdbl(txtInterest.Text)
    numOfYears = CInt(txtYears.Text)

    Dim i as Double = interestRate / 1200

    monthlyPayment = (i / (1 - Math.Pow((1 + i), -12 * numOfYears))) * loanAmount
    txtPayments.Text = monthlyPayment.ToString("C2")

  End Sub
End Class
