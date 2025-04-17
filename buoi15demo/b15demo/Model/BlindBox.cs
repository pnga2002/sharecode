

// kiểu tham trị
public class BlindBox<T>{
        public T GiaTri { get; set; }
}

// kiểu tham chiếu
// Generic class với ràng buộc where T : IBlindBox
public class BlindBox2<T> where T : IBlindBox
{
    public T GiaTri { get; set; }

    public void MoHop()
    {
        Console.WriteLine("Mở hộp ra thấy: " + GiaTri.MoTa());
    }
}






// interface
public interface IBlindBox
{
    string MoTa(); // ví dụ một phương thức
}

// Một class cài đặt IBlindBox
public class DoChoi : IBlindBox
{
    public string Ten { get; set; }

    public string MoTa()
    {
        return $"Đây là món đồ chơi: {Ten}";
    }
}
