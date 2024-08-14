Public Class Players_Delete
    Inherits System.Web.UI.Page
    Private m_PlayerID As String = String.Empty
    Private m_FirstN As String = String.Empty
    Dim m_origPlayerID As Integer = 0

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
                Dim strPlayer As String = Request.Form("ctl00_MainContent_ctrSearchPlayers_Update_cmbPlayer_ClientState") _
                .Replace(m_origPlayerID, m_PlayerID)
                If m_PlayerID.Length > 4 Then
                    Dim arrPlayers() As String = strPlayer.Split(":")
                    Me.ctrPlayers_Delete.PlayerID = Integer.Parse(arrPlayers(1)) : Me.ctrPlayers_Delete.FirstN = (arrPlayers(2))


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