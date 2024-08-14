Imports System.Data.SqlClient
Imports RCBasketball.DAL
Imports System.Linq
Imports System.Web
Public Class Players_Update
    Inherits System.Web.UI.Page

    Private m_PlayerID As String = String.Empty

    Private m_FirstN As String = String.Empty

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
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            If (Page.IsPostBack) Then
                If Request.Form("ctl00$MainContent$ctrSearch_Players$btnSearch") = "Search" Then

                    ctrSearch_Players.PopulateSearchControl()

                    If ctrSearch_Players.PlayerID.Length = 0 Then Exit Sub
                    Me.ctrPlayers_Update.PlayerID = ctrSearch_Players.PlayerID

                End If


            End If

        Catch ex As Exception
            Dim SendError As New clsRCBasketball_Web
            Dim NotificationBody As String = ex.Message & vbCrLf & ex.StackTrace
            SendError.SendMailMessage(NotificationBody)
            Response.Redirect("ErrorPage.aspx", False)
        End Try
    End Sub

End Class