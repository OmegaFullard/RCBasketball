Public Class clsPlayers
    Dim m_FirstN As String, m_LastN As String, m_Address As String, m_City As String, m_State As String, m_Zip As String, m_Phone As String, m_Email As String
    Dim m_origPlayerID As Integer = 0
    Dim m_PlayerID As Integer = 0

    Public Property PlayerID As Integer
        Get
            Return m_PlayerID
        End Get
        Set(ByVal value As Integer)
            m_PlayerID = value
        End Set
    End Property

    Public Property origPlayerID As Integer
        Get
            Return m_origPlayerID
        End Get
        Set(ByVal value As Integer)
            m_PlayerID = value
        End Set
    End Property


    Public Property FirstN As String
        Get
            Return m_FirstN
        End Get
        Set(ByVal value As String)
            m_FirstN = value
        End Set
    End Property


    Public Property LastN As String
        Get
            Return m_LastN
        End Get
        Set(ByVal value As String)
            m_LastN = value
        End Set
    End Property

    Public Property Address As String
        Get
            Return m_Address
        End Get
        Set(ByVal value As String)
            m_Address = value
        End Set
    End Property

    Public Property City As String
        Get
            Return m_City
        End Get
        Set(ByVal value As String)
            m_City = value
        End Set
    End Property


    Public Property State As String
        Get
            Return m_State
        End Get
        Set(ByVal value As String)
            m_State = value
        End Set
    End Property

    Public Property Zip As String
        Get
            Return m_Zip
        End Get
        Set(ByVal value As String)
            m_Zip = value
        End Set
    End Property

    Public Property Phone As String
        Get
            Return m_Phone
        End Get
        Set(ByVal value As String)
            m_Phone = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return m_Email
        End Get
        Set(ByVal value As String)
            m_Email = value
        End Set
    End Property



End Class
