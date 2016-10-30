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
        Me.RB_JURIDICA = New System.Windows.Forms.RadioButton()
        Me.RB_NARUTAL = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TXT_TELEFONO
        '
        Me.TXT_TELEFONO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_TELEFONO.Location = New System.Drawing.Point(607, 198)
        Me.TXT_TELEFONO.MaxLength = 9
        Me.TXT_TELEFONO.Name = "TXT_TELEFONO"
        Me.TXT_TELEFONO.Size = New System.Drawing.Size(159, 22)
        Me.TXT_TELEFONO.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(487, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 17)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "TELEFONO"
        '
        'TXT_CELULAR
        '
        Me.TXT_CELULAR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_CELULAR.Location = New System.Drawing.Point(298, 202)
        Me.TXT_CELULAR.MaxLength = 9
        Me.TXT_CELULAR.Name = "TXT_CELULAR"
        Me.TXT_CELULAR.Size = New System.Drawing.Size(175, 22)
        Me.TXT_CELULAR.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(154, 203)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 17)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "CELULAR"
        '
        'TXT_CORREO
        '
        Me.TXT_CORREO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_CORREO.Location = New System.Drawing.Point(298, 246)
        Me.TXT_CORREO.Name = "TXT_CORREO"
        Me.TXT_CORREO.Size = New System.Drawing.Size(175, 22)
        Me.TXT_CORREO.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(157, 251)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 17)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "CORREO"
        '
        'TXT_DOCUMENTO
        '
        Me.TXT_DOCUMENTO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_DOCUMENTO.Location = New System.Drawing.Point(297, 80)
        Me.TXT_DOCUMENTO.MaxLength = 11
        Me.TXT_DOCUMENTO.Name = "TXT_DOCUMENTO"
        Me.TXT_DOCUMENTO.Size = New System.Drawing.Size(175, 22)
        Me.TXT_DOCUMENTO.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(154, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 17)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "DOCUMENTO"
        '
        'TXT_APELLIDOS_MAT
        '
        Me.TXT_APELLIDOS_MAT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_APELLIDOS_MAT.Location = New System.Drawing.Point(607, 157)
        Me.TXT_APELLIDOS_MAT.Name = "TXT_APELLIDOS_MAT"
        Me.TXT_APELLIDOS_MAT.Size = New System.Drawing.Size(159, 22)
        Me.TXT_APELLIDOS_MAT.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(487, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 17)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "APELLIDO MAT."
        '
        'TXT_APELLIDOS_PAT
        '
        Me.TXT_APELLIDOS_PAT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_APELLIDOS_PAT.Location = New System.Drawing.Point(298, 159)
        Me.TXT_APELLIDOS_PAT.Name = "TXT_APELLIDOS_PAT"
        Me.TXT_APELLIDOS_PAT.Size = New System.Drawing.Size(175, 22)
        Me.TXT_APELLIDOS_PAT.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(154, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 17)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "APELLIDO PAT."
        '
        'TXT_NOMBRES
        '
        Me.TXT_NOMBRES.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_NOMBRES.Location = New System.Drawing.Point(298, 117)
        Me.TXT_NOMBRES.Name = "TXT_NOMBRES"
        Me.TXT_NOMBRES.Size = New System.Drawing.Size(468, 22)
        Me.TXT_NOMBRES.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(154, 120)
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
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "ACEPTAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(27, 162)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(111, 86)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "SALIR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RB_JURIDICA)
        Me.GroupBox1.Controls.Add(Me.RB_NARUTAL)
        Me.GroupBox1.Location = New System.Drawing.Point(478, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(288, 52)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TIPO DE CLIENTE"
        '
        'RB_JURIDICA
        '
        Me.RB_JURIDICA.AutoSize = True
        Me.RB_JURIDICA.Location = New System.Drawing.Point(154, 22)
        Me.RB_JURIDICA.Name = "RB_JURIDICA"
        Me.RB_JURIDICA.Size = New System.Drawing.Size(109, 21)
        Me.RB_JURIDICA.TabIndex = 1
        Me.RB_JURIDICA.Text = "MAYORISTA"
        Me.RB_JURIDICA.UseVisualStyleBackColor = True
        '
        'RB_NARUTAL
        '
        Me.RB_NARUTAL.AutoSize = True
        Me.RB_NARUTAL.Checked = True
        Me.RB_NARUTAL.Location = New System.Drawing.Point(23, 24)
        Me.RB_NARUTAL.Name = "RB_NARUTAL"
        Me.RB_NARUTAL.Size = New System.Drawing.Size(88, 21)
        Me.RB_NARUTAL.TabIndex = 0
        Me.RB_NARUTAL.TabStop = True
        Me.RB_NARUTAL.Text = "NORMAL"
        Me.RB_NARUTAL.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(487, 249)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 17)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "FECHA NAC."
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(607, 246)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DateTimePicker1.Size = New System.Drawing.Size(159, 22)
        Me.DateTimePicker1.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(154, 35)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(134, 17)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "TIPO DOCUMENTO"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(298, 32)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(174, 24)
        Me.ComboBox1.TabIndex = 1
        '
        'FRM_CLIENTE_CRUD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 301)
        Me.ControlBox = False
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label1)
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
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
