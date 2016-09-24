<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VISTAS
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.LAVANDERIADataSet = New Pruebas_Impresion.LAVANDERIADataSet()
        Me.ServicioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ServicioTableAdapter = New Pruebas_Impresion.LAVANDERIADataSetTableAdapters.ServicioTableAdapter()
        CType(Me.LAVANDERIADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServicioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ServicioBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Pruebas_Impresion.CLIENTES.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(998, 513)
        Me.ReportViewer1.TabIndex = 0
        '
        'LAVANDERIADataSet
        '
        Me.LAVANDERIADataSet.DataSetName = "LAVANDERIADataSet"
        Me.LAVANDERIADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ServicioBindingSource
        '
        Me.ServicioBindingSource.DataMember = "Servicio"
        Me.ServicioBindingSource.DataSource = Me.LAVANDERIADataSet
        '
        'ServicioTableAdapter
        '
        Me.ServicioTableAdapter.ClearBeforeFill = True
        '
        'VISTAS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1022, 537)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "VISTAS"
        Me.Text = "VISTAS"
        CType(Me.LAVANDERIADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServicioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ServicioBindingSource As BindingSource
    Friend WithEvents LAVANDERIADataSet As LAVANDERIADataSet
    Friend WithEvents ServicioTableAdapter As LAVANDERIADataSetTableAdapters.ServicioTableAdapter
End Class
