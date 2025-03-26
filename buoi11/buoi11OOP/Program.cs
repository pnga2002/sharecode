class Program
{
    static void Main()
    {
        // dùng taskmanager như 1 đối tượng
        TaskManager taskManager = new TaskManager();
        //Quản lý danh sách Task
        // đối tượng Task phương thức thuộc tính
        // - Tên
        // - trạng thái 
        // thêm task
        // - show thông tin
        // Cập nhật task

        // Menu chon chức năng
        int choice = -1;
        while (choice != 4)
        {
            Console.WriteLine("1/ Thêm task");
            Console.WriteLine("2/ Hiển thị nội dung task");
            Console.WriteLine("3/ Chọn task hoàn thành");
            Console.WriteLine("4/ Thoát");
            Console.Write("Hãy chọn chức năng: ");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    // Thêm task
                    taskManager.Add();
                    break;
                case 2:
                    // Hiển thị
                    taskManager.HienThi();
                    break;
                case 3:
                    // update
                    taskManager.Update();
                    break;
                case 4:
                    Console.WriteLine("Tạm biệt");
                    break;
            }
        }


    }
  

}