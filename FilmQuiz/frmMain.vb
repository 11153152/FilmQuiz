Public Class frmMain
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        PlayerScore = 0
        PlayerName = txtPlayerName.Text
        frmQuestion1.Show()
        Me.Hide()
        IfbtnAnswer2.CheckedThen
        PlayerScore = PlayerScore + 1
        End If
        frmQuestion2.Show()
        Me.Hide()
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()
    End Sub
End Class
