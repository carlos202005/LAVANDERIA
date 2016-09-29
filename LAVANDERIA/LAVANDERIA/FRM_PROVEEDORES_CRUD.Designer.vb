<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_PROVEEDORES_CRUD
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
        Me.TextBox20 = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TextBox23 = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TextBox24 = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TextBox25 = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TextBox26 = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TextBox27 = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.TextBox28 = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox20
        '
        Me.TextBox20.Location = New System.Drawing.Point(163, 250)
        Me.TextBox20.Multiline = True
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New System.Drawing.Size(443, 96)
        Me.TextBox20.TabIndex = 45
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(43, 253)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(82, 17)
        Me.Label20.TabIndex = 44
        Me.Label20.Text = "DIRECCIÓN"
        '
        'TextBox23
        '
        Me.TextBox23.Location = New System.Drawing.Point(163, 204)
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New System.Drawing.Size(443, 22)
        Me.TextBox23.TabIndex = 43
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(43, 207)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(68, 17)
        Me.Label23.TabIndex = 42
        Me.Label23.Text = "CORREO"
        '
        'TextBox24
        '
        Me.TextBox24.Location = New System.Drawing.Point(163, 159)
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New System.Drawing.Size(192, 22)
        Me.TextBox24.TabIndex = 41
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(43, 162)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(83, 17)
        Me.Label24.TabIndex = 40
        Me.Label24.Text = "TELEFONO"
        '
        'TextBox25
        '
        Me.TextBox25.Location = New System.Drawing.Point(452, 118)
        Me.TextBox25.MaxLength = 11
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New System.Drawing.Size(154, 22)
        Me.TextBox25.TabIndex = 39
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(375, 123)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(71, 17)
        Me.Label25.TabIndex = 38
        Me.Label25.Text = "CELULAR"
        '
        'TextBox26
        '
        Me.TextBox26.Location = New System.Drawing.Point(163, 118)
        Me.TextBox26.MaxLength = 11
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Size = New System.Drawing.Size(192, 22)
        Me.TextBox26.TabIndex = 37
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(43, 121)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(37, 17)
        Me.Label26.TabIndex = 36
        Me.Label26.Text = "RUC"
        '
        'TextBox27
        '
        Me.TextBox27.Location = New System.Drawing.Point(163, 77)
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Size = New System.Drawing.Size(443, 22)
        Me.TextBox27.TabIndex = 35
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(43, 80)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(110, 17)
        Me.Label27.TabIndex = 34
        Me.Label27.Text = "RAZON SOCIAL"
        '
        'TextBox28
        '
        Me.TextBox28.Location = New System.Drawing.Point(163, 38)
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Size = New System.Drawing.Size(131, 22)
        Me.TextBox28.TabIndex = 33
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(43, 41)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(63, 17)
        Me.Label28.TabIndex = 32
        Me.Label28.Text = "CÓDIGO"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(388, 363)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(111, 89)
        Me.Button2.TabIndex = 57
        Me.Button2.Text = "SALIR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(233, 363)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 89)
        Me.Button1.TabIndex = 56
        Me.Button1.Text = "ACEPTAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FRM_PROVEEDORES_CRUD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 488)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox20)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.TextBox23)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.TextBox24)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.TextBox25)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.TextBox26)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.TextBox27)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.TextBox28)
        Me.Controls.Add(Me.Label28)
        Me.Name = "FRM_PROVEEDORES_CRUD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PROVEEDORES"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox20 As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents TextBox23 As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents TextBox24 As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents TextBox25 As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents TextBox26 As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents TextBox27 As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents TextBox28 As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
