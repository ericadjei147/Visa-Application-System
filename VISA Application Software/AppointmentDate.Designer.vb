<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AppointmentDate
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
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.flpTime = New System.Windows.Forms.FlowLayoutPanel()
        Me.dtpAppointDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Guna2VSeparator1 = New Guna.UI2.WinForms.Guna2VSeparator()
        Me.lblSelectedDateTimePrompt = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BorderRadius = 15
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(-5, -4)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.PressedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2Button1.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2Button1.ShadowDecoration.Depth = 0
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(931, 123)
        Me.Guna2Button1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Poppins SemiBold", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(199, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(524, 70)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "VISA APPOINTMENT DATE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Poppins", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(253, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(423, 48)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Visa Interview date Selection"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(263, 145)
        Me.Label3.MaximumSize = New System.Drawing.Size(400, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(399, 66)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Kindly note that you can only select working days for your VISA Interview. Also, " &
    "holidays and fully booked days are exempted. Our period of work is between"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.flpTime)
        Me.Panel1.Controls.Add(Me.dtpAppointDate)
        Me.Panel1.Controls.Add(Me.Guna2VSeparator1)
        Me.Panel1.Location = New System.Drawing.Point(141, 210)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(636, 263)
        Me.Panel1.TabIndex = 4
        '
        'flpTime
        '
        Me.flpTime.Location = New System.Drawing.Point(346, 25)
        Me.flpTime.Name = "flpTime"
        Me.flpTime.Size = New System.Drawing.Size(277, 188)
        Me.flpTime.TabIndex = 5
        Me.flpTime.Visible = False
        '
        'dtpAppointDate
        '
        Me.dtpAppointDate.BorderRadius = 10
        Me.dtpAppointDate.CheckedState.Parent = Me.dtpAppointDate
        Me.dtpAppointDate.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpAppointDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpAppointDate.HoverState.Parent = Me.dtpAppointDate
        Me.dtpAppointDate.Location = New System.Drawing.Point(37, 23)
        Me.dtpAppointDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpAppointDate.MinDate = New Date(2024, 9, 1, 10, 51, 0, 0)
        Me.dtpAppointDate.Name = "dtpAppointDate"
        Me.dtpAppointDate.ShadowDecoration.Parent = Me.dtpAppointDate
        Me.dtpAppointDate.Size = New System.Drawing.Size(256, 36)
        Me.dtpAppointDate.TabIndex = 0
        Me.dtpAppointDate.Value = New Date(2024, 9, 1, 10, 51, 0, 0)
        '
        'Guna2VSeparator1
        '
        Me.Guna2VSeparator1.Location = New System.Drawing.Point(330, 25)
        Me.Guna2VSeparator1.Name = "Guna2VSeparator1"
        Me.Guna2VSeparator1.Size = New System.Drawing.Size(10, 232)
        Me.Guna2VSeparator1.TabIndex = 1
        '
        'lblSelectedDateTimePrompt
        '
        Me.lblSelectedDateTimePrompt.AutoSize = True
        Me.lblSelectedDateTimePrompt.BackColor = System.Drawing.Color.Transparent
        Me.lblSelectedDateTimePrompt.Font = New System.Drawing.Font("Poppins SemiBold", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectedDateTimePrompt.Location = New System.Drawing.Point(286, 476)
        Me.lblSelectedDateTimePrompt.MaximumSize = New System.Drawing.Size(400, 0)
        Me.lblSelectedDateTimePrompt.Name = "lblSelectedDateTimePrompt"
        Me.lblSelectedDateTimePrompt.Size = New System.Drawing.Size(148, 34)
        Me.lblSelectedDateTimePrompt.TabIndex = 5
        Me.lblSelectedDateTimePrompt.Text = "Date selected"
        Me.lblSelectedDateTimePrompt.Visible = False
        '
        'AppointmentDate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(923, 588)
        Me.Controls.Add(Me.lblSelectedDateTimePrompt)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "AppointmentDate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AppointmentDate"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblSelectedDateTimePrompt As Label
    Friend WithEvents Guna2VSeparator1 As Guna.UI2.WinForms.Guna2VSeparator
    Friend WithEvents flpTime As FlowLayoutPanel
    Friend WithEvents dtpAppointDate As Guna.UI2.WinForms.Guna2DateTimePicker
End Class
