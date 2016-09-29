Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class Form1
    Dim sqlConnection1 As New MySql.Data.MySqlClient.MySqlConnection(CONEXION_GLOBAL.Base_Conexion)
    Dim cmd As New MySql.Data.MySqlClient.MySqlCommand

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim dato1 As New ParameterValues
            Dim dato2 As New ParameterValues
            Dim pvisualizar As New ParameterDiscreteValue
            Dim pvisualizar1 As New ParameterDiscreteValue
            Dim cr1 As New CrystalReport1

            pvisualizar.Value = Format(DateTimePicker1.Value, "yyyy-MM-dd")
            dato1.Add(pvisualizar)
            pvisualizar1.Value = Format(DateTimePicker2.Value, "yyyy-MM-dd")
            dato2.Add(pvisualizar1)

            cr1.DataDefinition.ParameterFields("_fecha_ini").ApplyCurrentValues(dato1)
            cr1.DataDefinition.ParameterFields("_fecha_fin").ApplyCurrentValues(dato2)
            Me.CrystalReportViewer1.ReportSource = cr1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
