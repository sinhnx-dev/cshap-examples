using CollectionData;
//List Demo
List<Contact> lst = new List<Contact>();

lst.Add(new Contact(){ 
    FirstName = "A",
    MiddleName = "Van",
    LastName = "Nguyen"
});
lst.Add(new Contact(){ 
    FirstName = "X",
    MiddleName = "Van",
    LastName = "Tran"
});
lst.Add(new Contact(){ 
    FirstName = "A",
    MiddleName = "Van",
    LastName = "Tran"
});
lst.Add(new Contact(){ 
    FirstName = "D",
    MiddleName = "Van",
    LastName = "Hoang"
});
foreach(var e in lst){
    Console.WriteLine(e);
}

Contact c = new Contact(){ 
    FirstName = "A",
    MiddleName = "Van",
    LastName = "Tran"
};
Console.WriteLine($"Index Of c in lst: {lst.IndexOf(c)}");

Console.WriteLine("Sort By FullName: ");
//sort by FullName with CompareTo() method in Contact class
lst.Sort();
foreach(var e in lst){
    Console.WriteLine(e);
}

Console.WriteLine("Sort By LastName: ");
lst.Sort((c1, c2) => c1.LastName.CompareTo(c2.LastName));
foreach(var e in lst){
    Console.WriteLine(e);
}