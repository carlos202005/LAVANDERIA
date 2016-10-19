Public Class BEUsuarios
    Dim id_usu As Integer
    Dim nom_usu As String
    Dim clave_usu As String
    Dim id_perfil As Integer
    Dim id_emp As Integer

    Public Property gid_usu
        Get
            Return id_usu
        End Get
        Set(value)
            id_usu = value
        End Set
    End Property

    Public Property gnom_usu
        Get
            Return nom_usu
        End Get
        Set(value)
            nom_usu = value
        End Set
    End Property

    Public Property gclave_usu
        Get
            Return clave_usu
        End Get
        Set(value)
            clave_usu = value
        End Set
    End Property

    Public Property gid_perfil
        Get
            Return id_perfil
        End Get
        Set(value)
            id_perfil = value
        End Set
    End Property

    Public Property gid_emp
        Get
            Return id_emp
        End Get
        Set(value)
            id_emp = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal id_usu As Integer, ByVal nom_usu As String, ByVal clave_usu As String, ByVal id_perfil As Integer, ByVal id_emp As Integer)
        gid_usu = id_usu
        gnom_usu = nom_usu
        gclave_usu = clave_usu
        gid_perfil = id_perfil
        gid_emp = id_emp
    End Sub


End Class
