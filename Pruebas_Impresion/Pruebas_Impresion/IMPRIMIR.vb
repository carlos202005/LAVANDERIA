
Imports System.Drawing.Printing
Public Class IMPRIMIR

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PrintDocument1.Print()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim fontTitulo As New Font("Arial", 12, FontStyle.Bold)
        Dim fontEncabezado As New Font("Arial", 7, FontStyle.Regular)
        Dim fontCuerpo As New Font("Arial", 7, FontStyle.Regular)
        Dim fontTituloColumna As New Font("Arial", 7, FontStyle.Bold)
        Dim fontPiePagina As New Font("Arial", 5, FontStyle.Bold)

        Dim FormatoCentro As New StringFormat
        FormatoCentro.Alignment = StringAlignment.Center
        FormatoCentro.LineAlignment = StringAlignment.Center
        Dim FormatoIzquierda As New StringFormat()
        FormatoIzquierda.Alignment = StringAlignment.Near
        FormatoIzquierda.LineAlignment = StringAlignment.Center
        Dim FormatoDerecha As New StringFormat()
        FormatoDerecha.Alignment = StringAlignment.Far
        FormatoDerecha.LineAlignment = StringAlignment.Center

        Dim Parrafo As Rectangle

        Dim Imagen As Image = Image.FromFile("C:\cabana.png")
        e.Graphics.DrawImage(Imagen, 0, 5)
        Parrafo = New Rectangle(75, 5, 205, 25)
        e.Graphics.DrawString("LA CABAÑA", fontTitulo, Brushes.Black, Parrafo, FormatoCentro)
        Parrafo = New Rectangle(75, 30, 205, 12)
        e.Graphics.DrawString("Disco T - K", fontEncabezado, Brushes.Black, Parrafo, FormatoCentro)
        Parrafo = New Rectangle(75, 40, 205, 12)
        e.Graphics.DrawString("Av. Alameda Perú Cuadra 6", fontEncabezado, Brushes.Black, Parrafo, FormatoCentro)
        Parrafo = New Rectangle(75, 50, 205, 12)
        e.Graphics.DrawString("Tingo María - Perú", fontEncabezado, Brushes.Black, Parrafo, FormatoCentro)
        Parrafo = New Rectangle(75, 60, 205, 12)
        e.Graphics.DrawString("Tel: 8173512635    Cel: 1273637123", fontEncabezado, Brushes.Black, Parrafo, FormatoCentro)
        Parrafo = New Rectangle(75, 70, 205, 12)
        e.Graphics.DrawString("Fecha y Hora :" + DateTime.Now.ToString(), fontEncabezado, Brushes.Black, Parrafo, FormatoCentro)
        Parrafo = New Rectangle(75, 80, 205, 12)
        e.Graphics.DrawString("BOLETA ELECTRÓNICA", fontCuerpo, Brushes.Black, Parrafo, FormatoCentro)
        Parrafo = New Rectangle(75, 90, 205, 12)
        e.Graphics.DrawString("Serie: 0001111     Numero: 0000001  ", fontCuerpo, Brushes.Black, Parrafo, FormatoCentro)
        Parrafo = New Rectangle(0, 110, 205, 12)
        e.Graphics.DrawString("Cliente: DASDASD DNI: 215151515 ", fontCuerpo, Brushes.Black, Parrafo, FormatoIzquierda)

        Parrafo = New Rectangle(0, 125, 40, 12)
        e.Graphics.DrawString("COD.", fontTituloColumna, Brushes.Black, Parrafo, FormatoCentro)
        Parrafo = New Rectangle(45, 125, 100, 12)
        e.Graphics.DrawString("PRODUCTO", fontTituloColumna, Brushes.Black, Parrafo, FormatoIzquierda)
        Parrafo = New Rectangle(120, 125, 50, 12)
        e.Graphics.DrawString("CANT.", fontTituloColumna, Brushes.Black, Parrafo, FormatoDerecha)
        Parrafo = New Rectangle(170, 125, 50, 12)
        e.Graphics.DrawString("PREC.", fontTituloColumna, Brushes.Black, Parrafo, FormatoDerecha)
        Parrafo = New Rectangle(220, 125, 60, 12)
        e.Graphics.DrawString("COSTO", fontTituloColumna, Brushes.Black, Parrafo, FormatoDerecha)

        Dim Linea As Integer = 135

        Dim CantLinea As Integer = 0
        For n As Integer = 0 To DataGridView1.RowCount - 1
            Parrafo = New Rectangle(0, Linea + (n * 10), 40, 12)
            e.Graphics.DrawString(Convert.ToString(DataGridView1.Item(0, n).Value), fontCuerpo, Brushes.Black, Parrafo, FormatoCentro)
            Parrafo = New Rectangle(45, Linea + (n * 10), 100, 12)
            e.Graphics.DrawString(Convert.ToString(DataGridView1.Item(1, n).Value), fontCuerpo, Brushes.Black, Parrafo, FormatoIzquierda)
            Parrafo = New Rectangle(120, Linea + (n * 10), 50, 12)
            e.Graphics.DrawString(Convert.ToString(DataGridView1.Item(2, n).Value), fontCuerpo, Brushes.Black, Parrafo, FormatoDerecha)
            Parrafo = New Rectangle(170, Linea + (n * 10), 50, 12)
            e.Graphics.DrawString(Convert.ToString(DataGridView1.Item(3, n).Value), fontCuerpo, Brushes.Black, Parrafo, FormatoDerecha)
            Parrafo = New Rectangle(220, Linea + (n * 10), 60, 12)
            e.Graphics.DrawString(FormatNumber(DataGridView1.Item(3, n).Value), fontCuerpo, Brushes.Black, Parrafo, FormatoDerecha)
            CantLinea = (n * 10)
        Next
        Linea += CantLinea + 10
        Parrafo = New Rectangle(220, Linea, 50, 12)
        e.Graphics.DrawString("---------------", fontCuerpo, Brushes.Black, Parrafo, FormatoDerecha)
        Linea += 10
        Parrafo = New Rectangle(45, Linea, 100, 12)
        e.Graphics.DrawString("SUBTOTAL", fontTituloColumna, Brushes.Black, Parrafo, FormatoIzquierda)
        Parrafo = New Rectangle(220, Linea, 60, 12)

        'Aqui se MUESTRA el precio TOTAL DE LA COMPRA
        e.Graphics.DrawString(100, fontCuerpo, Brushes.Black, Parrafo, FormatoDerecha)
        Linea += 15
        Parrafo = New Rectangle(45, Linea, 100, 12)
        e.Graphics.DrawString("DESCUENTO", fontTituloColumna, Brushes.Black, Parrafo, FormatoIzquierda)
        Parrafo = New Rectangle(220, Linea, 60, 12)

        'Aqui se MUESTRA el precio TOTAL EN EFECTIVO
        e.Graphics.DrawString(0, fontCuerpo, Brushes.Black, Parrafo, FormatoDerecha)
        Linea += 15
        Parrafo = New Rectangle(45, Linea, 100, 12)
        e.Graphics.DrawString("TOTAL", fontTituloColumna, Brushes.Black, Parrafo, FormatoIzquierda)
        Parrafo = New Rectangle(220, Linea, 60, 12)

        'Aqui se MUESTRA el precio TOTAL DEL VUELTO
        e.Graphics.DrawString((0).ToString(“##,##0.00”), fontCuerpo, Brushes.Black, Parrafo, FormatoDerecha)

        Linea += 25
        Parrafo = New Rectangle(0, Linea, 280, 50)
        e.Graphics.DrawString("BIENES TRANSFERIDOS A LA AMAZONÍA REGIÓN SELVA PARA SER CONSUMIDOS A LA MISMA", fontEncabezado, Brushes.Black, Parrafo, FormatoCentro)
        Linea += 35
        Parrafo = New Rectangle(0, Linea, 280, 50)
        e.Graphics.DrawString("REPRESENTACIÓN IMPRESA DE BOLETA ELECTRÓNICA, CONSULTE EN : www.oliver.com/info", fontEncabezado, Brushes.Black, Parrafo, FormatoCentro)
        e.HasMorePages = False
        Linea += 30
        Parrafo = New Rectangle(0, Linea, 280, 50)
        e.Graphics.DrawString("AUTORIZADO MEDIANTE RESOLUCIÓN : XXXXN XXXXXXXXXXXXX", fontEncabezado, Brushes.Black, Parrafo, FormatoCentro)
        e.HasMorePages = False
        Linea += 30
        Parrafo = New Rectangle(0, Linea, 280, 50)
        e.Graphics.DrawString("---GRACIAS PO SU COMPRA, VUELVA PRONTO---", fontEncabezado, Brushes.Black, Parrafo, FormatoCentro)
        e.HasMorePages = False
        Linea += 10
        Parrafo = New Rectangle(0, Linea, 280, 50)
        e.Graphics.DrawString("CAJA : OLIVER   EMPLEADO : MARTEL VICENTE", fontPiePagina, Brushes.Black, Parrafo, FormatoCentro)
        e.HasMorePages = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        DataGridView1.Rows.Add(TextBox4.Text, TextBox1.Text, TextBox2.Text, TextBox3.Text)
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        Dim Total As Integer = 0
        For Each row As DataGridViewRow In Me.DataGridView1.Rows
            Total += Val(row.Cells(2).Value) * Val(row.Cells(3).Value)
        Next
        LBL_TOTAL.Text = "$$" & Total.ToString(“##,##0.00”)
        TextBox1.Select()

        'For fila As Integer = 0 To DataGridView1.RowCount - 1
        '    For Columnas As Integer = 0 To DataGridView1.ColumnCount - 1
        '        MsgBox(Me.DataGridView1.Item(Columnas, fila).Value)
        '    Next
        'Next
    End Sub
End Class