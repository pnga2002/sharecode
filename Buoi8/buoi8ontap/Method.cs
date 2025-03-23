class Method
{
    //1. Tính tổng các cố lớn hơn 50
    public static int TinhTongLonHon50(List<int> lst)
    {
        int kq = 0;
        // tông các số lớn hơn 50 
        foreach (int a in lst)
        {
            if (a > 50)
            {
                kq += a;
            }
        }
        return kq;
    }
    //Cách 2: 
    //kiểm tra và lấy ra những số lớn hơn 50 ==> 
    //
    public static int TinhTongLonHon50C2(List<int> lst) => lst.Where(a => a > 50).Sum();
    // public static int TinhTongLonHon50C2(List<int> lst){
    //     var lstfind = lst.Where(a => a > 50);
    //     return lstfind.Sum();
    // }


    //2. ĐẾM SỐ PHẦN TỬ LỚN HƠN 30
    public static int DemSoLonHon30(List<int> lst)
    {
        //function scope
        int kq = 0;
        // viêt vòng lặp kiểm tra các số lớn hơn 30
        foreach (int a in lst)
        {
            if (a > 30)
            {
                kq++;// kq=kq+1 | kq+=1
            }
        }
        return kq;
    }
    //lst.Where(a => a > 30): lấy ra danh sách các số lớn hơn 30
    public static int DemSoLonHon30C2(List<int> lst) => lst.Where(a => a > 30).Count();

    // 3 .  Tìm số lớn nhất trong danh sách 
    // 2 cách 
    // MAX 
    public static int TimSoLonNhat(List<int> lst)
    {
        // 4 6 8 2 9 8
        int max = lst[0];
        //lần 2 6> max - (4) đổi max=6
        //lần 3 8 > max - (6) đổi max = 8;
        // lần 4 2< max - (8) không đổi
        //lần 5 
        //lần n hết thì thôi
        //chạy vòng lặp kiểm tra 
        foreach (int a in lst)
        {
            if (a > max)
            {
                max = a;
            }
        }
        return max;
    }
    public static int TimSoLonNhatC2(List<int> lst) => lst.Max();

    //TÍNH TRUNG BÌNH CỘNG CÁC SỐ LẺ
    public static double TrungBinhCongSoLe(List<int> lst)
    {
        double kq = 0;
        // duyeetj vòng lặp tìm ra số lẻ
        // tính tổng, đếm số lượng
        //  tính trung bình cộng
        int tong = 0;
        int count = 0;
        foreach (int a in lst)
        {
            if (a % 2 != 0)
            {
                //thì là số lẻ
                tong += a;
                count++;// count = count +1 || count +=1
            }
        }
        kq = (double)tong / count;
        return kq;
    }
    // lấy ra danh sách các số lẻ -> tính trung bình
    //lst.Where(a => a % 2 !=0 ): lấy ra danh sách số lẻ
    public static double TrungBinhCongSoLeC2(List<int> lst) => lst.Where(a => a % 2 != 0).Average();


    // 5: Danh sách cá số chẳn
    // nhận vào 1 list và trả chuỗi hay là trả ra 1 list??
    // trả về chuỗi
    public static string DanhSachSoChan(List<int> lst)
    {
        string kq = "";
        foreach (int a in lst)
        {
            if (a % 2 == 0)
            {
                kq += $"{a} ";
            }
        }
        return kq;
    }
    //return về List<int>
    public static List<int> DanhSachSoChanC2(List<int> lst)
    {
        // string kq =""
        List<int> kq = new List<int>();
        foreach (int a in lst)
        {
            if (a % 2 == 0)
            {
                kq.Add(a);
            }
        }
        return kq;
    }
    // ngắn gọn dùng hàm có sẵn của list
    public static List<int> DanhSachSoChanC3(List<int> lst) => lst.FindAll(a => a % 2 == 0);


    //6. Tìm vị trí đầu tiên của số 20 trong danh sách
    // tìm vị trí đầu tiên thoả điều kiện : 
    public static int TimViTriDauTien(List<int> lst) => lst.FindIndex(a => a == 20);

    // 7. Tìm số lượng phần tử bằng 15 trong danh sách
    // số lương :int  Tìm ra danh sách các phần từ =15 -> đếm
    public static int SoLuongPhanTuBang15(List<int> lst) => lst.Where(a => a == 15).Count();
    //8. Tính tổng các số nhỏ hơn 40
    public static int TongBeHon40(List<int> lst) => lst.Where(a => a < 40).Sum();
    //9. Đếm số lượng các số chia hết cho 5
    public static int DemSoChiaHetCho5(List<int> lst) => lst.Where(a => a % 5 == 0).Count();
    //10. Tạo danh sách mới chỉ chứa các số nhỏ hơn 50
    public static List<int> DSNHoHon50(List<int> lst) => lst.Where(a => a < 50).ToList();

    //11. Tìm 2 số có tổng bằng target
    //nhận vào List<int> và target = n
    // kiểm tra xem trong list có 2 số nào cộng lại băng target hay không và trả về vị trí
    // [2 , 7, 11, 15] n=9
    // 9 - 2 = 7       lưu vào dict với key =7 và value là index của 7 // để mình timf xem 
    // 9 - 7 = 2
    // 9 - 11 = -2
    // 9 - 15 = -6
    // chạy từ 0 vì index của list bắt đầu bằng 0 
    public static List<int> TimHaiSo(List<int> lst, int target)
    {
        // string a = "";
        // a.ToLower()
        // ví dụ taget = 9
        // mình cần 1 dict để lưu trữ các số và vị trí tương ứng
        Dictionary<int,int>  dict = new Dictionary<int, int>(); // dict rỗng
        //xử lý : duyệt qua từng giá trị của list
        for (int i = 0; i < lst.Count(); i++)
        {
            //L1: 2
            //l2: 7
            // bù 
            // //
            int hieuTagrget  = target - lst[i]; // 2
            //tìm xem dict có số lst[i] hay không, 
            if(dict.ContainsKey(hieuTagrget)){
                // có thi mình return về và vị trí của số trong dict tương ứng & vị trí sô hiện tại 
                // [{0,2}]
                // nếu lưu key =vị trí và value =giá trị của số thì khhi mình muốn lấy vị trí 
                // lấy key tại value -> 
                //số 2 đó và số 7 hiện tại cộng lại bằng 9
                // ->  lấy ra index của 2 và của 7
                return new List<int>{dict[hieuTagrget],i};
            }
            // nếu không có
            else{
                dict.Add(lst[i],i); //{2,0} 
            }
            
        }
        return new List<int>{-1,-1};
    }
}
