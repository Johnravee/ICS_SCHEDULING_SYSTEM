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
        InsertBtn = New Button()
        UpdateButton = New Button()
        DeleteButton = New Button()
        Label4 = New Label()
        Label2 = New Label()
        txtroom = New TextBox()
        SearchTextBox = New TextBox()
        txtid = New TextBox()
        DataGridView1 = New DataGridView()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(2), CByte(47), CByte(31))
        Panel1.Controls.Add(InsertBtn)
        Panel1.Controls.Add(UpdateButton)
        Panel1.Controls.Add(DeleteButton)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(txtroom)
        Panel1.Location = New Point(29, 422)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(991, 168)
        Panel1.TabIndex = 20
        ' 
        ' InsertBtn
        ' 
        InsertBtn.BackColor = Color.FromArgb(CByte(24), CByte(161), CByte(79))
        InsertBtn.FlatAppearance.BorderSize = 0
        InsertBtn.FlatStyle = FlatStyle.Flat
        InsertBtn.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        InsertBtn.ForeColor = Color.WhiteSmoke
        InsertBtn.Location = New Point(312, 102)
        InsertBtn.Margin = New Padding(3, 2, 3, 2)
        InsertBtn.Name = "InsertBtn"
        InsertBtn.Size = New Size(126, 42)
        InsertBtn.TabIndex = 22
        InsertBtn.Text = "INSERT"
        InsertBtn.UseVisualStyleBackColor = False
        ' 
        ' UpdateButton
        ' 
        UpdateButton.BackColor = Color.FromArgb(CByte(228), CByte(161), CByte(27))
        UpdateButton.FlatAppearance.BorderSize = 0
        UpdateButton.FlatStyle = FlatStyle.Flat
        UpdateButton.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        UpdateButton.ForeColor = Color.WhiteSmoke
        UpdateButton.Location = New Point(444, 102)
        UpdateButton.Margin = New Padding(3, 2, 3, 2)
        UpdateButton.Name = "UpdateButton"
        UpdateButton.Size = New Size(126, 42)
        UpdateButton.TabIndex = 20
        UpdateButton.Text = "UPDATE"
        UpdateButton.UseVisualStyleBackColor = False
        ' 
        ' DeleteButton
        ' 
        DeleteButton.BackColor = Color.FromArgb(CByte(223), CByte(70), CByte(98))
        DeleteButton.FlatAppearance.BorderSize = 0
        DeleteButton.FlatStyle = FlatStyle.Flat
        DeleteButton.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DeleteButton.ForeColor = Color.WhiteSmoke
        DeleteButton.Location = New Point(576, 102)
        DeleteButton.Margin = New Padding(3, 2, 3, 2)
        DeleteButton.Name = "DeleteButton"
        DeleteButton.Size = New Size(126, 42)
        DeleteButton.TabIndex = 21
        DeleteButton.Text = "DELETE"
        DeleteButton.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(312, 13)
        Label4.Name = "Label4"
        Label4.Size = New Size(73, 29)
        Label4.TabIndex = 18
        Label4.Text = "Room"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(16, 13)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 29)
        Label2.TabIndex = 18
        Label2.Text = "Facility"
        ' 
        ' txtroom
        ' 
        txtroom.BorderStyle = BorderStyle.None
        txtroom.Font = New Font("Calibri", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtroom.Location = New Point(312, 45)
        txtroom.Name = "txtroom"
        txtroom.Size = New Size(390, 43)
        txtroom.TabIndex = 0
        txtroom.TextAlign = HorizontalAlignment.Center
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
        ' txtid
        ' 
        txtid.BorderStyle = BorderStyle.None
        txtid.Font = New Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtid.Location = New Point(420, 129)
        txtid.Name = "txtid"
        txtid.Size = New Size(139, 15)
        txtid.TabIndex = 23
        txtid.TextAlign = HorizontalAlignment.Center
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
        DataGridView1.Location = New Point(29, 57)
        DataGridView1.Margin = New Padding(3, 2, 3, 2)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(990, 365)
        DataGridView1.TabIndex = 24
        ' 
        ' FacilityListForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Beige
        ClientSize = New Size(1050, 609)
        Controls.Add(DataGridView1)
        Controls.Add(txtid)
        Controls.Add(Panel1)
        Controls.Add(SearchTextBox)
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
    Friend WithEvents Label2 As Label
    Friend WithEvents txtroom As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents InsertBtn As Button
    Friend WithEvents UpdateButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents txtid As TextBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
