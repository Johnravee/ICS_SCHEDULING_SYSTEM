<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Summary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Summary))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        Label9 = New Label()
        backbtn = New Button()
        Printbtn = New Button()
        printer = New Printing.PrintDocument()
        PrintPreviewDialog = New PrintPreviewDialog()
        dgvschedsum = New DataGridView()
        txtsearch = New TextBox()
        Panel1.SuspendLayout()
        CType(dgvschedsum, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(51), CByte(38))
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(backbtn)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1136, 42)
        Panel1.TabIndex = 0
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Calibri", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.WhiteSmoke
        Label9.Location = New Point(1014, 8)
        Label9.Name = "Label9"
        Label9.Size = New Size(99, 24)
        Label9.TabIndex = 4
        Label9.Text = "SUMMARY"
        ' 
        ' backbtn
        ' 
        backbtn.BackColor = Color.Transparent
        backbtn.BackgroundImage = My.Resources.Resources.backBtn
        backbtn.BackgroundImageLayout = ImageLayout.Stretch
        backbtn.FlatStyle = FlatStyle.Flat
        backbtn.ForeColor = Color.FromArgb(CByte(1), CByte(81), CByte(54))
        backbtn.Location = New Point(12, 3)
        backbtn.Name = "backbtn"
        backbtn.Size = New Size(43, 38)
        backbtn.TabIndex = 1
        backbtn.UseVisualStyleBackColor = False
        ' 
        ' Printbtn
        ' 
        Printbtn.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(237))
        Printbtn.FlatAppearance.BorderSize = 0
        Printbtn.FlatStyle = FlatStyle.Flat
        Printbtn.Font = New Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Printbtn.Image = CType(resources.GetObject("Printbtn.Image"), Image)
        Printbtn.Location = New Point(957, 76)
        Printbtn.Name = "Printbtn"
        Printbtn.Size = New Size(142, 55)
        Printbtn.TabIndex = 11
        Printbtn.Text = "Print"
        Printbtn.TextImageRelation = TextImageRelation.ImageBeforeText
        Printbtn.UseVisualStyleBackColor = False
        ' 
        ' printer
        ' 
        ' 
        ' PrintPreviewDialog
        ' 
        PrintPreviewDialog.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog.ClientSize = New Size(400, 300)
        PrintPreviewDialog.Enabled = True
        PrintPreviewDialog.Icon = CType(resources.GetObject("PrintPreviewDialog.Icon"), Icon)
        PrintPreviewDialog.Name = "PrintPreviewDialog"
        PrintPreviewDialog.Visible = False
        ' 
        ' dgvschedsum
        ' 
        dgvschedsum.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvschedsum.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvschedsum.BackgroundColor = Color.Beige
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = SystemColors.Control
        DataGridViewCellStyle2.Font = New Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.Padding = New Padding(2)
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvschedsum.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvschedsum.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = SystemColors.Window
        DataGridViewCellStyle3.Font = New Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle3.Padding = New Padding(5)
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvschedsum.DefaultCellStyle = DataGridViewCellStyle3
        dgvschedsum.Location = New Point(36, 137)
        dgvschedsum.Name = "dgvschedsum"
        dgvschedsum.ReadOnly = True
        dgvschedsum.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvschedsum.Size = New Size(1063, 492)
        dgvschedsum.TabIndex = 14
        ' 
        ' txtsearch
        ' 
        txtsearch.Font = New Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtsearch.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        txtsearch.Location = New Point(36, 100)
        txtsearch.Name = "txtsearch"
        txtsearch.PlaceholderText = "Search"
        txtsearch.Size = New Size(534, 31)
        txtsearch.TabIndex = 15
        ' 
        ' Summary
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Beige
        ClientSize = New Size(1136, 717)
        Controls.Add(txtsearch)
        Controls.Add(dgvschedsum)
        Controls.Add(Printbtn)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Summary"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Summary"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgvschedsum, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents backbtn As Button
    Friend WithEvents Printbtn As Button
    Friend WithEvents printer As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog As PrintPreviewDialog
    Friend WithEvents dgvschedsum As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents txtsearch As TextBox
End Class
