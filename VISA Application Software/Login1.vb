Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Public Class Login1
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

    Private Sub GunaGradient2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel.Paint

    End Sub


    Private Sub txtCaptcha_TextChanged(sender As Object, e As EventArgs) Handles txtCaptcha.TextChanged

    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        If chkShowPassword.Checked Then
            txtPassword.UseSystemPasswordChar = False
            txtPassword.PasswordChar = ""
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Login1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GenerateCaptcha()
    End Sub

    Public id = 0
    Public pass = ""
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try

            lblError.Text = ""

            ' Validate inputs
            If ValidateInputs() Then
                ' Perform login logic (e.g., check credentials against the database)

                ' Show the next form or proceed to the main application
                'Dim mainForm As New MainForm()
                ' mainForm.Show()

                ' Optionally, hide or close the current form
                ' Me.Hide() ' or Me.Close()

                Using con As New MySqlConnection(My.Settings.conStr)
                    con.Open()
                    Dim qurey = "SELECT `id`, `UserName`, `Password`, `Role` FROM `signup` WHERE `UserName` = @UserName and `Password` = @Password;"
                    Using cmd As New MySqlCommand(qurey, con)
                        cmd.Parameters.AddWithValue("@UserName", txtUsername.Text)
                        cmd.Parameters.AddWithValue("@Password", txtPassword.Text)
                        Dim dr As MySqlDataReader = cmd.ExecuteReader
                        Dim count = 0
                        While dr.Read
                            count += 1
                        End While
                        pass = txtPassword.Text
                        If count > 0 Then
                            id = CInt(dr("id"))
                            If dr("Role").ToString = "USER" Then
                                MessageBox.Show("Successful Login as User", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Me.Hide()
                                UpdateDashboard.Show()
                            ElseIf dr("Role").ToString = "ADMIN" Then
                                MessageBox.Show("Successful Login as Admin", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                ' MessageBox.Show("Login successful!")
                                Me.Hide()
                                frmAdminDashBoard.Show()
                            End If
                        Else
                            MessageBox.Show("Wrong Username Or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If

                        dr.Close()
                    End Using
                End Using

                'If dr.HasRows Then





            End If

        Catch ex As Exception
            MessageBox.Show("Error occured: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try ' Clear previous error messages

    End Sub

    Private Function ValidateInputs() As Boolean
        ' Username validation
        If String.IsNullOrEmpty(txtUsername.Text) Then
            lblError.Text = "Username is required."
            Return False
        End If

        ' Password validation
        If String.IsNullOrEmpty(txtPassword.Text) Then
            lblError.Text = "Password is required."
            Return False
        End If

        ' CAPTCHA validation
        If String.IsNullOrEmpty(txtCaptcha.Text) OrElse txtCaptcha.Text <> captchaText Then
            lblError.Text = "Invalid CAPTCHA."
            Return False
        End If

        ' Additional restrictions or validations
        ' e.g., Check if the username and password match the records in the database

        Return True
    End Function

    Private Sub btnRefreshCaptcha_Click(sender As Object, e As EventArgs) Handles btnRefreshCaptcha.Click
        GenerateCaptcha()
    End Sub

    Private Sub btnsignup_Click(sender As Object, e As EventArgs) Handles btnsignup.Click
        Me.Hide()
        SignUp1.Show()
    End Sub

    Private Sub picCaptcha_Click(sender As Object, e As EventArgs) Handles picCaptcha.Click

    End Sub
End Class