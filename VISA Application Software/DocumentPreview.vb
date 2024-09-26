Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports System.IO

Public Class DocumentPreview
    Public sendId = 0
    Private Sub DocumentPreview_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Using con As New MySqlConnection(My.Settings.conStr)
                con.Open()
                Dim query = "SELECT  concat(`userinfo`.`FName`,' ',`userinfo`.`LName`) as `Name`, `userinfo`.`VISATYPE`, `userinfo`.`Status` FROM `userinfo` JOIN `signup` on `userinfo`.`signupID` = `signup`.`Id` WHERE `User_id` = @id;"
                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@id", sendId)
                    Dim dr = cmd.ExecuteReader
                    While dr.Read
                        lblName.Text = "Name: " & dr("Name").ToString
                        lblVisaType.Text = "Visa Type: " & dr("VISATYPE").ToString
                        lblStatus.Text = "Status: " & dr("Status").ToString
                    End While
                    dr.Close()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCopyPreviousPass_Click(sender As Object, e As EventArgs) Handles btnCopyPreviousPass.Click
        Try
            Using con As New MySqlConnection(My.Settings.conStr)
                con.Open()
                Dim query = "SELECT `Cop_Pre_rep` FROM `userinfo` WHERE `User_id` = @id;"
                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@id", sendId)
                    Using dr = cmd.ExecuteReader()
                        If dr.HasRows Then
                            dr.Read()
                            If Not IsDBNull(dr("Cop_Pre_rep")) Then
                                Dim doc As Byte() = DirectCast(dr("Cop_Pre_rep"), Byte())

                                ' Check if the byte array is valid
                                If doc.Length > 0 Then
                                    Try
                                        ' Save the byte array as a temporary PDF file
                                        Dim tempFilePath As String = Path.Combine(Path.GetTempPath(), "tempfile.pdf")
                                        File.WriteAllBytes(tempFilePath, doc)

                                        ' Load the PDF file into the AxAcroPDF control
                                        AxAcroPDF1.LoadFile(tempFilePath)
                                        AxAcroPDF1.setView("Fit")
                                        AxAcroPDF1.setShowToolbar(False)
                                    Catch ex As Exception
                                        MessageBox.Show("Error loading document: " & ex.Message, "Document Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    End Try
                                Else
                                    MessageBox.Show("The document data is empty or corrupted.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End If
                            Else
                                MessageBox.Show("Copy of Previous Passport details have not been submitted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        Else
                            MessageBox.Show("No records found for the specified User ID.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while retrieving the Copy of Previous Passport details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnIncomeTaxReport_Click(sender As Object, e As EventArgs) Handles btnIncomeTaxReport.Click
        Try
            Using con As New MySqlConnection(My.Settings.conStr)
                con.Open()
                Dim query = "SELECT `Income_tax_Ret` FROM `userinfo` WHERE `User_id` = @id;"
                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@id", sendId)
                    Using dr = cmd.ExecuteReader()
                        If dr.HasRows Then
                            dr.Read()
                            If Not IsDBNull(dr("Income_tax_Ret")) Then
                                Dim doc As Byte() = DirectCast(dr("Income_tax_Ret"), Byte())

                                ' Check if the byte array is valid
                                If doc.Length > 0 Then
                                    Try
                                        ' Save the byte array as a temporary PDF file
                                        Dim tempFilePath As String = Path.Combine(Path.GetTempPath(), "tempfile.pdf")
                                        File.WriteAllBytes(tempFilePath, doc)

                                        ' Load the PDF file into the AxAcroPDF control
                                        AxAcroPDF1.LoadFile(tempFilePath)
                                        AxAcroPDF1.setView("Fit")
                                        AxAcroPDF1.setShowToolbar(False)
                                    Catch ex As Exception
                                        MessageBox.Show("Error loading document: " & ex.Message, "Document Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    End Try
                                Else
                                    MessageBox.Show("The document data is empty or corrupted.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End If
                            Else
                                MessageBox.Show("Income Tax Report details have not been submitted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        Else
                            MessageBox.Show("No records found for the specified User ID.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while retrieving the Income Tax Report details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnProfOfFinRes_Click(sender As Object, e As EventArgs) Handles btnProfOfFinRes.Click
        Try
            Using con As New MySqlConnection(My.Settings.conStr)
                con.Open()
                Dim query = "SELECT `Prof_fin_Res` FROM `userinfo` WHERE `User_id` = @id;"
                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@id", sendId)
                    Using dr = cmd.ExecuteReader()
                        If dr.HasRows Then
                            dr.Read()
                            If Not IsDBNull(dr("Prof_fin_Res")) Then
                                Dim doc As Byte() = DirectCast(dr("Prof_fin_Res"), Byte())

                                ' Check if the byte array is valid
                                If doc.Length > 0 Then
                                    Try
                                        ' Save the byte array as a temporary PDF file
                                        Dim tempFilePath As String = Path.Combine(Path.GetTempPath(), "tempfile.pdf")
                                        File.WriteAllBytes(tempFilePath, doc)

                                        ' Load the PDF file into the AxAcroPDF control
                                        AxAcroPDF1.LoadFile(tempFilePath)
                                        AxAcroPDF1.setView("Fit")
                                        AxAcroPDF1.setShowToolbar(False)
                                    Catch ex As Exception
                                        MessageBox.Show("Error loading document: " & ex.Message, "Document Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    End Try
                                Else
                                    MessageBox.Show("The document data is empty or corrupted.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End If
                            Else
                                MessageBox.Show("Proof Of Financial Resource details have not been submitted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        Else
                            MessageBox.Show("No records found for the specified User ID.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while retrieving the Proof Of Financial Resource details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCharaterRef_Click(sender As Object, e As EventArgs) Handles btnCharaterRef.Click
        Try
            Using con As New MySqlConnection(My.Settings.conStr)
                con.Open()
                Dim query = "SELECT `Char_Ref` FROM `userinfo` WHERE `User_id` = @id;"
                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@id", sendId)
                    Using dr = cmd.ExecuteReader()
                        If dr.HasRows Then
                            dr.Read()
                            If Not IsDBNull(dr("Char_Ref")) Then
                                Dim doc As Byte() = DirectCast(dr("Char_Ref"), Byte())

                                ' Check if the byte array is valid
                                If doc.Length > 0 Then
                                    Try
                                        ' Save the byte array as a temporary PDF file
                                        Dim tempFilePath As String = Path.Combine(Path.GetTempPath(), "tempfile.pdf")
                                        File.WriteAllBytes(tempFilePath, doc)

                                        ' Load the PDF file into the AxAcroPDF control
                                        AxAcroPDF1.LoadFile(tempFilePath)
                                        AxAcroPDF1.setView("Fit")
                                        AxAcroPDF1.setShowToolbar(False)
                                    Catch ex As Exception
                                        MessageBox.Show("Error loading document: " & ex.Message, "Document Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    End Try
                                Else
                                    MessageBox.Show("The document data is empty or corrupted.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End If
                            Else
                                MessageBox.Show("Charater Reference details have not been submitted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        Else
                            MessageBox.Show("No records found for the specified User ID.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while retrieving the Charater Reference details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnPoliceCert_Click(sender As Object, e As EventArgs) Handles btnPoliceCert.Click
        Try
            Using con As New MySqlConnection(My.Settings.conStr)
                con.Open()
                Dim query = "SELECT `Pol_Cert` FROM `userinfo` WHERE `User_id` = @id;"
                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@id", sendId)
                    Using dr = cmd.ExecuteReader()
                        If dr.HasRows Then
                            dr.Read()
                            If Not IsDBNull(dr("Pol_Cert")) Then
                                Dim doc As Byte() = DirectCast(dr("Pol_Cert"), Byte())

                                ' Check if the byte array is valid
                                If doc.Length > 0 Then
                                    Try
                                        ' Save the byte array as a temporary PDF file
                                        Dim tempFilePath As String = Path.Combine(Path.GetTempPath(), "tempfile.pdf")
                                        File.WriteAllBytes(tempFilePath, doc)

                                        ' Load the PDF file into the AxAcroPDF control
                                        AxAcroPDF1.LoadFile(tempFilePath)
                                        AxAcroPDF1.setView("Fit")
                                        AxAcroPDF1.setShowToolbar(False)
                                    Catch ex As Exception
                                        MessageBox.Show("Error loading document: " & ex.Message, "Document Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    End Try
                                Else
                                    MessageBox.Show("The document data is empty or corrupted.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End If
                            Else
                                MessageBox.Show("Police Certificate details have not been submitted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        Else
                            MessageBox.Show("No records found for the specified User ID.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while retrieving the Police Certificate details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnMedicalCert_Click(sender As Object, e As EventArgs) Handles btnMedicalCert.Click
        Try
            Using con As New MySqlConnection(My.Settings.conStr)
                con.Open()
                Dim query = "SELECT `Med_cert` FROM `userinfo` WHERE `User_id` = @id;"
                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@id", sendId)
                    Using dr = cmd.ExecuteReader()
                        If dr.HasRows Then
                            dr.Read()
                            If Not IsDBNull(dr("Med_cert")) Then
                                Dim doc As Byte() = DirectCast(dr("Med_cert"), Byte())

                                ' Check if the byte array is valid
                                If doc.Length > 0 Then
                                    Try
                                        ' Save the byte array as a temporary PDF file
                                        Dim tempFilePath As String = Path.Combine(Path.GetTempPath(), "tempfile.pdf")
                                        File.WriteAllBytes(tempFilePath, doc)

                                        ' Load the PDF file into the AxAcroPDF control
                                        AxAcroPDF1.LoadFile(tempFilePath)
                                        AxAcroPDF1.setView("Fit")
                                        AxAcroPDF1.setShowToolbar(False)
                                    Catch ex As Exception
                                        MessageBox.Show("Error loading document: " & ex.Message, "Document Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    End Try
                                Else
                                    MessageBox.Show("The document data is empty or corrupted.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End If
                            Else
                                MessageBox.Show("Medical Certificate details have not been submitted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        Else
                            MessageBox.Show("No records found for the specified User ID.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while retrieving the Medical Certificate details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCopOfPreVisas_Click(sender As Object, e As EventArgs) Handles btnCopOfPreVisas.Click
        Try
            Using con As New MySqlConnection(My.Settings.conStr)
                con.Open()
                Dim query = "SELECT `cop_Pre_Visa` FROM `userinfo` WHERE `User_id` = @id;"
                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@id", sendId)
                    Using dr = cmd.ExecuteReader()
                        If dr.HasRows Then
                            dr.Read()
                            If Not IsDBNull(dr("cop_Pre_Visa")) Then
                                Dim doc As Byte() = DirectCast(dr("cop_Pre_Visa"), Byte())

                                ' Check if the byte array is valid
                                If doc.Length > 0 Then
                                    Try
                                        ' Save the byte array as a temporary PDF file
                                        Dim tempFilePath As String = Path.Combine(Path.GetTempPath(), "tempfile.pdf")
                                        File.WriteAllBytes(tempFilePath, doc)

                                        ' Load the PDF file into the AxAcroPDF control
                                        AxAcroPDF1.LoadFile(tempFilePath)
                                        AxAcroPDF1.setView("Fit")
                                        AxAcroPDF1.setShowToolbar(False)
                                    Catch ex As Exception
                                        MessageBox.Show("Error loading document: " & ex.Message, "Document Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    End Try
                                Else
                                    MessageBox.Show("The document data is empty or corrupted.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End If
                            Else
                                MessageBox.Show("Copy Of Previous Visa details have not been submitted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        Else
                            MessageBox.Show("No records found for the specified User ID.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while retrieving the Copy Of Previous Visa details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBankAccDet_Click(sender As Object, e As EventArgs) Handles btnBankAccDet.Click
        Try
            Using con As New MySqlConnection(My.Settings.conStr)
                con.Open()
                Dim query = "SELECT `Bank_Acc_Det` FROM `userinfo` WHERE `User_id` = @id;"
                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@id", sendId)
                    Using dr = cmd.ExecuteReader()
                        If dr.HasRows Then
                            dr.Read()
                            If Not IsDBNull(dr("Bank_Acc_Det")) Then
                                Dim doc As Byte() = DirectCast(dr("Bank_Acc_Det"), Byte())

                                ' Check if the byte array is valid
                                If doc.Length > 0 Then
                                    Try
                                        ' Save the byte array as a temporary PDF file
                                        Dim tempFilePath As String = Path.Combine(Path.GetTempPath(), "tempfile.pdf")
                                        File.WriteAllBytes(tempFilePath, doc)

                                        ' Load the PDF file into the AxAcroPDF control
                                        AxAcroPDF1.LoadFile(tempFilePath)
                                        AxAcroPDF1.setView("Fit")
                                        AxAcroPDF1.setShowToolbar(False)
                                    Catch ex As Exception
                                        MessageBox.Show("Error loading document: " & ex.Message, "Document Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    End Try
                                Else
                                    MessageBox.Show("The document data is empty or corrupted.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End If
                            Else
                                MessageBox.Show("Bank Account details have not been submitted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        Else
                            MessageBox.Show("No records found for the specified User ID.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while retrieving the Bank Account details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

End Class