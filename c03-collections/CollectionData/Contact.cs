namespace CollectionData;
public class Contact : IComparable {
    public string FirstName {set;get;}
    public string MiddleName {set;get;}
    public string LastName {set;get;}
    public Contact(){
        FirstName = "";
        MiddleName = "";
        LastName = "";
    }
    public string FullName{
        get { 
            return $"{FirstName} {MiddleName} {LastName}".Trim();
        }
    }
    public override string ToString()
    {
        return FullName;
    }
    public override bool Equals(object? obj)
    {
        if(obj == null || !(obj is Contact)){
            return false;
        }
        return this.FullName.Equals(((Contact)obj).FullName);
    }
    public override int GetHashCode()
    {
        return this.FullName.GetHashCode();
    }

    public int CompareTo(object? obj){
        if(obj == null || !(obj is Contact)){
            return 0;
        }
        return this.FullName.CompareTo(((Contact)obj).FullName);
    }
}