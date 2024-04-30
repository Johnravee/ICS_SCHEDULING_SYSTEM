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
        Panel1 = New Panel()
        Label6 = New Label()
        Label4 = New Label()
        Button2 = New Button()
        Label5 = New Label()
        Button1 = New Button()
        Label3 = New Label()
        Label2 = New Label()
        TextBox5 = New TextBox()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        SearchTextBox = New TextBox()
        DataGridView1 = New DataGridView()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(2), CByte(47), CByte(31))
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(TextBox5)
        Panel1.Controls.Add(TextBox4)
        Panel1.Controls.Add(TextBox3)
        Panel1.Controls.Add(TextBox2)
        Panel1.Location = New Point(24, 415)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1000, 168)
        Panel1.TabIndex = 17
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(278, 109)
        Label6.Name = "Label6"
        Label6.Size = New Size(177, 29)
        Label6.TabIndex = 18
        Label6.Text = "Section Program"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(295, 63)
        Label4.Name = "Label4"
        Label4.Size = New Size(142, 29)
        Label4.TabIndex = 18
        Label4.Text = "Section Code"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(757, 110)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(95, 34)
        Button2.TabIndex = 14
        Button2.Text = "Update"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(57, 109)
        Label5.Name = "Label5"
        Label5.Size = New Size(56, 29)
        Label5.TabIndex = 18
        Label5.Text = "Year"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(635, 110)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(95, 34)
        Button1.TabIndex = 15
        Button1.Text = "Delete"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(18, 63)
        Label3.Name = "Label3"
        Label3.Size = New Size(107, 29)
        Label3.TabIndex = 18
        Label3.Text = "SectionID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(386, 16)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 29)
        Label2.TabIndex = 18
        Label2.Text = "Sections"
        ' 
        ' TextBox5
        ' 
        TextBox5.BorderStyle = BorderStyle.None
        TextBox5.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        TextBox5.Location = New Point(461, 120)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(139, 16)
        TextBox5.TabIndex = 0
        TextBox5.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox4
        ' 
        TextBox4.BorderStyle = BorderStyle.None
        TextBox4.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        TextBox4.Location = New Point(131, 120)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(139, 16)
        TextBox4.TabIndex = 0
        TextBox4.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox3
        ' 
        TextBox3.BorderStyle = BorderStyle.None
        TextBox3.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        TextBox3.Location = New Point(461, 74)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(139, 16)
        TextBox3.TabIndex = 0
        TextBox3.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox2
        ' 
        TextBox2.BorderStyle = BorderStyle.None
        TextBox2.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        TextBox2.Location = New Point(131, 74)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(139, 16)
        TextBox2.TabIndex = 0
        TextBox2.TextAlign = HorizontalAlignment.Center
        ' 
        ' SearchTextBox
        ' 
        SearchTextBox.Font = New Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SearchTextBox.Location = New Point(596, 11)
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
        DataGridView1.Location = New Point(25, 50)
        DataGridView1.Margin = New Padding(3, 2, 3, 2)
        DataGridView1.Name = "DataGridView1"
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
        FormBorderStyle = FormBorderStyle.None
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
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
