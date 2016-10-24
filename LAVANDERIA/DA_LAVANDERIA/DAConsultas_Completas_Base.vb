Imports System.Data.SqlClient
Imports System.Windows.Forms
Public Class DAConsultas_Completas_Base
    Dim DA_MDL_Conexion_Global As New DA_MDL_Conexion_Global
    Dim cmd As New SqlConnection(DA_MDL_Conexion_Global.conexion_base)
    Dim dts As New DataTable

    Public Sub cargarClientes(ByVal id_cli As Integer, ByVal TXT_NOMBRE As TextBox, ByVal TXT_APE_PAT As TextBox, ByVal TXT_APE_MAT As TextBox, ByVal TXT_CORREO As TextBox, ByVal TXT_DNI As TextBox, ByVal DTP_FECHA_NAC As DateTimePicker, ByVal RB_NATURAL As RadioButton, ByVal RB_JURIDICA As RadioButton, ByVal TXT_CELULAR As TextBox, ByVal TXT_TELEFONO As TextBox)

        Dim consulta As String = "SELECT id_cli,nom_cli,apepat_cli,apemat_cli,correo,dni,celular,telefono,fecha_nac,id_tipo FROM cliente WHERE id_cli=" & id_cli
        Dim comando As New SqlCommand(consulta, cmd)
        Dim tabla As SqlDataReader

        cmd.Open()
        tabla = comando.ExecuteReader()

        If tabla.Read() Then

            TXT_NOMBRE.Text = tabla.Item("nom_cli").ToString()
            TXT_APE_PAT.Text = tabla.Item("apepat_cli").ToString
            TXT_APE_MAT.Text = tabla.Item("apemat_cli").ToString()
            TXT_CORREO.Text = tabla.Item("correo").ToString
            TXT_CELULAR.Text = tabla.Item("celular").ToString
            TXT_TELEFONO.Text = tabla.Item("telefono").ToString
            TXT_DNI.Text = tabla.Item("dni").ToString()
            If tabla.Item("fecha_nac").ToString = "" Then
                DTP_FECHA_NAC.Value = DateTime.Now
            Else
                DTP_FECHA_NAC.Value = tabla.Item("fecha_nac").ToString
            End If

            If tabla.Item("id_tipo").ToString = 5 Then
                RB_JURIDICA.Checked = False
                RB_NATURAL.Checked = True
            End If
            If tabla.Item("id_tipo").ToString = 6 Then
                RB_JURIDICA.Checked = True
                RB_NATURAL.Checked = False
            End If
        End If
        tabla.Close()
        cmd.Close()
    End Sub

    Public Sub cargarProveedores(ByVal id_prove As Integer, ByVal TXT_RAZON_SOCIAL As TextBox, ByVal TXT_RUC As TextBox, ByVal TXT_CELULAR As TextBox, ByVal TXT_TELEFONO As TextBox, ByVal TXT_CORREO As TextBox)

        Dim consulta As String = "select id_proveedor,razon_social,ruc,telefono,celular,correo from Proveedor where id_proveedor=" & id_prove & ";"
        Dim comando As New SqlCommand(consulta, cmd)
        Dim tabla As SqlDataReader

        cmd.Open()
        tabla = comando.ExecuteReader()

        If tabla.Read() Then
            TXT_RAZON_SOCIAL.Text = tabla.Item("razon_social").ToString()
            TXT_RUC.Text = tabla.Item("ruc").ToString
            TXT_TELEFONO.Text = tabla.Item("telefono").ToString()
            TXT_CELULAR.Text = tabla.Item("celular").ToString
            TXT_CORREO.Text = tabla.Item("correo").ToString
        End If
        tabla.Close()
        cmd.Close()
    End Sub

    Public Sub cargarDocumento_Pago(ByVal id_doc As Integer, ByVal TXT_DESCRIPCION As TextBox, ByVal DTP_FECHA_VENC As DateTimePicker, ByVal TXT_COD_DOC As TextBox, ByVal TXT_SERIE As TextBox, ByVal TXT_NUMERO As TextBox, ByVal TXT_MONTO_TOTAL As TextBox, ByVal TXT_OBSERVACION As TextBox, ByVal CB_ID_PROVEEDOR As ComboBox, ByVal CB_ID_SUCURSAL As ComboBox)

        Dim consulta As String = "SELECT id_docu,descripcion,fecha_venc,cod_doc,serie,numero,mto_total,observacion,id_proveedor,id_sucursal FROM Documento_pago where id_docu=" & id_doc
        Dim comando As New SqlCommand(consulta, cmd)
        Dim tabla As SqlDataReader

        cmd.Open()
        tabla = comando.ExecuteReader()

        If tabla.Read() Then

            TXT_DESCRIPCION.Text = tabla.Item("descripcion").ToString()
            DTP_FECHA_VENC.Value = tabla.Item("fecha_venc").ToString
            TXT_COD_DOC.Text = tabla.Item("cod_doc").ToString()
            TXT_SERIE.Text = tabla.Item("serie").ToString
            TXT_NUMERO.Text = tabla.Item("numero").ToString
            TXT_MONTO_TOTAL.Text = tabla.Item("mto_total").ToString
            TXT_OBSERVACION.Text = tabla.Item("observacion").ToString()
            CB_ID_PROVEEDOR.SelectedValue = tabla.Item("id_proveedor").ToString
            CB_ID_SUCURSAL.SelectedValue = tabla.Item("id_sucursal").ToString

        End If
        tabla.Close()
        cmd.Close()
    End Sub

    Public Sub cargarPromocion(ByVal id_promocion As Integer, ByVal TXT_CODIGO As TextBox, ByVal TXT_DESCRIPCION As TextBox, ByVal CB_SUCURSAL As ComboBox, ByVal DTP_FECHA_INI As DateTimePicker, ByVal DTP_FECHA_FIN As DateTimePicker)

        Dim consulta As String = "SELECT cod_promo,des_promo,id_sucursal,fec_ini,fec_fin FROM Promocion WHERE id_promocio=" & id_promocion
        Dim comando As New SqlCommand(consulta, cmd)
        Dim tabla As SqlDataReader

        cmd.Open()
        tabla = comando.ExecuteReader()

        If tabla.Read() Then
            TXT_CODIGO.Text = tabla.Item("cod_promo").ToString()
            TXT_DESCRIPCION.Text = tabla.Item("des_promo").ToString
            CB_SUCURSAL.Text = tabla.Item("id_sucursal").ToString()
            DTP_FECHA_INI.Value = tabla.Item("fec_ini").ToString
            DTP_FECHA_FIN.Value = tabla.Item("fec_fin").ToString
        End If

        tabla.Close()
        cmd.Close()
    End Sub

    Public Sub cargarServicios(ByVal id_serv As Integer, ByVal TXT_CODIGO As TextBox, ByVal TXT_NOMBRE As TextBox, ByVal TXT_PRECIO1 As TextBox, ByVal TXT_PRECIO2 As TextBox, ByVal CB_MEDIDA As ComboBox, ByVal CB_TIPO As ComboBox)

        Dim consulta As String = "select cod_serv,des_ser,precio1,precio2,id_unimed,id_tipo from servicio where id_serv =" & id_serv
        Dim comando As New SqlCommand(consulta, cmd)
        Dim tabla As SqlDataReader

        cmd.Open()
        tabla = comando.ExecuteReader()

        If tabla.Read() Then
            TXT_CODIGO.Text = tabla.Item("cod_serv").ToString()
            TXT_NOMBRE.Text = tabla.Item("des_ser").ToString()
            TXT_PRECIO1.Text = tabla.Item("precio1").ToString
            TXT_PRECIO2.Text = tabla.Item("precio2").ToString()
            CB_MEDIDA.SelectedValue = tabla.Item("id_unimed").ToString
            CB_TIPO.SelectedValue = tabla.Item("id_tipo").ToString
        End If

        tabla.Close()
        cmd.Close()
    End Sub

    Public Sub cargarEmpleados(ByVal id_emp As Integer, ByVal TXT_CODIGO As TextBox, ByVal TXT_NOMBRE As TextBox, ByVal TXT_APE_PAT As TextBox, ByVal TXT_APE_MAT As TextBox, ByVal TXT_DNI As TextBox, ByVal TXT_CELULAR As TextBox, ByVal DTP_FECHA_NAC As DateTimePicker, ByVal TXT_PERFIL As TextBox, ByVal TXT_USUARIO As TextBox, ByVal TXT_CONTRASENA As TextBox)

        Dim consulta As String = "SELECT e.id_emp,e.nom_emp,e.apepat_emp,e.apemat_emp,e.dni,e.fecha_nac,e.celular,u.nom_usu,u.clave_usu,p.nom_per FROM Empleado as e inner join Usuario as u on e.id_emp=u.id_emp inner join Perfil as p on u.id_perfil=p.id_perfil where e.id_emp=" & id_emp
        Dim comando As New SqlCommand(consulta, cmd)
        Dim tabla As SqlDataReader

        cmd.Open()
        tabla = comando.ExecuteReader()

        If tabla.Read() Then
            TXT_CODIGO.Text = tabla.Item("id_emp").ToString()
            TXT_NOMBRE.Text = tabla.Item("nom_emp").ToString()
            TXT_APE_PAT.Text = tabla.Item("apepat_emp").ToString
            TXT_APE_MAT.Text = tabla.Item("apemat_emp").ToString()
            TXT_DNI.Text = tabla.Item("dni").ToString
            If tabla.Item("fecha_nac").ToString = "" Then
                DTP_FECHA_NAC.Value = DateTime.Now
            Else
                DTP_FECHA_NAC.Value = tabla.Item("fecha_nac").ToString
            End If
            TXT_CELULAR.Text = tabla.Item("celular").ToString()
            TXT_PERFIL.Text = tabla.Item("nom_per").ToString
            TXT_USUARIO.Text = tabla.Item("nom_usu").ToString
            TXT_CONTRASENA.Text = tabla.Item("clave_usu").ToString
        End If

        tabla.Close()
        cmd.Close()
    End Sub

End Class
