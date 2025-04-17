
// public class VanPhong : INhanVien
public class VanPhong : NhanVien
{
 public override void ShowInfo()
    {
        Console.WriteLine($"Nhân viên văn phòng {Ten} -  Lương {TinhLuong()}");
    }
    public void Them()
    {
        throw new NotImplementedException();
    }

    public double TinhLuong()
    {
       return 5100;
    }
}