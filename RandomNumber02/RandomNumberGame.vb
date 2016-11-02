Public Class RandomNumberGame

    Private _intRandomNumber As Integer
    Private _intCounter As Integer
    Public intAllowedTries As Integer = 10

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

    Public Sub New()

        _intRandomNumber = 0
        _intCounter = 0

    End Sub

    Public Sub Clear()

        _intRandomNumber = 0
        _intCounter = 0

    End Sub

    Public Sub GetRandomNumber()

        Dim rn As New Random()

        _intRandomNumber = rn.Next(1, 50)

    End Sub

    Public Function Counter() As Integer

        _intCounter = _intCounter + 1

        Return _intCounter

    End Function

End Class
