class Method
{

    // Tìm chuỗi con liên tục dài nhất
    // nhận vào 1 list 
    // trả ra hashset vì cần chuỗi con liên tục dài nhât (không trùng)
    public static int ChuoiConLienTuc(List<int> lst)
    {
        // đưa lst về hashset để loại bỏ số trùng nhau
        HashSet<int> nums = new HashSet<int>(lst);
        //[2 , 15, 14, 13, 12, 11,10 ]
        //mình chưa có 
        // đếm đươc 2
        // 13 thì đếm dc 
        //12 => 4
        // duyệt hashet
        int longChuoi = 0;
        foreach (int number in nums)
        {
            // kiểm tra nếu number là phần tử đầu tiên của chuỗi liên tiếp (number )
                // khởi tạo biến lưu số hiện tại và độ dài của chuỗi liên tiếp
                int curent  = number; //L1 2
                int currentChuoi = 1;
                while(nums.Contains(curent+1)){ 
                    // nếu có số 3 tăng đếm lên +1, và tăng curent lên 1 nữa
                    //nếu có 4  ...
                    //không có thì thôi
                        currentChuoi+=1;
                        curent+=1;
                }
                // nếu như độ dài mới của chuỗi liên tiếp lớn hơn longChuoi thì gán nó vào longChuoi
                longChuoi = Math.Max(currentChuoi,longChuoi); // 2 ,4 => longChuoi = 4
        }
        return longChuoi;
    }
}