Public Class FRM_CLIENTE
    Private Sub BTN_NUEVO_Click(sender As Object, e As EventArgs) Handles BTN_NUEVO.Click

        '################## ABRIR UN TABCONTROL DESDE OTRO FORMULARIO CON UN OBJETO DEFINIDO ############
        Dim FRM As New FRM_INSERTAR_USUARIOS
        FRM.TAB_CONTROL1.SelectedIndex = 0
        FRM.Show()

        '################# OTRA FORMA ADICIONAL DE HACERLO ###############################################

        'Dim tp As TabPage = FRM.TAB_CONTROL1.TabPages(1)
        'FRM.TAB_CONTROL1.SelectedTab = tp
    End Sub

    Private Sub BTN_EDITAR_Click(sender As Object, e As EventArgs) Handles BTN_EDITAR.Click
        Dim FRM As New FRM_INSERTAR_USUARIOS
        FRM.TAB_CONTROL1.SelectedIndex = 0
        FRM.Show()
    End Sub

    Private Sub BTN_VER_Click(sender As Object, e As EventArgs) Handles BTN_VER.Click
        Dim FRM As New FRM_INSERTAR_USUARIOS
        FRM.TAB_CONTROL1.SelectedIndex = 0
        FRM.Show()
    End Sub
End Class
