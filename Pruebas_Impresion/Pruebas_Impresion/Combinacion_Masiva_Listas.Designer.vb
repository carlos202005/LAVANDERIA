<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Combinacion_Masiva_Listas
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.CheckedListBox2 = New System.Windows.Forms.CheckedListBox()
        Me.CheckedListBox3 = New System.Windows.Forms.CheckedListBox()
        Me.CheckedListBox4 = New System.Windows.Forms.CheckedListBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(921, 260)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(260, 123)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "AGREGAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(21, 260)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(865, 276)
        Me.ListBox1.TabIndex = 1
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(21, 34)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(260, 208)
        Me.CheckedListBox1.TabIndex = 2
        '
        'CheckedListBox2
        '
        Me.CheckedListBox2.FormattingEnabled = True
        Me.CheckedListBox2.Location = New System.Drawing.Point(324, 34)
        Me.CheckedListBox2.Name = "CheckedListBox2"
        Me.CheckedListBox2.Size = New System.Drawing.Size(260, 208)
        Me.CheckedListBox2.TabIndex = 3
        '
        'CheckedListBox3
        '
        Me.CheckedListBox3.FormattingEnabled = True
        Me.CheckedListBox3.Location = New System.Drawing.Point(626, 34)
        Me.CheckedListBox3.Name = "CheckedListBox3"
        Me.CheckedListBox3.Size = New System.Drawing.Size(260, 208)
        Me.CheckedListBox3.TabIndex = 4
        '
        'CheckedListBox4
        '
        Me.CheckedListBox4.FormattingEnabled = True
        Me.CheckedListBox4.Location = New System.Drawing.Point(921, 34)
        Me.CheckedListBox4.Name = "CheckedListBox4"
        Me.CheckedListBox4.Size = New System.Drawing.Size(260, 208)
        Me.CheckedListBox4.TabIndex = 5
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(921, 413)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(260, 123)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "COMBINAR "
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(338, 554)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "CANTIDAD ELEMENTOS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(523, 554)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Label2"
        '
        'Combinacion_Masiva_Listas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1209, 593)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.CheckedListBox4)
        Me.Controls.Add(Me.CheckedListBox3)
        Me.Controls.Add(Me.CheckedListBox2)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Combinacion_Masiva_Listas"
        Me.Text = "Combinaciones"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents CheckedListBox2 As CheckedListBox
    Friend WithEvents CheckedListBox3 As CheckedListBox
    Friend WithEvents CheckedListBox4 As CheckedListBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
