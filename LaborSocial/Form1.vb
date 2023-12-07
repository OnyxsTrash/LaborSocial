Public Class Form1
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If String.IsNullOrEmpty(tbUsername.Text) OrElse String.IsNullOrEmpty(tbPassword.Text) Then
            MessageBox.Show("Todos los datos son requeridos.", "Warming", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim userData = PeopleService.Login(tbUsername.Text)
            Dim finalUser As Person = Nothing
            If userData.Rows.Count > 0 Then
                Dim row As DataRow = userData.Rows(0)
                finalUser = New Person With {
                        .Cedula = row(0).ToString(),
                        .Nombre = row(1).ToString(),
                        .Apellido = row(2).ToString(),
                        .Contrasenia = row(3).ToString()
                    }
                Me.Hide()
                'Main.Show()
            Else
                MessageBox.Show("Credenciales erroneos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MessageBox.Show("No se pudo hacer el login. Itente más tarde.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        tbUsername.Text = ""
        tbPassword.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
