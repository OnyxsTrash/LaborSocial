Imports System.ComponentModel

Public Class SchoolManintenance
    Private currentSchool As School
    Private schools As New BindingList(Of School)


    Private Sub dgvSchoolSelectedItem(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSchool.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = 0 Then
            Dim rowIndex As Integer = e.RowIndex
            currentSchool = schools(rowIndex)

            tbCip.Text = currentSchool.Id

            tbName.Text = currentSchool.Nombre

        End If

    End Sub

    Private Sub SchoolManintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvSchool.DataSource = schools
        listar()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrEmpty(tbCip.Text) OrElse
           String.IsNullOrEmpty(tbName.Text) Then
            MessageBox.Show("Todos los campos son requeridos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                disableButtons()
                Dim schoolData = SchoolService.Save(tbCip.Text, tbName.Text, "9-757-1876")

                If schoolData IsNot Nothing Then
                    schools.Remove(schoolData)
                    dgvSchool.Refresh()
                    clearFields()
                Else
                    MessageBox.Show("Error Al guardar", "Error", MessageBoxButtons.OK)
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
                Dim schooladata = SchoolService.Delete(tbCip.Text, "9-757-1876")

                If schooladata IsNot Nothing Then
                    schools.Remove(schooladata)
                    dgvSchool.Refresh()
                    clearFields()
                Else
                    MessageBox.Show("Error Al Eliminar", "Error", MessageBoxButtons.OK)
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
                Dim schooladata = SchoolService.Search(tbCip.Text)

                If schooladata IsNot Nothing Then
                    schools.Clear()
                    schools.Add(schooladata)
                    dgvSchool.Refresh()
                    clearFields()
                Else
                    MessageBox.Show("No se pudo encontrar una facultad con el id: " & tbCip.Text, "Error", MessageBoxButtons.OK)
                End If
                enableButtons()
            Catch ex As Exception
                enableButtons()
                MessageBox.Show("No se pudo encontrar una facultad con el id: " & tbCip.Text, "Error", MessageBoxButtons.OK)
            End Try
        End If
    End Sub

    Private Sub listar()
        schools.Clear()
        dgvSchool.Refresh()
        Dim dbRsults As List(Of School) = SchoolService.Listar()
        If dbRsults.Count > 0 Then
            For Each school As School In dbRsults
                schools.Add(school)
            Next
            dgvSchool.Refresh()
        End If
    End Sub

    Private Sub clearFields()
        tbCip.Text = ""
        tbName.Text = ""
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

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        listar()
    End Sub
End Class