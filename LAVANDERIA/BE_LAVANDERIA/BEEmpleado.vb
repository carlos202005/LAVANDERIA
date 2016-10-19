Public Class BEEmpleado
    Dim id_emp As Integer
    Dim nom_emp As String
    Dim apet_pat As String
    Dim apet_mat As String
    Dim dni As String
    Dim fecha_nac As DateTime
    Dim celular As String

    Public Property gid_emp
        Get
            Return id_emp
        End Get
        Set(value)
            id_emp = value
        End Set
    End Property

    Public Property gnom_emp
        Get
            Return nom_emp
        End Get
        Set(value)
            nom_emp = value
        End Set
    End Property

    Public Property gapet_pat
        Get
            Return apet_pat
        End Get
        Set(value)
            apet_pat = value
        End Set
    End Property

    Public Property gapet_mat
        Get
            Return apet_mat
        End Get
        Set(value)
            apet_mat = value
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

    Public Property gfecha_nac
        Get
            Return fecha_nac
        End Get
        Set(value)
            fecha_nac = value
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

    Public Sub New()

    End Sub


    Public Sub New(ByVal id_emp As Integer, ByVal nom_emp As String, ByVal apet_pat As String, ByVal apet_mat As String, ByVal dni As String, ByVal fecha_nac As DateTime, ByVal celular As String)
        gid_emp = id_emp
        gnom_emp = nom_emp
        gapet_pat = apet_pat
        gapet_mat = apet_mat
        gdni = dni
        gfecha_nac = fecha_nac
        gcelular = celular
    End Sub

End Class
