<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class instructorSched
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(instructorSched))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        backbtn = New Button()
        Label1 = New Label()
        Button1 = New Button()
        printer = New Printing.PrintDocument()
        printingdgv = New DataGridView()
        dgvInstructorSched = New DataGridView()
        Panel1.SuspendLayout()
        CType(printingdgv, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvInstructorSched, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(2), CByte(47), CByte(31))
        Panel1.Controls.Add(backbtn)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1359, 42)
        Panel1.TabIndex = 4
        ' 
        ' backbtn
        ' 
        backbtn.BackgroundImage = My.Resources.Resources._434230529_948718966640697_2976062282803324491_n1
        backbtn.BackgroundImageLayout = ImageLayout.Stretch
        backbtn.FlatStyle = FlatStyle.Flat
        backbtn.ForeColor = Color.FromArgb(CByte(1), CByte(81), CByte(54))
        backbtn.Location = New Point(12, 4)
        backbtn.Name = "backbtn"
        backbtn.Size = New Size(43, 38)
        backbtn.TabIndex = 2
        backbtn.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label1.Location = New Point(54, 87)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 26)
        Label1.TabIndex = 6
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(237))
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.Location = New Point(1152, 73)
        Button1.Name = "Button1"
        Button1.Size = New Size(142, 55)
        Button1.TabIndex = 2
        Button1.Text = "Print"
        Button1.TextImageRelation = TextImageRelation.ImageBeforeText
        Button1.UseVisualStyleBackColor = False
        ' 
        ' printer
        ' 
        ' 
        ' printingdgv
        ' 
        printingdgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        printingdgv.Location = New Point(255, 199)
        printingdgv.Name = "printingdgv"
        printingdgv.Size = New Size(791, 237)
        printingdgv.TabIndex = 8
        ' 
        ' dgvInstructorSched
        ' 
        dgvInstructorSched.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(237))
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.Padding = New Padding(10)
        DataGridViewCellStyle1.SelectionBackColor = Color.Transparent
        DataGridViewCellStyle1.SelectionForeColor = Color.Transparent
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvInstructorSched.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvInstructorSched.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(237))
        DataGridViewCellStyle2.Font = New Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.WhiteSmoke
        DataGridViewCellStyle2.Padding = New Padding(20)
        DataGridViewCellStyle2.SelectionBackColor = Color.Transparent
        DataGridViewCellStyle2.SelectionForeColor = Color.Transparent
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvInstructorSched.DefaultCellStyle = DataGridViewCellStyle2
        dgvInstructorSched.Location = New Point(54, 134)
        dgvInstructorSched.Name = "dgvInstructorSched"
        dgvInstructorSched.Size = New Size(1240, 506)
        dgvInstructorSched.TabIndex = 9
        ' 
        ' instructorSched
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Beige
        ClientSize = New Size(1359, 671)
        Controls.Add(dgvInstructorSched)
        Controls.Add(printingdgv)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "instructorSched"
        StartPosition = FormStartPosition.CenterScreen
        Text = "instructorSched"
        Panel1.ResumeLayout(False)
        CType(printingdgv, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvInstructorSched, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents backbtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents printer As Printing.PrintDocument
    Friend WithEvents printingdgv As DataGridView
    Friend WithEvents dgvInstructorSched As DataGridView
End Class
