
Imports System.Data.SqlClient
Imports RCBasketball.DAL
Imports System.Linq
Imports System.Web

Public Class ctrSearch_Players_Update
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim thePlayers As New clsRCBasketball

        If Not (Page.IsPostBack) Then

            cmbPlayer.DataSource = thePlayers.GetPlayersList()
            cmbPlayer.DataTextField = "FirstN" : cmbPlayer.DataValueField = "LastN"
            cmbPlayer.DataBind()

        End If

    End Sub
    Public Sub ClearControl()

        Me.cmbPlayer.Value = String.Empty : cmbPlayer.Text = "--"


    End Sub
End Class