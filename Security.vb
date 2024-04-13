Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Security



Module Security

    Public Function EncryptData(data As String) As String
        If data IsNot Nothing Then
            Dim msg As String = Nothing
            Dim encode As Byte() = New Byte(data.Length - 1) {}
            encode = Encoding.UTF8.GetBytes(data)
            msg = Convert.ToBase64String(encode)
            Return msg
        Else
            Return data
        End If
    End Function


    Public Function DecryptData(data As String) As String
        Dim decryptedtxt As String = Nothing
        Dim encodedtxt As New UTF8Encoding()
        Dim decodedtxt As Decoder = encodedtxt.GetDecoder()
        Dim byteData As Byte() = Convert.FromBase64String(data)
        Dim charCount As Integer = decodedtxt.GetCharCount(byteData, 0, byteData.Length)
        Dim decodedCharacter As Char() = New Char(charCount - 1) {}
        decodedtxt.GetChars(byteData, 0, byteData.Length, decodedCharacter, 0)
        decryptedtxt = New String(decodedCharacter)
        Return decryptedtxt
    End Function


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
