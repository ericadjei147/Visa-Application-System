<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContactUs
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
        Me.lblNotification = New System.Windows.Forms.Label()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.txtBody = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnContactSend = New Guna.UI2.WinForms.Guna2Button()
        Me.txtSubject = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFrom = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MyConColor = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNotification
        '
        Me.lblNotification.AutoSize = True
        Me.lblNotification.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.lblNotification.Font = New System.Drawing.Font("Roboto", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotification.ForeColor = System.Drawing.Color.White
        Me.lblNotification.Location = New System.Drawing.Point(78, 35)
        Me.lblNotification.Name = "lblNotification"
        Me.lblNotification.Size = New System.Drawing.Size(158, 35)
        Me.lblNotification.TabIndex = 5
        Me.lblNotification.Text = "Contact Us"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(-3, 22)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.PressedColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.PressedDepth = 0
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(965, 69)
        Me.Guna2Button1.TabIndex = 3
        Me.Guna2Button1.UseTransparentBackground = True
        '
        'txtBody
        '
        Me.txtBody.BackColor = System.Drawing.SystemColors.Control
        Me.txtBody.BorderRadius = 20
        Me.txtBody.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBody.DefaultText = ""
        Me.txtBody.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBody.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBody.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBody.DisabledState.Parent = Me.txtBody
        Me.txtBody.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBody.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBody.FocusedState.Parent = Me.txtBody
        Me.txtBody.ForeColor = System.Drawing.Color.Black
        Me.txtBody.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBody.HoverState.Parent = Me.txtBody
        Me.txtBody.Location = New System.Drawing.Point(195, 225)
        Me.txtBody.Multiline = True
        Me.txtBody.Name = "txtBody"
        Me.txtBody.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBody.PlaceholderText = "Message..."
        Me.txtBody.SelectedText = ""
        Me.txtBody.ShadowDecoration.Parent = Me.txtBody
        Me.txtBody.Size = New System.Drawing.Size(556, 145)
        Me.txtBody.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnContactSend)
        Me.Panel1.Controls.Add(Me.txtSubject)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtFrom)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtTo)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtBody)
        Me.Panel1.Controls.Add(Me.MyConColor)
        Me.Panel1.Location = New System.Drawing.Point(-3, 83)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(954, 469)
        Me.Panel1.TabIndex = 8
        '
        'btnContactSend
        '
        Me.btnContactSend.BackColor = System.Drawing.SystemColors.Control
        Me.btnContactSend.BorderRadius = 15
        Me.btnContactSend.CheckedState.Parent = Me.btnContactSend
        Me.btnContactSend.CustomImages.Parent = Me.btnContactSend
        Me.btnContactSend.FillColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnContactSend.Font = New System.Drawing.Font("Roboto Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContactSend.ForeColor = System.Drawing.Color.White
        Me.btnContactSend.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnContactSend.HoverState.Parent = Me.btnContactSend
        Me.btnContactSend.Location = New System.Drawing.Point(781, 277)
        Me.btnContactSend.Name = "btnContactSend"
        Me.btnContactSend.ShadowDecoration.Parent = Me.btnContactSend
        Me.btnContactSend.Size = New System.Drawing.Size(88, 45)
        Me.btnContactSend.TabIndex = 15
        Me.btnContactSend.Text = "Send"
        '
        'txtSubject
        '
        Me.txtSubject.BackColor = System.Drawing.SystemColors.Control
        Me.txtSubject.BorderRadius = 10
        Me.txtSubject.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSubject.DefaultText = ""
        Me.txtSubject.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSubject.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSubject.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSubject.DisabledState.Parent = Me.txtSubject
        Me.txtSubject.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSubject.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSubject.FocusedState.Parent = Me.txtSubject
        Me.txtSubject.ForeColor = System.Drawing.Color.Black
        Me.txtSubject.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSubject.HoverState.Parent = Me.txtSubject
        Me.txtSubject.Location = New System.Drawing.Point(264, 159)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSubject.PlaceholderText = ""
        Me.txtSubject.SelectedText = ""
        Me.txtSubject.ShadowDecoration.Parent = Me.txtSubject
        Me.txtSubject.Size = New System.Drawing.Size(428, 39)
        Me.txtSubject.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(177, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 25)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Subject"
        '
        'txtFrom
        '
        Me.txtFrom.BackColor = System.Drawing.SystemColors.Control
        Me.txtFrom.BorderRadius = 10
        Me.txtFrom.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFrom.DefaultText = ""
        Me.txtFrom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFrom.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFrom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFrom.DisabledState.Parent = Me.txtFrom
        Me.txtFrom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFrom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFrom.FocusedState.Parent = Me.txtFrom
        Me.txtFrom.ForeColor = System.Drawing.Color.Black
        Me.txtFrom.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFrom.HoverState.Parent = Me.txtFrom
        Me.txtFrom.Location = New System.Drawing.Point(264, 97)
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFrom.PlaceholderText = ""
        Me.txtFrom.SelectedText = ""
        Me.txtFrom.ShadowDecoration.Parent = Me.txtFrom
        Me.txtFrom.Size = New System.Drawing.Size(428, 39)
        Me.txtFrom.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(198, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 25)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "From"
        '
        'txtTo
        '
        Me.txtTo.BackColor = System.Drawing.SystemColors.Control
        Me.txtTo.BorderRadius = 10
        Me.txtTo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTo.DefaultText = "techwiiki01@gmail.com"
        Me.txtTo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtTo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtTo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTo.DisabledState.Parent = Me.txtTo
        Me.txtTo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTo.Enabled = False
        Me.txtTo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTo.FocusedState.Parent = Me.txtTo
        Me.txtTo.ForeColor = System.Drawing.Color.Black
        Me.txtTo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTo.HoverState.Parent = Me.txtTo
        Me.txtTo.Location = New System.Drawing.Point(264, 32)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTo.PlaceholderText = ""
        Me.txtTo.SelectedText = ""
        Me.txtTo.ShadowDecoration.Parent = Me.txtTo
        Me.txtTo.Size = New System.Drawing.Size(428, 39)
        Me.txtTo.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(223, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "To"
        '
        'MyConColor
        '
        Me.MyConColor.BackColor = System.Drawing.Color.Transparent
        Me.MyConColor.BorderRadius = 15
        Me.MyConColor.CheckedState.Parent = Me.MyConColor
        Me.MyConColor.CustomImages.Parent = Me.MyConColor
        Me.MyConColor.FillColor = System.Drawing.SystemColors.Control
        Me.MyConColor.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MyConColor.ForeColor = System.Drawing.Color.White
        Me.MyConColor.HoverState.BorderColor = System.Drawing.SystemColors.Control
        Me.MyConColor.HoverState.FillColor = System.Drawing.SystemColors.Control
        Me.MyConColor.HoverState.Parent = Me.MyConColor
        Me.MyConColor.Location = New System.Drawing.Point(16, 10)
        Me.MyConColor.Name = "MyConColor"
        Me.MyConColor.PressedColor = System.Drawing.Color.Transparent
        Me.MyConColor.PressedDepth = 0
        Me.MyConColor.ShadowDecoration.Parent = Me.MyConColor
        Me.MyConColor.Size = New System.Drawing.Size(923, 449)
        Me.MyConColor.TabIndex = 9
        Me.MyConColor.UseTransparentBackground = True
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox1.Image = Global.VISA_Application_Software.My.Resources.Resources.email
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(39, 31)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.ShadowDecoration.Parent = Me.Guna2CirclePictureBox1
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(39, 40)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2CirclePictureBox1.TabIndex = 7
        Me.Guna2CirclePictureBox1.TabStop = False
        Me.Guna2CirclePictureBox1.UseTransparentBackground = True
        '
        'ContactUs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(947, 552)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Controls.Add(Me.lblNotification)
        Me.Controls.Add(Me.Guna2Button1)
        Me.MaximizeBox = False
        Me.Name = "ContactUs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ContactUs"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents lblNotification As Label
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtBody As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSubject As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFrom As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnContactSend As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents MyConColor As Guna.UI2.WinForms.Guna2Button
End Class
