
Imports MySql.Data.MySqlClient


Public Class addNewInstructor


    Private Sub AddInstructor()
        'Sanitize inputs
        If EmailValidation(txtemail.Text) Then

            txtfname.Text = ReplaceSpecialCharacters(UCase(txtfname.Text))
            txtmname.Text = ReplaceSpecialCharacters(UCase(txtmname.Text))
            txtsurname.Text = ReplaceSpecialCharacters(UCase(txtsurname.Text))
            cbworkstatus.SelectedItem = ReplaceSpecialCharacters(UCase(cbworkstatus.SelectedItem))
            cb_gender.SelectedItem = ReplaceSpecialCharacters(UCase(cb_gender.SelectedItem))

            Try
                DBCon()
                cmd.Connection = con
                cmd.CommandText = "INSERT INTO instructor (Firstname, MiddleName, Surname, Gender, Position ,WorkStatus, email) VALUES(@fname, @mname, @surname, @gender, @position, @workstatus, @email)"

                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@fname", txtfname.Text)
                cmd.Parameters.AddWithValue("@mname", txtmname.Text)
                cmd.Parameters.AddWithValue("@surname", txtsurname.Text)
                cmd.Parameters.AddWithValue("@position", "INSTRUCTOR")
                cmd.Parameters.AddWithValue("@workstatus", cbworkstatus.SelectedItem)
                cmd.Parameters.AddWithValue("@email", txtemail.Text)
                cmd.Parameters.AddWithValue("@gender", cb_gender.SelectedItem)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Instructor added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearFields()
                con.Close()
            Catch ex As MySqlException
                If ex.Number = 1062 Then
                    ' MySQL error number 1062 indicates a duplicate entry .
                    MessageBox.Show("Account insertion failed: Duplicate entry found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else

                    MessageBox.Show("Account insertion failed: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            End Try

        Else
            MessageBox.Show("Invalid Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

        If String.IsNullOrEmpty(txtSurname.Text) Then
            errorMessage &= "- Surname" & vbCrLf
        End If


        If String.IsNullOrEmpty(cbworkstatus.SelectedItem) Then
            errorMessage &= "- Work Status" & vbCrLf
        End If



        If String.IsNullOrEmpty(txtEmail.Text) Then
            errorMessage &= "- Email" & vbCrLf
        End If


        If errorMessage <> "Please fill in the following fields:" & vbCrLf Then
            MessageBox.Show(errorMessage, "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Show()
        Else
            Return True
        End If
    End Function


    Private Sub ClearFields()
        txtemail.Clear()
        txtfname.Clear()
        txtmname.Clear()
        txtsurname.Clear()

        cbworkstatus.SelectedIndex = -1
        cb_gender.SelectedIndex = -1

    End Sub

    Private Sub ManualBackBtn_Click(sender As Object, e As EventArgs) Handles ManualBackBtn.Click
        Me.Hide()
        Dashboard.Show()
    End Sub

    Private Sub addbtn_Click(sender As Object, e As EventArgs) Handles addbtn.Click
        'If walang error/no empty fields
        If CheckEmptyFields() Then
            AddInstructor()
        End If

    End Sub


    'Prevent number
    Private Sub txtfname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtfname.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtmname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtmname.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtsurname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsurname.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class