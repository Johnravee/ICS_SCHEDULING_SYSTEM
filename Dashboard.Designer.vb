<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Panel1 = New Panel()
        ProfileBtn = New Button()
        LogoutBtn = New Button()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        minimizeBtn = New PictureBox()
        closeBtn = New PictureBox()
        Label1 = New Label()
        Panel3 = New Panel()
        Button8 = New Button()
        Button7 = New Button()
        Button6 = New Button()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(minimizeBtn, ComponentModel.ISupportInitialize).BeginInit()
        CType(closeBtn, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(51), CByte(38))
        Panel1.Controls.Add(ProfileBtn)
        Panel1.Controls.Add(LogoutBtn)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(79, 756)
        Panel1.TabIndex = 0
        ' 
        ' ProfileBtn
        ' 
        ProfileBtn.BackColor = Color.Transparent
        ProfileBtn.BackgroundImage = CType(resources.GetObject("ProfileBtn.BackgroundImage"), Image)
        ProfileBtn.BackgroundImageLayout = ImageLayout.Zoom
        ProfileBtn.Cursor = Cursors.Hand
        ProfileBtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(1), CByte(47), CByte(31))
        ProfileBtn.FlatAppearance.BorderSize = 0
        ProfileBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(29), CByte(53), CByte(50))
        ProfileBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(29), CByte(53), CByte(50))
        ProfileBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(29), CByte(53), CByte(50))
        ProfileBtn.FlatStyle = FlatStyle.Flat
        ProfileBtn.Location = New Point(12, 611)
        ProfileBtn.Name = "ProfileBtn"
        ProfileBtn.Size = New Size(48, 44)
        ProfileBtn.TabIndex = 2
        ProfileBtn.UseVisualStyleBackColor = False
        ' 
        ' LogoutBtn
        ' 
        LogoutBtn.BackColor = Color.Transparent
        LogoutBtn.BackgroundImage = CType(resources.GetObject("LogoutBtn.BackgroundImage"), Image)
        LogoutBtn.BackgroundImageLayout = ImageLayout.Zoom
        LogoutBtn.Cursor = Cursors.Hand
        LogoutBtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(1), CByte(47), CByte(31))
        LogoutBtn.FlatAppearance.BorderSize = 0
        LogoutBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(29), CByte(53), CByte(50))
        LogoutBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(29), CByte(53), CByte(50))
        LogoutBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(29), CByte(53), CByte(50))
        LogoutBtn.FlatStyle = FlatStyle.Flat
        LogoutBtn.Location = New Point(12, 684)
        LogoutBtn.Name = "LogoutBtn"
        LogoutBtn.Size = New Size(48, 44)
        LogoutBtn.TabIndex = 1
        LogoutBtn.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(16, 9)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(44, 42)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(0), CByte(51), CByte(38))
        Panel2.Controls.Add(minimizeBtn)
        Panel2.Controls.Add(closeBtn)
        Panel2.Controls.Add(Label1)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(79, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1404, 61)
        Panel2.TabIndex = 1
        ' 
        ' minimizeBtn
        ' 
        minimizeBtn.BackColor = Color.Transparent
        minimizeBtn.BackgroundImage = CType(resources.GetObject("minimizeBtn.BackgroundImage"), Image)
        minimizeBtn.BackgroundImageLayout = ImageLayout.Stretch
        minimizeBtn.Cursor = Cursors.Hand
        minimizeBtn.Location = New Point(1351, 3)
        minimizeBtn.Name = "minimizeBtn"
        minimizeBtn.Size = New Size(22, 21)
        minimizeBtn.TabIndex = 3
        minimizeBtn.TabStop = False
        ' 
        ' closeBtn
        ' 
        closeBtn.BackColor = Color.Transparent
        closeBtn.BackgroundImage = CType(resources.GetObject("closeBtn.BackgroundImage"), Image)
        closeBtn.BackgroundImageLayout = ImageLayout.Stretch
        closeBtn.Cursor = Cursors.Hand
        closeBtn.Location = New Point(1370, 3)
        closeBtn.Name = "closeBtn"
        closeBtn.Size = New Size(22, 21)
        closeBtn.TabIndex = 2
        closeBtn.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Calibri", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.WhiteSmoke
        Label1.Location = New Point(0, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(206, 42)
        Label1.TabIndex = 0
        Label1.Text = "DASHBOARD"
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Button8)
        Panel3.Controls.Add(Button7)
        Panel3.Controls.Add(Button6)
        Panel3.Controls.Add(Button5)
        Panel3.Controls.Add(Button4)
        Panel3.Controls.Add(Button3)
        Panel3.Controls.Add(Button2)
        Panel3.Controls.Add(Button1)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(79, 61)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1404, 695)
        Panel3.TabIndex = 2
        ' 
        ' Button8
        ' 
        Button8.AutoSize = True
        Button8.BackColor = Color.LightYellow
        Button8.Cursor = Cursors.Hand
        Button8.FlatAppearance.BorderColor = Color.Khaki
        Button8.FlatStyle = FlatStyle.Flat
        Button8.Font = New Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button8.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button8.Image = CType(resources.GetObject("Button8.Image"), Image)
        Button8.Location = New Point(736, 507)
        Button8.Name = "Button8"
        Button8.Size = New Size(591, 122)
        Button8.TabIndex = 15
        Button8.Text = "    Management"
        Button8.TextAlign = ContentAlignment.MiddleRight
        Button8.TextImageRelation = TextImageRelation.ImageBeforeText
        Button8.UseVisualStyleBackColor = False
        ' 
        ' Button7
        ' 
        Button7.AutoSize = True
        Button7.BackColor = Color.LightYellow
        Button7.Cursor = Cursors.Hand
        Button7.FlatAppearance.BorderColor = Color.Khaki
        Button7.FlatStyle = FlatStyle.Flat
        Button7.Font = New Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button7.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button7.Image = CType(resources.GetObject("Button7.Image"), Image)
        Button7.Location = New Point(68, 507)
        Button7.Name = "Button7"
        Button7.Size = New Size(591, 122)
        Button7.TabIndex = 15
        Button7.Text = "    Summary"
        Button7.TextAlign = ContentAlignment.MiddleRight
        Button7.TextImageRelation = TextImageRelation.ImageBeforeText
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.AutoSize = True
        Button6.BackColor = Color.LightYellow
        Button6.Cursor = Cursors.Hand
        Button6.FlatAppearance.BorderColor = Color.Khaki
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Font = New Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button6.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button6.Image = CType(resources.GetObject("Button6.Image"), Image)
        Button6.Location = New Point(736, 350)
        Button6.Name = "Button6"
        Button6.Size = New Size(591, 103)
        Button6.TabIndex = 14
        Button6.Text = "    Subjects"
        Button6.TextAlign = ContentAlignment.MiddleRight
        Button6.TextImageRelation = TextImageRelation.ImageBeforeText
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.AutoSize = True
        Button5.BackColor = Color.LightYellow
        Button5.Cursor = Cursors.Hand
        Button5.FlatAppearance.BorderColor = Color.Khaki
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button5.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button5.Image = CType(resources.GetObject("Button5.Image"), Image)
        Button5.Location = New Point(68, 350)
        Button5.Name = "Button5"
        Button5.Size = New Size(591, 103)
        Button5.TabIndex = 13
        Button5.Text = "    Sections"
        Button5.TextAlign = ContentAlignment.MiddleRight
        Button5.TextImageRelation = TextImageRelation.ImageBeforeText
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.AutoSize = True
        Button4.BackColor = Color.LightYellow
        Button4.Cursor = Cursors.Hand
        Button4.FlatAppearance.BorderColor = Color.Khaki
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button4.Image = CType(resources.GetObject("Button4.Image"), Image)
        Button4.Location = New Point(736, 204)
        Button4.Name = "Button4"
        Button4.Size = New Size(591, 103)
        Button4.TabIndex = 12
        Button4.Text = "    Instructors"
        Button4.TextAlign = ContentAlignment.MiddleRight
        Button4.TextImageRelation = TextImageRelation.ImageBeforeText
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.AutoSize = True
        Button3.BackColor = Color.LightYellow
        Button3.Cursor = Cursors.Hand
        Button3.FlatAppearance.BorderColor = Color.Khaki
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button3.Image = CType(resources.GetObject("Button3.Image"), Image)
        Button3.Location = New Point(68, 204)
        Button3.Name = "Button3"
        Button3.Size = New Size(591, 103)
        Button3.TabIndex = 11
        Button3.Text = "    Facilities"
        Button3.TextAlign = ContentAlignment.MiddleRight
        Button3.TextImageRelation = TextImageRelation.ImageBeforeText
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.AutoSize = True
        Button2.BackColor = Color.LightYellow
        Button2.Cursor = Cursors.Hand
        Button2.FlatAppearance.BorderColor = Color.Khaki
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button2.Image = CType(resources.GetObject("Button2.Image"), Image)
        Button2.Location = New Point(736, 51)
        Button2.Name = "Button2"
        Button2.Size = New Size(591, 103)
        Button2.TabIndex = 10
        Button2.Text = "    New Schedule"
        Button2.TextAlign = ContentAlignment.MiddleRight
        Button2.TextImageRelation = TextImageRelation.ImageBeforeText
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.AutoSize = True
        Button1.BackColor = Color.LightYellow
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderColor = Color.Khaki
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.Location = New Point(68, 51)
        Button1.Name = "Button1"
        Button1.Size = New Size(591, 103)
        Button1.TabIndex = 9
        Button1.Text = "    New Instructor"
        Button1.TextAlign = ContentAlignment.MiddleRight
        Button1.TextImageRelation = TextImageRelation.ImageBeforeText
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        BackColor = Color.Beige
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(1483, 756)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "Dashboard"
        RightToLeftLayout = True
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(minimizeBtn, ComponentModel.ISupportInitialize).EndInit()
        CType(closeBtn, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents LogoutBtn As Button
    Friend WithEvents ProfileBtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents minimizeBtn As PictureBox
    Friend WithEvents closeBtn As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button8 As Button

End Class
