<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InstructorListForm
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
        TextBox1.Location = New Point(617, 22)
        TextBox1.Margin = New Padding(4)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "  Search"
        TextBox1.Size = New Size(609, 45)
        TextBox1.TabIndex = 14
        ' 
        ' TextBox9
        ' 
        TextBox9.Location = New Point(10, 596)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(324, 31)
        TextBox9.TabIndex = 26
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(10, 508)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(324, 31)
        TextBox8.TabIndex = 25
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(10, 436)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(324, 31)
        TextBox7.TabIndex = 24
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(10, 365)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(324, 31)
        TextBox6.TabIndex = 23
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(10, 289)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(324, 31)
        TextBox5.TabIndex = 22
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(10, 217)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(324, 31)
        TextBox4.TabIndex = 21
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(10, 148)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(324, 31)
        TextBox3.TabIndex = 20
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(10, 80)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(324, 31)
        TextBox2.TabIndex = 19
        ' 
        ' upd
        ' 
        upd.Location = New Point(747, 755)
        upd.Margin = New Padding(4)
        upd.Name = "upd"
        upd.Size = New Size(136, 56)
        upd.TabIndex = 17
        upd.Text = "Update"
        upd.UseVisualStyleBackColor = True
        ' 
        ' del
        ' 
        del.Location = New Point(1077, 755)
        del.Margin = New Padding(4)
        del.Name = "del"
        del.Size = New Size(136, 56)
        del.TabIndex = 18
        del.Text = "Delete"
        del.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(404, 87)
        DataGridView1.Margin = New Padding(4)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1110, 651)
        DataGridView1.TabIndex = 16
        ' 
        ' TextBox10
        ' 
        TextBox10.Location = New Point(12, 664)
        TextBox10.Name = "TextBox10"
        TextBox10.Size = New Size(324, 31)
        TextBox10.TabIndex = 27
        ' 
        ' TextBox11
        ' 
        TextBox11.Location = New Point(10, 723)
        TextBox11.Name = "TextBox11"
        TextBox11.Size = New Size(324, 31)
        TextBox11.TabIndex = 28
        ' 
        ' InstructorListForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Beige
        ClientSize = New Size(1524, 842)
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
        Margin = New Padding(4)
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
