Imports RCBasketball.DAL.RCBasketball_Reports
Imports RCBasketball.DAL.RCBasketball_ReportsTableAdapters

Public Class clsRCBasketball_Reports

    Public Function GetPlayer() As DataTable
        Try

            Dim adpPlayers As New PlayersTableAdapter
            Dim tblPlayers As PlayersDataTable = adpPlayers.GetData

            Return tblPlayers

        Catch ex As Exception
            Throw
        End Try
    End Function
    Public Function GetPlayerByPlayerID(ByVal numPlayerID As Integer) As DataTable
        Try

            Dim adpPlayers As New PlayersTableAdapter
            Dim tblPlayers As PlayersDataTable = adpPlayers.GetDataByPlayerID(numPlayerID)

            Return tblPlayers

        Catch ex As Exception
            Throw
        End Try
    End Function
End Class
