Public Class FRM_PRINCIPAL
    Private Sub PorEntradasEnCajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorEntradasEnCajaToolStripMenuItem.Click

    End Sub

    Private Sub BTN_SALIR_Click(sender As Object, e As EventArgs) Handles BTN_SALIR.Click
        Me.Close()
    End Sub

    Private Sub BNT_CLIENTES_Click(sender As Object, e As EventArgs) Handles BNT_CLIENTES.Click
        FRM_CLIENTE.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        FRM_CLIENTE.Show()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        FRM_PROVEEDORES.Show()
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        FRM_USUARIOS.Show()
    End Sub

    Private Sub RecibosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecibosToolStripMenuItem.Click
        FRM_RECIBOS.Show()
    End Sub

    Private Sub PagosExtraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PagosExtraToolStripMenuItem.Click
        FRM_PAGOS_EXTRA.Show()
    End Sub

    Private Sub InsumosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsumosToolStripMenuItem.Click
        FRM_INSUMOS.Show()
    End Sub

    Private Sub BTN_ENTREGA_Click(sender As Object, e As EventArgs) Handles BTN_ENTREGA.Click
        FRM_ENTREGA_SERVICIO.Show()
    End Sub

    Private Sub EntregaDePedidoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntregaDePedidoToolStripMenuItem.Click
        FRM_ENTREGA_SERVICIO.Show()
    End Sub

    Private Sub OrdenDePedidoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenDePedidoToolStripMenuItem.Click
        FRM_ORDEN_PEDIDO.Show()
    End Sub

    Private Sub VentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentaToolStripMenuItem.Click
        FRM_VENTAS.Show()
    End Sub

    Private Sub BTN_VENTAS_Click(sender As Object, e As EventArgs) Handles BTN_VENTAS.Click
        FRM_VENTAS.Show()
    End Sub

    Private Sub BTN_ORDEN_Click(sender As Object, e As EventArgs) Handles BTN_ORDEN.Click
        FRM_ORDEN_PEDIDO.Show()
    End Sub

    Private Sub BTN_INSUMOS_Click(sender As Object, e As EventArgs) Handles BTN_INSUMOS.Click
        Dim FRM As New FRM_INSERTAR_GASTOS
        FRM.TAB_CONTROL1.SelectedIndex = 0
        FRM.Show()

    End Sub

    Private Sub BTN_PAGOS_EXTRA_Click(sender As Object, e As EventArgs) Handles BTN_PAGOS_EXTRA.Click
        Dim FRM As New FRM_INSERTAR_GASTOS
        FRM.TAB_CONTROL1.SelectedIndex = 2
        FRM.Show()
    End Sub

    Private Sub AperturaDeCajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AperturaDeCajaToolStripMenuItem.Click
        FRM_APERTURA_CAJA.Show()
    End Sub

    Private Sub CierreDeCajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CierreDeCajaToolStripMenuItem.Click
        FRM_CIERRE_CAJA.Show()
    End Sub

    Private Sub PrendasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrendasToolStripMenuItem.Click
        Dim FRM As New FRM_INSERTAR_SERVICIOS
        FRM.TAB_CONTROL1.SelectedIndex = 1
        FRM.Show()
    End Sub

    Private Sub ServiciosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ServiciosToolStripMenuItem1.Click
        FRM_SERVICIOS.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub BTN_FACTURA_Click(sender As Object, e As EventArgs) Handles BTN_FACTURA.Click
        Dim FRM As New FRM_INSERTAR_GASTOS
        FRM.TAB_CONTROL1.SelectedIndex = 1
        FRM.Show()
    End Sub
End Class