// trong 1 đối tượng : 
// A có phương thức ABC
// B có phương thức XYZ
// C có phương thức MNP kèm theo muốn dùng ABC và XYZ 

public interface IServiceA
{
    void ABC();
}
public interface IServiceB
{
    void XYZ();
}
public class ServiceA : IServiceA
{
    // hafm tao serviceA
    // public ServiceA(string name)
    // {
    //    Console.WriteLine("ServiceA: " + name);
    // }
   
    public void ABC()
    {
        Console.WriteLine("ABC");
    }
}
public class ServiceB: IServiceB
{
    // hàm tạo serviceB
    public ServiceB()
    {
        Console.WriteLine("ServiceB");
    }
    // hàm này không có trong serviceA

        public void XYZ()
    {
        Console.WriteLine("XYZ");
    }
}

// khoong cần khởi tạo serviceA và serviceB trong ServiceC
public class ServiceC
{
    // khởi tạo trong C sẽ bị lỗi khi A hoặc B thay đổi
    // public ServiceA serviceA = new ServiceA();// khởi tạo serviceA
    // public ServiceB serviceB = new ServiceB();// khởi tạo serviceB

    public readonly ServiceA serviceA;
    public readonly ServiceB serviceB;
    // truyền vào serviceA và serviceB vafo contructor cuar C
    public ServiceC(ServiceA A, ServiceB B)
    {
        serviceA = A; // gán serviceA vào serviceA của C
        serviceB = B; // gán serviceB vào serviceB của C
    }

    // dùng ABC, XYZ
    public void ABC()
    {
        serviceA.ABC(); // gọi phương thức ABC của serviceA
    }
    public void XYZ()
    {
        serviceB.XYZ(); // gọi phương thức XYZ của serviceB
    }

    public void MNP()
    {
        serviceA.ABC(); // gọi phương thức ABC của serviceA
        Console.WriteLine("MNP");
    }
}