Public Class formVerification
    Private Sub btnManual_Click(sender As Object, e As EventArgs) Handles btnManual.Click

        Form1.FormManualVerification1.FormManualVerification_Initiate1.txtGhanaCardNumber.Text = ""
        Form1.FormManualVerification1.FormManualVerification_Initiate1.txtGhanaCardNumber.Select()

        Form1.FormManualVerification1.FormManualVerification_Doodle1.BringToFront()
        Form1.FormManualVerification1.BringToFront()

    End Sub
End Class
