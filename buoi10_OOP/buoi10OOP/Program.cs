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
        List<int> a = new List<int>();

        Car cybert = new Car();
        cybert.Ten = "cybertruck";
        cybert.Gia = 3.5;
        cybert.ThuongHieu = "Tesla";
        Console.WriteLine($"Tên xe: {cybert.Ten}");
        Console.WriteLine($"Giá xe: {cybert.Gia}");
        Console.WriteLine($"Thuong hiệu xe: {cybert.ThuongHieu}");


        cybert.KenXe();

        // Cơ bản chúng ta đã được học về cách tạo ra 1 đối tượng với các thuộc tính và hành vi của nó
        // Đối tượng có thể là 1 đối tượng thực tế như xe, nhà, con người, động vật,....
        // Đối tượng có thể là 1 đối tượng ảo như 1 đối tượng trong game, 1 đối tượng trong phần mềm,....
        // troong dòng code Car cybert = new Car(); chúng ta đã tạo ra 1 đối tượng Car có tên là cybert
        // cybert là 1 đối tượng của lớp Car
        // cybert có các thuộc tính và hành vi của lớp Car
        #region Acess Modifier: public, private,protected, ...
        // public: có thể truy cập từ bất kỳ đâu
        // private: chỉ có thể truy cập từ bên trong lớp
        // protected: chỉ có thể truy cập từ bên trong lớp và các lớp kế thừa từ lớp đó
        // internal: chỉ có thể truy cập từ trong cùng 1 project
        // protected internal: có thể truy cập từ trong cùng 1 project và từ các lớp kế thừa từ lớp đó
        // private protected: chỉ có thể truy cập từ bên trong lớp và từ các lớp kế thừa từ lớp đó trong cùng 1 project


        House h = new House();
        Console.WriteLine(h.Door);
        // Console.WriteLine(h.Safe); // không thể truy cập vì Safe là private
        // Console.WriteLine(h.Bedroom); // không thể truy cập vì Bedroom là protected
        Console.WriteLine(h.Garden);
        Console.WriteLine(h.Garage);
        // Console.WriteLine(h.SecretPassage); // không thể truy cập vì SecretPassage là private protected
        h.ShowHouse();
        // truy cập vào getSafe từ bên ngoài lớp House
        Console.WriteLine(h.GetSafe());
        // gán lại cho Hourse h giá trị mới 
        h.Door = "Cửa chính mới";
        // h.Safe = "Két sắt mới"; // không thể truy cập vì Safe là private
        h.SetSafe("Két sắt mới");
        // h.Bedroom = "Phòng ngủ mới"; // không thể truy cập vì Bedroom là protected
        h.SetBedroom("Phòng ngủ mới");
        h.Garden = "Vườn mới";
        h.Garage = "Gara mới";
        // h.SecretPassage = "Lối đi bí mật mới"; // không thể truy cập vì SecretPassage là private protected
        h.SetBedroom("Lối đi bí mật mới");
        h.ShowHouse();

        // để update giá trị của được bảo mật thì chúng ta cần phải viết 1 function set để gán giá trị mới cho nó

        #endregion



        #region  Contructor
        /*
        Constructor là phương thức đặc biệt dùng để khởi tạo đối tượng của một class. Nó được gọi tự động khi bạn dùng new để tạo một object.
        ✅ Khi một class không khai báo constructor, thì sao?
        - Khi một class không khai báo constructor, thì C# sẽ tự động tạo ra một constructor mặc định (default constructor) không có tham số.
        - Default constructor sẽ khởi tạo giá trị mặc định cho các thuộc tính của class.
        Hourse h = new Hourse(); c# tự tạo ra 1 constructor mặc định không có tham số
        Khi chúng ta khởi tạo 1 đối tượng từ lớp Hourse thì constructor của lớp Hourse sẽ được gọi
        Constructor không có kiểu trả về.
        */
        Animals a1 = new Animals("Dog", "Black", "Husky");
        Animals a2 = new Animals("Cat", "White");
        Animals a3 = new Animals("Bird", 2);
       Console.WriteLine(a3.Name);
       Console.WriteLine(a3.Breed);
       Console.WriteLine(a3.Color);
        int aa =  Animals.Count; // đếm xử 
        #endregion

        #region class member: STATIC, GET, SET, ...
        //STATIC
        /*
        🧠 Ý nghĩa:
        Không thuộc về riêng một object nào.    
        Không cần tạo instance vẫn dùng được.   
        Thường dùng cho biến đếm, các hàm tiện ích, config chung...
        */
         // a3.Count = 10;  // không thể gán giá trị cho Count vì Count là static
        Console.WriteLine(Animals.Count);

        //🔹 III. GET, SET – Thuộc tính (Property)
        


        #endregion
    }
}