Imports BE_LAVANDERIA
Imports DA_LAVANDERIA

Public Class FRM_PROVEEDORES
    Dim CODIGO As Integer = Nothing
    Dim dts As New DataTable
    Private Sub BTN_NUEVO_Click(sender As Object, e As EventArgs) Handles BTN_NUEVO.Click
        FRM_PROVEEDORES_CRUD.Show()
        Me.Close()
    End Sub

    Private Sub BTN_SALIR_Click(sender As Object, e As EventArgs) Handles BTN_SALIR.Click
        Me.Close()
    End Sub

    Private Sub BTN_EDITAR_Click(sender As Object, e As EventArgs) Handles BTN_EDITAR.Click
        If CODIGO <> Nothing Then
            VARIABLES_GLOBALES.ID_PROVEEDOR = CODIGO
            FRM_PROVEEDORES_CRUD.Show()
            Me.Close()
        End If
    End Sub

    Private Sub DGV_CLIENTES_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_PROVEEDORES.CellEnter
        CODIGO = Me.DGV_PROVEEDORES.CurrentRow.Cells.Item("CODIGO").Value.ToString()
    End Sub

    Sub CARGARDATAGRIDVIEW()
        Try
            Dim DACargarDataGridView As New DACargarDataGridView
            dts = DACargarDataGridView.Mostrar_Proveedores()
            If dts.Rows.Count <> 0 Then
                DGV_PROVEEDORES.DataSource = dts
            Else
                DGV_PROVEEDORES.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BTN_ELIMINAR_Click(sender As Object, e As EventArgs) Handles BTN_ELIMINAR.Click
        If CODIGO <> Nothing Then
            If MsgBox("¿REALMENTE QUIERES ELIMINAR A ESTE PROVEEDOR?", MsgBoxStyle.YesNo) = vbYes Then
                Dim DAProveedores As New DAProveedores
                Dim BEProveedores As New BEProveedores
                BEProveedores.gid_proveedor = CODIGO
                BEProveedores.gusu_eli = VARIABLES_GLOBALES.ID_USUARIO
                DAProveedores.eliminar_Proveedores(BEProveedores)
                MsgBox("PROVEEDOR ELIMINADO CORRECTAMENTE...!!")
                CARGARDATAGRIDVIEW()
            End If
        Else
            MsgBox("SELECCIONE PRIMERO UN PROVEEDOR PARA PODER ELIMINARLO...!!")
        End If
    End Sub

    Private Sub BTN_VER_Click(sender As Object, e As EventArgs) Handles BTN_VER.Click
        If CODIGO <> Nothing Then
            Dim FRM_PROVEEDORES_CRUD As New FRM_PROVEEDORES_CRUD
            VARIABLES_GLOBALES.ID_PROVEEDOR = CODIGO
            FRM_PROVEEDORES_CRUD.BTN_ACEPTAR.Enabled = False
            FRM_PROVEEDORES_CRUD.BTN_ACEPTAR.Visible = False
            FRM_PROVEEDORES_CRUD.Show()
            Me.Close()
        End If
    End Sub

    Private Sub FRM_PROVEEDORES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CARGARDATAGRIDVIEW()
    End Sub

    Private Sub BTN_BUSCAR_Click(sender As Object, e As EventArgs) Handles BTN_BUSCAR.Click

        If RB_RAZON_SOCIAL.Checked = True Then
            CARGAR_BUSQUEDA_RAZON_SOCIAL()
        End If

        If RB_RUC.Checked = True Then
            CARGAR_BUSQUEDA_RUC()
        End If
    End Sub


    Sub CARGAR_BUSQUEDA_RAZON_SOCIAL()
        Try
            Dim DACargarDataGridView As New DACargarDataGridView
            dts = DACargarDataGridView.Mostrar_Proveedores_Busqueda(TXT_NOMBRES.Text)
            If dts.Rows.Count <> 0 Then
                DGV_PROVEEDORES.DataSource = dts
            Else
                DGV_PROVEEDORES.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Sub CARGAR_BUSQUEDA_RUC()
        Try
            Dim DACargarDataGridView As New DACargarDataGridView
            dts = DACargarDataGridView.Mostrar_Proveedores_RUC_Busqueda(TXT_NOMBRES.Text)
            If dts.Rows.Count <> 0 Then
                DGV_PROVEEDORES.DataSource = dts
            Else
                DGV_PROVEEDORES.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class