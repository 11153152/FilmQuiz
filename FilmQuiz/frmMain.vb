Public Class frmMain
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        playerScore = 0
        playerName = txtPlayerName.Text
        frmQuestion2.Show()

        Me.Hide()



        playerScore = 0
        PlayerName = txtPlayerName.Text
        frmQuestion2.Show()
        Me.Hide()


    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()



        Me.Hide()

    End Sub

    Private Sub txtPlayerName_TextChanged(sender As Object, e As EventArgs) Handles txtPlayerName.TextChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
