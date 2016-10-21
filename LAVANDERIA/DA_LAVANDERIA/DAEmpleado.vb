Imports System.Data.SqlClient
Imports BE_LAVANDERIA

Public Class DAEmpleado
    Inherits Conexion
    Dim cmd As SqlCommand

    Public Function insertar_Empleados(ByVal dts As BEEmpleado) As Boolean
        Try
            Conectar()
            cmd = New SqlCommand("insertarEmpleados")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@nom_emp", dts.gnom_emp)
            cmd.Parameters.AddWithValue("@apepat_emp", dts.gapet_pat)
            cmd.Parameters.AddWithValue("@apemat_ep", dts.gapet_mat)
            cmd.Parameters.AddWithValue("@dni", dts.gdni)
            cmd.Parameters.AddWithValue("@fecha_nac", dts.gfecha_nac)
            cmd.Parameters.AddWithValue("@celular", dts.gcelular)
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


    Public Function actualizar_Empleados(ByVal dts As BEEmpleado) As Boolean
        Try
            Conectar()
            cmd = New SqlCommand("actualizarEmpleado")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@id_emp", dts.gid_emp)
            cmd.Parameters.AddWithValue("@nom_emp", dts.gnom_emp)
            cmd.Parameters.AddWithValue("@apepat_emp", dts.gapet_pat)
            cmd.Parameters.AddWithValue("@apemat_ep", dts.gapet_mat)
            cmd.Parameters.AddWithValue("@dni", dts.gdni)
            cmd.Parameters.AddWithValue("@fecha_nac", dts.gfecha_nac)
            cmd.Parameters.AddWithValue("@celular", dts.gcelular)
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

    Public Function eliminar_Empleados(ByVal dts As BEEmpleado) As Boolean
        Try
            Conectar()
            cmd = New SqlCommand("eliminarEmpleado")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@id_emp", dts.gid_emp)
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
