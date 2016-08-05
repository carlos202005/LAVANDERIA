Public Class FRM_RECIBOS
    Private Sub BTN_NUEVO_Click(sender As Object, e As EventArgs) Handles BTN_NUEVO.Click

        '################## ABRIR UN TABCONTROL DESDE OTRO FORMULARIO CON UN OBJETO DEFINIDO ############
        Dim FRM As New FRM_INSERTAR_GASTOS
        FRM.TAB_CONTROL1.SelectedIndex = 1
        FRM.Show()

        '################# OTRA FORMA ADICIONAL DE HACERLO ###############################################

        'Dim tp As TabPage = FRM.TAB_CONTROL1.TabPages(1)
        'FRM.TAB_CONTROL1.SelectedTab = tp
    End Sub
End Class
