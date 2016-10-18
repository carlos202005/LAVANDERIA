Imports System.Data.SqlClient
Imports BE_LAVANDERIA
Public Class DAServicios
    Inherits Conexion
    Dim cmd As SqlCommand
    Dim BEServicios As New BEServicios

    Public Function insertar_Servicios(ByVal dts As BEServicios) As Boolean
        Try
            Conectar()
            cmd = New SqlCommand("insertarServicio")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@cod_ser", dts.gcod_serv)
            cmd.Parameters.AddWithValue("@precio1", dts.gprecio1)
            cmd.Parameters.AddWithValue("@precio2", dts.gprecio2)
            cmd.Parameters.AddWithValue("@des_ser", dts.gdes_ser)
            cmd.Parameters.AddWithValue("@id_unimed", dts.gid_unimed)
            cmd.Parameters.AddWithValue("@id_tipo", dts.gid_tipo)
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

    Public Function actualizar_Servicios(ByVal dts As BEServicios) As Boolean
        Try
            Conectar()
            cmd = New SqlCommand("actualizarServicio")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@id_serv", dts.gid_serv)
            cmd.Parameters.AddWithValue("@cod_ser", dts.gcod_serv)
            cmd.Parameters.AddWithValue("@precio1", dts.gprecio1)
            cmd.Parameters.AddWithValue("@precio2", dts.gprecio2)
            cmd.Parameters.AddWithValue("@des_ser", dts.gdes_ser)
            cmd.Parameters.AddWithValue("@id_unimed", dts.gid_unimed)
            cmd.Parameters.AddWithValue("@id_tipo", dts.gid_tipo)
            cmd.Parameters.AddWithValue("@usu_mod", dts.gusu_reg)

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

    Public Function eliminar_Servicios(ByVal dts As BEServicios) As Boolean
        Try
            Conectar()
            cmd = New SqlCommand("eliminarServicio")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@id_serv", dts.gid_serv)
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
