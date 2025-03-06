// while (true){
//     Console.WriteLine("Heloo");
// }
/*
4 yếu tố hình thành nên vòng lặp
1. Biến điều kiện  - luôn đặt ngoài vòng lặp
2. điều kiện để vòng lặp diễn ra
3. Khối lệnh (thực hiện khi điều kiện còn đúng)
4. thay đổi giá trị biến điều kiện
*/
// int i = 1; // 1. biến điều kiện
// while (i <= 6) //2. điều kiện để vòng lặp điễn ra
// {
//     Console.WriteLine("Hello dotnet 03");//khối lệnh (thực hiện khi dk đúng)
//     i++; //4. thay đổi giá trị của i 
// }

#region Nhập vào số n và chuỗi
// in ra chuỗi n lần
// b1: Nhập vào n và chuỗi

// Console.WriteLine("Nhập vào số lần : ");
// int n = int.Parse(Console.ReadLine());
// Console.WriteLine("Nhập vào chuỗi: ");
// string text = Console.ReadLine();
// // b2: xác định output
// // anh xin lỗi em /n anh xin lỗi em /n anh xin lỗi em /n .....
// string ketqua="";
// //1. biến điều kiện
// int i = 1;// vòng lặp sẽ chạy từ 1 đến n
// while(i <= n){
//     // ketqua += text + " \n "; 
//     ketqua = ketqua + text + "\n";
//     //thay đổi biến điều kiện
//     // Console.WriteLine(text);
//     i++;
// }
// Console.WriteLine(ketqua);

#endregion

#region Nhập số n tính tổng từ 1-> n
//b1: input n
// Console.WriteLine("Nhập vào số n: ");
// int n = int.Parse(Console.ReadLine());
// //b2: xác định kiểu dữ liệu của kết quả: 
// // int ketqua
// int ketqua = 0;
// //b3: khai báo biến điều kiện
// int i=1;
// //B4: Thân vongf lặp 
// while(i <= n){ // i tăng lần lượt từ 1 -> n
//     //xử lý tính toán tôngr từ 1 đến n
//     // 1+2+3+4+....+n
//     ketqua += i;
//     //ketqua = ketqua + i;
//     //b5: thay đổi biến điền kiện
//     i++;
//     //i = i + 1;
// }
// Console.WriteLine($"Tổng các số từ 1 đến {n} là: {ketqua}");
#endregion

#region Tính tổng các số chẳn tử 2 đến 2n
//input : int n
// Console.WriteLine("Nhập vào số n: ");
// int n = int.Parse(Console.ReadLine());
// int ketqua = 0;
// //output: int ketqua // 2+4+6+8+....+2n
// //ví dụ i =2; từ 2 đến 2n
// // điều kiện i = i + 2;
// int i = 2;
// //viết vòng lặp
// while (i <= 2 * n){
//     ketqua = ketqua + i;
//     //ketqua+=i;
//     i+=2;//i = i + 2
// }
// Console.WriteLine($"Tổng các số chẳn từ 2 đến {n} là : {ketqua}");
// 1. biến điều kiện
// 2. điều kiện
// 3. Thân vòng lặp : xử lý tính tổng
// 4. Tăng giá trị của biến điều kiện
#endregion

#region in ra câu anh xin lỗi em 1 ,2 3,...
// nhập vào n
//in ra 
// chạy vòng lặp giảm dần : tức là -- 
// Console.WriteLine("Em muốn anh xin lỗi mấy lần : ");
// int n = int.Parse(Console.ReadLine());
// while(n>=1){
//     Console.WriteLine($"Anh xin lỗi em {n}");
//     //thay đổi biến điều kiên
//     n--;
// }
#endregion

#region Tính giai thừa
//input số n
//output giai thừa của n | 1 * 2 * 3 * .... * n
//cách 1 là điều kiện tăng dần
//cách 2 giảm dần
//tương tự tính tổng  += thì giai thừa sẽ là *=
//cách giảm dần 
// Console.WriteLine("Nhập vào số n: ");
// int n = int.Parse(Console.ReadLine());
// //biến điều kiện 
// int i = n;//
// int ketqua = 1;
// while(i >= 1){
//     // nhân cho i vì i giảm dần còn n thì không
//     ketqua *= i; //ketqua = ketqua * i
//     //thay đổi biến điều kiện
//     i--;
// }
// Console.WriteLine($"Giai thừa của {n} là {ketqua}");
#endregion

#region Tính tổng bình phương từ 1 đến n
//kèm theo phân tích
//công thức 1^2 + 2^2 + 3^2 + ... + n^2
// 2*2  Math.pow(n,2)
// Console.WriteLine("Nhập vào n: ");
// int n = int.Parse(Console.ReadLine());
// //biến điều kiện
// int i=1;
// int ketqua = 0;
// while(i<=n)//điều kiêu
// {
//     ketqua += (int)Math.Pow(i,2); //Math.pow là hành tính số mũ
//     //ketqua += i * i; 
//     //tăng giá trị của điều kiện
//     i++;
// }
// Console.WriteLine($"Tổng bình phương của {n} là {ketqua}");
#endregion

// Giới thiệu về Math
// int a = Math.


