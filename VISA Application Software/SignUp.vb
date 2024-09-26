Public Class SignUp
    Private txtDOB As Object

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
    Private Sub TextBox1_keyDown(Sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")

        End If
    End Sub
    Private Sub TextBox1_keyPress(Sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox2_keyPress(Sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox2_keyDown(Sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")

        End If
    End Sub
    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs) Handles GunaGradientButton1.Click
        OpenFileDialog1.ShowDialog()
        PictureBox.Image = Image.FromFile(OpenFileDialog1.FileName)
    End Sub

    Private Sub SignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GunaCheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles GunaCheckBox1.CheckedChanged
        If GunaCheckBox1.Checked Then
            PasswordTextBox.PasswordChar = ChrW(0)
            ConfirmPwTextBox.PasswordChar = ChrW(0)
        Else
            PasswordTextBox.PasswordChar = "*"
            ConfirmPwTextBox.PasswordChar = "*"
        End If
    End Sub
    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        If PasswordTextBox.Text <> ConfirmPwTextBox.Text Then
            MessageBox.Show("Password Mismatch")
        Else

        End If
        If String.IsNullOrEmpty(TextBox1.Text) OrElse
                String.IsNullOrEmpty(TextBox2.Text) OrElse
                String.IsNullOrEmpty(TextBox3.Text) OrElse
                String.IsNullOrEmpty(TextBox4.Text) Then
            MessageBox.Show("There is an empty field")
        Else

        End If
        Dim dob As Date
        If Date.TryParse(DateOfBirth_Box.Text, dob) Then
            If dob < Date.Now.AddYears(-18) Then
                MessageBox.Show("You must be 18 or above to proceed.")
            Else
            End If
        Else
            MessageBox.Show("Invalid date format.Please enter a valid date.")
        End If
    End Sub
    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub PictureBox_Click(sender As Object, e As EventArgs) Handles PictureBox.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
    Private Function CalculateAge(dob As Date) As Integer
        Dim today As Date = Date.Today
        Dim age As Integer = today.Year - dob.Year
        If today.Month < dob.Month Or (today.Month = dob.Month And today.Day < dob.Day) Then
            age -= 1
        End If
        Return age
    End Function
    Private Sub TextBox3_keyDown(Sender As Object, e As KeyEventArgs) Handles TextBox3.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")

        End If
    End Sub
    Private Sub TextBox3_keyPress(Sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
    ' Private Function IsValid() As Boolean
    'If GunaDateTimePicker1.Value = DateTime.MaxValue OrElse
    '         GunaComboBox1.SelectedIndex = -1 Then
    '      Return False
    '   End If
    'Return True
    ' End Function

    Private Sub GunaComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GunaComboBox1.SelectedIndexChanged

    End Sub

    Private Sub GunaDateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub
End Class