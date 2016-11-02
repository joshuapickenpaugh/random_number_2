'Joshua Pickenpaugh
'November 2nd, 2016
'Random Number Game (OOP)

Public Class Main

    Dim rnGame As New RandomNumberGame()
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        rnGame.GetRandomNumber()

    End Sub

    Private Sub btnDidIGuessCorrectly_Click(sender As Object, e As EventArgs) Handles btnDidIGuessCorrectly.Click

        Dim intUserGuess As Integer

        intUserGuess = txtGuess.Text

        If (intUserGuess = rnGame.RandomNumber) Then
            lblResponse.Text = "You guessed correctly."
        ElseIf (intUserGuess > rnGame.RandomNumber) Then
            lblResponse.Text = "Try a lower number..."
        ElseIf (intUserGuess < rnGame.RandomNumber) Then
            lblResponse.Text = "Try a higher number..."
        ElseIf (intUserGuess = "") Then
            lblResponse.Text = "Please type a number, or click the red X to exit."
        End If

    End Sub
End Class
