//can't create object -> error
// Animal c = new Animal();

Animal c = new Cat();
Console.WriteLine($"c.MakeSound() -> {c.MakeSound()}");

Animal d = new Dog();
Console.WriteLine($"d.MakeSound() -> {d.MakeSound()}");

IFly p = new Plane();
Console.WriteLine($"p.Fly() -> {p.Fly()}");

Animal b = new Bird();
Console.WriteLine($"b.MakeSound() -> {b.MakeSound()}");
if (b is IFly)
{
    Console.WriteLine($"b.Fly() -> {((IFly)b).Fly()}");
}