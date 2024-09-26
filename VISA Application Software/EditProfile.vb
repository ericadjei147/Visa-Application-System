Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Imports System.IO

Public Class EditProfile

    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton1.Click
        Me.Hide()
        Dashboard1.childform(Profile)
    End Sub

    Private Sub EditProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Using con As New MySqlConnection(My.Settings.conStr)
                con.Open()
                Dim query = "SELECT `FName`, `LName`, `Email`, `PNumber`, `UserName`, `DoB`, `Password`,`PICTURE` FROM `signup` where `Id` = '" & Login1.id & "'"
                Using cmd As New MySqlCommand(query, con)
                    Dim dr = cmd.ExecuteReader()
                    While dr.Read
                        txtUsername.Text = dr("UserName").ToString
                        txtFirstname.Text = dr("FName").ToString
                        txtLastname.Text = dr("LName").ToString
                        txtEmail.Text = dr("Email").ToString
                        txtPhoneNumber.Text = dr("PNumber").ToString
                        txtPassword.Text = dr("Password").ToString
                        dtpDOB.Value = dr("DoB")
                        Dim img As Image = Nothing
                        If (dr("PICTURE") IsNot Nothing) Then
                            Dim imageData() As Byte = DirectCast(dr("PICTURE"), Byte())
                            Using ms As New MemoryStream(imageData)
                                img = Image.FromStream(ms)
                            End Using
                            pboProfile.Image = img
                        End If
                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If ValidateForm() Then

            Try
                Using con As New MySqlConnection(My.Settings.conStr)
                    con.Open()
                    Dim query = "UPDATE `signup` SET `FName`=@FName,`LName`=@LName,`Email`=@Email,`PNumber`=@PNumber,`DoB`=@DoB,`Password`=@Password, `PICTURE`=@picture WHERE `UserName`=@UserName;"
                    Using cmd As New MySqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@FName", txtFirstname.Text)
                        cmd.Parameters.AddWithValue("@LName", txtLastname.Text)
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
                        cmd.Parameters.AddWithValue("@PNumber", txtPhoneNumber.Text)
                        cmd.Parameters.AddWithValue("@DoB", dtpDOB.Value)
                        cmd.Parameters.AddWithValue("@Password", txtPassword.Text)
                        cmd.Parameters.AddWithValue("@UserName", txtUsername.Text)
                        cmd.Parameters.AddWithValue("@picture", imageBytes1)
                        cmd.ExecuteNonQuery()
                        MessageBox.Show("Profile is Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged

    End Sub
    Private Function IsValidPhoneNumber(phone As String) As Boolean
        ' Simple regex for phone number validation (international format included)
        Dim phonePattern As String = "^\+?\d{1,14}$"
        Return Regex.IsMatch(phone, phonePattern)
    End Function


    Private Function IsValidEmail(email As String) As Boolean
        ' Simple regex for email validation
        Dim emailPattern As String = "^[^@\s]+@[^@\s]+\.[^@\s]+$"
        Return Regex.IsMatch(email, emailPattern)
    End Function
    Private Sub txtPhoneNumber_TextChanged(sender As Object, e As EventArgs) Handles txtPhoneNumber.TextChanged

    End Sub
    Private Sub txtPhoneNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhoneNumber.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtFirstName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFirstname.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> vbBack AndAlso e.KeyChar <> " "c Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtLastName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLastname.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> vbBack AndAlso e.KeyChar <> " "c Then
            e.Handled = True
        End If
    End Sub
    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        If chkShowPassword.Checked Then
            txtPassword.UseSystemPasswordChar = True
            txtPassword.PasswordChar = ""
        Else
            txtPassword.UseSystemPasswordChar = False
        End If
    End Sub
    Public Function ValidateForm() As Boolean
        Dim isValid As Boolean = True
        Dim errorMessage As String = ""

        If Not IsValidPhoneNumber(txtPhoneNumber.Text) Then
            isValid = False
            errorMessage &= "Invalid phone number." & vbCrLf
            txtPhoneNumber.Focus()
        End If

        If Not IsValidEmail(txtEmail.Text) Then
            isValid = False
            errorMessage &= "Invalid email address." & vbCrLf
        End If

        If String.IsNullOrEmpty(txtFirstname.Text) Or txtFirstname.Text.Trim.Length < 3 Then
            MessageBox.Show("Invalid first name." & vbCrLf)
            Return False
        End If

        If String.IsNullOrEmpty(txtLastname.Text) Or txtLastname.Text.Trim.Length < 3 Then
            MessageBox.Show("Invalid last name." & vbCrLf)
            Return False
        End If

        Dim today As DateTime = DateTime.Now
        Dim minDateOfBirth As DateTime = today.AddYears(-18)
        If dtpDOB.Value > minDateOfBirth Then
            MessageBox.Show("You must be at least 18 years old.")
            Return False
        End If
        Return isValid
    End Function
    Dim imageBytes1 As Byte()
    Dim check = False
    Private Sub btnEditProfile_Click(sender As Object, e As EventArgs) Handles btnEditProfile.Click
        OpenFileDialog1.Title = "PICTURE"
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            pboProfile.Image = Image.FromFile(OpenFileDialog1.FileName)
            imageBytes1 = File.ReadAllBytes(OpenFileDialog1.FileName)
            check = True
        End If
    End Sub
End Class