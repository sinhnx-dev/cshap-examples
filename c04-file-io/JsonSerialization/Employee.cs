public class Employee
{
    public string EmpId { set; get; }
    public string Name { get; set; }
    public int Salary { get; set; }
    public Department EmpDepartment { get; set; }
    public Employee()
    {
        EmpId = "id";
        Name = "";
        Salary = 0;
        EmpDepartment = new Department();
    }
    public override string ToString()
    {
        return $"{EmpId} - {Name} - {EmpDepartment.DepartmentName}";
    }
}