<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreen1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashScreen1))
        Me.Lbl_mgs = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.percent = New System.Windows.Forms.Label()
        Me.Label_Loading = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Lbl_mgs
        '
        Me.Lbl_mgs.AutoSize = True
        Me.Lbl_mgs.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_mgs.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_mgs.ForeColor = System.Drawing.Color.Red
        Me.Lbl_mgs.Location = New System.Drawing.Point(638, 395)
        Me.Lbl_mgs.Name = "Lbl_mgs"
        Me.Lbl_mgs.Size = New System.Drawing.Size(89, 22)
        Me.Lbl_mgs.TabIndex = 7
        Me.Lbl_mgs.Text = "Processing. . ."
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(548, 375)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(266, 17)
        Me.ProgressBar1.TabIndex = 6
        '
        'percent
        '
        Me.percent.AutoSize = True
        Me.percent.BackColor = System.Drawing.Color.Transparent
        Me.percent.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.percent.Location = New System.Drawing.Point(709, 348)
        Me.percent.Name = "percent"
        Me.percent.Size = New System.Drawing.Size(34, 23)
        Me.percent.TabIndex = 5
        Me.percent.Text = "000"
        '
        'Label_Loading
        '
        Me.Label_Loading.AutoSize = True
        Me.Label_Loading.BackColor = System.Drawing.Color.Transparent
        Me.Label_Loading.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Loading.Location = New System.Drawing.Point(638, 347)
        Me.Label_Loading.Name = "Label_Loading"
        Me.Label_Loading.Size = New System.Drawing.Size(77, 23)
        Me.Label_Loading.TabIndex = 4
        Me.Label_Loading.Text = "Loading. . ."
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'SplashScreen1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(839, 515)
        Me.ControlBox = False
        Me.Controls.Add(Me.Lbl_mgs)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.percent)
        Me.Controls.Add(Me.Label_Loading)
        Me.Name = "SplashScreen1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Visa Application"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_mgs As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents percent As Label
    Friend WithEvents Label_Loading As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
End Class
