<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rfidandPinRegistrationforinstructors
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rfidandPinRegistrationforinstructors))
        rfidscanpanel = New Panel()
        Panel2 = New Panel()
        ScanDoneLogo = New PictureBox()
        logo = New PictureBox()
        txtRfidRegister = New TextBox()
        ScanRFID_Logo = New PictureBox()
        Scan_Label = New Label()
        pinloginregpanel = New Panel()
        clearPinBtn = New PictureBox()
        Panel7 = New Panel()
        Panel6 = New Panel()
        PinMinimize = New PictureBox()
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
        RFIDTIMER = New Timer(components)
        accountdialogtimer = New Timer(components)
        rfidscanpanel.SuspendLayout()
        CType(ScanDoneLogo, ComponentModel.ISupportInitialize).BeginInit()
        CType(logo, ComponentModel.ISupportInitialize).BeginInit()
        CType(ScanRFID_Logo, ComponentModel.ISupportInitialize).BeginInit()
        pinloginregpanel.SuspendLayout()
        CType(clearPinBtn, ComponentModel.ISupportInitialize).BeginInit()
        CType(PinMinimize, ComponentModel.ISupportInitialize).BeginInit()
        CType(PinClose, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
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
        ' pinloginregpanel
        ' 
        pinloginregpanel.BackColor = Color.Beige
        pinloginregpanel.Controls.Add(clearPinBtn)
        pinloginregpanel.Controls.Add(Panel7)
        pinloginregpanel.Controls.Add(Panel6)
        pinloginregpanel.Controls.Add(PinMinimize)
        pinloginregpanel.Controls.Add(PinClose)
        pinloginregpanel.Controls.Add(Label3)
        pinloginregpanel.Controls.Add(Button13)
        pinloginregpanel.Controls.Add(Button9)
        pinloginregpanel.Controls.Add(Button10)
        pinloginregpanel.Controls.Add(Button11)
        pinloginregpanel.Controls.Add(Button6)
        pinloginregpanel.Controls.Add(Button7)
        pinloginregpanel.Controls.Add(Button8)
        pinloginregpanel.Controls.Add(Button5)
        pinloginregpanel.Controls.Add(Button4)
        pinloginregpanel.Controls.Add(Button3)
        pinloginregpanel.Controls.Add(txtpin4)
        pinloginregpanel.Controls.Add(txtpin3)
        pinloginregpanel.Controls.Add(txtpin2)
        pinloginregpanel.Controls.Add(txtpin1)
        pinloginregpanel.Controls.Add(PictureBox2)
        pinloginregpanel.Location = New Point(528, 74)
        pinloginregpanel.Name = "pinloginregpanel"
        pinloginregpanel.Size = New Size(431, 480)
        pinloginregpanel.TabIndex = 21
        pinloginregpanel.Visible = False
        ' 
        ' clearPinBtn
        ' 
        clearPinBtn.Cursor = Cursors.Hand
        clearPinBtn.Image = CType(resources.GetObject("clearPinBtn.Image"), Image)
        clearPinBtn.Location = New Point(261, 351)
        clearPinBtn.Name = "clearPinBtn"
        clearPinBtn.Size = New Size(78, 58)
        clearPinBtn.SizeMode = PictureBoxSizeMode.CenterImage
        clearPinBtn.TabIndex = 28
        clearPinBtn.TabStop = False
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.FromArgb(CByte(10), CByte(55), CByte(39))
        Panel7.Dock = DockStyle.Top
        Panel7.Location = New Point(0, 0)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(431, 32)
        Panel7.TabIndex = 27
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
        ' RFIDTIMER
        ' 
        RFIDTIMER.Interval = 1000
        ' 
        ' accountdialogtimer
        ' 
        accountdialogtimer.Interval = 5000
        ' 
        ' rfidandPinRegistrationforinstructors
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Beige
        ClientSize = New Size(423, 479)
        Controls.Add(pinloginregpanel)
        Controls.Add(rfidscanpanel)
        FormBorderStyle = FormBorderStyle.None
        Name = "rfidandPinRegistrationforinstructors"
        StartPosition = FormStartPosition.CenterScreen
        Text = "rfidandPinRegistrationforinstructors"
        rfidscanpanel.ResumeLayout(False)
        rfidscanpanel.PerformLayout()
        CType(ScanDoneLogo, ComponentModel.ISupportInitialize).EndInit()
        CType(logo, ComponentModel.ISupportInitialize).EndInit()
        CType(ScanRFID_Logo, ComponentModel.ISupportInitialize).EndInit()
        pinloginregpanel.ResumeLayout(False)
        pinloginregpanel.PerformLayout()
        CType(clearPinBtn, ComponentModel.ISupportInitialize).EndInit()
        CType(PinMinimize, ComponentModel.ISupportInitialize).EndInit()
        CType(PinClose, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents rfidscanpanel As Panel
    Friend WithEvents ScanDoneLogo As PictureBox
    Friend WithEvents logo As PictureBox
    Friend WithEvents txtRfidRegister As TextBox
    Friend WithEvents ScanRFID_Logo As PictureBox
    Friend WithEvents Scan_Label As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents pinloginregpanel As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PinMinimize As PictureBox
    Friend WithEvents PinClose As PictureBox
    Friend WithEvents Label3 As Label
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
    Friend WithEvents txtpin3 As TextBox
    Friend WithEvents txtpin2 As TextBox
    Friend WithEvents txtpin1 As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents RFIDTIMER As Timer
    Friend WithEvents clearPinBtn As PictureBox
    Friend WithEvents accountCreatedDialog As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents accountdialogtimer As Timer
End Class
