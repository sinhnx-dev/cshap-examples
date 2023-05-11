using System.Text.Json;

Employee employee = new Employee
{
    Name = "SinhNX",
    Salary = 1000,
    EmpDepartment = new Department()
    {
        DepartmentId = "MKT",
        DepartmentName = "Marketing"
    }
};

string jsonString = JsonSerializer.Serialize(employee);
Console.WriteLine(jsonString);
