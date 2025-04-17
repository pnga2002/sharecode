public class Program{
    public static void Main(string[] args)
    {
        // khởi tạo đối tượng
        QuanLySanPham qlsp = new QuanLySanPham();
        int chon;
        do
        {
            qlsp.ShowMenu();
            chon = int.Parse(Console.ReadLine());
            switch (chon)
            {
                case 1:
                // chọn sản phẩm -> thêm sản phẩm
                    int typesp = qlsp.ChonSP();
                    qlsp.ThemSanPham(typesp);
                    break;
                case 2:
                    qlsp.HienThiDanhSach();
                    break;
                case 3:
                    Console.WriteLine("Tổng doanh thu: " + qlsp.TongDoanhThu());
                    break;
                case 4:
                    int maSP = qlsp.ChonSanPhamCanThaoTac();
                    qlsp.XoaSanPham(maSP);
                    break;
                case 5:
                    Console.WriteLine("Thoát chương trình");
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ");
                    break;
            }
        } while (chon != 5);
    }
}