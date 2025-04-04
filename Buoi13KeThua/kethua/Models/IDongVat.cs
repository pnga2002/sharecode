public interface IDongVat
{
    void Keu();
}

public class Cho : IDongVat
{
    public void Keu()
    {
        Console.WriteLine("Gâu gâu");
    }
}
public class Meo : IDongVat
{
    public void Keu()
    {
        Console.WriteLine("Meo meo");
    }
}
public class Ga : IDongVat
{
    public void Keu()
    {
        Console.WriteLine("Cục tác");
    }
}
public class Heo : IDongVat
{
    public void Keu()
    {
        Console.WriteLine("Út út");
    }
}