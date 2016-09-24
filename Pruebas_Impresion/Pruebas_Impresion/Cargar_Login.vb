
Imports System.Data.SqlClient
    Public Class Cargar_Login

    Dim Dt As DataTable
    Dim Cn As New SqlConnection(Variables_Globales.Base_Conexion)
    Dim Da As New SqlDataAdapter
        Dim Cmd As New SqlCommand
    Sub cargar(ByVal com As CheckedListBox)
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

    Sub cargarLogin(ByVal com As ComboBox)
            With Cmd
                .CommandType = CommandType.Text
                .CommandText = "Select * From Usuarios"
                .Connection = Cn
            End With
            Da.SelectCommand = Cmd
            Dt = New DataTable
            Da.Fill(Dt)
            With com
                .DataSource = Dt
                .DisplayMember = "usua_usu"
                .ValueMember = "DNI_usu"
            End With
        End Sub


    Sub cargar_CheckListBox_Dinamico(ByVal com As CheckedListBox, ByVal lab As Label)
        With Cmd
            .CommandType = CommandType.Text
            .CommandText = "Select * From Usuarios"
            .Connection = Cn
        End With
        Da.SelectCommand = Cmd
        Dt = New DataTable
        Da.Fill(Dt)
        With com
            .DataSource = Dt
            .DisplayMember = "usua_usu"
            .ValueMember = "DNI_usu"
        End With
    End Sub
End Class
