Contact c = new Contact("Nam", "Nguyen");

Student s = new Student();
s.FirstName = "SV";
s.LastName = "Nguyen";
s.StudentId = "0123456789";
Console.WriteLine($"Full Name: {s.FullName}");

Faculty f = new Faculty();
f.FirstName = "F";
f.LastName = "Tran";
f.Subjects = "C, OOP, C#, MySQL, OOAD";
Console.WriteLine($"Faculty Full Name: {f.FullName}");

Contact cs = new Student()
{
    FirstName = "Nam",
    LastName = "Le",
    TelephoneNo = "012346789"
};
Console.WriteLine($"cs.FullName = {cs.FullName}");
Console.WriteLine(cs.GetInfo());
Student ss = new Student()
{
    FirstName = "Nam",
    LastName = "Le",
    TelephoneNo = "012346789"
};
Console.WriteLine($"ss.FullName = {ss.FullName}");
Console.WriteLine(ss.GetInfo());