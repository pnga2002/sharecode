using System.Text.Json.Serialization;

public class NhanVien
{
    public static int IdDem = 1;
    //Thuộc tính
    public int MaNV { get; set; } // tự tăng , không cần nhập
    public string TenNV { get; set; }
    public double Luong1h { get; set; }
    public double SoGioLam { get; set; }


    //Hàm tạo  kèm theo xử lý tự động tăng Id
        [JsonConstructor]
    public NhanVien(string TenNV, double Luong1h, double SoGioLam)
    {
        MaNV = IdDem++; // iddem default =1
        this.TenNV = TenNV;
        this.Luong1h = Luong1h;
        this.SoGioLam = SoGioLam; // nếu tham số có tên giống với thuộc tính thì cần dùng từ khoa this để xác định đâu là giá trị của đối đượng NhanVienß
    }



    //phương thức

    //tính tổng lương
    public double TinhLuong()
    {
        return Luong1h * SoGioLam;
    }
    // hiện thị thong tin cá nhân
    public void ShowInfor()
    {
        Console.WriteLine($"{MaNV} - {TenNV} - Lương: {TinhLuong()}");
    }

}