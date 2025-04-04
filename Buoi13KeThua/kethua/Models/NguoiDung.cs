public class NguoiDung{
    public string Ten;
    public string Email;
    public string SDT;
    protected string MatKhau;

    // constructor
    //TH1 : Class cha có constructor mặc định (không tham số)
    public NguoiDung(){
        Console.WriteLine("Contructor NguoiDung");
    }
    // TH2: Class cha chỉ có constructor có tham số
    public NguoiDung(string ten, string email, string sdt, string matkhau){
        this.Ten = ten;
        this.Email = email;
        this.SDT = sdt;
        this.MatKhau = matkhau;
    }
    //phương thức
    public void DangNhap(){
        Console.WriteLine("Đăng nhập");
    }
    public void DangXuat(){
        Console.WriteLine("Đăng xuất");
    }
    #region GHI ĐÈ
    // không có vitual
     public void HienThi()
    {
        Console.WriteLine("Hiển thị từ NguoiDung1");
    }
    //có virtual
    public virtual void HienThi2(){
        Console.WriteLine("Hiển thị từ NguoiDung2");
    }
    #endregion

}