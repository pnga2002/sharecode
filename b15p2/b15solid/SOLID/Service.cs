public abstract class Bird{
    public abstract void Fly();
}
public interface IFlyable{
    void Fly();
}

public class ChimSe : IFlyable
{
    public  void Fly()
    {
        Console.WriteLine("Chim se bay");
    }
}

public class DaDieu
{

  
}



// public interface IPrint
// {
//     // tách 2 phương thức ra thành nhiều interface khác nhau
//     void Print();
//     void Scan();
//     void Fax();

// }
public interface IPrint
{
    void Print();
}
public interface IScan
{
    void Scan();
}
public interface IFax
{
    void Fax();
}

public class PrinterOld : IPrint // thuc thi imterface nao can thiet
{
    public void Print()
    {
        Console.WriteLine("In");
    }
   
}
public class SuperPrint : IScan, IPrint,IFax
{
    public void Print()
    {
        Console.WriteLine("In");
    }

    public void Scan()
    {
        Console.WriteLine("Quét");
    }

    public void Fax()
    {
        Console.WriteLine("Fax");
    }
}