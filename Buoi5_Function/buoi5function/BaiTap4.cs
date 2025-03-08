class BaiTap4
{
    // trường hợp trả về 0 . VD: "    "
    // "hello các bạn nhé" -> 3
    // tìm kí tự đầu tiên trong chuỗi firstindexof, lastindexof
    // tìm ký tự " " cuối 
    // substring cắt chuỗi từ vị trí tìm dc đến độ dài của chuỗi
//  biến global scope
    public static string mytext="Đây là code của Phú nè";
    public static int LenghtOfLast(string chuoi)
    {
        //xử lý
        // "   hello      nha nha     "
        //                   789
        //leng =10
        // last = 4
        //5->56789 
        //Trim() loại bỏ khoảng trắng đầu và cuối 
        //chuoiTrim, lastSpace ,... mình chỉ dùng được trong function này mà thôi
        // function scope
        string chuoiTrim = chuoi.Trim();
        int lastSpace = chuoiTrim.LastIndexOf(" ");
        string text = chuoiTrim.Substring(lastSpace + 1, chuoiTrim.Length - 1 - lastSpace);
        Console.WriteLine(text);
        Console.WriteLine(text.Length);
        Console.WriteLine($"{mytext}");

        return text.Length;
    }

    // Hello người đẹp 
    // 123450123450123
    public static int LastIndexOf2(string chuoi)
    {
        mytext="";
        int count = 0;
        foreach (var c in chuoi)
        {
            if (c == ' ')
            {
                //reset count về 0 để đếm lại từ đầu
                count = 0;
                continue;
            }
            else
            {

                count++;
            }
        }
        return count;
    }

}