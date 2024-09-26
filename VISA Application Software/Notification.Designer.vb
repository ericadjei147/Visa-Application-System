<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Notification
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
        Me.HeaderColor = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.palMain = New Guna.UI.WinForms.GunaElipsePanel()
        Me.lblNotification = New System.Windows.Forms.Label()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HeaderColor
        '
        Me.HeaderColor.BackColor = System.Drawing.Color.Transparent
        Me.HeaderColor.CheckedState.Parent = Me.HeaderColor
        Me.HeaderColor.CustomImages.Parent = Me.HeaderColor
        Me.HeaderColor.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.HeaderColor.ForeColor = System.Drawing.Color.White
        Me.HeaderColor.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HeaderColor.HoverState.Parent = Me.HeaderColor
        Me.HeaderColor.Location = New System.Drawing.Point(-6, 26)
        Me.HeaderColor.Name = "HeaderColor"
        Me.HeaderColor.PressedColor = System.Drawing.Color.Transparent
        Me.HeaderColor.PressedDepth = 0
        Me.HeaderColor.ShadowDecoration.Parent = Me.HeaderColor
        Me.HeaderColor.Size = New System.Drawing.Size(777, 69)
        Me.HeaderColor.TabIndex = 0
        Me.HeaderColor.UseTransparentBackground = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.palMain)
        Me.Panel1.Location = New System.Drawing.Point(-6, 84)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(777, 444)
        Me.Panel1.TabIndex = 3
        '
        'palMain
        '
        Me.palMain.AutoScrollMargin = New System.Drawing.Size(0, 20)
        Me.palMain.BackColor = System.Drawing.Color.Transparent
        Me.palMain.BaseColor = System.Drawing.SystemColors.Control
        Me.palMain.Location = New System.Drawing.Point(15, 17)
        Me.palMain.Name = "palMain"
        Me.palMain.Radius = 10
        Me.palMain.Size = New System.Drawing.Size(747, 412)
        Me.palMain.TabIndex = 1
        '
        'lblNotification
        '
        Me.lblNotification.AutoSize = True
        Me.lblNotification.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblNotification.Font = New System.Drawing.Font("Roboto", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotification.ForeColor = System.Drawing.Color.White
        Me.lblNotification.Location = New System.Drawing.Point(71, 45)
        Me.lblNotification.Name = "lblNotification"
        Me.lblNotification.Size = New System.Drawing.Size(168, 35)
        Me.lblNotification.TabIndex = 1
        Me.lblNotification.Text = "Notification"
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox1.Image = Global.VISA_Application_Software.My.Resources.Resources.notification_bell
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(39, 43)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.ShadowDecoration.Parent = Me.Guna2CirclePictureBox1
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(39, 40)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2CirclePictureBox1.TabIndex = 2
        Me.Guna2CirclePictureBox1.TabStop = False
        Me.Guna2CirclePictureBox1.UseTransparentBackground = True
        '
        'Notification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(768, 525)
        Me.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Controls.Add(Me.lblNotification)
        Me.Controls.Add(Me.HeaderColor)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Notification"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Notification"
        Me.Panel1.ResumeLayout(False)
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HeaderColor As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblNotification As Label
    Friend WithEvents palMain As Guna.UI.WinForms.GunaElipsePanel
End Class
