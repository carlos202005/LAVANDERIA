Imports DA_LAVANDERIA
Imports BE_LAVANDERIA
Public Class FRM_INSERTAR_SERVICIOS
    Private Sub BTN_SALIR_Click(sender As Object, e As EventArgs) Handles BTN_SALIR.Click
        VARIABLES_GLOBALES.ID_SERVICIO = Nothing
        FRM_SERVICIOS.Show()
        Me.Close()
    End Sub

    Private Sub FRM_INSERTAR_SERVICIOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim DAConsultas_Base As New DAConsultas_Base
        Dim DACargar_Combobox As New DACargar_Combobox
        DACargar_Combobox.cargarTipo_Medida(CB_MEDIDA)
        DACargar_Combobox.cargarTipo_Sevicio(CB_TIPO)


        If VARIABLES_GLOBALES.ID_SERVICIO <> Nothing Then
            Dim DAConsultas_Completas_Base As New DAConsultas_Completas_Base
            DAConsultas_Completas_Base.cargarServicios(DAConsultas_Base.mostrar_Id_Servicio(VARIABLES_GLOBALES.ID_SERVICIO), TXT_CODIGO, TXT_NOMBRE, TXT_PRECIO1, TXT_PRECIO2, CB_MEDIDA, CB_TIPO)
        End If


    End Sub

    Private Sub BTN_NUEVO_Click(sender As Object, e As EventArgs) Handles BTN_NUEVO.Click
        Dim BEServicios As New BEServicios
        Dim DAServicios As New DAServicios
        Dim DAConsultas_Base As New DAConsultas_Base

        If VARIABLES_GLOBALES.ID_SERVICIO = Nothing Then
            BEServicios.gcod_serv = TXT_CODIGO.Text
            BEServicios.gdes_ser = TXT_NOMBRE.Text
            BEServicios.gprecio1 = TXT_PRECIO1.Text
            BEServicios.gprecio2 = TXT_PRECIO2.Text
            BEServicios.gid_unimed = CB_MEDIDA.SelectedValue
            BEServicios.gid_tipo = CB_TIPO.SelectedValue
            BEServicios.gusu_reg = VARIABLES_GLOBALES.ID_USUARIO

            If DAServicios.insertar_Servicios(BEServicios) Then
                MsgBox("SERVICIO GUARDADO CORRECTAMENTE..!!")
            Else
                MsgBox("ERROR AL GUARDAR EL SERVICIO...")
            End If

        Else
            BEServicios.gid_serv = DAConsultas_Base.mostrar_Id_Servicio(VARIABLES_GLOBALES.ID_SERVICIO)
            BEServicios.gcod_serv = TXT_CODIGO.Text
            BEServicios.gdes_ser = TXT_NOMBRE.Text
            BEServicios.gprecio1 = TXT_PRECIO1.Text
            BEServicios.gprecio2 = TXT_PRECIO2.Text
            BEServicios.gid_unimed = CB_MEDIDA.SelectedValue
            BEServicios.gid_tipo = CB_TIPO.SelectedValue
            BEServicios.gusu_mod = VARIABLES_GLOBALES.ID_USUARIO

            If DAServicios.actualizar_Servicios(BEServicios) Then
                MsgBox("CLIENTE ACTUALIZADO CORRECTAMENTE..!!")
            Else
                MsgBox("ERROR AL ACTUALIZAR CLIENTES...!!")
            End If
        End If

        VARIABLES_GLOBALES.ID_SERVICIO = Nothing
        FRM_SERVICIOS.Show()
        Me.Close()
    End Sub

    Sub LIMPIAR()
        TXT_CODIGO.Text = ""
        TXT_NOMBRE.Text = ""
        TXT_PRECIO1.Text = ""
        TXT_PRECIO2.Text = ""
        CB_MEDIDA.SelectedIndex = 0
        CB_TIPO.SelectedIndex = 0
    End Sub

End Class