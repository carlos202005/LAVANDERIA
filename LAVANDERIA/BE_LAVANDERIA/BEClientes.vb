Public Class BEClientes
    Dim id_cli As Integer
    Dim nom_cli As String
    Dim apepat_cli As String
    Dim apemat_cli As String
    Dim correo As String
    Dim dni As String
    Dim celular As String
    Dim fec_nacimiento As DateTime
    Dim telefono As String
    Dim usu_reg As Integer
    Dim usu_mod As Integer
    Dim usu_eli As Integer
    Dim id_tipo As Integer

    Public Property gid_cli
        Get
            Return id_cli
        End Get
        Set(value)
            id_cli = value
        End Set
    End Property

    Public Property gnom_cli
        Get
            Return nom_cli
        End Get
        Set(value)
            nom_cli = value
        End Set
    End Property

    Public Property gapepat_cli
        Get
            Return apepat_cli
        End Get
        Set(value)
            apepat_cli = value
        End Set
    End Property

    Public Property gapemat_cli
        Get
            Return apemat_cli
        End Get
        Set(value)
            apemat_cli = value
        End Set
    End Property

    Public Property gcorreo
        Get
            Return correo
        End Get
        Set(value)
            correo = value
        End Set
    End Property


    Public Property gdni
        Get
            Return dni
        End Get
        Set(value)
            dni = value
        End Set
    End Property

    Public Property gcelular
        Get
            Return celular
        End Get
        Set(value)
            celular = value
        End Set
    End Property

    Public Property gfec_nacimiento
        Get
            Return fec_nacimiento
        End Get
        Set(value)
            fec_nacimiento = value
        End Set
    End Property

    Public Property gtelefono
        Get
            Return telefono
        End Get
        Set(value)
            telefono = value
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


    Public Sub New(ByVal id_cli As Integer, ByVal nom_cli As String, ByVal apepat_cli As String, ByVal apemat_cli As String, ByVal correo As String, ByVal dni As String, ByVal celular As String, ByVal fec_nacimiento As String, ByVal telefono As String, ByVal usu_reg As Integer, ByVal usu_mod As Integer, ByVal usu_eli As Integer, ByVal id_tipo As Integer)
        gid_cli = id_cli
        gnom_cli = nom_cli
        gapepat_cli = apepat_cli
        gapemat_cli = apemat_cli
        gcorreo = correo
        gdni = dni
        gcelular = celular
        gfec_nacimiento = fec_nacimiento
        gtelefono = telefono
        gusu_reg = usu_reg
        gusu_mod = usu_mod
        gusu_eli = usu_eli
        gid_tipo = id_tipo
    End Sub
End Class
