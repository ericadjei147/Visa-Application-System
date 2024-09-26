Imports MySql.Data.MySqlClient
Imports Guna.UI2.WinForms
Public Class frmSetting
    Private Sub btnNotificationSend_Click(sender As Object, e As EventArgs) Handles btnNotificationSend.Click
        MessageToUser.ShowDialog()
    End Sub

    Private Sub frmSetting_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Using con As New MySqlConnection(My.Settings.conStr)
                con.Open()
                Dim query = "SELECT `UserName` FROM `signup` where `Id` = '" & Login1.id & "'"
                Using cmd As New MySqlCommand(query, con)
                    Dim dr = cmd.ExecuteReader()
                    While dr.Read
                        txtUsername.Text = dr("UserName").ToString
                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnOldView1_CheckedChanged(sender As Object, e As EventArgs) Handles btnOldView1.CheckedChanged
        If btnOldView1.Checked Then
            txtOddPassword.UseSystemPasswordChar = False
            txtOddPassword.PasswordChar = ""
        Else
            txtOddPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnNewView_CheckedChanged(sender As Object, e As EventArgs) Handles btnNewView.CheckedChanged
        If btnNewView.Checked Then
            txtNewPassword.UseSystemPasswordChar = False
            txtNewPassword.PasswordChar = ""
        Else
            txtNewPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        If Login1.id <> 0 Then
            If txtOddPassword.Text.Length <= 0 Then
                MessageBox.Show("Type your old password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If txtNewPassword.Text.Length <= 0 Then
                MessageBox.Show(" Set a new password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If Not String.Equals(Login1.pass, txtOddPassword.Text) Then
                MessageBox.Show("Wrong Old Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Using con As New MySqlConnection(My.Settings.conStr)
                con.Open()
                Dim qurey = "UPDATE `signup` SET `Password`=@Cpass  WHERE `Id`=@id and `Password`=@Opass;"
                Using cmd As New MySqlCommand(qurey, con)
                    cmd.Parameters.AddWithValue("@id", Login1.id)
                    cmd.Parameters.AddWithValue("@Cpass", txtNewPassword.Text)
                    cmd.Parameters.AddWithValue("@Opass", txtOddPassword.Text)
                    cmd.ExecuteNonQuery()
                    Login1.pass = txtNewPassword.Text
                    txtOddPassword.Clear()
                    txtNewPassword.Clear()
                    MessageBox.Show("Change Password Successful", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            End Using
        End If
    End Sub
End Class