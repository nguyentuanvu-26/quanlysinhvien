<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDangNhap
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblStudentName = New System.Windows.Forms.Label()
        Me.lblStudentID = New System.Windows.Forms.Label()
        Me.txtStudentName = New System.Windows.Forms.TextBox()
        Me.txtStudentID = New System.Windows.Forms.TextBox()
        Me.btnDangNhap = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(200, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(325, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Đăng nhập hệ thống"
        '
        'lblStudentName
        '
        Me.lblStudentName.AutoSize = True
        Me.lblStudentName.Location = New System.Drawing.Point(73, 114)
        Me.lblStudentName.Name = "lblStudentName"
        Me.lblStudentName.Size = New System.Drawing.Size(95, 16)
        Me.lblStudentName.TabIndex = 1
        Me.lblStudentName.Text = "Student name :"
        '
        'lblStudentID
        '
        Me.lblStudentID.AutoSize = True
        Me.lblStudentID.Location = New System.Drawing.Point(73, 222)
        Me.lblStudentID.Name = "lblStudentID"
        Me.lblStudentID.Size = New System.Drawing.Size(74, 16)
        Me.lblStudentID.TabIndex = 1
        Me.lblStudentID.Text = "Student ID :"
        '
        'txtStudentName
        '
        Me.txtStudentName.Location = New System.Drawing.Point(226, 114)
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.Size = New System.Drawing.Size(299, 22)
        Me.txtStudentName.TabIndex = 2
        '
        'txtStudentID
        '
        Me.txtStudentID.Location = New System.Drawing.Point(226, 216)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.Size = New System.Drawing.Size(299, 22)
        Me.txtStudentID.TabIndex = 2
        '
        'btnDangNhap
        '
        Me.btnDangNhap.Location = New System.Drawing.Point(76, 323)
        Me.btnDangNhap.Name = "btnDangNhap"
        Me.btnDangNhap.Size = New System.Drawing.Size(114, 37)
        Me.btnDangNhap.TabIndex = 3
        Me.btnDangNhap.Text = "Đăng nhập"
        Me.btnDangNhap.UseVisualStyleBackColor = True
        '
        'btnThoat
        '
        Me.btnThoat.Location = New System.Drawing.Point(450, 323)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(103, 37)
        Me.btnThoat.TabIndex = 3
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'frmDangNhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 450)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnDangNhap)
        Me.Controls.Add(Me.txtStudentID)
        Me.Controls.Add(Me.txtStudentName)
        Me.Controls.Add(Me.lblStudentID)
        Me.Controls.Add(Me.lblStudentName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmDangNhap"
        Me.Text = "Đăng nhập"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblStudentName As Label
    Friend WithEvents lblStudentID As Label
    Friend WithEvents txtStudentName As TextBox
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents btnDangNhap As Button
    Friend WithEvents btnThoat As Button
End Class
