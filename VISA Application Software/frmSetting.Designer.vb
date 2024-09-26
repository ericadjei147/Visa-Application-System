<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetting
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
        Me.btnOldView1 = New Guna.UI.WinForms.GunaCheckBox()
        Me.btnNewView = New Guna.UI.WinForms.GunaCheckBox()
        Me.btnNotificationSend = New Guna.UI2.WinForms.Guna2Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Guna2Separator4 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnChange = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Separator2 = New Guna.UI2.WinForms.Guna2Separator()
        Me.txtNewPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.txtOddPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Separator3 = New Guna.UI2.WinForms.Guna2Separator()
        Me.txtUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Separator5 = New Guna.UI2.WinForms.Guna2Separator()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOldView1
        '
        Me.btnOldView1.BackColor = System.Drawing.SystemColors.Control
        Me.btnOldView1.BaseColor = System.Drawing.Color.White
        Me.btnOldView1.CheckedOffColor = System.Drawing.Color.Gray
        Me.btnOldView1.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnOldView1.FillColor = System.Drawing.Color.White
        Me.btnOldView1.ForeColor = System.Drawing.Color.DimGray
        Me.btnOldView1.Location = New System.Drawing.Point(700, 218)
        Me.btnOldView1.Name = "btnOldView1"
        Me.btnOldView1.Size = New System.Drawing.Size(54, 20)
        Me.btnOldView1.TabIndex = 45
        Me.btnOldView1.Text = "View"
        '
        'btnNewView
        '
        Me.btnNewView.BackColor = System.Drawing.SystemColors.Control
        Me.btnNewView.BaseColor = System.Drawing.Color.White
        Me.btnNewView.CheckedOffColor = System.Drawing.Color.Gray
        Me.btnNewView.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNewView.FillColor = System.Drawing.Color.White
        Me.btnNewView.ForeColor = System.Drawing.Color.DimGray
        Me.btnNewView.Location = New System.Drawing.Point(700, 268)
        Me.btnNewView.Name = "btnNewView"
        Me.btnNewView.Size = New System.Drawing.Size(54, 20)
        Me.btnNewView.TabIndex = 44
        Me.btnNewView.Text = "View"
        '
        'btnNotificationSend
        '
        Me.btnNotificationSend.BackColor = System.Drawing.Color.White
        Me.btnNotificationSend.BorderRadius = 15
        Me.btnNotificationSend.CheckedState.Parent = Me.btnNotificationSend
        Me.btnNotificationSend.CustomImages.Parent = Me.btnNotificationSend
        Me.btnNotificationSend.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotificationSend.ForeColor = System.Drawing.Color.Black
        Me.btnNotificationSend.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNotificationSend.HoverState.Parent = Me.btnNotificationSend
        Me.btnNotificationSend.Location = New System.Drawing.Point(418, 464)
        Me.btnNotificationSend.Name = "btnNotificationSend"
        Me.btnNotificationSend.ShadowDecoration.Parent = Me.btnNotificationSend
        Me.btnNotificationSend.Size = New System.Drawing.Size(98, 32)
        Me.btnNotificationSend.TabIndex = 42
        Me.btnNotificationSend.Text = "Show"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(387, 427)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(150, 23)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Send a message"
        '
        'Guna2Button3
        '
        Me.Guna2Button3.BorderRadius = 15
        Me.Guna2Button3.CheckedState.Parent = Me.Guna2Button3
        Me.Guna2Button3.CustomImages.Parent = Me.Guna2Button3
        Me.Guna2Button3.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2Button3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button3.ForeColor = System.Drawing.Color.White
        Me.Guna2Button3.HoverState.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2Button3.HoverState.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2Button3.HoverState.Parent = Me.Guna2Button3
        Me.Guna2Button3.Location = New System.Drawing.Point(171, 420)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.PressedColor = System.Drawing.Color.Transparent
        Me.Guna2Button3.PressedDepth = 0
        Me.Guna2Button3.ShadowDecoration.Parent = Me.Guna2Button3
        Me.Guna2Button3.Size = New System.Drawing.Size(594, 38)
        Me.Guna2Button3.TabIndex = 40
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(206, 387)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 25)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Notification"
        '
        'Guna2Separator4
        '
        Me.Guna2Separator4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator4.Location = New System.Drawing.Point(280, 395)
        Me.Guna2Separator4.Name = "Guna2Separator4"
        Me.Guna2Separator4.Size = New System.Drawing.Size(485, 14)
        Me.Guna2Separator4.TabIndex = 38
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(187, 270)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 23)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "New Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(195, 215)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 23)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Old Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(215, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 25)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Settings"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(231, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 23)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Username"
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox1.Image = Global.VISA_Application_Software.My.Resources.Resources.cloud_settings
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(90, 43)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.ShadowDecoration.Parent = Me.Guna2CirclePictureBox1
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(39, 34)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2CirclePictureBox1.TabIndex = 27
        Me.Guna2CirclePictureBox1.TabStop = False
        Me.Guna2CirclePictureBox1.UseTransparentBackground = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(131, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 25)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Settings"
        '
        'btnChange
        '
        Me.btnChange.BackColor = System.Drawing.SystemColors.Control
        Me.btnChange.BorderRadius = 15
        Me.btnChange.CheckedState.Parent = Me.btnChange
        Me.btnChange.CustomImages.Parent = Me.btnChange
        Me.btnChange.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChange.ForeColor = System.Drawing.Color.Black
        Me.btnChange.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnChange.HoverState.Parent = Me.btnChange
        Me.btnChange.Location = New System.Drawing.Point(585, 320)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.ShadowDecoration.Parent = Me.btnChange
        Me.btnChange.Size = New System.Drawing.Size(105, 32)
        Me.btnChange.TabIndex = 28
        Me.btnChange.Text = "Change"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.BorderColor = System.Drawing.SystemColors.Control
        Me.Guna2Button1.HoverState.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2Button1.HoverState.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(-14, 36)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.PressedColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.PressedDepth = 0
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(979, 45)
        Me.Guna2Button1.TabIndex = 25
        Me.Guna2Button1.UseTransparentBackground = True
        '
        'Guna2Separator2
        '
        Me.Guna2Separator2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator2.Location = New System.Drawing.Point(280, 108)
        Me.Guna2Separator2.Name = "Guna2Separator2"
        Me.Guna2Separator2.Size = New System.Drawing.Size(485, 14)
        Me.Guna2Separator2.TabIndex = 24
        '
        'txtNewPassword
        '
        Me.txtNewPassword.BackColor = System.Drawing.SystemColors.Control
        Me.txtNewPassword.BorderRadius = 10
        Me.txtNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNewPassword.DefaultText = ""
        Me.txtNewPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNewPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNewPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewPassword.DisabledState.Parent = Me.txtNewPassword
        Me.txtNewPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewPassword.FocusedState.Parent = Me.txtNewPassword
        Me.txtNewPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewPassword.HoverState.Parent = Me.txtNewPassword
        Me.txtNewPassword.Location = New System.Drawing.Point(330, 258)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNewPassword.PlaceholderText = ""
        Me.txtNewPassword.SelectedText = ""
        Me.txtNewPassword.ShadowDecoration.Parent = Me.txtNewPassword
        Me.txtNewPassword.Size = New System.Drawing.Size(361, 36)
        Me.txtNewPassword.TabIndex = 32
        Me.txtNewPassword.UseSystemPasswordChar = True
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator1.Location = New System.Drawing.Point(-14, 70)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(979, 52)
        Me.Guna2Separator1.TabIndex = 23
        '
        'txtOddPassword
        '
        Me.txtOddPassword.BackColor = System.Drawing.SystemColors.Control
        Me.txtOddPassword.BorderRadius = 10
        Me.txtOddPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOddPassword.DefaultText = ""
        Me.txtOddPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtOddPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtOddPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtOddPassword.DisabledState.Parent = Me.txtOddPassword
        Me.txtOddPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtOddPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtOddPassword.FocusedState.Parent = Me.txtOddPassword
        Me.txtOddPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtOddPassword.HoverState.Parent = Me.txtOddPassword
        Me.txtOddPassword.Location = New System.Drawing.Point(329, 210)
        Me.txtOddPassword.Name = "txtOddPassword"
        Me.txtOddPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtOddPassword.PlaceholderText = ""
        Me.txtOddPassword.SelectedText = ""
        Me.txtOddPassword.ShadowDecoration.Parent = Me.txtOddPassword
        Me.txtOddPassword.Size = New System.Drawing.Size(361, 36)
        Me.txtOddPassword.TabIndex = 30
        Me.txtOddPassword.UseSystemPasswordChar = True
        '
        'Guna2Separator3
        '
        Me.Guna2Separator3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator3.Location = New System.Drawing.Point(-14, 356)
        Me.Guna2Separator3.Name = "Guna2Separator3"
        Me.Guna2Separator3.Size = New System.Drawing.Size(955, 52)
        Me.Guna2Separator3.TabIndex = 33
        Me.Guna2Separator3.UseTransparentBackground = True
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.SystemColors.Control
        Me.txtUsername.BorderRadius = 10
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.DefaultText = ""
        Me.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.DisabledState.Parent = Me.txtUsername
        Me.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.Enabled = False
        Me.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.FocusedState.Parent = Me.txtUsername
        Me.txtUsername.ForeColor = System.Drawing.Color.Black
        Me.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.HoverState.Parent = Me.txtUsername
        Me.txtUsername.Location = New System.Drawing.Point(329, 155)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.PlaceholderText = ""
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.ShadowDecoration.Parent = Me.txtUsername
        Me.txtUsername.Size = New System.Drawing.Size(361, 36)
        Me.txtUsername.TabIndex = 29
        '
        'Guna2Button2
        '
        Me.Guna2Button2.BorderRadius = 15
        Me.Guna2Button2.CheckedState.Parent = Me.Guna2Button2
        Me.Guna2Button2.CustomImages.Parent = Me.Guna2Button2
        Me.Guna2Button2.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.HoverState.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2Button2.HoverState.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2Button2.HoverState.Parent = Me.Guna2Button2
        Me.Guna2Button2.Location = New System.Drawing.Point(171, 128)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.PressedColor = System.Drawing.Color.Transparent
        Me.Guna2Button2.PressedDepth = 0
        Me.Guna2Button2.ShadowDecoration.Parent = Me.Guna2Button2
        Me.Guna2Button2.Size = New System.Drawing.Size(594, 244)
        Me.Guna2Button2.TabIndex = 37
        '
        'Guna2Separator5
        '
        Me.Guna2Separator5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator5.Location = New System.Drawing.Point(-14, 482)
        Me.Guna2Separator5.Name = "Guna2Separator5"
        Me.Guna2Separator5.Size = New System.Drawing.Size(970, 52)
        Me.Guna2Separator5.TabIndex = 43
        Me.Guna2Separator5.UseTransparentBackground = True
        '
        'frmSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(955, 591)
        Me.Controls.Add(Me.btnOldView1)
        Me.Controls.Add(Me.btnNewView)
        Me.Controls.Add(Me.btnNotificationSend)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Guna2Button3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Guna2Separator4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnChange)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.Guna2Separator2)
        Me.Controls.Add(Me.txtNewPassword)
        Me.Controls.Add(Me.Guna2Separator1)
        Me.Controls.Add(Me.txtOddPassword)
        Me.Controls.Add(Me.Guna2Separator3)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Guna2Button2)
        Me.Controls.Add(Me.Guna2Separator5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSetting"
        Me.Text = "frmSetting"
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOldView1 As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents btnNewView As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents btnNotificationSend As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Guna2Separator4 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnChange As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Separator2 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents txtNewPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents txtOddPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Separator3 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents txtUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Separator5 As Guna.UI2.WinForms.Guna2Separator
End Class
