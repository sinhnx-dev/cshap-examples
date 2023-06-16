public class SellStock : Order
{
  private Stock sStock;

  public SellStock(Stock stock)
  {
    sStock = stock;
  }

  public void Execute()
  {
    sStock.Sell();
  }
}