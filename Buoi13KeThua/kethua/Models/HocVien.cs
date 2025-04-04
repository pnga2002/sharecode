public class HocVien : NguoiDung{ // có đầy đủ thuộc tính và phương thức của NguoiDung 
// public protedted 
// protected dùng được trong class con , không dùng ở đối tượng

// khi mà class cha có constructor thì 
// TH1: Class cha có constructor mặc định (không tham số)
// → Class con không cần viết constructor, vì mặc định compiler sẽ tự gọi constructor của class cha.
// TH2: Class cha chỉ có constructor có tham số
// → Class con bắt buộc phải gọi constructor của cha, bằng cách viết constructor và dùng base(...)
// Nếu bạn không viết constructor trong Child, compiler sẽ báo lỗi vì không biết gọi constructor nào trong Parent (vì không có constructor mặc định).

//    public HocVien(string ten, string email, string sdt, string matkhau) : base(ten, email, sdt, matkhau){
//         // gọi constructor của class cha
//         // base(ten, email, sdt, matkhau);
//         Console.WriteLine("Constructor HocVien");
//     }
// TH3: class cha có constructor mặc định và constructor có tham số
// → Class con có thể gọi constructor của cha bằng base(...) hoặc không gọi gì cả.
// Nếu không gọi gì cả thì mặc định sẽ gọi constructor mặc định của cha.
// Nếu gọi base(...) thì sẽ gọi constructor có tham số của cha.
   // phương thức riêng cho class con
    public void NopBai(){
        Console.WriteLine("Nộp bài thành công");
    }
    

    #region GHI ĐÈ
    // không có vitual - không có tính đa hình : không phải ghi đè mà là "ẩn"
    public void HienThi() // Không override, mà "ẩn" đi HienThi của cha
    {
        Console.WriteLine("Hiển thị từ SinhVien");
    }

    // ghi đè lại hàm HienThi của class cha
    public override void HienThi2()
    {
        Console.WriteLine("Hiển thị từ SinhVien2");
    }
    #endregion
    
}