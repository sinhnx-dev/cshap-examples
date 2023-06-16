public class BuyStock : Order
{
  private Stock bStock;

  public BuyStock(Stock stock)
  {
    bStock = stock;
  }

  public void Execute()
  {
    bStock.Buy();
  }
}