Imports System.Data.SqlClient


Public Class PeopleService
    Private Shared ReadOnly conexion As SqlConnection = Connection.OpenConnection()
    Private Shared dataset As New DataSet()
    Public Shared Function Login(id As String) As DataTable
        Try
            conexion.Open()
            Using conexion

                Dim query As String = "exec Persona_Login @id"
                Dim command As New SqlDataAdapter(query, conexion)
                command.SelectCommand.Parameters.AddWithValue("@id", id)
                command.Fill(dataset, "login")
                conexion.Close()
                command = Nothing

                Return dataset.Tables("login")
            End Using
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Shared Function Listar() As List(Of Person)
        Dim query As String = "exec Persona_Listar @limit, @at"
        Dim command As New SqlDataAdapter(query, conexion)
        command.SelectCommand.Parameters.AddWithValue("@limit", 10)
        command.SelectCommand.Parameters.AddWithValue("@at", 0)
        Try
            If conexion.State = ConnectionState.Closed Then
                conexion.Open()
            End If

            Using dataset As New DataSet()
                command.Fill(dataset, "person")

                If dataset.Tables.Contains("person") AndAlso dataset.Tables("person").Rows.Count > 0 Then
                    Dim dataTable As DataTable = dataset.Tables("person")

                    Dim listaDeRegistros As New List(Of Person)
                    For Each row As DataRow In dataTable.Rows
                        Dim persona As New Person With {
                        .Cedula = row(0).ToString(),
                        .Nombre = row(1).ToString(),
                        .Apellido = row(2).ToString(),
                        .Sexo = If(Convert.ToBoolean(row(3)), "Femenino", "Masculino"),
                        .Telefono = row(4).ToString(),
                        .Status = Convert.ToBoolean(row(6))
                    }
                        listaDeRegistros.Add(persona)
                    Next

                    Return listaDeRegistros
                Else
                    Return New List(Of Person)
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

    Public Shared Function Search(id As String) As DataTable
        Dim query As String = "exec Persona_Buscar @cip"
        Dim command As New SqlDataAdapter(query, conexion)
        command.SelectCommand.Parameters.AddWithValue("@cip", id)
        Try
            If conexion.State = ConnectionState.Closed Then
                conexion.Open()
            End If

            Using dataset As New DataSet()
                command.Fill(dataset, "person")

                If dataset.Tables.Contains("person") AndAlso dataset.Tables("person").Rows.Count > 0 Then
                    command = Nothing
                    Return dataset.Tables("person")
                Else
                    command = Nothing
                    Return Nothing
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


    Public Shared Function Save(cedula As String, nombre As String, apellido As String, telefono As String, sexo As Integer, password As String) As DataTable
        Try
            Using conexion
                Dim query As String = "exec Persona_Guardar @cedula, @nombre, @apellido, @sexo, @telefono, @contrasenia"
                Dim command As New SqlDataAdapter(query, conexion)
                command.SelectCommand.Parameters.AddWithValue("@cedula", cedula)
                command.SelectCommand.Parameters.AddWithValue("@nombre", nombre)
                command.SelectCommand.Parameters.AddWithValue("@apellido", apellido)
                command.SelectCommand.Parameters.AddWithValue("@sexo", telefono)
                command.SelectCommand.Parameters.AddWithValue("@telefono", sexo)
                command.SelectCommand.Parameters.AddWithValue("@contrasenia", password)
                command.Fill(dataset, "person")
                conexion.Close()
                command = Nothing
                Return dataset.Tables("person")
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function Delete(id As String) As DataTable
        Dim query As String = "exec Persona_Desactivar @cip"
        Dim command As New SqlDataAdapter(query, conexion)
        command.SelectCommand.Parameters.AddWithValue("@cip", id)
        Try
            If conexion.State = ConnectionState.Closed Then
                conexion.Open()
            End If

            Using dataset As New DataSet()
                command.Fill(dataset, "person")

                If dataset.Tables.Contains("person") AndAlso dataset.Tables("person").Rows.Count > 0 Then
                    command = Nothing
                    Return dataset.Tables("person")
                Else
                    command = Nothing
                    Return Nothing
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
End Class
