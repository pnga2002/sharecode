class Program
{
    private static void Main(string[] args)
    {

        //gọi function chỉ xử dụng mà không xử lý
        int res = Method.tinhTong(1, 2);
        Console.WriteLine($"Tổng là : {res}");
        // gọi function khong có return , không có tham số
        Method.sayHello();
        //gọi function không có return , có tham số
        string myName = "Phương và Tâm";
        Method.sayHelloName(myName);

        // gọi function
        Method.printDate(3,3,2026);
        Method.printDate(3,4);
        Method.printDate(6);
    }
}