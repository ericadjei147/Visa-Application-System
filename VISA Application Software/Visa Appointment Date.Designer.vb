<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVisaDateAppoint
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblSelectedDateTimePrompt = New System.Windows.Forms.Label()
        Me.flpTime = New System.Windows.Forms.FlowLayoutPanel()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblSelectedDateTimePrompt)
        Me.Panel1.Controls.Add(Me.flpTime)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(80, 44)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(564, 442)
        Me.Panel1.TabIndex = 0
        '
        'lblSelectedDateTimePrompt
        '
        Me.lblSelectedDateTimePrompt.AutoSize = True
        Me.lblSelectedDateTimePrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectedDateTimePrompt.Location = New System.Drawing.Point(59, 370)
        Me.lblSelectedDateTimePrompt.Name = "lblSelectedDateTimePrompt"
        Me.lblSelectedDateTimePrompt.Size = New System.Drawing.Size(296, 25)
        Me.lblSelectedDateTimePrompt.TabIndex = 4
        Me.lblSelectedDateTimePrompt.Text = "VISA Interview Data Selection"
        Me.lblSelectedDateTimePrompt.Visible = False
        '
        'flpTime
        '
        Me.flpTime.Location = New System.Drawing.Point(145, 170)
        Me.flpTime.Name = "flpTime"
        Me.flpTime.Size = New System.Drawing.Size(277, 186)
        Me.flpTime.TabIndex = 3
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(121, 144)
        Me.DateTimePicker1.MaxDate = New Date(2024, 12, 25, 23, 59, 59, 0)
        Me.DateTimePicker1.MinDate = New Date(2024, 7, 4, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(278, 20)
        Me.DateTimePicker1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(102, 60)
        Me.Label2.MaximumSize = New System.Drawing.Size(400, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(398, 48)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kindly note that you can only select working days for your VISA Interview. Also, " &
    "holidays and fully booked days are exempted. Our period of work is between "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(117, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(325, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "VISA Interview Data Selection"
        '
        'frmVisaDateAppoint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 562)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmVisaDateAppoint"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents flpTime As FlowLayoutPanel
    Friend WithEvents lblSelectedDateTimePrompt As Label
End Class
