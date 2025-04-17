public interface INhanVien
{//  Nhận diện dev c#
    double TinhLuong();
    void Them();
    void ShowInfo();
}
// NhanVienDTO


public abstract class NhanVien // lớp trừu tượng 
// bắt buộc class phải ghi đè những phương thức nhất đinh (abstract)
// ghi đè qua từ khoá override
// giống interface không khởi tạo được 
// vì nó là class cha bình thưởng  mỗi class con chỉ 1 abstract class thôi (khác với interface)
{
    // xem như class cha khai báo bình thường

    public int Ma { get; set; }
    public string Ten { get; set; }

    // phương thức 
    // showinfor
    // bắt buộc những class con có ShowInfor tự custom theo nhu cầu
    public abstract void ShowInfo(); // không cần thân hàm ở class cha ., qua class con tự viết 
    // tính lương
    
    // đăng xuuất
    public void DangXuat(){
        Console.WriteLine("Đăng xuất");
    }
}