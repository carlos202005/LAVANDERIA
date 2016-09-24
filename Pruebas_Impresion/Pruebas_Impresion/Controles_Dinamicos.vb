Public Class Controles_Dinamicos
    Friend WithEvents _ComboBox As ComboBox
    Friend WithEvents _Label As Label
    Dim nombre As New List(Of String)
    Dim frm As New CLASS_IMPRIMIR
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim control, limite, contador As Integer
        contador = 0
        limite = TextBox1.Text
        control = Integer.Parse(limite \ 5)

        For i = 0 To control
            For j = 0 To 4
                If contador < limite Then
                    Dim _ComboBox = New ComboBox
                    Dim _Label = New Label
                    With _ComboBox
                        .Width = 100
                        .Height = 100
                        .Text = "Selecciona un Objeto"
                        .Name = "ComboBox_(" & j & "," & i & ")"
                        .Location = New Point(.Width * (j), .Height * (i))
                    End With
                    With _Label
                        .Width = 100
                        .Height = 100
                        .Text = "1"
                        .Name = "Label_(" & j & "," & i & ")"
                        .Location = New Point(.Width * (j + 10), .Height * (i + 10))
                    End With
                    Me.Controls.Add(_ComboBox)
                    frm.cargar(_ComboBox)
                    AddHandler _ComboBox.SelectedIndexChanged, AddressOf _ComboBox_SelectedIndexChanged
                    contador += 1
                Else
                    Exit For
                End If
            Next
        Next

    End Sub

    Private Sub Controles_Dinamicos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub _ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles _ComboBox.SelectedIndexChanged
        Dim control, limite, contador, lab_codigo As Integer
        Dim nombre As String

        contador = 0
        limite = TextBox1.Text
        control = Integer.Parse(limite \ 5)

        For i = 0 To control
            For j = 0 To 4
                If CType(sender, ComboBox).Name = "ComboBox_(" & j & "," & i & ")" Then
                    lab_codigo = CType(sender, ComboBox).SelectedValue
                    nombre = DirectCast(CType(sender, ComboBox).SelectedItem, DataRowView).Item("nom_pren")
                    MsgBox("Entrada :" & lab_codigo & ", " & nombre)
                End If
            Next
        Next

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Public Function Recursividad(ByVal n As Integer, ByVal m As List(Of String)) As String
        Dim nombre As String = ""
        If n >= 1 Then
            For i = 0 To n
                nombre = nombre & " " & m(i)
                Recursividad(n, m)
                n -= 1
            Next
        Else
            Return nombre

        End If
        Return nombre
    End Function
End Class