Public Class FRM_VENTAS
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub FRM_VENTAS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim desktopSize As Size = System.Windows.Forms.SystemInformation.PrimaryMonitorSize 'Captura el Tamaño del Monitor
        Panel1.Location = New Point((desktopSize.Width - Panel1.Width) / 2, (desktopSize.Height - Panel1.Height) / 5)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()
    End Sub
End Class