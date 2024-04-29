<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SchedListForm
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
        TextBox1 = New TextBox()
        upd = New Button()
        del = New Button()
        dgv = New DataGridView()
        TextBox9 = New TextBox()
        TextBox8 = New TextBox()
        TextBox7 = New TextBox()
        TextBox6 = New TextBox()
        TextBox5 = New TextBox()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        CType(dgv, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(635, 32)
        TextBox1.Margin = New Padding(4)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "  Search"
        TextBox1.Size = New Size(609, 45)
        TextBox1.TabIndex = 6
        ' 
        ' upd
        ' 
        upd.Location = New Point(764, 762)
        upd.Margin = New Padding(4)
        upd.Name = "upd"
        upd.Size = New Size(136, 56)
        upd.TabIndex = 4
        upd.Text = "Update"
        upd.UseVisualStyleBackColor = True
        ' 
        ' del
        ' 
        del.Location = New Point(1094, 762)
        del.Margin = New Padding(4)
        del.Name = "del"
        del.Size = New Size(136, 56)
        del.TabIndex = 5
        del.Text = "Delete"
        del.UseVisualStyleBackColor = True
        ' 
        ' dgv
        ' 
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv.Location = New Point(421, 94)
        dgv.Margin = New Padding(4)
        dgv.Name = "dgv"
        dgv.RowHeadersWidth = 51
        dgv.Size = New Size(1110, 651)
        dgv.TabIndex = 3
        ' 
        ' TextBox9
        ' 
        TextBox9.Location = New Point(27, 661)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(324, 31)
        TextBox9.TabIndex = 15
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(27, 573)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(324, 31)
        TextBox8.TabIndex = 14
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(27, 501)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(324, 31)
        TextBox7.TabIndex = 13
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(27, 430)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(324, 31)
        TextBox6.TabIndex = 12
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(27, 354)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(324, 31)
        TextBox5.TabIndex = 11
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(27, 282)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(324, 31)
        TextBox4.TabIndex = 10
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(27, 213)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(324, 31)
        TextBox3.TabIndex = 9
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(27, 145)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(324, 31)
        TextBox2.TabIndex = 8
        ' 
        ' SchedListForm
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Beige
        ClientSize = New Size(1544, 842)
        Controls.Add(TextBox9)
        Controls.Add(TextBox8)
        Controls.Add(TextBox7)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(upd)
        Controls.Add(del)
        Controls.Add(dgv)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "SchedListForm"
        Text = "SchedListForm"
        CType(dgv, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents upd As Button
    Friend WithEvents del As Button
    Friend WithEvents dgv As DataGridView
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
End Class
