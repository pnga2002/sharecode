// quản lý có các chức năng như đề yêu cầu
public class QuanLyNhanVien
{
    public List<NhanVien> ds = new List<NhanVien>();
    // public List<INhanVien> ds = new List<INhanVien>();

    public int Chon { get; set; }

    //Phương thức 
    //ADD
    // thêm nhân viên gì
    public void Add()
    {

        // Console.WriteLine("Nhập tên: ");
        // Console.WriteLine("Nhập tên: ");

        // thêm nhân viên văn phòng
        VanPhong vp = new VanPhong(){ 
            Ten ="Phú",
            Ma = 1
        };
        ds.Add(vp);
        SanXuat sx = new SanXuat(){ 
            Ten ="Huỳnh",
            Ma = 2,
            SoLuongSP = 10
        };
        ds.Add(sx);
        KinhDoanh kd = new KinhDoanh(){ 
            Ten ="Vương",
            Ma = 3,
            KPI = 101
        };
        ds.Add(kd);
    }

    // show infor
    public void Showlist(){
        foreach(var item in ds){
            item.ShowInfo();
            // item.
        }
    }
}