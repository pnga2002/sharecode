class Program
{
    static void Main()
    {


        StudentManager ql = new StudentManager();


        // menu chọn
        int chon;

        while (true)
        {
            Console.WriteLine(@"
            MENU
            1- Thêm
            2- Xoá
            3- Hiển thị
            4- Thoát");
            Console.Write("Chọn chức năng: ");
            chon = int.Parse(Console.ReadLine());
            switch (chon)
            {
                case 1:
                    ql.Add();
                    break;
                case 2:
                    ql.ShowList();
                    Console.WriteLine("Nhập vào id cần xoá: ");
                    int id = int.Parse(Console.ReadLine());
                    ql.Delete(id);
                    break;
                case 3:
                    ql.ShowList();
                    break;
                case 4:
                    Console.WriteLine("Thoát");
                    return;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
        }
    }
}