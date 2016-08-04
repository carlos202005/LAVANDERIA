<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_PRINCIPAL
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GlobalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpresaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArchivosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsumosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecibosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PagosExtraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AperturaDeCajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CierreDeCajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArqueoDeCajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiciosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrendasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiciosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdenDePedidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntregaDePedidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PorClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PorEntradasEnCajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PorSalidasDeCajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PorCreditoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.InventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguracionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormasDePagoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PromocionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BTN_SALIR = New System.Windows.Forms.Button()
        Me.BTN_PAGOS_EXTRA = New System.Windows.Forms.Button()
        Me.BTN_INSUMOS = New System.Windows.Forms.Button()
        Me.BTN_FACTURA = New System.Windows.Forms.Button()
        Me.BTN_ENTREGA = New System.Windows.Forms.Button()
        Me.BTN_ORDEN = New System.Windows.Forms.Button()
        Me.BTN_VENTAS = New System.Windows.Forms.Button()
        Me.BNT_CLIENTES = New System.Windows.Forms.Button()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GlobalToolStripMenuItem, Me.ArchivosToolStripMenuItem, Me.ComprasToolStripMenuItem, Me.CajaToolStripMenuItem, Me.ServiciosToolStripMenuItem, Me.VentasToolStripMenuItem, Me.InformesToolStripMenuItem, Me.ConfiguracionToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(982, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GlobalToolStripMenuItem
        '
        Me.GlobalToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpresaToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.GlobalToolStripMenuItem.Name = "GlobalToolStripMenuItem"
        Me.GlobalToolStripMenuItem.Size = New System.Drawing.Size(65, 24)
        Me.GlobalToolStripMenuItem.Text = "Global"
        '
        'EmpresaToolStripMenuItem
        '
        Me.EmpresaToolStripMenuItem.Name = "EmpresaToolStripMenuItem"
        Me.EmpresaToolStripMenuItem.Size = New System.Drawing.Size(141, 26)
        Me.EmpresaToolStripMenuItem.Text = "Empresa"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(141, 26)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ArchivosToolStripMenuItem
        '
        Me.ArchivosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuariosToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.ProveedoresToolStripMenuItem})
        Me.ArchivosToolStripMenuItem.Name = "ArchivosToolStripMenuItem"
        Me.ArchivosToolStripMenuItem.Size = New System.Drawing.Size(77, 24)
        Me.ArchivosToolStripMenuItem.Text = "Archivos"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'ComprasToolStripMenuItem
        '
        Me.ComprasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InsumosToolStripMenuItem, Me.RecibosToolStripMenuItem, Me.PagosExtraToolStripMenuItem})
        Me.ComprasToolStripMenuItem.Name = "ComprasToolStripMenuItem"
        Me.ComprasToolStripMenuItem.Size = New System.Drawing.Size(80, 24)
        Me.ComprasToolStripMenuItem.Text = "Compras"
        '
        'InsumosToolStripMenuItem
        '
        Me.InsumosToolStripMenuItem.Name = "InsumosToolStripMenuItem"
        Me.InsumosToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.InsumosToolStripMenuItem.Text = "Insumos"
        '
        'RecibosToolStripMenuItem
        '
        Me.RecibosToolStripMenuItem.Name = "RecibosToolStripMenuItem"
        Me.RecibosToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.RecibosToolStripMenuItem.Text = "Recibos"
        '
        'PagosExtraToolStripMenuItem
        '
        Me.PagosExtraToolStripMenuItem.Name = "PagosExtraToolStripMenuItem"
        Me.PagosExtraToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.PagosExtraToolStripMenuItem.Text = "Pagos Extra"
        '
        'CajaToolStripMenuItem
        '
        Me.CajaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AperturaDeCajaToolStripMenuItem, Me.CierreDeCajaToolStripMenuItem, Me.ArqueoDeCajaToolStripMenuItem})
        Me.CajaToolStripMenuItem.Name = "CajaToolStripMenuItem"
        Me.CajaToolStripMenuItem.Size = New System.Drawing.Size(50, 24)
        Me.CajaToolStripMenuItem.Text = "Caja"
        '
        'AperturaDeCajaToolStripMenuItem
        '
        Me.AperturaDeCajaToolStripMenuItem.Name = "AperturaDeCajaToolStripMenuItem"
        Me.AperturaDeCajaToolStripMenuItem.Size = New System.Drawing.Size(196, 26)
        Me.AperturaDeCajaToolStripMenuItem.Text = "Apertura de Caja"
        '
        'CierreDeCajaToolStripMenuItem
        '
        Me.CierreDeCajaToolStripMenuItem.Name = "CierreDeCajaToolStripMenuItem"
        Me.CierreDeCajaToolStripMenuItem.Size = New System.Drawing.Size(196, 26)
        Me.CierreDeCajaToolStripMenuItem.Text = "Cierre de Caja"
        '
        'ArqueoDeCajaToolStripMenuItem
        '
        Me.ArqueoDeCajaToolStripMenuItem.Name = "ArqueoDeCajaToolStripMenuItem"
        Me.ArqueoDeCajaToolStripMenuItem.Size = New System.Drawing.Size(196, 26)
        Me.ArqueoDeCajaToolStripMenuItem.Text = "Arqueo de Caja"
        '
        'ServiciosToolStripMenuItem
        '
        Me.ServiciosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrendasToolStripMenuItem, Me.ServiciosToolStripMenuItem1})
        Me.ServiciosToolStripMenuItem.Name = "ServiciosToolStripMenuItem"
        Me.ServiciosToolStripMenuItem.Size = New System.Drawing.Size(79, 24)
        Me.ServiciosToolStripMenuItem.Text = "Servicios"
        '
        'PrendasToolStripMenuItem
        '
        Me.PrendasToolStripMenuItem.Name = "PrendasToolStripMenuItem"
        Me.PrendasToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.PrendasToolStripMenuItem.Text = "Prendas"
        '
        'ServiciosToolStripMenuItem1
        '
        Me.ServiciosToolStripMenuItem1.Name = "ServiciosToolStripMenuItem1"
        Me.ServiciosToolStripMenuItem1.Size = New System.Drawing.Size(181, 26)
        Me.ServiciosToolStripMenuItem1.Text = "Servicios"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VentaToolStripMenuItem, Me.OrdenDePedidoToolStripMenuItem, Me.EntregaDePedidoToolStripMenuItem})
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(65, 24)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'VentaToolStripMenuItem
        '
        Me.VentaToolStripMenuItem.Name = "VentaToolStripMenuItem"
        Me.VentaToolStripMenuItem.Size = New System.Drawing.Size(207, 26)
        Me.VentaToolStripMenuItem.Text = "Venta"
        '
        'OrdenDePedidoToolStripMenuItem
        '
        Me.OrdenDePedidoToolStripMenuItem.Name = "OrdenDePedidoToolStripMenuItem"
        Me.OrdenDePedidoToolStripMenuItem.Size = New System.Drawing.Size(207, 26)
        Me.OrdenDePedidoToolStripMenuItem.Text = "Orden de Pedido"
        '
        'EntregaDePedidoToolStripMenuItem
        '
        Me.EntregaDePedidoToolStripMenuItem.Name = "EntregaDePedidoToolStripMenuItem"
        Me.EntregaDePedidoToolStripMenuItem.Size = New System.Drawing.Size(207, 26)
        Me.EntregaDePedidoToolStripMenuItem.Text = "Entrega de Pedido"
        '
        'InformesToolStripMenuItem
        '
        Me.InformesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PorClienteToolStripMenuItem, Me.PorEntradasEnCajaToolStripMenuItem, Me.PorSalidasDeCajaToolStripMenuItem, Me.PorCreditoToolStripMenuItem, Me.ToolStripMenuItem1, Me.InventarioToolStripMenuItem})
        Me.InformesToolStripMenuItem.Name = "InformesToolStripMenuItem"
        Me.InformesToolStripMenuItem.Size = New System.Drawing.Size(79, 24)
        Me.InformesToolStripMenuItem.Text = "Informes"
        '
        'PorClienteToolStripMenuItem
        '
        Me.PorClienteToolStripMenuItem.Name = "PorClienteToolStripMenuItem"
        Me.PorClienteToolStripMenuItem.Size = New System.Drawing.Size(218, 26)
        Me.PorClienteToolStripMenuItem.Text = "Por cliente"
        '
        'PorEntradasEnCajaToolStripMenuItem
        '
        Me.PorEntradasEnCajaToolStripMenuItem.Name = "PorEntradasEnCajaToolStripMenuItem"
        Me.PorEntradasEnCajaToolStripMenuItem.Size = New System.Drawing.Size(218, 26)
        Me.PorEntradasEnCajaToolStripMenuItem.Text = "Por entradas en caja"
        '
        'PorSalidasDeCajaToolStripMenuItem
        '
        Me.PorSalidasDeCajaToolStripMenuItem.Name = "PorSalidasDeCajaToolStripMenuItem"
        Me.PorSalidasDeCajaToolStripMenuItem.Size = New System.Drawing.Size(218, 26)
        Me.PorSalidasDeCajaToolStripMenuItem.Text = "Por salidas de caja"
        '
        'PorCreditoToolStripMenuItem
        '
        Me.PorCreditoToolStripMenuItem.Name = "PorCreditoToolStripMenuItem"
        Me.PorCreditoToolStripMenuItem.Size = New System.Drawing.Size(218, 26)
        Me.PorCreditoToolStripMenuItem.Text = "Por credito"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(215, 6)
        '
        'InventarioToolStripMenuItem
        '
        Me.InventarioToolStripMenuItem.Name = "InventarioToolStripMenuItem"
        Me.InventarioToolStripMenuItem.Size = New System.Drawing.Size(218, 26)
        Me.InventarioToolStripMenuItem.Text = "Inventario"
        '
        'ConfiguracionToolStripMenuItem
        '
        Me.ConfiguracionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormasDePagoToolStripMenuItem, Me.PromocionesToolStripMenuItem})
        Me.ConfiguracionToolStripMenuItem.Name = "ConfiguracionToolStripMenuItem"
        Me.ConfiguracionToolStripMenuItem.Size = New System.Drawing.Size(114, 24)
        Me.ConfiguracionToolStripMenuItem.Text = "Configuracion"
        '
        'FormasDePagoToolStripMenuItem
        '
        Me.FormasDePagoToolStripMenuItem.Name = "FormasDePagoToolStripMenuItem"
        Me.FormasDePagoToolStripMenuItem.Size = New System.Drawing.Size(192, 26)
        Me.FormasDePagoToolStripMenuItem.Text = "Formas de pago"
        '
        'PromocionesToolStripMenuItem
        '
        Me.PromocionesToolStripMenuItem.Name = "PromocionesToolStripMenuItem"
        Me.PromocionesToolStripMenuItem.Size = New System.Drawing.Size(192, 26)
        Me.PromocionesToolStripMenuItem.Text = "Promociones"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(63, 24)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(150, 26)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BTN_SALIR)
        Me.Panel1.Controls.Add(Me.BTN_PAGOS_EXTRA)
        Me.Panel1.Controls.Add(Me.BTN_INSUMOS)
        Me.Panel1.Controls.Add(Me.BTN_FACTURA)
        Me.Panel1.Controls.Add(Me.BTN_ENTREGA)
        Me.Panel1.Controls.Add(Me.BTN_ORDEN)
        Me.Panel1.Controls.Add(Me.BTN_VENTAS)
        Me.Panel1.Controls.Add(Me.BNT_CLIENTES)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(982, 135)
        Me.Panel1.TabIndex = 1
        '
        'BTN_SALIR
        '
        Me.BTN_SALIR.Location = New System.Drawing.Point(839, 3)
        Me.BTN_SALIR.Name = "BTN_SALIR"
        Me.BTN_SALIR.Size = New System.Drawing.Size(100, 120)
        Me.BTN_SALIR.TabIndex = 7
        Me.BTN_SALIR.Text = "SALIR"
        Me.BTN_SALIR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTN_SALIR.UseVisualStyleBackColor = True
        '
        'BTN_PAGOS_EXTRA
        '
        Me.BTN_PAGOS_EXTRA.Location = New System.Drawing.Point(691, 3)
        Me.BTN_PAGOS_EXTRA.Name = "BTN_PAGOS_EXTRA"
        Me.BTN_PAGOS_EXTRA.Size = New System.Drawing.Size(100, 120)
        Me.BTN_PAGOS_EXTRA.TabIndex = 6
        Me.BTN_PAGOS_EXTRA.Text = "PAGOS "
        Me.BTN_PAGOS_EXTRA.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTN_PAGOS_EXTRA.UseVisualStyleBackColor = True
        '
        'BTN_INSUMOS
        '
        Me.BTN_INSUMOS.Location = New System.Drawing.Point(585, 3)
        Me.BTN_INSUMOS.Name = "BTN_INSUMOS"
        Me.BTN_INSUMOS.Size = New System.Drawing.Size(100, 120)
        Me.BTN_INSUMOS.TabIndex = 5
        Me.BTN_INSUMOS.Text = "INSUMOS"
        Me.BTN_INSUMOS.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTN_INSUMOS.UseVisualStyleBackColor = True
        '
        'BTN_FACTURA
        '
        Me.BTN_FACTURA.Location = New System.Drawing.Point(479, 3)
        Me.BTN_FACTURA.Name = "BTN_FACTURA"
        Me.BTN_FACTURA.Size = New System.Drawing.Size(100, 120)
        Me.BTN_FACTURA.TabIndex = 4
        Me.BTN_FACTURA.Text = "FACTURA"
        Me.BTN_FACTURA.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTN_FACTURA.UseVisualStyleBackColor = True
        '
        'BTN_ENTREGA
        '
        Me.BTN_ENTREGA.Location = New System.Drawing.Point(348, 3)
        Me.BTN_ENTREGA.Name = "BTN_ENTREGA"
        Me.BTN_ENTREGA.Size = New System.Drawing.Size(100, 120)
        Me.BTN_ENTREGA.TabIndex = 3
        Me.BTN_ENTREGA.Text = "ENTREGA"
        Me.BTN_ENTREGA.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTN_ENTREGA.UseVisualStyleBackColor = True
        '
        'BTN_ORDEN
        '
        Me.BTN_ORDEN.Location = New System.Drawing.Point(242, 3)
        Me.BTN_ORDEN.Name = "BTN_ORDEN"
        Me.BTN_ORDEN.Size = New System.Drawing.Size(100, 120)
        Me.BTN_ORDEN.TabIndex = 2
        Me.BTN_ORDEN.Text = "ORDEN"
        Me.BTN_ORDEN.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTN_ORDEN.UseVisualStyleBackColor = True
        '
        'BTN_VENTAS
        '
        Me.BTN_VENTAS.Location = New System.Drawing.Point(136, 3)
        Me.BTN_VENTAS.Name = "BTN_VENTAS"
        Me.BTN_VENTAS.Size = New System.Drawing.Size(100, 120)
        Me.BTN_VENTAS.TabIndex = 1
        Me.BTN_VENTAS.Text = "VENTAS"
        Me.BTN_VENTAS.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTN_VENTAS.UseVisualStyleBackColor = True
        '
        'BNT_CLIENTES
        '
        Me.BNT_CLIENTES.Location = New System.Drawing.Point(3, 3)
        Me.BNT_CLIENTES.Name = "BNT_CLIENTES"
        Me.BNT_CLIENTES.Size = New System.Drawing.Size(100, 120)
        Me.BNT_CLIENTES.TabIndex = 0
        Me.BNT_CLIENTES.Text = "CLIENTES"
        Me.BNT_CLIENTES.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BNT_CLIENTES.UseVisualStyleBackColor = True
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'FRM_PRINCIPAL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(982, 853)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FRM_PRINCIPAL"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LAVANDERIA"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GlobalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpresaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArchivosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InsumosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RecibosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PagosExtraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CajaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AperturaDeCajaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CierreDeCajaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArqueoDeCajaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ServiciosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrendasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ServiciosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrdenDePedidoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EntregaDePedidoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PorClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PorEntradasEnCajaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PorSalidasDeCajaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PorCreditoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents InventarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfiguracionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormasDePagoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PromocionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BTN_SALIR As Button
    Friend WithEvents BTN_PAGOS_EXTRA As Button
    Friend WithEvents BTN_INSUMOS As Button
    Friend WithEvents BTN_FACTURA As Button
    Friend WithEvents BTN_ENTREGA As Button
    Friend WithEvents BTN_ORDEN As Button
    Friend WithEvents BTN_VENTAS As Button
    Friend WithEvents BNT_CLIENTES As Button
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
End Class
