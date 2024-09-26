<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashAdmin
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.palShow = New System.Windows.Forms.Panel()
        Me.GunaElipsePanel6 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.lblAppTotal = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.GunaElipsePanel1 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GunaElipsePanel5 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.lblRejected = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GunaElipsePanel4 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.lblApproved = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GunaElipsePanel3 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.lblPending = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GunaElipsePanel2 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.palShow.SuspendLayout()
        Me.GunaElipsePanel6.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaElipsePanel1.SuspendLayout()
        Me.GunaElipsePanel5.SuspendLayout()
        Me.GunaElipsePanel4.SuspendLayout()
        Me.GunaElipsePanel3.SuspendLayout()
        Me.GunaElipsePanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'palShow
        '
        Me.palShow.Controls.Add(Me.GunaElipsePanel6)
        Me.palShow.Controls.Add(Me.GunaElipsePanel1)
        Me.palShow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.palShow.Location = New System.Drawing.Point(0, 0)
        Me.palShow.Name = "palShow"
        Me.palShow.Size = New System.Drawing.Size(939, 552)
        Me.palShow.TabIndex = 3
        '
        'GunaElipsePanel6
        '
        Me.GunaElipsePanel6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaElipsePanel6.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel6.BaseColor = System.Drawing.Color.Gainsboro
        Me.GunaElipsePanel6.Controls.Add(Me.lblAppTotal)
        Me.GunaElipsePanel6.Controls.Add(Me.Chart1)
        Me.GunaElipsePanel6.Location = New System.Drawing.Point(490, 78)
        Me.GunaElipsePanel6.Name = "GunaElipsePanel6"
        Me.GunaElipsePanel6.Size = New System.Drawing.Size(417, 405)
        Me.GunaElipsePanel6.TabIndex = 1
        '
        'lblAppTotal
        '
        Me.lblAppTotal.AutoSize = True
        Me.lblAppTotal.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAppTotal.Location = New System.Drawing.Point(14, 10)
        Me.lblAppTotal.Name = "lblAppTotal"
        Me.lblAppTotal.Size = New System.Drawing.Size(250, 37)
        Me.lblAppTotal.TabIndex = 2
        Me.lblAppTotal.Text = "TOTAL APPLICATION: 0"
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(41, 61)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(338, 304)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'GunaElipsePanel1
        '
        Me.GunaElipsePanel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaElipsePanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel1.BaseColor = System.Drawing.Color.Gainsboro
        Me.GunaElipsePanel1.Controls.Add(Me.Label7)
        Me.GunaElipsePanel1.Controls.Add(Me.GunaElipsePanel5)
        Me.GunaElipsePanel1.Controls.Add(Me.GunaElipsePanel4)
        Me.GunaElipsePanel1.Controls.Add(Me.GunaElipsePanel3)
        Me.GunaElipsePanel1.Controls.Add(Me.GunaElipsePanel2)
        Me.GunaElipsePanel1.Location = New System.Drawing.Point(37, 78)
        Me.GunaElipsePanel1.Name = "GunaElipsePanel1"
        Me.GunaElipsePanel1.Size = New System.Drawing.Size(422, 405)
        Me.GunaElipsePanel1.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(17, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 37)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "SUMMARY"
        '
        'GunaElipsePanel5
        '
        Me.GunaElipsePanel5.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel5.BaseColor = System.Drawing.Color.White
        Me.GunaElipsePanel5.Controls.Add(Me.lblRejected)
        Me.GunaElipsePanel5.Controls.Add(Me.Label11)
        Me.GunaElipsePanel5.Location = New System.Drawing.Point(222, 222)
        Me.GunaElipsePanel5.Name = "GunaElipsePanel5"
        Me.GunaElipsePanel5.Size = New System.Drawing.Size(161, 143)
        Me.GunaElipsePanel5.TabIndex = 4
        '
        'lblRejected
        '
        Me.lblRejected.AutoSize = True
        Me.lblRejected.Font = New System.Drawing.Font("Showcard Gothic", 50.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRejected.Location = New System.Drawing.Point(44, 23)
        Me.lblRejected.Name = "lblRejected"
        Me.lblRejected.Size = New System.Drawing.Size(75, 83)
        Me.lblRejected.TabIndex = 6
        Me.lblRejected.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(39, 106)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 28)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "REJECTED"
        '
        'GunaElipsePanel4
        '
        Me.GunaElipsePanel4.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel4.BaseColor = System.Drawing.Color.White
        Me.GunaElipsePanel4.Controls.Add(Me.lblApproved)
        Me.GunaElipsePanel4.Controls.Add(Me.Label10)
        Me.GunaElipsePanel4.Location = New System.Drawing.Point(41, 222)
        Me.GunaElipsePanel4.Name = "GunaElipsePanel4"
        Me.GunaElipsePanel4.Size = New System.Drawing.Size(161, 143)
        Me.GunaElipsePanel4.TabIndex = 3
        '
        'lblApproved
        '
        Me.lblApproved.AutoSize = True
        Me.lblApproved.Font = New System.Drawing.Font("Showcard Gothic", 50.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApproved.Location = New System.Drawing.Point(46, 23)
        Me.lblApproved.Name = "lblApproved"
        Me.lblApproved.Size = New System.Drawing.Size(75, 83)
        Me.lblApproved.TabIndex = 5
        Me.lblApproved.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(29, 106)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 28)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "APPROVED"
        '
        'GunaElipsePanel3
        '
        Me.GunaElipsePanel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel3.BaseColor = System.Drawing.Color.White
        Me.GunaElipsePanel3.Controls.Add(Me.lblPending)
        Me.GunaElipsePanel3.Controls.Add(Me.Label8)
        Me.GunaElipsePanel3.Location = New System.Drawing.Point(222, 61)
        Me.GunaElipsePanel3.Name = "GunaElipsePanel3"
        Me.GunaElipsePanel3.Size = New System.Drawing.Size(161, 143)
        Me.GunaElipsePanel3.TabIndex = 2
        '
        'lblPending
        '
        Me.lblPending.AutoSize = True
        Me.lblPending.Font = New System.Drawing.Font("Showcard Gothic", 50.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPending.Location = New System.Drawing.Point(44, 23)
        Me.lblPending.Name = "lblPending"
        Me.lblPending.Size = New System.Drawing.Size(75, 83)
        Me.lblPending.TabIndex = 5
        Me.lblPending.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(39, 106)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 28)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "PENDING"
        '
        'GunaElipsePanel2
        '
        Me.GunaElipsePanel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel2.BaseColor = System.Drawing.Color.White
        Me.GunaElipsePanel2.Controls.Add(Me.lblTotal)
        Me.GunaElipsePanel2.Controls.Add(Me.Label9)
        Me.GunaElipsePanel2.Location = New System.Drawing.Point(41, 61)
        Me.GunaElipsePanel2.Name = "GunaElipsePanel2"
        Me.GunaElipsePanel2.Size = New System.Drawing.Size(161, 143)
        Me.GunaElipsePanel2.TabIndex = 1
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Showcard Gothic", 50.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(35, 23)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(75, 83)
        Me.lblTotal.TabIndex = 4
        Me.lblTotal.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(46, 106)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 28)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "TOTAL"
        '
        'DashAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(939, 552)
        Me.Controls.Add(Me.palShow)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DashAdmin"
        Me.Text = "DashAdmin"
        Me.palShow.ResumeLayout(False)
        Me.GunaElipsePanel6.ResumeLayout(False)
        Me.GunaElipsePanel6.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaElipsePanel1.ResumeLayout(False)
        Me.GunaElipsePanel1.PerformLayout()
        Me.GunaElipsePanel5.ResumeLayout(False)
        Me.GunaElipsePanel5.PerformLayout()
        Me.GunaElipsePanel4.ResumeLayout(False)
        Me.GunaElipsePanel4.PerformLayout()
        Me.GunaElipsePanel3.ResumeLayout(False)
        Me.GunaElipsePanel3.PerformLayout()
        Me.GunaElipsePanel2.ResumeLayout(False)
        Me.GunaElipsePanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents palShow As Panel
    Friend WithEvents GunaElipsePanel6 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents lblAppTotal As Label
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents GunaElipsePanel1 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents Label7 As Label
    Friend WithEvents GunaElipsePanel5 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents lblRejected As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents GunaElipsePanel4 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents lblApproved As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GunaElipsePanel3 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents lblPending As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GunaElipsePanel2 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label9 As Label
End Class
