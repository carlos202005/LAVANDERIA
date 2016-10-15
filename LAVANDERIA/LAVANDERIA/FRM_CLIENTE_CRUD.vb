Imports BE_LAVANDERIA
Imports DA_LAVANDERIA
Public Class FRM_CLIENTE_CRUD
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
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
        BEClientes.gdni = TXT_DOCUMENTO.Text
        BEClientes.gnom_cli = TXT_NOMBRES.Text
        BEClientes.gapepat_cli = TXT_APELLIDOS_PAT.Text
        BEClientes.gapemat_cli = TXT_APELLIDOS_MAT.Text
        BEClientes.gcelular = TXT_CELULAR.Text
        BEClientes.gtelefono = TXT_TELEFONO.Text
        BEClientes.gcorreo = TXT_CORREO.Text
        BEClientes.gfec_nacimiento = "2016-05-30 00:00:00"
        BEClientes.gid_tipo = id_tipo

        If DAClientes.insertar_Clientes(BEClientes) Then
            MsgBox("CLIENTES GUARDADO CORRECTAMENTE..!!")
        Else
            MsgBox("ERROR AL GUARDAR AL SIGUIENTE CLIENTES")

        End If

    End Sub
End Class