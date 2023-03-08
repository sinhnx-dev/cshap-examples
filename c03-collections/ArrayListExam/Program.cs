using CollectionData;

System.Collections.ArrayList al = new System.Collections.ArrayList();
al.Add(new Contact(){ 
    FirstName = "A",
    MiddleName = "Van",
    LastName = "Nguyen"
});
al.Add(new Contact(){ 
    FirstName = "X",
    MiddleName = "Van",
    LastName = "Tran"
});
al.Add(new Contact(){ 
    FirstName = "A",
    MiddleName = "Van",
    LastName = "Tran"
});
al.Add(new Contact(){ 
    FirstName = "D",
    MiddleName = "Van",
    LastName = "Hoang"
});
foreach(var e in al){
    Console.WriteLine(e);
}

Contact c = new Contact(){ 
    FirstName = "A",
    MiddleName = "Van",
    LastName = "Tran"
};
Console.WriteLine($"Index Of c in al: {al.IndexOf(c)}");

Console.WriteLine("Sort By FullName: ");
//sort by FullName with CompareTo() method in Contact class
al.Sort();
foreach(var e in al){
    Console.WriteLine(e);
}

Console.WriteLine("Sort By LastName: ");
al.Sort(new ContactLastNameSorter());
foreach(var e in al){
    Console.WriteLine(e);
}