public class HocVien : NguoiDung{ // có đầy đủ thuộc tính và phương thức của NguoiDung 
// public protedted 
// protected dùng được trong class con , không dùng ở đối tượng

   public HocVien(){
   }
   // phương thức riêng cho class con
    public void NopBai(){
        Console.WriteLine("Nộp bài thành công");
    }
    
}