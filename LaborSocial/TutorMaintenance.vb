Imports System.ComponentModel

Public Class TutorMaintenance

    Private tutor As New BindingList(Of Tutor)
    Private currentTutor As Tutor
    Private Sub TutorMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvTutor.DataSource = tutor
        listar()
    End Sub

    Private Sub dgvTutorSelectedItem(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTutor.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = 0 Then
            Dim rowIndex As Integer = e.RowIndex
            currentTutor = tutor(rowIndex)

            tbCip.Text = currentTutor.Id

            tbName.Text = currentTutor.Nombre
            tbLastname.Text = currentTutor.Apellido

        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrEmpty(tbCip.Text) OrElse
           String.IsNullOrEmpty(tbLastname.Text) OrElse
           String.IsNullOrEmpty(tbName.Text) Then
            MessageBox.Show("Todos los campos son requeridos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                disableButtons()
                Dim tutorData = TutorService.Save(tbCip.Text, tbName.Text, tbLastname.Text, "9-757-1876")

                If tutorData IsNot Nothing Then
                    tutor.Remove(tutorData)
                    dgvTutor.Refresh()
                    clearFields()
                End If
                enableButtons()
            Catch ex As Exception
                enableButtons()
                MessageBox.Show("Error Al guardar", "Error", MessageBoxButtons.OK)
            End Try
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If String.IsNullOrEmpty(tbCip.Text) Then
            MessageBox.Show("Debe introducir la cédula", "Info", MessageBoxButtons.OK)
            Return
        Else
            disableButtons()
            Try
                disableButtons()
                Dim tutorData = TutorService.Delete(tbCip.Text, "9-757-1876")

                If tutorData IsNot Nothing Then
                    tutor.Add(tutorData)
                    dgvTutor.Refresh()
                    clearFields()
                End If
                enableButtons()
            Catch ex As Exception
                enableButtons()
                MessageBox.Show("Error Al Eliminar", "Error", MessageBoxButtons.OK)
            End Try
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If String.IsNullOrEmpty(tbCip.Text) Then
            MessageBox.Show("Debe introducir la cédula", "Info", MessageBoxButtons.OK)
            Return
        Else
            disableButtons()
            Try
                disableButtons()
                Dim tutorData = TutorService.Search(tbCip.Text)

                If tutorData IsNot Nothing Then
                    tutor.Clear()
                    tutor.Add(tutorData)
                    dgvTutor.Refresh()
                    clearFields()
                Else
                    MessageBox.Show("No se econtró un tutor con el id: " & tbCip.Text, "Error", MessageBoxButtons.OK)
                End If
                enableButtons()
            Catch ex As Exception
                enableButtons()
                MessageBox.Show("No se econtró un tutor con el id: " & tbCip.Text, "Error", MessageBoxButtons.OK)
            End Try
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        listar()
    End Sub

    Private Sub listar()
        tutor.Clear()
        dgvTutor.Refresh()
        Dim dbRsults As List(Of Tutor) = TutorService.Listar()
        If dbRsults.Count > 0 Then
            For Each persona As Tutor In dbRsults
                tutor.Add(persona)
            Next
            dgvTutor.Refresh()
        End If
    End Sub

    Private Sub clearFields()
        tbCip.Text = ""
        tbName.Text = ""
        tbLastname.Text = ""
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

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Dispose()
        Main.Show()
    End Sub
End Class