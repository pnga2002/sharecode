// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// THUỘC TÍNH : ATTRIBUTE
// NHỮNG BIẾN CÓ GIÁ TRỊ TRONG ĐỐI TƯỢNG
/*
XE CYBERTRUCK: TÊN , THƯƠNG HIỆU, MÀU SẮC, TỐC ĐỘ, ....
//              CBT   TL             KIM      100

*/



//HÀNH VI :  BEHAVIOR 
// HÀNH ĐỘNG NÓ CÓ THỂ LÀM, CÁC FUNCTION / HÀM
/*
    SPEAK: KÊU / CÒI XE
    TĂNG TỐC: 
    DE LUI:
    ......

*/


// tự định nghĩa ra đối tượng
class Program
{
    static void Main()
    {
        // sử dụng đối tượng xe
        // List<T> 
        // List<int> a = new List<int>();

        // Car cybert = new Car();
        // cybert.Ten = "cybertruck";
        // cybert.Gia = 3.5;
        // cybert.ThuongHieu = "Tesla";
        // Console.WriteLine($"Tên xe: {cybert.Ten}");
        // Console.WriteLine($"Giá xe: {cybert.Gia}");
        // Console.WriteLine($"Thuong hiệu xe: {cybert.ThuongHieu}");

        // // cybert.Key = "123"; // không thể truy cập vì được khai báo với từ khoá private
        // cybert.KenXe();


        //KIẾN THỨC BUỔI TRƯỚC
        /*
        khái niệm về OOP và tạo được class cơ bản là Car
        tạo đối tượng từ class Car
        sử dụng thuộc tính và hành vi của đối tượng
        */


        #region  Access Modifier
        // public : mọi nơi , cho phép truy cập ở mọi nơi
        // private : Chỉ dùng được ở class của nó, không thể truy xuất từ bên ngoài
        // protected :  Chỉ dùng được ở class của nó và class con được kế thừa từ nó
        // internal: Chỉ có thể truy cập trong cùng 1 dự án
        // protected internal: Cho phép truy cập từ lớp kế thừa hoặc trong cùng assembly
        // private protected: Cho phép truy cập từ lớp kế thừa trong cùng assembly.
        // House myHouse = new House();
        // myHouse.Door = "Cái cửa";
        // // myHouse.Key = "Chìa khoá";// không truy cập được
        // myHouse.SetKey("Chìa khoá");
        // // myHouse.Money = "Tiền"; // không được
        // myHouse.ThangMay = "Thang máy";
        // myHouse.Gara = "Gara";
        // // myHouse.LoiDiBiMat = "Lối đi bí mật"; // không dùng được
        // myHouse.ShowInfor();
        // Console.WriteLine(myHouse.GetKey());
        //Gán giá trị cho những thuộc tính bị hạn chế truy cập?
        // gán giá trị cho Key -> phương thức , getter, setter 

        #endregion

        #region hàm khởi tạo - Contructor

        // Contructor là phương thức đặc biệt - để khởi  tạo đối tương của một class. Nó được gọi tự động khi khai báo dùng từ khoá new
        // ĐẶC ĐIỂM: 
        /*
        - Trùng tên với class chứa nó
        - không có giá trị tả về
        - Tự gọi khi khai báo dùng từ khoá new
        - có thể tạo nhiều contructor

        DEFAULT CONTRUCTOR: Trong C# thì nếu class không có contructor thì mặc định C# sẽ lấy default contructor 
        // CONTRUCTOR TỰ TẠO: 
        Khi trong class có contructor tự tạo thì c# nó không hộ trợ cho hàm default nữa
        Một class có thể có nhiều contructor với điều kiện phải khác nhau về tham số
        */

        // House h1 = new House(); // gọi contructor
        // h1.ShowInfor();
        // House h2 = new House("Cửa 2","Key 2"); 
        // h2.ShowInfor();
        // House h3 = new House("Cửa 3",3); 
        // h3.ShowInfor();
        #endregion

        #region  STATIC, GET, SET, ...
        //STATIC :
        /*
        Dùng để khai báo thành phần của class , khi sử dụng không cần phải instance(khai báo new)
        -  static nó không đối tượng , mà nó thuôc về Lớp - Class của đối tượng
        - thường được dùng để tạo ra biến đếnm , hàm cấu hình, hàm tiện ích
        */
        // class  DT
        House h4 = new House(); // tạo ra đối tượng từ clas House
                                // h4.Count  =0; // vì là stattic nên không dùng được như này
        int a = House.Count; // Count thuộc về House 


        //GET SET 
        VienDan d1 = new VienDan(); // 
        VienDan d2 = new VienDan(); // 
        VienDan d3 = new VienDan(); // 
        VienDan d4 = new VienDan(); // 
        VienDan d5 = new VienDan(); // 
        Console.WriteLine(d1.Ten); // get 
        // d1.Ten = "Viên đạn mới"; // không gán được vì là private set
        Console.WriteLine($"Số viên đạn : {VienDan.Count}");
        // Console.WriteLine($"Viên đạn d1 có tên là: {d1.Ten} , Chất liệu : {d1.ChatLieu} , Tình trạng : {d1.TinhTrang} , xuất xứ {VienDan.XuatXu}");
        d1.ShowInfor();
        d2.ShowInfor();
        d3.ShowInfor();
        d4.ShowInfor();
        d5.ShowInfor();
        VienDan.ShowXuatXu();
    // Static contructor 
        #endregion

    }
}