Imports System.Data.SqlClient
Imports RCBasketball.DAL
Imports System.Linq
Imports System.Web

Public Class ctrPlayers_Add
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim thePlayers As New clsRCBasketball
        Dim tblPlayers As New DAL.RCBasketball.PlayersDataTable

        Try

            If (Page.IsPostBack) Then
                If Request.Form("ctl00$MainContent$ctrPlayers_Add$btnAdd") = "Add" Then

                    AddPlayers()

                End If
            Else
                'PopulateControls()
            End If

        Catch ex As Exception
            Throw
        End Try


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
                theRCBasketball.GetPlayersByID(Convert.ToInt32(thisPlayers))
                lblResult.Text = "Player data has been added"
            Catch ex As SqlException
                If ex.Number = 2627 Then
                    lblResult.Text = "Player already exist!"
                Else
                    Throw New ApplicationException(ex.Message)
                End If
            End Try


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

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Response.Redirect("Players_Find.aspx", False)
    End Sub

End Class