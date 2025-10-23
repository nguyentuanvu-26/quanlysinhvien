<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudent
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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblStudentName = New System.Windows.Forms.Label()
        Me.lblStudentID = New System.Windows.Forms.Label()
        Me.lblClassID = New System.Windows.Forms.Label()
        Me.txtClassID = New System.Windows.Forms.TextBox()
        Me.txtStudentID = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.txtStudentName = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(327, 361)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(96, 361)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 14
        Me.btnOK.Text = "&OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(93, 274)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(64, 16)
        Me.lblAddress.TabIndex = 3
        Me.lblAddress.Text = "Address :"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(93, 209)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(52, 16)
        Me.lblPhone.TabIndex = 4
        Me.lblPhone.Text = "Phone :"
        '
        'lblStudentName
        '
        Me.lblStudentName.AutoSize = True
        Me.lblStudentName.Location = New System.Drawing.Point(93, 143)
        Me.lblStudentName.Name = "lblStudentName"
        Me.lblStudentName.Size = New System.Drawing.Size(95, 16)
        Me.lblStudentName.TabIndex = 5
        Me.lblStudentName.Text = "Student name :"
        '
        'lblStudentID
        '
        Me.lblStudentID.AutoSize = True
        Me.lblStudentID.Location = New System.Drawing.Point(93, 88)
        Me.lblStudentID.Name = "lblStudentID"
        Me.lblStudentID.Size = New System.Drawing.Size(74, 16)
        Me.lblStudentID.TabIndex = 6
        Me.lblStudentID.Text = "Student ID :"
        '
        'lblClassID
        '
        Me.lblClassID.AutoSize = True
        Me.lblClassID.Location = New System.Drawing.Point(93, 37)
        Me.lblClassID.Name = "lblClassID"
        Me.lblClassID.Size = New System.Drawing.Size(63, 16)
        Me.lblClassID.TabIndex = 7
        Me.lblClassID.Text = "Class ID :"
        '
        'txtClassID
        '
        Me.txtClassID.Location = New System.Drawing.Point(258, 34)
        Me.txtClassID.Name = "txtClassID"
        Me.txtClassID.Size = New System.Drawing.Size(198, 22)
        Me.txtClassID.TabIndex = 15
        '
        'txtStudentID
        '
        Me.txtStudentID.Location = New System.Drawing.Point(258, 82)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.Size = New System.Drawing.Size(198, 22)
        Me.txtStudentID.TabIndex = 15
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(258, 140)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 22)
        Me.TextBox3.TabIndex = 15
        '
        'txtStudentName
        '
        Me.txtStudentName.Location = New System.Drawing.Point(258, 137)
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.Size = New System.Drawing.Size(198, 22)
        Me.txtStudentName.TabIndex = 15
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(258, 203)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(198, 22)
        Me.txtPhone.TabIndex = 15
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(258, 268)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(198, 22)
        Me.txtAddress.TabIndex = 15
        '
        'frmStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 450)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtStudentName)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.txtStudentID)
        Me.Controls.Add(Me.txtClassID)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblStudentName)
        Me.Controls.Add(Me.lblStudentID)
        Me.Controls.Add(Me.lblClassID)
        Me.Name = "frmStudent"
        Me.Text = "Student"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btnCancel As Button
    Private WithEvents btnOK As Button
    Private WithEvents lblAddress As Label
    Private WithEvents lblPhone As Label
    Private WithEvents lblStudentName As Label
    Private WithEvents lblStudentID As Label
    Private WithEvents lblClassID As Label
    Friend WithEvents txtClassID As TextBox
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents txtStudentName As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtAddress As TextBox
End Class
