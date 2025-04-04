public class Hinh
{
    public virtual double TinhDienTich() => 0;
}

// public class HinhTron : Hinh
// {
//     public double BanKinh { get; set; }

//     public HinhTron(double r) => BanKinh = r;

//     public override double TinhDienTich() => Math.PI * BanKinh * BanKinh;
// }

// public class HinhVuong : Hinh
// {
//     public double Canh { get; set; }

//     public HinhVuong(double c) => Canh = c;

//     public override double TinhDienTich() => Canh * Canh;
// }