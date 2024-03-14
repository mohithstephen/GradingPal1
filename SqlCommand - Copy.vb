Friend Class SqlCommand
    Private v As String
    Private con As SqlConnection

    Public Sub New(v As String, con As SqlConnection)
        Me.v = v
        Me.con = con
    End Sub
End Class
