

using System.Text.Json;

public class QuanLySanPham
{
    // chức năng thêm xoá sửa ... trước , lưu file làm sau
    // cần lưu thêm loại sản phẩm
    // danh sách sản phẩm 
    public List<SanPham> DanhSachSanPham = new List<SanPham>();
    public string path = "data.json"; // đường dẫn đến file json


    // contructor
    public QuanLySanPham()
    {
        // đọc file
        // nếu file không tồn tại thì không đọc
        if (File.Exists(path))
        {
            DocFile();
        }
        else
        {
            Console.WriteLine("File không tồn tại");
        }
    }
    // thêm sản phẩm
    public void ThemSanPham(int chon)
    {
        // chọn loại sản phẩm muốn thêm
        Console.WriteLine("Nhập tên sản phẩm");
        string ten = Console.ReadLine();
        Console.WriteLine("Nhập giá gốc sản phẩm");
        double giaGoc = double.Parse(Console.ReadLine());
        switch (chon)
        {
            case 1:
                // thêm sản phẩm thời trang
                Console.WriteLine("Nhập giảm giá theo mùa");
                double giamGiaTheoMua = double.Parse(Console.ReadLine());
                ThoiTrang thoiTrang = new ThoiTrang(ten, giaGoc, giamGiaTheoMua);
                DanhSachSanPham.Add(thoiTrang);
                Console.WriteLine("Thêm sản phẩm thời trang thành công");
                LuuFile();
                break;
            case 2:
                // thêm sản phẩm điện tử
                Console.WriteLine("Nhập thuế");
                double thue = double.Parse(Console.ReadLine());
                DienTu dienTu = new DienTu(ten, giaGoc, thue);
                DanhSachSanPham.Add(dienTu);
                Console.WriteLine("Thêm sản phẩm điện tử thành công");
                LuuFile();
                break;
            case 3:
                // thêm sản phẩm thực phẩm
                Console.WriteLine("Nhập phí vận chuyển");
                double phiVanChuyen = double.Parse(Console.ReadLine());
                ThucPham thucPham = new ThucPham(ten, giaGoc, phiVanChuyen);
                DanhSachSanPham.Add(thucPham);
                Console.WriteLine("Thêm sản phẩm thực phẩm thành công");
                LuuFile();
                break;
            default:
                Console.WriteLine("Lựa chọn không hợp lệ");
                break;
        }

    }

    // tính tổng doanh thu
    public double TongDoanhThu()
    {
        double tong = 0;
        // doanh thu là tổng giá bán
        foreach (SanPham item in DanhSachSanPham)
        {
            // gọi hàm tính giá bán
            tong += item.TinhGiaBan(); // lấy ra giá từng sp , cộng dồn vào tổng
        }
        return tong;
    }

    // hiển thị danh sách sản phẩm
    public void HienThiDanhSach()
    {
        Console.WriteLine("Danh sách sản phẩm");
        foreach (var item in DanhSachSanPham)
        {
            // gọi hienthi 
            item.HienThiThongTin();
        }
    }

    // xóa sản phẩm
    // nhận vào mã sản phẩm
    public void XoaSanPham(int maSP)
    {
        // tìm kiếm xem mã sp có tồn tại hay không
        SanPham find = DanhSachSanPham.Find(b => b.MaSanPham == maSP); // b duyêtj lần lượt vào từng phần tử trong danh sach để kiểm a -> có thì ra tra SanPham -> null
        // có thì xoá
        if (find != null)
        {
            DanhSachSanPham.Remove(find);
            Console.WriteLine("Xoá sản phẩm thành công");
        }
        else Console.WriteLine("Không tìm thấy sản phẩm"); // nếu không có thì không xóa được
        // nếu không có thì không xóa được
        // nếu có thì xóa
        // nếu không có thì thông báo
        // không thì thông báo
    }


    // Chọn sản phẩm
    public int ChonSanPhamCanThaoTac()
    {
        HienThiDanhSach();
        Console.WriteLine("Chọn mã sản phẩm cần xoá");
        int input = int.Parse(Console.ReadLine());
        return input;
    }


