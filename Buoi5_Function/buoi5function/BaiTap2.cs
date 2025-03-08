class BaiTap2
{
    // code các function xử lý cho bt2 
    // tìm các số nguyên tố từ 2 đến n 
    // chaỵ vòng lặp từ 2 đến n
    // kiểm tra xem có phải số nguyên tố không
    
    public static string danhSachSoNguyenTo()
    {
        Console.WriteLine("Nhập n: ");
        int n = int.Parse(Console.ReadLine());
        string ketqua = "";
        for (int i = 1; i <= n; i++)
        {
            bool isPrime = kiemTraSoNguyenTo(i);
            // nếu isPrimw == true thì cộng dồn vào kết quả
            if(isPrime){
                // nếu có giá trị là true thì thực hiện lênh
                ketqua +=$" {i}";
            }
        }
        return ketqua;
    }
    // kiểm tra số nguyên tố
    //kiểm tra xem số a có phải là snt hay không
    public static bool kiemTraSoNguyenTo(int a)
    {
        bool check = false;
        int count = 0;
        int j = 1;
        while (j <= a)
        {
            if (a % j == 0)
            {
                count++;
            }
            j++;
        }
        //nếu có 2 ước thì là số nguyên tố
        if (count == 2)
        {
            check=true;
        }

        return check;
    }
}