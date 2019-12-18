# Quản lí thư viện

## I. setup solution

### 1. lấy solution về
đầu tiên là cài github nếu chưa có

tiếp theo thì clone repository về

### 2. test xem quá trình clone có lỗi không
mở solution lên

nhấn ctrl+shift+b để build thử xem có lỗi gì không.
nếu có thì pm tui.

### 3. tạo database test
chuột phải vô project InitDatabase rồi chọn Set as StartUp Project

xong rồi thì nhấn F5 để chạy.

đợi tới khi nó kêu "xong" thì xong.

sau đó chuột phải vào project QuanLiThuVien rồi chọn Set as StartUp Project

## II. các thư viện

### 1. DataAccess

DataAccess.Database là lớp dùng để truy cập vào cơ sở dữ liệu.

[chú thích các phương thức của lớp Database](Doc/DataAccess.md#database)
