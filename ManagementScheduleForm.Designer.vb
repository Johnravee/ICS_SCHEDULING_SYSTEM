<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagementScheduleForm
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
        Panel1 = New Panel()
        BackBtn = New Button()
        Panel2 = New Panel()
        SectionListBtn = New Button()
        InstructorListBtn = New Button()
        FacilityListBtn = New Button()
        ScheduleListBtn = New Button()
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
        Panel1.ForeColor = Color.FromArgb(CByte(2), CByte(47), CByte(31))
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1484, 75)
        Panel1.TabIndex = 2
        ' 
        ' BackBtn
        ' 
        BackBtn.BackColor = Color.FromArgb(CByte(2), CByte(47), CByte(31))
        BackBtn.BackgroundImage = My.Resources.Resources.backBtn_removebg_preview
        BackBtn.BackgroundImageLayout = ImageLayout.Stretch
        BackBtn.FlatStyle = FlatStyle.Flat
        BackBtn.Location = New Point(11, 12)
        BackBtn.Name = "BackBtn"
        BackBtn.Size = New Size(45, 40)
        BackBtn.TabIndex = 0
        BackBtn.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.AccessibleRole = AccessibleRole.MenuBar
        Panel2.BackColor = Color.FromArgb(CByte(2), CByte(47), CByte(31))
        Panel2.Controls.Add(SectionListBtn)
        Panel2.Controls.Add(InstructorListBtn)
        Panel2.Controls.Add(FacilityListBtn)
        Panel2.Controls.Add(ScheduleListBtn)
        Panel2.ForeColor = Color.FromArgb(CByte(2), CByte(47), CByte(31))
        Panel2.Location = New Point(0, 75)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(259, 684)
        Panel2.TabIndex = 2
        ' 
        ' SectionListBtn
        ' 
        SectionListBtn.BackColor = Color.Beige

        SectionListBtn.BackgroundImageLayout = ImageLayout.None
        SectionListBtn.Font = New Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SectionListBtn.ImageAlign = ContentAlignment.TopLeft
        SectionListBtn.Location = New Point(23, 524)
        SectionListBtn.Name = "SectionListBtn"
        SectionListBtn.Size = New Size(211, 94)
        SectionListBtn.TabIndex = 3
        SectionListBtn.Text = "Section List    "
        SectionListBtn.TextAlign = ContentAlignment.MiddleRight
        SectionListBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        SectionListBtn.UseVisualStyleBackColor = False
        ' 
        ' InstructorListBtn
        ' 
        InstructorListBtn.BackColor = Color.Beige

        InstructorListBtn.BackgroundImageLayout = ImageLayout.None
        InstructorListBtn.Font = New Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        InstructorListBtn.ImageAlign = ContentAlignment.TopLeft
        InstructorListBtn.Location = New Point(23, 61)
        InstructorListBtn.Name = "InstructorListBtn"
        InstructorListBtn.Size = New Size(211, 94)
        InstructorListBtn.TabIndex = 3
        InstructorListBtn.Text = "Instructor List  "
        InstructorListBtn.TextAlign = ContentAlignment.MiddleRight
        InstructorListBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        InstructorListBtn.UseVisualStyleBackColor = False
        ' 
        ' FacilityListBtn
        ' 
        FacilityListBtn.BackColor = Color.Beige

        FacilityListBtn.BackgroundImageLayout = ImageLayout.None
        FacilityListBtn.Font = New Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FacilityListBtn.ImageAlign = ContentAlignment.TopLeft
        FacilityListBtn.Location = New Point(23, 369)
        FacilityListBtn.Name = "FacilityListBtn"
        FacilityListBtn.Size = New Size(211, 94)
        FacilityListBtn.TabIndex = 3
        FacilityListBtn.Text = "Facility List     "
        FacilityListBtn.TextAlign = ContentAlignment.MiddleRight
        FacilityListBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        FacilityListBtn.UseVisualStyleBackColor = False
        ' 
        ' ScheduleListBtn
        ' 
        ScheduleListBtn.BackColor = Color.Beige

        ScheduleListBtn.BackgroundImageLayout = ImageLayout.None
        ScheduleListBtn.Font = New Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ScheduleListBtn.ImageAlign = ContentAlignment.TopLeft
        ScheduleListBtn.Location = New Point(23, 213)
        ScheduleListBtn.Name = "ScheduleListBtn"
        ScheduleListBtn.Size = New Size(211, 94)
        ScheduleListBtn.TabIndex = 3
        ScheduleListBtn.Text = "Schedule List    "
        ScheduleListBtn.TextAlign = ContentAlignment.MiddleRight
        ScheduleListBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        ScheduleListBtn.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.Location = New Point(262, 80)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1219, 674)
        Panel3.TabIndex = 3
        ' 
        ' ManagementScheduleForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Beige
        ClientSize = New Size(1483, 756)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
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
    Friend WithEvents Panel3 As Panel
    Friend WithEvents InstructorListBtn As Button
    Friend WithEvents SectionListBtn As Button
    Friend WithEvents FacilityListBtn As Button
End Class
