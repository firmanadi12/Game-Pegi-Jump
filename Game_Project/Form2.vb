Imports MySql.Data.MySqlClient
Public Class Form2


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi()
        tampildata()
    End Sub

    Sub tampildata()
        da = New MySqlDataAdapter("select username,speed,score from tb_leaderboard order by score desc", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tb_leaderboard")
        Me.DataGridView1.DataSource = (ds.Tables("tb_leaderboard"))
    End Sub
End Class