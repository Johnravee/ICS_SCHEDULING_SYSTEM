
Imports System.CodeDom
Imports System.Data.Common
Imports System.Linq.Expressions
Imports MySql.Data.MySqlClient
Imports Mysqlx.Cursor
Imports Mysqlx.Prepare

Public Class InstructorListForm
    Dim i As Integer
    Private Sub InstructorListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_data()

    End Sub

    Private Sub Load_data()
        Dim tab As New DataTable()
        DBCon()
        cmd.Connection = con
        cmd.CommandText = "SELECT * FROM `instructor`"
        cmd.ExecuteNonQuery()
        dataReader.Fill(tab)

        DataGridView1.DataSource = tab

        DataGridView1.Columns("InstructorID").Visible = False
        DataGridView1.Columns("RFID").Visible = False

        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        con.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim searchQuery As String = TextBox1.Text.Trim()
        If Not String.IsNullOrEmpty(searchQuery) Then
            Dim filteredData As New DataTable()
            For Each column As DataColumn In table.Columns
                filteredData.Columns.Add(column.ColumnName, column.DataType)
            Next

            For Each row As DataRow In table.Rows
                For Each column As DataColumn In table.Columns
                    If row(column.ColumnName).ToString().ToLower().Contains(searchQuery.ToLower()) Then
                        filteredData.Rows.Add(row.ItemArray)
                        Exit For
                    End If
                Next
            Next

            DataGridView1.DataSource = filteredData
        Else
            DataGridView1.DataSource = table
        End If
    End Sub
    Public Sub ExecuteQuery(query As String)

        Dim command As New MySqlCommand(query, con)
        con.Open()
        command.ExecuteReader()
        con.Close()
    End Sub

    Private Sub del_Click(sender As Object, e As EventArgs) Handles del.Click
        If MsgBox("Are You Sure You Want to Delete This Record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                con.Open()
                Dim selectedRowIndex As Integer = DataGridView1.CurrentCell.RowIndex
                Dim InstructorID As Integer = Convert.ToInt32(DataGridView1.Rows(selectedRowIndex).Cells("InstructorID").Value)
                Dim delCommand As New MySqlCommand("DELETE FROM `instructor` WHERE `InstructorID` = @ins", con)
                delCommand.Parameters.AddWithValue("@ins", InstructorID)
                Dim rowsAffected As Integer = delCommand.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    DataGridView1.DataSource = Nothing
                    Load_data()
                    MessageBox.Show("Record Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Deletion Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
            Finally
                con.Close()
            End Try

            DataGridView1.Refresh()
        End If
    End Sub

    Private Sub upd_Click(sender As Object, e As EventArgs) Handles upd.Click
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Dim updateCommand As New MySqlCommand("UPDATE `instructor` SET PIN=@pin,RFID=@rfid,Firstname=@fn,MiddleName=@mn,Surname=@sn,Suffix=@sfx,Position=@pos,WorkStatus=@ws,email=@email WHERE `InstructorID` = @ins", con)
        updateCommand.Parameters.AddWithValue("@ins", TextBox2.Text)
        updateCommand.Parameters.AddWithValue("@pin", TextBox3.Text)
        updateCommand.Parameters.AddWithValue("@rfid", TextBox4.Text)
        updateCommand.Parameters.AddWithValue("@fn", TextBox5.Text)
        updateCommand.Parameters.AddWithValue("@mn", TextBox6.Text)
        updateCommand.Parameters.AddWithValue("@sn", TextBox7.Text)
        updateCommand.Parameters.AddWithValue("@sfx", TextBox8.Text)
        updateCommand.Parameters.AddWithValue("@pos", TextBox9.Text)
        updateCommand.Parameters.AddWithValue("@ws", TextBox10.Text)
        updateCommand.Parameters.AddWithValue("@email", TextBox11.Text)

        Dim selectedRowIndex As Integer = DataGridView1.CurrentCell.RowIndex
        If selectedRowIndex >= 0 AndAlso selectedRowIndex < DataGridView1.Rows.Count Then
            DataGridView1.Rows(selectedRowIndex).Cells("InstructorID").Value = TextBox2.Text
            DataGridView1.Rows(selectedRowIndex).Cells("RFID").Value = TextBox4.Text
            DataGridView1.Rows(selectedRowIndex).Cells("Firstname").Value = TextBox5.Text
            DataGridView1.Rows(selectedRowIndex).Cells("MiddleName").Value = TextBox6.Text
            DataGridView1.Rows(selectedRowIndex).Cells("Surname").Value = TextBox7.Text
            DataGridView1.Rows(selectedRowIndex).Cells("Suffix").Value = TextBox8.Text
            DataGridView1.Rows(selectedRowIndex).Cells("Position").Value = TextBox9.Text
            DataGridView1.Rows(selectedRowIndex).Cells("WorkStatus").Value = TextBox10.Text
            DataGridView1.Rows(selectedRowIndex).Cells("email").Value = TextBox11.Text

            DataGridView1.Refresh()

        End If
        If selectedRowIndex >= 0 AndAlso selectedRowIndex < DataGridView1.Rows.Count Then
            Try
                updateCommand.ExecuteNonQuery()
                MsgBox("Update successful")
            Catch ex As Exception
                MsgBox("Error updating record: " & ex.Message)
            End Try

            DataGridView1.Refresh()
        Else
            MessageBox.Show("Please select a valid row.")
        End If

        con.Close()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer = e.RowIndex

        ' Check if the index is within the valid range
        If index >= 0 AndAlso index < DataGridView1.Rows.Count Then
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(index)

            ' Update text boxes with cell values
            TextBox2.Text = selectedRow.Cells(0).Value.ToString()
            TextBox3.Text = selectedRow.Cells(1).Value.ToString()
            TextBox4.Text = selectedRow.Cells(2).Value.ToString()
            TextBox5.Text = selectedRow.Cells(3).Value.ToString()
            TextBox6.Text = selectedRow.Cells(4).Value.ToString()
            TextBox7.Text = selectedRow.Cells(5).Value.ToString()
            TextBox8.Text = selectedRow.Cells(6).Value.ToString()
            TextBox9.Text = selectedRow.Cells(7).Value.ToString()
            TextBox10.Text = selectedRow.Cells(8).Value.ToString()

            ' Refresh the DataGridView if needed
            DataGridView1.Refresh()
        End If
    End Sub
End Class