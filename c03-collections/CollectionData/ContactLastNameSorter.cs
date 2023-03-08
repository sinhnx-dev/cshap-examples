namespace CollectionData;
public class ContactLastNameSorter : System.Collections.IComparer
{
    public int Compare(object? obj1, object? obj2)
    {
        if(obj1 != null && obj2 != null &&
            obj1 is Contact && obj2 is Contact)
        {
            Contact c1 = (Contact)obj1;
            Contact c2 = (Contact)obj2;
            return c1.LastName.CompareTo(c2.LastName);
        }
        return 0;
    }
}