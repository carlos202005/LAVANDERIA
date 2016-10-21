Imports BE_LAVANDERIA
Imports DA_LAVANDERIA
Public Class FRM_USUARIOS_CRUD
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTN_ACEPTAR.Click
        Dim BEEmpleado As New BEEmpleado
        Dim BEPerfil As New BEPerfil
        Dim BEUsuarios As New BEUsuarios
        Dim DAEmpleado As New DAEmpleado
        Dim DAPerfil As New DAPerfil
        Dim DAUsuarios As New DAUsuarios
        Dim DAConsultas_Base As New DAConsultas_Base

        If VARIABLES_GLOBALES.ID_VENDEDOR = Nothing Then

            BEEmpleado.gnom_emp = TXT_NOMBRE.Text
            BEEmpleado.gapet_pat = TXT_APE_PAT.Text
            BEEmpleado.gapet_mat = TXT_APE_MAT.Text
            BEEmpleado.gdni = TXT_DNI.Text
            BEEmpleado.gcelular = TXT_CELULAR.Text
            BEEmpleado.gfecha_nac = Convert.ToDateTime(DTP_FECHA_NAC.Value).ToString("yyyy-MM-dd HH:mm:ss")
            BEEmpleado.gusu_reg = VARIABLES_GLOBALES.ID_USUARIO
            DAEmpleado.insertar_Empleados(BEEmpleado)

            BEPerfil.gnom_per = TXT_PERFIL.Text
            BEPerfil.gusu_reg = VARIABLES_GLOBALES.ID_USUARIO
            DAPerfil.insertar_Perfil(BEPerfil)

            Dim Id_Empleado As Integer = DAConsultas_Base.mostrar_Ultimo_Id_Empleado
            Dim Id_Perfil As Integer = DAConsultas_Base.mostrar_Ultimo_Id_Perfil

            BEUsuarios.gnom_usu = TXT_USUARIO.Text
            BEUsuarios.gclave_usu = TXT_CONTRASENA.Text
            BEUsuarios.gid_emp = Id_Empleado
            BEUsuarios.gid_perfil = Id_Perfil
            DAUsuarios.insertar_Usuarios(BEUsuarios)
            MsgBox("USUARIO INSERTADO CORRECTAMENTE...!!")
        Else
            BEEmpleado.gid_emp = VARIABLES_GLOBALES.ID_VENDEDOR
            BEEmpleado.gnom_emp = TXT_NOMBRE.Text
            BEEmpleado.gapet_pat = TXT_APE_PAT.Text
            BEEmpleado.gapet_mat = TXT_APE_MAT.Text
            BEEmpleado.gdni = TXT_DNI.Text
            BEEmpleado.gcelular = TXT_CELULAR.Text
            BEEmpleado.gfecha_nac = Convert.ToDateTime(DTP_FECHA_NAC.Value).ToString("yyyy-MM-dd HH:mm:ss")
            BEEmpleado.gusu_mod = VARIABLES_GLOBALES.ID_USUARIO
            DAEmpleado.actualizar_Empleados(BEEmpleado)

            Dim Id_Usuario As Integer = DAConsultas_Base.mostrarId_Usuario(VARIABLES_GLOBALES.ID_VENDEDOR)
            Dim Id_Perfil As Integer = DAConsultas_Base.mostrarIdPerfil(VARIABLES_GLOBALES.ID_VENDEDOR)

            BEPerfil.gid_perfil = Id_Perfil
            BEPerfil.gnom_per = TXT_PERFIL.Text
            BEPerfil.gusu_mod = VARIABLES_GLOBALES.ID_USUARIO
            DAPerfil.actualizar_Perfil(BEPerfil)

            BEUsuarios.gid_usu = Id_Usuario
            BEUsuarios.gnom_usu = TXT_USUARIO.Text
            BEUsuarios.gclave_usu = TXT_CONTRASENA.Text
            BEUsuarios.gid_emp = VARIABLES_GLOBALES.ID_VENDEDOR
            DAUsuarios.actualizar_Usuarios(BEUsuarios)
            MsgBox("USUARIO ACTUALIZADO CORRECTAMENTE...!!")
        End If

        VARIABLES_GLOBALES.ID_VENDEDOR = Nothing
        FRM_USUARIOS.Show()
        Me.Close()
    End Sub

    Private Sub FRM_USUARIOS_CRUD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If VARIABLES_GLOBALES.ID_VENDEDOR <> Nothing Then
            Dim DAConsultas_Completas_Base As New DAConsultas_Completas_Base
            DAConsultas_Completas_Base.cargarEmpleados(VARIABLES_GLOBALES.ID_VENDEDOR, TXT_CODIGO, TXT_NOMBRE, TXT_APE_PAT, TXT_APE_MAT, TXT_DNI, TXT_CELULAR, DTP_FECHA_NAC, TXT_PERFIL, TXT_USUARIO, TXT_CONTRASENA)
        End If
    End Sub

    Private Sub BTN_SALIR_Click(sender As Object, e As EventArgs) Handles BTN_SALIR.Click
        VARIABLES_GLOBALES.ID_VENDEDOR = Nothing
        FRM_USUARIOS.Show()
        Me.Close()
    End Sub
End Class