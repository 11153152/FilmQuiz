Public Class frmMain
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        PlayerScore = 0
        PlayerName = txtPlayerName.Text
        frmQuestion2.Show()
        Me.Hide()

        Me.Hide()
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()
    End Sub
End Class
