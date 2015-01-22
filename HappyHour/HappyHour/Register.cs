using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyHour
{
    public class Register
    {
        Order _order;

        public Register(Order order)
        {
            _order = order;
        }

        public List<string> PrintReceipt()
        {
            var result = new List<string>();
            result.Add("Customer: "+_order.Name);
            return result;
        }
    }
}
