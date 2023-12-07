Imports System.Data.SqlClient

Public Class ActivityService
    Private Shared ReadOnly conexion As SqlConnection = Connection.OpenConnection()
    Private Shared dataset As New DataSet()

    Public Shared Function Save(id As String, nombre As String, ente As String, horas As Integer, fecha As String, lugar As String, tutor As String, createdBy As String) As Activity
        Dim currentActivity As Activity = Nothing
        If conexion.State = ConnectionState.Closed Then
            conexion.Open()
        End If
        Try
            Using conexion
                Dim query As String = "exec Proyecto_Guardar2 @id, @nombre,@ente_rector, @cantidad_horas, @fecha_ejecuion, @lugar, @tutor, @updatedBy"
                Dim command As New SqlDataAdapter(query, conexion)
                command.SelectCommand.Parameters.AddWithValue("@id", id)
                command.SelectCommand.Parameters.AddWithValue("@nombre", nombre)
                command.SelectCommand.Parameters.AddWithValue("@ente_rector", ente)
                command.SelectCommand.Parameters.AddWithValue("@cantidad_horas", horas)
                command.SelectCommand.Parameters.AddWithValue("@fecha_ejecuion", fecha)
                command.SelectCommand.Parameters.AddWithValue("@lugar", lugar)
                command.SelectCommand.Parameters.AddWithValue("@tutor", tutor)
                command.SelectCommand.Parameters.AddWithValue("@updatedBy", createdBy)
                command.Fill(dataset, "activity")
                conexion.Close()

                If dataset.Tables.Contains("activity") AndAlso dataset.Tables("activity").Rows.Count > 0 Then
                    If dataset.Tables("activity").Rows.Count > 0 Then
                        Dim row As DataRow = dataset.Tables("activity").Rows(0)
                        currentActivity = New Activity With {
                            .IdProyecto = row(0).ToString(),
                            .Nombre = row(1).ToString(),
                            .EnteRector = row(2).ToString(),
                            .FechaEjecucion = row(3).ToString(),
                            .CantidadHoras = CInt(row(4)),
                            .Lugar = row(4).ToString(),
                            .Status = Convert.ToBoolean(row(5)),
                            .CreatedBy = row(6).ToString()
                        }
                    End If
                End If
                Return currentActivity
            End Using
        Catch ex As Exception
            Throw ex

        End Try
    End Function
End Class
