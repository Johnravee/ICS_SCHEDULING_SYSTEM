<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class forgot
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(forgot))
        rfidscanpanel = New Panel()
        imgerror = New PictureBox()
        imgloading = New PictureBox()
        imgsuccess = New PictureBox()
        ScanRFID_Logo = New PictureBox()
        lblunxerror = New Label()
        lblrfiderror = New Label()
        lblsuccess = New Label()
        lblredirect = New Label()
        Panel2 = New Panel()
        Button2 = New Button()
        Label1 = New Label()
        logo = New PictureBox()
        txtrfid = New TextBox()
        Scan_Label = New Label()
        emailpanel = New Panel()
        btnsubmitemil = New Button()
        Panel4 = New Panel()
        txtemail = New TextBox()
        lblunexerror = New Label()
        lblemailnotif = New Label()
        Panel3 = New Panel()
        Label7 = New Label()
        Button1 = New Button()
        PictureBox4 = New PictureBox()
        TextBox1 = New TextBox()
        existtimer = New Timer(components)
        redirectotlogintimer = New Timer(components)
        successtimer = New Timer(components)
        rfidscanpanel.SuspendLayout()
        CType(imgerror, ComponentModel.ISupportInitialize).BeginInit()
        CType(imgloading, ComponentModel.ISupportInitialize).BeginInit()
        CType(imgsuccess, ComponentModel.ISupportInitialize).BeginInit()
        CType(ScanRFID_Logo, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(logo, ComponentModel.ISupportInitialize).BeginInit()
        emailpanel.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' rfidscanpanel
        ' 
        rfidscanpanel.BackColor = Color.Beige
        rfidscanpanel.Controls.Add(imgerror)
        rfidscanpanel.Controls.Add(imgloading)
        rfidscanpanel.Controls.Add(imgsuccess)
        rfidscanpanel.Controls.Add(ScanRFID_Logo)
        rfidscanpanel.Controls.Add(lblunxerror)
        rfidscanpanel.Controls.Add(lblrfiderror)
        rfidscanpanel.Controls.Add(lblsuccess)
        rfidscanpanel.Controls.Add(lblredirect)
        rfidscanpanel.Controls.Add(Panel2)
        rfidscanpanel.Controls.Add(logo)
        rfidscanpanel.Controls.Add(txtrfid)
        rfidscanpanel.Controls.Add(Scan_Label)
        rfidscanpanel.Dock = DockStyle.Fill
        rfidscanpanel.Location = New Point(0, 0)
        rfidscanpanel.Name = "rfidscanpanel"
        rfidscanpanel.Size = New Size(419, 444)
        rfidscanpanel.TabIndex = 1
        rfidscanpanel.Visible = False
        ' 
        ' imgerror
        ' 
        imgerror.Image = CType(resources.GetObject("imgerror.Image"), Image)
        imgerror.Location = New Point(96, 277)
        imgerror.Name = "imgerror"
        imgerror.Size = New Size(235, 163)
        imgerror.SizeMode = PictureBoxSizeMode.CenterImage
        imgerror.TabIndex = 41
        imgerror.TabStop = False
        imgerror.Visible = False
        ' 
        ' imgloading
        ' 
        imgloading.Image = CType(resources.GetObject("imgloading.Image"), Image)
        imgloading.Location = New Point(96, 277)
        imgloading.Name = "imgloading"
        imgloading.Size = New Size(235, 163)
        imgloading.SizeMode = PictureBoxSizeMode.CenterImage
        imgloading.TabIndex = 40
        imgloading.TabStop = False
        imgloading.Visible = False
        ' 
        ' imgsuccess
        ' 
        imgsuccess.Image = CType(resources.GetObject("imgsuccess.Image"), Image)
        imgsuccess.Location = New Point(96, 277)
        imgsuccess.Name = "imgsuccess"
        imgsuccess.Size = New Size(235, 163)
        imgsuccess.SizeMode = PictureBoxSizeMode.CenterImage
        imgsuccess.TabIndex = 39
        imgsuccess.TabStop = False
        imgsuccess.Visible = False
        ' 
        ' ScanRFID_Logo
        ' 
        ScanRFID_Logo.Image = CType(resources.GetObject("ScanRFID_Logo.Image"), Image)
        ScanRFID_Logo.Location = New Point(96, 277)
        ScanRFID_Logo.Name = "ScanRFID_Logo"
        ScanRFID_Logo.Size = New Size(235, 163)
        ScanRFID_Logo.SizeMode = PictureBoxSizeMode.Zoom
        ScanRFID_Logo.TabIndex = 38
        ScanRFID_Logo.TabStop = False
        ' 
        ' lblunxerror
        ' 
        lblunxerror.AutoSize = True
        lblunxerror.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblunxerror.ForeColor = Color.FromArgb(CByte(220), CByte(76), CByte(100))
        lblunxerror.Location = New Point(11, 250)
        lblunxerror.Name = "lblunxerror"
        lblunxerror.Size = New Size(398, 19)
        lblunxerror.TabIndex = 37
        lblunxerror.Text = "An unexpected error has occurred. Please try again later."
        lblunxerror.Visible = False
        ' 
        ' lblrfiderror
        ' 
        lblrfiderror.AutoSize = True
        lblrfiderror.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblrfiderror.ForeColor = Color.FromArgb(CByte(220), CByte(76), CByte(100))
        lblrfiderror.Location = New Point(75, 250)
        lblrfiderror.Name = "lblrfiderror"
        lblrfiderror.Size = New Size(286, 19)
        lblrfiderror.TabIndex = 35
        lblrfiderror.Text = "Your provided RFID is already registered."
        lblrfiderror.Visible = False
        ' 
        ' lblsuccess
        ' 
        lblsuccess.AutoSize = True
        lblsuccess.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblsuccess.Location = New Point(96, 250)
        lblsuccess.Name = "lblsuccess"
        lblsuccess.Size = New Size(242, 19)
        lblsuccess.TabIndex = 32
        lblsuccess.Text = "Account RFID updated successfull!"
        lblsuccess.Visible = False
        ' 
        ' lblredirect
        ' 
        lblredirect.AutoSize = True
        lblredirect.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblredirect.Location = New Point(146, 250)
        lblredirect.Name = "lblredirect"
        lblredirect.Size = New Size(140, 19)
        lblredirect.TabIndex = 31
        lblredirect.Text = "redirecting to login"
        lblredirect.Visible = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(10), CByte(55), CByte(39))
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Label1)
        Panel2.Cursor = Cursors.IBeam
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(419, 32)
        Panel2.TabIndex = 28
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(2), CByte(47), CByte(31))
        Button2.BackgroundImage = My.Resources.Resources.backBtn
        Button2.BackgroundImageLayout = ImageLayout.Stretch
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = Color.FromArgb(CByte(1), CByte(81), CByte(54))
        Button2.Location = New Point(0, -1)
        Button2.Name = "Button2"
        Button2.Size = New Size(37, 33)
        Button2.TabIndex = 5
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.WhiteSmoke
        Label1.Location = New Point(220, 3)
        Label1.Name = "Label1"
        Label1.Size = New Size(196, 26)
        Label1.TabIndex = 4
        Label1.Text = "ACCOUNT RECOVERY"
        ' 
        ' logo
        ' 
        logo.BackgroundImage = CType(resources.GetObject("logo.BackgroundImage"), Image)
        logo.BackgroundImageLayout = ImageLayout.Zoom
        logo.Location = New Point(139, 54)
        logo.Name = "logo"
        logo.Size = New Size(153, 135)
        logo.TabIndex = 19
        logo.TabStop = False
        ' 
        ' txtrfid
        ' 
        txtrfid.Location = New Point(214, 88)
        txtrfid.Name = "txtrfid"
        txtrfid.Size = New Size(37, 23)
        txtrfid.TabIndex = 18
        ' 
        ' Scan_Label
        ' 
        Scan_Label.AutoSize = True
        Scan_Label.Font = New Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Scan_Label.Location = New Point(135, 207)
        Scan_Label.Name = "Scan_Label"
        Scan_Label.Size = New Size(157, 29)
        Scan_Label.TabIndex = 16
        Scan_Label.Text = "TAP NEW RFID"
        ' 
        ' emailpanel
        ' 
        emailpanel.BackColor = Color.Beige
        emailpanel.Controls.Add(btnsubmitemil)
        emailpanel.Controls.Add(Panel4)
        emailpanel.Controls.Add(lblunexerror)
        emailpanel.Controls.Add(lblemailnotif)
        emailpanel.Controls.Add(Panel3)
        emailpanel.Controls.Add(PictureBox4)
        emailpanel.Controls.Add(TextBox1)
        emailpanel.Dock = DockStyle.Fill
        emailpanel.Location = New Point(0, 0)
        emailpanel.Name = "emailpanel"
        emailpanel.Size = New Size(419, 444)
        emailpanel.TabIndex = 2
        ' 
        ' btnsubmitemil
        ' 
        btnsubmitemil.BackColor = Color.FromArgb(CByte(10), CByte(55), CByte(39))
        btnsubmitemil.FlatAppearance.BorderSize = 0
        btnsubmitemil.FlatStyle = FlatStyle.Flat
        btnsubmitemil.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnsubmitemil.ForeColor = Color.FromArgb(CByte(254), CByte(221), CByte(221))
        btnsubmitemil.Location = New Point(158, 367)
        btnsubmitemil.Name = "btnsubmitemil"
        btnsubmitemil.Size = New Size(112, 41)
        btnsubmitemil.TabIndex = 39
        btnsubmitemil.Text = "Submit"
        btnsubmitemil.UseVisualStyleBackColor = False
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.LightYellow
        Panel4.Controls.Add(txtemail)
        Panel4.Location = New Point(76, 293)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(288, 46)
        Panel4.TabIndex = 38
        ' 
        ' txtemail
        ' 
        txtemail.BackColor = Color.LightYellow
        txtemail.BorderStyle = BorderStyle.None
        txtemail.Font = New Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtemail.Location = New Point(15, 11)
        txtemail.Name = "txtemail"
        txtemail.PlaceholderText = "Email"
        txtemail.Size = New Size(261, 24)
        txtemail.TabIndex = 39
        ' 
        ' lblunexerror
        ' 
        lblunexerror.AutoSize = True
        lblunexerror.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblunexerror.ForeColor = Color.FromArgb(CByte(220), CByte(76), CByte(100))
        lblunexerror.Location = New Point(11, 246)
        lblunexerror.Name = "lblunexerror"
        lblunexerror.Size = New Size(398, 19)
        lblunexerror.TabIndex = 37
        lblunexerror.Text = "An unexpected error has occurred. Please try again later."
        lblunexerror.Visible = False
        ' 
        ' lblemailnotif
        ' 
        lblemailnotif.AutoSize = True
        lblemailnotif.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblemailnotif.ForeColor = Color.FromArgb(CByte(220), CByte(76), CByte(100))
        lblemailnotif.Location = New Point(79, 342)
        lblemailnotif.Name = "lblemailnotif"
        lblemailnotif.Size = New Size(238, 19)
        lblemailnotif.TabIndex = 35
        lblemailnotif.Text = "Your provided Email is not found."
        lblemailnotif.Visible = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(10), CByte(55), CByte(39))
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(Button1)
        Panel3.Cursor = Cursors.IBeam
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(419, 32)
        Panel3.TabIndex = 28
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.WhiteSmoke
        Label7.Location = New Point(220, 3)
        Label7.Name = "Label7"
        Label7.Size = New Size(196, 26)
        Label7.TabIndex = 3
        Label7.Text = "ACCOUNT RECOVERY"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(2), CByte(47), CByte(31))
        Button1.BackgroundImage = My.Resources.Resources.backBtn
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.FromArgb(CByte(1), CByte(81), CByte(54))
        Button1.Location = New Point(3, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(37, 33)
        Button1.TabIndex = 1
        Button1.UseVisualStyleBackColor = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), Image)
        PictureBox4.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox4.Location = New Point(135, 54)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(153, 135)
        PictureBox4.TabIndex = 19
        PictureBox4.TabStop = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(214, 88)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(37, 23)
        TextBox1.TabIndex = 18
        ' 
        ' existtimer
        ' 
        existtimer.Interval = 3000
        ' 
        ' redirectotlogintimer
        ' 
        redirectotlogintimer.Interval = 3000
        ' 
        ' successtimer
        ' 
        successtimer.Interval = 3000
        ' 
        ' forgot
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(419, 444)
        Controls.Add(emailpanel)
        Controls.Add(rfidscanpanel)
        FormBorderStyle = FormBorderStyle.None
        Name = "forgot"
        StartPosition = FormStartPosition.CenterScreen
        Text = "forgot"
        rfidscanpanel.ResumeLayout(False)
        rfidscanpanel.PerformLayout()
        CType(imgerror, ComponentModel.ISupportInitialize).EndInit()
        CType(imgloading, ComponentModel.ISupportInitialize).EndInit()
        CType(imgsuccess, ComponentModel.ISupportInitialize).EndInit()
        CType(ScanRFID_Logo, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(logo, ComponentModel.ISupportInitialize).EndInit()
        emailpanel.ResumeLayout(False)
        emailpanel.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents rfidscanpanel As Panel
    Friend WithEvents lblunxerror As Label
    Friend WithEvents lblduplicateentry As Label
    Friend WithEvents lblrfiderror As Label
    Friend WithEvents lblsuccess As Label
    Friend WithEvents lblredirect As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents logo As PictureBox
    Friend WithEvents txtrfid As TextBox
    Friend WithEvents Scan_Label As Label
    Friend WithEvents emailpanel As Panel
    Friend WithEvents lblunexerror As Label
    Friend WithEvents lblemailnotif As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnsubmitemil As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtemail As TextBox
    Friend WithEvents imgerror As PictureBox
    Friend WithEvents imgloading As PictureBox
    Friend WithEvents imgsuccess As PictureBox
    Friend WithEvents ScanRFID_Logo As PictureBox
    Friend WithEvents existtimer As Timer
    Friend WithEvents redirectotlogintimer As Timer
    Friend WithEvents successtimer As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
End Class
