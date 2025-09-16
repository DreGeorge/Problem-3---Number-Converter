Public Class Form1
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Try

            Dim userInput As String = txtNumber.Text


            Dim number As Integer = Integer.Parse(userInput)


            lblResult.Text = "Converted Number: " & number

        Catch ex As FormatException

            lblResult.Text = "Invalid input. Please enter a valid number."
        End Try
    End Sub

End Class
