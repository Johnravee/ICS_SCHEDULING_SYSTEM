<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addNewInstructor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addNewInstructor))
        Panel1 = New Panel()
        Label14 = New Label()
        Button17 = New Button()
        txtfirstname = New TextBox()
        Panel2 = New Panel()
        Label1 = New Label()
        Label2 = New Label()
        Panel3 = New Panel()
        txtMiddlename = New TextBox()
        Label3 = New Label()
        Panel4 = New Panel()
        txtSurname = New TextBox()
        Label5 = New Label()
        Panel5 = New Panel()
        txtSuffix = New ComboBox()
        Label7 = New Label()
        Panel8 = New Panel()
        txtWorkStatus = New ComboBox()
        Label8 = New Label()
        Panel9 = New Panel()
        txtemailGmailText = New TextBox()
        txtEmail = New TextBox()
        AddInstructorBtn = New Button()
        logo = New PictureBox()
        OpenFileDialog = New OpenFileDialog()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        Panel8.SuspendLayout()
        Panel9.SuspendLayout()
        CType(logo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(2), CByte(47), CByte(31))
        Panel1.Controls.Add(Label14)
        Panel1.Controls.Add(Button17)
        Panel1.Location = New Point(0, -1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1483, 74)
        Panel1.TabIndex = 0
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Calibri", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.ForeColor = Color.WhiteSmoke
        Label14.Location = New Point(93, 19)
        Label14.Name = "Label14"
        Label14.Size = New Size(286, 42)
        Label14.TabIndex = 39
        Label14.Text = "NEW INSTRUCTOR"
        ' 
        ' Button17
        ' 
        Button17.BackColor = Color.FromArgb(CByte(2), CByte(47), CByte(31))
        Button17.BackgroundImage = My.Resources.Resources.backBtn_removebg_preview
        Button17.BackgroundImageLayout = ImageLayout.Stretch
        Button17.FlatStyle = FlatStyle.Flat
        Button17.ForeColor = Color.FromArgb(CByte(1), CByte(81), CByte(54))
        Button17.Location = New Point(12, 12)
        Button17.Margin = New Padding(3, 2, 3, 2)
        Button17.Name = "Button17"
        Button17.Size = New Size(54, 49)
        Button17.TabIndex = 74
        Button17.UseVisualStyleBackColor = False
        ' 
        ' txtfirstname
        ' 
        txtfirstname.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(237))
        txtfirstname.BorderStyle = BorderStyle.None
        txtfirstname.Font = New Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtfirstname.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        txtfirstname.Location = New Point(13, 14)
        txtfirstname.Name = "txtfirstname"
        txtfirstname.Size = New Size(189, 26)
        txtfirstname.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(237))
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(txtfirstname)
        Panel2.Location = New Point(377, 172)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(207, 52)
        Panel2.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label1.Location = New Point(377, 158)
        Label1.Margin = New Padding(0)
        Label1.Name = "Label1"
        Label1.Size = New Size(99, 25)
        Label1.TabIndex = 4
        Label1.Text = "Firstname"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label2.Location = New Point(649, 158)
        Label2.Margin = New Padding(0)
        Label2.Name = "Label2"
        Label2.Size = New Size(123, 25)
        Label2.TabIndex = 6
        Label2.Text = "Middlename"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(237))
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(txtMiddlename)
        Panel3.Location = New Point(649, 172)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(207, 52)
        Panel3.TabIndex = 5
        ' 
        ' txtMiddlename
        ' 
        txtMiddlename.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(237))
        txtMiddlename.BorderStyle = BorderStyle.None
        txtMiddlename.Font = New Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtMiddlename.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        txtMiddlename.Location = New Point(12, 14)
        txtMiddlename.Name = "txtMiddlename"
        txtMiddlename.Size = New Size(190, 26)
        txtMiddlename.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label3.Location = New Point(926, 158)
        Label3.Margin = New Padding(0)
        Label3.Name = "Label3"
        Label3.Size = New Size(92, 25)
        Label3.TabIndex = 8
        Label3.Text = "Surname"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(237))
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(txtSurname)
        Panel4.Location = New Point(926, 172)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(207, 52)
        Panel4.TabIndex = 7
        ' 
        ' txtSurname
        ' 
        txtSurname.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(237))
        txtSurname.BorderStyle = BorderStyle.None
        txtSurname.Font = New Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSurname.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        txtSurname.Location = New Point(11, 14)
        txtSurname.Name = "txtSurname"
        txtSurname.Size = New Size(191, 26)
        txtSurname.TabIndex = 1
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label5.Location = New Point(1203, 158)
        Label5.Margin = New Padding(0)
        Label5.Name = "Label5"
        Label5.Size = New Size(65, 25)
        Label5.TabIndex = 12
        Label5.Text = "Suffix"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(237))
        Panel5.BorderStyle = BorderStyle.FixedSingle
        Panel5.Controls.Add(txtSuffix)
        Panel5.Location = New Point(1203, 172)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(207, 52)
        Panel5.TabIndex = 11
        ' 
        ' txtSuffix
        ' 
        txtSuffix.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(237))
        txtSuffix.FlatStyle = FlatStyle.Flat
        txtSuffix.Font = New Font("Calibri", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSuffix.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        txtSuffix.FormattingEnabled = True
        txtSuffix.Items.AddRange(New Object() {"N/A", "Jr.", "Sr.", "II", "III", "IV"})
        txtSuffix.Location = New Point(11, 11)
        txtSuffix.Name = "txtSuffix"
        txtSuffix.Size = New Size(190, 29)
        txtSuffix.TabIndex = 0
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label7.Location = New Point(377, 247)
        Label7.Margin = New Padding(0)
        Label7.Name = "Label7"
        Label7.Size = New Size(121, 25)
        Label7.TabIndex = 18
        Label7.Text = "Work Status"
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(237))
        Panel8.BorderStyle = BorderStyle.FixedSingle
        Panel8.Controls.Add(txtWorkStatus)
        Panel8.Location = New Point(377, 261)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(479, 52)
        Panel8.TabIndex = 17
        ' 
        ' txtWorkStatus
        ' 
        txtWorkStatus.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(237))
        txtWorkStatus.FlatStyle = FlatStyle.Flat
        txtWorkStatus.Font = New Font("Calibri", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtWorkStatus.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        txtWorkStatus.FormattingEnabled = True
        txtWorkStatus.Items.AddRange(New Object() {"Part-Timer", "Full-Timer"})
        txtWorkStatus.Location = New Point(11, 11)
        txtWorkStatus.Name = "txtWorkStatus"
        txtWorkStatus.Size = New Size(460, 29)
        txtWorkStatus.TabIndex = 0
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label8.Location = New Point(926, 247)
        Label8.Margin = New Padding(0)
        Label8.Name = "Label8"
        Label8.Size = New Size(59, 25)
        Label8.TabIndex = 20
        Label8.Text = "Email"
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(237))
        Panel9.BorderStyle = BorderStyle.FixedSingle
        Panel9.Controls.Add(txtemailGmailText)
        Panel9.Controls.Add(txtEmail)
        Panel9.Location = New Point(926, 261)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(484, 52)
        Panel9.TabIndex = 19
        ' 
        ' txtemailGmailText
        ' 
        txtemailGmailText.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(237))
        txtemailGmailText.BorderStyle = BorderStyle.None
        txtemailGmailText.Cursor = Cursors.No
        txtemailGmailText.Font = New Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtemailGmailText.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        txtemailGmailText.Location = New Point(362, 14)
        txtemailGmailText.Name = "txtemailGmailText"
        txtemailGmailText.ReadOnly = True
        txtemailGmailText.Size = New Size(120, 26)
        txtemailGmailText.TabIndex = 21
        txtemailGmailText.Text = "@gmail.com"
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(237))
        txtEmail.BorderStyle = BorderStyle.None
        txtEmail.Font = New Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtEmail.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        txtEmail.Location = New Point(13, 14)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(343, 26)
        txtEmail.TabIndex = 1
        ' 
        ' AddInstructorBtn
        ' 
        AddInstructorBtn.BackColor = Color.FromArgb(CByte(2), CByte(47), CByte(31))
        AddInstructorBtn.FlatStyle = FlatStyle.Flat
        AddInstructorBtn.Font = New Font("Calibri", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AddInstructorBtn.ForeColor = Color.WhiteSmoke
        AddInstructorBtn.Location = New Point(1329, 350)
        AddInstructorBtn.Name = "AddInstructorBtn"
        AddInstructorBtn.Size = New Size(80, 70)
        AddInstructorBtn.TabIndex = 28
        AddInstructorBtn.Text = "➤"
        AddInstructorBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        AddInstructorBtn.UseVisualStyleBackColor = False
        ' 
        ' logo
        ' 
        logo.BackgroundImage = CType(resources.GetObject("logo.BackgroundImage"), Image)
        logo.BackgroundImageLayout = ImageLayout.Zoom
        logo.Location = New Point(12, 679)
        logo.Name = "logo"
        logo.Size = New Size(78, 65)
        logo.TabIndex = 38
        logo.TabStop = False
        ' 
        ' OpenFileDialog
        ' 
        OpenFileDialog.FileName = "OpenFileDialog1"
        ' 
        ' addNewInstructor
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(246), CByte(246), CByte(222))
        ClientSize = New Size(1483, 475)
        Controls.Add(logo)
        Controls.Add(AddInstructorBtn)
        Controls.Add(Label8)
        Controls.Add(Panel9)
        Controls.Add(Label7)
        Controls.Add(Panel8)
        Controls.Add(Label5)
        Controls.Add(Panel5)
        Controls.Add(Label3)
        Controls.Add(Panel4)
        Controls.Add(Label2)
        Controls.Add(Panel3)
        Controls.Add(Label1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "addNewInstructor"
        StartPosition = FormStartPosition.CenterScreen
        Text = "addNewInstructor"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel8.ResumeLayout(False)
        Panel9.ResumeLayout(False)
        Panel9.PerformLayout()
        CType(logo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button17 As Button
    Friend WithEvents txtfirstname As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtMiddlename As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtSuffix As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents txtWorkStatus As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtemailGmailText As TextBox
    Friend WithEvents AddInstructorBtn As Button
    Friend WithEvents logo As PictureBox
    Friend WithEvents Label14 As Label
    Friend WithEvents OpenFileDialog As OpenFileDialog
End Class
