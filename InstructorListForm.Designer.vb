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
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InstructorListForm))
        TextBox1 = New TextBox()
        txtsurname = New TextBox()
        txtmidname = New TextBox()
        txtFirtname = New TextBox()
        txtrfid = New TextBox()
        txtinstructorid = New TextBox()
        upd = New Button()
        del = New Button()
        DataGridView1 = New DataGridView()
        txtemail = New TextBox()
        cborole = New ComboBox()
        cbworkstatus = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Panel1 = New Panel()
        Label8 = New Label()
        cb_gender = New ComboBox()
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
        ' txtsurname
        ' 
        txtsurname.BackColor = Color.LightYellow
        txtsurname.BorderStyle = BorderStyle.FixedSingle
        txtsurname.Font = New Font("Calibri", 15.75F, FontStyle.Bold)
        txtsurname.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        txtsurname.Location = New Point(561, 479)
        txtsurname.Margin = New Padding(2)
        txtsurname.Name = "txtsurname"
        txtsurname.Size = New Size(228, 33)
        txtsurname.TabIndex = 23
        ' 
        ' txtmidname
        ' 
        txtmidname.BackColor = Color.LightYellow
        txtmidname.BorderStyle = BorderStyle.FixedSingle
        txtmidname.Font = New Font("Calibri", 15.75F, FontStyle.Bold)
        txtmidname.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        txtmidname.Location = New Point(292, 479)
        txtmidname.Margin = New Padding(2)
        txtmidname.Name = "txtmidname"
        txtmidname.Size = New Size(228, 33)
        txtmidname.TabIndex = 22
        ' 
        ' txtFirtname
        ' 
        txtFirtname.BackColor = Color.LightYellow
        txtFirtname.BorderStyle = BorderStyle.FixedSingle
        txtFirtname.Font = New Font("Calibri", 15.75F, FontStyle.Bold)
        txtFirtname.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        txtFirtname.Location = New Point(25, 479)
        txtFirtname.Margin = New Padding(2)
        txtFirtname.Name = "txtFirtname"
        txtFirtname.Size = New Size(228, 33)
        txtFirtname.TabIndex = 21
        ' 
        ' txtrfid
        ' 
        txtrfid.Location = New Point(59, 11)
        txtrfid.Margin = New Padding(2)
        txtrfid.Name = "txtrfid"
        txtrfid.Size = New Size(56, 23)
        txtrfid.TabIndex = 20
        ' 
        ' txtinstructorid
        ' 
        txtinstructorid.Location = New Point(197, 11)
        txtinstructorid.Margin = New Padding(2)
        txtinstructorid.Name = "txtinstructorid"
        txtinstructorid.Size = New Size(56, 23)
        txtinstructorid.TabIndex = 19
        ' 
        ' upd
        ' 
        upd.BackColor = Color.FromArgb(CByte(20), CByte(164), CByte(77))
        upd.FlatAppearance.BorderSize = 0
        upd.FlatStyle = FlatStyle.Flat
        upd.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        upd.ForeColor = Color.WhiteSmoke
        upd.Location = New Point(799, 563)
        upd.Margin = New Padding(3, 2, 3, 2)
        upd.Name = "upd"
        upd.Size = New Size(95, 34)
        upd.TabIndex = 17
        upd.Text = "UPDATE"
        upd.UseVisualStyleBackColor = False
        ' 
        ' del
        ' 
        del.BackColor = Color.FromArgb(CByte(220), CByte(76), CByte(100))
        del.FlatAppearance.BorderSize = 0
        del.FlatStyle = FlatStyle.Flat
        del.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        del.ForeColor = Color.WhiteSmoke
        del.Location = New Point(932, 563)
        del.Margin = New Padding(3, 2, 3, 2)
        del.Name = "del"
        del.Size = New Size(95, 34)
        del.TabIndex = 18
        del.Text = "DELETE"
        del.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = Color.Beige
        DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = SystemColors.Control
        DataGridViewCellStyle2.Font = New Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.Padding = New Padding(5)
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = SystemColors.Window
        DataGridViewCellStyle3.Font = New Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle3.Padding = New Padding(10)
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        DataGridView1.Location = New Point(25, 46)
        DataGridView1.Margin = New Padding(3, 2, 3, 2)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(1002, 391)
        DataGridView1.TabIndex = 16
        ' 
        ' txtemail
        ' 
        txtemail.BackColor = Color.LightYellow
        txtemail.BorderStyle = BorderStyle.FixedSingle
        txtemail.Font = New Font("Calibri", 15.75F, FontStyle.Bold)
        txtemail.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        txtemail.Location = New Point(540, 564)
        txtemail.Margin = New Padding(2)
        txtemail.Name = "txtemail"
        txtemail.Size = New Size(228, 33)
        txtemail.TabIndex = 27
        ' 
        ' cborole
        ' 
        cborole.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cborole.AutoCompleteSource = AutoCompleteSource.ListItems
        cborole.BackColor = Color.LightYellow
        cborole.DropDownStyle = ComboBoxStyle.DropDownList
        cborole.Font = New Font("Calibri", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cborole.FormattingEnabled = True
        cborole.Items.AddRange(New Object() {"INSTRUCTOR"})
        cborole.Location = New Point(25, 565)
        cborole.Name = "cborole"
        cborole.Size = New Size(228, 32)
        cborole.TabIndex = 29
        ' 
        ' cbworkstatus
        ' 
        cbworkstatus.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cbworkstatus.AutoCompleteSource = AutoCompleteSource.ListItems
        cbworkstatus.BackColor = Color.LightYellow
        cbworkstatus.DropDownStyle = ComboBoxStyle.DropDownList
        cbworkstatus.Font = New Font("Calibri", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cbworkstatus.FormattingEnabled = True
        cbworkstatus.Items.AddRange(New Object() {"FULL-TIMER", "PART-TIMER"})
        cbworkstatus.Location = New Point(281, 565)
        cbworkstatus.Name = "cbworkstatus"
        cbworkstatus.Size = New Size(228, 32)
        cbworkstatus.TabIndex = 30
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(25, 454)
        Label1.Name = "Label1"
        Label1.Size = New Size(90, 23)
        Label1.TabIndex = 31
        Label1.Text = "Firstname"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(292, 454)
        Label2.Name = "Label2"
        Label2.Size = New Size(111, 23)
        Label2.TabIndex = 32
        Label2.Text = "Middlename"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(571, 454)
        Label3.Name = "Label3"
        Label3.Size = New Size(80, 23)
        Label3.TabIndex = 33
        Label3.Text = "Surname"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(25, 539)
        Label5.Name = "Label5"
        Label5.Size = New Size(46, 23)
        Label5.TabIndex = 36
        Label5.Text = "Role"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(281, 539)
        Label6.Name = "Label6"
        Label6.Size = New Size(106, 23)
        Label6.TabIndex = 37
        Label6.Text = "Work Status"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(539, 539)
        Label7.Name = "Label7"
        Label7.Size = New Size(53, 23)
        Label7.TabIndex = 38
        Label7.Text = "Email"
        ' 
        ' Panel1
        ' 
        Panel1.Location = New Point(59, 5)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(200, 29)
        Panel1.TabIndex = 39
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(826, 454)
        Label8.Name = "Label8"
        Label8.Size = New Size(69, 23)
        Label8.TabIndex = 41
        Label8.Text = "Gender"
        ' 
        ' cb_gender
        ' 
        cb_gender.AutoCompleteMode = AutoCompleteMode.Append
        cb_gender.AutoCompleteSource = AutoCompleteSource.ListItems
        cb_gender.BackColor = Color.LightYellow
        cb_gender.DropDownStyle = ComboBoxStyle.DropDownList
        cb_gender.Font = New Font("Calibri", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cb_gender.FormattingEnabled = True
        cb_gender.Items.AddRange(New Object() {"MALE", "FEMALE"})
        cb_gender.Location = New Point(826, 480)
        cb_gender.Name = "cb_gender"
        cb_gender.Size = New Size(201, 32)
        cb_gender.TabIndex = 40
        ' 
        ' InstructorListForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Beige
        ClientSize = New Size(1050, 609)
        Controls.Add(Label8)
        Controls.Add(cb_gender)
        Controls.Add(Panel1)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(cbworkstatus)
        Controls.Add(cborole)
        Controls.Add(txtemail)
        Controls.Add(txtsurname)
        Controls.Add(txtmidname)
        Controls.Add(txtFirtname)
        Controls.Add(txtrfid)
        Controls.Add(txtinstructorid)
        Controls.Add(upd)
        Controls.Add(del)
        Controls.Add(DataGridView1)
        Controls.Add(TextBox1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 2, 3, 2)
        Name = "InstructorListForm"
        Text = "InstructorListForm"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtsurname As TextBox
    Friend WithEvents txtmidname As TextBox
    Friend WithEvents txtFirtname As TextBox
    Friend WithEvents txtrfid As TextBox
    Friend WithEvents txtinstructorid As TextBox
    Friend WithEvents upd As Button
    Friend WithEvents del As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtemail As TextBox
    Friend WithEvents cborole As ComboBox
    Friend WithEvents cbworkstatus As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents cb_gender As ComboBox
End Class
