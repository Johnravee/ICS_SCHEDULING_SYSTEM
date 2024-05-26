﻿Imports MySql.Data.MySqlClient

Module DatabaseConnection

    Public cmd As New MySqlCommand
    Public dataReader As New MySqlDataAdapter(cmd)
    Public table As New DataTable
    Public con As New MySqlConnection("server=192.168.1.191;username=2d;password=123;database=ics_scheduling_db")


    Public Sub DBCon()
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()

            End If
        Catch ex As Exception
            MessageBox.Show("Failed to connect to database. Error: " & ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Module
