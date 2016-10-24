Imports BE_LAVANDERIA
Imports DA_LAVANDERIA
Public Class FRM_USUARIOS
    Dim CODIGO As Integer = Nothing
    Dim dts As New DataTable
    Private Sub BTN_NUEVO_Click(sender As Object, e As EventArgs) Handles BTN_NUEVO.Click
        FRM_USUARIOS_CRUD.Show()
        Me.Close()
    End Sub

    Private Sub BTN_SALIR_Click(sender As Object, e As EventArgs) Handles BTN_SALIR.Click
        Me.Close()
    End Sub
    Private Sub DGV_USUARIOS_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_USUARIOS.CellEnter
        CODIGO = Me.DGV_USUARIOS.CurrentRow.Cells.Item("CODIGO").Value.ToString()
    End Sub
    Private Sub BTN_EDITAR_Click(sender As Object, e As EventArgs) Handles BTN_EDITAR.Click
        If CODIGO <> Nothing Then
            VARIABLES_GLOBALES.ID_VENDEDOR = CODIGO
            FRM_USUARIOS_CRUD.Show()
            Me.Close()
        End If
    End Sub

    Private Sub BTN_VER_Click(sender As Object, e As EventArgs) Handles BTN_VER.Click
        If CODIGO <> Nothing Then
            VARIABLES_GLOBALES.ID_VENDEDOR = CODIGO
            Dim FRM_USUARIOS_CRUD As New FRM_USUARIOS_CRUD
            FRM_USUARIOS_CRUD.BTN_ACEPTAR.Enabled = False
            FRM_USUARIOS_CRUD.BTN_ACEPTAR.Visible = False
            FRM_USUARIOS_CRUD.Show()
            Me.Close()
        End If
    End Sub

    Private Sub BTN_ELIMINAR_Click(sender As Object, e As EventArgs) Handles BTN_ELIMINAR.Click
        If CODIGO <> Nothing Then
            If MsgBox("¿REALMENTE QUIERE ELIMINAR A ESTE VENDEDOR DEL SISTEMA?", MsgBoxStyle.YesNo) = vbYes Then
                Dim BEEmpleado As New BEEmpleado
                Dim DAEmpleado As New DAEmpleado

                BEEmpleado.gid_emp = CODIGO
                BEEmpleado.gusu_eli = VARIABLES_GLOBALES.ID_USUARIO

                DAEmpleado.eliminar_Empleados(BEEmpleado)

                MsgBox("USUARIO ELIMINADO CORRECTAMENTE..!!")
                CARGARDATAGRIDVIEW()
            End If
        End If
    End Sub

    Private Sub FRM_USUARIOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CARGARDATAGRIDVIEW()
    End Sub

    Sub CARGARDATAGRIDVIEW()
        Try
            Dim DACargarDataGridView As New DACargarDataGridView
            dts = DACargarDataGridView.Mostrar_Empleados()
            If dts.Rows.Count <> 0 Then
                DGV_USUARIOS.DataSource = dts
            Else
                DGV_USUARIOS.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BTN_BUSCAR_Click(sender As Object, e As EventArgs) Handles BTN_BUSCAR.Click
        If RB_NOMBRES.Checked = True Then
            CARGARBUSQUEDANOMBRES()
        End If
        If RB_DNI.Checked = True Then
            CARGARBUSQUEDADNI()
        End If
    End Sub


    Sub CARGARBUSQUEDANOMBRES()
        Try
            Dim DACargarDataGridView As New DACargarDataGridView
            dts = DACargarDataGridView.Mostrar_Empleados_Busqueda(TXT_NOMBRE.Text)
            If dts.Rows.Count <> 0 Then
                DGV_USUARIOS.DataSource = dts
            Else
                DGV_USUARIOS.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Sub CARGARBUSQUEDADNI()
        Try
            Dim DACargarDataGridView As New DACargarDataGridView
            dts = DACargarDataGridView.Mostrar_Empleados_DNI_Busqueda(TXT_NOMBRE.Text)
            If dts.Rows.Count <> 0 Then
                DGV_USUARIOS.DataSource = dts
            Else
                DGV_USUARIOS.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class