<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnNavigation = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlPersonalInformation = New System.Windows.Forms.Panel()
        Me.lblEmailAddress = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.rtbHomeAddress = New System.Windows.Forms.RichTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblRegion = New System.Windows.Forms.Label()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlNationalInformation = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.pBoxProfilePicture = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.pnlPersonalInformation.SuspendLayout()
        Me.pnlNationalInformation.SuspendLayout()
        CType(Me.pBoxProfilePicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.Controls.Add(Me.btnSubmit)
        Me.Panel1.Controls.Add(Me.btnNavigation)
        Me.Panel1.Controls.Add(Me.btnBrowse)
        Me.Panel1.Controls.Add(Me.pBoxProfilePicture)
        Me.Panel1.Controls.Add(Me.lblHeading)
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel1.Location = New System.Drawing.Point(-36, -100)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(895, 797)
        Me.Panel1.TabIndex = 0
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnSubmit.ForeColor = System.Drawing.SystemColors.Control
        Me.btnSubmit.Location = New System.Drawing.Point(449, 488)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(56, 32)
        Me.btnSubmit.TabIndex = 32
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'btnNavigation
        '
        Me.btnNavigation.BackColor = System.Drawing.Color.Transparent
        Me.btnNavigation.Location = New System.Drawing.Point(283, 488)
        Me.btnNavigation.Name = "btnNavigation"
        Me.btnNavigation.Size = New System.Drawing.Size(150, 32)
        Me.btnNavigation.TabIndex = 31
        Me.btnNavigation.Text = "Next"
        Me.btnNavigation.UseVisualStyleBackColor = False
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.btnBrowse.Location = New System.Drawing.Point(691, 147)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 29
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(59, 147)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(229, 25)
        Me.lblHeading.TabIndex = 8
        Me.lblHeading.Text = "Personal Information"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.Controls.Add(Me.pnlPersonalInformation)
        Me.FlowLayoutPanel1.Controls.Add(Me.pnlNationalInformation)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(18, 204)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(706, 276)
        Me.FlowLayoutPanel1.TabIndex = 9
        '
        'pnlPersonalInformation
        '
        Me.pnlPersonalInformation.AutoScroll = True
        Me.pnlPersonalInformation.Controls.Add(Me.lblEmailAddress)
        Me.pnlPersonalInformation.Controls.Add(Me.ComboBox3)
        Me.pnlPersonalInformation.Controls.Add(Me.ComboBox2)
        Me.pnlPersonalInformation.Controls.Add(Me.rtbHomeAddress)
        Me.pnlPersonalInformation.Controls.Add(Me.Label12)
        Me.pnlPersonalInformation.Controls.Add(Me.ComboBox1)
        Me.pnlPersonalInformation.Controls.Add(Me.DateTimePicker1)
        Me.pnlPersonalInformation.Controls.Add(Me.TextBox8)
        Me.pnlPersonalInformation.Controls.Add(Me.TextBox7)
        Me.pnlPersonalInformation.Controls.Add(Me.TextBox6)
        Me.pnlPersonalInformation.Controls.Add(Me.TextBox5)
        Me.pnlPersonalInformation.Controls.Add(Me.lblCity)
        Me.pnlPersonalInformation.Controls.Add(Me.lblRegion)
        Me.pnlPersonalInformation.Controls.Add(Me.lblPhoneNumber)
        Me.pnlPersonalInformation.Controls.Add(Me.Label8)
        Me.pnlPersonalInformation.Controls.Add(Me.Label7)
        Me.pnlPersonalInformation.Controls.Add(Me.Label6)
        Me.pnlPersonalInformation.Controls.Add(Me.Label5)
        Me.pnlPersonalInformation.Controls.Add(Me.TextBox3)
        Me.pnlPersonalInformation.Controls.Add(Me.TextBox2)
        Me.pnlPersonalInformation.Controls.Add(Me.TextBox1)
        Me.pnlPersonalInformation.Controls.Add(Me.Label4)
        Me.pnlPersonalInformation.Controls.Add(Me.Label3)
        Me.pnlPersonalInformation.Controls.Add(Me.Label2)
        Me.pnlPersonalInformation.Location = New System.Drawing.Point(3, 3)
        Me.pnlPersonalInformation.Name = "pnlPersonalInformation"
        Me.pnlPersonalInformation.Size = New System.Drawing.Size(748, 704)
        Me.pnlPersonalInformation.TabIndex = 7
        '
        'lblEmailAddress
        '
        Me.lblEmailAddress.AutoSize = True
        Me.lblEmailAddress.Location = New System.Drawing.Point(21, 545)
        Me.lblEmailAddress.Name = "lblEmailAddress"
        Me.lblEmailAddress.Size = New System.Drawing.Size(78, 13)
        Me.lblEmailAddress.TabIndex = 26
        Me.lblEmailAddress.Text = "Email Addresss"
        '
        'ComboBox3
        '
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"Ahafo Region", "Ashanti Region", "Bono Region", "Bono East Region", "Central Region", "Eastern Region", "Greater Accra Region", "North East Region", "Northern Region", "Oti Region", "Savannah Region", "Upper East Region", "Upper West Region", "Volta Region", "Western Region", "Western North Region"})
        Me.ComboBox3.Location = New System.Drawing.Point(419, 306)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox3.TabIndex = 25
        '
        'ComboBox2
        '
        Me.ComboBox2.AllowDrop = True
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"GHANAIAN", "INDIAN ", "CHINESE", "JAPANESE", "BRAZILIAN", "GERMAN", "FRENCH", "ITALIAN", "SPANISH", "NIGERIAN ", "SOUTH AFRICAN", "MEXICAN", "RUSSIAN", "EGYPTIAN", "DUTCH", "SWEDISH"})
        Me.ComboBox2.Location = New System.Drawing.Point(161, 192)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(140, 21)
        Me.ComboBox2.TabIndex = 24
        '
        'rtbHomeAddress
        '
        Me.rtbHomeAddress.Location = New System.Drawing.Point(167, 306)
        Me.rtbHomeAddress.Name = "rtbHomeAddress"
        Me.rtbHomeAddress.Size = New System.Drawing.Size(100, 96)
        Me.rtbHomeAddress.TabIndex = 23
        Me.rtbHomeAddress.Text = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(346, 154)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(42, 13)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Gender"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"MALE ", "FEMALE "})
        Me.ComboBox1.Location = New System.Drawing.Point(419, 146)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 21
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(161, 147)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(140, 20)
        Me.DateTimePicker1.TabIndex = 20
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(167, 249)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(373, 20)
        Me.TextBox8.TabIndex = 17
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(161, 538)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(379, 20)
        Me.TextBox7.TabIndex = 16
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(161, 456)
        Me.TextBox6.MaxLength = 10
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(140, 20)
        Me.TextBox6.TabIndex = 15
        '
        'TextBox5
        '
        Me.TextBox5.AllowDrop = True
        Me.TextBox5.AutoCompleteCustomSource.AddRange(New String() {"Goaso", "Kumasi", "Sunyani", "Techiman", "Cape Coast", "Koforidua", "Accra", "Nalerigu", "Tamale", "Dambai", "Damongo", "Bolgatanga", "Wa", "Ho", "Secondi-Takoradi", "Sefwi-Wiawso"})
        Me.TextBox5.Location = New System.Drawing.Point(419, 382)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(121, 20)
        Me.TextBox5.TabIndex = 14
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(346, 389)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(24, 13)
        Me.lblCity.TabIndex = 12
        Me.lblCity.Text = "City"
        '
        'lblRegion
        '
        Me.lblRegion.AutoSize = True
        Me.lblRegion.Location = New System.Drawing.Point(346, 306)
        Me.lblRegion.Name = "lblRegion"
        Me.lblRegion.Size = New System.Drawing.Size(41, 13)
        Me.lblRegion.TabIndex = 11
        Me.lblRegion.Text = "Region"
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Location = New System.Drawing.Point(18, 463)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(78, 13)
        Me.lblPhoneNumber.TabIndex = 10
        Me.lblPhoneNumber.Text = "Phone Number"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 306)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Home Addresss"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 256)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(143, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "National Identificatin Number"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Nationality"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Date of Birth"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(161, 94)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(379, 20)
        Me.TextBox3.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(161, 53)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(379, 20)
        Me.TextBox2.TabIndex = 4
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(161, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(379, 20)
        Me.TextBox1.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Other name(s)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Last name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "First name"
        '
        'pnlNationalInformation
        '
        Me.pnlNationalInformation.Controls.Add(Me.Label9)
        Me.pnlNationalInformation.Controls.Add(Me.ComboBox4)
        Me.pnlNationalInformation.Controls.Add(Me.ComboBox5)
        Me.pnlNationalInformation.Controls.Add(Me.RichTextBox1)
        Me.pnlNationalInformation.Controls.Add(Me.Label10)
        Me.pnlNationalInformation.Controls.Add(Me.ComboBox6)
        Me.pnlNationalInformation.Controls.Add(Me.TextBox13)
        Me.pnlNationalInformation.Controls.Add(Me.TextBox14)
        Me.pnlNationalInformation.Controls.Add(Me.TextBox15)
        Me.pnlNationalInformation.Controls.Add(Me.TextBox16)
        Me.pnlNationalInformation.Controls.Add(Me.Label11)
        Me.pnlNationalInformation.Controls.Add(Me.Label13)
        Me.pnlNationalInformation.Controls.Add(Me.Label14)
        Me.pnlNationalInformation.Controls.Add(Me.Label15)
        Me.pnlNationalInformation.Controls.Add(Me.Label16)
        Me.pnlNationalInformation.Controls.Add(Me.Label21)
        Me.pnlNationalInformation.Location = New System.Drawing.Point(3, 713)
        Me.pnlNationalInformation.Name = "pnlNationalInformation"
        Me.pnlNationalInformation.Size = New System.Drawing.Size(748, 671)
        Me.pnlNationalInformation.TabIndex = 8
        Me.pnlNationalInformation.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 516)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 13)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Email Addresss"
        '
        'ComboBox4
        '
        Me.ComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"Ahafo Region", "Ashanti Region", "Bono Region", "Bono East Region", "Central Region", "Eastern Region", "Greater Accra Region", "North East Region", "Northern Region", "Oti Region", "Savannah Region", "Upper East Region", "Upper West Region", "Volta Region", "Western Region", "Western North Region"})
        Me.ComboBox4.Location = New System.Drawing.Point(419, 238)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox4.TabIndex = 25
        '
        'ComboBox5
        '
        Me.ComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Items.AddRange(New Object() {"GHANAIAN", "INDIAN ", "CHINESE", "JAPANESE", "BRAZILIAN", "GERMAN", "FRENCH", "ITALIAN", "SPANISH", "NIGERIAN ", "SOUTH AFRICAN", "MEXICAN", "RUSSIAN", "EGYPTIAN", "DUTCH", "SWEDISH"})
        Me.ComboBox5.Location = New System.Drawing.Point(167, 19)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(183, 21)
        Me.ComboBox5.TabIndex = 24
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(164, 238)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(100, 96)
        Me.RichTextBox1.TabIndex = 23
        Me.RichTextBox1.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(21, 69)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Region born"
        '
        'ComboBox6
        '
        Me.ComboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Items.AddRange(New Object() {"Ahafo Region", "Ashanti Region", "Bono Region", "Bono East Region", "Central Region", "Eastern Region", "Greater Accra Region", "North East Region", "Northern Region", "Oti Region", "Savannah Region", "Upper East Region", "Upper West Region", "Volta Region", "Western Region", "Western North Region"})
        Me.ComboBox6.Location = New System.Drawing.Point(167, 69)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(183, 21)
        Me.ComboBox6.TabIndex = 21
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(167, 142)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(373, 20)
        Me.TextBox13.TabIndex = 17
        '
        'TextBox14
        '
        Me.TextBox14.Location = New System.Drawing.Point(155, 509)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(379, 20)
        Me.TextBox14.TabIndex = 16
        '
        'TextBox15
        '
        Me.TextBox15.Location = New System.Drawing.Point(161, 408)
        Me.TextBox15.MaxLength = 10
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(140, 20)
        Me.TextBox15.TabIndex = 15
        '
        'TextBox16
        '
        Me.TextBox16.AutoCompleteCustomSource.AddRange(New String() {"Goaso", "Kumasi", "Sunyani", "Techiman", "Cape Coast", "Koforidua", "Accra", "Nalerigu", "Tamale", "Dambai", "Damongo", "Bolgatanga", "Wa", "Ho", "Secondi-Takoradi", "Sefwi-Wiawso"})
        Me.TextBox16.Location = New System.Drawing.Point(419, 314)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(121, 20)
        Me.TextBox16.TabIndex = 14
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(346, 321)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(24, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "City"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(346, 238)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 13)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Region"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(15, 411)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(78, 13)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "Phone Number"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(15, 238)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(81, 13)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "Home Addresss"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(15, 142)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(143, 13)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "National Identificatin Number"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(21, 19)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(56, 13)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Nationality"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'pBoxProfilePicture
        '
        Me.pBoxProfilePicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pBoxProfilePicture.Location = New System.Drawing.Point(669, 11)
        Me.pBoxProfilePicture.Name = "pBoxProfilePicture"
        Me.pBoxProfilePicture.Size = New System.Drawing.Size(115, 118)
        Me.pBoxProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pBoxProfilePicture.TabIndex = 11
        Me.pBoxProfilePicture.TabStop = False
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(768, 480)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.pnlPersonalInformation.ResumeLayout(False)
        Me.pnlPersonalInformation.PerformLayout()
        Me.pnlNationalInformation.ResumeLayout(False)
        Me.pnlNationalInformation.PerformLayout()
        CType(Me.pBoxProfilePicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pBoxProfilePicture As PictureBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents pnlPersonalInformation As Panel
    Friend WithEvents lblEmailAddress As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents rtbHomeAddress As RichTextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents lblCity As Label
    Friend WithEvents lblRegion As Label
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pnlNationalInformation As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents TextBox15 As TextBox
    Friend WithEvents TextBox16 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents btnBrowse As Button
    Friend WithEvents btnNavigation As Button
    Friend WithEvents btnSubmit As Button
    Protected WithEvents Panel1 As Panel
End Class
