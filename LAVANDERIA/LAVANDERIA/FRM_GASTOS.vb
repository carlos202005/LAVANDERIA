Imports BE_LAVANDERIA
Imports DA_LAVANDERIA
Public Class FRM_GASTOS

    Private Sub BTN_SALIR_Click(sender As Object, e As EventArgs) Handles BTN_SALIR.Click
        VARIABLES_GLOBALES.ID_RECIBOS = Nothing
        FRM_RECIBOS.Show()
        Me.Close()
    End Sub

    Private Sub BTN_ACEPTAR_Click(sender As Object, e As EventArgs) Handles BTN_ACEPTAR.Click
        Dim BEDocumento_Pago As New BEDocumento_Pago
        Dim DADocumento_Pago As New DADocumento_Pago

        If VARIABLES_GLOBALES.ID_RECIBOS = Nothing Then
            BEDocumento_Pago.gdescripcion = TXT_DESCRIPCION.Text
            BEDocumento_Pago.gfecha_vencimiento = Convert.ToDateTime(DTP_FECHA_VENCIMIENTO.Value).ToString("yyyy-MM-dd HH:mm:ss")
            BEDocumento_Pago.gcod_doc = TXT_CODIGO_DOC.Text
            BEDocumento_Pago.gserie = TXT_SERIE.Text
            BEDocumento_Pago.gnumero = TXT_NUMERO.Text
            BEDocumento_Pago.gmto_total = TXT_MONTO.Text
            BEDocumento_Pago.gobservacion = TXT_OBSERVACION.Text
            BEDocumento_Pago.gid_proveedor = CB_PROVEEDOR.SelectedValue
            BEDocumento_Pago.gid_sucursal = CB_SUCURSAL.SelectedValue
            BEDocumento_Pago.gusu_reg = VARIABLES_GLOBALES.ID_USUARIO

            If DADocumento_Pago.insertar_Documento_Pago(BEDocumento_Pago) Then
                MsgBox("RECIBO GUARDADO CORRECTAMENTE..!!")
            Else
                MsgBox("ERROR AL GUARDAR EL RECIBO...")
            End If

        Else
            BEDocumento_Pago.gid_docu = VARIABLES_GLOBALES.ID_RECIBOS
            BEDocumento_Pago.gdescripcion = TXT_DESCRIPCION.Text
            BEDocumento_Pago.gfecha_vencimiento = Convert.ToDateTime(DTP_FECHA_VENCIMIENTO.Value).ToString("yyyy-MM-dd HH:mm:ss")
            BEDocumento_Pago.gcod_doc = TXT_CODIGO_DOC.Text
            BEDocumento_Pago.gserie = TXT_SERIE.Text
            BEDocumento_Pago.gnumero = TXT_NUMERO.Text
            BEDocumento_Pago.gmto_total = TXT_MONTO.Text
            BEDocumento_Pago.gobservacion = TXT_OBSERVACION.Text
            BEDocumento_Pago.gid_proveedor = CB_PROVEEDOR.SelectedValue
            BEDocumento_Pago.gid_sucursal = CB_SUCURSAL.SelectedValue
            BEDocumento_Pago.gusu_reg = VARIABLES_GLOBALES.ID_USUARIO
            If DADocumento_Pago.actualizar_Documento_Pago(BEDocumento_Pago) Then
                MsgBox("RECIBO ACTUALIZADO CORRECTAMENTE..!!")
            Else
                MsgBox("ERROR AL ACTUALIZAR RECIBO...!!")
            End If
        End If
        VARIABLES_GLOBALES.ID_RECIBOS = Nothing
        FRM_RECIBOS.Show()
        Me.Close()
    End Sub

    Sub LIMPIAR()
        CB_SUCURSAL.SelectedIndex = 0
        TXT_CODIGO_DOC.Text = ""
        TXT_SERIE.Text = ""
        TXT_NUMERO.Text = ""
        TXT_DESCRIPCION.Text = ""
        DTP_FECHA_VENCIMIENTO.Value = Now
        TXT_MONTO.Text = ""
        CB_PROVEEDOR.SelectedIndex = 0
        TXT_OBSERVACION.Text = ""
    End Sub

    Private Sub FRM_GASTOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim DACargar_Combobox As New DACargar_Combobox
        DACargar_Combobox.cargarProveedor(CB_PROVEEDOR)
        DACargar_Combobox.cargarSucursal(CB_SUCURSAL)
        If VARIABLES_GLOBALES.ID_RECIBOS <> Nothing Then
            Dim DAConsultas_Completas_Base As New DAConsultas_Completas_Base
            DAConsultas_Completas_Base.cargarDocumento_Pago(VARIABLES_GLOBALES.ID_RECIBOS, TXT_DESCRIPCION, DTP_FECHA_VENCIMIENTO, TXT_CODIGO_DOC, TXT_SERIE, TXT_NUMERO, TXT_MONTO, TXT_OBSERVACION, CB_PROVEEDOR, CB_SUCURSAL)
        End If
    End Sub

    Private Sub TXT_SERIE_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles TXT_SERIE.PreviewKeyDown, TXT_NUMERO.PreviewKeyDown
        TXT_CODIGO_DOC.Text = TXT_SERIE.Text & "-" & TXT_NUMERO.Text
    End Sub

    Private Sub TXT_MONTO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_MONTO.KeyPress
        NumerosyDecimal(TXT_MONTO, e)
    End Sub

    Public Sub NumerosyDecimal(ByVal CajaTexto As TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not CajaTexto.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

End Class