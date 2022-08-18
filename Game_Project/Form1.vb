

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bgsound()
    End Sub

    Public Sub bgsound()
        My.Computer.Audio.Play(My.Resources.mixkit_summer_fun_13, AudioPlayMode.BackgroundLoop)
    End Sub

    Sub audiostop()
        My.Computer.Audio.Stop()

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Please fill the username")
            TextBox1.Focus()
        Else
            Form3.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Form2.ShowDialog()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CheckBox1.Text = "Music On"
            audiostop()
        Else
            CheckBox1.Text = "Music Off"
            bgsound()

        End If
    End Sub
End Class
