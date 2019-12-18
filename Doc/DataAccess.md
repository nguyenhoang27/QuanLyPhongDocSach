# DataAccess #

## Type Database

 base class for database manipulation 



---
#### Method Database.InitDatabase(System.String,System.String)

 khởi tạo thông tin database 

|Name | Description |
|-----|------|
|path: |đường dẫn tới database|
|secret: |mật khẩu|


---
#### Method Database.DropDatabase(System.String)

 xóa toàn bộ database 

|Name | Description |
|-----|------|
|secret: |mật khẩu để xóa|


---
#### Method Database.DropTable(System.String,System.String)

 xóa table 

|Name | Description |
|-----|------|
|secret: |mật khẩu để xóa|
|table: |table muôn xóa|


---
#### Method Database.GetTacGia(System.String)

 truy xuất thông tin tác giả từ database 



---
#### Method Database.GetTacGia(System.Linq.Expressions.Expression{System.Func{DataAccess.DataObject.TacGia,System.Boolean}})

 truy xuất thông tin tác giả từ database 



---
#### Method Database.GetAllTacGia

 truy xuất thông tin tác giả từ database 



---
#### Method Database.SetTacGia(DataAccess.DataObject.TacGia)

 cập nhật thông tin tác giả vào database 



---
#### Method Database.AddTacGia(DataAccess.DataObject.TacGia)

 thêm thông tin tác giả vào database 



---
#### Method Database.RemoveTacGia(System.String)

 xóa thông tin tác giả khỏi database 



---
#### Method Database.GetTheLoai(System.String)

 truy xuất thông tin thể loại từ database 



---
#### Method Database.GetTheLoai(System.Linq.Expressions.Expression{System.Func{DataAccess.DataObject.TheLoai,System.Boolean}})

 truy xuất thông tin thể loại từ database 



---
#### Method Database.GetAllTheLoai

 truy xuất thông tin thể loại từ database 



---
#### Method Database.SetTheLoai(DataAccess.DataObject.TheLoai)

 cập nhật thông tin thể loại vào database 



---
#### Method Database.AddTheLoai(DataAccess.DataObject.TheLoai)

 thêm thông tin thể loại vào database 



---
#### Method Database.RemoveTheLoai(System.String)

 xóa thông tin thể loại khỏi database 



---
#### Method Database.GetQuyDinh(System.String)

 truy xuất thông tin quy định từ database 



---
#### Method Database.GetQuyDinh(System.Linq.Expressions.Expression{System.Func{DataAccess.DataObject.QuyDinh,System.Boolean}})

 truy xuất thông tin quy định từ database 



---
#### Method Database.GetQuyDinhs(System.Linq.Expressions.Expression{System.Func{DataAccess.DataObject.QuyDinh,System.Boolean}})

 truy xuất thông tin quy định từ database dựa trên điều kiện lọc 

|Name | Description |
|-----|------|
|dieukienloc: |điều kiện lọc|


---
#### Method Database.SetQuyDinh(DataAccess.DataObject.QuyDinh)

 cập nhật thông tin quy định vào database 



---
#### Method Database.AddQuyDinh(DataAccess.DataObject.QuyDinh)

 thêm thông tin quy định vào database 



---
#### Method Database.RemoveQuyDinh(System.String)

 xóa thông tin quy định khỏi database 



---
#### Method Database.GetLoaiDocGia(System.String)

 truy xuất thông tin loại đọc giả từ database 



---
#### Method Database.GetLoaiDocGia(System.Linq.Expressions.Expression{System.Func{DataAccess.DataObject.LoaiDocGia,System.Boolean}})

 truy xuất thông tin loại đọc giả từ database 



---
#### Method Database.SetLoaiDocGia(DataAccess.DataObject.LoaiDocGia)

 cập nhật thông tin loại đọc giả vào database 



---
#### Method Database.AddLoaiDocGia(DataAccess.DataObject.LoaiDocGia)

 thêm thông tin loại đọc giả vào database 



---
#### Method Database.RemoveLoaiDocGia(System.String)

 xóa thông tin loại đọc giả khỏi database 



