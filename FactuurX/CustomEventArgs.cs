using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactuurX
{
    public class CustomEventArgs
    {
        public string text;
        public List<string> texts = new List<string>();
        public Item item;
        public string amount;
        public Customer customer;
    }
}
