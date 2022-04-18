Public Class Data
    Public Id As String
    Public Value As String

    Public Sub New(id As Integer, value As String)
        Me.Id = id
        Me.Value = value
    End Sub

    Public Overrides Function ToString() As String
        Return Me.Value
    End Function
End Class
