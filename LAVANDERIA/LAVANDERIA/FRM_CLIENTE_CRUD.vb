Imports BE_LAVANDERIA
Imports DA_LAVANDERIA
Public Class FRM_CLIENTE_CRUD
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        VARIABLES_GLOBALES.ID_CLIENTE = Nothing
        FRM_CLIENTE.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim BEClientes As New BEClientes
        Dim DAClientes As New DAClientes
        Dim id_tipo As Integer
        If RB_NARUTAL.Checked Then
            id_tipo = 5
        Else
            id_tipo = 6
        End If

        If VARIABLES_GLOBALES.ID_CLIENTE = Nothing Then
            BEClientes.gdni = TXT_DOCUMENTO.Text
            BEClientes.gnom_cli = TXT_NOMBRES.Text
            BEClientes.gapepat_cli = TXT_APELLIDOS_PAT.Text
            BEClientes.gapemat_cli = TXT_APELLIDOS_MAT.Text
            BEClientes.gcelular = TXT_CELULAR.Text
            BEClientes.gtelefono = TXT_TELEFONO.Text
            BEClientes.gcorreo = TXT_CORREO.Text
            BEClientes.gfec_nacimiento = Convert.ToDateTime(DateTimePicker1.Value).ToString("yyyy-MM-dd HH:mm:ss")
            BEClientes.gid_tipo = id_tipo
            BEClientes.gusu_reg = VARIABLES_GLOBALES.ID_USUARIO

            If DAClientes.insertar_Clientes(BEClientes) Then
                MsgBox("CLIENTES GUARDADO CORRECTAMENTE..!!")
            Else
                MsgBox("ERROR AL GUARDAR AL CLIENTE...")
            End If

        Else
            BEClientes.gid_cli = VARIABLES_GLOBALES.ID_CLIENTE
            BEClientes.gdni = TXT_DOCUMENTO.Text
            BEClientes.gnom_cli = TXT_NOMBRES.Text
            BEClientes.gapepat_cli = TXT_APELLIDOS_PAT.Text
            BEClientes.gapemat_cli = TXT_APELLIDOS_MAT.Text
            BEClientes.gcelular = TXT_CELULAR.Text
            BEClientes.gtelefono = TXT_TELEFONO.Text
            BEClientes.gcorreo = TXT_CORREO.Text
            BEClientes.gfec_nacimiento = Convert.ToDateTime(DateTimePicker1.Value).ToString("yyyy-MM-dd HH:mm:ss")
            BEClientes.gid_tipo = id_tipo
            BEClientes.gusu_mod = VARIABLES_GLOBALES.ID_USUARIO
            If DAClientes.actualizar_Clientes(BEClientes) Then
                MsgBox("CLIENTE ACTUALIZADO CORRECTAMENTE..!!")
            Else
                MsgBox("ERROR AL ACTUALIZAR CLIENTES...!!")
            End If
        End If

        VARIABLES_GLOBALES.ID_CLIENTE = Nothing
        FRM_CLIENTE.Show()
        Me.Close()
    End Sub

    Private Sub FRM_CLIENTE_CRUD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim DAConsultas_Completas_Base As New DAConsultas_Completas_Base

        If VARIABLES_GLOBALES.ID_CLIENTE <> 0 Then
            DAConsultas_Completas_Base.cargarClientes(VARIABLES_GLOBALES.ID_CLIENTE, TXT_NOMBRES, TXT_APELLIDOS_PAT, TXT_APELLIDOS_MAT, TXT_CORREO, TXT_DOCUMENTO, DateTimePicker1, RB_NARUTAL, RB_JURIDICA, TXT_CELULAR, TXT_TELEFONO)
        End If
    End Sub
End Class