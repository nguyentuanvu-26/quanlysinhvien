Imports System.Data.SqlClient

Public Class frmStudent

    ' ► KHAI BÁO CHUNG (phải ở cấp class)
    ' (Chuỗi kết nối đã được sửa lỗi Trust Server Certificate)
    Private conn As New SqlConnection("Data Source=DESKTOP-LS6SVQ2\SQLEXPRESS01;Initial Catalog=StudentDB;Integrated Security=True;Encrypt=False")
    Public IsEdit As Boolean = False
    Public MaSVCanSua As String = ""    ' <-- Tên biến dùng chung cho update (giữ nguyên)

    Private Sub frmStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen

        If IsEdit Then
            LoadStudentToControls()     ' nếu là sửa thì nạp dữ liệu lên textbox
            txtStudentID.Enabled = False ' khóa không cho sửa StudentID khi sửa
        End If
    End Sub

    ' Nạp thông tin sinh viên khi sửa
    Private Sub LoadStudentToControls()
        If String.IsNullOrEmpty(MaSVCanSua) Then Return

        Try
            ' 🟢 SỬA LỖI TÊN BẢNG VÀ TÊN CỘT
            ' Tên bảng: SinhVien -> Students
            ' Tên cột: MaSV, TenSV, Lop, SDT, DiaChi -> StudentID, StudentName, ClassID, Phone, Address
            Using cmd As New SqlCommand("SELECT StudentID, StudentName, ClassID, Phone, Address FROM Students WHERE StudentID = @MaSV", conn)
                cmd.Parameters.AddWithValue("@MaSV", MaSVCanSua)
                conn.Open()
                Using rdr As SqlDataReader = cmd.ExecuteReader()
                    If rdr.Read() Then
                        ' 🟢 Đọc dữ liệu từ tên cột chính xác trong SQL Server
                        txtClassID.Text = rdr("ClassID").ToString()
                        txtStudentID.Text = rdr("StudentID").ToString()
                        txtStudentName.Text = rdr("StudentName").ToString()
                        txtPhone.Text = rdr("Phone").ToString()
                        txtAddress.Text = rdr("Address").ToString()
                    End If
                End Using
                conn.Close()
            End Using
        Catch ex As Exception
            If conn.State = ConnectionState.Open Then conn.Close()
            MessageBox.Show("Lỗi nạp sinh viên: " & ex.Message)
        End Try
    End Sub

    ' Nút OK: thêm hoặc cập nhật
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim classID As String = txtClassID.Text.Trim()
        Dim studentID As String = txtStudentID.Text.Trim()
        Dim studentName As String = txtStudentName.Text.Trim()
        Dim phone As String = txtPhone.Text.Trim()
        Dim address As String = txtAddress.Text.Trim()

        If classID = "" Or studentID = "" Or studentName = "" Then
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            If Not IsEdit Then
                ' Thêm mới
                ' 🟢 SỬA LỖI TÊN BẢNG VÀ TÊN CỘT TRONG INSERT
                Using cmd As New SqlCommand("INSERT INTO Students (StudentID, StudentName, ClassID, Phone, Address) VALUES (@MaSV, @TenSV, @Lop, @SDT, @DiaChi)", conn)
                    cmd.Parameters.AddWithValue("@MaSV", studentID)
                    cmd.Parameters.AddWithValue("@TenSV", studentName)
                    cmd.Parameters.AddWithValue("@Lop", classID)
                    cmd.Parameters.AddWithValue("@SDT", phone)
                    cmd.Parameters.AddWithValue("@DiaChi", address)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()
                End Using
                MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ' Cập nhật
                ' 🟢 SỬA LỖI TÊN BẢNG VÀ TÊN CỘT TRONG UPDATE
                Using cmd As New SqlCommand("UPDATE Students SET StudentName=@TenSV, ClassID=@Lop, Phone=@SDT, Address=@DiaChi WHERE StudentID=@MaSV", conn)
                    cmd.Parameters.AddWithValue("@MaSV", MaSVCanSua) ' <- dùng biến class-level
                    cmd.Parameters.AddWithValue("@TenSV", studentName)
                    cmd.Parameters.AddWithValue("@Lop", classID)
                    cmd.Parameters.AddWithValue("@SDT", phone)
                    cmd.Parameters.AddWithValue("@DiaChi", address)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()
                End Using
                MessageBox.Show("Cập nhật sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            If conn.State = ConnectionState.Open Then conn.Close()
            MessageBox.Show("Lỗi khi lưu dữ liệu: " & ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class
