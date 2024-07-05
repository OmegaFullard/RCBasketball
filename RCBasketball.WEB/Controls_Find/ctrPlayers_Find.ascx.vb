Imports System.Data.SqlClient
Imports RCBasketball.DAL
Imports System.Linq
Imports System.Web
Public Class ctrPlayers_Find

    Inherits System.Web.UI.UserControl

    Dim m_PlayerID As Integer = 0

    Public Property PlayerID As Integer
        Get
            Return m_PlayerID
        End Get
        Set(ByVal value As Integer)
            m_PlayerID = value
        End Set
    End Property
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim thePlayers As New clsRCBasketball
        Dim tblPlayers As New DAL.RCBasketball.PlayersDataTable

        Try

            If Request.Form("ctl00$MainContent$ctrPlayers_Find$btnSearch") = "Search" Then Me.ctrHiddebField.Value = Convert.ToString(m_PlayerID)

            If (Page.IsPostBack) And Me.ctrHiddebField.Value.Length > 0 Then
                tblPlayers = thePlayers.GetPlayersByID("%" + Me.ctrHiddebField.Value + "%")
            Else
                tblPlayers = thePlayers.GetPlayer
            End If


            Me.lblSearchResult.Text = tblPlayers.Rows.Count.ToString + " Result(s)"
            Me.grdPlayers.DataSource = tblPlayers.DefaultView
            Me.grdPlayers.DataBind()


        Catch ex As Exception
            Dim SendError As New clsRCBasketball_Web
            Dim NotificationBody As String = ex.Message & "  " & ex.StackTrace
            SendError.SendMailMessage(NotificationBody)
            Response.Redirect("ErrorPage.aspx", False)
        End Try

    End Sub

    Protected Sub grdPlayers_PageIndexChanging(sender As Object, e As GridViewPageEventArgs) Handles grdPlayers.PageIndexChanging

    End Sub

    Protected Sub grdPlayers_Sorting(sender As Object, e As GridViewSortEventArgs) Handles grdPlayers.Sorting

    End Sub
End Class