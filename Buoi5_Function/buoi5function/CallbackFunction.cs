class CallbackFunction{
    // Callback function là gì? 
    // hàm gọi lại 
    //Là một hàm được truyền vào function khác như 1 tham số -> sau đó được gọi lại
    // nhận vào 1 số và 1 funtion in ra kết quả
    public static void XuLyKetQua(int a, Action<double> callbackFn){
        // tính bình phương a
        // double kq = a*a;

        double kq = Math.Pow(a,2);
        // gọi lại callbackFn
        callbackFn(kq);
    }
    // public static void inKetQua(double kq){
    //     Console.WriteLine($"Kết quả là : {kq}");
    // }

    // viết function nhận vào 1 số và function có return  Func<int ,int> 
    public static int XuLy2(int a,Func<int,int> callback){
        //gọi lại callcack nhận vào số a
        return callback(a);
    }

}