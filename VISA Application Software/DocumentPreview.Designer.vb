<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DocumentPreview
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DocumentPreview))
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblVisaType = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnCopyPreviousPass = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCopOfPreVisas = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCharaterRef = New Guna.UI2.WinForms.Guna2Button()
        Me.btnPoliceCert = New Guna.UI2.WinForms.Guna2Button()
        Me.btnMedicalCert = New Guna.UI2.WinForms.Guna2Button()
        Me.btnProfOfFinRes = New Guna.UI2.WinForms.Guna2Button()
        Me.btnIncomeTaxReport = New Guna.UI2.WinForms.Guna2Button()
        Me.btnBankAccDet = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonAsColor = New Guna.UI2.WinForms.Guna2Button()
        Me.lblDocuments = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblPreview = New System.Windows.Forms.Label()
        Me.pnlPreview = New System.Windows.Forms.Panel()
        Me.AxAcroPDF1 = New AxAcroPDFLib.AxAcroPDF()
        Me.Guna2Button11 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnlPreview.SuspendLayout()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Button1
        '
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2Button1.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(-4, -4)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.PressedColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.PressedDepth = 0
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(940, 65)
        Me.Guna2Button1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblStatus)
        Me.Panel1.Controls.Add(Me.lblVisaType)
        Me.Panel1.Controls.Add(Me.lblName)
        Me.Panel1.Controls.Add(Me.btnCopyPreviousPass)
        Me.Panel1.Controls.Add(Me.btnCopOfPreVisas)
        Me.Panel1.Controls.Add(Me.btnCharaterRef)
        Me.Panel1.Controls.Add(Me.btnPoliceCert)
        Me.Panel1.Controls.Add(Me.btnMedicalCert)
        Me.Panel1.Controls.Add(Me.btnProfOfFinRes)
        Me.Panel1.Controls.Add(Me.btnIncomeTaxReport)
        Me.Panel1.Controls.Add(Me.btnBankAccDet)
        Me.Panel1.Controls.Add(Me.ButtonAsColor)
        Me.Panel1.Controls.Add(Me.lblDocuments)
        Me.Panel1.Location = New System.Drawing.Point(-4, 52)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(339, 519)
        Me.Panel1.TabIndex = 1
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.BackColor = System.Drawing.Color.Gainsboro
        Me.lblStatus.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.Black
        Me.lblStatus.Location = New System.Drawing.Point(17, 451)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(69, 28)
        Me.lblStatus.TabIndex = 13
        Me.lblStatus.Text = "Status:"
        '
        'lblVisaType
        '
        Me.lblVisaType.AutoSize = True
        Me.lblVisaType.BackColor = System.Drawing.Color.Gainsboro
        Me.lblVisaType.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVisaType.ForeColor = System.Drawing.Color.Black
        Me.lblVisaType.Location = New System.Drawing.Point(17, 408)
        Me.lblVisaType.Name = "lblVisaType"
        Me.lblVisaType.Size = New System.Drawing.Size(95, 28)
        Me.lblVisaType.TabIndex = 12
        Me.lblVisaType.Text = "Visa Type:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Gainsboro
        Me.lblName.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.Black
        Me.lblName.Location = New System.Drawing.Point(17, 369)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(66, 28)
        Me.lblName.TabIndex = 11
        Me.lblName.Text = "Name:"
        '
        'btnCopyPreviousPass
        '
        Me.btnCopyPreviousPass.BackColor = System.Drawing.Color.Transparent
        Me.btnCopyPreviousPass.BorderColor = System.Drawing.Color.Transparent
        Me.btnCopyPreviousPass.BorderRadius = 10
        Me.btnCopyPreviousPass.CheckedState.Parent = Me.btnCopyPreviousPass
        Me.btnCopyPreviousPass.CustomImages.Parent = Me.btnCopyPreviousPass
        Me.btnCopyPreviousPass.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCopyPreviousPass.ForeColor = System.Drawing.Color.White
        Me.btnCopyPreviousPass.HoverState.FillColor = System.Drawing.Color.Fuchsia
        Me.btnCopyPreviousPass.HoverState.Parent = Me.btnCopyPreviousPass
        Me.btnCopyPreviousPass.Location = New System.Drawing.Point(222, 250)
        Me.btnCopyPreviousPass.Name = "btnCopyPreviousPass"
        Me.btnCopyPreviousPass.ShadowDecoration.Parent = Me.btnCopyPreviousPass
        Me.btnCopyPreviousPass.Size = New System.Drawing.Size(94, 78)
        Me.btnCopyPreviousPass.TabIndex = 8
        Me.btnCopyPreviousPass.Text = "Copies of Previous Passports"
        Me.btnCopyPreviousPass.UseTransparentBackground = True
        '
        'btnCopOfPreVisas
        '
        Me.btnCopOfPreVisas.BackColor = System.Drawing.Color.Transparent
        Me.btnCopOfPreVisas.BorderColor = System.Drawing.Color.Transparent
        Me.btnCopOfPreVisas.BorderRadius = 10
        Me.btnCopOfPreVisas.CheckedState.Parent = Me.btnCopOfPreVisas
        Me.btnCopOfPreVisas.CustomImages.Parent = Me.btnCopOfPreVisas
        Me.btnCopOfPreVisas.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCopOfPreVisas.ForeColor = System.Drawing.Color.White
        Me.btnCopOfPreVisas.HoverState.FillColor = System.Drawing.Color.Fuchsia
        Me.btnCopOfPreVisas.HoverState.Parent = Me.btnCopOfPreVisas
        Me.btnCopOfPreVisas.Location = New System.Drawing.Point(22, 250)
        Me.btnCopOfPreVisas.Name = "btnCopOfPreVisas"
        Me.btnCopOfPreVisas.ShadowDecoration.Parent = Me.btnCopOfPreVisas
        Me.btnCopOfPreVisas.Size = New System.Drawing.Size(94, 78)
        Me.btnCopOfPreVisas.TabIndex = 7
        Me.btnCopOfPreVisas.Text = "Copies of previous visas"
        Me.btnCopOfPreVisas.UseTransparentBackground = True
        '
        'btnCharaterRef
        '
        Me.btnCharaterRef.BackColor = System.Drawing.Color.Transparent
        Me.btnCharaterRef.BorderColor = System.Drawing.Color.Transparent
        Me.btnCharaterRef.BorderRadius = 10
        Me.btnCharaterRef.CheckedState.Parent = Me.btnCharaterRef
        Me.btnCharaterRef.CustomImages.Parent = Me.btnCharaterRef
        Me.btnCharaterRef.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCharaterRef.ForeColor = System.Drawing.Color.White
        Me.btnCharaterRef.HoverState.Parent = Me.btnCharaterRef
        Me.btnCharaterRef.Location = New System.Drawing.Point(222, 156)
        Me.btnCharaterRef.Name = "btnCharaterRef"
        Me.btnCharaterRef.ShadowDecoration.Parent = Me.btnCharaterRef
        Me.btnCharaterRef.Size = New System.Drawing.Size(94, 78)
        Me.btnCharaterRef.TabIndex = 6
        Me.btnCharaterRef.Text = "Character Reference"
        Me.btnCharaterRef.UseTransparentBackground = True
        '
        'btnPoliceCert
        '
        Me.btnPoliceCert.BackColor = System.Drawing.Color.Transparent
        Me.btnPoliceCert.BorderColor = System.Drawing.Color.Transparent
        Me.btnPoliceCert.BorderRadius = 10
        Me.btnPoliceCert.CheckedState.Parent = Me.btnPoliceCert
        Me.btnPoliceCert.CustomImages.Parent = Me.btnPoliceCert
        Me.btnPoliceCert.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnPoliceCert.ForeColor = System.Drawing.Color.White
        Me.btnPoliceCert.HoverState.FillColor = System.Drawing.Color.Fuchsia
        Me.btnPoliceCert.HoverState.Parent = Me.btnPoliceCert
        Me.btnPoliceCert.Location = New System.Drawing.Point(122, 156)
        Me.btnPoliceCert.Name = "btnPoliceCert"
        Me.btnPoliceCert.ShadowDecoration.Parent = Me.btnPoliceCert
        Me.btnPoliceCert.Size = New System.Drawing.Size(94, 78)
        Me.btnPoliceCert.TabIndex = 5
        Me.btnPoliceCert.Text = "Police Certificate"
        Me.btnPoliceCert.UseTransparentBackground = True
        '
        'btnMedicalCert
        '
        Me.btnMedicalCert.BackColor = System.Drawing.Color.Transparent
        Me.btnMedicalCert.BorderColor = System.Drawing.Color.Transparent
        Me.btnMedicalCert.BorderRadius = 10
        Me.btnMedicalCert.CheckedState.Parent = Me.btnMedicalCert
        Me.btnMedicalCert.CustomImages.Parent = Me.btnMedicalCert
        Me.btnMedicalCert.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnMedicalCert.ForeColor = System.Drawing.Color.White
        Me.btnMedicalCert.HoverState.FillColor = System.Drawing.Color.Fuchsia
        Me.btnMedicalCert.HoverState.Parent = Me.btnMedicalCert
        Me.btnMedicalCert.Location = New System.Drawing.Point(22, 156)
        Me.btnMedicalCert.Name = "btnMedicalCert"
        Me.btnMedicalCert.ShadowDecoration.Parent = Me.btnMedicalCert
        Me.btnMedicalCert.Size = New System.Drawing.Size(94, 78)
        Me.btnMedicalCert.TabIndex = 4
        Me.btnMedicalCert.Text = "Medical Certificate"
        Me.btnMedicalCert.UseTransparentBackground = True
        '
        'btnProfOfFinRes
        '
        Me.btnProfOfFinRes.BackColor = System.Drawing.Color.Transparent
        Me.btnProfOfFinRes.BorderColor = System.Drawing.Color.Transparent
        Me.btnProfOfFinRes.BorderRadius = 10
        Me.btnProfOfFinRes.CheckedState.Parent = Me.btnProfOfFinRes
        Me.btnProfOfFinRes.CustomImages.Parent = Me.btnProfOfFinRes
        Me.btnProfOfFinRes.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnProfOfFinRes.ForeColor = System.Drawing.Color.White
        Me.btnProfOfFinRes.HoverState.Parent = Me.btnProfOfFinRes
        Me.btnProfOfFinRes.Location = New System.Drawing.Point(222, 62)
        Me.btnProfOfFinRes.Name = "btnProfOfFinRes"
        Me.btnProfOfFinRes.ShadowDecoration.Parent = Me.btnProfOfFinRes
        Me.btnProfOfFinRes.Size = New System.Drawing.Size(94, 78)
        Me.btnProfOfFinRes.TabIndex = 3
        Me.btnProfOfFinRes.Text = "Proof Of Financial Resource"
        Me.btnProfOfFinRes.UseTransparentBackground = True
        '
        'btnIncomeTaxReport
        '
        Me.btnIncomeTaxReport.BackColor = System.Drawing.Color.Transparent
        Me.btnIncomeTaxReport.BorderColor = System.Drawing.Color.Transparent
        Me.btnIncomeTaxReport.BorderRadius = 10
        Me.btnIncomeTaxReport.CheckedState.Parent = Me.btnIncomeTaxReport
        Me.btnIncomeTaxReport.CustomImages.Parent = Me.btnIncomeTaxReport
        Me.btnIncomeTaxReport.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnIncomeTaxReport.ForeColor = System.Drawing.Color.White
        Me.btnIncomeTaxReport.HoverState.FillColor = System.Drawing.Color.Fuchsia
        Me.btnIncomeTaxReport.HoverState.Parent = Me.btnIncomeTaxReport
        Me.btnIncomeTaxReport.Location = New System.Drawing.Point(122, 62)
        Me.btnIncomeTaxReport.Name = "btnIncomeTaxReport"
        Me.btnIncomeTaxReport.ShadowDecoration.Parent = Me.btnIncomeTaxReport
        Me.btnIncomeTaxReport.Size = New System.Drawing.Size(94, 78)
        Me.btnIncomeTaxReport.TabIndex = 2
        Me.btnIncomeTaxReport.Text = "Income Tax Report"
        Me.btnIncomeTaxReport.UseTransparentBackground = True
        '
        'btnBankAccDet
        '
        Me.btnBankAccDet.BackColor = System.Drawing.Color.Transparent
        Me.btnBankAccDet.BorderColor = System.Drawing.Color.Transparent
        Me.btnBankAccDet.BorderRadius = 10
        Me.btnBankAccDet.CheckedState.Parent = Me.btnBankAccDet
        Me.btnBankAccDet.CustomImages.Parent = Me.btnBankAccDet
        Me.btnBankAccDet.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnBankAccDet.ForeColor = System.Drawing.Color.White
        Me.btnBankAccDet.HoverState.FillColor = System.Drawing.Color.Fuchsia
        Me.btnBankAccDet.HoverState.Parent = Me.btnBankAccDet
        Me.btnBankAccDet.Location = New System.Drawing.Point(22, 62)
        Me.btnBankAccDet.Name = "btnBankAccDet"
        Me.btnBankAccDet.ShadowDecoration.Parent = Me.btnBankAccDet
        Me.btnBankAccDet.Size = New System.Drawing.Size(94, 78)
        Me.btnBankAccDet.TabIndex = 1
        Me.btnBankAccDet.Text = "Bank Account Details"
        Me.btnBankAccDet.UseTransparentBackground = True
        '
        'ButtonAsColor
        '
        Me.ButtonAsColor.BackColor = System.Drawing.Color.Transparent
        Me.ButtonAsColor.BorderColor = System.Drawing.Color.Transparent
        Me.ButtonAsColor.BorderRadius = 5
        Me.ButtonAsColor.CheckedState.Parent = Me.ButtonAsColor
        Me.ButtonAsColor.CustomImages.Parent = Me.ButtonAsColor
        Me.ButtonAsColor.FillColor = System.Drawing.Color.Gainsboro
        Me.ButtonAsColor.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonAsColor.ForeColor = System.Drawing.Color.White
        Me.ButtonAsColor.HoverState.FillColor = System.Drawing.Color.Gainsboro
        Me.ButtonAsColor.HoverState.ForeColor = System.Drawing.Color.Gainsboro
        Me.ButtonAsColor.HoverState.Parent = Me.ButtonAsColor
        Me.ButtonAsColor.Location = New System.Drawing.Point(12, 42)
        Me.ButtonAsColor.Name = "ButtonAsColor"
        Me.ButtonAsColor.PressedColor = System.Drawing.Color.Transparent
        Me.ButtonAsColor.PressedDepth = 0
        Me.ButtonAsColor.ShadowDecoration.Parent = Me.ButtonAsColor
        Me.ButtonAsColor.Size = New System.Drawing.Size(314, 474)
        Me.ButtonAsColor.TabIndex = 0
        Me.ButtonAsColor.UseTransparentBackground = True
        '
        'lblDocuments
        '
        Me.lblDocuments.AutoSize = True
        Me.lblDocuments.BackColor = System.Drawing.Color.Transparent
        Me.lblDocuments.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocuments.ForeColor = System.Drawing.Color.White
        Me.lblDocuments.Location = New System.Drawing.Point(120, 14)
        Me.lblDocuments.Name = "lblDocuments"
        Me.lblDocuments.Size = New System.Drawing.Size(107, 28)
        Me.lblDocuments.TabIndex = 10
        Me.lblDocuments.Text = "Documents"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel2.Controls.Add(Me.lblPreview)
        Me.Panel2.Controls.Add(Me.pnlPreview)
        Me.Panel2.Controls.Add(Me.Guna2Button11)
        Me.Panel2.Location = New System.Drawing.Point(332, 52)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(592, 519)
        Me.Panel2.TabIndex = 2
        '
        'lblPreview
        '
        Me.lblPreview.AutoSize = True
        Me.lblPreview.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.lblPreview.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreview.ForeColor = System.Drawing.Color.White
        Me.lblPreview.Location = New System.Drawing.Point(233, 14)
        Me.lblPreview.Name = "lblPreview"
        Me.lblPreview.Size = New System.Drawing.Size(76, 28)
        Me.lblPreview.TabIndex = 11
        Me.lblPreview.Text = "Preview"
        '
        'pnlPreview
        '
        Me.pnlPreview.Controls.Add(Me.AxAcroPDF1)
        Me.pnlPreview.Location = New System.Drawing.Point(3, 42)
        Me.pnlPreview.Name = "pnlPreview"
        Me.pnlPreview.Size = New System.Drawing.Size(589, 477)
        Me.pnlPreview.TabIndex = 2
        '
        'AxAcroPDF1
        '
        Me.AxAcroPDF1.Enabled = True
        Me.AxAcroPDF1.Location = New System.Drawing.Point(17, 20)
        Me.AxAcroPDF1.Name = "AxAcroPDF1"
        Me.AxAcroPDF1.OcxState = CType(resources.GetObject("AxAcroPDF1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDF1.Size = New System.Drawing.Size(559, 445)
        Me.AxAcroPDF1.TabIndex = 3
        '
        'Guna2Button11
        '
        Me.Guna2Button11.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button11.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Button11.BorderRadius = 5
        Me.Guna2Button11.CheckedState.Parent = Me.Guna2Button11
        Me.Guna2Button11.CustomImages.Parent = Me.Guna2Button11
        Me.Guna2Button11.FillColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Guna2Button11.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button11.ForeColor = System.Drawing.Color.White
        Me.Guna2Button11.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Guna2Button11.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Guna2Button11.HoverState.Parent = Me.Guna2Button11
        Me.Guna2Button11.Location = New System.Drawing.Point(-4, 3)
        Me.Guna2Button11.Name = "Guna2Button11"
        Me.Guna2Button11.PressedColor = System.Drawing.Color.Transparent
        Me.Guna2Button11.PressedDepth = 0
        Me.Guna2Button11.ShadowDecoration.Parent = Me.Guna2Button11
        Me.Guna2Button11.Size = New System.Drawing.Size(608, 39)
        Me.Guna2Button11.TabIndex = 1
        Me.Guna2Button11.UseTransparentBackground = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(408, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(175, 28)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Documents Preview"
        '
        'DocumentPreview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(923, 571)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(939, 610)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(939, 610)
        Me.Name = "DocumentPreview"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DocumentPreview"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.pnlPreview.ResumeLayout(False)
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ButtonAsColor As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCopyPreviousPass As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCopOfPreVisas As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCharaterRef As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnPoliceCert As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnMedicalCert As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnProfOfFinRes As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnIncomeTaxReport As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnBankAccDet As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblDocuments As Label
    Friend WithEvents pnlPreview As Panel
    Friend WithEvents Guna2Button11 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblPreview As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblVisaType As Label
    Friend WithEvents lblName As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF
End Class
