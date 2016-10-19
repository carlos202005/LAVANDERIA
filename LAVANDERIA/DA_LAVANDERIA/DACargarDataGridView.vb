Imports System.Data.SqlClient
Public Class DACargarDataGridView
    Inherits Conexion
    Dim cmd As New SqlCommand

    Public Function Mostrar_Clientes() As DataTable
        Try
            Conectar()
            cmd = New SqlCommand("select id_cli as 'CODIGO',nom_cli as 'NOMBRE(S)',apepat_cli + ' ' + apemat_cli as 'APELLIDOS',celular as 'CELULAR' from cliente where flg_estadi='A';")
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

    Public Function Mostrar_Servicios() As DataTable
        Try
            Conectar()
            cmd = New SqlCommand("SELECT cod_serv as 'CODIGO',des_ser as 'DESCRIPCION',precio1 as 'PRECIO 1',precio2 as 'PRECIO 2' FROM Servicio where flg_estado='A';")
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



    Public Function Mostrar_Promociones() As DataTable
        Try
            Conectar()
            cmd = New SqlCommand("SELECT id_promocio as CODIGO,cod_promo as 'ID_PROMOCION',des_promo as 'DESCRIPCION',fec_ini,fec_fin FROM Promocion WHERE flg_estado='A';")
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

    Public Function Mostrar_Proveedores() As DataTable
        Try
            Conectar()
            cmd = New SqlCommand("select id_proveedor as CODIGO,razon_social as 'RAZON SOCIAL',ruc as 'RUC',telefono as 'TELEFONO',celular as 'CELULAR',correo as 'EMAIL' from Proveedor where flg_estado='A'; ")
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

    Public Function Mostrar_Documentos_Pago() As DataTable
        Try
            Conectar()
            cmd = New SqlCommand("select id_docu as CODIGO,descripcion as DSCRIPCION,fecha_venc as 'FECHA LIMITE',mto_total as 'TOTAL' from Documento_pago where flg_estado='A';")
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
            cmd = New SqlCommand("select pd.id_serv as 'COD. SERV.',(select s.des_ser from Servicio as s where s.id_serv=pd.id_serv) as 'SERVICIO',cantserv,id_servbono AS 'COD. BONO.',(select s.des_ser from Servicio as s where s.id_serv=pd.id_servbono) as 'SERV. BONO.',cantbono from Promocion_det as pd where id_promocio=" & id_promocion)
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

End Class
