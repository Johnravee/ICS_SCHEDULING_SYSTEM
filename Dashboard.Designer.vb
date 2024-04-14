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
        LogoutBtn = New Button()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        minimizeBtn = New PictureBox()
        closeBtn = New PictureBox()
        Label1 = New Label()
        Panel3 = New Panel()
        btnManagement = New Button()
        btnViewSummary = New Button()
        btnViewSubject = New Button()
        btnViewSection = New Button()
        btnViewInstructor = New Button()
        btnViewFacilities = New Button()
        btnNewSched = New Button()
        btnNewInstructor = New Button()
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
        Panel1.Controls.Add(LogoutBtn)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(79, 756)
        Panel1.TabIndex = 0
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
        minimizeBtn.Location = New Point(1360, 3)
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
        closeBtn.Location = New Point(1379, 3)
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
        Panel3.Controls.Add(btnManagement)
        Panel3.Controls.Add(btnViewSummary)
        Panel3.Controls.Add(btnViewSubject)
        Panel3.Controls.Add(btnViewSection)
        Panel3.Controls.Add(btnViewInstructor)
        Panel3.Controls.Add(btnViewFacilities)
        Panel3.Controls.Add(btnNewSched)
        Panel3.Controls.Add(btnNewInstructor)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(79, 61)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1404, 695)
        Panel3.TabIndex = 2
        ' 
        ' btnManagement
        ' 
        btnManagement.AutoSize = True
        btnManagement.BackColor = Color.LightYellow
        btnManagement.Cursor = Cursors.Hand
        btnManagement.FlatAppearance.BorderColor = Color.Khaki
        btnManagement.FlatStyle = FlatStyle.Flat
        btnManagement.Font = New Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnManagement.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnManagement.Image = CType(resources.GetObject("btnManagement.Image"), Image)
        btnManagement.Location = New Point(736, 507)
        btnManagement.Name = "btnManagement"
        btnManagement.Size = New Size(591, 122)
        btnManagement.TabIndex = 15
        btnManagement.Text = "    Management"
        btnManagement.TextAlign = ContentAlignment.MiddleRight
        btnManagement.TextImageRelation = TextImageRelation.ImageBeforeText
        btnManagement.UseVisualStyleBackColor = False
        ' 
        ' btnViewSummary
        ' 
        btnViewSummary.AutoSize = True
        btnViewSummary.BackColor = Color.LightYellow
        btnViewSummary.Cursor = Cursors.Hand
        btnViewSummary.FlatAppearance.BorderColor = Color.Khaki
        btnViewSummary.FlatStyle = FlatStyle.Flat
        btnViewSummary.Font = New Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnViewSummary.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnViewSummary.Image = CType(resources.GetObject("btnViewSummary.Image"), Image)
        btnViewSummary.Location = New Point(68, 507)
        btnViewSummary.Name = "btnViewSummary"
        btnViewSummary.Size = New Size(591, 122)
        btnViewSummary.TabIndex = 15
        btnViewSummary.Text = "    Summary"
        btnViewSummary.TextAlign = ContentAlignment.MiddleRight
        btnViewSummary.TextImageRelation = TextImageRelation.ImageBeforeText
        btnViewSummary.UseVisualStyleBackColor = False
        ' 
        ' btnViewSubject
        ' 
        btnViewSubject.AutoSize = True
        btnViewSubject.BackColor = Color.LightYellow
        btnViewSubject.Cursor = Cursors.Hand
        btnViewSubject.FlatAppearance.BorderColor = Color.Khaki
        btnViewSubject.FlatStyle = FlatStyle.Flat
        btnViewSubject.Font = New Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnViewSubject.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnViewSubject.Image = CType(resources.GetObject("btnViewSubject.Image"), Image)
        btnViewSubject.Location = New Point(736, 350)
        btnViewSubject.Name = "btnViewSubject"
        btnViewSubject.Size = New Size(591, 103)
        btnViewSubject.TabIndex = 14
        btnViewSubject.Text = "    Subjects"
        btnViewSubject.TextAlign = ContentAlignment.MiddleRight
        btnViewSubject.TextImageRelation = TextImageRelation.ImageBeforeText
        btnViewSubject.UseVisualStyleBackColor = False
        ' 
        ' btnViewSection
        ' 
        btnViewSection.AutoSize = True
        btnViewSection.BackColor = Color.LightYellow
        btnViewSection.Cursor = Cursors.Hand
        btnViewSection.FlatAppearance.BorderColor = Color.Khaki
        btnViewSection.FlatStyle = FlatStyle.Flat
        btnViewSection.Font = New Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnViewSection.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnViewSection.Image = CType(resources.GetObject("btnViewSection.Image"), Image)
        btnViewSection.Location = New Point(68, 350)
        btnViewSection.Name = "btnViewSection"
        btnViewSection.Size = New Size(591, 103)
        btnViewSection.TabIndex = 13
        btnViewSection.Text = "    Sections"
        btnViewSection.TextAlign = ContentAlignment.MiddleRight
        btnViewSection.TextImageRelation = TextImageRelation.ImageBeforeText
        btnViewSection.UseVisualStyleBackColor = False
        ' 
        ' btnViewInstructor
        ' 
        btnViewInstructor.AutoSize = True
        btnViewInstructor.BackColor = Color.LightYellow
        btnViewInstructor.Cursor = Cursors.Hand
        btnViewInstructor.FlatAppearance.BorderColor = Color.Khaki
        btnViewInstructor.FlatStyle = FlatStyle.Flat
        btnViewInstructor.Font = New Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnViewInstructor.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnViewInstructor.Image = CType(resources.GetObject("btnViewInstructor.Image"), Image)
        btnViewInstructor.Location = New Point(736, 204)
        btnViewInstructor.Name = "btnViewInstructor"
        btnViewInstructor.Size = New Size(591, 103)
        btnViewInstructor.TabIndex = 12
        btnViewInstructor.Text = "    Instructors"
        btnViewInstructor.TextAlign = ContentAlignment.MiddleRight
        btnViewInstructor.TextImageRelation = TextImageRelation.ImageBeforeText
        btnViewInstructor.UseVisualStyleBackColor = False
        ' 
        ' btnViewFacilities
        ' 
        btnViewFacilities.AutoSize = True
        btnViewFacilities.BackColor = Color.LightYellow
        btnViewFacilities.Cursor = Cursors.Hand
        btnViewFacilities.FlatAppearance.BorderColor = Color.Khaki
        btnViewFacilities.FlatStyle = FlatStyle.Flat
        btnViewFacilities.Font = New Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnViewFacilities.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnViewFacilities.Image = CType(resources.GetObject("btnViewFacilities.Image"), Image)
        btnViewFacilities.Location = New Point(68, 204)
        btnViewFacilities.Name = "btnViewFacilities"
        btnViewFacilities.Size = New Size(591, 103)
        btnViewFacilities.TabIndex = 11
        btnViewFacilities.Text = "    Facilities"
        btnViewFacilities.TextAlign = ContentAlignment.MiddleRight
        btnViewFacilities.TextImageRelation = TextImageRelation.ImageBeforeText
        btnViewFacilities.UseVisualStyleBackColor = False
        ' 
        ' btnNewSched
        ' 
        btnNewSched.AutoSize = True
        btnNewSched.BackColor = Color.LightYellow
        btnNewSched.Cursor = Cursors.Hand
        btnNewSched.FlatAppearance.BorderColor = Color.Khaki
        btnNewSched.FlatStyle = FlatStyle.Flat
        btnNewSched.Font = New Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnNewSched.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnNewSched.Image = CType(resources.GetObject("btnNewSched.Image"), Image)
        btnNewSched.Location = New Point(736, 51)
        btnNewSched.Name = "btnNewSched"
        btnNewSched.Size = New Size(591, 103)
        btnNewSched.TabIndex = 10
        btnNewSched.Text = "    New Schedule"
        btnNewSched.TextAlign = ContentAlignment.MiddleRight
        btnNewSched.TextImageRelation = TextImageRelation.ImageBeforeText
        btnNewSched.UseVisualStyleBackColor = False
        ' 
        ' btnNewInstructor
        ' 
        btnNewInstructor.AutoSize = True
        btnNewInstructor.BackColor = Color.LightYellow
        btnNewInstructor.Cursor = Cursors.Hand
        btnNewInstructor.FlatAppearance.BorderColor = Color.Khaki
        btnNewInstructor.FlatStyle = FlatStyle.Flat
        btnNewInstructor.Font = New Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnNewInstructor.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnNewInstructor.Image = CType(resources.GetObject("btnNewInstructor.Image"), Image)
        btnNewInstructor.Location = New Point(68, 51)
        btnNewInstructor.Name = "btnNewInstructor"
        btnNewInstructor.Size = New Size(591, 103)
        btnNewInstructor.TabIndex = 9
        btnNewInstructor.Text = "    New Instructor"
        btnNewInstructor.TextAlign = ContentAlignment.MiddleRight
        btnNewInstructor.TextImageRelation = TextImageRelation.ImageBeforeText
        btnNewInstructor.UseVisualStyleBackColor = False
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
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents minimizeBtn As PictureBox
    Friend WithEvents closeBtn As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnViewSummary As Button
    Friend WithEvents btnViewSubject As Button
    Friend WithEvents btnViewSection As Button
    Friend WithEvents btnViewInstructor As Button
    Friend WithEvents btnViewFacilities As Button
    Friend WithEvents btnNewSched As Button
    Friend WithEvents btnNewInstructor As Button
    Friend WithEvents btnManagement As Button

End Class
