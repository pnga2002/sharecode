public class DienTu : SanPham // kế thừa class abs SanPham
{

    public double Thue { get; set; }


    public DienTu(string ten, double giaGoc, double thue) : base(ten, giaGoc)
    {
        Thue = thue;
    }

    // bắt buộc phải viết lại hàm TinhGiaBan
    public override double TinhGiaBan()
    {
        return GiaGoc + GiaGoc * Thue / 100;
    }
    // không bắt buộc ghi đè phương thức virtual
    //ghi đè lại hiện thị thong tin cho đúng class DIEN TU
    public override void HienThiThongTin()
    {
        // gọi lại hàm cha
        base.HienThiThongTin(); // gọi lại hàm cha in ra những thông tin tên , giá , giá bán
        Console.WriteLine($" Thue: {Thue}%");
    }

}