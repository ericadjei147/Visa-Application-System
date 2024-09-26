Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.Net.Mail
Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Imports System.IO
Public Class SignUp1
    Private captchaText As String

    Private Sub GenerateCaptcha()
        Dim random As New Random()
        captchaText = New String(Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", 6) _
        .Select(Function(s) s(random.Next(s.Length))).ToArray())

        Dim captchaImage As New Bitmap(200, 60)
        Dim graphics As Graphics = Graphics.FromImage(captchaImage)
        graphics.SmoothingMode = SmoothingMode.AntiAlias
        graphics.FillRectangle(Brushes.White, 0, 0, captchaImage.Width, captchaImage.Height)

        Dim font As New Font("Arial", 24, FontStyle.Bold)
        Dim brush As New HatchBrush(HatchStyle.DiagonalCross, Color.LightGray, Color.Black)

        ' Apply distortions and noise
        For i As Integer = 0 To captchaText.Length - 1
            Dim charX As Integer = 10 + i * 30
            Dim charY As Integer = random.Next(10, 30)

            ' Rotate each character slightly
            Dim angle As Integer = random.Next(-30, 30)
            graphics.TranslateTransform(charX, charY)
            graphics.RotateTransform(angle)
            graphics.DrawString(captchaText(i), font, brush, 0, 0)
            graphics.RotateTransform(-angle)
            graphics.TranslateTransform(-charX, -charY)
        Next

        ' Add more noise to the image
        For i As Integer = 0 To 100
            Dim x As Integer = random.Next(captchaImage.Width)
            Dim y As Integer = random.Next(captchaImage.Height)
            captchaImage.SetPixel(x, y, Color.Black)
        Next

        ' Add random lines for additional noise
        For i As Integer = 0 To 10
            Dim x1 As Integer = random.Next(captchaImage.Width)
            Dim y1 As Integer = random.Next(captchaImage.Height)
            Dim x2 As Integer = random.Next(captchaImage.Width)
            Dim y2 As Integer = random.Next(captchaImage.Height)
            graphics.DrawLine(New Pen(Color.Gray), x1, y1, x2, y2)
        Next

        picCaptcha.Image = captchaImage
    End Sub
    Private Sub Panel_Paint(sender As Object, e As PaintEventArgs)

    End Sub
    Private Function PhoneNumber(phone As String) As Boolean
        ' Simple regex for phone number validation (international format included)
        Dim phonePattern As String = "^\+?[1-9]\d{1,14}$"
        Return Regex.IsMatch(phone, phonePattern)
    End Function

    Private Sub ViewPassword_CheckedChanged(sender As Object, e As EventArgs) Handles ViewPassword.CheckedChanged
        If ViewPassword.Checked Then
            txtPassword.UseSystemPasswordChar = False
            txtConfirmpassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
            txtConfirmpassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtPhoneNumber_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnRefreshCaptcha_Click(sender As Object, e As EventArgs) Handles btnRefreshCaptcha.Click
        GenerateCaptcha()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If ValidateInputs() Then
            Try
                ' Clear previous error messages
                lblError.Text = ""

                ' Validate inputs
                ' Perform signup logic (e.g., save to database)
                Using con As New MySqlConnection(My.Settings.conStr)
                    con.Open()
                    Dim qurey = "INSERT INTO `signup`(`FName`, `LName`, `Email`, `PNumber`, `UserName`, `DoB`, `Nationality`, `Gender`, `Password`, `Role`, `picture`) VALUES (@FName,@LName,@Email,@PNumber,@UserName,@DoB,@Nationality,@Gender,@Password,'USER', @picture);"
                    Using cmd As New MySqlCommand(qurey, con)
                        cmd.Parameters.AddWithValue("@FName", txtFirstName.Text)
                        cmd.Parameters.AddWithValue("@LName", txtLastName.Text)
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
                        cmd.Parameters.AddWithValue("@PNumber", txtPhoneNumber.Text)
                        cmd.Parameters.AddWithValue("@UserName", txtUsername.Text)
                        cmd.Parameters.AddWithValue("@DoB", dtpDOB.Value)
                        cmd.Parameters.AddWithValue("@Nationality", cmbNationality.Text)
                        cmd.Parameters.AddWithValue("@Gender", cmbGender.Text)
                        cmd.Parameters.AddWithValue("@Password", txtPassword.Text)
                        cmd.Parameters.AddWithValue("@picture", imageBytes1)
                        cmd.ExecuteReader()
                    End Using
                End Using

                MessageBox.Show("Signup successful!")

                Login1.Show()

                ' Optionally, hide or close the current form
                Me.Hide()

            Catch ex As Exception
                MessageBox.Show("Error occured: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try
        End If

    End Sub

    Private Function ValidateInputs() As Boolean
        ' First Name validation
        If String.IsNullOrEmpty(txtFirstName.Text) Or txtFirstName.Text.Trim.Length < 3 Then
            lblError.Text = "First Name is required."
            Return False
        End If

        ' Last Name validation
        If String.IsNullOrEmpty(txtLastName.Text) Or txtLastName.Text.Trim.Length < 3 Then
            lblError.Text = "Last Name is required."

            Return False
        End If

        ' Username validation
        If String.IsNullOrEmpty(txtUsername.Text) Then
            lblError.Text = "Username is required."
            Return False
        End If

        ' Password validation
        If String.IsNullOrEmpty(txtPassword.Text) OrElse txtPassword.Text.Length < 6 Then
            lblError.Text = "Password is required and must be at least 6 characters long."
            Return False
        End If

        ' Confirm password validation
        If txtPassword.Text <> txtConfirmpassword.Text Then
            lblError.Text = "Passwords do not match."
            Return False
        End If

        ' Email validation
        If Not IsValidEmail(txtEmail.Text) Then
            lblError.Text = "Invalid email address."
            Return False
        End If

        ' Phone number validation
        If Not PhoneNumber(txtPhoneNumber.Text) Or txtPhoneNumber.Text.Trim.Length < 10 Then
            lblError.Text = "Invalid phone number."
            Return False
        End If

        ' Date of Birth validation
        If Not IsValidDOB(dtpDOB.Value) Then
            lblError.Text = "Invalid Date of Birth. You must be at least 18 years old."
            Return False
        End If

        ' Gender validation
        If cmbGender.SelectedIndex = -1 Then
            lblError.Text = "Gender is required."
            Return False
        End If

        ' Nationality validation
        If cmbNationality.SelectedIndex = -1 Then
            lblError.Text = "Nationality is required."
            Return False
        End If

        If Not check Then
            lblError.Text = "Please select a profile picture before you proceed."
            Return False
        End If

        ' Terms and Conditions validation
        If Not chkTerms.Checked Then
            lblError.Text = "You must accept the terms and conditions."
            Return False
        End If

        ' CAPTCHA validation
        If String.IsNullOrEmpty(txtCaptcha.Text) OrElse txtCaptcha.Text <> captchaText Then
            lblError.Text = "Invalid CAPTCHA."
            Return False
        End If

        Return True
    End Function
    Private Function IsValidEmail(email As String) As Boolean
        Try
            Dim addr = New MailAddress(email)
            Return addr.Address = email
        Catch
            Return False
        End Try
    End Function

    Private Function IsPhoneNumber(phone As String) As Boolean
        ' Simple regex for phone number validation (modify as needed)
        Dim phonePattern As String = "^\d{10}$"
        Return Regex.IsMatch(phone, phonePattern)
    End Function

    Private Function IsValidDOB(dob As DateTime) As Boolean
        ' Check if the user is at least 18 years old
        Dim today As DateTime = DateTime.Today
        Dim age As Integer = today.Year - dob.Year
        If dob > today.AddYears(-age) Then age -= 1
        Return age >= 18
    End Function

    Private Sub PopulateGenderComboBox()
        cmbGender.Items.Add("Male")
        cmbGender.Items.Add("Female")
        cmbGender.Items.Add("Other")
        cmbGender.SelectedIndex = -1
    End Sub

    Private Sub PopulateNationalityComboBox()
        cmbNationality.SelectedIndex = -1
    End Sub
    Private Sub SignUp1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GenerateCaptcha()
        PopulateGenderComboBox()
        PopulateNationalityComboBox()
    End Sub

    Private Sub HaveAccount_Click(sender As Object, e As EventArgs) Handles HaveAccount.Click

        Login1.Show()
        Me.Hide()
    End Sub

    Private Sub chkTerms_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub chkTerms_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtFirstName_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtFirstName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFirstName.KeyPress
        If Char.IsControl(e.KeyChar) Then
            Return
        End If

        If Not Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtLastName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLastName.KeyPress
        If Char.IsControl(e.KeyChar) Then
            Return
        End If

        If Not Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtPhoneNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhoneNumber.KeyPress
        If Char.IsControl(e.KeyChar) Then
            Return
        End If
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub HaveAccount_Click_1(sender As Object, e As EventArgs) Handles HaveAccount.Click

    End Sub
    Dim imageBytes1 As Byte()
    Dim check = False
    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs) Handles GunaGradientButton1.Click
        OpenFileDialog1.Title = "PROFILE PICTURE"
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            pBoxProfilePicture.Image = Image.FromFile(OpenFileDialog1.FileName)
            imageBytes1 = File.ReadAllBytes(OpenFileDialog1.FileName)
            check = True
        End If
    End Sub
End Class