Imports System.Data.SqlClient
Imports BE_LAVANDERIA

Public Class DAPerfil
    Inherits Conexion
    Dim cmd As SqlCommand

    Public Function insertar_Perfil(ByVal dts As BEPerfil) As Boolean
        Try
            Conectar()
            cmd = New SqlCommand("insertarPerfil")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@nom_per", dts.gnom_per)
            cmd.Parameters.AddWithValue("@usu_reg", dts.gusu_reg)

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


    Public Function actualizar_Perfil(ByVal dts As BEPerfil) As Boolean
        Try
            Conectar()
            cmd = New SqlCommand("actualizarPerfil")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@id_perfil", dts.gid_perfil)
            cmd.Parameters.AddWithValue("@nom_per", dts.gnom_per)
            cmd.Parameters.AddWithValue("@usu_mod", dts.gusu_mod)

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



    Public Function eliminar_Perfil(ByVal dts As BEPerfil) As Boolean
        Try
            Conectar()
            cmd = New SqlCommand("eliminarPerfil")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@id_perfil", dts.gid_perfil)
            cmd.Parameters.AddWithValue("@usu_eli", dts.gusu_eli)

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

