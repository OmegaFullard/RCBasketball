Imports System.Data.SqlClient
Imports RCBasketball.DAL
Imports System.Linq
Imports System.Web
Public Class Players_Update
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
        Try


            If (Page.IsPostBack) Then


                Dim strPlayer As String = (Request.Form("ctl00_MainContent_ctrPlayers_Update_cmbPlayer_ClientState") _
                    .Replace("""", "").Replace("{", "").Replace("}", "").Replace(",", "").Replace("text", "").Replace("value", "").Replace("%20", " ").Replace("%26", "&"))

                If strPlayer.Length > 0 Then
                    Dim arrPlayers As String() = strPlayer.Split(Convert.ToChar(":"))
                    Me.ctrPlayers_Update.PlayerID = Integer.Parse(arrPlayers(0))
                    Me.ctrSearch_Players_Update.ClearControl()
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