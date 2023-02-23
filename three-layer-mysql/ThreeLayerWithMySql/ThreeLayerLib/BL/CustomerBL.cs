using System;
using System.Collections.Generic;
using ThreeLayerLib.Persistence;
using ThreeLayerLib.DAL;

namespace ThreeLayerLib.BL
{
    public class CustomerBL
    {
        private CustomerDAL cdal = new CustomerDAL();
        public Customer GetById(int customerId)
        {
            return cdal.GetById(customerId);
        }

        public int AddCustomer(Customer customer)
        {
            return cdal.AddCustomer(customer) ?? 0;
        }
    }
}