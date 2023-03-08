public class Student : Contact
{
    public string StudentId { set; get; }
    public override string FullName
    {
        get
        {
            return $"Student: {base.FullName}";
        }
    }

    //constructor inheritance:
    public Student() : base("", "")
    {
        StudentId = "";
    }

    //constructor inheritance:
    public Student(string firstName, string lastName) :
        base(firstName, lastName)
    {
        StudentId = "";
    }

    new public string GetInfo()
    {
        return $"Student Info: {FullName} - {TelephoneNo}";
    }
}