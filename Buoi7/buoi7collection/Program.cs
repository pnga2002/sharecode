// // See https://aka.ms/new-console-template for more information
// // Console.WriteLine("Hello, World!");
// // Console.WriteLine("Huỳnh");
// // Console.WriteLine("Phú");
// // Console.WriteLine("Thanh ");
// // Console.WriteLine("Vương");
// // Console.WriteLine("Vương1");
// // Console.WriteLine("Vương2");
// // Console.WriteLine("Vương3");
// // là một danh sách chưa các giá trị cùng kiểu dự liệu
// // Cú pháp : List<kieu_du_lieu> ten_danh_sach = new List<kieu_du_lieu>{}
// //khai báo danh sách kèm theo giá trị 
// List<string> dotnet03 = new List<string>{"Huỳnh", "Phú","Thanh","Vương"};

// // List rỗng chư có học viên nào
// List<string> lstNames2 = new List<string>();

// // Tương tác với List C R U D
// //Thêm 1 bạn vào lstNames 
// // ADD: tương ứng với C trong CRUD, thêm 1 phần tử vào CUỐI danh sách 
// dotnet03.Add("Tâm");//"Huỳnh", "Phú","Thanh","Vương" , "Tâm"
// //
// //Thêm vào vị trí nào đó
// //Thêm Phước vào vị trí index số 0 -> dẫn đến index của những bạn hiện tại thay đổi
// dotnet03.Insert(0,"phước");//"Phước","Huỳnh", "Phú","Thanh","Vương" , "Tâm"
// //                             0      1         2      3     4         5
// //Thêm nhiều vào vị trí nhất định
// dotnet03.InsertRange(2,new List<string>{"Tuấn Anh","Fei Fei","Phương"});
// //"Phước","Huỳnh","Tuấn Anh","Fei Fei","Phương", "Phú","Thanh","Vương" , "Tâm"
// // 0      1         2           3         4        5       6      7      8

// //Xoá tử
// //Remove(gia_tri) : xoá giá trị đó ra khỏi danh sách
// dotnet03.Remove("Fei Fei");
// //"Phước","Huỳnh","Tuấn Anh","Phương", "Phú","Thanh","Vương" , "Tâm"
// // 0      1         2           3         4        5       6      7  
// //RemoveAt(index) : xoá giá trị tại vị trí index ra khỏi danh sách
// // xoá phần tử tại vị trí số 4 ra khỏi danh sách
// dotnet03.RemoveAt(4);
// //"Phước","Huỳnh","Tuấn Anh","Phương","Thanh","Vương" , "Tâm"
// // 0      1         2           3         4        5       6  
// //RemoveAll 
// // remove những bạn tên bắt đầu bằng chữ T
// //name => name.StartsWith("T") 
// dotnet03.RemoveAll(name => name.StartsWith("T"));
// //"Phước","Huỳnh","Phương","Vương"
// // 0      1         2           3 






// // ĐỌC: tương ứng với read trong CRUD
// // string : Hello
// //n         ['H','e','l','l','o']
// //index       0   1   2   3   4
// //Count của text 5 phương thức - method -hàm 
// //Length : thuộc tính của chuỗi 
// string text ="Hello";
// foreach(char a in text){// vì chuỗi được tạo thành từ nhiều char
//     Console.WriteLine(a);
// }
// Console.WriteLine(text.Count());
// //tương tự với chuỗi string -> có thể dùng forearch để in ra các giá trị của LIST
// //DUYÊT LIST
// foreach(string name in dotnet03){
//     Console.Write($"{name} ,");
// }
// //READ, tìm kiếm, 
// Console.WriteLine("");
// //Count:  Đếm số lượng phần tử trong danh sách
// Console.WriteLine($"Số lượng phần tử trong danh sách : {dotnet03.Count()}");
// //Sort: sắp xếp lại chuỗi theo thứ tự tăng dần
// // dotnet03.Sort();
// // Console.Write($"Sắp xếp theo thứ tự tăng dần : ");
// // foreach(string name in dotnet03){
// //     Console.Write($"{name} ,");
// // }
// // Đảo ngược 
// // Reverse : Đảo ngược chuỗi
// //Giảm dần:  sắp xếp tăng dần (Sort) sau đó đảo ngươc dùng Reverse
// //
// dotnet03.Add("Anh");
// dotnet03.Add("An");
// dotnet03.Add("Huỳnh 1");
// dotnet03.Sort();
// dotnet03.Reverse();
// foreach(string name in dotnet03){
//     Console.Write($"{name} ,");
// }
// Console.WriteLine("");
// //Tìm kiếm
// //Find : tìm phần tử đầu tiên trong danh sách thoả điều kiện
// Console.WriteLine($"Tìm 1 bạn đầu tiên tên bắt đầu bằng chữ A: {dotnet03.Find(name => name.StartsWith("A"))}");
// //FindLast: tìm phần tử cuối cùng trong danh sách thoả điều kiện
// Console.WriteLine($"Tìm 1 bạn cuối cùng tên bắt đầu bằng chữ A: {dotnet03.FindLast(name => name.StartsWith("A"))}");
// //FindAll: tìm kiếm nhiều thoả điều kiện
// //
// var lsFind = dotnet03.FindAll(name => name.StartsWith("A"));
// Console.WriteLine($"Tìm tất cả bạn tên bắt đầu bằng chữ A: ");
// lsFind.ForEach(Console.WriteLine);


