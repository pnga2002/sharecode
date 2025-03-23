// bài tập về arr
using System.Runtime.Intrinsics.Arm;

class Program
{
    //Bài tập quản lí điểm của sinh viên
    // nhập vào số lượng sinh viên n
    // nhập danh sách điểm với n sinh viên
    // 1. Hiển thị danh sách điểm
    // 2. tính  trung bình của danh sách đó
    // 3. tìm điểm lớn và nhỏ nhất
    static void Main()
    {
        #region ôn tập arr
        // // yêu cầu nhập số lượng n
        // Console.Write("Nhập vào số lượng sinh viên: ");
        // int n = int.Parse(Console.ReadLine());
        // // nhập mảng điểm với số lượng phần tử là n
        // // double[] ds = new double[n]  tao arrr voi n phan tu
        // double[] dsDiem = new double[n];
        // //Nhập điểm, Duyệt vòng lặp qua mảng để gán giá trị cho từng phần tử của arr
        // // dsDiem[vi_tri] = giá trị
        // for (int i = 0; i < n; i++)
        // {
        //     // nhập điển tại sinh viên thứ i
        //     Console.Write($"Nhập điểm sinh viên thứ {i + 1} : ");
        //     // nhập vào điểm và gán cho vị trí i
        //     dsDiem[i] = double.Parse(Console.ReadLine());
        // }

        // // 1: duyêt mảng để hiển thị điểm
        // for (int i = 0; i < n; i++)
        // {
        //     Console.WriteLine($"Điểm sv{i + 1}: {dsDiem[i]}");
        // }


        // // 2: tính trung bình
        // // duyệt mảng tính tổng
        // double tong = 0;
        // foreach (double a in dsDiem)
        // {
        //     tong += a;
        // }
        // Console.WriteLine($"Điểm trung bình của danh sách này là : {tong / dsDiem.Length}");

        // //3. tìm min max
        //  Console.WriteLine($"Điểm trị lớn nhất là: {dsDiem.Max()}");
        //  Console.WriteLine($"Điểm trị nhỏ nhất là: {dsDiem.Min()}");

        //  //tự viết thêm duyệt mảng tìm ra min max
        #endregion

        #region ArrayList : 
        //List<kieu_du_lieu>  bản nâng cấp của arraylist
        //ArrayList nó không ràng buộc về kiểu dữ liệu -> nó có thể chưa tất cả các giá trị , string, double , int, float....
        //["hello",9, 8.5, ......]
        // arraylist[0] để dùng được phải chuyển đổi kiểu dự liệu
        // thêm xoá sửa như 1 cái list 


        #endregion

        #region Khi nào dùng list & array
        // List<kieu_du_lieu> : 1 danh sách có cùng kiểu dữ liệu, có khả năng mở rộng
        // array: danh sách có cùng kiểu dữ liệu có số lượng phần tưe nhất định 

        // Khi nào dùng List - array
        // Array: khi biết số lượng phần tử và không cần mở rộng danh sách
        // List : ngược lại 
        // ArrayList : không dùng nữa 
        #endregion

        #region Phần mở rộng của kiểu dữ liệu
        // int , float , double, char, ..... kiểu giá trị / kiểu nguyên thuỷ / primitive type / kiểu cơ sở
        // những kiểu này máy tính có thể hiểu được
        //KIỂU GIÁ TRỊ
        // lưu trự của kiểu dữ liệu cơ sở 
        int a = 10; // biến a lưu trữ trên ram với địa chỉ là 999 có giá trị là 10
        int b = a; // biến b sao chép a ra và lưu ở địa chỉ là 888 có giá trị là 10
        b = 5;
        Console.WriteLine($"a: {a}");
        Console.WriteLine($"b: {b}");




        //Kiểu dữ liệu tham chiếu - Reference Value
        // dictionary, list, array, class, object .....
        // các biến không được lưu trự trực tiếp
        //Khi 1 biến mới tham chiếu vào biến có sẵn thì cả 2 cùng trỏ về 1 vùng nhớ (không copy lưu vào vùng mới như kiểu cơ sở(primitive value))
        // khi thay đổi giá trị của biến mới thì biến cũ cũng bị thay đổi/ ảnh hưởng

        Dictionary<int, string> dic1 = new Dictionary<int, string>();
        dic1[1] = "hello";
        Dictionary<int, string> dic2 = dic1;
        dic2[1] = "hi";
        Console.WriteLine(dic1[1]);
        Console.WriteLine(dic2[1]);

        //tìm cách tạo ra bản sao không ảnh hưởng đến cái cũ

        Dictionary<int, string> dic3 = new Dictionary<int, string>(dic1);
        // dic3 có vùng nhớ khác vói dic1 và dic2
        dic3[1] = "Baby3";
        // dic3.Add(1,"ád");
        Console.WriteLine(dic1[1]);
        Console.WriteLine(dic2[1]);
        Console.WriteLine($"dic3[1]:  {dic3[1]}");

        #endregion


        #region Thời điểm xác định kiểu dữ liệu
        //js python 
        // 100 dòng code , tại dòng 60 bị lỗi  
        // c# , java 
        //VAR : không phải là kiểu dữ liệu , nó là từ khoá
        // khai báo không cần xác định kiểu dữ liệu
        // bắt buộc có giá trị khi khai báo;
        // được tự xác định và thời điểm compile time (biên dịch)
        var text = 3;// trong quá trình biên dịch sẽ xác định dựa vào giá trị
        var string1 = "hello";

        //OBJECT : kiểu dữ liệu
        // là giá trị tham chiếu 
        // xác định kiểu dữ liệu lúc compile-time
        // khi giá trị và int , double,.. (kiểu giá trị thì boxing sẽ xảy ra )  - giống kiểu giá trị  không tham chiếu 

        object obj1 = 5;
        object obj2 = obj1; // xảy ra boxing - không tham chiếu
        obj1 = 8;
        Console.WriteLine($"obj2: {obj2}");
        Console.WriteLine(object.ReferenceEquals(obj1, obj2));
        // khi dùng cần 
        // arraylist chứa nhiều loại
        // object để hứng giá trị tại từng phần tử của arr  vì không biết kiểu cụ thể


        //DYMANIC là kiểu dữ liệu  trong c#
        // thời điểm xác định kdl : runtime
        // trình biên dịch bỏ qua không kiểm tra tính đúng đắn của dymanic
        // nếu login -> tên người dùng : không trả , 
        //                 class user      "lỗi"       true
        // dynamic
        dynamic dynamicVariable = 123;
        dynamicVariable = "Hello, World!";
        dynamicVariable = true;
        dynamicVariable = 10.5;

        // Console.ReadLine();// dang chạy runtime 
        // thực hiện tính toá =n không cần ép kiểu -> lỗi runtime
        dynamic result = dynamicVariable * 2;
        Console.WriteLine($"Result: {result}, Type: {result.GetType()}");


        object objVa = 123;
        objVa = "Hello, World!";
        objVa = true;
        objVa = 10.5;
    
        object result2 = (double)objVa * 2;

        Console.WriteLine($"Result: {result2}, Type: {result.GetType()}");


        #endregion








    }
}