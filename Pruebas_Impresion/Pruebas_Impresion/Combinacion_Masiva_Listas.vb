Public Class Combinacion_Masiva_Listas
    Private Sub Combinacion_Masiva_Listas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckedListBox1.Items.Add("COMER")
        CheckedListBox1.Items.Add("MUCHO")
        CheckedListBox1.Items.Add("ENGORDA")
        CheckedListBox1.Items.Add("A LOS QUE SON FLACOS")
        CheckedListBox1.Items.Add("POR ESO HIJO MIO")
        CheckedListBox1.Items.Add("TE RECOMIENDO")
        CheckedListBox1.Items.Add(" NO COMER DEMACIADO")
        CheckedListBox1.Items.Add("PORQUE TERMINARÁS ")
        CheckedListBox1.Items.Add("COMO TU")
        CheckedListBox1.Items.Add(" PADRE")

        CheckedListBox2.Items.Add("COMER")
        CheckedListBox2.Items.Add("MUCHO")
        CheckedListBox2.Items.Add("ENGORDA")
        CheckedListBox2.Items.Add("A LOS QUE SON FLACOS")
        CheckedListBox2.Items.Add("POR ESO HIJO MIO")
        CheckedListBox2.Items.Add("TE RECOMIENDO")
        CheckedListBox2.Items.Add(" NO COMER DEMACIADO")
        CheckedListBox2.Items.Add("PORQUE TERMINARÁS ")
        CheckedListBox2.Items.Add("COMO TU")
        CheckedListBox2.Items.Add(" PADRE")

        CheckedListBox3.Items.Add("COMER")
        CheckedListBox3.Items.Add("MUCHO")
        CheckedListBox3.Items.Add("ENGORDA")
        CheckedListBox3.Items.Add("A LOS QUE SON FLACOS")
        CheckedListBox3.Items.Add("POR ESO HIJO MIO")
        CheckedListBox3.Items.Add("TE RECOMIENDO")
        CheckedListBox3.Items.Add(" NO COMER DEMACIADO")
        CheckedListBox3.Items.Add("PORQUE TERMINARÁS ")
        CheckedListBox3.Items.Add("COMO TU")
        CheckedListBox3.Items.Add(" PADRE")

        CheckedListBox4.Items.Add("COMER")
        CheckedListBox4.Items.Add("MUCHO")
        CheckedListBox4.Items.Add("ENGORDA")
        CheckedListBox4.Items.Add("A LOS QUE SON FLACOS")
        CheckedListBox4.Items.Add("POR ESO HIJO MIO")
        CheckedListBox4.Items.Add("TE RECOMIENDO")
        CheckedListBox4.Items.Add(" NO COMER DEMACIADO")
        CheckedListBox4.Items.Add("PORQUE TERMINARÁS ")
        CheckedListBox4.Items.Add("COMO TU")
        CheckedListBox4.Items.Add(" PADRE")




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim variable_Nombre, variable_Id, variable_Combinacion, variable_Neutral As New List(Of String)
        Dim a As Integer = 1
        For i = 0 To 3
            If Me.Controls.Find("CheckedListBox" & i + 1, True).Count = 1 Then
                Dim check As CheckedListBox = Me.Controls.Find("CheckedListBox" & i + 1, True)(0)
                Dim cantidad As Integer = check.CheckedItems.Count
                If cantidad > 1 Then
                    variable_Combinacion.Add("CheckedListBox" & i + 1)
                    variable_Neutral.Add("CheckedListBox" & i + 1)
                    a = a * check.CheckedItems.Count
                End If
                If cantidad = 1 Then
                    variable_Neutral.Add("CheckedListBox" & i + 1)
                End If
            End If
        Next

        Dim nombres_combinados(1000, 1000) As String
        Dim contador As Integer = 0
        Dim valor As Integer


        For i = 0 To variable_Combinacion.Count - 1
            If Me.Controls.Find("CheckedListBox" & i + 1, True).Count = 1 Then
                If variable_Combinacion(i) = "CheckedListBox" & i + 1 Then
                    Dim check As CheckedListBox = Me.Controls.Find("CheckedListBox" & i + 1, True)(0)
                    Dim elementos As Integer = check.CheckedItems.Count
                    For j = 0 To (a / elementos) - 1
                        For k = 0 To elementos - 1
                            nombres_combinados(i, contador) = check.CheckedItems.Item(k).ToString
                            contador += 1
                        Next
                    Next
                End If
            End If
            contador = 0
            valor = i
        Next

        Dim cadena As String = ""

        For j = 0 To a - 1
            For i = 0 To variable_Combinacion.Count - 1
                cadena = cadena & " - " & nombres_combinados(i, j)
            Next
            ListBox1.Items.Add(cadena)
            cadena = ""
        Next

        Label2.Text = ListBox1.Items.Count

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim NUEVO_NOMBRE, NUEVO_ID, NUEVO_CLB As New List(Of String)
        NUEVO_NOMBRE.Add(New String("JUANITO"))
        NUEVO_NOMBRE.Add(New String("PEPITO"))
        NUEVO_NOMBRE.Add(New String("PEDRITO"))
        NUEVO_NOMBRE.Add(New String("OLIVERCITO"))
        NUEVO_NOMBRE.Add(New String("THIAGUITO"))

        NUEVO_ID.Add(New String("85"))
        NUEVO_ID.Add(New String("27"))
        NUEVO_ID.Add(New String("15"))
        NUEVO_ID.Add(New String("100"))
        NUEVO_ID.Add(New String("99"))

        NUEVO_CLB.Add(New String("CheckedListBox1"))
        NUEVO_CLB.Add(New String("CheckedListBox2"))
        NUEVO_CLB.Add(New String("CheckedListBox3"))
        NUEVO_CLB.Add(New String("CheckedListBox4"))
        NUEVO_CLB.Add(New String("CheckedListBox5"))

        Dim HOLA As String = ""
        Dim I = 0
        For I = 0 To NUEVO_NOMBRE.Count - 1
            If NUEVO_CLB(I) = "CheckedListBox1" Then
                HOLA = HOLA & " " & NUEVO_NOMBRE(I) & " " & NUEVO_NOMBRE(I + 1)
                ListBox1.Items.Add(HOLA)
                HOLA = ""
            End If
            If NUEVO_CLB(I) = "CheckedListBox2" Then
                HOLA = HOLA & " " & NUEVO_NOMBRE(I) & " " & NUEVO_NOMBRE(I + 1)
                ListBox1.Items.Add(HOLA)
                HOLA = ""
            End If
            If NUEVO_CLB(I) = "CheckedListBox3" Then
                HOLA = HOLA & " " & NUEVO_NOMBRE(I) & " " & NUEVO_NOMBRE(I + 1)
                ListBox1.Items.Add(HOLA)
                HOLA = ""
            End If
            If NUEVO_CLB(I) = "CheckedListBox4" Then
                HOLA = HOLA & " " & NUEVO_NOMBRE(I) & " " & NUEVO_NOMBRE(I + 1)
                ListBox1.Items.Add(HOLA)
                HOLA = ""
            End If
            If NUEVO_CLB(I) = "CheckedListBox5" Then
                HOLA = HOLA & " " & NUEVO_NOMBRE(I) & " " & NUEVO_NOMBRE(0)
                ListBox1.Items.Add(HOLA)
                HOLA = ""
            End If
        Next

    End Sub
End Class