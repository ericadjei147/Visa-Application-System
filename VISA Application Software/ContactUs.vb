Imports System.Net.Mail
Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class ContactUs
    'Private myMsg As New MailMessage
    'Private smtpSender As New SmtpClient
    'Public Shadows password As String = ""

    '' Create the email message
    'Public Sub createMessage()
    '    Try
    '        myMsg.From = New MailAddress(txtFrom.Text.Trim)
    '        myMsg.To.Add(txtTo.Text.Trim)
    '        myMsg.Subject = txtSubject.Text.Trim
    '        myMsg.Body = txtBody.Text.Trim
    '        myMsg.Priority = MailPriority.Normal
    '    Catch ex As Exception
    '        MessageBox.Show("Error creating the email message: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    '' Setup SMTP client
    'Private Sub createSMTP()
    '    Try
    '        smtpSender.Credentials = New Net.NetworkCredential(txtFrom.Text.Trim, password.Trim)
    '        smtpSender.EnableSsl = True
    '        smtpSender.Host = "smtp.live.com" ' Change to your SMTP provider if needed
    '        smtpSender.Port = 587
    '    Catch ex As Exception
    '        MessageBox.Show("Error setting up SMTP client: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    '' Send the email message
    'Private Sub sendMessage()
    '    Try
    '        smtpSender.Send(myMsg)
    '        MessageBox.Show("Email sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    Catch ex As Exception
    '        MessageBox.Show("Error sending the email: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    '' Button click handler to send the email
    'Private Sub btnContactSend_Click(sender As Object, e As EventArgs) Handles btnContactSend.Click
    '    If String.IsNullOrEmpty(txtFrom.Text) Or String.IsNullOrEmpty(txtTo.Text) Or String.IsNullOrEmpty(txtSubject.Text) Or String.IsNullOrEmpty(txtBody.Text) Then
    '        MessageBox.Show("Please fill out all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        Exit Sub
    '    End If

    '    password = InputBox("Enter your Email Password")
    '    If String.IsNullOrEmpty(password) Then
    '        MessageBox.Show("Password cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        Exit Sub
    '    End If

    '    createMessage()
    '    createSMTP()
    '    sendMessage()

    '    txtFrom.Clear()
    '    txtBody.Clear()
    '    txtSubject.Clear()
    'End Sub

    Private Shared ReadOnly apiUrl As String = "https://api.resend.com/emails"
    Private Shared ReadOnly apiKey As String = "re_CnniPVFV_B9gtCFFDS2p8BZcQSnUnfUf9"

    Public Async Function SendEmail() As Task
        Using client As New HttpClient()
            ' Add the API key in the Authorization header
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}")

            ' Create the email content as an object
            Dim emailData As New With {
                .from = "Acme <ericadjei147@gmail.com>",
                .to = New String() {"wiikitv02@gmail.com"},
                .subject = "hello world",
                .html = "<p>it works!</p>"
            }

            ' Convert the email data to JSON format
            Dim jsonData As String = JsonConvert.SerializeObject(emailData)
            Dim content As New StringContent(jsonData, Encoding.UTF8, "application/json")

            ' Send the POST request
            Dim response As HttpResponseMessage = Await client.PostAsync(apiUrl, content)

            ' Check if the response is successful
            If response.IsSuccessStatusCode Then
                Dim responseContent As String = Await response.Content.ReadAsStringAsync()
                MessageBox.Show("Email sent successfully! Response: " & responseContent)
            Else
                MessageBox.Show("Failed to send email. Status code: " & response.StatusCode.ToString())
            End If
        End Using
    End Function

    Private Async Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnContactSend.Click
        Dim resendEmail As New ResendEmail()
        Await resendEmail.SendEmail()
    End Sub

End Class
