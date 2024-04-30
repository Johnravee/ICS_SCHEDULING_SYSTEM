<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InstructorListForm
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
        TextBox1 = New TextBox()
        TextBox9 = New TextBox()
        TextBox8 = New TextBox()
        TextBox7 = New TextBox()
        TextBox6 = New TextBox()
        TextBox5 = New TextBox()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        upd = New Button()
        del = New Button()
        DataGridView1 = New DataGridView()
        TextBox10 = New TextBox()
        TextBox11 = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(599, 13)
        TextBox1.Margin = New Padding(3, 2, 3, 2)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "  Search"
        TextBox1.Size = New Size(428, 29)
        TextBox1.TabIndex = 14
        ' 
        ' TextBox9
        ' 
        TextBox9.Location = New Point(764, 540)
        TextBox9.Margin = New Padding(2)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(228, 23)
        TextBox9.TabIndex = 26
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(755, 498)
        TextBox8.Margin = New Padding(2)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(228, 23)
        TextBox8.TabIndex = 25
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(532, 540)
        TextBox7.Margin = New Padding(2)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(228, 23)
        TextBox7.TabIndex = 24
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(523, 498)
        TextBox6.Margin = New Padding(2)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(228, 23)
        TextBox6.TabIndex = 23
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(268, 540)
        TextBox5.Margin = New Padding(2)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(228, 23)
        TextBox5.TabIndex = 22
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(268, 498)
        TextBox4.Margin = New Padding(2)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(228, 23)
        TextBox4.TabIndex = 21
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(25, 540)
        TextBox3.Margin = New Padding(2)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(228, 23)
        TextBox3.TabIndex = 20
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(25, 498)
        TextBox2.Margin = New Padding(2)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(228, 23)
        TextBox2.TabIndex = 19
        ' 
        ' upd
        ' 
        upd.Location = New Point(523, 453)
        upd.Margin = New Padding(3, 2, 3, 2)
        upd.Name = "upd"
        upd.Size = New Size(95, 34)
        upd.TabIndex = 17
        upd.Text = "Update"
        upd.UseVisualStyleBackColor = True
        ' 
        ' del
        ' 
        del.Location = New Point(754, 453)
        del.Margin = New Padding(3, 2, 3, 2)
        del.Name = "del"
        del.Size = New Size(95, 34)
        del.TabIndex = 18
        del.Text = "Delete"
        del.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
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
        DataGridView1.Location = New Point(25, 46)
        DataGridView1.Margin = New Padding(3, 2, 3, 2)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1002, 391)
        DataGridView1.TabIndex = 16
        ' 
        ' TextBox10
        ' 
        TextBox10.Location = New Point(764, 575)
        TextBox10.Margin = New Padding(2)
        TextBox10.Name = "TextBox10"
        TextBox10.Size = New Size(228, 23)
        TextBox10.TabIndex = 27
        ' 
        ' TextBox11
        ' 
        TextBox11.Location = New Point(523, 575)
        TextBox11.Margin = New Padding(2)
        TextBox11.Name = "TextBox11"
        TextBox11.Size = New Size(228, 23)
        TextBox11.TabIndex = 28
        ' 
        ' InstructorListForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Beige
        ClientSize = New Size(1050, 609)
        Controls.Add(TextBox11)
        Controls.Add(TextBox10)
        Controls.Add(TextBox9)
        Controls.Add(TextBox8)
        Controls.Add(TextBox7)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(upd)
        Controls.Add(del)
        Controls.Add(DataGridView1)
        Controls.Add(TextBox1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "InstructorListForm"
        Text = "InstructorListForm"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents upd As Button
    Friend WithEvents del As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox11 As TextBox
End Class
