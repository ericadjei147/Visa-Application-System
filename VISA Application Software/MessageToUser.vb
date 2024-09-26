Imports MySql.Data.MySqlClient

Public Class MessageToUser

    Dim dbDataset1 As New DataTable
    Private Sub loadData(ByVal dataGridView As DataGridView)
        Dim SDA As New MySqlDataAdapter
        Dim bsource As New BindingSource
        Dim dbDataset As New DataTable

        Dim connection As New MySqlConnection(My.Settings.conStr)

        Try
            connection.Open()

            Dim query As String = "SELECT `Id`, concat(`FName`,' ',`LName`) as `Fullname`, `Email`, `UserName` FROM `signup` where role <> 'ADMIN';"
            Using command = New MySqlCommand(query, connection)
                SDA.SelectCommand = command
                SDA.Fill(dbDataset)
                bsource.DataSource = dbDataset
                dataGridView.DataSource = bsource
                SDA.Update(dbDataset)
            End Using
            dbDataset1 = dbDataset
            check = True
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Dim id = 0
    Private Sub Guna2DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellClick
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Dim row As New DataGridViewRow()
            row = Me.Guna2DataGridView1.Rows(e.RowIndex)
            id = CInt(row.Cells("id").Value)
            txtEmail.Text = row.Cells("Email").Value.ToString
            txtUsername.Text = row.Cells("UserName").Value.ToString
            txtFullname.Text = row.Cells("Fullname").Value.ToString
        End If
    End Sub

    Private Sub MessageToUser_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadData(Guna2DataGridView1)
    End Sub

    Dim check = False
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If check Then
            Dim DV As New DataView(dbDataset1)
            DV.RowFilter = String.Format("UserName like '%{0}%' or Email like '%{0}%' or Fullname like '%{0}%'", txtSearch.Text)
            Guna2DataGridView1.DataSource = DV
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If id <> 0 Then
            Try
                Using con As New MySqlConnection(My.Settings.conStr)
                    con.Open()
                    Dim qury = "INSERT INTO `message`(`Sendto`, `Message`) VALUES (@Sendto,@Message);"
                    Using cmd As New MySqlCommand(qury, con)
                        cmd.Parameters.AddWithValue("@Sendto", id)
                        cmd.Parameters.AddWithValue("@Message", txtMessage.Text)
                        cmd.ExecuteNonQuery()
                        MessageBox.Show("Message Sent", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtMessage.Clear()
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Select the Applicant", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class