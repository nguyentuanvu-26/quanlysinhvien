<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQLSV
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
        Me.lblFilter = New System.Windows.Forms.GroupBox()
        Me.cboClass = New System.Windows.Forms.ComboBox()
        Me.lblClass = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.dgvStudents = New System.Windows.Forms.DataGridView()
        Me.lblFilter.SuspendLayout()
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFilter
        '
        Me.lblFilter.Controls.Add(Me.cboClass)
        Me.lblFilter.Controls.Add(Me.lblClass)
        Me.lblFilter.ForeColor = System.Drawing.Color.Navy
        Me.lblFilter.Location = New System.Drawing.Point(862, 229)
        Me.lblFilter.Name = "lblFilter"
        Me.lblFilter.Size = New System.Drawing.Size(134, 102)
        Me.lblFilter.TabIndex = 12
        Me.lblFilter.TabStop = False
        Me.lblFilter.Text = "Filter"
        '
        'cboClass
        '
        Me.cboClass.FormattingEnabled = True
        Me.cboClass.Location = New System.Drawing.Point(7, 56)
        Me.cboClass.Name = "cboClass"
        Me.cboClass.Size = New System.Drawing.Size(121, 24)
        Me.cboClass.TabIndex = 0
        '
        'lblClass
        '
        Me.lblClass.AutoSize = True
        Me.lblClass.Location = New System.Drawing.Point(6, 37)
        Me.lblClass.Name = "lblClass"
        Me.lblClass.Size = New System.Drawing.Size(47, 16)
        Me.lblClass.TabIndex = 2
        Me.lblClass.Text = "Class :"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(110, 26)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(382, 22)
        Me.txtSearch.TabIndex = 11
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(37, 26)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(50, 16)
        Me.lblSearch.TabIndex = 10
        Me.lblSearch.Text = "Search"
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(862, 113)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(128, 23)
        Me.btnEdit.TabIndex = 6
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(862, 169)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(128, 23)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(512, 26)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 8
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(862, 60)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(128, 23)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'dgvStudents
        '
        Me.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStudents.Location = New System.Drawing.Point(40, 60)
        Me.dgvStudents.Name = "dgvStudents"
        Me.dgvStudents.RowHeadersWidth = 51
        Me.dgvStudents.RowTemplate.Height = 24
        Me.dgvStudents.Size = New System.Drawing.Size(803, 484)
        Me.dgvStudents.TabIndex = 5
        '
        'frmQLSV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1026, 596)
        Me.Controls.Add(Me.lblFilter)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dgvStudents)
        Me.Name = "frmQLSV"
        Me.Text = "QUAN LY SINH VIEN"
        Me.lblFilter.ResumeLayout(False)
        Me.lblFilter.PerformLayout()
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents lblFilter As GroupBox
    Private WithEvents cboClass As ComboBox
    Private WithEvents lblClass As Label
    Private WithEvents txtSearch As TextBox
    Private WithEvents lblSearch As Label
    Private WithEvents btnEdit As Button
    Private WithEvents btnDelete As Button
    Private WithEvents btnSearch As Button
    Private WithEvents btnAdd As Button
    Private WithEvents dgvStudents As DataGridView
End Class
