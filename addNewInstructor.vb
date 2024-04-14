
Imports MySql.Data.MySqlClient


Public Class addNewInstructor


    Private Sub AddInstructor()
        'Sanitize inputs
        If EmailValidation(txtemail.Text) Then

            txtfname.Text = ReplaceSpecialCharacters(UCase(txtfname.Text))
            txtmname.Text = ReplaceSpecialCharacters(UCase(txtmname.Text))
            txtsurname.Text = ReplaceSpecialCharacters(UCase(txtsurname.Text))
            cbsuffix.SelectedItem = ReplaceSpecialCharacters(UCase(cbsuffix.SelectedItem))
            cbworkstatus.SelectedItem = ReplaceSpecialCharacters(UCase(cbworkstatus.SelectedItem))

            Try
                DBCon()
                cmd.Connection = con
                cmd.CommandText = "INSERT INTO instructor (Firstname, MiddleName, Surname, Suffix, Position ,WorkStatus, email) VALUES(@fname, @mname, @surname, @suffix, @position, @workstatus, @email)"

                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@fname", txtfname.Text)
                cmd.Parameters.AddWithValue("@mname", txtmname.Text)
                cmd.Parameters.AddWithValue("@surname", txtsurname.Text)
                cmd.Parameters.AddWithValue("@suffix", cbsuffix.SelectedItem)
                cmd.Parameters.AddWithValue("@position", "INSTRUCTOR")
                cmd.Parameters.AddWithValue("@workstatus", cbworkstatus.SelectedItem)
                cmd.Parameters.AddWithValue("@email", txtemail.Text)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Account inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearFields()
                con.Close()
            Catch ex As MySqlException
                If ex.Number = 1062 Then
                    ' MySQL error number 1062 indicates a duplicate entry (e.g., unique key constraint violation)
                    MessageBox.Show("Account insertion failed: Duplicate entry found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    ' Display a generic error message for other MySQL exceptions
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

        If String.IsNullOrEmpty(cbsuffix.SelectedItem) Then
            errorMessage &= "- Suffix" & vbCrLf
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
        cbsuffix.SelectedIndex = -1
        cbworkstatus.SelectedIndex = -1

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
End Class