Imports System.ComponentModel

Public Class PeopleMaintenance

    Private currentPerson As Person
    Private people As New BindingList(Of Person)

    Private Sub PeopleMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvPeople.DataSource = people
        rbMale.Checked = True

        listar()

    End Sub

    Private Sub dgvEquipments(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPeople.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = 0 Then
            Dim rowIndex As Integer = e.RowIndex
            currentPerson = people(rowIndex)

            tbCip.Text = currentPerson.Cedula

            tbName.Text = currentPerson.Nombre
            tbLastname.Text = currentPerson.Apellido
            tbPhone.Text = currentPerson.Telefono

            If currentPerson.Sexo = "Masculino" Then
                rbMale.Checked = True
                rbFemale.Checked = False
            Else
                rbFemale.Checked = True
                rbMale.Checked = False
            End If
        End If

    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs)
        If String.IsNullOrEmpty(tbCip.Text) OrElse
           String.IsNullOrEmpty(tbPhone.Text) OrElse
           String.IsNullOrEmpty(tbLastname.Text) OrElse
           String.IsNullOrEmpty(tbName.Text) OrElse
           String.IsNullOrEmpty(tbPhone.Text) Then
            MessageBox.Show("Todos los campos son requeridos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                Dim gender As Integer = If(rbMale.Checked, 0, 1)
                Dim userData = PeopleService.Save(tbCip.Text, tbName.Text, tbLastname.Text, tbPhone.Text, gender, tbPassword.Text)
                If userData.Rows.Count > 0 Then
                    Dim row As DataRow = userData.Rows(0)
                    people.Add(New Person With {
                            .Cedula = row(0).ToString(),
                            .Nombre = row(1).ToString(),
                            .Apellido = row(2).ToString(),
                            .Telefono = row(3).ToString(),
                            .Sexo = If(Convert.ToBoolean(row(4)), "Femenino", "Masculino"),
                            .Status = Convert.ToBoolean(row(5))
                        })
                    enableButtons()
                    dgvPeople.Refresh()
                Else
                    MessageBox.Show("No se encontró a una persona con esa cédula", "Error", MessageBoxButtons.OK)
                End If
            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs)
        If String.IsNullOrEmpty(tbCip.Text) Then
            MessageBox.Show("Debe introducir la cédula", "Info", MessageBoxButtons.OK)
            Return
        Else
            disableButtons()
            Try
                Dim userData = PeopleService.Search(tbCip.Text)
                If userData.Rows.Count > 0 Then
                    Dim row As DataRow = userData.Rows(0)
                    people.Add(New Person With {
                            .Cedula = row(0).ToString(),
                            .Nombre = row(1).ToString(),
                            .Apellido = row(2).ToString(),
                            .Telefono = row(3).ToString(),
                            .Sexo = If(Convert.ToBoolean(row(4)), "Femenino", "Masculino"),
                            .Status = Convert.ToBoolean(row(5))
                        })
                    enableButtons()
                    dgvPeople.Refresh()
                    clearFields()
                End If
            Catch ex As Exception
                enableButtons()
                MessageBox.Show("No se encontró al usuario con la cédula: " & tbCip.Text, "Error", MessageBoxButtons.OK)
            End Try

        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs)
        If String.IsNullOrEmpty(tbCip.Text) Then
            MessageBox.Show("Debe introducir la cédula", "Info", MessageBoxButtons.OK)
            Return
        Else
            disableButtons()
            Try
                Dim userData = PeopleService.Delete(tbCip.Text)
                If userData.Rows.Count > 0 Then
                    Dim row As DataRow = userData.Rows(0)
                    people.Remove(currentPerson)
                    currentPerson = Nothing
                    enableButtons()
                    dgvPeople.Refresh()
                    clearFields()
                End If
            Catch ex As Exception
                enableButtons()
                MessageBox.Show("No se encontró al usuario con la cédula: " & tbCip.Text, "Error", MessageBoxButtons.OK)
            End Try

        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs)
        listar()
    End Sub

    Private Sub clearFields()
        tbCip.Text = ""
        tbName.Text = ""
        tbLastname.Text = ""
        tbPassword.Text = ""
        tbPhone.Text = ""
    End Sub

    Private Sub listar()
        people.Clear()
        dgvPeople.Refresh()
        Dim dbRsults As List(Of Person) = PeopleService.Listar()
        If dbRsults.Count > 0 Then
            For Each persona As Person In dbRsults
                people.Add(persona)
            Next
            dgvPeople.Refresh()
        End If
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