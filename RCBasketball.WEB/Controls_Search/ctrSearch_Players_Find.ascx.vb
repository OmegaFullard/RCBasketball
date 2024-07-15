Public Class ctrSearch_Players_Find
    Inherits System.Web.UI.UserControl


    Private m_PlayerID As Integer = 0

    Public Property PlayerID() As Integer
        Get
            Return m_PlayerID
        End Get
        Set(ByVal value As Integer)
            m_PlayerID = value
        End Set
    End Property
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Public Sub PopulateSearchControl()

        m_PlayerID = Me.txtPlayerID.Text

    End Sub
End Class