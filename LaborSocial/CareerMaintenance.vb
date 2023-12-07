Imports System.ComponentModel

Public Class CareerMaintenance
    Private currentCareer As Career
    Private careers As New BindingList(Of Career)
    Private schools As New BindingList(Of School)


    Private Sub dgvCareerSelectedItem(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCareers.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = 0 Then
            Dim rowIndex As Integer = e.RowIndex
            currentCareer = careers(rowIndex)

            tbCip.Text = currentCareer.Id

            tbName.Text = currentCareer.Nombre

            cbSchools.SelectedItem = currentCareer.Facultad


        End If

    End Sub

    Private Sub CareerMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvCareers.DataSource = careers

        cbSchools.DataSource = schools
        cbSchools.DisplayMember = "Nombre"
        cbSchools.ValueMember = "Id"

        Dim schoolsData = SchoolService.Listar()

        If schoolsData.Count > 0 Then
            For Each school As School In schoolsData
                schools.Add(school)
            Next
            cbSchools.SelectedItem = schools.ElementAt(0).Nombre
        End If

        listar()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrEmpty(tbCip.Text) OrElse
           String.IsNullOrEmpty(tbName.Text) Then
            MessageBox.Show("Todos los campos son requeridos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                disableButtons()
                Dim careerData = CareerService.Save(tbCip.Text, tbName.Text, cbSchools.SelectedValue, "9-757-1876")

                If careerData IsNot Nothing Then
                    careers.Add(careerData)
                    dgvCareers.Refresh()
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

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If String.IsNullOrEmpty(tbCip.Text) Then
            MessageBox.Show("Debe introducir la cédula", "Info", MessageBoxButtons.OK)
            Return
        Else
            disableButtons()
            Try
                disableButtons()
                Dim careerData = CareerService.Search(tbCip.Text)

                If careerData IsNot Nothing Then
                    careers.Clear()
                    careers.Add(careerData)
                    dgvCareers.Refresh()
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

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If String.IsNullOrEmpty(tbCip.Text) Then
            MessageBox.Show("Debe introducir el id", "Info", MessageBoxButtons.OK)
            Return
        Else
            disableButtons()
            Try
                disableButtons()
                Dim careerData = CareerService.Delete(tbCip.Text, "9-757-1876")

                If careerData IsNot Nothing Then
                    careers.Remove(careerData)
                    dgvCareers.Refresh()
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

    Private Sub listar()
        careers.Clear()
        dgvCareers.Refresh()
        Dim dbRsults As List(Of Career) = CareerService.Listar()
        If dbRsults.Count > 0 Then
            For Each career As Career In dbRsults
                careers.Add(career)
            Next
            dgvCareers.Refresh()
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