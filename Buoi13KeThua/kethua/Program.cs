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


// HÔM TRƯƠC: Kế thừa , 
// class con kế thừa nhưng phương thức và thuộc tính từ class cha :
// ĐIều kiện: khai báo với từ khóa protected, public

//HÀM TẠO

#region HÀM TẠO
// hàm tạo mặc định
/*TH1:  khi class cha không có hàm tạo , hoặc hàm tạo không có tham số thì class con cũng sẽ 
không bắt buộc có hàm tạo -> dùng hàm tạo default

*/
//TH2: Khi class cha có chỉ có hàm tạo có tham số thì class con phải có hàm tạo, 
// và gọi lại contructor của class cha qua từ khoá base
// base(ten,email,sdt,matkhau):  gọi lại contructor của class cha

// TH3: Khi class cha có hàm tạo không tham số và có hàm tạo có tham số thì class con
// có thể bỏ qua hàm tạo mặc định, trình biên dịch sẽ tự gọi contructor không tham số của class cha cho con

#endregion


#region GHI ĐÈ
// Ghi đè phương thức
// HocVien hv = new HocVien();
// hv.HienThi(); // HienThi Học viên
// NguoiDung nd = hv; // kiểu là HocVIen
// nd.HienThi();// HienThi Ngươi dùng, đối NguoiDung gọi HienThi


// Console.WriteLine("-----GHI ĐÈ-----");
// hv.HienThi2();
// nd.HienThi2();
// // Dù nd trỏ đến NguoiDung nhưng vẫn gọi hienthi 
// // của học viên vì có override lại phương vitual 
// // HienThi2


// HocVien hv2 = new HocVien()
// {
//     Ten = "Nguyễn Văn A",
//     Email = "a@gmail.com",
//     SDT = "0983599954",
//     Facebook = "facebook.com/123",
// };
// hv2.ShowInfor();

// NguoiDung nd2 = hv2; // kiểu là HocVIen
// nd2.ShowInfor(); // gọi phương thức của lớp cha



#endregion


#region CHẶN KẾ THỪA
// Chặn kế thừa không cho class khác kế thừa
// chăn kế thừa lớp HocVien là chặn không cho các class khác kế thừa HocVien
// sealed class HocVien : NguoiDung{ // có đầy đủ thuộc tính và phương thức của NguoiDung
// Chặn kế thừa (không ghi đè):   chặn kế thừa/ghi đè phương thức ShowInfor của lớp HocVien
// sealed override void ShowInfor(){ // mình kế thừa từ nguoiDung nhưng : không cho con kế thừa
 // CHẶN CLASS

 // chặn phương thức : cần đi trung gian NguoiDung-> HocVIen-> HocVienMoi


#endregion


#region ĐA HÌNH

/* INTERFACE
HÌNH HỌC : quy đinh bắt buộc các thuộc tính và phương thức
- vuông : cạnh , Chu vi diện tích thể tích ....
- tròn: bán kính,  Chu vi diện tích thể tích ....
- tam giác : 3 cạnh ,  Chu vi diện tích thể tích ....
- lớp giao diện interface không có hàm tao

*/
// IHinhHoc hh = new IHinhHoc();// lỗi vì interface không có hàm tạo - contructor


// Sử dụng interface cho đối tượng
List<IHinhHoc> dsHinh = new List<IHinhHoc>();
// dsHinh có thể bất kỳ thằng nào có implements IHinhHoc
HinhTron htron = new HinhTron(){BanKinh = 5};

// thêm hinhtron vào ds
dsHinh.Add(htron);
HocVien a = new HocVien();
// dsHinh.Add(a); // thêm hocvien vào dsHinh

// thêm vài hinh khác vào ds
HinhVuong hv = new HinhVuong();
dsHinh.Add(hv);
// thêm tam giác
HinhTamGiac htg = new HinhTamGiac();
dsHinh.Add(htg);
// duyệt dsHinh
foreach (var item in dsHinh)
{

    // kiểm tra implement có Imota hay không

    // if(item is IMoTa)
    // {
    //     IMoTa hinh = (IMoTa)item; // ép kiểu thủ công
    //     hinh.MoTa(); // gọi phương thức của interface
    // }
     if(item is IMoTa itemMoTa) // nếu item có implements IMoTa thì gán item cho itemMoTa
    {
        itemMoTa.MoTa(); // gọi phương thức của interface
    }
    item.TinhChuVi(); // gọi đên phương thức của từng lớp, tương ứng là kiểu nào thì sẽ gọi của class đó
    item.TinhDienTich();
}
#endregion
