<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class INSERCION
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
        Me.TXT_NOMBRE = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_MONTO = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXT_FECHA = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(328, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID_RECIBOS"
        '
        'TXT_CODIGO
        '
        Me.TXT_CODIGO.Location = New System.Drawing.Point(418, 93)
        Me.TXT_CODIGO.Name = "TXT_CODIGO"
        Me.TXT_CODIGO.Size = New System.Drawing.Size(216, 22)
        Me.TXT_CODIGO.TabIndex = 1
        '
        'TXT_NOMBRE
        '
        Me.TXT_NOMBRE.Location = New System.Drawing.Point(418, 143)
        Me.TXT_NOMBRE.Name = "TXT_NOMBRE"
        Me.TXT_NOMBRE.Size = New System.Drawing.Size(216, 22)
        Me.TXT_NOMBRE.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(328, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "NOMBRE"
        '
        'TXT_MONTO
        '
        Me.TXT_MONTO.Location = New System.Drawing.Point(418, 192)
        Me.TXT_MONTO.Name = "TXT_MONTO"
        Me.TXT_MONTO.Size = New System.Drawing.Size(216, 22)
        Me.TXT_MONTO.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(328, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "MONTO"
        '
        'TXT_FECHA
        '
        Me.TXT_FECHA.Location = New System.Drawing.Point(418, 239)
        Me.TXT_FECHA.Name = "TXT_FECHA"
        Me.TXT_FECHA.Size = New System.Drawing.Size(216, 22)
        Me.TXT_FECHA.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(328, 242)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "FECHA"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(405, 322)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(216, 54)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "AGREGAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'INSERCION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 552)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TXT_FECHA)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TXT_MONTO)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TXT_NOMBRE)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXT_CODIGO)
        Me.Controls.Add(Me.Label1)
        Me.Name = "INSERCION"
        Me.Text = "INSERCION"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_CODIGO As TextBox
    Friend WithEvents TXT_NOMBRE As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TXT_MONTO As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TXT_FECHA As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
End Class
