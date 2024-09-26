Public Class Dashboard1
    Public Sub childform(ByVal Panel As Form)
        Panel1.Controls.Clear()
        Panel.TopLevel = False
        Panel.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Panel.Dock = DockStyle.Fill
        Panel1.Controls.Add(Panel)
        Panel.Show()
    End Sub
    Private Sub GunaPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub


    Private Sub btnFAQs_Click(sender As Object, e As EventArgs) Handles btnFAQs.Click

    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        childform(Profile)
    End Sub


    Private Sub btnAppynow_Click(sender As Object, e As EventArgs) Handles btnAppynow.Click
        childform(ApplyNow)
    End Sub

    Private Sub btnOverview_Click(sender As Object, e As EventArgs) Handles btnOverview.Click
        childform(Overview)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click

    End Sub
End Class