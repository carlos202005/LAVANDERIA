<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_PRODUCTO
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_CODIGO = New System.Windows.Forms.TextBox()
        Me.TXT_PRODUCTO = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_STOCK = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXT_PRECIO_UNI = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CB_MEDIDA = New System.Windows.Forms.ComboBox()
        Me.CB_PROVEEDOR = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CB_TIPO_PRODUCTO = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(153, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CODIGO"
        '
        'TXT_CODIGO
        '
        Me.TXT_CODIGO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_CODIGO.Location = New System.Drawing.Point(255, 21)
        Me.TXT_CODIGO.MaxLength = 20
        Me.TXT_CODIGO.Name = "TXT_CODIGO"
        Me.TXT_CODIGO.Size = New System.Drawing.Size(142, 22)
        Me.TXT_CODIGO.TabIndex = 1
        '
        'TXT_PRODUCTO
        '
        Me.TXT_PRODUCTO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_PRODUCTO.Location = New System.Drawing.Point(255, 61)
        Me.TXT_PRODUCTO.MaxLength = 100
        Me.TXT_PRODUCTO.Name = "TXT_PRODUCTO"
        Me.TXT_PRODUCTO.Size = New System.Drawing.Size(429, 22)
        Me.TXT_PRODUCTO.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(153, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "PRODUCTO"
        '
        'TXT_STOCK
        '
        Me.TXT_STOCK.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_STOCK.Location = New System.Drawing.Point(255, 107)
        Me.TXT_STOCK.Name = "TXT_STOCK"
        Me.TXT_STOCK.Size = New System.Drawing.Size(193, 22)
        Me.TXT_STOCK.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(153, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "STOCK"
        '
        'TXT_PRECIO_UNI
        '
        Me.TXT_PRECIO_UNI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_PRECIO_UNI.Location = New System.Drawing.Point(547, 107)
        Me.TXT_PRECIO_UNI.Name = "TXT_PRECIO_UNI"
        Me.TXT_PRECIO_UNI.Size = New System.Drawing.Size(137, 22)
        Me.TXT_PRECIO_UNI.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(454, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "PRECIO UNI."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(153, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "MEDIDA"
        '
        'CB_MEDIDA
        '
        Me.CB_MEDIDA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_MEDIDA.FormattingEnabled = True
        Me.CB_MEDIDA.Location = New System.Drawing.Point(255, 150)
        Me.CB_MEDIDA.Name = "CB_MEDIDA"
        Me.CB_MEDIDA.Size = New System.Drawing.Size(193, 24)
        Me.CB_MEDIDA.TabIndex = 5
        '
        'CB_PROVEEDOR
        '
        Me.CB_PROVEEDOR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_PROVEEDOR.FormattingEnabled = True
        Me.CB_PROVEEDOR.Location = New System.Drawing.Point(255, 197)
        Me.CB_PROVEEDOR.Name = "CB_PROVEEDOR"
        Me.CB_PROVEEDOR.Size = New System.Drawing.Size(193, 24)
        Me.CB_PROVEEDOR.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(153, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "PROVEEDOR"
        '
        'CB_TIPO_PRODUCTO
        '
        Me.CB_TIPO_PRODUCTO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_TIPO_PRODUCTO.FormattingEnabled = True
        Me.CB_TIPO_PRODUCTO.Location = New System.Drawing.Point(547, 150)
        Me.CB_TIPO_PRODUCTO.Name = "CB_TIPO_PRODUCTO"
        Me.CB_TIPO_PRODUCTO.Size = New System.Drawing.Size(137, 24)
        Me.CB_TIPO_PRODUCTO.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(456, 153)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 17)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "TIPO PROD."
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 174)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(111, 68)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "SALIR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 68)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "ACEPTAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FRM_PRODUCTO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 253)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CB_TIPO_PRODUCTO)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CB_PROVEEDOR)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CB_MEDIDA)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TXT_PRECIO_UNI)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TXT_STOCK)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TXT_PRODUCTO)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXT_CODIGO)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FRM_PRODUCTO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PRODUCTOS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_CODIGO As TextBox
    Friend WithEvents TXT_PRODUCTO As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TXT_STOCK As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TXT_PRECIO_UNI As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CB_MEDIDA As ComboBox
    Friend WithEvents CB_PROVEEDOR As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CB_TIPO_PRODUCTO As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
