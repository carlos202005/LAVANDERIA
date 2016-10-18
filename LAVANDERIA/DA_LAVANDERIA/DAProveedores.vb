Imports System.Data.SqlClient
Imports BE_LAVANDERIA
Public Class DAProveedores
    Inherits Conexion
    Dim cmd As SqlCommand
    Dim BEProveedores As New BEProveedores

    Public Function insertar_Proveedores(ByVal dts As BEProveedores) As Boolean
        Try
            Conectar()
            cmd = New SqlCommand("insertarProveedores")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@razon_social", dts.grazon_social)
            cmd.Parameters.AddWithValue("@ruc", dts.gruc)
            cmd.Parameters.AddWithValue("@telefono", dts.gtelefono)
            cmd.Parameters.AddWithValue("@celular", dts.gcelular)
            cmd.Parameters.AddWithValue("@correo", dts.gcorreo)
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

    Public Function actualizar_Proveedores(ByVal dts As BEProveedores) As Boolean
        Try
            Conectar()
            cmd = New SqlCommand("actualizarProveedores")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@id_proveedor", dts.gid_proveedor)
            cmd.Parameters.AddWithValue("@razon_social", dts.grazon_social)
            cmd.Parameters.AddWithValue("@ruc", dts.gruc)
            cmd.Parameters.AddWithValue("@telefono", dts.gtelefono)
            cmd.Parameters.AddWithValue("@celular", dts.gcelular)
            cmd.Parameters.AddWithValue("@correo", dts.gcorreo)
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

    Public Function eliminar_Proveedores(ByVal dts As BEProveedores) As Boolean
        Try
            Conectar()
            cmd = New SqlCommand("eliminarProveedores")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@id_proveedor", dts.gid_proveedor)
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
