<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reportAdmin
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.reportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New VISA_Application_Software.DataSet1()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.reportTableAdapter = New VISA_Application_Software.DataSet1TableAdapters.reportTableAdapter()
        Me.VisaappDataSet = New VISA_Application_Software.visaappDataSet()
        Me.VisaappDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.reportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VisaappDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VisaappDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'reportBindingSource
        '
        Me.reportBindingSource.DataMember = "report"
        Me.reportBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.DocumentMapWidth = 56
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.reportBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "VISA_Application_Software.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(4)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1080, 641)
        Me.ReportViewer1.TabIndex = 0
        '
        'DataSet1BindingSource
        '
        Me.DataSet1BindingSource.DataSource = Me.DataSet1
        Me.DataSet1BindingSource.Position = 0
        '
        'reportTableAdapter
        '
        Me.reportTableAdapter.ClearBeforeFill = True
        '
        'VisaappDataSet
        '
        Me.VisaappDataSet.DataSetName = "visaappDataSet"
        Me.VisaappDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VisaappDataSetBindingSource
        '
        Me.VisaappDataSetBindingSource.DataSource = Me.VisaappDataSet
        Me.VisaappDataSetBindingSource.Position = 0
        '
        'reportAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1080, 641)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "reportAdmin"
        Me.Text = "reportAdmin"
        CType(Me.reportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VisaappDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VisaappDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DataSet1BindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents VisaappDataSetBindingSource As BindingSource
    Friend WithEvents VisaappDataSet As visaappDataSet
    Friend WithEvents reportBindingSource As BindingSource
    Friend WithEvents reportTableAdapter As DataSet1TableAdapters.reportTableAdapter
End Class
