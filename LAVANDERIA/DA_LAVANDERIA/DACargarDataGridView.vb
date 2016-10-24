Imports System.Data.SqlClient
Public Class DACargarDataGridView
    Inherits Conexion
    Dim cmd As New SqlCommand

    Public Function Mostrar_Clientes() As DataTable
        Try
            Conectar()
            cmd = New SqlCommand("mostrarClientes")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            If cmd.ExecuteNonQuery Then
                Dim dts As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dts)
                Return dts

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            Desconectar()

        End Try
        Return Nothing
    End Function

    Public Function Mostrar_Clientes_Busqueda(ByVal nom_cli As String) As DataTable
        Try
            Conectar()
            cmd = New SqlCommand("buscarClienteNombre")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@nom_cli", nom_cli)

            If cmd.ExecuteNonQuery Then
                Dim dts As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dts)
                Return dts

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            Desconectar()

        End Try
        Return Nothing
    End Function

    Public Function Mostrar_Clientes_DNI_Busqueda(ByVal dni_cli As String) As DataTable
        Try
            Conectar()
            cmd = New SqlCommand("buscarClienteDNI")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@DNI", dni_cli)

            If cmd.ExecuteNonQuery Then
                Dim dts As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dts)
                Return dts

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            Desconectar()

        End Try
        Return Nothing
    End Function

    Public Function Mostrar_Servicios() As DataTable
        Try
            Conectar()
            cmd = New SqlCommand("mostrarServicios")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            If cmd.ExecuteNonQuery Then
                Dim dts As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dts)
                Return dts

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            Desconectar()

        End Try
        Return Nothing
    End Function

    Public Function Mostrar_Servicios_Busqueda(ByVal des_ser As String) As DataTable
        Try
            Conectar()
            cmd = New SqlCommand("buscarServicioNombre")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@des_ser", des_ser)

            If cmd.ExecuteNonQuery Then
                Dim dts As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dts)
                Return dts

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            Desconectar()

        End Try
        Return Nothing
    End Function

    Public Function Mostrar_Servicios_CODIGO_Busqueda(ByVal cod_serv As String) As DataTable
        Try
            Conectar()
            cmd = New SqlCommand("buscarServicioCODIGO")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@cod_serv", cod_serv)

            If cmd.ExecuteNonQuery Then
                Dim dts As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dts)
                Return dts

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            Desconectar()

        End Try
        Return Nothing
    End Function

    Public Function Mostrar_Promociones() As DataTable
        Try
            Conectar()
            cmd = New SqlCommand("mostrarPromociones")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            If cmd.ExecuteNonQuery Then
                Dim dts As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dts)
                Return dts

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            Desconectar()

        End Try
        Return Nothing
    End Function

    Public Function Mostrar_Proveedores() As DataTable
        Try
            Conectar()
            cmd = New SqlCommand("mostrarProveedores")
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn

            If cmd.ExecuteNonQuery Then
                Dim dts As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dts)
                Return dts

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            Desconectar()

        End Try
        Return Nothing
    End Function

    Public Function Mostrar_Proveedores_Busqueda(ByVal razon_social As String) As DataTable
        Try
            Conectar()
            cmd = New SqlCommand("buscarProveedorNombre")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@razon_social", razon_social)

            If cmd.ExecuteNonQuery Then
                Dim dts As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dts)
                Return dts

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            Desconectar()
        End Try
        Return Nothing
    End Function

    Public Function Mostrar_Proveedores_RUC_Busqueda(ByVal ruc_prov As String) As DataTable
        Try
            Conectar()
            cmd = New SqlCommand("buscarProveedorRUC")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@ruc_prov", ruc_prov)

            If cmd.ExecuteNonQuery Then
                Dim dts As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dts)
                Return dts

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            Desconectar()
        End Try
        Return Nothing
    End Function

    Public Function Mostrar_Documentos_Pago() As DataTable
        Try
            Conectar()
            cmd = New SqlCommand("mostrarDocumentos_Pago")
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn

            If cmd.ExecuteNonQuery Then
                Dim dts As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dts)
                Return dts

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            Desconectar()

        End Try
        Return Nothing
    End Function

    Public Function Mostrar_Promocion_Detalle(ByVal id_promocion As Integer) As DataTable
        Try
            Conectar()
            cmd = New SqlCommand("mostrarPromocion_Detalle")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@id_promo", id_promocion)

            If cmd.ExecuteNonQuery Then
                Dim dts As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dts)
                Return dts
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            Desconectar()
        End Try
        Return Nothing
    End Function

    Public Function Mostrar_Empleados() As DataTable
        Try
            Conectar()
            cmd = New SqlCommand("mostrarEmpleados")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            If cmd.ExecuteNonQuery Then
                Dim dts As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dts)
                Return dts
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            Desconectar()
        End Try
        Return Nothing
    End Function

    Public Function Mostrar_Empleados_Busqueda(ByVal nom_emp As String) As DataTable
        Try
            Conectar()
            cmd = New SqlCommand("buscarEmpleadoNombre")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@nom_emp", nom_emp)

            If cmd.ExecuteNonQuery Then
                Dim dts As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dts)
                Return dts
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            Desconectar()
        End Try
        Return Nothing
    End Function

    Public Function Mostrar_Empleados_DNI_Busqueda(ByVal dni_emp As String) As DataTable
        Try
            Conectar()
            cmd = New SqlCommand("buscarEmpleadoDNI")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@dni_emp", dni_emp)

            If cmd.ExecuteNonQuery Then
                Dim dts As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dts)
                Return dts
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            Desconectar()
        End Try
        Return Nothing
    End Function

End Class
