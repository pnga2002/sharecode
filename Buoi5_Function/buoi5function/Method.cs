class Method
{
    //format alt + shift + f/ option + shift +f
    // file chưa các funtion xử lý
    //tách hết ra đây
    public static int tinhTong(int a, int b)
    {
        int tong = a + b;
        return tong;
    }

    //function không có return, không có input
    public static void sayHello(){
        Console.WriteLine("Hello nhé!");
    }
    //function không có return, nhưng có input
    //nhận vào tham số là string name , không cần return chỉ cần thực hiện lệnh
    public static void sayHelloName(string name){
        Console.WriteLine($"Hello {name} nhé!");
    }
    //function in ra ngày tháng năm
    // khai báo giá trọ default cho tham số trường hợp không truyền
    public static void printDate(int day, int month = 3, int year = 2025){
        Console.WriteLine($"Day {day}");
        Console.WriteLine($"Month {month}");
        Console.WriteLine($"Year {year}");
    }
}