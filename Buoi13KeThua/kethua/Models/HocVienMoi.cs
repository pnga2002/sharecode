public class HocVienMoi : HocVien{ // có đầy đủ thuộc tính và phương thức của NguoiDung và học viên
// public protedted 
// protected dùng được trong class con , không dùng ở đối tượng

   public HocVienMoi(){
    // this.
   }
   // phương thức riêng cho class con
   public void NopTien(){
    Console.WriteLine("Nôp tiền thành công!");
   }
    
}