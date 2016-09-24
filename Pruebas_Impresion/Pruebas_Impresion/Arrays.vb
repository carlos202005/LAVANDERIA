Public Class Arrays
    Private Sub Arrays_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim array_datos1 As String() = {"pera", "manzana", "limon", "naranja", "coco", "etc"}
        Dim array_datos2 As String() = {"MELON", "CALABAZA", "LIMA", "TORONJA", "COCONA", "MANDARINA"}

        For i = 0 To 5
            For j = 0 To 5
                Me.TextBox1.Text = TextBox1.Text & array_datos1(i) & "-" & array_datos2(j) & vbCrLf
            Next
        Next



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class