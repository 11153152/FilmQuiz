﻿Public Class frmQuestion2
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub frmQuestion2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAnswer4_CheckedChanged(sender As Object, e As EventArgs) Handles btnAnswer4.CheckedChanged

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub btnAnswer1_CheckedChanged(sender As Object, e As EventArgs) Handles btnAnswer1.CheckedChanged
        If btnAnswer1.Checked Then
            playerScore = playerScore + 1

        End If
        frmHighScore.Show()


        Me.Hide()


    End Sub
End Class