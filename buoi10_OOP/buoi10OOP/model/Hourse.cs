using System;

class House
{
    public string Door = "Cửa chính" ;// Ai cũng thấy được - dùng được ở bất kỳ đâu
    private string Safe = "Két sắt"; // Chỉ chủ nhà biết - chỉ dùng được trong lớp House
    protected string Bedroom = "Phòng ngủ"; // Con cháu mới được vào - dùng được trong lớp House và lớp kế thừa
    internal string Garden = "Vườn"; // Người trong xóm mới thấy - dùng được trong cùng 1 project
    protected internal string Garage = "Gara"; // Người trong xóm hoặc con cháu - dùng được trong cùng 1 project và lớp kế thừa
    private protected string SecretPassage = "Lối đi bí mật"; // Chỉ con cháu trong nhà (cùng project) - dùng được trong lớp kế thừa  cùng 1 project

    public string GetSafe()
    {
        return Safe;
    }

    public void SetSafe(string safe)
    {
        this.Safe = safe;
    }
    public void SetBedroom(string bedroom)
    {
        this.Bedroom = bedroom;
    }
    public void SetSecretPassage(string secretPassage)
    {
        SecretPassage = secretPassage;
    }
    
    public void ShowHouse()
    {
        Console.WriteLine($"1. {Door}");
        Console.WriteLine($"2. {Safe}");
        Console.WriteLine($"3. {Bedroom}");
        Console.WriteLine($"4. {Garden}");
        Console.WriteLine($"5. {Garage}");
        Console.WriteLine($"6. {SecretPassage}");
    }
}
