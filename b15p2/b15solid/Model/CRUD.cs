using System.Reflection;

// thêm ràng buộc để nó chỉ nhân class
// CRUD<T> : nó nhận vào tất cả các kiểu dữ liệu
//CRUD<T> where T : class : nhận vào tất cả các kiểu dữ liệu là class , tham chiếu (string , class, interface.....)
// CRUD<T> where T : IBlindBox : chỉ nhận vào các kiểu dữ liệu đối tượng thực thi Iblindbox)
public class CRUD<T> where T : IBlindBox // ràng buộc kiểu dữ liệu T là class
{ // CRUD 

    // danh sách lưu trữ nhiều đối tượng T
    List<T> ds = new List<T>();
    // quản lý danh sách T : với T là kiểu dự liệu tổng quát
    // Add
    public void Add(T item)// nhậ vào đối tượng có kdl là T
    {
        ds.Add(item); // thêm vào danh sách 
    }
    // Read : duyệt qua danh sách và in ra thuộc tính của T
    public void ShowDS()
    {
        // lấy ra ds properties của T
        PropertyInfo[] props = typeof(T).GetProperties(); // lấy ra danh sách thuộc tính của T
        foreach (T item in ds) // khắc phục lại -> duuyệt qua từng thuộc tính của T để in ra giá trị tương ứng
        {

            //dynamic
            // Console.WriteLine($"ID: {((dynamic)item).Id}");
            // môic item sẽ có các thuộc tính của T
            foreach (PropertyInfo prop in props) // duyệt qua từng thuộc tính của T: props
            {
                 Console.Write($"{prop.Name} - {prop.GetValue(item)} | ");// mõi dòng này là đại diện 1 thuộc tính của T
                // prop.Name: tên thuộc tính
                // prop.GetValue(item): lấy ra giá trị của thuộc tinh prop thuộc đối tượng item
                // item đối tương (phần từ của ds) của ds đang duyệt
            }
            Console.WriteLine("");
        }
    }

    // Update 

    // Find

    public T Find(int id)
    {
        dynamic newitem = Activator.CreateInstance(typeof(T)); // tạo ra 1 đối tượng mới có kiểu dữ liệu là T
        //dynamic
        T? item = ds.Find(x => ((dynamic)x).Id == id); //=> có phần tử tương ứng dk thì trả về cho item : null
        // tìm kiếm trong danh sách ds
        return item;
    }

    // Delete


}