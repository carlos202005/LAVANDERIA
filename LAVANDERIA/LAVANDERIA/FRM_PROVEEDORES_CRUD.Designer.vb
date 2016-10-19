<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_PROVEEDORES_CRUD
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
        Me.TXT_CORREO = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TXT_TELEFONO = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TXT_CELULAR = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TXT_RUC = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TXT_RAZON_SOCIAL = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.BTN_SALIR = New System.Windows.Forms.Button()
        Me.BTN_ACEPTAR = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TXT_CORREO
        '
        Me.TXT_CORREO.Location = New System.Drawing.Point(150, 157)
        Me.TXT_CORREO.Name = "TXT_CORREO"
        Me.TXT_CORREO.Size = New System.Drawing.Size(443, 22)
        Me.TXT_CORREO.TabIndex = 43
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(30, 160)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(68, 17)
        Me.Label23.TabIndex = 42
        Me.Label23.Text = "CORREO"
        '
        'TXT_TELEFONO
        '
        Me.TXT_TELEFONO.Location = New System.Drawing.Point(150, 112)
        Me.TXT_TELEFONO.MaxLength = 11
        Me.TXT_TELEFONO.Name = "TXT_TELEFONO"
        Me.TXT_TELEFONO.Size = New System.Drawing.Size(192, 22)
        Me.TXT_TELEFONO.TabIndex = 41
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(30, 115)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(83, 17)
        Me.Label24.TabIndex = 40
        Me.Label24.Text = "TELEFONO"
        '
        'TXT_CELULAR
        '
        Me.TXT_CELULAR.Location = New System.Drawing.Point(439, 71)
        Me.TXT_CELULAR.MaxLength = 11
        Me.TXT_CELULAR.Name = "TXT_CELULAR"
        Me.TXT_CELULAR.Size = New System.Drawing.Size(154, 22)
        Me.TXT_CELULAR.TabIndex = 39
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(362, 76)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(71, 17)
        Me.Label25.TabIndex = 38
        Me.Label25.Text = "CELULAR"
        '
        'TXT_RUC
        '
        Me.TXT_RUC.Location = New System.Drawing.Point(150, 71)
        Me.TXT_RUC.MaxLength = 11
        Me.TXT_RUC.Name = "TXT_RUC"
        Me.TXT_RUC.Size = New System.Drawing.Size(192, 22)
        Me.TXT_RUC.TabIndex = 37
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(30, 74)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(37, 17)
        Me.Label26.TabIndex = 36
        Me.Label26.Text = "RUC"
        '
        'TXT_RAZON_SOCIAL
        '
        Me.TXT_RAZON_SOCIAL.Location = New System.Drawing.Point(150, 30)
        Me.TXT_RAZON_SOCIAL.Name = "TXT_RAZON_SOCIAL"
        Me.TXT_RAZON_SOCIAL.Size = New System.Drawing.Size(443, 22)
        Me.TXT_RAZON_SOCIAL.TabIndex = 35
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(30, 33)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(110, 17)
        Me.Label27.TabIndex = 34
        Me.Label27.Text = "RAZON SOCIAL"
        '
        'BTN_SALIR
        '
        Me.BTN_SALIR.Location = New System.Drawing.Point(346, 198)
        Me.BTN_SALIR.Name = "BTN_SALIR"
        Me.BTN_SALIR.Size = New System.Drawing.Size(111, 89)
        Me.BTN_SALIR.TabIndex = 57
        Me.BTN_SALIR.Text = "SALIR"
        Me.BTN_SALIR.UseVisualStyleBackColor = True
        '
        'BTN_ACEPTAR
        '
        Me.BTN_ACEPTAR.Location = New System.Drawing.Point(191, 198)
        Me.BTN_ACEPTAR.Name = "BTN_ACEPTAR"
        Me.BTN_ACEPTAR.Size = New System.Drawing.Size(111, 89)
        Me.BTN_ACEPTAR.TabIndex = 56
        Me.BTN_ACEPTAR.Text = "ACEPTAR"
        Me.BTN_ACEPTAR.UseVisualStyleBackColor = True
        '
        'FRM_PROVEEDORES_CRUD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 299)
        Me.Controls.Add(Me.BTN_SALIR)
        Me.Controls.Add(Me.BTN_ACEPTAR)
        Me.Controls.Add(Me.TXT_CORREO)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.TXT_TELEFONO)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.TXT_CELULAR)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.TXT_RUC)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.TXT_RAZON_SOCIAL)
        Me.Controls.Add(Me.Label27)
        Me.Name = "FRM_PROVEEDORES_CRUD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PROVEEDORES"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TXT_CORREO As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents TXT_TELEFONO As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents TXT_CELULAR As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents TXT_RUC As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents TXT_RAZON_SOCIAL As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents BTN_SALIR As Button
    Friend WithEvents BTN_ACEPTAR As Button
End Class
