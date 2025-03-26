class VienDan
{
    //static: hàm xử lý chung, cấu hình, ...
    // connectstring ,
    public static string XuatXu;
    public string Ten { get; private set; } = "Viên đạn";
    public string ChatLieu { get; set; }
    public string TinhTrang { get; set; }
    public static int Count = 0;
    // tự viết lại contructor để xử lý biến đến
    public VienDan()
    {
        // thao tác với thuộc tính và biến count - static
        TinhTrang = "Mới";
        ChatLieu = "Đồng";
        Count++;
    }

    //STATIC CONTRUCTOR
    // tự được gọi khi khai báo
    static VienDan()
    {
        // thao tác với các giá trị được khai báo với từ khoá static
        // Count, XuatXu
        XuatXu = "America";

    }
    // phương thức thường show infor
    public void ShowInfor(){
        Console.WriteLine($"Tên - {Ten}; Chất liệu: {ChatLieu}; Tình trạng - {TinhTrang}; Xuất xứ - {XuatXu}");
    }

    //STATIC METHOD
    public static void ShowXuatXu(){
        //thao tác với các giá trị được khai báo với từ khoá static
        Console.WriteLine($"Xuất xứ của VienDan là : {XuatXu}");
    }
}