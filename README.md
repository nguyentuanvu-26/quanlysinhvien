# Quản lý Sinh viên - (Updated)

## Mục đích
Hoàn thiện project `quanlysinhvien` để nộp cho giáo viên: thêm file Form1.vb (logic chính), tập lệnh SQL để tạo bảng và dữ liệu mẫu, và hướng dẫn chạy.

## Những file mới đã thêm
- `Form1.vb` : File code logic cho Form1 (mở Form2, Form3, thoát, kiểm tra kết nối mẫu).
- `db/quanlysinhvien.sql` : Tập lệnh tạo bảng `SinhVien` và chèn dữ liệu mẫu.
- `README.md` : Hướng dẫn chạy nhanh.
- `package_quanlysinhvien_completed.zip` : bản nén cập nhật (nằm ở thư mục gốc khi tải về).

## Yêu cầu môi trường
- Visual Studio (2015/2017/2019/2022) với .NET Framework (project hiện dùng .NET Framework tương thích).
- SQL Server (Express/LocalDB) hoặc một SQL Server instance khác.
- Cập nhật connection string trong `App.config` (chuỗi connection name = `QLSVConnection`) trỏ đến database của bạn.

## Hướng dẫn nhanh để chạy (Windows)
1. Mở SQL Server Management Studio (hoặc dùng `sqlcmd`) và chạy file `db/quanlysinhvien.sql` để tạo database và bảng mẫu. File nằm trong thư mục `db/`.
2. Mở Visual Studio, chọn **Open -> Project/Solution** và chọn `QLSINHVIEN.vbproj` trong thư mục gốc.
3. Mở `App.config` và chỉnh sửa connection string `QLSVConnection` cho phù hợp (server, database, authentication).
4. Build -> Run (F5). Mở Form1 và thử mở Form2, Form3. Nếu gặp lỗi kết nối, kiểm tra lại `App.config` và SQL Server đang chạy.

## Tập lệnh SQL (tóm tắt)
File chi tiết: `db/quanlysinhvien.sql`. Nội dung chính tạo database `QLSV` (nếu cần) và bảng `SinhVien`.

## Gợi ý bổ sung (nên có để nộp đẹp hơn)
- Thêm ảnh chụp màn hình giao diện đang chạy vào báo cáo Word.
- Bổ sung xử lý lỗi và validate dữ liệu trước khi insert/update.
- Thêm file README.md chi tiết hơn về chức năng từng Form.
