Public Class BEProveedores
    Dim id_proveedor As Integer
    Dim razon_social As String
    Dim ruc As String
    Dim telefono As String
    Dim celular As String
    Dim correo As String
    Dim usu_reg As Integer
    Dim usu_mod As Integer
    Dim usu_eli As Integer


    Public Property gid_proveedor
        Get
            Return id_proveedor
        End Get
        Set(value)
            id_proveedor = value
        End Set
    End Property

    Public Property grazon_social
        Get
            Return razon_social
        End Get
        Set(value)
            razon_social = value
        End Set
    End Property

    Public Property gruc
        Get
            Return ruc
        End Get
        Set(value)
            ruc = value
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

    Public Property gcelular
        Get
            Return celular
        End Get
        Set(value)
            celular = value
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

    Public Sub New()

    End Sub


    Public Sub New(ByVal id_proveedor As Integer, ByVal razon_social As String, ByVal ruc As String, ByVal telefono As String, ByVal celular As String, ByVal correo As String, ByVal usu_reg As Integer, ByVal usu_mod As Integer, ByVal usu_eli As Integer)
        gid_proveedor = id_proveedor
        grazon_social = razon_social
        gruc = ruc
        gtelefono = telefono
        gcorreo = correo
        gcelular = celular
        gcorreo = correo
        gusu_reg = usu_reg
        gusu_mod = usu_mod
        gusu_eli = usu_eli
    End Sub
End Class
