Imports System.IO
Imports MySql.Data.MySqlClient
Imports Mysqlx.Notice
Imports System.Runtime.Intrinsics.Arm
Imports K4os.Compression.LZ4.Streams
Imports System.Net

Public Class addNewInstructor
    Dim imageBytes() As Byte
    Dim emailFormat As String





    'Save button
    Private Sub AddInstructorBtn_Click(sender As Object, e As EventArgs) Handles AddInstructorBtn.Click
        Me.Hide()

        If imageBytes Is Nothing Then
            MessageBox.Show("Please upload a profile image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Show()
            Return
        End If

        'If walang error/no empty fields
        If CheckEmptyFields() Then
            insertData()
        End If


    End Sub

    'Ayusin pa tong age base on birthdate


    'Evaluate every input boxes.
    Private Sub insertData()
        Dim firstName As String, middleName As String, surname As String, suffix As String,
    age As String, sex As String, contact As String, jobPosition As String, workStatus As String
        'instance
        Dim rfidandpinreg As New rfidandPinRegistrationforinstructors()

        'Sanitize inputs
        firstName = ReplaceSpecialCharacters(UCase(txtfirstname.Text))
        middleName = ReplaceSpecialCharacters(UCase(txtMiddlename.Text))
        surname = ReplaceSpecialCharacters(UCase(txtSurname.Text))
        suffix = ReplaceSpecialCharacters(UCase(txtSuffix.SelectedItem?.ToString()))
        workStatus = ReplaceSpecialCharacters(UCase(txtWorkStatus.SelectedItem?.ToString()))




        If txtEmail.Text.Contains("@gmail.com") Then
            emailFormat = txtEmail.Text
        ElseIf Not txtEmail.Text.Contains("@gmail.com") Then
            emailFormat = txtEmail.Text & "@gmail.com"
        End If



        If EmailValidation(emailFormat) Then
            'pass data
            'rfidandpinreg.instructorDataConstructor(imageBytes, firstName, middleName, surname, suffix, age,
            '                           sex, contact, jobPosition, emailFormat, workStatus,
            '                           department, birthdate.Value.ToString("MM-dd-yyyy"))
            'rfidandpinreg.Show()

            If jobPosition = "INSTRUCTOR" Then
                DBCon()

                If con.State = ConnectionState.Open Then
                    cmd.CommandText = "INSERT INTO instructor (ProfileImage, Firtname, MiddleName, Surname, Suffix, age, birthdate, Position, WorkStatus, email, Contact, Sex) VALUES (@profileimage, @fname, @mname, @surname, @suffix, @age, @bdate, @position, @workstats, @email, @contact, @sx)"


                    cmd.Parameters.Clear()
                    cmd.Connection = con

                    cmd.Parameters.Add("@profileimage", MySqlDbType.Blob).Value = imageBytes
                    cmd.Parameters.AddWithValue("@fname", firstName)
                    cmd.Parameters.AddWithValue("@mname", middleName)
                    cmd.Parameters.AddWithValue("@surname", surname)
                    cmd.Parameters.AddWithValue("@suffix", suffix)
                    cmd.Parameters.AddWithValue("@age", age)

                    cmd.Parameters.AddWithValue("@position", jobPosition)
                    cmd.Parameters.AddWithValue("@workstats", workStatus)
                    cmd.Parameters.AddWithValue("@email", emailFormat)
                    cmd.Parameters.AddWithValue("@contact", contact)
                    cmd.Parameters.AddWithValue("@sx", sex)


                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Instructor account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Me.Show()

                    con.Close()
                Else
                    MsgBox("Connection lost.")
                End If
            Else

                rfidandpinreg.Show()
            End If
        Else
            MessageBox.Show("Your email is invalid", "Invalid email", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Show()
        End If

        'clear fields
        Array.Clear(imageBytes, 0, imageBytes.Length)
        txtfirstname.Clear()
        txtMiddlename.Clear()
        txtMiddlename.Clear()
        txtSurname.Clear()
        txtSuffix.Text = ""


        txtEmail.Clear()
        txtWorkStatus.Text = ""


    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Me.Hide()
        Dashboard.Show()
    End Sub





    Private Function CheckEmptyFields() As Boolean
        Dim errorMessage As String = "Please fill in the following fields:" & vbCrLf



        If String.IsNullOrEmpty(txtfirstname.Text) Then
            errorMessage &= "- First Name" & vbCrLf
        End If

        If String.IsNullOrEmpty(txtMiddlename.Text) Then
            errorMessage &= "- Middle Name" & vbCrLf
        End If

        If String.IsNullOrEmpty(txtSurname.Text) Then
            errorMessage &= "- Surname" & vbCrLf
        End If

        If String.IsNullOrEmpty(txtSuffix.SelectedItem) Then
            errorMessage &= "- Suffix" & vbCrLf
        End If


        If String.IsNullOrEmpty(txtWorkStatus.SelectedItem) Then
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


End Class