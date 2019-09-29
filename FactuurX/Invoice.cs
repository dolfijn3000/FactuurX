using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactuurX
{
    public class Invoice
    {
        public Customer customer = new Customer();
        public List<Item> items = new List<Item>();
    }
}
