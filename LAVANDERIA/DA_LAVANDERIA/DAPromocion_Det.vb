Imports System.Data.SqlClient
Imports BE_LAVANDERIA
Public Class DAPromocion_Det
    Inherits Conexion
    Dim cmd As SqlCommand

    Public Function insertar_Promociones_Det(ByVal dts As BEPromocion_Det) As Boolean
        Try
            Conectar()
            cmd = New SqlCommand("insertarPromocion_Det")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@id_serv", dts.gid_serv)
            cmd.Parameters.AddWithValue("@cantserv", dts.gcantserv)
            cmd.Parameters.AddWithValue("@id_servbono", dts.gid_servbono)
            cmd.Parameters.AddWithValue("@cantbono", dts.gcantbono)
            cmd.Parameters.AddWithValue("@id_promocion", dts.gid_promocion)

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

    Public Function actualizar_Promociones_Det(ByVal dts As BEPromocion_Det) As Boolean
        Try
            Conectar()
            cmd = New SqlCommand("actualizarPromocion_Det")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@id_promodet", dts.gid_promodet)
            cmd.Parameters.AddWithValue("@id_serv", dts.gid_serv)
            cmd.Parameters.AddWithValue("@cantserv", dts.gcantserv)
            cmd.Parameters.AddWithValue("@id_servbono", dts.gid_servbono)
            cmd.Parameters.AddWithValue("@cantbono", dts.gcantbono)
            cmd.Parameters.AddWithValue("@id_promocion", dts.gid_promocion)

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

    Public Function eliminar_Promociones_Det(ByVal dts As BEPromocion_Det) As Boolean
        Try
            Conectar()
            cmd = New SqlCommand("eliminarPromocion_Det")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@id_promocion_det", dts.gid_promodet)

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
