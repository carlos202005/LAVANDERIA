Imports System.Data.SqlClient
Imports BE_LAVANDERIA
Public Class DAUsuarios
    Inherits Conexion
    Dim cmd As SqlCommand

    Public Function insertar_Usuarios(ByVal dts As BEUsuarios) As Boolean
        Try
            Conectar()
            cmd = New SqlCommand("insertarUsuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@nom_usu", dts.gnom_usu)
            cmd.Parameters.AddWithValue("@clave", dts.gclave_usu)
            cmd.Parameters.AddWithValue("@id_perfil", dts.gid_perfil)
            cmd.Parameters.AddWithValue("@id_emp", dts.gid_emp)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
            Desconectar()
        End Try
    End Function

    Public Function actualizar_Usuarios(ByVal dts As BEUsuarios) As Boolean
        Try
            Conectar()
            cmd = New SqlCommand("actualizarUsuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@id_usu", dts.gid_usu)
            cmd.Parameters.AddWithValue("@nom_usu", dts.gnom_usu)
            cmd.Parameters.AddWithValue("@clave", dts.gclave_usu)
            cmd.Parameters.AddWithValue("@id_perfil", dts.gid_perfil)
            cmd.Parameters.AddWithValue("@id_emp", dts.gid_emp)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
            Desconectar()
        End Try
    End Function

End Class
