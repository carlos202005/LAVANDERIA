<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_PROVEEDORES
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
        Me.BUSCAR = New System.Windows.Forms.GroupBox()
        Me.RB_RUC = New System.Windows.Forms.RadioButton()
        Me.RB_RAZON_SOCIAL = New System.Windows.Forms.RadioButton()
        Me.TXT_NOMBRES = New System.Windows.Forms.TextBox()
        Me.BTN_BUSCAR = New System.Windows.Forms.Button()
        Me.CLIENTES = New System.Windows.Forms.GroupBox()
        Me.DGV_PROVEEDORES = New System.Windows.Forms.DataGridView()
        Me.OPCIONES = New System.Windows.Forms.GroupBox()
        Me.BTN_SALIR = New System.Windows.Forms.Button()
        Me.BTN_VER = New System.Windows.Forms.Button()
        Me.BTN_ELIMINAR = New System.Windows.Forms.Button()
        Me.BTN_EDITAR = New System.Windows.Forms.Button()
        Me.BTN_NUEVO = New System.Windows.Forms.Button()
        Me.BUSCAR.SuspendLayout()
        Me.CLIENTES.SuspendLayout()
        CType(Me.DGV_PROVEEDORES, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OPCIONES.SuspendLayout()
        Me.SuspendLayout()
        '
        'BUSCAR
        '
        Me.BUSCAR.BackColor = System.Drawing.Color.Transparent
        Me.BUSCAR.Controls.Add(Me.RB_RUC)
        Me.BUSCAR.Controls.Add(Me.RB_RAZON_SOCIAL)
        Me.BUSCAR.Controls.Add(Me.TXT_NOMBRES)
        Me.BUSCAR.Controls.Add(Me.BTN_BUSCAR)
        Me.BUSCAR.Location = New System.Drawing.Point(134, 538)
        Me.BUSCAR.Name = "BUSCAR"
        Me.BUSCAR.Size = New System.Drawing.Size(836, 102)
        Me.BUSCAR.TabIndex = 9
        Me.BUSCAR.TabStop = False
        Me.BUSCAR.Text = "BUSCAR"
        '
        'RB_RUC
        '
        Me.RB_RUC.AutoSize = True
        Me.RB_RUC.Location = New System.Drawing.Point(29, 67)
        Me.RB_RUC.Name = "RB_RUC"
        Me.RB_RUC.Size = New System.Drawing.Size(58, 21)
        Me.RB_RUC.TabIndex = 4
        Me.RB_RUC.Text = "RUC"
        Me.RB_RUC.UseVisualStyleBackColor = True
        '
        'RB_RAZON_SOCIAL
        '
        Me.RB_RAZON_SOCIAL.AutoSize = True
        Me.RB_RAZON_SOCIAL.Checked = True
        Me.RB_RAZON_SOCIAL.Location = New System.Drawing.Point(29, 26)
        Me.RB_RAZON_SOCIAL.Name = "RB_RAZON_SOCIAL"
        Me.RB_RAZON_SOCIAL.Size = New System.Drawing.Size(112, 21)
        Me.RB_RAZON_SOCIAL.TabIndex = 3
        Me.RB_RAZON_SOCIAL.TabStop = True
        Me.RB_RAZON_SOCIAL.Text = "Razon Social"
        Me.RB_RAZON_SOCIAL.UseVisualStyleBackColor = True
        '
        'TXT_NOMBRES
        '
        Me.TXT_NOMBRES.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_NOMBRES.Location = New System.Drawing.Point(275, 42)
        Me.TXT_NOMBRES.Name = "TXT_NOMBRES"
        Me.TXT_NOMBRES.Size = New System.Drawing.Size(425, 27)
        Me.TXT_NOMBRES.TabIndex = 2
        '
        'BTN_BUSCAR
        '
        Me.BTN_BUSCAR.Location = New System.Drawing.Point(719, 25)
        Me.BTN_BUSCAR.Name = "BTN_BUSCAR"
        Me.BTN_BUSCAR.Size = New System.Drawing.Size(94, 63)
        Me.BTN_BUSCAR.TabIndex = 1
        Me.BTN_BUSCAR.Text = "BUSCAR"
        Me.BTN_BUSCAR.UseVisualStyleBackColor = True
        '
        'CLIENTES
        '
        Me.CLIENTES.BackColor = System.Drawing.Color.Transparent
        Me.CLIENTES.Controls.Add(Me.DGV_PROVEEDORES)
        Me.CLIENTES.Location = New System.Drawing.Point(134, 12)
        Me.CLIENTES.Name = "CLIENTES"
        Me.CLIENTES.Size = New System.Drawing.Size(836, 518)
        Me.CLIENTES.TabIndex = 8
        Me.CLIENTES.TabStop = False
        Me.CLIENTES.Text = "PROVEEDORES"
        '
        'DGV_PROVEEDORES
        '
        Me.DGV_PROVEEDORES.AllowUserToAddRows = False
        Me.DGV_PROVEEDORES.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_PROVEEDORES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_PROVEEDORES.Location = New System.Drawing.Point(6, 21)
        Me.DGV_PROVEEDORES.MultiSelect = False
        Me.DGV_PROVEEDORES.Name = "DGV_PROVEEDORES"
        Me.DGV_PROVEEDORES.ReadOnly = True
        Me.DGV_PROVEEDORES.RowTemplate.Height = 24
        Me.DGV_PROVEEDORES.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_PROVEEDORES.Size = New System.Drawing.Size(824, 491)
        Me.DGV_PROVEEDORES.TabIndex = 0
        '
        'OPCIONES
        '
        Me.OPCIONES.BackColor = System.Drawing.Color.Transparent
        Me.OPCIONES.Controls.Add(Me.BTN_SALIR)
        Me.OPCIONES.Controls.Add(Me.BTN_VER)
        Me.OPCIONES.Controls.Add(Me.BTN_ELIMINAR)
        Me.OPCIONES.Controls.Add(Me.BTN_EDITAR)
        Me.OPCIONES.Controls.Add(Me.BTN_NUEVO)
        Me.OPCIONES.Location = New System.Drawing.Point(12, 12)
        Me.OPCIONES.Name = "OPCIONES"
        Me.OPCIONES.Size = New System.Drawing.Size(116, 626)
        Me.OPCIONES.TabIndex = 7
        Me.OPCIONES.TabStop = False
        Me.OPCIONES.Text = "OPCIONES"
        '
        'BTN_SALIR
        '
        Me.BTN_SALIR.FlatAppearance.BorderSize = 0
        Me.BTN_SALIR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BTN_SALIR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.BTN_SALIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_SALIR.Image = Global.LAVANDERIA.My.Resources.Resources._1470052726_delete_16
        Me.BTN_SALIR.Location = New System.Drawing.Point(6, 505)
        Me.BTN_SALIR.Name = "BTN_SALIR"
        Me.BTN_SALIR.Size = New System.Drawing.Size(100, 115)
        Me.BTN_SALIR.TabIndex = 4
        Me.BTN_SALIR.UseVisualStyleBackColor = True
        '
        'BTN_VER
        '
        Me.BTN_VER.FlatAppearance.BorderSize = 0
        Me.BTN_VER.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BTN_VER.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.BTN_VER.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_VER.Image = Global.LAVANDERIA.My.Resources.Resources._1470052742_search_16
        Me.BTN_VER.Location = New System.Drawing.Point(6, 384)
        Me.BTN_VER.Name = "BTN_VER"
        Me.BTN_VER.Size = New System.Drawing.Size(100, 115)
        Me.BTN_VER.TabIndex = 3
        Me.BTN_VER.UseVisualStyleBackColor = True
        '
        'BTN_ELIMINAR
        '
        Me.BTN_ELIMINAR.FlatAppearance.BorderSize = 0
        Me.BTN_ELIMINAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BTN_ELIMINAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.BTN_ELIMINAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_ELIMINAR.Image = Global.LAVANDERIA.My.Resources.Resources._1470052776_trash_16
        Me.BTN_ELIMINAR.Location = New System.Drawing.Point(6, 263)
        Me.BTN_ELIMINAR.Name = "BTN_ELIMINAR"
        Me.BTN_ELIMINAR.Size = New System.Drawing.Size(100, 115)
        Me.BTN_ELIMINAR.TabIndex = 2
        Me.BTN_ELIMINAR.UseVisualStyleBackColor = True
        '
        'BTN_EDITAR
        '
        Me.BTN_EDITAR.FlatAppearance.BorderSize = 0
        Me.BTN_EDITAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BTN_EDITAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.BTN_EDITAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_EDITAR.Image = Global.LAVANDERIA.My.Resources.Resources._1470053680_reload
        Me.BTN_EDITAR.Location = New System.Drawing.Point(6, 142)
        Me.BTN_EDITAR.Name = "BTN_EDITAR"
        Me.BTN_EDITAR.Size = New System.Drawing.Size(100, 115)
        Me.BTN_EDITAR.TabIndex = 1
        Me.BTN_EDITAR.UseVisualStyleBackColor = True
        '
        'BTN_NUEVO
        '
        Me.BTN_NUEVO.FlatAppearance.BorderSize = 0
        Me.BTN_NUEVO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BTN_NUEVO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.BTN_NUEVO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_NUEVO.Image = Global.LAVANDERIA.My.Resources.Resources._1470052722_plus_16
        Me.BTN_NUEVO.Location = New System.Drawing.Point(6, 21)
        Me.BTN_NUEVO.Name = "BTN_NUEVO"
        Me.BTN_NUEVO.Size = New System.Drawing.Size(100, 115)
        Me.BTN_NUEVO.TabIndex = 0
        Me.BTN_NUEVO.UseVisualStyleBackColor = True
        '
        'FRM_PROVEEDORES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 653)
        Me.Controls.Add(Me.BUSCAR)
        Me.Controls.Add(Me.CLIENTES)
        Me.Controls.Add(Me.OPCIONES)
        Me.Name = "FRM_PROVEEDORES"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PROVEEDORES"
        Me.BUSCAR.ResumeLayout(False)
        Me.BUSCAR.PerformLayout()
        Me.CLIENTES.ResumeLayout(False)
        CType(Me.DGV_PROVEEDORES, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OPCIONES.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Protected WithEvents BUSCAR As GroupBox
    Friend WithEvents RB_RUC As RadioButton
    Friend WithEvents RB_RAZON_SOCIAL As RadioButton
    Protected WithEvents TXT_NOMBRES As TextBox
    Protected WithEvents BTN_BUSCAR As Button
    Protected WithEvents CLIENTES As GroupBox
    Protected WithEvents DGV_PROVEEDORES As DataGridView
    Protected WithEvents OPCIONES As GroupBox
    Protected WithEvents BTN_SALIR As Button
    Protected WithEvents BTN_VER As Button
    Protected WithEvents BTN_ELIMINAR As Button
    Protected WithEvents BTN_EDITAR As Button
    Protected WithEvents BTN_NUEVO As Button
End Class
