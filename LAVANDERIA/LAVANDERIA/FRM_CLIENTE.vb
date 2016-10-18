Public Class FRM_CLIENTE
    Dim CODIGO As Integer
    Private Sub BTN_NUEVO_Click(sender As Object, e As EventArgs) Handles BTN_NUEVO.Click
        FRM_CLIENTE_CRUD.ShowDialog()
    End Sub

    Private Sub BTN_SALIR_Click(sender As Object, e As EventArgs) Handles BTN_SALIR.Click
        Me.Close()
    End Sub

    Private Sub DGV_CLIENTES_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_CLIENTES.CellEnter
        CODIGO = Me.DGV_CLIENTES.CurrentRow.Cells.Item("CODIGO").Value.ToString()
    End Sub

    Private Sub BTN_EDITAR_Click(sender As Object, e As EventArgs) Handles BTN_EDITAR.Click
        VARIABLES_GLOBALES.ID_CLIENTE = CODIGO
        FRM_CLIENTE_CRUD.ShowDialog()
    End Sub
End Class