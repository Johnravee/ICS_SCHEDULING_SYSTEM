<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateScheduleForm
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateScheduleForm))
        Panel1 = New Panel()
        Panel6 = New Panel()
        cb_room = New ComboBox()
        Panel4 = New Panel()
        cb_day = New ComboBox()
        Panel3 = New Panel()
        cb_subject = New ComboBox()
        Panel2 = New Panel()
        cb_section = New ComboBox()
        Panel5 = New Panel()
        cb_instructor = New ComboBox()
        EndTIme = New DateTimePicker()
        StartTime = New DateTimePicker()
        Panel10 = New Panel()
        txt_search = New TextBox()
        Panel8 = New Panel()
        cb_building = New ComboBox()
        Label8 = New Label()
        GroupBox2 = New GroupBox()
        dgvSchedule = New DataGridView()
        Label7 = New Label()
        Label2 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label11 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label10 = New Label()
        logo = New PictureBox()
        Label1 = New Label()
        Button2 = New Button()
        Button1 = New Button()
        Label9 = New Label()
        Panel1.SuspendLayout()
        Panel6.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        Panel5.SuspendLayout()
        Panel10.SuspendLayout()
        Panel8.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(dgvSchedule, ComponentModel.ISupportInitialize).BeginInit()
        CType(logo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(246), CByte(246), CByte(222))
        Panel1.Controls.Add(Panel6)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(EndTIme)
        Panel1.Controls.Add(StartTime)
        Panel1.Controls.Add(Panel10)
        Panel1.Controls.Add(Panel8)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(GroupBox2)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(logo)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Button2)
        Panel1.Location = New Point(0, 38)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1576, 721)
        Panel1.TabIndex = 0
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.LightYellow
        Panel6.BorderStyle = BorderStyle.FixedSingle
        Panel6.Controls.Add(cb_room)
        Panel6.Location = New Point(42, 595)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(239, 50)
        Panel6.TabIndex = 37
        ' 
        ' cb_room
        ' 
        cb_room.BackColor = Color.LightYellow
        cb_room.FlatStyle = FlatStyle.Flat
        cb_room.Font = New Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cb_room.FormattingEnabled = True
        cb_room.Location = New Point(14, 8)
        cb_room.Name = "cb_room"
        cb_room.Size = New Size(214, 34)
        cb_room.TabIndex = 36
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.LightYellow
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(cb_day)
        Panel4.Location = New Point(42, 497)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(239, 50)
        Panel4.TabIndex = 39
        ' 
        ' cb_day
        ' 
        cb_day.BackColor = Color.LightYellow
        cb_day.FlatStyle = FlatStyle.Flat
        cb_day.Font = New Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cb_day.FormattingEnabled = True
        cb_day.Items.AddRange(New Object() {"MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY", "SUNDAY"})
        cb_day.Location = New Point(14, 8)
        cb_day.Name = "cb_day"
        cb_day.Size = New Size(214, 34)
        cb_day.TabIndex = 36
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.LightYellow
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(cb_subject)
        Panel3.Location = New Point(42, 309)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(573, 50)
        Panel3.TabIndex = 38
        ' 
        ' cb_subject
        ' 
        cb_subject.BackColor = Color.LightYellow
        cb_subject.FlatStyle = FlatStyle.Flat
        cb_subject.Font = New Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cb_subject.FormattingEnabled = True
        cb_subject.Location = New Point(14, 8)
        cb_subject.Name = "cb_subject"
        cb_subject.Size = New Size(548, 34)
        cb_subject.TabIndex = 36
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.LightYellow
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(cb_section)
        Panel2.Location = New Point(42, 209)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(573, 50)
        Panel2.TabIndex = 37
        ' 
        ' cb_section
        ' 
        cb_section.BackColor = Color.LightYellow
        cb_section.FlatStyle = FlatStyle.Flat
        cb_section.Font = New Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cb_section.FormattingEnabled = True
        cb_section.Location = New Point(14, 8)
        cb_section.Name = "cb_section"
        cb_section.Size = New Size(548, 34)
        cb_section.TabIndex = 36
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.LightYellow
        Panel5.BorderStyle = BorderStyle.FixedSingle
        Panel5.Controls.Add(cb_instructor)
        Panel5.Location = New Point(42, 110)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(573, 50)
        Panel5.TabIndex = 36
        ' 
        ' cb_instructor
        ' 
        cb_instructor.BackColor = Color.LightYellow
        cb_instructor.FlatStyle = FlatStyle.Flat
        cb_instructor.Font = New Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cb_instructor.FormattingEnabled = True
        cb_instructor.Location = New Point(14, 8)
        cb_instructor.Name = "cb_instructor"
        cb_instructor.Size = New Size(548, 34)
        cb_instructor.TabIndex = 36
        ' 
        ' EndTIme
        ' 
        EndTIme.Font = New Font("Calibri", 24.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        EndTIme.Format = DateTimePickerFormat.Time
        EndTIme.Location = New Point(376, 404)
        EndTIme.Name = "EndTIme"
        EndTIme.ShowUpDown = True
        EndTIme.Size = New Size(239, 48)
        EndTIme.TabIndex = 35
        ' 
        ' StartTime
        ' 
        StartTime.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        StartTime.CustomFormat = ""
        StartTime.Font = New Font("Calibri", 24.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        StartTime.Format = DateTimePickerFormat.Time
        StartTime.Location = New Point(42, 404)
        StartTime.Name = "StartTime"
        StartTime.ShowUpDown = True
        StartTime.Size = New Size(239, 48)
        StartTime.TabIndex = 34
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = Color.LightYellow
        Panel10.BorderStyle = BorderStyle.FixedSingle
        Panel10.Controls.Add(txt_search)
        Panel10.Location = New Point(691, 110)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(573, 50)
        Panel10.TabIndex = 33
        ' 
        ' txt_search
        ' 
        txt_search.BackColor = Color.LightYellow
        txt_search.BorderStyle = BorderStyle.None
        txt_search.CharacterCasing = CharacterCasing.Upper
        txt_search.Font = New Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_search.Location = New Point(13, 9)
        txt_search.Name = "txt_search"
        txt_search.Size = New Size(547, 26)
        txt_search.TabIndex = 0
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.LightYellow
        Panel8.BorderStyle = BorderStyle.FixedSingle
        Panel8.Controls.Add(cb_building)
        Panel8.Location = New Point(376, 497)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(239, 50)
        Panel8.TabIndex = 32
        ' 
        ' cb_building
        ' 
        cb_building.BackColor = Color.LightYellow
        cb_building.FlatStyle = FlatStyle.Flat
        cb_building.Font = New Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cb_building.FormattingEnabled = True
        cb_building.Items.AddRange(New Object() {"OLD", "NEW"})
        cb_building.Location = New Point(14, 8)
        cb_building.Name = "cb_building"
        cb_building.Size = New Size(214, 34)
        cb_building.TabIndex = 36
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label8.Location = New Point(42, 376)
        Label8.Name = "Label8"
        Label8.Size = New Size(104, 25)
        Label8.TabIndex = 27
        Label8.Text = "Start Time"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.FromArgb(CByte(246), CByte(246), CByte(222))
        GroupBox2.Controls.Add(dgvSchedule)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Location = New Point(689, 181)
        GroupBox2.Margin = New Padding(2)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(2)
        GroupBox2.Size = New Size(868, 445)
        GroupBox2.TabIndex = 26
        GroupBox2.TabStop = False
        ' 
        ' dgvSchedule
        ' 
        dgvSchedule.BackgroundColor = Color.FromArgb(CByte(246), CByte(246), CByte(222))
        dgvSchedule.BorderStyle = BorderStyle.None
        dgvSchedule.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(246), CByte(246), CByte(222))
        DataGridViewCellStyle1.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.Padding = New Padding(5)
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvSchedule.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(246), CByte(246), CByte(222))
        DataGridViewCellStyle2.Font = New Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.Padding = New Padding(5)
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvSchedule.DefaultCellStyle = DataGridViewCellStyle2
        dgvSchedule.Location = New Point(2, 21)
        dgvSchedule.Name = "dgvSchedule"
        dgvSchedule.ReadOnly = True
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.Padding = New Padding(10)
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvSchedule.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvSchedule.Size = New Size(866, 430)
        dgvSchedule.TabIndex = 28
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label7.Location = New Point(24, -10)
        Label7.Name = "Label7"
        Label7.Size = New Size(167, 37)
        Label7.TabIndex = 27
        Label7.Text = "SCHEDULES"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label2.Location = New Point(689, 80)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 28)
        Label2.TabIndex = 23
        Label2.Text = "Search"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label6.Location = New Point(376, 461)
        Label6.Name = "Label6"
        Label6.Size = New Size(87, 25)
        Label6.TabIndex = 22
        Label6.Text = "Building"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label5.Location = New Point(42, 567)
        Label5.Name = "Label5"
        Label5.Size = New Size(65, 25)
        Label5.TabIndex = 21
        Label5.Text = "Room"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label11.Location = New Point(376, 376)
        Label11.Name = "Label11"
        Label11.Size = New Size(94, 25)
        Label11.TabIndex = 20
        Label11.Text = "End Time"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label4.Location = New Point(42, 464)
        Label4.Name = "Label4"
        Label4.Size = New Size(46, 25)
        Label4.TabIndex = 19
        Label4.Text = "Day"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label3.Location = New Point(42, 281)
        Label3.Name = "Label3"
        Label3.Size = New Size(78, 25)
        Label3.TabIndex = 18
        Label3.Text = "Subject"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label10.Location = New Point(42, 181)
        Label10.Name = "Label10"
        Label10.Size = New Size(78, 25)
        Label10.TabIndex = 17
        Label10.Text = "Section"
        ' 
        ' logo
        ' 
        logo.BackgroundImage = CType(resources.GetObject("logo.BackgroundImage"), Image)
        logo.BackgroundImageLayout = ImageLayout.Zoom
        logo.Location = New Point(1666, 664)
        logo.Name = "logo"
        logo.Size = New Size(57, 43)
        logo.TabIndex = 16
        logo.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label1.Location = New Point(42, 80)
        Label1.Name = "Label1"
        Label1.Size = New Size(101, 25)
        Label1.TabIndex = 9
        Label1.Text = "Instructor"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(1), CByte(81), CByte(54))
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = SystemColors.ButtonHighlight
        Button2.Location = New Point(459, 640)
        Button2.Name = "Button2"
        Button2.Size = New Size(156, 53)
        Button2.TabIndex = 8
        Button2.Text = "Submit"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(2), CByte(47), CByte(31))
        Button1.BackgroundImage = My.Resources.Resources._434230529_948718966640697_2976062282803324491_n1
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.FromArgb(CByte(1), CByte(81), CByte(54))
        Button1.Location = New Point(11, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(43, 38)
        Button1.TabIndex = 0
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Calibri", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.WhiteSmoke
        Label9.Location = New Point(1394, 7)
        Label9.Name = "Label9"
        Label9.Size = New Size(164, 24)
        Label9.TabIndex = 1
        Label9.Text = "CREATE SCHEDULE"
        ' 
        ' CreateScheduleForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(2), CByte(47), CByte(31))
        ClientSize = New Size(1577, 757)
        Controls.Add(Label9)
        Controls.Add(Panel1)
        Controls.Add(Button1)
        FormBorderStyle = FormBorderStyle.None
        Name = "CreateScheduleForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CreateScheduleForm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel10.ResumeLayout(False)
        Panel10.PerformLayout()
        Panel8.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(dgvSchedule, ComponentModel.ISupportInitialize).EndInit()
        CType(logo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents logo As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents txt_search As TextBox
    Friend WithEvents StartTime As DateTimePicker
    Friend WithEvents EndTIme As DateTimePicker
    Friend WithEvents cb_building As ComboBox
    Friend WithEvents dgvSchedule As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cb_section As ComboBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents cb_instructor As ComboBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents cb_room As ComboBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents cb_day As ComboBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents cb_subject As ComboBox
    Friend WithEvents Label9 As Label
End Class
