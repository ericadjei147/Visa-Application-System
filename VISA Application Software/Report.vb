Imports MySql.Data.MySqlClient

Public Class Report
    Dim dbDataset1 As New DataTable
    Dim check = False

    Private Sub loadData(ByVal dataGridView As DataGridView)
        Dim SDA As New MySqlDataAdapter
        Dim bsource As New BindingSource
        Dim dbDataset As New DataTable

        Dim connection As New MySqlConnection(My.Settings.conStr)

        Try
            connection.Open()

            Dim query As String = "SELECT Status, COUNT(Status) as Number FROM userinfo GROUP by Status ORDER by Status ;"
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

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If check Then
            Dim DV As New DataView(dbDataset1)
            DV.RowFilter = String.Format("Status like '%{0}%'", txtSearch.Text)
            dgvReport.DataSource = DV
        End If
    End Sub

    Private Sub Report_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadData(dgvReport)

        Using con As New MySqlConnection(My.Settings.conStr)
            con.Open()
            Dim query = "SELECT `Status`, COUNT(`Status`) as Number FROM `userinfo` GROUP by Status;"
            Using cmd As New MySqlCommand(query, con)
                Dim dr = cmd.ExecuteReader
                Dim count = 0
                While dr.Read
                    If Not IsDBNull(dr("Status")) Then
                        Select Case dr("Status").ToString()
                            Case "Pending"
                                lblPending.Text = "Pending: " & dr("Number").ToString()
                            Case "Approved"
                                lblApproved.Text = "Approved: " & dr("Number").ToString()
                            Case "Rejected"
                                lblRejected.Text = "Rejected: " & dr("Number").ToString()
                        End Select

                    End If
                    count += 1
                End While
                lblTotal.Text = "Total: " & count
            End Using
        End Using

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        reportAdmin.ShowDialog()
    End Sub
End Class