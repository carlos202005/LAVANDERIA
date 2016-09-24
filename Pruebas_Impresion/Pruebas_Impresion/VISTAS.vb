Public Class VISTAS
    Private Sub VISTAS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'LAVANDERIADataSet.Servicio' Puede moverla o quitarla según sea necesario.
        Me.ServicioTableAdapter.Fill(Me.LAVANDERIADataSet.Servicio)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class