Public Class BEDocumento_Pago
    Dim id_docu As Integer
    Dim descripcion As String
    Dim fecha_vencimiento As DateTime
    Dim cod_doc As String
    Dim serie As String
    Dim numero As String
    Dim mto_total As Decimal
    Dim observacion As String
    Dim id_proveedor As Integer
    Dim id_sucursal As Integer
    Dim usu_reg As Integer
    Dim usu_mod As Integer
    Dim usu_eli As Integer

    Public Property gid_docu
        Get
            Return id_docu
        End Get
        Set(value)
            id_docu = value
        End Set
    End Property

    Public Property gdescripcion
        Get
            Return descripcion
        End Get
        Set(value)
            descripcion = value
        End Set
    End Property

    Public Property gfecha_vencimiento
        Get
            Return fecha_vencimiento
        End Get
        Set(value)
            fecha_vencimiento = value
        End Set
    End Property

    Public Property gcod_doc
        Get
            Return cod_doc
        End Get
        Set(value)
            cod_doc = value
        End Set
    End Property

    Public Property gserie
        Get
            Return serie
        End Get
        Set(value)
            serie = value
        End Set
    End Property

    Public Property gnumero
        Get
            Return numero
        End Get
        Set(value)
            numero = value
        End Set
    End Property

    Public Property gmto_total
        Get
            Return mto_total
        End Get
        Set(value)
            mto_total = value
        End Set
    End Property

    Public Property gobservacion
        Get
            Return observacion
        End Get
        Set(value)
            observacion = value
        End Set
    End Property

    Public Property gid_proveedor
        Get
            Return id_proveedor
        End Get
        Set(value)
            id_proveedor = value
        End Set
    End Property

    Public Property gid_sucursal
        Get
            Return id_sucursal
        End Get
        Set(value)
            id_sucursal = value
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

    Public Sub New(ByVal id_docu As Integer, ByVal descripcion As String, ByVal fecha_vencimiento As DateTime, ByVal cod_doc As String, ByVal serie As String, ByVal numero As String, ByVal mto_total As Decimal, ByVal observacion As String, ByVal id_proveedor As Integer, ByVal id_sucursal As Integer, ByVal usu_reg As Integer, ByVal usu_mod As Integer, ByVal usu_eli As Integer)
        gid_docu = id_docu
        gdescripcion = descripcion
        gfecha_vencimiento = fecha_vencimiento
        gcod_doc = cod_doc
        gserie = serie
        gnumero = numero
        gmto_total = mto_total
        gobservacion = observacion
        gid_proveedor = id_proveedor
        gid_sucursal = id_sucursal
        gusu_reg = usu_reg
        gusu_mod = usu_mod
        gusu_eli = usu_eli
    End Sub

End Class
