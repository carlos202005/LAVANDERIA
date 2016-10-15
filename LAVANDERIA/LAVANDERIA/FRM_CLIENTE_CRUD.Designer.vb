<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_CLIENTE_CRUD
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
        Me.TXT_TELEFONO = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXT_CELULAR = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXT_CORREO = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXT_DOCUMENTO = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TXT_APELLIDOS_MAT = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXT_APELLIDOS_PAT = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXT_NOMBRES = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RB_NARUTAL = New System.Windows.Forms.RadioButton()
        Me.RB_JURIDICA = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TXT_TELEFONO
        '
        Me.TXT_TELEFONO.Location = New System.Drawing.Point(606, 180)
        Me.TXT_TELEFONO.MaxLength = 11
        Me.TXT_TELEFONO.Name = "TXT_TELEFONO"
        Me.TXT_TELEFONO.Size = New System.Drawing.Size(159, 22)
        Me.TXT_TELEFONO.TabIndex = 51
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(486, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 17)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "TELEFONO"
        '
        'TXT_CELULAR
        '
        Me.TXT_CELULAR.Location = New System.Drawing.Point(297, 182)
        Me.TXT_CELULAR.MaxLength = 11
        Me.TXT_CELULAR.Name = "TXT_CELULAR"
        Me.TXT_CELULAR.Size = New System.Drawing.Size(175, 22)
        Me.TXT_CELULAR.TabIndex = 49
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(178, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 17)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "CELULAR"
        '
        'TXT_CORREO
        '
        Me.TXT_CORREO.Location = New System.Drawing.Point(297, 226)
        Me.TXT_CORREO.Name = "TXT_CORREO"
        Me.TXT_CORREO.Size = New System.Drawing.Size(468, 22)
        Me.TXT_CORREO.TabIndex = 47
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(181, 229)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 17)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "CORREO"
        '
        'TXT_DOCUMENTO
        '
        Me.TXT_DOCUMENTO.Location = New System.Drawing.Point(297, 56)
        Me.TXT_DOCUMENTO.Name = "TXT_DOCUMENTO"
        Me.TXT_DOCUMENTO.Size = New System.Drawing.Size(175, 22)
        Me.TXT_DOCUMENTO.TabIndex = 45
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(177, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 17)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "DOCUMENTO"
        '
        'TXT_APELLIDOS_MAT
        '
        Me.TXT_APELLIDOS_MAT.Location = New System.Drawing.Point(606, 137)
        Me.TXT_APELLIDOS_MAT.Name = "TXT_APELLIDOS_MAT"
        Me.TXT_APELLIDOS_MAT.Size = New System.Drawing.Size(159, 22)
        Me.TXT_APELLIDOS_MAT.TabIndex = 43
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(486, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 17)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "APELLIDO MAT."
        '
        'TXT_APELLIDOS_PAT
        '
        Me.TXT_APELLIDOS_PAT.Location = New System.Drawing.Point(297, 139)
        Me.TXT_APELLIDOS_PAT.Name = "TXT_APELLIDOS_PAT"
        Me.TXT_APELLIDOS_PAT.Size = New System.Drawing.Size(175, 22)
        Me.TXT_APELLIDOS_PAT.TabIndex = 41
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(177, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 17)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "APELLIDO PAT."
        '
        'TXT_NOMBRES
        '
        Me.TXT_NOMBRES.Location = New System.Drawing.Point(297, 97)
        Me.TXT_NOMBRES.Name = "TXT_NOMBRES"
        Me.TXT_NOMBRES.Size = New System.Drawing.Size(468, 22)
        Me.TXT_NOMBRES.TabIndex = 39
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(177, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 17)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "NOMBRE(S)"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(27, 35)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 88)
        Me.Button1.TabIndex = 54
        Me.Button1.Text = "ACEPTAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(27, 167)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(111, 86)
        Me.Button2.TabIndex = 55
        Me.Button2.Text = "SALIR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RB_JURIDICA)
        Me.GroupBox1.Controls.Add(Me.RB_NARUTAL)
        Me.GroupBox1.Location = New System.Drawing.Point(478, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(288, 52)
        Me.GroupBox1.TabIndex = 56
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TIPO DE CLIENTE"
        '
        'RB_NARUTAL
        '
        Me.RB_NARUTAL.AutoSize = True
        Me.RB_NARUTAL.Checked = True
        Me.RB_NARUTAL.Location = New System.Drawing.Point(23, 24)
        Me.RB_NARUTAL.Name = "RB_NARUTAL"
        Me.RB_NARUTAL.Size = New System.Drawing.Size(94, 21)
        Me.RB_NARUTAL.TabIndex = 0
        Me.RB_NARUTAL.TabStop = True
        Me.RB_NARUTAL.Text = "NATURAL"
        Me.RB_NARUTAL.UseVisualStyleBackColor = True
        '
        'RB_JURIDICA
        '
        Me.RB_JURIDICA.AutoSize = True
        Me.RB_JURIDICA.Location = New System.Drawing.Point(154, 22)
        Me.RB_JURIDICA.Name = "RB_JURIDICA"
        Me.RB_JURIDICA.Size = New System.Drawing.Size(90, 21)
        Me.RB_JURIDICA.TabIndex = 1
        Me.RB_JURIDICA.Text = "JURIDICA"
        Me.RB_JURIDICA.UseVisualStyleBackColor = True
        '
        'FRM_CLIENTE_CRUD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 307)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TXT_TELEFONO)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TXT_CELULAR)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TXT_CORREO)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TXT_DOCUMENTO)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TXT_APELLIDOS_MAT)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TXT_APELLIDOS_PAT)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TXT_NOMBRES)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FRM_CLIENTE_CRUD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CLIENTES"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TXT_TELEFONO As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TXT_CELULAR As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TXT_CORREO As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TXT_DOCUMENTO As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TXT_APELLIDOS_MAT As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TXT_APELLIDOS_PAT As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TXT_NOMBRES As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RB_JURIDICA As RadioButton
    Friend WithEvents RB_NARUTAL As RadioButton
End Class
