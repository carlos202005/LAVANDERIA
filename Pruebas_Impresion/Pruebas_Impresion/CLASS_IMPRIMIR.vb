Imports System.Data.SqlClient
Public Class CLASS_IMPRIMIR

    Dim Dt As DataTable
        Dim Cn As New SqlConnection("Data Source=.;Initial Catalog=Lavanderia_Cristal;Integrated Security=True")
        Dim Da As New SqlDataAdapter
        Dim Cmd As New SqlCommand
        Sub cargar(ByVal com As ComboBox)
            With Cmd
                .CommandType = CommandType.Text
                .CommandText = "Select * From Prendas"
                .Connection = Cn
            End With
            Da.SelectCommand = Cmd
            Dt = New DataTable
            Da.Fill(Dt)
            With com
                .DataSource = Dt
                .DisplayMember = "nom_pren"
                .ValueMember = "Id_pren"
            End With
        End Sub
    End Class
