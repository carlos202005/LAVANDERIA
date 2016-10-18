Imports System.Data.SqlClient
Imports BE_LAVANDERIA

Public Class DAPromociones
    Inherits Conexion
    Dim cmd As SqlCommand

    Public Function insertar_Promociones(ByVal dts As BEPromocion) As Boolean
        Try
            Conectar()
            cmd = New SqlCommand("insertarPromocion")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@cod_promo", dts.gcod_promo)
            cmd.Parameters.AddWithValue("@des_promo", dts.gdes_promo)
            cmd.Parameters.AddWithValue("@id_sucursal", dts.gid_suculsal)
            cmd.Parameters.AddWithValue("@fec_ini", dts.gfec_ini)
            cmd.Parameters.AddWithValue("@fec_fin", dts.gfec_fin)
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

    Public Function actualizar_Promociones(ByVal dts As BEPromocion) As Boolean
        Try
            Conectar()
            cmd = New SqlCommand("actualizarPromocion")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@id_promocion", dts.gid_promocion)
            cmd.Parameters.AddWithValue("@cod_promo", dts.gcod_promo)
            cmd.Parameters.AddWithValue("@des_promo", dts.gdes_promo)
            cmd.Parameters.AddWithValue("@id_sucursal", dts.gid_suculsal)
            cmd.Parameters.AddWithValue("@fec_ini", dts.gfec_ini)
            cmd.Parameters.AddWithValue("@fec_fin", dts.gfec_fin)
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

    Public Function eliminar_Promociones(ByVal dts As BEPromocion) As Boolean
        Try
            Conectar()
            cmd = New SqlCommand("eliminarPromocion")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@id_promocion", dts.gid_promocion)
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
