using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactuurX
{
    public class Item
    {
        public string name;
        public string referenceNumber;
        public string price;
        public string unit;

        public override string ToString()
        {
            return name;
        }
    }
}
