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
End Class