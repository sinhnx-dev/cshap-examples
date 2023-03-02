Author author = new Author("Nguyen Van A", "anv1121@vtc.edu.vn", 'M');
Book b = new Book("C# programming", author, 120000);

Console.WriteLine($"Ten sach: {b.Name}");
Console.WriteLine($"Tac gia:  {b.BookAuthor}");
Console.WriteLine($"Gia sach: {b.Price}");

Book b2 = new Book()
{
    Name = "C Programming",
    BookAuthor = new Author()
    {
        Name = "Tran Van B",
        Email = "btv@vtc.edu.vn",
        Gender = 'M'
    },
    Price = 150000,
    QuantityInStock = 100
};
Console.WriteLine($"Ten sach: {b2.Name}");
Console.WriteLine($"Tac gia:  {b2.BookAuthor}");
Console.WriteLine($"Gia sach: {b2.Price}");