Imports System.ComponentModel
Imports System.Net.Security

Public Class ActivityMaintenance
    Private currentActivity As Activity
    Private activities As New BindingList(Of Activity)
    Private tutor As New BindingList(Of Tutor)

    Private Sub ActivityMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvActivity.DataSource = activities

        cbTutor.DisplayMember = "Nombre"
        cbTutor.ValueMember = "Id"
        cbTutor.DataSource = tutor

        Dim dbTutors = TutorService.Listar()
        If dbTutors.Count > 0 Then
            For Each t As Tutor In dbTutors
                tutor.Add(t)
            Next
        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrEmpty(tbName.Text) OrElse
                String.IsNullOrEmpty(tbEntity.Text) OrElse
                String.IsNullOrEmpty(tbHours.Text) OrElse
                String.IsNullOrEmpty(tbLocation.Text) Then
            MessageBox.Show("Todos los campos son requeridos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                disableButtons()
                Dim careerData = ActivityService.Save(tbIdProject.Text, tbName.Text, tbEntity.Text, CInt(tbHours.Text), dt.Value, tbLocation.Text, cbTutor.SelectedValue, "9-757-1876")

                If careerData IsNot Nothing Then
                    activities.Add(careerData)
                    dgvActivity.Refresh()
                    clearFields()
                Else
                    MessageBox.Show("Error Al guardar", "Error", MessageBoxButtons.OK)
                End If
                enableButtons()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                enableButtons()
                MessageBox.Show("Error Al guardar", "Error", MessageBoxButtons.OK)
            End Try
        End If
    End Sub

    Private Sub clearFields()
        tbIdProject.Text = ""
        tbName.Text = ""
        tbEntity.Text = ""
        tbHours.Text = ""
        tbLocation.Text = ""
    End Sub

    Private Sub disableButtons()
        btnSave.Enabled = False
        btnDelete.Enabled = False
        btnSearch.Enabled = False
        btnRefresh.Enabled = False
    End Sub

    Private Sub enableButtons()
        btnSave.Enabled = True
        btnDelete.Enabled = True
        btnSearch.Enabled = True
        btnRefresh.Enabled = True
    End Sub

End Class