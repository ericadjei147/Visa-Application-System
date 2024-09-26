Public Class Settings
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub


    Private Sub btnOldView_CheckedChanged(sender As Object, e As EventArgs) Handles btnOldView.CheckedChanged
        If btnOldView.Checked Then
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

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class