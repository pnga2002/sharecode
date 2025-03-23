class BaiTap5
{
    // Giải bài tập 5
    //Đảo từ trong chuỗi
    public static string DaoNguoc(string s)
    {
        string ketQua = "";
        /*
        Hello con gà
        Hello_
        olleH noc àg
        khi gặp khoảng trắng thì đảo từ và reset từ tạm

        duyêt qua từng ký từ để lấy được từ hoàn chỉnh Hello => gặp khoảng trắng
        - Tiến hành đảo từ đó -> reset từ tam =""
        - đến từ cuối cùng thì không gặp trắng nên word = tưef cuối cùng và rời khỏi vòng lặp
        - Cần đảo ngược từ cuối cùng này và cộng vào kết quả

        */
        string word = "";
        foreach (char c in s)
        {
            if (c == ' ')
            {
                // string wordRe = "";
                // // lúc này có hetừ hello rồi -> đảo ngược
                // foreach (char a in word)
                // {
                //     wordRe = a + wordRe;// oÏlleH
                // }
                ketQua += $"{DaoTu(word)} ";
                // sau đó reset
                word = "";

            }
            else
            {
                word += c; //Hello
            }
        }
        // thoát vòng lặp rồi thì word chứa từ cuối cùng 
        ketQua += $"{DaoTu(word)} ";
        return ketQua;
    }
    static string DaoTu(string text){
        string kq="";
         foreach (char a in text)
        {
            kq = a + kq;// oÏlleH
        }
        return kq;
    }

}