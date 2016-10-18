<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_GASTOS
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
        Me.TXT_SERIE = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXT_CODIGO_DOC = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXT_DESCRIPCION = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXT_NUMERO = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DTP_FECHA_VENCIMIENTO = New System.Windows.Forms.DateTimePicker()
        Me.TXT_MONTO = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXT_OBSERVACION = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BTN_ACEPTAR = New System.Windows.Forms.Button()
        Me.BTN_SALIR = New System.Windows.Forms.Button()
        Me.CB_PROVEEDOR = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CB_SUCURSAL = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TXT_SERIE
        '
        Me.TXT_SERIE.Location = New System.Drawing.Point(144, 99)
        Me.TXT_SERIE.MaxLength = 10
        Me.TXT_SERIE.Name = "TXT_SERIE"
        Me.TXT_SERIE.Size = New System.Drawing.Size(180, 22)
        Me.TXT_SERIE.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 17)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "SERIE"
        '
        'TXT_CODIGO_DOC
        '
        Me.TXT_CODIGO_DOC.Location = New System.Drawing.Point(144, 64)
        Me.TXT_CODIGO_DOC.MaxLength = 15
        Me.TXT_CODIGO_DOC.Name = "TXT_CODIGO_DOC"
        Me.TXT_CODIGO_DOC.Size = New System.Drawing.Size(407, 22)
        Me.TXT_CODIGO_DOC.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 17)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "COD. DOC."
        '
        'TXT_DESCRIPCION
        '
        Me.TXT_DESCRIPCION.Location = New System.Drawing.Point(144, 141)
        Me.TXT_DESCRIPCION.Multiline = True
        Me.TXT_DESCRIPCION.Name = "TXT_DESCRIPCION"
        Me.TXT_DESCRIPCION.Size = New System.Drawing.Size(407, 70)
        Me.TXT_DESCRIPCION.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 17)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "DESCRIPCIÓN"
        '
        'TXT_NUMERO
        '
        Me.TXT_NUMERO.Location = New System.Drawing.Point(414, 101)
        Me.TXT_NUMERO.MaxLength = 10
        Me.TXT_NUMERO.Name = "TXT_NUMERO"
        Me.TXT_NUMERO.Size = New System.Drawing.Size(137, 22)
        Me.TXT_NUMERO.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(340, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "NUMERO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 235)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 17)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "FECHA VENC."
        '
        'DTP_FECHA_VENCIMIENTO
        '
        Me.DTP_FECHA_VENCIMIENTO.Location = New System.Drawing.Point(144, 230)
        Me.DTP_FECHA_VENCIMIENTO.Name = "DTP_FECHA_VENCIMIENTO"
        Me.DTP_FECHA_VENCIMIENTO.Size = New System.Drawing.Size(407, 22)
        Me.DTP_FECHA_VENCIMIENTO.TabIndex = 6
        '
        'TXT_MONTO
        '
        Me.TXT_MONTO.Location = New System.Drawing.Point(144, 276)
        Me.TXT_MONTO.Name = "TXT_MONTO"
        Me.TXT_MONTO.Size = New System.Drawing.Size(265, 22)
        Me.TXT_MONTO.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(29, 279)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 17)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "MONTO"
        '
        'TXT_OBSERVACION
        '
        Me.TXT_OBSERVACION.Location = New System.Drawing.Point(144, 368)
        Me.TXT_OBSERVACION.Multiline = True
        Me.TXT_OBSERVACION.Name = "TXT_OBSERVACION"
        Me.TXT_OBSERVACION.Size = New System.Drawing.Size(407, 70)
        Me.TXT_OBSERVACION.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(29, 371)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 17)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "OBSERVACION"
        '
        'BTN_ACEPTAR
        '
        Me.BTN_ACEPTAR.Location = New System.Drawing.Point(200, 444)
        Me.BTN_ACEPTAR.Name = "BTN_ACEPTAR"
        Me.BTN_ACEPTAR.Size = New System.Drawing.Size(109, 63)
        Me.BTN_ACEPTAR.TabIndex = 10
        Me.BTN_ACEPTAR.Text = "ACEPTAR"
        Me.BTN_ACEPTAR.UseVisualStyleBackColor = True
        '
        'BTN_SALIR
        '
        Me.BTN_SALIR.Location = New System.Drawing.Point(328, 444)
        Me.BTN_SALIR.Name = "BTN_SALIR"
        Me.BTN_SALIR.Size = New System.Drawing.Size(109, 63)
        Me.BTN_SALIR.TabIndex = 11
        Me.BTN_SALIR.Text = "SALIR"
        Me.BTN_SALIR.UseVisualStyleBackColor = True
        '
        'CB_PROVEEDOR
        '
        Me.CB_PROVEEDOR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_PROVEEDOR.FormattingEnabled = True
        Me.CB_PROVEEDOR.Location = New System.Drawing.Point(144, 318)
        Me.CB_PROVEEDOR.Name = "CB_PROVEEDOR"
        Me.CB_PROVEEDOR.Size = New System.Drawing.Size(265, 24)
        Me.CB_PROVEEDOR.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 321)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 17)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "PROVEEDOR"
        '
        'CB_SUCURSAL
        '
        Me.CB_SUCURSAL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_SUCURSAL.FormattingEnabled = True
        Me.CB_SUCURSAL.Location = New System.Drawing.Point(144, 24)
        Me.CB_SUCURSAL.Name = "CB_SUCURSAL"
        Me.CB_SUCURSAL.Size = New System.Drawing.Size(265, 24)
        Me.CB_SUCURSAL.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(29, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 17)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "SUCURSAL"
        '
        'FRM_GASTOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 519)
        Me.Controls.Add(Me.CB_SUCURSAL)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.CB_PROVEEDOR)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTN_SALIR)
        Me.Controls.Add(Me.BTN_ACEPTAR)
        Me.Controls.Add(Me.TXT_OBSERVACION)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TXT_MONTO)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DTP_FECHA_VENCIMIENTO)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TXT_SERIE)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TXT_CODIGO_DOC)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TXT_DESCRIPCION)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TXT_NUMERO)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FRM_GASTOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RECIBOS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXT_SERIE As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TXT_CODIGO_DOC As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TXT_DESCRIPCION As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TXT_NUMERO As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DTP_FECHA_VENCIMIENTO As DateTimePicker
    Friend WithEvents TXT_MONTO As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TXT_OBSERVACION As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents BTN_ACEPTAR As Button
    Friend WithEvents BTN_SALIR As Button
    Friend WithEvents CB_PROVEEDOR As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CB_SUCURSAL As ComboBox
    Friend WithEvents Label9 As Label
End Class
