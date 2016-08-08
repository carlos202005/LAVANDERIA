Public Class FRM_SERVICIOS
    Private Sub BTN_NUEVO_Click(sender As Object, e As EventArgs) Handles BTN_NUEVO.Click
        Dim FRM As New FRM_INSERTAR_SERVICIOS
        FRM.TAB_CONTROL1.SelectedIndex = 0
        FRM.Show()
    End Sub

    Private Sub BTN_EDITAR_Click(sender As Object, e As EventArgs) Handles BTN_EDITAR.Click
        Dim FRM As New FRM_INSERTAR_SERVICIOS
        FRM.TAB_CONTROL1.SelectedIndex = 0
        FRM.Show()
    End Sub

    Private Sub BTN_VER_Click(sender As Object, e As EventArgs) Handles BTN_VER.Click
        Dim FRM As New FRM_INSERTAR_SERVICIOS
        FRM.TAB_CONTROL1.SelectedIndex = 0
        FRM.Show()
    End Sub
End Class
