Public Class Form1

    ' Form Load Event: Initialize the DataGridView with columns
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Add columns to the DataGridView
        DataGridView1.Columns.Add("Bil", "Bil") ' Column 1: Bil
        DataGridView1.Columns.Add("Nama", "Nama") ' Column 2: Nama
        DataGridView1.Columns.Add("NoTelefon", "No. Telefon") ' Column 3: No. Telefon

        ' Set DataGridView properties
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.MultiSelect = False ' Allow selecting only one row at a time
    End Sub

    ' Create Button: Add a new row to the DataGridView
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click
        ' Check if all input fields are filled
        If txtNama.Text.Trim() <> "" And txtNoTelefon.Text.Trim() <> "" Then
            ' Get the next row number
            Dim bil As Integer = DataGridView1.Rows.Count + 1

            ' Add a new row at the bottom of the DataGridView
            DataGridView1.Rows.Add(bil.ToString(), txtNama.Text, txtNoTelefon.Text)

            ' Auto-scroll to the newly added row
            DataGridView1.FirstDisplayedScrollingRowIndex = DataGridView1.RowCount - 1

            ' Clear the input fields
            ClearFields()
        Else
            MessageBox.Show("Please fill in all fields before adding a customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Read Button: Display selected row details in the input fields
    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles BtnRead.Click
        ' Ensure a row is selected
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow = DataGridView1.SelectedRows(0) ' Get the selected row
            txtNama.Text = selectedRow.Cells("Nama").Value.ToString() ' Display Nama
            txtNoTelefon.Text = selectedRow.Cells("NoTelefon").Value.ToString() ' Display No. Telefon
        Else
            MessageBox.Show("Please select a row to read.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' Update Button: Update the selected row
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        ' Ensure a row is selected
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow = DataGridView1.SelectedRows(0) ' Get the selected row
            selectedRow.Cells("Nama").Value = txtNama.Text ' Update Nama
            selectedRow.Cells("NoTelefon").Value = txtNoTelefon.Text ' Update No. Telefon

            ' Clear the input fields
            ClearFields()
        Else
            MessageBox.Show("Please select a row to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Delete Button: Remove the selected row
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        ' Ensure a row is selected
        If DataGridView1.SelectedRows.Count > 0 Then
            DataGridView1.Rows.Remove(DataGridView1.SelectedRows(0)) ' Remove selected row

            ' Clear the input fields
            ClearFields()
        Else
            MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Clear the input fields
    Private Sub ClearFields()
        txtNama.Clear()
        txtNoTelefon.Clear()
    End Sub

End Class