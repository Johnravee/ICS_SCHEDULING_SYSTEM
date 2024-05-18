Public Class adminRegistration

    'Pass data when field is poluted
    Private Sub nextbtn_Click(sender As Object, e As EventArgs) Handles nextbtn.Click
        If CheckEmptyFields() Then
            If EmailValidation(txtemail.Text) Then
                Dim rfidscanForm As New RFIDREGISTRATION
                rfidscanForm.instructorDataConstructor(txtfname.Text, txtmname.Text, txtsurname.Text, cbRole.SelectedItem, txtemail.Text, cbworkstatus.SelectedItem, cb_gender.SelectedItem)


                rfidscanForm.Show()
                Me.Hide()
            Else
                MessageBox.Show("Invalid Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ClearFields()
            End If

        End If
    End Sub



    Private Function CheckEmptyFields() As Boolean
        Dim errorMessage As String = "Please fill in the following fields:" & vbCrLf

        If String.IsNullOrEmpty(txtfname.Text) Then
            errorMessage &= "- First Name" & vbCrLf
        End If

        If String.IsNullOrEmpty(txtmname.Text) Then
            errorMessage &= "- Middle Name" & vbCrLf
        End If

        If String.IsNullOrEmpty(txtsurname.Text) Then
            errorMessage &= "- Surname" & vbCrLf
        End If




        If String.IsNullOrEmpty(cb_gender.SelectedItem) Then
            errorMessage &= "- Gender" & vbCrLf
        End If

        If String.IsNullOrEmpty(cbRole.SelectedItem) Then
            errorMessage &= "- Role" & vbCrLf
        End If

        If String.IsNullOrEmpty(txtemail.Text) Then
            errorMessage &= "- Email" & vbCrLf
        End If

        If String.IsNullOrEmpty(cbworkstatus.SelectedItem) Then
            errorMessage &= "- Work Status" & vbCrLf
        End If



        If errorMessage <> "Please fill in the following fields:" & vbCrLf Then
            MessageBox.Show(errorMessage, "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Show()
        Else
            Return True
        End If
    End Function

    Private Sub ManualBackBtn_Click(sender As Object, e As EventArgs) Handles ManualBackBtn.Click
        Me.Hide()
        ScanRFIDLOGIN.Show()
        ClearFields()
    End Sub

    Private Sub ClearFields()
        txtemail.Clear()
        txtfname.Clear()
        txtmname.Clear()
        txtsurname.Clear()
        cbworkstatus.SelectedIndex = -1
        cbRole.SelectedIndex = -1
        cb_gender.SelectedIndex = -1
    End Sub


End Class