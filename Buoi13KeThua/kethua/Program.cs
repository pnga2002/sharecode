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
NguoiDung nd = new NguoiDung();// không truy xuất được những thuộc tính/ phương thức protected
// HocVIen, Mentor ,GiangVien class con /  Lớp dẫn xuất 
// Nguoidung là lớp cơ sở
HocVien hv = new HocVien();
hv.DangNhap(); // phương thức dc ké thừa từ NguoiDung - class cha
hv.NopBai(); // phương thức riêng của hocvien
// Tương tự GIANGVIEN VÀ MENTOR

// Đơn kế thừa : chỉ kế thừa từ 1 class cha
// Muốn nhiều hơn : ông nội -> cha -> con

