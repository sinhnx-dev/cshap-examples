//object is root class
public class Contact : object
{
    public string FirstName { set; get; }
    public string? MiddleName { set; get; }
    public string LastName { set; get; }
    public virtual string FullName
    {
        get
        {
            return $"{FirstName} {MiddleName ?? ""} {LastName}".Trim();
        }
    }
    public string? Email { set; get; }
    public string TelephoneNo { set; get; }
    public string Address { set; get; }
    public string? Note { set; get; }

    // public Contact(){
    //     FirstName = "";
    //     LastName = "";
    //     TelephoneNo = "";
    //     Address = "";
    // }

    public Contact(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
        TelephoneNo = "";
        Address = "";
    }

    public string GetInfo()
    {
        return $"{FullName} - {TelephoneNo}";
    }
}