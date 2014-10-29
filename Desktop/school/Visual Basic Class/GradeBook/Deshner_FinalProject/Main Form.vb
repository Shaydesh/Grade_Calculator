' Name:         Final Project
' Purpose:      Grade application that accepts scores as input and outputs percentages for the entire class, and a letter grade.
' Programmer:   Shay Deshner on 6 / 26 / 2014
Public Class frmMain

    
    Private dblForumScore As Double
    Private dblAssignmentScore As Double

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        'This is the function that accepts scores for the weekly forums and assignments and outputs them in the grade chart 

        Double.TryParse(txtForumScore.Text, dblForumScore)
        Double.TryParse(txtAssignmentScore.Text, dblAssignmentScore)

        'Guides the user into inputing data correctly using message boxes when invalid data is entered

        If txtAssignmentScore.Text = String.Empty Then
            MessageBox.Show("A score must be entered for both the Forum and the assignment fields.  Please re-enter your submission", _
                            "Critical Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf txtForumScore.Text = String.Empty Then
            MessageBox.Show("A score must be entered for both the Forum and the assignment fields.  Please re-enter your submission", _
                           "Critical Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf cobWeeks.Text = String.Empty Then
            MessageBox.Show("Remember to choose a week in order to ensure the integrity of your data.  Please re-enter your submission", _
                           "Critical Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        'assigns scores entered in the text boxes to the correct catagories on the grade chart

        If cobWeeks.SelectedItem = "Week 1" Then

            lblWeek1Forum.Text = Convert.ToString(dblForumScore)
            lblWeek1Assignment.Text = Convert.ToString(dblAssignmentScore)

        ElseIf cobWeeks.SelectedItem = "Week 2" Then

            lblWeek2Forum.Text = Convert.ToString(dblForumScore)
            lblWeek2Assignment.Text = Convert.ToString(dblAssignmentScore)

        ElseIf cobWeeks.SelectedItem = "Week 3" Then

            lblWeek3Forum.Text = Convert.ToString(dblForumScore)
            lblWeek3Assignment.Text = Convert.ToString(dblAssignmentScore)

        ElseIf cobWeeks.SelectedItem = "Week 4" Then

            lblWeek4Forum.Text = Convert.ToString(dblForumScore)
            lblWeek4Assignment.Text = Convert.ToString(dblAssignmentScore)

        ElseIf cobWeeks.SelectedItem = "Week 5" Then

            lblWeek5Forum.Text = Convert.ToString(dblForumScore)
            lblWeek5Assignment.Text = Convert.ToString(dblAssignmentScore)

        ElseIf cobWeeks.SelectedItem = "Week 6" Then

            lblWeek6Forum.Text = Convert.ToString(dblForumScore)
            lblWeek6Assignment.Text = Convert.ToString(dblAssignmentScore)

        ElseIf cobWeeks.SelectedItem = "Week 7" Then

            lblWeek7Forum.Text = Convert.ToString(dblForumScore)
            lblWeek7Assignment.Text = Convert.ToString(dblAssignmentScore)

        ElseIf cobWeeks.SelectedItem = "Week 8" Then

            lblWeek8Forum.Text = Convert.ToString(dblForumScore)
            lblWeek8Assignment.Text = Convert.ToString(dblAssignmentScore)

        End If

        txtAssignmentScore.Text = String.Empty
        txtForumScore.Text = String.Empty
        cobWeeks.Text = String.Empty

    End Sub

    'variables needed for grade calculations

    Private dblForumAverage1 As Double
    Private dblForumAverage2 As Double
    Private dblForumAverage3 As Double
    Private dblForumAverage4 As Double
    Private dblForumAverage5 As Double
    Private dblForumAverage6 As Double
    Private dblForumAverage7 As Double
    Private dblForumAverage8 As Double
    Private dblTotalForumAverage As Double

    Private dblAssignmentAverage1 As Double
    Private dblAssignmentAverage2 As Double
    Private dblAssignmentAverage3 As Double
    Private dblAssignmentAverage4 As Double
    Private dblAssignmentAverage5 As Double
    Private dblAssignmentAverage6 As Double
    Private dblAssignmentAverage7 As Double
    Private dblAssignmentAverage8 As Double
    Private dblTotalAssignmentAverage As Double

    Private dblClassAverage As Double

    Private dblFinalProjectScore As Double

    'two dimensional array used to assign the correct letter grade based on the total class average

    Private letterGrades(,) As String = {{"93", "A"},
                                         {"90", "A-"},
                                         {"88", "B+"},
                                         {"83", "B"},
                                         {"80", "B-"},
                                         {"78", "C+"},
                                         {"73", "C"},
                                         {"70", "C-"},
                                         {"68", "D+"},
                                         {"63", "D"},
                                         {"60", "D-"},
                                         {"0", "F"}}


    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        ' this function calculates the final score for forum post scores, assignment scores, total class score, and letter grade

        Double.TryParse(lblWeek1Forum.Text, dblForumAverage1)
        Double.TryParse(lblWeek2Forum.Text, dblForumAverage2)
        Double.TryParse(lblWeek3Forum.Text, dblForumAverage3)
        Double.TryParse(lblWeek4Forum.Text, dblForumAverage4)
        Double.TryParse(lblWeek5Forum.Text, dblForumAverage5)
        Double.TryParse(lblWeek6Forum.Text, dblForumAverage6)
        Double.TryParse(lblWeek7Forum.Text, dblForumAverage7)
        Double.TryParse(lblWeek8Forum.Text, dblForumAverage8)

        Double.TryParse(lblWeek1Assignment.Text, dblAssignmentAverage1)
        Double.TryParse(lblWeek2Assignment.Text, dblAssignmentAverage2)
        Double.TryParse(lblWeek3Assignment.Text, dblAssignmentAverage3)
        Double.TryParse(lblWeek4Assignment.Text, dblAssignmentAverage4)
        Double.TryParse(lblWeek5Assignment.Text, dblAssignmentAverage5)
        Double.TryParse(lblWeek6Assignment.Text, dblAssignmentAverage6)
        Double.TryParse(lblWeek7Assignment.Text, dblAssignmentAverage7)
        Double.TryParse(lblWeek8Assignment.Text, dblAssignmentAverage8)

        Double.TryParse(lblFinalProjectScore.Text, dblFinalProjectScore)

        'calculation for forum score

        dblTotalForumAverage = (dblForumAverage1 + dblForumAverage2 + dblForumAverage3 + dblForumAverage4 + dblForumAverage5 + dblForumAverage6 + dblForumAverage7 + dblForumAverage8) / 8.0
        lblForumAverage.Text = Convert.ToString(dblTotalForumAverage)

        'calculation for assignment score

        dblTotalAssignmentAverage = (dblAssignmentAverage1 + dblAssignmentAverage2 + dblAssignmentAverage3 + dblAssignmentAverage4 + dblAssignmentAverage5 + dblAssignmentAverage6 + dblAssignmentAverage7 + dblAssignmentAverage8) / 8.0
        lblAssignmentAverage.Text = Convert.ToString(dblTotalAssignmentAverage)

        'weighted average for the class

        dblClassAverage = (((dblTotalAssignmentAverage / 100.0) * (0.45)) + ((dblTotalForumAverage / 100.0) * (0.3)) + ((dblFinalProjectScore / 100) * (0.25))) * 100
        lblClassAverage.Text = Convert.ToString(dblClassAverage)


        ' For loops used to determine the correct letter grade based on the weighted class average

        For score As Integer = Convert.ToDouble(letterGrades(11, 0)) To Convert.ToDouble(dblClassAverage)

            lblLetterGrade.Text = letterGrades(11, 1)

        Next

        For score As Integer = Convert.ToDouble(letterGrades(10, 0)) To Convert.ToDouble(dblClassAverage)

            lblLetterGrade.Text = letterGrades(10, 1)

        Next

        For score As Integer = Convert.ToDouble(letterGrades(9, 0)) To Convert.ToDouble(dblClassAverage)

            lblLetterGrade.Text = letterGrades(9, 1)

        Next

        For score As Integer = Convert.ToDouble(letterGrades(8, 0)) To Convert.ToDouble(dblClassAverage)

            lblLetterGrade.Text = letterGrades(8, 1)

        Next

        For score As Integer = Convert.ToDouble(letterGrades(7, 0)) To Convert.ToDouble(dblClassAverage)

            lblLetterGrade.Text = letterGrades(7, 1)

        Next

        For score As Integer = Convert.ToDouble(letterGrades(6, 0)) To Convert.ToDouble(dblClassAverage)

            lblLetterGrade.Text = letterGrades(6, 1)

        Next

        For score As Integer = Convert.ToDouble(letterGrades(5, 0)) To Convert.ToDouble(dblClassAverage)

            lblLetterGrade.Text = letterGrades(5, 1)

        Next

        For score As Integer = Convert.ToDouble(letterGrades(4, 0)) To Convert.ToDouble(dblClassAverage)

            lblLetterGrade.Text = letterGrades(4, 1)

        Next

        For score As Integer = Convert.ToDouble(letterGrades(3, 0)) To Convert.ToDouble(dblClassAverage)

            lblLetterGrade.Text = letterGrades(3, 1)

        Next

        For score As Integer = Convert.ToDouble(letterGrades(2, 0)) To Convert.ToDouble(dblClassAverage)

            lblLetterGrade.Text = letterGrades(2, 1)

        Next

        For score As Integer = Convert.ToDouble(letterGrades(1, 0)) To Convert.ToDouble(dblClassAverage)

            lblLetterGrade.Text = letterGrades(1, 1)

        Next

        For score As Integer = Convert.ToDouble(letterGrades(0, 0)) To Convert.ToDouble(dblClassAverage)

            lblLetterGrade.Text = letterGrades(0, 1)

        Next


    End Sub


    Private Sub btnFinalScore_Click(sender As Object, e As EventArgs) Handles btnFinalScore.Click

        'button click that opens form with combo box and populates combobox woth scores for final project scor

        For i As Integer = 0 To 100

            ScoreForm.cboProjectScores.Items.Add(i)

        Next

        ScoreForm.Show()


    End Sub


    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        'print function for the grade book application

        Me.Height = Me.Height - 75

        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview

        PrintForm1.Print()

        Me.Height = Me.Height + 75
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'clear button clears all fields and re shows the name entry form

        lblWeek1Forum.Text = "0 / 100"
        lblWeek2Forum.Text = "0 / 100"
        lblWeek3Forum.Text = "0 / 100"
        lblWeek4Forum.Text = "0 / 100"
        lblWeek5Forum.Text = "0 / 100"
        lblWeek6Forum.Text = "0 / 100"
        lblWeek7Forum.Text = "0 / 100"
        lblWeek8Forum.Text = "0 / 100"

        lblWeek1Assignment.Text = "0 / 100"
        lblWeek2Assignment.Text = "0 / 100"
        lblWeek3Assignment.Text = "0 / 100"
        lblWeek4Assignment.Text = "0 / 100"
        lblWeek5Assignment.Text = "0 / 100"
        lblWeek6Assignment.Text = "0 / 100"
        lblWeek7Assignment.Text = "0 / 100"
        lblWeek8Assignment.Text = "0 / 100"

        lblAssignmentAverage.Text = "0 / 100"
        lblClassAverage.Text = "0 / 100"
        lblFinalProjectScore.Text = "0 / 100"
        lblLetterGrade.Text = "Null"
        lblNameContainer.Text = "Name"
        lblForumAverage.Text = "0 / 100"

        Form3.Show()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'closes application

        Me.Close()
    End Sub
End Class
