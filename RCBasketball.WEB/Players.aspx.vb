Public Class Players
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If (Page.IsPostBack) Then
            If Request.Form("ctl00$MainContent$ctrSearch_Players$btnSearch") = "Search" Then

                ctrSearch_Players.PopulateSearchControl()
                ctrPlayers.PlayerID = ctrSearch_Players.PlayerID

            End If
        End If
    End Sub

End Class