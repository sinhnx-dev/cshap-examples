public class OctalObserver : MyObserver
{
  public OctalObserver(Subject subject)
  {
    this.MyObserverSubject = subject;
    this.MyObserverSubject.Attach(this);
  }

  public override void Update()
  {
    Console.WriteLine("Octal String: " + Convert.ToString(MyObserverSubject.State, 8));
  }
}