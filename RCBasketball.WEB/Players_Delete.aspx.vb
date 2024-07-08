Public Class Players_Delete
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


                Dim strPlayers As String = Request.Form("ctl00_MainContent_ctrSearch_Players_Update_cmbPlayers_ClientState") _
                    .Replace(Chr(34), "").Replace("{", "").Replace("}", "").Replace(",", "").Replace("text", "").Replace("value", "").Replace("%20", " ").Replace("%26", "&")

                If strPlayers.Length > 4 Then
                    Dim arrPlayers() As String = strPlayers.Split(":")
                    Me.ctrPlayers_Delete.PlayerID = arrPlayers(1)
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