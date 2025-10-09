Imports System.Data.SqlClient

Public Class frmDangNhap

    ' 🟢 1. KHAI BÁO KẾT NỐI (dùng lại chuỗi kết nối đã sửa)
    Private conn As New SqlConnection("Data Source=DESKTOP-LS6SVQ2\SQLEXPRESS01;Initial Catalog=StudentDB;Integrated Security=True;Encrypt=False")

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub btnDangNhap_Click(sender As Object, e As EventArgs) Handles btnDangNhap.Click
        Dim tenSV As String = txtStudentName.Text.Trim()
        Dim maSV As String = txtStudentID.Text.Trim()

        If tenSV = "" Or maSV = "" Then
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return ' Thoát khỏi Sub nếu thiếu thông tin
        End If

        ' 🟢 2. THỰC HIỆN XÁC THỰC VỚI CƠ SỞ DỮ LIỆU
        Try
            ' 🟢 Truy vấn bảng Students (tên bảng chính xác trong database)
            ' Kiểm tra sự tồn tại của cặp StudentID và StudentName (giả sử tên là duy nhất)
            Dim sql As String = "SELECT COUNT(*) FROM Students WHERE StudentID = @MaSV AND StudentName = @TenSV"

            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@MaSV", maSV) ' Tham số cho StudentID
                cmd.Parameters.AddWithValue("@TenSV", tenSV) ' Tham số cho StudentName

                conn.Open()

                Dim result As Integer = CInt(cmd.ExecuteScalar())

                conn.Close()

                If result > 0 Then
                    ' Đăng nhập thành công
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' 🟢 Mở Form quản lý sinh viên (frmQLSV) và ẩn form đăng nhập
                    ' Giả sử frmQLSV là Form chính mà bạn muốn hiển thị sau khi đăng nhập
                    Me.Hide()
                    Dim mainForm As New frmQLSV()
                    mainForm.Show()

                Else
                    ' Đăng nhập thất bại
                    MessageBox.Show("Mã sinh viên hoặc Tên sinh viên không đúng!", "Lỗi Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using

        Catch ex As Exception
            If conn.State = ConnectionState.Open Then conn.Close()
            MessageBox.Show("Lỗi kết nối hoặc truy vấn cơ sở dữ liệu: " & ex.Message, "Lỗi Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

End Class
