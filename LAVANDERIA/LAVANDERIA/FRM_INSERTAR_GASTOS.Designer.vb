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
        Me.components = New System.ComponentModel.Container()
        Me.TAB_CONTROL1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BUSCAR = New System.Windows.Forms.GroupBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.BTN_BUSCAR = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.DATOS = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.OPCIONES = New System.Windows.Forms.GroupBox()
        Me.BTN_SALIR = New System.Windows.Forms.Button()
        Me.BTN_NUEVO = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TAB_CONTROL1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.BUSCAR.SuspendLayout()
        Me.DATOS.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabPage1.Controls.Add(Me.BUSCAR)
        Me.TabPage1.Controls.Add(Me.DATOS)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(812, 597)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "INSUMOS"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'BUSCAR
        '
        Me.BUSCAR.Controls.Add(Me.TextBox8)
        Me.BUSCAR.Controls.Add(Me.BTN_BUSCAR)
        Me.BUSCAR.Controls.Add(Me.ComboBox2)
        Me.BUSCAR.Location = New System.Drawing.Point(6, 505)
        Me.BUSCAR.Name = "BUSCAR"
        Me.BUSCAR.Size = New System.Drawing.Size(794, 86)
        Me.BUSCAR.TabIndex = 11
        Me.BUSCAR.TabStop = False
        Me.BUSCAR.Text = "BUSCAR"
        '
        'TextBox8
        '
        Me.TextBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(225, 42)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(439, 27)
        Me.TextBox8.TabIndex = 2
        '
        'BTN_BUSCAR
        '
        Me.BTN_BUSCAR.Location = New System.Drawing.Point(683, 38)
        Me.BTN_BUSCAR.Name = "BTN_BUSCAR"
        Me.BTN_BUSCAR.Size = New System.Drawing.Size(95, 36)
        Me.BTN_BUSCAR.TabIndex = 1
        Me.BTN_BUSCAR.Text = "BUSCAR"
        Me.ToolTip1.SetToolTip(Me.BTN_BUSCAR, "BUSCAR")
        Me.BTN_BUSCAR.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"NOMBRE", "APELLIDO", "SEXO", "COLOR", "DNI"})
        Me.ComboBox2.Location = New System.Drawing.Point(27, 42)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(162, 28)
        Me.ComboBox2.TabIndex = 0
        '
        'DATOS
        '
        Me.DATOS.Controls.Add(Me.DataGridView1)
        Me.DATOS.Controls.Add(Me.TextBox5)
        Me.DATOS.Controls.Add(Me.Label5)
        Me.DATOS.Controls.Add(Me.TextBox4)
        Me.DATOS.Controls.Add(Me.Label4)
        Me.DATOS.Controls.Add(Me.TextBox3)
        Me.DATOS.Controls.Add(Me.Label3)
        Me.DATOS.Controls.Add(Me.TextBox2)
        Me.DATOS.Controls.Add(Me.Label2)
        Me.DATOS.Controls.Add(Me.TextBox1)
        Me.DATOS.Controls.Add(Me.Label1)
        Me.DATOS.Location = New System.Drawing.Point(0, 3)
        Me.DATOS.Name = "DATOS"
        Me.DATOS.Size = New System.Drawing.Size(806, 496)
        Me.DATOS.TabIndex = 0
        Me.DATOS.TabStop = False
        Me.DATOS.Text = "DATOS"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 275)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(788, 212)
        Me.DataGridView1.TabIndex = 10
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(245, 242)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(407, 22)
        Me.TextBox5.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(130, 247)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "PRECIO"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(245, 198)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(407, 22)
        Me.TextBox4.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(130, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "CANTIDAD"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(245, 109)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(407, 73)
        Me.TextBox3.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(130, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "DESCRIPCIÓN"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(245, 66)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(407, 22)
        Me.TextBox2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(130, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "NOMBRE"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(245, 29)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(407, 22)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(130, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CÓDIGO"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(812, 597)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "RECIBOS"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 505)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(794, 86)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "BUSCAR"
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(225, 42)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(439, 27)
        Me.TextBox6.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(683, 38)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 36)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "BUSCAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"NOMBRE", "APELLIDO", "SEXO", "COLOR", "DNI"})
        Me.ComboBox1.Location = New System.Drawing.Point(27, 42)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(162, 28)
        Me.ComboBox1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.DataGridView2)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TextBox10)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TextBox11)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TextBox12)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(800, 493)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DATOS"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(254, 204)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(407, 22)
        Me.DateTimePicker2.TabIndex = 12
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(254, 160)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(407, 22)
        Me.DateTimePicker1.TabIndex = 11
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(6, 243)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(788, 244)
        Me.DataGridView2.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(130, 204)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "FECHA A PAGAR"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(130, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "DIAS PREVIOS"
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(254, 109)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(407, 22)
        Me.TextBox10.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(130, 114)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 17)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "MONTO"
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(254, 67)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(407, 22)
        Me.TextBox11.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(130, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 17)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "ENTIDAD"
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(254, 29)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(407, 22)
        Me.TextBox12.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(130, 34)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 17)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "CÓDIGO"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox3)
        Me.TabPage3.Controls.Add(Me.GroupBox4)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(812, 597)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "PAGOS ADICIONALES"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBox13)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.ComboBox3)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 505)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(794, 86)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "BUSCAR"
        '
        'TextBox13
        '
        Me.TextBox13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox13.Location = New System.Drawing.Point(225, 42)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(439, 27)
        Me.TextBox13.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(683, 38)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(95, 36)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "BUSCAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ComboBox3
        '
        Me.ComboBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"NOMBRE", "APELLIDO", "SEXO", "COLOR", "DNI"})
        Me.ComboBox3.Location = New System.Drawing.Point(27, 42)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(162, 28)
        Me.ComboBox3.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DataGridView3)
        Me.GroupBox4.Controls.Add(Me.TextBox15)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.TextBox16)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.TextBox17)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.TextBox18)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(800, 496)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "DATOS"
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(6, 243)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.RowTemplate.Height = 24
        Me.DataGridView3.Size = New System.Drawing.Size(788, 244)
        Me.DataGridView3.TabIndex = 10
        '
        'TextBox15
        '
        Me.TextBox15.Location = New System.Drawing.Point(239, 154)
        Me.TextBox15.Multiline = True
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(407, 75)
        Me.TextBox15.TabIndex = 7
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(124, 154)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 17)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "DESCRIPCIÓN"
        '
        'TextBox16
        '
        Me.TextBox16.Location = New System.Drawing.Point(239, 108)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(407, 22)
        Me.TextBox16.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(124, 113)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 17)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "MONTO"
        '
        'TextBox17
        '
        Me.TextBox17.Location = New System.Drawing.Point(239, 62)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(407, 22)
        Me.TextBox17.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(124, 67)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 17)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "ENTIDAD"
        '
        'TextBox18
        '
        Me.TextBox18.Location = New System.Drawing.Point(239, 19)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(407, 22)
        Me.TextBox18.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(124, 24)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(63, 17)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "CÓDIGO"
        '
        'OPCIONES
        '
        Me.OPCIONES.BackColor = System.Drawing.Color.Transparent
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
        Me.BTN_SALIR.FlatAppearance.BorderSize = 0
        Me.BTN_SALIR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BTN_SALIR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.BTN_SALIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_SALIR.Image = Global.LAVANDERIA.My.Resources.Resources._1470052726_delete_16
        Me.BTN_SALIR.Location = New System.Drawing.Point(6, 505)
        Me.BTN_SALIR.Name = "BTN_SALIR"
        Me.BTN_SALIR.Size = New System.Drawing.Size(100, 111)
        Me.BTN_SALIR.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.BTN_SALIR, "CANCELAR")
        Me.BTN_SALIR.UseVisualStyleBackColor = True
        '
        'BTN_NUEVO
        '
        Me.BTN_NUEVO.FlatAppearance.BorderSize = 0
        Me.BTN_NUEVO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BTN_NUEVO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.BTN_NUEVO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_NUEVO.Image = Global.LAVANDERIA.My.Resources.Resources._1470052718_tick_16
        Me.BTN_NUEVO.Location = New System.Drawing.Point(6, 21)
        Me.BTN_NUEVO.Name = "BTN_NUEVO"
        Me.BTN_NUEVO.Size = New System.Drawing.Size(100, 115)
        Me.BTN_NUEVO.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.BTN_NUEVO, "ACEPTAR")
        Me.BTN_NUEVO.UseVisualStyleBackColor = True
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
        Me.BUSCAR.ResumeLayout(False)
        Me.BUSCAR.PerformLayout()
        Me.DATOS.ResumeLayout(False)
        Me.DATOS.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OPCIONES.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TAB_CONTROL1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Protected WithEvents DATOS As GroupBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Protected WithEvents OPCIONES As GroupBox
    Protected WithEvents BTN_SALIR As Button
    Protected WithEvents BTN_NUEVO As Button
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Protected WithEvents BUSCAR As GroupBox
    Protected WithEvents TextBox8 As TextBox
    Protected WithEvents BTN_BUSCAR As Button
    Protected WithEvents ComboBox2 As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Protected WithEvents GroupBox1 As GroupBox
    Protected WithEvents TextBox6 As TextBox
    Protected WithEvents Button1 As Button
    Protected WithEvents ComboBox1 As ComboBox
    Protected WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents Label10 As Label
    Protected WithEvents GroupBox3 As GroupBox
    Protected WithEvents TextBox13 As TextBox
    Protected WithEvents Button2 As Button
    Protected WithEvents ComboBox3 As ComboBox
    Protected WithEvents GroupBox4 As GroupBox
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents TextBox15 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox16 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox17 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox18 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ToolTip1 As ToolTip
End Class
