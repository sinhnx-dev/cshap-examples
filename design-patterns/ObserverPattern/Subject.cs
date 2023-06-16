public class Subject
{
  private List<MyObserver> observers = new List<MyObserver>();
  private int state;

  public int State
  {
    get { return state; }
    set
    {
      state = value;
      NotifyAllObservers();
    }
  }

  public void Attach(MyObserver observer)
  {
    observers.Add(observer);
  }

  public void NotifyAllObservers()
  {
    foreach (var observer in observers)
    {
      observer.Update();
    }
  }
}