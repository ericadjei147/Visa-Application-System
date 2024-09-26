Imports MySql.Data.MySqlClient

Public Class Usermanagement
    Dim check = False
    Dim id = 0
    Dim dbDataset1 As New DataTable

    Private Sub Usermanagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData(dgvUserManagement)
    End Sub

    Private Sub loadData(ByVal dataGridView As DataGridView)
        Dim SDA As New MySqlDataAdapter
        Dim bsource As New BindingSource
        Dim dbDataset As New DataTable

        Dim connection As New MySqlConnection(My.Settings.conStr)

        Try
            connection.Open()

            Dim query As String = "SELECT `Id`, `FName` as `First Name`, `LName` as `Last Name`, `Email`, `UserName`, `DoB`, `Password` FROM `signup`;"
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

    Private Sub dgvUserManagement_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUserManagement.CellClick
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Dim row As New DataGridViewRow()
            row = Me.dgvUserManagement.Rows(e.RowIndex)
            id = CInt(row.Cells("id").Value)
            txtEmail.Text = row.Cells("Email").Value.ToString
            txtUsername.Text = row.Cells("UserName").Value.ToString
            txtPassword.Text = row.Cells("Password").Value.ToString
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If check Then
            Dim DV As New DataView(dbDataset1)
            DV.RowFilter = String.Format("UserName like '%{0}%' or Password like '%{0}%' or Email like '%{0}%' or [First Name] like '%{0}%' or [Last Name] like '%{0}%'", txtSearch.Text)
            dgvUserManagement.DataSource = DV
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clear()
    End Sub

    Private Sub clear()
        txtEmail.Clear()
        txtPassword.Clear()
        txtUsername.Clear()
        id = 0
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If id <> 0 Then
            Try
                Using con As New MySqlConnection(My.Settings.conStr)
                    con.Open()
                    Dim query = "UPDATE `signup` SET `Email`= @Email,`UserName`= @UserName,`Password`= @Password WHERE `Id`=@id;"
                    Using cmd As New MySqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@id", id)
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
                        cmd.Parameters.AddWithValue("@UserName", txtUsername.Text)
                        cmd.Parameters.AddWithValue("@Password", txtPassword.Text)
                        cmd.ExecuteNonQuery()
                        clear()
                        loadData(dgvUserManagement)
                        MessageBox.Show("Updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Select From The Table Above", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class