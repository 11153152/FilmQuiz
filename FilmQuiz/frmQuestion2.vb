Public Class frmQuestion2
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub frmQuestion2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAnswer4_CheckedChanged(sender As Object, e As EventArgs) Handles btnAnswer4.CheckedChanged

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If btnAnswer4.Checked Then
            playerScore = playerScore + 1
        End If
        frmHighScore.Show()
        frmHighScore.doScore()

        Me.Hide()
    End Sub

    Private Sub btnAnswer1_CheckedChanged(sender As Object, e As EventArgs) Handles btnAnswer1.CheckedChanged

    End Sub
End Class