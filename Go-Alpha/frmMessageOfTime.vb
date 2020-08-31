Public Class frmMessageOfTime
    Dim time_date As DateTime = DateTime.Now

    Private Sub lblTimeMessage_Click(sender As Object, e As EventArgs) Handles lblTimeMessage.Click
        lblTimeMessage.Text = time_date
    End Sub
End Class