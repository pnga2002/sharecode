
class Program
{

    // khai báo list kèm giá trị 
    static List<int> lstnumber = new List<int> { 20, 81, 97, 63, 72, 11, 20, 15, 33, 15, 41, 20 };
    private static void Main(string[] args)
    {
        //1. Tổng các số lớn hơn 50
        //viết 1 function ở method nhận vào danh sách trả ra tổng
        // int kq1 = Method.TinhTongLonHon50(lstnumber);
        // int kq1 = Method.TinhTongLonHon50C2(lstnumber);
        // Console.WriteLine($"1 . Tổng các số lơn hơn 50 trong lstNumber là : {kq1}");
        // Console.WriteLine("_________________________");

        //2.ĐẾM SỐ LƯỢNG PHẦN TỬ LỚN HƠN 30
        // int kq2 = Method.DemSoLonHon30(lstnumber);
        // int kq2 = Method.DemSoLonHon30C2(lstnumber);
        // Console.WriteLine($"2 . Đếm số lượng phần tử lớn hơn 30 trong lstNumber là : {kq2}");
        // Console.WriteLine("_________________________");

        //3. Tìm số lớn nhất trong danh sách
        // int kq3 = Method.DemSoLonHon30C2(lstnumber);
        // Console.WriteLine($"3 . Tìm số lớn nhất trong lstNumber là : {kq3}");
        // Console.WriteLine("_________________________");

        // 4. Tính trung bình cộng của các số lẻ
        // double kq4 = Method.TrungBinhCongSoLe(lstnumber);
        // double kq4c2 = Method.TrungBinhCongSoLeC2(lstnumber);
        // Console.WriteLine($"4.Trung bình các số lẻ trong lstNumber là : {kq4}");
        // Console.WriteLine($"4.Trung bình các số lẻ trong lstNumber là : {kq4c2}");
        // Console.WriteLine("_________________________");
        //In ra các số chẵn trong danh sách
        // lấy ra ds cách số chẳn -> in ra
        // Console.WriteLine("5. Danh sách các số chẳng trong lstNumber là: ");
        // string kq5 = Method.DanhSachSoChan(lstnumber);
        // List<int> kq5c2 = Method.DanhSachSoChanC2(lstnumber);
        // var k5c3 = Method.DanhSachSoChanC3(lstnumber);
        // Console.WriteLine($"5. Danh sách số chẳn trong lstNumber là : {kq5}");
        // Console.WriteLine($"5. Danh sách số chẳn trong lstNumber là : ");
        // kq5c2.ForEach(Console.WriteLine);
        // Console.WriteLine("_________________________");
        // 6.
        // Console.WriteLine($"6. Tìm vị trí đầu tiên của số 20 trong danh sách : {Method.TimViTriDauTien(lstnumber)}");
        // Console.WriteLine($"7. Tìm số lượng phần tử bằng 15 trong danh sách : {Method.SoLuongPhanTuBang15(lstnumber)}");
        // Console.WriteLine($"8. Tính tổng các số nhỏ hơn 40 : {Method.TongBeHon40(lstnumber)}");
        // Console.WriteLine($"9. Đếm số lượng các số chia hết cho 5 : {Method.DemSoChiaHetCho5(lstnumber)}");
        // var kq10 = Method.DSNHoHon50(lstnumber);
        // Console.WriteLine($"10. Tạo danh sách mới chỉ chứa các số nhỏ hơn 50 : ");
        // kq10.ForEach(Console.WriteLine);


        //BUILD lại theo dạng menu
        // viết menu in hêt các chức năng có trong bài toan
        int chon = -1;
        while (chon != 0)
        {
            Console.WriteLine("______________________________________________________________");
            Console.WriteLine("____________________________MENU______________________________");
            Console.WriteLine("| 1. Tính tổng các số lớn hơn 50 trong danh sách             |");
            Console.WriteLine("| 2. Đếm số lượng phần tử lớn hơn 30 trong lstNumber là      |");
            Console.WriteLine("| 3. Tìm số lớn nhất trong danh sách                         |");
            Console.WriteLine("| 4. Tính trung bình cộng của các số lẻ                      |");
            Console.WriteLine("| 5. In ra các số chẵn trong danh sách                       |");
            Console.WriteLine("| 6. Tìm vị trí đầu tiên của số 20 trong danh sách           |");
            Console.WriteLine("| 7. Tìm số lượng phần tử bằng 15 trong danh sách            |");
            Console.WriteLine("| 8. Tính tổng các số nhỏ hơn 40                             |");
            Console.WriteLine("| 9. Đếm số lượng các số chia hết cho 5                      |");
            Console.WriteLine("| 10. Tạo danh sách mới chỉ chứa các số nhỏ hơn 50           |");
            Console.WriteLine("| 11. Tìm 2 số có tổng bằng taget                            |");
            Console.WriteLine("| 0. Thoát                                                   |");
            Console.WriteLine("______________________________________________________________");

            // cho ngdung nhập số
            Console.Write("Chọn chức năng: ");
            chon = int.Parse(Console.ReadLine());

            // có giá trị là số từ 1 -> 10
            switch (chon)
            {
                case 1:
                    int kqcase1 = Method.TinhTongLonHon50C2(lstnumber);
                    Console.WriteLine($"1 . Tổng các số lơn hơn 50 trong lstNumber là : {kqcase1}");
                    break;
                case 2:
                    int kq2 = Method.DemSoLonHon30C2(lstnumber);
                    Console.WriteLine($"2 . Đếm số lượng phần tử lớn hơn 30 trong lstNumber là : {kq2}");
                    Console.WriteLine("_________________________"); break;
                case 3:
                    int kq3 = Method.TimSoLonNhat(lstnumber);
                    Console.WriteLine($"3 . Tìm số lớn nhất trong lstNumber là : {kq3}");
                    Console.WriteLine("_________________________"); break;
                case 4:
                    double kq4 = Method.TrungBinhCongSoLeC2(lstnumber);
                    Console.WriteLine($"4.Trung bình các số lẻ trong lstNumber là : {kq4}");
                    Console.WriteLine("_________________________"); break;
                case 5:
                    string kq5 = Method.DanhSachSoChan(lstnumber);
                    Console.WriteLine($"5. Danh sách số chẳn trong lstNumber là : {kq5}");
                    Console.WriteLine("_________________________"); break;
                case 6:
                    Console.WriteLine($"6. Tìm vị trí đầu tiên của số 20 trong danh sách : {Method.TimViTriDauTien(lstnumber)}");
                    break;
                case 7:
                    Console.WriteLine($"7. Tìm số lượng phần tử bằng 15 trong danh sách : {Method.SoLuongPhanTuBang15(lstnumber)}");
                    break;
                case 8:
                    Console.WriteLine($"8. Tính tổng các số nhỏ hơn 40 : {Method.TongBeHon40(lstnumber)}");
                    break;
                case 9:
                    Console.WriteLine($"9. Đếm số lượng các số chia hết cho 5 : {Method.DemSoChiaHetCho5(lstnumber)}");
                    break;
                case 10:
                    var kq10 = Method.DSNHoHon50(lstnumber);
                    Console.WriteLine($"10. Tạo danh sách mới chỉ chứa các số nhỏ hơn 50 : ");
                    kq10.ForEach(Console.WriteLine);
                    break;
                case 11:
                    Console.WriteLine("11. Tìm 2 số có tổng bằng taget");
                    // gọi function
                    List<int> lst11 = new List<int>{2,7,11,15};
                    var res11 = Method.TimHaiSo(lst11,18);
                    //[vị trí 1, vị trí 2]
                    Console.WriteLine($"[{res11[0]}, {res11[1]}]");

                    break;
                case 0:
                    Console.WriteLine("Thoát chương trình");
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
        }
        // chọn số -> show kết quả
        // tiếp tục hiện menu -> chọn chức năng-> 
        // người ta chọn số 0 thì mới kết thúc

    }
}