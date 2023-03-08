public class Bird : Animal, IFly
{
    public override string MakeSound()
    {
        return "bird sound";
    }
    public string Fly()
    {
        return "Bird is flying...";
    }
}