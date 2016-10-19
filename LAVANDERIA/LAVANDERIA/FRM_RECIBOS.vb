Imports BE_LAVANDERIA
Imports DA_LAVANDERIA
Public Class FRM_RECIBOS
    Dim CODIGO As Integer = Nothing
    Dim dts As New DataTable
    Private Sub BTN_NUEVO_Click(sender As Object, e As EventArgs) Handles BTN_NUEVO.Click
        FRM_GASTOS.Show()
        Me.Close()
    End Sub

    Private Sub DGV_CLIENTES_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_RECIBOS.CellEnter
        CODIGO = Me.DGV_RECIBOS.CurrentRow.Cells.Item("CODIGO").Value.ToString()
    End Sub
    Private Sub BTN_SALIR_Click(sender As Object, e As EventArgs) Handles BTN_SALIR.Click
        Me.Close()
    End Sub

    Private Sub BTN_EDITAR_Click(sender As Object, e As EventArgs) Handles BTN_EDITAR.Click
        If CODIGO <> Nothing Then
            VARIABLES_GLOBALES.ID_RECIBOS = CODIGO
            FRM_GASTOS.Show()
            Me.Close()
        End If
    End Sub

    Private Sub BTN_ELIMINAR_Click(sender As Object, e As EventArgs) Handles BTN_ELIMINAR.Click
        If CODIGO <> Nothing Then
            If MsgBox("¿REALMENTE DESEA ELIMINAR EL RECIBO?", MsgBoxStyle.YesNo) = vbYes Then
                Dim DADocumento_Pago As New DADocumento_Pago
                Dim BEDocumento_Pago As New BEDocumento_Pago

                BEDocumento_Pago.gid_docu = CODIGO
                BEDocumento_Pago.gusu_eli = VARIABLES_GLOBALES.ID_USUARIO
                DADocumento_Pago.eliminar_Documento_Pago(BEDocumento_Pago)
                MsgBox("PRODUCTO ELIMINADO CORRECTAMENTE")
                CARGARDATAGRIDVIEW()
            End If
        End If
    End Sub

    Private Sub FRM_RECIBOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CARGARDATAGRIDVIEW()
    End Sub

    Sub CARGARDATAGRIDVIEW()
        Try
            Dim DACargarDataGridView As New DACargarDataGridView
            dts = DACargarDataGridView.Mostrar_Documentos_Pago()
            If dts.Rows.Count <> 0 Then
                DGV_RECIBOS.DataSource = dts
            Else
                DGV_RECIBOS.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BTN_VER_Click(sender As Object, e As EventArgs) Handles BTN_VER.Click
        If CODIGO <> Nothing Then
            Dim FRM_GASTOS As New FRM_GASTOS
            VARIABLES_GLOBALES.ID_RECIBOS = CODIGO
            FRM_GASTOS.BTN_ACEPTAR.Enabled = False
            FRM_GASTOS.BTN_ACEPTAR.Visible = False
            FRM_GASTOS.Show()
            Me.Close()
        End If
    End Sub
End Class