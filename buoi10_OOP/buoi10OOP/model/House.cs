class House
{
    //STATIC 
    public static int Count; // có vẻ giống thuộc tính
    public string Door; // ai cũng nhìn thấy được -  dùng được

    private string Key; // chỉ có người trong nhà mới biết

    protected string Money; // người trong nhà và con cháu 

    internal string ThangMay; // trong xóm/ dự án có thể dùng được
    protected internal string Gara; // trong xóm/ dự án và con cháu
    private protected string LoiDiBiMat; // con cháu trong cùng xóm/ dự án
    

    // Phương thức trung gian để truy cập get(Lấy) và set(Gán) giá trị cho Key
    //Set
    public void SetKey(string newKey){
        Key = newKey;
    }
    //get - lấy giá trịß
    public string GetKey(){
        return Key;
    }
    // hành vi / phương thức
    // show thông tin
    public void ShowInfor(){
        Console.WriteLine("______________");
        Console.WriteLine($"- {Door}");
        Console.WriteLine($"- {Key}");
        Console.WriteLine($"- {Money}");
        Console.WriteLine($"- {ThangMay}");
        Console.WriteLine($"- {Gara}");
        Console.WriteLine($"- {LoiDiBiMat}");
    }

    // CONTRUCTOR 
    // không có tham số
    public House(){
        Door="Cửa df";
        Key="Key df";
        Gara="Gara df";
        Count++;
    }

    // có tham số
    public House (string door, string key){
        Door = door;
        Key = key;
        Count++;// dùng static làm biến đếm
    }
    public House (string door, int key){
        Door = door;
        // Key = key+"";
        Key = Convert.ToString(key);
        Count++;
    }
    public House (string door, string key,string gara){
        Door = door;
        Key = key;
        Gara = gara;
        Count++;

    }



}