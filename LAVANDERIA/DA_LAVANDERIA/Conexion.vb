
Imports System.Data.SqlClient

Public Class Conexion
    Dim DA_MDL_Conexion_Global As New DA_MDL_Conexion_Global
    Protected cnn As SqlConnection


    Public Function Conectar()
        Try
            cnn = New SqlConnection(DA_MDL_Conexion_Global.conexion_base)
            cnn.Open()
            Return True
        Catch ex As Exception
            MsgBox("Error al conectarse a la base de datos " + ex.Message)
            Return False
        End Try
    End Function

    Public Function Desconectar()
        Try
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            Else
                Return True
            End If
        Catch ex As Exception
            MsgBox("Error:" + ex.Message)
            Return False
        End Try
        Return False
    End Function


End Class
