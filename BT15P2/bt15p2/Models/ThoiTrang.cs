public class ThoiTrang : SanPham
{
    public double GiamGiaTheoMua { get; set; }

    // contructor
    public ThoiTrang(string ten , double giaGoc, double giamGiaTheoMua) : base(ten,giaGoc)
    {
        // TenSanPham = ten;
        // GiaGoc = giaGoc;
        GiamGiaTheoMua = giamGiaTheoMua;
        // MaSanPham = ++IdDem; // công trước khi gán
    }
    public override double TinhGiaBan()
    {
        return GiaGoc - GiaGoc * GiamGiaTheoMua / 100;
    }
    
    public override void HienThiThongTin()
    {
        // gọi lại hàm cha
        base.HienThiThongTin();
        Console.WriteLine($" Giam gia theo mua: {GiamGiaTheoMua}%");
    }
}