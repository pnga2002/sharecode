class LambdaFunction
{
    /*
    
    */
    //tính bình phương
    //Viết function bình thường
    static int binhPhuong(int a)
    {
        return a * a;
    }
    //lambda function
    // public static Func<int, int> binhPhuong2 => (a) => a * a;
    public static Func<int, int> binhPhuong2 = a => a * a;
    /*
    // nhận vào 1 tham số thì có thể bỏ qua ()
    Func<int ,int > : function nhận vào in và trả ra int
    (a) => a * a : tương đưởng binhPhuong(int a){ return a * a; }
    // Nhận vào 2 tham số
    //Nhiều hơn 1 lệnh return thì đặt code xử lý bên tron {... và return đáp án}
    //Tính tổng
    */
    // public static Func<int, int, int> tinhTong = (a, b) => a + b
    public static Func<int, int, int> tinhTong = (a, b) => {
        Console.WriteLine("Tổng 2 số đã cho là :");
        return a+b;
    };
    //funtion tính tổng theo cách bình thường
    static int tinhTong1(int a, int b)
    {
        Console.WriteLine("Tổng của 2 số là : ");
        return a + b;
    }

    //Không có return ??
    //Action tương ứng với hàm void - không có return
    // nhận tham số và cw 
    public static Action<string> chao = ten => Console.WriteLine($"Hello:  {ten}");
    public static Action<string> chao2 = ten => {
        Console.WriteLine($"Hello {ten}");
        Console.WriteLine("Tôi là supper dev");
    };
}