---
#### Method Database.GetDocGia(System.String)

 truy xuất thông tin đọc giả từ database 



---
#### Method Database.GetDocGia(System.Linq.Expressions.Expression{System.Func{DataAccess.DataObject.DocGia,System.Boolean}})

 truy xuất thông tin đọc giả từ database 



---
#### Method Database.GetDocGias(System.Linq.Expressions.Expression{System.Func{DataAccess.DataObject.DocGia,System.Boolean}})

 truy xuất thông tin đọc giả từ database 



---
#### Method Database.GetAllDocGia

 truy xuất tất cả thông tin đọc giả từ database 



---
#### Method Database.SetDocGia(DataAccess.DataObject.DocGia)

 cập nhật thông tin đọc giả vào database 



---
#### Method Database.AddDocGia(DataAccess.DataObject.DocGia)

 thêm thông tin đọc giả vào database 



---
#### Method Database.RemoveDocGia(System.String)

 xóa thông tin đọc giả khỏi database 



---
#### Method Database.GetSach(System.String)

 truy xuất thông tin sách từ database 



---
#### Method Database.GetSach(System.Linq.Expressions.Expression{System.Func{DataAccess.DataObject.Sach,System.Boolean}})

 truy xuất thông tin sách từ database 



---
#### Method Database.GetSachs(System.Linq.Expressions.Expression{System.Func{DataAccess.DataObject.Sach,System.Boolean}})

 truy xuất thông tin sách từ database 



---
#### Method Database.GetAllSach

 truy xuất tất cả thông tin sách từ database 



---
#### Method Database.SetSach(DataAccess.DataObject.Sach)

 cập nhật thông tin sách vào database 



---
#### Method Database.AddSach(DataAccess.DataObject.Sach)

 thêm thông tin sách vào database 



---
#### Method Database.RemoveSach(System.String)

 xóa thông tin sách khỏi database 



---
#### Method Database.GetPhieuThuTienPhat(System.String)

 truy xuất thông tin phiếu thu tiền phạttừ database 



---
#### Method Database.GetPhieuThuTienPhat(System.Linq.Expressions.Expression{System.Func{DataAccess.DataObject.PhieuThuTienPhat,System.Boolean}})

 truy xuất thông tin phiếu thu tiền phạttừ database 



---
#### Method Database.GetPhieuThuTienPhats(System.Linq.Expressions.Expression{System.Func{DataAccess.DataObject.PhieuThuTienPhat,System.Boolean}})

 truy xuất thông tin phiếu thu tiền phạttừ database 



---
#### Method Database.GetAllPhieuThuTienPhat

 truy xuất tất cả thông tin phiếu thu tiền phạttừ database 



---
#### Method Database.SetPhieuThuTienPhat(DataAccess.DataObject.PhieuThuTienPhat)

 cập nhật thông tin phiếu thu tiền phạtvào database 



---
#### Method Database.AddPhieuThuTienPhat(DataAccess.DataObject.PhieuThuTienPhat)

 thêm thông tin phiếu thu tiền phạtvào database 



---
#### Method Database.RemovePhieuThuTienPhat(System.String)

 xóa thông tin phiếu thu tiền phạtkhỏi database 



---
#### Method Database.GetPhieuTraSach(System.String)

 truy xuất thông tin phiếu trả sách từ database 



---
#### Method Database.GetPhieuTraSach(System.Linq.Expressions.Expression{System.Func{DataAccess.DataObject.PhieuTraSach,System.Boolean}})

 truy xuất thông tin phiếu trả sách từ database 



---
#### Method Database.GetPhieuTraSachs(System.Linq.Expressions.Expression{System.Func{DataAccess.DataObject.PhieuTraSach,System.Boolean}})

 truy xuất thông tin phiếu trả sách từ database 



---
#### Method Database.GetAllPhieuTraSach

 truy xuất tất cả thông tin phiếu trả sách từ database 



---
#### Method Database.SetPhieuTraSach(DataAccess.DataObject.PhieuTraSach)

 cập nhật thông tin phiếu trả sách vào database 



