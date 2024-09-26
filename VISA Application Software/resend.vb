Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class ResendEmail
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
End Class
