Imports System.Data.SqlClient
Imports System.Collections.Specialized
Public Class Arrays_Base
    Dim ta As New SqlDataAdapter("Select cod_serv,precio2 from Servicio", "Data Source=.;Initial Catalog=LAVANDERIA;Integrated Security=True")
    Dim dt As New DataTable
    Private mDataTable As New DataTable

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        'ta.Fill(dt)

        'Dim sc1 As New StringCollection

        'Dim sc2 As New StringCollection

        'Dim i As Integer = 0

        'For Each dr As DataRow In dt.Rows

        '    sc1.Insert(i, dr("cod_serv"))

        '    sc2.Insert(i, dr("precio2"))

        '    i += 1
        'Next

        'If dt.Rows.Count <> 0 Then
        '    DataGridView1.DataSource = dt
        'Else
        '    DataGridView1.DataSource = Nothing
        'End If

        'Dim Array(DataGridView1.RowCount - 1) As String
        'Dim liFila As Integer = 0
        ''Desde DataTable
        'For Each drFila As DataRow In dt.Rows
        '    Array(liFila) = drFila("precio2").ToString()
        '    liFila += 1
        'Next

        'For liCiclo As Integer = 0 To Array.Length - 1
        '    TextBox1.Text = Array(liCiclo) & vbCrLf
        'Next

        Dim lista As New List(Of String)

        For Each row As DataGridViewRow In DataGridView1.Rows

            lista.Add(CStr(row.Cells(0).Value))

        Next

        Dim arrayValores() As String = lista.ToArray()

        Dim liCliclo As Integer = 0
        For liCiclo = 0 To arrayValores.Length - 1
            TextBox1.Text = arrayValores(liCiclo)
        Next
        TextBox1.Text = arrayValores(0) & vbCrLf
        TextBox1.Text = arrayValores(1) & vbCrLf
        TextBox1.Text = arrayValores(2) & vbNewLine
        TextBox1.Text = arrayValores(3) & vbNewLine
        TextBox1.Text = arrayValores(4) & vbNewLine
        TextBox1.Text = arrayValores(5) & vbCrLf
        TextBox1.Text = arrayValores(6) & vbCrLf




    End Sub

    Private Sub Arrays_Base_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ta.Fill(dt)
        For k = 0 To dt.Rows.Count - 1
            DataGridView1.DataSource = dt
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Dim Array(DataGridView1.RowCount - 1) As String
        'Dim liFila As Integer = 0
        ''Desde DataGridView
        'For Each loFila As DataGridViewRow In Me.DataGridView1.Rows
        '    Array(liFila) = loFila.Cells("cod_serv").Value.ToString()
        '    liFila += 1
        'Next
        'For liCiclo As Integer = 0 To Array.Length - 1
        '    TextBox1.Text = Array(liCiclo) & vbCrLf
        'Next
    End Sub
End Class