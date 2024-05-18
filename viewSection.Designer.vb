<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewSection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(viewSection))
        Panel1 = New Panel()
        Label9 = New Label()
        backBtn = New Button()
        Panel2 = New Panel()
        txtsearch = New TextBox()
        panelbtns = New Panel()
        Label1 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(2), CByte(47), CByte(31))
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(backBtn)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1467, 42)
        Panel1.TabIndex = 1
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Calibri", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.WhiteSmoke
        Label9.Location = New Point(1364, 9)
        Label9.Name = "Label9"
        Label9.Size = New Size(91, 24)
        Label9.TabIndex = 4
        Label9.Text = "SECTIONS"
        ' 
        ' backBtn
        ' 
        backBtn.BackgroundImage = My.Resources.Resources.backBtn
        backBtn.BackgroundImageLayout = ImageLayout.Stretch
        backBtn.FlatStyle = FlatStyle.Flat
        backBtn.ForeColor = Color.FromArgb(CByte(1), CByte(81), CByte(54))
        backBtn.Location = New Point(12, 2)
        backBtn.Name = "backBtn"
        backBtn.Size = New Size(43, 38)
        backBtn.TabIndex = 1
        backBtn.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(237))
        Panel2.Controls.Add(txtsearch)
        Panel2.Location = New Point(811, 70)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(597, 46)
        Panel2.TabIndex = 3
        ' 
        ' txtsearch
        ' 
        txtsearch.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(237))
        txtsearch.BorderStyle = BorderStyle.None
        txtsearch.Font = New Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtsearch.Location = New Point(20, 13)
        txtsearch.Name = "txtsearch"
        txtsearch.PlaceholderText = "Search"
        txtsearch.Size = New Size(557, 20)
        txtsearch.TabIndex = 1
        ' 
        ' panelbtns
        ' 
        panelbtns.AutoScroll = True
        panelbtns.Location = New Point(62, 139)
        panelbtns.Name = "panelbtns"
        panelbtns.Size = New Size(1346, 546)
        panelbtns.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label1.Location = New Point(62, 70)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 26)
        Label1.TabIndex = 5
        ' 
        ' viewSection
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Beige
        ClientSize = New Size(1467, 717)
        Controls.Add(Label1)
        Controls.Add(panelbtns)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "viewSection"
        StartPosition = FormStartPosition.CenterScreen
        Text = "viewSection"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents backBtn As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents panelbtns As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
End Class
