using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyHour
{
    public class Order
    {
        private string _name;

        public string Name
        {
            get{return this._name;}
        }

        public Order(string customerName)
        {
            this._name = customerName;
        }

    }
}
