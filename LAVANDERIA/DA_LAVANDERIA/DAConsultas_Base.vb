Imports System.Data.SqlClient

Public Class DAConsultas_Base
    Inherits Conexion
    Dim cmd As SqlCommand
    Public Function mostrarId_Promocion_Ultima() As Integer
        Try
            Conectar()
            cmd = New SqlCommand("select top 1 id_promocio as CODIGO from Promocion order by id_promocio desc")
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn

            Dim da As Integer
            da = cmd.ExecuteScalar()
            Return da
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            Desconectar()
        End Try
    End Function

    Public Function mostrarCod_Promocion_Ultima() As String
        Try
            Conectar()
            cmd = New SqlCommand("select top 1 cod_promo as CODIGO from Promocion order by id_promocio desc")
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn

            Dim da As String
            da = cmd.ExecuteScalar()
            Return da
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            Desconectar()
        End Try
    End Function

    Public Function mostrarId_Nombre_Servicio(ByVal id_serv As Integer) As String
        Try
            Conectar()
            cmd = New SqlCommand("select des_ser from Servicio where id_serv=" & id_serv)
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn

            Dim da As String
            da = cmd.ExecuteScalar()
            Return da
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            Desconectar()
        End Try
    End Function

End Class