    //show menu các chức năng
    public void ShowMenu()
    {
        Console.WriteLine("Chọn chức năng");
        Console.WriteLine("1. Thêm sản phẩm");
        Console.WriteLine("2. Hiển thị danh sách sản phẩm");
        Console.WriteLine("3. Tổng doanh thu");
        Console.WriteLine("4. Xoá sản phẩm");
        Console.WriteLine("5. Thoát");
    }

    // chon loại sản phẩm
    public int ChonSP()
    {
        Console.WriteLine("Chọn loại sản phẩm");
        Console.WriteLine("1. Thời trang");
        Console.WriteLine("2. Điện tử");
        Console.WriteLine("3. Thực phẩm");
        int input = int.Parse(Console.ReadLine());
        return input;
    }


    //
    public void LuuFile()
    {
        // mapper
        // convert tay , chuyển đổi sản phẩm trong danh sách thành SanPhamData
        List<SanPhamData> sanPhamDataList = new List<SanPhamData>();
        sanPhamDataList = DanhSachSanPham.Select(sp =>
           {
               var spnew = new SanPhamData
               {
                   MaSanPham = sp.MaSanPham,
                   TenSanPham = sp.TenSanPham,
                   GiaGoc = sp.GiaGoc,
                   Loai = sp.GetType().Name // lấy tên class 
               };
               // nếu là thời trang thì thêm thuộc tính giảm giá theo mùa
               if (sp is ThoiTrang)
               {
                   spnew.GiamGiaTheoMua = ((ThoiTrang)sp).GiamGiaTheoMua;
               }
               //dientu
               else if (sp is DienTu)
               {
                   spnew.Thue = ((DienTu)sp).Thue;
               }
               //thucpham
               else if (sp is ThucPham)
               {
                   spnew.PhiVanChuyen = ((ThucPham)sp).PhiVanChuyen;
               }
               return spnew;
           }).ToList();

        // thiếu gắn thuộc tính thêm , thue, giam gia...

        // lúc này có được ds theo kiểu spdata
        var json = JsonSerializer.Serialize(sanPhamDataList, new JsonSerializerOptions { WriteIndented = true });

        // lưu vào file
        File.WriteAllText(path, json);
        Console.WriteLine("Lưu file thành công");


    }

    // đọc file
    public void DocFile()
    {
        // lấy json từ file 
        var json = File.ReadAllText(path);
        // chuyể đổi json thành list<SanphamData>
        var sanPhamDataList = JsonSerializer.Deserialize<List<SanPhamData>>(json);

        // cần chuyển sanphamdata về sanpham
        // duyệt từng phần tử trong danh sách
        foreach (var item in sanPhamDataList)
        {
            // kiểm tra loại sản phẩm
            // nếu loại =="ThoiTrang "-> 
            // nếu loại =="ThucPham "-> 
            // nếu loại =="DienTu "-> 
            switch (item.Loai)
            {
                case "ThoiTrang":
                    // chuyển đổi về sp tương ứng 

                    // thêm vào DanhSachSanPham

                    DanhSachSanPham.Add(new ThoiTrang(item.TenSanPham, item.GiaGoc, item.GiamGiaTheoMua ?? 0));
                    break;
                case "DienTu":
                    DanhSachSanPham.Add(new DienTu(item.TenSanPham, item.GiaGoc, item.Thue ?? 0));

                    break;
                case "ThucPham":
                    DanhSachSanPham.Add(new ThucPham(item.TenSanPham, item.GiaGoc, item.PhiVanChuyen ?? 0));
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
        }

    }
}


// 99
// 220 = 319


// lưu thông tin vào json

/*
 [
 
    {
        "MaSanPham": 1,
        "TenSanPham": "Thoi trang",
        "GiaGoc": 100000,
        "GiamGiaTheoMua": 10,
        "PhanLoai": "ThoiTrang" -> type của class đó
    }, -> ThoiTrang
    {
        "MaSanPham": 2,
        "TenSanPham": "Dien tu",
        "GiaGoc": 200000,
        "Thue": 5
    },  -> DienTu
    {
        "MaSanPham": 3,
        "TenSanPham": "Thuc pham",
        "GiaGoc": 300000,
        "PhiVanChuyen": 20
    } -> ThucPham


*/