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
        Panel1 = New Panel()
        btn_delete = New Button()
        btn_update = New Button()
        Panel9 = New Panel()
        txt_building = New TextBox()
        Label8 = New Label()
        Panel8 = New Panel()
        txt_endTime = New TextBox()
        Label7 = New Label()
        Panel7 = New Panel()
        txt_room = New TextBox()
        Label6 = New Label()
        Panel6 = New Panel()
        txt_day = New TextBox()
        Label5 = New Label()
        Panel5 = New Panel()
        txt_startTime = New TextBox()
        Label4 = New Label()
        Panel4 = New Panel()
        txt_subject = New TextBox()
        Label3 = New Label()
        Panel3 = New Panel()
        txt_section = New TextBox()
        Label2 = New Label()
        Panel2 = New Panel()
        txt_instructor = New TextBox()
        Label1 = New Label()
        Button1 = New Button()
        Panel1.SuspendLayout()
        Panel9.SuspendLayout()
        Panel8.SuspendLayout()
        Panel7.SuspendLayout()
        Panel6.SuspendLayout()
        Panel5.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Beige
        Panel1.Controls.Add(btn_delete)
        Panel1.Controls.Add(btn_update)
        Panel1.Controls.Add(Panel9)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Panel8)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Panel7)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Panel6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(0, 63)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(679, 741)
        Panel1.TabIndex = 0
        ' 
        ' btn_delete
        ' 
        btn_delete.BackColor = Color.FromArgb(CByte(223), CByte(70), CByte(98))
        btn_delete.FlatStyle = FlatStyle.Flat
        btn_delete.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_delete.ForeColor = Color.Beige
        btn_delete.Location = New Point(492, 636)
        btn_delete.Name = "btn_delete"
        btn_delete.Size = New Size(134, 45)
        btn_delete.TabIndex = 17
        btn_delete.Text = "DELETE"
        btn_delete.UseVisualStyleBackColor = False
        ' 
        ' btn_update
        ' 
        btn_update.BackColor = Color.FromArgb(CByte(24), CByte(161), CByte(79))
        btn_update.FlatStyle = FlatStyle.Flat
        btn_update.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_update.ForeColor = Color.Beige
        btn_update.Location = New Point(352, 636)
        btn_update.Name = "btn_update"
        btn_update.Size = New Size(134, 45)
        btn_update.TabIndex = 16
        btn_update.Text = "UPDATE"
        btn_update.UseVisualStyleBackColor = False
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.LightYellow
        Panel9.BorderStyle = BorderStyle.FixedSingle
        Panel9.Controls.Add(txt_building)
        Panel9.Location = New Point(387, 523)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(239, 50)
        Panel9.TabIndex = 15
        ' 
        ' txt_building
        ' 
        txt_building.BackColor = Color.LightYellow
        txt_building.BorderStyle = BorderStyle.None
        txt_building.CharacterCasing = CharacterCasing.Upper
        txt_building.Font = New Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_building.Location = New Point(13, 9)
        txt_building.Name = "txt_building"
        txt_building.Size = New Size(214, 26)
        txt_building.TabIndex = 0
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(387, 490)
        Label8.Name = "Label8"
        Label8.Size = New Size(96, 30)
        Label8.TabIndex = 14
        Label8.Text = "Building"
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.LightYellow
        Panel8.BorderStyle = BorderStyle.FixedSingle
        Panel8.Controls.Add(txt_endTime)
        Panel8.Location = New Point(387, 410)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(239, 50)
        Panel8.TabIndex = 13
        ' 
        ' txt_endTime
        ' 
        txt_endTime.BackColor = Color.LightYellow
        txt_endTime.BorderStyle = BorderStyle.None
        txt_endTime.CharacterCasing = CharacterCasing.Upper
        txt_endTime.Font = New Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_endTime.Location = New Point(13, 9)
        txt_endTime.Name = "txt_endTime"
        txt_endTime.Size = New Size(219, 26)
        txt_endTime.TabIndex = 0
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(387, 377)
        Label7.Name = "Label7"
        Label7.Size = New Size(104, 30)
        Label7.TabIndex = 12
        Label7.Text = "End Time"
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.LightYellow
        Panel7.BorderStyle = BorderStyle.FixedSingle
        Panel7.Controls.Add(txt_room)
        Panel7.Location = New Point(53, 631)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(239, 50)
        Panel7.TabIndex = 11
        ' 
        ' txt_room
        ' 
        txt_room.BackColor = Color.LightYellow
        txt_room.BorderStyle = BorderStyle.None
        txt_room.CharacterCasing = CharacterCasing.Upper
        txt_room.Font = New Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_room.Location = New Point(13, 9)
        txt_room.Name = "txt_room"
        txt_room.Size = New Size(214, 26)
        txt_room.TabIndex = 0
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(53, 598)
        Label6.Name = "Label6"
        Label6.Size = New Size(71, 30)
        Label6.TabIndex = 10
        Label6.Text = "Room"
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.LightYellow
        Panel6.BorderStyle = BorderStyle.FixedSingle
        Panel6.Controls.Add(txt_day)
        Panel6.Location = New Point(53, 523)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(239, 50)
        Panel6.TabIndex = 9
        ' 
        ' txt_day
        ' 
        txt_day.BackColor = Color.LightYellow
        txt_day.BorderStyle = BorderStyle.None
        txt_day.CharacterCasing = CharacterCasing.Upper
        txt_day.Font = New Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_day.Location = New Point(13, 9)
        txt_day.Name = "txt_day"
        txt_day.Size = New Size(214, 26)
        txt_day.TabIndex = 0
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(53, 490)
        Label5.Name = "Label5"
        Label5.Size = New Size(50, 30)
        Label5.TabIndex = 8
        Label5.Text = "Day"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.LightYellow
        Panel5.BorderStyle = BorderStyle.FixedSingle
        Panel5.Controls.Add(txt_startTime)
        Panel5.Location = New Point(53, 410)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(239, 50)
        Panel5.TabIndex = 7
        ' 
        ' txt_startTime
        ' 
        txt_startTime.BackColor = Color.LightYellow
        txt_startTime.BorderStyle = BorderStyle.None
        txt_startTime.CharacterCasing = CharacterCasing.Upper
        txt_startTime.Font = New Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_startTime.Location = New Point(13, 9)
        txt_startTime.Name = "txt_startTime"
        txt_startTime.Size = New Size(214, 26)
        txt_startTime.TabIndex = 0
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(53, 377)
        Label4.Name = "Label4"
        Label4.Size = New Size(114, 30)
        Label4.TabIndex = 6
        Label4.Text = "Start Time"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.LightYellow
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(txt_subject)
        Panel4.Location = New Point(53, 306)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(573, 50)
        Panel4.TabIndex = 5
        ' 
        ' txt_subject
        ' 
        txt_subject.BackColor = Color.LightYellow
        txt_subject.BorderStyle = BorderStyle.None
        txt_subject.CharacterCasing = CharacterCasing.Upper
        txt_subject.Font = New Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_subject.Location = New Point(13, 9)
        txt_subject.Name = "txt_subject"
        txt_subject.Size = New Size(547, 26)
        txt_subject.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(53, 273)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 30)
        Label3.TabIndex = 4
        Label3.Text = "Subject"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.LightYellow
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(txt_section)
        Panel3.Location = New Point(53, 201)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(573, 50)
        Panel3.TabIndex = 3
        ' 
        ' txt_section
        ' 
        txt_section.BackColor = Color.LightYellow
        txt_section.BorderStyle = BorderStyle.None
        txt_section.CharacterCasing = CharacterCasing.Upper
        txt_section.Font = New Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_section.Location = New Point(13, 9)
        txt_section.Name = "txt_section"
        txt_section.Size = New Size(547, 26)
        txt_section.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(53, 168)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 30)
        Label2.TabIndex = 2
        Label2.Text = "Section"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.LightYellow
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(txt_instructor)
        Panel2.Location = New Point(53, 98)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(573, 50)
        Panel2.TabIndex = 1
        ' 
        ' txt_instructor
        ' 
        txt_instructor.BackColor = Color.LightYellow
        txt_instructor.BorderStyle = BorderStyle.None
        txt_instructor.CharacterCasing = CharacterCasing.Upper
        txt_instructor.Font = New Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_instructor.Location = New Point(13, 9)
        txt_instructor.Name = "txt_instructor"
        txt_instructor.Size = New Size(547, 26)
        txt_instructor.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(53, 65)
        Label1.Name = "Label1"
        Label1.Size = New Size(119, 30)
        Label1.TabIndex = 0
        Label1.Text = "Instructors"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(2), CByte(47), CByte(32))
        Button1.BackgroundImage = My.Resources.Resources._434230529_948718966640697_2976062282803324491_n1
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.FromArgb(CByte(2), CByte(47), CByte(32))
        Button1.Location = New Point(0, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(62, 45)
        Button1.TabIndex = 1
        Button1.UseVisualStyleBackColor = False
        ' 
        ' SchedulePopupForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(2), CByte(47), CByte(32))
        ClientSize = New Size(675, 802)
        Controls.Add(Button1)
        Controls.Add(Panel1)
        ForeColor = Color.FromArgb(CByte(2), CByte(47), CByte(32))
        FormBorderStyle = FormBorderStyle.None
        Name = "SchedulePopupForm"
        Text = "SchedulePopupForm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel9.ResumeLayout(False)
        Panel9.PerformLayout()
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txt_instructor As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txt_subject As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txt_section As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents txt_endTime As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents txt_room As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents txt_day As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txt_startTime As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents txt_building As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_update As Button
End Class
