Imports BE_LAVANDERIA
Imports DA_LAVANDERIA
Public Class FRM_PROMOCIONES_D
    Private Sub FRM_PROMOCIONES_D_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CARGARDATAGRIDVIEW()
    End Sub
    Dim CODIGO As Integer = Nothing
    Dim dts As New DataTable

    Private Sub BTN_SALIR_Click(sender As Object, e As EventArgs) Handles BTN_SALIR.Click
        Me.Close()
    End Sub
    Private Sub DGV_CLIENTES_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_PROMOCIONES.CellEnter
        CODIGO = Me.DGV_PROMOCIONES.CurrentRow.Cells.Item("CODIGO").Value.ToString()
    End Sub

    Private Sub BTN_NUEVO_Click(sender As Object, e As EventArgs) Handles BTN_NUEVO.Click
        VARIABLES_GLOBALES.ID_PROMOCION = Nothing
        FRM_PROMOCIONES.Show()
        Me.Close()
    End Sub
    Sub CARGARDATAGRIDVIEW()
        Try
            Dim DACargarDataGridView As New DACargarDataGridView
            dts = DACargarDataGridView.Mostrar_Promociones()
            If dts.Rows.Count <> 0 Then
                DGV_PROMOCIONES.DataSource = dts
            Else
                DGV_PROMOCIONES.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BTN_EDITAR_Click(sender As Object, e As EventArgs) Handles BTN_EDITAR.Click
        If CODIGO <> Nothing Then
            VARIABLES_GLOBALES.ID_PROMOCION = CODIGO
            FRM_PROMOCIONES.Show()
            Me.Close()
        End If
    End Sub

    Private Sub BTN_VER_Click(sender As Object, e As EventArgs) Handles BTN_VER.Click
        If CODIGO <> Nothing Then
            Dim FRM_PROMOCIONES As New FRM_PROMOCIONES
            FRM_PROMOCIONES.BTN_ACEPTAR.Enabled = False
            FRM_PROMOCIONES.BTN_ACEPTAR.Visible = False
            VARIABLES_GLOBALES.ID_PROMOCION = CODIGO
            FRM_PROMOCIONES.Show()
            Me.Close()
        End If

    End Sub

    Private Sub BTN_ELIMINAR_Click(sender As Object, e As EventArgs) Handles BTN_ELIMINAR.Click
        If CODIGO <> Nothing Then
            If MsgBox("¿REALMENTE DESEA ELIMINAR ESTA PROMOCION DE SU LISTA?", MsgBoxStyle.YesNo) = vbYes Then
                Dim BEPromocion As New BEPromocion
                Dim DAPromociones As New DAPromociones

                BEPromocion.gid_promocion = CODIGO
                BEPromocion.gusu_eli = VARIABLES_GLOBALES.ID_USUARIO
                DAPromociones.eliminar_Promociones(BEPromocion)
                MsgBox("PROMOCION ELIMINADO CORRECTAMENTE..!!")
                CARGARDATAGRIDVIEW()
            End If
        End If

    End Sub
End Class