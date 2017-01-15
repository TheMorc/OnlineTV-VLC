Public Class ovladac
    Dim drag As Boolean
    Dim volume = 50
    Dim mousex As Integer
    Dim muted = False
    Dim mousey As Integer
    Dim osdvolume = 50
    Dim turned = False
    Public Sub setprogress(ByVal num As Long)
        Dim propprogress1 As Long = num * Form1.Panel6.Width
        Form1.Panel7.Width = propprogress1 / 200

    End Sub
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub
    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub
    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If turned = False Then
            turned = True
            tlacitka()
        Else
            turned = False
            tlacitka()
        End If
        Form1.AxVLCPlugin21.playlist.stop()
        Form1.PictureBox2.Visible = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form1.prehraj("1", "JEDNOTKA", "http://www.spusti.net/live/?id=101_7114487525752.m3u8")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form1.prehraj("2", "DVOJKA", "http://live.tvlux.sk:1935/lux/lux.stream_360p/playlist.m3u8")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Form1.prehraj("3", "CETV", "rtmp://62.197.236.3/livepkgr/cetv")
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Form1.prehraj("4", "TA3", "http://88.212.15.9:5000/live/ta3_1200/playlist_key_url.m3u8")
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Form1.prehraj("5", "MARKIZA", "http://213.81.153.243/live003/channel003_p5.stream/DVR.m3u8")
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Form1.prehraj("6", "TV JOJ", "http://88.212.15.9:5000/live/joj_1200/playlist_key_url.m3u8")
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Form1.prehraj("7", "TV LUX", "http://live.tvlux.sk:1935/lux/lux.stream_360p/playlist.m3u8")
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Form1.prehraj("8", "SLAGR TV", "http://88.212.15.9:5000/live/slagr/playlist_key_url.m3u8")
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Form1.prehraj("9", "CT1", "http://www.spusti.net/live/?id=3_211321411656.m3u8")
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form1.prehraj("10", "CT2", "http://www.spusti.net/live/?id=4_281761882208.m3u8")
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form1.prehraj("11", "RETRO", "http://stream.mediawork.cz/retrotv/retrotvHQ1/playlist.m3u8")
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Form1.PictureBox2.Visible = True
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        If muted = True Then
            muted = False
            Form1.PictureBox3.Visible = False
            Form1.AxVLCPlugin21.volume = osdvolume + 1
            Form1.Panel7.BackColor = Color.Lime
        Else
            Form1.Panel5.Visible = True
            Form1.Timer4.Start()
            Form1.AxVLCPlugin21.volume = Form1.AxVLCPlugin21.volume + 1
            setprogress(Form1.AxVLCPlugin21.volume)
            volume = Form1.AxVLCPlugin21.volume
            muted = False
            osdvolume = Form1.AxVLCPlugin21.volume
            Form1.Label4.Text = osdvolume
        End If

    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        If muted = True Then
            muted = False
            Form1.PictureBox3.Visible = False
            Form1.AxVLCPlugin21.volume = osdvolume + 1
            Form1.Panel7.BackColor = Color.Lime
        Else
            Form1.Panel5.Visible = True
            Form1.Timer4.Start()
            Form1.AxVLCPlugin21.volume = Form1.AxVLCPlugin21.volume - 1
            setprogress(Form1.AxVLCPlugin21.volume)
            volume = Form1.AxVLCPlugin21.volume
            muted = False
            osdvolume = Form1.AxVLCPlugin21.volume
            Form1.Label4.Text = osdvolume
        End If
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        If Form1.Panel4.Visible = True Then
        Else

            If Form1.channel = 1 Then
                Form1.prehraj("1", "JEDNOTKA", "http://www.spusti.net/live/?id=101_7114487525752.m3u8")
            ElseIf Form1.channel = 2 Then
                Form1.prehraj("2", "DVOJKA", "http://live.tvlux.sk:1935/lux/lux.stream_360p/playlist.m3u8")
            ElseIf Form1.channel = 3 Then
                Form1.prehraj("3", "CETV", "rtmp://62.197.236.3/livepkgr/cetv")
            ElseIf Form1.channel = 4 Then
                Form1.prehraj("4", "TA3", "http://88.212.15.9:5000/live/ta3_1200/playlist_key_url.m3u8")
            ElseIf Form1.channel = 5 Then
                Form1.prehraj("5", "MARKIZA", "http://213.81.153.243/live003/channel003_p5.stream/DVR.m3u8")
            ElseIf Form1.channel = 6 Then
                Form1.prehraj("6", "TV JOJ", "http://88.212.15.9:5000/live/joj_1200/playlist_key_url.m3u8")
            ElseIf Form1.channel = 7 Then
                Form1.prehraj("7", "TV LUX", "http://live.tvlux.sk:1935/lux/lux.stream_360p/playlist.m3u8")
            ElseIf Form1.channel = 8 Then
                Form1.prehraj("8", "SLAGR TV", "http://88.212.15.9:5000/live/slagr/playlist_key_url.m3u8")
            ElseIf Form1.channel = 9 Then
                Form1.prehraj("9", "CT1", "http://www.spusti.net/live/?id=3_211321411656.m3u8")
            ElseIf Form1.channel = 10 Then
                Form1.prehraj("10", "CT2", "http://www.spusti.net/live/?id=4_281761882208.m3u8")
            ElseIf Form1.channel = 11 Then
                Form1.prehraj("11", "RETRO", "http://stream.mediawork.cz/retrotv/retrotvHQ1/playlist.m3u8")
            ElseIf Form1.channel = 12 Then
                Form1.prehraj("12", "ELEKTRIKA.TV", "rtmp://rtmp.elektrika.cz/live/myStream.sdp")
            End If
            Form1.channel = Form1.channel + 1
        End If
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        If Form1.Panel4.Visible = True Then

        Else
            If Form1.channel = 1 Then
                Form1.prehraj("1", "JEDNOTKA", "http://www.spusti.net/live/?id=101_7114487525752.m3u8")
            ElseIf Form1.channel = 2 Then
                Form1.prehraj("2", "DVOJKA", "http://live.tvlux.sk:1935/lux/lux.stream_360p/playlist.m3u8")
            ElseIf Form1.channel = 3 Then
                Form1.prehraj("3", "CETV", "rtmp://62.197.236.3/livepkgr/cetv")
            ElseIf Form1.channel = 4 Then
                Form1.prehraj("4", "TA3", "http://88.212.15.9:5000/live/ta3_1200/playlist_key_url.m3u8")
            ElseIf Form1.channel = 5 Then
                Form1.prehraj("5", "MARKIZA", "http://213.81.153.243/live003/channel003_p5.stream/DVR.m3u8")
            ElseIf Form1.channel = 6 Then
                Form1.prehraj("6", "TV JOJ", "http://88.212.15.9:5000/live/joj_1200/playlist_key_url.m3u8")
            ElseIf Form1.channel = 7 Then
                Form1.prehraj("7", "TV LUX", "http://live.tvlux.sk:1935/lux/lux.stream_360p/playlist.m3u8")
            ElseIf Form1.channel = 8 Then
                Form1.prehraj("8", "SLAGR TV", "http://88.212.15.9:5000/live/slagr/playlist_key_url.m3u8")
            ElseIf Form1.channel = 9 Then
                Form1.prehraj("9", "CT1", "http://www.spusti.net/live/?id=3_211321411656.m3u8")
            ElseIf Form1.channel = 10 Then
                Form1.prehraj("10", "CT2", "http://www.spusti.net/live/?id=4_281761882208.m3u8")
            ElseIf Form1.channel = 11 Then
                Form1.prehraj("11", "RETRO", "http://stream.mediawork.cz/retrotv/retrotvHQ1/playlist.m3u8")
            ElseIf Form1.channel = 12 Then
                Form1.prehraj("12", "ELEKTRIKA.TV", "rtmp://rtmp.elektrika.cz/live/myStream.sdp")
            End If
            Form1.channel = Form1.channel - 1
        End If
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        Form1.Panel5.Visible = True
        Form1.Timer4.Start()
        If muted = False Then
            Form1.AxVLCPlugin21.volume = 0
            Form1.PictureBox3.Visible = True
            Form1.Panel7.BackColor = Color.LightGray
            muted = True
        Else
            Form1.AxVLCPlugin21.volume = volume
            osdvolume = Form1.AxVLCPlugin21.volume
            setprogress(volume)
            Form1.Panel7.BackColor = Color.Lime
            muted = False
            Form1.PictureBox3.Visible = False
        End If

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Form1.Label4.Left = Form1.Panel7.Width / 2 - 9

    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        Form1.Panel1.Visible = True
        Form1.Timer3.Start()
        If Form1.Label3.Text = "16:9" Then
            Form1.AxVLCPlugin21.video.aspectRatio = "16:10"
            Form1.Label3.Text = "16:10"
        ElseIf Form1.Label3.Text = "16:10" Then
            Form1.AxVLCPlugin21.video.aspectRatio = "4:3"
            Form1.Label3.Text = "4:3"
        ElseIf Form1.Label3.Text = "4:3" Then
            Form1.AxVLCPlugin21.video.aspectRatio = "5:4"
            Form1.Label3.Text = "5:4"
        ElseIf Form1.Label3.Text = "5:4" Then
            Form1.AxVLCPlugin21.video.aspectRatio = "16:9"
            Form1.Label3.Text = "16:9"
        End If
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        If Form1.Panel3.Visible = True Then
            Form1.AxVLCPlugin21.playlist.items.clear()
            Form1.AxVLCPlugin21.playlist.stop()
            Form1.Panel3.Visible = False
        Else
            Form1.AxVLCPlugin21.playlist.items.clear()
            Form1.AxVLCPlugin21.playlist.stop()
            Form1.Panel3.Visible = True
        End If
        If Form1.Panel4.Visible = True Then
            Form1.Panel4.Visible = False
        End If
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        If Form1.Panel3.Visible = True Then
            Form1.awebrow.GoBack()
        End If
    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        If Form1.Panel4.Visible = True Then
            Form1.Panel4.Visible = False
        Else
            Form1.Panel4.Visible = True
        End If
    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        If Form1.Panel4.Visible = True Then
            If Form1.Button1.BackColor = Color.DeepSkyBlue Then
                Form1.Button1.BackColor = Color.White
                Form1.Button12.BackColor = Color.DeepSkyBlue
            ElseIf Form1.Button2.BackColor = Color.DeepSkyBlue Then
                Form1.Button2.BackColor = Color.White
                Form1.Button1.BackColor = Color.DeepSkyBlue
            ElseIf Form1.Button3.BackColor = Color.DeepSkyBlue Then
                Form1.Button3.BackColor = Color.White
                Form1.Button2.BackColor = Color.DeepSkyBlue
            ElseIf Form1.Button4.BackColor = Color.DeepSkyBlue Then
                Form1.Button4.BackColor = Color.White
                Form1.Button3.BackColor = Color.DeepSkyBlue
            ElseIf Form1.Button5.BackColor = Color.DeepSkyBlue Then
                Form1.Button5.BackColor = Color.White
                Form1.Button4.BackColor = Color.DeepSkyBlue
            ElseIf Form1.Button6.BackColor = Color.DeepSkyBlue Then
                Form1.Button6.BackColor = Color.White
                Form1.Button5.BackColor = Color.DeepSkyBlue
            ElseIf Form1.Button7.BackColor = Color.DeepSkyBlue Then
                Form1.Button7.BackColor = Color.White
                Form1.Button6.BackColor = Color.DeepSkyBlue
            ElseIf Form1.Button8.BackColor = Color.DeepSkyBlue Then
                Form1.Button8.BackColor = Color.White
                Form1.Button7.BackColor = Color.DeepSkyBlue
            ElseIf Form1.Button9.BackColor = Color.DeepSkyBlue Then
                Form1.Button9.BackColor = Color.White
                Form1.Button8.BackColor = Color.DeepSkyBlue
            ElseIf Form1.Button10.BackColor = Color.DeepSkyBlue Then
                Form1.Button10.BackColor = Color.White
                Form1.Button9.BackColor = Color.DeepSkyBlue
            ElseIf Form1.Button11.BackColor = Color.DeepSkyBlue Then
                Form1.Button11.BackColor = Color.White
                Form1.Button10.BackColor = Color.DeepSkyBlue
            ElseIf Form1.Button12.BackColor = Color.DeepSkyBlue Then
                Form1.Button12.BackColor = Color.White
                Form1.Button11.BackColor = Color.DeepSkyBlue

            End If
        End If
    End Sub

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        If Form1.Panel4.Visible = True Then
            If Form1.Button1.BackColor = Color.DeepSkyBlue Then
                Form1.Button1.BackColor = Color.White
                Form1.Button2.BackColor = Color.DeepSkyBlue

            ElseIf Form1.Button2.BackColor = Color.DeepSkyBlue Then
                Form1.Button2.BackColor = Color.White
                Form1.Button3.BackColor = Color.DeepSkyBlue
            ElseIf Form1.Button3.BackColor = Color.DeepSkyBlue Then
                Form1.Button3.BackColor = Color.White
                Form1.Button4.BackColor = Color.DeepSkyBlue
            ElseIf Form1.Button4.BackColor = Color.DeepSkyBlue Then
                Form1.Button4.BackColor = Color.White
                Form1.Button5.BackColor = Color.DeepSkyBlue
            ElseIf Form1.Button5.BackColor = Color.DeepSkyBlue Then
                Form1.Button5.BackColor = Color.White
                Form1.Button6.BackColor = Color.DeepSkyBlue
            ElseIf Form1.Button6.BackColor = Color.DeepSkyBlue Then
                Form1.Button6.BackColor = Color.White
                Form1.Button7.BackColor = Color.DeepSkyBlue
            ElseIf Form1.Button7.BackColor = Color.DeepSkyBlue Then
                Form1.Button7.BackColor = Color.White
                Form1.Button8.BackColor = Color.DeepSkyBlue
            ElseIf Form1.Button8.BackColor = Color.DeepSkyBlue Then
                Form1.Button8.BackColor = Color.White
                Form1.Button9.BackColor = Color.DeepSkyBlue
            ElseIf Form1.Button9.BackColor = Color.DeepSkyBlue Then
                Form1.Button9.BackColor = Color.White
                Form1.Button10.BackColor = Color.DeepSkyBlue
            ElseIf Form1.Button10.BackColor = Color.DeepSkyBlue Then
                Form1.Button10.BackColor = Color.White
                Form1.Button11.BackColor = Color.DeepSkyBlue
            ElseIf Form1.Button11.BackColor = Color.DeepSkyBlue Then
                Form1.Button11.BackColor = Color.White
                Form1.Button12.BackColor = Color.DeepSkyBlue
            ElseIf Form1.Button12.BackColor = Color.DeepSkyBlue Then
                Form1.Button12.BackColor = Color.White
                Form1.Button1.BackColor = Color.DeepSkyBlue

            End If
        End If
    End Sub

    Private Sub Button28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button28.Click
        If Form1.Panel4.Visible = True Then
            If Form1.Button1.BackColor = Color.DeepSkyBlue Then
                Form1.prehraj("1", "JEDNOTKA", "http://www.spusti.net/live/?id=101_7114487525752.m3u8")
                Form1.Panel4.Visible = False
            ElseIf Form1.Button2.BackColor = Color.DeepSkyBlue Then
                Form1.prehraj("2", "DVOJKA", "http://live.tvlux.sk:1935/lux/lux.stream_360p/playlist.m3u8")
                Form1.Panel4.Visible = False
            ElseIf Form1.Button3.BackColor = Color.DeepSkyBlue Then
                Form1.prehraj("3", "CETV", "rtmp://62.197.236.3/livepkgr/cetv")
                Form1.Panel4.Visible = False
            ElseIf Form1.Button4.BackColor = Color.DeepSkyBlue Then
                Form1.prehraj("4", "TA3", "http://88.212.15.9:5000/live/ta3_1200/playlist_key_url.m3u8")
                Form1.Panel4.Visible = False
            ElseIf Form1.Button5.BackColor = Color.DeepSkyBlue Then
                Form1.prehraj("5", "MARKIZA", "http://213.81.153.243/live003/channel003_p5.stream/DVR.m3u8")
                Form1.Panel4.Visible = False
            ElseIf Form1.Button6.BackColor = Color.DeepSkyBlue Then
                Form1.prehraj("6", "TV JOJ", "http://88.212.15.9:5000/live/joj_1200/playlist_key_url.m3u8")
                Form1.Panel4.Visible = False
            ElseIf Form1.Button7.BackColor = Color.DeepSkyBlue Then
                Form1.prehraj("7", "TV LUX", "http://live.tvlux.sk:1935/lux/lux.stream_360p/playlist.m3u8")
                Form1.Panel4.Visible = False
            ElseIf Form1.Button8.BackColor = Color.DeepSkyBlue Then
                Form1.prehraj("8", "SLAGR TV", "http://88.212.15.9:5000/live/slagr/playlist_key_url.m3u8")
                Form1.Panel4.Visible = False
            ElseIf Form1.Button9.BackColor = Color.DeepSkyBlue Then
                Form1.prehraj("9", "CT1", "http://www.spusti.net/live/?id=3_211321411656.m3u8")
                Form1.Panel4.Visible = False
            ElseIf Form1.Button10.BackColor = Color.DeepSkyBlue Then
                Form1.prehraj("10", "CT2", "http://www.spusti.net/live/?id=4_281761882208.m3u8")
                Form1.Panel4.Visible = False
            ElseIf Form1.Button11.BackColor = Color.DeepSkyBlue Then
                Form1.prehraj("11", "RETRO", "http://stream.mediawork.cz/retrotv/retrotvHQ1/playlist.m3u8")
                Form1.Panel4.Visible = False
            ElseIf Form1.Button12.BackColor = Color.DeepSkyBlue Then
                Form1.prehraj("12", "ELEKTRIKA.TV", "rtmp://rtmp.elektrika.cz/live/myStream.sdp")
                Form1.Panel4.Visible = False


            End If
        Else
            Form1.Panel4.Visible = True
        End If
    End Sub

    Private Sub Button11_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        If Form1.Panel9.Visible = True Then
            Form1.Panel9.Visible = False
        Else
            Form1.Panel9.Visible = True
        End If
    End Sub

    Private Sub tlacitka()
        Button2.Enabled = turned
        Button3.Enabled = turned
        Button4.Enabled = turned
        Button5.Enabled = turned
        Button6.Enabled = turned
        Button7.Enabled = turned
        Button8.Enabled = turned
        Button9.Enabled = turned
        Button10.Enabled = turned
        Button11.Enabled = turned
        Button13.Enabled = turned
        Button14.Enabled = turned
        Button15.Enabled = turned
        Button16.Enabled = turned
        Button17.Enabled = turned
        Button18.Enabled = turned
        Button19.Enabled = turned
        Button20.Enabled = turned
        Button21.Enabled = turned
        Button22.Enabled = turned
        Button23.Enabled = turned
        Button24.Enabled = turned
        Button25.Enabled = turned
        Button26.Enabled = turned
        Button27.Enabled = turned
        Button28.Enabled = turned
        Form1.PictureBox4.Visible = turned

        Dim textturned As Boolean
        If turned = False Then
            textturned = True
        Else
            textturned = False
        End If
        Label1.Visible = textturned
    End Sub

    Private Sub ovladac_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        turned = False
        tlacitka()
    End Sub

    Private Sub Button1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Button1.KeyDown
        If e.KeyCode = Keys.S AndAlso e.Modifiers = (Keys.Control) Then
            Form1.Label1.Text = "*"
            Form1.Label2.Text = "Desktop"
            Form1.nazovs = "Desktop"
            Form1.cislos = "*"
            Form1.Panel2.Visible = True
            Form1.Timer1.Start()
            Form1.AxVLCPlugin21.playlist.stop()
            Form1.AxVLCPlugin21.playlist.items.clear()
            Dim Options As String() = New String() {":screen-fps=30.000000"}
            Form1.AxVLCPlugin21.playlist.add("screen://", Nothing, Options)
            Form1.AxVLCPlugin21.playlist.play()
            Form1.channel = "*"
        End If

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Form1.Close()
        Close()
    End Sub
End Class