Imports System.Data.SqlClient
Imports RCBasketball.DAL
Imports System.Linq
Imports System.Web
Imports RCBasketball.DAL.RCBasketball

Public Class ctrPlayers
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
        Dim thePlayers As clsRCBasketball = New clsRCBasketball()
        Dim tblPlayers As New PlayersDataTable

        Try

            If Request.Form("ctl00$MainContent$ctrSearch_Players$btnSearch") = "Search" Then
                Me.ctrHiddebField.Value = Convert.ToString(m_PlayerID)
            End If

            If (Page.IsPostBack) And Me.lblSearchResult.Text.Length > 0 Then
                tblPlayers = thePlayers.GetPlayersByID(m_PlayerID)
            Else
                tblPlayers = thePlayers.GetPlayer()
            End If


            Me.lblSearchResult.Text = tblPlayers.Rows.Count.ToString + " Result(s)"
            Me.grdPlayers.DataSource = tblPlayers.DefaultView
            Me.grdPlayers.DataBind()


        Catch ex As Exception
            Throw
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