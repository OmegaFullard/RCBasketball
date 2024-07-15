Imports System.Data.SqlClient
Imports RCBasketball.DAL
Imports System.Linq
Imports System.Web
Imports RCBasketball.DAL.RCBasketball

Public Class ctrPlayers_Find

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
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load, grdPlayers.Load


        Dim thePlayers As clsRCBasketball = New clsRCBasketball()
        Dim tblPlayers As PlayersDataTable = New DAL.RCBasketball.PlayersDataTable()


        Try
            If Request.Form("ctl00$MainContent$ctrSearch_Players_Find$btnSearch") = "Search" Then Me.lblSearchResult.Text = "ID" & m_PlayerID

            If (Page.IsPostBack) And Me.lblSearchResult.Text.Length > 0 Then
                tblPlayers = CType(thePlayers.GetPlayersByID(Integer.Parse(Me.lblSearchResult.Text.Replace("ID", ""))), PlayersDataTable)
            Else
                tblPlayers = CType(thePlayers.GetPlayer(), PlayersDataTable)
            End If

            Me.lblSearchResult.Text = tblPlayers.Rows.Count.ToString()
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
        Try
            If Not (IsNothing(ViewState("columnname")) Or IsNothing(ViewState("direction"))) Then

                Dim m_DataView As DataView = CType(Me.grdPlayers.DataSource, DataView)

                If Not m_DataView Is Nothing Then

                    m_DataView.Sort = ViewState("columnname").ToString() + " " + ViewState("direction").ToString()
                    Me.grdPlayers.DataSource = m_DataView

                End If
            End If

            Me.grdPlayers.PageIndex = e.NewPageIndex
            Me.grdPlayers.DataBind()

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Protected Sub grdPlayers_Sorting(sender As Object, e As GridViewSortEventArgs) Handles grdPlayers.Sorting
        Try

            Dim m_Dataview As DataView = CType(grdPlayers.DataSource, DataView)

            If Not m_Dataview Is Nothing Then

                m_Dataview.Sort = e.SortExpression + " " + ConvertSortDirection(e)
                Me.grdPlayers.DataSource = m_Dataview
                Me.grdPlayers.DataBind()

            End If

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Function ConvertSortDirection(ByVal e As System.Web.UI.WebControls.GridViewSortEventArgs) As String

        ViewState.Add("columnname", e.SortExpression)

        If (ViewState("direction") Is Nothing) Then
            ViewState.Add("direction", "asc")
        Else
            ViewState("direction") = IIf(ViewState("direction").ToString.ToLower = "desc", "asc", "desc")
        End If

        Return ViewState("direction").ToString()

    End Function

End Class