//Models để chứu tất cả các class đối tượng
using Unidecode.NET;

class Program
{
    static void Main()
    {
        // 
        FoodManager qly = new FoodManager();// dùng contructor/ hàm tạo dèault của c#
        int chon = -1;
        while (true) // while(true)
        { // chọn số 4 thì thoát
            Console.WriteLine(qly.HienThiTinhNang());
            Console.Write("Hãy chọn chức năng: ");
            chon = int.Parse(Console.ReadLine());
            switch (chon)
            {
                case 1:
                    qly.ThemMon();
                    break;
                case 2:
                    qly.HienThi();
                    break;
                case 3:
                // show danh sách để ngừoi dùng biến nên xoá món gì
                    qly.HienThi();
                    Console.Write("Chọn mã món cần xoá");
                    int i = int.Parse(Console.ReadLine());
                    qly.Xoa(i);
                    break;
                case 4:
                    Console.WriteLine("Trò chơi kết thúc!");
                    return; // chỗ này sẽ làm cho điều kiện while true ngừng laij
                default:
                    Console.WriteLine("Hãy chọn lại từ 1-> 4");
                    break;
            }
       
        }
        //  string a = "Tiếng việt có dấu nè";
        // string outtxt = a.Unidecode().ToLower();
        // Console.WriteLine(outtxt);
    }
}