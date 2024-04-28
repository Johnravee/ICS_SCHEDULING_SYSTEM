<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sectionSched
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sectionSched))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        backbtn = New Button()
        Label1 = New Label()
        Printbtn = New Button()
        printingdgv = New DataGridView()
        dgvSectionSched = New DataGridView()
        printer = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        Panel1.SuspendLayout()
        CType(printingdgv, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvSectionSched, ComponentModel.ISupportInitialize).BeginInit()
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
        Label1.Location = New Point(54, 84)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 26)
        Label1.TabIndex = 8
        ' 
        ' Printbtn
        ' 
        Printbtn.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(237))
        Printbtn.FlatAppearance.BorderSize = 0
        Printbtn.FlatStyle = FlatStyle.Flat
        Printbtn.Font = New Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Printbtn.Image = CType(resources.GetObject("Printbtn.Image"), Image)
        Printbtn.Location = New Point(1152, 73)
        Printbtn.Name = "Printbtn"
        Printbtn.Size = New Size(142, 55)
        Printbtn.TabIndex = 9
        Printbtn.Text = "Print"
        Printbtn.TextImageRelation = TextImageRelation.ImageBeforeText
        Printbtn.UseVisualStyleBackColor = False
        ' 
        ' printingdgv
        ' 
        printingdgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Window
        DataGridViewCellStyle1.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.Padding = New Padding(5)
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        printingdgv.DefaultCellStyle = DataGridViewCellStyle1
        printingdgv.Location = New Point(78, 267)
        printingdgv.Name = "printingdgv"
        printingdgv.ReadOnly = True
        printingdgv.Size = New Size(1192, 150)
        printingdgv.TabIndex = 10
        ' 
        ' dgvSectionSched
        ' 
        dgvSectionSched.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(237))
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = SystemColors.Control
        DataGridViewCellStyle2.Font = New Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.Padding = New Padding(10)
        DataGridViewCellStyle2.SelectionBackColor = Color.Transparent
        DataGridViewCellStyle2.SelectionForeColor = Color.Transparent
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvSectionSched.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvSectionSched.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(237))
        DataGridViewCellStyle3.Font = New Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = Color.WhiteSmoke
        DataGridViewCellStyle3.Padding = New Padding(20)
        DataGridViewCellStyle3.SelectionBackColor = Color.Transparent
        DataGridViewCellStyle3.SelectionForeColor = Color.Transparent
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvSectionSched.DefaultCellStyle = DataGridViewCellStyle3
        dgvSectionSched.Location = New Point(54, 134)
        dgvSectionSched.Name = "dgvSectionSched"
        dgvSectionSched.Size = New Size(1240, 506)
        dgvSectionSched.TabIndex = 11
        ' 
        ' printer
        ' 
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' sectionSched
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Beige
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(1359, 671)
        Controls.Add(dgvSectionSched)
        Controls.Add(printingdgv)
        Controls.Add(Printbtn)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "sectionSched"
        StartPosition = FormStartPosition.CenterScreen
        Text = "sectionSched"
        Panel1.ResumeLayout(False)
        CType(printingdgv, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvSectionSched, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents backbtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Printbtn As Button
    Friend WithEvents printingdgv As DataGridView
    Friend WithEvents dgvSectionSched As DataGridView
    Friend WithEvents printer As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
