Public Class Form1

    Private Sub okButton1_Click(sender As Object, e As EventArgs) Handles okButton1.Click
        infoText.Text = "Selamat sore, " & nameText.Text
    End Sub

    Private Sub nameText_TextChanged(sender As Object, e As EventArgs) Handles nameText.TextChanged
        Length.Text = "Panjang namanya " & nameText.Text.Length

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles showButton.Click
        Form2.Show()
    End Sub

    Private Sub nameText_KeyDown(sender As Object, e As KeyEventArgs) Handles nameText.KeyDown
        If e.KeyCode = Keys.Enter Then
            infoText.Text = "Selamat sore " & nameText.Text
        End If
    End Sub
End Class

