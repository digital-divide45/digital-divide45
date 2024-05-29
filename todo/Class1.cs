public class Task
{
    public DateTime Date { get; set; }  //入力日
    public DateTime DueDate { get; set; }  //タスクの期日
    public string Description { get; set; }  //タスクの内容

    public string DescriptionAndDueDate
    {
        get { return $"{DueDate.ToShortDateString()} - {Description}"; }
    }
}