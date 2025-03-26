public class Car{
    // viết các funtion xử lý 
    // tên , giá , thuong hiệu
    //THUÔC TÍNH
    public string Ten;
    public double Gia;
    public string ThuongHieu;
    // private string Key;
    protected string Key;

    // Hành Vi / Phương thức // hàm 
    public void KenXe(){ // là 1 function không nhận tham số
        Console.WriteLine("BÍP BÍP BÍP");
    }
    public void KhoiDong(string key){ // function có tham số
        // xử lý khởi động
        // nếu key = CYBERTRUCK thì 
        // thì log ra tiếng khởi động xe 
        // không thì hú cảnh báo trộm
        if(key == Key){
            
        }
    }

}