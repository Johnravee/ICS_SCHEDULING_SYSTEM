Imports MySql.Data.MySqlClient

Public Class forgot
    Dim email As String
    Private Sub btnsubmitemil_Click(sender As Object, e As EventArgs) Handles btnsubmitemil.Click
        If EmailValidation(txtemail.Text) Then
            Try
                DBCon()
                cmd.Connection = con
                cmd.CommandText = "SELECT email FROM admins WHERE email = @email"
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@email", txtemail.Text)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    email = reader("email").ToString()
                    rfidscanpanel.Show()
                    emailpanel.Hide()
                    txtemail.Clear()
                    txtrfid.Focus()


                Else
                    lblemailnotif.Visible = True
                    txtemail.Clear()

                End If
                reader.Close()
            Catch ex As Exception
                lblunexerror.Visible = True
                lblemailnotif.Visible = False
            Finally
                con.Close() ' Close the connection
            End Try
        Else
            MessageBox.Show("Invalid Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtemail.Clear()
        End If
    End Sub

    Private Sub txtrfid_TextChanged(sender As Object, e As EventArgs) Handles txtrfid.TextChanged
        If txtrfid.Text.Length = 10 Then
            If IsRFIDExist(txtrfid.Text) Then
                lblrfiderror.Visible = True
                imgerror.Visible = True
                existtimer.Start()
                redirectotlogintimer.Start()
                txtrfid.Clear()
                txtrfid.Focus()

                Return
            End If


            Dim newrfid As String = EncryptData(txtrfid.Text)

            Try
                DBCon()
                cmd.Connection = con
                cmd.CommandText = "UPDATE admins SET RFID = @newrfid WHERE email = @email"
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@newrfid", newrfid)
                cmd.Parameters.AddWithValue("@email", email)

                If cmd.ExecuteNonQuery > 0 Then
                    lblsuccess.Visible = True
                    imgsuccess.Visible = True
                    redirectotlogintimer.Start()

                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End If
    End Sub


    Private Function IsRFIDExist(rfid As String) As Boolean
        Try
            Dim HashRFID As String = EncryptData(rfid)
            DBCon()
            cmd.Connection = con
            cmd.CommandText = "SELECT RFID FROM admins WHERE RFID = @rfid"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@rfid", HashRFID)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.HasRows Then

                Return True
            Else

                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False ' Return False in case of an exception
        Finally
            con.Close() ' Ensure that the connection is always closed
        End Try
    End Function

    Private Sub existtimer_Tick(sender As Object, e As EventArgs)
        imgerror.Visible = False
        imgloading.Visible = True
        lblredirect.Visible = True
        redirectotlogintimer.Start()

        existtimer.Stop()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Close()
        ScanRFIDLOGIN.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        rfidscanpanel.Hide()
        emailpanel.Show()
    End Sub

    Private Sub redirectotlogintimer_Tick(sender As Object, e As EventArgs) Handles redirectotlogintimer.Tick
        imgerror.Visible = False
        ScanRFIDLOGIN.Show()
        Me.Close()
    End Sub
End Class