﻿Public Class Players_Delete
    Inherits System.Web.UI.Page
    Private m_PlayerID As Integer = 0

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            If (Page.IsPostBack) Then
                Dim strPlayer As String = (Request.Form("ctl00_MainContent_ctrPlayers_Update_PlayerID_ClientState").Replace("""", "").Replace("{", "").Replace("}", "").Replace(",", "").Replace("text", "").Replace("value", "").Replace("%20", " ").Replace("%26", "&"))

                If strPlayer.Length > 4 Then
                    Dim arrPlayers As String() = strPlayer.Split(Convert.ToChar(":"))
                    Me.ctrPlayers_Delete.PlayerID = Integer.Parse(arrPlayers(1))
                    Me.ctrSearch_Players_Update.ClearControl()
                    Me.ctrPlayers_Delete.CleanResultControl()

                    'Me.ctrPlayers_Delete.PlayerID = Integer.Parse(arrPlayers(1))
                    'Me.ctrPlayers_Delete.PlayerID = Integer.Parse(arrPlayers(2))
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