﻿Imports System.Data.SqlClient
Imports RCBasketball.DAL
Imports System.Linq
Imports System.Web
Imports Microsoft.Reporting.WebForms
Imports RCBasketball.DAL.RCBasketball_Reports

Public Class rptPlayers
    Inherits System.Web.UI.Page

    'Private frmRequest As String = String.Empty
    Private m_PlayerID As String = String.Empty
    Private theSearch As clsSearch = New clsSearch()
    Private thePlayers As clsRCBasketball = New clsRCBasketball()

    Public Property PlayerID As String
        Get
            Return m_PlayerID
        End Get
        Set(ByVal value As String)
            m_PlayerID = value
        End Set
    End Property
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If (Page.IsPostBack) Then
            If Request.Form("ctl00$MainContent$ctrSearch_Players$btnSearch") = "Search" Then
                ctrSearch_Players.PopulateSearchControl()
                theSearch.ReportPath = "~/Reports_Players/rptPlayers.rdlc"
                theSearch.PlayerID = ctrSearch_Players.PlayerID
                PlayerReport()
            End If
        End If
    End Sub

    Private Sub PlayerReport()

        Try

            Dim thePlayer As New clsRCBasketball_Reports

            Dim ReportDataSource As ReportDataSource = New ReportDataSource()
            Dim strTitle As String = String.Empty
            Dim dtReport As PlayersDataTable

            ReportDataSource.Name = "DataSet1"

            ReportViewer1.ProcessingMode = ProcessingMode.Local
            ReportViewer1.LocalReport.ReportPath = Server.MapPath(theSearch.ReportPath)
            If theSearch.PlayerID.Trim.Length = 0 Then theSearch.PlayerID = 0
            If IsNumeric(theSearch.PlayerID) Then Int32.Parse(theSearch.PlayerID)



            Dim numPlayerID As Integer = Int32.Parse(theSearch.PlayerID)
            dtReport = thePlayer.GetPlayerByPlayerID(numPlayerID)

            ReportDataSource.Value = dtReport


            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.DataSources.Add(ReportDataSource)

            ReportViewer1.LocalReport.Refresh()



        Catch ex As Exception
            Throw
        End Try


    End Sub

    Protected Sub ReportViewer1_Load(sender As Object, e As EventArgs)
        'string exportOption = "Excel";
        'string exportOption = "Word";
        Dim exportOption As String = "PDF"
        Dim extension As RenderingExtension = ReportViewer1.LocalReport.ListRenderingExtensions().ToList().Find(Function(x) x.Name.Equals(exportOption, StringComparison.CurrentCultureIgnoreCase))
        If extension IsNot Nothing Then
            Dim fieldInfo As System.Reflection.FieldInfo = extension.GetType().GetField("m_isVisible", System.Reflection.BindingFlags.Instance Or System.Reflection.BindingFlags.NonPublic)
            fieldInfo.SetValue(extension, False)
        End If
    End Sub
End Class