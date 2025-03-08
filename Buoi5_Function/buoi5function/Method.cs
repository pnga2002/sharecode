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
    public static void sayHello()
    {
        Console.WriteLine("Hello nhé!");
    }
    //function không có return, nhưng có input
    //nhận vào tham số là string name , không cần return chỉ cần thực hiện lệnh
    public static void sayHelloName(string name)
    {
        Console.WriteLine($"Hello {name} nhé!");
    }
    //function in ra ngày tháng năm
    // khai báo giá trọ default cho tham số trường hợp không truyền
    public static void printDate(int day, int month = 3, int year = 2025)
    {
        Console.WriteLine($"Day {day}");
        Console.WriteLine($"Month {month}");
        Console.WriteLine($"Year {year}");
    }
    // BREAK VÀ CONTINUE trong vòng lặp
    /*
    - Break: -> dừng vòng lặp;
    - continue: -> tiếp tục : ngưng xử lý cho lần lặp a nào đó và chạy tiếp với a + 1 (trường biến tăng ++)
    */
    //VÍ DỤ : in ra các số từ 1 đến 10 nhưng không in số 5
    public static void testContinue()
    {
        for (int i = 1; i <= 10; i++)
        {
            //1
            if (i == 5)
            {
                continue; // gặp continue thì bỏ qua xử lý lên dưới và tiếp tục vòng lặp với phần tử tiếp thep
            }
            Console.WriteLine(i);
            //2

        }
    }
    //BREAK : in ra các số từ 1 đến 5 -> 1 2 3 4 5
    //  khi nào chạy đến 5 thì ngừng lại;
    public static void testBreak()
    {
        for (int i = 1; i < 10; i++)
        {
            if (i > 5)
            {
                break; // khi gặp break thì ngưng và thoát khỏi vòng lặp 
            }
            Console.WriteLine(i);
        }
    }
}

/*

- Xử lý chuỗi, các phương thức xử lý chuỗi
- index và reindex của chuỗi
- foreach 
- 
Tách file, tách function tính năng ra file riêng, và sử dụng ở file Program () trong hàm main

- Function (method - hàm)
    + Hàm có tham số , không tham số ten_ham(Tham số)
    + Hàm có return và không có return
        Có return là public static int/ string ...
        không có return:  void
    + Hàm có tham số có giá trị mặc định
*/