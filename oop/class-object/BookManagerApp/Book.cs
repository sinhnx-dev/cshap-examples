public class Book{
    public string Name {set;get;}
    public Author BookAuthor {set;get;}
    public int QuantityInStock {set;get;}
    public double Price {set;get;}

    public Book(){
      Name = "no name";
      BookAuthor = new Author();
    }
    public Book(string name, Author author, double price){
        Name = name;
        BookAuthor = author;
        Price = price;
    }
    public Book(string name, Author author, double price, int quantityInStock){
        Name = name;
        BookAuthor = author;
        Price = price;
        QuantityInStock = quantityInStock;
    }
}