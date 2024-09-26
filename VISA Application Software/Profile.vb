Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Profile
    Dim clicked = False
    Private Sub btnVisaAppliedDropDown_Click(sender As Object, e As EventArgs) Handles btnVisaAppliedDropDown.Click
        If Not clicked Then
            palMain.AutoScroll = True
            palMain.AutoScrollMargin = New Size(0, 20)
            palVisaApplied.Height = 188
            palVisaApplied.AutoScroll = True
            palVisaApplied.AutoScrollMargin = New Size(0, 20)
            palPrefre.Top += 188
            palDarkMode.Top += 188
            btnVisaAppliedDropDown.Left -= 20
            Guna2Panel6.Width -= 20
            btnVisaAppliedDropDown.Image = My.Resources.upload
            clicked = True
        Else
            palMain.AutoScroll = False
            palMain.AutoScrollMargin = New Size(0, 0)
            palVisaApplied.Height = 37
            palVisaApplied.AutoScroll = False
            palVisaApplied.AutoScrollMargin = New Size(0, 0)
            palPrefre.Top -= 188
            palDarkMode.Top -= 188
            btnVisaAppliedDropDown.Left += 20
            Guna2Panel6.Width += 20
            btnVisaAppliedDropDown.Image = My.Resources.arrow_down_sign_to_navigate
            clicked = False
        End If
    End Sub

    Private Sub btnEditProfile_Click(sender As Object, e As EventArgs) Handles btnEditProfile.Click
        EditProfile.ShowDialog()
    End Sub

    Private Sub GunaAdvenceTileButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton1.Click

    End Sub

    Private Sub Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Using con As New MySqlConnection(My.Settings.conStr)
                con.Open()
                Dim query = "SELECT `VISATYPE`, COUNT(`VISATYPE`) as Number FROM `userinfo` WHERE signupID = @id GROUP by `VISATYPE`;"
                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@id", Login1.id)
                    Dim dr = cmd.ExecuteReader
                    While dr.Read
                        If Not IsDBNull(dr("VISATYPE")) Then
                            Select Case dr("VISATYPE").ToString()
                                Case "Tourist Visa"
                                    lblTourist.Text = dr("Number").ToString()
                                Case "Student Visa"
                                    lblStudent.Text = dr("Number").ToString()
                                Case "Medical Visa"
                                    lblMedical.Text = dr("Number").ToString()
                                Case "Diplomatic Visa"
                                    lblDeplomatic.Text = dr("Number").ToString()
                                Case "Entertainer Visa"
                                    lblEntertainer.Text = dr("Number").ToString()
                                Case "Business Visa"
                                    lblBussiness.Text = dr("Number").ToString()
                            End Select
                        End If
                    End While
                    dr.Close()
                End Using



                Dim querypic = "SELECT `PICTURE` FROM `signup` where `Id` = '" & Login1.id & "'"
                Using cmd As New MySqlCommand(querypic, con)
                    Dim dr = cmd.ExecuteReader()
                    While dr.Read
                        Dim img As Image = Nothing
                        If (dr("PICTURE") IsNot Nothing) Then
                            Dim imageData() As Byte = DirectCast(dr("PICTURE"), Byte())
                            Using ms As New MemoryStream(imageData)
                                img = Image.FromStream(ms)
                            End Using
                            pboProfile.Image = img
                        End If
                    End While
                    dr.Close()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class