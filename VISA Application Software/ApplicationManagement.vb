Imports MySql.Data.MySqlClient

Public Class ApplicationManagement
    Dim dbDataset1 As New DataTable
    Dim check = False
    Public id As Integer = 0

    Private Sub loadData(ByVal dataGridView As DataGridView)
        Dim SDA As New MySqlDataAdapter
        Dim bsource As New BindingSource
        Dim dbDataset As New DataTable

        Dim connection As New MySqlConnection(My.Settings.conStr)

        Try
            connection.Open()

            Dim query As String = "SELECT `User_id`, `FName`as `First Name`, `LName` as `Last Name`, `DOB` as `Date Of Birth`, `Gender`, `Nationality`, `Address`, `PNumber`, `EmailAddress`, `POfTravel`, `Des_Country`, `EntryDate`, `ExitDate`, `TravelPlan`, `PassType`, `Pass_Iss_Date`, `Pass_Expir_Date`, `PassNumber`, `Edu_BG`, `VISATYPE`, `Status` FROM `userinfo`;"
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

    Private Sub ApplicationManagement_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadData(dgvApplicationManagement)
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If check Then
            Dim DV As New DataView(dbDataset1)
            DV.RowFilter = String.Format("[First Name] like '%{0}%' or [Last Name] like '%{0}%' or Nationality like '%{0}%' or EmailAddress like '%{0}%' or PNumber like '%{0}%'", txtSearch.Text)
            dgvApplicationManagement.DataSource = DV
        End If
    End Sub

    Private Sub dgvApplicationManagement_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvApplicationManagement.CellClick
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Dim row As New DataGridViewRow
            row = Me.dgvApplicationManagement.Rows(e.RowIndex)
            id = CInt(row.Cells("User_id").Value)
            txtFirstName.Text = row.Cells("First Name").Value.ToString
            txtLastName.Text = row.Cells("Last Name").Value.ToString
            txtVisaType.Text = row.Cells("VISATYPE").Value.ToString
        End If
    End Sub

    Private Sub cmbStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStatus.SelectedIndexChanged
        If cmbStatus.SelectedIndex <> 0 Then
            Dim DV As New DataView(dbDataset1)
            DV.RowFilter = String.Format("Status like '%{0}%'", cmbStatus.Text)
            dgvApplicationManagement.DataSource = DV
        Else
            loadData(dgvApplicationManagement)
        End If
    End Sub

    Private Sub btnRejected_Click(sender As Object, e As EventArgs) Handles btnRejected.Click
        ChangeStatus("Rejected")
    End Sub

    Private Sub btnApproved_Click(sender As Object, e As EventArgs) Handles btnApproved.Click
        ChangeStatus("Approved")
    End Sub

    Private Sub clear()
        txtFirstName.Clear()
        txtLastName.Clear()
        txtVisaType.Clear()
        id = 0
    End Sub

    Private Sub ChangeStatus(ByVal Status As String)
        If id <> 0 Then
            Try
                Using con As New MySqlConnection(My.Settings.conStr)
                    con.Open()
                    Dim query = "UPDATE `userinfo` SET `Status`= @Status WHERE `User_id`=@id;"
                    Using cmd As New MySqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@id", id)
                        cmd.Parameters.AddWithValue("@Status", Status)
                        cmd.ExecuteNonQuery()
                        clear()
                        loadData(dgvApplicationManagement)
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


    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        If id <> 0 Then
            DocumentPreview.sendId = id
            DocumentPreview.ShowDialog()
        Else
            MessageBox.Show("Select From The Table Above", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class