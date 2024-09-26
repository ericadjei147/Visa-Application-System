Imports System.Text.RegularExpressions
Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient
Imports System.IO


Public Class MainForm1
    Private currentPanelIndex As Integer = 0
    Private panelList As List(Of Panel)
    Private headingList As List(Of String)
    Private VisaList As List(Of String)
    Public userID As Integer = 0

    Private Sub MainForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panelList = New List(Of Panel) From {
           pnlPersonalInfo,
           pnlContactaInfo,
           pnlTravelInfo,
           pnlPassportDetails,
           pnlBiographicalInfo,
           pnlEducationAndOccupation,
           pnlFinancialInfo,
           pnlHealthAndCharacter
       }
        btnSubmit.Visible = False

        ' Initialize the list of headings
        headingList = New List(Of String) From {
            "Personal Information",
            "Contact Information",
            "Travel Information",
            "Passport Detail",
            "Biographical Information",
            "Educational and Occupational Information",
            "Financial Information",
            "Health and Character Information"
        }

        VisaList = New List(Of String) From {
            "",
            "Tourist Visa",
            "Student Visa",
            "Medical Visa",
            "Diplomatic Visa",
            "Entertainer Visa",
            "Business Visa"
        }

        ' Set the initial state
        UpdatePanelVisibility()
        btnPrevious.Visible = False
    End Sub
    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentPanelIndex < panelList.Count - 1 Then
            If currentPanelIndex = 0 Then
                If ValidateForm1() Then
                    currentPanelIndex += 1
                    UpdatePanelVisibility()
                End If
            ElseIf currentPanelIndex = 1 Then
                If ValidateForm2() Then
                    currentPanelIndex += 1
                    UpdatePanelVisibility()
                End If
            ElseIf currentPanelIndex = 2 Then
                If ValidateForm3() Then
                    currentPanelIndex += 1
                    UpdatePanelVisibility()
                End If
            ElseIf currentPanelIndex = 3 Then
                If ValidateForm4() Then
                    currentPanelIndex += 1
                    UpdatePanelVisibility()
                End If
            ElseIf currentPanelIndex = 4 Then
                If ValidateForm5() Then
                    currentPanelIndex += 1
                    UpdatePanelVisibility()
                End If
            ElseIf currentPanelIndex = 5 Then
                If ValidateForm6() Then
                    currentPanelIndex += 1
                    UpdatePanelVisibility()
                End If
            ElseIf currentPanelIndex = 6 Then
                If ValidateForm7() Then
                    currentPanelIndex += 1
                    UpdatePanelVisibility()
                End If
            ElseIf currentPanelIndex = 7 Then
                If ValidateForm8() Then
                    currentPanelIndex += 1
                    UpdatePanelVisibility()
                End If
            End If
        End If
    End Sub

    Private Sub BtnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentPanelIndex > 0 Then
            currentPanelIndex -= 1
            UpdatePanelVisibility()
        End If
    End Sub

    Private Sub UpdatePanelVisibility()
        ' Hide all panels first
        For Each panel As Panel In panelList
            panel.Visible = False
        Next

        ' Show the current panel
        panelList(currentPanelIndex).Visible = True
        panelList(currentPanelIndex).Top = 0

        ' Update the heading label
        LblDisplay.Text = headingList(currentPanelIndex)

        ' Update button visibility and text
        If currentPanelIndex = 0 Then
            btnPrevious.Visible = False
        Else
            btnPrevious.Visible = True
        End If

        If currentPanelIndex = 7 Then
            btnNext.Visible = False
        Else
            btnNext.Visible = True
        End If

        If currentPanelIndex = 7 Then
            btnSubmit.Visible = True
        Else
            btnSubmit.Visible = False
        End If

        If currentPanelIndex = panelList.Count - 1 Then
            btnSubmit.Text = "Submit"
        Else
            btnNext.Text = "Next"
        End If
    End Sub

    Private Sub pnlPersonalInfo_Paint(sender As Object, e As PaintEventArgs) Handles pnlPersonalInfo.Paint

    End Sub
    Public Function ValidateForm1() As Boolean
        If String.IsNullOrEmpty(txtFirstName.Text) Or txtFirstName.Text.Trim.Length < 3 Then
            MessageBox.Show("First Name is required.")
            Return False

        End If

        If String.IsNullOrEmpty(txtLastName.Text) Or txtLastName.Text.Trim.Length < 3 Then
            MessageBox.Show("Last Name is required.")
            Return False

        End If

        Dim today As DateTime = DateTime.Now
        Dim minDateOfBirth As DateTime = today.AddYears(-18)
        If dtpDOB.Value > minDateOfBirth Then
            MessageBox.Show("You must be at least 18 years old.")
            Return False
        End If

        If cmbGender.SelectedIndex = -1 Then
            MessageBox.Show("Please select a gender.")
            Return False
        End If

        If cmbNationality.SelectedIndex = -1 Then
            MessageBox.Show("Please select a nationality.")
            Return False
        End If
        Return True
    End Function
    Public Function ValidateForm2() As Boolean
        Dim isValid As Boolean = True
        Dim errorMessage As String = ""

        If Not IsValidPhoneNumber(txtPhoneNumber.Text) Then
            isValid = False
            errorMessage &= "Invalid phone number." & vbCrLf
        End If
        If String.IsNullOrWhiteSpace(txtAddress.Text) Then
            isValid = False
            errorMessage &= "Address is required." & vbCrLf
        End If
        If Not IsValidEmail(txtEmailAddress.Text) Then
            isValid = False
            errorMessage &= "Invalid email address." & vbCrLf
        End If
        ' Show error message if validation fails
        If Not isValid Then
            MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Return isValid
    End Function
    Private Sub txtPhoneNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhoneNumber.KeyPress
        If Asc(e.KeyChar) <> 8 AndAlso Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
        End If
    End Sub
    Public Function ValidateForm3() As Boolean
        Dim isValid As Boolean = True
        Dim errorMessage As String = ""

        ' Validate Purpose of Travel
        If String.IsNullOrWhiteSpace(txtPurposeOfTravel.Text) And txtPurposeOfTravel.Text.Trim.Length > 15 Then
            isValid = False
            errorMessage &= "Purpose of travel is required." & vbNewLine & "Must be 15 or more character long" & vbCrLf
        End If

        ' Validate Destination Country
        If cmbDestinationCountry.SelectedIndex = -1 Then
            isValid = False
            errorMessage &= "Destination country is required." & vbCrLf
        End If

        ' Validate Entry and Exit Dates
        If dtpEntryDate.Value >= dtpExitDate.Value Then
            isValid = False
            errorMessage &= "Entry date must be before exit date." & vbCrLf
        End If

        ' Validate Flight Itinerary
        If String.IsNullOrWhiteSpace(txtFlightItinerary.Text) Then
            isValid = False
            errorMessage &= "Flight itinerary is required." & vbCrLf
        End If

        If txtFlightItinerary.Text.Trim.Length < 4 Then
            isValid = False
            errorMessage &= "Flight itinerary should be more than 3 letters." & vbCrLf
        End If
        ' Show error message if validation fails
        If Not isValid Then
            MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Return isValid
    End Function

    Public Function ValidateForm4() As Boolean
        Dim isValid As Boolean = True
        Dim errorMessage As String = ""

        ' Validate Passport Type
        If cmbPassportType.SelectedIndex = -1 Then
            isValid = False
            errorMessage &= "Passport type is required." & vbCrLf

        End If
        If String.IsNullOrEmpty(txtPassportNumber.Text) Then
            MessageBox.Show("Passport Number is required.")
            Return False
        End If

        If txtPassportNumber.Text.Trim.Length < 8 And txtPassportNumber.Text.Trim.Length > 10 Then
            MessageBox.Show("Passport Number must be 8 to 10 character long.")
            Return False
        End If
        ' Validate Passport Issuance Date
        If dtpPassportIssuanceDate.Value >= dtpPassportExpirationDate.Value Then
            isValid = False
            errorMessage &= "Passport issuance date must be before expiration date." & vbCrLf

        End If
        ' Show error message if validation fails
        If Not isValid Then
            MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Return isValid
    End Function

    Public Function ValidateForm5() As Boolean
        Dim isValid As Boolean = True
        Dim errorMessage As String = ""


        ' Validate Father's Name
        If String.IsNullOrWhiteSpace(txtFatherName.Text) Or txtFatherName.Text.Trim.Length < 3 Then
            isValid = False
            errorMessage &= "Father's name is required." & vbCrLf

        End If

        ' Validate Mother's Name
        If String.IsNullOrWhiteSpace(txtMotherName.Text) Or txtMotherName.Text.Trim.Length < 3 Then
            isValid = False
            errorMessage &= "Mother's name is required." & vbCrLf
        End If

        If String.IsNullOrWhiteSpace(txtChildrenName.Text) Or txtMotherName.Text.Trim.Length < 3 Then
            isValid = False
            errorMessage &= "Children's name is required." & vbCrLf
        End If

        If String.IsNullOrWhiteSpace(txtSpouseName.Text) Or txtMotherName.Text.Trim.Length < 3 Then
            isValid = False
            errorMessage &= "Spouse's name is required." & vbCrLf
        End If
        ' Show error message if validation fails
        If Not isValid Then
            MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Return isValid
    End Function

    Private Sub txtMotherName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMotherName.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> vbBack AndAlso e.KeyChar <> " "c Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtFatherName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFatherName.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> vbBack AndAlso e.KeyChar <> " "c Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtChildrenName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtChildrenName.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> vbBack AndAlso e.KeyChar <> " "c Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSpouseName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSpouseName.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> vbBack AndAlso e.KeyChar <> " "c Then
            e.Handled = True
        End If
    End Sub

    Public Function ValidateForm6() As Boolean
        Dim isValid As Boolean = True
        Dim errorMessage As String = ""

        ' Show error message if validation fails

        ' Validate Employer's Name
        If String.IsNullOrWhiteSpace(txtEmployerName.Text) Or txtEmployerName.Text.Trim.Length < 3 Then
            isValid = False
            errorMessage &= "Employer's name is required." & vbCrLf
        End If

        ' Validate Employer's Address
        If String.IsNullOrWhiteSpace(txtEmployerAddress.Text) Or txtEmployerAddress.Text.Trim.Length < 2 Then
            isValid = False
            errorMessage &= "Employer's address is required." & vbCrLf
        End If

        ' Validate Educational Background
        If String.IsNullOrWhiteSpace(txtEducationalBackground.Text) Or txtEducationalBackground.Text.Trim.Length < 10 Then
            isValid = False
            errorMessage &= "Educational background is required." & vbCrLf
        End If


        If cmbCurrentOccupation.SelectedIndex = -1 Then
            MessageBox.Show("Please select a current Occupations.")
            Return False
        End If

        ' Show error message if validation fails
        If Not isValid Then
            MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Return isValid
    End Function

    Public Function ValidateForm7() As Boolean
        Dim isValid As Boolean = True
        Dim errorMessage As String = ""

        If String.IsNullOrWhiteSpace(txtBankAccountDetails.Text) Then
            isValid = False
            errorMessage &= "Bank account details are required." & vbCrLf
        End If

        If Not isValid Then
            MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Return isValid
    End Function

    Private Sub btnUploadBankAccountDetails_Click(sender As Object, e As EventArgs) Handles btnUploadBankAccountDetails.Click
        UploadFile(ofdBankAccountDetails, txtBankAccountDetails)
    End Sub
    Private Sub btnUploadIncomeTaxReturns_Click(sender As Object, e As EventArgs) Handles btnUploadIncomeTaxReturns.Click
        UploadFile(ofdIncomeTaxReturns, txtIncomeTaxReturns)
    End Sub
    Private Sub btnUploadProofOfFinancialResources_Click(sender As Object, e As EventArgs) Handles btnUploadProofOfFinancialResources.Click
        UploadFile(ofdProofOfFinancialResources, txtProofOfFinancialResources)
    End Sub
    Private Sub UploadFile(ofd As OpenFileDialog, textBox As Guna2TextBox)
        ofd.Filter = "PDF files (*.pdf)|*.pdf"
        If ofd.ShowDialog() = DialogResult.OK Then
            textBox.Text = ofd.FileName
        End If
    End Sub
    Public Function ValidateForm8() As Boolean
        Dim isValid As Boolean = True
        Dim errorMessage As String = ""

        If Not isValid Then
            MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


        If Not isValid Then
            MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Return isValid
    End Function


    Private Sub btnUploadMedicalCertificate_Click(sender As Object, e As EventArgs) Handles btnUploadMedicalCertificate.Click
        UploadFile(ofdMedicalCertificate, txtMedicalCertificate)
    End Sub

    Private Sub btnUploadPoliceCertificate_Click(sender As Object, e As EventArgs) Handles btnUploadPoliceCertificate.Click
        UploadFile(ofdPoliceCertificate, txtPoliceCertificate)
    End Sub

    Private Sub btnUploadCharacterReferences_Click(sender As Object, e As EventArgs) Handles btnUploadCharacterReferences.Click
        UploadFile(ofdCharacterReferences, txtCharacterReferences)
    End Sub

    Private Sub btnUploadPreviousVisas_Click(sender As Object, e As EventArgs) Handles btnUploadPreviousVisas.Click
        UploadFile(ofdPreviousVisas, txtPreviousVisa)
    End Sub

    Private Sub btnUploadPreviousPassports_Click(sender As Object, e As EventArgs) Handles btnUploadPreviousPassports.Click
        UploadFile(ofdPreviousPassports, txtPreviousPassports)
    End Sub
    Private Sub txtEmployerName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmployerName.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> vbBack AndAlso e.KeyChar <> " "c Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtFlightItinerary_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFlightItinerary.KeyPress
        Dim txtFlightItinerary As Guna2TextBox = CType(sender, Guna2TextBox)

        If Char.IsControl(e.KeyChar) Or e.KeyChar = " "c Then
            Return
        End If

        If Not Char.IsLetter(e.KeyChar) Then
            'If txtPurposeOfTravel.Text.Length < 9 Then
            e.Handled = True
            ' End If
        End If
        If txtFlightItinerary.Text.Length >= 50 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("You must enter at most 50 characters.")
        End If
    End Sub


    Private Sub txtPurposeOfTravel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPurposeOfTravel.KeyPress
        Dim txtPurposeOfTravel As Guna2TextBox = CType(sender, Guna2TextBox)

        If Char.IsControl(e.KeyChar) Or e.KeyChar = " "c Then
            Return
        End If

        If Not Char.IsLetter(e.KeyChar) Then
            'If txtPurposeOfTravel.Text.Length < 9 Then
            e.Handled = True
            ' End If
        End If
        If txtPurposeOfTravel.Text.Length >= 50 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("You must enter at most 50 characters.")
        End If
    End Sub

    Private Function IsValidPhoneNumber(phone As String) As Boolean
        ' Simple regex for phone number validation (international format included)
        Dim phonePattern As String = "^\+?\d{1,14}$"
        Return Regex.IsMatch(phone, phonePattern)
    End Function
    Private Function IsValidEmail(email As String) As Boolean
        ' Simple regex for email validation
        Dim emailPattern As String = "^[^@\s]+@[^@\s]+\.[^@\s]+$"
        Return Regex.IsMatch(email, emailPattern)
    End Function
    Private Sub txtLastName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLastName.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> vbBack AndAlso e.KeyChar <> " "c Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtFirstName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFirstName.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> vbBack AndAlso e.KeyChar <> " "c Then
            e.Handled = True
        End If
    End Sub
    Public diaPic As New OpenFileDialog
    Private Sub btnUploadPassportPhoto_Click(sender As Object, e As EventArgs) Handles btnUploadPassportPhoto.Click
        diaPic.Filter = "jpg, jpeg, png files (*.png,*.jpg,*.jpeg)|*.png;*.jpg;*.jpeg"
        If diaPic.ShowDialog() = DialogResult.OK Then
            picPassportPhoto.Image = Image.FromFile(diaPic.FileName)
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If ValidateForm8() Then
            Try
                Using checkCon As New MySqlConnection(My.Settings.conStr)
                    checkCon.Open()
                    Dim query = "SELECT `FName`, `LName` FROM `signup` WHERE id = @ID and `FName` =@FName and `LName`=@LName;"
                    Using checkcmd As New MySqlCommand(query, checkCon)
                        checkcmd.Parameters.AddWithValue("@ID", Login1.id)
                        checkcmd.Parameters.AddWithValue("@FName", txtFirstName.Text)
                        checkcmd.Parameters.AddWithValue("@LName", txtLastName.Text)
                        Dim dr = checkcmd.ExecuteReader
                        Dim count = 0
                        While dr.Read
                            count += 1
                        End While
                        If count = 0 Then
                            MessageBox.Show("Please first name and last do not match your profile.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Exit Sub
                        End If
                        dr.Close()
                    End Using

                End Using


                    Dim bankAccountDetail, incomeTaxReturn, ProofOfFinance, MedicalCert, PoliceCert, CharacterReference, CopyOfPreviousVisa, CopyOfPreviousPassport, ProfilePic As Byte()
                    ProfilePic = File.ReadAllBytes(diaPic.FileName)
                    bankAccountDetail = File.ReadAllBytes(txtBankAccountDetails.Text)
                    ProofOfFinance = File.ReadAllBytes(txtProofOfFinancialResources.Text)
                    MedicalCert = File.ReadAllBytes(txtMedicalCertificate.Text)

                Using con As New MySqlConnection(My.Settings.conStr)
                    con.Open()
                    Dim query = "INSERT INTO `userinfo`(`signupID`, `FName`, `LName`, `DOB`, `Gender`, `Nationality`, `Address`, `PNumber`, `EmailAddress`, `POfTravel`, `Des_Country`, `EntryDate`, `ExitDate`, `TravelPlan`, `PassType`, `Pass_Iss_Date`, `Pass_Expir_Date`, `PassNumber`, `FatherName`, `MotherName`, `ChildrenName`, `spouseName`, `Edu_BG`, `Current_Occu`, `EmployersName`, `EmployersAddress`, `VISATYPE`, `Bank_Acc_Det`, `Income_tax_Ret`, `Prof_fin_Res`, `Med_cert`, `Pol_Cert`, `Char_Ref`, `cop_Pre_Visa`, `Cop_Pre_rep`, `Pro_Pic`) VALUES 
(@signupID,@FName,@LName,@DOB,@Gender,@Nationality,@Address,@PNumber,@EmailAddress,@POfTravel,@Des_Country,@EntryDate,
@ExitDate,@TravelPlan,@PassType,@Pass_Iss_Date,@Pass_Expir_Date,@PassNumber,@FatherName,@MotherName,@ChildrenName,@spouseName,
@Edu_BG,@Current_Occu,@EmployersName,@EmployersAddress,@VISATYPE,@Bank_Acc_Det,@Income_tax_Ret,@Prof_fin_Res,
@Med_cert,@Pol_Cert,@Char_Ref,@cop_Pre_Visa,@Cop_Pre_rep,@Pro_Pic)"
                    Using cmd As New MySqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@signupID", Login1.id)
                        cmd.Parameters.AddWithValue("@FName", txtFirstName.Text)
                        cmd.Parameters.AddWithValue("@LName", txtLastName.Text)
                        cmd.Parameters.AddWithValue("@DOB", dtpDOB.Value)
                        cmd.Parameters.AddWithValue("@Gender", cmbGender.Text)
                        cmd.Parameters.AddWithValue("@Nationality", cmbNationality.Text)
                        cmd.Parameters.AddWithValue("@Address", txtAddress.Text)
                        cmd.Parameters.AddWithValue("@PNumber", txtPhoneNumber.Text)
                        cmd.Parameters.AddWithValue("@EmailAddress", txtEmailAddress.Text)
                        cmd.Parameters.AddWithValue("@POfTravel", txtPurposeOfTravel.Text)
                        cmd.Parameters.AddWithValue("@Des_Country", cmbDestinationCountry.Text)
                        cmd.Parameters.AddWithValue("@EntryDate", dtpEntryDate.Value)
                        cmd.Parameters.AddWithValue("@ExitDate", dtpExitDate.Value)
                        cmd.Parameters.AddWithValue("@TravelPlan", txtFlightItinerary.Text)
                        cmd.Parameters.AddWithValue("@PassType", cmbPassportType.Text)
                        cmd.Parameters.AddWithValue("@Pass_Iss_Date", dtpPassportIssuanceDate.Value)
                        cmd.Parameters.AddWithValue("@Pass_Expir_Date", dtpPassportExpirationDate.Value)
                        cmd.Parameters.AddWithValue("@PassNumber", txtPassportNumber.Text)
                        cmd.Parameters.AddWithValue("@FatherName", txtFatherName.Text)
                        cmd.Parameters.AddWithValue("@MotherName", txtMotherName.Text)
                        cmd.Parameters.AddWithValue("@spouseName", txtSpouseName.Text)
                        cmd.Parameters.AddWithValue("@ChildrenName", txtChildrenName.Text)
                        cmd.Parameters.AddWithValue("@Edu_BG", txtEducationalBackground.Text)
                        cmd.Parameters.AddWithValue("@Current_Occu", cmbCurrentOccupation.Text)
                        cmd.Parameters.AddWithValue("@EmployersName", txtEmployerName.Text)
                        cmd.Parameters.AddWithValue("@EmployersAddress", txtEmployerAddress.Text)
                        cmd.Parameters.AddWithValue("@VISATYPE", VisaList(ApplyNow.VisaType))
                        cmd.Parameters.AddWithValue("@Med_cert", MedicalCert)
                        cmd.Parameters.AddWithValue("@Prof_fin_Res", ProofOfFinance)
                        cmd.Parameters.AddWithValue("@Bank_Acc_Det", bankAccountDetail)
                        cmd.Parameters.AddWithValue("@Pro_Pic", ProfilePic)

                        If txtIncomeTaxReturns.Text.Trim.Length > 0 Then
                            incomeTaxReturn = File.ReadAllBytes(txtIncomeTaxReturns.Text)
                            cmd.Parameters.AddWithValue("@Income_tax_Ret", incomeTaxReturn)
                        Else
                            cmd.Parameters.AddWithValue("@Income_tax_Ret", DBNull.Value)
                        End If

                        If txtPoliceCertificate.Text.Trim.Length > 0 Then
                            PoliceCert = File.ReadAllBytes(txtPoliceCertificate.Text)
                            cmd.Parameters.AddWithValue("@Pol_Cert", PoliceCert)
                        Else
                            cmd.Parameters.AddWithValue("@Pol_Cert", DBNull.Value)
                        End If

                        If txtCharacterReferences.Text.Trim.Length > 0 Then
                            CharacterReference = File.ReadAllBytes(txtCharacterReferences.Text)
                            cmd.Parameters.AddWithValue("@Char_Ref", CharacterReference)
                        Else
                            cmd.Parameters.AddWithValue("@Char_Ref", DBNull.Value)
                        End If

                        If txtPreviousVisa.Text.Trim.Length > 0 Then
                            CopyOfPreviousVisa = File.ReadAllBytes(txtPreviousVisa.Text)
                            cmd.Parameters.AddWithValue("@cop_Pre_Visa", CopyOfPreviousVisa)
                        Else
                            cmd.Parameters.AddWithValue("@cop_Pre_Visa", DBNull.Value)
                        End If

                        If txtPreviousPassports.Text.Trim.Length > 0 Then
                            CopyOfPreviousPassport = File.ReadAllBytes(txtPreviousPassports.Text)
                            cmd.Parameters.AddWithValue("@Cop_Pre_rep", CopyOfPreviousPassport)
                        Else
                            cmd.Parameters.AddWithValue("@Cop_Pre_rep", DBNull.Value)
                        End If
                        cmd.ExecuteNonQuery()
                    End Using

                    Dim IDquery = "SELECT LAST_INSERT_ID()"
                    Using IDcmd As New MySqlCommand(IDquery, con)
                        userID = Convert.ToInt32(IDcmd.ExecuteScalar())
                    End Using
                    AppointmentDate.ShowDialog()
                    clear()
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub clear
  txtFirstName.clear
        txtLastName.Clear
        dtpDOB.Value = now
        cmbGender.SelectedIndex =-1
        cmbNationality.SelectedIndex =-1
        txtAddress.Clear
        txtPhoneNumber.Clear
        txtEmailAddress.Clear
        txtPurposeOfTravel.Clear
        cmbDestinationCountry.SelectedIndex =-1
        dtpEntryDate.Value = now
        dtpExitDate.Value = now
        txtFlightItinerary.Clear
        cmbPassportType.SelectedIndex =-1
        dtpPassportIssuanceDate.Value = Now
        dtpPassportExpirationDate.Value = now
        txtPassportNumber.Clear
        txtFatherName.Clear
        txtMotherName.Clear
        txtSpouseName.Clear
        txtChildrenName.Clear
        txtEducationalBackground.Clear
        cmbCurrentOccupation.SelectedIndex =-1
        txtEmployerName.Clear
        txtEmployerAddress.Clear()
        txtIncomeTaxReturns.Clear()
        txtPoliceCertificate.Clear()
        txtCharacterReferences.Clear()
        txtPreviousVisa.Clear()
        txtPreviousPassports.Clear()
        txtBankAccountDetails.Clear()
        txtProofOfFinancialResources.Clear()
        txtMedicalCertificate.Clear()
        picPassportPhoto.Image = My.Resources.profile
    End Sub





End Class