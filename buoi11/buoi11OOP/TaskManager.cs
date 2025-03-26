public class TaskManager
{
    // list
    private List<Task> lst = new List<Task>();// khởi tạo 1 danh sách Task rỗng 

    // 3 function
    // Thêm 
    // tạo function
    // khởi tạo Task tuyền vào tên task được người dùng nhập 
    // thông qua contructor đã viết ở task
    // b1: nhập tên task
    // b2: tạo Task bằng contructor
    // b3: lst  thêm task vừa tạo vào
    public void Add()
    {
        Console.WriteLine("________________");

        // b1
        Console.Write("Nhập tên task: ");
        string tenTask = Console.ReadLine();
        // b2:
        Task t = new Task(tenTask); // lúc này có dc 1 đối tượng t : Task
        // b3:  thêm vào list
        lst.Add(t);
        Console.WriteLine("Thêm thành công");
    }

    // Hiển thị
    //Duyệt vòng lặp qua list 
    // dùng hàm show infor của Task để hiển thị danh sách
    public void HienThi()
    {
        Console.WriteLine("________________");

        // hiển thị các task trong lst
        for (int i = 0; i < lst.Count(); i++)
        {
            lst[i].ShowInfor(i + 1);
        }
    }


    //Cập nhật task
    //  cho user chọn số là update trạn thái cho task tương ứng
    public void Update()
    {
        // kiểm tra lỗi , nếu nhập < 1 hoặc lớn hơn count của lst thì thông báo lỗi

        Console.WriteLine("________________");
        // show danh sách để chọn
        HienThi();
        //1 ăn sang //0
        //2 ăn trưa //1 = n-1
        //chọn , nhập vào số n tương ứng
        Console.Write("Hãy chọn task cần update");
        int n = int.Parse(Console.ReadLine());
        // nếu nhập số 2 thì cần số index = 2 -1
        lst[n - 1].TrangThai = true;
        Console.WriteLine("Đã update thành công");
    }

}