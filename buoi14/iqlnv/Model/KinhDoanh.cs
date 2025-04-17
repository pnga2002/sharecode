
// public class KinhDoanh : INhanVien
public class KinhDoanh : NhanVien
{
    public int KPI { get; set; }

 public override void ShowInfo()
    {
        Console.WriteLine($"Nhân viên Kinh doánh {Ten} -  Lương {TinhLuong()}");
    }
    public void Them()
    {
        throw new NotImplementedException();
    }

    public double TinhLuong()
    {
        if (KPI > 100)
        {
            return 10000;
        } return 7000;
    }
}