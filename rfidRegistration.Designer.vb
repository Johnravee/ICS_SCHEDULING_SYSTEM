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
        Panel2 = New Panel()
        ScanDoneLogo = New PictureBox()
        logo = New PictureBox()
        txtRfidRegister = New TextBox()
        ScanRFID_Logo = New PictureBox()
        Scan_Label = New Label()
        RFIDTIMER = New Timer(components)
        rfidscanpanel.SuspendLayout()
        CType(ScanDoneLogo, ComponentModel.ISupportInitialize).BeginInit()
        CType(logo, ComponentModel.ISupportInitialize).BeginInit()
        CType(ScanRFID_Logo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' rfidscanpanel
        ' 
        rfidscanpanel.Controls.Add(Panel2)
        rfidscanpanel.Controls.Add(ScanDoneLogo)
        rfidscanpanel.Controls.Add(logo)
        rfidscanpanel.Controls.Add(txtRfidRegister)
        rfidscanpanel.Controls.Add(ScanRFID_Logo)
        rfidscanpanel.Controls.Add(Scan_Label)
        rfidscanpanel.Location = New Point(-3, 5)
        rfidscanpanel.Name = "rfidscanpanel"
        rfidscanpanel.Size = New Size(422, 475)
        rfidscanpanel.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(10), CByte(55), CByte(39))
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(422, 32)
        Panel2.TabIndex = 28
        ' 
        ' ScanDoneLogo
        ' 
        ScanDoneLogo.Image = CType(resources.GetObject("ScanDoneLogo.Image"), Image)
        ScanDoneLogo.Location = New Point(94, 259)
        ScanDoneLogo.Name = "ScanDoneLogo"
        ScanDoneLogo.Size = New Size(235, 163)
        ScanDoneLogo.SizeMode = PictureBoxSizeMode.Zoom
        ScanDoneLogo.TabIndex = 20
        ScanDoneLogo.TabStop = False
        ScanDoneLogo.Visible = False
        ' 
        ' logo
        ' 
        logo.BackgroundImage = CType(resources.GetObject("logo.BackgroundImage"), Image)
        logo.BackgroundImageLayout = ImageLayout.Zoom
        logo.Location = New Point(146, 53)
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
        ScanRFID_Logo.Location = New Point(94, 259)
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
        Scan_Label.Location = New Point(94, 210)
        Scan_Label.Name = "Scan_Label"
        Scan_Label.Size = New Size(235, 29)
        Scan_Label.TabIndex = 16
        Scan_Label.Text = "TAP RFID TO REGISTER"
        ' 
        ' RFIDTIMER
        ' 
        RFIDTIMER.Interval = 1000
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
        CType(ScanDoneLogo, ComponentModel.ISupportInitialize).EndInit()
        CType(logo, ComponentModel.ISupportInitialize).EndInit()
        CType(ScanRFID_Logo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents rfidscanpanel As Panel
    Friend WithEvents ScanDoneLogo As PictureBox
    Friend WithEvents logo As PictureBox
    Friend WithEvents txtRfidRegister As TextBox
    Friend WithEvents ScanRFID_Logo As PictureBox
    Friend WithEvents Scan_Label As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents RFIDTIMER As Timer
    Friend WithEvents accountCreatedDialog As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
End Class
