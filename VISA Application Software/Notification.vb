Imports Guna.UI.WinForms
Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient

Public Class Notification
    Dim dr As MySqlDataReader
    Private Const PanelWidth As Integer = 650
    Private Const PanelHeight As Integer = 100
    Private Const PanelSpacing As Integer = 20
    Private Msgtop As Integer = 20
    Private count As Integer = 0


    Private Sub AddNotification()
        Dim panel As New Guna2Panel With {
            .Width = PanelWidth,
            .Height = PanelHeight,
            .BorderStyle = Drawing2D.DashStyle.Solid,
            .BorderThickness = 1,
            .BorderRadius = 10,
            .Top = Msgtop,
            .Left = 20,
            .BorderColor = Color.DimGray,
            .FillColor = Color.Gainsboro,
            .AutoSize = False
        }

        Dim picture As New GunaCirclePictureBox With {
            .Width = 50,
            .Height = 50,
            .Image = My.Resources.profile,
            .Top = 20,
            .Left = 20,
            .BackColor = Color.Transparent
        }
        panel.Controls.Add(picture)

        Dim header As New GunaLabel With {
            .Text = "ADMIN",
            .Top = 3,
            .Font = New Font("Arial", 15, FontStyle.Bold),
            .Width = panel.Width - (picture.Left + picture.Width + 30) - 100,
            .Left = picture.Left + picture.Width + 30,
            .BackColor = Color.Transparent
        }
        panel.Controls.Add(header)

        Dim msg As New GunaLabel With {
            .Text = dr("Message"),
            .Top = 30,
            .Font = New Font("Arial", 12),
            .Width = panel.Width - (picture.Left + picture.Width + 30) - 100,
            .Height = 70,
            .Left = picture.Left + picture.Width + 30,
            .BackColor = Color.Transparent,
            .AutoSize = False,
            .MaximumSize = New Size(panel.Width - (picture.Left + picture.Width + 30) - 100, 70) ' Adjusted for maximum size
        }
        panel.Controls.Add(msg)

        Dim time As New GunaLabel With {
            .Left = PanelWidth - 80,
            .Top = 80,
            .Text = dr("MessageDate"),
            .Width = 150,
            .BackColor = Color.Transparent
        }
        panel.Controls.Add(time)

        Me.palMain.Controls.Add(panel)

        'count += 1
        Msgtop += PanelHeight + PanelSpacing
        Me.palMain.AutoScroll = True
        'Me.palMain.VerticalScroll.Value = Me.palMain.VerticalScroll.Maximum
    End Sub

    Sub loadNotfity()
        palMain.Controls.Clear()
        Msgtop = 20
        Try
            Using con As New MySqlConnection(My.Settings.conStr)
                con.Open()
                Dim query = "SELECT `Message`, `MessageDate` FROM `message` where sendto = " & Login1.id & ";"
                Using cmd As New MySqlCommand(query, con)
                    dr = cmd.ExecuteReader()
                    While dr.Read
                        AddNotification()
                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub openNotify()
        Try
            Using con As New MySqlConnection(My.Settings.conStr)
                con.Open()
                Dim query = "UPDATE `message` SET `opened`=1 WHERE `Sendto`= " & Login1.id & ";"
                Using cmd As New MySqlCommand(query, con)
                    cmd.ExecuteNonQuery()
                    UpdateDashboard.NotifiacationCount.Text = 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Notification_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.palMain.AutoScroll = True
        loadNotfity()
        openNotify()
    End Sub
End Class