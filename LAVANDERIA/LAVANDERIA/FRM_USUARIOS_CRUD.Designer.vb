<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_USUARIOS_CRUD
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TXT_CELULAR = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TXT_DNI = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TXT_APE_MAT = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TXT_APE_PAT = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TXT_NOMBRE = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TXT_CODIGO = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TXT_CONTRASENA = New System.Windows.Forms.TextBox()
        Me.TXT_USUARIO = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.BTN_SALIR = New System.Windows.Forms.Button()
        Me.BTN_ACEPTAR = New System.Windows.Forms.Button()
        Me.TXT_PERFIL = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTP_FECHA_NAC = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TXT_CELULAR
        '
        Me.TXT_CELULAR.Location = New System.Drawing.Point(579, 149)
        Me.TXT_CELULAR.Name = "TXT_CELULAR"
        Me.TXT_CELULAR.Size = New System.Drawing.Size(150, 22)
        Me.TXT_CELULAR.TabIndex = 6
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(461, 152)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(71, 17)
        Me.Label17.TabIndex = 30
        Me.Label17.Text = "CELULAR"
        '
        'TXT_DNI
        '
        Me.TXT_DNI.Location = New System.Drawing.Point(286, 149)
        Me.TXT_DNI.MaxLength = 8
        Me.TXT_DNI.Name = "TXT_DNI"
        Me.TXT_DNI.Size = New System.Drawing.Size(164, 22)
        Me.TXT_DNI.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(159, 149)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(31, 17)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "DNI"
        '
        'TXT_APE_MAT
        '
        Me.TXT_APE_MAT.Location = New System.Drawing.Point(579, 105)
        Me.TXT_APE_MAT.Name = "TXT_APE_MAT"
        Me.TXT_APE_MAT.Size = New System.Drawing.Size(150, 22)
        Me.TXT_APE_MAT.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(461, 108)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(112, 17)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "APELLIDO MAT."
        '
        'TXT_APE_PAT
        '
        Me.TXT_APE_PAT.Location = New System.Drawing.Point(286, 107)
        Me.TXT_APE_PAT.Name = "TXT_APE_PAT"
        Me.TXT_APE_PAT.Size = New System.Drawing.Size(164, 22)
        Me.TXT_APE_PAT.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(159, 110)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(110, 17)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "APELLIDO PAT."
        '
        'TXT_NOMBRE
        '
        Me.TXT_NOMBRE.Location = New System.Drawing.Point(286, 72)
        Me.TXT_NOMBRE.Name = "TXT_NOMBRE"
        Me.TXT_NOMBRE.Size = New System.Drawing.Size(443, 22)
        Me.TXT_NOMBRE.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(159, 72)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 17)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "NOMBRE"
        '
        'TXT_CODIGO
        '
        Me.TXT_CODIGO.Location = New System.Drawing.Point(286, 33)
        Me.TXT_CODIGO.Name = "TXT_CODIGO"
        Me.TXT_CODIGO.Size = New System.Drawing.Size(113, 22)
        Me.TXT_CODIGO.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(159, 33)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 17)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "CÓDIGO"
        '
        'TXT_CONTRASENA
        '
        Me.TXT_CONTRASENA.Location = New System.Drawing.Point(579, 267)
        Me.TXT_CONTRASENA.Name = "TXT_CONTRASENA"
        Me.TXT_CONTRASENA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXT_CONTRASENA.Size = New System.Drawing.Size(150, 22)
        Me.TXT_CONTRASENA.TabIndex = 12
        '
        'TXT_USUARIO
        '
        Me.TXT_USUARIO.Location = New System.Drawing.Point(286, 267)
        Me.TXT_USUARIO.Name = "TXT_USUARIO"
        Me.TXT_USUARIO.Size = New System.Drawing.Size(164, 22)
        Me.TXT_USUARIO.TabIndex = 11
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(461, 270)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(103, 17)
        Me.Label18.TabIndex = 34
        Me.Label18.Text = "CONTRASEÑA"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(159, 270)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(70, 17)
        Me.Label19.TabIndex = 32
        Me.Label19.Text = "USUARIO"
        '
        'BTN_SALIR
        '
        Me.BTN_SALIR.Location = New System.Drawing.Point(12, 219)
        Me.BTN_SALIR.Name = "BTN_SALIR"
        Me.BTN_SALIR.Size = New System.Drawing.Size(111, 68)
        Me.BTN_SALIR.TabIndex = 14
        Me.BTN_SALIR.Text = "SALIR"
        Me.BTN_SALIR.UseVisualStyleBackColor = True
        '
        'BTN_ACEPTAR
        '
        Me.BTN_ACEPTAR.Location = New System.Drawing.Point(12, 21)
        Me.BTN_ACEPTAR.Name = "BTN_ACEPTAR"
        Me.BTN_ACEPTAR.Size = New System.Drawing.Size(111, 68)
        Me.BTN_ACEPTAR.TabIndex = 13
        Me.BTN_ACEPTAR.Text = "ACEPTAR"
        Me.BTN_ACEPTAR.UseVisualStyleBackColor = True
        '
        'TXT_PERFIL
        '
        Me.TXT_PERFIL.Location = New System.Drawing.Point(286, 229)
        Me.TXT_PERFIL.Name = "TXT_PERFIL"
        Me.TXT_PERFIL.Size = New System.Drawing.Size(164, 22)
        Me.TXT_PERFIL.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(159, 232)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 17)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "PERFIL"
        '
        'DTP_FECHA_NAC
        '
        Me.DTP_FECHA_NAC.Location = New System.Drawing.Point(286, 192)
        Me.DTP_FECHA_NAC.Name = "DTP_FECHA_NAC"
        Me.DTP_FECHA_NAC.Size = New System.Drawing.Size(245, 22)
        Me.DTP_FECHA_NAC.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(158, 197)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 17)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "FECHA NAC."
        '
        'FRM_USUARIOS_CRUD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 334)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DTP_FECHA_NAC)
        Me.Controls.Add(Me.TXT_PERFIL)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTN_SALIR)
        Me.Controls.Add(Me.BTN_ACEPTAR)
        Me.Controls.Add(Me.TXT_CONTRASENA)
        Me.Controls.Add(Me.TXT_USUARIO)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.TXT_CELULAR)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.TXT_DNI)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TXT_APE_MAT)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TXT_APE_PAT)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TXT_NOMBRE)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TXT_CODIGO)
        Me.Controls.Add(Me.Label10)
        Me.Name = "FRM_USUARIOS_CRUD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "USUARIOS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXT_CELULAR As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TXT_DNI As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TXT_APE_MAT As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TXT_APE_PAT As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TXT_NOMBRE As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TXT_CODIGO As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TXT_CONTRASENA As TextBox
    Friend WithEvents TXT_USUARIO As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents BTN_SALIR As Button
    Friend WithEvents BTN_ACEPTAR As Button
    Friend WithEvents TXT_PERFIL As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DTP_FECHA_NAC As DateTimePicker
    Friend WithEvents Label2 As Label
End Class
