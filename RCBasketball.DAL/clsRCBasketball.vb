Imports RCBasketball.DAL.RCBasketball
Imports RCBasketball.DAL.RCBasketballTableAdapters


Public Class clsRCBasketball

    Dim m_PlayerID As Integer = 0
    Private PlayerID As Boolean

    Public Function GetPlayersList() As DataTable
        Try
            Dim adpPlayersList As New PlayersListTableAdapter
            Dim tblPlayersList As RCBasketball.PlayersListDataTable = adpPlayersList.GetDataByList()

            Return tblPlayersList


        Catch ex As Exception
            Throw
        End Try
    End Function


    Public Function GetPlayer() As DataTable
        Try
            Dim adpPlayers As PlayersTableAdapter = New PlayersTableAdapter()
            Dim tblPlayers As RCBasketball.PlayersDataTable = adpPlayers.GetData()

            Return tblPlayers


        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GetPlayersByFirstLast(ByRef FirstN As String, LastN As String) As DataTable
        Try
            Dim adpPlayers As New PlayersTableAdapter
            Dim tblPlayers As RCBasketball.PlayersDataTable = adpPlayers.GetDataByFirstLast(FirstN, LastN)

            Return tblPlayers


        Catch ex As Exception
            Throw
        End Try
    End Function


    Public Function GetPlayersByID(ByVal PlayerID As Integer) As DataTable
        Try
            Dim adpPlayers As PlayersTableAdapter = New PlayersTableAdapter()
            Dim tblPlayers As RCBasketball.PlayersDataTable = adpPlayers.GetDataByPlayerID(PlayerID)

            Return tblPlayers


        Catch ex As Exception
            Throw
        End Try
    End Function



    Public Function GetStatesList() As DataTable

        Dim ds As New DataSet
        Dim dt As New DataTable("GetData")
        Dim dr As DataRow

        dt.Columns.Add("State", Type.GetType("System.String")).DefaultValue = String.Empty

        dr = dt.NewRow : dr("State") = "AL" : dt.Rows.Add(dr) : dr = dt.NewRow : dr("State") = "AK" : dt.Rows.Add(dr) : dr = dt.NewRow : dr("State") = "AZ" : dt.Rows.Add(dr)
        dr = dt.NewRow : dr("State") = "AR" : dt.Rows.Add(dr) : dr = dt.NewRow : dr("State") = "CA" : dt.Rows.Add(dr) : dr = dt.NewRow : dr("State") = "CO" : dt.Rows.Add(dr)
        dr = dt.NewRow : dr("State") = "CT" : dt.Rows.Add(dr) : dr = dt.NewRow : dr("State") = "DE" : dt.Rows.Add(dr) : dr = dt.NewRow : dr("State") = "DC" : dt.Rows.Add(dr)
        dr = dt.NewRow : dr("State") = "FL" : dt.Rows.Add(dr) : dr = dt.NewRow : dr("State") = "GA" : dt.Rows.Add(dr) : dr = dt.NewRow : dr("State") = "ID" : dt.Rows.Add(dr)
        dr = dt.NewRow : dr("State") = "IL" : dt.Rows.Add(dr) : dr = dt.NewRow : dr("State") = "IN" : dt.Rows.Add(dr) : dr = dt.NewRow : dr("State") = "IA" : dt.Rows.Add(dr)
        dr = dt.NewRow : dr("State") = "KS" : dt.Rows.Add(dr) : dr = dt.NewRow : dr("State") = "KY" : dt.Rows.Add(dr) : dr = dt.NewRow : dr("State") = "LA" : dt.Rows.Add(dr)
        dr = dt.NewRow : dr("State") = "Me" : dt.Rows.Add(dr) : dr = dt.NewRow : dr("State") = "MD" : dt.Rows.Add(dr) : dr = dt.NewRow : dr("State") = "MA" : dt.Rows.Add(dr)
        dr = dt.NewRow : dr("State") = "MI" : dt.Rows.Add(dr) : dr = dt.NewRow : dr("State") = "MN" : dt.Rows.Add(dr) : dr = dt.NewRow : dr("State") = "MS" : dt.Rows.Add(dr)
        dr = dt.NewRow : dr("State") = "MO" : dt.Rows.Add(dr) : dr = dt.NewRow : dr("State") = "MT" : dt.Rows.Add(dr) : dr = dt.NewRow : dr("State") = "NE" : dt.Rows.Add(dr)
        dr = dt.NewRow : dr("State") = "NV" : dt.Rows.Add(dr) : dr = dt.NewRow : dr("State") = "NH" : dt.Rows.Add(dr) : dr = dt.NewRow : dr("State") = "NJ" : dt.Rows.Add(dr)
        dr = dt.NewRow : dr("State") = "NM" : dt.Rows.Add(dr) : dr = dt.NewRow : dr("State") = "NY" : dt.Rows.Add(dr) : dr = dt.NewRow : dr("State") = "NC" : dt.Rows.Add(dr)
        dr = dt.NewRow : dr("State") = "ND" : dt.Rows.Add(dr) : dr = dt.NewRow : dr("State") = "OH" : dt.Rows.Add(dr) : dr = dt.NewRow : dr("State") = "OK" : dt.Rows.Add(dr)
        dr = dt.NewRow : dr("State") = "OR" : dt.Rows.Add(dr) : dr = dt.NewRow : dr("State") = "PA" : dt.Rows.Add(dr) : dr = dt.NewRow : dr("State") = "PR" : dt.Rows.Add(dr)
        dr = dt.NewRow : dr("State") = "RI" : dt.Rows.Add(dr) : dr = dt.NewRow : dr("State") = "SC" : dt.Rows.Add(dr) : dr = dt.NewRow : dr("State") = "SD" : dt.Rows.Add(dr)
        dr = dt.NewRow : dr("State") = "TN" : dt.Rows.Add(dr) : dr = dt.NewRow : dr("State") = "TX" : dt.Rows.Add(dr) : dr = dt.NewRow : dr("State") = "UT" : dt.Rows.Add(dr)
        dr = dt.NewRow : dr("State") = "VI" : dt.Rows.Add(dr) : dr = dt.NewRow : dr("State") = "VA" : dt.Rows.Add(dr) : dr = dt.NewRow : dr("State") = "WA" : dt.Rows.Add(dr)
        dr = dt.NewRow : dr("State") = "WV" : dt.Rows.Add(dr) : dr = dt.NewRow : dr("State") = "WI" : dt.Rows.Add(dr) : dr = dt.NewRow : dr("State") = "WY" : dt.Rows.Add(dr)


        Return dt

    End Function

    Public Function GetPlayersReport() As DataTable
        Try

            Dim adpPlayersReport As New PlayersTableAdapter
            Dim tblPlayers As PlayersDataTable = adpPlayersReport.GetData

            Return tblPlayers

        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GetPReportByID(ByVal strPlayerID As String) As DataTable
        Try

            Dim adpPReport As New PlayersTableAdapter
            Dim tblPlayers As PlayersDataTable = adpPReport.GetDataByPlayerID(strPlayerID)

            Return tblPlayers

        Catch ex As Exception
            Throw
        End Try
    End Function

    'Public Function GetPlayerID() As Integer

    '    Dim adpGetPlayerID As New GetPlayerIDTableAdapter
    '    Try
    '        Dim tblGetPlayerID As GetPlayerIDDataTable = adpGetPlayerID.GetData
    '        Dim row As GetPlayerIDRow = tblGetPlayerID(0)

    '        Return row.PlayerID

    '    Catch ex As Exception

    '    End Try

    'End Function
    Public Sub UpdatePlayer(ByVal thisPlayer As clsPlayers)


        Dim adpPlayer As New PlayersTableAdapter


        Try

            With thisPlayer

                adpPlayer.UpdateQuery(.FirstN, .LastN, .Address, .City, .State, .Zip, .Phone, .Email, .origPlayerID)
            End With




        Catch ex As Exception
            Throw
        End Try

    End Sub

    Public Function AddPlayer(ByVal thisPlayer As clsPlayers) As Integer

        Dim adpPlayer As New PlayersTableAdapter
        Dim adpGetPlayerID As New GetPlayerIDTableAdapter

        'Dim tblPlayer As PlayersDataTable = New PlayersDataTable()
        'PlayerID = False

        Try

            With thisPlayer
                adpPlayer.InsertQuery(.FirstN, .LastN, .Address, .City, .State, .Zip, .Phone, .Email)
            End With

            Dim tblGetPlayerID As GetPlayerIDDataTable = adpGetPlayerID.GetData
            Dim row As GetPlayerIDRow = tblGetPlayerID(0)
            Return row.PlayerID

        Catch ex As Exception
            Throw
        End Try

    End Function


    Public Sub DeletePlayer(ByVal thisPlayer As clsPlayers)
        Dim adpPlayer As PlayersTableAdapter = New PlayersTableAdapter()

        Try

            If True Then
                Dim withBlock = thisPlayer
                adpPlayer.Delete(withBlock.PlayerID)
            End If

        Catch ex As Exception
            Throw
        End Try

    End Sub
End Class
