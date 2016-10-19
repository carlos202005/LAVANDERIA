<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_PRINCIPAL
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GlobalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpresaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArchivosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecibosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AperturaDeCajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CierreDeCajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiciosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiciosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormasDePagoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.PromocionesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.SERVICIOS = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CLIENTES = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ENTREGA_SERVICIOS = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GlobalToolStripMenuItem, Me.ArchivosToolStripMenuItem, Me.ComprasToolStripMenuItem, Me.CajaToolStripMenuItem, Me.ServiciosToolStripMenuItem, Me.VentasToolStripMenuItem, Me.InformesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(732, 28)
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
        Me.ArchivosToolStripMenuItem.Size = New System.Drawing.Size(72, 24)
        Me.ArchivosToolStripMenuItem.Text = "General"
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
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'ComprasToolStripMenuItem
        '
        Me.ComprasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RecibosToolStripMenuItem})
        Me.ComprasToolStripMenuItem.Name = "ComprasToolStripMenuItem"
        Me.ComprasToolStripMenuItem.Size = New System.Drawing.Size(80, 24)
        Me.ComprasToolStripMenuItem.Text = "Compras"
        '
        'RecibosToolStripMenuItem
        '
        Me.RecibosToolStripMenuItem.Name = "RecibosToolStripMenuItem"
        Me.RecibosToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.RecibosToolStripMenuItem.Text = "Recibos"
        '
        'CajaToolStripMenuItem
        '
        Me.CajaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AperturaDeCajaToolStripMenuItem, Me.CierreDeCajaToolStripMenuItem})
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
        'ServiciosToolStripMenuItem
        '
        Me.ServiciosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ServiciosToolStripMenuItem1, Me.FormasDePagoToolStripMenuItem1, Me.ToolStripMenuItem2, Me.PromocionesToolStripMenuItem1})
        Me.ServiciosToolStripMenuItem.Name = "ServiciosToolStripMenuItem"
        Me.ServiciosToolStripMenuItem.Size = New System.Drawing.Size(79, 24)
        Me.ServiciosToolStripMenuItem.Text = "Servicios"
        '
        'ServiciosToolStripMenuItem1
        '
        Me.ServiciosToolStripMenuItem1.Name = "ServiciosToolStripMenuItem1"
        Me.ServiciosToolStripMenuItem1.Size = New System.Drawing.Size(191, 26)
        Me.ServiciosToolStripMenuItem1.Text = "Servicios"
        '
        'FormasDePagoToolStripMenuItem1
        '
        Me.FormasDePagoToolStripMenuItem1.Name = "FormasDePagoToolStripMenuItem1"
        Me.FormasDePagoToolStripMenuItem1.Size = New System.Drawing.Size(191, 26)
        Me.FormasDePagoToolStripMenuItem1.Text = "Formas de Pago"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(188, 6)
        '
        'PromocionesToolStripMenuItem1
        '
        Me.PromocionesToolStripMenuItem1.Name = "PromocionesToolStripMenuItem1"
        Me.PromocionesToolStripMenuItem1.Size = New System.Drawing.Size(191, 26)
        Me.PromocionesToolStripMenuItem1.Text = "Promociones"
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
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(50, 50)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SERVICIOS, Me.ToolStripSeparator1, Me.CLIENTES, Me.ToolStripButton3, Me.ENTREGA_SERVICIOS, Me.ToolStripSeparator2, Me.ToolStripButton5, Me.ToolStripButton6, Me.ToolStripButton7, Me.ToolStripSeparator3, Me.ToolStripButton8})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 28)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(732, 79)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'SERVICIOS
        '
        Me.SERVICIOS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SERVICIOS.Image = Global.LAVANDERIA.My.Resources.Resources._1470052756_buy_16
        Me.SERVICIOS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SERVICIOS.Name = "SERVICIOS"
        Me.SERVICIOS.Size = New System.Drawing.Size(54, 76)
        Me.SERVICIOS.Text = "SERVICIOS"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 79)
        '
        'CLIENTES
        '
        Me.CLIENTES.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CLIENTES.Image = Global.LAVANDERIA.My.Resources.Resources._1470052684_user
        Me.CLIENTES.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CLIENTES.Name = "CLIENTES"
        Me.CLIENTES.Size = New System.Drawing.Size(54, 76)
        Me.CLIENTES.Text = "CLIENTES"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = Global.LAVANDERIA.My.Resources.Resources._1470053677_document_pencil
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(54, 76)
        Me.ToolStripButton3.Text = "RECIBOS"
        '
        'ENTREGA_SERVICIOS
        '
        Me.ENTREGA_SERVICIOS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ENTREGA_SERVICIOS.Image = Global.LAVANDERIA.My.Resources.Resources._1470053401_delivery
        Me.ENTREGA_SERVICIOS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ENTREGA_SERVICIOS.Name = "ENTREGA_SERVICIOS"
        Me.ENTREGA_SERVICIOS.Size = New System.Drawing.Size(54, 76)
        Me.ENTREGA_SERVICIOS.Text = "ENTREGA DE SERVICIOS"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 79)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = Global.LAVANDERIA.My.Resources.Resources._1470052693_report
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(54, 76)
        Me.ToolStripButton5.Text = "FACTURAS"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = Global.LAVANDERIA.My.Resources.Resources._1470053414_shopping_bag
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(54, 76)
        Me.ToolStripButton6.Text = "INGRESO DE COMPRAS"
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton7.Image = Global.LAVANDERIA.My.Resources.Resources._1470053407_credit_cards
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(54, 76)
        Me.ToolStripButton7.Text = "COBRAR"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 79)
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton8.Image = Global.LAVANDERIA.My.Resources.Resources._1470052726_delete_16
        Me.ToolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.Size = New System.Drawing.Size(54, 76)
        Me.ToolStripButton8.Text = "SALIR"
        '
        'FRM_PRINCIPAL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(732, 503)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_PRINCIPAL"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LAVANDERIA"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GlobalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpresaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArchivosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RecibosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CajaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AperturaDeCajaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CierreDeCajaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ServiciosToolStripMenuItem As ToolStripMenuItem
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
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents SERVICIOS As ToolStripButton
    Friend WithEvents CLIENTES As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ENTREGA_SERVICIOS As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents ToolStripButton7 As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripButton8 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents FormasDePagoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents PromocionesToolStripMenuItem1 As ToolStripMenuItem
End Class
