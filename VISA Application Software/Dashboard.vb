Public Class Dashboard


    Private Sub BtnNavigation_Click(sender As Object, e As EventArgs) Handles btnNavigation.Click
        If pnlPersonalInformation.Visible Then
            pnlPersonalInformation.Visible = False
            pnlNationalInformation.Visible = True
            btnNavigation.Text = "Back"
            lblHeading.Text = "National Information"
        Else
            pnlPersonalInformation.Visible = True
            pnlNationalInformation.Visible = False
            btnNavigation.Text = "Next"
            lblHeading.Text = "Personal Information"
        End If
    End Sub

    Private Sub BtnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.ShowDialog()
        pBoxProfilePicture.ImageLocation = OpenFileDialog1.FileName
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Me.Hide()
        frmVisaDateAppoint.Show()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub
    Private Sub TextBox6_keyPress(Sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox13_keyPress(Sender As Object, e As KeyPressEventArgs) Handles TextBox13.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles TextBox13.TextChanged

    End Sub

    Private Sub TextBox15_TextChanged(sender As Object, e As EventArgs) Handles TextBox15.TextChanged

    End Sub
    Private Sub TextBox15_keyPress(Sender As Object, e As KeyPressEventArgs) Handles TextBox15.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox8_keyPress(Sender As Object, e As KeyPressEventArgs) Handles TextBox8.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
    Private Sub TextBox1_Validating(Sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBox1.Validating
        If TextBox1.Text.Trim() = "" Then
            MessageBox.Show("Please Complete the first Name Section before  Proceeding")
            e.Cancel = True
        Else TextBox3.Focus()
        End If
    End Sub
    Private Sub TextBox3_Validating(Sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBox3.Validating
        If TextBox1.Text.Trim() = "" Then
            MessageBox.Show("Please fill in the last name section before  Proceeding")
            e.Cancel = True

        End If
    End Sub
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub PBoxProfilePicture_Click(sender As Object, e As EventArgs) Handles pBoxProfilePicture.Click
        pBoxProfilePicture.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class


