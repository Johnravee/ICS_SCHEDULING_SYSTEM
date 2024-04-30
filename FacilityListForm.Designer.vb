<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FacilityListForm
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
        Label4 = New Label()
        UpdateButton = New Button()
        DeleteButton = New Button()
        Label3 = New Label()
        Label2 = New Label()
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
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(UpdateButton)
        Panel1.Controls.Add(DeleteButton)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(TextBox3)
        Panel1.Controls.Add(TextBox2)
        Panel1.Location = New Point(29, 422)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(991, 168)
        Panel1.TabIndex = 20
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(48, 115)
        Label4.Name = "Label4"
        Label4.Size = New Size(161, 29)
        Label4.TabIndex = 18
        Label4.Text = "Room Number"
        ' 
        ' UpdateButton
        ' 
        UpdateButton.Location = New Point(675, 108)
        UpdateButton.Margin = New Padding(3, 2, 3, 2)
        UpdateButton.Name = "UpdateButton"
        UpdateButton.Size = New Size(95, 34)
        UpdateButton.TabIndex = 14
        UpdateButton.Text = "Update"
        UpdateButton.UseVisualStyleBackColor = True
        ' 
        ' DeleteButton
        ' 
        DeleteButton.Location = New Point(521, 108)
        DeleteButton.Margin = New Padding(3, 2, 3, 2)
        DeleteButton.Name = "DeleteButton"
        DeleteButton.Size = New Size(95, 34)
        DeleteButton.TabIndex = 15
        DeleteButton.Text = "Delete"
        DeleteButton.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(101, 73)
        Label3.Name = "Label3"
        Label3.Size = New Size(94, 29)
        Label3.TabIndex = 18
        Label3.Text = "RoomID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(386, 16)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 29)
        Label2.TabIndex = 18
        Label2.Text = "Facility"
        ' 
        ' TextBox3
        ' 
        TextBox3.BorderStyle = BorderStyle.None
        TextBox3.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        TextBox3.Location = New Point(214, 126)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(139, 16)
        TextBox3.TabIndex = 0
        TextBox3.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox2
        ' 
        TextBox2.BorderStyle = BorderStyle.None
        TextBox2.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        TextBox2.Location = New Point(214, 84)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(139, 16)
        TextBox2.TabIndex = 0
        TextBox2.TextAlign = HorizontalAlignment.Center
        ' 
        ' SearchTextBox
        ' 
        SearchTextBox.Font = New Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SearchTextBox.Location = New Point(592, 24)
        SearchTextBox.Margin = New Padding(3, 2, 3, 2)
        SearchTextBox.Multiline = True
        SearchTextBox.Name = "SearchTextBox"
        SearchTextBox.PlaceholderText = "  Search"
        SearchTextBox.Size = New Size(428, 29)
        SearchTextBox.TabIndex = 19
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.Beige
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.Padding = New Padding(5)
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.Padding = New Padding(10)
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.Location = New Point(30, 57)
        DataGridView1.Margin = New Padding(3, 2, 3, 2)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(990, 365)
        DataGridView1.TabIndex = 18
        ' 
        ' FacilityListForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Beige
        ClientSize = New Size(1050, 609)
        Controls.Add(Panel1)
        Controls.Add(SearchTextBox)
        Controls.Add(DataGridView1)
        FormBorderStyle = FormBorderStyle.None
        Name = "FacilityListForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FacilityListForm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents UpdateButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
