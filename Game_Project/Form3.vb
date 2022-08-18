Imports MySql.Data.MySqlClient
Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label5.Text = Form1.TextBox1.Text
        start()
        Koneksi()

    End Sub

    '' dim score
    Dim score As Integer = 0
    Dim speed As Integer = 0
    ''sub start game

    Sub start()
        score = 0
        peggi.Location = New Point(147, 270)
        ob1.Location = New Point(885, 291)
        obstacel.Location = New Point(885, 291)
        peggi.Visible = True
        ob1.Visible = True
        obstacel.Visible = True
        tmrjump.Start()
        tmrScore.Start()
        tmrObstacle.Start()
        tmrObstacle.Interval = 100
    End Sub

    Sub insertdata()
        Conn.Open()
        Dim inputdata As String
        inputdata = "insert into tb_leaderboard values('""','" & Form1.TextBox1.Text & "','" & speed & "','" & score & "')"
        cmd = New MySqlCommand(inputdata, Conn)
        cmd.ExecuteNonQuery()
        Conn.Close()
    End Sub

    Sub gameover()
        insertdata()
        tmrjump.Stop()
        tmrScore.Stop()
        tmrObstacle.Stop()
        MsgBox("Game Over")
        MsgBox("Your Score is " & Val(score))
        score = 0
        speed = 0
        Me.Close()
        Form1.Show()
        Form1.bgsound()
    End Sub


    ''timer for score
    Private Sub tmrScore_Tick(sender As Object, e As EventArgs) Handles tmrScore.Tick
        score = score + 1
        Label4.Text = score
        tmrScore.Interval = 5

        If score = 100 Then
            speed = 1
            tmrObstacle.Interval = 100

        ElseIf score = 500 Then
            speed = 2
            tmrObstacle.Interval = 90

        ElseIf score = 1000 Then
            speed = 3
            tmrObstacle.Interval = 80

        ElseIf score = 1500 Then
            tmrObstacle.Interval = 70
            speed = 4

        ElseIf score = 2000 Then
            tmrObstacle.Interval = 60
            speed = 5

        ElseIf score = 3000 Then
            tmrObstacle.Interval = 50
            speed = 6

        ElseIf score = 4000 Then
            tmrObstacle.Interval = 40
            speed = 7

        ElseIf score = 6000 Then
            tmrObstacle.Interval = 30
            speed = 8

        ElseIf score = 8000 Then
            tmrObstacle.Interval = 20
            speed = 9
        End If

        Label3.Text = speed
    End Sub

    Private Sub tmrJump_Tick_1(sender As Object, e As EventArgs) Handles tmrjump.Tick

        Static intOldTop As Integer
        Static intCounter As Integer
        Dim intStep As Integer = 10

        If intCounter = 0 Then
            intOldTop = peggi.Top
        End If


        intCounter += 1

        Select Case intCounter
            Case 1 To 25
                peggi.Top -= intStep
            Case 26 To 50
                peggi.Top += intStep
            Case Else
                peggi.Top = intOldTop
                intCounter = 0
                tmrjump.Stop()
        End Select

    End Sub

    '' sub collision
    Sub CollisionDetect()
        If peggi.Bounds.IntersectsWith(ob1.Bounds) Then
            My.Computer.Audio.Play(My.Resources.mixkit_cartoon_failure_piano_473, AudioPlayMode.Background)
            gameover()
        End If
    End Sub

    Private Sub tmrObstacle_Tick(sender As Object, e As EventArgs) Handles tmrObstacle.Tick

        If (ob1.Left + ob1.Width) <= 0 Then
            ob1.Left = Me.Width
        End If
        ob1.Left = ob1.Left - 70

        If (obstacel.Left + obstacel.Width) <= 0 Then
            obstacel.Left = Me.Width
        End If
        obstacel.Left = obstacel.Left - 70

        CollisionDetect()
    End Sub


    Private Sub Button1_KeyDown(sender As Object, e As KeyEventArgs) Handles Button1.KeyDown
        If e.KeyCode = Keys.Space Then
            tmrjump.Start()
            Me.tmrjump.Interval = 1
            My.Computer.Audio.Play(My.Resources.mixkit_video_game_spin_jump_2648, AudioPlayMode.Background)
        ElseIf e.KeyCode = Keys.P Then
            tmrjump.Stop()
            tmrScore.Stop()
            tmrObstacle.Stop()
            MsgBox("GAME PAUSED, PILIH OK UNTUK LANJUT")
            tmrjump.Start()
            tmrScore.Start()
            tmrObstacle.Start()

        End If
    End Sub
End Class