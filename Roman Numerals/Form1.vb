'************************************
'Greg Pina
'.Net Programming IT 101-401
'Assignment 9 - Roman Numerals
'10/13/2017

Option Strict On

Public Class Form1


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'This clears the program of its data
        txtNumber.Clear()
        lblRoman.ResetText()
        txtNumber.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'This closes the program
        Close()

    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click

        'Creates local variables
        Dim intNumber As Integer
        Dim strRoman As String

        txtNumber.BackColor = Color.White

        Try
            'validates input is actually a number
            If Not Integer.TryParse(txtNumber.Text, intNumber) Then
                MessageBox.Show("Please enter numbers only.")
                txtNumber.Focus()
                txtNumber.BackColor = Color.Yellow
                Exit Sub
            End If

            'Makes sure number inputted is betwen 1 and 10
            If intNumber < 1 Or intNumber > 10 Then
                MessageBox.Show("Please only enter numbers between 1 and 10.")
                txtNumber.Focus()
                txtNumber.BackColor = Color.Yellow
            End If

            'assigns Roman Numerals to number values
            If intNumber = 1 Then
                strRoman = "I"
            ElseIf intNumber = 2 Then
                strRoman = "II"
            ElseIf intNumber = 3 Then
                strRoman = "III"
            ElseIf intNumber = 4 Then
                strRoman = "IV"
            ElseIf intNumber = 5 Then
                strRoman = "V"
            ElseIf intNumber = 6 Then
                strRoman = "VI"
            ElseIf intNumber = 7 Then
                strRoman = "VII"
            ElseIf intNumber = 8 Then
                strRoman = "VIII"
            ElseIf intNumber = 9 Then
                strRoman = "IX"
            ElseIf intNumber = 10 Then
                strRoman = "X"
            Else
                strRoman = "Incorrect Number."
            End If


            'Displays the Roman Numeral
            lblRoman.Text = strRoman

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

End Class
