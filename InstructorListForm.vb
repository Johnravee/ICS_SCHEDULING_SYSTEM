Imports MySql.Data.MySqlClient

Public Class InstructorListForm
    Dim tab As New DataTable()

    Private Sub InstructorListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_data()

    End Sub

    Private Sub Load_data()
        DBCon()
        cmd.Connection = con
        cmd.CommandText = "SELECT * FROM `instructor`"
        cmd.ExecuteNonQuery()
        dataReader.Fill(tab)

        DataGridView1.DataSource = tab

        DataGridView1.Columns("InstructorID").Visible = False
        DataGridView1.Columns("RFID").Visible = False
        DataGridView1.Columns("Position").HeaderText = "Role"

        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        con.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim searchQuery As String = TextBox1.Text.Trim()

        If Not String.IsNullOrEmpty(searchQuery) Then
            Dim filteredData As New DataTable()
            For Each column As DataColumn In tab.Columns
                filteredData.Columns.Add(column.ColumnName, column.DataType)
            Next

            For Each row As DataRow In tab.Rows
                For Each column As DataColumn In tab.Columns
                    If row(column.ColumnName).ToString().ToLower().Contains(searchQuery.ToLower()) Then
                        filteredData.Rows.Add(row.ItemArray)
                        Exit For
                    End If
                Next
            Next

            DataGridView1.DataSource = filteredData
        Else
            DataGridView1.DataSource = tab
        End If

        DataGridView1.Columns("InstructorID").Visible = False
        DataGridView1.Columns("RFID").Visible = False
        DataGridView1.Columns("Position").HeaderText = "Role"
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True
    End Sub

    Private Sub del_Click(sender As Object, e As EventArgs) Handles del.Click
        If String.IsNullOrEmpty(txtinstructorid.Text) Then
            MsgBox("Please select a row to delete.", MsgBoxStyle.Information, "Select Row")
            Return
        End If

        If MsgBox("Are You Sure You Want to Delete This Record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                con.Open()

                Dim InstructorID As Integer = txtinstructorid.Text
                Dim delCommand As New MySqlCommand("DELETE FROM `instructor` WHERE `InstructorID` = @ins", con)
                delCommand.Parameters.AddWithValue("@ins", InstructorID)
                Dim rowsAffected As Integer = delCommand.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    DataGridView1.DataSource = Nothing
                    tab.Columns.Clear()
                    tab.Rows.Clear()
                    txtemail.Clear()
                    txtFirtname.Clear()
                    txtinstructorid.Clear()
                    txtmidname.Clear()
                    cborole.SelectedIndex = -1
                    txtrfid.Clear()
                    txtsurname.Clear()
                    cbworkstatus.SelectedIndex = -1
                    cb_gender.SelectedIndex = -1
                    Load_data()
                    MessageBox.Show("Record Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    tab.Columns.Clear()
                    tab.Rows.Clear()
                    txtemail.Clear()
                    txtFirtname.Clear()
                    txtinstructorid.Clear()
                    txtmidname.Clear()
                    cborole.SelectedIndex = -1
                    txtrfid.Clear()
                    txtsurname.Clear()
                    cbworkstatus.SelectedIndex = -1
                    cb_gender.SelectedIndex = -1
                    Load_data()
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
        If String.IsNullOrEmpty(txtinstructorid.Text) Then
            MsgBox("Please select a row to update.", MsgBoxStyle.Information, "Select Row")
            Return
        End If

        Try
            If con.State = ConnectionState.Closed Then
                DBCon()
            End If

            cmd.Connection = con
            cmd.CommandText = "UPDATE instructor SET Firstname=@fn,MiddleName=@mn,Surname=@sn, Gender = @gender,Position=@pos,WorkStatus=@ws,email=@email WHERE InstructorID = @insID"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@insID", ReplaceSpecialCharacters(UCase(txtinstructorid.Text)))
            cmd.Parameters.AddWithValue("@fn", ReplaceSpecialCharacters(UCase(txtFirtname.Text)))
            cmd.Parameters.AddWithValue("@mn", ReplaceSpecialCharacters(UCase(txtmidname.Text)))
            cmd.Parameters.AddWithValue("@sn", ReplaceSpecialCharacters(UCase(txtsurname.Text)))
            cmd.Parameters.AddWithValue("@pos", ReplaceSpecialCharacters(UCase(cborole.SelectedItem)))
            cmd.Parameters.AddWithValue("@ws", ReplaceSpecialCharacters(UCase(cbworkstatus.SelectedItem)))
            cmd.Parameters.AddWithValue("@email", txtemail.Text)
            cmd.Parameters.AddWithValue("@gender", ReplaceSpecialCharacters(UCase(cb_gender.SelectedItem)))

            If cmd.ExecuteNonQuery() > 0 Then
                DataGridView1.DataSource = Nothing
                tab.Columns.Clear()
                tab.Rows.Clear()
                txtemail.Clear()
                txtFirtname.Clear()
                txtinstructorid.Clear()
                txtmidname.Clear()
                cborole.SelectedIndex = -1
                txtrfid.Clear()
                txtsurname.Clear()
                cbworkstatus.SelectedIndex = -1
                cb_gender.SelectedIndex = -1
                Load_data()
                MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                tab.Columns.Clear()
                tab.Rows.Clear()
                txtemail.Clear()
                txtFirtname.Clear()
                txtinstructorid.Clear()
                txtmidname.Clear()
                cborole.SelectedIndex = -1
                txtrfid.Clear()
                txtsurname.Clear()
                cbworkstatus.SelectedIndex = -1
                cb_gender.SelectedIndex = -1
                Load_data()
                MessageBox.Show("No record found with the provided Instructor ID.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message())
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer = e.RowIndex

        ' Check if the index is within the valid range
        If index >= 0 AndAlso index < DataGridView1.Rows.Count Then
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(index)

            ' Update text boxes with cell values
            txtinstructorid.Text = selectedRow.Cells(0).Value.ToString()
            txtrfid.Text = selectedRow.Cells(1).Value.ToString()
            txtFirtname.Text = selectedRow.Cells(2).Value.ToString()
            txtmidname.Text = selectedRow.Cells(3).Value.ToString()
            txtsurname.Text = selectedRow.Cells(4).Value.ToString()
            cb_gender.Text = selectedRow.Cells(5).Value.ToString()
            cborole.SelectedItem = selectedRow.Cells(6).Value.ToString()
            cbworkstatus.SelectedItem = selectedRow.Cells(7).Value.ToString()
            txtemail.Text = selectedRow.Cells(8).Value.ToString()

            ' Refresh the DataGridView if needed
            DataGridView1.Refresh()
        End If
    End Sub
End Class
