public class HocVien : NguoiDung{ // có đầy đủ thuộc tính và phương thức của NguoiDung 
// public protedted 
// protected dùng được trong class con , không dùng ở đối tượng

//    public HocVien(){
//    }
// Hàm tạo : nếu Clasc cha không có hàm tạo (hàm tạo kh tham số) thì class con không cần hàm tạo , 
// trình biên dich sẽ tự gọi contructor của class cha cho con

// Cha có contructor có tham số thì class con phải có hàm tạo 
// base(ten,email,sdt,matkhau):  gọi lại contructor của class cha
// 
 public string Facebook;

 public HocVien(){}
 // Nếu class cha có hàm tạo không tham số và có hàm tạo có tham số thì class con có thể bỏ qua hàm tạo 
   public HocVien(string ten, string email, string sdt, string matkhau, string facebook) : base(ten,email,sdt,matkhau){
        //  xử lý riêng của contructor class con
        Facebook = facebook;
   }
   // phương thức riêng cho class con
    public void NopBai(){
        Console.WriteLine("Nộp bài thành công");
    }


    #region GHI ĐÈ
    //không ghi đè mà ẩn đi phương thức của class cha
    public void HienThi(){ // ẩn đi HienThi NguoiDung 
        Console.WriteLine($"Hiển thị Học Viên");
    }
    public override void HienThi2(){ // ghi đè
        Console.WriteLine($"Hiển thị Học Viên2");
    }

    // Ghi đè 

   // show thông tin : tên - email - sdt - link fb 
    public sealed override void ShowInfor(){ // mình kế thừa từ nguoiDung nhưng : không cho con kế thừa
          Console.WriteLine($"Tên: {Ten} - Email: {Email} - SĐT: {SDT} - Facebook: {Facebook}");
     }
    #endregion
    
}