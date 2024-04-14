Public Class Dashboard
    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub

    Private Sub minimizeBtn_Click(sender As Object, e As EventArgs) Handles minimizeBtn.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub



    Private Sub btnNewSched_Click(sender As Object, e As EventArgs) Handles btnNewSched.Click
        CreateScheduleForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnNewInstructor_Click(sender As Object, e As EventArgs) Handles btnNewInstructor.Click
        addNewInstructor.Show()
        Me.Hide()
    End Sub

    Private Sub LogoutBtn_Click(sender As Object, e As EventArgs) Handles LogoutBtn.Click
        SaveUserData(Nothing)

        Authentication_Form.Show()
        Me.Hide()
    End Sub
End Class
