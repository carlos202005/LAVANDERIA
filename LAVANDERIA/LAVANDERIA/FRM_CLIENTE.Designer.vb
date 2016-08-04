<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_CLIENTE
    Inherits LAVANDERIA.FRM_CLIENTES_INICIO

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
        Me.OPCIONES.SuspendLayout()
        Me.BUSCAR.SuspendLayout()
        Me.SuspendLayout()
        '
        'BTN_VER
        '
        '
        'BTN_EDITAR
        '
        '
        'BTN_NUEVO
        '
        '
        'FRM_CLIENTE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(982, 653)
        Me.Name = "FRM_CLIENTE"
        Me.Text = "CLIENTES"
        Me.OPCIONES.ResumeLayout(False)
        Me.BUSCAR.ResumeLayout(False)
        Me.BUSCAR.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

End Class
