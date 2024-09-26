Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms

Public Class reportAdmin
    Private Sub reportAdmin_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            ' Clear existing data sources
            Dim dt As New DataTable()

            Using cn As New MySqlConnection(My.Settings.conStr)
                cn.Open()

                ' Use parameterized queries to prevent SQL injection
                Dim query As String = "SELECT * FROM `report`;"
                Using com As New MySqlCommand(query, cn)
                    Dim da As New MySqlDataAdapter(com)
                    da.Fill(dt)
                End Using
            End Using

            With Me.ReportViewer1.LocalReport
                .DataSources.Clear()
                .ReportPath = "..\..\Report1.rdlc"
                .DataSources.Add(New ReportDataSource("DataSet1", dt))
            End With

            Me.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
            Me.ReportViewer1.ZoomMode = ZoomMode.Percent
            Me.ReportViewer1.ZoomPercent = 60

            ' Refresh the Report
            Me.ReportViewer1.RefreshReport()

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class