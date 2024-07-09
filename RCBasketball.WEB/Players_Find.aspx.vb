Imports System.Data.SqlClient
Imports RCBasketball.DAL
Imports System.Linq
Imports System.Web

Public Class Players_Find
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            If (Page.IsPostBack) Then

                If Request.Form("ctl00$MainContent$ctrSearch_Players$btnSearch") = "Search" Then
                    ctrSearch_Players.PopulateSearchControl()
                    Me.ctrPlayers_Find.PlayerID = ctrSearch_Players.PlayerID
                End If
            End If

        Catch ex As Exception
            Dim SendError As New clsRCBasketball_Web
            Dim NotificationBody As String = ex.Message & vbCrLf & ex.StackTrace
            SendError.SendMailMessage(NotificationBody)
            Response.Redirect("ErrorPage.aspx", False)
        End Try
    End Sub

    Public Overrides Property EnableEventValidation As Boolean
        Get
            Return False
        End Get
        Set(ByVal value As Boolean)
        End Set
    End Property
End Class