---
#### Method Database.AddPhieuTraSach(DataAccess.DataObject.PhieuTraSach)

 thêm thông tin phiếu trả sách vào database 



---
#### Method Database.RemovePhieuTraSach(System.String)

 xóa thông tin phiếu trả sách khỏi database 



---
#### Method Database.GetSachTra(System.String,System.String)

 truy xuất thông tin sách trả từ database 



---
#### Method Database.GetSachTra(System.Linq.Expressions.Expression{System.Func{DataAccess.DataObject.SachTra,System.Boolean}})

 truy xuất thông tin sách trả từ database 



---
#### Method Database.GetSachTras(System.Linq.Expressions.Expression{System.Func{DataAccess.DataObject.SachTra,System.Boolean}})

 truy xuất thông tin sách trả từ database 



---
#### Method Database.GetAllSachTra

 truy xuất tất cả thông tin sách trả từ database 



---
#### Method Database.SetSachTra(DataAccess.DataObject.SachTra)

 cập nhật thông tin sách trả vào database 



---
#### Method Database.AddSachTra(DataAccess.DataObject.SachTra)

 thêm thông tin sách trả vào database 



---
#### Method Database.RemoveSachTra(System.String,System.String)

 xóa thông tin sách trả khỏi database 



---
#### Method Database.GetThongTinMuonSach(System.String,System.String)

 truy xuất thông tin mượn sách từ database 



---
#### Method Database.GetThongTinMuonSach(System.Linq.Expressions.Expression{System.Func{DataAccess.DataObject.ThongTinMuonSach,System.Boolean}})

 truy xuất thông tin mượn sách từ database 



---
#### Method Database.GetThongTinMuonSachs(System.Linq.Expressions.Expression{System.Func{DataAccess.DataObject.ThongTinMuonSach,System.Boolean}})

 truy xuất thông tin mượn sách từ database 



---
#### Method Database.GetAllThongTinMuonSach

 truy xuất tất cả thông tin mượn sách từ database 



---
#### Method Database.SetThongTinMuonSach(DataAccess.DataObject.ThongTinMuonSach)

 cập nhật thông tin mượn sách vào database 



---
#### Method Database.AddThongTinMuonSach(DataAccess.DataObject.ThongTinMuonSach)

 thêm thông tin mượn sách vào database 



---
#### Method Database.RemoveThongTinMuonSach(System.String,System.String)

 xóa thông tin mượn sách khỏi database 



---
#### Method Database.GetBaocaoThongkeSachTraTre(System.String)

 truy xuất báo cáo thống kê sách trả trễ từ database 



---
#### Method Database.GetBaocaoThongkeSachTraTre(System.Linq.Expressions.Expression{System.Func{DataAccess.DataObject.BaocaoThongkeSachTraTre,System.Boolean}})

 truy xuất báo cáo thống kê sách trả trễ từ database 



---
#### Method Database.GetBaocaoThongkeSachTraTres(System.Linq.Expressions.Expression{System.Func{DataAccess.DataObject.BaocaoThongkeSachTraTre,System.Boolean}})

 truy xuất báo cáo thống kê sách trả trễ từ database 



---
#### Method Database.GetAllBaocaoThongkeSachTraTre

 truy xuất tất cả báo cáo thống kê sách trả trễ từ database 



---
#### Method Database.SetBaocaoThongkeSachTraTre(DataAccess.DataObject.BaocaoThongkeSachTraTre)

 cập nhật báo cáo thống kê sách trả trễ vào database 



---
#### Method Database.AddBaocaoThongkeSachTraTre(DataAccess.DataObject.BaocaoThongkeSachTraTre)

 thêm báo cáo thống kê sách trả trễ vào database 



---
#### Method Database.RemoveBaocaoThongkeSachTraTre(System.String)

 xóa báo cáo thống kê sách trả trễ khỏi database 



---
#### Method Database.GetBaocaoSachMuonTheoTheloai(System.String)

 truy xuất báo cáo thống kê sách mượn theo thể loại từ database 



