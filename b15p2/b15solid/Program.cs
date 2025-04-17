class Program
{
    static void Main(string[] args)
    {
        #region GENERICTYPE

        // void wellcome(string name)
        // { // tham số động , cố định kiểu dữ liệu
        //     Console.WriteLine($"Hello {name}");
        // }
        // // dùng Wellcome
        // wellcome("Hà");
        // wellcome("Phú");

        // // dùng BlindBox
        // // chứa 6 chữ số giải đặc biệt ngày 14/4
        // BlindBox<int> blindBox1 = new BlindBox<int>(); // khởi tạo 1 đối tượng Blinbox có kiểu int
        // blindBox1.value = 123456;// gán giá trị cho value
        // Console.WriteLine(blindBox1.GetValue()); // gọi hàm
        // // string
        // BlindBox<string> blindBox2 = new BlindBox<string>();
        // blindBox2.value = "123456";
        // Console.WriteLine(blindBox2.GetValue());
        // // tương tự cho boolean , double, .... 
        // BlindBox<BabyThree> blindBox3 = new BlindBox<BabyThree>();
        // // KHởi tạo 1 đối tượng có kiểu dữ liệu là BabyThree
        // blindBox3.value = new BabyThree(){ Id=1, Name="Hà", Price=1000};
        // // blindBox3.value.Id = 2; // gán giá trị cho Id
        // // blindBox3.value.Name = "Phú"; // gán giá trị cho Name
        // // blindBox3.value.Price = 2000; // gán giá trị cho Price
        // //gán giá trị cho value 
        // Console.WriteLine(blindBox3.GetValue()); // in ra giá trị Name của thuộc tính
        // Console.WriteLine(blindBox3.GetValue().Name); 
        // Console.WriteLine(blindBox3.GetValue().Id); 
        // Console.WriteLine(blindBox3.GetValue().Price); 


        #endregion

        #region CRUD

        // // khởi CRUD 
        // CRUD<Product> crud = new CRUD<Product>();
        // // thêm sản phẩm vào danh sách
        // crud.Add(new Product() { Id = 1, FullName = "Hà", Age = 18 });
        // crud.Add(new Product() { Id = 2, FullName = "Phú", Age = 20 });
        // //show ds
        // crud.ShowDS();
        // Console.WriteLine(""); 


        // // tạo crud cho bb3

        // CRUD<BabyThree> crud2 = new CRUD<BabyThree>();
        // // thêm
        // crud2.Add(new BabyThree() { Id = 1, Name = "Baby 1", Price = 1000 });
        // crud2.Add(new BabyThree() { Id = 2, Name = "Baby 2", Price = 2000 });
        // crud2.Add(new BabyThree() { Id = 3, Name = "Baby 3", Price = 3000 });
        // crud2.ShowDS();
        // // 
        // CRUD<string> crud3 = new CRUD<string>(); 
        // crud3.Add("Hà");
        // crud3.Add("Phú");
        // crud3.Find(1);

        // // crud3.ShowDS();
        // //
        // // CRUD<int> crud4 = new CRUD<int>(); // in là kiểu giá trị không phải class nên khonng dùng được CRUD
        // // crud4.Add(1);
        // // crud4.Add(2);
        // // crud4.ShowDS();
        #endregion


        #region     Activator
        // hàm hỗ trợ tạo ra 1 đối tượng từ tên class không dùng từ khoá new
        // Sẽ có trường hợp mình không bioeets đối tuong là gì, hàm tạo ra sao , có tham số hay không , thì sẽ kh dùng được cách new đối tượng -> Activator

        // // tạo đối tượng từ tên class
        // Product a = new Product();
        // sẽ có những 
        //1: Tạo một thể hiện mới của kiểu được chỉ định.
        // dynamic? b = Activator.CreateInstance(typeof(Product));// NHẬN VÀO TYPE CỦA ĐỐI TƯỢNG


        // //2: Tạo một đối tượng mới và truyền các tham số vào constructor.
        // dynamic? c = Activator.CreateInstance(typeof(Product), 1, "Hà", 18); // truyền vào các tham số của hàm tạo
        // dynamic? c2 = Activator.CreateInstance(typeof(Product), new object[] { 1, "Hà", 18 });


        // //3: 
        // dynamic d = Activator.CreateInstance<Product>();
        // //4:non-public
        // dynamic? e = Activator.CreateInstance(typeof(Product), true);

        #endregion

        


        #region DI 
        // 
        // DI: Dependency Injection
        // DI THỦ CÔNG . CHẠY BẰNG CƠM
        // khởi tạo serviceA
        // ServiceA serviceA = new ServiceA("Hà");
        // // khởi tạo serviceB
        // ServiceB serviceB = new ServiceB();
        // // Khởi tạo serC 
        // ServiceC serviceC = new ServiceC(serviceA, serviceB);

        // tự khởi tạo serviceA và serviceB trong DICOntainer 


        // DI ĐỘNG : DICONTAINER
//DI Container là 1 lớp giúp mình khởi tạo ra các service - đối tượng phục cho DI 

        DIContainer diContainer = new DIContainer();// khởi tạo DIC
        // đăng ký serviceA và serviceB
        diContainer.Register<IServiceA, ServiceA>(); // Nhận vào interface , class thực thi
        diContainer.Register<IServiceB, ServiceB>(); // Nhận vào interface , class thực thi
        // khởi tạo serviceC
        // truyền vào serviceA và serviceB
        ServiceC serviceC = diContainer.Resolve<ServiceC>(); // khởi tạo serviceC
        serviceC.ABC(); // gọi hàm ABC của A
        serviceC.XYZ(); // gọi hàm XYZ  của B
         
        #endregion
    }
}