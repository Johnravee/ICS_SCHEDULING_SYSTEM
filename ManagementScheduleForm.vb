Public Class ManagementScheduleForm
    Sub switchPanel(ByVal panel As Form)
        Panel3.Controls.Clear()
        panel.TopLevel = False
        Panel3.Controls.Add(panel)
        panel.Show()

    End Sub
    Private Sub InstructorListBtn_Click(sender As Object, e As EventArgs) Handles InstructorListBtn.Click
        switchPanel(InstructorListForm)
    End Sub

    Private Sub ScheduleListBtn_Click(sender As Object, e As EventArgs) Handles ScheduleListBtn.Click
        switchPanel(SchedListForm)
    End Sub

    Private Sub FacilityListBtn_Click(sender As Object, e As EventArgs) Handles FacilityListBtn.Click
        switchPanel(FacilityListForm)
    End Sub

    Private Sub SectionListBtn_Click(sender As Object, e As EventArgs) Handles SectionListBtn.Click
        switchPanel(SectionListForm)
    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Dashboard.Show()
        Me.Hide()
    End Sub
End Class