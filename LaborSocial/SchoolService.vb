Imports System.Data.SqlClient

Public Class SchoolService
    Private Shared ReadOnly conexion As SqlConnection = Connection.OpenConnection()
    Private Shared dataset As New DataSet()


    Public Shared Function Listar() As List(Of School)
        Dim query As String = "exec Facultad_Listar @limit, @at"
        Dim command As New SqlDataAdapter(query, conexion)
        command.SelectCommand.Parameters.AddWithValue("@limit", 10)
        command.SelectCommand.Parameters.AddWithValue("@at", 0)
        Try
            If conexion.State = ConnectionState.Closed Then
                conexion.Open()
            End If

            Using dataset As New DataSet()
                command.Fill(dataset, "school")

                If dataset.Tables.Contains("school") AndAlso dataset.Tables("school").Rows.Count > 0 Then
                    Dim dataTable As DataTable = dataset.Tables("school")

                    Dim listaDeRegistros As New List(Of School)
                    For Each row As DataRow In dataTable.Rows
                        Dim school As New School With {
                        .Id = row(0).ToString(),
                            .Nombre = row(1).ToString(),
                            .Status = Convert.ToBoolean(row(2)),
                            .CreatedBy = row(3).ToString()
                    }
                        listaDeRegistros.Add(school)
                    Next

                    Return listaDeRegistros
                Else
                    Return New List(Of School)
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

    Public Shared Function Save(id As String, nombre As String, createdBy As String) As School
        Dim currentSchool As School = Nothing
        Try
            Using conexion
                Dim query As String = "exec Facultad_Guardar @id, @nombre, @updatedBy"
                Dim command As New SqlDataAdapter(query, conexion)
                command.SelectCommand.Parameters.AddWithValue("@id", id)
                command.SelectCommand.Parameters.AddWithValue("@nombre", nombre)
                command.SelectCommand.Parameters.AddWithValue("@updatedBy", createdBy)
                command.Fill(dataset, "tutor")
                conexion.Close()

                If dataset.Tables.Contains("school") AndAlso dataset.Tables("school").Rows.Count > 0 Then
                    If dataset.Tables("school").Rows.Count > 0 Then
                        Dim row As DataRow = dataset.Tables("school").Rows(0)
                        currentSchool = New School With {
                            .Id = row(0).ToString(),
                            .Nombre = row(1).ToString(),
                            .Status = Convert.ToBoolean(row(2)),
                            .CreatedBy = row(3).ToString()
                        }
                    End If
                End If
                Return currentSchool
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function Search(id As String) As School
        Dim currentSchool As School = Nothing
        Dim query As String = "exec Facultad_Buscar @id"
        Dim command As New SqlDataAdapter(query, conexion)
        command.SelectCommand.Parameters.AddWithValue("@id", id)
        Try
            If conexion.State = ConnectionState.Closed Then
                conexion.Open()
            End If

            Using dataset As New DataSet()
                command.Fill(dataset, "school")

                If dataset.Tables.Contains("school") AndAlso dataset.Tables("school").Rows.Count > 0 Then
                    If dataset.Tables("school").Rows.Count > 0 Then
                        Dim row As DataRow = dataset.Tables("school").Rows(0)
                        currentSchool = New School With {
                            .Id = row(0).ToString(),
                            .Nombre = row(1).ToString(),
                            .Status = Convert.ToBoolean(row(2)),
                            .CreatedBy = row(3).ToString()
                        }
                    End If
                End If
                Return currentSchool
            End Using

        Catch ex As Exception
            Throw ex

        Finally
            If conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
        End Try
    End Function

    Public Shared Function Delete(id As String, updatedBy As String) As School
        Dim currentSchool As School = Nothing
        Try
            Using conexion
                Dim query As String = "exec Facultad_Desactivar @id, @updatedBy"
                Dim command As New SqlDataAdapter(query, conexion)
                command.SelectCommand.Parameters.AddWithValue("@id", id)
                command.SelectCommand.Parameters.AddWithValue("@updatedBy", updatedBy)

                command.Fill(dataset, "school")
                conexion.Close()

                If dataset.Tables.Contains("school") AndAlso dataset.Tables("school").Rows.Count > 0 Then
                    If dataset.Tables("school").Rows.Count > 0 Then
                        Dim row As DataRow = dataset.Tables("school").Rows(0)
                        currentSchool = New School With {
                            .Id = row(0).ToString(),
                            .Nombre = row(1).ToString(),
                            .Status = Convert.ToBoolean(row(2)),
                            .CreatedBy = row(3).ToString()
                        }
                    End If
                End If
                Return currentSchool
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
