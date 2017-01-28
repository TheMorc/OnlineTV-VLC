Imports System.Xml
' Form1 aka the tv form...
' this is main form without controls.
' and this is the main source code.
' use this source code with caution..
' i am not responsible for any errors that you can make when editing this sourcecode
' made in 2010 > switched to VB comunnity 2015 cuz to uploading to github :F
' Morc 2017
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
        con.type("playing " + nazov)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ovladac.Visible = True
        If My.Settings.firstrun = True Then
            Form2.Show()
        End If
        Label5.Text = "ver " + ver
        jazyk()
        con.type("loaded tv form")
    End Sub

    Public Sub jazyk()
        If My.Settings.lang = "Slovak" Then
            Dim doc As New XmlDocument
            doc.Load("languages.xml")
            For Each atribut As XmlElement In doc.DocumentElement.GetElementsByTagName("slovak")
                ' Google translator translates attribute to slovak as atribút, interesting...
                Label11.Text = citajxml(atribut, "transtxt")
                Label10.Text = citajxml(atribut, "langtxt")
                Label7.Text = citajxml(atribut, "settxt")
                Button13.Text = citajxml(atribut, "resetbtn")
                ovladac.Label1.Text = citajxml(atribut, "turnontxt")
                con.type("changed language to slovak")
            Next atribut
        End If
        If My.Settings.lang = "English" Then
            Dim doc As New XmlDocument
            doc.Load("languages.xml")
            For Each atribut As XmlElement In doc.DocumentElement.GetElementsByTagName("english")
                ' Google translator translates attribute to slovak as atribút, interesting...
                Label11.Text = citajxml(atribut, "transtxt")
                Label10.Text = citajxml(atribut, "langtxt")
                Label7.Text = citajxml(atribut, "settxt")
                Button13.Text = citajxml(atribut, "resetbtn")
                ovladac.Label1.Text = citajxml(atribut, "turnontxt")
                con.type("changed language to english")
            Next atribut
        End If
        If My.Settings.lang = "Czech" Then
            Dim doc As New XmlDocument
            doc.Load("languages.xml")
            For Each atribut As XmlElement In doc.DocumentElement.GetElementsByTagName("czech")
                ' Google translator translates attribute to slovak as atribút, interesting...
                Label11.Text = citajxml(atribut, "transtxt")
                Label10.Text = citajxml(atribut, "langtxt")
                Label7.Text = citajxml(atribut, "settxt")
                Button13.Text = citajxml(atribut, "resetbtn")
                ovladac.Label1.Text = citajxml(atribut, "turnontxt")
                con.type("changed language to czech")
            Next atribut
        End If
    End Sub


    Private Function citajxml(ByVal node As XmlNode, ByVal attibutename As String) As String
        Dim ret As String = String.Empty
        If node IsNot Nothing AndAlso node.Attributes IsNot Nothing Then
            Dim attrib As XmlNode = node.Attributes.GetNamedItem(attibutename)
            If attrib IsNot Nothing Then
                ret = attrib.Value
            End If
        End If
        Return ret
    End Function 'GetAttibuteValue

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Panel1.Visible = False
        Timer3.Stop()
    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        Panel5.Visible = False
        Timer4.Stop()
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Label8.Font = New Font("Segoe UI", 27.75, FontStyle.Bold)
        Timer6.Start()
        Timer5.Stop()
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        Label8.Font = New Font("Segoe UI", 27.75, FontStyle.Regular)
        Timer6.Stop()
    End Sub

    Private Sub Timer8_Tick(sender As Object, e As EventArgs) Handles Timer8.Tick
        Label9.Font = New Font("Segoe UI", 27.75, FontStyle.Regular)
        Timer8.Stop()
    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        Label9.Font = New Font("Segoe UI", 27.75, FontStyle.Bold)
        Timer8.Start()
        Timer7.Stop()
    End Sub

    Private Sub Timer12_Tick(sender As Object, e As EventArgs) Handles Timer12.Tick
        Label13.Font = New Font("Segoe UI", 27.75, FontStyle.Regular)
        Timer12.Stop()
    End Sub

    Private Sub Timer11_Tick(sender As Object, e As EventArgs) Handles Timer11.Tick
        Label13.Font = New Font("Segoe UI", 27.75, FontStyle.Bold)
        Timer12.Start()
        Timer11.Stop()
    End Sub

    Private Sub Timer10_Tick(sender As Object, e As EventArgs) Handles Timer10.Tick
        Label8.Font = New Font("Segoe UI", 27.75, FontStyle.Regular)
        Timer10.Stop()
    End Sub

    Private Sub Timer9_Tick(sender As Object, e As EventArgs) Handles Timer9.Tick
        Label14.Font = New Font("Segoe UI", 27.75, FontStyle.Bold)
        Timer10.Start()
        Timer9.Stop()
    End Sub
End Class
