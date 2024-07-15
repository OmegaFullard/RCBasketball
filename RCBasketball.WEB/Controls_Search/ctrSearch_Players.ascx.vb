Public Class ctrSearch_Players
    Inherits System.Web.UI.UserControl

    Private m_PlayerID As String = String.Empty

    Public Property PlayerID() As String
        Get
            Return m_PlayerID
        End Get
        Set(ByVal value As String)
            m_PlayerID = value
        End Set
    End Property
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Public Sub PopulateSearchControl()

        m_PlayerID = txtPlayerID.Text

    End Sub

End Class