public abstract class Animal
{
    //property
    public string Name { set; get; }
    //constructor
    public Animal()
    {
        Name = "no name";
    }

    //define abstract method
    public abstract string MakeSound();
}