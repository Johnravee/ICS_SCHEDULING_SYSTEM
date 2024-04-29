<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScanRFIDLOGIN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ScanRFIDLOGIN))
        Panel1 = New Panel()
        closeBtn = New PictureBox()
        Scan_Label = New Label()
        Granted_Access_Logo = New PictureBox()
        Scan_Denied_Logo = New PictureBox()
        txtrfidlogin = New TextBox()
        logo = New PictureBox()
        ScanRFID_Logo = New PictureBox()
        lk1register = New LinkLabel()
        Panel2 = New Panel()
        rfidlink = New LinkLabel()
        clearinputtimer = New Timer(components)
        hidelogos = New Timer(components)
        Panel1.SuspendLayout()
        CType(closeBtn, ComponentModel.ISupportInitialize).BeginInit()
        CType(Granted_Access_Logo, ComponentModel.ISupportInitialize).BeginInit()
        CType(Scan_Denied_Logo, ComponentModel.ISupportInitialize).BeginInit()
        CType(logo, ComponentModel.ISupportInitialize).BeginInit()
        CType(ScanRFID_Logo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(2), CByte(47), CByte(31))
        Panel1.Controls.Add(closeBtn)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(472, 42)
        Panel1.TabIndex = 10
        ' 
        ' closeBtn
        ' 
        closeBtn.BackColor = Color.Transparent
        closeBtn.BackgroundImage = CType(resources.GetObject("closeBtn.BackgroundImage"), Image)
        closeBtn.BackgroundImageLayout = ImageLayout.Stretch
        closeBtn.Cursor = Cursors.Hand
        closeBtn.Location = New Point(450, 3)
        closeBtn.Name = "closeBtn"
        closeBtn.Size = New Size(22, 21)
        closeBtn.TabIndex = 3
        closeBtn.TabStop = False
        ' 
        ' Scan_Label
        ' 
        Scan_Label.AutoSize = True
        Scan_Label.Font = New Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Scan_Label.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Scan_Label.Location = New Point(133, 247)
        Scan_Label.Name = "Scan_Label"
        Scan_Label.Size = New Size(202, 29)
        Scan_Label.TabIndex = 11
        Scan_Label.Text = "TAP RFID TO LOGIN"
        ' 
        ' Granted_Access_Logo
        ' 
        Granted_Access_Logo.Image = CType(resources.GetObject("Granted_Access_Logo.Image"), Image)
        Granted_Access_Logo.Location = New Point(117, 305)
        Granted_Access_Logo.Name = "Granted_Access_Logo"
        Granted_Access_Logo.Size = New Size(227, 163)
        Granted_Access_Logo.SizeMode = PictureBoxSizeMode.CenterImage
        Granted_Access_Logo.TabIndex = 12
        Granted_Access_Logo.TabStop = False
        Granted_Access_Logo.Visible = False
        ' 
        ' Scan_Denied_Logo
        ' 
        Scan_Denied_Logo.Image = CType(resources.GetObject("Scan_Denied_Logo.Image"), Image)
        Scan_Denied_Logo.Location = New Point(117, 305)
        Scan_Denied_Logo.Name = "Scan_Denied_Logo"
        Scan_Denied_Logo.Size = New Size(227, 163)
        Scan_Denied_Logo.SizeMode = PictureBoxSizeMode.Zoom
        Scan_Denied_Logo.TabIndex = 13
        Scan_Denied_Logo.TabStop = False
        Scan_Denied_Logo.Visible = False
        ' 
        ' txtrfidlogin
        ' 
        txtrfidlogin.Location = New Point(177, 122)
        txtrfidlogin.Name = "txtrfidlogin"
        txtrfidlogin.Size = New Size(130, 23)
        txtrfidlogin.TabIndex = 14
        ' 
        ' logo
        ' 
        logo.BackgroundImage = CType(resources.GetObject("logo.BackgroundImage"), Image)
        logo.BackgroundImageLayout = ImageLayout.Zoom
        logo.Location = New Point(165, 69)
        logo.Name = "logo"
        logo.Size = New Size(153, 135)
        logo.TabIndex = 15
        logo.TabStop = False
        ' 
        ' ScanRFID_Logo
        ' 
        ScanRFID_Logo.Image = CType(resources.GetObject("ScanRFID_Logo.Image"), Image)
        ScanRFID_Logo.Location = New Point(117, 305)
        ScanRFID_Logo.Name = "ScanRFID_Logo"
        ScanRFID_Logo.Size = New Size(227, 163)
        ScanRFID_Logo.SizeMode = PictureBoxSizeMode.Zoom
        ScanRFID_Logo.TabIndex = 16
        ScanRFID_Logo.TabStop = False
        ' 
        ' lk1register
        ' 
        lk1register.AutoSize = True
        lk1register.Location = New Point(211, 488)
        lk1register.Name = "lk1register"
        lk1register.Size = New Size(49, 15)
        lk1register.TabIndex = 19
        lk1register.TabStop = True
        lk1register.Text = "Register"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(2), CByte(47), CByte(31))
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 533)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(472, 42)
        Panel2.TabIndex = 20
        ' 
        ' rfidlink
        ' 
        rfidlink.AutoSize = True
        rfidlink.Location = New Point(133, 515)
        rfidlink.Name = "rfidlink"
        rfidlink.Size = New Size(194, 15)
        rfidlink.TabIndex = 21
        rfidlink.TabStop = True
        rfidlink.Text = "Don't have RFID device? CLick here!"
        ' 
        ' clearinputtimer
        ' 
        ' 
        ' hidelogos
        ' 
        hidelogos.Interval = 3000
        ' 
        ' ScanRFIDLOGIN
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Beige
        ClientSize = New Size(472, 575)
        Controls.Add(rfidlink)
        Controls.Add(Panel2)
        Controls.Add(lk1register)
        Controls.Add(ScanRFID_Logo)
        Controls.Add(logo)
        Controls.Add(txtrfidlogin)
        Controls.Add(Scan_Denied_Logo)
        Controls.Add(Granted_Access_Logo)
        Controls.Add(Scan_Label)
        Controls.Add(Panel1)
        ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        FormBorderStyle = FormBorderStyle.None
        Name = "ScanRFIDLOGIN"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ScanRFIDLOGIN"
        Panel1.ResumeLayout(False)
        CType(closeBtn, ComponentModel.ISupportInitialize).EndInit()
        CType(Granted_Access_Logo, ComponentModel.ISupportInitialize).EndInit()
        CType(Scan_Denied_Logo, ComponentModel.ISupportInitialize).EndInit()
        CType(logo, ComponentModel.ISupportInitialize).EndInit()
        CType(ScanRFID_Logo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Scan_Label As Label
    Friend WithEvents Granted_Access_Logo As PictureBox
    Friend WithEvents Scan_Denied_Logo As PictureBox
    Friend WithEvents txtrfidlogin As TextBox
    Friend WithEvents logo As PictureBox
    Friend WithEvents ScanRFID_Logo As PictureBox
    Friend WithEvents lk1register As LinkLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents closeBtn As PictureBox
    Friend WithEvents rfidlink As LinkLabel
    Friend WithEvents clearinputtimer As Timer
    Friend WithEvents hidelogos As Timer
End Class
