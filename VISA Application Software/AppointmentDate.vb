Imports MySql.Data.MySqlClient

Public Class AppointmentDate
    Dim Check = False

    Dim times() As Integer = {8, 10, 12, 14}
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dtpAppointDate.ValueChanged
        flpTime.Controls.Clear()
        If Check Then
            For Each time In times
                Dim btnTime As Button = New Button
                Dim endTime As Integer = time + 2
                Dim btnText As String = time.ToString + ":00 - " + endTime.ToString + ":00"
                btnTime.Text = btnText
                btnTime.Size = New System.Drawing.Size(100, 32)

                AddHandler btnTime.Click, AddressOf TimeButton_Click

                flpTime.Controls.Add(btnTime)
            Next
            flpTime.Visible = True
        End If
    End Sub

    Private Sub TimeButton_Click(Sender As Button, e As EventArgs)
        addTime(Sender.Text)
    End Sub

    Private Sub addTime(time As String)
        lblSelectedDateTimePrompt.Text = dtpAppointDate.Value.ToLongDateString + ", " + time
        lblSelectedDateTimePrompt.Visible = True
        Dim message As DialogResult = MessageBox.Show("Do you want your appointment schedule to be at " & lblSelectedDateTimePrompt.Text.ToString, "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If message = DialogResult.Yes Then
            If MainForm1.userID <> 0 Then
                Try
                    Using Con As New MySqlConnection(My.Settings.conStr)
                        Con.Open()
                        Dim query = "INSERT INTO `appointment_schedule`(`user_id`, `Appoint_Date`, `Appoint_Time`) VALUES (@user_id,@Appoint_Date,@Appoint_Time)"
                        Using cmd As New MySqlCommand(query, Con)
                            cmd.Parameters.AddWithValue("@user_id", MainForm1.userID)
                            cmd.Parameters.AddWithValue("@Appoint_Date", dtpAppointDate.Value)
                            cmd.Parameters.AddWithValue("@Appoint_Time", time)
                            cmd.ExecuteNonQuery()
                        End Using
                        MessageBox.Show("THANK YOU, Your appointment has been successfully scheduled for " & lblSelectedDateTimePrompt.Text.ToString & ", " & vbNewLine &
                                    "We will contact you for any information ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        UpdateDashboard.Show()
                        MainForm1.Close()
                        Me.Hide()

                    End Using
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                MessageBox.Show("Fill in the Application Form first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub AppointDate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Check = True
    End Sub




End Class