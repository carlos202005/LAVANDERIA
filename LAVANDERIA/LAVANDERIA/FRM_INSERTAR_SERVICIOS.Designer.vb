<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_INSERTAR_SERVICIOS
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
        Me.BTN_SALIR = New System.Windows.Forms.Button()
        Me.BTN_NUEVO = New System.Windows.Forms.Button()
        Me.TXT_PRECIO2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXT_PRECIO1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXT_NOMBRE = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_CODIGO = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CB_MEDIDA = New System.Windows.Forms.ComboBox()
        Me.CB_TIPO = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BTN_SALIR
        '
        Me.BTN_SALIR.Location = New System.Drawing.Point(284, 198)
        Me.BTN_SALIR.Name = "BTN_SALIR"
        Me.BTN_SALIR.Size = New System.Drawing.Size(100, 83)
        Me.BTN_SALIR.TabIndex = 9
        Me.BTN_SALIR.Text = "CANCELAR"
        Me.BTN_SALIR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTN_SALIR.UseVisualStyleBackColor = True
        '
        'BTN_NUEVO
        '
        Me.BTN_NUEVO.Location = New System.Drawing.Point(173, 198)
        Me.BTN_NUEVO.Name = "BTN_NUEVO"
        Me.BTN_NUEVO.Size = New System.Drawing.Size(100, 83)
        Me.BTN_NUEVO.TabIndex = 8
        Me.BTN_NUEVO.Text = "ACEPTAR"
        Me.BTN_NUEVO.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTN_NUEVO.UseVisualStyleBackColor = True
        '
        'TXT_PRECIO2
        '
        Me.TXT_PRECIO2.Location = New System.Drawing.Point(376, 104)
        Me.TXT_PRECIO2.MaxLength = 10
        Me.TXT_PRECIO2.Name = "TXT_PRECIO2"
        Me.TXT_PRECIO2.Size = New System.Drawing.Size(153, 22)
        Me.TXT_PRECIO2.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(299, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 17)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "PRECIO 2"
        '
        'TXT_PRECIO1
        '
        Me.TXT_PRECIO1.Location = New System.Drawing.Point(124, 104)
        Me.TXT_PRECIO1.MaxLength = 10
        Me.TXT_PRECIO1.Name = "TXT_PRECIO1"
        Me.TXT_PRECIO1.Size = New System.Drawing.Size(153, 22)
        Me.TXT_PRECIO1.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 17)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "PRECIO 1"
        '
        'TXT_NOMBRE
        '
        Me.TXT_NOMBRE.Location = New System.Drawing.Point(124, 57)
        Me.TXT_NOMBRE.Name = "TXT_NOMBRE"
        Me.TXT_NOMBRE.Size = New System.Drawing.Size(405, 22)
        Me.TXT_NOMBRE.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 17)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "NOMBRE"
        '
        'TXT_CODIGO
        '
        Me.TXT_CODIGO.Enabled = False
        Me.TXT_CODIGO.Location = New System.Drawing.Point(124, 19)
        Me.TXT_CODIGO.MaxLength = 4
        Me.TXT_CODIGO.Name = "TXT_CODIGO"
        Me.TXT_CODIGO.Size = New System.Drawing.Size(122, 22)
        Me.TXT_CODIGO.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 17)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "CÓDIGO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 17)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "MEDIDA"
        '
        'CB_MEDIDA
        '
        Me.CB_MEDIDA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_MEDIDA.FormattingEnabled = True
        Me.CB_MEDIDA.Location = New System.Drawing.Point(124, 147)
        Me.CB_MEDIDA.Name = "CB_MEDIDA"
        Me.CB_MEDIDA.Size = New System.Drawing.Size(153, 24)
        Me.CB_MEDIDA.TabIndex = 6
        '
        'CB_TIPO
        '
        Me.CB_TIPO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_TIPO.FormattingEnabled = True
        Me.CB_TIPO.Location = New System.Drawing.Point(376, 147)
        Me.CB_TIPO.Name = "CB_TIPO"
        Me.CB_TIPO.Size = New System.Drawing.Size(153, 24)
        Me.CB_TIPO.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(299, 150)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 17)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "TIPO"
        '
        'FRM_INSERTAR_SERVICIOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 298)
        Me.Controls.Add(Me.CB_TIPO)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CB_MEDIDA)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TXT_PRECIO2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TXT_PRECIO1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TXT_NOMBRE)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXT_CODIGO)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTN_NUEVO)
        Me.Controls.Add(Me.BTN_SALIR)
        Me.Name = "FRM_INSERTAR_SERVICIOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SERVICIOS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TXT_PRECIO2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TXT_PRECIO1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TXT_NOMBRE As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TXT_CODIGO As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CB_MEDIDA As ComboBox
    Friend WithEvents CB_TIPO As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents BTN_SALIR As Button
    Friend WithEvents BTN_NUEVO As Button
End Class
