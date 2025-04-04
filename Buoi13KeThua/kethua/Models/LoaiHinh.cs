

public interface ILoaiHinh// interface trong c# thường bắt đầu bằng I , quy tắc chung thôi không bắc buột
{
    double TinhDienTich();
}

public interface IMoTa
{
    string MoTaHinh();
}
// triển khai interface (implement)
public class HinhTron : ILoaiHinh,IMoTa // kế thừa từ interface
// class HinhTron sẽ phải có phương thức TinhDienTich() vì đã implement interface ILoaiHinh (đã kế thừa class interface) 
{
    public double BanKinh { get; set; }

    public HinhTron(double r) => BanKinh = r;

    // bắt buộc phải có phương thức này
    public double TinhDienTich() => Math.PI * BanKinh * BanKinh;
    public string MoTaHinh()
    {
        return $"Hình tròn có bán kính {BanKinh}";
    }
}
