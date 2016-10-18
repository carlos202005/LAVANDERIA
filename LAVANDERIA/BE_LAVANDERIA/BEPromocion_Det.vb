Public Class BEPromocion_Det
    Dim id_promodet As Integer
    Dim id_serv As Integer
    Dim cantserv As Integer
    Dim id_servbono As Integer
    Dim cantbono As Integer
    Dim id_promocion As Integer

    Public Property gid_promodet
        Get
            Return id_promodet
        End Get
        Set(value)
            id_promodet = value
        End Set
    End Property

    Public Property gid_serv
        Get
            Return id_serv
        End Get
        Set(value)
            id_serv = value
        End Set
    End Property
    Public Property gcantserv
        Get
            Return cantserv
        End Get
        Set(value)
            cantserv = value
        End Set
    End Property

    Public Property gid_servbono
        Get
            Return id_servbono
        End Get
        Set(value)
            id_servbono = value
        End Set
    End Property

    Public Property gcantbono
        Get
            Return cantbono
        End Get
        Set(value)
            cantbono = value
        End Set
    End Property

    Public Property gid_promocion
        Get
            Return id_promocion
        End Get
        Set(value)
            id_promocion = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal id_promodet As Integer, ByVal id_serv As Integer, ByVal cantserv As Integer, ByVal id_servbono As Integer, ByVal cantbono As Integer, ByVal id_promocion As Integer)
        gid_promodet = id_promodet
        gid_serv = id_serv
        gcantserv = cantserv
        gid_servbono = id_servbono
        gcantbono = cantbono
        gid_promocion = id_promocion
    End Sub

End Class
