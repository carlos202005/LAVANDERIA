<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_PROMOCIONES
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CB_SUCURSAL = New System.Windows.Forms.ComboBox()
        Me.CB_SERVICIO_BONO = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BTN_AGREGAR = New System.Windows.Forms.Button()
        Me.NUD_CANTIDAD_SERVICIO_BONO = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.NUD_CANTIDAD_SERVICIO = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CB_SERVICIO = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DGVPROMOCIONES = New System.Windows.Forms.DataGridView()
        Me.COD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DTP_FECHA_FIN = New System.Windows.Forms.DateTimePicker()
        Me.DTP_FECHA_INI = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXT_DESCRIPCION = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_CODIGO = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OPCIONES = New System.Windows.Forms.GroupBox()
        Me.BTN_SALIR = New System.Windows.Forms.Button()
        Me.BTN_ACEPTAR = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NUD_CANTIDAD_SERVICIO_BONO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_CANTIDAD_SERVICIO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVPROMOCIONES, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OPCIONES.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CB_SUCURSAL)
        Me.GroupBox1.Controls.Add(Me.CB_SERVICIO_BONO)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.BTN_AGREGAR)
        Me.GroupBox1.Controls.Add(Me.NUD_CANTIDAD_SERVICIO_BONO)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.NUD_CANTIDAD_SERVICIO)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.CB_SERVICIO)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.DGVPROMOCIONES)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.DTP_FECHA_FIN)
        Me.GroupBox1.Controls.Add(Me.DTP_FECHA_INI)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TXT_DESCRIPCION)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TXT_CODIGO)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(134, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(773, 548)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PROMOCIONES"
        '
        'CB_SUCURSAL
        '
        Me.CB_SUCURSAL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_SUCURSAL.FormattingEnabled = True
        Me.CB_SUCURSAL.Location = New System.Drawing.Point(151, 159)
        Me.CB_SUCURSAL.Name = "CB_SUCURSAL"
        Me.CB_SUCURSAL.Size = New System.Drawing.Size(210, 24)
        Me.CB_SUCURSAL.TabIndex = 3
        '
        'CB_SERVICIO_BONO
        '
        Me.CB_SERVICIO_BONO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_SERVICIO_BONO.FormattingEnabled = True
        Me.CB_SERVICIO_BONO.Location = New System.Drawing.Point(151, 310)
        Me.CB_SERVICIO_BONO.Name = "CB_SERVICIO_BONO"
        Me.CB_SERVICIO_BONO.Size = New System.Drawing.Size(210, 24)
        Me.CB_SERVICIO_BONO.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(31, 312)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 17)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "SERVICIO BONO:"
        '
        'BTN_AGREGAR
        '
        Me.BTN_AGREGAR.Location = New System.Drawing.Point(640, 274)
        Me.BTN_AGREGAR.Name = "BTN_AGREGAR"
        Me.BTN_AGREGAR.Size = New System.Drawing.Size(77, 60)
        Me.BTN_AGREGAR.TabIndex = 10
        Me.BTN_AGREGAR.Text = "Agregar"
        Me.BTN_AGREGAR.UseVisualStyleBackColor = True
        '
        'NUD_CANTIDAD_SERVICIO_BONO
        '
        Me.NUD_CANTIDAD_SERVICIO_BONO.Location = New System.Drawing.Point(573, 312)
        Me.NUD_CANTIDAD_SERVICIO_BONO.Name = "NUD_CANTIDAD_SERVICIO_BONO"
        Me.NUD_CANTIDAD_SERVICIO_BONO.Size = New System.Drawing.Size(51, 22)
        Me.NUD_CANTIDAD_SERVICIO_BONO.TabIndex = 9
        Me.NUD_CANTIDAD_SERVICIO_BONO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(450, 312)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(126, 17)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "CANTIDAD BONO:"
        '
        'NUD_CANTIDAD_SERVICIO
        '
        Me.NUD_CANTIDAD_SERVICIO.Location = New System.Drawing.Point(573, 278)
        Me.NUD_CANTIDAD_SERVICIO.Name = "NUD_CANTIDAD_SERVICIO"
        Me.NUD_CANTIDAD_SERVICIO.Size = New System.Drawing.Size(51, 22)
        Me.NUD_CANTIDAD_SERVICIO.TabIndex = 7
        Me.NUD_CANTIDAD_SERVICIO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(450, 279)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 17)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "CANTIDAD:"
        '
        'CB_SERVICIO
        '
        Me.CB_SERVICIO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_SERVICIO.FormattingEnabled = True
        Me.CB_SERVICIO.Location = New System.Drawing.Point(151, 276)
        Me.CB_SERVICIO.Name = "CB_SERVICIO"
        Me.CB_SERVICIO.Size = New System.Drawing.Size(210, 24)
        Me.CB_SERVICIO.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(31, 278)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 17)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "SERVICIO:"
        '
        'DGVPROMOCIONES
        '
        Me.DGVPROMOCIONES.AllowUserToAddRows = False
        Me.DGVPROMOCIONES.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVPROMOCIONES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPROMOCIONES.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.COD, Me.Column1, Me.Column5, Me.Column2, Me.Column3, Me.Column4})
        Me.DGVPROMOCIONES.Location = New System.Drawing.Point(16, 341)
        Me.DGVPROMOCIONES.MultiSelect = False
        Me.DGVPROMOCIONES.Name = "DGVPROMOCIONES"
        Me.DGVPROMOCIONES.ReadOnly = True
        Me.DGVPROMOCIONES.RowTemplate.Height = 24
        Me.DGVPROMOCIONES.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVPROMOCIONES.Size = New System.Drawing.Size(739, 188)
        Me.DGVPROMOCIONES.TabIndex = 30
        '
        'COD
        '
        Me.COD.FillWeight = 30.0!
        Me.COD.HeaderText = "COD"
        Me.COD.Name = "COD"
        Me.COD.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.FillWeight = 120.0!
        Me.Column1.HeaderText = "SERVICIO"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.FillWeight = 60.0!
        Me.Column5.HeaderText = "CANTIDAD"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.FillWeight = 60.0!
        Me.Column2.HeaderText = "COD. 2"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.FillWeight = 120.0!
        Me.Column3.HeaderText = "SERVICIO BONO"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.FillWeight = 50.0!
        Me.Column4.HeaderText = "CANT. BONO"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(368, 212)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 17)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "FECHA FIN:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 210)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 17)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "FECHA INICIO:"
        '
        'DTP_FECHA_FIN
        '
        Me.DTP_FECHA_FIN.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_FECHA_FIN.Location = New System.Drawing.Point(456, 207)
        Me.DTP_FECHA_FIN.Name = "DTP_FECHA_FIN"
        Me.DTP_FECHA_FIN.Size = New System.Drawing.Size(156, 22)
        Me.DTP_FECHA_FIN.TabIndex = 5
        '
        'DTP_FECHA_INI
        '
        Me.DTP_FECHA_INI.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_FECHA_INI.Location = New System.Drawing.Point(151, 205)
        Me.DTP_FECHA_INI.Name = "DTP_FECHA_INI"
        Me.DTP_FECHA_INI.Size = New System.Drawing.Size(170, 22)
        Me.DTP_FECHA_INI.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 17)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "SUCURSAL:"
        '
        'TXT_DESCRIPCION
        '
        Me.TXT_DESCRIPCION.Location = New System.Drawing.Point(151, 79)
        Me.TXT_DESCRIPCION.Multiline = True
        Me.TXT_DESCRIPCION.Name = "TXT_DESCRIPCION"
        Me.TXT_DESCRIPCION.Size = New System.Drawing.Size(338, 54)
        Me.TXT_DESCRIPCION.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 17)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "DESCRIPCION:"
        '
        'TXT_CODIGO
        '
        Me.TXT_CODIGO.Enabled = False
        Me.TXT_CODIGO.Location = New System.Drawing.Point(151, 37)
        Me.TXT_CODIGO.MaxLength = 4
        Me.TXT_CODIGO.Name = "TXT_CODIGO"
        Me.TXT_CODIGO.Size = New System.Drawing.Size(158, 22)
        Me.TXT_CODIGO.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 17)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "CÓDIGO:"
        '
        'OPCIONES
        '
        Me.OPCIONES.Controls.Add(Me.BTN_SALIR)
        Me.OPCIONES.Controls.Add(Me.BTN_ACEPTAR)
        Me.OPCIONES.Location = New System.Drawing.Point(12, 12)
        Me.OPCIONES.Name = "OPCIONES"
        Me.OPCIONES.Size = New System.Drawing.Size(116, 548)
        Me.OPCIONES.TabIndex = 5
        Me.OPCIONES.TabStop = False
        Me.OPCIONES.Text = "OPCIONES"
        '
        'BTN_SALIR
        '
        Me.BTN_SALIR.Location = New System.Drawing.Point(6, 430)
        Me.BTN_SALIR.Name = "BTN_SALIR"
        Me.BTN_SALIR.Size = New System.Drawing.Size(100, 99)
        Me.BTN_SALIR.TabIndex = 12
        Me.BTN_SALIR.Text = "CANCELAR"
        Me.BTN_SALIR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTN_SALIR.UseVisualStyleBackColor = True
        '
        'BTN_ACEPTAR
        '
        Me.BTN_ACEPTAR.Location = New System.Drawing.Point(6, 21)
        Me.BTN_ACEPTAR.Name = "BTN_ACEPTAR"
        Me.BTN_ACEPTAR.Size = New System.Drawing.Size(100, 92)
        Me.BTN_ACEPTAR.TabIndex = 11
        Me.BTN_ACEPTAR.Text = "ACEPTAR"
        Me.BTN_ACEPTAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTN_ACEPTAR.UseVisualStyleBackColor = True
        '
        'FRM_PROMOCIONES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 573)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.OPCIONES)
        Me.Name = "FRM_PROMOCIONES"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PROMOCIONES"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NUD_CANTIDAD_SERVICIO_BONO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_CANTIDAD_SERVICIO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVPROMOCIONES, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OPCIONES.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TXT_DESCRIPCION As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TXT_CODIGO As TextBox
    Friend WithEvents Label1 As Label
    Protected WithEvents OPCIONES As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DTP_FECHA_FIN As DateTimePicker
    Friend WithEvents DTP_FECHA_INI As DateTimePicker
    Friend WithEvents DGVPROMOCIONES As DataGridView
    Friend WithEvents NUD_CANTIDAD_SERVICIO As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents CB_SERVICIO As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents NUD_CANTIDAD_SERVICIO_BONO As NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents BTN_AGREGAR As Button
    Friend WithEvents CB_SERVICIO_BONO As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents CB_SUCURSAL As ComboBox
    Friend WithEvents COD As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents BTN_SALIR As Button
    Friend WithEvents BTN_ACEPTAR As Button
End Class
