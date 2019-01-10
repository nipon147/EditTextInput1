Public Class timeBomb

    Dim countDownNumber As Integer = 10


    Private Sub timeBomb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        labelMsg.Text = ""
        labelContDown.Text = countDownNumber.ToString

        PictureBox2.Image = My.Resources.bomb1
        PictureBox1.Image = My.Resources.bomb2
        PictureBox2.Visible = True
        PictureBox1.Visible = False



        Timer1.Enabled = True




        Dim path As String = AppDomain.CurrentDomain.BaseDirectory


        Dim path1 As String = path.Replace("\bin\Debug\", "\musics\")


        'Me.AxWindowsMediaPlayer1.URL = path1 & "Maid with the Flaxen Hair.mp3"








    End Sub







    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim mynum As String
        mynum = TextBox1.Text.ToString & TextBox2.Text.ToString & TextBox3.Text.ToString

        If mynum.ToString = "787" Then
            labelMsg.Text = "Congretulation"
            labelMsg.ForeColor = Color.Green



            Dim path As String = AppDomain.CurrentDomain.BaseDirectory


            Dim path1 As String = path.Replace("\bin\Debug\", "\musics\")


            Me.AxWindowsMediaPlayer1.URL = path1 & "Maid with the Flaxen Hair.mp3"

            Timer1.Enabled = False


        Else


            labelMsg.Text = "Sorry You Fail ...!!!"
            labelMsg.ForeColor = Color.Red




        End If




    End Sub






    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If countDownNumber = 0 Then
            PictureBox1.Visible = True
            PictureBox2.Visible = False
            Timer1.Enabled = False

            '  Dim path As String = AppDomain.CurrentDomain.BaseDirectory


            '  Dim path1 As String = path.Replace("\bin\Debug\", "\musics\")


            '  Me.AxWindowsMediaPlayer1.URL = path1 & "Maid with the Flaxen Hair.mp3"


        End If



        countDownNumber = countDownNumber - 1
        labelContDown.Text = countDownNumber.ToString









    End Sub









    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        labelMsg.Text = ""
        countDownNumber = 10
        labelContDown.Text = countDownNumber.ToString


        PictureBox1.Visible = False


        Timer1.Enabled = True




        Dim path As String = AppDomain.CurrentDomain.BaseDirectory


        Dim path1 As String = path.Replace("\bin\Debug\", "\musics\")

        AxWindowsMediaPlayer1.Ctlcontrols.stop()





    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        PictureBox2.Visible = False
    End Sub
End Class