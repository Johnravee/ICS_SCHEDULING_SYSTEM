<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SchedListForm
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        TextBox1 = New TextBox()
        upd = New Button()
        del = New Button()
        txtScheduleID = New TextBox()
        dgv = New DataGridView()
        Panel10 = New Panel()
        cbo_instructor = New ComboBox()
        Panel2 = New Panel()
        cbo_sec = New ComboBox()
        Panel3 = New Panel()
        cbo_subject = New ComboBox()
        pane100 = New Panel()
        cbo_day = New ComboBox()
        Panel4 = New Panel()
        cb_room = New ComboBox()
        StartTime = New DateTimePicker()
        EndTime = New DateTimePicker()
        ResetBtn = New Button()
        CType(dgv, ComponentModel.ISupportInitialize).BeginInit()
        Panel10.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        pane100.SuspendLayout()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(588, 27)
        TextBox1.Margin = New Padding(3, 2, 3, 2)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "  Search"
        TextBox1.Size = New Size(428, 29)
        TextBox1.TabIndex = 6
        ' 
        ' upd
        ' 
        upd.BackColor = Color.FromArgb(CByte(24), CByte(161), CByte(79))
        upd.FlatAppearance.BorderSize = 0
        upd.FlatStyle = FlatStyle.Flat
        upd.Font = New Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        upd.ForeColor = Color.WhiteSmoke
        upd.Location = New Point(656, 547)
        upd.Margin = New Padding(3, 2, 3, 2)
        upd.Name = "upd"
        upd.Size = New Size(114, 45)
        upd.TabIndex = 4
        upd.Text = "UPDATE"
        upd.UseVisualStyleBackColor = False
        ' 
        ' del
        ' 
        del.BackColor = Color.FromArgb(CByte(223), CByte(70), CByte(98))
        del.FlatAppearance.BorderSize = 0
        del.FlatStyle = FlatStyle.Flat
        del.Font = New Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        del.ForeColor = Color.WhiteSmoke
        del.Location = New Point(778, 547)
        del.Margin = New Padding(3, 2, 3, 2)
        del.Name = "del"
        del.Size = New Size(114, 45)
        del.TabIndex = 5
        del.Text = "DELETE"
        del.UseVisualStyleBackColor = False
        ' 
        ' txtScheduleID
        ' 
        txtScheduleID.Location = New Point(395, 119)
        txtScheduleID.Margin = New Padding(2)
        txtScheduleID.Name = "txtScheduleID"
        txtScheduleID.Size = New Size(77, 23)
        txtScheduleID.TabIndex = 8
        ' 
        ' dgv
        ' 
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv.BackgroundColor = Color.Beige
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.Padding = New Padding(5)
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.Padding = New Padding(10)
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgv.DefaultCellStyle = DataGridViewCellStyle2
        dgv.Location = New Point(28, 72)
        dgv.Margin = New Padding(3, 2, 3, 2)
        dgv.Name = "dgv"
        dgv.ReadOnly = True
        dgv.RowHeadersWidth = 51
        dgv.Size = New Size(988, 391)
        dgv.TabIndex = 16
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = Color.LightYellow
        Panel10.BorderStyle = BorderStyle.FixedSingle
        Panel10.Controls.Add(cbo_instructor)
        Panel10.Location = New Point(28, 488)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(284, 50)
        Panel10.TabIndex = 38
        ' 
        ' cbo_instructor
        ' 
        cbo_instructor.BackColor = Color.LightYellow
        cbo_instructor.FlatStyle = FlatStyle.Flat
        cbo_instructor.Font = New Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbo_instructor.FormattingEnabled = True
        cbo_instructor.Location = New Point(14, 8)
        cbo_instructor.Name = "cbo_instructor"
        cbo_instructor.Size = New Size(256, 34)
        cbo_instructor.TabIndex = 36
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.LightYellow
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(cbo_sec)
        Panel2.Location = New Point(28, 547)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(284, 50)
        Panel2.TabIndex = 39
        ' 
        ' cbo_sec
        ' 
        cbo_sec.BackColor = Color.LightYellow
        cbo_sec.FlatStyle = FlatStyle.Flat
        cbo_sec.Font = New Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbo_sec.FormattingEnabled = True
        cbo_sec.Location = New Point(13, 7)
        cbo_sec.Name = "cbo_sec"
        cbo_sec.Size = New Size(256, 34)
        cbo_sec.TabIndex = 37
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.LightYellow
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(cbo_subject)
        Panel3.Location = New Point(351, 488)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(284, 50)
        Panel3.TabIndex = 40
        ' 
        ' cbo_subject
        ' 
        cbo_subject.BackColor = Color.LightYellow
        cbo_subject.FlatStyle = FlatStyle.Flat
        cbo_subject.Font = New Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbo_subject.FormattingEnabled = True
        cbo_subject.Location = New Point(13, 7)
        cbo_subject.Name = "cbo_subject"
        cbo_subject.Size = New Size(256, 34)
        cbo_subject.TabIndex = 37
        ' 
        ' pane100
        ' 
        pane100.BackColor = Color.LightYellow
        pane100.BorderStyle = BorderStyle.FixedSingle
        pane100.Controls.Add(cbo_day)
        pane100.Location = New Point(656, 488)
        pane100.Name = "pane100"
        pane100.Size = New Size(175, 50)
        pane100.TabIndex = 42
        ' 
        ' cbo_day
        ' 
        cbo_day.BackColor = Color.LightYellow
        cbo_day.FlatStyle = FlatStyle.Flat
        cbo_day.Font = New Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbo_day.FormattingEnabled = True
        cbo_day.Items.AddRange(New Object() {"MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY", "SUNDAY"})
        cbo_day.Location = New Point(8, 8)
        cbo_day.Name = "cbo_day"
        cbo_day.Size = New Size(156, 34)
        cbo_day.TabIndex = 36
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.LightYellow
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(cb_room)
        Panel4.Location = New Point(841, 488)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(175, 50)
        Panel4.TabIndex = 43
        ' 
        ' cb_room
        ' 
        cb_room.BackColor = Color.LightYellow
        cb_room.FlatStyle = FlatStyle.Flat
        cb_room.Font = New Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cb_room.FormattingEnabled = True
        cb_room.Location = New Point(14, 8)
        cb_room.Name = "cb_room"
        cb_room.Size = New Size(151, 34)
        cb_room.TabIndex = 36
        ' 
        ' StartTime
        ' 
        StartTime.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        StartTime.CustomFormat = ""
        StartTime.Font = New Font("Calibri", 24.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        StartTime.Format = DateTimePickerFormat.Time
        StartTime.Location = New Point(338, 544)
        StartTime.Name = "StartTime"
        StartTime.ShowUpDown = True
        StartTime.Size = New Size(153, 48)
        StartTime.TabIndex = 46
        StartTime.Value = New Date(2024, 4, 29, 0, 0, 0, 0)
        ' 
        ' EndTime
        ' 
        EndTime.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        EndTime.CustomFormat = ""
        EndTime.Font = New Font("Calibri", 24.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        EndTime.Format = DateTimePickerFormat.Time
        EndTime.Location = New Point(497, 544)
        EndTime.Name = "EndTime"
        EndTime.ShowUpDown = True
        EndTime.Size = New Size(153, 48)
        EndTime.TabIndex = 47
        EndTime.Value = New Date(2024, 4, 28, 0, 0, 0, 0)
        ' 
        ' ResetBtn
        ' 
        ResetBtn.BackColor = Color.FromArgb(CByte(223), CByte(70), CByte(98))
        ResetBtn.FlatAppearance.BorderSize = 0
        ResetBtn.FlatStyle = FlatStyle.Flat
        ResetBtn.Font = New Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ResetBtn.ForeColor = Color.WhiteSmoke
        ResetBtn.Location = New Point(902, 547)
        ResetBtn.Margin = New Padding(3, 2, 3, 2)
        ResetBtn.Name = "ResetBtn"
        ResetBtn.Size = New Size(114, 45)
        ResetBtn.TabIndex = 48
        ResetBtn.Text = "RESET"
        ResetBtn.UseVisualStyleBackColor = False
        ' 
        ' SchedListForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Beige
        ClientSize = New Size(1050, 609)
        Controls.Add(ResetBtn)
        Controls.Add(EndTime)
        Controls.Add(StartTime)
        Controls.Add(Panel4)
        Controls.Add(pane100)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel10)
        Controls.Add(dgv)
        Controls.Add(txtScheduleID)
        Controls.Add(TextBox1)
        Controls.Add(upd)
        Controls.Add(del)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "SchedListForm"
        StartPosition = FormStartPosition.WindowsDefaultBounds
        Text = "SchedListForm"
        WindowState = FormWindowState.Maximized
        CType(dgv, ComponentModel.ISupportInitialize).EndInit()
        Panel10.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        pane100.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents upd As Button
    Friend WithEvents del As Button
    Friend WithEvents txtScheduleID As TextBox
    Friend WithEvents dgv As DataGridView
    Friend WithEvents Panel10 As Panel
    Friend WithEvents cbo_instructor As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents pane100 As Panel
    Friend WithEvents cbo_day As ComboBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents cb_room As ComboBox
    Friend WithEvents StartTime As DateTimePicker
    Friend WithEvents EndTime As DateTimePicker
    Friend WithEvents cbo_subject As ComboBox
    Friend WithEvents cb_sections As ComboBox
    Friend WithEvents cbo_sec As ComboBox
    Friend WithEvents ResetBtn As Button
End Class
