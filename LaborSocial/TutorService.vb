Imports System.Data.SqlClient

Public Class TutorService
    Private Shared ReadOnly conexion As SqlConnection = Connection.OpenConnection()
    Private Shared dataset As New DataSet()


    Public Shared Function Listar() As List(Of Tutor)
        Dim query As String = "exec Tutor_Listar @limit, @at"
        Dim command As New SqlDataAdapter(query, conexion)
        command.SelectCommand.Parameters.AddWithValue("@limit", 10)
        command.SelectCommand.Parameters.AddWithValue("@at", 0)
        Try
            If conexion.State = ConnectionState.Closed Then
                conexion.Open()
            End If

            Using dataset As New DataSet()
                command.Fill(dataset, "tutor")

                If dataset.Tables.Contains("tutor") AndAlso dataset.Tables("tutor").Rows.Count > 0 Then
                    Dim dataTable As DataTable = dataset.Tables("tutor")

                    Dim listaDeRegistros As New List(Of Tutor)
                    For Each row As DataRow In dataTable.Rows
                        Dim tutor As New Tutor With {
                        .Id = row(0).ToString(),
                        .Nombre = row(1).ToString(),
                        .Apellido = row(2).ToString(),
                        .Status = Convert.ToBoolean(row(3)),
                        .CreatedBy = row(4).ToString()
                    }
                        listaDeRegistros.Add(tutor)
                    Next

                    Return listaDeRegistros
                Else
                    Return New List(Of Tutor)
                End If
            End Using

        Catch ex As Exception
            Throw ex

        Finally
            If conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
        End Try
    End Function

    Public Shared Function Save(id As String, nombre As String, apellido As String, createdBy As String) As Tutor
        Dim currentTutor As Tutor = Nothing
        Try
            Using conexion
                Dim query As String = "exec Tutor_Guardar @id, @nombre, @apellido, @updatedBy"
                Dim command As New SqlDataAdapter(query, conexion)
                command.SelectCommand.Parameters.AddWithValue("@id", id)
                command.SelectCommand.Parameters.AddWithValue("@nombre", nombre)
                command.SelectCommand.Parameters.AddWithValue("@apellido", apellido)
                command.SelectCommand.Parameters.AddWithValue("@updatedBy", createdBy)
                command.Fill(dataset, "tutor")
                conexion.Close()

                If dataset.Tables.Contains("tutor") AndAlso dataset.Tables("tutor").Rows.Count > 0 Then
                    If dataset.Tables("tutor").Rows.Count > 0 Then
                        Dim row As DataRow = dataset.Tables("tutor").Rows(0)
                        currentTutor = New Tutor With {
                            .Id = row(0).ToString(),
                            .Nombre = row(1).ToString(),
                            .Apellido = row(2).ToString(),
                            .Status = Convert.ToBoolean(row(3)),
                            .CreatedBy = row(4).ToString()
                        }
                    End If
                End If
                Return currentTutor
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function Search(id As String) As Tutor
        Dim currentTutor As Tutor = Nothing
        Dim query As String = "exec Tutor_Buscar @id"
        Dim command As New SqlDataAdapter(query, conexion)
        command.SelectCommand.Parameters.AddWithValue("@id", id)
        Try
            If conexion.State = ConnectionState.Closed Then
                conexion.Open()
            End If

            Using dataset As New DataSet()
                command.Fill(dataset, "tutor")

                If dataset.Tables.Contains("tutor") AndAlso dataset.Tables("tutor").Rows.Count > 0 Then
                    If dataset.Tables("tutor").Rows.Count > 0 Then
                        Dim row As DataRow = dataset.Tables("tutor").Rows(0)
                        currentTutor = New Tutor With {
                            .Id = row(0).ToString(),
                            .Nombre = row(1).ToString(),
                            .Apellido = row(2).ToString(),
                            .Status = Convert.ToBoolean(row(3)),
                            .CreatedBy = row(4).ToString()
                        }
                    End If
                End If
                Return currentTutor
            End Using

        Catch ex As Exception
            Throw ex

        Finally
            If conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
        End Try
    End Function

    Public Shared Function Delete(id As String, updatedBy As String) As Tutor
        Dim currentTutor As Tutor = Nothing
        Try
            Using conexion
                Dim query As String = "exec Tutor_Desactivar @id, @updatedBy"
                Dim command As New SqlDataAdapter(query, conexion)
                command.SelectCommand.Parameters.AddWithValue("@id", id)
                command.SelectCommand.Parameters.AddWithValue("@updatedBy", updatedBy)

                command.Fill(dataset, "tutor")
                conexion.Close()

                If dataset.Tables.Contains("tutor") AndAlso dataset.Tables("tutor").Rows.Count > 0 Then
                    If dataset.Tables("tutor").Rows.Count > 0 Then
                        Dim row As DataRow = dataset.Tables("tutor").Rows(0)
                        currentTutor = New Tutor With {
                            .Id = row(0).ToString(),
                            .Nombre = row(1).ToString(),
                            .Apellido = row(2).ToString(),
                            .Status = Convert.ToBoolean(row(3)),
                            .CreatedBy = row(4).ToString()
                        }
                    End If
                End If
                Return currentTutor
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
