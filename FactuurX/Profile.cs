using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactuurX
{
    public class Profile
    {
        public string name;

        public List<Customer> customers = new List<Customer>();
        public List<Item> Items = new List<Item>();

    }
}
