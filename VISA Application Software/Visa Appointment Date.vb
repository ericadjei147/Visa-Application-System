Public Class frmVisaDateAppoint
    Dim times() As Integer = {8, 10, 12, 14}
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

        flpTime.Controls.Clear()

        For Each time In times
            Dim btnTime As Button = New Button
            Dim endTime As Integer = time + 2
            Dim btnText As String = time.ToString + ":00 - " + endTime.ToString + ":00"
            btnTime.Text = btnText
            btnTime.Size = New System.Drawing.Size(100, 32)

            AddHandler btnTime.Click, AddressOf TimeButton_Click

            flpTime.Controls.Add(btnTime)
        Next
    End Sub

    Private Sub TimeButton_Click(Sender As Button, e As EventArgs)
        addTime(Sender.Text)
    End Sub

    Private Sub addTime(time As String)
        lblSelectedDateTimePrompt.Text = DateTimePicker1.Value.ToLongDateString + ", " + time
        lblSelectedDateTimePrompt.Visible = True
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub frmVisaDateAppoint_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class