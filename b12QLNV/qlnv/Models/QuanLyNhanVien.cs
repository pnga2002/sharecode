using System.Text;
using System.Text.Json;
using Unidecode.NET;

class QuanLyNhanVien
{
    // thuộc tính
    // cần có 1 danh sách để quản lý
    private List<NhanVien> ds = new List<NhanVien>();// khởi tạo list rỗng
    //[{new NhanVien(), new NhanVien(),..........}]
    private readonly string path = "data.json";
    public int Chon { get; set; }
    // Hàm tạo
    public QuanLyNhanVien()
    {
        LayData(); //
    }

    //phương thức
    // Thêm nhân viên
    public void ThemNV()
    {
        Console.Write("Nhập tên NV: ");
        string ten = Console.ReadLine();
        Console.Write("Lương làm việc 1h: ");
        double luong = double.Parse(Console.ReadLine());
        Console.Write("Số giờ làm việc: ");
        double soGio = double.Parse(Console.ReadLine());
        NhanVien emp = new NhanVien(ten, luong, soGio);
        // NhanVien emp = new NhanVien(luong,ten,soGio);
        ds.Add(emp);
        Console.WriteLine("Đã thêm thành công!");
        // gọi thằng lưu data để nó lưu thông tin vào file luôn không cần gọi riêng lẻ chức năng lưu
        LuuData();
    }


    // Tìm kiếm  nhận vào tên
    public void TimKiem(string ten)
    {

        // "   Nga   "
        // xử lý tìm kiếm không dấu
        // string a = "tiếng việt";
        // a.Unidecode();// tieng viet
        // nhã -> nha
        // Vương , Nhàn, Nhã, Nhạn, Nhân, ....
        // nv đối tượng có các thuộc tính
        var res = ds.Where(nv => nv.TenNV.Trim().Unidecode().ToLower().Contains(ten.Trim().Unidecode().ToLower()));
        // nv.TenNV.Unidecode().ToLower(): chuyển tên trong ds thành tiết việt ghi thường không dâu
        //ten.Unidecode().ToLower(): tên người dùng muốn tìm thành nt
        // Constain
        // show kết quả
        Console.WriteLine("Kết quả tìm kiếm");
        foreach (var a in res)
        {
            a.ShowInfor();
        }



    }



    // Đổi tên
    // muốn đổi tên ai , và đổi thành cái gì
    public void DoiTen(int id, string newName)
    {
        int nvFind = ds.FindIndex(a => a.MaNV == id); // vị trí đầu tiên thoả DK
        ds[nvFind].TenNV = newName; // là giá trị tham chiếu 
        Console.WriteLine("Đã đổi tên");
        LuuData();
    }



    //Xoá nhân viên
    public void XoaNV(int id)
    { // nhận tham số qua trung gian(Nhận từ FE)
        // tìm xem có nhân viên tương ứng với id này hay không
        int nvFind = ds.FindIndex(a => a.MaNV == id); // vị trí đầu tiên thoả DK
        if (nvFind != -1)
        { // có thì xoá 
            ds.RemoveAt(nvFind);
            Console.WriteLine($"Đã xoá thành công nhân viên có mã là {id}");
            LuuData();
        }
        else
        {
            Console.WriteLine($"Không tìm thấy nhân viên có mã là {id}");
        }

    }
    // Hiển thị danh sách
    public void HienThiDanhSach()
    {
        // hiển thị danh sách nhâ viên
        foreach (var nv in ds)
        {
            nv.ShowInfor();
        }
    }



    //Chon chuc năng

    public void ShowChucNang()
    {
        string lsmenu = @"
-------------Danh sách chức năng------------------
        1/ Thêm nhân viên
        2/ Tìm kiếm thông tin nhân viên dựa vào tên nhân viên (tên nhân viên không dấu)
        3/ Thay đổi tên nhân viên (khó)
        4/ Xoá nhân viên
        5/ Hiển thị danh sách thông tin nhân viên bao gồm: (mã nhân viên, tên nhân viên, lương dựa trên số giờ làm)
        6/ Thoát
        ";
        Console.WriteLine(lsmenu);
    }
    // danh sách chức năng
    // kêu người dùng chọn chức năng từ 1 đến 6 
    public void ChonChucNang()
    {
        Console.Write("Hãy chọn chức năng từ 1 -> 6: ");
        int n = int.Parse(Console.ReadLine());
        Chon = n;
    }
    // cần lưu lại list vào file json để khi start lại vẫn có dữ liệu
    // khi chạy vẫn còn data cũ 
    // phương thức lưu data
    public void LuuData()
    {
        // data.json
        // cần chuyển đổi từ list -> json
        string json = JsonSerializer.Serialize(ds, new JsonSerializerOptions { WriteIndented = true });
        // lưu vào file có tên là data.json
        File.WriteAllText(path, json);// ghi thông tin vào file
        Console.WriteLine("Lưu thành công!");
    }

    //gọi ngay khi khởi tạo quanlynhanvien
    public void LayData()
    {
        // đọc thong tin từ file
        // var json = File.ReadAllText(path);
        // ds = JsonSerializer.Deserialize<List<NhanVien>>(json);
        // // foreach (var a in ds)
        // // {
        // //     NhanVien newnv = new NhanVien(a.MaNV, a.TenNV, a.Luong1h, a.SoGioLam);
        // //     ds.Add(newnv);
        // // }
        // Console.WriteLine(json);

        // // upate lại id dem để khi thêm không bị manv
        // // lấy ra thằng cuối trong ds 
        // var lastNv = ds.LastOrDefault();// nhân viên cuối cùng trong ds
        // NhanVien.IdDem = lastNv.MaNV + 1; // mã nhân viên cuối +1

        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            ds = JsonSerializer.Deserialize<List<NhanVien>>(json);
            if (ds.Count > 0)
            {
                NhanVien.IdDem = ds.Max(a => a.MaNV) + 1;

            }
        }
    }


}