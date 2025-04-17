// GENERIC TYPE 
// T này là kiểun dữ liệu tổng quát, kiểu dữ liệu động
// có thể thay T bằng bất kì "tên biến" nào cũng được -> Nên để là T

public class BlindBox<T>{ // Babythree
    public T value; // 
    public T GetValue(){ // 
        return value ;
    }  
}

public interface IBlindBox{ // interface
    void Secret();
}
public class BabyThree : IBlindBox{ // kế thừa từ IBlindBox
    public void Secret()
    {
        Console.WriteLine("Secret bb3");
    }
    public int Id {get; set;}
    public string Name {get; set;}
    public double Price {get; set;} 
    //secret
    
}
public class Labubu : IBlindBox{ // kế thừa từ IBlindBox
    public void Secret()
    {
        Console.WriteLine("Secret labubu");
    }
    public int Id {get; set;}
    public string Name {get; set;}
    public double Price {get; set;} 
    public string Color {get; set;}
    // secret 


}



public class Product{
    public int Id {get; set;}
    public string FullName {get; set;}
    public int Age {get; set;}
    public Product(int id, string fullName, int age){
        Id = id;
        FullName = fullName;
        Age = age;
    }
}



