Imports System.Linq

Public Class Form1

    Private Enum TodoPriority
        Rendah
        Sedang
        Tinggi
    End Enum

    Private Class TodoItem
        Public Property Judul As String
        Public Property Prioritas As TodoPriority
        Public Property JatuhTempo As Date
        Public Property Selesai As Boolean
    End Class

    Private ReadOnly _tasks As New List(Of TodoItem)

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboPriority.DataSource = [Enum].GetNames(GetType(TodoPriority))
        dtpDueDate.Value = Date.Today
        UpdateTaskList()
        UpdateActionButtons()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim judul = txtTask.Text.Trim()
        If String.IsNullOrEmpty(judul) Then
            MessageBox.Show("Masukkan nama tugas terlebih dahulu.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtTask.Focus()
            Return
        End If

        Dim prioritas = CType([Enum].Parse(GetType(TodoPriority), cboPriority.SelectedItem.ToString()), TodoPriority)
        Dim item = New TodoItem With {
            .Judul = judul,
            .Prioritas = prioritas,
            .JatuhTempo = dtpDueDate.Value.Date,
            .Selesai = False
        }

        _tasks.Add(item)
        txtTask.Clear()
        dtpDueDate.Value = Date.Today
        txtTask.Focus()
        UpdateTaskList()
    End Sub

    Private Sub btnToggleComplete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnToggleComplete.Click
        Dim task = GetSelectedTask()
        If task Is Nothing Then
            MessageBox.Show("Pilih tugas terlebih dahulu.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        task.Selesai = Not task.Selesai
        UpdateTaskList()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim task = GetSelectedTask()
        If task Is Nothing Then
            MessageBox.Show("Pilih tugas yang ingin dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        _tasks.Remove(task)
        UpdateTaskList()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        If _tasks.Count = 0 Then
            Return
        End If

        Dim result = MessageBox.Show("Bersihkan semua tugas?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            _tasks.Clear()
            UpdateTaskList()
        End If
    End Sub

    Private Sub lvTasks_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvTasks.DoubleClick
        If lvTasks.SelectedItems.Count > 0 Then
            btnToggleComplete.PerformClick()
        End If
    End Sub

    Private Sub lvTasks_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvTasks.SelectedIndexChanged
        UpdateActionButtons()
    End Sub

    Private Function GetSelectedTask() As TodoItem
        If lvTasks.SelectedItems.Count = 0 Then
            Return Nothing
        End If

        Return CType(lvTasks.SelectedItems(0).Tag, TodoItem)
    End Function

    Private Sub UpdateTaskList()
        lvTasks.BeginUpdate()
        lvTasks.Items.Clear()

        For Each task In _tasks
            Dim listItem = New ListViewItem(task.Judul)
            listItem.SubItems.Add(task.Prioritas.ToString())
            listItem.SubItems.Add(task.JatuhTempo.ToString("dd MMM yyyy"))
            listItem.SubItems.Add(If(task.Selesai, "Selesai", "Belum"))
            listItem.Tag = task

            If task.Selesai Then
                listItem.ForeColor = Color.DarkGreen
            End If

            lvTasks.Items.Add(listItem)
        Next

        lvTasks.EndUpdate()

        Dim total = _tasks.Count
        Dim selesai = _tasks.FindAll(Function(t) t.Selesai).Count
        Dim aktif = total - selesai
        lblStats.Text = String.Format("Total: {0} | Selesai: {1} | Aktif: {2}", total, selesai, aktif)

        UpdateActionButtons()
    End Sub

    Private Sub UpdateActionButtons()
        Dim hasSelection = lvTasks.SelectedItems.Count > 0
        btnToggleComplete.Enabled = hasSelection
        btnDelete.Enabled = hasSelection
        btnClear.Enabled = _tasks.Count > 0
    End Sub
End Class
