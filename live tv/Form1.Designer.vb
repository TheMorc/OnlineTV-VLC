<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim WebPreferences1 As Awesomium.Core.WebPreferences = New Awesomium.Core.WebPreferences(True)
        Me.AxVLCPlugin21 = New AxAXVLC.AxVLCPlugin2()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.WebSessionProvider1 = New Awesomium.Windows.Forms.WebSessionProvider(Me.components)
        Me.awebrow = New Awesomium.Windows.Forms.WebControl(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer6 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer7 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer8 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer9 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer10 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer11 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer12 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.AxVLCPlugin21, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.SuspendLayout()
        '
        'AxVLCPlugin21
        '
        Me.AxVLCPlugin21.Enabled = True
        Me.AxVLCPlugin21.Location = New System.Drawing.Point(36, 21)
        Me.AxVLCPlugin21.Name = "AxVLCPlugin21"
        Me.AxVLCPlugin21.OcxState = CType(resources.GetObject("AxVLCPlugin21.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxVLCPlugin21.Size = New System.Drawing.Size(1192, 685)
        Me.AxVLCPlugin21.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 750
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.livetv_morc.My.Resources.Resources.panel
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(93, 42)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(185, 52)
        Me.Panel2.TabIndex = 2
        Me.Panel2.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(63, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "CETV"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.livetv_morc.My.Resources.Resources.channelicon1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(63, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(62, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "1"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.livetv_morc.My.Resources.Resources.CrackedScreen1440x900_001
        Me.PictureBox2.Location = New System.Drawing.Point(37, 21)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1191, 685)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.livetv_morc.My.Resources.Resources.panel
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(571, 590)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(122, 55)
        Me.Panel1.TabIndex = 6
        Me.Panel1.Visible = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semilight", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 55)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "16:9"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer3
        '
        Me.Timer3.Interval = 5000
        '
        'WebSessionProvider1
        '
        WebPreferences1.Databases = True
        WebPreferences1.EnableGPUAcceleration = True
        WebPreferences1.JavascriptViewChangeSource = False
        WebPreferences1.JavascriptViewEvents = False
        WebPreferences1.JavascriptViewExecute = False
        WebPreferences1.SmoothScrolling = True
        WebPreferences1.UniversalAccessFromFileURL = True
        WebPreferences1.WebGL = True
        Me.WebSessionProvider1.Preferences = WebPreferences1
        Me.WebSessionProvider1.Views.Add(Me.awebrow)
        '
        'awebrow
        '
        Me.awebrow.BackColor = System.Drawing.Color.Magenta
        Me.awebrow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.awebrow.Location = New System.Drawing.Point(0, 0)
        Me.awebrow.Size = New System.Drawing.Size(1191, 685)
        Me.awebrow.Source = New System.Uri("http://google.com/", System.UriKind.Absolute)
        Me.awebrow.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.awebrow)
        Me.Panel3.Location = New System.Drawing.Point(37, 21)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1191, 685)
        Me.Panel3.TabIndex = 7
        Me.Panel3.Visible = False
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = Global.livetv_morc.My.Resources.Resources.panel
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Controls.Add(Me.Button12)
        Me.Panel4.Controls.Add(Me.Button11)
        Me.Panel4.Controls.Add(Me.Button10)
        Me.Panel4.Controls.Add(Me.Button9)
        Me.Panel4.Controls.Add(Me.Button8)
        Me.Panel4.Controls.Add(Me.Button7)
        Me.Panel4.Controls.Add(Me.Button6)
        Me.Panel4.Controls.Add(Me.Button5)
        Me.Panel4.Controls.Add(Me.Button4)
        Me.Panel4.Controls.Add(Me.Button3)
        Me.Panel4.Controls.Add(Me.Button2)
        Me.Panel4.Controls.Add(Me.Button1)
        Me.Panel4.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(93, 44)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1079, 537)
        Me.Panel4.TabIndex = 8
        Me.Panel4.Visible = False
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.White
        Me.Button12.Enabled = False
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Font = New System.Drawing.Font("Segoe UI Semilight", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.Location = New System.Drawing.Point(294, 201)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(285, 60)
        Me.Button12.TabIndex = 11
        Me.Button12.Text = "12 Elektrika.tv"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.White
        Me.Button11.Enabled = False
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Font = New System.Drawing.Font("Segoe UI Semilight", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.Location = New System.Drawing.Point(294, 135)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(285, 60)
        Me.Button11.TabIndex = 10
        Me.Button11.Text = "11 RETRO"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.White
        Me.Button10.Enabled = False
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Segoe UI Semilight", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(294, 69)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(285, 60)
        Me.Button10.TabIndex = 9
        Me.Button10.Text = "10 CT 2"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.White
        Me.Button9.Enabled = False
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Segoe UI Semilight", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(294, 3)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(285, 60)
        Me.Button9.TabIndex = 8
        Me.Button9.Text = "9 CT 1"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.White
        Me.Button8.Enabled = False
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Segoe UI Semilight", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(3, 465)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(285, 60)
        Me.Button8.TabIndex = 7
        Me.Button8.Text = "8 SLAGR TV"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.White
        Me.Button7.Enabled = False
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Segoe UI Semilight", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(3, 399)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(285, 60)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "7 TV LUX"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.White
        Me.Button6.Enabled = False
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Segoe UI Semilight", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(3, 333)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(285, 60)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "6 TV JOJ"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.Enabled = False
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Segoe UI Semilight", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(3, 267)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(285, 60)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "5 MARKIZA"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.Enabled = False
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Segoe UI Semilight", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(3, 201)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(285, 60)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "4 TA3"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Enabled = False
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI Semilight", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(3, 135)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(285, 60)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "3 CETV"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Enabled = False
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Semilight", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(3, 69)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(285, 60)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "2 DVOJKA"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button1.Enabled = False
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semilight", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(285, 60)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "1 JEDNOTKA"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackgroundImage = Global.livetv_morc.My.Resources.Resources.panel
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Location = New System.Drawing.Point(632, 43)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(540, 52)
        Me.Panel5.TabIndex = 6
        Me.Panel5.Visible = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel6.Controls.Add(Me.PictureBox3)
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Location = New System.Drawing.Point(3, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(534, 46)
        Me.Panel6.TabIndex = 6
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.livetv_morc.My.Resources.Resources.mute
        Me.PictureBox3.Location = New System.Drawing.Point(237, -3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(61, 52)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Lime
        Me.Panel7.Controls.Add(Me.Label4)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(29, 46)
        Me.Panel7.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semilight", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(0, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 37)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "0"
        '
        'Timer4
        '
        Me.Timer4.Interval = 5000
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Transparent
        Me.Panel8.Location = New System.Drawing.Point(559, 706)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(177, 35)
        Me.Panel8.TabIndex = 10
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(580, 706)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(100, 74)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 9
        Me.PictureBox4.TabStop = False
        '
        'Panel9
        '
        Me.Panel9.BackgroundImage = Global.livetv_morc.My.Resources.Resources.panel
        Me.Panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel9.Controls.Add(Me.Label13)
        Me.Panel9.Controls.Add(Me.Label14)
        Me.Panel9.Controls.Add(Me.Button15)
        Me.Panel9.Controls.Add(Me.Label11)
        Me.Panel9.Controls.Add(Me.Label10)
        Me.Panel9.Controls.Add(Me.Label9)
        Me.Panel9.Controls.Add(Me.Label8)
        Me.Panel9.Controls.Add(Me.Button14)
        Me.Panel9.Controls.Add(Me.Label7)
        Me.Panel9.Controls.Add(Me.Button13)
        Me.Panel9.Controls.Add(Me.Panel10)
        Me.Panel9.Controls.Add(Me.Label5)
        Me.Panel9.Controls.Add(Me.Label12)
        Me.Panel9.Location = New System.Drawing.Point(93, 44)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1079, 537)
        Me.Panel9.TabIndex = 1
        Me.Panel9.Visible = False
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(523, 204)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(36, 60)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = ">"
        Me.Label13.UseCompatibleTextRendering = True
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(201, 204)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(36, 60)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "<"
        Me.Label14.UseCompatibleTextRendering = True
        '
        'Button15
        '
        Me.Button15.BackColor = System.Drawing.Color.White
        Me.Button15.Enabled = False
        Me.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button15.Font = New System.Drawing.Font("Segoe UI Semilight", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button15.Location = New System.Drawing.Point(238, 204)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(285, 60)
        Me.Button15.TabIndex = 16
        Me.Button15.Text = "✓"
        Me.Button15.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(549, 135)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(512, 60)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Translator:"
        Me.Label11.UseCompatibleTextRendering = True
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semilight", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(0, 139)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(205, 51)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Language:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(524, 135)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 60)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = ">"
        Me.Label9.UseCompatibleTextRendering = True
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(202, 135)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 60)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "<"
        Me.Label8.UseCompatibleTextRendering = True
        '
        'Button14
        '
        Me.Button14.BackColor = System.Drawing.Color.White
        Me.Button14.Enabled = False
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button14.Font = New System.Drawing.Font("Segoe UI Semilight", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.Location = New System.Drawing.Point(238, 135)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(285, 60)
        Me.Button14.TabIndex = 10
        Me.Button14.Text = "English"
        Me.Button14.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semilight", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(0, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(228, 51)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Settings:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button13.Enabled = False
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.Font = New System.Drawing.Font("Segoe UI Semilight", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.Location = New System.Drawing.Point(238, 65)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(285, 60)
        Me.Button13.TabIndex = 8
        Me.Button13.Text = "Reset Settings"
        Me.Button13.UseVisualStyleBackColor = False
        '
        'Panel10
        '
        Me.Panel10.BackgroundImage = Global.livetv_morc.My.Resources.Resources.panel
        Me.Panel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel10.Controls.Add(Me.Label6)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel10.Location = New System.Drawing.Point(0, 493)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(1079, 44)
        Me.Panel10.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(245, 42)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "by Morc 2017"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(3, 451)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 42)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "ver."
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semilight", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(1, 185)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(205, 100)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "TopMost:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer5
        '
        Me.Timer5.Interval = 10
        '
        'Timer6
        '
        Me.Timer6.Interval = 500
        '
        'Timer7
        '
        Me.Timer7.Interval = 10
        '
        'Timer8
        '
        Me.Timer8.Interval = 500
        '
        'Timer9
        '
        Me.Timer9.Interval = 10
        '
        'Timer10
        '
        Me.Timer10.Interval = 500
        '
        'Timer11
        '
        Me.Timer11.Interval = 10
        '
        'Timer12
        '
        Me.Timer12.Interval = 500
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.livetv_morc.My.Resources.Resources.tv
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1264, 825)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.AxVLCPlugin21)
        Me.Controls.Add(Me.PictureBox2)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LIVE TV"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Magenta
        CType(Me.AxVLCPlugin21, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AxVLCPlugin21 As AxAXVLC.AxVLCPlugin2
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents WebSessionProvider1 As Awesomium.Windows.Forms.WebSessionProvider
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents awebrow As Awesomium.Windows.Forms.WebControl
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button14 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Button13 As Button
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Timer5 As Timer
    Friend WithEvents Timer6 As Timer
    Friend WithEvents Timer7 As Timer
    Friend WithEvents Timer8 As Timer
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Button15 As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Timer9 As Timer
    Friend WithEvents Timer10 As Timer
    Friend WithEvents Timer11 As Timer
    Friend WithEvents Timer12 As Timer
End Class
