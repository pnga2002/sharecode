class Food{
    // static 
    public static int IdDem = 1;
    // các thuộc tính
    public int MaMonAn { get; set; }// tự động tăng
    public string TenMonAn { get; set; }
    public double Gia { get; set; }
    // hàm tạo 
    public Food(string ten, double gia){
        MaMonAn = IdDem++; // gán cho mamonan idDem hiện tại và tăng lên 1 
        TenMonAn = ten;
        Gia = gia;
    }

    // các phương thức
    public void HienThiThongTin(){
        Console.WriteLine($"{MaMonAn} - {TenMonAn} - Giá : {Gia} VND");
    }
}