
public class Employee
{
    // Public property - ai cũng đọc/gán được
    public string Name { get; set; }

    // Chỉ cho phép đọc từ bên ngoài, gán từ trong class
    public string EmployeeId { get; private set; }

    // Chỉ class và class con mới gán được
    public string Department { get; protected set; }

    // Chỉ cho phép đọc từ trong class (hiếm dùng)
    public double Salary { private get; set; }

    // Property chỉ đọc (readonly), gán khi khởi tạo
    public DateTime CreatedAt { get; } = DateTime.Now;

    // Constructor
    public Employee(string name, string employeeId)
    {
        Name = name;
        EmployeeId = employeeId;
        Salary = 0; // có thể gán vì đang trong class
    }

    // Phương thức gán lương
    public void SetSalary(double newSalary)
    {
        if (newSalary >= 0)
            Salary = newSalary;
    }

    // Phương thức hiển thị thông tin nhân viên
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"ID: {EmployeeId}");
        Console.WriteLine($"Department: {Department}");
        Console.WriteLine($"Created: {CreatedAt}");
        Console.WriteLine($"(Private) Salary: {Salary}"); // Được vì vẫn trong class
    }
}
