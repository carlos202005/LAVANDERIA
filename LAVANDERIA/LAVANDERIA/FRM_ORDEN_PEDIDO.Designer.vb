<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_ORDEN_PEDIDO
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
        Me.OPCIONES = New System.Windows.Forms.GroupBox()
        Me.BTN_SALIR = New System.Windows.Forms.Button()
        Me.BTN_VER = New System.Windows.Forms.Button()
        Me.BTN_ELIMINAR = New System.Windows.Forms.Button()
        Me.BTN_EDITAR = New System.Windows.Forms.Button()
        Me.BTN_NUEVO = New System.Windows.Forms.Button()
        Me.CLIENTES = New System.Windows.Forms.GroupBox()
        Me.DGV_CLIENTES = New System.Windows.Forms.DataGridView()
        Me.OPCIONES.SuspendLayout()
        Me.CLIENTES.SuspendLayout()
        CType(Me.DGV_CLIENTES, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OPCIONES
        '
        Me.OPCIONES.Controls.Add(Me.BTN_SALIR)
        Me.OPCIONES.Controls.Add(Me.BTN_VER)
        Me.OPCIONES.Controls.Add(Me.BTN_ELIMINAR)
        Me.OPCIONES.Controls.Add(Me.BTN_EDITAR)
        Me.OPCIONES.Controls.Add(Me.BTN_NUEVO)
        Me.OPCIONES.Location = New System.Drawing.Point(12, 15)
        Me.OPCIONES.Name = "OPCIONES"
        Me.OPCIONES.Size = New System.Drawing.Size(116, 626)
        Me.OPCIONES.TabIndex = 1
        Me.OPCIONES.TabStop = False
        Me.OPCIONES.Text = "OPCIONES"
        '
        'BTN_SALIR
        '
        Me.BTN_SALIR.Location = New System.Drawing.Point(6, 505)
        Me.BTN_SALIR.Name = "BTN_SALIR"
        Me.BTN_SALIR.Size = New System.Drawing.Size(100, 115)
        Me.BTN_SALIR.TabIndex = 4
        Me.BTN_SALIR.Text = "SALIR"
        Me.BTN_SALIR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTN_SALIR.UseVisualStyleBackColor = True
        '
        'BTN_VER
        '
        Me.BTN_VER.Location = New System.Drawing.Point(6, 384)
        Me.BTN_VER.Name = "BTN_VER"
        Me.BTN_VER.Size = New System.Drawing.Size(100, 115)
        Me.BTN_VER.TabIndex = 3
        Me.BTN_VER.Text = "VER"
        Me.BTN_VER.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTN_VER.UseVisualStyleBackColor = True
        '
        'BTN_ELIMINAR
        '
        Me.BTN_ELIMINAR.Location = New System.Drawing.Point(6, 263)
        Me.BTN_ELIMINAR.Name = "BTN_ELIMINAR"
        Me.BTN_ELIMINAR.Size = New System.Drawing.Size(100, 115)
        Me.BTN_ELIMINAR.TabIndex = 2
        Me.BTN_ELIMINAR.Text = "ELIMINAR"
        Me.BTN_ELIMINAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTN_ELIMINAR.UseVisualStyleBackColor = True
        '
        'BTN_EDITAR
        '
        Me.BTN_EDITAR.Location = New System.Drawing.Point(6, 142)
        Me.BTN_EDITAR.Name = "BTN_EDITAR"
        Me.BTN_EDITAR.Size = New System.Drawing.Size(100, 115)
        Me.BTN_EDITAR.TabIndex = 1
        Me.BTN_EDITAR.Text = "EDITAR"
        Me.BTN_EDITAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTN_EDITAR.UseVisualStyleBackColor = True
        '
        'BTN_NUEVO
        '
        Me.BTN_NUEVO.Location = New System.Drawing.Point(6, 21)
        Me.BTN_NUEVO.Name = "BTN_NUEVO"
        Me.BTN_NUEVO.Size = New System.Drawing.Size(100, 115)
        Me.BTN_NUEVO.TabIndex = 0
        Me.BTN_NUEVO.Text = "ENTREGAR"
        Me.BTN_NUEVO.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTN_NUEVO.UseVisualStyleBackColor = True
        '
        'CLIENTES
        '
        Me.CLIENTES.Controls.Add(Me.DGV_CLIENTES)
        Me.CLIENTES.Location = New System.Drawing.Point(134, 15)
        Me.CLIENTES.Name = "CLIENTES"
        Me.CLIENTES.Size = New System.Drawing.Size(836, 626)
        Me.CLIENTES.TabIndex = 2
        Me.CLIENTES.TabStop = False
        Me.CLIENTES.Text = "ORDEN"
        '
        'DGV_CLIENTES
        '
        Me.DGV_CLIENTES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_CLIENTES.Location = New System.Drawing.Point(6, 21)
        Me.DGV_CLIENTES.Name = "DGV_CLIENTES"
        Me.DGV_CLIENTES.RowTemplate.Height = 24
        Me.DGV_CLIENTES.Size = New System.Drawing.Size(824, 599)
        Me.DGV_CLIENTES.TabIndex = 0
        '
        'FRM_ORDEN_PEDIDO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 653)
        Me.Controls.Add(Me.CLIENTES)
        Me.Controls.Add(Me.OPCIONES)
        Me.Name = "FRM_ORDEN_PEDIDO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ORDEN DE PEDIDO"
        Me.OPCIONES.ResumeLayout(False)
        Me.CLIENTES.ResumeLayout(False)
        CType(Me.DGV_CLIENTES, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Protected WithEvents OPCIONES As GroupBox
    Protected WithEvents BTN_SALIR As Button
    Protected WithEvents BTN_VER As Button
    Protected WithEvents BTN_ELIMINAR As Button
    Protected WithEvents BTN_EDITAR As Button
    Protected WithEvents BTN_NUEVO As Button
    Protected WithEvents CLIENTES As GroupBox
    Protected WithEvents DGV_CLIENTES As DataGridView
End Class
