Public Class Authentication_Form
    Private Sub Authentication_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Scan_AuthForm.Dock = DockStyle.Fill
        ManualLoginForm.Dock = DockStyle.Fill
        PinLoginForm.Dock = DockStyle.Fill
    End Sub
    Private Sub Scan_AuthForm_Paint(sender As Object, e As PaintEventArgs) Handles Scan_AuthForm.Paint
        RFIDBOX_Scan.Focus()
    End Sub

    Private Sub ManualLogin_Link_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ManualLogin_Link.LinkClicked
        MsgBox("Clicked")
        Scan_AuthForm.Hide()
        ManualLoginForm.Show()
    End Sub

    'Timer
    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        RFIDBOX_Scan.Text = ""
    End Sub

    Private Sub RFIDBOX_Scan_TextChanged(sender As Object, e As EventArgs) Handles RFIDBOX_Scan.TextChanged
        If RFIDBOX_Scan.Text.Length = 10 Then
            timer.Start()
        End If
    End Sub

    Private Sub ScanMinimize_Click(sender As Object, e As EventArgs) Handles ScanMinimize.Click

    End Sub
End Class