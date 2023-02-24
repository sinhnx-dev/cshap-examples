using ThreeLayerLib.Persistence;
using ThreeLayerLib.DAL;

namespace ThreeLayerLib.BL
{
    public class OrderBL
    {
        private OrderDAL odl = new OrderDAL();
        public bool CreateOrder(Order order)
        {
            bool result = odl.CreateOrder(order);
            return result;
        }
    }
}