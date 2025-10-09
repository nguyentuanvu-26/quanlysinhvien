Imports System.Data.SqlClient

Public Class frmQLSV

    ' Kết nối SQL Server
    Private conn As New SqlConnection("Data Source=DESKTOP-LS6SVQ2\SQLEXPRESS01;Initial Catalog=StudentDB;Integrated Security=True;Encrypt=False")

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        LoadData()
        LoadClassList()
    End Sub

    ' =======================================================
    ' ======= TẢI DỮ LIỆU SINH VIÊN LÊN BẢNG (LoadData) =======
    ' =======================================================
    Private Sub LoadData(Optional ByVal search As String = "", Optional ByVal classFilter As String = "")
        Try
            ' 🟢 SỬA LỖI TÊN CỘT: Sử dụng tên cột chính xác trong SQL (StudentID, StudentName, ClassID,...)
            ' Chú ý: Tên bảng trong FROM đã là Students (đúng)
            Dim sql As String = "SELECT StudentID AS [Student ID], StudentName AS [Student Name], ClassID AS [Class], Phone AS [Phone], Address AS [Address] FROM Students WHERE 1=1"

            If search <> "" Then
                ' 🟢 SỬA LỖI TÊN CỘT: MaSV -> StudentID, TenSV -> StudentName
                sql &= " AND (StudentID LIKE @Search OR StudentName LIKE @Search)"
            End If
            If classFilter <> "" And classFilter <> "All" Then
                ' 🟢 SỬA LỖI TÊN CỘT: Lop -> ClassID
                sql &= " AND ClassID = @Class"
            End If

            Using cmd As New SqlCommand(sql, conn)
                If search <> "" Then cmd.Parameters.AddWithValue("@Search", "%" & search & "%")
                If classFilter <> "" And classFilter <> "All" Then cmd.Parameters.AddWithValue("@Class", classFilter)
                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()
                da.Fill(dt)
                dgvStudents.DataSource = dt
            End Using

        Catch ex As Exception
            MessageBox.Show("Lỗi tải dữ liệu: " & ex.Message)
        End Try
    End Sub

    ' =========================================================
    ' ======= NẠP DANH SÁCH LỚP VÀO COMBOBOX (LoadClassList) =======
    ' =========================================================
    Private Sub LoadClassList()
        Try
            cboClass.Items.Clear()
            cboClass.Items.Add("All")

            ' 🟢 SỬA TÊN BẢNG: Students -> Classes để lấy TẤT CẢ các lớp
            Using cmd As New SqlCommand("SELECT ClassID FROM Classes", conn)
                conn.Open()
                Using rdr As SqlDataReader = cmd.ExecuteReader()
                    While rdr.Read()
                        ' Tên cột trong bảng Classes là ClassID
                        cboClass.Items.Add(rdr("ClassID").ToString())
                    End While
                End Using
                conn.Close()
            End Using

            cboClass.SelectedIndex = 0
        Catch ex As Exception
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    ' ===================================
    ' ======= NÚT THÊM SINH VIÊN =======
    ' ===================================
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim f As New frmStudent()
        f.IsEdit = False
        If f.ShowDialog() = DialogResult.OK Then
            LoadData()
            LoadClassList() ' Có thể cần nạp lại danh sách lớp nếu có lớp mới được thêm
        End If
    End Sub

    ' ===================================
    ' ======= NÚT SỬA SINH VIÊN =======
    ' ===================================
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvStudents.SelectedRows.Count = 0 Then
            MessageBox.Show("Vui lòng chọn sinh viên để sửa!", "Thông báo")
            Return
        End If

        ' Tên Cell trong DataGridView đã được đặt alias là "Student ID"
        Dim maSV As String = dgvStudents.SelectedRows(0).Cells("Student ID").Value.ToString()
        Dim f As New frmStudent()
        f.IsEdit = True
        f.MaSVCanSua = maSV
        If f.ShowDialog() = DialogResult.OK Then
            LoadData()
            LoadClassList() ' Có thể cần nạp lại danh sách lớp nếu lớp bị sửa
        End If
    End Sub

    ' ===================================
    ' ======= NÚT XÓA SINH VIÊN =======
    ' ===================================
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvStudents.SelectedRows.Count = 0 Then
            MessageBox.Show("Vui lòng chọn sinh viên để xóa!", "Thông báo")
            Return
        End If

        Dim maSV As String = dgvStudents.SelectedRows(0).Cells("Student ID").Value.ToString()

        If MessageBox.Show("Bạn có chắc muốn xóa sinh viên " & maSV & " không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                ' 🟢 SỬA LỖI TÊN BẢNG VÀ TÊN CỘT TRONG DELETE
                ' SinhVien -> Students, MaSV -> StudentID
                Using cmd As New SqlCommand("DELETE FROM Students WHERE StudentID = @MaSV", conn)
                    cmd.Parameters.AddWithValue("@MaSV", maSV)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()
                End Using
                MessageBox.Show("Đã xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadData()
                LoadClassList() ' Nạp lại danh sách lớp sau khi xóa
            Catch ex As Exception
                If conn.State = ConnectionState.Open Then conn.Close()
                MessageBox.Show("Lỗi khi xóa: " & ex.Message)
            End Try
        End If
    End Sub

    ' ======================================
    ' ======= TÌM KIẾM & LỌC DỮ LIỆU =======
    ' ======================================
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        LoadData(txtSearch.Text.Trim(), cboClass.Text)
    End Sub

    Private Sub cboClass_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboClass.SelectedIndexChanged
        LoadData(txtSearch.Text.Trim(), cboClass.Text)
    End Sub

End Class
