Imports System.Data.SqlClient
Imports RCBasketball.DAL
Imports System.Linq
Imports System.Web
Imports RCBasketball.DAL.RCBasketball

Public Class ctrPlayers_Add
    Inherits System.Web.UI.UserControl
    Private m_PlayerID As String = String.Empty
    Private m_PlayersList As String = String.Empty

    Public Property PlayerID() As String
        Get
            Return m_PlayerID
        End Get
        Set(ByVal value As String)
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

        Dim thePlayers As New clsRCBasketball
        Dim tblPlayers As New PlayersDataTable

        Try
            If (Page.IsPostBack) Then
                If Request.Form("ct100$MainContent$ctrPlayers_Add$btnAdd") = "Add" Then
                    AddPlayers()
                End If

            Else
                PopulateControls()
            End If
        Catch ex As Exception

        End Try


    End Sub


    Public Sub AddPlayers()


        Try

            Dim thisPlayers As New clsPlayers

            With thisPlayers




                .PlayerID = txtID.Text : .FirstN = txtFN.Text : .LastN = txtLN.Text
                .Address = txtAdd.Text : .City = txtc.Text : .State = cmbStates.Text : .Zip = txtZ.Text
                .Phone = txtPh.Text : .Email = txtE.Text


                If txtID.Text.Trim.Length = 0 Then Exit Sub

            End With

            Try


                Dim theRCBasketball As New clsRCBasketball
                m_PlayerID = theRCBasketball.AddPlayer(thisPlayers)



            Catch ex As SqlException
                Throw New ApplicationException(ex.Message)
            End Try


            lblResult.Text = "Player has been added"
            Me.lblPlayerID.Text = "ID" + m_PlayerID

        Catch ex As Exception
            Dim SendError As New clsRCBasketball_Web
            Dim NotificationBody As String = ex.Message & "  " & ex.StackTrace
            SendError.SendMailMessage(NotificationBody)
            Response.Redirect("ErrorPage.aspx", False)
        End Try


    End Sub

    Private Sub PopulateControls()
        Dim thePlayers As New clsRCBasketball


        Me.cmbStates.DataSource = thePlayers.GetStatesList
        Me.cmbStates.DataTextField = "State"
        Me.cmbStates.DataBind()
        Me.cmbStates.Text = "PA"


        txtc.Text = "Philadelphia"



    End Sub

    Public Sub ClearControls()

    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Response.Redirect("Players_Find.aspx", False)
    End Sub

End Class