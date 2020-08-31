Public Class frmTime
    Private Sub frmTime_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim time As DateTime = DateTime.Now
        lblTime.Text = time
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Panel4.Width += 3
        If (Panel4.Width >= 700) Then
            Me.Close()

        End If
    End Sub
End Class