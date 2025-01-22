Public Class Form1

    ' Form Load Event: Initialize the DataGridView with columns
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Add columns to the DataGridView
        dgv.Columns.Add("Bil", "Bil") ' Column 1: Bil
        dgv.Columns.Add("Nama", "Nama") ' Column 2: Nama
        dgv.Columns.Add("NoTelefon", "No. Telefon") ' Column 3: No. Telefon

        ' Set DataGridView properties
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv.MultiSelect = False ' Allow selecting only one row at a time
        dgv.AllowUserToAddRows = False ' Disable the default empty row
    End Sub

    ' Create Button: Add a new row to the DataGridView
    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click
        ' Validate input fields
        If txtNama.Text.Trim() <> "" And txtNoTelefon.Text.Trim() <> "" Then
            ' Generate the next sequential number for "Bil"
            Dim bil As Integer = dgv.Rows.Count + 1

            ' Add the new row to the DataGridView
            dgv.Rows.Add(bil.ToString(), txtNama.Text.Trim(), txtNoTelefon.Text.Trim())

            ' Scroll to the new row
            dgv.FirstDisplayedScrollingRowIndex = dgv.RowCount - 1

            ' Clear the input fields
            ClearFields()
        Else
            MessageBox.Show("Please fill in all fields before adding a customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Read Button: Display selected row details in the input fields
    Private Sub BtnRead_Click(sender As Object, e As EventArgs) Handles BtnRead.Click
        If dgv.SelectedRows.Count > 0 Then
            Dim selectedRow = dgv.SelectedRows(0)
            txtNama.Text = selectedRow.Cells("Nama").Value.ToString()
            txtNoTelefon.Text = selectedRow.Cells("NoTelefon").Value.ToString()
        Else
            MessageBox.Show("Please select a row to read.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' Update Button: Update the selected row
    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If dgv.SelectedRows.Count > 0 Then
            Dim selectedRow = dgv.SelectedRows(0)

            ' Validate input fields
            If txtNama.Text.Trim() <> "" And txtNoTelefon.Text.Trim() <> "" Then
                selectedRow.Cells("Nama").Value = txtNama.Text.Trim()
                selectedRow.Cells("NoTelefon").Value = txtNoTelefon.Text.Trim()
                ClearFields()
                MessageBox.Show("Row updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Please fill in all fields before updating.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Please select a row to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Delete Button: Remove the selected row
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If dgv.SelectedRows.Count > 0 Then
            If MessageBox.Show("Are you sure you want to delete this row?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                dgv.Rows.Remove(dgv.SelectedRows(0))
                ClearFields()
                UpdateRowNumbers()
            End If
        Else
            MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Clear the input fields
    Private Sub ClearFields()
        txtNama.Clear()
        txtNoTelefon.Clear()
    End Sub

    ' Update the "Bil" column to maintain sequential numbering
    Private Sub UpdateRowNumbers()
        For i As Integer = 0 To dgv.Rows.Count - 1
            dgv.Rows(i).Cells("Bil").Value = (i + 1).ToString()
        Next
    End Sub

End Class
