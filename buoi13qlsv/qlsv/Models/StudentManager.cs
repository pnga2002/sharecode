using System.Text.Json;

public class StudentManager
{

    // danh sách
    List<Student>? ds = new List<Student>();


    // Hàm tạo
    public StudentManager()
    {
        DocData();
    }
    // đường dẫn
    public string path = "data.json";
    // phương thức
    public void Add()
    {
        Console.Write("Nhập tên: ");
        string ten = Console.ReadLine();
        Console.Write("Điểm toán: ");
        double toan = double.Parse(Console.ReadLine());
        Console.Write("Điểm Anh: ");
        double anh = double.Parse(Console.ReadLine());
        Console.Write("Điểm Văn: ");
        double van = double.Parse(Console.ReadLine());
        ds.Add(new Student(ten, toan, van, anh));
        Console.WriteLine("Them thanh cong");
        LuuData();
    }


    public void Delete(int id)
    {
        // tìm xem có hay không
        int find = ds.FindIndex(a => a.MaSV == id); // nếu không tìm thấy trả ra -1
        if (find != -1)
        {// có tìm thấy
            ds.RemoveAt(find);
            Console.WriteLine("Xoá thành công");
            LuuData();
        }
        else
        {
            Console.WriteLine("Không tìm thấy sinh viên!");
        }
    }
    public void ShowList()
    {
        foreach (var hs in ds)
        {
            hs.ShowInfor();
        }
    }
    public void LuuData()
    {
        // chuyển ds về json
        var json = JsonSerializer.Serialize(ds, new JsonSerializerOptions { WriteIndented = true }); // đưa ds về json
        // ghi vào file
        File.WriteAllText(path, json);
        // thông báo thành công
        Console.WriteLine("Lưu thành công");
    }

    // đọc data
    public void DocData()
    {
        if (File.Exists(path))
        {
            var json = File.ReadAllText(path);
            // chuyển đổi về List student
            ds = JsonSerializer.Deserialize<List<Student>>(json);
            // tăng ID dem
            // var last = ds.LastOrDefault
            var maxId = ds.Max(a => a.MaSV);
            Student.IdDem = maxId + 1;
        }
        else
        {
            Console.WriteLine("Không tìm thấy đường dẫn file!");
        }



    }
}