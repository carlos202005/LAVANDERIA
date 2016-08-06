<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_INSERTAR_GASTOS
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
        Me.TAB_CONTROL1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DATOS = New System.Windows.Forms.GroupBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.OPCIONES = New System.Windows.Forms.GroupBox()
        Me.BTN_SALIR = New System.Windows.Forms.Button()
        Me.BTN_NUEVO = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TAB_CONTROL1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.OPCIONES.SuspendLayout()
        Me.SuspendLayout()
        '
        'TAB_CONTROL1
        '
        Me.TAB_CONTROL1.Controls.Add(Me.TabPage1)
        Me.TAB_CONTROL1.Controls.Add(Me.TabPage2)
        Me.TAB_CONTROL1.Controls.Add(Me.TabPage3)
        Me.TAB_CONTROL1.Location = New System.Drawing.Point(150, 13)
        Me.TAB_CONTROL1.Name = "TAB_CONTROL1"
        Me.TAB_CONTROL1.SelectedIndex = 0
        Me.TAB_CONTROL1.Size = New System.Drawing.Size(820, 626)
        Me.TAB_CONTROL1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.DATOS)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(812, 597)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "INSUMOS"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(6, 441)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(800, 150)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "OPCIONES"
        '
        'DATOS
        '
        Me.DATOS.Location = New System.Drawing.Point(6, 6)
        Me.DATOS.Name = "DATOS"
        Me.DATOS.Size = New System.Drawing.Size(800, 429)
        Me.DATOS.TabIndex = 0
        Me.DATOS.TabStop = False
        Me.DATOS.Text = "DATOS"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(812, 597)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "RECIBOS"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Location = New System.Drawing.Point(6, 441)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(800, 150)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "OPCIONES"
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(800, 429)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox3)
        Me.TabPage3.Controls.Add(Me.GroupBox5)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(812, 597)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "PAGOS ADICIONALES"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'OPCIONES
        '
        Me.OPCIONES.Controls.Add(Me.BTN_SALIR)
        Me.OPCIONES.Controls.Add(Me.BTN_NUEVO)
        Me.OPCIONES.Location = New System.Drawing.Point(12, 13)
        Me.OPCIONES.Name = "OPCIONES"
        Me.OPCIONES.Size = New System.Drawing.Size(116, 626)
        Me.OPCIONES.TabIndex = 3
        Me.OPCIONES.TabStop = False
        Me.OPCIONES.Text = "OPCIONES"
        '
        'BTN_SALIR
        '
        Me.BTN_SALIR.Location = New System.Drawing.Point(6, 505)
        Me.BTN_SALIR.Name = "BTN_SALIR"
        Me.BTN_SALIR.Size = New System.Drawing.Size(100, 111)
        Me.BTN_SALIR.TabIndex = 4
        Me.BTN_SALIR.Text = "CANCELAR"
        Me.BTN_SALIR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTN_SALIR.UseVisualStyleBackColor = True
        '
        'BTN_NUEVO
        '
        Me.BTN_NUEVO.Location = New System.Drawing.Point(6, 21)
        Me.BTN_NUEVO.Name = "BTN_NUEVO"
        Me.BTN_NUEVO.Size = New System.Drawing.Size(100, 115)
        Me.BTN_NUEVO.TabIndex = 0
        Me.BTN_NUEVO.Text = "ACEPTAR"
        Me.BTN_NUEVO.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTN_NUEVO.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Location = New System.Drawing.Point(6, 441)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(800, 150)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "OPCIONES"
        '
        'GroupBox5
        '
        Me.GroupBox5.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(800, 429)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "DATOS"
        '
        'FRM_INSERTAR_GASTOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 653)
        Me.Controls.Add(Me.TAB_CONTROL1)
        Me.Controls.Add(Me.OPCIONES)
        Me.Name = "FRM_INSERTAR_GASTOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INGRESAR GASTOS"
        Me.TAB_CONTROL1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.OPCIONES.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TAB_CONTROL1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Protected WithEvents GroupBox2 As GroupBox
    Protected WithEvents DATOS As GroupBox
    Friend WithEvents TabPage2 As TabPage
    Protected WithEvents GroupBox4 As GroupBox
    Protected WithEvents GroupBox1 As GroupBox
    Friend WithEvents TabPage3 As TabPage
    Protected WithEvents OPCIONES As GroupBox
    Protected WithEvents BTN_SALIR As Button
    Protected WithEvents BTN_NUEVO As Button
    Protected WithEvents GroupBox3 As GroupBox
    Protected WithEvents GroupBox5 As GroupBox
End Class
