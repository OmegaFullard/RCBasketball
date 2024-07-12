Public Class clsSearch
    Private m_ReportName As String = String.Empty
    Private m_ClassOption As String = String.Empty
    Private m_ActivityBy As String = String.Empty
    Private m_ReportPath As String = String.Empty
    Private m_FirstN As String = String.Empty
    Private m_LastN As String = String.Empty
    Private m_Address As String = String.Empty
    Private m_City As String = String.Empty
    Private m_State As String = String.Empty
    Private m_Zip As String = String.Empty
    Private m_Phone As String = String.Empty
    Private m_Email As String = String.Empty
    Private m_PlayerID As Integer = 0


    Public Property ReportName() As String
        Get
            Return m_ReportName
        End Get
        Set(ByVal value As String)
            m_ReportName = value
        End Set
    End Property
    Public Property ClassOption() As String
        Get
            Return m_ClassOption
        End Get
        Set(ByVal value As String)
            m_ClassOption = value
        End Set
    End Property
    Public Property ActivityBy() As String
        Get
            Return m_ActivityBy
        End Get
        Set(ByVal value As String)
            m_ActivityBy = value
        End Set
    End Property
    Public Property ReportPath() As String
        Get
            Return m_ReportPath
        End Get
        Set(ByVal value As String)
            m_ReportPath = value
        End Set
    End Property


    Public Property PlayerID As Integer
        Get
            Return m_PlayerID
        End Get
        Set(ByVal value As Integer)
            m_PlayerID = value
        End Set
    End Property

    Public Property FirstN() As String
        Get
            Return m_FirstN
        End Get
        Set(ByVal value As String)
            m_FirstN = value
        End Set
    End Property
    Public Property LastN() As String
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
