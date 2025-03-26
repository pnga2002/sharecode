using System;
using System.Collections.Generic;

public class TaskManager
{
    private List<TaskItem> tasks = new List<TaskItem>();

//thêm task
    public void AddTask()
    {
        Console.Write("Nhập vào task: ");
        string title = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(title))
        {
            tasks.Add(new TaskItem(title));
            Console.WriteLine("Thêm task thành công!");
        }
        else
        {
            Console.WriteLine("Task không được để trống!");
        }
    }
// in danh sách task
    public void DisplayTasks()
    {
        Console.WriteLine("==== Danh sách task của bạn ====");

        if (tasks.Count == 0)
        {
            Console.WriteLine("Chưa có task nào!");
            return;
        }

        int index = 1;
        foreach (var task in tasks)
        {
            Console.WriteLine($"{index}/ {task}");
            index++;
        }
    }

// hoàn thành task
    public void CompleteTask()
    {
        DisplayTasks();

        Console.Write("Chọn số thứ tự task cần đánh dấu hoàn thành: ");
        if (int.TryParse(Console.ReadLine(), out int choice))
        {
            if (choice >= 1 && choice <= tasks.Count)
            {
                tasks[choice - 1].IsCompleted = true;
                Console.WriteLine("Đã đánh dấu hoàn thành!");
            }
            else
            {
                Console.WriteLine("Số không hợp lệ!");
            }
        }
        else
        {
            Console.WriteLine("Vui lòng nhập số!");
        }
    }

// xoá task 
    public void DeleteTask()
    {
        DisplayTasks();

        Console.Write("Chọn số thứ tự task cần xoá: ");
        if (int.TryParse(Console.ReadLine(), out int choice))
        {
            if (choice >= 1 && choice <= tasks.Count)
            {
                tasks.RemoveAt(choice - 1);
                Console.WriteLine("Đã xoá task thành công!");
            }
            else
            {
                Console.WriteLine("Số không hợp lệ!");
            }
        }
        else
        {
            Console.WriteLine("Vui lòng nhập số!");
        }
    }
}
