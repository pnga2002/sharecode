public class TaskItem
{
    public string Title { get; set; }
    public bool IsCompleted { get; set; }

    public TaskItem(string title)
    {
        Title = title;
        IsCompleted = false;
    }

    public override string ToString()
    {
        string status = IsCompleted ? "Done" : "Pending";
        return $"{Title} - {status}";
    }
}
