using System;

class Program
{
    static void Main()
    {
        TaskManager taskManager = new TaskManager();

        while (true)
        {
            ShowMenu();
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    taskManager.AddTask();
                    break;
                case "2":
                    taskManager.DisplayTasks();
                    break;
                case "3":
                    taskManager.CompleteTask();
                    break;
                case "4":
                    taskManager.DeleteTask();
                    break;
                case "5":
                    Console.WriteLine("Tạm biệt!");
                    return;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ!");
                    break;
            }

        }
    }

    static void ShowMenu()
    {
        Console.WriteLine("==== QUẢN LÝ TASK ====");
        Console.WriteLine("1/ Thêm task");
        Console.WriteLine("2/ Hiển thị nội dung task");
        Console.WriteLine("3/ Chọn task hoàn thành");
        Console.WriteLine("4/ Xoá task");
        Console.WriteLine("5/ Thoát");
        Console.Write("Chọn chức năng: ");
    }
}
