Public Class fromMaze

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()


        movetoStart()


        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub finishPoint_MouseEnter(sender As Object, e As EventArgs) Handles finishPoint.MouseEnter

        Dim path As String = AppDomain.CurrentDomain.BaseDirectory


        Dim path1 As String = path.Replace("\bin\Debug\", "\musics\")


        Me.AxWindowsMediaPlayer1.URL = path1 & "Maid with the Flaxen Hair.mp3"
        MessageBox.Show("Great!!!")


        Close()
    End Sub



    Sub movetoStart()

        Dim startingPoint = Panel1.Location
        startingPoint.Offset(10, 10)
        Cursor.Position = PointToScreen(startingPoint)

    End Sub

























  




    Private Sub wallEnter(sender As Object, e As EventArgs) Handles Label1.MouseEnter, Label9.MouseEnter, Label8.MouseEnter, Label7.MouseEnter, Label6.MouseEnter, Label5.MouseEnter, Label4.MouseEnter, Label39.MouseEnter, Label38.MouseEnter, Label37.MouseEnter, Label36.MouseEnter, Label35.MouseEnter, Label34.MouseEnter, Label33.MouseEnter, Label32.MouseEnter, Label31.MouseEnter, Label30.MouseEnter, Label3.MouseEnter, Label29.MouseEnter, Label28.MouseEnter, Label27.MouseEnter, Label26.MouseEnter, Label25.MouseEnter, Label24.MouseEnter, Label23.MouseEnter, Label22.MouseEnter, Label21.MouseEnter, Label20.MouseEnter, Label2.MouseEnter, Label19.MouseEnter, Label18.MouseEnter, Label15.MouseEnter, Label14.MouseEnter, Label13.MouseEnter, Label12.MouseEnter, Label10.MouseEnter
        movetoStart()
    End Sub

   




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'OpenFileDialog1.ShowDialog()
        'MessageBox.Show(OpenFileDialog1.FileName)
        'Me.AxWindowsMediaPlayer1.URL = (OpenFileDialog1.FileName)
        ' Me.AxWindowsMediaPlayer1.URL = "C:\Users\Public\Music\Sample Music\Kalimba.mp3"



        Dim path As String = AppDomain.CurrentDomain.BaseDirectory


        Dim path1 As String = path.Replace("\bin\Debug\", "\musics\")

        MessageBox.Show(path & vbCrLf & path1)

    End Sub

    Private Sub fromMaze_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Me.AxWindowsMediaPlayer1.URL = "C:\Users\Public\Music\Sample Music\Kalimba.mp3"
    End Sub
End Class
