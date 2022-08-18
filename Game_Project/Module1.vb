Imports MySql.Data.MySqlClient
Module Module1
    Public Conn As MySqlConnection
    Public cmd As MySqlCommand
    Public ds As DataSet
    Public da As MySqlDataAdapter
    Public rdr As MySqlDataReader
    Public db As String


    Public Sub Koneksi()
        db = "Server=localhost;user id=root;password=;database=db_game;Convert Zero Datetime=true"
        Conn = New MySqlConnection(db)
    End Sub



End Module