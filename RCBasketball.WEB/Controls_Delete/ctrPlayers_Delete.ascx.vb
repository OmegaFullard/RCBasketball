Imports System.Data.SqlClient
Imports RCBasketball.DAL
Imports System.Linq
Imports System.Web
Imports RCBasketball.DAL.RCBasketball

Public Class ctrPlayers_Delete
    Inherits System.Web.UI.UserControl


    Private m_PlayerID As String = String.Empty
    Public Property PlayerID() As String
        Get
            Return m_PlayerID
        End Get
        Set(ByVal value As String)
            m_PlayerID = value
        End Set
    End Property
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim thePlayers As New clsRCBasketball
        Dim tblPlayers As New PlayersDataTable

        Try


            If (Page.IsPostBack) Then
                If Request.Form("ctl00$MainContent$ctrPlayers_Delete$btnDelete") = "Delete" Then

                    DeletePlayers()

                Else
                    If m_PlayerID.Length = 0 Then Exit Sub

                    tblPlayers = thePlayers.GetPlayersByID(m_PlayerID)
                    If tblPlayers.Count = 0 Then Exit Sub

                    With tblPlayers(0)



                        Me.txtID.Text = .PlayerID : If Not .IsFirstNNull Then Me.txtFN.Text = .FirstN
                        If Not .IsLastNNull Then txtLN.Text = .LastN : If Not .IsAddressNull Then txtAdd.Text = .Address.Trim

                        If Not .IsCityNull Then Me.txtc.Text = .City.Trim : If Not .IsStateNull Then Me.cmbStates.Text = .State.Trim
                        If Not .IsZipNull Then
                            If .Zip.Trim.Length > 5 Then txtZ.Text = .Zip.Trim.Substring(0, 5) Else txtZ.Text = .Zip.Trim
                        End If

                        If Not .IsPhoneNull Then txtPh.Text = .Phone
                        If Not .IsEmailNull Then txtE.Text = .Email



                    End With

                    Me.btnDelete.Enabled = True

                End If

            End If

        Catch ex As Exception
            Dim SendError As New clsRCBasketball_Web
            Dim NotificationBody As String = ex.Message & "  " & ex.StackTrace
            SendError.SendMailMessage(NotificationBody)
            Response.Redirect("ErrorPage.aspx", False)
        End Try

    End Sub
    Private Sub DeletePlayers()
        Try

            Dim thisPlayers As New clsPlayers

            With thisPlayers
                If txtID.Text.Trim.Length = 0 Then Exit Sub

                .PlayerID = txtID.Text.Trim


            End With


            Try
                Dim theRCBasketball As New clsRCBasketball
                theRCBasketball.DeletePlayer(thisPlayers)
                lblResult.Text = "Player data has been deleted"
            Catch ex As SqlException
                Throw New ApplicationException(ex.Message)
            End Try

            CleanupControls()



        Catch ex As Exception
            Throw
        End Try
    End Sub


    Private Sub CleanupControls()

        Me.txtID.Text = String.Empty : Me.txtFN.Text = String.Empty : Me.txtLN.Text = String.Empty
        txtAdd.Text = String.Empty : Me.txtc.Text = String.Empty : Me.cmbStates.Text = String.Empty : txtZ.Text = String.Empty
        txtPh.Text = String.Empty : txtE.Text = String.Empty


    End Sub

    Public Sub CleanResultControl()
        Me.lblResult.Text = String.Empty
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Response.Redirect("Players_Find.aspx", False)
    End Sub

End Class