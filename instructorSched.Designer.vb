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
<<<<<<< HEAD
=======
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(instructorSched))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
>>>>>>> upstream/main
        Panel1 = New Panel()
        backbtn = New Button()
        Label1 = New Label()
<<<<<<< HEAD
        TextBox2 = New TextBox()
        TextBox7 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        upd = New Button()
        del = New Button()
        TextBox8 = New TextBox()
=======
        Printbtn = New Button()
        printer = New Printing.PrintDocument()
        printingdgv = New DataGridView()
        dgvInstructorSched = New DataGridView()
        PrintPreviewDialog = New PrintPreviewDialog()
>>>>>>> upstream/main
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
        Panel1.Margin = New Padding(4, 5, 4, 5)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1741, 70)
        Panel1.TabIndex = 4
        ' 
        ' backbtn
        ' 
        backbtn.BackgroundImage = My.Resources.Resources._434230529_948718966640697_2976062282803324491_n1
        backbtn.BackgroundImageLayout = ImageLayout.Stretch
        backbtn.FlatStyle = FlatStyle.Flat
        backbtn.ForeColor = Color.FromArgb(CByte(1), CByte(81), CByte(54))
        backbtn.Location = New Point(17, 7)
        backbtn.Margin = New Padding(4, 5, 4, 5)
        backbtn.Name = "backbtn"
        backbtn.Size = New Size(61, 63)
        backbtn.TabIndex = 2
        backbtn.UseVisualStyleBackColor = False
        ' 
<<<<<<< HEAD
        ' Panel2
        ' 
        Panel2.Controls.Add(dgvInstructorSched)
        Panel2.Location = New Point(436, 91)
        Panel2.Margin = New Padding(4, 5, 4, 5)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1280, 706)
        Panel2.TabIndex = 5
        ' 
        ' dgvInstructorSched
        ' 
        dgvInstructorSched.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvInstructorSched.Location = New Point(0, 0)
        dgvInstructorSched.Margin = New Padding(4)
        dgvInstructorSched.Name = "dgvInstructorSched"
        dgvInstructorSched.RowHeadersWidth = 51
        dgvInstructorSched.Size = New Size(1280, 706)
        dgvInstructorSched.TabIndex = 4
        ' 
=======
>>>>>>> upstream/main
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label1.Location = New Point(77, 145)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 39)
        Label1.TabIndex = 6
        ' 
<<<<<<< HEAD
        ' TextBox2
        ' 
        TextBox2.Location = New Point(66, 153)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(324, 31)
        TextBox2.TabIndex = 15
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(66, 509)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(324, 31)
        TextBox7.TabIndex = 20
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(66, 221)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(324, 31)
        TextBox3.TabIndex = 16
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(66, 290)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(324, 31)
        TextBox4.TabIndex = 17
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(66, 362)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(324, 31)
        TextBox5.TabIndex = 18
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(66, 438)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(324, 31)
        TextBox6.TabIndex = 19
        ' 
        ' upd
        ' 
        upd.Location = New Point(76, 635)
        upd.Margin = New Padding(4)
        upd.Name = "upd"
        upd.Size = New Size(136, 56)
        upd.TabIndex = 21
        upd.Text = "Update"
        upd.UseVisualStyleBackColor = True
        ' 
        ' del
        ' 
        del.Location = New Point(238, 635)
        del.Margin = New Padding(4)
        del.Name = "del"
        del.Size = New Size(136, 56)
        del.TabIndex = 22
        del.Text = "Delete"
        del.UseVisualStyleBackColor = True
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(66, 571)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(324, 31)
        TextBox8.TabIndex = 23
=======
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
        Printbtn.TabIndex = 2
        Printbtn.Text = "Print"
        Printbtn.TextImageRelation = TextImageRelation.ImageBeforeText
        Printbtn.UseVisualStyleBackColor = False
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
        ' PrintPreviewDialog
        ' 
        PrintPreviewDialog.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog.ClientSize = New Size(400, 300)
        PrintPreviewDialog.Enabled = True
        PrintPreviewDialog.Icon = CType(resources.GetObject("PrintPreviewDialog.Icon"), Icon)
        PrintPreviewDialog.Name = "PrintPreviewDialog"
        PrintPreviewDialog.Visible = False
>>>>>>> upstream/main
        ' 
        ' instructorSched
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Beige
<<<<<<< HEAD
        ClientSize = New Size(1741, 841)
        Controls.Add(TextBox8)
        Controls.Add(upd)
        Controls.Add(del)
        Controls.Add(TextBox7)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
=======
        ClientSize = New Size(1359, 671)
        Controls.Add(dgvInstructorSched)
        Controls.Add(printingdgv)
        Controls.Add(Printbtn)
>>>>>>> upstream/main
        Controls.Add(Label1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 5, 4, 5)
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
<<<<<<< HEAD
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvInstructorSched As DataGridView
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents upd As Button
    Friend WithEvents del As Button
    Friend WithEvents TextBox8 As TextBox
=======
    Friend WithEvents Label1 As Label
    Friend WithEvents Printbtn As Button
    Friend WithEvents printer As Printing.PrintDocument
    Friend WithEvents printingdgv As DataGridView
    Friend WithEvents dgvInstructorSched As DataGridView
    Friend WithEvents PrintPreviewDialog As PrintPreviewDialog
>>>>>>> upstream/main
End Class
