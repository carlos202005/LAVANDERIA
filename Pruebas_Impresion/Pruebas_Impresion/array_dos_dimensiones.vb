Imports System.Runtime.CompilerServices
Imports System.Threading
Public Class array_dos_dimensiones
    Dim frm As New Cargar_Login
    Private Sub array_dos_dimensiones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
        frm.cargar(CheckListBox_1)
        frm.cargar(CheckListBox_2)
        frm.cargar(CheckListBox_3)
        frm.cargar(CheckListBox_4)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim ron_cont As Integer
        Dim vodka_cont As Integer
        Dim tequila_cont As Integer
        Dim winkye_cont As Integer
        ron_cont = CheckListBox_1.CheckedItems.Count
        vodka_cont = CheckListBox_2.CheckedItems.Count
        tequila_cont = CheckListBox_3.CheckedItems.Count
        winkye_cont = CheckListBox_4.CheckedItems.Count

        Dim nombre_ron As New List(Of String)
        Dim nombre_vodka As New List(Of String)
        Dim nombre_tequila As New List(Of String)
        Dim nombre_winkye As New List(Of String)

        If ron_cont > 1 Then
            For i = 0 To CheckListBox_1.CheckedItems.Count - 1
                nombre_ron.Add(CheckListBox_1.CheckedItems(i).ToString)
            Next
        End If

        If vodka_cont > 1 Then
            For i = 0 To CheckListBox_2.CheckedItems.Count - 1
                nombre_vodka.Add(CheckListBox_2.CheckedItems(i).ToString)
            Next
        End If
        If tequila_cont > 1 Then
            For i = 0 To CheckListBox_3.CheckedItems.Count - 1
                nombre_tequila.Add(CheckListBox_3.CheckedItems(i).ToString)
            Next
        End If

        If winkye_cont > 1 Then
            For i = 0 To CheckListBox_4.CheckedItems.Count - 1
                nombre_winkye.Add(CheckListBox_4.CheckedItems(i).ToString)
            Next
        End If

        Dim contador As Integer = 0
        Dim Nombre_Combinado(50, 100) As String
        For i = 0 To 3

            If Me.Controls.Find("CheckListBox_" & i + 1, True).Count = 1 Then
                Dim check As CheckedListBox = Me.Controls.Find("CheckListBox_" & i + 1, True)(0)
                Dim cantidad As Integer = check.CheckedItems.Count
                For Each item As DataRowView In check.CheckedItems
                    If cantidad > 1 Then
                        'ListBox1.Items.Add(item(check.DisplayMember).ToString())
                        'codigo.Add(item(check.ValueMember).ToString())
                        Nombre_Combinado(i + 1, contador + 1) = item(check.DisplayMember).ToString()
                    End If
                Next item
            End If
            contador = 0
        Next

        NOMBRES_COMBINADOS.Items.Add(For_Masivo(36))
        'For i = 0 To 3
        '    For j = 0 To 10
        '        If Nombre_Combinado(i + 1, j + 1) <> " " Then
        '            NOMBRES_COMBINADOS.Items.Add(Nombre_Combinado(i, j) & " " & Nombre_Combinado(i + 2, j + 1))
        '        End If
        '    Next
        'Next

        '################# IMPRIME CUANDO LOS CUATRO CASILLEROS ESTÁN COMPLETOS O TIENE  MÁS DE 2 ELMENTOS SELECCIONADOS ##############
        'If ron_cont > 1 And tequila_cont > 1 And winkye_cont > 1 And vodka_cont > 1 Then
        '    For i = 0 To ron_cont - 1
        '        For k = 0 To vodka_cont - 1
        '            For j = 0 To tequila_cont - 1
        '                For z = 0 To winkye_cont - 1
        '                    NOMBRES_COMBINADOS.Items.Add(ComboBox1.Text & " " & nombre_ron(i) & "  " & nombre_vodka(k) & " " & nombre_tequila(j) & " " & nombre_winkye(z))
        '                     
        '                Next
        '            Next
        '        Next
        '    Next
        'End If

        '#######################    ESTE CÓDIGO SIRVE PARA SACAR EL ID DE CADA ELEMENTO SELECCIONADO ######################
        'For Each item As DataRowView In CheckedListBox1.CheckedItems
        '    ListBox1.Items.Add(item(CheckedListBox1.ValueMember).ToString())
        'Next item

        '#######################   OTRA FORMA PARA SACAR EL INDEX DE CADA ELEMENTO SELECCIONADO ######################
        'For i = 0 To RON.Items.Count - 1
        '    If (RON.GetItemChecked(i)) Then
        '        MessageBox.Show(RON.GetItemText(i))
        '    End If
        'Next

        'Label9.Text = NOMBRES_COMBINADOS.Items.Count

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        NOMBRES_COMBINADOS.Items.Clear()
        For i = 0 To CheckListBox_1.Items.Count - 1
            CheckListBox_1.SetItemChecked(i, False)
        Next
        For i = 0 To CheckListBox_2.Items.Count - 1
            CheckListBox_2.SetItemChecked(i, False)
        Next
        For i = 0 To CheckListBox_3.Items.Count - 1
            CheckListBox_3.SetItemChecked(i, False)
        Next
        For i = 0 To CheckListBox_4.Items.Count - 1
            CheckListBox_4.SetItemChecked(i, False)
        Next
        Label9.Text = 0
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub


    Public Function For_Masivo(ByVal num As Double) As Double
        If num <= 1 Then
            Return 1
        Else
            Return For_Masivo(num - 1) * num
        End If

    End Function
End Class