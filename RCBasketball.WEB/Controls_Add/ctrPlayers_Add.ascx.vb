﻿Imports System.Data.SqlClient
Imports RCBasketball.DAL
Imports System.Linq
Imports System.Web

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
        PopulateControls()



    End Sub


    Public Sub AddPlayers()


        Try

            Dim thisPlayers As New clsPlayers

            With thisPlayers
                If txtPlayerID.Text.Trim.Length = 0 Then Exit Sub


                .PlayerID = txtPlayerID.Text.Trim : .FirstN = txtFirstN.Text.Trim : .LastN = txtLastN.Text.Trim
                .Address = txtAddress.Text.Trim : .City = txtCity.Text.Trim : .State = cmbStates.Text : .Zip = txtZip.Text
                .Phone = txtPhone.Text.Trim : .Email = txtEmail.Text.Trim


            End With



            Try
                Dim theRCBasketball As New clsRCBasketball
                m_PlayerID = theRCBasketball.AddPlayer(thisPlayers)

            Catch ex As SqlException

                Throw New ApplicationException(ex.Message)

            End Try

            lblResult.Text = "Player data has been added"
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


        txtCity.Text = "Philadelphia"



    End Sub

    Public Sub ClearControls()

    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Response.Redirect("Players_Find.aspx", False)
    End Sub

End Class