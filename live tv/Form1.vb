Public Class Form1
    Dim drag As Boolean
    Public channel = "1"
    Dim mysz As Integer
    Public cislos
    Public nazovs
    Dim mys As Integer
    Public ver = "1.4"
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True
        mys = Windows.Forms.Cursor.Position.X - Me.Left
        mysz = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub
    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mysz
            Me.Left = Windows.Forms.Cursor.Position.X - mys
        End If
    End Sub
    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Panel2.Visible = False
        Timer1.Stop()
    End Sub

    Public Sub prehraj(ByVal cislo As String, ByVal nazov As String, ByVal adresa As String)
        Label1.Text = cislo
        Label2.Text = nazov
        cislos = cislo
        nazovs = nazov
        Panel2.Visible = True
        Timer1.Start()
        AxVLCPlugin21.playlist.stop()
        AxVLCPlugin21.playlist.items.clear()
        AxVLCPlugin21.playlist.add(adresa)
        AxVLCPlugin21.playlist.play()
        channel = cislo
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ovladac.Visible = True
        If My.Settings.firstrun = True Then
            Form2.Show()
        End If
        Label1.Text = "ver " + ver
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Panel1.Visible = False
        Timer3.Stop()
    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        Panel5.Visible = False
        Timer4.Stop()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click

        My.Settings.firstrun = True
        My.Settings.Save()
    End Sub
End Class
