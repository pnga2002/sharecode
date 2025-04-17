
// public class SanXuat : INhanVien
public class SanXuat : NhanVien
{
    public int SoLuongSP {get;set;}
 // override lại abstract
    public override void ShowInfo()
    {
        Console.WriteLine($"Nhân viên sản xuất {Ten} -  Lương {TinhLuong()}");
    }

    
    public void Them()
    {
        throw new NotImplementedException();
    }

    public double TinhLuong()
    {
        return 80 * SoLuongSP;

    }
}