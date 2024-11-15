Imports MySql.Data.MySqlClient
Public Class Form1
    Dim query As String
    Dim tableInfo As DataTable
    Dim da As MySqlDataAdapter

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        databaseConnect()


    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        End

    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Try
            query = "SELECT * FROM vehicleInfo"
            da = New MySqlDataAdapter(query, datacon)
            tableInfo = New DataTable
            da.Fill(tableInfo)
            dataRecord.DataSource = tableInfo
            dataRecord.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            datacon.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            datacon.Close()
        End Try
    End Sub

    Private Sub dataRecord_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataRecord.CellContentClick

    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class
