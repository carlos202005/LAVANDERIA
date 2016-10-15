Public Class BEPromocion
    Dim id_promocion As Integer
    Dim cod_promo As String
    Dim id_suculsal As Integer
    Dim fec_ini As String
    Dim fec_fin As String
    Dim usu_reg As Integer
    Dim usu_mod As Integer
    Dim usu_eli As Integer

    Public Property gid_promocion
        Get
            Return id_promocion
        End Get
        Set(value)
            id_promocion = value
        End Set
    End Property

    Public Property gcod_promo
        Get
            Return cod_promo
        End Get
        Set(value)
            cod_promo = value
        End Set
    End Property

    Public Property gid_suculsal
        Get
            Return id_suculsal
        End Get
        Set(value)
            id_suculsal = value
        End Set
    End Property

    Public Property gfec_ini
        Get
            Return fec_ini
        End Get
        Set(value)
            fec_ini = value
        End Set
    End Property

    Public Property gfec_fin
        Get
            Return fec_fin
        End Get
        Set(value)
            fec_fin = value
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



    Public Sub New()

    End Sub


    Public Sub New(ByVal id_promocion As Integer, ByVal cod_promo As String, ByVal id_suculsal As Integer, ByVal fec_ini As String, ByVal fec_fin As String, ByVal usu_reg As Integer, ByVal usu_mod As Integer, ByVal usu_eli As Integer)
        gid_promocion = id_promocion
        gcod_promo = cod_promo
        gid_suculsal = id_suculsal
        gfec_ini = fec_ini
        gfec_fin = fec_fin
        gusu_reg = usu_reg
        gusu_mod = usu_mod
        gusu_eli = usu_eli
    End Sub
End Class
