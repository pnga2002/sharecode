using System.Runtime.Intrinsics.Arm;

class FoodManager
{
    // Thuộc tính
    // danh sách các mons ăn
    List<Food> ds = new List<Food>();// tạo ra ds rỗng



    // phương thức

    public void ThemMon()
    {
        // xử lý thêm món ăn
        Console.Write("Nhập tên món: ");
        string ten = Console.ReadLine();
        Console.Write("\nNhập giá món: ");
        double gia = double.Parse(Console.ReadLine());
        // Food monan = new Food();// hàm tạo default ủa c#
        // monan.TenMonAn = ten;
        // monan.Gia = gia;
        Food monan = new Food(ten, gia);
        ds.Add(monan);
        Console.WriteLine("----- Đã thêm món thành công-------");
    }
    public void HienThi()
    {
        // show ds món ăn
        foreach (Food mon in ds)
        {
            // Console.WriteLine($"{mon.TenMonAn} Giá: {mon.Gia} VND");
            // lấy mon : Food tại từng vị trí trong danh sách
            mon.HienThiThongTin();
        }
    }
    // cần xoá cái gì
    // mã món // tên món
    public void Xoa(int id)
    {
        // xoá món có id tương ứng 
        // nhận vào nguyên Food monan
        // tìm 
        Food foodFind = ds.Find(a => a.MaMonAn == id); // trả null nếu không tìm thấy
        // Nếu có tìm thấy thông tin món
        if (foodFind != null)
        {
            ds.Remove(foodFind);
            Console.WriteLine("Đã xoá thành công món ăn !");
        } //nếu không tìm thấy
        else
        {
            Console.WriteLine("Không tìm thấy - 404 ");
        }
        // nhận vào index
        // int find = ds.FindIndex(a=>a.MaMonAn ==id); // nếu không thấy thì trả -1
        // kiểu tra find rồi xoá
        // remove all theo dk
        // ds.RemoveAll(a => a.MaMonAn  == id);

    }
    public string HienThiTinhNang()
    {
        string a = @"
                    --------MENU-------
                        1/ Thêm món ăn 
                        2/ Hiển thị menu
                        3/ Xoá món ăn
                        4/ Thoát ";
        return a;
    }


}