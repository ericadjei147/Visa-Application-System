<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdminDashBoard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdminDashBoard))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GunaControlBox3 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaControlBox2 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaControlBox1 = New Guna.UI.WinForms.GunaControlBox()
        Me.palMenu = New Guna.UI.WinForms.GunaElipsePanel()
        Me.lblAppManagement = New System.Windows.Forms.Label()
        Me.lblDashboard = New System.Windows.Forms.Label()
        Me.lblSettings = New System.Windows.Forms.Label()
        Me.lblUserManagemen = New System.Windows.Forms.Label()
        Me.lblReport = New System.Windows.Forms.Label()
        Me.palShow = New System.Windows.Forms.Panel()
        Me.btnProfilePic = New Guna.UI.WinForms.GunaImageButton()
        Me.btnMenuNav = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaImageButton1 = New Guna.UI.WinForms.GunaImageButton()
        Me.Panel1.SuspendLayout()
        Me.palMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Magenta
        Me.Panel1.Controls.Add(Me.GunaImageButton1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.GunaControlBox3)
        Me.Panel1.Controls.Add(Me.GunaControlBox2)
        Me.Panel1.Controls.Add(Me.GunaControlBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(955, 28)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "VISA"
        '
        'GunaControlBox3
        '
        Me.GunaControlBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox3.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox3.AnimationSpeed = 0.03!
        Me.GunaControlBox3.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox
        Me.GunaControlBox3.IconColor = System.Drawing.Color.Black
        Me.GunaControlBox3.IconSize = 15.0!
        Me.GunaControlBox3.Location = New System.Drawing.Point(806, 0)
        Me.GunaControlBox3.Name = "GunaControlBox3"
        Me.GunaControlBox3.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GunaControlBox3.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox3.Size = New System.Drawing.Size(45, 29)
        Me.GunaControlBox3.TabIndex = 6
        '
        'GunaControlBox2
        '
        Me.GunaControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox2.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox2.AnimationSpeed = 0.03!
        Me.GunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MaximizeBox
        Me.GunaControlBox2.IconColor = System.Drawing.Color.Black
        Me.GunaControlBox2.IconSize = 15.0!
        Me.GunaControlBox2.Location = New System.Drawing.Point(858, 0)
        Me.GunaControlBox2.Name = "GunaControlBox2"
        Me.GunaControlBox2.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GunaControlBox2.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox2.Size = New System.Drawing.Size(45, 29)
        Me.GunaControlBox2.TabIndex = 5
        '
        'GunaControlBox1
        '
        Me.GunaControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox1.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox1.AnimationSpeed = 0.03!
        Me.GunaControlBox1.IconColor = System.Drawing.Color.Black
        Me.GunaControlBox1.IconSize = 15.0!
        Me.GunaControlBox1.Location = New System.Drawing.Point(910, 0)
        Me.GunaControlBox1.Name = "GunaControlBox1"
        Me.GunaControlBox1.OnHoverBackColor = System.Drawing.Color.Red
        Me.GunaControlBox1.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox1.Size = New System.Drawing.Size(45, 29)
        Me.GunaControlBox1.TabIndex = 4
        '
        'palMenu
        '
        Me.palMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.palMenu.BackColor = System.Drawing.Color.Transparent
        Me.palMenu.BaseColor = System.Drawing.Color.Cyan
        Me.palMenu.Controls.Add(Me.btnProfilePic)
        Me.palMenu.Controls.Add(Me.lblAppManagement)
        Me.palMenu.Controls.Add(Me.btnMenuNav)
        Me.palMenu.Controls.Add(Me.lblDashboard)
        Me.palMenu.Controls.Add(Me.lblSettings)
        Me.palMenu.Controls.Add(Me.lblUserManagemen)
        Me.palMenu.Controls.Add(Me.lblReport)
        Me.palMenu.Location = New System.Drawing.Point(821, 34)
        Me.palMenu.Name = "palMenu"
        Me.palMenu.Radius = 20
        Me.palMenu.Size = New System.Drawing.Size(122, 48)
        Me.palMenu.TabIndex = 1
        '
        'lblAppManagement
        '
        Me.lblAppManagement.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblAppManagement.AutoSize = True
        Me.lblAppManagement.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblAppManagement.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAppManagement.Location = New System.Drawing.Point(-474, 13)
        Me.lblAppManagement.Name = "lblAppManagement"
        Me.lblAppManagement.Size = New System.Drawing.Size(232, 28)
        Me.lblAppManagement.TabIndex = 8
        Me.lblAppManagement.Text = "APPLICATION MANAGEMENT"
        '
        'lblDashboard
        '
        Me.lblDashboard.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblDashboard.AutoSize = True
        Me.lblDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblDashboard.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDashboard.Location = New System.Drawing.Point(-801, 13)
        Me.lblDashboard.Name = "lblDashboard"
        Me.lblDashboard.Size = New System.Drawing.Size(110, 28)
        Me.lblDashboard.TabIndex = 4
        Me.lblDashboard.Text = "DASHBOARD"
        '
        'lblSettings
        '
        Me.lblSettings.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblSettings.AutoSize = True
        Me.lblSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSettings.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSettings.Location = New System.Drawing.Point(-117, 13)
        Me.lblSettings.Name = "lblSettings"
        Me.lblSettings.Size = New System.Drawing.Size(87, 28)
        Me.lblSettings.TabIndex = 10
        Me.lblSettings.Text = "SETTINGS"
        '
        'lblUserManagemen
        '
        Me.lblUserManagemen.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblUserManagemen.AutoSize = True
        Me.lblUserManagemen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblUserManagemen.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserManagemen.Location = New System.Drawing.Point(-667, 13)
        Me.lblUserManagemen.Name = "lblUserManagemen"
        Me.lblUserManagemen.Size = New System.Drawing.Size(169, 28)
        Me.lblUserManagemen.TabIndex = 5
        Me.lblUserManagemen.Text = "USER MANAGEMENT"
        '
        'lblReport
        '
        Me.lblReport.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblReport.AutoSize = True
        Me.lblReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblReport.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReport.Location = New System.Drawing.Point(-218, 13)
        Me.lblReport.Name = "lblReport"
        Me.lblReport.Size = New System.Drawing.Size(73, 28)
        Me.lblReport.TabIndex = 7
        Me.lblReport.Text = "REPORT"
        '
        'palShow
        '
        Me.palShow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.palShow.Location = New System.Drawing.Point(0, 28)
        Me.palShow.Name = "palShow"
        Me.palShow.Size = New System.Drawing.Size(955, 591)
        Me.palShow.TabIndex = 2
        '
        'btnProfilePic
        '
        Me.btnProfilePic.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProfilePic.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnProfilePic.Image = Global.VISA_Application_Software.My.Resources.Resources.profile
        Me.btnProfilePic.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnProfilePic.Location = New System.Drawing.Point(71, 6)
        Me.btnProfilePic.Name = "btnProfilePic"
        Me.btnProfilePic.OnHoverImage = Nothing
        Me.btnProfilePic.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.btnProfilePic.Size = New System.Drawing.Size(35, 35)
        Me.btnProfilePic.TabIndex = 9
        '
        'btnMenuNav
        '
        Me.btnMenuNav.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMenuNav.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenuNav.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnMenuNav.Image = Global.VISA_Application_Software.My.Resources.Resources.setup
        Me.btnMenuNav.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnMenuNav.Location = New System.Drawing.Point(12, 6)
        Me.btnMenuNav.Name = "btnMenuNav"
        Me.btnMenuNav.OnHoverImage = Nothing
        Me.btnMenuNav.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.btnMenuNav.Size = New System.Drawing.Size(35, 35)
        Me.btnMenuNav.TabIndex = 6
        '
        'GunaImageButton1
        '
        Me.GunaImageButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton1.Image = Global.VISA_Application_Software.My.Resources.Resources.Project_Splash_
        Me.GunaImageButton1.ImageSize = New System.Drawing.Size(30, 30)
        Me.GunaImageButton1.Location = New System.Drawing.Point(21, 3)
        Me.GunaImageButton1.Name = "GunaImageButton1"
        Me.GunaImageButton1.OnHoverImage = Nothing
        Me.GunaImageButton1.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton1.Size = New System.Drawing.Size(21, 22)
        Me.GunaImageButton1.TabIndex = 2
        '
        'frmAdminDashBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 619)
        Me.Controls.Add(Me.palMenu)
        Me.Controls.Add(Me.palShow)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAdminDashBoard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAdminDashBoard"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.palMenu.ResumeLayout(False)
        Me.palMenu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GunaControlBox3 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaControlBox2 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaControlBox1 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaImageButton1 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents Label1 As Label
    Friend WithEvents palMenu As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents btnProfilePic As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents lblAppManagement As Label
    Friend WithEvents btnMenuNav As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents lblDashboard As Label
    Friend WithEvents lblSettings As Label
    Friend WithEvents lblUserManagemen As Label
    Friend WithEvents lblReport As Label
    Friend WithEvents palShow As Panel
End Class
