class Program{
    static void Main(string[] args)
    {
        // Tạo một đối tượng BlindBox với kiểu dữ liệu là int, string , double , ..... đều được vì T là kiểu tham số
        var baby3 = new BlindBox<string>(){
            GiaTri = "Baby tree"
        };
        var baby4 = new BlindBox<int>(){
            GiaTri = 2
        };
        
        // Ràng buộc kiểu dữ liệu 
        // vì DoChoi là một class thực thi - implement IBlindBox2 
        //where T : IBlindBox đảm bảo rằng BlindBox<T> chỉ hoạt động với những kiểu có cài đặt interface IBlindBox2, nên trong class BlindBox2<T> bạn có thể gọi GiaTri.MoTa() mà không cần ép kiểu hay kiểm tra null.
        var baby5 = new BlindBox2<DoChoi>(){
            GiaTri = new DoChoi(){
                Ten = "Baby"
            }
        };

    }
}