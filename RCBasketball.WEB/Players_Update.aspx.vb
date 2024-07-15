Imports System.Data.SqlClient
Imports RCBasketball.DAL
Imports System.Linq
Imports System.Web
Public Class Players_Update
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try


            If (Page.IsPostBack) Then


                Dim strPlayer As String = (Request.Form("ctl00_MainContent_ctrSearch_Players_Update_cmbPlayer_ClientState") _
                    .Replace(Chr(34), "").Replace("{", "").Replace("}", "").Replace(",", "").Replace("text", "").Replace("value", "").Replace("%20", " ").Replace("%26", "&")

                If strPlayer.Length > 4 Then
                    Dim arrPlayers() As String = strPlayer.Split(":")
                    Me.ctrPlayers_Update.PlayerID = arrPlayers(1)
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