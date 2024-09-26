Public Class ApplyNow
    Public Shared VisaType = 0
    Private Sub GunaSeparator2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnTouristVisa_Click(sender As Object, e As EventArgs) Handles btnTouristVisa.Click
        VisaType = 1
        MainForm1.ShowDialog()
    End Sub

    Private Sub btnStudentVisa_Click(sender As Object, e As EventArgs) Handles btnStudentVisa.Click
        VisaType = 2
        MainForm1.ShowDialog()
    End Sub

    Private Sub btnMedicalVisa_Click(sender As Object, e As EventArgs) Handles btnMedicalVisa.Click
        VisaType = 3
        MainForm1.ShowDialog()
    End Sub

    Private Sub btnDiplomaticVisa_Click(sender As Object, e As EventArgs) Handles btnDiplomaticVisa.Click
        VisaType = 4
        MainForm1.ShowDialog()
    End Sub

    Private Sub btnEntertainerVisa_Click(sender As Object, e As EventArgs) Handles btnEntertainerVisa.Click
        VisaType = 5
        MainForm1.ShowDialog()
    End Sub

    Private Sub btnBusinessVisa_Click(sender As Object, e As EventArgs) Handles btnBusinessVisa.Click
        VisaType = 6
        MainForm1.ShowDialog()
    End Sub

    Private Sub ApplyNow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class