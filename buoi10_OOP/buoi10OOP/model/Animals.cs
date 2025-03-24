using System.Drawing;

class Animals{
    // thuộc tính của animals
    public string Name;
    public string Color;
    public string Breed;
    // thuộc tính của animals
    public static int Count = 0; // không còn là thuộc tính của đối tượng nữa mà là thuộc tính của lớp

    // hàm tạo 
    // Khi có 2 hàm tạo rồi thì hàm tạo default sẽ không còn tồn tại nữa
    public Animals(){
        Name = "";
        Color = "";
        Breed = "";
    }
    // hàm tạo nhận 3 tham số string
    public Animals(string name, string color, string breed){
        Name = name;
        Color = color;
        Breed = breed;
    }
    // hàm tạo nhận 2 tham số string
    public Animals(string name, string color){
        Name = name;
        Color = color;
    }
    // hàm tạo có tham số kiểu int
    public Animals(string name, int color){
        Name = name;
        Color = color.ToString();
    }

 // 5. Hàm tiện ích - static method: không cần tạo object
    public static void ShowCompanyInfo()
    {
        Console.WriteLine($"🏢 Company: {Count}");
    }
}