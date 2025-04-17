public class NguoiDung
{
    public string Ten;
    public string Email;
    public string SDT;
    protected string MatKhau;

    public NguoiDung()// không khác gì hàm tại mặc định vì không có tham số
    {
        Console.WriteLine("Hàm tạo NguoiDung");
    }

    // hàm tạo có tham số
    public NguoiDung(string ten, string email, string sdt, string matkhau)
    {
        this.Ten = ten;
        this.Email = email;
        this.SDT = sdt;
        this.MatKhau = matkhau;
    }
    //phương thức
    public void HienThi(){
        Console.WriteLine($"Hiển thị Người Dùng");
    }

     public virtual void HienThi2(){ // ghi đè
        Console.WriteLine($"Hiển thị Người Dùng2");
    }
    // show thông tin : tên - email - sdt
    public virtual void ShowInfor(){
        Console.WriteLine($"Tên: {Ten} - Email: {Email} - SĐT: {SDT}");
    }




    public void DangNhap()
    {
        Console.WriteLine("Đăng nhập");
    }
    public void DangXuat()
    {
        Console.WriteLine("Đăng xuất");
    }
}