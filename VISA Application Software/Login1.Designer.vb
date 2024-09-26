<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login1))
        Me.Panel = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.btnsignup = New Guna.UI.WinForms.GunaGradientButton()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.lblError = New Guna.UI.WinForms.GunaLabel()
        Me.lblsecurity = New Guna.UI.WinForms.GunaLabel()
        Me.btnRefreshCaptcha = New Guna.UI.WinForms.GunaButton()
        Me.chkShowPassword = New Guna.UI.WinForms.GunaCheckBox()
        Me.captchtxt = New Guna.UI.WinForms.GunaLabel()
        Me.picCaptcha = New System.Windows.Forms.PictureBox()
        Me.txtCaptcha = New Guna.UI.WinForms.GunaLineTextBox()
        Me.btnSubmit = New Guna.UI.WinForms.GunaGradientButton()
        Me.logintxt = New Guna.UI.WinForms.GunaLabel()
        Me.GunaGradient2Panel3 = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.GunaImageButton2 = New Guna.UI.WinForms.GunaImageButton()
        Me.txtPassword = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaGradient2Panel2 = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.GunaImageButton1 = New Guna.UI.WinForms.GunaImageButton()
        Me.txtUsername = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.Guna2ImageButton1 = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Panel.SuspendLayout()
        CType(Me.picCaptcha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaGradient2Panel3.SuspendLayout()
        Me.GunaGradient2Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel
        '
        Me.Panel.BackColor = System.Drawing.Color.Transparent
        Me.Panel.Controls.Add(Me.Guna2ImageButton1)
        Me.Panel.Controls.Add(Me.btnsignup)
        Me.Panel.Controls.Add(Me.GunaLabel1)
        Me.Panel.Controls.Add(Me.lblError)
        Me.Panel.Controls.Add(Me.lblsecurity)
        Me.Panel.Controls.Add(Me.btnRefreshCaptcha)
        Me.Panel.Controls.Add(Me.chkShowPassword)
        Me.Panel.Controls.Add(Me.captchtxt)
        Me.Panel.Controls.Add(Me.picCaptcha)
        Me.Panel.Controls.Add(Me.txtCaptcha)
        Me.Panel.Controls.Add(Me.btnSubmit)
        Me.Panel.Controls.Add(Me.logintxt)
        Me.Panel.Controls.Add(Me.GunaGradient2Panel3)
        Me.Panel.Controls.Add(Me.GunaGradient2Panel2)
        Me.Panel.ForeColor = System.Drawing.Color.Red
        Me.Panel.GradientColor1 = System.Drawing.Color.White
        Me.Panel.GradientColor2 = System.Drawing.Color.White
        Me.Panel.Location = New System.Drawing.Point(93, 149)
        Me.Panel.Name = "Panel"
        Me.Panel.Radius = 20
        Me.Panel.Size = New System.Drawing.Size(718, 393)
        Me.Panel.TabIndex = 1
        '
        'btnsignup
        '
        Me.btnsignup.AnimationHoverSpeed = 0.07!
        Me.btnsignup.AnimationSpeed = 0.03!
        Me.btnsignup.BackColor = System.Drawing.Color.Transparent
        Me.btnsignup.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnsignup.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnsignup.BorderColor = System.Drawing.Color.Black
        Me.btnsignup.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnsignup.FocusedColor = System.Drawing.Color.Empty
        Me.btnsignup.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsignup.ForeColor = System.Drawing.Color.White
        Me.btnsignup.Image = Nothing
        Me.btnsignup.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnsignup.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnsignup.Location = New System.Drawing.Point(534, 338)
        Me.btnsignup.Name = "btnsignup"
        Me.btnsignup.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnsignup.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnsignup.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnsignup.OnHoverForeColor = System.Drawing.Color.White
        Me.btnsignup.OnHoverImage = Nothing
        Me.btnsignup.OnPressedColor = System.Drawing.Color.Black
        Me.btnsignup.Radius = 8
        Me.btnsignup.Size = New System.Drawing.Size(53, 16)
        Me.btnsignup.TabIndex = 19
        Me.btnsignup.Text = "SignUp"
        Me.btnsignup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel1.ForeColor = System.Drawing.Color.Gray
        Me.GunaLabel1.Location = New System.Drawing.Point(394, 339)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(134, 15)
        Me.GunaLabel1.TabIndex = 18
        Me.GunaLabel1.Text = "I don't have an account."
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.Location = New System.Drawing.Point(383, 245)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 17)
        Me.lblError.TabIndex = 17
        '
        'lblsecurity
        '
        Me.lblsecurity.AutoSize = True
        Me.lblsecurity.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblsecurity.ForeColor = System.Drawing.Color.Gray
        Me.lblsecurity.Location = New System.Drawing.Point(91, 325)
        Me.lblsecurity.Name = "lblsecurity"
        Me.lblsecurity.Size = New System.Drawing.Size(113, 15)
        Me.lblsecurity.TabIndex = 16
        Me.lblsecurity.Text = "Privacy and Security"
        '
        'btnRefreshCaptcha
        '
        Me.btnRefreshCaptcha.AnimationHoverSpeed = 0.07!
        Me.btnRefreshCaptcha.AnimationSpeed = 0.03!
        Me.btnRefreshCaptcha.BackgroundImage = CType(resources.GetObject("btnRefreshCaptcha.BackgroundImage"), System.Drawing.Image)
        Me.btnRefreshCaptcha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnRefreshCaptcha.BaseColor = System.Drawing.Color.Transparent
        Me.btnRefreshCaptcha.BorderColor = System.Drawing.Color.Black
        Me.btnRefreshCaptcha.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnRefreshCaptcha.FocusedColor = System.Drawing.Color.Empty
        Me.btnRefreshCaptcha.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnRefreshCaptcha.ForeColor = System.Drawing.Color.White
        Me.btnRefreshCaptcha.Image = Nothing
        Me.btnRefreshCaptcha.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnRefreshCaptcha.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnRefreshCaptcha.Location = New System.Drawing.Point(256, 293)
        Me.btnRefreshCaptcha.Name = "btnRefreshCaptcha"
        Me.btnRefreshCaptcha.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRefreshCaptcha.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnRefreshCaptcha.OnHoverForeColor = System.Drawing.Color.White
        Me.btnRefreshCaptcha.OnHoverImage = Nothing
        Me.btnRefreshCaptcha.OnPressedColor = System.Drawing.Color.Black
        Me.btnRefreshCaptcha.Size = New System.Drawing.Size(36, 28)
        Me.btnRefreshCaptcha.TabIndex = 15
        '
        'chkShowPassword
        '
        Me.chkShowPassword.BaseColor = System.Drawing.Color.White
        Me.chkShowPassword.CheckedOffColor = System.Drawing.Color.Gray
        Me.chkShowPassword.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chkShowPassword.FillColor = System.Drawing.Color.White
        Me.chkShowPassword.ForeColor = System.Drawing.Color.DimGray
        Me.chkShowPassword.Location = New System.Drawing.Point(443, 206)
        Me.chkShowPassword.Name = "chkShowPassword"
        Me.chkShowPassword.Size = New System.Drawing.Size(106, 20)
        Me.chkShowPassword.TabIndex = 12
        Me.chkShowPassword.Text = "View password"
        '
        'captchtxt
        '
        Me.captchtxt.AutoSize = True
        Me.captchtxt.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.captchtxt.ForeColor = System.Drawing.Color.Black
        Me.captchtxt.Location = New System.Drawing.Point(39, 278)
        Me.captchtxt.Name = "captchtxt"
        Me.captchtxt.Size = New System.Drawing.Size(223, 13)
        Me.captchtxt.TabIndex = 9
        Me.captchtxt.Text = "Confirm the captcha if you're not a robot."
        '
        'picCaptcha
        '
        Me.picCaptcha.BackColor = System.Drawing.Color.White
        Me.picCaptcha.Location = New System.Drawing.Point(50, 204)
        Me.picCaptcha.Name = "picCaptcha"
        Me.picCaptcha.Size = New System.Drawing.Size(200, 69)
        Me.picCaptcha.TabIndex = 8
        Me.picCaptcha.TabStop = False
        '
        'txtCaptcha
        '
        Me.txtCaptcha.BackColor = System.Drawing.Color.BlueViolet
        Me.txtCaptcha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCaptcha.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCaptcha.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCaptcha.ForeColor = System.Drawing.Color.Transparent
        Me.txtCaptcha.LineColor = System.Drawing.Color.Thistle
        Me.txtCaptcha.Location = New System.Drawing.Point(50, 295)
        Me.txtCaptcha.Name = "txtCaptcha"
        Me.txtCaptcha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCaptcha.SelectedText = ""
        Me.txtCaptcha.Size = New System.Drawing.Size(200, 26)
        Me.txtCaptcha.TabIndex = 7
        '
        'btnSubmit
        '
        Me.btnSubmit.AnimationHoverSpeed = 0.07!
        Me.btnSubmit.AnimationSpeed = 0.03!
        Me.btnSubmit.BackColor = System.Drawing.Color.Transparent
        Me.btnSubmit.BaseColor1 = System.Drawing.Color.ForestGreen
        Me.btnSubmit.BaseColor2 = System.Drawing.Color.ForestGreen
        Me.btnSubmit.BorderColor = System.Drawing.Color.Black
        Me.btnSubmit.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSubmit.FocusedColor = System.Drawing.Color.Empty
        Me.btnSubmit.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.Image = Nothing
        Me.btnSubmit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnSubmit.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnSubmit.Location = New System.Drawing.Point(334, 278)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnSubmit.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSubmit.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnSubmit.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSubmit.OnHoverImage = Nothing
        Me.btnSubmit.OnPressedColor = System.Drawing.Color.Black
        Me.btnSubmit.Radius = 20
        Me.btnSubmit.Size = New System.Drawing.Size(338, 42)
        Me.btnSubmit.TabIndex = 6
        Me.btnSubmit.Text = "LOGIN"
        Me.btnSubmit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'logintxt
        '
        Me.logintxt.AutoSize = True
        Me.logintxt.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logintxt.ForeColor = System.Drawing.Color.Black
        Me.logintxt.Location = New System.Drawing.Point(449, 48)
        Me.logintxt.Name = "logintxt"
        Me.logintxt.Size = New System.Drawing.Size(79, 32)
        Me.logintxt.TabIndex = 5
        Me.logintxt.Text = "Login"
        '
        'GunaGradient2Panel3
        '
        Me.GunaGradient2Panel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradient2Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GunaGradient2Panel3.Controls.Add(Me.GunaImageButton2)
        Me.GunaGradient2Panel3.Controls.Add(Me.txtPassword)
        Me.GunaGradient2Panel3.Controls.Add(Me.GunaLabel3)
        Me.GunaGradient2Panel3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGradient2Panel3.GradientColor1 = System.Drawing.Color.LightGray
        Me.GunaGradient2Panel3.GradientColor2 = System.Drawing.Color.LightGray
        Me.GunaGradient2Panel3.Location = New System.Drawing.Point(334, 160)
        Me.GunaGradient2Panel3.Name = "GunaGradient2Panel3"
        Me.GunaGradient2Panel3.Radius = 20
        Me.GunaGradient2Panel3.Size = New System.Drawing.Size(338, 40)
        Me.GunaGradient2Panel3.TabIndex = 2
        '
        'GunaImageButton2
        '
        Me.GunaImageButton2.BackgroundImage = CType(resources.GetObject("GunaImageButton2.BackgroundImage"), System.Drawing.Image)
        Me.GunaImageButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GunaImageButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton2.Image = Nothing
        Me.GunaImageButton2.ImageSize = New System.Drawing.Size(64, 64)
        Me.GunaImageButton2.Location = New System.Drawing.Point(5, 5)
        Me.GunaImageButton2.Name = "GunaImageButton2"
        Me.GunaImageButton2.OnHoverImage = Nothing
        Me.GunaImageButton2.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton2.Size = New System.Drawing.Size(28, 28)
        Me.GunaImageButton2.TabIndex = 14
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.Transparent
        Me.txtPassword.BaseColor = System.Drawing.Color.WhiteSmoke
        Me.txtPassword.BorderColor = System.Drawing.Color.Silver
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.FocusedBaseColor = System.Drawing.Color.White
        Me.txtPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPassword.ForeColor = System.Drawing.Color.Black
        Me.txtPassword.Location = New System.Drawing.Point(110, 5)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPassword.Radius = 8
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.Size = New System.Drawing.Size(223, 30)
        Me.txtPassword.TabIndex = 12
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.DimGray
        Me.GunaLabel3.Location = New System.Drawing.Point(35, 10)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(70, 20)
        Me.GunaLabel3.TabIndex = 13
        Me.GunaLabel3.Text = "Password"
        '
        'GunaGradient2Panel2
        '
        Me.GunaGradient2Panel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradient2Panel2.Controls.Add(Me.GunaImageButton1)
        Me.GunaGradient2Panel2.Controls.Add(Me.txtUsername)
        Me.GunaGradient2Panel2.Controls.Add(Me.GunaLabel2)
        Me.GunaGradient2Panel2.GradientColor1 = System.Drawing.Color.LightGray
        Me.GunaGradient2Panel2.GradientColor2 = System.Drawing.Color.LightGray
        Me.GunaGradient2Panel2.Location = New System.Drawing.Point(333, 96)
        Me.GunaGradient2Panel2.Name = "GunaGradient2Panel2"
        Me.GunaGradient2Panel2.Radius = 20
        Me.GunaGradient2Panel2.Size = New System.Drawing.Size(338, 40)
        Me.GunaGradient2Panel2.TabIndex = 1
        '
        'GunaImageButton1
        '
        Me.GunaImageButton1.BackgroundImage = CType(resources.GetObject("GunaImageButton1.BackgroundImage"), System.Drawing.Image)
        Me.GunaImageButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GunaImageButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton1.Image = Nothing
        Me.GunaImageButton1.ImageSize = New System.Drawing.Size(64, 64)
        Me.GunaImageButton1.Location = New System.Drawing.Point(1, 1)
        Me.GunaImageButton1.Name = "GunaImageButton1"
        Me.GunaImageButton1.OnHoverImage = Nothing
        Me.GunaImageButton1.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton1.Size = New System.Drawing.Size(40, 38)
        Me.GunaImageButton1.TabIndex = 13
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.Transparent
        Me.txtUsername.BaseColor = System.Drawing.Color.White
        Me.txtUsername.BorderColor = System.Drawing.Color.Silver
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.FocusedBaseColor = System.Drawing.Color.White
        Me.txtUsername.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtUsername.ForeColor = System.Drawing.Color.Black
        Me.txtUsername.Location = New System.Drawing.Point(110, 5)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.Radius = 8
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.Size = New System.Drawing.Size(223, 30)
        Me.txtUsername.TabIndex = 13
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.DimGray
        Me.GunaLabel2.Location = New System.Drawing.Point(36, 10)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(75, 20)
        Me.GunaLabel2.TabIndex = 12
        Me.GunaLabel2.Text = "Username"
        '
        'Guna2ImageButton1
        '
        Me.Guna2ImageButton1.CheckedState.Parent = Me.Guna2ImageButton1
        Me.Guna2ImageButton1.HoverState.ImageSize = New System.Drawing.Size(150, 150)
        Me.Guna2ImageButton1.HoverState.Parent = Me.Guna2ImageButton1
        Me.Guna2ImageButton1.Image = Global.VISA_Application_Software.My.Resources.Resources.Project_Splash_
        Me.Guna2ImageButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Guna2ImageButton1.ImageSize = New System.Drawing.Size(150, 150)
        Me.Guna2ImageButton1.Location = New System.Drawing.Point(42, 86)
        Me.Guna2ImageButton1.Name = "Guna2ImageButton1"
        Me.Guna2ImageButton1.PressedState.Parent = Me.Guna2ImageButton1
        Me.Guna2ImageButton1.Size = New System.Drawing.Size(208, 104)
        Me.Guna2ImageButton1.TabIndex = 20
        '
        'Login1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(890, 647)
        Me.Controls.Add(Me.Panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login1"
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        CType(Me.picCaptcha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaGradient2Panel3.ResumeLayout(False)
        Me.GunaGradient2Panel3.PerformLayout()
        Me.GunaGradient2Panel2.ResumeLayout(False)
        Me.GunaGradient2Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents btnSubmit As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents logintxt As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaGradient2Panel3 As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents GunaGradient2Panel2 As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents txtCaptcha As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents captchtxt As Guna.UI.WinForms.GunaLabel
    Friend WithEvents picCaptcha As PictureBox
    Friend WithEvents chkShowPassword As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents txtPassword As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtUsername As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaImageButton2 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaImageButton1 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents lblsecurity As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnRefreshCaptcha As Guna.UI.WinForms.GunaButton
    Friend WithEvents lblError As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnsignup As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Guna2ImageButton1 As Guna.UI2.WinForms.Guna2ImageButton
End Class
