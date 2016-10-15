Public Class BEServicios
    Dim id_serv As Integer
    Dim cod_serv As String
    Dim precio1 As Decimal
    Dim precio2 As Decimal
    Dim des_ser As String
    Dim usu_reg As Integer
    Dim usu_mod As Integer
    Dim usu_eli As Integer
    Dim id_unimed As Integer
    Dim id_tipo As Integer

    Public Property gid_serv
        Get
            Return id_serv
        End Get
        Set(value)
            id_serv = value
        End Set
    End Property

    Public Property gcod_serv
        Get
            Return cod_serv
        End Get
        Set(value)
            cod_serv = value
        End Set
    End Property
    Public Property gprecio1
        Get
            Return precio1
        End Get
        Set(value)
            precio1 = value
        End Set
    End Property


    Public Property gprecio2
        Get
            Return precio2
        End Get
        Set(value)
            precio2 = value
        End Set
    End Property

    Public Property gdes_ser
        Get
            Return des_ser
        End Get
        Set(value)
            des_ser = value
        End Set
    End Property

    Public Property gusu_reg
        Get
            Return usu_reg
        End Get
        Set(value)
            usu_reg = value
        End Set
    End Property

    Public Property gusu_mod
        Get
            Return usu_mod
        End Get
        Set(value)
            usu_mod = value
        End Set
    End Property

    Public Property gusu_eli
        Get
            Return usu_eli
        End Get
        Set(value)
            usu_eli = value
        End Set
    End Property

    Public Property gid_unimed
        Get
            Return id_unimed
        End Get
        Set(value)
            id_unimed = value
        End Set
    End Property


    Public Property gid_tipo
        Get
            Return id_tipo
        End Get
        Set(value)
            id_tipo = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal id_serv As Integer, ByVal cod_serv As String, ByVal precio1 As Decimal, ByVal precio2 As Decimal, ByVal des_ser As String, ByVal usu_reg As Integer, ByVal usu_mod As Integer, usu_eli As Integer, ByVal id_unimed As Integer, ByVal id_tipo As Integer)
        gid_serv = id_serv
        gcod_serv = cod_serv
        gprecio1 = precio1
        gprecio2 = precio2
        gdes_ser = des_ser
        gusu_reg = usu_reg
        gusu_mod = usu_mod
        gusu_eli = usu_eli
        gid_unimed = id_unimed
        gid_tipo = id_tipo
    End Sub

End Class
