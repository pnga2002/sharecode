class Program
{
    private static void Main(string[] args)
    {

        //gọi function chỉ xử dụng mà không xử lý
        // int res = Method.tinhTong(1, 2);
        // Console.WriteLine($"Tổng là : {res}");
        // // gọi function khong có return , không có tham số
        // Method.sayHello();
        // //gọi function không có return , có tham số
        // string myName = "Phương và Tâm";
        // Method.sayHelloName(myName);

        // // gọi function
        // Method.printDate(3,3,2026);
        // //gọi mà không truyền tham số thử 3 thì sẽ lấy mặc định
        // Method.printDate(3,4);
        // // gọi mà không truyền tham số thứ 2 và 3 sẽ lấy mặc định
        // Method.printDate(6);
        // Method.testContinue();
        // Method.testBreak();
        //============================================
        #region BT1
        //BÀI TẬP 1
        // gọi function
        //  gọi hàm tính điểm trung bình nhận vào 3 tham số
        // Console.Write("Nhập điểm toán: ");
        // double toan = double.Parse(Console.ReadLine());
        // Console.Write("Nhập điểm lý: ");
        // double ly = double.Parse(Console.ReadLine());
        // Console.Write("Nhập điểm hoá: ");
        // double hoa = double.Parse(Console.ReadLine());
        // // Gọi hàm 
        // double dtb = BaiTap1.tinhDTB(toan,ly,hoa);
        // //có điểm tb rồi -> lấy điểm đi kiểm tra xếp loại
        // string xeploai = BaiTap1.xepLoai(dtb);
        // Console.WriteLine(xeploai);
        #endregion
        #region BT2
        //---------BÀI 2-------------
        // Console.WriteLine("Nhập số n: ");
        // int n = int.Parse(Console.ReadLine());
        // string ds = BaiTap2.danhSachSoNguyenTo();
        // Console.WriteLine(ds);
        #endregion
        #region BT3
        // Console.WriteLine("Nhập chuỗi số nguyên: ");
        // string chuoi = Console.ReadLine();
        // string kq = BaiTap3.timSoNguyenToTrongChuoi(chuoi);
        // Console.WriteLine(kq);
        // // Console.WriteLine(BaiTap3.timSoNguyenToTrongChuoi(chuoi));
        #endregion

        #region BT4
        Console.WriteLine("Nhập vào chuỗi: ");
        string input = Console.ReadLine();
        Console.WriteLine($"cách dùng phương thức của chuỗi: {BaiTap4.LenghtOfLast(input)}");
        Console.WriteLine($"cách dùng giải thuật: {BaiTap4.LastIndexOf2(input)}");
        
        #endregion
    }
}