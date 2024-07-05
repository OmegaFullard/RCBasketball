Public Class clsSearch
    Private m_ReportName As String = String.Empty
    Private m_ClassOption As String = String.Empty
    Private m_ActivityBy As String = String.Empty
    Private m_ReportPath As String = String.Empty
    Private m_FirstN As String = String.Empty
    Private m_LastN As String = String.Empty
    Private m_PlayerID As String = String.Empty


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


    Public Property PlayerID() As String
        Get
            Return m_PlayerID
        End Get
        Set(ByVal value As String)
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

End Class
