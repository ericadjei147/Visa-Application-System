Public Class Splashscreen
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label_Loading.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Lbl_mgs.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 1
        percent.Text = ProgressBar1.Value
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Timer2.Start()
        End If
        If ProgressBar1.Value = 30 Then
            Lbl_mgs.Text = "Loading. . ."
        End If
        If ProgressBar1.Value = 50 Then
            Lbl_mgs.Text = "Preparing Files. . ."
        End If
        If ProgressBar1.Value = 70 Then
            Lbl_mgs.Text = "Few Seconds to go. . ."
        End If
        If ProgressBar1.Value = 85 Then
            Lbl_mgs.Text = "Nice! We're Ready. . ."
        End If
        If ProgressBar1.Value = 99 Then
            Lbl_mgs.Text = "Done. . ."
            Me.Hide()
            Login1.Show()
        End If
    End Sub

    Private Sub Splashscreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Value = 0
        Timer1.Start()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Stop()
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub percent_Click(sender As Object, e As EventArgs) Handles percent.Click

    End Sub
End Class