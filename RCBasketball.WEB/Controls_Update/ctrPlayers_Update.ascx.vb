﻿Imports System.Data.SqlClient
Imports RCBasketball.DAL
Imports System.Linq
Imports System.Web
Imports RCBasketball.DAL.RCBasketball

Public Class ctrPlayers_Update
    Inherits System.Web.UI.UserControl

    Private m_FirstN As String = String.Empty
    Private m_LastN As String = String.Empty
    Private m_PlayerID As String = String.Empty

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
    Public Property LastN() As String
        Get
            Return m_LastN
        End Get
        Set(ByVal value As String)
            m_LastN = value
        End Set
    End Property
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim thePlayers As clsRCBasketball = New clsRCBasketball()
        Dim tblPlayers As PlayersDataTable = New PlayersDataTable()

        Try

            If (Page.IsPostBack) Then


                If Request.Form("ctl00$MainContent$ctrPlayers_Update$btnUpdate") = "Update" Then

                    UpdatePlayer()

                Else
                    If m_PlayerID.Length > 0 Then
                        lblResult.Text = "ID" + m_PlayerID
                        If (lblResult.Text.Length = 0) Then Return
                        If True Then

                            With tblPlayers(0)


                                cmbStates.Value = .State
                                Me.txtFirstN.Text = .FirstN : Me.txtLastN.Text = .LastN : Me.txtPlayerID.Text = .PlayerID : If Not .IsAddressNull Then txtAddress.Text = .Address.Trim

                                If Not .IsCityNull Then Me.txtCity.Text = .City.Trim
                                If Not .IsZipNull Then
                                    If .Zip.Trim.Length > 5 Then txtZip.Text = .Zip.Trim.Substring(0, 5) Else txtZip.Text = .Zip.Trim
                                End If

                                If Not .IsPhoneNull Then txtPhone.Text = .Phone
                                If Not .IsEmailNull Then txtEmail.Text = .Email

                            End With


                            Me.btnUpdate.Enabled = True

                        End If

                    Else
                        PopulateControls()
                    End If
                End If
            End If
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



    End Sub
    Private Sub UpdatePlayer()
        Try

            Dim thisPlayers As New clsPlayers

            With thisPlayers
                If txtPlayerID.Text.Length = 0 Then Exit Sub

                .origPlayerID = txtPlayerID.Text.Trim
                .FirstN = txtFirstN.Text.Trim : .LastN = txtLastN.Text.Trim : .Address = txtAddress.Text.Trim
                .City = txtCity.Text.Trim : .State = cmbStates.Text : .Zip = txtZip.Text : .Phone = txtPhone.Text.Trim : .Email = txtEmail.Text.Trim

            End With


            Try
                Dim thePlayers As New clsRCBasketball
                thePlayers.UpdatePlayer(thisPlayers)
                lblResult.Text = "Player data has been updated"
            Catch ex As SqlException
                Throw New ApplicationException(ex.Message)
            End Try



        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Response.Redirect("Players_Find.aspx", False)
    End Sub
    Private Sub CleanControls()

        txtPlayerID.Text = String.Empty : txtFirstN.Text = String.Empty : txtLastN.Text = String.Empty
        txtAddress.Text = String.Empty : txtCity.Text = String.Empty : cmbStates.Text = String.Empty : txtZip.Text = String.Empty
        txtPhone.Text = String.Empty : txtEmail.Text = String.Empty


    End Sub

    Public Sub CleanResultControl()
        Me.lblResult.Text = String.Empty
    End Sub

End Class