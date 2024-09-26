<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Overview
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnOverview = New Guna.UI2.WinForms.Guna2Button()
        Me.lblOverview = New System.Windows.Forms.Label()
        Me.lblFullname = New System.Windows.Forms.Label()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pboProfile = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.palMain = New System.Windows.Forms.Panel()
        Me.palAppoint = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.pboProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(-2, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 28)
        Me.Label4.TabIndex = 4
        '
        'btnOverview
        '
        Me.btnOverview.BackColor = System.Drawing.Color.Transparent
        Me.btnOverview.BorderColor = System.Drawing.Color.Transparent
        Me.btnOverview.BorderRadius = 10
        Me.btnOverview.CheckedState.Parent = Me.btnOverview
        Me.btnOverview.CustomImages.Parent = Me.btnOverview
        Me.btnOverview.FillColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btnOverview.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnOverview.ForeColor = System.Drawing.Color.White
        Me.btnOverview.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btnOverview.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btnOverview.HoverState.Parent = Me.btnOverview
        Me.btnOverview.Location = New System.Drawing.Point(-9, -12)
        Me.btnOverview.Name = "btnOverview"
        Me.btnOverview.PressedColor = System.Drawing.Color.Transparent
        Me.btnOverview.PressedDepth = 0
        Me.btnOverview.ShadowDecoration.Parent = Me.btnOverview
        Me.btnOverview.Size = New System.Drawing.Size(959, 55)
        Me.btnOverview.TabIndex = 5
        Me.btnOverview.UseTransparentBackground = True
        '
        'lblOverview
        '
        Me.lblOverview.AutoSize = True
        Me.lblOverview.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.lblOverview.Font = New System.Drawing.Font("Poppins SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOverview.ForeColor = System.Drawing.Color.White
        Me.lblOverview.Location = New System.Drawing.Point(422, 6)
        Me.lblOverview.Name = "lblOverview"
        Me.lblOverview.Size = New System.Drawing.Size(105, 34)
        Me.lblOverview.TabIndex = 6
        Me.lblOverview.Text = "Overview"
        '
        'lblFullname
        '
        Me.lblFullname.AutoSize = True
        Me.lblFullname.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullname.Location = New System.Drawing.Point(210, 63)
        Me.lblFullname.Name = "lblFullname"
        Me.lblFullname.Size = New System.Drawing.Size(97, 28)
        Me.lblFullname.TabIndex = 8
        Me.lblFullname.Text = "Full Name:"
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhoneNumber.Location = New System.Drawing.Point(210, 94)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(138, 28)
        Me.lblPhoneNumber.TabIndex = 9
        Me.lblPhoneNumber.Text = "Phone number:"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(210, 122)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(61, 28)
        Me.lblEmail.TabIndex = 10
        Me.lblEmail.Text = "Email:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.palMain)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(76, 236)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(385, 255)
        Me.Panel1.TabIndex = 11
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.palAppoint)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(478, 236)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(385, 255)
        Me.Panel2.TabIndex = 12
        '
        'pboProfile
        '
        Me.pboProfile.BackColor = System.Drawing.Color.Transparent
        Me.pboProfile.Image = Global.VISA_Application_Software.My.Resources.Resources.Untitled_1
        Me.pboProfile.Location = New System.Drawing.Point(76, 49)
        Me.pboProfile.Name = "pboProfile"
        Me.pboProfile.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.pboProfile.ShadowDecoration.Parent = Me.pboProfile
        Me.pboProfile.Size = New System.Drawing.Size(118, 118)
        Me.pboProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboProfile.TabIndex = 7
        Me.pboProfile.TabStop = False
        Me.pboProfile.UseTransparentBackground = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(105, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 28)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "APPLICATION STATUS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(95, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(209, 28)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "APPOINTMENT SCHEDULE"
        '
        'palMain
        '
        Me.palMain.AutoScroll = True
        Me.palMain.AutoScrollMargin = New System.Drawing.Size(0, 20)
        Me.palMain.BackColor = System.Drawing.Color.WhiteSmoke
        Me.palMain.Location = New System.Drawing.Point(0, 42)
        Me.palMain.Name = "palMain"
        Me.palMain.Size = New System.Drawing.Size(383, 213)
        Me.palMain.TabIndex = 14
        '
        'palAppoint
        '
        Me.palAppoint.BackColor = System.Drawing.Color.WhiteSmoke
        Me.palAppoint.Location = New System.Drawing.Point(0, 42)
        Me.palAppoint.Name = "palAppoint"
        Me.palAppoint.Size = New System.Drawing.Size(383, 213)
        Me.palAppoint.TabIndex = 15
        '
        'Overview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(939, 552)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblPhoneNumber)
        Me.Controls.Add(Me.lblFullname)
        Me.Controls.Add(Me.pboProfile)
        Me.Controls.Add(Me.lblOverview)
        Me.Controls.Add(Me.btnOverview)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Overview"
        Me.Text = "v"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.pboProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents btnOverview As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblOverview As Label
    Friend WithEvents pboProfile As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents lblFullname As Label
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents palMain As Panel
    Friend WithEvents palAppoint As Panel
End Class
