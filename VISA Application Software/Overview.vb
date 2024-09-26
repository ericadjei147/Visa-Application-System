Imports MySql.Data.MySqlClient
Imports System.IO
Imports Guna.UI2.WinForms

Public Class Overview
    Dim dr As MySqlDataReader
    Dim drAppoint As MySqlDataReader

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblOverview_Click(sender As Object, e As EventArgs) Handles lblOverview.Click

    End Sub

    Private Sub Overview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        histroyTop = 10
        AppointTop = 10
        Try
            Using con As New MySqlConnection(My.Settings.conStr)
                con.Open()
                Dim query = "SELECT  concat(`FName`,' ', `LName`) as `FullName`, `Email`, `PNumber`, `PICTURE` FROM `signup` WHERE `Id` = @id"
                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@id", Login1.id)
                    Dim reader = cmd.ExecuteReader
                    While reader.Read
                        lblEmail.Text = "Email: " & reader("Email").ToString
                        lblFullname.Text = "Full Name: " & reader("FullName").ToString
                        lblPhoneNumber.Text = "Phone number: " & reader("PNumber").ToString
                        Dim img As Image = Nothing
                        If (reader("PICTURE") IsNot Nothing) Then
                            Dim imageData() As Byte = DirectCast(reader("PICTURE"), Byte())
                            Using ms As New MemoryStream(imageData)
                                img = Image.FromStream(ms)
                            End Using
                            pboProfile.Image = img
                        End If
                    End While
                    reader.Close()
                End Using

                Dim queryStatus = "SELECT `VISATYPE`,`Status`, `created` FROM `userinfo` WHERE `signupID` = @id"
                Using cmd As New MySqlCommand(queryStatus, con)
                    cmd.Parameters.AddWithValue("@id", Login1.id)
                    dr = cmd.ExecuteReader
                    While dr.Read
                        histroy()
                    End While
                    dr.Close()
                End Using

                Dim queryAppoint = "SELECT `Appoint_Date`, `userinfo`.`Status`, `Appoint_Time` FROM `appointment_schedule` JOIN `userinfo` on `appointment_schedule`.`user_id` = `userinfo`.`User_id` WHERE `userinfo`.`signupID` = @id;"
                Using Appointcmd As New MySqlCommand(queryAppoint, con)
                    Appointcmd.Parameters.AddWithValue("@id", Login1.id)
                    drAppoint = Appointcmd.ExecuteReader
                    While drAppoint.Read
                        Appointhistroy()
                    End While
                    drAppoint.Close()
                End Using

            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Shared histroyTop As Integer = 10
    Private Sub histroy()

        Dim panel As New Guna2Panel With {
        .Width = Me.palMain.Width - 30,
        .Height = 40,
        .FillColor = Color.Gainsboro,
        .Top = histroyTop,
        .BorderStyle = Drawing2D.DashStyle.Solid,
        .BorderThickness = 1,
        .BorderRadius = 5,
        .Left = 10
        }

        Dim type As New Label With {
        .Text = dr("VISATYPE"),
        .Font = New Font("Poppins", 10, FontStyle.Bold),
        .Left = 0,
        .Width = (panel.Width / 3) + 20,
        .Top = 10,
            .BackColor = Color.Transparent
        }
        panel.Controls.Add(type)

        Dim visaDate As New Label With {
        .Text = dr("created").ToString,
        .Font = New Font("Poppins", 10),
        .Width = (panel.Width / 3) - 20,
        .Height = 20,
        .Left = type.Width + type.Left + 20,
        .Top = type.Top,
            .BackColor = Color.Transparent
        }
        panel.Controls.Add(visaDate)

        Dim status As New Label With {
        .Text = dr("Status"),
        .Font = New Font("Poppins", 10),
        .Left = visaDate.Width + visaDate.Left + 10,
        .Top = type.Top,
        .Height = 20,
            .BackColor = Color.Transparent
        }
        panel.Controls.Add(status)

        histroyTop += panel.Height + 10

        Me.palMain.Controls.Add(panel)
    End Sub

    Shared AppointTop As Integer = 10

    Private Sub Appointhistroy()

        Dim panel As New Guna2Panel With {
        .Width = Me.palAppoint.Width - 30,
        .Height = 40,
        .FillColor = Color.Gainsboro,
        .Top = AppointTop,
        .BorderStyle = Drawing2D.DashStyle.Solid,
        .BorderThickness = 1,
        .BorderRadius = 5,
        .Left = 10
        }


        Dim AppointDate As New Label With {
        .Text = drAppoint("Appoint_Date").ToString,
        .Font = New Font("Poppins", 10),
        .Width = (panel.Width / 3),
        .Height = 20,
        .Left = 0,
        .Top = 10,
            .BackColor = Color.Transparent
        }
        panel.Controls.Add(AppointDate)

        Dim AppointTime As New Label With {
        .Text = drAppoint("Appoint_Time").ToString,
        .Font = New Font("Poppins", 10),
        .Width = (panel.Width / 3),
        .Height = 20,
        .Left = AppointDate.Width + AppointDate.Left,
        .Top = AppointDate.Top,
            .BackColor = Color.Transparent
        }
        panel.Controls.Add(AppointTime)

        Dim status As New Label With {
        .Text = drAppoint("Status"),
        .Font = New Font("Poppins", 10),
        .Left = AppointTime.Width + AppointTime.Left + 10,
        .Top = AppointDate.Top,
        .Height = 20,
            .BackColor = Color.Transparent
        }
        panel.Controls.Add(status)

        AppointTop += panel.Height + 10

        Me.palAppoint.Controls.Add(panel)
    End Sub
End Class