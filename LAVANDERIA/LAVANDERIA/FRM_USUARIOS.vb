Public Class FRM_USUARIOS
    Private Sub BTN_NUEVO_Click(sender As Object, e As EventArgs) Handles BTN_NUEVO.Click
        Dim FRM As New FRM_INSERTAR_USUARIOS
        FRM.TAB_CONTROL1.SelectedIndex = 1
        FRM.Show()
    End Sub
End Class
