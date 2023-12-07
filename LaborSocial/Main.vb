Public Class Main
    Private Sub btnPoeple_Click(sender As Object, e As EventArgs) Handles btnPoeple.Click
        Me.Hide()
        PeopleMaintenance.Show()
    End Sub

    Private Sub btnTutor_Click(sender As Object, e As EventArgs) Handles btnTutor.Click
        Me.Hide()
        TutorMaintenance.Show()
    End Sub

    Private Sub btnFaculty_Click(sender As Object, e As EventArgs) Handles btnFaculty.Click
        Me.Hide()
        SchoolManintenance.Show()
    End Sub

    Private Sub btnCareer_Click(sender As Object, e As EventArgs) Handles btnCareer.Click
        Me.Hide()
        CareerMaintenance.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        ActivityMaintenance.Show()
    End Sub
End Class