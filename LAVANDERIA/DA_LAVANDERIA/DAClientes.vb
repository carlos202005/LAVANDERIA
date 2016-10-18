Imports System.Data.SqlClient
Imports BE_LAVANDERIA
Public Class DAClientes
    Inherits Conexion
    Dim cmd As SqlCommand
    Dim BEClientes As New BEClientes

    Public Function insertar_Clientes(ByVal dts As BEClientes) As Boolean
        Try
            Conectar()
            cmd = New SqlCommand("insertarClientes")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@nom_cli", dts.gnom_cli)
            cmd.Parameters.AddWithValue("@apepat_cli", dts.gapepat_cli)
            cmd.Parameters.AddWithValue("@apemat_cli", dts.gapemat_cli)
            cmd.Parameters.AddWithValue("@correo", dts.gcorreo)
            cmd.Parameters.AddWithValue("@dni", dts.gdni)
            cmd.Parameters.AddWithValue("@celular", dts.gcelular)
            cmd.Parameters.AddWithValue("@fecha_nac", dts.gfec_nacimiento)
            cmd.Parameters.AddWithValue("@telefono", dts.gtelefono)
            cmd.Parameters.AddWithValue("@usu_reg", dts.gusu_reg)
            cmd.Parameters.AddWithValue("@id_tipo", dts.gid_tipo)
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

    Public Function actualizar_Clientes(ByVal dts As BEClientes) As Boolean
        Try
            Conectar()
            cmd = New SqlCommand("actualizarClientes")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@id_cli", dts.gid_cli)
            cmd.Parameters.AddWithValue("@nom_cli", dts.gnom_cli)
            cmd.Parameters.AddWithValue("@apepat_cli", dts.gapepat_cli)
            cmd.Parameters.AddWithValue("@apemat_cli", dts.gapemat_cli)
            cmd.Parameters.AddWithValue("@correo", dts.gcorreo)
            cmd.Parameters.AddWithValue("@dni", dts.gdni)
            cmd.Parameters.AddWithValue("@celular", dts.gcelular)
            cmd.Parameters.AddWithValue("@fecha_nac", dts.gfec_nacimiento)
            cmd.Parameters.AddWithValue("@telefono", dts.gtelefono)
            cmd.Parameters.AddWithValue("@usu_mod", dts.gusu_mod)
            cmd.Parameters.AddWithValue("@id_tipo ", dts.gid_tipo)
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

    Public Function eliminar_Clientes(ByVal dts As BEClientes) As Boolean
        Try
            Conectar()
            cmd = New SqlCommand("eliminarClientes")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@id_cli", dts.gid_cli)
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
