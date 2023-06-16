public class HexaObserver : MyObserver
{
  public HexaObserver(Subject subject)
  {
    this.MyObserverSubject = subject;
    this.MyObserverSubject.Attach(this);
  }

  public override void Update()
  {
    Console.WriteLine("Hexa String: " + Convert.ToString(MyObserverSubject.State, 16));
  }
}