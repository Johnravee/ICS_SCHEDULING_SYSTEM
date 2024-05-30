<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RFIDREGISTRATION
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RFIDREGISTRATION))
        rfidscanpanel = New Panel()
        lblunxerror = New Label()
        lblduplicateentry = New Label()
        lblrfiderror = New Label()
        lblemailerror = New Label()
        imgerror = New PictureBox()
        lblsuccess = New Label()
        lblredirect = New Label()
        imgloading = New PictureBox()
        imgsuccess = New PictureBox()
        Panel2 = New Panel()
        logo = New PictureBox()
        txtRfidRegister = New TextBox()
        ScanRFID_Logo = New PictureBox()
        Scan_Label = New Label()
        redirectionTimer = New Timer(components)
        backtoregistrationTimer = New Timer(components)
        createdsuccesstimer = New Timer(components)
        Button1 = New Button()
        rfidscanpanel.SuspendLayout()
        CType(imgerror, ComponentModel.ISupportInitialize).BeginInit()
        CType(imgloading, ComponentModel.ISupportInitialize).BeginInit()
        CType(imgsuccess, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(logo, ComponentModel.ISupportInitialize).BeginInit()
        CType(ScanRFID_Logo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' rfidscanpanel
        ' 
        rfidscanpanel.Controls.Add(lblunxerror)
        rfidscanpanel.Controls.Add(lblduplicateentry)
        rfidscanpanel.Controls.Add(lblrfiderror)
        rfidscanpanel.Controls.Add(lblemailerror)
        rfidscanpanel.Controls.Add(imgerror)
        rfidscanpanel.Controls.Add(lblsuccess)
        rfidscanpanel.Controls.Add(lblredirect)
        rfidscanpanel.Controls.Add(imgloading)
        rfidscanpanel.Controls.Add(imgsuccess)
        rfidscanpanel.Controls.Add(Panel2)
        rfidscanpanel.Controls.Add(logo)
        rfidscanpanel.Controls.Add(txtRfidRegister)
        rfidscanpanel.Controls.Add(ScanRFID_Logo)
        rfidscanpanel.Controls.Add(Scan_Label)
        rfidscanpanel.Dock = DockStyle.Fill
        rfidscanpanel.Location = New Point(0, 0)
        rfidscanpanel.Name = "rfidscanpanel"
        rfidscanpanel.Size = New Size(419, 479)
        rfidscanpanel.TabIndex = 0
        ' 
        ' lblunxerror
        ' 
        lblunxerror.AutoSize = True
        lblunxerror.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblunxerror.ForeColor = Color.FromArgb(CByte(220), CByte(76), CByte(100))
        lblunxerror.Location = New Point(14, 250)
        lblunxerror.Name = "lblunxerror"
        lblunxerror.Size = New Size(398, 19)
        lblunxerror.TabIndex = 37
        lblunxerror.Text = "An unexpected error has occurred. Please try again later."
        lblunxerror.Visible = False
        ' 
        ' lblduplicateentry
        ' 
        lblduplicateentry.AutoSize = True
        lblduplicateentry.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblduplicateentry.ForeColor = Color.FromArgb(CByte(220), CByte(76), CByte(100))
        lblduplicateentry.Location = New Point(94, 250)
        lblduplicateentry.Name = "lblduplicateentry"
        lblduplicateentry.Size = New Size(241, 19)
        lblduplicateentry.TabIndex = 36
        lblduplicateentry.Text = "Sorry, that account already exists."
        lblduplicateentry.Visible = False
        ' 
        ' lblrfiderror
        ' 
        lblrfiderror.AutoSize = True
        lblrfiderror.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblrfiderror.ForeColor = Color.FromArgb(CByte(220), CByte(76), CByte(100))
        lblrfiderror.Location = New Point(73, 250)
        lblrfiderror.Name = "lblrfiderror"
        lblrfiderror.Size = New Size(286, 19)
        lblrfiderror.TabIndex = 35
        lblrfiderror.Text = "Your provided RFID is already registered."
        lblrfiderror.Visible = False
        ' 
        ' lblemailerror
        ' 
        lblemailerror.AutoSize = True
        lblemailerror.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblemailerror.ForeColor = Color.FromArgb(CByte(220), CByte(76), CByte(100))
        lblemailerror.Location = New Point(73, 250)
        lblemailerror.Name = "lblemailerror"
        lblemailerror.Size = New Size(293, 19)
        lblemailerror.TabIndex = 34
        lblemailerror.Text = "Your provided email is already registered."
        lblemailerror.Visible = False
        ' 
        ' imgerror
        ' 
        imgerror.Image = CType(resources.GetObject("imgerror.Image"), Image)
        imgerror.Location = New Point(94, 272)
        imgerror.Name = "imgerror"
        imgerror.Size = New Size(235, 163)
        imgerror.SizeMode = PictureBoxSizeMode.CenterImage
        imgerror.TabIndex = 33
        imgerror.TabStop = False
        imgerror.Visible = False
        ' 
        ' lblsuccess
        ' 
        lblsuccess.AutoSize = True
        lblsuccess.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblsuccess.Location = New Point(107, 250)
        lblsuccess.Name = "lblsuccess"
        lblsuccess.Size = New Size(210, 19)
        lblsuccess.TabIndex = 32
        lblsuccess.Text = "Account created successfully!"
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
        ' imgloading
        ' 
        imgloading.Image = CType(resources.GetObject("imgloading.Image"), Image)
        imgloading.Location = New Point(94, 272)
        imgloading.Name = "imgloading"
        imgloading.Size = New Size(235, 163)
        imgloading.SizeMode = PictureBoxSizeMode.CenterImage
        imgloading.TabIndex = 30
        imgloading.TabStop = False
        ' 
        ' imgsuccess
        ' 
        imgsuccess.Image = CType(resources.GetObject("imgsuccess.Image"), Image)
        imgsuccess.Location = New Point(94, 272)
        imgsuccess.Name = "imgsuccess"
        imgsuccess.Size = New Size(235, 163)
        imgsuccess.SizeMode = PictureBoxSizeMode.CenterImage
        imgsuccess.TabIndex = 29
        imgsuccess.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(10), CByte(55), CByte(39))
        Panel2.Controls.Add(Button1)
        Panel2.Cursor = Cursors.IBeam
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(419, 32)
        Panel2.TabIndex = 28
        ' 
        ' logo
        ' 
        logo.BackgroundImage = CType(resources.GetObject("logo.BackgroundImage"), Image)
        logo.BackgroundImageLayout = ImageLayout.Zoom
        logo.Location = New Point(135, 54)
        logo.Name = "logo"
        logo.Size = New Size(153, 135)
        logo.TabIndex = 19
        logo.TabStop = False
        ' 
        ' txtRfidRegister
        ' 
        txtRfidRegister.Location = New Point(214, 88)
        txtRfidRegister.Name = "txtRfidRegister"
        txtRfidRegister.Size = New Size(37, 23)
        txtRfidRegister.TabIndex = 18
        ' 
        ' ScanRFID_Logo
        ' 
        ScanRFID_Logo.Image = CType(resources.GetObject("ScanRFID_Logo.Image"), Image)
        ScanRFID_Logo.Location = New Point(94, 272)
        ScanRFID_Logo.Name = "ScanRFID_Logo"
        ScanRFID_Logo.Size = New Size(235, 163)
        ScanRFID_Logo.SizeMode = PictureBoxSizeMode.Zoom
        ScanRFID_Logo.TabIndex = 17
        ScanRFID_Logo.TabStop = False
        ' 
        ' Scan_Label
        ' 
        Scan_Label.AutoSize = True
        Scan_Label.Font = New Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Scan_Label.Location = New Point(104, 212)
        Scan_Label.Name = "Scan_Label"
        Scan_Label.Size = New Size(235, 29)
        Scan_Label.TabIndex = 16
        Scan_Label.Text = "TAP RFID TO REGISTER"
        ' 
        ' redirectionTimer
        ' 
        redirectionTimer.Interval = 7000
        ' 
        ' backtoregistrationTimer
        ' 
        backtoregistrationTimer.Interval = 5000
        ' 
        ' createdsuccesstimer
        ' 
        createdsuccesstimer.Interval = 3000
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(10), CByte(55), CByte(39))
        Button1.BackgroundImage = My.Resources.Resources.backBtn
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.FromArgb(CByte(1), CByte(81), CByte(54))
        Button1.Location = New Point(0, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(41, 32)
        Button1.TabIndex = 1
        Button1.UseVisualStyleBackColor = False
        ' 
        ' RFIDREGISTRATION
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Beige
        ClientSize = New Size(419, 479)
        Controls.Add(rfidscanpanel)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "RFIDREGISTRATION"
        StartPosition = FormStartPosition.CenterScreen
        Text = "rfidandPinRegistrationforinstructors"
        rfidscanpanel.ResumeLayout(False)
        rfidscanpanel.PerformLayout()
        CType(imgerror, ComponentModel.ISupportInitialize).EndInit()
        CType(imgloading, ComponentModel.ISupportInitialize).EndInit()
        CType(imgsuccess, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        CType(logo, ComponentModel.ISupportInitialize).EndInit()
        CType(ScanRFID_Logo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents rfidscanpanel As Panel
    Friend WithEvents logo As PictureBox
    Friend WithEvents txtRfidRegister As TextBox
    Friend WithEvents ScanRFID_Logo As PictureBox
    Friend WithEvents Scan_Label As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents redirectionTimer As Timer
    Friend WithEvents accountCreatedDialog As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblduplicateentry As Label
    Friend WithEvents imgsuccess As PictureBox
    Friend WithEvents lblredirect As Label
    Friend WithEvents imgloading As PictureBox
    Friend WithEvents backtoregistrationTimer As Timer
    Friend WithEvents lblsuccess As Label
    Friend WithEvents createdsuccesstimer As Timer
    Friend WithEvents lblrfiderror As Label
    Friend WithEvents lblemailerror As Label
    Friend WithEvents imgerror As PictureBox
    Friend WithEvents lblunxerror As Label
    Friend WithEvents Button1 As Button
End Class
