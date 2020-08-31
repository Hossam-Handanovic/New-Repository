Public Class Form3
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
    End Sub

    Private Sub PictureBox4_Click_1(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Dim closeornot As DialogResult = MessageBox.Show("Are you sure to exit", "Go-Alpha", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)

        If (closeornot = DialogResult.Yes) Then
            Me.Close()
            fremMainWindow.Close()
        End If
    End Sub
End Class