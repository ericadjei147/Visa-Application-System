Imports MySql.Data.MySqlClient

Public Class DashAdmin
    Private Sub DashAdmin_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Using con As New MysqlConnection(My.Settings.conStr)
                con.Open
                Dim query = "SELECT `Status`, COUNT(`Status`) as Number FROM `userinfo` GROUP by `Status`;"
                Using cmd As New MySqlCommand(query, con)
                    Dim dr = cmd.ExecuteReader
                    Dim count = 0
                    While dr.Read
                        If Not IsDBNull(dr("Status")) Then
                            Select Case dr("Status").ToString()
                                Case "Pending"
                                    lblPending.Text = dr("Number").ToString()
                                Case "Approved"
                                    lblApproved.Text = dr("Number").ToString()
                                Case "Rejected"
                                    lblRejected.Text = dr("Number").ToString()
                            End Select

                        End If
                        count += 1
                    End While
                    lblTotal.Text = CInt(lblPending.Text) + CInt(lblApproved.Text) + CInt(lblRejected.Text)
                    lblAppTotal.Text = "TOTAL APPLICATION: " & CInt(lblPending.Text) + CInt(lblApproved.Text) + CInt(lblRejected.Text)
                    dr.Close()
                End Using

                Dim ChaQuery = "SELECT Status as s, COUNT(Status) as n FROM userinfo GROUP by s ORDER by s;"
                Using chaCmd As New MySqlCommand(ChaQuery, con)
                    Dim reader As MySqlDataReader = chaCmd.ExecuteReader()
                    While reader.Read
                        Chart1.Series("Series1").Points.AddXY(reader.GetString("s"), reader.GetDecimal("n"))
                    End While
                    reader.Close()
                End Using

            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class