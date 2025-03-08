class BaiTap1
{
    // có các function  xử lý tinhs toán cho bài 1
    //nhập điểm, tính trung bình và trả ra xếp loai
    // gom hết vào 1 hàm 
    // tách ra làm 2 : 1 tính điểm trung bình, kiểm tra kết quả(so sánh để return đúng )
    // nhập vào điểm toán lý hoá -> return điểm trung bình
    // gõ ba dấu /// là tự ra 
    /// <summary>
    /// sTính điểm trung bình của 3 môn toán lý hoá
    /// </summary>
    /// <param name="toan">điểm toán</param>
    /// <param name="ly">điểm lý</param>
    /// <param name="hoa">điểm hoá</param>
    /// <returns>return điểm trung bình</returns>
    public static double tinhDTB(double toan, double ly, double hoa)
    {
        //khai báo ra biến kết quả 
        double kq;
        //xử lý tính toán
        kq = (toan + ly + hoa) / 3;
        // trả ra kết quả
        return Math.Round(kq,2);
    }

    //Xếp loại học sinh: nhập vào điểm trung bình -> string 
    // function có tham số và có return
    /// <summary>
    /// Xếp loại dựa vào điểm trung bình
    /// </summary>
    /// <param name="dtb"></param>
    /// <returns>chuỗi xếp loại</returns>
    public static string xepLoai(double dtb)
    {
        string kq = "";
        if (dtb >= 8 && dtb <= 10)
        {
            kq = $"{dtb} điểm - Xếp loại giỏi";
        }
        else if (dtb >= 6.5)
        {
            kq = $"{dtb} điểm - Xếp loại khá";
        }
        else if (dtb >= 5)
        {
            kq = $"{dtb} điểm - Xếp loại Trung bình";
        }
        else
        {
            kq = $"{dtb} điểm - Xếp loại Yếu";

        }
        return kq;
    }

}