// class Program
// {
//     public static void Main(string[] args)
//     {
//         //gọi function
//         List<int> lst = new List<int> {10,1,2, 3, 9, 10, 12,11};
//         // 1,2,3,4,
//         //9 10 11 12 13 14 15 
//         Console.WriteLine($"độ dài chuỗi liên tục dài nhất là : {Method.ChuoiConLienTuc(lst)}");
//     }
// }

// array
// array  tương tự List , nhưng có số lượng phần tử nhất định, 
//Khai báo : khởi tao arrau phải kèm số lượng phần tử
string[] lstName = new string[5]; // mảng có 5 phần tử 
// Khai báo có giá trị 
string[] lstPhim = new string[] { "Bố già", "Nhà bà nữ", "Mai" };
//                                 0         1          2
// so luong phan tu : Lenght
int lengthPhim = lstPhim.Length;
Console.WriteLine($"độ daig của lstPhim : {lstPhim.Length}");

//Copy 
int[] arr1 = new int[] { 1, 2, 6, 5, 3, 4 };
int[] arr2 = arr1;

Console.WriteLine("\nDanh sacsh arr2 sau khi copy tuwf arr1");

//duyệt mảng
foreach (int a in arr2)
{
    Console.Write(a + " ");
}
Console.WriteLine("\nDanh sacsh arr1 sau khi sap xep");


//Xắp xếp , reverse
Array.Sort(arr1);
//duyệt mảng
foreach (int a in arr1)
{
    Console.Write(a + " ");
}
// reverse :đảo ngược
Array.Reverse(arr1);
Console.WriteLine("\nDanh sacsh arr1 sau khi đảo ngược ngược");
foreach (int a in arr1)
{
    Console.Write(a + " ");
}


//resize : thay đổi kích thước ví dụ ban đầu nó có lenght =5 -> lenght =10
Console.WriteLine($"\nlength của lstName trước khi RESIZE là: {lstName.Length}");

Array.Resize(ref lstName, 10);
Console.WriteLine($"length của lstName sau khi RESIZE là: {lstName.Length}");


// find
// tìm các số chẳn trong arr1
int resFind = Array.Find(arr1, a => a % 2 == 0); // tìm phần tử đầu tiên thoả điều kiện
int[] resFindAll = Array.FindAll(arr1, a => a % 2 == 0); // tìm tất cả

lstName[]
Console.WriteLine($"\nsố chẳn đầu tiên trong arr1 {resFind}");
foreach (int a in resFindAll)
{
    Console.Write(a + " ");
}


// Đầu buổi T6 giải bài tập array ,hashset, -> tham chiếu , tham trị của collection ty và reference value -> OOP


