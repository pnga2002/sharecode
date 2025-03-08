class BaiTap3
{
    //chứa các funtion xử lý cho bài tập 3
    // tìm số nguyên tố trong chuỗi số sau  
    // ví dụ chuỗi : 3789654 -> 3 7 8 9 6 5 4
    // chuoi[0]=3
    // chuoi[1]=7
    // chuoi[2]=8

    public static string timSoNguyenToTrongChuoi(string chuoi)
    {
        string kq = "";
        //xử lý
        // vòng lặp duyệt qua từng ký tự của chuỗi và kiểm tra 
        // nếu đúng thì cộng dồn vào kq
        for(int i =0; i<=chuoi.Length;i++){
            int number1 = Convert.ToInt16(chuoi[i].ToString());
            // gọi đến function kiểm tra
            bool isPrime1 = BaiTap2.kiemTraSoNguyenTo(number1);
            if(isPrime1){
                // nếu có giá trị là true thì thực hiện lênh
                kq +=$" {number1}";
                // kq +=$" {chuoi[i]}";

            }
        }
        foreach (char c in chuoi)
        {
            // tại lần chạy đầu tiên c=3 // thứ nhất
            // tại lần chạy thứ 2  c=7 / giá trị kí tự thứ 2
            // tái sử dụng function đã có ở BaiTap2.kiemTraSoNguyenTo
            // cần chuyển char về string sau đó ép về kiểu int để kiểm tra
            int number  = Convert.ToInt16(c.ToString());
            bool isPrime = BaiTap2.kiemTraSoNguyenTo(number);
             if(isPrime){
                // nếu có giá trị là true thì thực hiện lênh
                kq +=$" {c}";

            }
        }
        return kq;
    }
}