public class Task
{
    // quản lý tưng đối tượng
    // Thuộc tính
    public string Ten;
    public bool TrangThai;  // chỉ có pending và done : bool
                            // new ,pending, done, cancel,

    // Contructor
    // .. contructor  nhận vào tham số là ten 
    // true = done , false = pending
    public Task(string ten)
    {
        Ten = ten;
        TrangThai = false;
    }
    public void ShowInfor(int i)
    {
        // cw ra tên - trạng thái
        string status = TrangThai ? "Done" : "Pending";
        Console.WriteLine($"{i} : {Ten} - {status}");
    }



}