<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblTask = New System.Windows.Forms.Label()
        Me.txtTask = New System.Windows.Forms.TextBox()
        Me.lblPriority = New System.Windows.Forms.Label()
        Me.cboPriority = New System.Windows.Forms.ComboBox()
        Me.lblDueDate = New System.Windows.Forms.Label()
        Me.dtpDueDate = New System.Windows.Forms.DateTimePicker()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lvTasks = New System.Windows.Forms.ListView()
        Me.chTask = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chPriority = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chDueDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnToggleComplete = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblStats = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(20, 15)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(190, 28)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Aplikasi To-Do List"
        '
        'lblTask
        '
        Me.lblTask.AutoSize = True
        Me.lblTask.Location = New System.Drawing.Point(22, 58)
        Me.lblTask.Name = "lblTask"
        Me.lblTask.Size = New System.Drawing.Size(85, 17)
        Me.lblTask.TabIndex = 1
        Me.lblTask.Text = "Nama Tugas"
        '
        'txtTask
        '
        Me.txtTask.Location = New System.Drawing.Point(25, 78)
        Me.txtTask.Name = "txtTask"
        Me.txtTask.Size = New System.Drawing.Size(370, 22)
        Me.txtTask.TabIndex = 2
        '
        'lblPriority
        '
        Me.lblPriority.AutoSize = True
        Me.lblPriority.Location = New System.Drawing.Point(412, 58)
        Me.lblPriority.Name = "lblPriority"
        Me.lblPriority.Size = New System.Drawing.Size(57, 17)
        Me.lblPriority.TabIndex = 3
        Me.lblPriority.Text = "Prioritas"
        '
        'cboPriority
        '
        Me.cboPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPriority.FormattingEnabled = True
        Me.cboPriority.Location = New System.Drawing.Point(415, 78)
        Me.cboPriority.Name = "cboPriority"
        Me.cboPriority.Size = New System.Drawing.Size(140, 24)
        Me.cboPriority.TabIndex = 4
        '
        'lblDueDate
        '
        Me.lblDueDate.AutoSize = True
        Me.lblDueDate.Location = New System.Drawing.Point(568, 58)
        Me.lblDueDate.Name = "lblDueDate"
        Me.lblDueDate.Size = New System.Drawing.Size(83, 17)
        Me.lblDueDate.TabIndex = 5
        Me.lblDueDate.Text = "Jatuh Tempo"
        '
        'dtpDueDate
        '
        Me.dtpDueDate.CustomFormat = "dd MMM yyyy"
        Me.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDueDate.Location = New System.Drawing.Point(571, 78)
        Me.dtpDueDate.Name = "dtpDueDate"
        Me.dtpDueDate.Size = New System.Drawing.Size(160, 22)
        Me.dtpDueDate.TabIndex = 6
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(747, 76)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 28)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "Tambah"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lvTasks
        '
        Me.lvTasks.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chTask, Me.chPriority, Me.chDueDate, Me.chStatus})
        Me.lvTasks.FullRowSelect = True
        Me.lvTasks.GridLines = True
        Me.lvTasks.HideSelection = False
        Me.lvTasks.Location = New System.Drawing.Point(25, 120)
        Me.lvTasks.MultiSelect = False
        Me.lvTasks.Name = "lvTasks"
        Me.lvTasks.Size = New System.Drawing.Size(822, 260)
        Me.lvTasks.TabIndex = 8
        Me.lvTasks.UseCompatibleStateImageBehavior = False
        Me.lvTasks.View = System.Windows.Forms.View.Details
        '
        'chTask
        '
        Me.chTask.Text = "Tugas"
        Me.chTask.Width = 350
        '
        'chPriority
        '
        Me.chPriority.Text = "Prioritas"
        Me.chPriority.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chPriority.Width = 120
        '
        'chDueDate
        '
        Me.chDueDate.Text = "Jatuh Tempo"
        Me.chDueDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chDueDate.Width = 160
        '
        'chStatus
        '
        Me.chStatus.Text = "Status"
        Me.chStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chStatus.Width = 120
        '
        'btnToggleComplete
        '
        Me.btnToggleComplete.Location = New System.Drawing.Point(25, 395)
        Me.btnToggleComplete.Name = "btnToggleComplete"
        Me.btnToggleComplete.Size = New System.Drawing.Size(150, 32)
        Me.btnToggleComplete.TabIndex = 9
        Me.btnToggleComplete.Text = "Tandai Selesai"
        Me.btnToggleComplete.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(189, 395)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(120, 32)
        Me.btnDelete.TabIndex = 10
        Me.btnDelete.Text = "Hapus"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(323, 395)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(120, 32)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "Bersihkan"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblStats
        '
        Me.lblStats.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStats.Location = New System.Drawing.Point(463, 399)
        Me.lblStats.Name = "lblStats"
        Me.lblStats.Size = New System.Drawing.Size(384, 23)
        Me.lblStats.TabIndex = 12
        Me.lblStats.Text = "Total: 0 • Selesai: 0 • Aktif: 0"
        Me.lblStats.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 449)
        Me.Controls.Add(Me.lblStats)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnToggleComplete)
        Me.Controls.Add(Me.lvTasks)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dtpDueDate)
        Me.Controls.Add(Me.lblDueDate)
        Me.Controls.Add(Me.cboPriority)
        Me.Controls.Add(Me.lblPriority)
        Me.Controls.Add(Me.txtTask)
        Me.Controls.Add(Me.lblTask)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manajemen Tugas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents lblTask As System.Windows.Forms.Label
    Friend WithEvents txtTask As System.Windows.Forms.TextBox
    Friend WithEvents lblPriority As System.Windows.Forms.Label
    Friend WithEvents cboPriority As System.Windows.Forms.ComboBox
    Friend WithEvents lblDueDate As System.Windows.Forms.Label
    Friend WithEvents dtpDueDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents lvTasks As System.Windows.Forms.ListView
    Friend WithEvents chTask As System.Windows.Forms.ColumnHeader
    Friend WithEvents chPriority As System.Windows.Forms.ColumnHeader
    Friend WithEvents chDueDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents chStatus As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnToggleComplete As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblStats As System.Windows.Forms.Label

End Class
