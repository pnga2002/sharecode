public class Student
{
    public static int IdDem = 1;
    public int MaSV { get; set; }
    public string TenSV { get; set; }
    public double DToan { get; set; }
    public double DVan { get; set; }
    public double DAnh { get; set; }

    // HÀM TẠO
    public Student(){
        
    }
    public Student(string ten, double DToan, double van, double anh)
    {
        MaSV = IdDem++;
        TenSV = ten;
        this.DToan = DToan;// vì tham số trùng tên với thuộc tính nên cần từ khoá this để phân biệt
        DVan = van;
        DAnh = anh;
    }
    // phương thức show thông tin
    public void ShowInfor()
    {
        Console.WriteLine($"{MaSV} - {TenSV} - Điểm trung bình : {DTB()}");
    }
    // tính điểm trung bình
    public double DTB()
    {
        return (DAnh + DToan + DVan) / 3;
    }
}