// IHinhHoc
// các lớp interface thường bắt đầu bằng chữ I + Tên lớp  => IHinhHoc
// INterface là bản thiết kế , mà thằng nào dùng bản thiết kế này thì phải làm theo quy tắc của 
// danh sách phương mà nhưng thằng con buộc phải có 
// 1 class có thể implements nhiều interface

public interface IHinhHoc{
// quy tắc - phương thức
    double TinhDienTich(); // khong có thân hàm
    double TinhChuVi();
    // các phương thức khác
}
public interface IMoTa{
    void MoTa();
}

// có thể hiểu giống như kế thừa nhưng bắt buộc nhận hết 
// yêu cầu hinhTron phải viết lại phương thức cho riêng nó 
//
public class HinhTron : IHinhHoc, IMoTa  // implement interface 
{

    // thuộc tính
    public double BanKinh { get; set; }
    // quy tăc của bản thiết kế - interface
    // Phương thức của interface
    public double TinhChuVi()
    {
       Console.WriteLine("Tính chu vi hình tròn");
       return 0;
    }

    public double TinhDienTich()
    {
         Console.WriteLine("Tính diện tích hình tròn");
         return 0;
    }
    public void MoTa(){
        Console.WriteLine($"Hình tròn có bán kính {BanKinh}");
    }

}
// HinhVuong

public class HinhVuong : IHinhHoc,IMoTa
{
    public void MoTa()
    {
        Console.WriteLine($"Hình vuông có 4 cạnh bằng nhau");
    }

    public double TinhChuVi()
    {
        Console.WriteLine("Tính chu vi hình vuông");
        return 0;
    }

    public double TinhDienTich()
    {
        Console.WriteLine("Tính diện tích hình vuông");
        return 0;
    }
}
public class HinhTamGiac : IHinhHoc
{
    public double TinhChuVi()
    {
        Console.WriteLine("Tính chu vi hình tam giác");
        return 0;
    }

    public double TinhDienTich()
    {
        Console.WriteLine("Tính diện tích hình tam giác");
        return 0;
    }
}