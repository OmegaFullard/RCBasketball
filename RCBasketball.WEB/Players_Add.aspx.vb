Public Class Players_Add
    Inherits System.Web.UI.Page

    Private m_PlayerID As Integer = 0
    Private m_PlayersList As String = String.Empty

    Public Property PlayerID As Integer
        Get
            Return m_PlayerID
        End Get
        Set(ByVal value As Integer)
            m_PlayerID = value
        End Set
    End Property
    Public Property PlayersList() As String
        Get
            Return m_PlayersList
        End Get
        Set(ByVal value As String)
            m_PlayersList = value
        End Set
    End Property
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If (Page.IsPostBack) Then

            If Request.Form("ctl00$MainContent$ctrSearch_Players$btnSearch") = "Search" Then
                ctrSearch_Players.PopulateSearchControl()
                If ctrSearch_Players.PlayerID = 0 Then Exit Sub
                Me.ctrPlayers_Add.ClearControls() : Me.ctrPlayers_Add.PlayersList = ctrSearch_Players.PlayerID

            ElseIf Request.Form("ctl00$MainContent$ctrPlayers_Add$btnCreate") = "Add" Then
                Me.ctrPlayers_Add.AddPlayers()
                If Me.ctrPlayers_Add.PlayerID = 0 Then Exit Sub
            End If

        End If
    End Sub

End Class