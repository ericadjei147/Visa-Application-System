Imports MySql.Data.MySqlClient

Public Class UpdateDashboard
    Public Sub childform(ByVal Panel As Form)
        Panel1.Controls.Clear()
        Panel.TopLevel = False
        Panel.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Panel.Dock = DockStyle.Fill
        Panel1.Controls.Add(Panel)
        Panel.Show()
    End Sub

    Private Sub btnOverview_Click(sender As Object, e As EventArgs) Handles btnOverview.Click
        childform(New Overview)
    End Sub

    Private Sub btnAppynow_Click(sender As Object, e As EventArgs) Handles btnAppynow.Click
        childform(New ApplyNow)
    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        childform(New Profile)
    End Sub

    Private Sub UpdateDashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        childform(New Overview)
        openNotify()
    End Sub


    Sub openNotify()
        Try
            Using con As New MySqlConnection(My.Settings.conStr)
                con.Open()
                Dim query = "SELECT count(*) as `number` FROM `message` WHERE `Sendto`= " & Login1.id & " and `opened`=0;"
                Using cmd As New MySqlCommand(query, con)
                    Dim dr = cmd.ExecuteReader()
                    While dr.Read
                        NotifiacationCount.Text = dr("number").ToString
                    End While
                    dr.close
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnContactUs_Click(sender As Object, e As EventArgs) Handles btnContactUs.Click
        childform(ContactUs)
    End Sub

    Private Sub NotificationBell_Click(sender As Object, e As EventArgs) Handles NotificationBell.Click
        Notification.ShowDialog()
    End Sub

    Private Sub btnFAQs_Click(sender As Object, e As EventArgs) Handles btnFAQs.Click
        childform(FAQForm)
    End Sub
End Class