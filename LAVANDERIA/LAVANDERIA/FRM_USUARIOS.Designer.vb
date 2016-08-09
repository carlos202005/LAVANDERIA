<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_USUARIOS
    Inherits LAVANDERIA.FRM_TEMPLATE_RECIBOS

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BUSCAR.SuspendLayout()
        Me.OPCIONES.SuspendLayout()
        Me.SuspendLayout()
        '
        'CLIENTES
        '
        Me.CLIENTES.Text = "USUARIOS"
        '
        'BTN_NUEVO
        '
        '
        'FRM_USUARIOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(982, 653)
        Me.Name = "FRM_USUARIOS"
        Me.Text = "USUARIOS"
        Me.BUSCAR.ResumeLayout(False)
        Me.BUSCAR.PerformLayout()
        Me.OPCIONES.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

End Class