#region Nhập số n kiểm tra số  nguyên tố
// intput : n
// kiểm tra xem từ 1 đến n nó có chia hết cho số nào ngoại trừ 1 và n hay không 
// nếu có thì không phải số nguyên tố
// chạy vòng lặp từ 1 đến n hoặc 2-> n-1 
// thâ vòng lặp : n%i==0???  nếu chia hết thì kh phải số nguyên tố i !=1 và i!=n
// Console.WriteLine("Nhập vào số cần kiểm tra: ");
// int n = int.Parse(Console.ReadLine());
// int i = 1;
// int count = 0;
// //chạy từ i đến n/2 
// //ví dụ: 1  2 3 4 5 6 7 8 9 10
// //       10 5 _ _ 2 _ _ _ _ 1
// // chạy từ i đến căn 2 của n 

// while(i <= n){//từ 1 đến n nếu chỉ có 2 số chia hết (1 và n ) thì là số nguyên tố
//     if(n % i == 0){
//         count++;
//     }
//     i++;
// }
// //kiểm tra xem count==2 là spps nguyên tố 
// if(count==2) Console.WriteLine($"Số {n} là số nguyên tố");
// else Console.WriteLine($"Số {n} không phải là số nguyên tố");
#endregion

#region VÒNG LẶP FOR
//tương tự như while cũng có 4 phần
/*
for(khởi tạo ; điều kiện ; thay đổi điều kiện)
{
//Khối lệnh
}
*/
// for(int i =1; i<=3; i++)
// {
//     Console.WriteLine($"Hello {i}");
// }
//Nhập vào số hàng và số cột in ra hình chữ nhật ngôi sao tương ứng
// Console.Write("Nhập vào số hàng: ");
// int rows = int.Parse(Console.ReadLine());
// Console.Write("Nhập vào số cột: ");
// int cols = int.Parse(Console.ReadLine());
// //ví dụ 3 hàng 5 cột
// // 3 hàng mỗi hàng 5 ngôi sao
// // string ketqua="";
// for(int i = 1; i <= rows; i++)// chạy mỗi dòng 1 lần
// {

//     for(int j = 1; j <= cols; j++) // chạy 5 lần
//     {
//         //ketqua +=" ☆ ";
//         Console.Write(" ⭐ ");
//     }
//     //ketqua+="\n";
//     Console.WriteLine("");
// }
// Console.WriteLine(ketqua);
#endregion
//☆ ☆ ☆ ☆ ☆
#region Tam Giac Vuông
// nhậpvào số n in ra hình tam giacs vuông cân tương ứng
// số 4 thì lần lượt in ra 4 dòng (1 ☆, 2☆, 3☆, 4☆)
// Console.Write("Nhập n: ");
// int n = int.Parse(Console.ReadLine());
// //chạy vòng lặp;
// for(int i = 1; i <= n ; i++){
//     //hàng 1
//     //j là số ngôi sao trên 1 hàng
//     for(int j = 1; j <= i; j++ )
//     {
//         Console.Write(" ⭐ ");
//     }
//     Console.WriteLine("");
// }
//hàng 1 1 ngôi sao
//hàng 2 2 ngôi sao
// hàng 3 3 ngôi sao
// hàng n n ngôi sao

#endregion


#region  TAM GIÁC CÂN
/* ví dụ input = 3, Một ngôi sao bằng 2 khOẢNG trắng
____⭐   n-i khoảng trắng và 2 * i -1 
__⭐⭐⭐   n-1 
⭐⭐⭐⭐⭐

*/
// Console.WriteLine("Nhập n: ");
// int n = int.Parse(Console.ReadLine());
// for (int i = 1; i <= n; i++)
// {
//     //vòng lặp mỗi dòng
//     //dòng i = 2 số ngôi sao = 2 *2 -1 =3 
//     for (int j = 1; j <= n - i; j++)
//     {
//         Console.Write("  ");
//     }
//     for (int z = 1; z <= 2 * i - 1; z++)
//     {
//         Console.Write("⭐");
//     }
//     Console.WriteLine("");
// }

#endregion


#region demo
// Nhập số dòng của tam giác
// Console.Write("Nhập số dòng của tam giác: ");
// int n = int.Parse(Console.ReadLine());
// Console.WriteLine("\nTam giác cân:");

// // Vòng lặp for lồng nhau để in tam giác cân
// for (int i = 1; i <= n; i++) // Lặp qua từng dòng
// {
//     // In khoảng trắng để căn giữa
//     for (int j = 1; j <= n - i; j++)
//     {
//         Console.Write("  ");
//     }

//     // In dấu sao
//     for (int k = 1; k <= (2 * i - 1); k++)
//     {
//         Console.Write("⭐");
//     }

//     Console.WriteLine(); // Xuống dòng
// }
#endregion


#region Tìm các số nguyên tố trong khoảng từ 1 đến n
//input: số n dương
// output: chuối các số nguyên tố string ketqua = "2 3 5 7 11 ..."
//duyệt qua các số từ 1 đến n , kiểm tra xem nó có phải số nguyên tố hay không 
// -> có thì cộng dồn vào biến kết quả
// cw ra kết quả
//

Console.WriteLine("Nhập n: ");
int n = int.Parse(Console.ReadLine());
string ketqua ="";
for (int i = 1; i <= n; i++)
{
   
    int count = 0;
    int j=1;
    while (j <= i)
    {
        if (i % j == 0)
        {
            count++;
        }
        j++;
    }
    if (count == 2){
        ketqua+=$" {i}";
    }
}
Console.WriteLine(ketqua);
#endregion
