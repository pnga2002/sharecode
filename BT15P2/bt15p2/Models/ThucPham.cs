public class ThucPham : SanPham
{
    public double PhiVanChuyen { get; set; }


    // contructor
    public ThucPham(string ten,double giaGoc,double phiVanChuyen): base(ten,giaGoc)
    {
        PhiVanChuyen = phiVanChuyen;
    }

    // Phuog thức abs
    public override double TinhGiaBan()
    {
        return GiaGoc + PhiVanChuyen;
    }

    // phương thức ghi đè virtual
    public override void HienThiThongTin()
    {
        // gọi lại hàm cha
        base.HienThiThongTin();
        Console.WriteLine($" Phi van chuyen: {PhiVanChuyen} vnd");
    }
}