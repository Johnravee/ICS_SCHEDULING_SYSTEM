<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Authentication_Form
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Authentication_Form))
        Scan_AuthForm = New Panel()
        lk1register = New LinkLabel()
        Panel1 = New Panel()
        logo = New PictureBox()
        RFIDBOX_Scan = New TextBox()
        ManualLogin_Link = New LinkLabel()
        Label1 = New Label()
        Granted_Access_Logo = New PictureBox()
        Scan_Denied_Logo = New PictureBox()
        ScanRFID_Logo = New PictureBox()
        Scan_Label = New Label()
        ScanMinimize = New PictureBox()
        ScanClose = New PictureBox()
        ManualLoginForm = New Panel()
        lk2register = New LinkLabel()
        Label4 = New Label()
        lkForgot = New LinkLabel()
        Panel5 = New Panel()
        Panel4 = New Panel()
        PictureBox3 = New PictureBox()
        ManualBackBtn = New PictureBox()
        PictureBox4 = New PictureBox()
        ManualMinimize = New PictureBox()
        ManualClose = New PictureBox()
        loginBtn = New Button()
        Label2 = New Label()
        Panel2 = New Panel()
        txtEmail = New TextBox()
        PictureBox1 = New PictureBox()
        PinLoginForm = New Panel()
        delBtn = New PictureBox()
        Panel7 = New Panel()
        PictureBox5 = New PictureBox()
        PictureBox7 = New PictureBox()
        Panel6 = New Panel()
        PinMinimize = New PictureBox()
        Forgot_PIN_Link = New LinkLabel()
        PinClose = New PictureBox()
        Label3 = New Label()
        Button13 = New Button()
        Button9 = New Button()
        Button10 = New Button()
        Button11 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        Button8 = New Button()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        txtpin4 = New TextBox()
        txtpin3 = New TextBox()
        txtpin2 = New TextBox()
        txtpin1 = New TextBox()
        PictureBox2 = New PictureBox()
        timer = New Timer(components)
        Panel3 = New Panel()
        clearInputs = New Timer(components)
        Scan_AuthForm.SuspendLayout()
        CType(logo, ComponentModel.ISupportInitialize).BeginInit()
        CType(Granted_Access_Logo, ComponentModel.ISupportInitialize).BeginInit()
        CType(Scan_Denied_Logo, ComponentModel.ISupportInitialize).BeginInit()
        CType(ScanRFID_Logo, ComponentModel.ISupportInitialize).BeginInit()
        CType(ScanMinimize, ComponentModel.ISupportInitialize).BeginInit()
        CType(ScanClose, ComponentModel.ISupportInitialize).BeginInit()
        ManualLoginForm.SuspendLayout()
        Panel4.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(ManualBackBtn, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(ManualMinimize, ComponentModel.ISupportInitialize).BeginInit()
        CType(ManualClose, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        PinLoginForm.SuspendLayout()
        CType(delBtn, ComponentModel.ISupportInitialize).BeginInit()
        Panel7.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PinMinimize, ComponentModel.ISupportInitialize).BeginInit()
        CType(PinClose, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Scan_AuthForm
        ' 
        Scan_AuthForm.BackColor = Color.FromArgb(CByte(246), CByte(246), CByte(222))
        Scan_AuthForm.Controls.Add(lk1register)
        Scan_AuthForm.Controls.Add(Panel1)
        Scan_AuthForm.Controls.Add(logo)
        Scan_AuthForm.Controls.Add(RFIDBOX_Scan)
        Scan_AuthForm.Controls.Add(ManualLogin_Link)
        Scan_AuthForm.Controls.Add(Label1)
        Scan_AuthForm.Controls.Add(Granted_Access_Logo)
        Scan_AuthForm.Controls.Add(Scan_Denied_Logo)
        Scan_AuthForm.Controls.Add(ScanRFID_Logo)
        Scan_AuthForm.Controls.Add(Scan_Label)
        Scan_AuthForm.Location = New Point(0, 0)
        Scan_AuthForm.Name = "Scan_AuthForm"
        Scan_AuthForm.RightToLeft = RightToLeft.No
        Scan_AuthForm.Size = New Size(436, 485)
        Scan_AuthForm.TabIndex = 0
        ' 
        ' lk1register
        ' 
        lk1register.AutoSize = True
        lk1register.Location = New Point(192, 430)
        lk1register.Name = "lk1register"
        lk1register.Size = New Size(49, 15)
        lk1register.TabIndex = 16
        lk1register.TabStop = True
        lk1register.Text = "Register"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(10), CByte(55), CByte(39))
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(0, 453)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(436, 32)
        Panel1.TabIndex = 15
        ' 
        ' logo
        ' 
        logo.BackgroundImage = CType(resources.GetObject("logo.BackgroundImage"), Image)
        logo.BackgroundImageLayout = ImageLayout.Zoom
        logo.Location = New Point(137, 34)
        logo.Name = "logo"
        logo.Size = New Size(153, 135)
        logo.TabIndex = 8
        logo.TabStop = False
        ' 
        ' RFIDBOX_Scan
        ' 
        RFIDBOX_Scan.Location = New Point(211, 76)
        RFIDBOX_Scan.Name = "RFIDBOX_Scan"
        RFIDBOX_Scan.Size = New Size(37, 23)
        RFIDBOX_Scan.TabIndex = 7
        ' 
        ' ManualLogin_Link
        ' 
        ManualLogin_Link.AutoSize = True
        ManualLogin_Link.Font = New Font("Calibri", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        ManualLogin_Link.Location = New Point(244, 399)
        ManualLogin_Link.Name = "ManualLogin_Link"
        ManualLogin_Link.Size = New Size(62, 15)
        ManualLogin_Link.TabIndex = 6
        ManualLogin_Link.TabStop = True
        ManualLogin_Link.Text = "Click here!"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(128, 399)
        Label1.Name = "Label1"
        Label1.Size = New Size(120, 15)
        Label1.TabIndex = 5
        Label1.Text = "Scanner won't work?"
        ' 
        ' Granted_Access_Logo
        ' 
        Granted_Access_Logo.Image = CType(resources.GetObject("Granted_Access_Logo.Image"), Image)
        Granted_Access_Logo.Location = New Point(99, 224)
        Granted_Access_Logo.Name = "Granted_Access_Logo"
        Granted_Access_Logo.Size = New Size(227, 163)
        Granted_Access_Logo.SizeMode = PictureBoxSizeMode.CenterImage
        Granted_Access_Logo.TabIndex = 4
        Granted_Access_Logo.TabStop = False
        Granted_Access_Logo.Visible = False
        ' 
        ' Scan_Denied_Logo
        ' 
        Scan_Denied_Logo.Image = CType(resources.GetObject("Scan_Denied_Logo.Image"), Image)
        Scan_Denied_Logo.Location = New Point(96, 224)
        Scan_Denied_Logo.Name = "Scan_Denied_Logo"
        Scan_Denied_Logo.Size = New Size(227, 163)
        Scan_Denied_Logo.SizeMode = PictureBoxSizeMode.Zoom
        Scan_Denied_Logo.TabIndex = 3
        Scan_Denied_Logo.TabStop = False
        Scan_Denied_Logo.Visible = False
        ' 
        ' ScanRFID_Logo
        ' 
        ScanRFID_Logo.Image = CType(resources.GetObject("ScanRFID_Logo.Image"), Image)
        ScanRFID_Logo.Location = New Point(96, 224)
        ScanRFID_Logo.Name = "ScanRFID_Logo"
        ScanRFID_Logo.Size = New Size(227, 163)
        ScanRFID_Logo.SizeMode = PictureBoxSizeMode.Zoom
        ScanRFID_Logo.TabIndex = 2
        ScanRFID_Logo.TabStop = False
        ' 
        ' Scan_Label
        ' 
        Scan_Label.AutoSize = True
        Scan_Label.Font = New Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Scan_Label.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Scan_Label.Location = New Point(114, 180)
        Scan_Label.Name = "Scan_Label"
        Scan_Label.Size = New Size(202, 29)
        Scan_Label.TabIndex = 1
        Scan_Label.Text = "TAP RFID TO LOGIN"
        ' 
        ' ScanMinimize
        ' 
        ScanMinimize.BackColor = Color.Transparent
        ScanMinimize.BackgroundImage = CType(resources.GetObject("ScanMinimize.BackgroundImage"), Image)
        ScanMinimize.BackgroundImageLayout = ImageLayout.Stretch
        ScanMinimize.Cursor = Cursors.Hand
        ScanMinimize.Location = New Point(395, 3)
        ScanMinimize.Name = "ScanMinimize"
        ScanMinimize.Size = New Size(22, 21)
        ScanMinimize.TabIndex = 14
        ScanMinimize.TabStop = False
        ' 
        ' ScanClose
        ' 
        ScanClose.BackColor = Color.Transparent
        ScanClose.BackgroundImage = CType(resources.GetObject("ScanClose.BackgroundImage"), Image)
        ScanClose.BackgroundImageLayout = ImageLayout.Stretch
        ScanClose.Cursor = Cursors.Hand
        ScanClose.Location = New Point(414, 3)
        ScanClose.Name = "ScanClose"
        ScanClose.Size = New Size(22, 21)
        ScanClose.TabIndex = 13
        ScanClose.TabStop = False
        ' 
        ' ManualLoginForm
        ' 
        ManualLoginForm.BackColor = Color.FromArgb(CByte(246), CByte(246), CByte(222))
        ManualLoginForm.Controls.Add(lk2register)
        ManualLoginForm.Controls.Add(Label4)
        ManualLoginForm.Controls.Add(lkForgot)
        ManualLoginForm.Controls.Add(Panel5)
        ManualLoginForm.Controls.Add(Panel4)
        ManualLoginForm.Controls.Add(ManualMinimize)
        ManualLoginForm.Controls.Add(ManualClose)
        ManualLoginForm.Controls.Add(loginBtn)
        ManualLoginForm.Controls.Add(Label2)
        ManualLoginForm.Controls.Add(Panel2)
        ManualLoginForm.Controls.Add(PictureBox1)
        ManualLoginForm.Location = New Point(461, 41)
        ManualLoginForm.Name = "ManualLoginForm"
        ManualLoginForm.Size = New Size(431, 480)
        ManualLoginForm.TabIndex = 1
        ManualLoginForm.Visible = False
        ' 
        ' lk2register
        ' 
        lk2register.AutoSize = True
        lk2register.Location = New Point(193, 426)
        lk2register.Name = "lk2register"
        lk2register.Size = New Size(49, 15)
        lk2register.TabIndex = 27
        lk2register.TabStop = True
        lk2register.Text = "Register"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Calibri Light", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(72, 312)
        Label4.Name = "Label4"
        Label4.Size = New Size(154, 14)
        Label4.TabIndex = 26
        Label4.Text = "Please input registered email."
        ' 
        ' lkForgot
        ' 
        lkForgot.AutoSize = True
        lkForgot.Font = New Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lkForgot.Location = New Point(164, 399)
        lkForgot.Name = "lkForgot"
        lkForgot.Size = New Size(110, 15)
        lkForgot.TabIndex = 25
        lkForgot.TabStop = True
        lkForgot.Text = "Forgot your Email?"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(10), CByte(55), CByte(39))
        Panel5.Dock = DockStyle.Bottom
        Panel5.Location = New Point(0, 448)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(431, 32)
        Panel5.TabIndex = 18
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(10), CByte(55), CByte(39))
        Panel4.Controls.Add(PictureBox3)
        Panel4.Controls.Add(ManualBackBtn)
        Panel4.Controls.Add(PictureBox4)
        Panel4.Dock = DockStyle.Top
        Panel4.Location = New Point(0, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(431, 32)
        Panel4.TabIndex = 17
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), Image)
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox3.Cursor = Cursors.Hand
        PictureBox3.Location = New Point(406, 3)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(22, 21)
        PictureBox3.TabIndex = 13
        PictureBox3.TabStop = False
        ' 
        ' ManualBackBtn
        ' 
        ManualBackBtn.Image = CType(resources.GetObject("ManualBackBtn.Image"), Image)
        ManualBackBtn.Location = New Point(3, 3)
        ManualBackBtn.Name = "ManualBackBtn"
        ManualBackBtn.Size = New Size(35, 29)
        ManualBackBtn.SizeMode = PictureBoxSizeMode.Zoom
        ManualBackBtn.TabIndex = 14
        ManualBackBtn.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.Transparent
        PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), Image)
        PictureBox4.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox4.Cursor = Cursors.Hand
        PictureBox4.Location = New Point(387, 3)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(22, 21)
        PictureBox4.TabIndex = 14
        PictureBox4.TabStop = False
        ' 
        ' ManualMinimize
        ' 
        ManualMinimize.BackColor = Color.Transparent
        ManualMinimize.BackgroundImage = CType(resources.GetObject("ManualMinimize.BackgroundImage"), Image)
        ManualMinimize.BackgroundImageLayout = ImageLayout.Stretch
        ManualMinimize.Cursor = Cursors.Hand
        ManualMinimize.Location = New Point(328, 3)
        ManualMinimize.Name = "ManualMinimize"
        ManualMinimize.Size = New Size(22, 21)
        ManualMinimize.TabIndex = 13
        ManualMinimize.TabStop = False
        ' 
        ' ManualClose
        ' 
        ManualClose.BackColor = Color.Transparent
        ManualClose.BackgroundImage = CType(resources.GetObject("ManualClose.BackgroundImage"), Image)
        ManualClose.BackgroundImageLayout = ImageLayout.Stretch
        ManualClose.Cursor = Cursors.Hand
        ManualClose.Location = New Point(347, 3)
        ManualClose.Name = "ManualClose"
        ManualClose.Size = New Size(22, 21)
        ManualClose.TabIndex = 12
        ManualClose.TabStop = False
        ' 
        ' loginBtn
        ' 
        loginBtn.BackColor = Color.FromArgb(CByte(0), CByte(51), CByte(38))
        loginBtn.Cursor = Cursors.Hand
        loginBtn.FlatStyle = FlatStyle.Flat
        loginBtn.Font = New Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        loginBtn.ForeColor = Color.WhiteSmoke
        loginBtn.Location = New Point(141, 348)
        loginBtn.Name = "loginBtn"
        loginBtn.Size = New Size(153, 44)
        loginBtn.TabIndex = 11
        loginBtn.Text = "LOGIN"
        loginBtn.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label2.Location = New Point(72, 232)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 26)
        Label2.TabIndex = 10
        Label2.Text = "Email"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(237))
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(txtEmail)
        Panel2.Location = New Point(72, 261)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(291, 48)
        Panel2.TabIndex = 9
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(237))
        txtEmail.BorderStyle = BorderStyle.None
        txtEmail.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtEmail.Location = New Point(16, 13)
        txtEmail.Name = "txtEmail"
        txtEmail.PasswordChar = "•"c
        txtEmail.Size = New Size(257, 20)
        txtEmail.TabIndex = 8
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(141, 42)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(153, 135)
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' PinLoginForm
        ' 
        PinLoginForm.BackColor = Color.Beige
        PinLoginForm.Controls.Add(delBtn)
        PinLoginForm.Controls.Add(Panel7)
        PinLoginForm.Controls.Add(Panel6)
        PinLoginForm.Controls.Add(PinMinimize)
        PinLoginForm.Controls.Add(Forgot_PIN_Link)
        PinLoginForm.Controls.Add(PinClose)
        PinLoginForm.Controls.Add(Label3)
        PinLoginForm.Controls.Add(Button13)
        PinLoginForm.Controls.Add(Button9)
        PinLoginForm.Controls.Add(Button10)
        PinLoginForm.Controls.Add(Button11)
        PinLoginForm.Controls.Add(Button6)
        PinLoginForm.Controls.Add(Button7)
        PinLoginForm.Controls.Add(Button8)
        PinLoginForm.Controls.Add(Button5)
        PinLoginForm.Controls.Add(Button4)
        PinLoginForm.Controls.Add(Button3)
        PinLoginForm.Controls.Add(txtpin4)
        PinLoginForm.Controls.Add(txtpin3)
        PinLoginForm.Controls.Add(txtpin2)
        PinLoginForm.Controls.Add(txtpin1)
        PinLoginForm.Controls.Add(PictureBox2)
        PinLoginForm.Location = New Point(925, 41)
        PinLoginForm.Name = "PinLoginForm"
        PinLoginForm.Size = New Size(431, 480)
        PinLoginForm.TabIndex = 12
        PinLoginForm.Visible = False
        ' 
        ' delBtn
        ' 
        delBtn.Cursor = Cursors.Hand
        delBtn.Image = CType(resources.GetObject("delBtn.Image"), Image)
        delBtn.Location = New Point(261, 348)
        delBtn.Name = "delBtn"
        delBtn.Size = New Size(78, 50)
        delBtn.SizeMode = PictureBoxSizeMode.CenterImage
        delBtn.TabIndex = 28
        delBtn.TabStop = False
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.FromArgb(CByte(10), CByte(55), CByte(39))
        Panel7.Controls.Add(PictureBox5)
        Panel7.Controls.Add(PictureBox7)
        Panel7.Dock = DockStyle.Top
        Panel7.Location = New Point(0, 0)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(431, 32)
        Panel7.TabIndex = 27
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.Transparent
        PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), Image)
        PictureBox5.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox5.Cursor = Cursors.Hand
        PictureBox5.Location = New Point(399, 3)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(22, 21)
        PictureBox5.TabIndex = 13
        PictureBox5.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackColor = Color.Transparent
        PictureBox7.BackgroundImage = CType(resources.GetObject("PictureBox7.BackgroundImage"), Image)
        PictureBox7.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox7.Cursor = Cursors.Hand
        PictureBox7.Location = New Point(380, 3)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(22, 21)
        PictureBox7.TabIndex = 14
        PictureBox7.TabStop = False
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(10), CByte(55), CByte(39))
        Panel6.Dock = DockStyle.Bottom
        Panel6.Location = New Point(0, 448)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(431, 32)
        Panel6.TabIndex = 26
        ' 
        ' PinMinimize
        ' 
        PinMinimize.BackColor = Color.Transparent
        PinMinimize.BackgroundImage = CType(resources.GetObject("PinMinimize.BackgroundImage"), Image)
        PinMinimize.BackgroundImageLayout = ImageLayout.Stretch
        PinMinimize.Cursor = Cursors.Hand
        PinMinimize.Location = New Point(328, 3)
        PinMinimize.Name = "PinMinimize"
        PinMinimize.Size = New Size(22, 21)
        PinMinimize.TabIndex = 14
        PinMinimize.TabStop = False
        ' 
        ' Forgot_PIN_Link
        ' 
        Forgot_PIN_Link.AutoSize = True
        Forgot_PIN_Link.Font = New Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Forgot_PIN_Link.Location = New Point(182, 426)
        Forgot_PIN_Link.Name = "Forgot_PIN_Link"
        Forgot_PIN_Link.Size = New Size(98, 15)
        Forgot_PIN_Link.TabIndex = 24
        Forgot_PIN_Link.TabStop = True
        Forgot_PIN_Link.Text = "Forgot your PIN?"
        ' 
        ' PinClose
        ' 
        PinClose.BackColor = Color.Transparent
        PinClose.BackgroundImage = CType(resources.GetObject("PinClose.BackgroundImage"), Image)
        PinClose.BackgroundImageLayout = ImageLayout.Stretch
        PinClose.Cursor = Cursors.Hand
        PinClose.Location = New Point(347, 3)
        PinClose.Name = "PinClose"
        PinClose.Size = New Size(22, 21)
        PinClose.TabIndex = 13
        PinClose.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(159, 65)
        Label3.Name = "Label3"
        Label3.Size = New Size(125, 23)
        Label3.TabIndex = 23
        Label3.Text = "Enter your PIN"
        ' 
        ' Button13
        ' 
        Button13.BackColor = Color.Beige
        Button13.Cursor = Cursors.Hand
        Button13.FlatAppearance.BorderSize = 0
        Button13.FlatStyle = FlatStyle.Flat
        Button13.Font = New Font("Calibri", 15.75F, FontStyle.Bold)
        Button13.Location = New Point(105, 348)
        Button13.Margin = New Padding(0)
        Button13.Name = "Button13"
        Button13.Size = New Size(78, 58)
        Button13.TabIndex = 22
        Button13.Text = "0"
        Button13.UseVisualStyleBackColor = False
        ' 
        ' Button9
        ' 
        Button9.BackColor = Color.Beige
        Button9.Cursor = Cursors.Hand
        Button9.FlatAppearance.BorderSize = 0
        Button9.FlatStyle = FlatStyle.Flat
        Button9.Font = New Font("Calibri", 15.75F, FontStyle.Bold)
        Button9.Location = New Point(261, 290)
        Button9.Margin = New Padding(0)
        Button9.Name = "Button9"
        Button9.Size = New Size(78, 58)
        Button9.TabIndex = 20
        Button9.Text = "9"
        Button9.UseVisualStyleBackColor = False
        ' 
        ' Button10
        ' 
        Button10.BackColor = Color.Beige
        Button10.Cursor = Cursors.Hand
        Button10.FlatAppearance.BorderSize = 0
        Button10.FlatStyle = FlatStyle.Flat
        Button10.Font = New Font("Calibri", 15.75F, FontStyle.Bold)
        Button10.Location = New Point(183, 290)
        Button10.Margin = New Padding(0)
        Button10.Name = "Button10"
        Button10.Size = New Size(78, 58)
        Button10.TabIndex = 19
        Button10.Text = "8"
        Button10.UseVisualStyleBackColor = False
        ' 
        ' Button11
        ' 
        Button11.BackColor = Color.Beige
        Button11.Cursor = Cursors.Hand
        Button11.FlatAppearance.BorderSize = 0
        Button11.FlatStyle = FlatStyle.Flat
        Button11.Font = New Font("Calibri", 15.75F, FontStyle.Bold)
        Button11.Location = New Point(105, 290)
        Button11.Margin = New Padding(0)
        Button11.Name = "Button11"
        Button11.Size = New Size(78, 58)
        Button11.TabIndex = 18
        Button11.Text = "7"
        Button11.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.Beige
        Button6.Cursor = Cursors.Hand
        Button6.FlatAppearance.BorderSize = 0
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Font = New Font("Calibri", 15.75F, FontStyle.Bold)
        Button6.Location = New Point(261, 232)
        Button6.Margin = New Padding(0)
        Button6.Name = "Button6"
        Button6.Size = New Size(78, 58)
        Button6.TabIndex = 17
        Button6.Text = "6"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.Beige
        Button7.Cursor = Cursors.Hand
        Button7.FlatAppearance.BorderSize = 0
        Button7.FlatStyle = FlatStyle.Flat
        Button7.Font = New Font("Calibri", 15.75F, FontStyle.Bold)
        Button7.Location = New Point(183, 232)
        Button7.Margin = New Padding(0)
        Button7.Name = "Button7"
        Button7.Size = New Size(78, 58)
        Button7.TabIndex = 16
        Button7.Text = "5"
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Button8
        ' 
        Button8.BackColor = Color.Beige
        Button8.Cursor = Cursors.Hand
        Button8.FlatAppearance.BorderSize = 0
        Button8.FlatStyle = FlatStyle.Flat
        Button8.Font = New Font("Calibri", 15.75F, FontStyle.Bold)
        Button8.Location = New Point(105, 232)
        Button8.Margin = New Padding(0)
        Button8.Name = "Button8"
        Button8.Size = New Size(78, 58)
        Button8.TabIndex = 15
        Button8.Text = "4"
        Button8.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Beige
        Button5.Cursor = Cursors.Hand
        Button5.FlatAppearance.BorderSize = 0
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Calibri", 15.75F, FontStyle.Bold)
        Button5.Location = New Point(261, 174)
        Button5.Margin = New Padding(0)
        Button5.Name = "Button5"
        Button5.Size = New Size(78, 58)
        Button5.TabIndex = 14
        Button5.Text = "3"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Beige
        Button4.Cursor = Cursors.Hand
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Calibri", 15.75F, FontStyle.Bold)
        Button4.Location = New Point(183, 174)
        Button4.Margin = New Padding(0)
        Button4.Name = "Button4"
        Button4.Size = New Size(78, 58)
        Button4.TabIndex = 13
        Button4.Text = "2"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Beige
        Button3.Cursor = Cursors.Hand
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Calibri", 15.75F, FontStyle.Bold)
        Button3.Location = New Point(105, 174)
        Button3.Margin = New Padding(0)
        Button3.Name = "Button3"
        Button3.Size = New Size(78, 58)
        Button3.TabIndex = 12
        Button3.Text = "1"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' txtpin4
        ' 
        txtpin4.BackColor = Color.White
        txtpin4.Cursor = Cursors.No
        txtpin4.Font = New Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtpin4.Location = New Point(301, 101)
        txtpin4.Name = "txtpin4"
        txtpin4.PasswordChar = "•"c
        txtpin4.ReadOnly = True
        txtpin4.Size = New Size(50, 47)
        txtpin4.TabIndex = 11
        txtpin4.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtpin3
        ' 
        txtpin3.BackColor = Color.White
        txtpin3.Cursor = Cursors.No
        txtpin3.Font = New Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtpin3.Location = New Point(234, 101)
        txtpin3.Name = "txtpin3"
        txtpin3.PasswordChar = "•"c
        txtpin3.ReadOnly = True
        txtpin3.Size = New Size(50, 47)
        txtpin3.TabIndex = 10
        txtpin3.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtpin2
        ' 
        txtpin2.BackColor = Color.White
        txtpin2.Cursor = Cursors.No
        txtpin2.Font = New Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtpin2.Location = New Point(167, 101)
        txtpin2.Name = "txtpin2"
        txtpin2.PasswordChar = "•"c
        txtpin2.ReadOnly = True
        txtpin2.Size = New Size(50, 47)
        txtpin2.TabIndex = 9
        txtpin2.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtpin1
        ' 
        txtpin1.BackColor = Color.White
        txtpin1.Cursor = Cursors.No
        txtpin1.Font = New Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtpin1.Location = New Point(97, 101)
        txtpin1.Name = "txtpin1"
        txtpin1.PasswordChar = "•"c
        txtpin1.ReadOnly = True
        txtpin1.Size = New Size(50, 47)
        txtpin1.TabIndex = 8
        txtpin1.TextAlign = HorizontalAlignment.Center
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox2.Location = New Point(16, 37)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(47, 40)
        PictureBox2.TabIndex = 7
        PictureBox2.TabStop = False
        ' 
        ' timer
        ' 
        timer.Interval = 5000
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(10), CByte(55), CByte(39))
        Panel3.Controls.Add(ScanClose)
        Panel3.Controls.Add(ScanMinimize)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(435, 32)
        Panel3.TabIndex = 16
        ' 
        ' clearInputs
        ' 
        clearInputs.Interval = 1000
        ' 
        ' Authentication_Form
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(435, 485)
        Controls.Add(Panel3)
        Controls.Add(PinLoginForm)
        Controls.Add(ManualLoginForm)
        Controls.Add(Scan_AuthForm)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "Authentication_Form"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Authentication Form"
        Scan_AuthForm.ResumeLayout(False)
        Scan_AuthForm.PerformLayout()
        CType(logo, ComponentModel.ISupportInitialize).EndInit()
        CType(Granted_Access_Logo, ComponentModel.ISupportInitialize).EndInit()
        CType(Scan_Denied_Logo, ComponentModel.ISupportInitialize).EndInit()
        CType(ScanRFID_Logo, ComponentModel.ISupportInitialize).EndInit()
        CType(ScanMinimize, ComponentModel.ISupportInitialize).EndInit()
        CType(ScanClose, ComponentModel.ISupportInitialize).EndInit()
        ManualLoginForm.ResumeLayout(False)
        ManualLoginForm.PerformLayout()
        Panel4.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(ManualBackBtn, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(ManualMinimize, ComponentModel.ISupportInitialize).EndInit()
        CType(ManualClose, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        PinLoginForm.ResumeLayout(False)
        PinLoginForm.PerformLayout()
        CType(delBtn, ComponentModel.ISupportInitialize).EndInit()
        Panel7.ResumeLayout(False)
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PinMinimize, ComponentModel.ISupportInitialize).EndInit()
        CType(PinClose, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Scan_AuthForm As Panel
    Friend WithEvents Scan_Label As Label
    Friend WithEvents ScanRFID_Logo As PictureBox
    Friend WithEvents Scan_Denied_Logo As PictureBox
    Friend WithEvents Granted_Access_Logo As PictureBox
    Friend WithEvents ManualLoginForm As Panel
    Friend WithEvents ManualLogin_Link As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents loginBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PinLoginForm As Panel
    Friend WithEvents txtpin3 As TextBox
    Friend WithEvents txtpin2 As TextBox
    Friend WithEvents txtpin1 As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button13 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents txtpin4 As TextBox
    Friend WithEvents logo As PictureBox
    Friend WithEvents RFIDBOX_Scan As TextBox
    Friend WithEvents Forgot_PIN_Link As LinkLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents ScanMinimize As PictureBox
    Friend WithEvents ScanClose As PictureBox
    Friend WithEvents ManualMinimize As PictureBox
    Friend WithEvents ManualClose As PictureBox
    Friend WithEvents PinMinimize As PictureBox
    Friend WithEvents PinClose As PictureBox
    Friend WithEvents ManualBackBtn As PictureBox
    Friend WithEvents timer As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents lkForgot As LinkLabel
    Friend WithEvents lk1register As LinkLabel
    Friend WithEvents lk2register As LinkLabel
    Friend WithEvents delBtn As PictureBox
    Friend WithEvents clearInputs As Timer
End Class
