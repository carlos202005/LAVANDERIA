Imports System.Data.SqlClient
Imports BE_LAVANDERIA

Public Class DADocumento_Pago
    Inherits Conexion
    Dim cmd As SqlCommand

    Public Function insertar_Documento_Pago(ByVal dts As BEDocumento_Pago) As Boolean
        Try
            Conectar()
            cmd = New SqlCommand("insertarDocumento_Pago")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@descripcion", dts.gdescripcion)
            cmd.Parameters.AddWithValue("@fecha_venc", dts.gfecha_vencimiento)
            cmd.Parameters.AddWithValue("@cod_doc", dts.gcod_doc)
            cmd.Parameters.AddWithValue("@serie", dts.gserie)
            cmd.Parameters.AddWithValue("@numero", dts.gnumero)
            cmd.Parameters.AddWithValue("@mto_total", dts.gmto_total)
            cmd.Parameters.AddWithValue("@observacion", dts.gobservacion)
            cmd.Parameters.AddWithValue("@id_proveedor", dts.gid_proveedor)
            cmd.Parameters.AddWithValue("@id_sucursal", dts.gid_sucursal)
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

    Public Function actualizar_Documento_Pago(ByVal dts As BEDocumento_Pago) As Boolean
        Try
            Conectar()
            cmd = New SqlCommand("actualizarDocumento_Pago")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@id_docu", dts.gid_docu)
            cmd.Parameters.AddWithValue("@descripcion", dts.gdescripcion)
            cmd.Parameters.AddWithValue("@fecha_venc", dts.gfecha_vencimiento)
            cmd.Parameters.AddWithValue("@cod_doc", dts.gcod_doc)
            cmd.Parameters.AddWithValue("@serie", dts.gserie)
            cmd.Parameters.AddWithValue("@numero", dts.gnumero)
            cmd.Parameters.AddWithValue("@mto_total", dts.gmto_total)
            cmd.Parameters.AddWithValue("@observacion", dts.gobservacion)
            cmd.Parameters.AddWithValue("@id_proveedor", dts.gid_proveedor)
            cmd.Parameters.AddWithValue("@id_sucursal", dts.gid_sucursal)
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

    Public Function eliminar_Documento_Pago(ByVal dts As BEDocumento_Pago) As Boolean
        Try
            Conectar()
            cmd = New SqlCommand("eliminarDocumento_Pago")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@id_docu", dts.gid_docu)
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
