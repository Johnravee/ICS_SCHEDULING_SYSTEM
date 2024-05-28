Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Security
Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient



Module Security
    Public currentUser As String

    'Hash RFID
    Public Function EncryptData(RFID As String) As String
        Using Sha256Hash As New SHA256Managed()
            Dim bytes As Byte() = Sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(RFID))

            Dim builder As New StringBuilder()

            For Each b As Byte In bytes
                builder.Append(b.ToString("x2"))
            Next

            Return builder.ToString()
        End Using
    End Function

    'Verify inputted rfid
    Public Function VerifyRFID(RFID As String) As Boolean
        Try
            Dim HashRFID As String = EncryptData(RFID)
            DBCon()
            cmd.Connection = con
            cmd.CommandText = "SELECT RFID, CONCAT(Firstname, ' ' ,Surname) AS name FROM admins WHERE RFID = @rfid AND Position IN ('DEAN', 'BSIT PROGRAM HEAD', 'BScPE PROGRAM HEAD' )"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@rfid", HashRFID)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.HasRows Then
                reader.Read()
                currentUser = reader("name").ToString()
                con.Close()
                Return True
            Else
                currentUser = ""
                con.Close()
                Return False
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try







    End Function



    'Evaluate inputted email  email
    Public Function EmailValidation(email As String) As Boolean

        If Regex.IsMatch(email, "^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$") Then
            Return True
        Else
            Return False
        End If
    End Function


    Public Function ReplaceSpecialCharacters(text As String) As String
        Dim newText As String = Nothing
        Dim encodedInput As String = SecurityElement.Escape(text)
        newText = encodedInput
        Return newText
    End Function









End Module
