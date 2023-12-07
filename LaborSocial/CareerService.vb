Imports System.Data.SqlClient

Public Class CareerService
    Private Shared ReadOnly conexion As SqlConnection = Connection.OpenConnection()
    Private Shared dataset As New DataSet()


    Public Shared Function Listar() As List(Of Career)
        Dim query As String = "exec Carrera_Listar @limit, @at"
        Dim command As New SqlDataAdapter(query, conexion)
        command.SelectCommand.Parameters.AddWithValue("@limit", 10)
        command.SelectCommand.Parameters.AddWithValue("@at", 0)
        Try
            If conexion.State = ConnectionState.Closed Then
                conexion.Open()
            End If

            Using dataset As New DataSet()
                command.Fill(dataset, "career")

                If dataset.Tables.Contains("career") AndAlso dataset.Tables("career").Rows.Count > 0 Then
                    Dim dataTable As DataTable = dataset.Tables("career")

                    Dim listaDeRegistros As New List(Of Career)
                    For Each row As DataRow In dataTable.Rows
                        Dim career As New Career With {
                            .Id = row(0).ToString(),
                            .Nombre = row(1).ToString(),
                            .Facultad = row(3).ToString(),
                            .Status = Convert.ToBoolean(row(4)),
                            .CreatedBy = row(5).ToString()
                    }
                        listaDeRegistros.Add(career)
                    Next

                    Return listaDeRegistros
                Else
                    Return New List(Of Career)
                End If
            End Using

        Catch ex As Exception
            Throw ex

        End Try
    End Function

    Public Shared Function Save(id As String, nombre As String, facultad As String, createdBy As String) As Career
        Dim currentCareer As Career = Nothing
        If conexion.State = ConnectionState.Closed Then
            conexion.Open()
        End If
        Try
            Using conexion
                Dim query As String = "exec Carrera_Guardar @id, @nombre,@facultad, @updatedBy"
                Dim command As New SqlDataAdapter(query, conexion)
                command.SelectCommand.Parameters.AddWithValue("@id", id)
                command.SelectCommand.Parameters.AddWithValue("@nombre", nombre)
                command.SelectCommand.Parameters.AddWithValue("@facultad", facultad)
                command.SelectCommand.Parameters.AddWithValue("@updatedBy", createdBy)
                command.Fill(dataset, "career")
                conexion.Close()

                If dataset.Tables.Contains("career") AndAlso dataset.Tables("career").Rows.Count > 0 Then
                    If dataset.Tables("career").Rows.Count > 0 Then
                        Dim row As DataRow = dataset.Tables("career").Rows(0)
                        currentCareer = New Career With {
                             .Id = row(0).ToString(),
                            .Nombre = row(1).ToString(),
                            .Facultad = row(3).ToString(),
                            .Status = Convert.ToBoolean(row(4)),
                            .CreatedBy = row(5).ToString()
                        }
                    End If
                End If
                Return currentCareer
            End Using
        Catch ex As Exception
            Throw ex

        End Try
    End Function

    Public Shared Function Search(id As String) As Career
        Dim currentCareer As Career = Nothing
        Dim query As String = "exec Carrera_Buscar @id"
        Dim command As New SqlDataAdapter(query, conexion)
        command.SelectCommand.Parameters.AddWithValue("@id", id)
        Try
            If conexion.State = ConnectionState.Closed Then
                conexion.Open()
            End If

            Using dataset As New DataSet()
                command.Fill(dataset, "career")

                If dataset.Tables.Contains("career") AndAlso dataset.Tables("career").Rows.Count > 0 Then
                    If dataset.Tables("career").Rows.Count > 0 Then
                        Dim row As DataRow = dataset.Tables("career").Rows(0)
                        currentCareer = New Career With {
                             .Id = row(0).ToString(),
                            .Nombre = row(1).ToString(),
                            .Facultad = row(3).ToString(),
                            .Status = Convert.ToBoolean(row(4)),
                            .CreatedBy = row(5).ToString()
                        }
                    End If
                End If
                Return currentCareer
            End Using

        Catch ex As Exception
            Throw ex


        End Try
    End Function

    Public Shared Function Delete(id As String, updatedBy As String) As Career
        Dim currentCareer As Career = Nothing
        Try
            Using conexion
                Dim query As String = "exec Carrera_Desactivar @id, @updatedBy"
                Dim command As New SqlDataAdapter(query, conexion)
                command.SelectCommand.Parameters.AddWithValue("@id", id)
                command.SelectCommand.Parameters.AddWithValue("@updatedBy", updatedBy)

                command.Fill(dataset, "career")
                conexion.Close()

                If dataset.Tables.Contains("career") AndAlso dataset.Tables("career").Rows.Count > 0 Then
                    If dataset.Tables("career").Rows.Count > 0 Then
                        Dim row As DataRow = dataset.Tables("career").Rows(0)
                        currentCareer = New Career With {
                             .Id = row(0).ToString(),
                            .Nombre = row(1).ToString(),
                            .Facultad = row(3).ToString(),
                            .Status = Convert.ToBoolean(row(4)),
                            .CreatedBy = row(5).ToString()
                        }
                    End If
                End If
                Return currentCareer
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
