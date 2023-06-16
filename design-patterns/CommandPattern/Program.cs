Stock abcStock = new Stock();
abcStock.Name = "ABC";
abcStock.Quantity = 10;

BuyStock buyStockOrder = new BuyStock(abcStock);
SellStock sellStockOrder = new SellStock(abcStock);

Broker broker = new Broker();
broker.TakeOrder(buyStockOrder);
broker.TakeOrder(sellStockOrder);
broker.PlaceOrders();