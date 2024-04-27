Imports MySql.Data.MySqlClient

Public Class ScanRFIDLOGIN
    Private Sub ScanRFIDLOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtrfidlogin.Focus()
    End Sub

    Private Sub txtrfid_TextChanged(sender As Object, e As EventArgs) Handles txtrfidlogin.TextChanged
        If txtrfidlogin.Text.Length >= 10 Then
            Dim inputedRFID = EncryptData(txtrfidlogin.Text)

            Try
                DBCon()
                cmd.Connection = con
                cmd.CommandText = "SELECT * FROM instructor WHERE RFID = @rfid"
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@rfid", inputedRfid)


                Dashboard.Show()


                    Me.Hide()





                con.Close()
            Catch ex As Exception
                MsgBox("An error occurred: " & ex.ToString())
            End Try

        End If
    End Sub


End Class