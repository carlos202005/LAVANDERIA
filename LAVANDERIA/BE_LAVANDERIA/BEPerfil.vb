Public Class BEPerfil

    Dim id_perfil As Integer
    Dim nom_per As String
    Dim usu_reg As Integer
    Dim usu_mod As Integer
    Dim usu_eli As Integer

    Public Property gid_perfil
        Get
            Return id_perfil
        End Get
        Set(value)
            id_perfil = value
        End Set
    End Property


    Public Property gnom_per
        Get
            Return nom_per
        End Get
        Set(value)
            nom_per = value
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

    Public Sub New(ByVal id_perfil As Integer, ByVal nom_per As String, ByVal usu_reg As Integer, ByVal usu_mod As Integer, ByVal usu_eli As Integer)

        gid_perfil = id_perfil
        gnom_per = nom_per
        gusu_reg = usu_reg
        gusu_mod = usu_mod
        gusu_eli = usu_eli
    End Sub


End Class
