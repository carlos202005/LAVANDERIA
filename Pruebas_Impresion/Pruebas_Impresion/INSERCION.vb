Public Class INSERCION
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sqlConnection1 As New System.Data.SqlClient.SqlConnection("Data Source=.;Initial Catalog=Lavanderia_Cristal;Integrated Security=True")

        Dim cmd As New System.Data.SqlClient.SqlCommand
        cmd.CommandType = System.Data.CommandType.Text
        cmd.CommandText = "INSERT INTO Recibos(nom_rec,monto_rec,fecha) VALUES ('" & TXT_NOMBRE.Text & "','" & TXT_MONTO.Text & " ', '" & TXT_FECHA.Text & "')"
        cmd.Connection = sqlConnection1

        sqlConnection1.Open()
        cmd.ExecuteNonQuery()
        sqlConnection1.Close()
    End Sub
End Class