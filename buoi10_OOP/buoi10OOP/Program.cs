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
class Program {
    static void Main(){
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

        

    }
}