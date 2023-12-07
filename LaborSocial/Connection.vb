Imports System.Data.SqlClient

Public Class Connection
    Private Shared connectionString As String = "Initial catalog=LaborSocial; Data Source=DESKTOP-8DPA547\SQLEXPRESS; Integrated Security=true; USER ID=sa; password=!Onyxs0820"

    Private Shared connection As New SqlConnection(connectionString)

    Public Shared Function OpenConnection() As SqlConnection
        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
            Return connection
        Catch ex As Exception
            MsgBox("No se pudo conectar con la base de datos, revisa los logs.")
            Throw ex
        End Try
    End Function

    Public Shared Sub CloseConnection()
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
