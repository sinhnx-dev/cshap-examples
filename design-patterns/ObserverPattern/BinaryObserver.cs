public class BinaryObserver : MyObserver
{
  public BinaryObserver(Subject subject)
  {
    this.MyObserverSubject = subject;
    this.MyObserverSubject.Attach(this);
  }

  public override void Update()
  {
    Console.WriteLine("Binary String: " + Convert.ToString(MyObserverSubject.State, 2));
  }
}