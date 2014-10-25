Public Class ScoreForm

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        ' function that assigns final score the appropriated field on the main form

        Dim strProjectScore As Double

        strProjectScore = cboProjectScores.SelectedItem

        frmMain.lblFinalProjectScore.Text = Convert.ToString(strProjectScore)

        Me.Hide()
    End Sub
End Class