public abstract class NhanVien
{
    public string Ma { get; set; }
    public string Ten { get; set; }

    public NhanVien(string ma, string ten)
    {
        Ma = ma;
        Ten = ten;
    }

    public abstract double TinhLuong(); // Bắt buộc class con phải override
}

public class NhanVienVanPhong : NhanVien
{
    public int SoNgayLam { get; set; }
    public double LuongNgay { get; set; }

    public NhanVienVanPhong(string ma, string ten, int soNgay, double luongNgay)
        : base(ma, ten)
    {
        SoNgayLam = soNgay;
        LuongNgay = luongNgay;
    }

    public override double TinhLuong() => SoNgayLam * LuongNgay;
}

