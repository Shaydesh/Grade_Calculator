Public Class Form3

    Private Sub btnSubmitName_Click(sender As Object, e As EventArgs) Handles btnSubmitName.Click

        'Function assigns a name for the main form

        Dim strStudentsName As String
        strStudentsName = txtStudentsName.Text
        frmMain.lblNameContainer.Text = strStudentsName
        txtStudentsName.Text = String.Empty
        frmMain.Show()
        Me.Hide()

    End Sub
End Class