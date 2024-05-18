<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SubjectForm
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
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SubjectForm))
        Panel1 = New Panel()
        backBtn = New Button()
        Label1 = New Label()
        Panel2 = New Panel()
        Panel3 = New Panel()
        txtsubjectname = New TextBox()
        Panel4 = New Panel()
        txtsubjectcode = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        InsertBtn = New Button()
        UpdateBtn = New Button()
        DeleteBtn = New Button()
        txtsubjectid = New TextBox()
        Panel5 = New Panel()
        GroupBox1 = New GroupBox()
        dgvSubjectTable = New DataGridView()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(dgvSubjectTable, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(2), CByte(47), CByte(31))
        Panel1.Controls.Add(backBtn)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1173, 42)
        Panel1.TabIndex = 0
        ' 
        ' backBtn
        ' 
        backBtn.BackgroundImage = My.Resources.Resources.backBtn
        backBtn.BackgroundImageLayout = ImageLayout.Stretch
        backBtn.FlatStyle = FlatStyle.Flat
        backBtn.ForeColor = Color.FromArgb(CByte(1), CByte(81), CByte(54))
        backBtn.Location = New Point(3, 1)
        backBtn.Name = "backBtn"
        backBtn.Size = New Size(43, 38)
        backBtn.TabIndex = 4
        backBtn.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.WhiteSmoke
        Label1.Location = New Point(1045, 5)
        Label1.Name = "Label1"
        Label1.Size = New Size(123, 33)
        Label1.TabIndex = 3
        Label1.Text = "SUBJECTS"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(2), CByte(47), CByte(31))
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 42)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(42, 561)
        Panel2.TabIndex = 1
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(246), CByte(246), CByte(222))
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(txtsubjectname)
        Panel3.Location = New Point(147, 181)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(371, 48)
        Panel3.TabIndex = 3
        ' 
        ' txtsubjectname
        ' 
        txtsubjectname.BackColor = Color.FromArgb(CByte(246), CByte(246), CByte(222))
        txtsubjectname.BorderStyle = BorderStyle.None
        txtsubjectname.Font = New Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtsubjectname.Location = New Point(19, 14)
        txtsubjectname.Name = "txtsubjectname"
        txtsubjectname.Size = New Size(328, 20)
        txtsubjectname.TabIndex = 0
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(246), CByte(246), CByte(222))
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(txtsubjectcode)
        Panel4.Location = New Point(147, 274)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(371, 48)
        Panel4.TabIndex = 4
        ' 
        ' txtsubjectcode
        ' 
        txtsubjectcode.BackColor = Color.FromArgb(CByte(246), CByte(246), CByte(222))
        txtsubjectcode.BorderStyle = BorderStyle.None
        txtsubjectcode.Font = New Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtsubjectcode.Location = New Point(19, 14)
        txtsubjectcode.Name = "txtsubjectcode"
        txtsubjectcode.Size = New Size(328, 20)
        txtsubjectcode.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label2.Location = New Point(147, 155)
        Label2.Name = "Label2"
        Label2.Size = New Size(164, 23)
        Label2.TabIndex = 5
        Label2.Text = "Subject Description"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label3.Location = New Point(147, 248)
        Label3.Name = "Label3"
        Label3.Size = New Size(113, 23)
        Label3.TabIndex = 6
        Label3.Text = "Subject Code"
        ' 
        ' InsertBtn
        ' 
        InsertBtn.BackColor = Color.FromArgb(CByte(92), CByte(184), CByte(92))
        InsertBtn.FlatStyle = FlatStyle.Flat
        InsertBtn.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        InsertBtn.ForeColor = Color.FromArgb(CByte(244), CByte(244), CByte(244))
        InsertBtn.Location = New Point(147, 373)
        InsertBtn.Name = "InsertBtn"
        InsertBtn.Size = New Size(105, 49)
        InsertBtn.TabIndex = 31
        InsertBtn.Text = "INSERT"
        InsertBtn.UseVisualStyleBackColor = False
        ' 
        ' UpdateBtn
        ' 
        UpdateBtn.BackColor = Color.FromArgb(CByte(2), CByte(117), CByte(216))
        UpdateBtn.FlatStyle = FlatStyle.Flat
        UpdateBtn.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        UpdateBtn.ForeColor = Color.FromArgb(CByte(244), CByte(244), CByte(244))
        UpdateBtn.Location = New Point(279, 373)
        UpdateBtn.Name = "UpdateBtn"
        UpdateBtn.Size = New Size(105, 49)
        UpdateBtn.TabIndex = 32
        UpdateBtn.Text = "UPDATE"
        UpdateBtn.UseVisualStyleBackColor = False
        ' 
        ' DeleteBtn
        ' 
        DeleteBtn.BackColor = Color.FromArgb(CByte(217), CByte(83), CByte(79))
        DeleteBtn.FlatStyle = FlatStyle.Flat
        DeleteBtn.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DeleteBtn.ForeColor = Color.FromArgb(CByte(244), CByte(244), CByte(244))
        DeleteBtn.Location = New Point(413, 373)
        DeleteBtn.Name = "DeleteBtn"
        DeleteBtn.Size = New Size(105, 49)
        DeleteBtn.TabIndex = 33
        DeleteBtn.Text = "DELETE"
        DeleteBtn.UseVisualStyleBackColor = False
        ' 
        ' txtsubjectid
        ' 
        txtsubjectid.BackColor = Color.Beige
        txtsubjectid.BorderStyle = BorderStyle.None
        txtsubjectid.Location = New Point(324, 96)
        txtsubjectid.Name = "txtsubjectid"
        txtsubjectid.Size = New Size(100, 16)
        txtsubjectid.TabIndex = 34
        ' 
        ' Panel5
        ' 
        Panel5.Location = New Point(279, 69)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(200, 74)
        Panel5.TabIndex = 35
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(dgvSubjectTable)
        GroupBox1.Font = New Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        GroupBox1.Location = New Point(554, 73)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(563, 482)
        GroupBox1.TabIndex = 36
        GroupBox1.TabStop = False
        GroupBox1.Text = "LIST OF SUBJECTS"
        ' 
        ' dgvSubjectTable
        ' 
        dgvSubjectTable.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvSubjectTable.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvSubjectTable.BackgroundColor = Color.FromArgb(CByte(246), CByte(246), CByte(222))
        dgvSubjectTable.BorderStyle = BorderStyle.None
        dgvSubjectTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(246), CByte(246), CByte(222))
        DataGridViewCellStyle2.Font = New Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.Padding = New Padding(5)
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvSubjectTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvSubjectTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(246), CByte(246), CByte(222))
        DataGridViewCellStyle3.Font = New Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        DataGridViewCellStyle3.Padding = New Padding(10)
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvSubjectTable.DefaultCellStyle = DataGridViewCellStyle3
        dgvSubjectTable.Dock = DockStyle.Fill
        dgvSubjectTable.Location = New Point(3, 36)
        dgvSubjectTable.Name = "dgvSubjectTable"
        dgvSubjectTable.ReadOnly = True
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = SystemColors.Control
        DataGridViewCellStyle4.Font = New Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.Padding = New Padding(10)
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        dgvSubjectTable.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        dgvSubjectTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvSubjectTable.Size = New Size(557, 443)
        dgvSubjectTable.TabIndex = 30
        ' 
        ' SubjectForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Beige
        ClientSize = New Size(1173, 603)
        Controls.Add(GroupBox1)
        Controls.Add(Panel5)
        Controls.Add(txtsubjectid)
        Controls.Add(DeleteBtn)
        Controls.Add(UpdateBtn)
        Controls.Add(InsertBtn)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "SubjectForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "subjects"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        GroupBox1.ResumeLayout(False)
        CType(dgvSubjectTable, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents backBtn As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtsubjectname As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtsubjectcode As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents InsertBtn As Button
    Friend WithEvents UpdateBtn As Button
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents txtsubjectid As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvSubjectTable As DataGridView
End Class
