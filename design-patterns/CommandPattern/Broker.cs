public class Broker
{
  private List<Order> orderList = new List<Order>();

  public void TakeOrder(Order order)
  {
    orderList.Add(order);
  }

  public void PlaceOrders()
  {
    foreach (var order in orderList)
    {
      order.Execute();
    }
    orderList.Clear();
  }
}