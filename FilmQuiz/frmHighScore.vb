Public Class frmHighScore

    Public Sub dosScore()
        If playerScore < 1 Then
            lblMessage.Text = "Sorry your Score was not good enough
        " OrElse
       lblMessage.Text = "congratulations your score will be added to the hall of fame"

            IstHighScore.Items.Add(playerName & vbTab & playerScore)
        End If
    End Sub


    Private Sub btnAgain_Click(sender As Object, e As EventArgs) Handles btnAgain.Click
        frmMain.Show()
        Me.Hide()
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()
    End Sub
End Class