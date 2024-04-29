<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SchedulePopupForm
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
        Button1 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        btn_update = New Button()
        btn_delete = New Button()
        Panel10 = New Panel()
        cbo_instructor = New ComboBox()
        Panel2 = New Panel()
        cbo_section = New ComboBox()
        Panel3 = New Panel()
        cbo_subject = New ComboBox()
        pane100 = New Panel()
        cbo_day = New ComboBox()
        Panel4 = New Panel()
        cb_room = New ComboBox()
        TXTid = New TextBox()
        Panel5 = New Panel()
        Panel1 = New Panel()
        EndTime = New DateTimePicker()
        StartTime1 = New DateTimePicker()
        Panel10.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        pane100.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(2), CByte(47), CByte(32))
        Button1.BackgroundImage = My.Resources.Resources._434230529_948718966640697_2976062282803324491_n1
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.FromArgb(CByte(2), CByte(47), CByte(32))
        Button1.Location = New Point(4, 6)
        Button1.Name = "Button1"
        Button1.Size = New Size(46, 34)
        Button1.TabIndex = 1
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(46, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(119, 30)
        Label1.TabIndex = 0
        Label1.Text = "Instructors"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(46, 126)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 30)
        Label2.TabIndex = 2
        Label2.Text = "Section"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(46, 231)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 30)
        Label3.TabIndex = 4
        Label3.Text = "Subject"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(46, 335)
        Label4.Name = "Label4"
        Label4.Size = New Size(114, 30)
        Label4.TabIndex = 6
        Label4.Text = "Start Time"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(46, 431)
        Label5.Name = "Label5"
        Label5.Size = New Size(50, 30)
        Label5.TabIndex = 8
        Label5.Text = "Day"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(289, 431)
        Label6.Name = "Label6"
        Label6.Size = New Size(71, 30)
        Label6.TabIndex = 10
        Label6.Text = "Room"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(303, 335)
        Label7.Name = "Label7"
        Label7.Size = New Size(104, 30)
        Label7.TabIndex = 12
        Label7.Text = "End Time"
        ' 
        ' btn_update
        ' 
        btn_update.BackColor = Color.FromArgb(CByte(24), CByte(161), CByte(79))
        btn_update.FlatStyle = FlatStyle.Flat
        btn_update.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_update.ForeColor = Color.Beige
        btn_update.Location = New Point(46, 532)
        btn_update.Name = "btn_update"
        btn_update.Size = New Size(175, 45)
        btn_update.TabIndex = 16
        btn_update.Text = "UPDATE"
        btn_update.UseVisualStyleBackColor = False
        ' 
        ' btn_delete
        ' 
        btn_delete.BackColor = Color.FromArgb(CByte(223), CByte(70), CByte(98))
        btn_delete.FlatStyle = FlatStyle.Flat
        btn_delete.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_delete.ForeColor = Color.Beige
        btn_delete.Location = New Point(276, 532)
        btn_delete.Name = "btn_delete"
        btn_delete.Size = New Size(175, 45)
        btn_delete.TabIndex = 17
        btn_delete.Text = "DELETE"
        btn_delete.UseVisualStyleBackColor = False
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = Color.LightYellow
        Panel10.BorderStyle = BorderStyle.FixedSingle
        Panel10.Controls.Add(cbo_instructor)
        Panel10.Location = New Point(46, 56)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(405, 50)
        Panel10.TabIndex = 37
        ' 
        ' cbo_instructor
        ' 
        cbo_instructor.BackColor = Color.LightYellow
        cbo_instructor.FlatStyle = FlatStyle.Flat
        cbo_instructor.Font = New Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbo_instructor.FormattingEnabled = True
        cbo_instructor.Location = New Point(14, 8)
        cbo_instructor.Name = "cbo_instructor"
        cbo_instructor.Size = New Size(381, 34)
        cbo_instructor.TabIndex = 36
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.LightYellow
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(cbo_section)
        Panel2.Location = New Point(46, 159)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(405, 50)
        Panel2.TabIndex = 38
        ' 
        ' cbo_section
        ' 
        cbo_section.BackColor = Color.LightYellow
        cbo_section.FlatStyle = FlatStyle.Flat
        cbo_section.Font = New Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbo_section.FormattingEnabled = True
        cbo_section.Location = New Point(14, 8)
        cbo_section.Name = "cbo_section"
        cbo_section.Size = New Size(381, 34)
        cbo_section.TabIndex = 36
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.LightYellow
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(cbo_subject)
        Panel3.Location = New Point(46, 264)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(405, 50)
        Panel3.TabIndex = 39
        ' 
        ' cbo_subject
        ' 
        cbo_subject.BackColor = Color.LightYellow
        cbo_subject.FlatStyle = FlatStyle.Flat
        cbo_subject.Font = New Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbo_subject.FormattingEnabled = True
        cbo_subject.Location = New Point(14, 8)
        cbo_subject.Name = "cbo_subject"
        cbo_subject.Size = New Size(381, 34)
        cbo_subject.TabIndex = 36
        ' 
        ' pane100
        ' 
        pane100.BackColor = Color.LightYellow
        pane100.BorderStyle = BorderStyle.FixedSingle
        pane100.Controls.Add(cbo_day)
        pane100.Location = New Point(46, 464)
        pane100.Name = "pane100"
        pane100.Size = New Size(175, 50)
        pane100.TabIndex = 41
        ' 
        ' cbo_day
        ' 
        cbo_day.BackColor = Color.LightYellow
        cbo_day.FlatStyle = FlatStyle.Flat
        cbo_day.Font = New Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbo_day.FormattingEnabled = True
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
        Panel4.Location = New Point(276, 464)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(175, 50)
        Panel4.TabIndex = 42
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
        ' TXTid
        ' 
        TXTid.Location = New Point(73, 28)
        TXTid.Name = "TXTid"
        TXTid.Size = New Size(100, 23)
        TXTid.TabIndex = 43
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(TXTid)
        Panel5.Location = New Point(471, 12)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(200, 51)
        Panel5.TabIndex = 44
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Beige
        Panel1.Controls.Add(EndTime)
        Panel1.Controls.Add(StartTime1)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(pane100)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Panel10)
        Panel1.Controls.Add(btn_delete)
        Panel1.Controls.Add(btn_update)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(0, 44)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(515, 595)
        Panel1.TabIndex = 0
        ' 
        ' EndTime
        ' 
        EndTime.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        EndTime.CustomFormat = ""
        EndTime.Font = New Font("Calibri", 24.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        EndTime.Format = DateTimePickerFormat.Time
        EndTime.Location = New Point(276, 368)
        EndTime.Name = "EndTime"
        EndTime.ShowUpDown = True
        EndTime.Size = New Size(175, 48)
        EndTime.TabIndex = 46
        EndTime.Value = New Date(2024, 4, 28, 0, 0, 0, 0)
        ' 
        ' StartTime1
        ' 
        StartTime1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        StartTime1.CustomFormat = ""
        StartTime1.Font = New Font("Calibri", 24.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        StartTime1.Format = DateTimePickerFormat.Time
        StartTime1.Location = New Point(46, 368)
        StartTime1.Name = "StartTime1"
        StartTime1.ShowUpDown = True
        StartTime1.Size = New Size(175, 48)
        StartTime1.TabIndex = 45
        StartTime1.Value = New Date(2024, 4, 28, 0, 0, 0, 0)
        ' 
        ' SchedulePopupForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(2), CByte(47), CByte(32))
        ClientSize = New Size(513, 640)
        Controls.Add(Button1)
        Controls.Add(Panel1)
        Controls.Add(Panel5)
        ForeColor = Color.FromArgb(CByte(2), CByte(47), CByte(32))
        FormBorderStyle = FormBorderStyle.None
        Name = "SchedulePopupForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "0618983539"
        Panel10.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        pane100.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents Panel10 As Panel
    Friend WithEvents cbo_instructor As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cbo_section As ComboBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents cbo_subject As ComboBox
    Friend WithEvents pane100 As Panel
    Friend WithEvents cbo_day As ComboBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents cb_room As ComboBox
    Friend WithEvents TXTid As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents EndTime As DateTimePicker
    Friend WithEvents StartTime1 As DateTimePicker
End Class
