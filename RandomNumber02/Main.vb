'Joshua Pickenpaugh
'November 2nd, 2016
'Random Number Game (OOP)

Public Class Main

    Dim rnGame As New RandomNumberGame()
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Generates random number:
        rnGame.GetRandomNumber()

    End Sub

    Private Sub btnDidIGuessCorrectly_Click(sender As Object, e As EventArgs) Handles btnDidIGuessCorrectly.Click

        Dim intUserGuess As Integer
        Dim intCounter As Integer

        'Gets user input:
        intUserGuess = txtGuess.Text

        'Ticks the counter:
        intCounter = rnGame.Counter()

        'Checks the counter to see if allowed attempts has been reached...:
        If (intCounter < rnGame.intAllowedTries) Then

            '...if not check to see if user got it right...:, 
            If (intUserGuess = rnGame.RandomNumber) Then
                lblResponse.Text = "You guessed correctly."
            ElseIf (intUserGuess > rnGame.RandomNumber) Then
                lblResponse.Text = "Try a lower number..."
            ElseIf (intUserGuess < rnGame.RandomNumber) Then
                lblResponse.Text = "Try a higher number..."
            ElseIf (intUserGuess = "") Then
                lblResponse.Text = "Please type a number, or click the red X to exit."
            End If

            '...if allowed attempts reachied, display message and random number:
        Else
            lblResponse.Text = "You've run out of attempts. The number was " & rnGame.RandomNumber & "."

        End If

    End Sub

    'Private Sub txtGuess_GotFocus()

    '    txtGuess.SelectionStart = 0
    '    txtGuess.SelectionLength = 


    'End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'Clears the RandomNumberGame object:
        rnGame.Clear()

        'Clears the txt and lbl:
        txtGuess.Text = String.Empty
        lblResponse.Text = String.Empty

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Closes the app:
        Me.Close()

    End Sub

    Private Sub txtGuess_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGuess.KeyPress

        'Allows only numbers, ".", and the backspace key in the text boxes:
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
                e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

End Class
