public class Department
{
    public string DepartmentId { set; get; }
    public string DepartmentName { set; get; }
    public string? Note { set; get; }
    public Department()
    {
        DepartmentId = "";
        DepartmentName = "no name";
    }
}