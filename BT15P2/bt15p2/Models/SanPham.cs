public abstract class SanPham{
    public static int IdDem = 0;
    public int MaSanPham { get; set; }
    public string TenSanPham { get; set; }
    public double GiaGoc { get; set; }
    // phương thức abs
    public abstract double TinhGiaBan();// không cần viết thân hàm ở đây


    // contructor
    public SanPham(string ten, double giaGoc)
    {
        TenSanPham = ten;
        GiaGoc = giaGoc;
        MaSanPham = ++IdDem; // công trước khi gán
    }

    // vitual
    // public virtual void HienThiThongTin();
    // dùng vitual thì class cha phải viết thân hàm
    // 
    public virtual void HienThiThongTin()
    {
        // vì là void nên không cần return
        Console.Write($"Ma san pham: {MaSanPham} - Ten san pham: {TenSanPham} - Gia goc: {GiaGoc} - Giá bán: {TinhGiaBan()}");
    }


// qua class bổ sung thêm , virtual ghi đè
    //  public virtual void NhapThongTin(){
    //     Console.WriteLine("Nhap ten san pham");
    //     string tenSanPham = Console.ReadLine();
    //     Console.WriteLine("Nhap gia goc san pham");
    //     double giaGoc = double.Parse(Console.ReadLine());
    //     // còn những thuộc tính khác thì không cần nhập, qua class con bổ sung thêm

        
    //  }

}

// public interface IKhuyenMai // bản thiết kế 
// {
//     double TinhKhuyenMai();
//     string tenKhuyenMai();
//     int ThoiGianKhuyenMai();
// }


// public class SPKM: IKhuyenMai{ // dùng bản thiết kế - implement interface 
//     // tuân thủ quy tắc
//     public double phantran;

//     public string tenKhuyenMai()
//     {
        
//         return "Khuyen Mai";
//     }

//     public int ThoiGianKhuyenMai()
//     {
//         return 30;
//     }

//     double TinhKhuyenMai()
//     {
//         // thực hiện tính
//         return 0.1;
//     }

//     double IKhuyenMai.TinhKhuyenMai()
//     {
//         return TinhKhuyenMai();
//     }
// }