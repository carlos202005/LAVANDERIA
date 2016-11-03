Imports DA_LAVANDERIA
Imports BE_LAVANDERIA
Public Class FRM_INSERTAR_SERVICIOS

    Private Sub BTN_SALIR_Click(sender As Object, e As EventArgs) Handles BTN_SALIR.Click
        VARIABLES_GLOBALES.ID_SERVICIO = Nothing
        FRM_SERVICIOS.Show()
        Me.Close()
    End Sub

    Private Sub FRM_INSERTAR_SERVICIOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim r As New Globalization.CultureInfo("es-ES")
        r.NumberFormat.CurrencyDecimalSeparator = "."

        r.NumberFormat.NumberDecimalSeparator = "."

        System.Threading.Thread.CurrentThread.CurrentCulture = r

        Dim DAConsultas_Base As New DAConsultas_Base
        Dim DACargar_Combobox As New DACargar_Combobox
        Dim DAConsultas_Completas_Base As New DAConsultas_Completas_Base

        DACargar_Combobox.cargarTipo_Medida(CB_MEDIDA)
        DACargar_Combobox.cargarTipo_Sevicio(CB_TIPO)

        If VARIABLES_GLOBALES.ID_SERVICIO = Nothing Then
            Dim VARIABLE1 As String
            VARIABLE1 = DAConsultas_Base.mostrarId_Servicio_Ultima()
            VARIABLE1 = Microsoft.VisualBasic.Right(VARIABLE1, 3)
            VARIABLE1 = Integer.Parse(VARIABLE1) + 1
            If VARIABLE1.Length = 1 Then VARIABLE1 = "00" & VARIABLE1
            If VARIABLE1.Length = 2 Then VARIABLE1 = "0" & VARIABLE1
            VARIABLE1 = "S" & VARIABLE1
            TXT_CODIGO.Text = VARIABLE1
        Else
            DAConsultas_Completas_Base.cargarServicios(DAConsultas_Base.mostrar_Id_Servicio(VARIABLES_GLOBALES.ID_SERVICIO), TXT_CODIGO, TXT_NOMBRE, TXT_PRECIO1, TXT_PRECIO2, CB_MEDIDA, CB_TIPO)
        End If

        LBL_IGV.Text = DAConsultas_Base.mostrarIGV & "% "

    End Sub

    Public Sub NumerosyDecimal(ByVal CajaTexto As TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not CajaTexto.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
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

    Private Sub TXT_PRECIO1_Leave(sender As Object, e As EventArgs) Handles TXT_PRECIO1.Leave
        Dim DAConsultas_Base As New DAConsultas_Base
        LBL_PRECIO_1.Text = ((Double.Parse(DAConsultas_Base.mostrarIGV) / 100) + 1) * Double.Parse(TXT_PRECIO1.Text)
    End Sub

    Private Sub TXT_PRECIO2_Leave(sender As Object, e As EventArgs) Handles TXT_PRECIO2.Leave
        Dim DAConsultas_Base As New DAConsultas_Base
        LBL_PRECIO_2.Text = ((Double.Parse(DAConsultas_Base.mostrarIGV) / 100) + 1) * Double.Parse(TXT_PRECIO2.Text)
    End Sub

    Private Sub TXT_PRECIO2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_PRECIO2.KeyPress
        NumerosyDecimal(TXT_PRECIO2, e)
    End Sub

    Private Sub TXT_PRECIO1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_PRECIO1.KeyPress
        NumerosyDecimal(TXT_PRECIO1, e)
    End Sub

    Private Sub TXT_NOMBRE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_NOMBRE.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

End Class