---
#### Method Database.GetBaocaoSachMuonTheoTheloai(System.Linq.Expressions.Expression{System.Func{DataAccess.DataObject.BaocaoSachMuonTheoTheloai,System.Boolean}})

 truy xuất báo cáo thống kê sách mượn theo thể loại từ database 



---
#### Method Database.GetBaocaoSachMuonTheoTheloais(System.Linq.Expressions.Expression{System.Func{DataAccess.DataObject.BaocaoSachMuonTheoTheloai,System.Boolean}})

 truy xuất báo cáo thống kê sách mượn theo thể loại từ database 



---
#### Method Database.GetAllBaocaoSachMuonTheoTheloai

 truy xuất tất cả báo cáo thống kê sách mượn theo thể loại từ database 



---
#### Method Database.SetBaocaoSachMuonTheoTheloai(DataAccess.DataObject.BaocaoSachMuonTheoTheloai)

 cập nhật báo cáo thống kê sách mượn theo thể loại vào database 



---
#### Method Database.AddBaocaoSachMuonTheoTheloai(DataAccess.DataObject.BaocaoSachMuonTheoTheloai)

 thêm báo cáo thống kê sách mượn theo thể loại vào database 



---
#### Method Database.RemoveBaocaoSachMuonTheoTheloai(System.String)

 xóa báo cáo thống kê sách mượn theo thể loại khỏi database 



---
#### Method Database.GetQuyen(System.String)

 truy xuất quyền của 1 user từ database 

|Name | Description |
|-----|------|
|username: |username|


---
#### Method Database.AddQuyen(System.String,DataAccess.DataObject.Quyen)

 thêm quyền của 1 user vào đatabase 

|Name | Description |
|-----|------|
|password: |password của user|
|quyen: |thông tin user|


---
#### Method Database.LoginQuyen(System.String,System.String)

 kiểm tra thông tin đăng nhập của 1 user 

|Name | Description |
|-----|------|
|username: |username|
|password: |password|


---
## Type DataObject.PhieuThuTienPhat

 phiếu thu tiền phạt được lưu trong bảng PhieuThuTienPhat 



---
## Type DataObject.PhieuTraSach

 phiếu trả sách được lưu trong bảng PhieuTraSach 



---
## Type DataObject.Quyen

 quyen duoc luu trong quyen 



---
#### Property DataObject.Quyen.Username

 Username 



---
#### Property DataObject.Quyen.Salt

 Salt 



---
#### Property DataObject.Quyen.Hash

 Hash 



---
#### Property DataObject.Quyen.ThayDoiQuyDinh

 Quyền thay đổi quy định 



---
#### Property DataObject.Quyen.ThaoTacSach

 Quyền thao tác sách : 

 thêm sách

 cập nhật sách

 xóa sách





---
#### Property DataObject.Quyen.TimSach

 Quyền xem thông tin sách 



---
#### Property DataObject.Quyen.MuonTraSach

 Quyền thực hiện mượn và trả sách 



---
#### Property DataObject.Quyen.ThaoTacDocGia

 Quyền thao tác đọc giả : 

 lập thẻ đọc giả

 cập nhật thông tin đọc giả

 xóa thông tin đọc giả





---
#### Property DataObject.Quyen.TimDocGia

 Quyền xem thông tin đọc giả 



---
#### Property DataObject.Quyen.BaoCao

 Quyền lập và xem báo cáo 



---
## Type DataObject.Sach

 thông tin sách được lưu trong bảng Sach 



---
## Type DataObject.DocGia

 đối tượng Độc Giả được lưu trong bảng DocGia 



---
## Type DataObject.SachTra

 thông tin sách được trả được lưu trong bảng SachTra 



---
## Type DataObject.TheLoai

 thể loại được lưu trong bảng TheLoai 



---
## Type DataObject.ThongTinMuonSach

 thông tin mượn sách được lưu trong bảng TTMuonSach 



---
## Type DataObject.QuyDinh

 quy định được lưu trong bảng QuyDinh 



---
## Type DataObject.TacGia

 tác giả được lưu trong bảng TacGia 



---


