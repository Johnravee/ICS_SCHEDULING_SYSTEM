<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SectionListForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SectionListForm))
        Panel1 = New Panel()
        InsertBtn = New Button()
        Label6 = New Label()
        Label4 = New Label()
        Button2 = New Button()
        Label5 = New Label()
        Button1 = New Button()
        Label2 = New Label()
        txtprogram = New TextBox()
        txtyear = New TextBox()
        txtcode = New TextBox()
        txtsectionid = New TextBox()
        SearchTextBox = New TextBox()
        DataGridView1 = New DataGridView()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(2), CByte(47), CByte(31))
        Panel1.Controls.Add(InsertBtn)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(txtprogram)
        Panel1.Controls.Add(txtyear)
        Panel1.Controls.Add(txtcode)
        Panel1.Location = New Point(24, 415)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1000, 168)
        Panel1.TabIndex = 17
        ' 
        ' InsertBtn
        ' 
        InsertBtn.BackColor = Color.FromArgb(CByte(24), CByte(161), CByte(79))
        InsertBtn.FlatAppearance.BorderSize = 0
        InsertBtn.FlatStyle = FlatStyle.Flat
        InsertBtn.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        InsertBtn.ForeColor = Color.WhiteSmoke
        InsertBtn.Location = New Point(323, 106)
        InsertBtn.Margin = New Padding(3, 2, 3, 2)
        InsertBtn.Name = "InsertBtn"
        InsertBtn.Size = New Size(126, 42)
        InsertBtn.TabIndex = 19
        InsertBtn.Text = "INSERT"
        InsertBtn.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(266, 11)
        Label6.Name = "Label6"
        Label6.Size = New Size(99, 29)
        Label6.TabIndex = 18
        Label6.Text = "Program"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(455, 11)
        Label4.Name = "Label4"
        Label4.Size = New Size(71, 29)
        Label4.TabIndex = 18
        Label4.Text = "Code:"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(228), CByte(161), CByte(27))
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.WhiteSmoke
        Button2.Location = New Point(455, 106)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(126, 42)
        Button2.TabIndex = 14
        Button2.Text = "UPDATE"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(650, 11)
        Label5.Name = "Label5"
        Label5.Size = New Size(63, 29)
        Label5.TabIndex = 18
        Label5.Text = "Year:"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(223), CByte(70), CByte(98))
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.WhiteSmoke
        Button1.Location = New Point(587, 106)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(126, 42)
        Button1.TabIndex = 15
        Button1.Text = "DELETE"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(16, 11)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 29)
        Label2.TabIndex = 18
        Label2.Text = "Sections"
        ' 
        ' txtprogram
        ' 
        txtprogram.BorderStyle = BorderStyle.None
        txtprogram.Font = New Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtprogram.Location = New Point(266, 43)
        txtprogram.Name = "txtprogram"
        txtprogram.Size = New Size(139, 40)
        txtprogram.TabIndex = 0
        txtprogram.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtyear
        ' 
        txtyear.BorderStyle = BorderStyle.None
        txtyear.Font = New Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtyear.Location = New Point(650, 43)
        txtyear.Name = "txtyear"
        txtyear.Size = New Size(139, 40)
        txtyear.TabIndex = 0
        txtyear.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtcode
        ' 
        txtcode.BorderStyle = BorderStyle.None
        txtcode.Font = New Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtcode.Location = New Point(455, 43)
        txtcode.Name = "txtcode"
        txtcode.Size = New Size(139, 40)
        txtcode.TabIndex = 0
        txtcode.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtsectionid
        ' 
        txtsectionid.BorderStyle = BorderStyle.None
        txtsectionid.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        txtsectionid.Location = New Point(155, 86)
        txtsectionid.Name = "txtsectionid"
        txtsectionid.Size = New Size(139, 16)
        txtsectionid.TabIndex = 0
        txtsectionid.TextAlign = HorizontalAlignment.Center
        ' 
        ' SearchTextBox
        ' 
        SearchTextBox.Font = New Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SearchTextBox.Location = New Point(596, 26)
        SearchTextBox.Margin = New Padding(3, 2, 3, 2)
        SearchTextBox.Multiline = True
        SearchTextBox.Name = "SearchTextBox"
        SearchTextBox.PlaceholderText = "  Search"
        SearchTextBox.Size = New Size(428, 29)
        SearchTextBox.TabIndex = 16
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.Beige
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.Padding = New Padding(5)
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.Padding = New Padding(10)
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.Location = New Point(24, 59)
        DataGridView1.Margin = New Padding(3, 2, 3, 2)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(999, 365)
        DataGridView1.TabIndex = 13
        ' 
        ' SectionListForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Beige
        ClientSize = New Size(1050, 609)
        Controls.Add(Panel1)
        Controls.Add(SearchTextBox)
        Controls.Add(DataGridView1)
        Controls.Add(txtsectionid)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 2, 3, 2)
        Name = "SectionListForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SectionListForm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtprogram As TextBox
    Friend WithEvents txtyear As TextBox
    Friend WithEvents txtcode As TextBox
    Friend WithEvents txtsectionid As TextBox
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents InsertBtn As Button
End Class
