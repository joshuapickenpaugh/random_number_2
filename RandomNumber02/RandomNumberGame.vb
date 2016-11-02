Public Class RandomNumberGame

    Private _intRandomNumber As Integer

    Public Property RandomNumber As Integer
        Get
            Return _intRandomNumber
        End Get
        Set(value As Integer)
            If value > 0 Then
                _intRandomNumber = value
            Else
                _intRandomNumber = 0
            End If
        End Set
    End Property

    Public Sub GetRandomNumber()

        Dim rn As New Random()

        _intRandomNumber = rn.Next(1, 50)

    End Sub

End Class
