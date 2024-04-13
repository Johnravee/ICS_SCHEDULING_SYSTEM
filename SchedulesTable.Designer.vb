<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SchedulesTable
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SchedulesTable))
        Panel1 = New Panel()
        ListBox1 = New ListBox()
        Label2 = New Label()
        DataGridView1 = New DataGridView()
        Label1 = New Label()
        Button17 = New Button()
        closeBtn = New PictureBox()
        minimizeBtn = New PictureBox()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(closeBtn, ComponentModel.ISupportInitialize).BeginInit()
        CType(minimizeBtn, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(246), CByte(246), CByte(222))
        Panel1.Controls.Add(ListBox1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(DataGridView1)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(0, 68)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(744, 920)
        Panel1.TabIndex = 0
        ' 
        ' ListBox1
        ' 
        ListBox1.BackColor = Color.FromArgb(CByte(246), CByte(246), CByte(222))
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(12, 676)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(719, 109)
        ListBox1.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(55))
        Label2.Location = New Point(12, 633)
        Label2.Name = "Label2"
        Label2.Size = New Size(161, 25)
        Label2.TabIndex = 2
        Label2.Text = "List of Instructors"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToOrderColumns = True
        DataGridView1.BackgroundColor = Color.FromArgb(CByte(246), CByte(246), CByte(222))
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 45)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(719, 574)
        DataGridView1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(55))
        Label1.Location = New Point(12, 7)
        Label1.Name = "Label1"
        Label1.Size = New Size(146, 25)
        Label1.TabIndex = 0
        Label1.Text = "List of Schedule"
        ' 
        ' Button17
        ' 
        Button17.BackColor = Color.FromArgb(CByte(2), CByte(46), CByte(31))
        Button17.BackgroundImage = My.Resources.Resources.backBtn_removebg_preview
        Button17.BackgroundImageLayout = ImageLayout.Stretch
        Button17.FlatStyle = FlatStyle.Flat
        Button17.ForeColor = Color.FromArgb(CByte(1), CByte(81), CByte(54))
        Button17.Location = New Point(9, 9)
        Button17.Margin = New Padding(3, 2, 3, 2)
        Button17.Name = "Button17"
        Button17.Size = New Size(80, 49)
        Button17.TabIndex = 74
        Button17.UseVisualStyleBackColor = False
        ' 
        ' closeBtn
        ' 
        closeBtn.BackColor = Color.Transparent
        closeBtn.BackgroundImage = CType(resources.GetObject("closeBtn.BackgroundImage"), Image)
        closeBtn.BackgroundImageLayout = ImageLayout.Stretch
        closeBtn.Cursor = Cursors.Hand
        closeBtn.Location = New Point(712, 2)
        closeBtn.Name = "closeBtn"
        closeBtn.Size = New Size(22, 21)
        closeBtn.TabIndex = 75
        closeBtn.TabStop = False
        ' 
        ' minimizeBtn
        ' 
        minimizeBtn.BackColor = Color.Transparent
        minimizeBtn.BackgroundImage = CType(resources.GetObject("minimizeBtn.BackgroundImage"), Image)
        minimizeBtn.BackgroundImageLayout = ImageLayout.Stretch
        minimizeBtn.Cursor = Cursors.Hand
        minimizeBtn.Location = New Point(684, 2)
        minimizeBtn.Name = "minimizeBtn"
        minimizeBtn.Size = New Size(22, 21)
        minimizeBtn.TabIndex = 76
        minimizeBtn.TabStop = False
        ' 
        ' ViewSchedinroomForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(2), CByte(46), CByte(31))
        ClientSize = New Size(740, 920)
        Controls.Add(minimizeBtn)
        Controls.Add(closeBtn)
        Controls.Add(Button17)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "ViewSchedinroomForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ViewSchedinroomForm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(closeBtn, ComponentModel.ISupportInitialize).EndInit()
        CType(minimizeBtn, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button17 As Button
    Friend WithEvents closeBtn As PictureBox
    Friend WithEvents minimizeBtn As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents ListBox1 As ListBox
End Class
