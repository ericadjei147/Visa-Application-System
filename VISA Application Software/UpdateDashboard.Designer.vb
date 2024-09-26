<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateDashboard))
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlSide = New System.Windows.Forms.Panel()
        Me.btnContactUs = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnOverview = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnFAQs = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnAppynow = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnProfile = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.NotificationBell = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.NotifiacationCount = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.pnlSide.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.BorderRadius = 10
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.Font = New System.Drawing.Font("Poppins", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2Button1.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(-10, -6)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.PressedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(1120, 78)
        Me.Guna2Button1.TabIndex = 0
        Me.Guna2Button1.UseTransparentBackground = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Poppins", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(455, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 48)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "DASHBOARD"
        '
        'pnlSide
        '
        Me.pnlSide.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.pnlSide.Controls.Add(Me.btnContactUs)
        Me.pnlSide.Controls.Add(Me.btnOverview)
        Me.pnlSide.Controls.Add(Me.btnFAQs)
        Me.pnlSide.Controls.Add(Me.btnAppynow)
        Me.pnlSide.Controls.Add(Me.btnProfile)
        Me.pnlSide.Location = New System.Drawing.Point(-2, 69)
        Me.pnlSide.Name = "pnlSide"
        Me.pnlSide.Size = New System.Drawing.Size(175, 549)
        Me.pnlSide.TabIndex = 2
        '
        'btnContactUs
        '
        Me.btnContactUs.AnimationHoverSpeed = 0.07!
        Me.btnContactUs.AnimationSpeed = 0.03!
        Me.btnContactUs.BackColor = System.Drawing.Color.Transparent
        Me.btnContactUs.BaseColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnContactUs.BorderColor = System.Drawing.Color.Transparent
        Me.btnContactUs.CheckedBaseColor = System.Drawing.Color.Transparent
        Me.btnContactUs.CheckedBorderColor = System.Drawing.Color.Transparent
        Me.btnContactUs.CheckedForeColor = System.Drawing.Color.White
        Me.btnContactUs.CheckedImage = Nothing
        Me.btnContactUs.CheckedLineColor = System.Drawing.Color.Transparent
        Me.btnContactUs.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnContactUs.FocusedColor = System.Drawing.Color.Empty
        Me.btnContactUs.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContactUs.ForeColor = System.Drawing.Color.White
        Me.btnContactUs.Image = CType(resources.GetObject("btnContactUs.Image"), System.Drawing.Image)
        Me.btnContactUs.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnContactUs.LineColor = System.Drawing.Color.Transparent
        Me.btnContactUs.Location = New System.Drawing.Point(14, 334)
        Me.btnContactUs.Name = "btnContactUs"
        Me.btnContactUs.OnHoverBaseColor = System.Drawing.Color.Fuchsia
        Me.btnContactUs.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnContactUs.OnHoverForeColor = System.Drawing.Color.White
        Me.btnContactUs.OnHoverImage = Nothing
        Me.btnContactUs.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnContactUs.OnPressedColor = System.Drawing.Color.Transparent
        Me.btnContactUs.Radius = 10
        Me.btnContactUs.Size = New System.Drawing.Size(146, 80)
        Me.btnContactUs.TabIndex = 15
        Me.btnContactUs.Text = "Contact Us."
        Me.btnContactUs.UseTransfarantBackground = True
        '
        'btnOverview
        '
        Me.btnOverview.AnimationHoverSpeed = 0.07!
        Me.btnOverview.AnimationSpeed = 0.03!
        Me.btnOverview.BackColor = System.Drawing.Color.Transparent
        Me.btnOverview.BaseColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnOverview.BorderColor = System.Drawing.Color.Transparent
        Me.btnOverview.CheckedBaseColor = System.Drawing.Color.Transparent
        Me.btnOverview.CheckedBorderColor = System.Drawing.Color.Transparent
        Me.btnOverview.CheckedForeColor = System.Drawing.Color.White
        Me.btnOverview.CheckedImage = Nothing
        Me.btnOverview.CheckedLineColor = System.Drawing.Color.Transparent
        Me.btnOverview.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnOverview.FocusedColor = System.Drawing.Color.Empty
        Me.btnOverview.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOverview.ForeColor = System.Drawing.Color.White
        Me.btnOverview.Image = CType(resources.GetObject("btnOverview.Image"), System.Drawing.Image)
        Me.btnOverview.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnOverview.LineColor = System.Drawing.Color.Transparent
        Me.btnOverview.Location = New System.Drawing.Point(14, 40)
        Me.btnOverview.Name = "btnOverview"
        Me.btnOverview.OnHoverBaseColor = System.Drawing.Color.Fuchsia
        Me.btnOverview.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnOverview.OnHoverForeColor = System.Drawing.Color.White
        Me.btnOverview.OnHoverImage = Nothing
        Me.btnOverview.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnOverview.OnPressedColor = System.Drawing.Color.Transparent
        Me.btnOverview.Radius = 10
        Me.btnOverview.Size = New System.Drawing.Size(146, 80)
        Me.btnOverview.TabIndex = 11
        Me.btnOverview.Text = "Overview"
        Me.btnOverview.UseTransfarantBackground = True
        '
        'btnFAQs
        '
        Me.btnFAQs.AnimationHoverSpeed = 0.07!
        Me.btnFAQs.AnimationSpeed = 0.03!
        Me.btnFAQs.BackColor = System.Drawing.Color.Transparent
        Me.btnFAQs.BaseColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnFAQs.BorderColor = System.Drawing.Color.Transparent
        Me.btnFAQs.CheckedBaseColor = System.Drawing.Color.Transparent
        Me.btnFAQs.CheckedBorderColor = System.Drawing.Color.Transparent
        Me.btnFAQs.CheckedForeColor = System.Drawing.Color.White
        Me.btnFAQs.CheckedImage = Nothing
        Me.btnFAQs.CheckedLineColor = System.Drawing.Color.Transparent
        Me.btnFAQs.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnFAQs.FocusedColor = System.Drawing.Color.Empty
        Me.btnFAQs.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFAQs.ForeColor = System.Drawing.Color.White
        Me.btnFAQs.Image = CType(resources.GetObject("btnFAQs.Image"), System.Drawing.Image)
        Me.btnFAQs.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnFAQs.LineColor = System.Drawing.Color.Transparent
        Me.btnFAQs.Location = New System.Drawing.Point(14, 432)
        Me.btnFAQs.Name = "btnFAQs"
        Me.btnFAQs.OnHoverBaseColor = System.Drawing.Color.Fuchsia
        Me.btnFAQs.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnFAQs.OnHoverForeColor = System.Drawing.Color.White
        Me.btnFAQs.OnHoverImage = Nothing
        Me.btnFAQs.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnFAQs.OnPressedColor = System.Drawing.Color.Transparent
        Me.btnFAQs.Radius = 10
        Me.btnFAQs.Size = New System.Drawing.Size(146, 80)
        Me.btnFAQs.TabIndex = 14
        Me.btnFAQs.Text = "FAQs"
        Me.btnFAQs.UseTransfarantBackground = True
        '
        'btnAppynow
        '
        Me.btnAppynow.AnimationHoverSpeed = 0.07!
        Me.btnAppynow.AnimationSpeed = 0.03!
        Me.btnAppynow.BackColor = System.Drawing.Color.Transparent
        Me.btnAppynow.BaseColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAppynow.BorderColor = System.Drawing.Color.Transparent
        Me.btnAppynow.CheckedBaseColor = System.Drawing.Color.Transparent
        Me.btnAppynow.CheckedBorderColor = System.Drawing.Color.Transparent
        Me.btnAppynow.CheckedForeColor = System.Drawing.Color.White
        Me.btnAppynow.CheckedImage = Nothing
        Me.btnAppynow.CheckedLineColor = System.Drawing.Color.Transparent
        Me.btnAppynow.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAppynow.FocusedColor = System.Drawing.Color.Empty
        Me.btnAppynow.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAppynow.ForeColor = System.Drawing.Color.White
        Me.btnAppynow.Image = CType(resources.GetObject("btnAppynow.Image"), System.Drawing.Image)
        Me.btnAppynow.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnAppynow.LineColor = System.Drawing.Color.Transparent
        Me.btnAppynow.Location = New System.Drawing.Point(14, 138)
        Me.btnAppynow.Name = "btnAppynow"
        Me.btnAppynow.OnHoverBaseColor = System.Drawing.Color.Fuchsia
        Me.btnAppynow.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnAppynow.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAppynow.OnHoverImage = Nothing
        Me.btnAppynow.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnAppynow.OnPressedColor = System.Drawing.Color.Transparent
        Me.btnAppynow.Radius = 10
        Me.btnAppynow.Size = New System.Drawing.Size(146, 80)
        Me.btnAppynow.TabIndex = 12
        Me.btnAppynow.Text = "Apply Now"
        Me.btnAppynow.UseTransfarantBackground = True
        '
        'btnProfile
        '
        Me.btnProfile.AnimationHoverSpeed = 0.07!
        Me.btnProfile.AnimationSpeed = 0.03!
        Me.btnProfile.BackColor = System.Drawing.Color.Transparent
        Me.btnProfile.BaseColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnProfile.BorderColor = System.Drawing.Color.Transparent
        Me.btnProfile.CheckedBaseColor = System.Drawing.Color.Transparent
        Me.btnProfile.CheckedBorderColor = System.Drawing.Color.Transparent
        Me.btnProfile.CheckedForeColor = System.Drawing.Color.White
        Me.btnProfile.CheckedImage = Nothing
        Me.btnProfile.CheckedLineColor = System.Drawing.Color.Transparent
        Me.btnProfile.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnProfile.FocusedColor = System.Drawing.Color.Empty
        Me.btnProfile.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProfile.ForeColor = System.Drawing.Color.White
        Me.btnProfile.Image = CType(resources.GetObject("btnProfile.Image"), System.Drawing.Image)
        Me.btnProfile.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnProfile.LineColor = System.Drawing.Color.Transparent
        Me.btnProfile.Location = New System.Drawing.Point(14, 236)
        Me.btnProfile.Name = "btnProfile"
        Me.btnProfile.OnHoverBaseColor = System.Drawing.Color.Fuchsia
        Me.btnProfile.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnProfile.OnHoverForeColor = System.Drawing.Color.White
        Me.btnProfile.OnHoverImage = Nothing
        Me.btnProfile.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnProfile.OnPressedColor = System.Drawing.Color.Transparent
        Me.btnProfile.Radius = 10
        Me.btnProfile.Size = New System.Drawing.Size(146, 80)
        Me.btnProfile.TabIndex = 13
        Me.btnProfile.Text = "Profile"
        Me.btnProfile.UseTransfarantBackground = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Location = New System.Drawing.Point(171, 66)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(939, 552)
        Me.Panel1.TabIndex = 3
        '
        'NotificationBell
        '
        Me.NotificationBell.BackColor = System.Drawing.Color.Transparent
        Me.NotificationBell.CheckedState.Parent = Me.NotificationBell
        Me.NotificationBell.CustomImages.Parent = Me.NotificationBell
        Me.NotificationBell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NotificationBell.ForeColor = System.Drawing.Color.White
        Me.NotificationBell.HoverState.Parent = Me.NotificationBell
        Me.NotificationBell.Image = Global.VISA_Application_Software.My.Resources.Resources.notification_bell
        Me.NotificationBell.ImageSize = New System.Drawing.Size(40, 40)
        Me.NotificationBell.Location = New System.Drawing.Point(1021, 18)
        Me.NotificationBell.Name = "NotificationBell"
        Me.NotificationBell.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.NotificationBell.ShadowDecoration.Parent = Me.NotificationBell
        Me.NotificationBell.Size = New System.Drawing.Size(46, 45)
        Me.NotificationBell.TabIndex = 4
        Me.NotificationBell.UseTransparentBackground = True
        '
        'NotifiacationCount
        '
        Me.NotifiacationCount.BackColor = System.Drawing.Color.Transparent
        Me.NotifiacationCount.CheckedState.Parent = Me.NotifiacationCount
        Me.NotifiacationCount.CustomImages.Parent = Me.NotifiacationCount
        Me.NotifiacationCount.FillColor = System.Drawing.Color.Fuchsia
        Me.NotifiacationCount.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotifiacationCount.ForeColor = System.Drawing.Color.White
        Me.NotifiacationCount.HoverState.Parent = Me.NotifiacationCount
        Me.NotifiacationCount.Location = New System.Drawing.Point(1045, 22)
        Me.NotifiacationCount.Name = "NotifiacationCount"
        Me.NotifiacationCount.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.NotifiacationCount.ShadowDecoration.Parent = Me.NotifiacationCount
        Me.NotifiacationCount.Size = New System.Drawing.Size(19, 19)
        Me.NotifiacationCount.TabIndex = 0
        Me.NotifiacationCount.Text = "0"
        Me.NotifiacationCount.UseTransparentBackground = True
        '
        'UpdateDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1105, 648)
        Me.Controls.Add(Me.NotifiacationCount)
        Me.Controls.Add(Me.NotificationBell)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.pnlSide)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "UpdateDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UpdateDashboard"
        Me.pnlSide.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlSide As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnContactUs As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnFAQs As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnProfile As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnAppynow As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnOverview As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents NotificationBell As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents NotifiacationCount As Guna.UI2.WinForms.Guna2CircleButton
End Class
