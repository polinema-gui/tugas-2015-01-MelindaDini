Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.BackColor = Color.Coral Then
            Me.BackColor = Color.RosyBrown
        ElseIf Me.BackColor = Color.RosyBrown Then
            Me.BackColor = Color.Coral
        End If
    End Sub
End Class
