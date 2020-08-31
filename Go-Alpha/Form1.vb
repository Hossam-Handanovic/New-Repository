Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Panel2.Width = Panel2.Width + 3
        If (Panel2.Width >= 700) Then
            Timer1.Stop()
            Me.Hide()
            fremMainWindow.Show()
        End If
    End Sub
End Class
