<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManagementScheduleForm
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
        Panel1 = New Panel()
        BackBtn = New Button()
        Panel2 = New Panel()
        SectionListBtn = New Button()
        ScheduleListBtn = New Button()
        FacilityListBtn = New Button()
        InstructorListBtn = New Button()
        Panel3 = New Panel()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.AccessibleRole = AccessibleRole.MenuBar
        Panel1.BackColor = Color.FromArgb(CByte(2), CByte(47), CByte(31))
        Panel1.Controls.Add(BackBtn)
        Panel1.Dock = DockStyle.Top
        Panel1.ForeColor = Color.FromArgb(CByte(2), CByte(47), CByte(31))
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1220, 42)
        Panel1.TabIndex = 2
        ' 
        ' BackBtn
        ' 
        BackBtn.BackColor = Color.FromArgb(CByte(2), CByte(47), CByte(31))
        BackBtn.BackgroundImage = My.Resources.Resources.backBtn_removebg_preview
        BackBtn.BackgroundImageLayout = ImageLayout.Stretch
        BackBtn.FlatStyle = FlatStyle.Flat
        BackBtn.Location = New Point(9, 6)
        BackBtn.Margin = New Padding(3, 2, 3, 2)
        BackBtn.Name = "BackBtn"
        BackBtn.Size = New Size(39, 30)
        BackBtn.TabIndex = 0
        BackBtn.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.AccessibleRole = AccessibleRole.MenuBar
        Panel2.BackColor = Color.FromArgb(CByte(2), CByte(47), CByte(31))
        Panel2.Controls.Add(SectionListBtn)
        Panel2.Controls.Add(ScheduleListBtn)
        Panel2.Controls.Add(FacilityListBtn)
        Panel2.Controls.Add(InstructorListBtn)
        Panel2.Dock = DockStyle.Left
        Panel2.ForeColor = Color.FromArgb(CByte(2), CByte(47), CByte(31))
        Panel2.Location = New Point(0, 42)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(173, 613)
        Panel2.TabIndex = 2
        ' 
        ' SectionListBtn
        ' 
        SectionListBtn.BackColor = Color.LightYellow
        SectionListBtn.BackgroundImageLayout = ImageLayout.None
        SectionListBtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(195), CByte(176), CByte(145))
        SectionListBtn.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SectionListBtn.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        SectionListBtn.Image = My.Resources.Resources.icons8_information_50
        SectionListBtn.ImageAlign = ContentAlignment.TopLeft
        SectionListBtn.Location = New Point(10, 329)
        SectionListBtn.Margin = New Padding(3, 2, 3, 2)
        SectionListBtn.Name = "SectionListBtn"
        SectionListBtn.Size = New Size(154, 59)
        SectionListBtn.TabIndex = 3
        SectionListBtn.Text = "Section Lists    "
        SectionListBtn.TextAlign = ContentAlignment.BottomCenter
        SectionListBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        SectionListBtn.UseVisualStyleBackColor = False
        ' 
        ' ScheduleListBtn
        ' 
        ScheduleListBtn.BackColor = Color.Beige
        ScheduleListBtn.BackgroundImageLayout = ImageLayout.None
        ScheduleListBtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(195), CByte(176), CByte(145))
        ScheduleListBtn.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ScheduleListBtn.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ScheduleListBtn.Image = My.Resources.Resources.icons8_information_50
        ScheduleListBtn.ImageAlign = ContentAlignment.TopLeft
        ScheduleListBtn.Location = New Point(9, 459)
        ScheduleListBtn.Margin = New Padding(3, 2, 3, 2)
        ScheduleListBtn.Name = "ScheduleListBtn"
        ScheduleListBtn.Size = New Size(154, 59)
        ScheduleListBtn.TabIndex = 3
        ScheduleListBtn.Text = "Schedule Lists"
        ScheduleListBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        ScheduleListBtn.UseVisualStyleBackColor = False
        ' 
        ' FacilityListBtn
        ' 
        FacilityListBtn.BackColor = Color.LightYellow
        FacilityListBtn.BackgroundImageLayout = ImageLayout.None
        FacilityListBtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(195), CByte(176), CByte(145))
        FacilityListBtn.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FacilityListBtn.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        FacilityListBtn.Image = My.Resources.Resources.icons8_information_50
        FacilityListBtn.ImageAlign = ContentAlignment.TopLeft
        FacilityListBtn.Location = New Point(9, 195)
        FacilityListBtn.Margin = New Padding(3, 2, 3, 2)
        FacilityListBtn.Name = "FacilityListBtn"
        FacilityListBtn.Size = New Size(154, 59)
        FacilityListBtn.TabIndex = 3
        FacilityListBtn.Text = "Facility Lists    "
        FacilityListBtn.TextAlign = ContentAlignment.BottomCenter
        FacilityListBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        FacilityListBtn.UseVisualStyleBackColor = False
        ' 
        ' InstructorListBtn
        ' 
        InstructorListBtn.BackColor = Color.LightYellow
        InstructorListBtn.BackgroundImageLayout = ImageLayout.None
        InstructorListBtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(195), CByte(176), CByte(145))
        InstructorListBtn.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        InstructorListBtn.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        InstructorListBtn.Image = My.Resources.Resources.icons8_information_50
        InstructorListBtn.ImageAlign = ContentAlignment.TopLeft
        InstructorListBtn.Location = New Point(10, 58)
        InstructorListBtn.Margin = New Padding(3, 2, 3, 2)
        InstructorListBtn.Name = "InstructorListBtn"
        InstructorListBtn.Size = New Size(153, 59)
        InstructorListBtn.TabIndex = 3
        InstructorListBtn.Text = "Instructor Lists"
        InstructorListBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        InstructorListBtn.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.Location = New Point(170, 42)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1050, 609)
        Panel3.TabIndex = 3
        ' 
        ' ManagementScheduleForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Beige
        ClientSize = New Size(1220, 655)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "ManagementScheduleForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ManagementScheduleForm"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BackBtn As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ScheduleListBtn As Button
    Friend WithEvents InstructorListBtn As Button
    Friend WithEvents SectionListBtn As Button
    Friend WithEvents FacilityListBtn As Button
    Friend WithEvents Panel3 As Panel
End Class
