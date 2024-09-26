Public Class frmAdminDashBoard
    Dim max As Boolean = False
    Dim menuOpened As Boolean = False
    Dim targetWidth As Integer
    Dim targetLeft As Integer
    Private WithEvents Timer1 As New Timer()
    Private WithEvents Timer2 As New Timer()
    Private targetLabel As Label
    Private fadeStep As Integer = 15 ' Control the speed of the fade effect
    Private fontSizeStep As Single = 0.5 ' Control the speed of the font size change
    Private targetFontSize As Single ' Control the speed of the fade effect

    Private Sub btnMenuNav_Click(sender As Object, e As EventArgs) Handles btnMenuNav.Click
        If menuOpened Then
            ' Set target dimensions for closing the menu
            targetWidth = 123
            targetLeft = If(max, 1225, 820)
            btnMenuNav.Image = My.Resources.setup
        Else
            ' Set target dimensions for opening the menu
            targetWidth = 931
            targetLeft = If(max, 420, 12)
            btnMenuNav.Image = My.Resources.cross
        End If

        Timer1.Start() ' Start the animation
        menuOpened = Not menuOpened
    End Sub

    Private Sub GunaControlBox2_Click(sender As Object, e As EventArgs) Handles GunaControlBox2.Click
        max = Not max
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles timer1.Tick
        ' Gradually adjust the width
        If palMenu.Width < targetWidth Then
            palMenu.Width += 20
            If palMenu.Width > targetWidth Then palMenu.Width = targetWidth
        ElseIf palMenu.Width > targetWidth Then
            palMenu.Width -= 20
            If palMenu.Width < targetWidth Then palMenu.Width = targetWidth
        End If

        ' Gradually adjust the left position
        If palMenu.Left < targetLeft Then
            palMenu.Left += 20
            If palMenu.Left > targetLeft Then palMenu.Left = targetLeft
        ElseIf palMenu.Left > targetLeft Then
            palMenu.Left -= 20
            If palMenu.Left < targetLeft Then palMenu.Left = targetLeft
        End If

        ' Stop the timer if the target dimensions are reached
        If palMenu.Width = targetWidth AndAlso palMenu.Left = targetLeft Then
            Timer1.Stop()
        End If
    End Sub

    Public Sub LoadForm(ByVal form As Object)
        Dim f As Form

        If Me.palShow.Controls.Count > 0 Then
            Me.palShow.Controls.RemoveAt(0)
        End If

        f = TryCast(form, Form)
        f.TopLevel = False
        f.Dock = DockStyle.Fill
        f.Name = "palFrame"
        Me.palShow.Controls.Add(f)


        Me.palShow.Tag = f
        f.Show()
    End Sub

    Private Sub lblDashboard_Click(sender As Object, e As EventArgs) Handles lblDashboard.Click
        LoadForm(New DashAdmin)
        StartFade(lblDashboard)
    End Sub

    Private Sub lblUserManagemen_Click(sender As Object, e As EventArgs) Handles lblUserManagemen.Click
        LoadForm(New Usermanagement)
        StartFade(lblUserManagemen)
    End Sub

    Private Sub lblAppManagement_Click(sender As Object, e As EventArgs) Handles lblAppManagement.Click
        LoadForm(New ApplicationManagement)
        StartFade(lblAppManagement)
    End Sub

    Private Sub lblSettings_Click(sender As Object, e As EventArgs) Handles lblSettings.Click
        LoadForm(New frmSetting)
        StartFade(lblSettings)
    End Sub

    Private Sub lblReport_Click(sender As Object, e As EventArgs) Handles lblReport.Click
        LoadForm(New Report)
        StartFade(lblReport)
    End Sub

    Private Sub StartFade(selectedLabel As Label)
        ' Reset all labels to their normal font and color
        ResetLabels()

        ' Set the target label for fading
        targetLabel = selectedLabel
        targetFontSize = targetLabel.Font.Size + 2 ' Increase font size for the selected label
        targetLabel.Font = New Font(targetLabel.Font.FontFamily, targetLabel.Font.Size, FontStyle.Bold Or FontStyle.Underline)
        targetLabel.ForeColor = Color.FromArgb(0, 0, 0) ' Start from fully transparent

        Timer1.Start() ' Start the fade animation
    End Sub

    Private Sub ResetLabels()
        Dim labels As Label() = {lblDashboard, lblUserManagemen, lblAppManagement, lblReport, lblSettings}

        For Each lbl In labels
            lbl.Font = New Font(lbl.Font.FontFamily, 12) ' Reset font size
            lbl.ForeColor = Color.Black ' Reset color to default
        Next
    End Sub

    Private Sub frmAdminDashBoard_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Interval = 10
        Timer2.Interval = 30
        LoadForm(New DashAdmin)
        'StartFade(lblDashboard)
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If targetLabel IsNot Nothing Then
            ' Gradually adjust the font size
            If targetLabel.Font.Size < targetFontSize Then
                targetLabel.Font = New Font(targetLabel.Font.FontFamily, targetLabel.Font.Size + fontSizeStep, FontStyle.Bold Or FontStyle.Underline)
                If targetLabel.Font.Size > targetFontSize Then targetLabel.Font = New Font(targetLabel.Font.FontFamily, targetFontSize, FontStyle.Bold Or FontStyle.Underline)
            ElseIf targetLabel.Font.Size > targetFontSize Then
                targetLabel.Font = New Font(targetLabel.Font.FontFamily, targetLabel.Font.Size - fontSizeStep, FontStyle.Bold Or FontStyle.Underline)
                If targetLabel.Font.Size < targetFontSize Then targetLabel.Font = New Font(targetLabel.Font.FontFamily, targetFontSize, FontStyle.Bold Or FontStyle.Underline)
            End If

            ' Gradually adjust the color
            Dim currentColor = targetLabel.ForeColor
            Dim newR = Math.Min(currentColor.R + fadeStep, 0)
            Dim newG = Math.Min(currentColor.G + fadeStep, 0)
            Dim newB = Math.Min(currentColor.B + fadeStep, 0)
            targetLabel.ForeColor = Color.FromArgb(newR, newG, newB)

            ' Stop the timer if the target dimensions and color are reached
            If targetLabel.Font.Size = targetFontSize AndAlso newR >= 0 AndAlso newG >= 0 AndAlso newB >= 0 Then
                Timer1.Stop()
            End If
        End If

    End Sub


End Class