// // Tìm kiếm bằng từ => lấy ra những phần tử tương ứng
// var lstFindName = dotnet03.FindAll(c => c=="Huỳnh");
// lstFindName.ForEach(Console.WriteLine);
// //tìm nhiều người like: giống 
// //constains: chứa đựng : tên nào có chứa chữ "Huỳnh" thì gom nó vào lstLike
// var lstLike = dotnet03.Where(name => name.Contains("Huỳnh"));
// /*LINQ
//  ten_function(a){
//     if(a.Constains(Huynh)){
//     return a
//     }
//  }
// */

// lstLike.ToList().ForEach(Console.WriteLine);

//

//Luyện tập 
List<string> dsPhim = new List<string>
        {
            "Đệ Nhất Tội Ác",
            "Bố Già Youtube",
            "Bố Già Chiếu Rạp",
            "Kỵ Sĩ Bóng Đêm ",
            "Chuyện Tình Pulp Fiction ",
            "Forest Gump",
            "Khởi Nghiệp ",
            "Câu Lạc Bộ Đấm Bốc "
        };

//YC1:  tìm kiếm theo tên phim
Console.WriteLine("---------Tìm bố già");
var findBoGia = dsPhim.Where(name => name.Contains("Bố Già"));
findBoGia.ToList().ForEach(Console.WriteLine);
//YC2: sắp xếp tăng dần
Console.WriteLine("-------sắp xếp tăng đần");
dsPhim.Sort();
dsPhim.ForEach(Console.WriteLine);
//YC3: Xoá bố già youtube ra khỏi danh sách
//remove(gia_tri)
Console.WriteLine("--------Xoá bố già youtube-------");
dsPhim.Remove("Bố Già Youtube");
dsPhim.ForEach(Console.WriteLine);


/*
TỔNG KẾT KIẾN THỨC BUỔI 7
1. List danh sách
    - Khai báo 
    List<kieu_du_lieu> ten_danh_sach = new List<kieu_du_lieu>() : khởi tạo List rỗng
    List<kieu_du_lieu> ten_danh_sach = new List<kieu_du_lieu>{ "",""} khởi tạo kèm giá trị

    - Thêm, xoá, đọc 
    - Duyệt
        - list.ForEach(Console.WriteLine);
        - forearch để duyệt
    - Tìm kiếm : find, findAll, where
    - Sắp xếp : sort
    - Đảo ngược : reverse
2. C R U D
    - Add
    - Insert
    - InsertRange
    - Read
    - Remove
    - RemoveAt
    - RemoveAll
    - Find
    - FindAll
    - Where
    - Sort
    - Reverse
3. Luyện tập
*/

//UPDATE : chỉnh sửa 
// thay đổi phim đầu tiên thành Nhà Gia Tiên
//thay đổi bằng vị trí 
// thay đổi giá trị tại vị trí tương ưng thành giá trị ở vế phải
dsPhim[0] = "Nhà Gia Tiên";
Console.WriteLine("_____________________");
Console.WriteLine("Thay đổi phim đầu tiên");
dsPhim.ForEach(Console.WriteLine);


// Yêu cầu tìm phim "Forest Gump" và đổi tên cho nó
//Cách thông thuongừ duyệt for
// tìm phim có tên là "Forest Gump"
for(int i=0;i<dsPhim.Count();i++){
    //kiểm tra tên phim =='Forest Gump'
    //có thì lấy ra i : index của phim đó
    if(dsPhim[i] == "Forest Gump"){
        //bằng thì update giá trị và kết thúc
        dsPhim[i]  = "Lật Mặt 8";
        break;
    }
}
// cách dùng findindex
int a = dsPhim.FindIndex(phim=> phim=="Forest Gump");
// cái `phim` nó sẽ đi vào từng phần tử trong dsPhim để kiểm phim=="Forest Gump" có đúng hay không 
//ĐÚNG -> trả ra vị trí tại phần tử đó
//KHông -> -1
dsPhim[a]  = "Lật Mặt 8";




Console.WriteLine("Sau khi update 'Forest Gump': ");
dsPhim.ForEach(Console.WriteLine);








