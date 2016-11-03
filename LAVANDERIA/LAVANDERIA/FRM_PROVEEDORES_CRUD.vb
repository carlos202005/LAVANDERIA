Imports BE_LAVANDERIA
Imports DA_LAVANDERIA
Imports System.Text.RegularExpressions
Public Class FRM_PROVEEDORES_CRUD
    Dim DAConsultas_Completas_Base As New DAConsultas_Completas_Base

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BTN_SALIR.Click
        VARIABLES_GLOBALES.ID_PROVEEDOR = Nothing
        FRM_PROVEEDORES.Show()
        Me.Close()
    End Sub

    Private Sub BTN_ACEPTAR_Click(sender As Object, e As EventArgs) Handles BTN_ACEPTAR.Click
        Dim BEProveedores As New BEProveedores
        Dim DAProveedores As New DAProveedores

        If VARIABLES_GLOBALES.ID_PROVEEDOR = Nothing Then
            BEProveedores.grazon_social = TXT_RAZON_SOCIAL.Text
            BEProveedores.gruc = TXT_RUC.Text
            BEProveedores.gcelular = TXT_CELULAR.Text
            BEProveedores.gtelefono = TXT_TELEFONO.Text
            BEProveedores.gcorreo = TXT_CORREO.Text
            BEProveedores.gusu_reg = VARIABLES_GLOBALES.ID_USUARIO

            If DAProveedores.insertar_Proveedores(BEProveedores) Then
                MsgBox("PROVEEDOR GUARDADO CORRECTAMENTE..!!")
            Else
                MsgBox("ERROR AL GUARDAR PROVEEDOR...")
            End If

        Else
            BEProveedores.gid_proveedor = VARIABLES_GLOBALES.ID_PROVEEDOR
            BEProveedores.grazon_social = TXT_RAZON_SOCIAL.Text
            BEProveedores.gruc = TXT_RUC.Text
            BEProveedores.gcelular = TXT_CELULAR.Text
            BEProveedores.gtelefono = TXT_TELEFONO.Text
            BEProveedores.gcorreo = TXT_CORREO.Text
            BEProveedores.gusu_mod = VARIABLES_GLOBALES.ID_USUARIO

            If DAProveedores.actualizar_Proveedores(BEProveedores) Then
                MsgBox("PROVEEDOR ACTUALIZADO CORRECTAMENTE..!!")
            Else
                MsgBox("ERROR AL ACTUALIZAR PROVEEDOR...!!")
            End If
        End If

        VARIABLES_GLOBALES.ID_PROVEEDOR = Nothing
        FRM_PROVEEDORES.Show()
        Me.Close()
    End Sub

    Sub LIMPIAR()
        TXT_CELULAR.Text = ""
        TXT_CORREO.Text = ""
        TXT_RAZON_SOCIAL.Text = ""
        TXT_RUC.Text = ""
        TXT_TELEFONO.Text = ""
    End Sub

    Private Sub FRM_PROVEEDORES_CRUD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If VARIABLES_GLOBALES.ID_PROVEEDOR <> Nothing Then
            DAConsultas_Completas_Base.cargarProveedores(VARIABLES_GLOBALES.ID_PROVEEDOR, TXT_RAZON_SOCIAL, TXT_RUC, TXT_CELULAR, TXT_TELEFONO, TXT_CORREO)
        End If
    End Sub

    Private Sub TXT_TELEFONO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_TELEFONO.KeyPress, TXT_RUC.KeyPress, TXT_CELULAR.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TXT_RAZON_SOCIAL_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_RAZON_SOCIAL.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Function validar_Mail(ByVal sMail As String) As Boolean
        ' retorna true o false   
        Return Regex.IsMatch(sMail,
                  "^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$")
    End Function

    Private Sub TXT_CORREO_Leave(sender As Object, e As EventArgs) Handles TXT_CORREO.Leave
        If validar_Mail(LCase(TXT_CORREO.Text)) = False Then
            MessageBox.Show("Dirección de correo electronico no valida, el correo debe tener el formato: nombre@dominio.com, por favor seleccione un correo valido", "Validación de correo electronico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TXT_CORREO.Focus()
            TXT_CORREO.SelectAll()
        End If
    End Sub

End Class