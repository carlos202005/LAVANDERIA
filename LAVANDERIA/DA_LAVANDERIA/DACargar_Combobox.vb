Imports System.Data.SqlClient
Imports System.Windows.Forms
Public Class DACargar_Combobox
    Inherits Conexion
    Dim cmd As New SqlCommand
    Dim DA_MDL_Conexion_Global As New DA_MDL_Conexion_Global
    Dim Dt As DataTable
    Dim Cn As New SqlConnection(DA_MDL_Conexion_Global.conexion_base)
    Dim Da As New SqlDataAdapter

    Sub cargarTipo_Cliente(ByVal com As ComboBox)
        With cmd
            .CommandType = CommandType.Text
            .CommandText = "SELECT * FROM TABLA_TIPO where id_padre=4"
            .Connection = Cn
        End With
        Da.SelectCommand = cmd
        Dt = New DataTable
        Da.Fill(Dt)
        With com
            .DataSource = Dt
            .DisplayMember = "valor"
            .ValueMember = "id_tabla"
        End With
    End Sub

    Sub cargarTipo_Sevicio(ByVal com As ComboBox)
        With cmd
            .CommandType = CommandType.Text
            .CommandText = "SELECT * FROM TABLA_TIPO where id_padre=19"
            .Connection = Cn
        End With
        Da.SelectCommand = cmd
        Dt = New DataTable
        Da.Fill(Dt)
        With com
            .DataSource = Dt
            .DisplayMember = "valor"
            .ValueMember = "id_tabla"
        End With
    End Sub
    Sub cargarEstado(ByVal com As ComboBox)
        With cmd
            .CommandType = CommandType.Text
            .CommandText = "SELECT * FROM TABLA_TIPO where id_padre=1"
            .Connection = Cn
        End With
        Da.SelectCommand = cmd
        Dt = New DataTable
        Da.Fill(Dt)
        With com
            .DataSource = Dt
            .DisplayMember = "valor"
            .ValueMember = "id_tabla"
        End With
    End Sub
    Sub cargarOrden_Venta(ByVal com As ComboBox)
        With cmd
            .CommandType = CommandType.Text
            .CommandText = "SELECT * FROM TABLA_TIPO where id_padre=7"
            .Connection = Cn
        End With
        Da.SelectCommand = cmd
        Dt = New DataTable
        Da.Fill(Dt)
        With com
            .DataSource = Dt
            .DisplayMember = "valor"
            .ValueMember = "id_tabla"
        End With
    End Sub
    Sub cargarTipo_Documento(ByVal com As ComboBox)
        With cmd
            .CommandType = CommandType.Text
            .CommandText = "SELECT * FROM TABLA_TIPO where id_padre=15"
            .Connection = Cn
        End With
        Da.SelectCommand = cmd
        Dt = New DataTable
        Da.Fill(Dt)
        With com
            .DataSource = Dt
            .DisplayMember = "valor"
            .ValueMember = "id_tabla"
        End With
    End Sub
    Sub cargarEstado_Pago(ByVal com As ComboBox)
        With cmd
            .CommandType = CommandType.Text
            .CommandText = "SELECT * FROM TABLA_TIPO where id_padre=27"
            .Connection = Cn
        End With
        Da.SelectCommand = cmd
        Dt = New DataTable
        Da.Fill(Dt)
        With com
            .DataSource = Dt
            .DisplayMember = "valor"
            .ValueMember = "id_tabla"
        End With
    End Sub
    Sub cargarTipo_Medida(ByVal com As ComboBox)
        With cmd
            .CommandType = CommandType.Text
            .CommandText = "SELECT * FROM TABLA_TIPO where id_padre=24"
            .Connection = Cn
        End With
        Da.SelectCommand = cmd
        Dt = New DataTable
        Da.Fill(Dt)
        With com
            .DataSource = Dt
            .DisplayMember = "valor"
            .ValueMember = "id_tabla"
        End With
    End Sub

    Sub cargarTipo_Pago(ByVal com As ComboBox)
        With cmd
            .CommandType = CommandType.Text
            .CommandText = "SELECT * FROM TABLA_TIPO where id_padre=30"
            .Connection = Cn
        End With
        Da.SelectCommand = cmd
        Dt = New DataTable
        Da.Fill(Dt)
        With com
            .DataSource = Dt
            .DisplayMember = "valor"
            .ValueMember = "id_tabla"
        End With
    End Sub

End Class
