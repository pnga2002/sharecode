// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// HOCVIEN
/*
Tên , Email, SDT, Facebook,ds lớp học
nộp bài, đánh giá, đăng nhập , đăng xuất ...
*/
//MENTOR
/*
tên, email, sdt, facebook, ds lớp mentor, thời gian có thể mentor,...
chấm điểm, điểm danh, , đăng nhập , đăng xuất...
*/

// Giảng viên
/*
tên, email, sdt, facebook, ds lớp dạy,...
upvideo, gia hạn,, đăng nhập , đăng xuất ...
*/ 

// con sẽ kế thừa những thuộc tính và phương thức của class cha
// Cha ( thuộc tính a và phương thức b)  , Con  kế thừa a và b
// NguoiDung nd = new NguoiDung();// không truy xuất được những thuộc tính/ phương thức protected
// // HocVIen, Mentor ,GiangVien class con /  Lớp dẫn xuất 
// // Nguoidung là lớp cơ sở
// HocVien hv = new HocVien();
// hv.DangNhap(); // phương thức dc ké thừa từ NguoiDung - class cha
// hv.NopBai(); // phương thức riêng của hocvien
// Tương tự GIANGVIEN VÀ MENTOR

// Đơn kế thừa : chỉ kế thừa từ 1 class cha
// Muốn nhiều hơn : ông nội -> cha -> con




// BUỔI 13
/*
- Gỉai bt, đọc ghi file
- tìm hiểu về kế thừa 
- class con kế thừa nhưng phương thức, thuộc tính của class cha 
- Với điều kiện class cha phải là public hoặc protected
- class con có thể có thêm thuộc tính, phương thức riêng

HÔM NAY : 
- CONTRUCTOR: hàm tạo của class con va class cha 
- GHI ĐÈ
- 

*/
// DA HÌNH : Là khả năng gọi cùng một method nhưng kết quả thực thi khác nhau tùy loại object thật sự.

#region GHI ĐÈ
// 
// không có vitual - không có tính đa hình
HocVien sv = new HocVien();
sv.HienThi(); // 👉 In ra "Hiển thị từ SinhVien"


NguoiDung nd = sv;
nd.HienThi(); // 👉 In ra "Hiển thị từ NguoiDung" ❗❗❗
//  Dù nd đang trỏ tới object SinhVien, nhưng kiểu biến là NguoiDung ⇒ gọi method của class cha.
// nếu như muốn nd.HienThi() gọi method của class con thì phải dùng từ khóa virtual

// ghi đè lại hàm HienThi của class cha
sv.HienThi2(); // 👉 In ra "Hiển thị từ SinhVien2"
nd.HienThi2(); // 👉 In ra "Hiển thị từ SinhVien2" ❗❗❗
#endregion

#region INTERFACE
// Interface là một bản thiết kế (contract), định nghĩa những gì một class phải có, chứ không chứa code cụ thể.
// -> Interface giống như một cái "hợp đồng" → class nào ký hợp đồng đó thì bắt buộc phải thực hiện đầy đủ các điều khoản (các method, property...).
// - Interface không thể khởi tạo đối tượng
// ILoaiHinh hinh = new ILoaiHinh(); vì bản chất nó không phải 1 thực thể
/*👉 Lỗi ngay lập tức, vì interface:

❌ Không có thân hàm

❌ Không có constructor

❌ Không có dữ liệu cụ thể

✅ Chỉ là danh sách "cam kết" của một lớp nào đó phải thực hiện.

*/

// kế thừa nhiều interface

#endregion

#region Abstract: 
// abstract dùng để tạo ra lớp hoặc method trừu tượng (chưa có thân, chỉ khai báo).
//Dùng khi muốn ép class con phải override lại.
// Không bắt buộc phải override lại hết tất cả, chỉ cần override lại những cái có abstract thôi.
//Khi muốn tạo 1 lớp cha định nghĩa sẵn “khuôn mẫu” – nhưng để class con tự định nghĩa hành vi cụ thể (như tính lương).
// NhanVien nhanv = new NhanVien("1","Nga");// không thể khởi tạo đối tượng từ lớp trừu tượng
NhanVien nv = new NhanVienVanPhong("NV01", "Nguyễn Văn A", 20, 100000);// có thể khởi tạo đối tượng từ lớp con
nv.TinhLuong(); // 👉 In ra 2000000

#endregion