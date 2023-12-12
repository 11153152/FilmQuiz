Public Class frmHighScore
    Private Sub IstHighiScore_SelectedIndexChanged(sender As Object, e As EventArgs) Handles IstHighiScore.SelectedIndexChanged
        If PlayerScore < 1 Then
            lblMessage.Text = " Sorry Your Score Was Not Good enough "

        Else
            lblMessage.Text = "Congratulations Your Score will Be Added To The Hall Of Fame"
            IstHighiScore.Items.Add(PlayerName & vbTab & PlayerScore)
        End If

    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()
    End Sub

    Private Sub btnAgain_Click(sender As Object, e As EventArgs) Handles btnAgain.Click
        frmMain.Show()
        Me.Hide()
    End Sub
End Class