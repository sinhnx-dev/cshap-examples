public abstract class MyObserver
{
  protected Subject MyObserverSubject { set; get; }
  public abstract void Update();
}