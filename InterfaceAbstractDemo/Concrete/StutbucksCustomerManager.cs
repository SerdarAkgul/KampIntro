using InterfaceAbstractDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Concrete
{
    public class StutbucksCustomerManager :BaseCustomerManager
    {
        public override void Save(Customer customer)
        {
            
            base.Save(customer);
        }

       
    }
}
