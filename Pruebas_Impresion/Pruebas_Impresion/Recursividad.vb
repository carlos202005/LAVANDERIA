
Imports System.Data.SqlClient
Public Class Recursividad
    Dim frm As New Cargar_Login

    Friend WithEvents _ComboBox As ComboBox
    Friend WithEvents _CheckListBox As CheckedListBox
    Friend WithEvents _NumericUpDown As New NumericUpDown
    Friend WithEvents _Label1, _Label2, _Label_Cod As Label
    Friend WithEvents _Panel As Panel
    Dim Dt As DataTable
    Dim Cn As New SqlConnection(Variables_Globales.Base_Conexion)
    Dim Da As New SqlDataAdapter
    Dim Cmd As New SqlCommand
    Dim contador As Integer = 0
    Dim limite, control As Integer

    Private Sub Recursividad_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        limite = NumericUpDown1.Value
        control = Integer.Parse(limite \ 5)
        Dim Nombre_Combinado As New List(Of String)
        Dim codigo As New List(Of Integer)

        For i = 0 To limite - 1
            If Me.Controls.Find("CheckListBox_" & i + 1, True).Count = 1 Then
                Dim check As CheckedListBox = Me.Controls.Find("CheckListBox_" & i + 1, True)(0)
                Dim numero As Integer = check.CheckedItems.Count
                For Each item As DataRowView In check.CheckedItems
                    If numero > 1 Then
                        'ListBox1.Items.Add(item(check.DisplayMember).ToString())
                        codigo.Add(item(check.ValueMember).ToString())
                        Nombre_Combinado.Add(item(check.DisplayMember).ToString())
                    End If
                Next item
            End If
        Next

        Dim Exceso As Integer = codigo.Count - 1
        Dim cadena As String = ""
        For i = 0 To limite - 1
            For j = 0 To Exceso
                cadena = cadena & " " & Nombre_Combinado(i) & " " & Nombre_Combinado(j)
            Next
            ListBox1.Items.Add(cadena)
        Next

        For i = 0 To codigo.Count - 1
            ListBox1.Items.Add(codigo(i) & ", " & Nombre_Combinado(i))
        Next

    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles Button1.Click

        limite = NumericUpDown1.Value
        control = Integer.Parse(limite \ 5)

        For i As Integer = 0 To control
            For j As Integer = 0 To 4
                If contador < limite Then
                    _ComboBox = New ComboBox
                    _CheckListBox = New CheckedListBox
                    _NumericUpDown = New NumericUpDown
                    _Label1 = New Label
                    _Label2 = New Label
                    _Label_Cod = New Label
                    _Panel = New Panel


                    With _Panel
                        .Width = 250
                        .Height = 280
                        .BorderStyle = BorderStyle.FixedSingle
                        .BackColor = Color.AliceBlue
                        .Name = "Panel_" & contador + 1
                        .Top = 10
                        .Left = 10
                        .Location = New Point((.Height) * (j), (.Width + 50) * (i))
                    End With


                    With _Label1
                        .Width = 30
                        .Height = 20
                        .Visible = True
                        .Text = "Tipo"
                        .Top = 10
                        .ForeColor = Color.Black
                        .Location = New Point(10, 10)
                    End With

                    With Cmd
                        .CommandType = CommandType.Text
                        .CommandText = "Select * From prendas"
                        .Connection = Cn
                    End With

                    Da.SelectCommand = Cmd
                    Dt = New DataTable
                    Da.Fill(Dt)


                    With _ComboBox
                        .Width = 90
                        .Height = 20
                        .Name = "ComboBox_" & contador + 1
                        .Visible = True
                        .DropDownStyle = ComboBoxStyle.DropDownList
                        .Top = 10
                        .ForeColor = Color.Black
                        .Location = New Point(10 * 4, 10)
                        .DataSource = Dt
                        .DisplayMember = "Descripcion"
                        .ValueMember = "Tipo_Producto"
                    End With


                    With _Label2
                        .Width = 30
                        .Height = 20
                        .Visible = True
                        .Text = "Cantidad"
                        .Top = 10
                        .ForeColor = Color.Black
                        .Location = New Point(10 * 14, 10)
                    End With

                    With _NumericUpDown
                        .Width = 30
                        .Height = 30
                        .Visible = True
                        .Name = "NumericUpDown_" & contador + 1
                        .Top = 10
                        .ForeColor = Color.Black
                        .Minimum = 1
                        .Location = New Point(10 * (17), 10)
                    End With

                    With _CheckListBox
                        .Width = 210
                        .Height = 150
                        .Visible = True
                        .Name = "CheckListBox_" & contador + 1
                        .Left = 10
                        .Top = 10
                        .BackColor = Color.White
                        .Location = New Point(10, 20 + ((.Left + 10)))
                    End With

                    Me.Controls.Add(_Panel)
                    _Panel.Controls.Add(_Label1)
                    _Panel.Controls.Add(_ComboBox)
                    _Panel.Controls.Add(_Label2)
                    _Panel.Controls.Add(_NumericUpDown)
                    _Panel.Controls.Add(_CheckListBox)
                    'MsgBox(_Panel.Name & " ," & _CheckListBox.Name & " ," & _ComboBox.Name)
                    AddHandler _ComboBox.SelectedIndexChanged, AddressOf ComboBox_SelectedIndexChanged
                    contador += 1
                Else
                    Exit For
                End If
            Next

        Next

    End Sub
    Private Sub ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles _ComboBox.SelectedIndexChanged
        Dim nombre As String
        Dim lab_codigo As New Label
        limite = NumericUpDown1.Value
        lab_codigo.Text = DirectCast(CType(sender, ComboBox).SelectedItem, DataRowView).Item("Tipo_Producto")
        nombre = DirectCast(CType(sender, ComboBox).SelectedItem, DataRowView).Item("Descripcion")

        For i = 0 To limite - 1
            If CType(sender, ComboBox).Name = "ComboBox_" & i + 1 Then
                If Me.Controls.Find("CheckListBox_" & i + 1, True).Count = 1 Then
                    Dim check As CheckedListBox = Me.Controls.Find("CheckListBox_" & i + 1, True)(0)
                    frm.cargar_CheckListBox_Dinamico(check, lab_codigo)
                End If
            End If

        Next
    End Sub

End Class