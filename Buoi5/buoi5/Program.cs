#region In Chuỗi Đảo ngược

// 2p đầu phân tích bài toán gửi lên nhóm
// lấy kí tự của chuỗi text[vị trí] . Ví dụ
// 4p tiếp theo giải bài gửi lên nhóm
// string text ="Hello";
// int count = text.Length;// text.Count()
// text[0] là H
// text[1] là e
// text[2] là l
// text[3] là l ......

//input : nhập vào chuỗi
//output : chuỗi đảo ngược tương ứng string ketqua
//process: duyệt từng ký tự trong chuỗi để đảo ngược chuỗi

// Console.WriteLine("Nhập vào chuỗi cần đảo ngược: ");
// string input = Console.ReadLine();
// string ketqua="";
// string ketqua2="";

// //chạy vòng lặp duyệt qua từ ký tự của chuỗi
// for(int i = 0; i<=  input.Length - 1; i++){// duyệt xuôi
//     //kí tự đầu của chuỗi input[0]
//     //h
//     ketqua =input[i] + ketqua; //h   e+h=> eh....
// }
// //duyệt ngược
// // for(int j = input.Length - 1;j>=0;j--){
// //     //input[j] -> chạy vòng đầu sẽ lấy ra vị trí cuối cùng
// //     ketqua2 +=input[j];
// // }
// //forearch duyệt qua từng ký tự có trong input mà không cần input[i]
// foreach(char x in input){ // h e l l o
//     Console.WriteLine(x);
// }
// Console.WriteLine($"Cách 1: Chuỗi đảo ngược của {input} là : {ketqua}");
// Console.WriteLine($"Cách 2: Chuỗi đảo ngược của {input} là : {ketqua2}");
#endregion
#region Các hàm xử lý chuỗi
string text = "Hello dote";
//
// Console.WriteLine(text[19]);//vượt index -> lỗi chương trình
//Constains: kiểm tra chuỗi có chứa chuỗi con hay không => trả vể boolean
//StartWith: kiểm tra chuỗi có bắt đầu bằng chuỗi con hay không => trả vể boolean
//Constains: kiểm tra chuỗi có kết thúc bằng chuỗi con hay không => trả vể boolean
Console.WriteLine($"kiểm tra xem chuỗi có chứa chuỗi con 'ello' hay không : {text.Contains("ello")}");
Console.WriteLine($"kiểm tra xem chuỗi có bắt đầu bằng chuỗi con 'Hello' hay không : {text.Contains("Hello")}");
Console.WriteLine($"kiểm tra xem chuỗi có kết thúc bằng chuỗi con '03' hay không : {text.Contains("03")}");
//Substring(a,b) : cắt chuỗi theo vị trí bắt đầu từ a vào kéo dài đến b ký tự
// h e l l o d o t n e 
// 0 1 2 3 4 5 6 7 8 9 
//                          
// (2,5) là lấy từ vị trí thứ 2 cộng thêm 5 ký tự nữa => 
Console.WriteLine(text.Substring(2, 5));
//join
string[] words = { "world", "C#", "programming", "is", "fun" };// hôm sau học tới sẽ giải thích kỹ hơn.

string result = string.Join("_", words); // world  c#
Console.WriteLine(result);
//ToUpper: in hoa, ToLower: in thuonwfg
Console.WriteLine($"In hoa chuỗi : {text.ToUpper()}");
Console.WriteLine($"In thường chuỗi : {text.ToLower()}");
// h  e  l  l  o  d  o  t  n  e    
//                     ^3 ^2 ^1     // reindex duyêt mảng không cần lenght-1
// 0  1  2  3  4  5  6  7  8  9     // index
Console.WriteLine($"vị trí cuối của chuỗi in bằng reindex: {text[^1]}");
//Làm nhanh bài đảo ngược chuỗi bằng reindex

// break và continue trong vòng lặp
#endregion

#region Làm lại bài đảo ngược bằng reindex
Console.WriteLine("Nhập vào chuỗi: ");
string input = Console.ReadLine();
string res = "";
//
//vị trí cuối của chuỗi theo reindex ^1 -> ^input.Length
for (int i = 1; i <= input.Length ; i++)// duyệt xuôi
{
    //vidu chuỗi là : hello ^1 o
    res = res + input[^i]; 
}
Console.WriteLine($"Chuỗi sau khi đảo ngươc với reindex là : {res}");
#endregion



















