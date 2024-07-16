
Imports System.Data.SqlClient
Imports RCBasketball.DAL
Imports System.Linq
Imports System.Web

Public Class ctrSearch_Players_Update
    Inherits System.Web.UI.UserControl

    Private m_PlayerID As Integer = 0

    Public Property PlayerID As Integer
        Get
            Return m_PlayerID
        End Get
        Set(ByVal value As Integer)
            m_PlayerID = value
        End Set
    End Property
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim thePlayers As New clsRCBasketball

        If Not (Page.IsPostBack) Then

            cmbPlayer.DataSource = thePlayers.GetPlayersList
            cmbPlayer.DataTextField = "PlayerID" : cmbPlayer.DataValueField = "FirstN"
            cmbPlayer.DataBind()

        End If

    End Sub
    Public Sub ClearControl()

        Me.cmbPlayer.Value = String.Empty : cmbPlayer.Text = "--"


    End Sub

    'Public Sub PopulateSearchControl()

    '    m_PlayerID = cmbPlayer.Text

    'End Sub
End Class